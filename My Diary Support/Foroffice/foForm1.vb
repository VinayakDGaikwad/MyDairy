'Top toolbar off03blue color =220, 230, 254
'Bottom toolbar off03blue color=129, 169, 226
'Toolbar back color =195,217,249
Imports System.Drawing.Printing
Public Class foform1
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
    Friend WithEvents cmtext As System.Windows.Forms.ContextMenu
    Private WithEvents il2 As System.Windows.Forms.ImageList
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents taskpane As System.Windows.Forms.Panel
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents toolbar1 As System.Windows.Forms.Panel
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents cmca As System.Windows.Forms.ContextMenu
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents FontDialog1 As System.Windows.Forms.FontDialog
    Friend WithEvents ColorDialog1 As System.Windows.Forms.ColorDialog
    Friend WithEvents text2 As System.Windows.Forms.TextBox
    Friend WithEvents mea As System.Windows.Forms.ContextMenu
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents stag1 As System.Windows.Forms.Button
    Friend WithEvents text3 As System.Windows.Forms.TextBox
    Friend WithEvents tagm1 As System.Windows.Forms.ContextMenu
    Friend WithEvents stlabel1 As System.Windows.Forms.Label
    Friend WithEvents stpanel1 As System.Windows.Forms.Panel
    Friend WithEvents taganim1 As System.Windows.Forms.Timer
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents toolbar As gscore10.gsverlb1
    Friend WithEvents tptitle As gscore10.gsverlb1
    Friend WithEvents caadv As gscore10.gshorlb1
    Friend WithEvents panelcontent As System.Windows.Forms.Panel
    Friend WithEvents panelruler As System.Windows.Forms.Panel
    Friend WithEvents paneltopruler As System.Windows.Forms.Panel
    Friend WithEvents panel2filler As System.Windows.Forms.Panel
    Friend WithEvents Panel3fill As System.Windows.Forms.Panel
    Friend WithEvents bnew As gscore10.gsflatxp
    Friend WithEvents bopen As gscore10.gsflatxp
    Friend WithEvents bsave As gscore10.gsflatxp
    Friend WithEvents sbbar As System.Windows.Forms.Panel
    Friend WithEvents statusdone As gscore10.gsflatxp
    Friend WithEvents panelingrammar As System.Windows.Forms.Panel
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents textsearch As System.Windows.Forms.TextBox
    Friend WithEvents searchgo As gscore10.gsflatxp
    Friend WithEvents panelcontsearch As System.Windows.Forms.Panel
    Friend WithEvents paneloutputgrammar As System.Windows.Forms.Panel
    Friend WithEvents fopath As System.Windows.Forms.TextBox
    Friend WithEvents fosaved As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents word As System.Windows.Forms.Label
    Friend WithEvents mean1 As System.Windows.Forms.Label
    Friend WithEvents mean2 As System.Windows.Forms.Label
    Friend WithEvents gram As System.Windows.Forms.Label
    Friend WithEvents amean1 As gscore10.gsflatxp
    Friend WithEvents amean2 As gscore10.gsflatxp
    Friend WithEvents Paneltext As System.Windows.Forms.Panel
    Friend WithEvents researchm1 As System.Windows.Forms.ContextMenu
    Friend WithEvents researchm2 As System.Windows.Forms.ContextMenu
    Friend WithEvents bgtp1 As gscore10.gsverlb1
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents exttbmain1 As gscore10.gsverlb1
    Friend WithEvents bcut As gscore10.gsflatxp
    Friend WithEvents sepcut11 As System.Windows.Forms.Label
    Friend WithEvents text1 As Gurustedrtb.Windows.Forms.RichEditBox
    Friend WithEvents PageSetupDialog1 As System.Windows.Forms.PageSetupDialog
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents PrintDialog1 As System.Windows.Forms.PrintDialog
    Friend WithEvents miscil1 As System.Windows.Forms.ImageList
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Panelhelp As System.Windows.Forms.Panel
    Friend WithEvents Labelleft As System.Windows.Forms.Label
    Friend WithEvents helpim1 As System.Windows.Forms.ImageList
    Friend WithEvents helpview1 As System.Windows.Forms.TreeView
    Friend WithEvents bcopy As gscore10.gsflatxp
    Friend WithEvents bpaste As gscore10.gsflatxp
    Friend WithEvents sep12 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(foform1))
        Dim TreeNode1 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node2", 1, 1)
        Dim TreeNode2 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node5", 1, 1)
        Dim TreeNode3 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node1", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode1, TreeNode2})
        Dim TreeNode4 As System.Windows.Forms.TreeNode = New System.Windows.Forms.TreeNode("Node0", 0, 0, New System.Windows.Forms.TreeNode() {TreeNode3})
        Me.cmtext = New System.Windows.Forms.ContextMenu()
        Me.il2 = New System.Windows.Forms.ImageList(Me.components)
        Me.MainMenu1 = New System.Windows.Forms.MainMenu(Me.components)
        Me.taskpane = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Panelhelp = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.helpview1 = New System.Windows.Forms.TreeView()
        Me.helpim1 = New System.Windows.Forms.ImageList(Me.components)
        Me.panelingrammar = New System.Windows.Forms.Panel()
        Me.paneloutputgrammar = New System.Windows.Forms.Panel()
        Me.amean2 = New gscore10.gsflatxp()
        Me.amean1 = New gscore10.gsflatxp()
        Me.gram = New System.Windows.Forms.Label()
        Me.mean2 = New System.Windows.Forms.Label()
        Me.mean1 = New System.Windows.Forms.Label()
        Me.word = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.panelcontsearch = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.textsearch = New System.Windows.Forms.TextBox()
        Me.searchgo = New gscore10.gsflatxp()
        Me.caadv = New gscore10.gshorlb1()
        Me.tptitle = New gscore10.gsverlb1()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.bgtp1 = New gscore10.gsverlb1()
        Me.text2 = New System.Windows.Forms.TextBox()
        Me.toolbar1 = New System.Windows.Forms.Panel()
        Me.sep12 = New System.Windows.Forms.Label()
        Me.bpaste = New gscore10.gsflatxp()
        Me.bcopy = New gscore10.gsflatxp()
        Me.sepcut11 = New System.Windows.Forms.Label()
        Me.bcut = New gscore10.gsflatxp()
        Me.bsave = New gscore10.gsflatxp()
        Me.bopen = New gscore10.gsflatxp()
        Me.bnew = New gscore10.gsflatxp()
        Me.text3 = New System.Windows.Forms.TextBox()
        Me.toolbar = New gscore10.gsverlb1()
        Me.exttbmain1 = New gscore10.gsverlb1()
        Me.cmca = New System.Windows.Forms.ContextMenu()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog()
        Me.FontDialog1 = New System.Windows.Forms.FontDialog()
        Me.ColorDialog1 = New System.Windows.Forms.ColorDialog()
        Me.mea = New System.Windows.Forms.ContextMenu()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.stag1 = New System.Windows.Forms.Button()
        Me.tagm1 = New System.Windows.Forms.ContextMenu()
        Me.stlabel1 = New System.Windows.Forms.Label()
        Me.stpanel1 = New System.Windows.Forms.Panel()
        Me.taganim1 = New System.Windows.Forms.Timer(Me.components)
        Me.panelruler = New System.Windows.Forms.Panel()
        Me.panelcontent = New System.Windows.Forms.Panel()
        Me.panel2filler = New System.Windows.Forms.Panel()
        Me.Panel3fill = New System.Windows.Forms.Panel()
        Me.Paneltext = New System.Windows.Forms.Panel()
        Me.text1 = New Gurustedrtb.Windows.Forms.RichEditBox()
        Me.Labelleft = New System.Windows.Forms.Label()
        Me.paneltopruler = New System.Windows.Forms.Panel()
        Me.sbbar = New System.Windows.Forms.Panel()
        Me.statusdone = New gscore10.gsflatxp()
        Me.fosaved = New System.Windows.Forms.TextBox()
        Me.fopath = New System.Windows.Forms.TextBox()
        Me.researchm1 = New System.Windows.Forms.ContextMenu()
        Me.researchm2 = New System.Windows.Forms.ContextMenu()
        Me.PageSetupDialog1 = New System.Windows.Forms.PageSetupDialog()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.PrintDialog1 = New System.Windows.Forms.PrintDialog()
        Me.miscil1 = New System.Windows.Forms.ImageList(Me.components)
        Me.taskpane.SuspendLayout()
        Me.Panelhelp.SuspendLayout()
        Me.panelingrammar.SuspendLayout()
        Me.paneloutputgrammar.SuspendLayout()
        Me.panelcontsearch.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.toolbar1.SuspendLayout()
        Me.stpanel1.SuspendLayout()
        Me.panelcontent.SuspendLayout()
        Me.panel2filler.SuspendLayout()
        Me.Panel3fill.SuspendLayout()
        Me.Paneltext.SuspendLayout()
        Me.sbbar.SuspendLayout()
        Me.SuspendLayout()
        '
        'il2
        '
        Me.il2.ImageStream = CType(resources.GetObject("il2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.il2.TransparentColor = System.Drawing.Color.Transparent
        Me.il2.Images.SetKeyName(0, "")
        Me.il2.Images.SetKeyName(1, "")
        Me.il2.Images.SetKeyName(2, "")
        Me.il2.Images.SetKeyName(3, "")
        Me.il2.Images.SetKeyName(4, "")
        Me.il2.Images.SetKeyName(5, "")
        Me.il2.Images.SetKeyName(6, "")
        Me.il2.Images.SetKeyName(7, "")
        Me.il2.Images.SetKeyName(8, "")
        Me.il2.Images.SetKeyName(9, "")
        Me.il2.Images.SetKeyName(10, "")
        Me.il2.Images.SetKeyName(11, "")
        Me.il2.Images.SetKeyName(12, "")
        Me.il2.Images.SetKeyName(13, "")
        Me.il2.Images.SetKeyName(14, "")
        Me.il2.Images.SetKeyName(15, "")
        Me.il2.Images.SetKeyName(16, "")
        Me.il2.Images.SetKeyName(17, "")
        Me.il2.Images.SetKeyName(18, "")
        Me.il2.Images.SetKeyName(19, "")
        Me.il2.Images.SetKeyName(20, "")
        Me.il2.Images.SetKeyName(21, "")
        Me.il2.Images.SetKeyName(22, "")
        Me.il2.Images.SetKeyName(23, "")
        Me.il2.Images.SetKeyName(24, "")
        Me.il2.Images.SetKeyName(25, "")
        Me.il2.Images.SetKeyName(26, "")
        Me.il2.Images.SetKeyName(27, "")
        Me.il2.Images.SetKeyName(28, "")
        Me.il2.Images.SetKeyName(29, "")
        Me.il2.Images.SetKeyName(30, "")
        Me.il2.Images.SetKeyName(31, "")
        '
        'taskpane
        '
        Me.taskpane.AutoScroll = True
        Me.taskpane.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.taskpane.Controls.Add(Me.Label8)
        Me.taskpane.Controls.Add(Me.Label7)
        Me.taskpane.Controls.Add(Me.Panelhelp)
        Me.taskpane.Controls.Add(Me.panelingrammar)
        Me.taskpane.Controls.Add(Me.caadv)
        Me.taskpane.Controls.Add(Me.tptitle)
        Me.taskpane.Controls.Add(Me.Label11)
        Me.taskpane.Controls.Add(Me.Label4)
        Me.taskpane.Controls.Add(Me.Label3)
        Me.taskpane.Controls.Add(Me.Label2)
        Me.taskpane.Controls.Add(Me.Label1)
        Me.taskpane.Controls.Add(Me.PictureBox1)
        Me.taskpane.Controls.Add(Me.bgtp1)
        Me.taskpane.Dock = System.Windows.Forms.DockStyle.Right
        Me.taskpane.Location = New System.Drawing.Point(596, 0)
        Me.taskpane.Name = "taskpane"
        Me.taskpane.Size = New System.Drawing.Size(216, 333)
        Me.taskpane.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label8.Location = New System.Drawing.Point(5, 375)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(187, 3)
        Me.Label8.TabIndex = 23
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.SteelBlue
        Me.Label7.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.LightCyan
        Me.Label7.Location = New System.Drawing.Point(5, 360)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(187, 14)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Help"
        '
        'Panelhelp
        '
        Me.Panelhelp.AutoScroll = True
        Me.Panelhelp.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panelhelp.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panelhelp.Controls.Add(Me.Label9)
        Me.Panelhelp.Controls.Add(Me.helpview1)
        Me.Panelhelp.Location = New System.Drawing.Point(8, 384)
        Me.Panelhelp.Name = "Panelhelp"
        Me.Panelhelp.Size = New System.Drawing.Size(184, 160)
        Me.Panelhelp.TabIndex = 21
        '
        'Label9
        '
        Me.Label9.Location = New System.Drawing.Point(26, 36)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(110, 35)
        Me.Label9.TabIndex = 2
        Me.Label9.Text = "Currently under development"
        '
        'helpview1
        '
        Me.helpview1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.helpview1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.helpview1.ForeColor = System.Drawing.Color.Blue
        Me.helpview1.ImageIndex = 0
        Me.helpview1.ImageList = Me.helpim1
        Me.helpview1.Location = New System.Drawing.Point(8, 0)
        Me.helpview1.Name = "helpview1"
        TreeNode1.ImageIndex = 1
        TreeNode1.Name = ""
        TreeNode1.SelectedImageIndex = 1
        TreeNode1.Text = "Node2"
        TreeNode2.ImageIndex = 1
        TreeNode2.Name = ""
        TreeNode2.SelectedImageIndex = 1
        TreeNode2.Text = "Node5"
        TreeNode3.ImageIndex = 0
        TreeNode3.Name = ""
        TreeNode3.SelectedImageIndex = 0
        TreeNode3.Text = "Node1"
        TreeNode4.ImageIndex = 0
        TreeNode4.Name = ""
        TreeNode4.SelectedImageIndex = 0
        TreeNode4.Text = "Node0"
        Me.helpview1.Nodes.AddRange(New System.Windows.Forms.TreeNode() {TreeNode4})
        Me.helpview1.SelectedImageIndex = 0
        Me.helpview1.Size = New System.Drawing.Size(160, 152)
        Me.helpview1.TabIndex = 1
        '
        'helpim1
        '
        Me.helpim1.ImageStream = CType(resources.GetObject("helpim1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.helpim1.TransparentColor = System.Drawing.Color.Transparent
        Me.helpim1.Images.SetKeyName(0, "")
        Me.helpim1.Images.SetKeyName(1, "")
        '
        'panelingrammar
        '
        Me.panelingrammar.Controls.Add(Me.paneloutputgrammar)
        Me.panelingrammar.Controls.Add(Me.panelcontsearch)
        Me.panelingrammar.Location = New System.Drawing.Point(8, 48)
        Me.panelingrammar.Name = "panelingrammar"
        Me.panelingrammar.Size = New System.Drawing.Size(184, 200)
        Me.panelingrammar.TabIndex = 19
        '
        'paneloutputgrammar
        '
        Me.paneloutputgrammar.Controls.Add(Me.amean2)
        Me.paneloutputgrammar.Controls.Add(Me.amean1)
        Me.paneloutputgrammar.Controls.Add(Me.gram)
        Me.paneloutputgrammar.Controls.Add(Me.mean2)
        Me.paneloutputgrammar.Controls.Add(Me.mean1)
        Me.paneloutputgrammar.Controls.Add(Me.word)
        Me.paneloutputgrammar.Controls.Add(Me.Label6)
        Me.paneloutputgrammar.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneloutputgrammar.Location = New System.Drawing.Point(0, 56)
        Me.paneloutputgrammar.Name = "paneloutputgrammar"
        Me.paneloutputgrammar.Size = New System.Drawing.Size(184, 144)
        Me.paneloutputgrammar.TabIndex = 4
        '
        'amean2
        '
        Me.amean2.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.amean2.BackColorDown = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.amean2.BackColorFocus = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.amean2.DialogResult = System.Windows.Forms.DialogResult.None
        Me.amean2.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amean2.Location = New System.Drawing.Point(152, 88)
        Me.amean2.Name = "amean2"
        Me.amean2.Size = New System.Drawing.Size(24, 24)
        Me.amean2.TabIndex = 6
        Me.amean2.TabStop = False
        Me.amean2.Text = "V"
        Me.amean2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.amean2.Visible = False
        '
        'amean1
        '
        Me.amean1.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.amean1.BackColorDown = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.amean1.BackColorFocus = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.amean1.DialogResult = System.Windows.Forms.DialogResult.None
        Me.amean1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.amean1.Location = New System.Drawing.Point(152, 48)
        Me.amean1.Name = "amean1"
        Me.amean1.Size = New System.Drawing.Size(24, 24)
        Me.amean1.TabIndex = 5
        Me.amean1.TabStop = False
        Me.amean1.Text = "V"
        Me.amean1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.amean1.Visible = False
        '
        'gram
        '
        Me.gram.Location = New System.Drawing.Point(8, 120)
        Me.gram.Name = "gram"
        Me.gram.Size = New System.Drawing.Size(144, 23)
        Me.gram.TabIndex = 4
        Me.gram.Text = "Grammar"
        Me.gram.Visible = False
        '
        'mean2
        '
        Me.mean2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mean2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mean2.Location = New System.Drawing.Point(8, 88)
        Me.mean2.Name = "mean2"
        Me.mean2.Size = New System.Drawing.Size(141, 24)
        Me.mean2.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.mean2, "Click to Insert this Word")
        Me.mean2.Visible = False
        '
        'mean1
        '
        Me.mean1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.mean1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.mean1.Location = New System.Drawing.Point(8, 48)
        Me.mean1.Name = "mean1"
        Me.mean1.Size = New System.Drawing.Size(141, 24)
        Me.mean1.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.mean1, "Click to Insert this Word")
        Me.mean1.Visible = False
        '
        'word
        '
        Me.word.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.word.Location = New System.Drawing.Point(8, 20)
        Me.word.Name = "word"
        Me.word.Size = New System.Drawing.Size(144, 16)
        Me.word.TabIndex = 1
        Me.word.Text = "Any word"
        Me.word.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(8, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(90, 13)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Reference for:"
        '
        'panelcontsearch
        '
        Me.panelcontsearch.Controls.Add(Me.Label5)
        Me.panelcontsearch.Controls.Add(Me.textsearch)
        Me.panelcontsearch.Controls.Add(Me.searchgo)
        Me.panelcontsearch.Dock = System.Windows.Forms.DockStyle.Top
        Me.panelcontsearch.Location = New System.Drawing.Point(0, 0)
        Me.panelcontsearch.Name = "panelcontsearch"
        Me.panelcontsearch.Size = New System.Drawing.Size(184, 56)
        Me.panelcontsearch.TabIndex = 3
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(8, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(72, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Search for:"
        '
        'textsearch
        '
        Me.textsearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.textsearch.Location = New System.Drawing.Point(8, 24)
        Me.textsearch.Name = "textsearch"
        Me.textsearch.Size = New System.Drawing.Size(128, 21)
        Me.textsearch.TabIndex = 1
        '
        'searchgo
        '
        Me.searchgo.BackColor = System.Drawing.Color.Lavender
        Me.searchgo.BackColorDown = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.searchgo.BackColorFocus = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.searchgo.BorderColor = System.Drawing.Color.Lavender
        Me.searchgo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.searchgo.DialogResult = System.Windows.Forms.DialogResult.None
        Me.searchgo.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.searchgo.Image = CType(resources.GetObject("searchgo.Image"), System.Drawing.Image)
        Me.searchgo.ImageMargin = 0
        Me.searchgo.Location = New System.Drawing.Point(144, 24)
        Me.searchgo.Name = "searchgo"
        Me.searchgo.Size = New System.Drawing.Size(21, 22)
        Me.searchgo.TabIndex = 2
        Me.searchgo.TabStop = False
        Me.searchgo.Text = "."
        Me.searchgo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'caadv
        '
        Me.caadv.ButtonColor1 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.caadv.ButtonColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.caadv.ButtonEmbossText = False
        Me.caadv.ButtonMouseOver = False
        Me.caadv.ButtonRadius = 0
        Me.caadv.ButtonShadowText = False
        Me.caadv.ButtonTextX = 0
        Me.caadv.ButtonTextY = 0
        Me.caadv.Location = New System.Drawing.Point(128, 275)
        Me.caadv.Name = "caadv"
        Me.caadv.Size = New System.Drawing.Size(16, 80)
        Me.caadv.TabIndex = 0
        Me.caadv.Text = "V"
        '
        'tptitle
        '
        Me.tptitle.ButtonColor1 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.tptitle.ButtonColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.tptitle.ButtonEmbossText = False
        Me.tptitle.ButtonMouseOver = False
        Me.tptitle.ButtonRadius = 0
        Me.tptitle.ButtonShadowText = False
        Me.tptitle.ButtonTextX = 0
        Me.tptitle.ButtonTextY = 0
        Me.tptitle.Dock = System.Windows.Forms.DockStyle.Top
        Me.tptitle.Enabled = False
        Me.tptitle.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tptitle.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.tptitle.Location = New System.Drawing.Point(4, 0)
        Me.tptitle.Name = "tptitle"
        Me.tptitle.Size = New System.Drawing.Size(195, 24)
        Me.tptitle.TabIndex = 17
        Me.tptitle.Text = "  : Taskpane"
        Me.tptitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label11
        '
        Me.Label11.BackColor = System.Drawing.SystemColors.Control
        Me.Label11.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label11.Location = New System.Drawing.Point(0, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(4, 544)
        Me.Label11.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label4.Location = New System.Drawing.Point(5, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 3)
        Me.Label4.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.SteelBlue
        Me.Label3.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.LightCyan
        Me.Label3.Location = New System.Drawing.Point(5, 251)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(187, 14)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Cliparts"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.LightSkyBlue
        Me.Label2.Location = New System.Drawing.Point(5, 40)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(187, 3)
        Me.Label2.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.SteelBlue
        Me.Label1.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.LightCyan
        Me.Label1.Location = New System.Drawing.Point(5, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(187, 14)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Spelling and Grammar"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.PictureBox1.Location = New System.Drawing.Point(45, 275)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 80)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'bgtp1
        '
        Me.bgtp1.ButtonColor1 = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.bgtp1.ButtonColor2 = System.Drawing.Color.SteelBlue
        Me.bgtp1.ButtonEmbossText = False
        Me.bgtp1.ButtonMouseOver = False
        Me.bgtp1.ButtonRadius = 0
        Me.bgtp1.ButtonShadowText = False
        Me.bgtp1.ButtonTextX = 0
        Me.bgtp1.ButtonTextY = 0
        Me.bgtp1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.bgtp1.Enabled = False
        Me.bgtp1.Location = New System.Drawing.Point(0, 0)
        Me.bgtp1.Name = "bgtp1"
        Me.bgtp1.Size = New System.Drawing.Size(199, 544)
        Me.bgtp1.TabIndex = 20
        '
        'text2
        '
        Me.text2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.text2.Location = New System.Drawing.Point(513, 5)
        Me.text2.Name = "text2"
        Me.text2.Size = New System.Drawing.Size(100, 14)
        Me.text2.TabIndex = 10
        Me.text2.TabStop = False
        Me.text2.Visible = False
        '
        'toolbar1
        '
        Me.toolbar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(218, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.toolbar1.Controls.Add(Me.sep12)
        Me.toolbar1.Controls.Add(Me.bpaste)
        Me.toolbar1.Controls.Add(Me.bcopy)
        Me.toolbar1.Controls.Add(Me.sepcut11)
        Me.toolbar1.Controls.Add(Me.bcut)
        Me.toolbar1.Controls.Add(Me.bsave)
        Me.toolbar1.Controls.Add(Me.bopen)
        Me.toolbar1.Controls.Add(Me.bnew)
        Me.toolbar1.Controls.Add(Me.text3)
        Me.toolbar1.Controls.Add(Me.text2)
        Me.toolbar1.Controls.Add(Me.toolbar)
        Me.toolbar1.Controls.Add(Me.exttbmain1)
        Me.toolbar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.toolbar1.Location = New System.Drawing.Point(0, 0)
        Me.toolbar1.Name = "toolbar1"
        Me.toolbar1.Size = New System.Drawing.Size(812, 29)
        Me.toolbar1.TabIndex = 2
        '
        'sep12
        '
        Me.sep12.BackColor = System.Drawing.Color.RoyalBlue
        Me.sep12.Location = New System.Drawing.Point(212, 2)
        Me.sep12.Name = "sep12"
        Me.sep12.Size = New System.Drawing.Size(1, 24)
        Me.sep12.TabIndex = 24
        Me.sep12.Text = "Label9"
        '
        'bpaste
        '
        Me.bpaste.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.bpaste.BackColorDown = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bpaste.BackColorFocus = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bpaste.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bpaste.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bpaste.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.bpaste.Image = CType(resources.GetObject("bpaste.Image"), System.Drawing.Image)
        Me.bpaste.ImageMargin = 3
        Me.bpaste.Location = New System.Drawing.Point(180, 2)
        Me.bpaste.Name = "bpaste"
        Me.bpaste.Size = New System.Drawing.Size(24, 24)
        Me.bpaste.TabIndex = 23
        Me.bpaste.TabStop = False
        Me.bpaste.Text = "."
        Me.bpaste.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'bcopy
        '
        Me.bcopy.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.bcopy.BackColorDown = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bcopy.BackColorFocus = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bcopy.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bcopy.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcopy.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.bcopy.Image = CType(resources.GetObject("bcopy.Image"), System.Drawing.Image)
        Me.bcopy.ImageMargin = 3
        Me.bcopy.Location = New System.Drawing.Point(151, 2)
        Me.bcopy.Name = "bcopy"
        Me.bcopy.Size = New System.Drawing.Size(24, 24)
        Me.bcopy.TabIndex = 22
        Me.bcopy.TabStop = False
        Me.bcopy.Text = "."
        Me.bcopy.TextAlign = System.Drawing.ContentAlignment.BottomRight
        '
        'sepcut11
        '
        Me.sepcut11.BackColor = System.Drawing.Color.RoyalBlue
        Me.sepcut11.Location = New System.Drawing.Point(112, 2)
        Me.sepcut11.Name = "sepcut11"
        Me.sepcut11.Size = New System.Drawing.Size(1, 24)
        Me.sepcut11.TabIndex = 21
        '
        'bcut
        '
        Me.bcut.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.bcut.BackColorDown = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bcut.BackColorFocus = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bcut.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bcut.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bcut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.bcut.Image = CType(resources.GetObject("bcut.Image"), System.Drawing.Image)
        Me.bcut.ImageMargin = 3
        Me.bcut.Location = New System.Drawing.Point(120, 2)
        Me.bcut.Name = "bcut"
        Me.bcut.Size = New System.Drawing.Size(24, 24)
        Me.bcut.TabIndex = 20
        Me.bcut.TabStop = False
        Me.bcut.Text = "."
        Me.bcut.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bsave
        '
        Me.bsave.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.bsave.BackColorDown = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bsave.BackColorFocus = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bsave.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bsave.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bsave.Image = CType(resources.GetObject("bsave.Image"), System.Drawing.Image)
        Me.bsave.ImageMargin = 3
        Me.bsave.Location = New System.Drawing.Point(80, 2)
        Me.bsave.Name = "bsave"
        Me.bsave.Size = New System.Drawing.Size(24, 24)
        Me.bsave.TabIndex = 19
        Me.bsave.TabStop = False
        Me.bsave.Text = "."
        Me.bsave.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bopen
        '
        Me.bopen.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.bopen.BackColorDown = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bopen.BackColorFocus = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bopen.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bopen.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bopen.Image = CType(resources.GetObject("bopen.Image"), System.Drawing.Image)
        Me.bopen.ImageMargin = 3
        Me.bopen.Location = New System.Drawing.Point(48, 2)
        Me.bopen.Name = "bopen"
        Me.bopen.Size = New System.Drawing.Size(24, 24)
        Me.bopen.TabIndex = 18
        Me.bopen.TabStop = False
        Me.bopen.Text = "."
        Me.bopen.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'bnew
        '
        Me.bnew.BackColor = System.Drawing.Color.FromArgb(CType(CType(195, Byte), Integer), CType(CType(217, Byte), Integer), CType(CType(249, Byte), Integer))
        Me.bnew.BackColorDown = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.bnew.BackColorFocus = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.bnew.DialogResult = System.Windows.Forms.DialogResult.None
        Me.bnew.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bnew.Image = CType(resources.GetObject("bnew.Image"), System.Drawing.Image)
        Me.bnew.Location = New System.Drawing.Point(16, 2)
        Me.bnew.Name = "bnew"
        Me.bnew.Size = New System.Drawing.Size(24, 24)
        Me.bnew.TabIndex = 17
        Me.bnew.TabStop = False
        Me.bnew.Text = "."
        Me.bnew.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'text3
        '
        Me.text3.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.text3.Location = New System.Drawing.Point(599, 11)
        Me.text3.Name = "text3"
        Me.text3.Size = New System.Drawing.Size(32, 14)
        Me.text3.TabIndex = 11
        Me.text3.TabStop = False
        Me.text3.Visible = False
        '
        'toolbar
        '
        Me.toolbar.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.toolbar.ButtonColor1 = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(254, Byte), Integer))
        Me.toolbar.ButtonColor2 = System.Drawing.Color.FromArgb(CType(CType(129, Byte), Integer), CType(CType(169, Byte), Integer), CType(CType(226, Byte), Integer))
        Me.toolbar.ButtonEmbossText = False
        Me.toolbar.ButtonMouseOver = False
        Me.toolbar.ButtonRadius = 5
        Me.toolbar.ButtonShadowText = True
        Me.toolbar.ButtonTextX = 0
        Me.toolbar.ButtonTextY = 0
        Me.toolbar.Enabled = False
        Me.toolbar.Location = New System.Drawing.Point(2, 1)
        Me.toolbar.Name = "toolbar"
        Me.toolbar.Size = New System.Drawing.Size(308, 26)
        Me.toolbar.TabIndex = 13
        Me.toolbar.Text = " :"
        Me.toolbar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.toolbar.UseVisualStyleBackColor = False
        '
        'exttbmain1
        '
        Me.exttbmain1.ButtonColor1 = System.Drawing.Color.DodgerBlue
        Me.exttbmain1.ButtonColor2 = System.Drawing.Color.SlateBlue
        Me.exttbmain1.ButtonEmbossText = True
        Me.exttbmain1.ButtonMouseOver = False
        Me.exttbmain1.ButtonRadius = 5
        Me.exttbmain1.ButtonShadowText = False
        Me.exttbmain1.ButtonTextX = 0
        Me.exttbmain1.ButtonTextY = 0
        Me.exttbmain1.Enabled = False
        Me.exttbmain1.ForeColor = System.Drawing.Color.Black
        Me.exttbmain1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.exttbmain1.Location = New System.Drawing.Point(304, 1)
        Me.exttbmain1.Name = "exttbmain1"
        Me.exttbmain1.Size = New System.Drawing.Size(16, 26)
        Me.exttbmain1.TabIndex = 19
        Me.exttbmain1.Text = "v"
        Me.exttbmain1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.Filter = "Rtf files only|*.rtf|All Files|*.*"
        Me.OpenFileDialog1.Title = "Open a File"
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.Filter = "Picture files|*.jpeg;*.jpg;*.bmp;*.gif"
        Me.OpenFileDialog2.Title = "Insert Picture"
        '
        'SaveFileDialog1
        '
        Me.SaveFileDialog1.Filter = "Rtf files only|*.rtf"
        Me.SaveFileDialog1.Title = "Save file"
        '
        'stag1
        '
        Me.stag1.BackColor = System.Drawing.SystemColors.Control
        Me.stag1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.stag1.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.stag1.ForeColor = System.Drawing.Color.White
        Me.stag1.ImageAlign = System.Drawing.ContentAlignment.BottomRight
        Me.stag1.Location = New System.Drawing.Point(0, 0)
        Me.stag1.Name = "stag1"
        Me.stag1.Size = New System.Drawing.Size(24, 24)
        Me.stag1.TabIndex = 0
        Me.stag1.UseVisualStyleBackColor = False
        '
        'stlabel1
        '
        Me.stlabel1.BackColor = System.Drawing.Color.Transparent
        Me.stlabel1.Location = New System.Drawing.Point(0, 24)
        Me.stlabel1.Name = "stlabel1"
        Me.stlabel1.Size = New System.Drawing.Size(16, 8)
        Me.stlabel1.TabIndex = 1
        '
        'stpanel1
        '
        Me.stpanel1.BackColor = System.Drawing.SystemColors.Control
        Me.stpanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.stpanel1.Controls.Add(Me.stag1)
        Me.stpanel1.Controls.Add(Me.stlabel1)
        Me.stpanel1.Location = New System.Drawing.Point(60, 52)
        Me.stpanel1.Name = "stpanel1"
        Me.stpanel1.Size = New System.Drawing.Size(24, 24)
        Me.stpanel1.TabIndex = 2
        Me.stpanel1.Visible = False
        '
        'taganim1
        '
        Me.taganim1.Interval = 250
        '
        'panelruler
        '
        Me.panelruler.BackColor = System.Drawing.Color.White
        Me.panelruler.BackgroundImage = CType(resources.GetObject("panelruler.BackgroundImage"), System.Drawing.Image)
        Me.panelruler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.panelruler.Dock = System.Windows.Forms.DockStyle.Left
        Me.panelruler.Location = New System.Drawing.Point(0, 0)
        Me.panelruler.Name = "panelruler"
        Me.panelruler.Size = New System.Drawing.Size(16, 333)
        Me.panelruler.TabIndex = 4
        '
        'panelcontent
        '
        Me.panelcontent.BackColor = System.Drawing.Color.SlateGray
        Me.panelcontent.Controls.Add(Me.panel2filler)
        Me.panelcontent.Controls.Add(Me.panelruler)
        Me.panelcontent.Controls.Add(Me.taskpane)
        Me.panelcontent.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panelcontent.Location = New System.Drawing.Point(0, 29)
        Me.panelcontent.Name = "panelcontent"
        Me.panelcontent.Size = New System.Drawing.Size(812, 333)
        Me.panelcontent.TabIndex = 5
        '
        'panel2filler
        '
        Me.panel2filler.Controls.Add(Me.Panel3fill)
        Me.panel2filler.Controls.Add(Me.paneltopruler)
        Me.panel2filler.Dock = System.Windows.Forms.DockStyle.Fill
        Me.panel2filler.Location = New System.Drawing.Point(16, 0)
        Me.panel2filler.Name = "panel2filler"
        Me.panel2filler.Size = New System.Drawing.Size(580, 333)
        Me.panel2filler.TabIndex = 6
        '
        'Panel3fill
        '
        Me.Panel3fill.Controls.Add(Me.Paneltext)
        Me.Panel3fill.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3fill.Location = New System.Drawing.Point(0, 16)
        Me.Panel3fill.Name = "Panel3fill"
        Me.Panel3fill.Size = New System.Drawing.Size(580, 317)
        Me.Panel3fill.TabIndex = 6
        '
        'Paneltext
        '
        Me.Paneltext.AutoScroll = True
        Me.Paneltext.Controls.Add(Me.stpanel1)
        Me.Paneltext.Controls.Add(Me.text1)
        Me.Paneltext.Controls.Add(Me.Labelleft)
        Me.Paneltext.Location = New System.Drawing.Point(56, 30)
        Me.Paneltext.Name = "Paneltext"
        Me.Paneltext.Size = New System.Drawing.Size(264, 282)
        Me.Paneltext.TabIndex = 3
        '
        'text1
        '
        Me.text1.AcceptsTab = True
        Me.text1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.text1.ContextMenu = Me.cmtext
        Me.text1.Location = New System.Drawing.Point(112, 128)
        Me.text1.Name = "text1"
        Me.text1.PageSettings = CType(resources.GetObject("text1.PageSettings"), System.Drawing.Printing.PageSettings)
        Me.text1.Size = New System.Drawing.Size(100, 96)
        Me.text1.TabIndex = 3
        Me.text1.Text = ""
        '
        'Labelleft
        '
        Me.Labelleft.BackColor = System.Drawing.Color.White
        Me.Labelleft.Dock = System.Windows.Forms.DockStyle.Left
        Me.Labelleft.Enabled = False
        Me.Labelleft.Location = New System.Drawing.Point(0, 0)
        Me.Labelleft.Name = "Labelleft"
        Me.Labelleft.Size = New System.Drawing.Size(40, 282)
        Me.Labelleft.TabIndex = 4
        '
        'paneltopruler
        '
        Me.paneltopruler.BackColor = System.Drawing.Color.White
        Me.paneltopruler.BackgroundImage = CType(resources.GetObject("paneltopruler.BackgroundImage"), System.Drawing.Image)
        Me.paneltopruler.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.paneltopruler.Dock = System.Windows.Forms.DockStyle.Top
        Me.paneltopruler.Location = New System.Drawing.Point(0, 0)
        Me.paneltopruler.Name = "paneltopruler"
        Me.paneltopruler.Size = New System.Drawing.Size(580, 16)
        Me.paneltopruler.TabIndex = 5
        '
        'sbbar
        '
        Me.sbbar.BackColor = System.Drawing.SystemColors.Control
        Me.sbbar.Controls.Add(Me.statusdone)
        Me.sbbar.Controls.Add(Me.fosaved)
        Me.sbbar.Controls.Add(Me.fopath)
        Me.sbbar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.sbbar.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.sbbar.Location = New System.Drawing.Point(0, 362)
        Me.sbbar.Name = "sbbar"
        Me.sbbar.Size = New System.Drawing.Size(812, 21)
        Me.sbbar.TabIndex = 3
        '
        'statusdone
        '
        Me.statusdone.BackColorDown = System.Drawing.SystemColors.Control
        Me.statusdone.BackColorFocus = System.Drawing.SystemColors.Control
        Me.statusdone.BorderColor = System.Drawing.SystemColors.ControlDark
        Me.statusdone.BorderColorFocus = System.Drawing.SystemColors.ControlDark
        Me.statusdone.DialogResult = System.Windows.Forms.DialogResult.None
        Me.statusdone.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.statusdone.Location = New System.Drawing.Point(0, 1)
        Me.statusdone.Name = "statusdone"
        Me.statusdone.Size = New System.Drawing.Size(312, 19)
        Me.statusdone.TabIndex = 0
        Me.statusdone.TabStop = False
        Me.statusdone.Text = "Done"
        Me.statusdone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'fosaved
        '
        Me.fosaved.Location = New System.Drawing.Point(440, 0)
        Me.fosaved.Name = "fosaved"
        Me.fosaved.Size = New System.Drawing.Size(100, 21)
        Me.fosaved.TabIndex = 4
        Me.fosaved.Text = "yes"
        Me.fosaved.Visible = False
        '
        'fopath
        '
        Me.fopath.Location = New System.Drawing.Point(328, 0)
        Me.fopath.Name = "fopath"
        Me.fopath.Size = New System.Drawing.Size(100, 21)
        Me.fopath.TabIndex = 3
        Me.fopath.Text = "null"
        Me.fopath.Visible = False
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'miscil1
        '
        Me.miscil1.ImageStream = CType(resources.GetObject("miscil1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.miscil1.TransparentColor = System.Drawing.Color.Transparent
        Me.miscil1.Images.SetKeyName(0, "")
        '
        'foform1
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.BackColor = System.Drawing.Color.CadetBlue
        Me.ClientSize = New System.Drawing.Size(812, 383)
        Me.Controls.Add(Me.panelcontent)
        Me.Controls.Add(Me.toolbar1)
        Me.Controls.Add(Me.sbbar)
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Menu = Me.MainMenu1
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "foform1"
        Me.Text = "Foroffice Codenamed  ""Style2003"""
        Me.taskpane.ResumeLayout(False)
        Me.Panelhelp.ResumeLayout(False)
        Me.panelingrammar.ResumeLayout(False)
        Me.paneloutputgrammar.ResumeLayout(False)
        Me.paneloutputgrammar.PerformLayout()
        Me.panelcontsearch.ResumeLayout(False)
        Me.panelcontsearch.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.toolbar1.ResumeLayout(False)
        Me.toolbar1.PerformLayout()
        Me.stpanel1.ResumeLayout(False)
        Me.panelcontent.ResumeLayout(False)
        Me.panel2filler.ResumeLayout(False)
        Me.Panel3fill.ResumeLayout(False)
        Me.Paneltext.ResumeLayout(False)
        Me.sbbar.ResumeLayout(False)
        Me.sbbar.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region
    Dim canclose As Boolean
    Dim c As gscore10.mnuoff03blue
    Dim stbold As Boolean
    Dim stitalic As Boolean
    Dim stunderline As Boolean
    Dim stnormal As Boolean
    Dim handlerFile As EventHandler = New EventHandler(AddressOf MenuItemClick)
    Dim etcm As EventHandler = New EventHandler(AddressOf meaningclick)
    Dim forg As EventHandler = New EventHandler(AddressOf forgram)
    Dim toolbardown As Boolean
    Dim hwnd As Long
    Private Shared m_vb6FormDefInstance As foform1
    Private WithEvents pdoc As New PrintDocument()
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As foform1
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New foform1()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As foform1)
            m_vb6FormDefInstance = Value
        End Set
    End Property

#Region "Menu - Procedures"
    Private Sub forgram(ByVal sender As Object, ByVal e As EventArgs)
        Exit Sub
    End Sub
    Private Sub meaningclick(ByVal sender As Object, ByVal e As EventArgs)
        Dim b
        b = CType(sender, MenuItem).Text
        text1.SelectedText = b
    End Sub
    Private Sub MenuItemClick(ByVal sender As Object, ByVal e As EventArgs)
        Dim a
        a = CType(sender, MenuItem).Text
        Dim fon As Font
        fon = text1.Font

        'File menu items
        If a = "&Look up..." Then

        End If
        If a = "&New" Then
            procnew()
        End If
        If a = "&Open                 " Then
            procopen()
        End If
        If a = "&Save                 " Then
            procsave()
        End If
        If a = "&Print                  " Then
            doprint()
        End If
        If a = "Page S&etup" Then
            pagesetup()
        End If
        If a = "Print Pre&view" Then
            printpreview()
        End If
        If a = "E&xit                  " Then
            procclose()
        End If
        If a = "&About     " Then
            foabout.DefInstance.ShowDialog()
            'MessageBox.Show("Gurusted Foroffice version 2", "About Foroffice", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If

        'Takspane

        If a = "&Choose file..." Then
            dochoosefile()
        End If
        If a = "&Remove" Then
            removepic()
        End If
        If a = "&Insert" Then
            doinsertpic()
        End If

        'Insert menu

        If a = "&Break" Then
            text1.SelectedText = Chr(13) + Chr(10) + Chr(13) + Chr(10)
        End If
        If a = "Date and &Time..." Then
            Dim dt As New fodateandtime()
            dt.ShowDialog()
        End If
        If a = "&Hyperlink     " Then
            fohyperlink.DefInstance.Show()
            fohyperlink.DefInstance.Focus()
        End If

        'Edit menu

        If a = "&Undo           " Then
            text1.Undo()
        End If
        If a = "&Redo           " Then
            text1.Redo()
        End If
        If a = "Cu&t" Then
            text1.Cut()
        End If
        If a = "Cut          " Then
            text1.Cut()
        End If
        If a = "Copy" Then
            text1.Copy()
        End If
        If a = "Paste" Then
            text1.Paste()
        End If
        If a = "&Copy           " Then
            text1.Copy()
        End If
        If a = "&Paste          " Then
            text1.Paste()
        End If
        If a = "C&lear All       " Then
            text1.SelectedText = ""
        End If
        If a = "Select &All     " Then
            text1.SelectAll()
        End If
        If a = "&Bold                      " Then
            text1.SelectionFont = New Font(fon, FontStyle.Bold)
            If stitalic = True Then
                text1.SelectionFont = New Font(fon, FontStyle.Bold Or FontStyle.Italic)
            End If
        End If
        If a = "&Normal" Then
            text1.SelectionFont = New Font(fon, FontStyle.Regular)
        End If
        If a = "&Italic                      " Then
            text1.SelectionFont = New Font(fon, FontStyle.Italic)
        End If
        If a = "&Underline" Then
            text1.SelectionFont = New Font(fon, FontStyle.Underline)
        End If
        If a = "&Strikeout" Then
            text1.SelectionFont = New Font(fon, FontStyle.Strikeout)
        End If

        'Format menu
        If a = "C&enter                  " Then
            text1.SelectionAlignment = HorizontalAlignment.Center
        End If
        If a = "&Left Align              " Then
            text1.SelectionAlignment = HorizontalAlignment.Left
        End If
        If a = "&Right Align            " Then
            text1.SelectionAlignment = HorizontalAlignment.Right
        End If
        If a = "&Font" Then
            FontDialog1.ShowDialog()
            On Error GoTo err
            Dim s
            s = FontDialog1.Font
            text1.SelectionFont = s
err:
            Exit Sub
        End If

        If a = "Back&ground" Then
            Dim c1, re, dr
            re = text1.BackColor
            If ColorDialog1.ShowDialog() = DialogResult.OK Then
                On Error GoTo errc
                c1 = ColorDialog1.Color
                    text1.BackColor = c1
                    Labelleft.BackColor = c1
            ElseIf DialogResult.Cancel Then
                text1.BackColor = re
                Labelleft.BackColor = re
            End If
            Exit Sub
errc:
            text1.BackColor = re
            Labelleft.BackColor = re
            Exit Sub
        End If
            If a = "Font &Color" Then
                Dim c2
                On Error GoTo errc2
                ColorDialog1.ShowDialog()
                c2 = ColorDialog1.Color
                text1.SelectionColor = c2
errc2:
                Exit Sub
            End If

            If a = "Increase Indent" Then
                On Error Resume Next
                Dim IndentPlus As Object
                IndentPlus = 8
                text1.SelectionIndent = text1.SelectionIndent + IndentPlus
            End If
            If a = "Decrease Indent" Then
                Dim IndentMinus As Object
                IndentMinus = 8
                text1.SelectionIndent = text1.SelectionIndent - IndentMinus
            End If
            If a = "&Superscript" Then
                text1.SelectionCharOffset = 5
            End If
            If a = "Subs&cript" Then
                text1.SelectionCharOffset = -5
            End If
            If a = "&No script" Then
                text1.SelectionCharOffset = 0
            End If
            If a = "&Upper case" Then
                text1.SelectedText = UCase(text1.SelectedText)
            End If
            If a = "&Lower case" Then
                text1.SelectedText = LCase(text1.SelectedText)
            End If
            If a = "&Encrypt      " Then
                encrypt()
            End If
            If a = "&Decrypt      " Then
                decrypt()
            End If

        If a = "Thesaurus..." Then
            forpopup(text1.SelectedText, True)
        End If
        'Window menu
        If a = "&Close" Then
            procclose()
        End If
        If a = "&Minimize" Then
            Me.WindowState = FormWindowState.Minimized
        End If

        'Smart tags
    End Sub
    Private Sub mnulookup_click(ByVal sender As Object, ByVal e As EventArgs)
        Dim w
        w = text1.SelectedText
        forpopup(w, True)
    End Sub
    Private Sub createmenu()
        MainMenu1.MenuItems.Clear()
        c.SetImageList = il2
        With MainMenu1.MenuItems
            'Create for normal
            .Add("&File")
            .Add("&Edit")
            .Add("&Insert")
            .Add("F&ormat")
            .Add("&Tools")
            .Add("&Window")
            .Add("&Help")
        End With
        Dim submenufile As Menu
        submenufile = MainMenu1.MenuItems(0)
        With submenufile.MenuItems
            .Add(New gscore10.mnuoff03blue(6, "&New", handlerFile, Shortcut.None, False))
            .Add(New gscore10.mnuoff03blue(7, "&Open                 ", handlerFile, Shortcut.CtrlO, False))
            .Add(New gscore10.mnuoff03blue(9, "&Save                 ", handlerFile, Shortcut.CtrlS, True))
            .Add(New gscore10.mnuoff03blue(12, "&Print                  ", handlerFile, Shortcut.CtrlP, False))
            .Add(New gscore10.mnuoff03blue(13, "Print Pre&view", handlerFile, Shortcut.None, False))
            .Add(New gscore10.mnuoff03blue("Page S&etup", handlerFile, Shortcut.None, True))
            .Add(New gscore10.mnuoff03blue("&Properties", handlerFile, Shortcut.None, True))
            .Add(New gscore10.mnuoff03blue(31, "E&xit                  ", handlerFile, Shortcut.CtrlQ, False))
        End With
        Dim submenuedit As Menu
        submenuedit = MainMenu1.MenuItems(1)
        With submenuedit.MenuItems
            .Add(New gscore10.mnuoff03blue(10, "&Undo           ", handlerFile, Shortcut.CtrlZ, False))
            .Add(New gscore10.mnuoff03blue(11, "&Redo           ", handlerFile, Shortcut.CtrlY, True))
            .Add(New gscore10.mnuoff03blue(5, "Cu&t", handlerFile, Shortcut.None, False))
            .Add(New gscore10.mnuoff03blue(4, "&Copy           ", handlerFile, Shortcut.CtrlC, False))
            .Add(New gscore10.mnuoff03blue(8, "&Paste          ", handlerFile, Shortcut.CtrlV, True))
            .Add(New gscore10.mnuoff03blue("C&lear All       ", handlerFile, Shortcut.Del, True))
            .Add(New gscore10.mnuoff03blue("Select &All     ", handlerFile, Shortcut.CtrlA, False))
        End With
        Dim submenuformat As Menu
        submenuformat = MainMenu1.MenuItems(3)
        With submenuformat.MenuItems
            .Add(New gscore10.mnuoff03blue(14, "&Font", handlerFile, Shortcut.None, True))
            .Add(New gscore10.mnuoff03blue(2, "Back&ground", handlerFile, Shortcut.None, False))
            .Add(New gscore10.mnuoff03blue(15, "Font &Color", handlerFile, Shortcut.None, True))
            .Add(New gscore10.mnuoff03blue(16, "C&enter                  ", handlerFile, Shortcut.CtrlE, False))
            .Add(New gscore10.mnuoff03blue(21, "&Left Align              ", handlerFile, Shortcut.CtrlL, False))
            .Add(New gscore10.mnuoff03blue(25, "&Right Align            ", handlerFile, Shortcut.CtrlR, True))
            .Add(New gscore10.mnuoff03blue(28, "&Bold                      ", handlerFile, Shortcut.CtrlB, False))
            .Add(New gscore10.mnuoff03blue("&Italic                      ", handlerFile, Shortcut.CtrlI, False))
            .Add(New gscore10.mnuoff03blue("&Underline              ", handlerFile, Shortcut.CtrlU, False))
            .Add(New gscore10.mnuoff03blue("Change Case", handlerFile, Shortcut.None, True))
            .Add(New gscore10.mnuoff03blue(27, "Increase Indent", handlerFile, Shortcut.None, False))
            .Add(New gscore10.mnuoff03blue(19, "Decrease Indent", handlerFile, Shortcut.None, True))
            .Add(New gscore10.mnuoff03blue("&Superscript", handlerFile, False))
            .Add(New gscore10.mnuoff03blue("Subs&cript", handlerFile, False))
            .Add(New gscore10.mnuoff03blue("&No script", handlerFile, False))
        End With
        Dim submenucase As Menu
        submenucase = submenuformat.MenuItems(9)
        With submenucase.MenuItems
            .Add(New gscore10.mnuoff03blue("&Upper case", handlerFile, False))
            .Add(New gscore10.mnuoff03blue("&Lower case", handlerFile, False))
        End With
        Dim submenuinsert As Menu
        submenuinsert = MainMenu1.MenuItems(2)
        With submenuinsert.MenuItems
            .Add(New gscore10.mnuoff03blue("&Break", handlerFile, Shortcut.None, True))
            .Add(New gscore10.mnuoff03blue("Date and &Time...", handlerFile, Shortcut.None, False))
            .Add(New gscore10.mnuoff03blue("&Symbol...", handlerFile, Shortcut.None, False))
            .Add(New gscore10.mnuoff03blue(1, "&Autotext", handlerFile, Shortcut.None, False))
            .Add(New gscore10.mnuoff03blue(18, "&Hyperlink     ", handlerFile, Shortcut.CtrlK, False))
        End With
        Dim submenutools As Menu
        submenutools = MainMenu1.MenuItems(4)
        With submenutools.MenuItems
            .Add(New gscore10.mnuoff03blue("&Encrypt      ", handlerFile, Shortcut.ShiftF1, False))
            .Add(New gscore10.mnuoff03blue("&Decrypt      ", handlerFile, Shortcut.ShiftF2, True))
            .Add(New gscore10.mnuoff03blue(22, "&Research", handlerFile, Shortcut.None, False))
            .Add(New gscore10.mnuoff03blue("&Customize", handlerFile, Shortcut.None, True))
            .Add(New gscore10.mnuoff03blue("&gsdev", handlerFile, Shortcut.None, False))
        End With
        Dim submenuwindow As Menu
        submenuwindow = MainMenu1.MenuItems(5)
        With submenuwindow.MenuItems
            .Add(New gscore10.mnuoff03blue(23, "&Minimize", handlerFile, Shortcut.None, True))
            .Add(New gscore10.mnuoff03blue("&Close", handlerFile, Shortcut.None, False))
        End With
        Dim submenuhelp As Menu
        submenuhelp = MainMenu1.MenuItems(6)
        With submenuhelp.MenuItems
            .Add(New gscore10.mnuoff03blue(26, "&Topics", handlerFile, Shortcut.None, True))
            .Add(New gscore10.mnuoff03blue(0, "&About     ", handlerFile, Shortcut.F1, False))
        End With

        'For insert pic in Taskpane
        cmca.MenuItems.Clear()
        cmca.MenuItems.Add(New gscore10.mnuoff03blue(30, "&Choose file...", handlerFile, Shortcut.None, True))
        cmca.MenuItems.Add(New gscore10.mnuoff03blue(29, "&Insert", handlerFile, Shortcut.None, True))
        cmca.MenuItems.Add(New gscore10.mnuoff03blue(24, "&Remove", handlerFile, Shortcut.None, False))

        createresearchmenu()


    End Sub
    Private Sub createresearchmenu()
        With researchm1.MenuItems
            'Create for normal
            .Add(New gscore10.mnuoff03blue("Insert", New System.EventHandler(AddressOf Me.mnurm1insertclick1), False))
        End With
        With researchm2.MenuItems
            .Add(New gscore10.mnuoff03blue("Insert", New System.EventHandler(AddressOf Me.mnurm1insertclick2), False))
        End With
    End Sub
    'End of this region
    'By Guruparan
#End Region

#Region "Normal Subs"
    Private Sub createchild()
        'Dim NewMDIChild As New fotoolbar()
        ''Set the Parent Form of the Child window.
        'NewMDIChild.MdiParent = Me
        ''Display the new form.
        'NewMDIChild.Show()
        'NewMDIChild.Focus()
    End Sub
    Private Sub doresform()
        taskpane.Left = Me.Width - taskpane.Width - 10
        taskpane.Top = toolbar1.Height
        Paneltext.Dock = DockStyle.Fill
        'text1.Dock = DockStyle.Fill
        'Paneltext.Top = 0
        'Paneltext.Left = 0
        'Paneltext.Width = Me.Width - taskpane.Width - 25
        'Paneltext.Height = Me.Height - sbbar.Height - toolbar.Height - 70
        'Paneltext.Height = 750
        text1.Top = 0
        text1.Left = Labelleft.Width
        text1.Height = Paneltext.Height
        text1.Width = 613
        stpanel1.Top = text1.Height / 2
        stpanel1.Left = Me.Width / 2
        exttbmain1.Left = toolbar.Width - 3
        text1.Focus()
    End Sub
    Private Sub dochoosefile()
        Dim fname
        On Error GoTo err
        If OpenFileDialog2.ShowDialog() = DialogResult.OK Then
            fname = OpenFileDialog2.FileName
            PictureBox1.Image = Image.FromFile(fname)
        End If
        Exit Sub
err:
        Exit Sub
    End Sub
    Private Sub removepic()
        PictureBox1.Image = Nothing
    End Sub
    Private Sub doinsertpic()
        On Error GoTo err
        Clipboard.SetDataObject(PictureBox1.Image)
        text1.Paste()
err:
        Exit Sub
    End Sub
    Private Sub doprint()
        Try
            '            PrintDialog1.Document = text1.Document
            text1.Print(True)
        Catch exp1 As Exception
            MessageBox.Show("An error occurred while trying to load the " & _
          "document for printing. Make sure you currently have " & _
          "access to a printer.", Me.Text, _
         MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Dim dialog As New PrintDialog()
        'dialog.Document = pdoc
        'If dialog.ShowDialog = DialogResult.OK Then
        '    pdoc.Print()
        'End If
    End Sub
    Private Sub printpreview()
        Try
            PrintPreviewDialog1.Document = text1.Document
            PrintPreviewDialog1.Icon = Me.Icon
            PrintPreviewDialog1.ShowDialog()
        Catch exp As Exception
            MessageBox.Show("An error occurred while trying to load the " & _
                         "document for Print Preview. Make sure you currently have " & _
                          "access to a printer. A printer must be connected and " & _
                          "accessible for Print Preview to work.", Me.Text, _
                           MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        'Dim ppd As New PrintPreviewDialog()
        'Try
        '    ppd.Document = pdoc
        '    ppd.ShowDialog()
        'Catch exp As Exception
        '    MessageBox.Show("An error occurred while trying to load the " & _
        '        "document for Print Preview. Make sure you currently have " & _
        '        "access to a printer. A printer must be connected and " & _
        '        "accessible for Print Preview to work.", Me.Text, _
        '         MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
    End Sub
    Private Sub pagesetup()
        On Error GoTo err
        PageSetupDialog1.Document = text1.Document
        PageSetupDialog1.ShowDialog()
        Exit Sub
err:
        MessageBox.Show("No printer is available or not installed properly,Click print to add new printer", "Foroffice", MessageBoxButtons.OK, MessageBoxIcon.Error)

        '        Dim psd As New PageSetupDialog()
        '        With psd
        '            .Document = pdoc
        '            .PageSettings = pdoc.DefaultPageSettings
        '        End With
        '        On Error GoTo err

        '        If psd.ShowDialog = DialogResult.OK Then
        '            pdoc.DefaultPageSettings = psd.PageSettings
        '        End If
        '        Exit Sub
        'err:
        'MessageBox.Show("No printer is available or not installed properly,Click print to add new printer", "Foroffice", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub animatestpanel1()
        stag1.Image = fodummy.DefInstance.st1.Image
        taganim1.Enabled = True
    End Sub
    Private Sub stopanimatepanel1()
        taganim1.Enabled = False
        stag1.Image = fodummy.DefInstance.st4.Image
    End Sub
    Public Sub dostag1menu(ByVal word)
        Dim stm As Menu
        tagm1.MenuItems.Clear()
        If word = "apple" Then
            tagm1.MenuItems.Add(New gscore10.mnutopoff03blue("Information", handlerFile, Shortcut.None, False))
            tagm1.MenuItems.Add(New gscore10.mnuoff03blue("This is a Fruit name", handlerFile, Shortcut.None, True))
            tagm1.MenuItems.Add(New gscore10.mnuoff03blue("Cool Smarttag ha!", handlerFile, Shortcut.None, False))
            stpanel1.Top = 75
            stpanel1.Left = 75
            Exit Sub
        End If
    End Sub
#End Region

#Region "Print -Related"
    Private Sub pdoc_PrintPage(ByVal sender As Object, ByVal e As System.Drawing.Printing.PrintPageEventArgs) Handles pdoc.PrintPage
        ' Declare a variable to hold the position of the last printed char. Declare
        ' as static so that subsequent PrintPage events can reference it.
        Static intCurrentChar As Int32
        ' Initialize the font to be used for printing.
        Dim font As New Font("Microsoft Sans Serif", 24)

        Dim intPrintAreaHeight, intPrintAreaWidth, marginLeft, marginTop As Int32
        With pdoc.DefaultPageSettings
            ' Initialize local variables that contain the bounds of the printing 
            ' area rectangle.
            intPrintAreaHeight = .PaperSize.Height - .Margins.Top - .Margins.Bottom
            intPrintAreaWidth = .PaperSize.Width - .Margins.Left - .Margins.Right

            ' Initialize local variables to hold margin values that will serve
            ' as the X and Y coordinates for the upper left corner of the printing 
            ' area rectangle.
            marginLeft = .Margins.Left ' X coordinate
            marginTop = .Margins.Top ' Y coordinate
        End With

        ' If the user selected Landscape mode, swap the printing area height 
        ' and width.
        If pdoc.DefaultPageSettings.Landscape Then
            Dim intTemp As Int32
            intTemp = intPrintAreaHeight
            intPrintAreaHeight = intPrintAreaWidth
            intPrintAreaWidth = intTemp
        End If

        ' Calculate the total number of lines in the document based on the height of
        ' the printing area and the height of the font.
        Dim intLineCount As Int32 = CInt(intPrintAreaHeight / font.Height)
        ' Initialize the rectangle structure that defines the printing area.
        Dim rectPrintingArea As New RectangleF(marginLeft, marginTop, intPrintAreaWidth, intPrintAreaHeight)

        Dim fmt As New StringFormat(StringFormatFlags.LineLimit)

        Dim intLinesFilled, intCharsFitted As Int32
        e.Graphics.MeasureString(Mid(text1.Text, intCurrentChar + 1), font, _
                    New SizeF(intPrintAreaWidth, intPrintAreaHeight), fmt, _
                   intCharsFitted, intLinesFilled)

        ' Print the text to the page.

        e.Graphics.DrawString(Mid(text1.Text, intCurrentChar + 1), font, _
            Brushes.Black, rectPrintingArea, fmt)


        intCurrentChar += intCharsFitted


        If intCurrentChar < text1.Text.Length Then
            e.HasMorePages = True
        Else
            e.HasMorePages = False
            ' You must explicitly reset intCurrentChar as it is static.
            intCurrentChar = 0
        End If
    End Sub
    Private Sub fopagebreak()
        'exit sub
    End Sub
#End Region

#Region "Security"
    Private Sub decrypt()
        Dim EncStr As String
        Dim EncKey As String, TempEncKey As String
        Dim EncLen As Integer
        Dim EncPos As Integer
        Dim EncKeyPos As Integer
        Dim tempChar As String
        Dim TA As Integer, TB As Integer, TC As Integer
        Dim x
        TempEncKey = InputBox("Enter the decryption key.  This is the key that was typed for encryption.", "Decrypt")
        If TempEncKey = "" Then Exit Sub
        EncStr = ""
        EncPos = 1
        EncKeyPos = 1
        For x = 1 To Len(TempEncKey)
            EncKey = EncKey & Asc(Mid$(TempEncKey, x, 1))
        Next
        EncLen = Len(EncKey)
        For x = 1 To Len(Me.text1.Text) Step 2
            TB = Asc(Mid$(EncKey, EncKeyPos, 1))
            EncKeyPos = EncKeyPos + 1
            If EncKeyPos > EncLen Then EncKeyPos = 1
            tempChar = Mid$(Me.text1.Text, x, 2)
            TA = Val("&H" + tempChar)
            TC = TB Xor TA
            EncStr = EncStr & Chr(TC)
        Next
        Me.text1.Text = EncStr
    End Sub
    Private Sub encrypt()
        Dim EncStr As String
        Dim EncKey As String, TempEncKey As String
        Dim EncLen As Integer
        Dim EncPos As Integer
        Dim EncKeyPos As Integer
        Dim tempChar As String
        Dim TA As Integer, TB As Integer, TC As Integer
        Dim x
        TempEncKey = InputBox("Enter the encryption key.  This key will be vital for decrypting this text later.", "Encrypt")
        If TempEncKey = "" Then Exit Sub
        EncStr = ""
        EncPos = 1
        EncKeyPos = 1

        For x = 1 To Len(TempEncKey)
            EncKey = EncKey & Asc(Mid$(TempEncKey, x, 1))
        Next

        EncLen = Len(EncKey)

        For x = 1 To Len(text1.Text)
            TB = Asc(Mid$(EncKey, EncKeyPos, 1))
            EncKeyPos = EncKeyPos + 1
            If EncKeyPos > EncLen Then EncKeyPos = 1
            TA = Asc(Mid$(text1.Text, x, 1))
            TC = TB Xor TA
            tempChar = Hex$(TC)
            If Len(tempChar) < 2 Then tempChar = "0" & tempChar
            EncStr = EncStr & tempChar
        Next
        text1.Text = EncStr
    End Sub
#End Region

#Region "UI procdures"

    'Main procedure
    Private Sub closeall()
        Me.Hide()
        canclose = True
        End
    End Sub
    Private Sub updateapp(ByVal saved As String, ByVal path As String)
        fosaved.Text = saved
        fopath.Text = path
        If path = "null" Then
            Me.Text = "Foroffice Codenamed ""Style2003"" - New Document"
        Else
            Me.Text = "Foroffice Codenamed ""Style2003"" - " & path
        End If
        If fopath.Text = "" Then
            MessageBox.Show("An Error occured in saving the file", "Foroffice", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        If fosaved.Text = "" Then
            MessageBox.Show("An Error occured in saving the file", "Foroffice", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub
    Private Sub procnew()
        If fosaved.Text = "no" Then
            chknewprocpath()
        ElseIf fosaved.Text = "yes" Then
            createnew()
        End If
    End Sub
    Private Sub chknewprocpath()
        Dim a As DialogResult
        a = MessageBox.Show("Do you want to save the changes made", "Foroffice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        'Dialog result Yes
        If a = DialogResult.Yes Then
            If fopath.Text = "null" Then
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    text1.SaveFile(SaveFileDialog1.FileName)
                    createnew()
                End If
            Else
                text1.SaveFile(fopath.Text)
                createnew()
            End If
        End If
        'Dialog result No
        If a = DialogResult.No Then
            createnew()
        End If
        If a = DialogResult.Cancel Then
            Exit Sub
        End If
    End Sub
    Private Sub createnew()
        text1.Text = ""
        updateapp("no", "null")
    End Sub
    Private Sub procopen()
        If fosaved.Text = "no" Then
            askforsaveandopen()
        ElseIf fosaved.Text = "yes" Then
            openonly()
        End If
    End Sub
    Private Sub openonly()
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            On Error GoTo err
            text1.LoadFile(OpenFileDialog1.FileName)
            updateapp("yes", OpenFileDialog1.FileName)
        End If
        Exit Sub
err:
        MessageBox.Show("The Opened is not a Valid RTF or txt file to open", "Cannot Open!", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
    Private Sub askforsaveandopen()
        Dim b As DialogResult
        b = MessageBox.Show("Do you want to save the changes made?", "Foroffice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        'Dialog result Yes
        If b = DialogResult.Yes Then
            If fopath.Text = "null" Then
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    text1.SaveFile(SaveFileDialog1.FileName)
                    openonly()
                End If
            Else
                text1.SaveFile(fopath.Text)
                updateapp("yes", fopath.Text)
                openonly()
            End If
        End If
        'Dialog result No
        If b = DialogResult.No Then
            openonly()
        End If
        'Dialog result Cancel
        If b = DialogResult.Cancel Then
            Exit Sub
        End If
    End Sub
    Private Sub procsave()
        If fopath.Text = "null" Then
            If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                text1.SaveFile(SaveFileDialog1.FileName)
                updateapp("yes", SaveFileDialog1.FileName)
            End If
        Else
            text1.SaveFile(fopath.Text)
            updateapp("yes", fopath.Text)
        End If
    End Sub
    Private Sub procclose()
        If text1.Text = "" Then
            closeall()
        End If
        If fosaved.Text = "no" Then
            saveandcloseproc()
        Else
            closeall()
        End If
    End Sub
    Private Sub saveandcloseproc()
        Dim c As DialogResult
        c = MessageBox.Show("Do you want to save the changes made?", "Foroffice", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information)
        'Dialog result Yes
        If c = DialogResult.Yes Then
            If fopath.Text = "null" Then
                If SaveFileDialog1.ShowDialog() = DialogResult.OK Then
                    text1.SaveFile(SaveFileDialog1.FileName)
                    closeall()
                    Exit Sub
                End If
            Else
                text1.SaveFile(fopath.Text)
                closeall()
            End If
        End If
        'Dialog result No
        If c = DialogResult.No Then
            closeall()
        End If
        'Dialog result Cancel
        If c = DialogResult.Cancel Then
            canclose = False
            Exit Sub
        End If
    End Sub
#End Region



    Private Sub mnurm1insertclick1(ByVal sender As Object, ByVal e As EventArgs)
        text1.SelectedText = mean1.Text
    End Sub
    Private Sub mnurm1insertclick2(ByVal sender As Object, ByVal e As EventArgs)
        text1.SelectedText = mean2.Text
    End Sub

    Private Sub foform1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        fodummy.DefInstance.saved.Text = "yes"
        fodummy.DefInstance.bold.Text = "no"
        fodummy.DefInstance.italic.Text = "no"
        fodummy.DefInstance.underline.Text = "no"
        fodummy.DefInstance.strikeout.Text = "no"
        fopath.Text = "null"
        fosaved.Text = "no"
        updateapp("no", "null")
        createmenu()
        doresform()
        canclose = False
        toolbardown = False
        text1.Text = "Hi users just type - APPLE and hit your space key see what happens,Then type GOOD and select it and right click it and you can see the exact grammar with spelling"
    End Sub
    Private Sub foform1_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Resize
        If Me.WindowState = FormWindowState.Minimized Then
            Exit Sub
        Else
            doresform()
        End If
    End Sub

    Private Sub stag1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles stag1.Click
        Dim p As Point
        On Error GoTo err
        tagm1.Show(stlabel1, p)
err:
        Exit Sub
    End Sub
    Private Sub stpanel1_VisibleChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles stpanel1.VisibleChanged
        If stpanel1.Visible = True Then
            animatestpanel1()
        ElseIf stpanel1.Visible = False Then
            stopanimatepanel1()
        End If
    End Sub
    Private Sub taganim1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles taganim1.Tick
        Dim mcpic
        mcpic = stag1.Image Is fodummy.DefInstance.st1.Image
        If mcpic = True Then
            stag1.Image = fodummy.DefInstance.st2.Image
            Exit Sub
        End If
        mcpic = stag1.Image Is fodummy.DefInstance.st2.Image
        If mcpic = True Then
            stag1.Image = fodummy.DefInstance.st3.Image
            Exit Sub
        End If
        mcpic = stag1.Image Is fodummy.DefInstance.st3.Image
        If mcpic = True Then
            stag1.Image = fodummy.DefInstance.st4.Image
            Exit Sub
        End If
        mcpic = stag1.Image Is fodummy.DefInstance.st4.Image
        If mcpic = True Then
            stag1.Image = fodummy.DefInstance.st1.Image
            Exit Sub
        End If
    End Sub
    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click
        Dim a
        a = PictureBox1.Image Is Nothing
        If a = True Then
            Exit Sub
        End If
        doinsertpic()
    End Sub
    Private Sub foform1_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        e.Cancel = True
        procclose()
    End Sub
    Private Sub caadv_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles caadv.Click
        Dim p As Point
        cmca.Show(caadv, p)
    End Sub
    Private Sub bnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bnew.Click
        procnew()
    End Sub
    Private Sub bopen_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bopen.Click
        procopen()
    End Sub
    Private Sub bsave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bsave.Click
        procsave()
    End Sub
    Private Sub mean1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mean1.Click
        text1.SelectedText = mean1.Text
    End Sub
    Private Sub amean1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles amean1.Click
        Dim ps As Point
        researchm1.Show(amean1, ps)
    End Sub
    Private Sub mean2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mean2.Click
        text1.SelectedText = mean2.Text
    End Sub
    Private Sub amean2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles amean2.Click
        Dim ps As Point
        researchm2.Show(amean2, ps)
    End Sub
    Private Sub textsearch_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles textsearch.KeyDown
        If e.KeyCode = Keys.Enter Then
            mnulookup_click(Me, e)
        End If
    End Sub
    Private Sub bcut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcut.Click
        text1.Cut()
    End Sub
    Private Sub text1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles text1.MouseDown
        If Button.MouseButtons = MouseButtons.Right Then
            stpanel1.Visible = False
            Dim a, b
            a = text1.SelectedText
            b = Microsoft.VisualBasic.LCase(a)
            forpopup(b, False)
            c.SetImageList = il2
            cmtext.MenuItems.Clear()
            Dim m1, m2, g
            m1 = fodummy.DefInstance.meaning1.Text
            m2 = fodummy.DefInstance.meaning2.Text
            g = fodummy.DefInstance.grammar.Text
            With cmtext.MenuItems
                .Add(New gscore10.mnuoff03blue(5, "Cut          ", handlerFile, Shortcut.CtrlX, False))
                .Add(New gscore10.mnuoff03blue(4, "Copy", handlerFile, Shortcut.None, False))
                .Add(New gscore10.mnuoff03blue(8, "Paste", handlerFile, Shortcut.None, True))
                .Add(New gscore10.mnuoff03blue(14, "&Font", handlerFile, Shortcut.None, True))
                .Add(New gscore10.mnuoff03blue("&Look up...", New System.EventHandler(AddressOf Me.mnulookup_click), False))
                .Add(New gscore10.mnuoff03blue("Meanings", handlerFile, Shortcut.None, False))
                Dim submenu1 As Menu
                submenu1 = cmtext.MenuItems(5)
                With submenu1.MenuItems
                    If m1 = "" Then
                        GoTo notm1
                    End If
                    .Add(New gscore10.mnuoff03blue(m1, etcm, False))
notm1:
                    If m2 = "" Then
                        GoTo notm2
                    End If
                    .Add(New gscore10.mnuoff03blue(m2, etcm, True))
notm2:
                    If g = "" Then
                        GoTo notg
                    End If
                    .Add(New gscore10.mnuoff03blue(g, forg, True))
notg:
                    .Add(New gscore10.mnuoff03blue("Thesaurus...", handlerFile, False))
                End With
                '  submenu1.MergeMenu(mea)
            End With
        End If
    End Sub
    Private Sub text1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles text1.KeyDown
        fodummy.DefInstance.saved.Text = "no"
        If e.KeyCode = Keys.Space Then
            Dim t
            text2.SelectAll()
            t = text2.SelectedText
            docheck(t)
            text2.Text = ""
            Exit Sub
        End If
        If e.KeyCode = Keys.Add Then
            text2.Text = text2.Text & "+"
            GoTo hidestpanel1
        End If
        If e.KeyCode = Keys.Alt Then
            GoTo hidestpanel1
        End If
        If e.KeyCode = Keys.Apps Then
            GoTo hidestpanel1
        End If
        If e.KeyCode = Keys.Back Then
            GoTo hidestpanel1
        End If
        If e.KeyCode = Keys.Enter Then
            GoTo hidestpanel1
        End If
        If e.KeyCode = Keys.F7 Then
            mnulookup_click(Me, e)
        End If
        Dim a, b, c
        a = e.KeyCode.ToString
        b = Microsoft.VisualBasic.LCase(a)
        text2.Text = text2.Text & b
hidestpanel1:
        stpanel1.Visible = False
    End Sub
    Private Sub text1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles text1.TextChanged
        fosaved.Text = "no"
    End Sub

    Private Sub text1_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkClickedEventArgs) Handles text1.LinkClicked
        Dim thelink As String
        thelink = e.LinkText
        Try
            System.Diagnostics.Process.Start(thelink)
        Catch exp As Exception
            MessageBox.Show(exp.Message, "An Error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub searchgo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles searchgo.Click
        mnulookup_click(Me, e)
    End Sub

    Private Sub bcopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bcopy.Click
        text1.Copy()
    End Sub

    Private Sub bpaste_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bpaste.Click
        text1.Paste()
    End Sub
End Class
