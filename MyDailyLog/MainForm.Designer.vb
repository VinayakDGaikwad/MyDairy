<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Main_ToolStrip = New System.Windows.Forms.ToolStrip()
        Me.ChangeDate_Button = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.Date_Label = New System.Windows.Forms.ToolStripStatusLabel()
        Me.UserNameTB = New System.Windows.Forms.Label()
        Me.SmallPictureBox = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.LogoutButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ClosePane = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.UserName2 = New System.Windows.Forms.Label()
        Me.UserID = New System.Windows.Forms.Label()
        Me.RegistrationButton = New System.Windows.Forms.Button()
        Me.LargePictureBox = New System.Windows.Forms.PictureBox()
        Me.MainRichTextBox = New System.Windows.Forms.RichTextBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.I_Button = New System.Windows.Forms.Button()
        Me.U_Button = New System.Windows.Forms.Button()
        Me.B_Button = New System.Windows.Forms.Button()
        Me.MoreOptionsPanel_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Main_ToolStrip.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.SmallPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.LargePictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Main_ToolStrip
        '
        Me.Main_ToolStrip.AutoSize = False
        Me.Main_ToolStrip.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.Main_ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.Main_ToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ChangeDate_Button})
        Me.Main_ToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.Main_ToolStrip.Name = "Main_ToolStrip"
        Me.Main_ToolStrip.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Main_ToolStrip.Size = New System.Drawing.Size(914, 70)
        Me.Main_ToolStrip.TabIndex = 0
        '
        'ChangeDate_Button
        '
        Me.ChangeDate_Button.BackColor = System.Drawing.Color.Transparent
        Me.ChangeDate_Button.Image = CType(resources.GetObject("ChangeDate_Button.Image"), System.Drawing.Image)
        Me.ChangeDate_Button.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ChangeDate_Button.ImageTransparentColor = System.Drawing.Color.Maroon
        Me.ChangeDate_Button.Name = "ChangeDate_Button"
        Me.ChangeDate_Button.Size = New System.Drawing.Size(68, 67)
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Date_Label})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 456)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.StatusStrip1.Size = New System.Drawing.Size(914, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'Date_Label
        '
        Me.Date_Label.BackColor = System.Drawing.Color.Transparent
        Me.Date_Label.Name = "Date_Label"
        Me.Date_Label.Size = New System.Drawing.Size(81, 17)
        Me.Date_Label.Text = "Selected Date:"
        '
        'UserNameTB
        '
        Me.UserNameTB.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.UserNameTB.Location = New System.Drawing.Point(722, 9)
        Me.UserNameTB.Name = "UserNameTB"
        Me.UserNameTB.Size = New System.Drawing.Size(122, 54)
        Me.UserNameTB.TabIndex = 3
        Me.UserNameTB.Text = "UserName"
        Me.UserNameTB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'SmallPictureBox
        '
        Me.SmallPictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SmallPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SmallPictureBox.Location = New System.Drawing.Point(850, 9)
        Me.SmallPictureBox.Name = "SmallPictureBox"
        Me.SmallPictureBox.Size = New System.Drawing.Size(52, 54)
        Me.SmallPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.SmallPictureBox.TabIndex = 4
        Me.SmallPictureBox.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.LogoutButton)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.ClosePane)
        Me.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        Me.Panel1.Controls.Add(Me.RegistrationButton)
        Me.Panel1.Controls.Add(Me.LargePictureBox)
        Me.Panel1.Location = New System.Drawing.Point(619, 73)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(283, 159)
        Me.Panel1.TabIndex = 5
        Me.Panel1.Visible = False
        '
        'LogoutButton
        '
        Me.LogoutButton.Location = New System.Drawing.Point(146, 128)
        Me.LogoutButton.Name = "LogoutButton"
        Me.LogoutButton.Size = New System.Drawing.Size(134, 23)
        Me.LogoutButton.TabIndex = 9
        Me.LogoutButton.Text = "Logout"
        Me.LogoutButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(3, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(137, 22)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Change Picture"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'ClosePane
        '
        Me.ClosePane.AutoSize = True
        Me.ClosePane.Location = New System.Drawing.Point(266, 6)
        Me.ClosePane.Name = "ClosePane"
        Me.ClosePane.Size = New System.Drawing.Size(14, 13)
        Me.ClosePane.TabIndex = 10
        Me.ClosePane.Text = "X"
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Transparent
        Me.FlowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.FlowLayoutPanel1.Controls.Add(Me.UserName2)
        Me.FlowLayoutPanel1.Controls.Add(Me.UserID)
        Me.FlowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(146, 21)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(134, 101)
        Me.FlowLayoutPanel1.TabIndex = 6
        '
        'UserName2
        '
        Me.UserName2.Font = New System.Drawing.Font("Comic Sans MS", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName2.Location = New System.Drawing.Point(3, 0)
        Me.UserName2.Name = "UserName2"
        Me.UserName2.Size = New System.Drawing.Size(100, 26)
        Me.UserName2.TabIndex = 0
        Me.UserName2.Text = "<UserName>"
        '
        'UserID
        '
        Me.UserID.AutoSize = True
        Me.UserID.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.UserID.Location = New System.Drawing.Point(3, 26)
        Me.UserID.Name = "UserID"
        Me.UserID.Size = New System.Drawing.Size(52, 13)
        Me.UserID.TabIndex = 1
        Me.UserID.Text = "<UserID>"
        '
        'RegistrationButton
        '
        Me.RegistrationButton.Location = New System.Drawing.Point(6, 128)
        Me.RegistrationButton.Name = "RegistrationButton"
        Me.RegistrationButton.Size = New System.Drawing.Size(128, 23)
        Me.RegistrationButton.TabIndex = 8
        Me.RegistrationButton.Text = "Add Acount"
        Me.RegistrationButton.UseVisualStyleBackColor = True
        '
        'LargePictureBox
        '
        Me.LargePictureBox.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LargePictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.LargePictureBox.Location = New System.Drawing.Point(6, 6)
        Me.LargePictureBox.Name = "LargePictureBox"
        Me.LargePictureBox.Size = New System.Drawing.Size(134, 116)
        Me.LargePictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.LargePictureBox.TabIndex = 5
        Me.LargePictureBox.TabStop = False
        '
        'MainRichTextBox
        '
        Me.MainRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.MainRichTextBox.Location = New System.Drawing.Point(12, 120)
        Me.MainRichTextBox.Name = "MainRichTextBox"
        Me.MainRichTextBox.Size = New System.Drawing.Size(890, 321)
        Me.MainRichTextBox.TabIndex = 6
        Me.MainRichTextBox.Text = ""
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.I_Button)
        Me.Panel2.Controls.Add(Me.U_Button)
        Me.Panel2.Controls.Add(Me.B_Button)
        Me.Panel2.Location = New System.Drawing.Point(0, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(914, 41)
        Me.Panel2.TabIndex = 7
        '
        'I_Button
        '
        Me.I_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.I_Button.Location = New System.Drawing.Point(44, 9)
        Me.I_Button.Name = "I_Button"
        Me.I_Button.Size = New System.Drawing.Size(24, 23)
        Me.I_Button.TabIndex = 2
        Me.I_Button.Text = "I"
        Me.I_Button.UseVisualStyleBackColor = True
        '
        'U_Button
        '
        Me.U_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.U_Button.Location = New System.Drawing.Point(74, 9)
        Me.U_Button.Name = "U_Button"
        Me.U_Button.Size = New System.Drawing.Size(27, 23)
        Me.U_Button.TabIndex = 1
        Me.U_Button.Text = "U"
        Me.U_Button.UseVisualStyleBackColor = True
        '
        'B_Button
        '
        Me.B_Button.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.B_Button.Location = New System.Drawing.Point(12, 9)
        Me.B_Button.Name = "B_Button"
        Me.B_Button.Size = New System.Drawing.Size(26, 23)
        Me.B_Button.TabIndex = 0
        Me.B_Button.Text = "B"
        Me.B_Button.UseVisualStyleBackColor = True
        '
        'MoreOptionsPanel_Timer
        '
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(37, Byte), Integer), CType(CType(147, Byte), Integer), CType(CType(229, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(914, 478)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SmallPictureBox)
        Me.Controls.Add(Me.UserNameTB)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.Main_ToolStrip)
        Me.Controls.Add(Me.MainRichTextBox)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MainForm"
        Me.Text = "My Diary Editor"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.Main_ToolStrip.ResumeLayout(False)
        Me.Main_ToolStrip.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.SmallPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        CType(Me.LargePictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Main_ToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents ChangeDate_Button As System.Windows.Forms.ToolStripButton
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents Date_Label As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents UserNameTB As System.Windows.Forms.Label
    Friend WithEvents SmallPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents LargePictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UserName2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents UserID As System.Windows.Forms.Label
    Friend WithEvents RegistrationButton As System.Windows.Forms.Button
    Friend WithEvents LogoutButton As System.Windows.Forms.Button
    Friend WithEvents ClosePane As System.Windows.Forms.Label
    Friend WithEvents MainRichTextBox As System.Windows.Forms.RichTextBox
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents B_Button As System.Windows.Forms.Button
    Friend WithEvents U_Button As System.Windows.Forms.Button
    Friend WithEvents I_Button As System.Windows.Forms.Button
    Friend WithEvents MoreOptionsPanel_Timer As System.Windows.Forms.Timer

End Class
