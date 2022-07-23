Option Explicit On 
Option Strict On
Option Compare Text

Public Class MarineTurtleCaptiveFacilityQuarterlyReportForWashbacksDlg
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
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents tabReportTab As System.Windows.Forms.TabControl
    Friend WithEvents tpgActions As System.Windows.Forms.TabPage
    Friend WithEvents lblDateThru As System.Windows.Forms.Label
    Friend WithEvents lblDateFrom As System.Windows.Forms.Label
    Friend WithEvents radFillManually As System.Windows.Forms.RadioButton
    Friend WithEvents dtpDateThru As TurtleGeek.Controls.DateComboBox
    Friend WithEvents dtpDateFrom As TurtleGeek.Controls.DateComboBox
    Friend WithEvents radFillDatabase As System.Windows.Forms.RadioButton
    Friend WithEvents picMoreInfoReport As System.Windows.Forms.PictureBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents tpgOptions As System.Windows.Forms.TabPage
    Friend WithEvents tpgSavedReports As System.Windows.Forms.TabPage
    Friend WithEvents lblSavedReportsList As System.Windows.Forms.Label
    Friend WithEvents txtComments As System.Windows.Forms.TextBox
    Friend WithEvents lblComments As System.Windows.Forms.Label
    Friend WithEvents SavedReportGridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grdSavedReportsGrid As System.Windows.Forms.DataGridView
    Friend WithEvents colSavedReportEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colSavedReportDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colSavedReportReportFileNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSavedReportDateOfReportDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents chkIncludeDoaCounts As System.Windows.Forms.CheckBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MarineTurtleCaptiveFacilityQuarterlyReportForWashbacksDlg))
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.btnCreate = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnHelp = New System.Windows.Forms.Button
        Me.tabReportTab = New System.Windows.Forms.TabControl
        Me.tpgActions = New System.Windows.Forms.TabPage
        Me.lblDateThru = New System.Windows.Forms.Label
        Me.lblDateFrom = New System.Windows.Forms.Label
        Me.radFillManually = New System.Windows.Forms.RadioButton
        Me.dtpDateThru = New TurtleGeek.Controls.DateComboBox
        Me.dtpDateFrom = New TurtleGeek.Controls.DateComboBox
        Me.radFillDatabase = New System.Windows.Forms.RadioButton
        Me.picMoreInfoReport = New System.Windows.Forms.PictureBox
        Me.lblDescription = New System.Windows.Forms.Label
        Me.tpgOptions = New System.Windows.Forms.TabPage
        Me.txtComments = New System.Windows.Forms.TextBox
        Me.lblComments = New System.Windows.Forms.Label
        Me.tpgSavedReports = New System.Windows.Forms.TabPage
        Me.grdSavedReportsGrid = New System.Windows.Forms.DataGridView
        Me.colSavedReportEditActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colSavedReportDeleteActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colSavedReportReportFileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSavedReportDateOfReportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colSavedReportDisplayDateOfReportDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SavedReportGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblSavedReportsList = New System.Windows.Forms.Label
        Me.chkIncludeDoaCounts = New System.Windows.Forms.CheckBox
        Me.tabReportTab.SuspendLayout()
        Me.tpgActions.SuspendLayout()
        CType(Me.picMoreInfoReport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgOptions.SuspendLayout()
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
        Me.btnCreate.TabIndex = 2
        Me.btnCreate.Text = "Create"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(440, 200)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 24)
        Me.btnClose.TabIndex = 3
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
        Me.lblSeparator.TabIndex = 1
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(8, 200)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 24)
        Me.btnHelp.TabIndex = 4
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
        Me.dtpDateThru.BackColor = System.Drawing.SystemColors.Window
        Me.dtpDateThru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dtpDateThru.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtpDateThru.DateValue = New Date(2006, 5, 31, 0, 0, 0, 0)
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
        Me.radFillDatabase.Checked = True
        Me.radFillDatabase.Location = New System.Drawing.Point(16, 43)
        Me.radFillDatabase.Name = "radFillDatabase"
        Me.radFillDatabase.Size = New System.Drawing.Size(472, 17)
        Me.radFillDatabase.TabIndex = 1
        Me.radFillDatabase.TabStop = True
        Me.radFillDatabase.Text = "Populate the report using the information that is stored in the database."
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
        Me.tpgOptions.Controls.Add(Me.chkIncludeDoaCounts)
        Me.tpgOptions.Controls.Add(Me.txtComments)
        Me.tpgOptions.Controls.Add(Me.lblComments)
        Me.tpgOptions.Location = New System.Drawing.Point(4, 22)
        Me.tpgOptions.Name = "tpgOptions"
        Me.tpgOptions.Size = New System.Drawing.Size(496, 142)
        Me.tpgOptions.TabIndex = 1
        Me.tpgOptions.Text = "Options"
        '
        'txtComments
        '
        Me.txtComments.Location = New System.Drawing.Point(12, 25)
        Me.txtComments.Multiline = True
        Me.txtComments.Name = "txtComments"
        Me.txtComments.Size = New System.Drawing.Size(480, 91)
        Me.txtComments.TabIndex = 1
        '
        'lblComments
        '
        Me.lblComments.AutoSize = True
        Me.lblComments.Location = New System.Drawing.Point(9, 9)
        Me.lblComments.Name = "lblComments"
        Me.lblComments.Size = New System.Drawing.Size(59, 13)
        Me.lblComments.TabIndex = 0
        Me.lblComments.Text = "Comments:"
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
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdSavedReportsGrid.DefaultCellStyle = DataGridViewCellStyle8
        Me.grdSavedReportsGrid.Location = New System.Drawing.Point(8, 24)
        Me.grdSavedReportsGrid.MultiSelect = False
        Me.grdSavedReportsGrid.Name = "grdSavedReportsGrid"
        Me.grdSavedReportsGrid.ReadOnly = True
        Me.grdSavedReportsGrid.RowHeadersVisible = False
        Me.grdSavedReportsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdSavedReportsGrid.Size = New System.Drawing.Size(480, 112)
        Me.grdSavedReportsGrid.TabIndex = 1
        '
        'colSavedReportEditActionDataGridViewLinkColumn
        '
        Me.colSavedReportEditActionDataGridViewLinkColumn.DataPropertyName = "EditAction"
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colSavedReportEditActionDataGridViewLinkColumn.DefaultCellStyle = DataGridViewCellStyle5
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
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        Me.colSavedReportDeleteActionDataGridViewLinkColumn.DefaultCellStyle = DataGridViewCellStyle6
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
        DataGridViewCellStyle7.Format = "G"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.colSavedReportDateOfReportDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
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
        'chkIncludeDoaCounts
        '
        Me.chkIncludeDoaCounts.AutoSize = True
        Me.chkIncludeDoaCounts.Location = New System.Drawing.Point(12, 122)
        Me.chkIncludeDoaCounts.Name = "chkIncludeDoaCounts"
        Me.chkIncludeDoaCounts.Size = New System.Drawing.Size(241, 17)
        Me.chkIncludeDoaCounts.TabIndex = 2
        Me.chkIncludeDoaCounts.Text = "Include DOA counts by species for this period"
        Me.chkIncludeDoaCounts.UseVisualStyleBackColor = True
        '
        'MarineTurtleCaptiveFacilityQuarterlyReportForWashbacksDlg
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
        Me.Name = "MarineTurtleCaptiveFacilityQuarterlyReportForWashbacksDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Marine Turtle Captive Facility Quarterly Report For Washbacks"
        Me.tabReportTab.ResumeLayout(False)
        Me.tpgActions.ResumeLayout(False)
        Me.tpgActions.PerformLayout()
        CType(Me.picMoreInfoReport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgOptions.ResumeLayout(False)
        Me.tpgOptions.PerformLayout()
        Me.tpgSavedReports.ResumeLayout(False)
        Me.tpgSavedReports.PerformLayout()
        CType(Me.grdSavedReportsGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SavedReportGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim iCurrentMonth As Integer
        Dim iCurrentMonthDiff As Integer
        Dim dtDateTimeNow As Date
        Dim dtDateTimeLastMonthOfLastQuarter As Date

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

    Private Sub radFillManually_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetControlState()
    End Sub

    Private Sub radFillDatabase_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        SetControlState()
    End Sub

    Private Sub SetControlState()
        dtpDateFrom.Enabled = radFillDatabase.Checked
        dtpDateThru.Enabled = radFillDatabase.Checked
    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        Dim iStartingBalance As Integer

        Dim sMonthsAndYearOfReport As String = String.Empty
        Dim sOrganizationAndPermitNumber As String = String.Empty

        Dim sFieldNumber As String = String.Empty
        Dim sFieldsReportName As String = MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_WASHBACKS_PDF
        Dim sFilledReportName As String = String.Empty

        Dim sComments As String = String.Empty

        Dim dtDateFrom As Date
        Dim dtDateThru As Date
        Dim dtTempDate As Date

        Dim oOrganization As Organization
        Dim oCaptiveFacilityWashbacksReportItem As CaptiveFacilityWashbacksReportItem

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
                sFilledReportName = sFieldsReportName.Replace("MASTER - ", "FILLED - ").Replace(".master.pdf", " - " & Now.ToString("yyyyMMddHHmmss") & ".pdf")
                System.IO.File.Copy(sFieldsReportName, sFilledReportName)
                System.Diagnostics.Process.Start(sFilledReportName)

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

                '----------------------------------------------------------------
                '-- get WASHBACK EVENT data for report
                '----------------------------------------------------------------
                oCaptiveFacilityWashbacksReportItem = CaptiveFacilityWashbacksReportItem.GetCaptiveFacilityWashbacksReportItem(dtDateFrom, dtDateThru)

                '----------------------------------------------------------------
                '-- open the field-ready PDF file
                '----------------------------------------------------------------
                oPdfReader = New PdfReader(sFieldsReportName)
                oPdfDictionary = DirectCast(PdfReader.GetPdfObject(oPdfReader.Catalog.Get(PdfName.ACROFORM)), PdfDictionary)
                oPdfDictionary.Remove(New PdfName("XFA"))

                sFilledReportName = sFieldsReportName.Replace("MASTER - ", "FILLED - ").Replace(".master.pdf", " - " & Now.ToString("yyyyMMddHHmmss") & ".pdf")
                oPdfStamper = New PdfStamper(oPdfReader, New System.IO.FileStream(sFilledReportName, IO.FileMode.Create))

                oAcroFields = oPdfStamper.AcroFields()
                oAcroFields.SetField("txtOrganizationAndPermitNumber", sOrganizationAndPermitNumber)
                oAcroFields.SetField("txtMonthsAndYearOfReport", sMonthsAndYearOfReport)

                iStartingBalance = oCaptiveFacilityWashbacksReportItem.CcWashbackStartingBalance + oCaptiveFacilityWashbacksReportItem.CcWashbackAdditionsBeforeThisPeriod - oCaptiveFacilityWashbacksReportItem.CcWashbackSubtractionsBeforeThisPeriod
                oAcroFields.SetField("txtCcPrevBal", Convert.ToString(iStartingBalance))
                oAcroFields.SetField("txtCcAcquired", Convert.ToString(oCaptiveFacilityWashbacksReportItem.CcWashbacksAcquiredThisPeriod))
                oAcroFields.SetField("txtCcDied", Convert.ToString(oCaptiveFacilityWashbacksReportItem.CcWashbacksDiedThisPeriod))
                oAcroFields.SetField("txtCcReleased", Convert.ToString(oCaptiveFacilityWashbacksReportItem.CcWashbacksReleasedOnTheBeachThisPeriod + oCaptiveFacilityWashbacksReportItem.CcWashbacksReleasedOffshoreThisPeriod))
                oAcroFields.SetField("txtCcEndBal", Convert.ToString(iStartingBalance + oCaptiveFacilityWashbacksReportItem.CcWashbacksAcquiredThisPeriod - oCaptiveFacilityWashbacksReportItem.CcWashbacksDiedThisPeriod - oCaptiveFacilityWashbacksReportItem.CcWashbacksReleasedOnTheBeachThisPeriod - oCaptiveFacilityWashbacksReportItem.CcWashbacksReleasedOffshoreThisPeriod))
                oAcroFields.SetField("txtCcBeachVsOffshore", "Beach: " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.CcWashbacksReleasedOnTheBeachThisPeriod) & ControlChars.NewLine & "Offshore: " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.CcWashbacksReleasedOffshoreThisPeriod))

                iStartingBalance = oCaptiveFacilityWashbacksReportItem.CmWashbackStartingBalance + oCaptiveFacilityWashbacksReportItem.CmWashbackAdditionsBeforeThisPeriod - oCaptiveFacilityWashbacksReportItem.CmWashbackSubtractionsBeforeThisPeriod
                oAcroFields.SetField("txtCmPrevBal", Convert.ToString(iStartingBalance))
                oAcroFields.SetField("txtCmAcquired", Convert.ToString(oCaptiveFacilityWashbacksReportItem.CmWashbacksAcquiredThisPeriod))
                oAcroFields.SetField("txtCmDied", Convert.ToString(oCaptiveFacilityWashbacksReportItem.CmWashbacksDiedThisPeriod))
                oAcroFields.SetField("txtCmReleased", Convert.ToString(oCaptiveFacilityWashbacksReportItem.CmWashbacksReleasedOnTheBeachThisPeriod + oCaptiveFacilityWashbacksReportItem.CmWashbacksReleasedOffshoreThisPeriod))
                oAcroFields.SetField("txtCmEndBal", Convert.ToString(iStartingBalance + oCaptiveFacilityWashbacksReportItem.CmWashbacksAcquiredThisPeriod - oCaptiveFacilityWashbacksReportItem.CmWashbacksDiedThisPeriod - oCaptiveFacilityWashbacksReportItem.CmWashbacksReleasedOnTheBeachThisPeriod - oCaptiveFacilityWashbacksReportItem.CmWashbacksReleasedOffshoreThisPeriod))
                oAcroFields.SetField("txtCmBeachVsOffshore", "Beach: " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.CmWashbacksReleasedOnTheBeachThisPeriod) & ControlChars.NewLine & "Offshore: " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.CmWashbacksReleasedOffshoreThisPeriod))

                iStartingBalance = oCaptiveFacilityWashbacksReportItem.DcWashbackStartingBalance + oCaptiveFacilityWashbacksReportItem.DcWashbackAdditionsBeforeThisPeriod - oCaptiveFacilityWashbacksReportItem.DcWashbackSubtractionsBeforeThisPeriod
                oAcroFields.SetField("txtDcPrevBal", Convert.ToString(iStartingBalance))
                oAcroFields.SetField("txtDcAcquired", Convert.ToString(oCaptiveFacilityWashbacksReportItem.DcWashbacksAcquiredThisPeriod))
                oAcroFields.SetField("txtDcDied", Convert.ToString(oCaptiveFacilityWashbacksReportItem.DcWashbacksDiedThisPeriod))
                oAcroFields.SetField("txtDcReleased", Convert.ToString(oCaptiveFacilityWashbacksReportItem.DcWashbacksReleasedOnTheBeachThisPeriod + oCaptiveFacilityWashbacksReportItem.DcWashbacksReleasedOffshoreThisPeriod))
                oAcroFields.SetField("txtDcEndBal", Convert.ToString(iStartingBalance + oCaptiveFacilityWashbacksReportItem.DcWashbacksAcquiredThisPeriod - oCaptiveFacilityWashbacksReportItem.DcWashbacksDiedThisPeriod - oCaptiveFacilityWashbacksReportItem.DcWashbacksReleasedOnTheBeachThisPeriod - oCaptiveFacilityWashbacksReportItem.DcWashbacksReleasedOffshoreThisPeriod))
                oAcroFields.SetField("txtDcBeachVsOffshore", "Beach: " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.DcWashbacksReleasedOnTheBeachThisPeriod) & ControlChars.NewLine & "Offshore: " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.DcWashbacksReleasedOffshoreThisPeriod))

                iStartingBalance = oCaptiveFacilityWashbacksReportItem.OtherWashbackStartingBalance + oCaptiveFacilityWashbacksReportItem.OtherWashbackAdditionsBeforeThisPeriod - oCaptiveFacilityWashbacksReportItem.OtherWashbackSubtractionsBeforeThisPeriod
                oAcroFields.SetField("txtOtherPrevBal", Convert.ToString(iStartingBalance))
                oAcroFields.SetField("txtOtherAcquired", Convert.ToString(oCaptiveFacilityWashbacksReportItem.OtherWashbacksAcquiredThisPeriod))
                oAcroFields.SetField("txtOtherDied", Convert.ToString(oCaptiveFacilityWashbacksReportItem.OtherWashbacksDiedThisPeriod))
                oAcroFields.SetField("txtOtherReleased", Convert.ToString(oCaptiveFacilityWashbacksReportItem.OtherWashbacksReleasedOnTheBeachThisPeriod + oCaptiveFacilityWashbacksReportItem.OtherWashbacksReleasedOffshoreThisPeriod))
                oAcroFields.SetField("txtOtherEndBal", Convert.ToString(iStartingBalance + oCaptiveFacilityWashbacksReportItem.OtherWashbacksAcquiredThisPeriod - oCaptiveFacilityWashbacksReportItem.OtherWashbacksDiedThisPeriod - oCaptiveFacilityWashbacksReportItem.OtherWashbacksReleasedOnTheBeachThisPeriod - oCaptiveFacilityWashbacksReportItem.OtherWashbacksReleasedOffshoreThisPeriod))
                oAcroFields.SetField("txtOtherBeachVsOffshore", "Beach: " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.OtherWashbacksReleasedOnTheBeachThisPeriod) & ControlChars.NewLine & "Offshore: " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.OtherWashbacksReleasedOffshoreThisPeriod))

                iStartingBalance = oCaptiveFacilityWashbacksReportItem.UnknownWashbackStartingBalance + oCaptiveFacilityWashbacksReportItem.UnknownWashbackAdditionsBeforeThisPeriod - oCaptiveFacilityWashbacksReportItem.UnknownWashbackSubtractionsBeforeThisPeriod
                oAcroFields.SetField("txtUnknownPrevBal", Convert.ToString(iStartingBalance))
                oAcroFields.SetField("txtUnknownAcquired", Convert.ToString(oCaptiveFacilityWashbacksReportItem.UnknownWashbacksAcquiredThisPeriod))
                oAcroFields.SetField("txtUnknownDied", Convert.ToString(oCaptiveFacilityWashbacksReportItem.UnknownWashbacksDiedThisPeriod))
                oAcroFields.SetField("txtUnknownReleased", Convert.ToString(oCaptiveFacilityWashbacksReportItem.UnknownWashbacksReleasedOnTheBeachThisPeriod + oCaptiveFacilityWashbacksReportItem.UnknownWashbacksReleasedOffshoreThisPeriod))
                oAcroFields.SetField("txtUnknownEndBal", Convert.ToString(iStartingBalance + oCaptiveFacilityWashbacksReportItem.UnknownWashbacksAcquiredThisPeriod - oCaptiveFacilityWashbacksReportItem.UnknownWashbacksDiedThisPeriod - oCaptiveFacilityWashbacksReportItem.UnknownWashbacksReleasedOnTheBeachThisPeriod - oCaptiveFacilityWashbacksReportItem.UnknownWashbacksReleasedOffshoreThisPeriod))
                oAcroFields.SetField("txtUnknownBeachVsOffshore", "Beach: " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.UnknownWashbacksReleasedOnTheBeachThisPeriod) & ControlChars.NewLine & "Offshore: " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.UnknownWashbacksReleasedOffshoreThisPeriod))

                If (Me.chkIncludeDoaCounts.Checked) Then

                    If (oCaptiveFacilityWashbacksReportItem.CcWashbacksDoaThisPeriod > 0) Then
                        If (sComments.Length > 0) Then
                            sComments &= "; "
                        End If
                        sComments &= "DOA Cc washbacks = " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.CcWashbacksDoaThisPeriod)
                    End If

                    If (oCaptiveFacilityWashbacksReportItem.CmWashbacksDoaThisPeriod > 0) Then
                        If (sComments.Length > 0) Then
                            sComments &= "; "
                        End If
                        sComments &= "DOA Cm washbacks = " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.CmWashbacksDoaThisPeriod)
                    End If

                    If (oCaptiveFacilityWashbacksReportItem.DcWashbacksDoaThisPeriod > 0) Then
                        If (sComments.Length > 0) Then
                            sComments &= "; "
                        End If
                        sComments &= "DOA Dc washbacks = " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.DcWashbacksDoaThisPeriod)
                    End If

                    If (oCaptiveFacilityWashbacksReportItem.OtherWashbacksDoaThisPeriod > 0) Then
                        If (sComments.Length > 0) Then
                            sComments &= "; "
                        End If
                        sComments &= "DOA Other washbacks = " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.OtherWashbacksDoaThisPeriod)
                    End If

                    If (oCaptiveFacilityWashbacksReportItem.UnknownWashbacksDoaThisPeriod > 0) Then
                        If (sComments.Length > 0) Then
                            sComments &= "; "
                        End If
                        sComments &= "DOA Unknown washbacks = " & Convert.ToString(oCaptiveFacilityWashbacksReportItem.UnknownWashbacksDoaThisPeriod)
                    End If

                End If

                If (sComments.Length > 0) Then
                    sComments += "; "
                End If
                sComments &= Me.txtComments.Text

                oAcroFields.SetField("txtComments", sComments)

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
                '-- display all pages of the filled-in PDF file
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

            oCaptiveFacilityWashbacksReportItem = Nothing
            oOrganization = Nothing

            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "MarineTurtleCaptiveFacilityQuarterlyReportForWashbacks.htm")
    End Sub

#Region " Saved Reports Grid "

    Private Sub LoadSavedReportGridData()

        Dim sFormTitle As String = String.Empty

        Try
            Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- add the data to the grid
            '----------------------------------------------------------------
            sFormTitle = MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_WASHBACKS_PDF.Replace("MASTER - ", "").Replace(".master.pdf", "")

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
