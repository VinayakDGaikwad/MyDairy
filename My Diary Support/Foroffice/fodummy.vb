Public Class fodummy
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
    Friend WithEvents meaning1 As System.Windows.Forms.TextBox
    Friend WithEvents meaning2 As System.Windows.Forms.TextBox
    Friend WithEvents grammar As System.Windows.Forms.TextBox
    Friend WithEvents saved As System.Windows.Forms.TextBox
    Friend WithEvents path As System.Windows.Forms.TextBox
    Friend WithEvents underline As System.Windows.Forms.TextBox
    Friend WithEvents bold As System.Windows.Forms.TextBox
    Friend WithEvents italic As System.Windows.Forms.TextBox
    Friend WithEvents strikeout As System.Windows.Forms.TextBox
    Friend WithEvents er As System.Windows.Forms.TextBox
    Friend WithEvents st1 As System.Windows.Forms.PictureBox
    Friend WithEvents st2 As System.Windows.Forms.PictureBox
    Friend WithEvents st3 As System.Windows.Forms.PictureBox
    Friend WithEvents st4 As System.Windows.Forms.PictureBox
    Friend WithEvents rectangle As System.Windows.Forms.PictureBox
    Friend WithEvents circle As System.Windows.Forms.PictureBox
    Friend WithEvents star As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(fodummy))
        Me.meaning1 = New System.Windows.Forms.TextBox()
        Me.meaning2 = New System.Windows.Forms.TextBox()
        Me.grammar = New System.Windows.Forms.TextBox()
        Me.saved = New System.Windows.Forms.TextBox()
        Me.path = New System.Windows.Forms.TextBox()
        Me.underline = New System.Windows.Forms.TextBox()
        Me.bold = New System.Windows.Forms.TextBox()
        Me.italic = New System.Windows.Forms.TextBox()
        Me.strikeout = New System.Windows.Forms.TextBox()
        Me.er = New System.Windows.Forms.TextBox()
        Me.st1 = New System.Windows.Forms.PictureBox()
        Me.st2 = New System.Windows.Forms.PictureBox()
        Me.st3 = New System.Windows.Forms.PictureBox()
        Me.st4 = New System.Windows.Forms.PictureBox()
        Me.rectangle = New System.Windows.Forms.PictureBox()
        Me.circle = New System.Windows.Forms.PictureBox()
        Me.star = New System.Windows.Forms.PictureBox()
        Me.SuspendLayout()
        '
        'meaning1
        '
        Me.meaning1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.meaning1.Location = New System.Drawing.Point(27, 25)
        Me.meaning1.Name = "meaning1"
        Me.meaning1.TabIndex = 0
        Me.meaning1.Text = ""
        '
        'meaning2
        '
        Me.meaning2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.meaning2.Location = New System.Drawing.Point(26, 61)
        Me.meaning2.Name = "meaning2"
        Me.meaning2.TabIndex = 1
        Me.meaning2.Text = ""
        '
        'grammar
        '
        Me.grammar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.grammar.Location = New System.Drawing.Point(24, 99)
        Me.grammar.Name = "grammar"
        Me.grammar.TabIndex = 2
        Me.grammar.Text = ""
        '
        'saved
        '
        Me.saved.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.saved.Location = New System.Drawing.Point(141, 28)
        Me.saved.Name = "saved"
        Me.saved.TabIndex = 3
        Me.saved.Text = ""
        '
        'path
        '
        Me.path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.path.Location = New System.Drawing.Point(142, 57)
        Me.path.Name = "path"
        Me.path.TabIndex = 4
        Me.path.Text = ""
        '
        'underline
        '
        Me.underline.Location = New System.Drawing.Point(119, 270)
        Me.underline.Name = "underline"
        Me.underline.TabIndex = 5
        Me.underline.Text = ""
        '
        'bold
        '
        Me.bold.Location = New System.Drawing.Point(127, 216)
        Me.bold.Name = "bold"
        Me.bold.TabIndex = 6
        Me.bold.Text = ""
        '
        'italic
        '
        Me.italic.Location = New System.Drawing.Point(126, 245)
        Me.italic.Name = "italic"
        Me.italic.TabIndex = 7
        Me.italic.Text = ""
        '
        'strikeout
        '
        Me.strikeout.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.strikeout.Location = New System.Drawing.Point(127, 294)
        Me.strikeout.Name = "strikeout"
        Me.strikeout.TabIndex = 8
        Me.strikeout.Text = ""
        '
        'er
        '
        Me.er.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.er.Location = New System.Drawing.Point(27, 145)
        Me.er.Name = "er"
        Me.er.TabIndex = 9
        Me.er.Text = ""
        '
        'st1
        '
        Me.st1.Image = CType(resources.GetObject("st1.Image"), System.Drawing.Bitmap)
        Me.st1.Location = New System.Drawing.Point(392, 16)
        Me.st1.Name = "st1"
        Me.st1.Size = New System.Drawing.Size(16, 16)
        Me.st1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.st1.TabIndex = 10
        Me.st1.TabStop = False
        '
        'st2
        '
        Me.st2.Image = CType(resources.GetObject("st2.Image"), System.Drawing.Bitmap)
        Me.st2.Location = New System.Drawing.Point(392, 40)
        Me.st2.Name = "st2"
        Me.st2.Size = New System.Drawing.Size(16, 16)
        Me.st2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.st2.TabIndex = 11
        Me.st2.TabStop = False
        '
        'st3
        '
        Me.st3.Image = CType(resources.GetObject("st3.Image"), System.Drawing.Bitmap)
        Me.st3.Location = New System.Drawing.Point(392, 64)
        Me.st3.Name = "st3"
        Me.st3.Size = New System.Drawing.Size(16, 16)
        Me.st3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.st3.TabIndex = 12
        Me.st3.TabStop = False
        '
        'st4
        '
        Me.st4.Image = CType(resources.GetObject("st4.Image"), System.Drawing.Bitmap)
        Me.st4.Location = New System.Drawing.Point(392, 88)
        Me.st4.Name = "st4"
        Me.st4.Size = New System.Drawing.Size(16, 16)
        Me.st4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.st4.TabIndex = 13
        Me.st4.TabStop = False
        '
        'rectangle
        '
        Me.rectangle.Image = CType(resources.GetObject("rectangle.Image"), System.Drawing.Bitmap)
        Me.rectangle.Location = New System.Drawing.Point(288, 152)
        Me.rectangle.Name = "rectangle"
        Me.rectangle.Size = New System.Drawing.Size(80, 64)
        Me.rectangle.TabIndex = 14
        Me.rectangle.TabStop = False
        '
        'circle
        '
        Me.circle.Image = CType(resources.GetObject("circle.Image"), System.Drawing.Bitmap)
        Me.circle.Location = New System.Drawing.Point(296, 248)
        Me.circle.Name = "circle"
        Me.circle.TabIndex = 15
        Me.circle.TabStop = False
        '
        'star
        '
        Me.star.Image = CType(resources.GetObject("star.Image"), System.Drawing.Bitmap)
        Me.star.Location = New System.Drawing.Point(400, 144)
        Me.star.Name = "star"
        Me.star.Size = New System.Drawing.Size(56, 64)
        Me.star.TabIndex = 16
        Me.star.TabStop = False
        '
        'fodummy
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.FromArgb(CType(250, Byte), CType(250, Byte), CType(250, Byte))
        Me.ClientSize = New System.Drawing.Size(467, 346)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.star, Me.circle, Me.rectangle, Me.st4, Me.st3, Me.st2, Me.st1, Me.er, Me.strikeout, Me.italic, Me.bold, Me.underline, Me.path, Me.saved, Me.grammar, Me.meaning2, Me.meaning1})
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fodummy"
        Me.Text = "fodummy"
        Me.ResumeLayout(False)

    End Sub

#End Region
    ''----------Office xp color--------
    ''sbcolor = Color.FromKnownColor(KnownColor.Control)
    '' selcolorofmenu = Color.FromArgb(255, 193, 210, 238)
    ''bgcolorofmenu = Color.FromArgb(255, 251, 251, 251)
    'Hover color of the selected menu
    'Dim selcolorofmenu As Color
    'selcolorofmenu = Color.FromArgb(255, 193, 210, 238)
    'Dim selbrush As New SolidBrush(selcolorofmenu)
    ''------------------------------------->
    ''---------2003 color----------------===========
    ''        Dim sb1 As Color
    ''sb1 = Color.FromArgb(255, 225, 240, 255)
    ''Dim sb2 As Color
    ''sb2 = Color.FromArgb(255, 139, 177, 231)
    ''bg same as xp
    ''hover peachpuff
    ''---------------------=====================>>>>
    'Background color of the normal menu
    Private Shared m_vb6FormDefInstance As fodummy
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As fodummy
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New fodummy()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As fodummy)
            m_vb6FormDefInstance = Value
        End Set
    End Property

    Private Sub fodummy_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
