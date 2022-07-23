Option Explicit On 
Option Strict On
Option Compare Text

Public Class TankInformationDlg
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
    Friend WithEvents lblSeparator As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents tipToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents txtTankName As System.Windows.Forms.TextBox
    Friend WithEvents lblTankName As System.Windows.Forms.Label
    Friend WithEvents grpWaters As System.Windows.Forms.GroupBox
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents btnAddWater As System.Windows.Forms.Button
    Friend WithEvents grdTankWaterGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TankWaterGridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colWaterTankIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWaterTankNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents erpErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents tabTankInformationTab As System.Windows.Forms.TabControl
    Friend WithEvents tpgMeasurements As System.Windows.Forms.TabPage
    Friend WithEvents tpgTemperatureGraph As System.Windows.Forms.TabPage
    Friend WithEvents graphTemperature As TurtleGeek.Graphics.Windows.PlotSurface2D
    Friend WithEvents colWaterEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colWaterDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colWaterTankWaterIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWaterDateMeasuredBindableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWaterDateMeasuredStringDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWaterTemperatureDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWaterSalinityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWaterPhDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpgSalinityGraph As System.Windows.Forms.TabPage
    Friend WithEvents graphSalinity As TurtleGeek.Graphics.Windows.PlotSurface2D
    Friend WithEvents tpgPhGraph As System.Windows.Forms.TabPage
    Friend WithEvents graphPh As TurtleGeek.Graphics.Windows.PlotSurface2D
    Friend WithEvents lnkPrintTemperatureGraph As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkPrintSalinityGraph As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkPrintPhGraph As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkCopyToClipboardTemperatureGraph As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkCopyToClipboardSalinityGraph As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkCopyToClipboardPhGraph As System.Windows.Forms.LinkLabel
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TankInformationDlg))
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.tipToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.txtTankName = New System.Windows.Forms.TextBox
        Me.lblTankName = New System.Windows.Forms.Label
        Me.grpWaters = New System.Windows.Forms.GroupBox
        Me.tabTankInformationTab = New System.Windows.Forms.TabControl
        Me.tpgMeasurements = New System.Windows.Forms.TabPage
        Me.grdTankWaterGrid = New System.Windows.Forms.DataGridView
        Me.colWaterEditActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colWaterDeleteActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colWaterTankWaterIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWaterDateMeasuredBindableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWaterDateMeasuredStringDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWaterTemperatureDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWaterSalinityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWaterPhDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TankWaterGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.lblDescription = New System.Windows.Forms.Label
        Me.tpgTemperatureGraph = New System.Windows.Forms.TabPage
        Me.lnkCopyToClipboardTemperatureGraph = New System.Windows.Forms.LinkLabel
        Me.lnkPrintTemperatureGraph = New System.Windows.Forms.LinkLabel
        Me.graphTemperature = New TurtleGeek.Graphics.Windows.PlotSurface2D
        Me.tpgSalinityGraph = New System.Windows.Forms.TabPage
        Me.lnkCopyToClipboardSalinityGraph = New System.Windows.Forms.LinkLabel
        Me.lnkPrintSalinityGraph = New System.Windows.Forms.LinkLabel
        Me.graphSalinity = New TurtleGeek.Graphics.Windows.PlotSurface2D
        Me.tpgPhGraph = New System.Windows.Forms.TabPage
        Me.lnkCopyToClipboardPhGraph = New System.Windows.Forms.LinkLabel
        Me.lnkPrintPhGraph = New System.Windows.Forms.LinkLabel
        Me.graphPh = New TurtleGeek.Graphics.Windows.PlotSurface2D
        Me.btnAddWater = New System.Windows.Forms.Button
        Me.btnHelp = New System.Windows.Forms.Button
        Me.erpErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.grpWaters.SuspendLayout()
        Me.tabTankInformationTab.SuspendLayout()
        Me.tpgMeasurements.SuspendLayout()
        CType(Me.grdTankWaterGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TankWaterGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgTemperatureGraph.SuspendLayout()
        Me.tpgSalinityGraph.SuspendLayout()
        Me.tpgPhGraph.SuspendLayout()
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(8, 360)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(528, 2)
        Me.lblSeparator.TabIndex = 4
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(464, 376)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(384, 376)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 24)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        '
        'txtTankName
        '
        Me.txtTankName.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtTankName.Location = New System.Drawing.Point(80, 8)
        Me.txtTankName.MaxLength = 255
        Me.txtTankName.Name = "txtTankName"
        Me.txtTankName.Size = New System.Drawing.Size(448, 20)
        Me.txtTankName.TabIndex = 1
        '
        'lblTankName
        '
        Me.lblTankName.Location = New System.Drawing.Point(8, 8)
        Me.lblTankName.Name = "lblTankName"
        Me.lblTankName.Size = New System.Drawing.Size(72, 20)
        Me.lblTankName.TabIndex = 0
        Me.lblTankName.Text = "Tank name:"
        Me.lblTankName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'grpWaters
        '
        Me.grpWaters.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpWaters.Controls.Add(Me.tabTankInformationTab)
        Me.grpWaters.Location = New System.Drawing.Point(8, 40)
        Me.grpWaters.Name = "grpWaters"
        Me.grpWaters.Size = New System.Drawing.Size(528, 312)
        Me.grpWaters.TabIndex = 3
        Me.grpWaters.TabStop = False
        Me.grpWaters.Text = "Water Quality Measurements"
        '
        'tabTankInformationTab
        '
        Me.tabTankInformationTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabTankInformationTab.Controls.Add(Me.tpgMeasurements)
        Me.tabTankInformationTab.Controls.Add(Me.tpgTemperatureGraph)
        Me.tabTankInformationTab.Controls.Add(Me.tpgSalinityGraph)
        Me.tabTankInformationTab.Controls.Add(Me.tpgPhGraph)
        Me.tabTankInformationTab.Location = New System.Drawing.Point(11, 22)
        Me.tabTankInformationTab.Name = "tabTankInformationTab"
        Me.tabTankInformationTab.SelectedIndex = 0
        Me.tabTankInformationTab.Size = New System.Drawing.Size(509, 284)
        Me.tabTankInformationTab.TabIndex = 1
        '
        'tpgMeasurements
        '
        Me.tpgMeasurements.Controls.Add(Me.grdTankWaterGrid)
        Me.tpgMeasurements.Controls.Add(Me.lblDescription)
        Me.tpgMeasurements.Location = New System.Drawing.Point(4, 22)
        Me.tpgMeasurements.Name = "tpgMeasurements"
        Me.tpgMeasurements.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgMeasurements.Size = New System.Drawing.Size(501, 258)
        Me.tpgMeasurements.TabIndex = 0
        Me.tpgMeasurements.Text = "Measurements"
        Me.tpgMeasurements.UseVisualStyleBackColor = True
        '
        'grdTankWaterGrid
        '
        Me.grdTankWaterGrid.AllowUserToAddRows = False
        Me.grdTankWaterGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTankWaterGrid.AutoGenerateColumns = False
        Me.grdTankWaterGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdTankWaterGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colWaterEditActionDataGridViewLinkColumn, Me.colWaterDeleteActionDataGridViewLinkColumn, Me.colWaterTankWaterIDDataGridViewTextBoxColumn, Me.colWaterDateMeasuredBindableDataGridViewTextBoxColumn, Me.colWaterDateMeasuredStringDataGridViewTextBoxColumn, Me.colWaterTemperatureDataGridViewTextBoxColumn, Me.colWaterSalinityDataGridViewTextBoxColumn, Me.colWaterPhDataGridViewTextBoxColumn})
        Me.grdTankWaterGrid.DataSource = Me.TankWaterGridBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdTankWaterGrid.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdTankWaterGrid.Location = New System.Drawing.Point(0, 27)
        Me.grdTankWaterGrid.MultiSelect = False
        Me.grdTankWaterGrid.Name = "grdTankWaterGrid"
        Me.grdTankWaterGrid.ReadOnly = True
        Me.grdTankWaterGrid.RowHeadersVisible = False
        Me.grdTankWaterGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTankWaterGrid.Size = New System.Drawing.Size(498, 231)
        Me.grdTankWaterGrid.TabIndex = 2
        '
        'colWaterEditActionDataGridViewLinkColumn
        '
        Me.colWaterEditActionDataGridViewLinkColumn.DataPropertyName = "EditAction"
        Me.colWaterEditActionDataGridViewLinkColumn.Frozen = True
        Me.colWaterEditActionDataGridViewLinkColumn.HeaderText = ""
        Me.colWaterEditActionDataGridViewLinkColumn.Name = "colWaterEditActionDataGridViewLinkColumn"
        Me.colWaterEditActionDataGridViewLinkColumn.ReadOnly = True
        Me.colWaterEditActionDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colWaterEditActionDataGridViewLinkColumn.TrackVisitedState = False
        Me.colWaterEditActionDataGridViewLinkColumn.Width = 28
        '
        'colWaterDeleteActionDataGridViewLinkColumn
        '
        Me.colWaterDeleteActionDataGridViewLinkColumn.DataPropertyName = "DeleteAction"
        Me.colWaterDeleteActionDataGridViewLinkColumn.Frozen = True
        Me.colWaterDeleteActionDataGridViewLinkColumn.HeaderText = ""
        Me.colWaterDeleteActionDataGridViewLinkColumn.Name = "colWaterDeleteActionDataGridViewLinkColumn"
        Me.colWaterDeleteActionDataGridViewLinkColumn.ReadOnly = True
        Me.colWaterDeleteActionDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colWaterDeleteActionDataGridViewLinkColumn.TrackVisitedState = False
        Me.colWaterDeleteActionDataGridViewLinkColumn.Width = 40
        '
        'colWaterTankWaterIDDataGridViewTextBoxColumn
        '
        Me.colWaterTankWaterIDDataGridViewTextBoxColumn.DataPropertyName = "TankWaterID"
        Me.colWaterTankWaterIDDataGridViewTextBoxColumn.HeaderText = "TankWaterID"
        Me.colWaterTankWaterIDDataGridViewTextBoxColumn.Name = "colWaterTankWaterIDDataGridViewTextBoxColumn"
        Me.colWaterTankWaterIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.colWaterTankWaterIDDataGridViewTextBoxColumn.Visible = False
        '
        'colWaterDateMeasuredBindableDataGridViewTextBoxColumn
        '
        Me.colWaterDateMeasuredBindableDataGridViewTextBoxColumn.DataPropertyName = "DateMeasuredBindable"
        DataGridViewCellStyle1.Format = "d"
        Me.colWaterDateMeasuredBindableDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.colWaterDateMeasuredBindableDataGridViewTextBoxColumn.HeaderText = "Date Measured"
        Me.colWaterDateMeasuredBindableDataGridViewTextBoxColumn.Name = "colWaterDateMeasuredBindableDataGridViewTextBoxColumn"
        Me.colWaterDateMeasuredBindableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colWaterDateMeasuredStringDataGridViewTextBoxColumn
        '
        Me.colWaterDateMeasuredStringDataGridViewTextBoxColumn.DataPropertyName = "DateMeasuredString"
        Me.colWaterDateMeasuredStringDataGridViewTextBoxColumn.HeaderText = "DateMeasuredString"
        Me.colWaterDateMeasuredStringDataGridViewTextBoxColumn.Name = "colWaterDateMeasuredStringDataGridViewTextBoxColumn"
        Me.colWaterDateMeasuredStringDataGridViewTextBoxColumn.ReadOnly = True
        Me.colWaterDateMeasuredStringDataGridViewTextBoxColumn.Visible = False
        '
        'colWaterTemperatureDataGridViewTextBoxColumn
        '
        Me.colWaterTemperatureDataGridViewTextBoxColumn.DataPropertyName = "Temperature"
        Me.colWaterTemperatureDataGridViewTextBoxColumn.HeaderText = "Temperature"
        Me.colWaterTemperatureDataGridViewTextBoxColumn.Name = "colWaterTemperatureDataGridViewTextBoxColumn"
        Me.colWaterTemperatureDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colWaterSalinityDataGridViewTextBoxColumn
        '
        Me.colWaterSalinityDataGridViewTextBoxColumn.DataPropertyName = "Salinity"
        Me.colWaterSalinityDataGridViewTextBoxColumn.HeaderText = "Salinity"
        Me.colWaterSalinityDataGridViewTextBoxColumn.Name = "colWaterSalinityDataGridViewTextBoxColumn"
        Me.colWaterSalinityDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colWaterPhDataGridViewTextBoxColumn
        '
        Me.colWaterPhDataGridViewTextBoxColumn.DataPropertyName = "Ph"
        Me.colWaterPhDataGridViewTextBoxColumn.HeaderText = "Ph"
        Me.colWaterPhDataGridViewTextBoxColumn.Name = "colWaterPhDataGridViewTextBoxColumn"
        Me.colWaterPhDataGridViewTextBoxColumn.ReadOnly = True
        '
        'TankWaterGridBindingSource
        '
        Me.TankWaterGridBindingSource.DataSource = GetType(TurtleGeek.Roster.TankWaters)
        '
        'lblDescription
        '
        Me.lblDescription.ForeColor = System.Drawing.Color.Green
        Me.lblDescription.Location = New System.Drawing.Point(1, 0)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(512, 24)
        Me.lblDescription.TabIndex = 1
        Me.lblDescription.Text = "Measurements must be taken each week for every turtle holding tank with a separat" & _
            "e water supply."
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tpgTemperatureGraph
        '
        Me.tpgTemperatureGraph.Controls.Add(Me.lnkCopyToClipboardTemperatureGraph)
        Me.tpgTemperatureGraph.Controls.Add(Me.lnkPrintTemperatureGraph)
        Me.tpgTemperatureGraph.Controls.Add(Me.graphTemperature)
        Me.tpgTemperatureGraph.Location = New System.Drawing.Point(4, 22)
        Me.tpgTemperatureGraph.Name = "tpgTemperatureGraph"
        Me.tpgTemperatureGraph.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgTemperatureGraph.Size = New System.Drawing.Size(501, 258)
        Me.tpgTemperatureGraph.TabIndex = 1
        Me.tpgTemperatureGraph.Text = "Temperature Graph"
        Me.tpgTemperatureGraph.UseVisualStyleBackColor = True
        '
        'lnkCopyToClipboardTemperatureGraph
        '
        Me.lnkCopyToClipboardTemperatureGraph.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkCopyToClipboardTemperatureGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkCopyToClipboardTemperatureGraph.AutoSize = True
        Me.lnkCopyToClipboardTemperatureGraph.Location = New System.Drawing.Point(380, 242)
        Me.lnkCopyToClipboardTemperatureGraph.Name = "lnkCopyToClipboardTemperatureGraph"
        Me.lnkCopyToClipboardTemperatureGraph.Size = New System.Drawing.Size(88, 13)
        Me.lnkCopyToClipboardTemperatureGraph.TabIndex = 1
        Me.lnkCopyToClipboardTemperatureGraph.TabStop = True
        Me.lnkCopyToClipboardTemperatureGraph.Text = "copy to clipboard"
        Me.lnkCopyToClipboardTemperatureGraph.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkPrintTemperatureGraph
        '
        Me.lnkPrintTemperatureGraph.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkPrintTemperatureGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkPrintTemperatureGraph.AutoSize = True
        Me.lnkPrintTemperatureGraph.Location = New System.Drawing.Point(474, 242)
        Me.lnkPrintTemperatureGraph.Name = "lnkPrintTemperatureGraph"
        Me.lnkPrintTemperatureGraph.Size = New System.Drawing.Size(27, 13)
        Me.lnkPrintTemperatureGraph.TabIndex = 2
        Me.lnkPrintTemperatureGraph.TabStop = True
        Me.lnkPrintTemperatureGraph.Text = "print"
        Me.lnkPrintTemperatureGraph.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'graphTemperature
        '
        Me.graphTemperature.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.graphTemperature.AutoScaleAutoGeneratedAxes = False
        Me.graphTemperature.AutoScaleTitle = False
        Me.graphTemperature.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.graphTemperature.DateTimeToolTip = False
        Me.graphTemperature.Legend = Nothing
        Me.graphTemperature.LegendZOrder = -1
        Me.graphTemperature.Location = New System.Drawing.Point(0, 3)
        Me.graphTemperature.Name = "graphTemperature"
        Me.graphTemperature.RightMenu = Nothing
        Me.graphTemperature.ShowCoordinates = False
        Me.graphTemperature.Size = New System.Drawing.Size(501, 252)
        Me.graphTemperature.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        Me.graphTemperature.TabIndex = 0
        Me.graphTemperature.Text = "PlotSurface2D1"
        Me.graphTemperature.Title = ""
        Me.graphTemperature.TitleFont = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.graphTemperature.XAxis1 = Nothing
        Me.graphTemperature.XAxis2 = Nothing
        Me.graphTemperature.YAxis1 = Nothing
        Me.graphTemperature.YAxis2 = Nothing
        '
        'tpgSalinityGraph
        '
        Me.tpgSalinityGraph.Controls.Add(Me.lnkCopyToClipboardSalinityGraph)
        Me.tpgSalinityGraph.Controls.Add(Me.lnkPrintSalinityGraph)
        Me.tpgSalinityGraph.Controls.Add(Me.graphSalinity)
        Me.tpgSalinityGraph.Location = New System.Drawing.Point(4, 22)
        Me.tpgSalinityGraph.Name = "tpgSalinityGraph"
        Me.tpgSalinityGraph.Size = New System.Drawing.Size(501, 258)
        Me.tpgSalinityGraph.TabIndex = 2
        Me.tpgSalinityGraph.Text = "Salinity Graph"
        Me.tpgSalinityGraph.UseVisualStyleBackColor = True
        '
        'lnkCopyToClipboardSalinityGraph
        '
        Me.lnkCopyToClipboardSalinityGraph.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkCopyToClipboardSalinityGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkCopyToClipboardSalinityGraph.AutoSize = True
        Me.lnkCopyToClipboardSalinityGraph.Location = New System.Drawing.Point(380, 242)
        Me.lnkCopyToClipboardSalinityGraph.Name = "lnkCopyToClipboardSalinityGraph"
        Me.lnkCopyToClipboardSalinityGraph.Size = New System.Drawing.Size(88, 13)
        Me.lnkCopyToClipboardSalinityGraph.TabIndex = 1
        Me.lnkCopyToClipboardSalinityGraph.TabStop = True
        Me.lnkCopyToClipboardSalinityGraph.Text = "copy to clipboard"
        Me.lnkCopyToClipboardSalinityGraph.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkPrintSalinityGraph
        '
        Me.lnkPrintSalinityGraph.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkPrintSalinityGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkPrintSalinityGraph.AutoSize = True
        Me.lnkPrintSalinityGraph.Location = New System.Drawing.Point(474, 242)
        Me.lnkPrintSalinityGraph.Name = "lnkPrintSalinityGraph"
        Me.lnkPrintSalinityGraph.Size = New System.Drawing.Size(27, 13)
        Me.lnkPrintSalinityGraph.TabIndex = 2
        Me.lnkPrintSalinityGraph.TabStop = True
        Me.lnkPrintSalinityGraph.Text = "print"
        Me.lnkPrintSalinityGraph.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'graphSalinity
        '
        Me.graphSalinity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.graphSalinity.AutoScaleAutoGeneratedAxes = False
        Me.graphSalinity.AutoScaleTitle = False
        Me.graphSalinity.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.graphSalinity.DateTimeToolTip = False
        Me.graphSalinity.Legend = Nothing
        Me.graphSalinity.LegendZOrder = -1
        Me.graphSalinity.Location = New System.Drawing.Point(0, 3)
        Me.graphSalinity.Name = "graphSalinity"
        Me.graphSalinity.RightMenu = Nothing
        Me.graphSalinity.ShowCoordinates = False
        Me.graphSalinity.Size = New System.Drawing.Size(501, 252)
        Me.graphSalinity.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        Me.graphSalinity.TabIndex = 2
        Me.graphSalinity.Text = "PlotSurface2D1"
        Me.graphSalinity.Title = ""
        Me.graphSalinity.TitleFont = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.graphSalinity.XAxis1 = Nothing
        Me.graphSalinity.XAxis2 = Nothing
        Me.graphSalinity.YAxis1 = Nothing
        Me.graphSalinity.YAxis2 = Nothing
        '
        'tpgPhGraph
        '
        Me.tpgPhGraph.Controls.Add(Me.lnkCopyToClipboardPhGraph)
        Me.tpgPhGraph.Controls.Add(Me.lnkPrintPhGraph)
        Me.tpgPhGraph.Controls.Add(Me.graphPh)
        Me.tpgPhGraph.Location = New System.Drawing.Point(4, 22)
        Me.tpgPhGraph.Name = "tpgPhGraph"
        Me.tpgPhGraph.Size = New System.Drawing.Size(501, 258)
        Me.tpgPhGraph.TabIndex = 3
        Me.tpgPhGraph.Text = "Ph Graph"
        Me.tpgPhGraph.UseVisualStyleBackColor = True
        '
        'lnkCopyToClipboardPhGraph
        '
        Me.lnkCopyToClipboardPhGraph.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkCopyToClipboardPhGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkCopyToClipboardPhGraph.AutoSize = True
        Me.lnkCopyToClipboardPhGraph.Location = New System.Drawing.Point(380, 242)
        Me.lnkCopyToClipboardPhGraph.Name = "lnkCopyToClipboardPhGraph"
        Me.lnkCopyToClipboardPhGraph.Size = New System.Drawing.Size(88, 13)
        Me.lnkCopyToClipboardPhGraph.TabIndex = 1
        Me.lnkCopyToClipboardPhGraph.TabStop = True
        Me.lnkCopyToClipboardPhGraph.Text = "copy to clipboard"
        Me.lnkCopyToClipboardPhGraph.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkPrintPhGraph
        '
        Me.lnkPrintPhGraph.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkPrintPhGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkPrintPhGraph.AutoSize = True
        Me.lnkPrintPhGraph.Location = New System.Drawing.Point(474, 242)
        Me.lnkPrintPhGraph.Name = "lnkPrintPhGraph"
        Me.lnkPrintPhGraph.Size = New System.Drawing.Size(27, 13)
        Me.lnkPrintPhGraph.TabIndex = 2
        Me.lnkPrintPhGraph.TabStop = True
        Me.lnkPrintPhGraph.Text = "print"
        Me.lnkPrintPhGraph.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'graphPh
        '
        Me.graphPh.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.graphPh.AutoScaleAutoGeneratedAxes = False
        Me.graphPh.AutoScaleTitle = False
        Me.graphPh.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.graphPh.DateTimeToolTip = False
        Me.graphPh.Legend = Nothing
        Me.graphPh.LegendZOrder = -1
        Me.graphPh.Location = New System.Drawing.Point(0, 3)
        Me.graphPh.Name = "graphPh"
        Me.graphPh.RightMenu = Nothing
        Me.graphPh.ShowCoordinates = False
        Me.graphPh.Size = New System.Drawing.Size(501, 252)
        Me.graphPh.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        Me.graphPh.TabIndex = 4
        Me.graphPh.Text = "PlotSurface2D1"
        Me.graphPh.Title = ""
        Me.graphPh.TitleFont = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.graphPh.XAxis1 = Nothing
        Me.graphPh.XAxis2 = Nothing
        Me.graphPh.YAxis1 = Nothing
        Me.graphPh.YAxis2 = Nothing
        '
        'btnAddWater
        '
        Me.btnAddWater.BackColor = System.Drawing.Color.MintCream
        Me.btnAddWater.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddWater.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddWater.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddWater.ForeColor = System.Drawing.Color.Blue
        Me.btnAddWater.Location = New System.Drawing.Point(164, 36)
        Me.btnAddWater.Name = "btnAddWater"
        Me.btnAddWater.Size = New System.Drawing.Size(39, 20)
        Me.btnAddWater.TabIndex = 2
        Me.btnAddWater.Text = "add"
        Me.btnAddWater.UseVisualStyleBackColor = False
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(8, 376)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 24)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.Text = "Help"
        '
        'erpErrorProvider
        '
        Me.erpErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.erpErrorProvider.ContainerControl = Me
        '
        'TankInformationDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(546, 415)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnAddWater)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtTankName)
        Me.Controls.Add(Me.lblTankName)
        Me.Controls.Add(Me.grpWaters)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TankInformationDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Holding Tank Information"
        Me.grpWaters.ResumeLayout(False)
        Me.tabTankInformationTab.ResumeLayout(False)
        Me.tpgMeasurements.ResumeLayout(False)
        CType(Me.grdTankWaterGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TankWaterGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgTemperatureGraph.ResumeLayout(False)
        Me.tpgTemperatureGraph.PerformLayout()
        Me.tpgSalinityGraph.ResumeLayout(False)
        Me.tpgSalinityGraph.PerformLayout()
        Me.tpgPhGraph.ResumeLayout(False)
        Me.tpgPhGraph.PerformLayout()
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mbIsOkayButtonClicked As Boolean = False
    Private moTank As Tank
    Private msSortedColumnPropertyName As String = "DateMeasured"
    Private moListSortDirection As System.ComponentModel.ListSortDirection = System.ComponentModel.ListSortDirection.Descending

    Public Sub New(ByVal oTank As Tank)

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None

        moTank = oTank

    End Sub

    Private Sub frmTankInformationDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            '*** ASSERTION ***
            If moTank Is Nothing Then
                Throw New ApplicationException("Tank object must be set before opening this screen.")
            End If
            '*** ASSERTION ***

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- load the form fields with the data values
            '----------------------------------------------------------------
            moTank.BeginEdit()

            Me.txtTankName.Text = moTank.TankName

            '----------------------------------------------------------------
            '-- populate the TANK WATER grid
            '----------------------------------------------------------------
            LoadTankWaterGridData()

            '----------------------------------------------------------------
            '-- display required field indicators 
            '----------------------------------------------------------------
            Me.DisplayBrokenRules(False)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub frmTankInformationDlg_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim bCancelFormClosingEvent As Boolean = False

        '------------------------------------------------------------ 
        '-- transfer the form data values into the business object 
        '------------------------------------------------------------ 
        Me.CopyFormValuesToBusinessObject()

        '------------------------------------------------------------ 
        '-- form being closed via OK button; 
        '-- validate data values, commit to the database, etc. 
        '------------------------------------------------------------ 
        If mbIsOkayButtonClicked Then
            bCancelFormClosingEvent = (Not DoSaveLogic())
        Else
            '------------------------------------------------------------ 
            '-- form being closed via Cancel button or Close [X] button; 
            '-- if object is dirty, prompt for save, etc. 
            '------------------------------------------------------------ 
            bCancelFormClosingEvent = (Not DoCancelLogic())
        End If

        '------------------------------------------------------------ 
        '-- CANCEL the form closing event and return the user to the form 
        '------------------------------------------------------------ 
        If bCancelFormClosingEvent Then
            e.Cancel = True
            mbIsOkayButtonClicked = False
        Else
            '------------------------------------------------------------ 
            '-- PROCEED with the form closing event 
            '------------------------------------------------------------ 
            e.Cancel = False
        End If

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            mbIsOkayButtonClicked = True
            Me.Close()
        Catch ex As Exception
            ErrorMessageBox.Show(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            mbIsOkayButtonClicked = False
            Me.Close()
        Catch ex As Exception
            ErrorMessageBox.Show(ex)
        End Try
    End Sub

    Private Function DoCancelLogic() As Boolean

        Dim oDialogResult As DialogResult

        Try
            '------------------------------------------------------------ 
            '-- if the object has changed 
            '-- but the user has clicked the Cancel button... 
            '------------------------------------------------------------ 
            If moTank.IsDirty Then

                '------------------------------------------------------------ 
                '-- prompt the user to save the changes 
                '------------------------------------------------------------ 
                oDialogResult = MessageBox.Show("Save changes?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                Select Case oDialogResult

                    Case DialogResult.Yes

                        '------------------------------------------------------------ 
                        '-- if the user wishes to save the changes, 
                        '-- attempt to validate and save the object 
                        '------------------------------------------------------------ 

                        Return DoSaveLogic()

                    Case DialogResult.No

                        '------------------------------------------------------------ 
                        '-- if the user does NOT wish to save the changes, 
                        '-- do nothing; fall through, cancel changes, and close the form 
                        '------------------------------------------------------------ 

                        Exit Select

                    Case DialogResult.Cancel

                        '------------------------------------------------------------ 
                        '-- if the user cancels the confirmation, 
                        '-- do NOT save the changes and return the user to the form 
                        '------------------------------------------------------------ 

                        '------------------------------------------------------------ 
                        '-- DO cancel the form closing event 
                        '------------------------------------------------------------ 
                        Return False

                End Select

            End If

            '------------------------------------------------------------ 
            '-- if the object changed but the user does NOT want to save the changes 
            '-- OR the object has NOT changed, 
            '-- then cancel the edit and continue closing the form 
            '------------------------------------------------------------ 
            moTank.CancelEdit()
            Me.DialogResult = DialogResult.Cancel

            '------------------------------------------------------------ 
            '-- do NOT cancel the form closing event 
            '------------------------------------------------------------ 
            Return True

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

            '------------------------------------------------------------ 
            '-- DO cancel the form closing event 
            '------------------------------------------------------------ 
            Return False

        End Try

    End Function

    Private Function DoSaveLogic() As Boolean
        '------------------------------------------------------------ 
        '-- validate data and save object; 
        '-- if the data is NOT valid, do NOT leave the form 
        '------------------------------------------------------------ 
        Dim oTempTank As Tank

        Try
            '------------------------------------------------------------ 
            '-- if the object has changed... 
            '------------------------------------------------------------ 
            If moTank.IsDirty Then

                '------------------------------------------------------------ 
                '-- if all of the validation rules have passed... 
                '------------------------------------------------------------ 
                If moTank.IsValid Then

                    '----------------------------------------------------------------
                    '-- commit edits in memory
                    '----------------------------------------------------------------
                    moTank.ApplyEdit()

                    '----------------------------------------------------------------
                    '-- clone and save the object (it is the CSLA way)
                    '----------------------------------------------------------------
                    oTempTank = moTank.Clone
                    moTank = oTempTank.Save

                Else

                    '------------------------------------------------------------ 
                    '-- else, display the list of broken rules, but do NOT close the form 
                    '------------------------------------------------------------ 
                    DisplayBrokenRules(True)

                    '------------------------------------------------------------ 
                    '-- DO cancel the form closing event 
                    '------------------------------------------------------------ 
                    Return False

                End If

            End If

            '------------------------------------------------------------ 
            '-- if the object has NOT changed 
            '-- OR if the data is valid and the object was saved, 
            '-- then continue closing the form 
            '------------------------------------------------------------ 
            Me.DialogResult = DialogResult.OK

            '------------------------------------------------------------ 
            '-- do NOT cancel the form closing event 
            '------------------------------------------------------------ 
            Return True

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

            '------------------------------------------------------------ 
            '-- DO cancel the form closing event 
            '------------------------------------------------------------ 
            Return False

        End Try

    End Function

    Private Sub DisplayBrokenRules(Optional ByVal bShowMessageBox As Boolean = False)

        Try

            'Dim i As Integer

            ''----------------------------------------------------------------
            ''-- clear all ErrorProvider messages
            ''----------------------------------------------------------------
            'erpErrorProvider.SetError(Me.txtOrganizationName, "")
            'erpErrorProvider.SetError(Me.txtPermitNumber, "")

            '----------------------------------------------------------------
            '-- indicate any broken rules to the user
            '----------------------------------------------------------------
            If (bShowMessageBox) Then
                MessageBox.Show(" *** The following data validation issue(s) must be resolved before this package can be saved: *** " & ControlChars.CrLf & ControlChars.CrLf & moTank.GetBrokenRulesString, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            'For i = 0 To moOrganization.BrokenRulesCollection.Count() - 1
            '    Select Case moOrganization.BrokenRulesCollection(i).Property
            '        Case "OrganizationName"
            '            erpErrorProvider.SetError(Me.txtOrganizationName, moOrganization.BrokenRulesCollection(i).Description)
            '        Case "PermitNumber"
            '            erpErrorProvider.SetError(Me.txtPermitNumber, moOrganization.BrokenRulesCollection(i).Description)
            '    End Select
            'Next

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub CopyFormValuesToBusinessObject()

        '------------------------------------------------------------ 
        '-- copy the data from the form fields into the business object 
        '------------------------------------------------------------ 
        moTank.TankName = txtTankName.Text.Trim

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "HoldingTankInformationScreen.htm")
    End Sub

#Region " Tank Waters "

    Private Sub LoadTankWaterGridData()

        Dim oSortedBindingList As Csla.SortedBindingList(Of TankWater)

        Try
            If moTank.TankWaters Is Nothing Then Exit Sub

            Cursor.Current = Cursors.WaitCursor

            '****************************************************************
            '-- load the GRID
            '****************************************************************
            oSortedBindingList = New Csla.SortedBindingList(Of TankWater)(moTank.TankWaters)

            If String.IsNullOrEmpty(msSortedColumnPropertyName) Then
                msSortedColumnPropertyName = "DateMeasured"
            End If

            oSortedBindingList.ApplySort(msSortedColumnPropertyName, moListSortDirection)

            Me.grdTankWaterGrid.DataSource = oSortedBindingList


            '****************************************************************
            '-- load the GRAPHS
            '****************************************************************
            Dim i As Integer
            Dim oSortedBindingListForGraph As Csla.SortedBindingList(Of TankWater)

            Dim oTemperatureLinePlot As LinePlot = New LinePlot
            Dim oTemperatureXData As ArrayList = New ArrayList
            Dim oTemperatureYData As ArrayList = New ArrayList

            Dim oSalinityLinePlot As LinePlot = New LinePlot
            Dim oSalinityXData As ArrayList = New ArrayList
            Dim oSalinityYData As ArrayList = New ArrayList

            Dim oPhLinePlot As LinePlot = New LinePlot
            Dim oPhXData As ArrayList = New ArrayList
            Dim oPhYData As ArrayList = New ArrayList

            oSortedBindingListForGraph = New Csla.SortedBindingList(Of TankWater)(moTank.TankWaters)
            oSortedBindingListForGraph.ApplySort("DateMeasured", System.ComponentModel.ListSortDirection.Ascending)

            '----------------------------------------------------------------
            '-- TEMPERATURE GRAPH
            '----------------------------------------------------------------
            oTemperatureXData.Clear()
            oTemperatureYData.Clear()

            graphTemperature.Clear()
            graphTemperature.Title = "Temperature Graph"
            graphTemperature.BackColor = Color.Empty

            For i = 0 To oSortedBindingListForGraph.Count - 1
                oTemperatureXData.Add(oSortedBindingListForGraph(i).DateMeasured)
                oTemperatureYData.Add(oSortedBindingListForGraph(i).Temperature)
            Next

            oTemperatureLinePlot.AbscissaData = oTemperatureXData
            oTemperatureLinePlot.DataSource = oTemperatureYData
            oTemperatureLinePlot.Color = Color.Blue
            graphTemperature.Add(oTemperatureLinePlot)

            graphTemperature.XAxis1.Label = "Date"
            graphTemperature.YAxis1.Label = "Temperature"

            graphTemperature.Refresh()

            '----------------------------------------------------------------
            '-- SALINITY GRAPH
            '----------------------------------------------------------------
            oSalinityXData.Clear()
            oSalinityYData.Clear()

            graphSalinity.Clear()
            graphSalinity.Title = "Salinity Graph"
            graphSalinity.BackColor = Color.Empty

            For i = 0 To oSortedBindingListForGraph.Count - 1
                oSalinityXData.Add(oSortedBindingListForGraph(i).DateMeasured)
                oSalinityYData.Add(oSortedBindingListForGraph(i).Salinity)
            Next

            oSalinityLinePlot.AbscissaData = oSalinityXData
            oSalinityLinePlot.DataSource = oSalinityYData
            oSalinityLinePlot.Color = Color.Red
            graphSalinity.Add(oSalinityLinePlot)

            graphSalinity.XAxis1.Label = "Date"
            graphSalinity.YAxis1.Label = "Salinity (in ppt)"

            graphSalinity.Refresh()

            '----------------------------------------------------------------
            '-- PH GRAPH
            '----------------------------------------------------------------
            oPhXData.Clear()
            oPhYData.Clear()

            graphPh.Clear()
            graphPh.Title = "Ph Graph"
            graphPh.BackColor = Color.Empty

            For i = 0 To oSortedBindingListForGraph.Count - 1
                oPhXData.Add(oSortedBindingListForGraph(i).DateMeasured)
                oPhYData.Add(oSortedBindingListForGraph(i).Ph)
            Next

            oPhLinePlot.AbscissaData = oPhXData
            oPhLinePlot.DataSource = oPhYData
            oPhLinePlot.Color = Color.Green
            graphPh.Add(oPhLinePlot)

            graphPh.XAxis1.Label = "Date"
            graphPh.YAxis1.Label = "Ph"

            graphPh.Refresh()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnAddWater_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWater.Click

        CreateTankWater()

    End Sub

    Private Sub CreateTankWater()

        Dim frm As TankWaterInformationDlg = Nothing

        Try
            '----------------------------------------------------------------
            '-- instantiate and display the edit form
            '----------------------------------------------------------------
            frm = New TankWaterInformationDlg(TankWater.NewTankWater())
            frm.ShowDialog(Me)

            '----------------------------------------------------------------
            '-- if the user chose to save the child object, 
            '-- then add the child object to the parent object's collection
            '----------------------------------------------------------------
            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                '-- this updates the parent object (which will handle the update of the child)
                moTank.TankWaters.Add(frm.TankWater)

                '-- this updates the grid
                LoadTankWaterGridData()

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            If Not (frm Is Nothing) Then
                frm.Dispose()
                frm = Nothing
            End If

        End Try

    End Sub

    Private Sub EditTankWater()

        Dim sTankWaterID As String = String.Empty
        Dim frm As TankWaterInformationDlg = Nothing

        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdTankWaterGrid.SelectedRows.Count > 0) Then

                sTankWaterID = Convert.ToString(grdTankWaterGrid.SelectedRows(0).Cells(Me.colWaterTankWaterIDDataGridViewTextBoxColumn.Name).Value)

                '----------------------------------------------------------------
                '-- instantiate and display the edit form
                '----------------------------------------------------------------
                frm = New TankWaterInformationDlg(moTank.TankWaters.GetItem(sTankWaterID))

                frm.ShowDialog(Me)

                '-- if okay, save and continue
                If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                    LoadTankWaterGridData()

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            If Not (frm Is Nothing) Then
                frm.Dispose()
                frm = Nothing
            End If

        End Try

    End Sub

    Private Sub DeleteTankWater()

        Dim sTankWaterID As String = String.Empty

        Try
            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdTankWaterGrid.SelectedRows.Count > 0) Then

                sTankWaterID = Convert.ToString(grdTankWaterGrid.SelectedRows(0).Cells(Me.colWaterTankWaterIDDataGridViewTextBoxColumn.Name).Value)

                If (MessageBox.Show("Are you sure you want to delete the tank water information for '" & Convert.ToString(grdTankWaterGrid.SelectedRows(0).Cells(Me.colWaterDateMeasuredStringDataGridViewTextBoxColumn.Name).Value) & "' from this tank record?  This is a permanent action and CANNOT be undone.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then

                    '-- this updates the parent object (which will handle the deletion of the child)
                    moTank.TankWaters.Remove(sTankWaterID)

                    '-- this updates the grid
                    LoadTankWaterGridData()

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub grdTankWaterGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdTankWaterGrid.CellClick

        Try

            '----------------------------------------------------------------
            '-- handle the EDIT or DELETE command
            '----------------------------------------------------------------
            If (e.RowIndex > -1) Then
                If Me.grdTankWaterGrid.Columns(e.ColumnIndex).Name.Equals(Me.colWaterEditActionDataGridViewLinkColumn.Name) Then
                    EditTankWater()
                ElseIf Me.grdTankWaterGrid.Columns(e.ColumnIndex).Name.Equals(Me.colWaterDeleteActionDataGridViewLinkColumn.Name) Then
                    DeleteTankWater()
                End If
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub grdTankWaterGrid_ColumnDividerDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventArgs) Handles grdTankWaterGrid.ColumnDividerDoubleClick

        If ((Me.grdTankWaterGrid.Columns(e.ColumnIndex).Visible) AndAlso (Not Me.grdTankWaterGrid.Columns(e.ColumnIndex).Frozen)) Then
            Me.grdTankWaterGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Me.grdTankWaterGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        End If

    End Sub

    Private Sub grdTankWaterGrid_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdTankWaterGrid.ColumnHeaderMouseClick

        Try

            '----------------------------------------------------------------
            '-- if we are re-sorting the same column, save the order
            '----------------------------------------------------------------
            If (String.Compare(msSortedColumnPropertyName, Me.grdTankWaterGrid.Columns(e.ColumnIndex).DataPropertyName) = 0) Then
                If Me.grdTankWaterGrid.SortOrder = SortOrder.Ascending Then
                    moListSortDirection = System.ComponentModel.ListSortDirection.Ascending
                Else
                    moListSortDirection = System.ComponentModel.ListSortDirection.Descending
                End If
            Else
                '----------------------------------------------------------------
                '-- otherwise, we are sorting a new column; default to ASCENDING
                '----------------------------------------------------------------
                moListSortDirection = System.ComponentModel.ListSortDirection.Ascending
            End If

            msSortedColumnPropertyName = Me.grdTankWaterGrid.Columns(e.ColumnIndex).DataPropertyName

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub grdTankWaterGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTankWaterGrid.DoubleClick

        Dim oPoint As Point = Me.grdTankWaterGrid.PointToClient(Cursor.Position)
        Dim oHitTestInfo As DataGridView.HitTestInfo = Me.grdTankWaterGrid.HitTest(oPoint.X, oPoint.Y)

        '----------------------------------------------------------------
        '-- only edit the record if a data row cell was double-clicked
        '-- (we do this to allow a double click of the column separator to resize the column)
        '----------------------------------------------------------------
        If (oHitTestInfo.Type = DataGridViewHitTestType.Cell) Then
            EditTankWater()
        End If

    End Sub

#End Region

    Private Sub lnkPrintTemperatureGraph_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPrintTemperatureGraph.LinkClicked
        Me.graphTemperature.Print(True, Me.Icon, "ROSTER - Temperature Graph")
    End Sub

    Private Sub lnkCopyToClipboardTemperatureGraph_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCopyToClipboardTemperatureGraph.LinkClicked
        Me.graphTemperature.CopyToClipboard()
        MessageBox.Show("Graph copied to clipboard", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub lnkPrintSalinityGraph_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPrintSalinityGraph.LinkClicked
        Me.graphSalinity.Print(True, Me.Icon, "ROSTER - Salinity Graph")
    End Sub

    Private Sub lnkCopyToClipboardSalinityGraph_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCopyToClipboardSalinityGraph.LinkClicked
        Me.graphSalinity.CopyToClipboard()
        MessageBox.Show("Graph copied to clipboard", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub lnkPrintPhGraph_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPrintPhGraph.LinkClicked
        Me.graphPh.Print(True, Me.Icon, "ROSTER - Ph Graph")
    End Sub

    Private Sub lnkCopyToClipboardPhGraph_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCopyToClipboardPhGraph.LinkClicked
        Me.graphPh.CopyToClipboard()
        MessageBox.Show("Graph copied to clipboard", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

End Class
