Imports System.Data.OleDb

Public Class ChangePassword

    Private Function RequiredEntry() As Boolean
        If txtOldPass.Text = "" Or TxtNewPass.Text = "" Or txtConformPass.Text = "" Then
            MsgBox("Please enter all information....", MsgBoxStyle.Critical, "Attention...")
            Me.txtOldPass.Focus()
            Return True
            Exit Function
        End If
    End Function
    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click
        txtOldPass.Clear()
        TxtNewPass.Clear()
        txtConformPass.Clear()
        txtOldPass.Focus()
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If RequiredEntry() = True Then
            Return
        End If
        Try
            If MsgBox("Do you really want to update this record?", "Response", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then

                Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\testing.Accdb;Persist Security Info=False;")

                Dim dr1 As OleDbDataReader
                Dim com As New OleDbCommand

                If FrmLogin.CBformState.Text = "User" Then
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                    cn.Open()

                    com.CommandText = "select [UserID],[Pass] from UserInfo where userid = '" & FrmLogin.txtUserName.Text & "'"
                    com.Connection = cn
                    dr1 = com.ExecuteReader

                    If dr1.Read Then
                        If UCase(dr1("Pass")) = UCase(txtOldPass.Text) Then

                            If TxtNewPass.Text = txtConformPass.Text Then

                                Dim cmd1 As New OleDb.OleDbCommand("Update Userinfo Set Pass=@UPass Where UserId='" & FrmLogin.txtUserName.Text & "' ", cn)

                                'Password
                                Dim Pass As OleDbParameter = New OleDbParameter("@UPass", OleDbType.VarWChar, 8)
                                Pass.Value = TxtNewPass.Text.ToString()
                                cmd1.Parameters.Add(Pass)


                                If cmd1.ExecuteNonQuery() Then
                                    cn.Close()
                                    MsgBox("Your password update successfully...", MsgBoxStyle.Information, "Password Updated")
                                    cmdClear.PerformClick()
                                Else
                                    MsgBox("Password updation failed ", MsgBoxStyle.Critical, "Updation Failed")
                                End If

                            Else
                                MessageBox.Show("Password & confom password does not match", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If

                        Else
                            MsgBox("Old password is Wrong!!!", MsgBoxStyle.Critical, "Password Wrong")
                        End If
                    End If

                    Return
                End If

                If FrmLogin.CBformState.Text = "Admin" Then
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                    cn.Open()

                    com.CommandText = "select [UserID],[Pass] from AdminInfo where userid = '" & FrmLogin.TxtAdminUserName.Text & "'"
                    com.Connection = cn
                    dr1 = com.ExecuteReader

                    If dr1.Read Then
                        If UCase(dr1("Pass")) = UCase(txtOldPass.Text) Then

                            If TxtNewPass.Text = txtConformPass.Text Then

                                Dim cmd1 As New OleDb.OleDbCommand("Update Admininfo Set Pass=@UPass Where UserId='" & FrmLogin.txtUserName.Text & "' ", cn)

                                'Password
                                Dim Pass As OleDbParameter = New OleDbParameter("@UPass", OleDbType.VarWChar, 8)
                                Pass.Value = TxtNewPass.Text.ToString()
                                cmd1.Parameters.Add(Pass)


                                If cmd1.ExecuteNonQuery() Then
                                    cn.Close()
                                    MsgBox("Your password update successfully...", MsgBoxStyle.Information, "Password Updated")
                                    cmdClear.PerformClick()
                                Else
                                    MsgBox("Password updation failed ", MsgBoxStyle.Critical, "Updation Failed")
                                End If

                            Else
                                MessageBox.Show("Password & confom password does not match", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                            End If

                        Else
                            MsgBox("Old password is Wrong!!!", MsgBoxStyle.Critical, "Password Wrong")
                        End If
                    End If
                    Return

                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
            Exit Sub
        End Try

    End Sub

    Private Sub ChangePassword_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        UserInfo.Show()
    End Sub

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClose.Click
        Me.Close()
    End Sub

    Private Sub TxtNewPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtNewPass.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtOldPass_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtOldPass.KeyPress
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
End Class