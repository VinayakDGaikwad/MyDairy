Imports System.Drawing.Drawing2D
Public Class fofirst
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
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(fofirst))
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Timer1
        '
        Me.Timer1.Interval = 2500
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(129, 83)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 30)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Gurusted"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(2, 125)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(420, 26)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Foroffice Codenamed ""Style2003"""
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(106, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 23)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Copyright Guruparan,2003-2004"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(100, 188)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 16)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "www.geocities.com/gurusted"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(83, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(233, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "For more information and latest version  goto:"
        '
        'fofirst
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Gainsboro
        Me.ClientSize = New System.Drawing.Size(412, 272)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1})
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "fofirst"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Foroffice"
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Shared m_vb6FormDefInstance As fofirst
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As fofirst
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New fofirst()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As fofirst)
            m_vb6FormDefInstance = Value
        End Set
    End Property
    Private Sub normalguiinit()
        Dim errw, errh
        errw = Windows.Forms.Screen.PrimaryScreen.Bounds.Width
        errh = Windows.Forms.Screen.PrimaryScreen.Bounds.Height
        If errw < 700 Then
            MessageBox.Show("Screen resolution is minimum than 800 x 600", "Display Settings", MessageBoxButtons.OK, MessageBoxIcon.Error)
            '  End
            '   Exit Sub
        End If
        Timer1.Enabled = True
    End Sub

    Private Sub fofirst_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        normalguiinit()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Me.Hide()
        foform1.DefInstance.Show()
        foform1.DefInstance.Focus()
        Timer1.Enabled = False
    End Sub
    Private Sub fofirst_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim mypen As New Pen(Color.Black, 3)
        Dim myrect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim c1, c2 As Color
        c1 = Color.Red
        c2 = Color.Orange
        Dim mybrush As New LinearGradientBrush(myrect, c1, c2, LinearGradientMode.BackwardDiagonal)
        e.Graphics.DrawRectangle(mypen, myrect)
        e.Graphics.FillRectangle(mybrush, myrect)
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        On Error GoTo err
        Dim thisfile As String, retval
        thisfile = Label5.Text
        retval = System.Diagnostics.Process.Start(thisfile)
        Exit Sub
err:
        MessageBox.Show("Cannot open www.geocities.com/gurusted,Please connect to internet and try again", "Cannot open,Please connect to internet", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
