Option Explicit On 
Option Strict On
Option Compare Text

Public Class EulaDlg
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
    Friend WithEvents lblHeader As System.Windows.Forms.Label
    Friend WithEvents rtxEula As System.Windows.Forms.RichTextBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(EulaDlg))
        Me.lblHeader = New System.Windows.Forms.Label
        Me.rtxEula = New System.Windows.Forms.RichTextBox
        Me.SuspendLayout()
        '
        'lblHeader
        '
        Me.lblHeader.BackColor = System.Drawing.Color.LightGreen
        Me.lblHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.lblHeader.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeader.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblHeader.Location = New System.Drawing.Point(0, 0)
        Me.lblHeader.Name = "lblHeader"
        Me.lblHeader.Size = New System.Drawing.Size(794, 40)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "*** END-USER LICENSE AGREEMENT ***"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rtxEula
        '
        Me.rtxEula.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.rtxEula.Location = New System.Drawing.Point(8, 48)
        Me.rtxEula.Name = "rtxEula"
        Me.rtxEula.ReadOnly = True
        Me.rtxEula.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical
        Me.rtxEula.Size = New System.Drawing.Size(776, 520)
        Me.rtxEula.TabIndex = 1
        Me.rtxEula.Text = ""
        '
        'frmEulaDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackColor = System.Drawing.Color.Honeydew
        Me.ClientSize = New System.Drawing.Size(794, 578)
        Me.Controls.Add(Me.rtxEula)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmEulaDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "End-User License Agreement"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmEulaDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim sEulaRtfFile As String = String.Empty
        Dim oStream As System.IO.Stream
        Dim oStreamReader As System.IO.StreamReader

        Try
            sEulaRtfFile = System.Reflection.MethodBase.GetCurrentMethod().ReflectedType.Namespace.ToString & ".EULA.rtf"

            oStream = Me.GetType().Assembly.GetManifestResourceStream(sEulaRtfFile)

            If Not (oStream Is Nothing) Then

                oStreamReader = New System.IO.StreamReader(oStream)

                Me.rtxEula.LoadFile(oStream, RichTextBoxStreamType.RichText)

                oStreamReader.Close()
                oStreamReader = Nothing

                oStream.Close()
                oStream = Nothing

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub frmEulaDlg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub rtxEula_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles rtxEula.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

End Class
