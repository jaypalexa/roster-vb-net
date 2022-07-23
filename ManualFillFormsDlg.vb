Option Explicit On 
Option Strict On
Option Compare Text

Imports System.Text

Public Class ManualFillFormsDlg
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New(ByVal vsMasterFormFileName As String)

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        msMasterFormFileName = vsMasterFormFileName

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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblSeparator As System.Windows.Forms.Label
    Friend WithEvents tipToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents tabReportTab As System.Windows.Forms.TabControl
    Friend WithEvents tpgActions As System.Windows.Forms.TabPage
    Friend WithEvents tpgSavedReports As System.Windows.Forms.TabPage
    Friend WithEvents picMoreInfoReport As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblDateThru As System.Windows.Forms.Label
    Friend WithEvents lblDateFrom As System.Windows.Forms.Label
    Friend WithEvents radFillManually As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDateThru As TurtleGeek.Controls.DateComboBox
    Friend WithEvents dtpDateFrom As TurtleGeek.Controls.DateComboBox
    Friend WithEvents radFillDatabase As System.Windows.Forms.RadioButton
    Friend WithEvents grdSavedReportsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents SavedReportGridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colSavedReportEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colSavedReportDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colSavedReportReportFileNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSavedReportDateOfReportDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnDebug As System.Windows.Forms.Button
    Friend WithEvents lblSavedReportsList As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ManualFillFormsDlg))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnCreate = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.tipToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.picMoreInfoReport = New System.Windows.Forms.PictureBox
        Me.btnHelp = New System.Windows.Forms.Button
        Me.tabReportTab = New System.Windows.Forms.TabControl
        Me.tpgActions = New System.Windows.Forms.TabPage
        Me.lblDateThru = New System.Windows.Forms.Label
        Me.lblDateFrom = New System.Windows.Forms.Label
        Me.radFillManually = New System.Windows.Forms.RadioButton
        Me.dtpDateThru = New TurtleGeek.Controls.DateComboBox
        Me.dtpDateFrom = New TurtleGeek.Controls.DateComboBox
        Me.radFillDatabase = New System.Windows.Forms.RadioButton
        Me.lblDescription = New System.Windows.Forms.Label
        Me.tpgSavedReports = New System.Windows.Forms.TabPage
        Me.grdSavedReportsGrid = New System.Windows.Forms.DataGridView
        Me.colSavedReportDeleteActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.lblSavedReportsList = New System.Windows.Forms.Label
        Me.btnDebug = New System.Windows.Forms.Button
        Me.colSavedReportEditActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colSavedReportReportFileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSavedReportDateOfReportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SavedReportGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.picMoreInfoReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReportTab.SuspendLayout()
        Me.tpgActions.SuspendLayout()
        Me.tpgSavedReports.SuspendLayout()
        CType(Me.grdSavedReportsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavedReportGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.Location = New System.Drawing.Point(360, 200)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(72, 24)
        Me.btnCreate.TabIndex = 17
        Me.btnCreate.Text = "Create"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(440, 200)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 24)
        Me.btnClose.TabIndex = 18
        Me.btnClose.Text = "Close"
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(8, 184)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(504, 2)
        Me.lblSeparator.TabIndex = 15
        '
        'picMoreInfoReport
        '
        Me.picMoreInfoReport.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoReport.Image = CType(resources.GetObject("picMoreInfoReport.Image"), System.Drawing.Image)
        Me.picMoreInfoReport.Location = New System.Drawing.Point(16, 18)
        Me.picMoreInfoReport.Name = "picMoreInfoReport"
        Me.picMoreInfoReport.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoReport.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoReport.TabIndex = 53
        Me.picMoreInfoReport.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoReport, "More information about the Marine SavedReport Holding Facility Quarterly Report")
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(8, 200)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 24)
        Me.btnHelp.TabIndex = 16
        Me.btnHelp.Text = "Help"
        '
        'tabReportTab
        '
        Me.tabReportTab.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabReportTab.Controls.Add(Me.tpgActions)
        Me.tabReportTab.Controls.Add(Me.tpgSavedReports)
        Me.tabReportTab.Location = New System.Drawing.Point(8, 8)
        Me.tabReportTab.Name = "tabReportTab"
        Me.tabReportTab.SelectedIndex = 0
        Me.tabReportTab.Size = New System.Drawing.Size(504, 168)
        Me.tabReportTab.TabIndex = 0
        '
        'tpgActions
        '
        Me.tpgActions.Controls.Add(Me.lblDateThru)
        Me.tpgActions.Controls.Add(Me.lblDateFrom)
        Me.tpgActions.Controls.Add(Me.radFillManually)
        Me.tpgActions.Controls.Add(Me.dtpDateThru)
        Me.tpgActions.Controls.Add(Me.dtpDateFrom)
        Me.tpgActions.Controls.Add(Me.radFillDatabase)
        Me.tpgActions.Controls.Add(Me.picMoreInfoReport)
        Me.tpgActions.Controls.Add(Me.lblDescription)
        Me.tpgActions.Location = New System.Drawing.Point(4, 22)
        Me.tpgActions.Name = "tpgActions"
        Me.tpgActions.Size = New System.Drawing.Size(496, 142)
        Me.tpgActions.TabIndex = 0
        Me.tpgActions.Text = "Actions"
        Me.tpgActions.UseVisualStyleBackColor = True
        '
        'lblDateThru
        '
        Me.lblDateThru.AutoSize = True
        Me.lblDateThru.Enabled = False
        Me.lblDateThru.Location = New System.Drawing.Point(232, 68)
        Me.lblDateThru.Name = "lblDateThru"
        Me.lblDateThru.Size = New System.Drawing.Size(54, 13)
        Me.lblDateThru.TabIndex = 4
        Me.lblDateThru.Text = "Date thru:"
        '
        'lblDateFrom
        '
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.Enabled = False
        Me.lblDateFrom.Location = New System.Drawing.Point(40, 68)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(56, 13)
        Me.lblDateFrom.TabIndex = 2
        Me.lblDateFrom.Text = "Date from:"
        '
        'radFillManually
        '
        Me.radFillManually.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radFillManually.Checked = True
        Me.radFillManually.Location = New System.Drawing.Point(16, 96)
        Me.radFillManually.Name = "radFillManually"
        Me.radFillManually.Size = New System.Drawing.Size(472, 32)
        Me.radFillManually.TabIndex = 6
        Me.radFillManually.TabStop = True
        Me.radFillManually.Text = "Fill out the report manually."
        '
        'dtpDateThru
        '
        Me.dtpDateThru.BackColor = System.Drawing.SystemColors.Window
        Me.dtpDateThru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dtpDateThru.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtpDateThru.DateValue = New Date(2006, 5, 31, 0, 0, 0, 0)
        Me.dtpDateThru.Enabled = False
        Me.dtpDateThru.Location = New System.Drawing.Point(288, 64)
        Me.dtpDateThru.MaxValue = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateThru.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateThru.Name = "dtpDateThru"
        Me.dtpDateThru.Size = New System.Drawing.Size(96, 20)
        Me.dtpDateThru.TabIndex = 5
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.BackColor = System.Drawing.SystemColors.Window
        Me.dtpDateFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dtpDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtpDateFrom.DateValue = New Date(2006, 5, 31, 0, 0, 0, 0)
        Me.dtpDateFrom.Enabled = False
        Me.dtpDateFrom.Location = New System.Drawing.Point(104, 64)
        Me.dtpDateFrom.MaxValue = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateFrom.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(96, 20)
        Me.dtpDateFrom.TabIndex = 3
        '
        'radFillDatabase
        '
        Me.radFillDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radFillDatabase.Enabled = False
        Me.radFillDatabase.Location = New System.Drawing.Point(16, 43)
        Me.radFillDatabase.Name = "radFillDatabase"
        Me.radFillDatabase.Size = New System.Drawing.Size(472, 21)
        Me.radFillDatabase.TabIndex = 1
        Me.radFillDatabase.Text = "[COMING SOON] Populate the report using the information that is stored in the dat" & _
            "abase."
        '
        'lblDescription
        '
        Me.lblDescription.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDescription.ForeColor = System.Drawing.Color.Green
        Me.lblDescription.Location = New System.Drawing.Point(16, 8)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(472, 32)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "Select a method to populate the report and then click 'Create' to generate the re" & _
            "port form."
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpgSavedReports
        '
        Me.tpgSavedReports.Controls.Add(Me.grdSavedReportsGrid)
        Me.tpgSavedReports.Controls.Add(Me.lblSavedReportsList)
        Me.tpgSavedReports.Location = New System.Drawing.Point(4, 22)
        Me.tpgSavedReports.Name = "tpgSavedReports"
        Me.tpgSavedReports.Size = New System.Drawing.Size(496, 142)
        Me.tpgSavedReports.TabIndex = 2
        Me.tpgSavedReports.Text = "Saved Reports"
        Me.tpgSavedReports.UseVisualStyleBackColor = True
        '
        'grdSavedReportsGrid
        '
        Me.grdSavedReportsGrid.AllowUserToAddRows = False
        Me.grdSavedReportsGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdSavedReportsGrid.AutoGenerateColumns = False
        Me.grdSavedReportsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdSavedReportsGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colSavedReportEditActionDataGridViewLinkColumn, Me.colSavedReportDeleteActionDataGridViewLinkColumn, Me.colSavedReportReportFileNameDataGridViewTextBoxColumn, Me.colSavedReportDateOfReportDataGridViewTextBoxColumn, Me.colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn})
        Me.grdSavedReportsGrid.DataSource = Me.SavedReportGridBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdSavedReportsGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdSavedReportsGrid.Location = New System.Drawing.Point(8, 24)
        Me.grdSavedReportsGrid.MultiSelect = False
        Me.grdSavedReportsGrid.Name = "grdSavedReportsGrid"
        Me.grdSavedReportsGrid.ReadOnly = True
        Me.grdSavedReportsGrid.RowHeadersVisible = False
        Me.grdSavedReportsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSavedReportsGrid.Size = New System.Drawing.Size(480, 112)
        Me.grdSavedReportsGrid.TabIndex = 1
        '
        'colSavedReportDeleteActionDataGridViewLinkColumn
        '
        Me.colSavedReportDeleteActionDataGridViewLinkColumn.DataPropertyName = "DeleteAction"
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colSavedReportDeleteActionDataGridViewLinkColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.colSavedReportDeleteActionDataGridViewLinkColumn.Frozen = True
        Me.colSavedReportDeleteActionDataGridViewLinkColumn.HeaderText = ""
        Me.colSavedReportDeleteActionDataGridViewLinkColumn.Name = "colSavedReportDeleteActionDataGridViewLinkColumn"
        Me.colSavedReportDeleteActionDataGridViewLinkColumn.ReadOnly = True
        Me.colSavedReportDeleteActionDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colSavedReportDeleteActionDataGridViewLinkColumn.TrackVisitedState = False
        Me.colSavedReportDeleteActionDataGridViewLinkColumn.Width = 40
        '
        'lblSavedReportsList
        '
        Me.lblSavedReportsList.AutoSize = True
        Me.lblSavedReportsList.Location = New System.Drawing.Point(8, 8)
        Me.lblSavedReportsList.Name = "lblSavedReportsList"
        Me.lblSavedReportsList.Size = New System.Drawing.Size(125, 13)
        Me.lblSavedReportsList.TabIndex = 0
        Me.lblSavedReportsList.Text = "Previously saved reports:"
        '
        'btnDebug
        '
        Me.btnDebug.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDebug.Location = New System.Drawing.Point(86, 200)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(72, 24)
        Me.btnDebug.TabIndex = 19
        Me.btnDebug.Text = "Debug"
        Me.btnDebug.Visible = False
        '
        'colSavedReportEditActionDataGridViewLinkColumn
        '
        Me.colSavedReportEditActionDataGridViewLinkColumn.DataPropertyName = "EditAction"
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colSavedReportEditActionDataGridViewLinkColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.colSavedReportEditActionDataGridViewLinkColumn.Frozen = True
        Me.colSavedReportEditActionDataGridViewLinkColumn.HeaderText = ""
        Me.colSavedReportEditActionDataGridViewLinkColumn.Name = "colSavedReportEditActionDataGridViewLinkColumn"
        Me.colSavedReportEditActionDataGridViewLinkColumn.ReadOnly = True
        Me.colSavedReportEditActionDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colSavedReportEditActionDataGridViewLinkColumn.TrackVisitedState = False
        Me.colSavedReportEditActionDataGridViewLinkColumn.Width = 40
        '
        'colSavedReportReportFileNameDataGridViewTextBoxColumn
        '
        Me.colSavedReportReportFileNameDataGridViewTextBoxColumn.DataPropertyName = "ReportFileName"
        Me.colSavedReportReportFileNameDataGridViewTextBoxColumn.HeaderText = "ReportFileName"
        Me.colSavedReportReportFileNameDataGridViewTextBoxColumn.Name = "colSavedReportReportFileNameDataGridViewTextBoxColumn"
        Me.colSavedReportReportFileNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.colSavedReportReportFileNameDataGridViewTextBoxColumn.Visible = False
        '
        'colSavedReportDateOfReportDataGridViewTextBoxColumn
        '
        Me.colSavedReportDateOfReportDataGridViewTextBoxColumn.DataPropertyName = "DateOfReport"
        DataGridViewCellStyle3.Format = "G"
        DataGridViewCellStyle3.NullValue = Nothing
        Me.colSavedReportDateOfReportDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle3
        Me.colSavedReportDateOfReportDataGridViewTextBoxColumn.HeaderText = "Date Created"
        Me.colSavedReportDateOfReportDataGridViewTextBoxColumn.Name = "colSavedReportDateOfReportDataGridViewTextBoxColumn"
        Me.colSavedReportDateOfReportDataGridViewTextBoxColumn.ReadOnly = True
        Me.colSavedReportDateOfReportDataGridViewTextBoxColumn.Width = 200
        '
        'colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn
        '
        Me.colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn.DataPropertyName = "DisplayDateOfReport"
        Me.colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn.HeaderText = "DisplayDateOfReport"
        Me.colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn.Name = "colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn"
        Me.colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn.ReadOnly = True
        Me.colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn.Visible = False
        '
        'SavedReportGridBindingSource
        '
        Me.SavedReportGridBindingSource.DataSource = GetType(TurtleGeek.Roster.SavedReportItems)
        '
        'ManualFillFormsDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(522, 239)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.tabReportTab)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ManualFillFormsDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "<form caption set in Form_Load()>"
        CType(Me.picMoreInfoReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReportTab.ResumeLayout(False)
        Me.tpgActions.ResumeLayout(False)
        Me.tpgActions.PerformLayout()
        Me.tpgSavedReports.ResumeLayout(False)
        Me.tpgSavedReports.PerformLayout()
        CType(Me.grdSavedReportsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavedReportGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private msMasterFormFileName As String = String.Empty
    Private msFormTitle As String = String.Empty

    Private Sub frmManualFillFormsDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim iCurrentMonth As Integer
        Dim iCurrentMonthDiff As Integer
        Dim dtDateTimeNow As Date
        Dim dtDateTimeLastMonthOfLastQuarter As Date

        '----------------------------------------------------------------
        '-- get the form title from the file name
        '----------------------------------------------------------------
        msFormTitle = msMasterFormFileName.Replace("MASTER - ", "").Replace(".master.pdf", "")
        Me.Text = msFormTitle

        '----------------------------------------------------------------
        '-- initialize the report dates to last quarter
        '----------------------------------------------------------------
        dtDateTimeNow = DateTime.Now

        iCurrentMonth = dtDateTimeNow.Month
        iCurrentMonthDiff = iCurrentMonth Mod 3
        If (iCurrentMonthDiff = 0) Then
            iCurrentMonthDiff = 3
        End If

        dtDateTimeLastMonthOfLastQuarter = New Date(dtDateTimeNow.AddMonths(-iCurrentMonthDiff).Year, dtDateTimeNow.AddMonths(-iCurrentMonthDiff).Month, DateTime.DaysInMonth(dtDateTimeNow.AddMonths(-iCurrentMonthDiff).Year, dtDateTimeNow.AddMonths(-iCurrentMonthDiff).Month), 0, 0, 0)

        dtpDateThru.DateValue = dtDateTimeLastMonthOfLastQuarter
        dtpDateFrom.DateValue = New Date(dtDateTimeLastMonthOfLastQuarter.AddDays(1).AddMonths(-3).Year, dtDateTimeLastMonthOfLastQuarter.AddDays(1).AddMonths(-3).Month, 1, 0, 0, 0)

        '----------------------------------------------------------------
        '----------------------------------------------------------------
        SetControlState()

        '----------------------------------------------------------------
        '-- populate the list of saved reports
        '----------------------------------------------------------------
        LoadSavedReportGridData()

    End Sub

    Private Sub radFillManually_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFillManually.CheckedChanged
        SetControlState()
    End Sub

    Private Sub radFillDatabase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFillDatabase.CheckedChanged
        SetControlState()
    End Sub

    Private Sub SetControlState()
        ''dtpDateFrom.Enabled = radFillDatabase.Checked
        ''dtpDateThru.Enabled = radFillDatabase.Checked
        radFillDatabase.Enabled = False
        lblDateFrom.Enabled = False
        dtpDateFrom.Enabled = False
        lblDateThru.Enabled = False
        dtpDateThru.Enabled = False
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        Dim sManuallyFilledFormFileName As String = String.Empty

        Try

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- display the field-ready PDF file
            '----------------------------------------------------------------
            sManuallyFilledFormFileName = msMasterFormFileName.Replace("MASTER - ", "FILLED - ").Replace(".master.pdf", " - " & Now.ToString("yyyyMMddHHmmss") & ".pdf")
            System.IO.File.Copy(msMasterFormFileName, sManuallyFilledFormFileName)
            System.Diagnostics.Process.Start(sManuallyFilledFormFileName)

            '----------------------------------------------------------------
            '-- refresh the saved report list
            '----------------------------------------------------------------
            LoadSavedReportGridData()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub picMoreInfoReport_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoReport.Click

        Dim sb As New StringBuilder
        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = msFormTitle

            sb.Append("Directions:  Fill out the report form manually and save it.  To view the report form again, go to the Saved Reports tab.")
            sb.Append(ControlChars.CrLf)
            sb.Append(ControlChars.CrLf)
            frm.BodyText = sb.ToString
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "FillingOutReportsAndForms.htm")
    End Sub

#Region " Saved Reports Grid "

    Private Sub LoadSavedReportGridData()

        Try
            Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- add the data to the grid
            '----------------------------------------------------------------
            Me.SavedReportGridBindingSource.DataSource = SavedReportItems.GetList("view", msFormTitle)

        Catch ex As Exception
            ErrorMessageBox.Show(ex)

        Finally
            Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub grdSavedReportDataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdSavedReportsGrid.DoubleClick

        Dim oPoint As Point = Me.grdSavedReportsGrid.PointToClient(Cursor.Position)
        Dim oHitTestInfo As DataGridView.HitTestInfo = Me.grdSavedReportsGrid.HitTest(oPoint.X, oPoint.Y)

        '----------------------------------------------------------------
        '-- only edit the record if a data row cell was double-clicked
        '-- (we do this to allow a double click of the column separator to resize the column)
        '----------------------------------------------------------------
        If (oHitTestInfo.Type = DataGridViewHitTestType.Cell) Then
            EditSavedReport()
        End If

    End Sub

    Private Sub EditSavedReport()

        Dim sReportFileName As String = String.Empty

        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdSavedReportsGrid.SelectedRows.Count > 0) Then

                sReportFileName = Convert.ToString(grdSavedReportsGrid.SelectedRows(0).Cells(Me.colSavedReportReportFileNameDataGridViewTextBoxColumn.Name).Value)

                If System.IO.File.Exists(sReportFileName) Then
                    System.Diagnostics.Process.Start(sReportFileName)
                End If

                '-- this updates the grid
                LoadSavedReportGridData()

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub DeleteSavedReport()

        Dim sReportFileName As String = String.Empty
        Dim oDialogResult As DialogResult

        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdSavedReportsGrid.SelectedRows.Count > 0) Then

                sReportFileName = Convert.ToString(grdSavedReportsGrid.SelectedRows(0).Cells(colSavedReportReportFileNameDataGridViewTextBoxColumn.Name).Value)

                oDialogResult = MessageBox.Show("Are you sure you want to delete the report generated on " & Convert.ToString(grdSavedReportsGrid.SelectedRows(0).Cells(Me.colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn.Name).Value) & "?  This is a permanent action and CANNOT be undone.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)

                If (oDialogResult = System.Windows.Forms.DialogResult.Yes) Then

                    '----------------------------------------------------------------
                    '-- "delete" the file by renaming it so it does not appear in the list
                    '----------------------------------------------------------------
                    If System.IO.File.Exists(sReportFileName) Then
                        System.IO.File.Move(sReportFileName, sReportFileName & ".deleted")
                    End If

                    '----------------------------------------------------------------
                    '-- reload the list
                    '----------------------------------------------------------------
                    LoadSavedReportGridData()

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub grdSavedReportsGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdSavedReportsGrid.CellClick

        Dim iRowIndex As Integer

        Try

            '----------------------------------------------------------------
            '-- handle the EDIT or DELETE command
            '----------------------------------------------------------------
            iRowIndex = e.RowIndex

            If (iRowIndex > -1) Then

                If Me.grdSavedReportsGrid.Columns(e.ColumnIndex).Name.Equals(Me.colSavedReportEditActionDataGridViewLinkColumn.Name) Then

                    EditSavedReport()

                ElseIf Me.grdSavedReportsGrid.Columns(e.ColumnIndex).Name.Equals(Me.colSavedReportDeleteActionDataGridViewLinkColumn.Name) Then

                    DeleteSavedReport()

                    '----------------------------------------------------------------
                    '-- set the current row in the list
                    '----------------------------------------------------------------
                    If (Me.grdSavedReportsGrid.Rows.Count > 0) Then
                        If (iRowIndex < Me.grdSavedReportsGrid.Rows.Count) Then
                            grdSavedReportsGrid.Rows(iRowIndex).Selected = True
                        Else
                            grdSavedReportsGrid.Rows(Me.grdSavedReportsGrid.Rows.Count - 1).Selected = True
                        End If
                    End If

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub grdSavedReportsGrid_ColumnDividerDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventArgs) Handles grdSavedReportsGrid.ColumnDividerDoubleClick

        If ((Me.grdSavedReportsGrid.Columns(e.ColumnIndex).Visible) AndAlso (Not Me.grdSavedReportsGrid.Columns(e.ColumnIndex).Frozen)) Then
            Me.grdSavedReportsGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Me.grdSavedReportsGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        End If

    End Sub

#End Region

    Private Sub btnDebug_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDebug.Click

        Dim oDirectoryInfo As New IO.DirectoryInfo(".")
        Dim oFileInfoArray As IO.FileInfo() = oDirectoryInfo.GetFiles("FILLED - " & msFormTitle & " - *.pdf")
        Dim oFileInfo As IO.FileInfo
        Dim sb As StringBuilder = New StringBuilder()

        sb.AppendLine("oDirectoryInfo.Name = " & oDirectoryInfo.Name)
        sb.AppendLine("oDirectoryInfo.FullName = " & oDirectoryInfo.FullName)
        For Each oFileInfo In oFileInfoArray
            sb.AppendLine("oFileInfo.Name = " & oFileInfo.Name)
            sb.AppendLine("oFileInfo.FullName = " & oFileInfo.FullName)
        Next

        MessageBox.Show(sb.ToString())

    End Sub

End Class
