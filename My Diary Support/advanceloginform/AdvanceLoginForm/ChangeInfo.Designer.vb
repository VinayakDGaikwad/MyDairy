<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangeInfo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangeInfo))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.EmpPic = New System.Windows.Forms.PictureBox()
        Me.BRemove = New System.Windows.Forms.Button()
        Me.BBrowse = New System.Windows.Forms.Button()
        Me.cmdCancel = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.txtPOB = New System.Windows.Forms.TextBox()
        Me.txtUserName = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.txtEmailID = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dtpDOB = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox2.SuspendLayout()
        CType(Me.EmpPic, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.EmpPic)
        Me.GroupBox2.Location = New System.Drawing.Point(317, 1)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(189, 202)
        Me.GroupBox2.TabIndex = 133
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
        Me.EmpPic.TabIndex = 12
        Me.EmpPic.TabStop = False
        '
        'BRemove
        '
        Me.BRemove.BackColor = System.Drawing.SystemColors.Control
        Me.BRemove.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRemove.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BRemove.Image = CType(resources.GetObject("BRemove.Image"), System.Drawing.Image)
        Me.BRemove.Location = New System.Drawing.Point(417, 211)
        Me.BRemove.Name = "BRemove"
        Me.BRemove.Size = New System.Drawing.Size(89, 37)
        Me.BRemove.TabIndex = 126
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
        Me.BBrowse.Location = New System.Drawing.Point(317, 211)
        Me.BBrowse.Name = "BBrowse"
        Me.BBrowse.Size = New System.Drawing.Size(94, 37)
        Me.BBrowse.TabIndex = 125
        Me.BBrowse.Text = "&Browse"
        Me.BBrowse.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BBrowse.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.BBrowse.UseVisualStyleBackColor = True
        '
        'cmdCancel
        '
        Me.cmdCancel.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdCancel.Image = CType(resources.GetObject("cmdCancel.Image"), System.Drawing.Image)
        Me.cmdCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdCancel.Location = New System.Drawing.Point(196, 211)
        Me.cmdCancel.Name = "cmdCancel"
        Me.cmdCancel.Size = New System.Drawing.Size(89, 37)
        Me.cmdCancel.TabIndex = 129
        Me.cmdCancel.Text = "    &Close"
        Me.cmdCancel.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(104, 211)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(89, 37)
        Me.cmdClear.TabIndex = 128
        Me.cmdClear.Text = "    C&lear"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(11, 211)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(89, 37)
        Me.cmdEdit.TabIndex = 127
        Me.cmdEdit.Text = "&Update"
        Me.cmdEdit.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'txtPOB
        '
        Me.txtPOB.BackColor = System.Drawing.Color.White
        Me.txtPOB.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtPOB.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtPOB.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPOB.Location = New System.Drawing.Point(137, 120)
        Me.txtPOB.Name = "txtPOB"
        Me.txtPOB.Size = New System.Drawing.Size(121, 23)
        Me.txtPOB.TabIndex = 123
        '
        'txtUserName
        '
        Me.txtUserName.BackColor = System.Drawing.Color.White
        Me.txtUserName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtUserName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtUserName.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Location = New System.Drawing.Point(137, 46)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Size = New System.Drawing.Size(121, 23)
        Me.txtUserName.TabIndex = 121
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 121)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 18)
        Me.Label3.TabIndex = 132
        Me.Label3.Text = "Place of Birth :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(39, 84)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 18)
        Me.Label2.TabIndex = 131
        Me.Label2.Text = "Date of Birth :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(51, 47)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(82, 18)
        Me.label1.TabIndex = 130
        Me.label1.Text = "Your Name :"
        '
        'txtEmailID
        '
        Me.txtEmailID.BackColor = System.Drawing.Color.White
        Me.txtEmailID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmailID.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower
        Me.txtEmailID.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmailID.Location = New System.Drawing.Point(137, 157)
        Me.txtEmailID.Name = "txtEmailID"
        Me.txtEmailID.Size = New System.Drawing.Size(121, 23)
        Me.txtEmailID.TabIndex = 124
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(68, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 18)
        Me.Label4.TabIndex = 134
        Me.Label4.Text = "Email ID :"
        '
        'dtpDOB
        '
        Me.dtpDOB.CustomFormat = "dd/MMM/yyyy"
        Me.dtpDOB.Font = New System.Drawing.Font("Palatino Linotype", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtpDOB.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpDOB.Location = New System.Drawing.Point(137, 81)
        Me.dtpDOB.Name = "dtpDOB"
        Me.dtpDOB.Size = New System.Drawing.Size(121, 24)
        Me.dtpDOB.TabIndex = 135
        '
        'ChangeInfo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(516, 258)
        Me.Controls.Add(Me.dtpDOB)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.BRemove)
        Me.Controls.Add(Me.BBrowse)
        Me.Controls.Add(Me.cmdCancel)
        Me.Controls.Add(Me.cmdClear)
        Me.Controls.Add(Me.cmdEdit)
        Me.Controls.Add(Me.txtPOB)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.label1)
        Me.Controls.Add(Me.txtEmailID)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangeInfo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Info"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.EmpPic, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents BRemove As System.Windows.Forms.Button
    Friend WithEvents BBrowse As System.Windows.Forms.Button
    Private WithEvents cmdCancel As System.Windows.Forms.Button
    Private WithEvents cmdClear As System.Windows.Forms.Button
    Private WithEvents cmdEdit As System.Windows.Forms.Button
    Private WithEvents txtPOB As System.Windows.Forms.TextBox
    Private WithEvents txtUserName As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
    Private WithEvents txtEmailID As System.Windows.Forms.TextBox
    Private WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents dtpDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents EmpPic As System.Windows.Forms.PictureBox
End Class
