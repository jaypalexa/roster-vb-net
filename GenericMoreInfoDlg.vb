Option Explicit On 
Option Strict On
Option Compare Text

Public Class GenericMoreInfoDlg
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
    Friend WithEvents lblBody As System.Windows.Forms.Label
    Friend WithEvents picLeftHeaderTurtle As System.Windows.Forms.PictureBox
    Friend WithEvents picRightHeaderTurtle As System.Windows.Forms.PictureBox
    Friend WithEvents btnClose As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GenericMoreInfoDlg))
        Me.lblHeader = New System.Windows.Forms.Label
        Me.lblBody = New System.Windows.Forms.Label
        Me.picLeftHeaderTurtle = New System.Windows.Forms.PictureBox
        Me.picRightHeaderTurtle = New System.Windows.Forms.PictureBox
        Me.btnClose = New System.Windows.Forms.Button
        CType(Me.picLeftHeaderTurtle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightHeaderTurtle, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.lblHeader.Size = New System.Drawing.Size(698, 40)
        Me.lblHeader.TabIndex = 0
        Me.lblHeader.Text = "<set in Form_Load>"
        Me.lblHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblBody
        '
        Me.lblBody.BackColor = System.Drawing.Color.Honeydew
        Me.lblBody.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lblBody.ForeColor = System.Drawing.Color.DarkGreen
        Me.lblBody.Location = New System.Drawing.Point(0, 40)
        Me.lblBody.Name = "lblBody"
        Me.lblBody.Size = New System.Drawing.Size(698, 274)
        Me.lblBody.TabIndex = 1
        Me.lblBody.Text = "<set in Form_Load>"
        '
        'picLeftHeaderTurtle
        '
        Me.picLeftHeaderTurtle.Image = CType(resources.GetObject("picLeftHeaderTurtle.Image"), System.Drawing.Image)
        Me.picLeftHeaderTurtle.Location = New System.Drawing.Point(2, 2)
        Me.picLeftHeaderTurtle.Name = "picLeftHeaderTurtle"
        Me.picLeftHeaderTurtle.Size = New System.Drawing.Size(39, 34)
        Me.picLeftHeaderTurtle.TabIndex = 2
        Me.picLeftHeaderTurtle.TabStop = False
        '
        'picRightHeaderTurtle
        '
        Me.picRightHeaderTurtle.Image = CType(resources.GetObject("picRightHeaderTurtle.Image"), System.Drawing.Image)
        Me.picRightHeaderTurtle.Location = New System.Drawing.Point(657, 2)
        Me.picRightHeaderTurtle.Name = "picRightHeaderTurtle"
        Me.picRightHeaderTurtle.Size = New System.Drawing.Size(39, 34)
        Me.picRightHeaderTurtle.TabIndex = 3
        Me.picRightHeaderTurtle.TabStop = False
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(616, 280)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 24)
        Me.btnClose.TabIndex = 2
        Me.btnClose.Text = "&Close"
        '
        'GenericMoreInfoDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(698, 314)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.picRightHeaderTurtle)
        Me.Controls.Add(Me.picLeftHeaderTurtle)
        Me.Controls.Add(Me.lblBody)
        Me.Controls.Add(Me.lblHeader)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "GenericMoreInfoDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "More Information"
        CType(Me.picLeftHeaderTurtle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightHeaderTurtle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Public HeaderText As String = String.Empty
    Public BodyText As String = String.Empty

    Private Sub frmGenericMoreInfoDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.lblHeader.Text = HeaderText
        Me.lblBody.Text = BodyText

    End Sub

    Private Sub frmGenericMoreInfoDlg_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

End Class
