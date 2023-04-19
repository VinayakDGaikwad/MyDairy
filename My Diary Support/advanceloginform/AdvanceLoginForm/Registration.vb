Imports System.Data.OleDb
Imports System.IO

Public Class Registration

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Registration_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        FrmMain.Show()
    End Sub
    Sub clear()
        txtUserName.Clear()
        dtpDOB.Value = Today
        txtPOB.Clear()
        txtEmailID.Clear()
        txtUserID.Clear()
        txtpassword.Clear()
        txtConformPass.Clear()
    End Sub
    Private Function RequiredEntry() As Boolean
        If txtUserName.Text = "" Or txtPOB.Text = "" Or txtEmailID.Text = "" Or txtUserID.Text = "" Or txtpassword.Text = "" Or txtConformPass.Text = "" Then
            MsgBox("Please enter all information....", MsgBoxStyle.Critical, "Attention")
            Return True
            Exit Function
        End If
    End Function

    Private Sub BBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BBrowse.Click
        Dim OpenFile As New OpenFileDialog()
        Try
            With OpenFile
                .FileName = ""
                .Title = "Photo:"
                .Filter = "Image files: (*.jpg)|*.jpg|(*.jpeg)|*.jpeg|(*.png)|*.png|(*.Gif)|*.Gif|(*.bmp)|*.bmp| All Files (*.*)|*.*"
                If .ShowDialog = Windows.Forms.DialogResult.OK Then
                    Me.EmpPic.Image = System.Drawing.Image.FromFile(.FileName)
                End If
            End With
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
        End Try
    End Sub

    Private Sub BRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRemove.Click
        Me.EmpPic.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\Image\personal.PNG")
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Call clear()
    End Sub

    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        dtpDOB.Value = Today
    End Sub

    Private Sub button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles button1.Click
        If RequiredEntry() = True Then
            Return
        End If
        Try

            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\testing.Accdb;Persist Security Info=False;")
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()

            If txtpassword.Text = txtConformPass.Text Then

                Dim sSQL As String = "insert into UserInfo(UserID,Pass,UserName,DateOfBirth,PlaceOfBirth,EmailID,UserPic) values(@d1,@d2,@d3,@d4,@d5,@d6,@d7)"
                Dim cmd As OleDbCommand = New OleDbCommand(sSQL, cn)


                ' UserID
                Dim UserID As OleDbParameter = New OleDbParameter("@d1", OleDbType.VarWChar, 8)
                UserID.Value = txtUserID.Text.ToString()
                cmd.Parameters.Add(UserID)

                ' Password
                Dim Password As OleDbParameter = New OleDbParameter("@d2", OleDbType.VarWChar, 8)
                Password.Value = txtpassword.Text.ToString()
                cmd.Parameters.Add(Password)

                ' UserName
                Dim UserName As OleDbParameter = New OleDbParameter("@d3", OleDbType.VarWChar, 15)
                UserName.Value = txtUserName.Text.ToString()
                cmd.Parameters.Add(UserName)

                'DateOfBirth
                Dim DOB As OleDbParameter = New OleDbParameter("@d4", OleDbType.Date, 15)
                DOB.Value = dtpDOB.Text.ToString()
                cmd.Parameters.Add(DOB)

                ' PlaceOfBirth
                Dim POB As OleDbParameter = New OleDbParameter("@d5", OleDbType.VarWChar, 25)
                POB.Value = txtPOB.Text.ToString()
                cmd.Parameters.Add(POB)


                'EmailID
                Dim EmailID As OleDbParameter = New OleDbParameter("@d6", OleDbType.VarWChar, 25)
                EmailID.Value = txtEmailID.Text.ToString()
                cmd.Parameters.Add(EmailID)



                Dim MemStream As New MemoryStream
                Dim DataPic_Update As Byte()

                Me.EmpPic.Image.Save(MemStream, Imaging.ImageFormat.Png)
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

        Catch ex As Exception
            MessageBox.Show(ex.Message.ToString(), "Data Error")
            Exit Sub
        End Try
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtPOB_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPOB.KeyPress
        Dim NotAllowed As String = "1234567890~`@#$%^&*()_-+={[}]:;',!.><?/|\"

        'Allowed Letters only
        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub txtUserID_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserID.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"
        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtpassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtpassword.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"
        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtConformPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtConformPass.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"
        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Dispose()
        FrmRegistrationDetails.Show()
    End Sub
End Class