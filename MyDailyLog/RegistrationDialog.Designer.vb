<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RegistrationDialog
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.OK_Button = New System.Windows.Forms.Button()
        Me.Cancel_Button = New System.Windows.Forms.Button()
        Me.EmailID_Lable = New System.Windows.Forms.Label()
        Me.Conform_Lable = New System.Windows.Forms.Label()
        Me.Password_Lable = New System.Windows.Forms.Label()
        Me.UserID_Lable = New System.Windows.Forms.Label()
        Me.DOB_Label = New System.Windows.Forms.Label()
        Me.Name_label = New System.Windows.Forms.Label()
        Me.Personal_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Email_TextBox = New System.Windows.Forms.TextBox()
        Me.DOB_DateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Name_TextBox = New System.Windows.Forms.TextBox()
        Me.LoginGroupBox = New System.Windows.Forms.GroupBox()
        Me.Conform_TextBox = New System.Windows.Forms.TextBox()
        Me.Password_TextBox = New System.Windows.Forms.TextBox()
        Me.UserID_TextBox = New System.Windows.Forms.TextBox()
        Me.DairyFolder_TextBox = New System.Windows.Forms.TextBox()
        Me.FolderPath_Lable = New System.Windows.Forms.Label()
        Me.MyPicGB = New System.Windows.Forms.GroupBox()
        Me.RemovePicButton = New System.Windows.Forms.Button()
        Me.Browse_Button = New System.Windows.Forms.Button()
        Me.MyPicPB = New System.Windows.Forms.PictureBox()
        Me.DiaryFolder_GroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.Personal_GroupBox.SuspendLayout()
        Me.LoginGroupBox.SuspendLayout()
        Me.MyPicGB.SuspendLayout()
        CType(Me.MyPicPB, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DiaryFolder_GroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.OK_Button, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Cancel_Button, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(457, 349)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(144, 29)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'OK_Button
        '
        Me.OK_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.OK_Button.Location = New System.Drawing.Point(3, 3)
        Me.OK_Button.Name = "OK_Button"
        Me.OK_Button.Size = New System.Drawing.Size(66, 23)
        Me.OK_Button.TabIndex = 0
        Me.OK_Button.Text = "OK"
        '
        'Cancel_Button
        '
        Me.Cancel_Button.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.Cancel_Button.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Cancel_Button.Location = New System.Drawing.Point(75, 3)
        Me.Cancel_Button.Name = "Cancel_Button"
        Me.Cancel_Button.Size = New System.Drawing.Size(66, 23)
        Me.Cancel_Button.TabIndex = 1
        Me.Cancel_Button.Text = "Cancel"
        '
        'EmailID_Lable
        '
        Me.EmailID_Lable.AutoSize = True
        Me.EmailID_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.EmailID_Lable.Location = New System.Drawing.Point(62, 80)
        Me.EmailID_Lable.Name = "EmailID_Lable"
        Me.EmailID_Lable.Size = New System.Drawing.Size(49, 13)
        Me.EmailID_Lable.TabIndex = 120
        Me.EmailID_Lable.Text = "Email ID:"
        '
        'Conform_Lable
        '
        Me.Conform_Lable.AutoSize = True
        Me.Conform_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Conform_Lable.Location = New System.Drawing.Point(26, 85)
        Me.Conform_Lable.Name = "Conform_Lable"
        Me.Conform_Lable.Size = New System.Drawing.Size(121, 13)
        Me.Conform_Lable.TabIndex = 119
        Me.Conform_Lable.Text = "Conform your Password:"
        '
        'Password_Lable
        '
        Me.Password_Lable.AutoSize = True
        Me.Password_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Password_Lable.Location = New System.Drawing.Point(52, 59)
        Me.Password_Lable.Name = "Password_Lable"
        Me.Password_Lable.Size = New System.Drawing.Size(98, 13)
        Me.Password_Lable.TabIndex = 118
        Me.Password_Lable.Text = "Create a password:"
        '
        'UserID_Lable
        '
        Me.UserID_Lable.AutoSize = True
        Me.UserID_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.UserID_Lable.Location = New System.Drawing.Point(28, 33)
        Me.UserID_Lable.Name = "UserID_Lable"
        Me.UserID_Lable.Size = New System.Drawing.Size(122, 13)
        Me.UserID_Lable.TabIndex = 117
        Me.UserID_Lable.Text = "Choose your UserName:"
        '
        'DOB_Label
        '
        Me.DOB_Label.AutoSize = True
        Me.DOB_Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.DOB_Label.Location = New System.Drawing.Point(42, 54)
        Me.DOB_Label.Name = "DOB_Label"
        Me.DOB_Label.Size = New System.Drawing.Size(69, 13)
        Me.DOB_Label.TabIndex = 115
        Me.DOB_Label.Text = "Date of Birth:"
        '
        'Name_label
        '
        Me.Name_label.AutoSize = True
        Me.Name_label.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.Name_label.Location = New System.Drawing.Point(73, 28)
        Me.Name_label.Name = "Name_label"
        Me.Name_label.Size = New System.Drawing.Size(38, 13)
        Me.Name_label.TabIndex = 114
        Me.Name_label.Text = "Name:"
        '
        'Personal_GroupBox
        '
        Me.Personal_GroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Personal_GroupBox.Controls.Add(Me.Email_TextBox)
        Me.Personal_GroupBox.Controls.Add(Me.DOB_DateTimePicker)
        Me.Personal_GroupBox.Controls.Add(Me.Name_TextBox)
        Me.Personal_GroupBox.Controls.Add(Me.Name_label)
        Me.Personal_GroupBox.Controls.Add(Me.EmailID_Lable)
        Me.Personal_GroupBox.Controls.Add(Me.DOB_Label)
        Me.Personal_GroupBox.Location = New System.Drawing.Point(12, 20)
        Me.Personal_GroupBox.Name = "Personal_GroupBox"
        Me.Personal_GroupBox.Size = New System.Drawing.Size(384, 115)
        Me.Personal_GroupBox.TabIndex = 121
        Me.Personal_GroupBox.TabStop = False
        Me.Personal_GroupBox.Text = "Personal Details"
        '
        'Email_TextBox
        '
        Me.Email_TextBox.Location = New System.Drawing.Point(117, 77)
        Me.Email_TextBox.MaxLength = 255
        Me.Email_TextBox.Name = "Email_TextBox"
        Me.Email_TextBox.Size = New System.Drawing.Size(192, 20)
        Me.Email_TextBox.TabIndex = 120
        '
        'DOB_DateTimePicker
        '
        Me.DOB_DateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.DOB_DateTimePicker.Location = New System.Drawing.Point(117, 51)
        Me.DOB_DateTimePicker.Name = "DOB_DateTimePicker"
        Me.DOB_DateTimePicker.Size = New System.Drawing.Size(107, 20)
        Me.DOB_DateTimePicker.TabIndex = 121
        '
        'Name_TextBox
        '
        Me.Name_TextBox.Location = New System.Drawing.Point(117, 25)
        Me.Name_TextBox.MaxLength = 255
        Me.Name_TextBox.Name = "Name_TextBox"
        Me.Name_TextBox.Size = New System.Drawing.Size(231, 20)
        Me.Name_TextBox.TabIndex = 120
        '
        'LoginGroupBox
        '
        Me.LoginGroupBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LoginGroupBox.Controls.Add(Me.Conform_TextBox)
        Me.LoginGroupBox.Controls.Add(Me.Password_TextBox)
        Me.LoginGroupBox.Controls.Add(Me.UserID_TextBox)
        Me.LoginGroupBox.Controls.Add(Me.UserID_Lable)
        Me.LoginGroupBox.Controls.Add(Me.Password_Lable)
        Me.LoginGroupBox.Controls.Add(Me.Conform_Lable)
        Me.LoginGroupBox.Location = New System.Drawing.Point(12, 141)
        Me.LoginGroupBox.Name = "LoginGroupBox"
        Me.LoginGroupBox.Size = New System.Drawing.Size(384, 126)
        Me.LoginGroupBox.TabIndex = 122
        Me.LoginGroupBox.TabStop = False
        Me.LoginGroupBox.Text = "Login Details"
        '
        'Conform_TextBox
        '
        Me.Conform_TextBox.Location = New System.Drawing.Point(156, 82)
        Me.Conform_TextBox.MaxLength = 255
        Me.Conform_TextBox.Name = "Conform_TextBox"
        Me.Conform_TextBox.Size = New System.Drawing.Size(166, 20)
        Me.Conform_TextBox.TabIndex = 124
        Me.Conform_TextBox.UseSystemPasswordChar = True
        '
        'Password_TextBox
        '
        Me.Password_TextBox.Location = New System.Drawing.Point(156, 56)
        Me.Password_TextBox.MaxLength = 255
        Me.Password_TextBox.Name = "Password_TextBox"
        Me.Password_TextBox.Size = New System.Drawing.Size(166, 20)
        Me.Password_TextBox.TabIndex = 123
        Me.Password_TextBox.UseSystemPasswordChar = True
        '
        'UserID_TextBox
        '
        Me.UserID_TextBox.Location = New System.Drawing.Point(156, 30)
        Me.UserID_TextBox.MaxLength = 255
        Me.UserID_TextBox.Name = "UserID_TextBox"
        Me.UserID_TextBox.Size = New System.Drawing.Size(192, 20)
        Me.UserID_TextBox.TabIndex = 122
        '
        'DairyFolder_TextBox
        '
        Me.DairyFolder_TextBox.Location = New System.Drawing.Point(156, 19)
        Me.DairyFolder_TextBox.MaxLength = 255
        Me.DairyFolder_TextBox.Name = "DairyFolder_TextBox"
        Me.DairyFolder_TextBox.Size = New System.Drawing.Size(358, 20)
        Me.DairyFolder_TextBox.TabIndex = 127
        '
        'FolderPath_Lable
        '
        Me.FolderPath_Lable.AutoSize = True
        Me.FolderPath_Lable.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!)
        Me.FolderPath_Lable.Location = New System.Drawing.Point(81, 22)
        Me.FolderPath_Lable.Name = "FolderPath_Lable"
        Me.FolderPath_Lable.Size = New System.Drawing.Size(69, 13)
        Me.FolderPath_Lable.TabIndex = 126
        Me.FolderPath_Lable.Text = "Dairy Folder :"
        '
        'MyPicGB
        '
        Me.MyPicGB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MyPicGB.Controls.Add(Me.RemovePicButton)
        Me.MyPicGB.Controls.Add(Me.Browse_Button)
        Me.MyPicGB.Controls.Add(Me.MyPicPB)
        Me.MyPicGB.Location = New System.Drawing.Point(402, 20)
        Me.MyPicGB.Name = "MyPicGB"
        Me.MyPicGB.Size = New System.Drawing.Size(196, 247)
        Me.MyPicGB.TabIndex = 129
        Me.MyPicGB.TabStop = False
        Me.MyPicGB.Text = "Picture "
        '
        'RemovePicButton
        '
        Me.RemovePicButton.Location = New System.Drawing.Point(115, 218)
        Me.RemovePicButton.Name = "RemovePicButton"
        Me.RemovePicButton.Size = New System.Drawing.Size(75, 23)
        Me.RemovePicButton.TabIndex = 2
        Me.RemovePicButton.Text = "Remove"
        Me.RemovePicButton.UseVisualStyleBackColor = True
        '
        'Browse_Button
        '
        Me.Browse_Button.Location = New System.Drawing.Point(6, 218)
        Me.Browse_Button.Name = "Browse_Button"
        Me.Browse_Button.Size = New System.Drawing.Size(103, 23)
        Me.Browse_Button.TabIndex = 1
        Me.Browse_Button.Text = "Browse"
        Me.Browse_Button.UseVisualStyleBackColor = True
        '
        'MyPicPB
        '
        Me.MyPicPB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.MyPicPB.Image = Global.MyDailyLog.My.Resources.Resources.DefaltPicIcon
        Me.MyPicPB.InitialImage = Global.MyDailyLog.My.Resources.Resources.DefaltPicIcon
        Me.MyPicPB.Location = New System.Drawing.Point(6, 19)
        Me.MyPicPB.Name = "MyPicPB"
        Me.MyPicPB.Size = New System.Drawing.Size(184, 193)
        Me.MyPicPB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.MyPicPB.TabIndex = 0
        Me.MyPicPB.TabStop = False
        '
        'DiaryFolder_GroupBox
        '
        Me.DiaryFolder_GroupBox.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DiaryFolder_GroupBox.Controls.Add(Me.Label1)
        Me.DiaryFolder_GroupBox.Controls.Add(Me.FolderPath_Lable)
        Me.DiaryFolder_GroupBox.Controls.Add(Me.DairyFolder_TextBox)
        Me.DiaryFolder_GroupBox.Location = New System.Drawing.Point(12, 273)
        Me.DiaryFolder_GroupBox.Name = "DiaryFolder_GroupBox"
        Me.DiaryFolder_GroupBox.Size = New System.Drawing.Size(589, 73)
        Me.DiaryFolder_GroupBox.TabIndex = 128
        Me.DiaryFolder_GroupBox.TabStop = False
        Me.DiaryFolder_GroupBox.Text = "Dairy Details"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 45)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 13)
        Me.Label1.TabIndex = 128
        Me.Label1.Text = "Archvie:"
        '
        'RegistrationDialog
        '
        Me.AcceptButton = Me.OK_Button
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.Cancel_Button
        Me.ClientSize = New System.Drawing.Size(613, 390)
        Me.Controls.Add(Me.MyPicGB)
        Me.Controls.Add(Me.DiaryFolder_GroupBox)
        Me.Controls.Add(Me.LoginGroupBox)
        Me.Controls.Add(Me.Personal_GroupBox)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(629, 428)
        Me.Name = "RegistrationDialog"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "RegistrationDialog"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.Personal_GroupBox.ResumeLayout(False)
        Me.Personal_GroupBox.PerformLayout()
        Me.LoginGroupBox.ResumeLayout(False)
        Me.LoginGroupBox.PerformLayout()
        Me.MyPicGB.ResumeLayout(False)
        CType(Me.MyPicPB, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DiaryFolder_GroupBox.ResumeLayout(False)
        Me.DiaryFolder_GroupBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents OK_Button As System.Windows.Forms.Button
    Friend WithEvents Cancel_Button As System.Windows.Forms.Button
    Private WithEvents EmailID_Lable As System.Windows.Forms.Label
    Private WithEvents Conform_Lable As System.Windows.Forms.Label
    Private WithEvents Password_Lable As System.Windows.Forms.Label
    Private WithEvents UserID_Lable As System.Windows.Forms.Label
    Private WithEvents DOB_Label As System.Windows.Forms.Label
    Private WithEvents Name_label As System.Windows.Forms.Label
    Friend WithEvents Personal_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Email_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DOB_DateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Name_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents LoginGroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Conform_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents Password_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents UserID_TextBox As System.Windows.Forms.TextBox
    Friend WithEvents DairyFolder_TextBox As System.Windows.Forms.TextBox
    Private WithEvents FolderPath_Lable As System.Windows.Forms.Label
    Friend WithEvents MyPicGB As System.Windows.Forms.GroupBox
    Friend WithEvents RemovePicButton As System.Windows.Forms.Button
    Friend WithEvents Browse_Button As System.Windows.Forms.Button
    Friend WithEvents MyPicPB As System.Windows.Forms.PictureBox
    Friend WithEvents DiaryFolder_GroupBox As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label

End Class
