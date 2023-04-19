'Imports MySql.Data.MySqlClient

Public Class Welcome_Form
    'Dim conn As New MySqlConnection

    Private Sub Exit_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub CreateNew_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CreateNewYear.Click
        RegistrationDialog.ShowDialog()
    End Sub

    Private Sub NextButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NextButton.Click
        If Len(Trim(UserID_TB.Text)) = 0 Then
            MessageBox.Show("Please enter  your UserName.", "Booboo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            UserID_TB.Focus()
            Exit Sub
        End If

        If Len(Trim(Password_TB.Text)) = 0 Then
            MessageBox.Show("Please enter the Password.", "Booboo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            Password_TB.Focus()
            Exit Sub
        End If

        Try
            Dim cn As New OleDb.OleDbConnection(MDLModule.GetConnectionString())
            If cn.State = ConnectionState.Open Then
                cn.Close()
            End If
            cn.Open()

            Dim dr1 As OleDb.OleDbDataReader
            Dim com As New OleDb.OleDbCommand
            '                            Field Names     Table Name     Condition     
            '                            \/      \/           \/     \/ \/ \/ \/ \/ 
            com.CommandText = "select [UserID],[Pass] from UserInfo where UserID = @UName"

            ' UserName
            Dim UName As OleDb.OleDbParameter = New OleDb.OleDbParameter("@UName", OleDb.OleDbType.VarWChar, 30)
            UName.Value = UCase(UserID_TB.Text.ToString())
            com.Parameters.Add(UName)

            com.Connection = cn
            dr1 = com.ExecuteReader

            If dr1.Read Then

                If UCase(dr1("Pass")) = UCase(Password_TB.Text) Then

                    cn.Close()
                    MainForm.Show()
                    Me.Close()

                Else
                    MessageBox.Show("Invalid Username or Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    cn.Close()
                    ForgetPassword_LL.Visible = True
                    ForgetPassword_LL.Text = "Forget Password"
                    Password_TB.Focus()
                    Return
                End If

            Else
                MessageBox.Show("Invalid Username or Password.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                cn.Close()
                UserID_TB.Focus()
                Return
            End If

        Catch ex As Exception
            Console.WriteLine(ex.ToString
                              )

            'MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub CancelButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CancelButton.Click
        Me.Close()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        UserID_TB.Text = "Vinayak"
        Password_TB.Text = "Vinky@12"
    End Sub
End Class