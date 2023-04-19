<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Welcome_Form
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Welcome_Form))
        Me.Main_Label = New System.Windows.Forms.Label()
        Me.Password_TB = New System.Windows.Forms.TextBox()
        Me.Welcome_Panel = New System.Windows.Forms.Panel()
        Me.ForgetPassword_LL = New System.Windows.Forms.LinkLabel()
        Me.UserID_TB = New System.Windows.Forms.TextBox()
        Me.MyDailyLogPictureBox = New System.Windows.Forms.PictureBox()
        Me.Welcome_ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.CreateNewYear = New System.Windows.Forms.ToolStripButton()
        Me.ExitButton = New System.Windows.Forms.ToolStripButton()
        Me.NextButton = New System.Windows.Forms.ToolStripButton()
        Me.CreateNew_Button = New System.Windows.Forms.ToolStripButton()
        Me.CancelButton = New System.Windows.Forms.ToolStripButton()
        Me.Login_Button = New System.Windows.Forms.ToolStripButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Welcome_Panel.SuspendLayout()
        CType(Me.MyDailyLogPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Welcome_ToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'Main_Label
        '
        Me.Main_Label.AutoSize = True
        Me.Main_Label.BackColor = System.Drawing.Color.Transparent
        Me.Main_Label.Font = New System.Drawing.Font("Lucida Handwriting", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Main_Label.ForeColor = System.Drawing.Color.White
        Me.Main_Label.Location = New System.Drawing.Point(222, 10)
        Me.Main_Label.Name = "Main_Label"
        Me.Main_Label.Size = New System.Drawing.Size(287, 48)
        Me.Main_Label.TabIndex = 1
        Me.Main_Label.Text = "My Daily Log"
        '
        'Password_TB
        '
        Me.Password_TB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Password_TB.Location = New System.Drawing.Point(264, 296)
        Me.Password_TB.Name = "Password_TB"
        Me.Password_TB.Size = New System.Drawing.Size(202, 20)
        Me.Password_TB.TabIndex = 2
        Me.Password_TB.UseSystemPasswordChar = True
        '
        'Welcome_Panel
        '
        Me.Welcome_Panel.BackColor = System.Drawing.Color.Transparent
        Me.Welcome_Panel.Controls.Add(Me.ForgetPassword_LL)
        Me.Welcome_Panel.Controls.Add(Me.UserID_TB)
        Me.Welcome_Panel.Controls.Add(Me.MyDailyLogPictureBox)
        Me.Welcome_Panel.Controls.Add(Me.Password_TB)
        Me.Welcome_Panel.Controls.Add(Me.Main_Label)
        Me.Welcome_Panel.Location = New System.Drawing.Point(12, 12)
        Me.Welcome_Panel.Name = "Welcome_Panel"
        Me.Welcome_Panel.Size = New System.Drawing.Size(730, 373)
        Me.Welcome_Panel.TabIndex = 6
        '
        'ForgetPassword_LL
        '
        Me.ForgetPassword_LL.AutoSize = True
        Me.ForgetPassword_LL.Location = New System.Drawing.Point(322, 331)
        Me.ForgetPassword_LL.Name = "ForgetPassword_LL"
        Me.ForgetPassword_LL.Size = New System.Drawing.Size(86, 13)
        Me.ForgetPassword_LL.TabIndex = 11
        Me.ForgetPassword_LL.TabStop = True
        Me.ForgetPassword_LL.Text = "Forget Password"
        '
        'UserID_TB
        '
        Me.UserID_TB.ForeColor = System.Drawing.Color.Black
        Me.UserID_TB.Location = New System.Drawing.Point(264, 270)
        Me.UserID_TB.Name = "UserID_TB"
        Me.UserID_TB.Size = New System.Drawing.Size(202, 20)
        Me.UserID_TB.TabIndex = 1
        '
        'MyDailyLogPictureBox
        '
        Me.MyDailyLogPictureBox.Image = Global.MyDailyLog.My.Resources.Resources.App_Image
        Me.MyDailyLogPictureBox.Location = New System.Drawing.Point(302, 67)
        Me.MyDailyLogPictureBox.Name = "MyDailyLogPictureBox"
        Me.MyDailyLogPictureBox.Size = New System.Drawing.Size(126, 187)
        Me.MyDailyLogPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.MyDailyLogPictureBox.TabIndex = 9
        Me.MyDailyLogPictureBox.TabStop = False
        '
        'Welcome_ToolStrip
        '
        Me.Welcome_ToolStrip.AutoSize = False
        Me.Welcome_ToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Welcome_ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Welcome_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Welcome_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CreateNewYear, Me.ExitButton, Me.NextButton})
        Me.Welcome_ToolStrip.Location = New System.Drawing.Point(0, 401)
        Me.Welcome_ToolStrip.Name = "Welcome_ToolStrip"
        Me.Welcome_ToolStrip.Size = New System.Drawing.Size(754, 70)
        Me.Welcome_ToolStrip.TabIndex = 8
        '
        'CreateNewYear
        '
        Me.CreateNewYear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CreateNewYear.Image = Global.MyDailyLog.My.Resources.Resources.CreateNew_Icon
        Me.CreateNewYear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CreateNewYear.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CreateNewYear.Name = "CreateNewYear"
        Me.CreateNewYear.Size = New System.Drawing.Size(68, 67)
        Me.CreateNewYear.Text = "Register New Member"
        '
        'ExitButton
        '
        Me.ExitButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ExitButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ExitButton.Image = Global.MyDailyLog.My.Resources.Resources.Cancel_Icon
        Me.ExitButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ExitButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never
        Me.ExitButton.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ExitButton.Size = New System.Drawing.Size(68, 67)
        Me.ExitButton.Text = "Exit"
        '
        'NextButton
        '
        Me.NextButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NextButton.Image = Global.MyDailyLog.My.Resources.Resources.Next_Icon
        Me.NextButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NextButton.Name = "NextButton"
        Me.NextButton.Size = New System.Drawing.Size(68, 67)
        Me.NextButton.Text = "Login"
        '
        'CreateNew_Button
        '
        Me.CreateNew_Button.BackColor = System.Drawing.Color.Transparent
        Me.CreateNew_Button.Image = Global.MyDailyLog.My.Resources.Resources.CreateNew_Icon
        Me.CreateNew_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CreateNew_Button.ImageTransparentColor = System.Drawing.Color.Maroon
        Me.CreateNew_Button.Name = "CreateNew_Button"
        Me.CreateNew_Button.Size = New System.Drawing.Size(68, 67)
        '
        'CancelButton
        '
        Me.CancelButton.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.CancelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CancelButton.Image = Global.MyDailyLog.My.Resources.Resources.Cancel_Icon
        Me.CancelButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.CancelButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.CancelButton.Name = "CancelButton"
        Me.CancelButton.Size = New System.Drawing.Size(68, 67)
        Me.CancelButton.Text = "CancelButton"
        '
        'Login_Button
        '
        Me.Login_Button.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.Login_Button.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.Login_Button.Image = Global.MyDailyLog.My.Resources.Resources.Next_Icon
        Me.Login_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.Login_Button.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.Login_Button.Name = "Login_Button"
        Me.Login_Button.Size = New System.Drawing.Size(68, 67)
        Me.Login_Button.Text = "Login"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 388)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(733, 13)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "_________________________________________________________________________________" & _
            "________________________________________"
        '
        'Welcome_Form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(754, 471)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Welcome_ToolStrip)
        Me.Controls.Add(Me.Welcome_Panel)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Welcome_Form"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Welcome"
        Me.Welcome_Panel.ResumeLayout(False)
        Me.Welcome_Panel.PerformLayout()
        CType(Me.MyDailyLogPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Welcome_ToolStrip.ResumeLayout(False)
        Me.Welcome_ToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Main_Label As System.Windows.Forms.Label
    Friend WithEvents Password_TB As System.Windows.Forms.TextBox
    Friend WithEvents Welcome_Panel As System.Windows.Forms.Panel
    Friend WithEvents Welcome_ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents CreateNew_Button As System.Windows.Forms.ToolStripButton
    Friend WithEvents CancelButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Login_Button As System.Windows.Forms.ToolStripButton
    Friend WithEvents MyDailyLogPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UserID_TB As System.Windows.Forms.TextBox
    Friend WithEvents ForgetPassword_LL As System.Windows.Forms.LinkLabel
    Friend WithEvents CreateNewYear As System.Windows.Forms.ToolStripButton
    Friend WithEvents ExitButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents NextButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
