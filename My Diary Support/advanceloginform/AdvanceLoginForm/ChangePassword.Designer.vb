<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ChangePassword))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtNewPass = New System.Windows.Forms.TextBox()
        Me.cmdClose = New System.Windows.Forms.Button()
        Me.cmdClear = New System.Windows.Forms.Button()
        Me.cmdEdit = New System.Windows.Forms.Button()
        Me.txtConformPass = New System.Windows.Forms.TextBox()
        Me.txtOldPass = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtNewPass)
        Me.GroupBox1.Controls.Add(Me.cmdClose)
        Me.GroupBox1.Controls.Add(Me.cmdClear)
        Me.GroupBox1.Controls.Add(Me.cmdEdit)
        Me.GroupBox1.Controls.Add(Me.txtConformPass)
        Me.GroupBox1.Controls.Add(Me.txtOldPass)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(9, 2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(316, 193)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        '
        'TxtNewPass
        '
        Me.TxtNewPass.BackColor = System.Drawing.Color.White
        Me.TxtNewPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TxtNewPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.TxtNewPass.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNewPass.Location = New System.Drawing.Point(165, 61)
        Me.TxtNewPass.Name = "TxtNewPass"
        Me.TxtNewPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TxtNewPass.Size = New System.Drawing.Size(121, 23)
        Me.TxtNewPass.TabIndex = 127
        '
        'cmdClose
        '
        Me.cmdClose.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClose.Image = CType(resources.GetObject("cmdClose.Image"), System.Drawing.Image)
        Me.cmdClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClose.Location = New System.Drawing.Point(207, 142)
        Me.cmdClose.Name = "cmdClose"
        Me.cmdClose.Size = New System.Drawing.Size(89, 37)
        Me.cmdClose.TabIndex = 131
        Me.cmdClose.Text = "    Cl&ose"
        Me.cmdClose.UseVisualStyleBackColor = True
        '
        'cmdClear
        '
        Me.cmdClear.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdClear.Image = CType(resources.GetObject("cmdClear.Image"), System.Drawing.Image)
        Me.cmdClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdClear.Location = New System.Drawing.Point(114, 142)
        Me.cmdClear.Name = "cmdClear"
        Me.cmdClear.Size = New System.Drawing.Size(89, 37)
        Me.cmdClear.TabIndex = 130
        Me.cmdClear.Text = "    Clea&r"
        Me.cmdClear.UseVisualStyleBackColor = True
        '
        'cmdEdit
        '
        Me.cmdEdit.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdEdit.Image = CType(resources.GetObject("cmdEdit.Image"), System.Drawing.Image)
        Me.cmdEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.cmdEdit.Location = New System.Drawing.Point(21, 142)
        Me.cmdEdit.Name = "cmdEdit"
        Me.cmdEdit.Size = New System.Drawing.Size(89, 37)
        Me.cmdEdit.TabIndex = 129
        Me.cmdEdit.Text = "         &Update"
        Me.cmdEdit.UseVisualStyleBackColor = True
        '
        'txtConformPass
        '
        Me.txtConformPass.BackColor = System.Drawing.Color.White
        Me.txtConformPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtConformPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtConformPass.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtConformPass.Location = New System.Drawing.Point(165, 98)
        Me.txtConformPass.Name = "txtConformPass"
        Me.txtConformPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConformPass.Size = New System.Drawing.Size(121, 23)
        Me.txtConformPass.TabIndex = 128
        '
        'txtOldPass
        '
        Me.txtOldPass.BackColor = System.Drawing.Color.White
        Me.txtOldPass.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtOldPass.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtOldPass.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOldPass.Location = New System.Drawing.Point(165, 24)
        Me.txtOldPass.Name = "txtOldPass"
        Me.txtOldPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPass.Size = New System.Drawing.Size(121, 23)
        Me.txtOldPass.TabIndex = 126
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(30, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 18)
        Me.Label3.TabIndex = 134
        Me.Label3.Text = "Conform Password :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(56, 61)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(106, 18)
        Me.Label2.TabIndex = 133
        Me.Label2.Text = "New Password :"
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Calibri", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(70, 24)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(91, 18)
        Me.label1.TabIndex = 132
        Me.label1.Text = "Old Passwor :"
        '
        'ChangePassword
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(335, 202)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Private WithEvents TxtNewPass As System.Windows.Forms.TextBox
    Private WithEvents cmdClose As System.Windows.Forms.Button
    Private WithEvents cmdClear As System.Windows.Forms.Button
    Private WithEvents cmdEdit As System.Windows.Forms.Button
    Private WithEvents txtConformPass As System.Windows.Forms.TextBox
    Private WithEvents txtOldPass As System.Windows.Forms.TextBox
    Private WithEvents Label3 As System.Windows.Forms.Label
    Private WithEvents Label2 As System.Windows.Forms.Label
    Private WithEvents label1 As System.Windows.Forms.Label
End Class
