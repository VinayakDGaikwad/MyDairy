Imports System.Data.OleDb

Public Class FrmLogin
    Dim cmd As OleDbCommand = Nothing

    Private Sub CmdAdminLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdminLogin.Click

        If Len(Trim(TxtAdminUserName.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtAdminUserName.Focus()
            Exit Sub
        End If
        If Len(Trim(TxtAdminPassword.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            TxtAdminPassword.Focus()
            Exit Sub
        End If

        Try
            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\testing.Accdb;Persist Security Info=False;")
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()
            Dim dr1 As OleDbDataReader
            Dim com As New OleDbCommand
            com.CommandText = "select [UserID],[Pass] from AdminInfo where UserID = @UName"

            ' UserName
            Dim UName As OleDbParameter = New OleDbParameter("@UName", OleDbType.VarWChar, 20)
            UName.Value = UCase(TxtAdminUserName.Text.ToString())
            com.Parameters.Add(UName)
            com.Connection = cn

            dr1 = com.ExecuteReader
            If dr1.Read Then
                If UCase(dr1("Pass")) = UCase(TxtAdminPassword.Text) Then
                    cn.Close()
                    CBformState.SelectedItem = "Admin"

                    Dim obj As New FrmMain
                    Me.Hide()
                    obj.Show()

                Else
                    MessageBox.Show("Password is wrong", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cn.Close()
                    LinkLabel2.Visible = True
                    LinkLabel2.Text = "Forget Password"
                    txtPassword.Focus()
                    Return
                End If
            Else
                MessageBox.Show("UserName is wrong", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cn.Close()
                txtUserName.Focus()
                Return
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmdLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdLogin.Click
        If Len(Trim(txtUserName.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtUserName.Focus()
            Exit Sub
        End If
        If Len(Trim(txtPassword.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            txtPassword.Focus()
            Exit Sub
        End If

        Try
            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\testing.Accdb;Persist Security Info=False;")
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()

            Dim dr1 As OleDbDataReader
            Dim com As New OleDbCommand
            com.CommandText = "select [UserID],[Pass] from UserInfo where UserID = @UName"

            ' UserName
            Dim UName As OleDbParameter = New OleDbParameter("@UName", OleDbType.VarWChar, 30)
            UName.Value = UCase(txtUserName.Text.ToString())
            com.Parameters.Add(UName)

            com.Connection = cn
            dr1 = com.ExecuteReader

            If dr1.Read Then

                If UCase(dr1("Pass")) = UCase(txtPassword.Text) Then

                    cn.Close()
                    CBformState.SelectedItem = "User"
                    Dim obj As New FrmMain
                    Me.Hide()
                    obj.Show()

                Else
                    MessageBox.Show("Password is wrong", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    cn.Close()
                    LinkLabel1.Visible = True
                    LinkLabel1.Text = "Forget Password"
                    txtPassword.Focus()
                    Return
                End If

            Else
                MessageBox.Show("UserName is wrong", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cn.Close()
                txtUserName.Focus()
                Return
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdCancel.Click
        End
    End Sub

    Private Sub CmdAdmincancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CmdAdmincancel.Click
        End
    End Sub

    Private Sub TxtAdminUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAdminUserName.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub TxtAdminPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TxtAdminPassword.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtUserName_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtUserName.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub txtPassword_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtPassword.KeyPress
        Dim NotAllowed As String = "~`@%^&+={[}]()!:,;'><?/|\-.#+"

        'Allowed letters numbers and ( _ $ *)

        If e.KeyChar <> ControlChars.Back = True Then
            If NotAllowed.IndexOf(e.KeyChar) = -1 = False Then
                e.Handled = True
            End If
        End If
    End Sub

    Private Sub FrmLogin_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        End
    End Sub

    Private Sub LinkLabel1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel1.Click
        Me.Hide()
        TxtAdminUserName.Text = ""
        TxtAdminPassword.Text = ""
        txtUserName.Text = ""
        txtPassword.Text = ""
        LinkLabel1.Visible = False
        LinkLabel2.Visible = False
        Me.CBformState.Text = "User"
        FrmForgetPass.Show()
    End Sub

    Private Sub LinkLabel2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles LinkLabel2.Click
        Me.Hide()
        TxtAdminUserName.Text = ""
        TxtAdminPassword.Text = ""
        txtUserName.Text = ""
        txtPassword.Text = ""
        LinkLabel1.Visible = False
        LinkLabel2.Visible = False
        Me.CBformState.Text = "Admin"
        FrmForgetPass.Show()
    End Sub

    Private Sub TabControl1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles TabControl1.Click
        TxtAdminUserName.Text = ""
        TxtAdminPassword.Text = ""
        txtUserName.Text = ""
        txtPassword.Text = ""
        LinkLabel1.Visible = False
        LinkLabel2.Visible = False
    End Sub
End Class
