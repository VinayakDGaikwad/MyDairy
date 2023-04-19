<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(UserInfo))
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.PicStudent = New System.Windows.Forms.PictureBox()
        Me.EmailID = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.PlaceOfBirth = New System.Windows.Forms.Label()
        Me.DateOfBirth = New System.Windows.Forms.Label()
        Me.UserName = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PicStudent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(29, 45)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(79, 18)
        Me.label1.TabIndex = 112
        Me.label1.Text = "Your Name:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.PicStudent)
        Me.GroupBox2.Location = New System.Drawing.Point(341, 11)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 202)
        Me.GroupBox2.TabIndex = 111
        Me.GroupBox2.TabStop = False
        '
        'PicStudent
        '
        Me.PicStudent.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.PicStudent.Location = New System.Drawing.Point(6, 13)
        Me.PicStudent.Name = "PicStudent"
        Me.PicStudent.Size = New System.Drawing.Size(177, 181)
        Me.PicStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PicStudent.TabIndex = 11
        Me.PicStudent.TabStop = False
        '
        'EmailID
        '
        Me.EmailID.AutoSize = True
        Me.EmailID.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.EmailID.ForeColor = System.Drawing.Color.Navy
        Me.EmailID.Location = New System.Drawing.Point(114, 135)
        Me.EmailID.Name = "EmailID"
        Me.EmailID.Size = New System.Drawing.Size(0, 18)
        Me.EmailID.TabIndex = 121
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(46, 135)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(62, 18)
        Me.Label4.TabIndex = 120
        Me.Label4.Text = "Email ID:"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.BackColor = System.Drawing.Color.Transparent
        Me.LinkLabel1.DisabledLinkColor = System.Drawing.Color.Black
        Me.LinkLabel1.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel1.LinkColor = System.Drawing.Color.MediumVioletRed
        Me.LinkLabel1.Location = New System.Drawing.Point(12, 205)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(102, 14)
        Me.LinkLabel1.TabIndex = 119
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Change Password"
        Me.LinkLabel1.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'LinkLabel2
        '
        Me.LinkLabel2.ActiveLinkColor = System.Drawing.Color.Navy
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.BackColor = System.Drawing.Color.White
        Me.LinkLabel2.DisabledLinkColor = System.Drawing.Color.Black
        Me.LinkLabel2.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel2.LinkBehavior = System.Windows.Forms.LinkBehavior.HoverUnderline
        Me.LinkLabel2.LinkColor = System.Drawing.Color.MediumVioletRed
        Me.LinkLabel2.Location = New System.Drawing.Point(12, 188)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(72, 14)
        Me.LinkLabel2.TabIndex = 118
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Change Info"
        Me.LinkLabel2.VisitedLinkColor = System.Drawing.Color.Navy
        '
        'PlaceOfBirth
        '
        Me.PlaceOfBirth.AutoSize = True
        Me.PlaceOfBirth.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PlaceOfBirth.ForeColor = System.Drawing.Color.Navy
        Me.PlaceOfBirth.Location = New System.Drawing.Point(114, 105)
        Me.PlaceOfBirth.Name = "PlaceOfBirth"
        Me.PlaceOfBirth.Size = New System.Drawing.Size(0, 18)
        Me.PlaceOfBirth.TabIndex = 117
        '
        'DateOfBirth
        '
        Me.DateOfBirth.AutoSize = True
        Me.DateOfBirth.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateOfBirth.ForeColor = System.Drawing.Color.Navy
        Me.DateOfBirth.Location = New System.Drawing.Point(114, 75)
        Me.DateOfBirth.Name = "DateOfBirth"
        Me.DateOfBirth.Size = New System.Drawing.Size(0, 18)
        Me.DateOfBirth.TabIndex = 116
        '
        'UserName
        '
        Me.UserName.AutoSize = True
        Me.UserName.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.UserName.ForeColor = System.Drawing.Color.Navy
        Me.UserName.Location = New System.Drawing.Point(114, 45)
        Me.UserName.Name = "UserName"
        Me.UserName.Size = New System.Drawing.Size(0, 18)
        Me.UserName.TabIndex = 115
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 105)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(94, 18)
        Me.Label3.TabIndex = 114
        Me.Label3.Text = "Place of Birth:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 75)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 18)
        Me.Label2.TabIndex = 113
        Me.Label2.Text = "Date of Birth:"
        '
        'UserInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(540, 231)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.EmailID)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.PlaceOfBirth)
        Me.Controls.Add(Me.DateOfBirth)
        Me.Controls.Add(Me.UserName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "UserInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "User Info"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.PicStudent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents PicStudent As System.Windows.Forms.PictureBox
    Friend WithEvents EmailID As System.Windows.Forms.Label
    Private WithEvents Label4 As System.Windows.Forms.Label
    Private WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Private WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
    Friend WithEvents PlaceOfBirth As System.Windows.Forms.Label
    Friend WithEvents DateOfBirth As System.Windows.Forms.Label
    Friend WithEvents UserName As System.Windows.Forms.Label
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
End Class
