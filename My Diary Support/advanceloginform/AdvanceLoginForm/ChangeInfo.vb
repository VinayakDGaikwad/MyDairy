Imports System.Data.OleDb
Imports System.IO

Public Class ChangeInfo

    Private Sub cmdCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCancel.Click
        Me.Close()
    End Sub

    Private Sub ChangeInfo_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Dispose()
        UserInfo.Show()
    End Sub

    Private Function RequiredEntry() As Boolean
        If txtUserName.Text = "" Or txtPOB.Text = "" Or txtEmailID.Text = "" Then
            MsgBox("Please enter all information....", MsgBoxStyle.Critical, "Attention")
            Return True
            Exit Function
        End If
    End Function

    Private Sub ChangeInfo_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            Dim cn As New OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\testing.Accdb;Persist Security Info=False;")
           
            Dim dr1 As OleDbDataReader
            Dim com As New OleDbCommand

            If FrmLogin.CBformState.Text = "User" Then
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
                cn.Open()
                com.CommandText = "select [UserID],[UserName],[DateOfBirth],[PlaceOfBirth],[EmailID],[UserPic] from userinfo where userid = '" & FrmLogin.txtUserName.Text & "'"
                com.Connection = cn
                dr1 = com.ExecuteReader
                If dr1.Read Then
                    txtUserName.Text = UCase(dr1(1)).ToString()
                    dtpDOB.Value = UCase(dr1(2)).ToString()
                    txtPOB.Text = UCase(dr1(3)).ToString()
                    txtEmailID.Text = LCase(dr1(4)).ToString()
                    Dim x As Byte() = dr1("UserPic")
                    Dim ms As MemoryStream = New MemoryStream(x)
                    EmpPic.Image = Image.FromStream(ms)
                End If
                cn.Close()
                Return
            End If

            If FrmLogin.CBformState.Text = "Admin" Then
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
                cn.Open()
                com.CommandText = "select [UserID],[UserName],[DateOfBirth],[PlaceOfBirth],[EmailID],[Pic] from AdminInfo where userid = '" & FrmLogin.TxtAdminUserName.Text & "'"
                com.Connection = cn
                dr1 = com.ExecuteReader
                If dr1.Read Then
                    txtUserName.Text = UCase(dr1(1)).ToString()
                    dtpDOB.Text = UCase(dr1(2)).ToString()
                    txtPOB.Text = UCase(dr1(3)).ToString()
                    txtEmailID.Text = LCase(dr1(4)).ToString()
                    Dim x As Byte() = dr1("Pic")
                    Dim ms As MemoryStream = New MemoryStream(x)
                    EmpPic.Image = Image.FromStream(ms)
                End If
                cn.Close()
                Return
            End If

        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub cmdClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdClear.Click

        txtUserName.Clear()
        dtpDOB.Value = Today
        txtPOB.Clear()
        txtEmailID.Clear()

        Try
            Dim cn As New OleDbConnection("Provider=Microsoft.Ace.Oledb.12.0; Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\testing.Accdb;Persist Security Info=False;")
            
            Dim dr1 As OleDbDataReader
            Dim com As New OleDbCommand


            If FrmLogin.CBformState.Text = "User" Then
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
                cn.Open()
                com.CommandText = "select [UserPic] from userInfo where userid = '" & FrmLogin.txtUserName.Text & "'"
                com.Connection = cn
                dr1 = com.ExecuteReader
                If dr1.Read Then
                    Dim x As Byte() = dr1("UserPic")
                    Dim ms As MemoryStream = New MemoryStream(x)
                    EmpPic.Image = Image.FromStream(ms)
                End If
                cn.Close()
                Return
            End If


            If FrmLogin.CBformState.Text = "Admin" Then
                If cn.State = ConnectionState.Open Then
                    cn.Close()
                End If
                cn.Open()
                com.CommandText = "select [Pic] from AdminInfo where userid = '" & FrmLogin.txtUserName.Text & "'"
                com.Connection = cn
                dr1 = com.ExecuteReader
                If dr1.Read Then
                    Dim x As Byte() = dr1("Pic")
                    Dim ms As MemoryStream = New MemoryStream(x)
                    EmpPic.Image = Image.FromStream(ms)
                End If
                cn.Close()
                Return
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try
    End Sub

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
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub BRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BRemove.Click
        Me.EmpPic.Image = System.Drawing.Image.FromFile(My.Application.Info.DirectoryPath & "\Image\personal.PNG")
    End Sub

    Private Sub cmdEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdEdit.Click
        If RequiredEntry() = True Then
            Return
        End If
        Try
            If MsgBox("Do you really want to update this record?", "Response", MsgBoxStyle.YesNo Or MsgBoxStyle.Question) = MsgBoxResult.Yes Then

                Dim cn As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" & My.Application.Info.DirectoryPath.ToString() & "\BackUp\testing.Accdb;Persist Security Info=False;")

                If FrmLogin.CBformState.Text = "User" Then
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                    cn.Open()

                    Dim cmd1 As New OleDb.OleDbCommand("Update Userinfo Set UserName=@UName,DateOfBirth=@DOB,PlaceOfBirth=@POB,EmailID=@EmailID,UserPic=@Pic Where (UserId='" & FrmLogin.txtUserName.Text & "') ", cn)

                    ' UserName
                    Dim UserName As OleDbParameter = New OleDbParameter("@UName", OleDbType.VarWChar, 15)
                    UserName.Value = txtUserName.Text.ToString()
                    cmd1.Parameters.Add(UserName)

                    'DateOfBirth
                    Dim DOB As OleDbParameter = New OleDbParameter("@DOB", OleDbType.VarWChar, 15)
                    DOB.Value = dtpDOB.Text.ToString()
                    cmd1.Parameters.Add(DOB)

                    'PlaceOfBirth
                    Dim POB As OleDbParameter = New OleDbParameter("@POB", OleDbType.VarWChar, 20)
                    POB.Value = txtPOB.Text.ToString()
                    cmd1.Parameters.Add(POB)

                    'EmailID
                    Dim EmailID As OleDbParameter = New OleDbParameter("@EmailID", OleDbType.VarWChar, 25)
                    EmailID.Value = txtEmailID.Text.ToString()
                    cmd1.Parameters.Add(EmailID)

                    Dim MemStream As New MemoryStream
                    Dim DataPic_Update As Byte()

                    Me.EmpPic.Image.Save(MemStream, Imaging.ImageFormat.Png)
                    DataPic_Update = MemStream.GetBuffer()
                    MemStream.Read(DataPic_Update, 0, MemStream.Length)

                    ' image content
                    Dim photo As OleDbParameter = New OleDbParameter("@Pic", SqlDbType.Image)
                    photo.Value = DataPic_Update
                    cmd1.Parameters.Add(photo)


                    If cmd1.ExecuteNonQuery() Then
                        cn.Close()
                        MsgBox("Your info updated successfully... ", MsgBoxStyle.Information, "Record Updated")

                    Else
                        MsgBox("Your info modification failed ", MsgBoxStyle.Critical, "Modificatio Failed")
                        Return
                    End If
                End If



                If FrmLogin.CBformState.Text = "Admin" Then
                    If cn.State = ConnectionState.Open Then
                        cn.Close()
                    End If
                    cn.Open()

                    Dim cmd2 As New OleDb.OleDbCommand("Update AdminInfo Set UserName=@UserName,DateOfBirth=@DOB,PlaceOfBirth=@POB,EmailID=@EmailID,Pic=@Pic Where (UserId='" & FrmLogin.TxtAdminUserName.Text & "') ", cn)


                    'AdminName
                    Dim AdminName As OleDbParameter = New OleDbParameter("@AdminName", OleDbType.VarWChar, 50)
                    AdminName.Value = txtUserName.Text.ToString()
                    cmd2.Parameters.Add(AdminName)

                    'DOB
                    Dim DOB As OleDbParameter = New OleDbParameter("@DOB", OleDbType.VarWChar, 50)
                    DOB.Value = dtpDOB.Text.ToString()
                    cmd2.Parameters.Add(DOB)

                    ' POB
                    Dim POB As OleDbParameter = New OleDbParameter("@POB", OleDbType.VarWChar, 50)
                    POB.Value = txtPOB.Text.ToString()
                    cmd2.Parameters.Add(POB)

                    'EmailID
                    Dim EmailID As OleDbParameter = New OleDbParameter("@EmailID", OleDbType.VarWChar, 50)
                    EmailID.Value = txtEmailID.Text.ToString()
                    cmd2.Parameters.Add(EmailID)


                    Dim MemStream As New MemoryStream
                    Dim DataPic_Update As Byte()

                    Me.EmpPic.Image.Save(MemStream, Imaging.ImageFormat.Png)
                    DataPic_Update = MemStream.GetBuffer()
                    MemStream.Read(DataPic_Update, 0, MemStream.Length)


                    ' image content
                    Dim photo As OleDbParameter = New OleDbParameter("@Pic", SqlDbType.Image)
                    photo.Value = DataPic_Update
                    cmd2.Parameters.Add(photo)


                    If cmd2.ExecuteNonQuery() Then
                        cn.Close()
                        MsgBox("Your info updated successfully... ", MsgBoxStyle.Information, "Record Updated")

                    Else
                        MsgBox("Your info modification failed ", MsgBoxStyle.Critical, "Modificatio Failed")
                        Return
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox(ex.Message(), MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try

    End Sub
End Class