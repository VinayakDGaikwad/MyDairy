'Panel Main - Location 120,24
'Panel Main - Size 290,210
'Flat button color=255, 128, 0
Public Class fohyperlink
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents buttonflt1 As gscore10.gsflatxp
    Friend WithEvents buttonflt2 As gscore10.gsflatxp
    Friend WithEvents Panelweb As System.Windows.Forms.Panel
    Friend WithEvents Panelemail As System.Windows.Forms.Panel
    Friend WithEvents MyXPButton1 As gsxpbut10.MyXPButton
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents weblinktextbox As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents emailtextbox As System.Windows.Forms.TextBox
    Friend WithEvents subjecttextbox As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents opt1 As System.Windows.Forms.Label
    Friend WithEvents opt2 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(fohyperlink))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.buttonflt2 = New gscore10.gsflatxp()
        Me.buttonflt1 = New gscore10.gsflatxp()
        Me.Panelweb = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.weblinktextbox = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.MyXPButton1 = New gsxpbut10.MyXPButton()
        Me.Panelemail = New System.Windows.Forms.Panel()
        Me.subjecttextbox = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.emailtextbox = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.opt1 = New System.Windows.Forms.Label()
        Me.opt2 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        Me.Panelweb.SuspendLayout()
        Me.Panelemail.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(56, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Link To:"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Panel1.Controls.AddRange(New System.Windows.Forms.Control() {Me.buttonflt2, Me.buttonflt1})
        Me.Panel1.Location = New System.Drawing.Point(32, 24)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(84, 200)
        Me.Panel1.TabIndex = 3
        '
        'buttonflt2
        '
        Me.buttonflt2.BackColorDown = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte))
        Me.buttonflt2.BackColorFocus = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.buttonflt2.BorderColor = System.Drawing.SystemColors.Control
        Me.buttonflt2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonflt2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonflt2.Location = New System.Drawing.Point(0, 77)
        Me.buttonflt2.Name = "buttonflt2"
        Me.buttonflt2.ShowFocus = True
        Me.buttonflt2.Size = New System.Drawing.Size(78, 64)
        Me.buttonflt2.TabIndex = 1
        Me.buttonflt2.Text = "E-&mail Address"
        Me.buttonflt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'buttonflt1
        '
        Me.buttonflt1.BackColorDown = System.Drawing.Color.FromArgb(CType(255, Byte), CType(128, Byte), CType(0, Byte))
        Me.buttonflt1.BackColorFocus = System.Drawing.Color.FromArgb(CType(255, Byte), CType(224, Byte), CType(192, Byte))
        Me.buttonflt1.BorderColor = System.Drawing.SystemColors.Control
        Me.buttonflt1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.buttonflt1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.buttonflt1.Location = New System.Drawing.Point(1, 1)
        Me.buttonflt1.Name = "buttonflt1"
        Me.buttonflt1.ShowFocus = True
        Me.buttonflt1.Size = New System.Drawing.Size(78, 64)
        Me.buttonflt1.TabIndex = 0
        Me.buttonflt1.Text = "E&xisting File    or       Webpage"
        Me.buttonflt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panelweb
        '
        Me.Panelweb.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label2, Me.weblinktextbox, Me.Label4, Me.MyXPButton1})
        Me.Panelweb.Location = New System.Drawing.Point(120, 24)
        Me.Panelweb.Name = "Panelweb"
        Me.Panelweb.Size = New System.Drawing.Size(290, 210)
        Me.Panelweb.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(16, 152)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(241, 14)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "(Type a Website address or choose a file)"
        '
        'weblinktextbox
        '
        Me.weblinktextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.weblinktextbox.Location = New System.Drawing.Point(16, 48)
        Me.weblinktextbox.Name = "weblinktextbox"
        Me.weblinktextbox.Size = New System.Drawing.Size(248, 21)
        Me.weblinktextbox.TabIndex = 4
        Me.weblinktextbox.Text = ""
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 14)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "File or Web Link:"
        '
        'MyXPButton1
        '
        Me.MyXPButton1.AdjustImageLocation = New System.Drawing.Point(0, 0)
        Me.MyXPButton1.BtnShape = gsxpbut10.BtnShape.Rectangle
        Me.MyXPButton1.BtnStyle = gsxpbut10.XPStyle.Default
        Me.MyXPButton1.Location = New System.Drawing.Point(192, 88)
        Me.MyXPButton1.Name = "MyXPButton1"
        Me.MyXPButton1.Size = New System.Drawing.Size(64, 40)
        Me.MyXPButton1.TabIndex = 0
        Me.MyXPButton1.Text = "Choose a File..."
        '
        'Panelemail
        '
        Me.Panelemail.Controls.AddRange(New System.Windows.Forms.Control() {Me.subjecttextbox, Me.Label5, Me.emailtextbox, Me.Label3})
        Me.Panelemail.Location = New System.Drawing.Point(424, 64)
        Me.Panelemail.Name = "Panelemail"
        Me.Panelemail.Size = New System.Drawing.Size(290, 210)
        Me.Panelemail.TabIndex = 5
        Me.Panelemail.Visible = False
        '
        'subjecttextbox
        '
        Me.subjecttextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.subjecttextbox.Location = New System.Drawing.Point(9, 128)
        Me.subjecttextbox.Multiline = True
        Me.subjecttextbox.Name = "subjecttextbox"
        Me.subjecttextbox.Size = New System.Drawing.Size(272, 20)
        Me.subjecttextbox.TabIndex = 3
        Me.subjecttextbox.Text = ""
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 96)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(52, 14)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Subject:"
        '
        'emailtextbox
        '
        Me.emailtextbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.emailtextbox.Location = New System.Drawing.Point(8, 56)
        Me.emailtextbox.Multiline = True
        Me.emailtextbox.Name = "emailtextbox"
        Me.emailtextbox.Size = New System.Drawing.Size(272, 20)
        Me.emailtextbox.TabIndex = 1
        Me.emailtextbox.Text = ""
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(8, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(92, 14)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "E-Mail address:"
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(232, 248)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "&Ok"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(320, 248)
        Me.Button2.Name = "Button2"
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "&Cancel"
        '
        'opt1
        '
        Me.opt1.BackColor = System.Drawing.SystemColors.ControlDark
        Me.opt1.Location = New System.Drawing.Point(16, 24)
        Me.opt1.Name = "opt1"
        Me.opt1.Size = New System.Drawing.Size(16, 72)
        Me.opt1.TabIndex = 10
        Me.opt1.Text = ">"
        Me.opt1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.opt1.Visible = False
        '
        'opt2
        '
        Me.opt2.BackColor = System.Drawing.SystemColors.ControlDark
        Me.opt2.Location = New System.Drawing.Point(16, 102)
        Me.opt2.Name = "opt2"
        Me.opt2.Size = New System.Drawing.Size(16, 72)
        Me.opt2.TabIndex = 11
        Me.opt2.Text = ">"
        Me.opt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.opt2.Visible = False
        '
        'fohyperlink
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(442, 280)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.opt2, Me.opt1, Me.Button2, Me.Button1, Me.Panelweb, Me.Panel1, Me.Label1, Me.Panelemail})
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "fohyperlink"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Insert Hyperlink"
        Me.Panel1.ResumeLayout(False)
        Me.Panelweb.ResumeLayout(False)
        Me.Panelemail.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim isemaildown As Boolean
    Dim iswebdown As Boolean

    Private Shared m_vb6FormDefInstance As fohyperlink
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As fohyperlink
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New fohyperlink()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As fohyperlink)
            m_vb6FormDefInstance = Value
        End Set
    End Property

    Private Sub fohyperlink_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        iswebdown = True
        isemaildown = False
        opt1.Visible = True
        Panelweb.Visible = True
        Panelemail.Visible = False
        Panelweb.Location = New System.Drawing.Point(120, 24)
        Panelemail.Location = New System.Drawing.Point(120, 24)
    End Sub

    Private Sub buttonflt1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonflt1.Click
        iswebdown = True
        isemaildown = False
        opt1.Visible = True
        opt2.Visible = False
        Panelweb.Visible = True
        Panelemail.Visible = False
        Panelweb.Location = New System.Drawing.Point(120, 24)
        Panelemail.Location = New System.Drawing.Point(120, 24)
        If weblinktextbox.Text = "" Then
            Button1.Enabled = False
            Exit Sub
        End If
        Button1.Enabled = True
    End Sub

    Private Sub buttonflt2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles buttonflt2.Click
        iswebdown = False
        isemaildown = True
        opt1.Visible = False
        opt2.Visible = True
        Panelweb.Visible = False
        Panelemail.Visible = True
        Panelweb.Location = New System.Drawing.Point(120, 24)
        Panelemail.Location = New System.Drawing.Point(120, 24)
        If emailtextbox.Text = "" Then
            Button1.Enabled = False
            Exit Sub
        End If
        Button1.Enabled = True
    End Sub

    Private Sub weblinktextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles weblinktextbox.TextChanged
        Button1.Enabled = True
        If weblinktextbox.Text = "" Then
            Button1.Enabled = False
        End If
    End Sub

    Private Sub emailtextbox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles emailtextbox.TextChanged
        Button1.Enabled = True
        If emailtextbox.Text = "" Then
            Button1.Enabled = False
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If opt1.Visible = True Then
            addweborfilelink()
            Exit Sub
        End If
        If opt2.Visible = True Then
            addemaillink()
            Exit Sub
        End If
    End Sub

    Private Sub addweborfilelink()
        foform1.DefInstance.text1.SelectedText = weblinktextbox.Text
        Me.Close()
    End Sub

    Private Sub addemaillink()
        Dim emtext As String, subtext As String
        If subjecttextbox.Text = "" Then
            nosubject()
            Exit Sub
        End If
        emtext = emailtextbox.Text
        subtext = subjecttextbox.Text
        foform1.DefInstance.text1.SelectedText = "mailto:" & emtext & "?Subject=" & subtext
        Me.Close()
    End Sub

    Private Sub nosubject()
        Dim emtext As String
        emtext = emailtextbox.Text
        foform1.DefInstance.text1.SelectedText = "mailto:" & emtext
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class
