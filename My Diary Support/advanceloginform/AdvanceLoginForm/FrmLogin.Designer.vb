<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmLogin
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmLogin))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.AdminPictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CmdAdmincancel = New System.Windows.Forms.Button()
        Me.AdminLabel2 = New System.Windows.Forms.Label()
        Me.AdminLabel1 = New System.Windows.Forms.Label()
        Me.CmdAdminLogin = New System.Windows.Forms.Button()
        Me.TxtAdminPassword = New System.Windows.Forms.TextBox()
        Me.TxtAdminUserName = New System.Windows.Forms.TextBox()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.CBformState = New System.Windows.Forms.ComboBox()
        Me.LblAttempt = New System.Windows.Forms.Label()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CmdCancel = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CmdLogin = New System.Windows.Forms.Button()
        Me.txtPassword = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.AdminPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Location = New System.Drawing.Point(-5, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(420, 252)
        Me.TabControl1.TabIndex = 1
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage1.Controls.Add(Me.GroupBox2)
        Me.TabPage1.Location = New System.Drawing.Point(4, 27)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(412, 221)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Admin"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox2.Controls.Add(Me.LinkLabel2)
        Me.GroupBox2.Controls.Add(Me.AdminPictureBox2)
        Me.GroupBox2.Controls.Add(Me.CmdAdmincancel)
        Me.GroupBox2.Controls.Add(Me.AdminLabel2)
        Me.GroupBox2.Controls.Add(Me.AdminLabel1)
        Me.GroupBox2.Controls.Add(Me.CmdAdminLogin)
        Me.GroupBox2.Controls.Add(Me.TxtAdminPassword)
        Me.GroupBox2.Controls.Add(Me.TxtAdminUserName)
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.White
        Me.GroupBox2.Location = New System.Drawing.Point(7, -1)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox2.Size = New System.Drawing.Size(398, 214)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.RoyalBlue
        Me.LinkLabel2.Location = New System.Drawing.Point(20, 178)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(96, 14)
        Me.LinkLabel2.TabIndex = 19
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Forget Password"
        Me.LinkLabel2.Visible = False
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'AdminPictureBox2
        '
        Me.AdminPictureBox2.Image = CType(resources.GetObject("AdminPictureBox2.Image"), System.Drawing.Image)
        Me.AdminPictureBox2.Location = New System.Drawing.Point(17, 24)
        Me.AdminPictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.AdminPictureBox2.Name = "AdminPictureBox2"
        Me.AdminPictureBox2.Size = New System.Drawing.Size(132, 139)
        Me.AdminPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.AdminPictureBox2.TabIndex = 18
        Me.AdminPictureBox2.TabStop = False
        '
        'CmdAdmincancel
        '
        Me.CmdAdmincancel.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdmincancel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmdAdmincancel.Image = CType(resources.GetObject("CmdAdmincancel.Image"), System.Drawing.Image)
        Me.CmdAdmincancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAdmincancel.Location = New System.Drawing.Point(277, 152)
        Me.CmdAdmincancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdAdmincancel.Name = "CmdAdmincancel"
        Me.CmdAdmincancel.Size = New System.Drawing.Size(97, 40)
        Me.CmdAdmincancel.TabIndex = 3
        Me.CmdAdmincancel.Text = "     &Cancel"
        Me.CmdAdmincancel.UseVisualStyleBackColor = True
        '
        'AdminLabel2
        '
        Me.AdminLabel2.AutoSize = True
        Me.AdminLabel2.BackColor = System.Drawing.Color.Transparent
        Me.AdminLabel2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel2.ForeColor = System.Drawing.Color.White
        Me.AdminLabel2.Location = New System.Drawing.Point(175, 86)
        Me.AdminLabel2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AdminLabel2.Name = "AdminLabel2"
        Me.AdminLabel2.Size = New System.Drawing.Size(79, 19)
        Me.AdminLabel2.TabIndex = 16
        Me.AdminLabel2.Text = "Password :"
        '
        'AdminLabel1
        '
        Me.AdminLabel1.AutoSize = True
        Me.AdminLabel1.BackColor = System.Drawing.Color.Transparent
        Me.AdminLabel1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AdminLabel1.ForeColor = System.Drawing.Color.White
        Me.AdminLabel1.Location = New System.Drawing.Point(175, 34)
        Me.AdminLabel1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AdminLabel1.Name = "AdminLabel1"
        Me.AdminLabel1.Size = New System.Drawing.Size(89, 19)
        Me.AdminLabel1.TabIndex = 15
        Me.AdminLabel1.Text = "User Name :"
        '
        'CmdAdminLogin
        '
        Me.CmdAdminLogin.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdAdminLogin.ForeColor = System.Drawing.Color.Black
        Me.CmdAdminLogin.Image = CType(resources.GetObject("CmdAdminLogin.Image"), System.Drawing.Image)
        Me.CmdAdminLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdAdminLogin.Location = New System.Drawing.Point(176, 152)
        Me.CmdAdminLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdAdminLogin.Name = "CmdAdminLogin"
        Me.CmdAdminLogin.Size = New System.Drawing.Size(97, 40)
        Me.CmdAdminLogin.TabIndex = 2
        Me.CmdAdminLogin.Text = "        &Login"
        Me.CmdAdminLogin.UseVisualStyleBackColor = True
        '
        'TxtAdminPassword
        '
        Me.TxtAdminPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAdminPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminPassword.Location = New System.Drawing.Point(176, 108)
        Me.TxtAdminPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAdminPassword.Name = "TxtAdminPassword"
        Me.TxtAdminPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtAdminPassword.Size = New System.Drawing.Size(200, 23)
        Me.TxtAdminPassword.TabIndex = 1
        '
        'TxtAdminUserName
        '
        Me.TxtAdminUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtAdminUserName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtAdminUserName.Location = New System.Drawing.Point(176, 55)
        Me.TxtAdminUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.TxtAdminUserName.Name = "TxtAdminUserName"
        Me.TxtAdminUserName.Size = New System.Drawing.Size(200, 23)
        Me.TxtAdminUserName.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.DarkGray
        Me.TabPage2.Controls.Add(Me.GroupBox1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 27)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(412, 221)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = " User"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.DarkGray
        Me.GroupBox1.Controls.Add(Me.LinkLabel1)
        Me.GroupBox1.Controls.Add(Me.CBformState)
        Me.GroupBox1.Controls.Add(Me.LblAttempt)
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.CmdCancel)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.CmdLogin)
        Me.GroupBox1.Controls.Add(Me.txtPassword)
        Me.GroupBox1.Controls.Add(Me.txtUserName)
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.GroupBox1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.Color.White
        Me.GroupBox1.Location = New System.Drawing.Point(7, -1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(398, 214)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.RoyalBlue
        Me.LinkLabel1.Location = New System.Drawing.Point(20, 177)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(96, 14)
        Me.LinkLabel1.TabIndex = 91
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forget Password"
        Me.LinkLabel1.Visible = False
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'CBformState
        '
        Me.CBformState.FormattingEnabled = True
        Me.CBformState.Items.AddRange(New Object() {"Admin", "User"})
        Me.CBformState.Location = New System.Drawing.Point(306, 15)
        Me.CBformState.Name = "CBformState"
        Me.CBformState.Size = New System.Drawing.Size(86, 23)
        Me.CBformState.TabIndex = 2
        Me.CBformState.Visible = False
        '
        'LblAttempt
        '
        Me.LblAttempt.AutoSize = True
        Me.LblAttempt.BackColor = System.Drawing.Color.Transparent
        Me.LblAttempt.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblAttempt.ForeColor = System.Drawing.Color.White
        Me.LblAttempt.Location = New System.Drawing.Point(146, 176)
        Me.LblAttempt.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblAttempt.Name = "LblAttempt"
        Me.LblAttempt.Size = New System.Drawing.Size(0, 19)
        Me.LblAttempt.TabIndex = 90
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(17, 24)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(132, 139)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'CmdCancel
        '
        Me.CmdCancel.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdCancel.ForeColor = System.Drawing.SystemColors.WindowText
        Me.CmdCancel.Image = CType(resources.GetObject("CmdCancel.Image"), System.Drawing.Image)
        Me.CmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdCancel.Location = New System.Drawing.Point(276, 151)
        Me.CmdCancel.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdCancel.Name = "CmdCancel"
        Me.CmdCancel.Size = New System.Drawing.Size(97, 40)
        Me.CmdCancel.TabIndex = 3
        Me.CmdCancel.Text = "     &Cancel"
        Me.CmdCancel.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(174, 85)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(79, 19)
        Me.Label2.TabIndex = 16
        Me.Label2.Text = "Password :"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(174, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 19)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "User Name :"
        '
        'CmdLogin
        '
        Me.CmdLogin.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CmdLogin.ForeColor = System.Drawing.Color.Black
        Me.CmdLogin.Image = CType(resources.GetObject("CmdLogin.Image"), System.Drawing.Image)
        Me.CmdLogin.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.CmdLogin.Location = New System.Drawing.Point(175, 151)
        Me.CmdLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.CmdLogin.Name = "CmdLogin"
        Me.CmdLogin.Size = New System.Drawing.Size(97, 40)
        Me.CmdLogin.TabIndex = 2
        Me.CmdLogin.Text = "        &Login"
        Me.CmdLogin.UseVisualStyleBackColor = True
        '
        'txtPassword
        '
        Me.txtPassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Location = New System.Drawing.Point(175, 107)
        Me.txtPassword.Margin = New System.Windows.Forms.Padding(4)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPassword.Size = New System.Drawing.Size(200, 23)
        Me.txtPassword.TabIndex = 1
        '
        'txtUserName
        '
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(175, 54)
        Me.txtUserName.Margin = New System.Windows.Forms.Padding(4)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(200, 23)
        Me.txtUserName.TabIndex = 0
        '
        'FrmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(410, 247)
        Me.Controls.Add(Me.TabControl1)
        Me.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "FrmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Tag = "Login "
        Me.Text = "Login"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.AdminPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents AdminPictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CmdAdmincancel As System.Windows.Forms.Button
    Friend WithEvents AdminLabel2 As System.Windows.Forms.Label
    Friend WithEvents AdminLabel1 As System.Windows.Forms.Label
    Friend WithEvents CmdAdminLogin As System.Windows.Forms.Button
    Friend WithEvents TxtAdminPassword As System.Windows.Forms.TextBox
    Friend WithEvents TxtAdminUserName As System.Windows.Forms.TextBox
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Public WithEvents CBformState As System.Windows.Forms.ComboBox
    Friend WithEvents LblAttempt As System.Windows.Forms.Label
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CmdCancel As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CmdLogin As System.Windows.Forms.Button
    Friend WithEvents txtPassword As System.Windows.Forms.TextBox
    Friend WithEvents txtUserName As System.Windows.Forms.TextBox
    Private WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Private WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel

End Class
