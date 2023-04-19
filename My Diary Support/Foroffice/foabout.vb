Imports System.Drawing.Drawing2D
Public Class foabout
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
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(foabout))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.AccessibleDescription = ""
        Me.Button1.AccessibleName = ""
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Location = New System.Drawing.Point(344, 264)
        Me.Button1.Name = "Button1"
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Ok"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Verdana", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(18, 106)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 26)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Foroffice Codenamed ""Style2003"""
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Verdana", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(64, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(136, 30)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Gurusted"
        '
        'Label3
        '
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(116, 163)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(192, 23)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Copyright Guruparan,2003-2004"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(61, 202)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(269, 14)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "For more information and latest version  goto:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Label5.Font = New System.Drawing.Font("Verdana", 9.75!, (System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Blue
        Me.Label5.Location = New System.Drawing.Point(78, 230)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(229, 16)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "www.geocities.com/gurusted"
        '
        'foabout
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 14)
        Me.ClientSize = New System.Drawing.Size(450, 312)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.Label5, Me.Label4, Me.Label3, Me.Label2, Me.Label1, Me.Button1})
        Me.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "foabout"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub

#End Region
    Private Shared m_vb6FormDefInstance As foabout
    Private Shared m_InitializingDefInstance As Boolean
    Public Shared Property DefInstance() As foabout
        Get
            If m_vb6FormDefInstance Is Nothing OrElse m_vb6FormDefInstance.IsDisposed Then
                m_InitializingDefInstance = True
                m_vb6FormDefInstance = New foabout()
                m_InitializingDefInstance = False
            End If
            DefInstance = m_vb6FormDefInstance
        End Get
        Set(ByVal Value As foabout)
            m_vb6FormDefInstance = Value
        End Set
    End Property

    Private Sub foabout_Paint(ByVal sender As Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles MyBase.Paint
        Dim myrect As New Rectangle(0, 0, Me.Width, Me.Height)
        Dim mypen As New Pen(Color.Black, 3)
        Dim c1, c2 As Color
        c1 = Color.Red
        c2 = Color.Orange
        Dim mybrush As New LinearGradientBrush(myrect, c1, c2, LinearGradientMode.BackwardDiagonal)
        e.Graphics.DrawRectangle(mypen, myrect)
        e.Graphics.FillRectangle(mybrush, myrect)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        On Error GoTo err
        Dim thisfile As String, retval
        thisfile = Label5.Text
        retval = System.Diagnostics.Process.Start(thisfile)
        Me.Close()
        Exit Sub
err:
        MessageBox.Show("Cannot open www.geocities.com/gurusted,Please connect to internet and try again", "Cannot open,Please connect to internet", MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub
End Class
