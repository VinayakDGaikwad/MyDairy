<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registration
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registration))
        Me.txtEmailID = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EmpPic = New System.Windows.Forms.PictureBox()
        Me.BRemove = New System.Windows.Forms.Button()
        Me.BBrowse = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.button1 = New System.Windows.Forms.Button()
        Me.txtConformPass = New System.Windows.Forms.TextBox()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.txtUserID = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtPOB = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EmpPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtEmailID
        '
        Me.txtEmailID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmailID.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailID.Location = New System.Drawing.Point(152, 117)
        Me.txtEmailID.Name = "txtEmailID"
        Me.txtEmailID.Size = New System.Drawing.Size(121, 23)
        Me.txtEmailID.TabIndex = 97
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(84, 119)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(65, 18)
        Me.Label7.TabIndex = 113
        Me.Label7.Text = "Email ID :"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.EmpPic)
        Me.GroupBox2.Location = New System.Drawing.Point(318, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 202)
        Me.GroupBox2.TabIndex = 112
        Me.GroupBox2.TabStop = False
        '
        'EmpPic
        '
        Me.EmpPic.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.EmpPic.Image = CType(resources.GetObject("EmpPic.Image"), System.Drawing.Image)
        Me.EmpPic.Location = New System.Drawing.Point(6, 13)
        Me.EmpPic.Name = "EmpPic"
        Me.EmpPic.Size = New System.Drawing.Size(177, 181)
        Me.EmpPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.EmpPic.TabIndex = 11
        Me.EmpPic.TabStop = False
        '
        'BRemove
        '
        Me.BRemove.BackColor = System.Drawing.SystemColors.Control
        Me.BRemove.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRemove.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BRemove.Image = CType(resources.GetObject("BRemove.Image"), System.Drawing.Image)
        Me.BRemove.Location = New System.Drawing.Point(419, 216)
        Me.BRemove.Name = "BRemove"
        Me.BRemove.Size = New System.Drawing.Size(89, 37)
        Me.BRemove.TabIndex = 102
        Me.BRemove.Text = "&Remove"
        Me.BRemove.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BRemove.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BRemove.UseVisualStyleBackColor = True
        '
        'BBrowse
        '
        Me.BBrowse.BackColor = System.Drawing.SystemColors.Control
        Me.BBrowse.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BBrowse.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BBrowse.Image = CType(resources.GetObject("BBrowse.Image"), System.Drawing.Image)
        Me.BBrowse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BBrowse.Location = New System.Drawing.Point(319, 216)
        Me.BBrowse.Name = "BBrowse"
        Me.BBrowse.Size = New System.Drawing.Size(94, 37)
        Me.BBrowse.TabIndex = 101
        Me.BBrowse.Text = " &Browse"
        Me.BBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BBrowse.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(202, 254)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(89, 37)
        Me.Button3.TabIndex = 105
        Me.Button3.Text = "   &Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(109, 254)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(89, 37)
        Me.Button2.TabIndex = 104
        Me.Button2.Text = "    C&lear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'button1
        '
        Me.button1.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.button1.Image = CType(resources.GetObject("button1.Image"), System.Drawing.Image)
        Me.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.button1.Location = New System.Drawing.Point(16, 254)
        Me.button1.Name = "button1"
        Me.button1.Size = New System.Drawing.Size(89, 37)
        Me.button1.TabIndex = 103
        Me.button1.Text = "  C&reat"
        Me.button1.UseVisualStyleBackColor = True
        '
        'txtConformPass
        '
        Me.txtConformPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConformPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConformPass.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConformPass.Location = New System.Drawing.Point(152, 204)
        Me.txtConformPass.Name = "txtConformPass"
        Me.txtConformPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConformPass.Size = New System.Drawing.Size(121, 23)
        Me.txtConformPass.TabIndex = 100
        '
        'txtpassword
        '
        Me.txtpassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtpassword.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtpassword.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpassword.Location = New System.Drawing.Point(152, 175)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(121, 23)
        Me.txtpassword.TabIndex = 99
        '
        'txtUserID
        '
        Me.txtUserID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserID.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserID.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserID.Location = New System.Drawing.Point(152, 146)
        Me.txtUserID.Name = "txtUserID"
        Me.txtUserID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtUserID.Size = New System.Drawing.Size(121, 23)
        Me.txtUserID.TabIndex = 98
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(18, 206)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(131, 18)
        Me.Label6.TabIndex = 111
        Me.Label6.Text = "Conform Password :"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(75, 177)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(74, 18)
        Me.Label5.TabIndex = 110
        Me.Label5.Text = "Password :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(90, 148)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(59, 18)
        Me.Label4.TabIndex = 109
        Me.Label4.Text = "User ID :"
        '
        'txtPOB
        '
        Me.txtPOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPOB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPOB.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOB.Location = New System.Drawing.Point(152, 88)
        Me.txtPOB.Name = "txtPOB"
        Me.txtPOB.Size = New System.Drawing.Size(121, 23)
        Me.txtPOB.TabIndex = 96
        '
        'txtUserName
        '
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(152, 30)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(121, 23)
        Me.txtUserName.TabIndex = 94
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(52, 90)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Place of Birth :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 107
        Me.Label2.Text = "Date of Birth :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(67, 32)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 18)
        Me.label1.TabIndex = 106
        Me.label1.Text = "Your Name :"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(152, 58)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(121, 24)
        Me.dtpDOB.TabIndex = 136
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(357, 264)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(113, 37)
        Me.Button4.TabIndex = 137
        Me.Button4.Text = "&Get Data    "
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Registration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(520, 312)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.txtEmailID)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BRemove)
        Me.Controls.Add(Me.BBrowse)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.button1)
        Me.Controls.Add(Me.txtConformPass)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.txtUserID)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtPOB)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Registration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.EmpPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents txtEmailID As System.Windows.Forms.TextBox
    Private WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents EmpPic As System.Windows.Forms.PictureBox
    Friend WithEvents BRemove As System.Windows.Forms.Button
    Friend WithEvents BBrowse As System.Windows.Forms.Button
    Private WithEvents Button3 As System.Windows.Forms.Button
    Private WithEvents Button2 As System.Windows.Forms.Button
    Private WithEvents button1 As System.Windows.Forms.Button
    Private WithEvents txtConformPass As System.Windows.Forms.TextBox
    Private WithEvents txtpassword As System.Windows.Forms.TextBox
    Private WithEvents txtUserID As System.Windows.Forms.TextBox
    Private WithEvents Label6 As System.Windows.Forms.Label
    Private WithEvents Label5 As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents txtPOB As System.Windows.Forms.TextBox
    Private WithEvents txtUserName As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button4 As System.Windows.Forms.Button
End Class
