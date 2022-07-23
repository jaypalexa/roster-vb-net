<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrintPreviewDlg
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(PrintPreviewDlg))
        Me.pvwPrintPreviewControl = New System.Windows.Forms.PrintPreviewControl()
        Me.cboZoomList = New System.Windows.Forms.ComboBox()
        Me.lblZoom = New System.Windows.Forms.Label()
        Me.lblCopies = New System.Windows.Forms.Label()
        Me.nudCopies = New System.Windows.Forms.NumericUpDown()
        Me.btnPrint = New System.Windows.Forms.Button()
        Me.btnFirstPage = New System.Windows.Forms.Button()
        Me.btnPreviousPage = New System.Windows.Forms.Button()
        Me.btnLastPage = New System.Windows.Forms.Button()
        Me.btnNextPage = New System.Windows.Forms.Button()
        Me.lblPage = New System.Windows.Forms.Label()
        Me.btnClose = New System.Windows.Forms.Button()
        CType(Me.nudCopies, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'pvwPrintPreviewControl
        '
        Me.pvwPrintPreviewControl.Anchor = (((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right)
        Me.pvwPrintPreviewControl.AutoZoom = False
        Me.pvwPrintPreviewControl.Location = New System.Drawing.Point(8, 40)
        Me.pvwPrintPreviewControl.Name = "pvwPrintPreviewControl"
        Me.pvwPrintPreviewControl.Size = New System.Drawing.Size(616, 376)
        Me.pvwPrintPreviewControl.TabIndex = 11
        Me.pvwPrintPreviewControl.Zoom = 0.30000001192092896
        '
        'cboZoomList
        '
        Me.cboZoomList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboZoomList.Location = New System.Drawing.Point(240, 8)
        Me.cboZoomList.Name = "cboZoomList"
        Me.cboZoomList.Size = New System.Drawing.Size(72, 21)
        Me.cboZoomList.TabIndex = 6
        '
        'lblZoom
        '
        Me.lblZoom.AutoSize = True
        Me.lblZoom.Location = New System.Drawing.Point(200, 12)
        Me.lblZoom.Name = "lblZoom"
        Me.lblZoom.Size = New System.Drawing.Size(36, 13)
        Me.lblZoom.TabIndex = 5
        Me.lblZoom.Text = "Zoom:"
        '
        'lblCopies
        '
        Me.lblCopies.AutoSize = True
        Me.lblCopies.Location = New System.Drawing.Point(328, 12)
        Me.lblCopies.Name = "lblCopies"
        Me.lblCopies.Size = New System.Drawing.Size(43, 13)
        Me.lblCopies.TabIndex = 7
        Me.lblCopies.Text = "Copies:"
        '
        'nudCopies
        '
        Me.nudCopies.Location = New System.Drawing.Point(376, 9)
        Me.nudCopies.Name = "nudCopies"
        Me.nudCopies.Size = New System.Drawing.Size(56, 20)
        Me.nudCopies.TabIndex = 8
        '
        'btnPrint
        '
        Me.btnPrint.Location = New System.Drawing.Point(440, 8)
        Me.btnPrint.Name = "btnPrint"
        Me.btnPrint.Size = New System.Drawing.Size(64, 21)
        Me.btnPrint.TabIndex = 9
        Me.btnPrint.Text = "Print..."
        '
        'btnFirstPage
        '
        Me.btnFirstPage.Image = CType(resources.GetObject("btnFirstPage.Image"), System.Drawing.Bitmap)
        Me.btnFirstPage.Location = New System.Drawing.Point(8, 8)
        Me.btnFirstPage.Name = "btnFirstPage"
        Me.btnFirstPage.Size = New System.Drawing.Size(24, 24)
        Me.btnFirstPage.TabIndex = 0
        '
        'btnPreviousPage
        '
        Me.btnPreviousPage.Image = CType(resources.GetObject("btnPreviousPage.Image"), System.Drawing.Bitmap)
        Me.btnPreviousPage.Location = New System.Drawing.Point(32, 8)
        Me.btnPreviousPage.Name = "btnPreviousPage"
        Me.btnPreviousPage.Size = New System.Drawing.Size(24, 24)
        Me.btnPreviousPage.TabIndex = 1
        '
        'btnLastPage
        '
        Me.btnLastPage.Image = CType(resources.GetObject("btnLastPage.Image"), System.Drawing.Bitmap)
        Me.btnLastPage.Location = New System.Drawing.Point(152, 8)
        Me.btnLastPage.Name = "btnLastPage"
        Me.btnLastPage.Size = New System.Drawing.Size(24, 24)
        Me.btnLastPage.TabIndex = 4
        '
        'btnNextPage
        '
        Me.btnNextPage.Image = CType(resources.GetObject("btnNextPage.Image"), System.Drawing.Bitmap)
        Me.btnNextPage.Location = New System.Drawing.Point(128, 8)
        Me.btnNextPage.Name = "btnNextPage"
        Me.btnNextPage.Size = New System.Drawing.Size(24, 24)
        Me.btnNextPage.TabIndex = 3
        '
        'lblPage
        '
        Me.lblPage.Location = New System.Drawing.Point(56, 12)
        Me.lblPage.Name = "lblPage"
        Me.lblPage.Size = New System.Drawing.Size(72, 13)
        Me.lblPage.TabIndex = 2
        Me.lblPage.Text = "0 of 0"
        Me.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnClose
        '
        Me.btnClose.Anchor = (System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(560, 8)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(64, 21)
        Me.btnClose.TabIndex = 10
        Me.btnClose.Text = "Close"
        '
        'PrintPreviewDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(632, 421)
        Me.Controls.AddRange(New System.Windows.Forms.Control() {Me.btnClose, Me.lblPage, Me.btnLastPage, Me.btnNextPage, Me.btnPreviousPage, Me.btnFirstPage, Me.btnPrint, Me.lblCopies, Me.nudCopies, Me.lblZoom, Me.cboZoomList, Me.pvwPrintPreviewControl})
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "PrintPreviewDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Print Preview"
        CType(Me.nudCopies, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pvwPrintPreviewControl As System.Windows.Forms.PrintPreviewControl
    Friend WithEvents cboZoomList As System.Windows.Forms.ComboBox
    Friend WithEvents lblZoom As System.Windows.Forms.Label
    Friend WithEvents lblCopies As System.Windows.Forms.Label
    Friend WithEvents nudCopies As System.Windows.Forms.NumericUpDown
    Friend WithEvents btnPrint As System.Windows.Forms.Button
    Friend WithEvents btnFirstPage As System.Windows.Forms.Button
    Friend WithEvents btnPreviousPage As System.Windows.Forms.Button
    Friend WithEvents btnLastPage As System.Windows.Forms.Button
    Friend WithEvents btnNextPage As System.Windows.Forms.Button
    Friend WithEvents lblPage As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
End Class
