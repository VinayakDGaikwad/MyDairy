Imports System.IO.Compression
Imports System.Data.OleDb
Imports System.IO

Public Class MainForm
    Public UserName As String = Welcome_Form.UserID_TB.Text
    Public DirayFolder As String
    Public ChangesMade As String
    Public NoOFMouseEnter As Integer = 0

    'Formating
    Dim IsBold As Boolean = False


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim cn As New OleDbConnection(MDLModule.GetConnectionString())

            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()

            Dim dr1 As OleDbDataReader
            Dim com1 As New OleDbCommand

            com1.CommandText = "select [UserID],[UserName],[DateOfBirth],[FolderPath],[EmailID],[UserPic] from userinfo where userid = '" & UserName & "'"
            com1.Connection = cn
            dr1 = com1.ExecuteReader()

            If dr1.Read Then
                UserName = "'" & UCase(dr1(1)).ToString() & "'"
                DirayFolder = "'" & UCase(dr1(3)).ToString() & "'"
                If dr1("UserPic").ToString <> "" Then


                    Dim x As Byte() = dr1("UserPic")
                    Dim ms As MemoryStream = New MemoryStream(x)
                    SmallPictureBox.Image = Image.FromStream(ms)
                    LargePictureBox.Image = SmallPictureBox.Image

                Else

                    SmallPictureBox.Image = My.Resources.DefaltPicIcon

                End If
            End If

            UserNameTB.Text = dr1("UserName")
            UserName2.Text = UserNameTB.Text
            UserID.Text = dr1("UserID")


            cn.Close()
            dr1.Close()

            Return
        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub MyPictureBox_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SmallPictureBox.Click
        If Panel1.Visible = False Then
            Panel1.Visible = True
            Exit Sub
        End If

        If Panel1.Visible = True Then
            Panel1.Visible = False
            Exit Sub
        End If
    End Sub

    Private Sub ClosePane_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClosePane.Click
        Panel1.Visible = False
    End Sub

    Private Sub RegistrationButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RegistrationButton.Click
        Panel1.Visible = False
        RegistrationDialog.ShowDialog()
    End Sub

    Private Sub LogoutButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutButton.Click
        Panel1.Visible = False
        Me.Close()
    End Sub

    Private Sub B_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles B_Button.Click
        If MainRichTextBox.SelectionFont IsNot Nothing Then
            Dim currentFont As System.Drawing.Font = MainRichTextBox.SelectionFont

            If MainRichTextBox.SelectionFont.Bold = True Then
                SetFont(False, MainRichTextBox.SelectionFont.Italic, MainRichTextBox.SelectionFont.Underline)
                Exit Sub
            Else
                SetFont(True, MainRichTextBox.SelectionFont.Italic, MainRichTextBox.SelectionFont.Underline)
                Exit Sub
            End If

            If MainRichTextBox.SelectionFont.Italic = True Then
                SetFont(MainRichTextBox.SelectionFont.Bold, False, MainRichTextBox.SelectionFont.Underline)
                Exit Sub
            Else
                SetFont(MainRichTextBox.SelectionFont.Bold, True, MainRichTextBox.SelectionFont.Underline)
                Exit Sub
            End If

            If MainRichTextBox.SelectionFont.Underline = True Then
                SetFont(MainRichTextBox.SelectionFont.Bold, MainRichTextBox.SelectionFont.Italic, False)
                Exit Sub
            Else
                SetFont(MainRichTextBox.SelectionFont.Bold, MainRichTextBox.SelectionFont.Italic, True)
                Exit Sub
            End If

        End If
    End Sub

    Private Sub I_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles I_Button.Click
        Dim fon As Font = MainRichTextBox.Font

        MainRichTextBox.SelectionFont = New Font(fon, FontStyle.Italic)
    End Sub

    Private Sub U_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles U_Button.Click
        Dim fon As Font = MainRichTextBox.Font

        MainRichTextBox.SelectionFont = New Font(fon, FontStyle.Underline)
    End Sub

    Public Sub SetFont(ByRef Bold As Boolean, ByRef Italic As Boolean, ByRef Underline As Boolean)
        Dim fon As Font = MainRichTextBox.Font

        MsgBox(Bold.ToString + Italic.ToString + Underline.ToString)

        'Only Bold
        If Bold = True And Italic = False And Underline = False Then
            MainRichTextBox.SelectionFont = New Font(fon, FontStyle.Bold)
            Exit Sub
        End If

        'Only Italic
        If Bold = False And Italic = True And Underline = False Then
            MainRichTextBox.SelectionFont = New Font(fon, FontStyle.Italic)
            Exit Sub
        End If

        'Only Underline
        If Bold = False And Italic = False And Underline = True Then
            MainRichTextBox.SelectionFont = New Font(fon, FontStyle.Underline)
            Exit Sub
        End If

        'Bold and Italic
        If Bold = True And Italic = True And Underline = False Then
            MainRichTextBox.SelectionFont = New Font(fon, FontStyle.Bold Or FontStyle.Italic)
            Exit Sub
        End If

        'Bold And Underline
        If Bold = True And Italic = False And Underline = True Then
            MainRichTextBox.SelectionFont = New Font(fon, FontStyle.Bold Or FontStyle.Underline)
            Exit Sub
        End If

        'Italic and Underline
        If Bold = False And Italic = True And Underline = True Then
            MainRichTextBox.SelectionFont = New Font(fon, FontStyle.Bold Or FontStyle.Underline)
            Exit Sub
        End If

        'All 
        If Bold = True And Italic = True And Underline = True Then
            MainRichTextBox.SelectionFont = New Font(fon, FontStyle.Regular)
            Exit Sub
        End If

        'Noting
        If Bold = False And Italic = False And Underline = False Then
            MainRichTextBox.SelectionFont = New Font(fon, FontStyle.Regular)
            Exit Sub
        End If

    End Sub

    Private Sub Panel1_MouseLeave(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Panel1.MouseLeave
        MoreOptionsPanel_Timer.Start()
    End Sub

    Private Sub MoreOptionsPanel_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MoreOptionsPanel_Timer.Tick
        ' If MoreOptionsPanel_Timer.Then Then

        ' End If
    End Sub
End Class
