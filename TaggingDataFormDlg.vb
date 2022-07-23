Option Explicit On 
Option Strict On
Option Compare Text

Imports System.Text

Public Class TaggingDataFormDlg
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

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
    Friend WithEvents lblChooseOneOrMoreTurtles As System.Windows.Forms.Label
    Friend WithEvents radFillManually As System.Windows.Forms.RadioButton
    Friend WithEvents radFillDatabase As System.Windows.Forms.RadioButton
    Friend WithEvents chkAdditionalRemarksOrDataOnBackOfForm As System.Windows.Forms.CheckBox
    Friend WithEvents lblSavedReportsList As System.Windows.Forms.Label
    Friend WithEvents SavedReportGridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grdSavedReportsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents chkPopulateFacilityField As System.Windows.Forms.CheckBox
    Friend WithEvents radMorphometricsClosestAcquired As System.Windows.Forms.RadioButton
    Friend WithEvents radMorphometricsClosestRelinquished As System.Windows.Forms.RadioButton
    Friend WithEvents grpMorphometrics As System.Windows.Forms.GroupBox
    Friend WithEvents colSavedReportEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colSavedReportDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colSavedReportReportFileNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSavedReportDateOfReportDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkPrintSidOnForm As System.Windows.Forms.CheckBox
    Friend WithEvents cboTurtleList As System.Windows.Forms.ComboBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TaggingDataFormDlg))
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
        Me.cboTurtleList = New System.Windows.Forms.ComboBox
        Me.lblChooseOneOrMoreTurtles = New System.Windows.Forms.Label
        Me.radFillManually = New System.Windows.Forms.RadioButton
        Me.radFillDatabase = New System.Windows.Forms.RadioButton
        Me.lblDescription = New System.Windows.Forms.Label
        Me.tpgOptions = New System.Windows.Forms.TabPage
        Me.grpMorphometrics = New System.Windows.Forms.GroupBox
        Me.radMorphometricsClosestRelinquished = New System.Windows.Forms.RadioButton
        Me.radMorphometricsClosestAcquired = New System.Windows.Forms.RadioButton
        Me.chkPopulateFacilityField = New System.Windows.Forms.CheckBox
        Me.chkAdditionalRemarksOrDataOnBackOfForm = New System.Windows.Forms.CheckBox
        Me.tpgSavedReports = New System.Windows.Forms.TabPage
        Me.grdSavedReportsGrid = New System.Windows.Forms.DataGridView
        Me.colSavedReportEditActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colSavedReportDeleteActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colSavedReportReportFileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSavedReportDateOfReportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SavedReportGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSavedReportsList = New System.Windows.Forms.Label
        Me.chkPrintSidOnForm = New System.Windows.Forms.CheckBox
        CType(Me.picMoreInfoReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReportTab.SuspendLayout()
        Me.tpgActions.SuspendLayout()
        Me.tpgOptions.SuspendLayout()
        Me.grpMorphometrics.SuspendLayout()
        Me.tpgSavedReports.SuspendLayout()
        CType(Me.grdSavedReportsGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SavedReportGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.Location = New System.Drawing.Point(360, 216)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(72, 24)
        Me.btnCreate.TabIndex = 17
        Me.btnCreate.Text = "Create"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(440, 216)
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
        Me.lblSeparator.Location = New System.Drawing.Point(8, 200)
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
        Me.tipToolTip.SetToolTip(Me.picMoreInfoReport, "More information about the Tagging Data form")
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(8, 216)
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
        Me.tabReportTab.Size = New System.Drawing.Size(504, 181)
        Me.tabReportTab.TabIndex = 0
        '
        'tpgActions
        '
        Me.tpgActions.Controls.Add(Me.cboTurtleList)
        Me.tpgActions.Controls.Add(Me.lblChooseOneOrMoreTurtles)
        Me.tpgActions.Controls.Add(Me.radFillManually)
        Me.tpgActions.Controls.Add(Me.radFillDatabase)
        Me.tpgActions.Controls.Add(Me.picMoreInfoReport)
        Me.tpgActions.Controls.Add(Me.lblDescription)
        Me.tpgActions.Location = New System.Drawing.Point(4, 22)
        Me.tpgActions.Name = "tpgActions"
        Me.tpgActions.Size = New System.Drawing.Size(496, 155)
        Me.tpgActions.TabIndex = 0
        Me.tpgActions.Text = "Actions"
        Me.tpgActions.UseVisualStyleBackColor = True
        '
        'cboTurtleList
        '
        Me.cboTurtleList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboTurtleList.FormattingEnabled = True
        Me.cboTurtleList.Location = New System.Drawing.Point(35, 84)
        Me.cboTurtleList.Name = "cboTurtleList"
        Me.cboTurtleList.Size = New System.Drawing.Size(453, 21)
        Me.cboTurtleList.TabIndex = 56
        '
        'lblChooseOneOrMoreTurtles
        '
        Me.lblChooseOneOrMoreTurtles.AutoSize = True
        Me.lblChooseOneOrMoreTurtles.Location = New System.Drawing.Point(32, 68)
        Me.lblChooseOneOrMoreTurtles.Name = "lblChooseOneOrMoreTurtles"
        Me.lblChooseOneOrMoreTurtles.Size = New System.Drawing.Size(194, 13)
        Me.lblChooseOneOrMoreTurtles.TabIndex = 2
        Me.lblChooseOneOrMoreTurtles.Text = "Choose a turtle to generate the form for:"
        '
        'radFillManually
        '
        Me.radFillManually.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radFillManually.Location = New System.Drawing.Point(16, 122)
        Me.radFillManually.Name = "radFillManually"
        Me.radFillManually.Size = New System.Drawing.Size(472, 32)
        Me.radFillManually.TabIndex = 6
        Me.radFillManually.Text = "Fill out the form manually."
        '
        'radFillDatabase
        '
        Me.radFillDatabase.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.radFillDatabase.Checked = True
        Me.radFillDatabase.Location = New System.Drawing.Point(16, 40)
        Me.radFillDatabase.Name = "radFillDatabase"
        Me.radFillDatabase.Size = New System.Drawing.Size(472, 24)
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
        Me.lblDescription.Text = "Select a method to populate the form and then click 'Create' to generate the form" & _
            "."
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'tpgOptions
        '
        Me.tpgOptions.Controls.Add(Me.chkPrintSidOnForm)
        Me.tpgOptions.Controls.Add(Me.grpMorphometrics)
        Me.tpgOptions.Controls.Add(Me.chkPopulateFacilityField)
        Me.tpgOptions.Controls.Add(Me.chkAdditionalRemarksOrDataOnBackOfForm)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(496, 155)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        Me.tpgOptions.UseVisualStyleBackColor = True
        '
        'grpMorphometrics
        '
        Me.grpMorphometrics.Controls.Add(Me.radMorphometricsClosestRelinquished)
        Me.grpMorphometrics.Controls.Add(Me.radMorphometricsClosestAcquired)
        Me.grpMorphometrics.Location = New System.Drawing.Point(8, 64)
        Me.grpMorphometrics.Name = "grpMorphometrics"
        Me.grpMorphometrics.Size = New System.Drawing.Size(287, 72)
        Me.grpMorphometrics.TabIndex = 3
        Me.grpMorphometrics.TabStop = False
        Me.grpMorphometrics.Text = "Morphometrics"
        '
        'radMorphometricsClosestRelinquished
        '
        Me.radMorphometricsClosestRelinquished.AutoSize = True
        Me.radMorphometricsClosestRelinquished.Location = New System.Drawing.Point(8, 19)
        Me.radMorphometricsClosestRelinquished.Name = "radMorphometricsClosestRelinquished"
        Me.radMorphometricsClosestRelinquished.Size = New System.Drawing.Size(246, 17)
        Me.radMorphometricsClosestRelinquished.TabIndex = 0
        Me.radMorphometricsClosestRelinquished.TabStop = True
        Me.radMorphometricsClosestRelinquished.Text = "Use morphometrics closest to date relinquished"
        Me.radMorphometricsClosestRelinquished.UseVisualStyleBackColor = True
        '
        'radMorphometricsClosestAcquired
        '
        Me.radMorphometricsClosestAcquired.AutoSize = True
        Me.radMorphometricsClosestAcquired.Location = New System.Drawing.Point(8, 42)
        Me.radMorphometricsClosestAcquired.Name = "radMorphometricsClosestAcquired"
        Me.radMorphometricsClosestAcquired.Size = New System.Drawing.Size(231, 17)
        Me.radMorphometricsClosestAcquired.TabIndex = 1
        Me.radMorphometricsClosestAcquired.TabStop = True
        Me.radMorphometricsClosestAcquired.Text = "Use morphometrics closest to date acquired"
        Me.radMorphometricsClosestAcquired.UseVisualStyleBackColor = True
        '
        'chkPopulateFacilityField
        '
        Me.chkPopulateFacilityField.AutoSize = True
        Me.chkPopulateFacilityField.Location = New System.Drawing.Point(8, 16)
        Me.chkPopulateFacilityField.Name = "chkPopulateFacilityField"
        Me.chkPopulateFacilityField.Size = New System.Drawing.Size(267, 17)
        Me.chkPopulateFacilityField.TabIndex = 0
        Me.chkPopulateFacilityField.Text = "Populate ""Facility where turtle was being held"" field"
        '
        'chkAdditionalRemarksOrDataOnBackOfForm
        '
        Me.chkAdditionalRemarksOrDataOnBackOfForm.AutoSize = True
        Me.chkAdditionalRemarksOrDataOnBackOfForm.Location = New System.Drawing.Point(8, 40)
        Me.chkAdditionalRemarksOrDataOnBackOfForm.Name = "chkAdditionalRemarksOrDataOnBackOfForm"
        Me.chkAdditionalRemarksOrDataOnBackOfForm.Size = New System.Drawing.Size(225, 17)
        Me.chkAdditionalRemarksOrDataOnBackOfForm.TabIndex = 1
        Me.chkAdditionalRemarksOrDataOnBackOfForm.Text = "Additional remarks or data on back of form"
        '
        'tpgSavedReports
        '
        Me.tpgSavedReports.Controls.Add(Me.grdSavedReportsGrid)
        Me.tpgSavedReports.Controls.Add(Me.lblSavedReportsList)
        Me.tpgSavedReports.Location = New System.Drawing.Point(4, 22)
        Me.tpgSavedReports.Name = "tpgSavedReports"
        Me.tpgSavedReports.Size = New System.Drawing.Size(496, 155)
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
        Me.grdSavedReportsGrid.Size = New System.Drawing.Size(480, 128)
        Me.grdSavedReportsGrid.TabIndex = 1
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
        'chkPrintSidOnForm
        '
        Me.chkPrintSidOnForm.AutoSize = True
        Me.chkPrintSidOnForm.Location = New System.Drawing.Point(314, 16)
        Me.chkPrintSidOnForm.Name = "chkPrintSidOnForm"
        Me.chkPrintSidOnForm.Size = New System.Drawing.Size(106, 17)
        Me.chkPrintSidOnForm.TabIndex = 2
        Me.chkPrintSidOnForm.Text = "Print SID on form"
        '
        'TaggingDataFormDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(522, 255)
        Me.Controls.Add(Me.tabReportTab)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TaggingDataFormDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tagging Data Form"
        CType(Me.picMoreInfoReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReportTab.ResumeLayout(False)
        Me.tpgActions.ResumeLayout(False)
        Me.tpgActions.PerformLayout()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.grpMorphometrics.ResumeLayout(False)
        Me.grpMorphometrics.PerformLayout()
        Me.tpgSavedReports.ResumeLayout(False)
        Me.tpgSavedReports.PerformLayout()
        CType(Me.grdSavedReportsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavedReportGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private moTurtle As Turtle = Nothing

    Public Sub New(Optional ByVal oTurtle As Turtle = Nothing)

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        moTurtle = oTurtle

    End Sub

    Private Sub frmTaggingDataFormDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim i As Integer

        Try
            '----------------------------------------------------------------
            '-- restore last user settings
            '----------------------------------------------------------------
            Me.chkPopulateFacilityField.Checked = My.Settings.TaggingDataPopulateFacilityField
            Me.chkAdditionalRemarksOrDataOnBackOfForm.Checked = My.Settings.TaggingDataAdditionalRemarks
            Me.chkPrintSidOnForm.Checked = My.Settings.TaggingDataPrintSidOnForm

            If (My.Settings.TaggingDataMorphometrics = "A") Then
                Me.radMorphometricsClosestAcquired.Checked = True
            Else
                Me.radMorphometricsClosestRelinquished.Checked = True
            End If

            '----------------------------------------------------------------
            '-- set the state of the Report Actions controls
            '-- based on which action type is selected
            '----------------------------------------------------------------
            SetControlState()

            '----------------------------------------------------------------
            '-- populate the list of turtles
            '----------------------------------------------------------------
            LoadTurtleList()

            If Not (moTurtle Is Nothing) AndAlso Not String.IsNullOrEmpty(moTurtle.TurtleID) Then
                For i = 0 To Me.cboTurtleList.Items.Count - 1
                    If (String.Compare(moTurtle.TurtleID, DirectCast(Me.cboTurtleList.Items(i), KeyValueInfo).Key, True) = 0) Then
                        Me.cboTurtleList.SelectedIndex = i
                        Me.cboTurtleList.Enabled = False
                        Exit For
                    End If
                Next
            End If

            '----------------------------------------------------------------
            '-- populate the list of saved reports
            '----------------------------------------------------------------
            LoadSavedReportGridData()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub TaggingDataFormDlg_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        '----------------------------------------------------------------
        '-- save last user settings
        '----------------------------------------------------------------
        My.Settings.TaggingDataPopulateFacilityField = Me.chkPopulateFacilityField.Checked
        My.Settings.TaggingDataAdditionalRemarks = Me.chkAdditionalRemarksOrDataOnBackOfForm.Checked
        My.Settings.TaggingDataPrintSidOnForm = Me.chkPrintSidOnForm.Checked

        If (Me.radMorphometricsClosestAcquired.Checked) Then
            My.Settings.TaggingDataMorphometrics = "A"
        Else
            My.Settings.TaggingDataMorphometrics = "R"
        End If

    End Sub

    Private Sub chkShowInactiveTurtles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        LoadTurtleList()
    End Sub

    Private Sub LoadTurtleList()

        Dim s As String = String.Empty
        Dim oTurtleListItem As TurtleListItem
        Dim oTurtleListItems As TurtleListItems

        '----------------------------------------------------------------
        '-- fill the list of turtles
        '----------------------------------------------------------------
        Me.cboTurtleList.Items.Clear()
        Me.cboTurtleList.DisplayMember = "Value"
        Me.cboTurtleList.ValueMember = "Key"

        oTurtleListItems = TurtleListItems.GetListBySearchOptions(True, String.Empty, String.Empty)

        For Each oTurtleListItem In oTurtleListItems

            '----------------------------------------------------------------
            '-- create a list item  for each data record
            '----------------------------------------------------------------
            s = oTurtleListItem.TurtleName & " | " & oTurtleListItem.SidNumber & " | " & oTurtleListItem.Species & " | " & oTurtleListItem.TurtleSize & " | " & oTurtleListItem.Status

            If Not String.IsNullOrEmpty(oTurtleListItem.DateRelinquishedString) Then
                s &= " | Relinquished: " & oTurtleListItem.DateRelinquishedString
            End If

            Me.cboTurtleList.Items.Add(New KeyValueInfo(oTurtleListItem.TurtleID.Trim.ToUpper, s))

        Next

    End Sub

    Private Sub radFillManually_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFillManually.CheckedChanged
        SetControlState()
    End Sub

    Private Sub radFillDatabase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radFillDatabase.CheckedChanged
        SetControlState()
    End Sub

    Private Sub SetControlState()
        Me.cboTurtleList.Enabled = radFillDatabase.Checked
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        Dim i As Integer

        Dim sOrganizationInformation As String = String.Empty
        Dim sPitTagNumber As String = String.Empty
        Dim sPitTagLocation As String = String.Empty
        Dim sFlipperTagLeftFront As String = String.Empty
        Dim sFlipperTagRightFront As String = String.Empty
        Dim sFlipperTagLeftRear As String = String.Empty
        Dim sFlipperTagRightRear As String = String.Empty

        Dim sFieldNumber As String = String.Empty
        Dim sFieldsReportName As String = MASTER_TAGGING_DATA_FORM_PDF
        Dim sFilledReportName As String = String.Empty

        Dim oKeyValueInfo As KeyValueInfo
        Dim oOrganization As Organization
        Dim oTurtle As Turtle
        Dim oTurtleTag As TurtleTag
        Dim oTurtleMorphometric As TurtleMorphometric = Nothing

        Dim oPdfReader As PdfReader
        Dim oPdfStamper As PdfStamper
        Dim oAcroFields As AcroFields
        Dim oPdfDictionary As PdfDictionary

        Try

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            If Me.radFillManually.Checked Then

                '----------------------------------------------------------------
                '-- display the field-ready PDF file
                '----------------------------------------------------------------
                sFilledReportName = sFieldsReportName.Replace("MASTER - ", "FILLED - ").Replace(".master.pdf", " - " & Now.ToString("yyyyMMddHHmmss") & ".pdf")
                System.IO.File.Copy(sFieldsReportName, sFilledReportName)
                System.Diagnostics.Process.Start(sFilledReportName)

            Else 'If radFillDatabase.Checked Then
                '----------------------------------------------------------------
                '-- validate date range
                '----------------------------------------------------------------
                If (Me.cboTurtleList.SelectedIndex = -1) Then
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    MessageBox.Show("At least one turtle must be selected.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    Exit Sub
                End If

                '----------------------------------------------------------------
                '-- get ORGANIZATION data for report
                '----------------------------------------------------------------
                oOrganization = Organization.GetOrganization()
                sOrganizationInformation = oOrganization.OrganizationName & " - " & oOrganization.Phone & Convert.ToString(IIf(String.IsNullOrEmpty(oOrganization.EmailAddress), "", " - " & oOrganization.EmailAddress))
                oOrganization = Nothing

                '----------------------------------------------------------------
                '-- start filling the report
                '----------------------------------------------------------------
                sFilledReportName = sFieldsReportName.Replace("MASTER - ", "FILLED - ").Replace(".master.pdf", " - " & Now.ToString("yyyyMMddHHmmss") & ".pdf")

                '----------------------------------------------------------------
                '-- open the field-ready PDF file
                '----------------------------------------------------------------
                oPdfReader = New PdfReader(sFieldsReportName)
                oPdfDictionary = DirectCast(PdfReader.GetPdfObject(oPdfReader.Catalog.Get(PdfName.ACROFORM)), PdfDictionary)
                oPdfDictionary.Remove(New PdfName("XFA"))

                '----------------------------------------------------------------
                '-- "RemoveUsageRights()" prevents the "This document enabled extended features in Adobe Reader. This document has changed..." 
                '-- message when trying to open a newly-filled and saved Tagging Data Form .pdf file.
                '----------------------------------------------------------------
                oPdfReader.RemoveUsageRights()

                oPdfStamper = New PdfStamper(oPdfReader, New System.IO.FileStream(sFilledReportName, IO.FileMode.Create))

                oAcroFields = oPdfStamper.AcroFields()

                '----------------------------------------------------------------
                '-- write form information for the selected turtle
                '----------------------------------------------------------------
                If Not (moTurtle Is Nothing) Then
                    oTurtle = moTurtle
                Else
                    oKeyValueInfo = DirectCast(Me.cboTurtleList.SelectedItem, KeyValueInfo)
                    oTurtle = Turtle.GetTurtle(oKeyValueInfo.Key)
                End If

                '----------------------------------------------------------------
                '-- SID
                '----------------------------------------------------------------
                If Me.chkPrintSidOnForm.Checked Then
                    oAcroFields.SetField("txtSID", "SID:  " & oTurtle.SidNumber)
                Else
                    oAcroFields.SetField("txtSID", "")
                End If

                '----------------------------------------------------------------
                '-- SPECIES
                '----------------------------------------------------------------
                oAcroFields.SetField("txtSpecies", oTurtle.Species)

                '----------------------------------------------------------------
                '-- DATE CAPTURED (first try Date Captured...then try Date Acquired)
                '----------------------------------------------------------------
                If Not oTurtle.DateCaptured.Equals(Date.MinValue) Then
                    oAcroFields.SetField("txtDateCapturedDay", Convert.ToDateTime(oTurtle.DateCaptured).Day.ToString("00"))
                    oAcroFields.SetField("txtDateCapturedMonth", Convert.ToDateTime(oTurtle.DateCaptured).Month.ToString("00"))
                    oAcroFields.SetField("txtDateCapturedYear", Convert.ToDateTime(oTurtle.DateCaptured).Year.ToString())
                Else
                    If Not oTurtle.DateAcquired.Equals(Date.MinValue) Then
                        oAcroFields.SetField("txtDateCapturedDay", Convert.ToDateTime(oTurtle.DateAcquired).Day.ToString("00"))
                        oAcroFields.SetField("txtDateCapturedMonth", Convert.ToDateTime(oTurtle.DateAcquired).Month.ToString("00"))
                        oAcroFields.SetField("txtDateCapturedYear", Convert.ToDateTime(oTurtle.DateAcquired).Year.ToString())
                    End If
                End If

                '----------------------------------------------------------------
                '-- DATE RELEASED
                '----------------------------------------------------------------
                If Not oTurtle.DateRelinquished.Equals(Date.MinValue) Then
                    oAcroFields.SetField("txtDateReleasedDay", Convert.ToDateTime(oTurtle.DateRelinquished).Day.ToString("00"))
                    oAcroFields.SetField("txtDateReleasedMonth", Convert.ToDateTime(oTurtle.DateRelinquished).Month.ToString("00"))
                    oAcroFields.SetField("txtDateReleasedYear", Convert.ToDateTime(oTurtle.DateRelinquished).Year.ToString())
                End If

                '----------------------------------------------------------------
                '-- get TAG information
                '----------------------------------------------------------------
                For i = 0 To oTurtle.TurtleTags.Count - 1

                    oTurtleTag = oTurtle.TurtleTags(i)

                    If oTurtleTag.TagType.ToUpper.Contains("PIT") Then

                        If Not String.IsNullOrEmpty(sPitTagNumber) Then
                            sPitTagNumber &= ", "
                        End If
                        sPitTagNumber &= oTurtleTag.TagNumber

                        If Not String.IsNullOrEmpty(sPitTagLocation) Then
                            sPitTagLocation &= ", "
                        End If
                        sPitTagLocation &= oTurtleTag.Location

                    Else

                        If (String.Compare(oTurtleTag.Location, "LFF", True) = 0) Then

                            If Not String.IsNullOrEmpty(sFlipperTagLeftFront) Then
                                sFlipperTagLeftFront &= ", "
                            End If
                            sFlipperTagLeftFront &= oTurtleTag.TagNumber

                        ElseIf (String.Compare(oTurtleTag.Location, "RFF", True) = 0) Then

                            If Not String.IsNullOrEmpty(sFlipperTagRightFront) Then
                                sFlipperTagRightFront &= ", "
                            End If
                            sFlipperTagRightFront &= oTurtleTag.TagNumber

                        ElseIf (String.Compare(oTurtleTag.Location, "LRF", True) = 0) Then

                            If Not String.IsNullOrEmpty(sFlipperTagLeftRear) Then
                                sFlipperTagLeftRear &= ", "
                            End If
                            sFlipperTagLeftRear &= oTurtleTag.TagNumber

                        ElseIf (String.Compare(oTurtleTag.Location, "RRF", True) = 0) Then

                            If Not String.IsNullOrEmpty(sFlipperTagRightRear) Then
                                sFlipperTagRightRear &= ", "
                            End If
                            sFlipperTagRightRear &= oTurtleTag.TagNumber

                        End If

                    End If

                Next

                '----------------------------------------------------------------
                '-- FLIPPER TAGS
                '----------------------------------------------------------------
                oAcroFields.SetField("txtFlipperTagLeftFront", sFlipperTagLeftFront)
                oAcroFields.SetField("txtFlipperTagRightFront", sFlipperTagRightFront)
                oAcroFields.SetField("txtFlipperTagLeftRear", sFlipperTagLeftRear)
                oAcroFields.SetField("txtFlipperTagRightRear", sFlipperTagRightRear)

                '----------------------------------------------------------------
                '-- PIT TAGS
                '----------------------------------------------------------------
                oAcroFields.SetField("txtPitTagNumber", sPitTagNumber)
                oAcroFields.SetField("txtPitTagLocation", sPitTagLocation)

                '----------------------------------------------------------------
                '-- ORGANIZATION INFORMATION
                '----------------------------------------------------------------
                oAcroFields.SetField("txtOrganizationInformation", sOrganizationInformation)

                '----------------------------------------------------------------
                '-- WAS TURTLE CARRYING TAGS
                '----------------------------------------------------------------
                If oTurtle.WasCarryingTagsWhenEncountered Then
                    oAcroFields.SetField("radTurtleCarryingTags", "Yes")
                    If oTurtle.RecaptureType = "S" Then
                        oAcroFields.SetField("radRecapture", "1")
                    ElseIf oTurtle.RecaptureType = "D" Then
                        oAcroFields.SetField("radRecapture", "2")
                    End If
                Else
                    oAcroFields.SetField("radTurtleCarryingTags", "No")
                End If

                '----------------------------------------------------------------
                '-- TAG RETURN ADDRESS
                '----------------------------------------------------------------
                oAcroFields.SetField("txtTagReturnAddress", oTurtle.TagReturnAddress)

                '----------------------------------------------------------------
                '-- CAPTURE PROJECT stuff
                '----------------------------------------------------------------
                If (oTurtle.CaptureProjectType = "N") Then
                    oAcroFields.SetField("radProjectType", "NestingBeach")
                    If (oTurtle.DidTurtleNest = "Y") Then
                        oAcroFields.SetField("radDidTurtleNest", "Yes")
                    ElseIf (oTurtle.DidTurtleNest = "N") Then
                        oAcroFields.SetField("radDidTurtleNest", "No")
                    ElseIf (oTurtle.DidTurtleNest = "U") Then
                        oAcroFields.SetField("radDidTurtleNest", "Undetermined")
                    End If
                ElseIf (oTurtle.CaptureProjectType = "T") Then
                    oAcroFields.SetField("radProjectType", "TangleNet")
                ElseIf (oTurtle.CaptureProjectType = "P") Then
                    oAcroFields.SetField("radProjectType", "PoundNet")
                ElseIf (oTurtle.CaptureProjectType = "H") Then
                    oAcroFields.SetField("radProjectType", "HandCatch")
                ElseIf (oTurtle.CaptureProjectType = "S") Then
                    oAcroFields.SetField("radProjectType", "Stranding")
                ElseIf (oTurtle.CaptureProjectType = "O") Then
                    oAcroFields.SetField("radProjectType", "Other")
                    oAcroFields.SetField("txtProjectTypeOther", oTurtle.CaptureProjectOther)
                End If

                '----------------------------------------------------------------
                '-- FACILITY
                '----------------------------------------------------------------
                If Me.chkPopulateFacilityField.Checked Then
                    oAcroFields.SetField("txtFacility", sOrganizationInformation)
                End If

                '----------------------------------------------------------------
                '-- CAPTURE LOCATION
                '----------------------------------------------------------------
                oAcroFields.SetField("txtCaptureLocation", oTurtle.AcquiredFrom & Convert.ToString(IIf(String.IsNullOrEmpty(oTurtle.AcquiredCounty), String.Empty, "; County: " & oTurtle.AcquiredCounty)) & Convert.ToString(IIf(String.IsNullOrEmpty(oTurtle.AcquiredLatitudeString), String.Empty, "; Latitude: " & oTurtle.AcquiredLatitudeString)) & Convert.ToString(IIf(String.IsNullOrEmpty(oTurtle.AcquiredLongitudeString), String.Empty, "; Longitude: " & oTurtle.AcquiredLongitudeString)))

                '----------------------------------------------------------------
                '-- RELEASE LOCATION
                '----------------------------------------------------------------
                oAcroFields.SetField("txtReleaseLocation", oTurtle.RelinquishedTo & Convert.ToString(IIf(String.IsNullOrEmpty(oTurtle.RelinquishedCounty), String.Empty, "; County: " & oTurtle.RelinquishedCounty)) & Convert.ToString(IIf(String.IsNullOrEmpty(oTurtle.RelinquishedLatitudeString), String.Empty, "; Latitude: " & oTurtle.RelinquishedLatitudeString)) & Convert.ToString(IIf(String.IsNullOrEmpty(oTurtle.RelinquishedLongitudeString), String.Empty, "; Longitude: " & oTurtle.RelinquishedLongitudeString)))

                '----------------------------------------------------------------
                '-- TAG SCARS
                '----------------------------------------------------------------
                If oTurtle.InspectedForTagScars Then
                    oAcroFields.SetField("radTagScars", "Yes")
                    oAcroFields.SetField("txtTagScars", oTurtle.TagScarsLocated)
                Else
                    oAcroFields.SetField("radTagScars", "No")
                End If

                '----------------------------------------------------------------
                '-- PIT TAGS
                '----------------------------------------------------------------
                If oTurtle.ScannedForPitTags Then
                    oAcroFields.SetField("radPitTags", "Yes")
                    oAcroFields.SetField("txtPitTags", oTurtle.PitTagsScanFrequency)
                Else
                    oAcroFields.SetField("radPitTags", "No")
                End If

                '----------------------------------------------------------------
                '-- MAGNETIC WIRES
                '----------------------------------------------------------------
                If oTurtle.ScannedForMagneticWires Then
                    oAcroFields.SetField("radMagneticWires", "Yes")
                    oAcroFields.SetField("txtMagneticWires", oTurtle.MagneticWiresLocated)
                Else
                    oAcroFields.SetField("radMagneticWires", "No")
                End If

                '----------------------------------------------------------------
                '-- LIVING TAGS
                '----------------------------------------------------------------
                If oTurtle.InspectedForLivingTags Then
                    oAcroFields.SetField("radLivingTags", "Yes")
                    oAcroFields.SetField("txtLivingTags", oTurtle.LivingTagsLocated)
                Else
                    oAcroFields.SetField("radLivingTags", "No")
                End If

                '----------------------------------------------------------------
                '-- ADDITIONAL REMARKS ON BACK
                '----------------------------------------------------------------
                If Me.chkAdditionalRemarksOrDataOnBackOfForm.Checked Then
                    oAcroFields.SetField("radAdditionalRemarksOnBack", "Yes")
                Else
                    oAcroFields.SetField("radAdditionalRemarksOnBack", "No")
                End If

                '----------------------------------------------------------------
                '-- get MORPHOMETRIC information
                '----------------------------------------------------------------
                For i = 0 To oTurtle.TurtleMorphometrics.Count - 1

                    If Not (oTurtle.TurtleMorphometrics(i).DateMeasured.Equals(DateTime.MinValue)) Then

                        If Me.radMorphometricsClosestAcquired.Checked Then

                            If Not oTurtle.DateAcquired.Equals(DateTime.MinValue) Then

                                If (oTurtle.DateAcquired <= oTurtle.TurtleMorphometrics(i).DateMeasured) Then

                                    If (oTurtleMorphometric Is Nothing) Then
                                        oTurtleMorphometric = oTurtle.TurtleMorphometrics(i)
                                    Else
                                        If (oTurtle.TurtleMorphometrics(i).DateMeasured <= oTurtleMorphometric.DateMeasured) Then
                                            oTurtleMorphometric = oTurtle.TurtleMorphometrics(i)
                                        End If
                                    End If

                                End If

                            End If

                        Else 'If Me.radMorphometricsClosestRelinquished.Checked Then

                            If Not oTurtle.DateRelinquished.Equals(DateTime.MinValue) Then

                                If (oTurtle.TurtleMorphometrics(i).DateMeasured <= oTurtle.DateRelinquished) Then

                                    If (oTurtleMorphometric Is Nothing) Then
                                        oTurtleMorphometric = oTurtle.TurtleMorphometrics(i)
                                    Else
                                        If (oTurtleMorphometric.DateMeasured <= oTurtle.TurtleMorphometrics(i).DateMeasured) Then
                                            oTurtleMorphometric = oTurtle.TurtleMorphometrics(i)
                                        End If
                                    End If

                                End If

                            End If

                        End If

                    End If

                Next

                If Not (oTurtleMorphometric Is Nothing) Then

                    If (oTurtleMorphometric.SclNotchNotchValue > 0) Then
                        If (oTurtleMorphometric.SclNotchNotchUnits = "cm") Then
                            oAcroFields.SetField("txtSclMinCm", oTurtleMorphometric.SclNotchNotchValueString)
                        ElseIf (oTurtleMorphometric.SclNotchNotchUnits = "in") Then
                            oAcroFields.SetField("txtSclMinIn", oTurtleMorphometric.SclNotchNotchValueString)
                        End If
                    End If

                    If (oTurtleMorphometric.SclNotchTipValue > 0) Then
                        If (oTurtleMorphometric.SclNotchTipUnits = "cm") Then
                            oAcroFields.SetField("txtSclNotchTipCm", oTurtleMorphometric.SclNotchTipValueString)
                        ElseIf (oTurtleMorphometric.SclNotchTipUnits = "in") Then
                            oAcroFields.SetField("txtSclNotchTipIn", oTurtleMorphometric.SclNotchTipValueString)
                        End If
                    End If

                    If (oTurtleMorphometric.ScwValue > 0) Then
                        If (oTurtleMorphometric.ScwUnits = "cm") Then
                            oAcroFields.SetField("txtScwCm", oTurtleMorphometric.ScwValueString)
                        ElseIf (oTurtleMorphometric.ScwUnits = "in") Then
                            oAcroFields.SetField("txtScwIn", oTurtleMorphometric.ScwValueString)
                        End If
                    End If

                    If (oTurtleMorphometric.CclNotchNotchValue > 0) Then
                        If (oTurtleMorphometric.CclNotchNotchUnits = "cm") Then
                            oAcroFields.SetField("txtCclMinCm", oTurtleMorphometric.CclNotchNotchValueString)
                        ElseIf (oTurtleMorphometric.CclNotchNotchUnits = "in") Then
                            oAcroFields.SetField("txtCclMinIn", oTurtleMorphometric.CclNotchNotchValueString)
                        End If
                    End If

                    If (oTurtleMorphometric.CclNotchTipValue > 0) Then
                        If (oTurtleMorphometric.CclNotchTipUnits = "cm") Then
                            oAcroFields.SetField("txtCclNotchTipCm", oTurtleMorphometric.CclNotchTipValueString)
                        ElseIf (oTurtleMorphometric.CclNotchTipUnits = "in") Then
                            oAcroFields.SetField("txtCclNotchTipIn", oTurtleMorphometric.CclNotchTipValueString)
                        End If
                    End If

                    If (oTurtleMorphometric.CcwValue > 0) Then
                        If (oTurtleMorphometric.CcwUnits = "cm") Then
                            oAcroFields.SetField("txtCcwCm", oTurtleMorphometric.CcwValueString)
                        ElseIf (oTurtleMorphometric.CcwUnits = "in") Then
                            oAcroFields.SetField("txtCcwIn", oTurtleMorphometric.CcwValueString)
                        End If
                    End If

                    If (oTurtleMorphometric.WeightValue > 0) Then
                        If (oTurtleMorphometric.WeightUnits = "kg") Then
                            oAcroFields.SetField("txtWeightKg", oTurtleMorphometric.WeightValueString)
                        ElseIf (oTurtleMorphometric.WeightUnits = "lb") Then
                            oAcroFields.SetField("txtWeightLbs", oTurtleMorphometric.WeightValueString)
                        End If
                    End If

                End If

                oAcroFields = Nothing

                '----------------------------------------------------------------
                ''v-- add this to make the form READ-ONLY
                '----------------------------------------------------------------
                oPdfStamper.FormFlattening = True
                ''^-- add this to make the form READ-ONLY

                oPdfStamper.Close()
                oPdfStamper = Nothing

                oPdfReader.Close()
                oPdfReader = Nothing

                '----------------------------------------------------------------
                '-- display the filled-in PDF file
                '----------------------------------------------------------------
                System.Diagnostics.Process.Start(sFilledReportName)

            End If

            '----------------------------------------------------------------
            '-- refresh the saved report list
            '----------------------------------------------------------------
            LoadSavedReportGridData()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            oTurtle = Nothing
            oOrganization = Nothing

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
            frm.HeaderText = "Tagging Data form"

            sb.Append("The Date Captured value comes from the turtle's Date Acquired field.")
            sb.Append(ControlChars.CrLf)
            sb.Append(ControlChars.CrLf)
            sb.Append("The tags associated with the turtle will appear in the Tag Numbers section.")
            sb.Append(ControlChars.CrLf)
            sb.Append(ControlChars.CrLf)
            'sb.Append("The Acquired From location will appear as extra information in the Status field, but only when the report date range is one quarter or less.")
            'sb.Append(ControlChars.CrLf)
            'sb.Append(ControlChars.CrLf)
            'sb.Append("The Stranding ID # associated with the turtle will appear as extra information in the Date Released field.")
            'sb.Append(ControlChars.CrLf)
            'sb.Append(ControlChars.CrLf)
            frm.BodyText = sb.ToString
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "TaggingDataForm.htm")
    End Sub

#Region " Saved Reports Grid "

    Private Sub LoadSavedReportGridData()

        Dim sFormTitle As String = String.Empty

        Try
            Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- add the data to the grid
            '----------------------------------------------------------------
            sFormTitle = MASTER_TAGGING_DATA_FORM_PDF.Replace("MASTER - ", "").Replace(".master.pdf", "")

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
