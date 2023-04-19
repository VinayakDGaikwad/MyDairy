Imports System.Data.OleDb
Imports System.IO

Public Class UserInfo

    Private Sub UserInfo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        FrmMain.Show()
    End Sub

    Private Sub LinkLabel2_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel2.LinkClicked
        Me.Dispose()
        ChangeInfo.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Me.Dispose()
        ChangePassword.Show()
    End Sub

    Private Sub UserInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Try

            Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\testing.Accdb;Persist Security Info=False;")
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()

            Dim dr1 As OleDbDataReader
            Dim com1 As New OleDbCommand

            If FrmLogin.CBformState.Text = "User" Then
                com1.CommandText = "select [UserID],[UserName],[DateOfBirth],[PlaceOfBirth],[EmailID],[UserPic] from userinfo where userid = '" & FrmLogin.txtUserName.Text & "'"
                com1.Connection = cn
                dr1 = com1.ExecuteReader
                If dr1.Read Then
                    UserName.Text = "'" & UCase(dr1(1)).ToString() & "'"
                    DateOfBirth.Text = "'" & UCase(dr1(2)).ToString() & "'"
                    PlaceOfBirth.Text = "'" & UCase(dr1(3)).ToString() & "'"
                    EmailID.Text = "'" & LCase(dr1(4)).ToString() & "'"
                    Dim x As Byte() = dr1("UserPic")
                    Dim ms As MemoryStream = New MemoryStream(x)
                    PicStudent.Image = Image.FromStream(ms)
                End If
                cn.Close()
                dr1.Close()
                Return
            End If
            If FrmLogin.CBformState.Text = "Admin" Then

                com1.CommandText = "select [UserID],[UserName],[DateOfBirth],[PlaceOfBirth],[EmailID],[Pic] from AdminInfo where userid = '" & FrmLogin.TxtAdminUserName.Text & "'"
                com1.Connection = cn
                dr1 = com1.ExecuteReader
                If dr1.Read Then
                    UserName.Text = "'" & UCase(dr1(1)).ToString() & "'"
                    DateOfBirth.Text = "'" & UCase(dr1(2)).ToString() & "'"
                    PlaceOfBirth.Text = "'" & UCase(dr1(3)).ToString() & "'"
                    EmailID.Text = "'" & LCase(dr1(4)).ToString() & "'"
                    Dim x As Byte() = dr1("Pic")
                    Dim ms As MemoryStream = New MemoryStream(x)
                    PicStudent.Image = Image.FromStream(ms)
                End If
                cn.Close()
                dr1.Close()
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error...")
        End Try
    End Sub
End Class