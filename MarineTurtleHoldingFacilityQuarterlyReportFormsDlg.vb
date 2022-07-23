Option Explicit On 
Option Strict On
Option Compare Text

Imports System.Text

Public Class MarineTurtleHoldingFacilityQuarterlyReportFormsDlg
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
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblSeparator As System.Windows.Forms.Label
    Friend WithEvents tipToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    Friend WithEvents tabReportTab As System.Windows.Forms.TabControl
    Friend WithEvents tpgActions As System.Windows.Forms.TabPage
    Friend WithEvents tpgOptions As System.Windows.Forms.TabPage
    Friend WithEvents tpgSavedReports As System.Windows.Forms.TabPage
    Friend WithEvents picMoreInfoReport As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents lblDateThru As System.Windows.Forms.Label
    Friend WithEvents lblDateFrom As System.Windows.Forms.Label
    Friend WithEvents radFillManually As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDateThru As TurtleGeek.Controls.DateComboBox
    Friend WithEvents dtpDateFrom As TurtleGeek.Controls.DateComboBox
    Friend WithEvents radFillDatabase As System.Windows.Forms.RadioButton
    Friend WithEvents chkIncludeAnomalies As System.Windows.Forms.CheckBox
    Friend WithEvents chkIncludeAcquiredFrom As System.Windows.Forms.CheckBox
    Friend WithEvents chkIncludeTurtleName As System.Windows.Forms.CheckBox
    Friend WithEvents radGroupTankDataByDate As System.Windows.Forms.RadioButton
    Friend WithEvents radGroupTankDataByTank As System.Windows.Forms.RadioButton
    Friend WithEvents lblSavedReportsList As System.Windows.Forms.Label
    Friend WithEvents SavedReportGridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grdSavedReportsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents colSavedReportEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colSavedReportDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colSavedReportReportFileNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSavedReportDateOfReportDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents grpGroupTankDataBy As System.Windows.Forms.GroupBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MarineTurtleHoldingFacilityQuarterlyReportFormsDlg))
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
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
        Me.tpgOptions = New System.Windows.Forms.TabPage
        Me.grpGroupTankDataBy = New System.Windows.Forms.GroupBox
        Me.radGroupTankDataByTank = New System.Windows.Forms.RadioButton
        Me.radGroupTankDataByDate = New System.Windows.Forms.RadioButton
        Me.chkIncludeTurtleName = New System.Windows.Forms.CheckBox
        Me.chkIncludeAcquiredFrom = New System.Windows.Forms.CheckBox
        Me.chkIncludeAnomalies = New System.Windows.Forms.CheckBox
        Me.tpgSavedReports = New System.Windows.Forms.TabPage
        Me.grdSavedReportsGrid = New System.Windows.Forms.DataGridView
        Me.SavedReportGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSavedReportsList = New System.Windows.Forms.Label
        Me.colSavedReportEditActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colSavedReportDeleteActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colSavedReportReportFileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSavedReportDateOfReportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.picMoreInfoReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReportTab.SuspendLayout()
        Me.tpgActions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.grpGroupTankDataBy.SuspendLayout()
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
        Me.tipToolTip.SetToolTip(Me.picMoreInfoReport, "More information about the Marine Turtle Holding Facility Quarterly Report")
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
        Me.tabReportTab.Controls.Add(Me.tpgOptions)
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
        '
        'lblDateThru
        '
        Me.lblDateThru.AutoSize = True
        Me.lblDateThru.Location = New System.Drawing.Point(232, 68)
        Me.lblDateThru.Name = "lblDateThru"
        Me.lblDateThru.Size = New System.Drawing.Size(54, 13)
        Me.lblDateThru.TabIndex = 4
        Me.lblDateThru.Text = "Date thru:"
        '
        'lblDateFrom
        '
        Me.lblDateFrom.AutoSize = True
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
        Me.radFillManually.Location = New System.Drawing.Point(16, 99)
        Me.radFillManually.Name = "radFillManually"
        Me.radFillManually.Size = New System.Drawing.Size(472, 17)
        Me.radFillManually.TabIndex = 6
        Me.radFillManually.Text = "Fill out the report manually."
        '
        'dtpDateThru
        '
        Me.dtpDateThru.DateValue = New Date(2006, 5, 31, 23, 35, 21, 281)
        Me.dtpDateThru.Location = New System.Drawing.Point(288, 64)
        Me.dtpDateThru.Name = "dtpDateThru"
        Me.dtpDateThru.Size = New System.Drawing.Size(96, 20)
        Me.dtpDateThru.TabIndex = 5
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.DateValue = New Date(2006, 5, 31, 23, 40, 21, 984)
        Me.dtpDateFrom.Location = New System.Drawing.Point(104, 64)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(96, 20)
        Me.dtpDateFrom.TabIndex = 3
        '
        'radFillDatabase
        '
        Me.radFillDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radFillDatabase.Checked = True
        Me.radFillDatabase.Location = New System.Drawing.Point(16, 43)
        Me.radFillDatabase.Name = "radFillDatabase"
        Me.radFillDatabase.Size = New System.Drawing.Size(472, 17)
        Me.radFillDatabase.TabIndex = 1
        Me.radFillDatabase.TabStop = True
        Me.radFillDatabase.Text = "Populate the report using the information that is stored in the database."
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
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.grpGroupTankDataBy)
        Me.tpgOptions.Controls.Add(Me.chkIncludeTurtleName)
        Me.tpgOptions.Controls.Add(Me.chkIncludeAcquiredFrom)
        Me.tpgOptions.Controls.Add(Me.chkIncludeAnomalies)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(496, 142)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        '
        'grpGroupTankDataBy
        '
        Me.grpGroupTankDataBy.Controls.Add(Me.radGroupTankDataByTank)
        Me.grpGroupTankDataBy.Controls.Add(Me.radGroupTankDataByDate)
        Me.grpGroupTankDataBy.Location = New System.Drawing.Point(216, 8)
        Me.grpGroupTankDataBy.Name = "grpGroupTankDataBy"
        Me.grpGroupTankDataBy.Size = New System.Drawing.Size(136, 72)
        Me.grpGroupTankDataBy.TabIndex = 3
        Me.grpGroupTankDataBy.TabStop = False
        Me.grpGroupTankDataBy.Text = "Group tank data by"
        '
        'radGroupTankDataByTank
        '
        Me.radGroupTankDataByTank.Checked = True
        Me.radGroupTankDataByTank.Location = New System.Drawing.Point(16, 16)
        Me.radGroupTankDataByTank.Name = "radGroupTankDataByTank"
        Me.radGroupTankDataByTank.Size = New System.Drawing.Size(96, 24)
        Me.radGroupTankDataByTank.TabIndex = 0
        Me.radGroupTankDataByTank.TabStop = True
        Me.radGroupTankDataByTank.Text = "Tank"
        '
        'radGroupTankDataByDate
        '
        Me.radGroupTankDataByDate.Location = New System.Drawing.Point(16, 40)
        Me.radGroupTankDataByDate.Name = "radGroupTankDataByDate"
        Me.radGroupTankDataByDate.Size = New System.Drawing.Size(96, 24)
        Me.radGroupTankDataByDate.TabIndex = 1
        Me.radGroupTankDataByDate.Text = "Date"
        '
        'chkIncludeTurtleName
        '
        Me.chkIncludeTurtleName.Checked = True
        Me.chkIncludeTurtleName.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeTurtleName.Location = New System.Drawing.Point(8, 64)
        Me.chkIncludeTurtleName.Name = "chkIncludeTurtleName"
        Me.chkIncludeTurtleName.Size = New System.Drawing.Size(192, 18)
        Me.chkIncludeTurtleName.TabIndex = 2
        Me.chkIncludeTurtleName.Text = "Include turtle name in SID # box"
        '
        'chkIncludeAcquiredFrom
        '
        Me.chkIncludeAcquiredFrom.Checked = True
        Me.chkIncludeAcquiredFrom.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeAcquiredFrom.Location = New System.Drawing.Point(8, 40)
        Me.chkIncludeAcquiredFrom.Name = "chkIncludeAcquiredFrom"
        Me.chkIncludeAcquiredFrom.Size = New System.Drawing.Size(192, 18)
        Me.chkIncludeAcquiredFrom.TabIndex = 1
        Me.chkIncludeAcquiredFrom.Text = "Include acquired from"
        '
        'chkIncludeAnomalies
        '
        Me.chkIncludeAnomalies.Checked = True
        Me.chkIncludeAnomalies.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkIncludeAnomalies.Location = New System.Drawing.Point(8, 16)
        Me.chkIncludeAnomalies.Name = "chkIncludeAnomalies"
        Me.chkIncludeAnomalies.Size = New System.Drawing.Size(192, 18)
        Me.chkIncludeAnomalies.TabIndex = 0
        Me.chkIncludeAnomalies.Text = "Include anomalies"
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
        'SavedReportGridBindingSource
        '
        Me.SavedReportGridBindingSource.DataSource = GetType(TurtleGeek.Roster.SavedReportItems)
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
        'MarineTurtleHoldingFacilityQuarterlyReportFormsDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(522, 239)
        Me.Controls.Add(Me.tabReportTab)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "MarineTurtleHoldingFacilityQuarterlyReportFormsDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marine Turtle Holding Facility Quarterly Report"
        CType(Me.picMoreInfoReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReportTab.ResumeLayout(False)
        Me.tpgActions.ResumeLayout(False)
        Me.tpgActions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.grpGroupTankDataBy.ResumeLayout(False)
        Me.tpgSavedReports.ResumeLayout(False)
        Me.tpgSavedReports.PerformLayout()
        CType(Me.grdSavedReportsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavedReportGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMarineTurtleHoldingFacilityQuarterlyReportFormsDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim iCurrentMonth As Integer
        Dim iCurrentMonthDiff As Integer
        Dim dtDateTimeNow As Date
        Dim dtDateTimeLastMonthOfLastQuarter As Date

        Try
            '----------------------------------------------------------------
            '-- restore last user settings
            '----------------------------------------------------------------
            Me.chkIncludeAnomalies.Checked = My.Settings.HoldingIncludeAnomalies
            Me.chkIncludeAcquiredFrom.Checked = My.Settings.HoldingIncludeAcquiredFrom
            Me.chkIncludeTurtleName.Checked = My.Settings.HoldingIncludeTurtleName

            If (String.Compare(My.Settings.HoldingGroupTankBy, "Date") = 0) Then
                Me.radGroupTankDataByDate.Checked = True
            Else
                Me.radGroupTankDataByTank.Checked = True
            End If

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

        Catch ex As Exception

            ErrorMessageBox.Show(ex)
            Me.Close()

        Finally

            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub frmMarineTurtleHoldingFacilityQuarterlyReportFormsDlg_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        '----------------------------------------------------------------
        '-- save last user settings
        '----------------------------------------------------------------
        My.Settings.HoldingIncludeAnomalies = Me.chkIncludeAnomalies.Checked
        My.Settings.HoldingIncludeAcquiredFrom = Me.chkIncludeAcquiredFrom.Checked
        My.Settings.HoldingIncludeTurtleName = Me.chkIncludeTurtleName.Checked

        If Me.radGroupTankDataByDate.Checked Then
            My.Settings.HoldingGroupTankBy = "Date"
        Else
            My.Settings.HoldingGroupTankBy = "Tank"
        End If

    End Sub

    Private Sub radFillManually_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFillManually.CheckedChanged
        SetControlState()
    End Sub

    Private Sub radFillDatabase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFillDatabase.CheckedChanged
        SetControlState()
    End Sub

    Private Sub SetControlState()
        dtpDateFrom.Enabled = radFillDatabase.Checked
        dtpDateThru.Enabled = radFillDatabase.Checked
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        Dim i As Integer
        Dim iTurtleCount As Integer
        Dim iTankWaterCount As Integer
        Dim iPage2Count As Integer
        Dim iPage2Index As Integer
        Dim iPage3Count As Integer
        Dim iPage3Index As Integer
        Dim iLineCount As Integer
        Dim iLineIndex As Integer

        Dim sMonthsAndYearOfReport As String
        Dim sOrganizationAndPermitNumber As String
        Dim sReportTagNumberFieldData As String
        Dim oWrappedLineArray As String() = Nothing

        Dim sFieldNumber As String = String.Empty
        Dim sFieldsReportAllPagesName As String = MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_ALL_PAGES_PDF
        Dim sFieldsReportPage1Name As String = MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_1_PDF
        Dim sFieldsReportPage2Name As String = MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_2_PDF
        Dim sFieldsReportPage3Name As String = MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_3_PDF
        Dim sFilledReportAllPagesName As String = String.Empty
        Dim sFilledReportPage1Name As String = String.Empty
        Dim sFilledReportPage2Name As String() = Nothing
        Dim sFilledReportPage3Name As String() = Nothing

        Dim dtDateFrom As Date
        Dim dtDateThru As Date
        Dim dtTempDate As Date

        Dim oOrganization As Organization
        Dim oTurtle As Turtle
        Dim oTurtleListItems As TurtleListItems
        Dim oPreReportTurtle As Turtle
        Dim oPreReportTurtleListItems As TurtleListItems
        Dim oTankWater As TankWater
        Dim oTankWaterListItems As TankWaterListItems

        Dim oPdfReader As PdfReader
        Dim oPdfStamper As PdfStamper
        Dim oAcroFields As AcroFields
        Dim oPdfDictionary As PdfDictionary

        Try

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            If radFillManually.Checked Then

                '----------------------------------------------------------------
                '-- display the field-ready PDF file
                '----------------------------------------------------------------
                sFilledReportAllPagesName = sFieldsReportAllPagesName.Replace("MASTER - ", "FILLED - ").Replace(".master.pdf", " - " & Now.ToString("yyyyMMddHHmmss") & ".pdf")
                System.IO.File.Copy(sFieldsReportAllPagesName, sFilledReportAllPagesName)
                System.Diagnostics.Process.Start(sFilledReportAllPagesName)

            Else 'If radFillDatabase.Checked Then
                '----------------------------------------------------------------
                '-- validate date range
                '----------------------------------------------------------------
                dtDateFrom = dtpDateFrom.DateValue
                dtDateThru = dtpDateThru.DateValue

                If (dtDateFrom.Equals(Date.MinValue)) Then
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    MessageBox.Show("Date From cannot be blank.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                If (dtDateThru.Equals(Date.MinValue)) Then
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    MessageBox.Show("Date Thru cannot be blank.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                '-- make the earlier date be first, if need be
                If (dtDateThru < dtDateFrom) Then
                    dtTempDate = dtDateThru
                    dtDateThru = dtDateFrom
                    dtDateFrom = dtTempDate
                End If

                If (dtDateFrom.Year = dtDateThru.Year) Then
                    sMonthsAndYearOfReport = dtDateFrom.ToString("dd") & " " & dtDateFrom.ToString("MMMM") & " - " & dtDateThru.ToString("dd") & " " & dtDateThru.ToString("MMMM") & " " & dtDateThru.Year.ToString
                Else
                    sMonthsAndYearOfReport = dtDateFrom.ToString("dd") & " " & dtDateFrom.ToString("MMMM") & " " & dtDateFrom.Year.ToString & " - " & dtDateThru.ToString("dd") & " " & dtDateThru.ToString("MMMM") & " " & dtDateThru.Year.ToString
                End If

                '----------------------------------------------------------------
                '-- get ORGANIZATION data for report
                '----------------------------------------------------------------
                oOrganization = Organization.GetOrganization()
                sOrganizationAndPermitNumber = oOrganization.OrganizationName & " - " & oOrganization.PermitNumber
                oOrganization = Nothing

                '----------------------------------------------------------------
                '-- get TURTLE data for report
                '----------------------------------------------------------------
                oPreReportTurtleListItems = TurtleListItems.GetListByDatesInFacilityRange(dtDateFrom, dtDateThru)

                If (oPreReportTurtleListItems.Count = 0) Then
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    MessageBox.Show("No turtle data found for the indicated date range.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'Exit Sub
                End If

                '----------------------------------------------------------------
                '-- kludge to account for all the data we want to cram into the 
                '-- status/tag number line...ugh...
                '----------------------------------------------------------------
                oTurtleListItems = TurtleListItems.NewList()

                For i = 0 To oPreReportTurtleListItems.Count - 1

                    oPreReportTurtle = Turtle.GetTurtle(oPreReportTurtleListItems(i).TurtleID)
                    sReportTagNumberFieldData = GetReportTagNumberFieldData(oPreReportTurtle, dtDateFrom, dtDateThru, chkIncludeAnomalies.Checked, chkIncludeAcquiredFrom.Checked)

                    If (sReportTagNumberFieldData.Trim.Length = 0) Then
                        iLineCount = 0
                    Else
                        oWrappedLineArray = AppCommon.WrapLine(sReportTagNumberFieldData, 92)
                        iLineCount = oWrappedLineArray.Length
                    End If

                    If (iLineCount = 0) Then
                        oTurtleListItems.Add(New TurtleListItem(oPreReportTurtle.TurtleID, oPreReportTurtle.TurtleName, oPreReportTurtle.SidNumber, oPreReportTurtle.StrandingIdNumber, oPreReportTurtle.Species, oPreReportTurtle.DateAcquired, oPreReportTurtle.AcquiredFrom, oPreReportTurtle.AcquiredCounty, oPreReportTurtle.TurtleSize, oPreReportTurtle.Status, oPreReportTurtle.DateRelinquished, oPreReportTurtle.RelinquishedTo, sReportTagNumberFieldData))
                    Else
                        '-- if there is too much data to fit into the status/tag line, 
                        '-- then insert an "extra line(s)" into the report 
                        '-- by using "fake" turtle records
                        oTurtleListItems.Add(New TurtleListItem(oPreReportTurtle.TurtleID, oPreReportTurtle.TurtleName, oPreReportTurtle.SidNumber, oPreReportTurtle.StrandingIdNumber, oPreReportTurtle.Species, oPreReportTurtle.DateAcquired, oPreReportTurtle.AcquiredFrom, oPreReportTurtle.AcquiredCounty, oPreReportTurtle.TurtleSize, oPreReportTurtle.Status, oPreReportTurtle.DateRelinquished, oPreReportTurtle.RelinquishedTo, oWrappedLineArray(0)))

                        For iLineIndex = 1 To iLineCount - 1
                            oTurtle = Turtle.NewTurtle()
                            oTurtleListItems.Add(New TurtleListItem(oTurtle.TurtleID, oTurtle.TurtleName, oTurtle.SidNumber, oTurtle.StrandingIdNumber, oTurtle.Species, oTurtle.DateAcquired, oTurtle.AcquiredFrom, oTurtle.AcquiredCounty, oTurtle.TurtleSize, oTurtle.Status, oTurtle.DateRelinquished, oTurtle.RelinquishedTo, oWrappedLineArray(iLineIndex)))
                        Next

                    End If

                Next

                '----------------------------------------------------------------
                '-- start filling the report
                '----------------------------------------------------------------
                iTurtleCount = oTurtleListItems.Count
                sFilledReportAllPagesName = sFieldsReportAllPagesName.Replace("MASTER - ", "FILLED - ").Replace(".master.pdf", " - " & Now.ToString("yyyyMMddHHmmss") & ".pdf")

                '----------------------------------------------------------------
                '-- PAGE 1:  open the field-ready PDF file
                '----------------------------------------------------------------
                oPdfReader = New PdfReader(sFieldsReportPage1Name)
                oPdfDictionary = DirectCast(PdfReader.GetPdfObject(oPdfReader.Catalog.Get(PdfName.ACROFORM)), PdfDictionary)
                oPdfDictionary.Remove(New PdfName("XFA"))

                sFilledReportPage1Name = sFieldsReportPage1Name.Replace("MASTER - ", "FILLED - ").Replace(".master.pdf", " - " & Now.ToString("yyyyMMddHHmmss") & ".pdf")
                oPdfStamper = New PdfStamper(oPdfReader, New System.IO.FileStream(sFilledReportPage1Name, IO.FileMode.Create))

                oAcroFields = oPdfStamper.AcroFields()
                oAcroFields.SetField("txtOrganizationAndPermitNumber", sOrganizationAndPermitNumber)
                oAcroFields.SetField("txtMonthsAndYearOfReport", sMonthsAndYearOfReport)

                '----------------------------------------------------------------
                '-- PAGE 1:  write to the report's "grid" row for each turtle record
                '----------------------------------------------------------------
                i = 1
                Do While (i <= iTurtleCount) AndAlso (i <= 8)

                    sFieldNumber = i.ToString("00")

                    oTurtle = Turtle.GetTurtle(oTurtleListItems(i - 1).TurtleID)

                    'FillSection1Row(oAcroFields, sFieldNumber, oTurtle, dtDateFrom, dtDateThru, chkIncludeTurtleName.Checked)
                    FillSection1Row(oAcroFields, sFieldNumber, oTurtleListItems(i - 1), dtDateFrom, dtDateThru, chkIncludeTurtleName.Checked)

                    i += 1
                Loop

                oAcroFields = Nothing

                '----------------------------------------------------------------
                ''v-- PAGE 1:  add this to make the form READ-ONLY
                '----------------------------------------------------------------
                oPdfStamper.FormFlattening = True
                ''^-- add this to make the form READ-ONLY

                oPdfStamper.Close()
                oPdfStamper = Nothing

                oPdfReader.Close()
                oPdfReader = Nothing


                '----------------------------------------------------------------
                '-- PAGE 2:  add as many Page 2 - "Section 1 (continued)" pages as we need (if any)
                '----------------------------------------------------------------
                iPage2Count = 0

                If (iTurtleCount > 8) Then

                    'iPage2Count = ((iTurtleCount - 8) \ 22 + 1)
                    iPage2Count = ((iTurtleCount - 8) \ 22) + CInt(IIf(((iTurtleCount - 8) Mod 22) > 0, 1, 0))

                    If (iPage2Count > 0) Then

                        ReDim sFilledReportPage2Name(iPage2Count)

                        For iPage2Index = 0 To iPage2Count - 1

                            '----------------------------------------------------------------
                            '-- PAGE 2:  open the field-ready PDF file
                            '----------------------------------------------------------------
                            oPdfReader = New PdfReader(sFieldsReportPage2Name)
                            oPdfDictionary = DirectCast(PdfReader.GetPdfObject(oPdfReader.Catalog.Get(PdfName.ACROFORM)), PdfDictionary)
                            oPdfDictionary.Remove(New PdfName("XFA"))

                            sFilledReportPage2Name(iPage2Index) = sFieldsReportPage2Name.Replace("MASTER - ", "FILLED - ").Replace(".master.pdf", " - " & Now.ToString("yyyyMMddHHmmss") & "_" & (iPage2Index + 1).ToString & ".pdf")
                            oPdfStamper = New PdfStamper(oPdfReader, New System.IO.FileStream(sFilledReportPage2Name(iPage2Index), IO.FileMode.Create))

                            oAcroFields = oPdfStamper.AcroFields()
                            oAcroFields.SetField("txtOrganizationAndPermitNumber", sOrganizationAndPermitNumber)
                            oAcroFields.SetField("txtMonthsAndYearOfReport", sMonthsAndYearOfReport)

                            '----------------------------------------------------------------
                            '-- PAGE 2:  write to the report's "grid" row for each turtle record
                            '----------------------------------------------------------------
                            i = 9
                            Do While ((i - 1 + (iPage2Index * 22)) < iTurtleCount) AndAlso (i <= 30)

                                sFieldNumber = (i).ToString("00")
                                oTurtle = Turtle.GetTurtle(oTurtleListItems(i - 1 + (iPage2Index * 22)).TurtleID)

                                'FillSection1Row(oAcroFields, sFieldNumber, oTurtle, dtDateFrom, dtDateThru, chkIncludeTurtleName.Checked)
                                FillSection1Row(oAcroFields, sFieldNumber, oTurtleListItems(i - 1 + (iPage2Index * 22)), dtDateFrom, dtDateThru, chkIncludeTurtleName.Checked)

                                i += 1
                            Loop

                            oAcroFields = Nothing

                            '----------------------------------------------------------------
                            ''v-- PAGE 2:  add this to make the form READ-ONLY
                            '----------------------------------------------------------------
                            oPdfStamper.FormFlattening = True
                            ''^-- add this to make the form READ-ONLY

                            oPdfStamper.Close()
                            oPdfStamper = Nothing

                            oPdfReader.Close()
                            oPdfReader = Nothing

                        Next iPage2Index

                    End If '-- If (iPage2Count > 0) Then

                End If '--If (iTurtleCount > 8) Then

                '----------------------------------------------------------------
                '-- get WATER TANK data for report
                '----------------------------------------------------------------
                oTankWaterListItems = TankWaterListItems.GetListByDateRange(dtDateFrom, dtDateThru, CType(IIf((Me.radGroupTankDataByTank.Checked), "name", "date"), String))

                iTankWaterCount = oTankWaterListItems.Count

                If (iTankWaterCount = 0) Then
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    MessageBox.Show("No tank water quality data found for the indicated date range.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    'Exit Sub
                End If

                '----------------------------------------------------------------
                '-- PAGE 3:  add as many Page 3 - "Section 2 Water quality..." pages as we need (if any)
                '----------------------------------------------------------------
                If (iTankWaterCount > 34) Then

                    'iPage3Count = (iTankWaterCount \ 34 + 1)
                    iPage3Count = (iTankWaterCount \ 34) + CInt(IIf((iTankWaterCount Mod 34) > 0, 1, 0))

                Else

                    iPage3Count = 1

                End If '--If (iTankWaterCount > 34) Then

                ReDim sFilledReportPage3Name(iPage3Count)

                For iPage3Index = 0 To iPage3Count - 1

                    '----------------------------------------------------------------
                    '-- PAGE 3:  open the field-ready PDF file
                    '----------------------------------------------------------------
                    oPdfReader = New PdfReader(sFieldsReportPage3Name)
                    oPdfDictionary = DirectCast(PdfReader.GetPdfObject(oPdfReader.Catalog.Get(PdfName.ACROFORM)), PdfDictionary)
                    oPdfDictionary.Remove(New PdfName("XFA"))

                    sFilledReportPage3Name(iPage3Index) = sFieldsReportPage3Name.Replace("MASTER - ", "FILLED - ").Replace(".master.pdf", " - " & Now.ToString("yyyyMMddHHmmss") & "_" & (iPage3Index + 1).ToString & ".pdf")
                    oPdfStamper = New PdfStamper(oPdfReader, New System.IO.FileStream(sFilledReportPage3Name(iPage3Index), IO.FileMode.Create))

                    oAcroFields = oPdfStamper.AcroFields()
                    oAcroFields.SetField("txtOrganizationAndPermitNumber", sOrganizationAndPermitNumber)
                    oAcroFields.SetField("txtMonthsAndYearOfReport", sMonthsAndYearOfReport)

                    '----------------------------------------------------------------
                    '-- PAGE 3:  write to the report's "grid" row for each tank record
                    '----------------------------------------------------------------
                    i = 1
                    Do While ((i - 1 + (iPage3Index * 34)) < iTankWaterCount) AndAlso (i <= 34)

                        sFieldNumber = i.ToString("00")

                        FillSection3Row(oAcroFields, sFieldNumber, oTankWaterListItems(i - 1 + (iPage3Index * 34)))

                        i += 1
                    Loop

                    oAcroFields = Nothing

                    '----------------------------------------------------------------
                    ''v-- PAGE 3:  add this to make the form READ-ONLY
                    '----------------------------------------------------------------
                    oPdfStamper.FormFlattening = True
                    ''^-- add this to make the form READ-ONLY

                    oPdfStamper.Close()
                    oPdfStamper = Nothing

                    oPdfReader.Close()
                    oPdfReader = Nothing

                Next iPage3Index

                '----------------------------------------------------------------
                '-- ALL:  combine PAGE 1 + PAGE 2(s)(if any) + PAGE 3
                '--       arguments: file1 [file2 ...] destfile
                '----------------------------------------------------------------
                Dim sPageArray As String()

                '----------------------------------------------------------------
                '-- add the source pages
                '----------------------------------------------------------------
                ReDim Preserve sPageArray(0)
                sPageArray(0) = sFilledReportPage1Name

                For iPage2Index = 0 To iPage2Count - 1
                    ReDim Preserve sPageArray(UBound(sPageArray) + 1)
                    sPageArray(UBound(sPageArray)) = sFilledReportPage2Name(iPage2Index)
                Next

                For iPage3Index = 0 To iPage3Count - 1
                    ReDim Preserve sPageArray(UBound(sPageArray) + 1)
                    sPageArray(UBound(sPageArray)) = sFilledReportPage3Name(iPage3Index)
                Next

                '----------------------------------------------------------------
                '-- set the destination file
                '----------------------------------------------------------------
                ReDim Preserve sPageArray(UBound(sPageArray) + 1)
                sPageArray(UBound(sPageArray)) = sFilledReportAllPagesName

                AppCommon.ConcatenatePdfFiles(sPageArray)

                '----------------------------------------------------------------
                '-- delete working files
                '----------------------------------------------------------------
                System.IO.File.Delete(sFilledReportPage1Name)

                For iPage2Index = 0 To iPage2Count - 1
                    System.IO.File.Delete(sFilledReportPage2Name(iPage2Index))
                Next

                For iPage3Index = 0 To iPage3Count - 1
                    System.IO.File.Delete(sFilledReportPage3Name(iPage3Index))
                Next

                '----------------------------------------------------------------
                '-- ALL:  display all pages of the filled-in PDF file
                '----------------------------------------------------------------
                System.Diagnostics.Process.Start(sFilledReportAllPagesName)

            End If

            '----------------------------------------------------------------
            '-- refresh the saved report list
            '----------------------------------------------------------------
            LoadSavedReportGridData()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            oTurtle = Nothing
            oTurtleListItems = Nothing
            oPreReportTurtle = Nothing
            oPreReportTurtleListItems = Nothing
            oTankWater = Nothing
            oTankWaterListItems = Nothing
            oOrganization = Nothing

            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Function GetReportTagNumberFieldData(ByVal oTurtle As Turtle, ByVal dtDateFrom As Date, ByVal dtDateThru As Date, ByVal bIncludeAnomalies As Boolean, ByVal bIncludeAcquiredFrom As Boolean) As String

        Dim sDateAcquiredString As String = String.Empty
        Dim sAcquiredFrom As String = String.Empty
        Dim sTagNumberList As String = String.Empty
        Dim sAnomalies As String = String.Empty
        Dim sText As String = String.Empty

        Try
            sText = String.Empty

            '----------------------------------------------------------------
            '-- display DATE ACQUIRED -only- when requested 
            '-- and when report date range is for one quarter or less
            '----------------------------------------------------------------
            '-- if the DATE ACQUIRED is within the date range of the report, 
            '-- then do display the ACQUIRED FROM information
            '----------------------------------------------------------------
            If (bIncludeAcquiredFrom) AndAlso (Math.Abs(DateDiff(DateInterval.Day, dtDateFrom, dtDateThru)) <= 95) Then
                sDateAcquiredString = oTurtle.DateAcquiredString.Trim
                If (sDateAcquiredString.Length > 0) Then
                    If (dtDateFrom <= CDate(sDateAcquiredString)) AndAlso (CDate(sDateAcquiredString) <= dtDateThru) Then
                        sAcquiredFrom = oTurtle.AcquiredFrom
                        If (sAcquiredFrom.Trim.Length > 0) Then
                            sText = "Acq. from: " & sAcquiredFrom
                        End If
                    End If
                End If
            End If

            '----------------------------------------------------------------
            '-- add TAG information here (if any)
            '----------------------------------------------------------------
            sTagNumberList = oTurtle.TurtleTags.GetTagNumberListString

            If (sTagNumberList.Trim.Length > 0) Then
                If (sText.Trim.Length > 0) Then
                    sText &= "; "
                End If
                If (oTurtle.TurtleTags.Count > 1) Then
                    sText &= "Tags: "
                Else
                    sText &= "Tag: "
                End If
                sText &= sTagNumberList
            End If

            '----------------------------------------------------------------
            '-- add ANOMALIES information here (if request and if any exist)
            '----------------------------------------------------------------
            If (bIncludeAnomalies) Then
                sAnomalies = oTurtle.Anomalies

                If (sAnomalies.Trim.Length > 0) Then
                    If (sText.Trim.Length > 0) Then
                        sText &= "; "
                    End If
                    sText &= "Anomalies: " & sAnomalies
                End If
            End If

            Return sText

        Catch ex As Exception

            ErrorMessageBox.Show(ex)
            Return String.Empty

        Finally

        End Try

    End Function

    Private Sub FillSection1Row(ByVal oAcroFields As AcroFields, ByVal vsFieldNumber As String, ByVal oTurtleListItem As TurtleListItem, ByVal dtDateFrom As Date, ByVal dtDateThru As Date, ByVal vbIncludeTurtleName As Boolean)

        Dim sDateRelinquishedString As String = String.Empty
        Dim sRelinquishedTo As String = String.Empty
        Dim sStrandingIdNumber As String = String.Empty
        Dim sText As String = String.Empty

        '*************************************************************************************************
        '-- Tag Numbers, Acquired From, and Anomalies share the TAG NUMBER field (part of the STATUS field)
        '-- Relinquished To and Stranding ID Number share the RELINQUISHED TO field (part of the DATE RELEASED/.../... field)
        '*************************************************************************************************

        Try
            sText = oTurtleListItem.SidNumber

            If (vbIncludeTurtleName) AndAlso (oTurtleListItem.TurtleName.Trim.Length > 0) Then
                sText &= " - " & oTurtleListItem.TurtleName.Trim
            End If

            oAcroFields.SetField("txtSID" & vsFieldNumber, sText)

            oAcroFields.SetField("cboSpecies" & vsFieldNumber, oTurtleListItem.Species)

            oAcroFields.SetField("txtDateAcquired" & vsFieldNumber, oTurtleListItem.DateAcquiredString.Trim)

            oAcroFields.SetField("cboSize" & vsFieldNumber, oTurtleListItem.TurtleSize)
            oAcroFields.SetField("cboStatus" & vsFieldNumber, oTurtleListItem.Status)

            '*************************************************************************************************
            'v-- *** TAG NUMBER *** TAG NUMBER *** TAG NUMBER *** TAG NUMBER *** TAG NUMBER 
            '*************************************************************************************************
            oAcroFields.SetField("txtTagNumber" & vsFieldNumber, oTurtleListItem.ReportTagNumberFieldData)

            '*************************************************************************************************
            '^-- *** TAG NUMBER *** TAG NUMBER *** TAG NUMBER *** TAG NUMBER *** TAG NUMBER 
            '*************************************************************************************************

            '----------------------------------------------------------------
            '-- if the DATE RELINQUISHED is later than the report date, 
            '-- then do NOT display the relinquished information
            '----------------------------------------------------------------
            sDateRelinquishedString = oTurtleListItem.DateRelinquishedString.Trim
            sRelinquishedTo = oTurtleListItem.RelinquishedTo.Trim

            If (sDateRelinquishedString.Length > 0) Then
                If (CDate(sDateRelinquishedString) > dtDateThru) Then
                    sDateRelinquishedString = String.Empty
                    sRelinquishedTo = String.Empty
                End If
            End If

            oAcroFields.SetField("txtDateRelinquished" & vsFieldNumber, sDateRelinquishedString)

            '*************************************************************************************************
            'v-- *** RELINQUISHED TO *** RELINQUISHED TO *** RELINQUISHED TO *** RELINQUISHED TO *** RELINQUISHED TO 
            '*************************************************************************************************
            sText = String.Empty

            '----------------------------------------------------------------
            '-- add STRANDING ID NUMBER information here (if any)
            '----------------------------------------------------------------
            sStrandingIdNumber = oTurtleListItem.StrandingIdNumber.Trim

            If (sStrandingIdNumber.Length > 0) Then
                sText = "Stranding ID #: " & sStrandingIdNumber
            End If

            If (sRelinquishedTo.Length > 0) Then
                sText &= "; Relinq. To: " & sRelinquishedTo
            End If

            oAcroFields.SetField("txtRelinquishedTo" & vsFieldNumber, sText)
            '*************************************************************************************************
            '^-- *** RELINQUISHED TO *** RELINQUISHED TO *** RELINQUISHED TO *** RELINQUISHED TO *** RELINQUISHED TO 
            '*************************************************************************************************

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub FillSection3Row(ByVal oAcroFields As AcroFields, ByVal sFieldNumber As String, ByVal oTankWaterListItem As TankWaterListItem)

        Try
            oAcroFields.SetField("txtDate" & sFieldNumber, oTankWaterListItem.DateMeasuredString)
            oAcroFields.SetField("txtTank" & sFieldNumber, oTankWaterListItem.TankName)
            oAcroFields.SetField("txtTemperature" & sFieldNumber, oTankWaterListItem.Temperature)
            oAcroFields.SetField("txtSalinity" & sFieldNumber, oTankWaterListItem.Salinity)
            oAcroFields.SetField("txtPH" & sFieldNumber, oTankWaterListItem.Ph)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

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
            frm.HeaderText = "Marine Turtle Holding Facility Quarterly Report"

            sb.Append("Any turtle that was resident in the facility (as determined by the Date Acquired/Date Relinquished dates) during the specified report date range will appear on the report.  This includes currently non-resident turtles.")
            sb.Append(ControlChars.CrLf)
            sb.Append(ControlChars.CrLf)
            sb.Append("The tag numbers associated with the turtle will appear as extra information in the Status field.")
            sb.Append(ControlChars.CrLf)
            sb.Append(ControlChars.CrLf)
            sb.Append("The anomalies specified for the turtle will appear as extra information in the Status field.")
            sb.Append(ControlChars.CrLf)
            sb.Append(ControlChars.CrLf)
            sb.Append("The Acquired From location will appear as extra information in the Status field, but only when the report date range is one quarter or less.")
            sb.Append(ControlChars.CrLf)
            sb.Append(ControlChars.CrLf)
            sb.Append("The Stranding ID # associated with the turtle will appear as extra information in the Date Released field.")
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
        Help.ShowHelp(Me, gsHelpFileName, "SeaTurtleHoldingFacilityQuarterlyReport.htm")
    End Sub

#Region " Saved Reports Grid "

    Private Sub LoadSavedReportGridData()

        Dim sFormTitle As String = String.Empty

        Try
            Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- add the data to the grid
            '----------------------------------------------------------------
            sFormTitle = MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_ALL_PAGES_PDF.Replace("MASTER - ", "").Replace(".master.pdf", "")

            Me.SavedReportGridBindingSource.DataSource = SavedReportItems.GetList("view", sFormTitle)

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

End Class
