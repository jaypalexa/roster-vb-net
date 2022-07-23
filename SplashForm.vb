Option Explicit On 
Option Strict On
Option Compare Text

Imports System
Imports System.Data
Imports System.Windows.Forms

Public Class frmSplashForm
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
    Friend WithEvents picRosterLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblRoster As System.Windows.Forms.Label
    Friend WithEvents lblMessage As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSplashForm))
        Me.lblMessage = New System.Windows.Forms.Label
        Me.picRosterLogo = New System.Windows.Forms.PictureBox
        Me.lblRoster = New System.Windows.Forms.Label
        CType(Me.picRosterLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMessage
        '
        Me.lblMessage.BackColor = System.Drawing.Color.Honeydew
        Me.lblMessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMessage.Location = New System.Drawing.Point(16, 72)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(248, 23)
        Me.lblMessage.TabIndex = 3
        Me.lblMessage.Text = "Loading ROSTER..."
        Me.lblMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picRosterLogo
        '
        Me.picRosterLogo.Image = CType(resources.GetObject("picRosterLogo.Image"), System.Drawing.Image)
        Me.picRosterLogo.Location = New System.Drawing.Point(8, 8)
        Me.picRosterLogo.Name = "picRosterLogo"
        Me.picRosterLogo.Size = New System.Drawing.Size(44, 38)
        Me.picRosterLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRosterLogo.TabIndex = 4
        Me.picRosterLogo.TabStop = False
        '
        'lblRoster
        '
        Me.lblRoster.Font = New System.Drawing.Font("Verdana", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoster.ForeColor = System.Drawing.Color.DarkOliveGreen
        Me.lblRoster.Location = New System.Drawing.Point(40, 8)
        Me.lblRoster.Name = "lblRoster"
        Me.lblRoster.Size = New System.Drawing.Size(192, 56)
        Me.lblRoster.TabIndex = 5
        Me.lblRoster.Text = "ROSTER"
        Me.lblRoster.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frmSplashForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(6, 13)
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(274, 106)
        Me.ControlBox = False
        Me.Controls.Add(Me.picRosterLogo)
        Me.Controls.Add(Me.lblRoster)
        Me.Controls.Add(Me.lblMessage)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplashForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picRosterLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmSplashForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.WaitCursor
        Me.Refresh()
        Application.DoEvents()
    End Sub

    Private Sub frmSplashForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing
        System.Windows.Forms.Cursor.Current = System.Windows.Forms.Cursors.Default
    End Sub

    Public Sub SetMessage(Optional ByVal vsMessage As String = "")
        If (vsMessage.Trim.Length > 0) Then
            Me.lblMessage.Text = vsMessage
        Else
            Me.lblMessage.Text = "Loading ROSTER..."
        End If

        Me.Refresh()
        Application.DoEvents()
    End Sub

End Class
