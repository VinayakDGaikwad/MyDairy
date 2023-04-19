Imports System.Windows.Forms
Imports System.Data.OleDb
Imports System.IO

Public Class RegistrationDialog

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK_Button.Click
        If RequiredEntry() = False Then
            Return
        End If

        Try

            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\MDL_Data\UserData_DB.accdb;Persist Security Info=False;")
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()

            If Password_TextBox.Text = Conform_TextBox.Text Then

                Dim sSQL As String = "insert into UserInfo(UserID,Pass,UserName,DateOfBirth,FolderPath,EmailID,UserPic) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7)"
                Dim cmd As OleDbCommand = New OleDbCommand(sSQL, cn)


                ' UserID
                Dim UserID As OleDbParameter = New OleDbParameter("@d1", OleDbType.VarWChar, 8)
                UserID.Value = UserID_TextBox.Text.ToString()
                cmd.Parameters.Add(UserID)

                ' Password
                Dim Password As OleDbParameter = New OleDbParameter("@d2", OleDbType.VarWChar, 8)
                Password.Value = Password_TextBox.Text.ToString()
                cmd.Parameters.Add(Password)

                ' UserName
                Dim UserName As OleDbParameter = New OleDbParameter("@d3", OleDbType.VarWChar, 15)
                UserName.Value = UserID_TextBox.Text.ToString()
                cmd.Parameters.Add(UserName)

                'DateOfBirth
                Dim DOB As OleDbParameter = New OleDbParameter("@d4", OleDbType.Date, 15)
                DOB.Value = DOB_DateTimePicker.Text.ToString()
                cmd.Parameters.Add(DOB)

                ' Dairy Folder
                Dim POB As OleDbParameter = New OleDbParameter("@d5", OleDbType.VarWChar, 25)
                POB.Value = DairyFolder_TextBox.Text.ToString()
                cmd.Parameters.Add(POB)


                'EmailID
                Dim EmailID As OleDbParameter = New OleDbParameter("@d6", OleDbType.VarWChar, 25)
                EmailID.Value = Email_TextBox.Text.ToString()
                cmd.Parameters.Add(EmailID)



                Dim MemStream As New MemoryStream
                Dim DataPic_Update As Byte()

                Me.MyPicPB.Image.Save(MemStream, Imaging.ImageFormat.Png)
                DataPic_Update = MemStream.GetBuffer()
                MemStream.Read(DataPic_Update, 0, MemStream.Length)


                ' image content
                Dim photo As OleDbParameter = New OleDbParameter("@d7", SqlDbType.Image)
                photo.Value = DataPic_Update
                cmd.Parameters.Add(photo)


                If cmd.ExecuteNonQuery() Then
                    cn.Close()
                    MsgBox("New user registerd successfully... ", MsgBoxStyle.Information, "Record Saved")

                Else
                    MsgBox("New user registration failed... ", MsgBoxStyle.Critical, "Registration failed")
                    Return
                End If
            Else
                MessageBox.Show("Password & confom password does not match", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If

        Catch aas As FileNotFoundException
            MessageBox.Show("Some files were not found they are been rcovered. Please try again.", "File Not Found.")
        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
            Exit Sub
        End Try

    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub New_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim year As String = Year_TextBox.Text.Replace(" ", "")
        'If year.Length >= 4 And ValidatePassword(Password_TextBox.Text) = True Then
        '    '  NewYearForm.ShowDialog()
        'Else
        '    MsgBox("Please enter a valid Year and Password", MsgBoxStyle.Exclamation, "Import Diary")
        'End If
    End Sub

    Private Sub ImportExisting_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        'Dim year As String = Year_TextBox.Text.Replace(" ", "")
        'If year.Length >= 4 And ValidatePassword(Password_TextBox.Text) = True Then
        '    ImportDiaryDialog.ShowDialog()
        'Else
        '    MsgBox("Please enter a valid Year and Password.", MsgBoxStyle.Exclamation, "Import Diary")
        'End If
    End Sub

    Private Function RequiredEntry() As Boolean
        If UserID_TextBox.Text = "" Or Password_TextBox.Text = "" Or Email_TextBox.Text = "" _
            Or Password_TextBox.Text = "" Or Conform_TextBox.Text = "" Or DairyFolder_TextBox.Text = "" Then

            MsgBox("Please enter all information....", MsgBoxStyle.Critical, "Attention")
            Return False
            Exit Function
        ElseIf ValidatePassword(Password_TextBox.Text) = False Then
            MessageBox.Show("Please check if you password has at lest" + vbNewLine + "   -1 Numeric Character" + vbNewLine + "     -1 Special Character" + vbNewLine + "    -1 Uppercase Character.", "Password Requirements", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly, False)
            Return False
            Exit Function
        End If

        If Password_TextBox.Text <> Conform_TextBox.Text Then
            MsgBox("The Password and Conform Password do not match.", MsgBoxStyle.Critical, "Attention")
            Password_TextBox.Text = ""
            Conform_TextBox.Text = ""
            Return False
            Exit Function
        End If
        Return True
    End Function

    Private Sub Browse_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Browse_Button.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Photo:"
                '.Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp| All Files (*.*)|*.*"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    MyPicPB.Image = System.Drawing.Image.FromFile(.FileName)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
        End Try
    End Sub

    Private Sub RemovePicButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemovePicButton.Click
        MyPicPB.Image = My.Resources.DefaltPicIcon
    End Sub

    Function ValidatePassword(ByVal pwd As String, Optional ByVal minLength As Integer = 8, Optional ByVal numUpper As Integer = 1, Optional ByVal numNumbers As Integer = 1, Optional ByVal numSpecial As Integer = 1) As Boolean

        ' Replace [A-Z] with \p{Lu}, to allow for Unicode uppercase letters. 
        Dim upper As New System.Text.RegularExpressions.Regex("[A-Z]")
        Dim lower As New System.Text.RegularExpressions.Regex("[a-z]")
        Dim number As New System.Text.RegularExpressions.Regex("[0-9]")
        ' Special is "none of the above". 
        Dim special As New System.Text.RegularExpressions.Regex("[^a-zA-Z0-9]")

        ' Check the length. 
        If Len(pwd) < minLength Then Return False
        ' Check for minimum number of occurrences. 
        If upper.Matches(pwd).Count < numUpper Then Return False
        If number.Matches(pwd).Count < numNumbers Then Return False
        If special.Matches(pwd).Count < numSpecial Then Return False

        ' Passed all checks. 
        Return True
    End Function

    Private Sub Password_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Password_TextBox.TextChanged
        If ValidatePassword(Password_TextBox.Text) = True Then
            Password_TextBox.BackColor = Color.LightSkyBlue
        ElseIf ValidatePassword(Password_TextBox.Text) = False Then
            Password_TextBox.BackColor = Color.LightPink
        End If

        If Password_TextBox.Text = "" Then
            Password_TextBox.BackColor = Color.White
        End If
    End Sub

    Private Sub Conform_TextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Conform_TextBox.TextChanged
        If Password_TextBox.Text = Conform_TextBox.Text Then
            Conform_TextBox.BackColor = Color.LightSkyBlue
        Else
            Conform_TextBox.BackColor = Color.LightPink
        End If
    End Sub

    Private Sub RegistrationDialog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
