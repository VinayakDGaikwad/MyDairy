Imports System.Data.OleDb

Public Class FrmMain


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        TimeStatusLabel.Text = Now.ToLongTimeString.ToString()
    End Sub

    Private Sub FrmMain_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If FrmLogin.CBformState.Text = "" Then
            Me.Dispose()
            FrmLogin.Show()
            FrmLogin.TxtAdminUserName.Text = ""
            FrmLogin.TxtAdminPassword.Text = ""
            FrmLogin.txtUserName.Text = ""
            FrmLogin.txtPassword.Text = ""
            Return
        End If

        Try
            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\testing.Accdb;Persist Security Info=False;")
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()

            Dim dr1 As OleDbDataReader
            Dim com As New OleDbCommand

            If FrmLogin.CBformState.Text = "User" Then
                com.CommandText = "select [UserID],[UserName] from userinfo where UserID = '" & FrmLogin.txtUserName.Text & "'"
                com.Connection = cn

                dr1 = com.ExecuteReader
                If dr1.Read Then
                    Dim intResponse As Integer
                    intResponse = MessageBox.Show("Do you really want to logout?", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If intResponse = MsgBoxResult.No Then
                        e.Cancel = True
                        ' Exit Sub
                    Else
                        MsgBox("Thank you!!  '" & UCase(dr1("UserName")).ToString() & "'" & vbNewLine & "" & vbNewLine & " God Bless U...", MsgBoxStyle.Information, "God Bless...")
                        cn.Close()
                        Me.Dispose()
                        FrmLogin.Show()
                        FrmLogin.TxtAdminUserName.Text = ""
                        FrmLogin.TxtAdminPassword.Text = ""
                        FrmLogin.txtUserName.Text = ""
                        FrmLogin.txtPassword.Text = ""

                    End If

                End If
            Else
                If FrmLogin.CBformState.Text = "Admin" Then
                    Dim intResponse As Integer
                    intResponse = MessageBox.Show("Do you really want to logout? ", "Response", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                    If intResponse = MsgBoxResult.No Then
                        e.Cancel = True
                        ' Exit Sub
                    Else
                        MsgBox("Thank you, God Bless...", MsgBoxStyle.Information, "God Bless U...")
                        cn.Close()
                        Me.Dispose()
                        FrmLogin.Show()
                        FrmLogin.TxtAdminUserName.Text = ""
                        FrmLogin.TxtAdminPassword.Text = ""
                        FrmLogin.txtUserName.Text = ""
                        FrmLogin.txtPassword.Text = ""

                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
        End Try

    End Sub

    Private Sub FrmMain_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ToolStripStatusLabel1.Text = "UserName :"
        ToolStripStatusLabel3.Text = "Date :"
        DateStatusLabel.Text = Format(Now, "dd/MM/yyy")
        ToolStripStatusLabel5.Text = "Time :"
        Try
            If FrmLogin.CBformState.Text = "User" Then
                Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\testing.Accdb;Persist Security Info=False;")
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
                cn.Open()

                Dim dr1 As OleDbDataReader
                Dim com As New OleDbCommand
                com.CommandText = "select [UserID],[UserName] from UserInfo where UserID = @UName"

                ' UserName
                Dim UName As OleDbParameter = New OleDbParameter("@UName", OleDbType.VarWChar, 30)
                UName.Value = UCase(FrmLogin.txtUserName.Text.ToString())
                com.Parameters.Add(UName)
                com.Connection = cn

                dr1 = com.ExecuteReader
                If dr1.Read Then
                    UserNameStatusLabel.Text = UCase(dr1("UserName").ToString())
                    ToolStripRegistartion.Visible = False
                    ToolStripSeparator4.Visible = False
                    cn.Close()
                    Return
                End If
            Else
                UserNameStatusLabel.Text = "ADMIN"
                ToolStripRegistartion.Visible = True
            End If

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
        End Try

    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Me.Close()
    End Sub

    Private Sub ToolStripRegistartion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripRegistartion.Click
        Me.Dispose()
        Registration.Show()
    End Sub

    Private Sub ToolStripUserInfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripUserInfo.Click
        Me.Dispose()
        UserInfo.Show()
    End Sub

    Private Sub ToolStripLogout_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLogout.Click
        Me.Close()
    End Sub
End Class