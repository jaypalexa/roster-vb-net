Option Explicit On
Option Strict On

'----------------------------------------------------------------
'-- System.Data.SQLite is an ADO.NET implementation for the open-source SQLite database.
'-- http://sqlite.phxsoftware.com/
'----------------------------------------------------------------
'-- An application to view the SQLite database is available at http://sqliteadmin.orbmu2k.de/
'----------------------------------------------------------------

'----------------------------------------------------------------
'-- iTextSharp is a .NET implementation of the open-source iText PDF library.
'-- http://itextsharp.sourceforge.net/
'----------------------------------------------------------------
'Imports iTextSharp.text.pdf

Public Class MainForm
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
    Friend WithEvents mnuMainMenu As System.Windows.Forms.MainMenu
    Friend WithEvents mnuFile As System.Windows.Forms.MenuItem
    Friend WithEvents mnuFileExit As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelp As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpAbout As System.Windows.Forms.MenuItem
    Friend WithEvents sbrStatusBar As System.Windows.Forms.StatusBar
    Friend WithEvents grpOrganizationInformation As System.Windows.Forms.GroupBox
    Friend WithEvents lblPermitNumberLabel As System.Windows.Forms.Label
    Friend WithEvents lblOrganizationNameLabel As System.Windows.Forms.Label
    Friend WithEvents lblAddressLabel As System.Windows.Forms.Label
    Friend WithEvents lblPhoneLabel As System.Windows.Forms.Label
    Friend WithEvents lblEmailLabel As System.Windows.Forms.Label
    Friend WithEvents lblOrganizationName As System.Windows.Forms.Label
    Friend WithEvents lblAddress1 As System.Windows.Forms.Label
    Friend WithEvents lblAddress2 As System.Windows.Forms.Label
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents lblPermitNumber As System.Windows.Forms.Label
    Friend WithEvents lblCityLabel As System.Windows.Forms.Label
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents lblStateLabel As System.Windows.Forms.Label
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZipCode As System.Windows.Forms.Label
    Friend WithEvents lblZipCodeLabel As System.Windows.Forms.Label
    Friend WithEvents lblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents tipToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents erpErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents tabMainFormTab As System.Windows.Forms.TabControl
    Friend WithEvents tpgTurtles As System.Windows.Forms.TabPage
    Friend WithEvents tpgTanks As System.Windows.Forms.TabPage
    Friend WithEvents chkShowInactiveTurtles As System.Windows.Forms.CheckBox
    Friend WithEvents btnEditOrganization As System.Windows.Forms.Button
    Friend WithEvents btnAddTurtle As System.Windows.Forms.Button
    Friend WithEvents btnAddTank As System.Windows.Forms.Button
    Friend WithEvents mnuHelpViewErrorLog As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpClearErrorLog As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpSep99 As System.Windows.Forms.MenuItem
    Friend WithEvents hlpHelpProvider As System.Windows.Forms.HelpProvider
    Friend WithEvents mnuHelpSep01 As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpContents As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpIndex As System.Windows.Forms.MenuItem
    Friend WithEvents mnuHelpSearch As System.Windows.Forms.MenuItem
    Friend WithEvents picBannerBackground As System.Windows.Forms.PictureBox
    Friend WithEvents picBanner As System.Windows.Forms.PictureBox
    Friend WithEvents picLeftHeaderTurtle As System.Windows.Forms.PictureBox
    Friend WithEvents picRightHeaderTurtle As System.Windows.Forms.PictureBox
    Friend WithEvents cboFilterByList As System.Windows.Forms.ComboBox
    Friend WithEvents txtFilterByValue As System.Windows.Forms.TextBox
    Friend WithEvents btnRefresh As System.Windows.Forms.Button
    Friend WithEvents tabReportsTab As System.Windows.Forms.TabControl
    Friend WithEvents tpgFwcReportsAndForms As System.Windows.Forms.TabPage
    Friend WithEvents tpgOtherReports As System.Windows.Forms.TabPage
    Friend WithEvents btnTurtleTransferFormFill As System.Windows.Forms.Button
    Friend WithEvents btnTaggingDataFormFill As System.Windows.Forms.Button
    Friend WithEvents btnTagRequestFormFill As System.Windows.Forms.Button
    Friend WithEvents btnStrandingAndSalvageFormFill As System.Windows.Forms.Button
    Friend WithEvents lblTurtleTransferForm As System.Windows.Forms.Label
    Friend WithEvents lblTaggingDataForm As System.Windows.Forms.Label
    Friend WithEvents lblTagRequestForm As System.Windows.Forms.Label
    Friend WithEvents lblStrandingAndSalvageForm As System.Windows.Forms.Label
    Friend WithEvents btnPublicTurtleWatchScheduleFormFill As System.Windows.Forms.Button
    Friend WithEvents lblPublicTurtleWatchScheduleForm As System.Windows.Forms.Label
    Friend WithEvents lblBeachRestorationProjectMonitoringTable As System.Windows.Forms.Label
    Friend WithEvents lblLine01 As System.Windows.Forms.Label
    Friend WithEvents btnPapillomaFormFill As System.Windows.Forms.Button
    Friend WithEvents lblPapillomaForm As System.Windows.Forms.Label
    Friend WithEvents btnNighttimePublicHatchlingReleaseFormFill As System.Windows.Forms.Button
    Friend WithEvents lblNighttimePublicHatchlingReleaseForm As System.Windows.Forms.Label
    Friend WithEvents btnNecropsyFormFill As System.Windows.Forms.Button
    Friend WithEvents lblNecropsyForm As System.Windows.Forms.Label
    Friend WithEvents btnEducationalPresentationsUsingLiveTurtlesFormFill As System.Windows.Forms.Button
    Friend WithEvents lblEducationalPresentationsUsingLiveTurtlesForm As System.Windows.Forms.Label
    Friend WithEvents btnDisorientationIncidentFormFill As System.Windows.Forms.Button
    Friend WithEvents lblDisorientationIncidentForm As System.Windows.Forms.Label
    Friend WithEvents btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill As System.Windows.Forms.Button
    Friend WithEvents btnMarineTurtleHoldingFacilityQuarterlyReportFill As System.Windows.Forms.Button
    Friend WithEvents btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank As System.Windows.Forms.Button
    Friend WithEvents btnTurtleTransferFormBlank As System.Windows.Forms.Button
    Friend WithEvents btnTaggingDataFormBlank As System.Windows.Forms.Button
    Friend WithEvents btnTagRequestFormBlank As System.Windows.Forms.Button
    Friend WithEvents btnStrandingAndSalvageFormBlank As System.Windows.Forms.Button
    Friend WithEvents btnPublicTurtleWatchScheduleFormBlank As System.Windows.Forms.Button
    Friend WithEvents btnPapillomaFormBlank As System.Windows.Forms.Button
    Friend WithEvents btnNighttimePublicHatchlingReleaseFormBlank As System.Windows.Forms.Button
    Friend WithEvents btnNecropsyFormBlank As System.Windows.Forms.Button
    Friend WithEvents btnDisorientationIncidentFormBlank As System.Windows.Forms.Button
    Friend WithEvents btnEducationalPresentationsUsingLiveTurtlesFormBlank As System.Windows.Forms.Button
    Friend WithEvents btnBeachRestorationProjectMonitoringTableBlank As System.Windows.Forms.Button
    Friend WithEvents btnMarineTurtleHoldingFacilityQuarterlyReportBlank As System.Windows.Forms.Button
    Friend WithEvents lblMarineTurtleCaptiveFacilityQuarterlyReportForHatchlings As System.Windows.Forms.Label
    Friend WithEvents lblMarineTurtleHoldingFacilityQuarterlyReport As System.Windows.Forms.Label
    Friend WithEvents lnkTurtleInjuryReport As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkTurtleTagReport As System.Windows.Forms.LinkLabel
    Friend WithEvents lblContactName As System.Windows.Forms.Label
    Friend WithEvents lblContactNameLabel As System.Windows.Forms.Label
    Friend WithEvents grdTurtleGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TurtleGridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grdTankGrid As System.Windows.Forms.DataGridView
    Friend WithEvents TankGridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colTankEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTankDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTankTankIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTankTankNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpgHatchlingsEvents As System.Windows.Forms.TabPage
    Friend WithEvents btnAddHatchlingsAcquiredEvent As System.Windows.Forms.Button
    Friend WithEvents grdHatchlingsEventGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddHatchlingsReleasedEvent As System.Windows.Forms.Button
    Friend WithEvents btnAddHatchlingsDiedEvent As System.Windows.Forms.Button
    Friend WithEvents HatchlingsEventGridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents tabOrganizationInformationTab As System.Windows.Forms.TabControl
    Friend WithEvents tpgGeneralInformation As System.Windows.Forms.TabPage
    Friend WithEvents tpgHatchlingWashbackStartingBalances As System.Windows.Forms.TabPage
    Friend WithEvents lblFaxLabel As System.Windows.Forms.Label
    Friend WithEvents lblHatchlingBalanceAsOfDateLabel As System.Windows.Forms.Label
    Friend WithEvents lblCcHatchlingStartingBalanceLabel As System.Windows.Forms.Label
    Friend WithEvents lblCmHatchlingStartingBalanceLabel As System.Windows.Forms.Label
    Friend WithEvents lblDcHatchlingStartingBalanceLabel As System.Windows.Forms.Label
    Friend WithEvents lblOtherHatchlingStartingBalanceLabel As System.Windows.Forms.Label
    Friend WithEvents lblHatchlingBalanceAsOfDate As System.Windows.Forms.Label
    Friend WithEvents lblUnknownHatchlingStartingBalanceLabel As System.Windows.Forms.Label
    Friend WithEvents lblUnknownHatchlingStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblOtherHatchlingStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblDcHatchlingStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblCmHatchlingStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblCcHatchlingStartingBalance As System.Windows.Forms.Label
    Friend WithEvents mnuAdminLatitudeLongitudeHelper As System.Windows.Forms.MenuItem
    Friend WithEvents btnPublicTurtleWatchSummaryFormFill As System.Windows.Forms.Button
    Friend WithEvents lblPublicTurtleWatchSummaryForm As System.Windows.Forms.Label
    Friend WithEvents btnPublicTurtleWatchSummaryFormBlank As System.Windows.Forms.Button
    Friend WithEvents tpgWashbacksEvents As System.Windows.Forms.TabPage
    Friend WithEvents btnAddWashbacksReleasedEvent As System.Windows.Forms.Button
    Friend WithEvents btnAddWashbacksDiedEvent As System.Windows.Forms.Button
    Friend WithEvents grdWashbacksEventGrid As System.Windows.Forms.DataGridView
    Friend WithEvents btnAddWashbacksAcquiredEvent As System.Windows.Forms.Button
    Friend WithEvents btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill As System.Windows.Forms.Button
    Friend WithEvents btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank As System.Windows.Forms.Button
    Friend WithEvents lblMarineTurtleCaptiveFacilityQuarterlyReportForWashbacks As System.Windows.Forms.Label
    Friend WithEvents WashbacksEventGridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblObstructedNestingAttemptFormDirections As System.Windows.Forms.Label
    Friend WithEvents btnObstructedNestingAttemptFormDirectionsBlank As System.Windows.Forms.Button
    Friend WithEvents btnObstructedNestingAttemptFormFill As System.Windows.Forms.Button
    Friend WithEvents lblObstructedNestingAttemptForm As System.Windows.Forms.Label
    Friend WithEvents btnObstructedNestingAttemptFormBlank As System.Windows.Forms.Button
    Friend WithEvents lblDisorientationIncidentFormDirections As System.Windows.Forms.Label
    Friend WithEvents btnDisorientationIncidentFormDirectionsBlank As System.Windows.Forms.Button
    Friend WithEvents btnAddHatchlingsDoaEvent As System.Windows.Forms.Button
    Friend WithEvents btnAddWashbacksDoaEvent As System.Windows.Forms.Button
    Friend WithEvents lnkHatchlingsWashbacksCountyReport As System.Windows.Forms.LinkLabel
    Friend WithEvents colHatchlingsEventEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colHatchlingsEventDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colHatchlingsEventEventIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHatchlingsEventSpeciesDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHatchlingsEventEventTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHatchlingsEventEventDateBindableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHatchlingsEventEventCountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colHatchlingsEventCountyNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblWashbackStartingBalances As System.Windows.Forms.Label
    Friend WithEvents lblHatchlingStartingBalances As System.Windows.Forms.Label
    Friend WithEvents lblUnknownWashbackStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblOtherWashbackStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblDcWashbackStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblCmWashbackStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblCcWashbackStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblWashbackBalanceAsOfDate As System.Windows.Forms.Label
    Friend WithEvents mnuAdmin As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdminCounties As System.Windows.Forms.MenuItem
    Friend WithEvents mnuAdminSeparator01 As System.Windows.Forms.MenuItem
    Friend WithEvents colWashbacksEventEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colWashbacksEventDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colWashbacksEventEventIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWashbacksEventSpeciesDescriptionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWashbacksEventEventTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWashbacksEventEventDateBindableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWashbacksEventEventCountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWashbacksEventCountyNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colWashbacksEventUnder5CmClslDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTurtleDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTurtleTurtleIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleTurtleNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleSidNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleSpeciesDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleDateAcquiredBindableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleAcquiredFromDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleAcquiredCountyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleTurtleSizeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colDateRelinquishedBindableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleRelinquishedToDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleTagNumberListStringDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents picMoreInfoFiltering As System.Windows.Forms.PictureBox
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.mnuMainMenu = New System.Windows.Forms.MainMenu(Me.components)
        Me.mnuFile = New System.Windows.Forms.MenuItem
        Me.mnuFileExit = New System.Windows.Forms.MenuItem
        Me.mnuAdmin = New System.Windows.Forms.MenuItem
        Me.mnuAdminCounties = New System.Windows.Forms.MenuItem
        Me.mnuAdminSeparator01 = New System.Windows.Forms.MenuItem
        Me.mnuAdminLatitudeLongitudeHelper = New System.Windows.Forms.MenuItem
        Me.mnuHelp = New System.Windows.Forms.MenuItem
        Me.mnuHelpContents = New System.Windows.Forms.MenuItem
        Me.mnuHelpIndex = New System.Windows.Forms.MenuItem
        Me.mnuHelpSearch = New System.Windows.Forms.MenuItem
        Me.mnuHelpSep01 = New System.Windows.Forms.MenuItem
        Me.mnuHelpViewErrorLog = New System.Windows.Forms.MenuItem
        Me.mnuHelpClearErrorLog = New System.Windows.Forms.MenuItem
        Me.mnuHelpSep99 = New System.Windows.Forms.MenuItem
        Me.mnuHelpAbout = New System.Windows.Forms.MenuItem
        Me.sbrStatusBar = New System.Windows.Forms.StatusBar
        Me.grpOrganizationInformation = New System.Windows.Forms.GroupBox
        Me.tabOrganizationInformationTab = New System.Windows.Forms.TabControl
        Me.tpgGeneralInformation = New System.Windows.Forms.TabPage
        Me.lblFaxLabel = New System.Windows.Forms.Label
        Me.lblOrganizationNameLabel = New System.Windows.Forms.Label
        Me.lblOrganizationName = New System.Windows.Forms.Label
        Me.lblAddressLabel = New System.Windows.Forms.Label
        Me.lblAddress1 = New System.Windows.Forms.Label
        Me.lblAddress2 = New System.Windows.Forms.Label
        Me.lblCityLabel = New System.Windows.Forms.Label
        Me.lblCity = New System.Windows.Forms.Label
        Me.lblStateLabel = New System.Windows.Forms.Label
        Me.lblState = New System.Windows.Forms.Label
        Me.lblZipCodeLabel = New System.Windows.Forms.Label
        Me.lblZipCode = New System.Windows.Forms.Label
        Me.lblPhoneLabel = New System.Windows.Forms.Label
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblFax = New System.Windows.Forms.Label
        Me.lblEmailLabel = New System.Windows.Forms.Label
        Me.lblEmailAddress = New System.Windows.Forms.Label
        Me.lblContactNameLabel = New System.Windows.Forms.Label
        Me.lblContactName = New System.Windows.Forms.Label
        Me.lblPermitNumberLabel = New System.Windows.Forms.Label
        Me.lblPermitNumber = New System.Windows.Forms.Label
        Me.tpgHatchlingWashbackStartingBalances = New System.Windows.Forms.TabPage
        Me.lblWashbackStartingBalances = New System.Windows.Forms.Label
        Me.lblHatchlingStartingBalances = New System.Windows.Forms.Label
        Me.lblUnknownWashbackStartingBalance = New System.Windows.Forms.Label
        Me.lblOtherWashbackStartingBalance = New System.Windows.Forms.Label
        Me.lblDcWashbackStartingBalance = New System.Windows.Forms.Label
        Me.lblCmWashbackStartingBalance = New System.Windows.Forms.Label
        Me.lblCcWashbackStartingBalance = New System.Windows.Forms.Label
        Me.lblWashbackBalanceAsOfDate = New System.Windows.Forms.Label
        Me.lblUnknownHatchlingStartingBalance = New System.Windows.Forms.Label
        Me.lblOtherHatchlingStartingBalance = New System.Windows.Forms.Label
        Me.lblDcHatchlingStartingBalance = New System.Windows.Forms.Label
        Me.lblCmHatchlingStartingBalance = New System.Windows.Forms.Label
        Me.lblCcHatchlingStartingBalance = New System.Windows.Forms.Label
        Me.lblHatchlingBalanceAsOfDate = New System.Windows.Forms.Label
        Me.lblUnknownHatchlingStartingBalanceLabel = New System.Windows.Forms.Label
        Me.lblOtherHatchlingStartingBalanceLabel = New System.Windows.Forms.Label
        Me.lblDcHatchlingStartingBalanceLabel = New System.Windows.Forms.Label
        Me.lblCmHatchlingStartingBalanceLabel = New System.Windows.Forms.Label
        Me.lblCcHatchlingStartingBalanceLabel = New System.Windows.Forms.Label
        Me.lblHatchlingBalanceAsOfDateLabel = New System.Windows.Forms.Label
        Me.btnEditOrganization = New System.Windows.Forms.Button
        Me.chkShowInactiveTurtles = New System.Windows.Forms.CheckBox
        Me.tipToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.picMoreInfoFiltering = New System.Windows.Forms.PictureBox
        Me.btnTurtleTransferFormFill = New System.Windows.Forms.Button
        Me.btnTaggingDataFormFill = New System.Windows.Forms.Button
        Me.btnTagRequestFormFill = New System.Windows.Forms.Button
        Me.btnStrandingAndSalvageFormFill = New System.Windows.Forms.Button
        Me.btnPublicTurtleWatchScheduleFormFill = New System.Windows.Forms.Button
        Me.btnPapillomaFormFill = New System.Windows.Forms.Button
        Me.btnNighttimePublicHatchlingReleaseFormFill = New System.Windows.Forms.Button
        Me.btnNecropsyFormFill = New System.Windows.Forms.Button
        Me.btnEducationalPresentationsUsingLiveTurtlesFormFill = New System.Windows.Forms.Button
        Me.btnDisorientationIncidentFormFill = New System.Windows.Forms.Button
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill = New System.Windows.Forms.Button
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill = New System.Windows.Forms.Button
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank = New System.Windows.Forms.Button
        Me.btnTurtleTransferFormBlank = New System.Windows.Forms.Button
        Me.btnTaggingDataFormBlank = New System.Windows.Forms.Button
        Me.btnTagRequestFormBlank = New System.Windows.Forms.Button
        Me.btnStrandingAndSalvageFormBlank = New System.Windows.Forms.Button
        Me.btnPublicTurtleWatchScheduleFormBlank = New System.Windows.Forms.Button
        Me.btnPapillomaFormBlank = New System.Windows.Forms.Button
        Me.btnNighttimePublicHatchlingReleaseFormBlank = New System.Windows.Forms.Button
        Me.btnNecropsyFormBlank = New System.Windows.Forms.Button
        Me.btnDisorientationIncidentFormBlank = New System.Windows.Forms.Button
        Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank = New System.Windows.Forms.Button
        Me.btnBeachRestorationProjectMonitoringTableBlank = New System.Windows.Forms.Button
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank = New System.Windows.Forms.Button
        Me.btnPublicTurtleWatchSummaryFormFill = New System.Windows.Forms.Button
        Me.btnPublicTurtleWatchSummaryFormBlank = New System.Windows.Forms.Button
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill = New System.Windows.Forms.Button
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank = New System.Windows.Forms.Button
        Me.btnDisorientationIncidentFormDirectionsBlank = New System.Windows.Forms.Button
        Me.btnObstructedNestingAttemptFormDirectionsBlank = New System.Windows.Forms.Button
        Me.btnObstructedNestingAttemptFormFill = New System.Windows.Forms.Button
        Me.btnObstructedNestingAttemptFormBlank = New System.Windows.Forms.Button
        Me.erpErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.tabMainFormTab = New System.Windows.Forms.TabControl
        Me.tpgTurtles = New System.Windows.Forms.TabPage
        Me.grdTurtleGrid = New System.Windows.Forms.DataGridView
        Me.colTurtleDateAcquiredBindableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTurtleAcquiredCountyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colDateRelinquishedBindableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTurtleTagNumberListStringDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnRefresh = New System.Windows.Forms.Button
        Me.txtFilterByValue = New System.Windows.Forms.TextBox
        Me.cboFilterByList = New System.Windows.Forms.ComboBox
        Me.btnAddTurtle = New System.Windows.Forms.Button
        Me.tpgTanks = New System.Windows.Forms.TabPage
        Me.grdTankGrid = New System.Windows.Forms.DataGridView
        Me.colTankEditActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colTankDeleteActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.btnAddTank = New System.Windows.Forms.Button
        Me.tpgHatchlingsEvents = New System.Windows.Forms.TabPage
        Me.btnAddHatchlingsDoaEvent = New System.Windows.Forms.Button
        Me.btnAddHatchlingsReleasedEvent = New System.Windows.Forms.Button
        Me.btnAddHatchlingsDiedEvent = New System.Windows.Forms.Button
        Me.grdHatchlingsEventGrid = New System.Windows.Forms.DataGridView
        Me.colHatchlingsEventEditActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colHatchlingsEventDeleteActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colHatchlingsEventEventIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHatchlingsEventSpeciesDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHatchlingsEventEventTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHatchlingsEventEventDateBindableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colHatchlingsEventCountyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAddHatchlingsAcquiredEvent = New System.Windows.Forms.Button
        Me.tpgWashbacksEvents = New System.Windows.Forms.TabPage
        Me.btnAddWashbacksDoaEvent = New System.Windows.Forms.Button
        Me.btnAddWashbacksReleasedEvent = New System.Windows.Forms.Button
        Me.btnAddWashbacksDiedEvent = New System.Windows.Forms.Button
        Me.grdWashbacksEventGrid = New System.Windows.Forms.DataGridView
        Me.colWashbacksEventEditActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colWashbacksEventDeleteActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colWashbacksEventEventIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWashbacksEventSpeciesDescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWashbacksEventEventTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWashbacksEventEventDateBindableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWashbacksEventCountyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colWashbacksEventUnder5CmClslDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnAddWashbacksAcquiredEvent = New System.Windows.Forms.Button
        Me.hlpHelpProvider = New System.Windows.Forms.HelpProvider
        Me.picBannerBackground = New System.Windows.Forms.PictureBox
        Me.picBanner = New System.Windows.Forms.PictureBox
        Me.picLeftHeaderTurtle = New System.Windows.Forms.PictureBox
        Me.picRightHeaderTurtle = New System.Windows.Forms.PictureBox
        Me.tabReportsTab = New System.Windows.Forms.TabControl
        Me.tpgFwcReportsAndForms = New System.Windows.Forms.TabPage
        Me.lblObstructedNestingAttemptFormDirections = New System.Windows.Forms.Label
        Me.lblObstructedNestingAttemptForm = New System.Windows.Forms.Label
        Me.lblDisorientationIncidentFormDirections = New System.Windows.Forms.Label
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForWashbacks = New System.Windows.Forms.Label
        Me.lblPublicTurtleWatchSummaryForm = New System.Windows.Forms.Label
        Me.lblTurtleTransferForm = New System.Windows.Forms.Label
        Me.lblTaggingDataForm = New System.Windows.Forms.Label
        Me.lblTagRequestForm = New System.Windows.Forms.Label
        Me.lblStrandingAndSalvageForm = New System.Windows.Forms.Label
        Me.lblPublicTurtleWatchScheduleForm = New System.Windows.Forms.Label
        Me.lblBeachRestorationProjectMonitoringTable = New System.Windows.Forms.Label
        Me.lblLine01 = New System.Windows.Forms.Label
        Me.lblPapillomaForm = New System.Windows.Forms.Label
        Me.lblNighttimePublicHatchlingReleaseForm = New System.Windows.Forms.Label
        Me.lblNecropsyForm = New System.Windows.Forms.Label
        Me.lblEducationalPresentationsUsingLiveTurtlesForm = New System.Windows.Forms.Label
        Me.lblDisorientationIncidentForm = New System.Windows.Forms.Label
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForHatchlings = New System.Windows.Forms.Label
        Me.lblMarineTurtleHoldingFacilityQuarterlyReport = New System.Windows.Forms.Label
        Me.tpgOtherReports = New System.Windows.Forms.TabPage
        Me.lnkHatchlingsWashbacksCountyReport = New System.Windows.Forms.LinkLabel
        Me.lnkTurtleTagReport = New System.Windows.Forms.LinkLabel
        Me.lnkTurtleInjuryReport = New System.Windows.Forms.LinkLabel
        Me.colTurtleEditActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colTurtleDeleteActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colTurtleTurtleIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTurtleTurtleNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTurtleSidNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTurtleSpeciesDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTurtleAcquiredFromDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTurtleTurtleSizeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTurtleStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTurtleRelinquishedToDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TurtleGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colTankTankIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTankTankNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TankGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colHatchlingsEventEventCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.HatchlingsEventGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.colWashbacksEventEventCountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.WashbacksEventGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.grpOrganizationInformation.SuspendLayout()
        Me.tabOrganizationInformationTab.SuspendLayout()
        Me.tpgGeneralInformation.SuspendLayout()
        Me.tpgHatchlingWashbackStartingBalances.SuspendLayout()
        CType(Me.picMoreInfoFiltering, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabMainFormTab.SuspendLayout()
        Me.tpgTurtles.SuspendLayout()
        CType(Me.grdTurtleGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgTanks.SuspendLayout()
        CType(Me.grdTankGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgHatchlingsEvents.SuspendLayout()
        CType(Me.grdHatchlingsEventGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgWashbacksEvents.SuspendLayout()
        CType(Me.grdWashbacksEventGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBannerBackground, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLeftHeaderTurtle, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRightHeaderTurtle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabReportsTab.SuspendLayout()
        Me.tpgFwcReportsAndForms.SuspendLayout()
        Me.tpgOtherReports.SuspendLayout()
        CType(Me.TurtleGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TankGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.HatchlingsEventGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WashbacksEventGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'mnuMainMenu
        '
        Me.mnuMainMenu.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFile, Me.mnuAdmin, Me.mnuHelp})
        '
        'mnuFile
        '
        Me.mnuFile.Index = 0
        Me.mnuFile.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuFileExit})
        Me.mnuFile.Text = "&File"
        '
        'mnuFileExit
        '
        Me.mnuFileExit.Index = 0
        Me.mnuFileExit.Text = "E&xit"
        '
        'mnuAdmin
        '
        Me.mnuAdmin.Index = 1
        Me.mnuAdmin.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuAdminCounties, Me.mnuAdminSeparator01, Me.mnuAdminLatitudeLongitudeHelper})
        Me.mnuAdmin.Text = "&Admin"
        '
        'mnuAdminCounties
        '
        Me.mnuAdminCounties.Index = 0
        Me.mnuAdminCounties.Text = "&Counties..."
        '
        'mnuAdminSeparator01
        '
        Me.mnuAdminSeparator01.Index = 1
        Me.mnuAdminSeparator01.Text = "-"
        '
        'mnuAdminLatitudeLongitudeHelper
        '
        Me.mnuAdminLatitudeLongitudeHelper.Index = 2
        Me.mnuAdminLatitudeLongitudeHelper.Text = "&Latitude/Longitude Helper..."
        '
        'mnuHelp
        '
        Me.mnuHelp.Index = 2
        Me.mnuHelp.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuHelpContents, Me.mnuHelpIndex, Me.mnuHelpSearch, Me.mnuHelpSep01, Me.mnuHelpViewErrorLog, Me.mnuHelpClearErrorLog, Me.mnuHelpSep99, Me.mnuHelpAbout})
        Me.mnuHelp.Text = "&Help"
        '
        'mnuHelpContents
        '
        Me.mnuHelpContents.Index = 0
        Me.mnuHelpContents.Text = "&Contents..."
        '
        'mnuHelpIndex
        '
        Me.mnuHelpIndex.Index = 1
        Me.mnuHelpIndex.Text = "&Index..."
        '
        'mnuHelpSearch
        '
        Me.mnuHelpSearch.Index = 2
        Me.mnuHelpSearch.Text = "&Search..."
        '
        'mnuHelpSep01
        '
        Me.mnuHelpSep01.Index = 3
        Me.mnuHelpSep01.Text = "-"
        '
        'mnuHelpViewErrorLog
        '
        Me.mnuHelpViewErrorLog.Index = 4
        Me.mnuHelpViewErrorLog.Text = "&View Error Log"
        '
        'mnuHelpClearErrorLog
        '
        Me.mnuHelpClearErrorLog.Index = 5
        Me.mnuHelpClearErrorLog.Text = "C&lear Error Log"
        '
        'mnuHelpSep99
        '
        Me.mnuHelpSep99.Index = 6
        Me.mnuHelpSep99.Text = "-"
        '
        'mnuHelpAbout
        '
        Me.mnuHelpAbout.Index = 7
        Me.mnuHelpAbout.Text = "&About ROSTER..."
        '
        'sbrStatusBar
        '
        Me.sbrStatusBar.Location = New System.Drawing.Point(0, 559)
        Me.sbrStatusBar.Name = "sbrStatusBar"
        Me.sbrStatusBar.ShowPanels = True
        Me.sbrStatusBar.Size = New System.Drawing.Size(1016, 22)
        Me.sbrStatusBar.TabIndex = 4
        '
        'grpOrganizationInformation
        '
        Me.grpOrganizationInformation.Controls.Add(Me.tabOrganizationInformationTab)
        Me.grpOrganizationInformation.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpOrganizationInformation.ForeColor = System.Drawing.SystemColors.ControlText
        Me.grpOrganizationInformation.Location = New System.Drawing.Point(8, 48)
        Me.grpOrganizationInformation.Name = "grpOrganizationInformation"
        Me.grpOrganizationInformation.Size = New System.Drawing.Size(441, 300)
        Me.grpOrganizationInformation.TabIndex = 1
        Me.grpOrganizationInformation.TabStop = False
        Me.grpOrganizationInformation.Text = "Organization Information"
        '
        'tabOrganizationInformationTab
        '
        Me.tabOrganizationInformationTab.Controls.Add(Me.tpgGeneralInformation)
        Me.tabOrganizationInformationTab.Controls.Add(Me.tpgHatchlingWashbackStartingBalances)
        Me.tabOrganizationInformationTab.Location = New System.Drawing.Point(6, 18)
        Me.tabOrganizationInformationTab.Name = "tabOrganizationInformationTab"
        Me.tabOrganizationInformationTab.SelectedIndex = 0
        Me.tabOrganizationInformationTab.Size = New System.Drawing.Size(429, 276)
        Me.tabOrganizationInformationTab.TabIndex = 0
        '
        'tpgGeneralInformation
        '
        Me.tpgGeneralInformation.Controls.Add(Me.lblFaxLabel)
        Me.tpgGeneralInformation.Controls.Add(Me.lblOrganizationNameLabel)
        Me.tpgGeneralInformation.Controls.Add(Me.lblOrganizationName)
        Me.tpgGeneralInformation.Controls.Add(Me.lblAddressLabel)
        Me.tpgGeneralInformation.Controls.Add(Me.lblAddress1)
        Me.tpgGeneralInformation.Controls.Add(Me.lblAddress2)
        Me.tpgGeneralInformation.Controls.Add(Me.lblCityLabel)
        Me.tpgGeneralInformation.Controls.Add(Me.lblCity)
        Me.tpgGeneralInformation.Controls.Add(Me.lblStateLabel)
        Me.tpgGeneralInformation.Controls.Add(Me.lblState)
        Me.tpgGeneralInformation.Controls.Add(Me.lblZipCodeLabel)
        Me.tpgGeneralInformation.Controls.Add(Me.lblZipCode)
        Me.tpgGeneralInformation.Controls.Add(Me.lblPhoneLabel)
        Me.tpgGeneralInformation.Controls.Add(Me.lblPhone)
        Me.tpgGeneralInformation.Controls.Add(Me.lblFax)
        Me.tpgGeneralInformation.Controls.Add(Me.lblEmailLabel)
        Me.tpgGeneralInformation.Controls.Add(Me.lblEmailAddress)
        Me.tpgGeneralInformation.Controls.Add(Me.lblContactNameLabel)
        Me.tpgGeneralInformation.Controls.Add(Me.lblContactName)
        Me.tpgGeneralInformation.Controls.Add(Me.lblPermitNumberLabel)
        Me.tpgGeneralInformation.Controls.Add(Me.lblPermitNumber)
        Me.tpgGeneralInformation.Location = New System.Drawing.Point(4, 22)
        Me.tpgGeneralInformation.Name = "tpgGeneralInformation"
        Me.tpgGeneralInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgGeneralInformation.Size = New System.Drawing.Size(421, 250)
        Me.tpgGeneralInformation.TabIndex = 0
        Me.tpgGeneralInformation.Text = "General Information"
        Me.tpgGeneralInformation.UseVisualStyleBackColor = True
        '
        'lblFaxLabel
        '
        Me.lblFaxLabel.Location = New System.Drawing.Point(6, 152)
        Me.lblFaxLabel.Name = "lblFaxLabel"
        Me.lblFaxLabel.Size = New System.Drawing.Size(49, 16)
        Me.lblFaxLabel.TabIndex = 22
        Me.lblFaxLabel.Text = "Fax:"
        '
        'lblOrganizationNameLabel
        '
        Me.lblOrganizationNameLabel.Location = New System.Drawing.Point(6, 5)
        Me.lblOrganizationNameLabel.Name = "lblOrganizationNameLabel"
        Me.lblOrganizationNameLabel.Size = New System.Drawing.Size(56, 16)
        Me.lblOrganizationNameLabel.TabIndex = 1
        Me.lblOrganizationNameLabel.Text = "Name:"
        '
        'lblOrganizationName
        '
        Me.lblOrganizationName.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOrganizationName.ForeColor = System.Drawing.Color.Green
        Me.lblOrganizationName.Location = New System.Drawing.Point(61, 5)
        Me.lblOrganizationName.Name = "lblOrganizationName"
        Me.lblOrganizationName.Size = New System.Drawing.Size(330, 16)
        Me.lblOrganizationName.TabIndex = 2
        Me.lblOrganizationName.Text = "<lblOrganizationName>"
        '
        'lblAddressLabel
        '
        Me.lblAddressLabel.Location = New System.Drawing.Point(6, 26)
        Me.lblAddressLabel.Name = "lblAddressLabel"
        Me.lblAddressLabel.Size = New System.Drawing.Size(56, 16)
        Me.lblAddressLabel.TabIndex = 3
        Me.lblAddressLabel.Text = "Address:"
        '
        'lblAddress1
        '
        Me.lblAddress1.ForeColor = System.Drawing.Color.Green
        Me.lblAddress1.Location = New System.Drawing.Point(61, 26)
        Me.lblAddress1.Name = "lblAddress1"
        Me.lblAddress1.Size = New System.Drawing.Size(330, 16)
        Me.lblAddress1.TabIndex = 4
        Me.lblAddress1.Text = "<lblAddress1>"
        '
        'lblAddress2
        '
        Me.lblAddress2.ForeColor = System.Drawing.Color.Green
        Me.lblAddress2.Location = New System.Drawing.Point(61, 47)
        Me.lblAddress2.Name = "lblAddress2"
        Me.lblAddress2.Size = New System.Drawing.Size(330, 16)
        Me.lblAddress2.TabIndex = 5
        Me.lblAddress2.Text = "<lblAddress2>"
        '
        'lblCityLabel
        '
        Me.lblCityLabel.Location = New System.Drawing.Point(6, 68)
        Me.lblCityLabel.Name = "lblCityLabel"
        Me.lblCityLabel.Size = New System.Drawing.Size(56, 16)
        Me.lblCityLabel.TabIndex = 6
        Me.lblCityLabel.Text = "City:"
        '
        'lblCity
        '
        Me.lblCity.ForeColor = System.Drawing.Color.Green
        Me.lblCity.Location = New System.Drawing.Point(61, 68)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(330, 16)
        Me.lblCity.TabIndex = 7
        Me.lblCity.Text = "<lblCity>"
        '
        'lblStateLabel
        '
        Me.lblStateLabel.Location = New System.Drawing.Point(6, 88)
        Me.lblStateLabel.Name = "lblStateLabel"
        Me.lblStateLabel.Size = New System.Drawing.Size(56, 16)
        Me.lblStateLabel.TabIndex = 8
        Me.lblStateLabel.Text = "State:"
        '
        'lblState
        '
        Me.lblState.ForeColor = System.Drawing.Color.Green
        Me.lblState.Location = New System.Drawing.Point(61, 89)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(330, 16)
        Me.lblState.TabIndex = 9
        Me.lblState.Text = "<lblState>"
        '
        'lblZipCodeLabel
        '
        Me.lblZipCodeLabel.Location = New System.Drawing.Point(6, 110)
        Me.lblZipCodeLabel.Name = "lblZipCodeLabel"
        Me.lblZipCodeLabel.Size = New System.Drawing.Size(56, 16)
        Me.lblZipCodeLabel.TabIndex = 10
        Me.lblZipCodeLabel.Text = "ZIP:"
        '
        'lblZipCode
        '
        Me.lblZipCode.ForeColor = System.Drawing.Color.Green
        Me.lblZipCode.Location = New System.Drawing.Point(61, 110)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(330, 16)
        Me.lblZipCode.TabIndex = 11
        Me.lblZipCode.Text = "<lblZipCode>"
        '
        'lblPhoneLabel
        '
        Me.lblPhoneLabel.Location = New System.Drawing.Point(6, 131)
        Me.lblPhoneLabel.Name = "lblPhoneLabel"
        Me.lblPhoneLabel.Size = New System.Drawing.Size(49, 16)
        Me.lblPhoneLabel.TabIndex = 12
        Me.lblPhoneLabel.Text = "Phone:"
        '
        'lblPhone
        '
        Me.lblPhone.ForeColor = System.Drawing.Color.Green
        Me.lblPhone.Location = New System.Drawing.Point(61, 131)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(330, 16)
        Me.lblPhone.TabIndex = 13
        Me.lblPhone.Text = "<lblPhone>"
        '
        'lblFax
        '
        Me.lblFax.ForeColor = System.Drawing.Color.Green
        Me.lblFax.Location = New System.Drawing.Point(61, 152)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(330, 16)
        Me.lblFax.TabIndex = 15
        Me.lblFax.Text = "<lblFax>"
        '
        'lblEmailLabel
        '
        Me.lblEmailLabel.Location = New System.Drawing.Point(6, 173)
        Me.lblEmailLabel.Name = "lblEmailLabel"
        Me.lblEmailLabel.Size = New System.Drawing.Size(56, 16)
        Me.lblEmailLabel.TabIndex = 16
        Me.lblEmailLabel.Text = "E-mail:"
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.ForeColor = System.Drawing.Color.Green
        Me.lblEmailAddress.Location = New System.Drawing.Point(61, 173)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(330, 16)
        Me.lblEmailAddress.TabIndex = 17
        Me.lblEmailAddress.Text = "<lblEmailAddress>"
        '
        'lblContactNameLabel
        '
        Me.lblContactNameLabel.Location = New System.Drawing.Point(6, 194)
        Me.lblContactNameLabel.Name = "lblContactNameLabel"
        Me.lblContactNameLabel.Size = New System.Drawing.Size(56, 16)
        Me.lblContactNameLabel.TabIndex = 18
        Me.lblContactNameLabel.Text = "Contact:"
        '
        'lblContactName
        '
        Me.lblContactName.ForeColor = System.Drawing.Color.Green
        Me.lblContactName.Location = New System.Drawing.Point(61, 194)
        Me.lblContactName.Name = "lblContactName"
        Me.lblContactName.Size = New System.Drawing.Size(330, 16)
        Me.lblContactName.TabIndex = 19
        Me.lblContactName.Text = "<lblContactName>"
        '
        'lblPermitNumberLabel
        '
        Me.lblPermitNumberLabel.Location = New System.Drawing.Point(6, 215)
        Me.lblPermitNumberLabel.Name = "lblPermitNumberLabel"
        Me.lblPermitNumberLabel.Size = New System.Drawing.Size(56, 16)
        Me.lblPermitNumberLabel.TabIndex = 20
        Me.lblPermitNumberLabel.Text = "Permit #:"
        '
        'lblPermitNumber
        '
        Me.lblPermitNumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPermitNumber.ForeColor = System.Drawing.Color.Green
        Me.lblPermitNumber.Location = New System.Drawing.Point(61, 215)
        Me.lblPermitNumber.Name = "lblPermitNumber"
        Me.lblPermitNumber.Size = New System.Drawing.Size(330, 16)
        Me.lblPermitNumber.TabIndex = 21
        Me.lblPermitNumber.Text = "<lblPermitNumber>"
        '
        'tpgHatchlingWashbackStartingBalances
        '
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblWashbackStartingBalances)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblHatchlingStartingBalances)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblUnknownWashbackStartingBalance)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblOtherWashbackStartingBalance)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblDcWashbackStartingBalance)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblCmWashbackStartingBalance)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblCcWashbackStartingBalance)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblWashbackBalanceAsOfDate)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblUnknownHatchlingStartingBalance)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblOtherHatchlingStartingBalance)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblDcHatchlingStartingBalance)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblCmHatchlingStartingBalance)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblCcHatchlingStartingBalance)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblHatchlingBalanceAsOfDate)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblUnknownHatchlingStartingBalanceLabel)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblOtherHatchlingStartingBalanceLabel)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblDcHatchlingStartingBalanceLabel)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblCmHatchlingStartingBalanceLabel)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblCcHatchlingStartingBalanceLabel)
        Me.tpgHatchlingWashbackStartingBalances.Controls.Add(Me.lblHatchlingBalanceAsOfDateLabel)
        Me.tpgHatchlingWashbackStartingBalances.Location = New System.Drawing.Point(4, 22)
        Me.tpgHatchlingWashbackStartingBalances.Name = "tpgHatchlingWashbackStartingBalances"
        Me.tpgHatchlingWashbackStartingBalances.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgHatchlingWashbackStartingBalances.Size = New System.Drawing.Size(421, 250)
        Me.tpgHatchlingWashbackStartingBalances.TabIndex = 1
        Me.tpgHatchlingWashbackStartingBalances.Text = "Hatchling/Washback Starting Balances"
        Me.tpgHatchlingWashbackStartingBalances.UseVisualStyleBackColor = True
        '
        'lblWashbackStartingBalances
        '
        Me.lblWashbackStartingBalances.AutoSize = True
        Me.lblWashbackStartingBalances.Location = New System.Drawing.Point(230, 10)
        Me.lblWashbackStartingBalances.Name = "lblWashbackStartingBalances"
        Me.lblWashbackStartingBalances.Size = New System.Drawing.Size(64, 13)
        Me.lblWashbackStartingBalances.TabIndex = 35
        Me.lblWashbackStartingBalances.Text = "Washbacks"
        '
        'lblHatchlingStartingBalances
        '
        Me.lblHatchlingStartingBalances.AutoSize = True
        Me.lblHatchlingStartingBalances.Location = New System.Drawing.Point(107, 10)
        Me.lblHatchlingStartingBalances.Name = "lblHatchlingStartingBalances"
        Me.lblHatchlingStartingBalances.Size = New System.Drawing.Size(57, 13)
        Me.lblHatchlingStartingBalances.TabIndex = 34
        Me.lblHatchlingStartingBalances.Text = "Hatchlings"
        '
        'lblUnknownWashbackStartingBalance
        '
        Me.lblUnknownWashbackStartingBalance.ForeColor = System.Drawing.Color.Green
        Me.lblUnknownWashbackStartingBalance.Location = New System.Drawing.Point(230, 151)
        Me.lblUnknownWashbackStartingBalance.Name = "lblUnknownWashbackStartingBalance"
        Me.lblUnknownWashbackStartingBalance.Size = New System.Drawing.Size(119, 16)
        Me.lblUnknownWashbackStartingBalance.TabIndex = 33
        Me.lblUnknownWashbackStartingBalance.Text = "<lblUnknownWashbackStartingBalance>"
        '
        'lblOtherWashbackStartingBalance
        '
        Me.lblOtherWashbackStartingBalance.ForeColor = System.Drawing.Color.Green
        Me.lblOtherWashbackStartingBalance.Location = New System.Drawing.Point(230, 127)
        Me.lblOtherWashbackStartingBalance.Name = "lblOtherWashbackStartingBalance"
        Me.lblOtherWashbackStartingBalance.Size = New System.Drawing.Size(119, 16)
        Me.lblOtherWashbackStartingBalance.TabIndex = 32
        Me.lblOtherWashbackStartingBalance.Text = "<lblOtherWashbackStartingBalance>"
        '
        'lblDcWashbackStartingBalance
        '
        Me.lblDcWashbackStartingBalance.ForeColor = System.Drawing.Color.Green
        Me.lblDcWashbackStartingBalance.Location = New System.Drawing.Point(230, 103)
        Me.lblDcWashbackStartingBalance.Name = "lblDcWashbackStartingBalance"
        Me.lblDcWashbackStartingBalance.Size = New System.Drawing.Size(119, 16)
        Me.lblDcWashbackStartingBalance.TabIndex = 31
        Me.lblDcWashbackStartingBalance.Text = "<lblDcWashbackStartingBalance>"
        '
        'lblCmWashbackStartingBalance
        '
        Me.lblCmWashbackStartingBalance.ForeColor = System.Drawing.Color.Green
        Me.lblCmWashbackStartingBalance.Location = New System.Drawing.Point(230, 79)
        Me.lblCmWashbackStartingBalance.Name = "lblCmWashbackStartingBalance"
        Me.lblCmWashbackStartingBalance.Size = New System.Drawing.Size(119, 16)
        Me.lblCmWashbackStartingBalance.TabIndex = 30
        Me.lblCmWashbackStartingBalance.Text = "<lblCmWashbackStartingBalanceLabel>"
        '
        'lblCcWashbackStartingBalance
        '
        Me.lblCcWashbackStartingBalance.ForeColor = System.Drawing.Color.Green
        Me.lblCcWashbackStartingBalance.Location = New System.Drawing.Point(230, 55)
        Me.lblCcWashbackStartingBalance.Name = "lblCcWashbackStartingBalance"
        Me.lblCcWashbackStartingBalance.Size = New System.Drawing.Size(119, 16)
        Me.lblCcWashbackStartingBalance.TabIndex = 29
        Me.lblCcWashbackStartingBalance.Text = "<lblCcWashbackStartingBalance>"
        '
        'lblWashbackBalanceAsOfDate
        '
        Me.lblWashbackBalanceAsOfDate.ForeColor = System.Drawing.Color.Green
        Me.lblWashbackBalanceAsOfDate.Location = New System.Drawing.Point(230, 30)
        Me.lblWashbackBalanceAsOfDate.Name = "lblWashbackBalanceAsOfDate"
        Me.lblWashbackBalanceAsOfDate.Size = New System.Drawing.Size(119, 16)
        Me.lblWashbackBalanceAsOfDate.TabIndex = 28
        Me.lblWashbackBalanceAsOfDate.Text = "<lblWashbackBalanceAsOfDate>"
        '
        'lblUnknownHatchlingStartingBalance
        '
        Me.lblUnknownHatchlingStartingBalance.ForeColor = System.Drawing.Color.Green
        Me.lblUnknownHatchlingStartingBalance.Location = New System.Drawing.Point(105, 151)
        Me.lblUnknownHatchlingStartingBalance.Name = "lblUnknownHatchlingStartingBalance"
        Me.lblUnknownHatchlingStartingBalance.Size = New System.Drawing.Size(119, 16)
        Me.lblUnknownHatchlingStartingBalance.TabIndex = 15
        Me.lblUnknownHatchlingStartingBalance.Text = "<lblUnknownHatchlingStartingBalance>"
        '
        'lblOtherHatchlingStartingBalance
        '
        Me.lblOtherHatchlingStartingBalance.ForeColor = System.Drawing.Color.Green
        Me.lblOtherHatchlingStartingBalance.Location = New System.Drawing.Point(105, 127)
        Me.lblOtherHatchlingStartingBalance.Name = "lblOtherHatchlingStartingBalance"
        Me.lblOtherHatchlingStartingBalance.Size = New System.Drawing.Size(119, 16)
        Me.lblOtherHatchlingStartingBalance.TabIndex = 14
        Me.lblOtherHatchlingStartingBalance.Text = "<lblOtherHatchlingStartingBalance>"
        '
        'lblDcHatchlingStartingBalance
        '
        Me.lblDcHatchlingStartingBalance.ForeColor = System.Drawing.Color.Green
        Me.lblDcHatchlingStartingBalance.Location = New System.Drawing.Point(105, 103)
        Me.lblDcHatchlingStartingBalance.Name = "lblDcHatchlingStartingBalance"
        Me.lblDcHatchlingStartingBalance.Size = New System.Drawing.Size(119, 16)
        Me.lblDcHatchlingStartingBalance.TabIndex = 13
        Me.lblDcHatchlingStartingBalance.Text = "<lblDcHatchlingStartingBalance>"
        '
        'lblCmHatchlingStartingBalance
        '
        Me.lblCmHatchlingStartingBalance.ForeColor = System.Drawing.Color.Green
        Me.lblCmHatchlingStartingBalance.Location = New System.Drawing.Point(105, 79)
        Me.lblCmHatchlingStartingBalance.Name = "lblCmHatchlingStartingBalance"
        Me.lblCmHatchlingStartingBalance.Size = New System.Drawing.Size(119, 16)
        Me.lblCmHatchlingStartingBalance.TabIndex = 12
        Me.lblCmHatchlingStartingBalance.Text = "<lblCmHatchlingStartingBalance>"
        '
        'lblCcHatchlingStartingBalance
        '
        Me.lblCcHatchlingStartingBalance.ForeColor = System.Drawing.Color.Green
        Me.lblCcHatchlingStartingBalance.Location = New System.Drawing.Point(105, 55)
        Me.lblCcHatchlingStartingBalance.Name = "lblCcHatchlingStartingBalance"
        Me.lblCcHatchlingStartingBalance.Size = New System.Drawing.Size(119, 16)
        Me.lblCcHatchlingStartingBalance.TabIndex = 11
        Me.lblCcHatchlingStartingBalance.Text = "<lblCcHatchlingStartingBalance>"
        '
        'lblHatchlingBalanceAsOfDate
        '
        Me.lblHatchlingBalanceAsOfDate.ForeColor = System.Drawing.Color.Green
        Me.lblHatchlingBalanceAsOfDate.Location = New System.Drawing.Point(105, 30)
        Me.lblHatchlingBalanceAsOfDate.Name = "lblHatchlingBalanceAsOfDate"
        Me.lblHatchlingBalanceAsOfDate.Size = New System.Drawing.Size(119, 16)
        Me.lblHatchlingBalanceAsOfDate.TabIndex = 10
        Me.lblHatchlingBalanceAsOfDate.Text = "<lblHatchlingBalanceAsOfDate>"
        '
        'lblUnknownHatchlingStartingBalanceLabel
        '
        Me.lblUnknownHatchlingStartingBalanceLabel.AutoSize = True
        Me.lblUnknownHatchlingStartingBalanceLabel.Location = New System.Drawing.Point(6, 151)
        Me.lblUnknownHatchlingStartingBalanceLabel.Name = "lblUnknownHatchlingStartingBalanceLabel"
        Me.lblUnknownHatchlingStartingBalanceLabel.Size = New System.Drawing.Size(56, 13)
        Me.lblUnknownHatchlingStartingBalanceLabel.TabIndex = 9
        Me.lblUnknownHatchlingStartingBalanceLabel.Text = "Unknown:"
        '
        'lblOtherHatchlingStartingBalanceLabel
        '
        Me.lblOtherHatchlingStartingBalanceLabel.AutoSize = True
        Me.lblOtherHatchlingStartingBalanceLabel.Location = New System.Drawing.Point(6, 127)
        Me.lblOtherHatchlingStartingBalanceLabel.Name = "lblOtherHatchlingStartingBalanceLabel"
        Me.lblOtherHatchlingStartingBalanceLabel.Size = New System.Drawing.Size(36, 13)
        Me.lblOtherHatchlingStartingBalanceLabel.TabIndex = 7
        Me.lblOtherHatchlingStartingBalanceLabel.Text = "Other:"
        '
        'lblDcHatchlingStartingBalanceLabel
        '
        Me.lblDcHatchlingStartingBalanceLabel.AutoSize = True
        Me.lblDcHatchlingStartingBalanceLabel.Location = New System.Drawing.Point(6, 103)
        Me.lblDcHatchlingStartingBalanceLabel.Name = "lblDcHatchlingStartingBalanceLabel"
        Me.lblDcHatchlingStartingBalanceLabel.Size = New System.Drawing.Size(93, 13)
        Me.lblDcHatchlingStartingBalanceLabel.TabIndex = 5
        Me.lblDcHatchlingStartingBalanceLabel.Text = "Leatherback (Dc):"
        '
        'lblCmHatchlingStartingBalanceLabel
        '
        Me.lblCmHatchlingStartingBalanceLabel.AutoSize = True
        Me.lblCmHatchlingStartingBalanceLabel.Location = New System.Drawing.Point(6, 79)
        Me.lblCmHatchlingStartingBalanceLabel.Name = "lblCmHatchlingStartingBalanceLabel"
        Me.lblCmHatchlingStartingBalanceLabel.Size = New System.Drawing.Size(63, 13)
        Me.lblCmHatchlingStartingBalanceLabel.TabIndex = 3
        Me.lblCmHatchlingStartingBalanceLabel.Text = "Green (Cm):"
        '
        'lblCcHatchlingStartingBalanceLabel
        '
        Me.lblCcHatchlingStartingBalanceLabel.AutoSize = True
        Me.lblCcHatchlingStartingBalanceLabel.Location = New System.Drawing.Point(6, 55)
        Me.lblCcHatchlingStartingBalanceLabel.Name = "lblCcHatchlingStartingBalanceLabel"
        Me.lblCcHatchlingStartingBalanceLabel.Size = New System.Drawing.Size(89, 13)
        Me.lblCcHatchlingStartingBalanceLabel.TabIndex = 2
        Me.lblCcHatchlingStartingBalanceLabel.Text = "Loggerhead (Cc):"
        '
        'lblHatchlingBalanceAsOfDateLabel
        '
        Me.lblHatchlingBalanceAsOfDateLabel.AutoSize = True
        Me.lblHatchlingBalanceAsOfDateLabel.Location = New System.Drawing.Point(6, 30)
        Me.lblHatchlingBalanceAsOfDateLabel.Name = "lblHatchlingBalanceAsOfDateLabel"
        Me.lblHatchlingBalanceAsOfDateLabel.Size = New System.Drawing.Size(75, 13)
        Me.lblHatchlingBalanceAsOfDateLabel.TabIndex = 1
        Me.lblHatchlingBalanceAsOfDateLabel.Text = "Balance as of:"
        '
        'btnEditOrganization
        '
        Me.btnEditOrganization.BackColor = System.Drawing.Color.MintCream
        Me.btnEditOrganization.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEditOrganization.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEditOrganization.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditOrganization.ForeColor = System.Drawing.Color.Blue
        Me.hlpHelpProvider.SetHelpKeyword(Me.btnEditOrganization, "ChangingOrganizationInformation.htm")
        Me.hlpHelpProvider.SetHelpNavigator(Me.btnEditOrganization, System.Windows.Forms.HelpNavigator.Topic)
        Me.hlpHelpProvider.SetHelpString(Me.btnEditOrganization, "")
        Me.btnEditOrganization.Location = New System.Drawing.Point(144, 44)
        Me.btnEditOrganization.Name = "btnEditOrganization"
        Me.hlpHelpProvider.SetShowHelp(Me.btnEditOrganization, True)
        Me.btnEditOrganization.Size = New System.Drawing.Size(38, 20)
        Me.btnEditOrganization.TabIndex = 0
        Me.btnEditOrganization.Text = "edit"
        Me.btnEditOrganization.UseVisualStyleBackColor = False
        '
        'chkShowInactiveTurtles
        '
        Me.chkShowInactiveTurtles.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.chkShowInactiveTurtles.Location = New System.Drawing.Point(848, 3)
        Me.chkShowInactiveTurtles.Name = "chkShowInactiveTurtles"
        Me.chkShowInactiveTurtles.Size = New System.Drawing.Size(135, 16)
        Me.chkShowInactiveTurtles.TabIndex = 4
        Me.chkShowInactiveTurtles.Text = "Show &inactive turtles?"
        '
        'picMoreInfoFiltering
        '
        Me.picMoreInfoFiltering.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoFiltering.Image = CType(resources.GetObject("picMoreInfoFiltering.Image"), System.Drawing.Image)
        Me.picMoreInfoFiltering.Location = New System.Drawing.Point(256, 4)
        Me.picMoreInfoFiltering.Name = "picMoreInfoFiltering"
        Me.picMoreInfoFiltering.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoFiltering.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoFiltering.TabIndex = 54
        Me.picMoreInfoFiltering.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoFiltering, "More information about the Marine Turtle Holding Facility Quarterly Report")
        '
        'btnTurtleTransferFormFill
        '
        Me.btnTurtleTransferFormFill.BackColor = System.Drawing.Color.MintCream
        Me.btnTurtleTransferFormFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTurtleTransferFormFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTurtleTransferFormFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTurtleTransferFormFill.ForeColor = System.Drawing.Color.Blue
        Me.btnTurtleTransferFormFill.Location = New System.Drawing.Point(294, 227)
        Me.btnTurtleTransferFormFill.Name = "btnTurtleTransferFormFill"
        Me.btnTurtleTransferFormFill.Size = New System.Drawing.Size(24, 20)
        Me.btnTurtleTransferFormFill.TabIndex = 49
        Me.btnTurtleTransferFormFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnTurtleTransferFormFill, "Fill out the form")
        Me.btnTurtleTransferFormFill.UseVisualStyleBackColor = False
        '
        'btnTaggingDataFormFill
        '
        Me.btnTaggingDataFormFill.BackColor = System.Drawing.Color.MintCream
        Me.btnTaggingDataFormFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTaggingDataFormFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTaggingDataFormFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaggingDataFormFill.ForeColor = System.Drawing.Color.Blue
        Me.btnTaggingDataFormFill.Location = New System.Drawing.Point(294, 203)
        Me.btnTaggingDataFormFill.Name = "btnTaggingDataFormFill"
        Me.btnTaggingDataFormFill.Size = New System.Drawing.Size(24, 20)
        Me.btnTaggingDataFormFill.TabIndex = 46
        Me.btnTaggingDataFormFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnTaggingDataFormFill, "Fill out the form")
        Me.btnTaggingDataFormFill.UseVisualStyleBackColor = False
        '
        'btnTagRequestFormFill
        '
        Me.btnTagRequestFormFill.BackColor = System.Drawing.Color.MintCream
        Me.btnTagRequestFormFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTagRequestFormFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTagRequestFormFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTagRequestFormFill.ForeColor = System.Drawing.Color.Blue
        Me.btnTagRequestFormFill.Location = New System.Drawing.Point(294, 179)
        Me.btnTagRequestFormFill.Name = "btnTagRequestFormFill"
        Me.btnTagRequestFormFill.Size = New System.Drawing.Size(24, 20)
        Me.btnTagRequestFormFill.TabIndex = 43
        Me.btnTagRequestFormFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnTagRequestFormFill, "Fill out the form")
        Me.btnTagRequestFormFill.UseVisualStyleBackColor = False
        '
        'btnStrandingAndSalvageFormFill
        '
        Me.btnStrandingAndSalvageFormFill.BackColor = System.Drawing.Color.MintCream
        Me.btnStrandingAndSalvageFormFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStrandingAndSalvageFormFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStrandingAndSalvageFormFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStrandingAndSalvageFormFill.ForeColor = System.Drawing.Color.Blue
        Me.btnStrandingAndSalvageFormFill.Location = New System.Drawing.Point(294, 155)
        Me.btnStrandingAndSalvageFormFill.Name = "btnStrandingAndSalvageFormFill"
        Me.btnStrandingAndSalvageFormFill.Size = New System.Drawing.Size(24, 20)
        Me.btnStrandingAndSalvageFormFill.TabIndex = 40
        Me.btnStrandingAndSalvageFormFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnStrandingAndSalvageFormFill, "Fill out the form")
        Me.btnStrandingAndSalvageFormFill.UseVisualStyleBackColor = False
        '
        'btnPublicTurtleWatchScheduleFormFill
        '
        Me.btnPublicTurtleWatchScheduleFormFill.BackColor = System.Drawing.Color.MintCream
        Me.btnPublicTurtleWatchScheduleFormFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPublicTurtleWatchScheduleFormFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPublicTurtleWatchScheduleFormFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPublicTurtleWatchScheduleFormFill.ForeColor = System.Drawing.Color.Blue
        Me.btnPublicTurtleWatchScheduleFormFill.Location = New System.Drawing.Point(294, 107)
        Me.btnPublicTurtleWatchScheduleFormFill.Name = "btnPublicTurtleWatchScheduleFormFill"
        Me.btnPublicTurtleWatchScheduleFormFill.Size = New System.Drawing.Size(24, 20)
        Me.btnPublicTurtleWatchScheduleFormFill.TabIndex = 34
        Me.btnPublicTurtleWatchScheduleFormFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnPublicTurtleWatchScheduleFormFill, "Fill out the form")
        Me.btnPublicTurtleWatchScheduleFormFill.UseVisualStyleBackColor = False
        '
        'btnPapillomaFormFill
        '
        Me.btnPapillomaFormFill.BackColor = System.Drawing.Color.MintCream
        Me.btnPapillomaFormFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPapillomaFormFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPapillomaFormFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPapillomaFormFill.ForeColor = System.Drawing.Color.Blue
        Me.btnPapillomaFormFill.Location = New System.Drawing.Point(294, 83)
        Me.btnPapillomaFormFill.Name = "btnPapillomaFormFill"
        Me.btnPapillomaFormFill.Size = New System.Drawing.Size(24, 20)
        Me.btnPapillomaFormFill.TabIndex = 31
        Me.btnPapillomaFormFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnPapillomaFormFill, "Print a blank form")
        Me.btnPapillomaFormFill.UseVisualStyleBackColor = False
        '
        'btnNighttimePublicHatchlingReleaseFormFill
        '
        Me.btnNighttimePublicHatchlingReleaseFormFill.BackColor = System.Drawing.Color.MintCream
        Me.btnNighttimePublicHatchlingReleaseFormFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNighttimePublicHatchlingReleaseFormFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNighttimePublicHatchlingReleaseFormFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNighttimePublicHatchlingReleaseFormFill.ForeColor = System.Drawing.Color.Blue
        Me.btnNighttimePublicHatchlingReleaseFormFill.Location = New System.Drawing.Point(3, 203)
        Me.btnNighttimePublicHatchlingReleaseFormFill.Name = "btnNighttimePublicHatchlingReleaseFormFill"
        Me.btnNighttimePublicHatchlingReleaseFormFill.Size = New System.Drawing.Size(24, 20)
        Me.btnNighttimePublicHatchlingReleaseFormFill.TabIndex = 23
        Me.btnNighttimePublicHatchlingReleaseFormFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnNighttimePublicHatchlingReleaseFormFill, "Print a blank form")
        Me.btnNighttimePublicHatchlingReleaseFormFill.UseVisualStyleBackColor = False
        '
        'btnNecropsyFormFill
        '
        Me.btnNecropsyFormFill.BackColor = System.Drawing.Color.MintCream
        Me.btnNecropsyFormFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNecropsyFormFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNecropsyFormFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNecropsyFormFill.ForeColor = System.Drawing.Color.Blue
        Me.btnNecropsyFormFill.Location = New System.Drawing.Point(3, 179)
        Me.btnNecropsyFormFill.Name = "btnNecropsyFormFill"
        Me.btnNecropsyFormFill.Size = New System.Drawing.Size(24, 20)
        Me.btnNecropsyFormFill.TabIndex = 20
        Me.btnNecropsyFormFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnNecropsyFormFill, "Print a blank form")
        Me.btnNecropsyFormFill.UseVisualStyleBackColor = False
        '
        'btnEducationalPresentationsUsingLiveTurtlesFormFill
        '
        Me.btnEducationalPresentationsUsingLiveTurtlesFormFill.BackColor = System.Drawing.Color.MintCream
        Me.btnEducationalPresentationsUsingLiveTurtlesFormFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEducationalPresentationsUsingLiveTurtlesFormFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEducationalPresentationsUsingLiveTurtlesFormFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEducationalPresentationsUsingLiveTurtlesFormFill.ForeColor = System.Drawing.Color.Blue
        Me.btnEducationalPresentationsUsingLiveTurtlesFormFill.Location = New System.Drawing.Point(3, 155)
        Me.btnEducationalPresentationsUsingLiveTurtlesFormFill.Name = "btnEducationalPresentationsUsingLiveTurtlesFormFill"
        Me.btnEducationalPresentationsUsingLiveTurtlesFormFill.Size = New System.Drawing.Size(24, 20)
        Me.btnEducationalPresentationsUsingLiveTurtlesFormFill.TabIndex = 17
        Me.btnEducationalPresentationsUsingLiveTurtlesFormFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnEducationalPresentationsUsingLiveTurtlesFormFill, "Print a blank form")
        Me.btnEducationalPresentationsUsingLiveTurtlesFormFill.UseVisualStyleBackColor = False
        '
        'btnDisorientationIncidentFormFill
        '
        Me.btnDisorientationIncidentFormFill.BackColor = System.Drawing.Color.MintCream
        Me.btnDisorientationIncidentFormFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDisorientationIncidentFormFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisorientationIncidentFormFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisorientationIncidentFormFill.ForeColor = System.Drawing.Color.Blue
        Me.btnDisorientationIncidentFormFill.Location = New System.Drawing.Point(3, 107)
        Me.btnDisorientationIncidentFormFill.Name = "btnDisorientationIncidentFormFill"
        Me.btnDisorientationIncidentFormFill.Size = New System.Drawing.Size(24, 20)
        Me.btnDisorientationIncidentFormFill.TabIndex = 12
        Me.btnDisorientationIncidentFormFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnDisorientationIncidentFormFill, "Fill out the form")
        Me.btnDisorientationIncidentFormFill.UseVisualStyleBackColor = False
        '
        'btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill
        '
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill.BackColor = System.Drawing.Color.MintCream
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill.ForeColor = System.Drawing.Color.Blue
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill.Location = New System.Drawing.Point(3, 27)
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill.Name = "btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill"
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill.Size = New System.Drawing.Size(24, 20)
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill.TabIndex = 3
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill, "Fill out the form")
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill.UseVisualStyleBackColor = False
        '
        'btnMarineTurtleHoldingFacilityQuarterlyReportFill
        '
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill.BackColor = System.Drawing.Color.MintCream
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill.ForeColor = System.Drawing.Color.Blue
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill.Location = New System.Drawing.Point(3, 3)
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill.Name = "btnMarineTurtleHoldingFacilityQuarterlyReportFill"
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill.Size = New System.Drawing.Size(24, 20)
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill.TabIndex = 0
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill, "Populate the report")
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill.UseVisualStyleBackColor = False
        '
        'btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank
        '
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank.Location = New System.Drawing.Point(27, 27)
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank.Name = "btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank"
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank.TabIndex = 4
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank, "Print a blank form")
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank.UseVisualStyleBackColor = False
        '
        'btnTurtleTransferFormBlank
        '
        Me.btnTurtleTransferFormBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnTurtleTransferFormBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTurtleTransferFormBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTurtleTransferFormBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTurtleTransferFormBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnTurtleTransferFormBlank.Location = New System.Drawing.Point(318, 227)
        Me.btnTurtleTransferFormBlank.Name = "btnTurtleTransferFormBlank"
        Me.btnTurtleTransferFormBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnTurtleTransferFormBlank.TabIndex = 50
        Me.btnTurtleTransferFormBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnTurtleTransferFormBlank, "Print a blank form")
        Me.btnTurtleTransferFormBlank.UseVisualStyleBackColor = False
        '
        'btnTaggingDataFormBlank
        '
        Me.btnTaggingDataFormBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnTaggingDataFormBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTaggingDataFormBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTaggingDataFormBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTaggingDataFormBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnTaggingDataFormBlank.Location = New System.Drawing.Point(318, 203)
        Me.btnTaggingDataFormBlank.Name = "btnTaggingDataFormBlank"
        Me.btnTaggingDataFormBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnTaggingDataFormBlank.TabIndex = 47
        Me.btnTaggingDataFormBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnTaggingDataFormBlank, "Print a blank form")
        Me.btnTaggingDataFormBlank.UseVisualStyleBackColor = False
        '
        'btnTagRequestFormBlank
        '
        Me.btnTagRequestFormBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnTagRequestFormBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnTagRequestFormBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTagRequestFormBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTagRequestFormBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnTagRequestFormBlank.Location = New System.Drawing.Point(318, 179)
        Me.btnTagRequestFormBlank.Name = "btnTagRequestFormBlank"
        Me.btnTagRequestFormBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnTagRequestFormBlank.TabIndex = 44
        Me.btnTagRequestFormBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnTagRequestFormBlank, "Print a blank form")
        Me.btnTagRequestFormBlank.UseVisualStyleBackColor = False
        '
        'btnStrandingAndSalvageFormBlank
        '
        Me.btnStrandingAndSalvageFormBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnStrandingAndSalvageFormBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnStrandingAndSalvageFormBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnStrandingAndSalvageFormBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStrandingAndSalvageFormBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnStrandingAndSalvageFormBlank.Location = New System.Drawing.Point(318, 155)
        Me.btnStrandingAndSalvageFormBlank.Name = "btnStrandingAndSalvageFormBlank"
        Me.btnStrandingAndSalvageFormBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnStrandingAndSalvageFormBlank.TabIndex = 41
        Me.btnStrandingAndSalvageFormBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnStrandingAndSalvageFormBlank, "Print a blank form")
        Me.btnStrandingAndSalvageFormBlank.UseVisualStyleBackColor = False
        '
        'btnPublicTurtleWatchScheduleFormBlank
        '
        Me.btnPublicTurtleWatchScheduleFormBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnPublicTurtleWatchScheduleFormBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPublicTurtleWatchScheduleFormBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPublicTurtleWatchScheduleFormBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPublicTurtleWatchScheduleFormBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnPublicTurtleWatchScheduleFormBlank.Location = New System.Drawing.Point(318, 107)
        Me.btnPublicTurtleWatchScheduleFormBlank.Name = "btnPublicTurtleWatchScheduleFormBlank"
        Me.btnPublicTurtleWatchScheduleFormBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnPublicTurtleWatchScheduleFormBlank.TabIndex = 35
        Me.btnPublicTurtleWatchScheduleFormBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnPublicTurtleWatchScheduleFormBlank, "Print a blank form")
        Me.btnPublicTurtleWatchScheduleFormBlank.UseVisualStyleBackColor = False
        '
        'btnPapillomaFormBlank
        '
        Me.btnPapillomaFormBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnPapillomaFormBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPapillomaFormBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPapillomaFormBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPapillomaFormBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnPapillomaFormBlank.Location = New System.Drawing.Point(318, 83)
        Me.btnPapillomaFormBlank.Name = "btnPapillomaFormBlank"
        Me.btnPapillomaFormBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnPapillomaFormBlank.TabIndex = 32
        Me.btnPapillomaFormBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnPapillomaFormBlank, "Print a blank form")
        Me.btnPapillomaFormBlank.UseVisualStyleBackColor = False
        '
        'btnNighttimePublicHatchlingReleaseFormBlank
        '
        Me.btnNighttimePublicHatchlingReleaseFormBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnNighttimePublicHatchlingReleaseFormBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNighttimePublicHatchlingReleaseFormBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNighttimePublicHatchlingReleaseFormBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNighttimePublicHatchlingReleaseFormBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnNighttimePublicHatchlingReleaseFormBlank.Location = New System.Drawing.Point(27, 203)
        Me.btnNighttimePublicHatchlingReleaseFormBlank.Name = "btnNighttimePublicHatchlingReleaseFormBlank"
        Me.btnNighttimePublicHatchlingReleaseFormBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnNighttimePublicHatchlingReleaseFormBlank.TabIndex = 24
        Me.btnNighttimePublicHatchlingReleaseFormBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnNighttimePublicHatchlingReleaseFormBlank, "Print a blank form")
        Me.btnNighttimePublicHatchlingReleaseFormBlank.UseVisualStyleBackColor = False
        '
        'btnNecropsyFormBlank
        '
        Me.btnNecropsyFormBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnNecropsyFormBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnNecropsyFormBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnNecropsyFormBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNecropsyFormBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnNecropsyFormBlank.Location = New System.Drawing.Point(27, 179)
        Me.btnNecropsyFormBlank.Name = "btnNecropsyFormBlank"
        Me.btnNecropsyFormBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnNecropsyFormBlank.TabIndex = 21
        Me.btnNecropsyFormBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnNecropsyFormBlank, "Print a blank form")
        Me.btnNecropsyFormBlank.UseVisualStyleBackColor = False
        '
        'btnDisorientationIncidentFormBlank
        '
        Me.btnDisorientationIncidentFormBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnDisorientationIncidentFormBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDisorientationIncidentFormBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisorientationIncidentFormBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisorientationIncidentFormBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnDisorientationIncidentFormBlank.Location = New System.Drawing.Point(27, 107)
        Me.btnDisorientationIncidentFormBlank.Name = "btnDisorientationIncidentFormBlank"
        Me.btnDisorientationIncidentFormBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnDisorientationIncidentFormBlank.TabIndex = 13
        Me.btnDisorientationIncidentFormBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnDisorientationIncidentFormBlank, "Print a blank form")
        Me.btnDisorientationIncidentFormBlank.UseVisualStyleBackColor = False
        '
        'btnEducationalPresentationsUsingLiveTurtlesFormBlank
        '
        Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank.Location = New System.Drawing.Point(27, 155)
        Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank.Name = "btnEducationalPresentationsUsingLiveTurtlesFormBlank"
        Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank.TabIndex = 18
        Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank, "Print a blank form")
        Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank.UseVisualStyleBackColor = False
        '
        'btnBeachRestorationProjectMonitoringTableBlank
        '
        Me.btnBeachRestorationProjectMonitoringTableBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnBeachRestorationProjectMonitoringTableBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBeachRestorationProjectMonitoringTableBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBeachRestorationProjectMonitoringTableBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBeachRestorationProjectMonitoringTableBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnBeachRestorationProjectMonitoringTableBlank.Location = New System.Drawing.Point(27, 83)
        Me.btnBeachRestorationProjectMonitoringTableBlank.Name = "btnBeachRestorationProjectMonitoringTableBlank"
        Me.btnBeachRestorationProjectMonitoringTableBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnBeachRestorationProjectMonitoringTableBlank.TabIndex = 10
        Me.btnBeachRestorationProjectMonitoringTableBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnBeachRestorationProjectMonitoringTableBlank, "Print a blank form")
        Me.btnBeachRestorationProjectMonitoringTableBlank.UseVisualStyleBackColor = False
        '
        'btnMarineTurtleHoldingFacilityQuarterlyReportBlank
        '
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank.Location = New System.Drawing.Point(27, 3)
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank.Name = "btnMarineTurtleHoldingFacilityQuarterlyReportBlank"
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank.TabIndex = 1
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank, "Print a blank form")
        Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank.UseVisualStyleBackColor = False
        '
        'btnPublicTurtleWatchSummaryFormFill
        '
        Me.btnPublicTurtleWatchSummaryFormFill.BackColor = System.Drawing.Color.MintCream
        Me.btnPublicTurtleWatchSummaryFormFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPublicTurtleWatchSummaryFormFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPublicTurtleWatchSummaryFormFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPublicTurtleWatchSummaryFormFill.ForeColor = System.Drawing.Color.Blue
        Me.btnPublicTurtleWatchSummaryFormFill.Location = New System.Drawing.Point(294, 131)
        Me.btnPublicTurtleWatchSummaryFormFill.Name = "btnPublicTurtleWatchSummaryFormFill"
        Me.btnPublicTurtleWatchSummaryFormFill.Size = New System.Drawing.Size(24, 20)
        Me.btnPublicTurtleWatchSummaryFormFill.TabIndex = 37
        Me.btnPublicTurtleWatchSummaryFormFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnPublicTurtleWatchSummaryFormFill, "Fill out the form")
        Me.btnPublicTurtleWatchSummaryFormFill.UseVisualStyleBackColor = False
        '
        'btnPublicTurtleWatchSummaryFormBlank
        '
        Me.btnPublicTurtleWatchSummaryFormBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnPublicTurtleWatchSummaryFormBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnPublicTurtleWatchSummaryFormBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnPublicTurtleWatchSummaryFormBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPublicTurtleWatchSummaryFormBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnPublicTurtleWatchSummaryFormBlank.Location = New System.Drawing.Point(318, 131)
        Me.btnPublicTurtleWatchSummaryFormBlank.Name = "btnPublicTurtleWatchSummaryFormBlank"
        Me.btnPublicTurtleWatchSummaryFormBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnPublicTurtleWatchSummaryFormBlank.TabIndex = 38
        Me.btnPublicTurtleWatchSummaryFormBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnPublicTurtleWatchSummaryFormBlank, "Print a blank form")
        Me.btnPublicTurtleWatchSummaryFormBlank.UseVisualStyleBackColor = False
        '
        'btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill
        '
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill.BackColor = System.Drawing.Color.MintCream
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill.ForeColor = System.Drawing.Color.Blue
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill.Location = New System.Drawing.Point(3, 51)
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill.Name = "btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill"
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill.Size = New System.Drawing.Size(24, 20)
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill.TabIndex = 6
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill, "Fill out the form")
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill.UseVisualStyleBackColor = False
        '
        'btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank
        '
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank.Location = New System.Drawing.Point(27, 51)
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank.Name = "btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank"
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank.TabIndex = 7
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank, "Print a blank form")
        Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank.UseVisualStyleBackColor = False
        '
        'btnDisorientationIncidentFormDirectionsBlank
        '
        Me.btnDisorientationIncidentFormDirectionsBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnDisorientationIncidentFormDirectionsBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnDisorientationIncidentFormDirectionsBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDisorientationIncidentFormDirectionsBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDisorientationIncidentFormDirectionsBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnDisorientationIncidentFormDirectionsBlank.Location = New System.Drawing.Point(27, 131)
        Me.btnDisorientationIncidentFormDirectionsBlank.Name = "btnDisorientationIncidentFormDirectionsBlank"
        Me.btnDisorientationIncidentFormDirectionsBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnDisorientationIncidentFormDirectionsBlank.TabIndex = 15
        Me.btnDisorientationIncidentFormDirectionsBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnDisorientationIncidentFormDirectionsBlank, "Print a blank form")
        Me.btnDisorientationIncidentFormDirectionsBlank.UseVisualStyleBackColor = False
        '
        'btnObstructedNestingAttemptFormDirectionsBlank
        '
        Me.btnObstructedNestingAttemptFormDirectionsBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnObstructedNestingAttemptFormDirectionsBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnObstructedNestingAttemptFormDirectionsBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnObstructedNestingAttemptFormDirectionsBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObstructedNestingAttemptFormDirectionsBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnObstructedNestingAttemptFormDirectionsBlank.Location = New System.Drawing.Point(27, 251)
        Me.btnObstructedNestingAttemptFormDirectionsBlank.Name = "btnObstructedNestingAttemptFormDirectionsBlank"
        Me.btnObstructedNestingAttemptFormDirectionsBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnObstructedNestingAttemptFormDirectionsBlank.TabIndex = 29
        Me.btnObstructedNestingAttemptFormDirectionsBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnObstructedNestingAttemptFormDirectionsBlank, "Print a blank form")
        Me.btnObstructedNestingAttemptFormDirectionsBlank.UseVisualStyleBackColor = False
        '
        'btnObstructedNestingAttemptFormFill
        '
        Me.btnObstructedNestingAttemptFormFill.BackColor = System.Drawing.Color.MintCream
        Me.btnObstructedNestingAttemptFormFill.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnObstructedNestingAttemptFormFill.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnObstructedNestingAttemptFormFill.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObstructedNestingAttemptFormFill.ForeColor = System.Drawing.Color.Blue
        Me.btnObstructedNestingAttemptFormFill.Location = New System.Drawing.Point(3, 227)
        Me.btnObstructedNestingAttemptFormFill.Name = "btnObstructedNestingAttemptFormFill"
        Me.btnObstructedNestingAttemptFormFill.Size = New System.Drawing.Size(24, 20)
        Me.btnObstructedNestingAttemptFormFill.TabIndex = 26
        Me.btnObstructedNestingAttemptFormFill.Text = "fill"
        Me.tipToolTip.SetToolTip(Me.btnObstructedNestingAttemptFormFill, "Fill out the form")
        Me.btnObstructedNestingAttemptFormFill.UseVisualStyleBackColor = False
        '
        'btnObstructedNestingAttemptFormBlank
        '
        Me.btnObstructedNestingAttemptFormBlank.BackColor = System.Drawing.Color.MintCream
        Me.btnObstructedNestingAttemptFormBlank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnObstructedNestingAttemptFormBlank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnObstructedNestingAttemptFormBlank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnObstructedNestingAttemptFormBlank.ForeColor = System.Drawing.Color.Blue
        Me.btnObstructedNestingAttemptFormBlank.Location = New System.Drawing.Point(27, 227)
        Me.btnObstructedNestingAttemptFormBlank.Name = "btnObstructedNestingAttemptFormBlank"
        Me.btnObstructedNestingAttemptFormBlank.Size = New System.Drawing.Size(42, 20)
        Me.btnObstructedNestingAttemptFormBlank.TabIndex = 27
        Me.btnObstructedNestingAttemptFormBlank.Text = "blank"
        Me.tipToolTip.SetToolTip(Me.btnObstructedNestingAttemptFormBlank, "Print a blank form")
        Me.btnObstructedNestingAttemptFormBlank.UseVisualStyleBackColor = False
        '
        'erpErrorProvider
        '
        Me.erpErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.erpErrorProvider.ContainerControl = Me
        '
        'tabMainFormTab
        '
        Me.tabMainFormTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMainFormTab.Controls.Add(Me.tpgTurtles)
        Me.tabMainFormTab.Controls.Add(Me.tpgTanks)
        Me.tabMainFormTab.Controls.Add(Me.tpgHatchlingsEvents)
        Me.tabMainFormTab.Controls.Add(Me.tpgWashbacksEvents)
        Me.tabMainFormTab.Location = New System.Drawing.Point(8, 354)
        Me.tabMainFormTab.Name = "tabMainFormTab"
        Me.tabMainFormTab.SelectedIndex = 0
        Me.tabMainFormTab.Size = New System.Drawing.Size(1000, 202)
        Me.tabMainFormTab.TabIndex = 3
        '
        'tpgTurtles
        '
        Me.tpgTurtles.Controls.Add(Me.grdTurtleGrid)
        Me.tpgTurtles.Controls.Add(Me.picMoreInfoFiltering)
        Me.tpgTurtles.Controls.Add(Me.btnRefresh)
        Me.tpgTurtles.Controls.Add(Me.txtFilterByValue)
        Me.tpgTurtles.Controls.Add(Me.cboFilterByList)
        Me.tpgTurtles.Controls.Add(Me.btnAddTurtle)
        Me.tpgTurtles.Controls.Add(Me.chkShowInactiveTurtles)
        Me.tpgTurtles.Location = New System.Drawing.Point(4, 22)
        Me.tpgTurtles.Name = "tpgTurtles"
        Me.tpgTurtles.Size = New System.Drawing.Size(992, 176)
        Me.tpgTurtles.TabIndex = 0
        Me.tpgTurtles.Text = "Sea Turtles"
        Me.tpgTurtles.UseVisualStyleBackColor = True
        '
        'grdTurtleGrid
        '
        Me.grdTurtleGrid.AllowUserToAddRows = False
        Me.grdTurtleGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTurtleGrid.AutoGenerateColumns = False
        Me.grdTurtleGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTurtleEditActionDataGridViewLinkColumn, Me.colTurtleDeleteActionDataGridViewLinkColumn, Me.colTurtleTurtleIDDataGridViewTextBoxColumn, Me.colTurtleTurtleNameDataGridViewTextBoxColumn, Me.colTurtleSidNumberDataGridViewTextBoxColumn, Me.colTurtleSpeciesDataGridViewTextBoxColumn, Me.colTurtleDateAcquiredBindableDataGridViewTextBoxColumn, Me.colTurtleAcquiredFromDataGridViewTextBoxColumn, Me.colTurtleAcquiredCountyDataGridViewTextBoxColumn, Me.colTurtleTurtleSizeDataGridViewTextBoxColumn, Me.colTurtleStatusDataGridViewTextBoxColumn, Me.colDateRelinquishedBindableDataGridViewTextBoxColumn, Me.colTurtleRelinquishedToDataGridViewTextBoxColumn, Me.colTurtleTagNumberListStringDataGridViewTextBoxColumn})
        Me.grdTurtleGrid.DataSource = Me.TurtleGridBindingSource
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdTurtleGrid.DefaultCellStyle = DataGridViewCellStyle3
        Me.grdTurtleGrid.Location = New System.Drawing.Point(8, 20)
        Me.grdTurtleGrid.MultiSelect = False
        Me.grdTurtleGrid.Name = "grdTurtleGrid"
        Me.grdTurtleGrid.ReadOnly = True
        Me.grdTurtleGrid.RowHeadersVisible = False
        Me.grdTurtleGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTurtleGrid.Size = New System.Drawing.Size(976, 150)
        Me.grdTurtleGrid.TabIndex = 5
        '
        'colTurtleDateAcquiredBindableDataGridViewTextBoxColumn
        '
        Me.colTurtleDateAcquiredBindableDataGridViewTextBoxColumn.DataPropertyName = "DateAcquiredBindable"
        DataGridViewCellStyle1.Format = "d"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.colTurtleDateAcquiredBindableDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle1
        Me.colTurtleDateAcquiredBindableDataGridViewTextBoxColumn.HeaderText = "Date Acquired"
        Me.colTurtleDateAcquiredBindableDataGridViewTextBoxColumn.Name = "colTurtleDateAcquiredBindableDataGridViewTextBoxColumn"
        Me.colTurtleDateAcquiredBindableDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleDateAcquiredBindableDataGridViewTextBoxColumn.Width = 104
        '
        'colTurtleAcquiredCountyDataGridViewTextBoxColumn
        '
        Me.colTurtleAcquiredCountyDataGridViewTextBoxColumn.DataPropertyName = "AcquiredCounty"
        Me.colTurtleAcquiredCountyDataGridViewTextBoxColumn.HeaderText = "County"
        Me.colTurtleAcquiredCountyDataGridViewTextBoxColumn.Name = "colTurtleAcquiredCountyDataGridViewTextBoxColumn"
        Me.colTurtleAcquiredCountyDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colDateRelinquishedBindableDataGridViewTextBoxColumn
        '
        Me.colDateRelinquishedBindableDataGridViewTextBoxColumn.DataPropertyName = "DateRelinquishedBindable"
        DataGridViewCellStyle2.Format = "MM/dd/yyy"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.colDateRelinquishedBindableDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle2
        Me.colDateRelinquishedBindableDataGridViewTextBoxColumn.HeaderText = "Date Relinquished"
        Me.colDateRelinquishedBindableDataGridViewTextBoxColumn.Name = "colDateRelinquishedBindableDataGridViewTextBoxColumn"
        Me.colDateRelinquishedBindableDataGridViewTextBoxColumn.ReadOnly = True
        Me.colDateRelinquishedBindableDataGridViewTextBoxColumn.Width = 116
        '
        'colTurtleTagNumberListStringDataGridViewTextBoxColumn
        '
        Me.colTurtleTagNumberListStringDataGridViewTextBoxColumn.DataPropertyName = "TagNumberListString"
        Me.colTurtleTagNumberListStringDataGridViewTextBoxColumn.HeaderText = "Tag Numbers"
        Me.colTurtleTagNumberListStringDataGridViewTextBoxColumn.Name = "colTurtleTagNumberListStringDataGridViewTextBoxColumn"
        Me.colTurtleTagNumberListStringDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleTagNumberListStringDataGridViewTextBoxColumn.Width = 200
        '
        'btnRefresh
        '
        Me.btnRefresh.BackColor = System.Drawing.Color.MintCream
        Me.btnRefresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRefresh.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.ForeColor = System.Drawing.Color.Blue
        Me.btnRefresh.Location = New System.Drawing.Point(540, 0)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(68, 20)
        Me.btnRefresh.TabIndex = 3
        Me.btnRefresh.Text = "refresh"
        Me.btnRefresh.UseVisualStyleBackColor = False
        '
        'txtFilterByValue
        '
        Me.txtFilterByValue.Location = New System.Drawing.Point(420, 0)
        Me.txtFilterByValue.Name = "txtFilterByValue"
        Me.txtFilterByValue.Size = New System.Drawing.Size(120, 20)
        Me.txtFilterByValue.TabIndex = 2
        '
        'cboFilterByList
        '
        Me.cboFilterByList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboFilterByList.Location = New System.Drawing.Point(276, -1)
        Me.cboFilterByList.Name = "cboFilterByList"
        Me.cboFilterByList.Size = New System.Drawing.Size(144, 21)
        Me.cboFilterByList.TabIndex = 1
        '
        'btnAddTurtle
        '
        Me.btnAddTurtle.BackColor = System.Drawing.Color.MintCream
        Me.btnAddTurtle.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTurtle.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddTurtle.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTurtle.ForeColor = System.Drawing.Color.Blue
        Me.btnAddTurtle.Location = New System.Drawing.Point(8, 0)
        Me.btnAddTurtle.Name = "btnAddTurtle"
        Me.btnAddTurtle.Size = New System.Drawing.Size(38, 20)
        Me.btnAddTurtle.TabIndex = 0
        Me.btnAddTurtle.Text = "add"
        Me.btnAddTurtle.UseVisualStyleBackColor = False
        '
        'tpgTanks
        '
        Me.tpgTanks.Controls.Add(Me.grdTankGrid)
        Me.tpgTanks.Controls.Add(Me.btnAddTank)
        Me.tpgTanks.Location = New System.Drawing.Point(4, 22)
        Me.tpgTanks.Name = "tpgTanks"
        Me.tpgTanks.Size = New System.Drawing.Size(992, 196)
        Me.tpgTanks.TabIndex = 1
        Me.tpgTanks.Text = "Holding Tanks"
        Me.tpgTanks.UseVisualStyleBackColor = True
        '
        'grdTankGrid
        '
        Me.grdTankGrid.AllowUserToAddRows = False
        Me.grdTankGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTankGrid.AutoGenerateColumns = False
        Me.grdTankGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdTankGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTankEditActionDataGridViewLinkColumn, Me.colTankDeleteActionDataGridViewLinkColumn, Me.colTankTankIDDataGridViewTextBoxColumn, Me.colTankTankNameDataGridViewTextBoxColumn})
        Me.grdTankGrid.DataSource = Me.TankGridBindingSource
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdTankGrid.DefaultCellStyle = DataGridViewCellStyle4
        Me.grdTankGrid.Location = New System.Drawing.Point(8, 20)
        Me.grdTankGrid.MultiSelect = False
        Me.grdTankGrid.Name = "grdTankGrid"
        Me.grdTankGrid.ReadOnly = True
        Me.grdTankGrid.RowHeadersVisible = False
        Me.grdTankGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTankGrid.Size = New System.Drawing.Size(976, 170)
        Me.grdTankGrid.TabIndex = 1
        '
        'colTankEditActionDataGridViewLinkColumn
        '
        Me.colTankEditActionDataGridViewLinkColumn.DataPropertyName = "EditAction"
        Me.colTankEditActionDataGridViewLinkColumn.Frozen = True
        Me.colTankEditActionDataGridViewLinkColumn.HeaderText = ""
        Me.colTankEditActionDataGridViewLinkColumn.Name = "colTankEditActionDataGridViewLinkColumn"
        Me.colTankEditActionDataGridViewLinkColumn.ReadOnly = True
        Me.colTankEditActionDataGridViewLinkColumn.Width = 28
        '
        'colTankDeleteActionDataGridViewLinkColumn
        '
        Me.colTankDeleteActionDataGridViewLinkColumn.DataPropertyName = "DeleteAction"
        Me.colTankDeleteActionDataGridViewLinkColumn.Frozen = True
        Me.colTankDeleteActionDataGridViewLinkColumn.HeaderText = ""
        Me.colTankDeleteActionDataGridViewLinkColumn.Name = "colTankDeleteActionDataGridViewLinkColumn"
        Me.colTankDeleteActionDataGridViewLinkColumn.ReadOnly = True
        Me.colTankDeleteActionDataGridViewLinkColumn.Width = 40
        '
        'btnAddTank
        '
        Me.btnAddTank.BackColor = System.Drawing.Color.MintCream
        Me.btnAddTank.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTank.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddTank.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTank.ForeColor = System.Drawing.Color.Blue
        Me.btnAddTank.Location = New System.Drawing.Point(8, 0)
        Me.btnAddTank.Name = "btnAddTank"
        Me.btnAddTank.Size = New System.Drawing.Size(38, 20)
        Me.btnAddTank.TabIndex = 0
        Me.btnAddTank.Text = "add"
        Me.btnAddTank.UseVisualStyleBackColor = False
        '
        'tpgHatchlingsEvents
        '
        Me.tpgHatchlingsEvents.Controls.Add(Me.btnAddHatchlingsDoaEvent)
        Me.tpgHatchlingsEvents.Controls.Add(Me.btnAddHatchlingsReleasedEvent)
        Me.tpgHatchlingsEvents.Controls.Add(Me.btnAddHatchlingsDiedEvent)
        Me.tpgHatchlingsEvents.Controls.Add(Me.grdHatchlingsEventGrid)
        Me.tpgHatchlingsEvents.Controls.Add(Me.btnAddHatchlingsAcquiredEvent)
        Me.tpgHatchlingsEvents.Location = New System.Drawing.Point(4, 22)
        Me.tpgHatchlingsEvents.Name = "tpgHatchlingsEvents"
        Me.tpgHatchlingsEvents.Size = New System.Drawing.Size(992, 196)
        Me.tpgHatchlingsEvents.TabIndex = 2
        Me.tpgHatchlingsEvents.Text = "Hatchlings"
        Me.tpgHatchlingsEvents.UseVisualStyleBackColor = True
        '
        'btnAddHatchlingsDoaEvent
        '
        Me.btnAddHatchlingsDoaEvent.BackColor = System.Drawing.Color.MintCream
        Me.btnAddHatchlingsDoaEvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddHatchlingsDoaEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddHatchlingsDoaEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHatchlingsDoaEvent.ForeColor = System.Drawing.Color.Blue
        Me.btnAddHatchlingsDoaEvent.Location = New System.Drawing.Point(566, 0)
        Me.btnAddHatchlingsDoaEvent.Name = "btnAddHatchlingsDoaEvent"
        Me.btnAddHatchlingsDoaEvent.Size = New System.Drawing.Size(180, 20)
        Me.btnAddHatchlingsDoaEvent.TabIndex = 3
        Me.btnAddHatchlingsDoaEvent.Text = "add ""hatchlings DOA"" event"
        Me.btnAddHatchlingsDoaEvent.UseVisualStyleBackColor = False
        '
        'btnAddHatchlingsReleasedEvent
        '
        Me.btnAddHatchlingsReleasedEvent.BackColor = System.Drawing.Color.MintCream
        Me.btnAddHatchlingsReleasedEvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddHatchlingsReleasedEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddHatchlingsReleasedEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHatchlingsReleasedEvent.ForeColor = System.Drawing.Color.Blue
        Me.btnAddHatchlingsReleasedEvent.Location = New System.Drawing.Point(380, 0)
        Me.btnAddHatchlingsReleasedEvent.Name = "btnAddHatchlingsReleasedEvent"
        Me.btnAddHatchlingsReleasedEvent.Size = New System.Drawing.Size(180, 20)
        Me.btnAddHatchlingsReleasedEvent.TabIndex = 2
        Me.btnAddHatchlingsReleasedEvent.Text = "add ""hatchlings released"" event"
        Me.btnAddHatchlingsReleasedEvent.UseVisualStyleBackColor = False
        '
        'btnAddHatchlingsDiedEvent
        '
        Me.btnAddHatchlingsDiedEvent.BackColor = System.Drawing.Color.MintCream
        Me.btnAddHatchlingsDiedEvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddHatchlingsDiedEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddHatchlingsDiedEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHatchlingsDiedEvent.ForeColor = System.Drawing.Color.Blue
        Me.btnAddHatchlingsDiedEvent.Location = New System.Drawing.Point(194, 0)
        Me.btnAddHatchlingsDiedEvent.Name = "btnAddHatchlingsDiedEvent"
        Me.btnAddHatchlingsDiedEvent.Size = New System.Drawing.Size(180, 20)
        Me.btnAddHatchlingsDiedEvent.TabIndex = 1
        Me.btnAddHatchlingsDiedEvent.Text = "add ""hatchlings died"" event"
        Me.btnAddHatchlingsDiedEvent.UseVisualStyleBackColor = False
        '
        'grdHatchlingsEventGrid
        '
        Me.grdHatchlingsEventGrid.AllowUserToAddRows = False
        Me.grdHatchlingsEventGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdHatchlingsEventGrid.AutoGenerateColumns = False
        Me.grdHatchlingsEventGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdHatchlingsEventGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colHatchlingsEventEditActionDataGridViewLinkColumn, Me.colHatchlingsEventDeleteActionDataGridViewLinkColumn, Me.colHatchlingsEventEventIDDataGridViewTextBoxColumn, Me.colHatchlingsEventSpeciesDescriptionDataGridViewTextBoxColumn, Me.colHatchlingsEventEventTypeDataGridViewTextBoxColumn, Me.colHatchlingsEventEventDateBindableDataGridViewTextBoxColumn, Me.colHatchlingsEventEventCountDataGridViewTextBoxColumn, Me.colHatchlingsEventCountyNameDataGridViewTextBoxColumn})
        Me.grdHatchlingsEventGrid.DataSource = Me.HatchlingsEventGridBindingSource
        DataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle6.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdHatchlingsEventGrid.DefaultCellStyle = DataGridViewCellStyle6
        Me.grdHatchlingsEventGrid.Location = New System.Drawing.Point(8, 20)
        Me.grdHatchlingsEventGrid.MultiSelect = False
        Me.grdHatchlingsEventGrid.Name = "grdHatchlingsEventGrid"
        Me.grdHatchlingsEventGrid.ReadOnly = True
        Me.grdHatchlingsEventGrid.RowHeadersVisible = False
        Me.grdHatchlingsEventGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdHatchlingsEventGrid.Size = New System.Drawing.Size(976, 170)
        Me.grdHatchlingsEventGrid.TabIndex = 4
        '
        'colHatchlingsEventEditActionDataGridViewLinkColumn
        '
        Me.colHatchlingsEventEditActionDataGridViewLinkColumn.DataPropertyName = "EditAction"
        Me.colHatchlingsEventEditActionDataGridViewLinkColumn.Frozen = True
        Me.colHatchlingsEventEditActionDataGridViewLinkColumn.HeaderText = ""
        Me.colHatchlingsEventEditActionDataGridViewLinkColumn.Name = "colHatchlingsEventEditActionDataGridViewLinkColumn"
        Me.colHatchlingsEventEditActionDataGridViewLinkColumn.ReadOnly = True
        Me.colHatchlingsEventEditActionDataGridViewLinkColumn.Width = 28
        '
        'colHatchlingsEventDeleteActionDataGridViewLinkColumn
        '
        Me.colHatchlingsEventDeleteActionDataGridViewLinkColumn.DataPropertyName = "DeleteAction"
        Me.colHatchlingsEventDeleteActionDataGridViewLinkColumn.Frozen = True
        Me.colHatchlingsEventDeleteActionDataGridViewLinkColumn.HeaderText = ""
        Me.colHatchlingsEventDeleteActionDataGridViewLinkColumn.Name = "colHatchlingsEventDeleteActionDataGridViewLinkColumn"
        Me.colHatchlingsEventDeleteActionDataGridViewLinkColumn.ReadOnly = True
        Me.colHatchlingsEventDeleteActionDataGridViewLinkColumn.Width = 40
        '
        'colHatchlingsEventEventIDDataGridViewTextBoxColumn
        '
        Me.colHatchlingsEventEventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID"
        Me.colHatchlingsEventEventIDDataGridViewTextBoxColumn.Frozen = True
        Me.colHatchlingsEventEventIDDataGridViewTextBoxColumn.HeaderText = "EventID"
        Me.colHatchlingsEventEventIDDataGridViewTextBoxColumn.Name = "colHatchlingsEventEventIDDataGridViewTextBoxColumn"
        Me.colHatchlingsEventEventIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.colHatchlingsEventEventIDDataGridViewTextBoxColumn.Visible = False
        '
        'colHatchlingsEventSpeciesDescriptionDataGridViewTextBoxColumn
        '
        Me.colHatchlingsEventSpeciesDescriptionDataGridViewTextBoxColumn.DataPropertyName = "SpeciesDescription"
        Me.colHatchlingsEventSpeciesDescriptionDataGridViewTextBoxColumn.HeaderText = "Species"
        Me.colHatchlingsEventSpeciesDescriptionDataGridViewTextBoxColumn.Name = "colHatchlingsEventSpeciesDescriptionDataGridViewTextBoxColumn"
        Me.colHatchlingsEventSpeciesDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.colHatchlingsEventSpeciesDescriptionDataGridViewTextBoxColumn.Width = 250
        '
        'colHatchlingsEventEventTypeDataGridViewTextBoxColumn
        '
        Me.colHatchlingsEventEventTypeDataGridViewTextBoxColumn.DataPropertyName = "EventType"
        Me.colHatchlingsEventEventTypeDataGridViewTextBoxColumn.HeaderText = "Event Type"
        Me.colHatchlingsEventEventTypeDataGridViewTextBoxColumn.Name = "colHatchlingsEventEventTypeDataGridViewTextBoxColumn"
        Me.colHatchlingsEventEventTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colHatchlingsEventEventDateBindableDataGridViewTextBoxColumn
        '
        Me.colHatchlingsEventEventDateBindableDataGridViewTextBoxColumn.DataPropertyName = "EventDateBindable"
        DataGridViewCellStyle5.Format = "d"
        DataGridViewCellStyle5.NullValue = Nothing
        Me.colHatchlingsEventEventDateBindableDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle5
        Me.colHatchlingsEventEventDateBindableDataGridViewTextBoxColumn.HeaderText = "Event Date"
        Me.colHatchlingsEventEventDateBindableDataGridViewTextBoxColumn.Name = "colHatchlingsEventEventDateBindableDataGridViewTextBoxColumn"
        Me.colHatchlingsEventEventDateBindableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colHatchlingsEventCountyNameDataGridViewTextBoxColumn
        '
        Me.colHatchlingsEventCountyNameDataGridViewTextBoxColumn.DataPropertyName = "CountyName"
        Me.colHatchlingsEventCountyNameDataGridViewTextBoxColumn.HeaderText = "County"
        Me.colHatchlingsEventCountyNameDataGridViewTextBoxColumn.Name = "colHatchlingsEventCountyNameDataGridViewTextBoxColumn"
        Me.colHatchlingsEventCountyNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.colHatchlingsEventCountyNameDataGridViewTextBoxColumn.Width = 150
        '
        'btnAddHatchlingsAcquiredEvent
        '
        Me.btnAddHatchlingsAcquiredEvent.BackColor = System.Drawing.Color.MintCream
        Me.btnAddHatchlingsAcquiredEvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddHatchlingsAcquiredEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddHatchlingsAcquiredEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddHatchlingsAcquiredEvent.ForeColor = System.Drawing.Color.Blue
        Me.btnAddHatchlingsAcquiredEvent.Location = New System.Drawing.Point(8, 0)
        Me.btnAddHatchlingsAcquiredEvent.Name = "btnAddHatchlingsAcquiredEvent"
        Me.btnAddHatchlingsAcquiredEvent.Size = New System.Drawing.Size(180, 20)
        Me.btnAddHatchlingsAcquiredEvent.TabIndex = 0
        Me.btnAddHatchlingsAcquiredEvent.Text = "add ""hatchlings acquired"" event"
        Me.btnAddHatchlingsAcquiredEvent.UseVisualStyleBackColor = False
        '
        'tpgWashbacksEvents
        '
        Me.tpgWashbacksEvents.Controls.Add(Me.btnAddWashbacksDoaEvent)
        Me.tpgWashbacksEvents.Controls.Add(Me.btnAddWashbacksReleasedEvent)
        Me.tpgWashbacksEvents.Controls.Add(Me.btnAddWashbacksDiedEvent)
        Me.tpgWashbacksEvents.Controls.Add(Me.grdWashbacksEventGrid)
        Me.tpgWashbacksEvents.Controls.Add(Me.btnAddWashbacksAcquiredEvent)
        Me.tpgWashbacksEvents.Location = New System.Drawing.Point(4, 22)
        Me.tpgWashbacksEvents.Name = "tpgWashbacksEvents"
        Me.tpgWashbacksEvents.Size = New System.Drawing.Size(992, 196)
        Me.tpgWashbacksEvents.TabIndex = 3
        Me.tpgWashbacksEvents.Text = "Washbacks"
        Me.tpgWashbacksEvents.UseVisualStyleBackColor = True
        '
        'btnAddWashbacksDoaEvent
        '
        Me.btnAddWashbacksDoaEvent.BackColor = System.Drawing.Color.MintCream
        Me.btnAddWashbacksDoaEvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddWashbacksDoaEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddWashbacksDoaEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddWashbacksDoaEvent.ForeColor = System.Drawing.Color.Blue
        Me.btnAddWashbacksDoaEvent.Location = New System.Drawing.Point(566, 0)
        Me.btnAddWashbacksDoaEvent.Name = "btnAddWashbacksDoaEvent"
        Me.btnAddWashbacksDoaEvent.Size = New System.Drawing.Size(180, 20)
        Me.btnAddWashbacksDoaEvent.TabIndex = 3
        Me.btnAddWashbacksDoaEvent.Text = "add ""washbacks DOA"" event"
        Me.btnAddWashbacksDoaEvent.UseVisualStyleBackColor = False
        '
        'btnAddWashbacksReleasedEvent
        '
        Me.btnAddWashbacksReleasedEvent.BackColor = System.Drawing.Color.MintCream
        Me.btnAddWashbacksReleasedEvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddWashbacksReleasedEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddWashbacksReleasedEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddWashbacksReleasedEvent.ForeColor = System.Drawing.Color.Blue
        Me.btnAddWashbacksReleasedEvent.Location = New System.Drawing.Point(380, 0)
        Me.btnAddWashbacksReleasedEvent.Name = "btnAddWashbacksReleasedEvent"
        Me.btnAddWashbacksReleasedEvent.Size = New System.Drawing.Size(180, 20)
        Me.btnAddWashbacksReleasedEvent.TabIndex = 2
        Me.btnAddWashbacksReleasedEvent.Text = "add ""washbacks released"" event"
        Me.btnAddWashbacksReleasedEvent.UseVisualStyleBackColor = False
        '
        'btnAddWashbacksDiedEvent
        '
        Me.btnAddWashbacksDiedEvent.BackColor = System.Drawing.Color.MintCream
        Me.btnAddWashbacksDiedEvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddWashbacksDiedEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddWashbacksDiedEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddWashbacksDiedEvent.ForeColor = System.Drawing.Color.Blue
        Me.btnAddWashbacksDiedEvent.Location = New System.Drawing.Point(194, 0)
        Me.btnAddWashbacksDiedEvent.Name = "btnAddWashbacksDiedEvent"
        Me.btnAddWashbacksDiedEvent.Size = New System.Drawing.Size(180, 20)
        Me.btnAddWashbacksDiedEvent.TabIndex = 1
        Me.btnAddWashbacksDiedEvent.Text = "add ""washbacks died"" event"
        Me.btnAddWashbacksDiedEvent.UseVisualStyleBackColor = False
        '
        'grdWashbacksEventGrid
        '
        Me.grdWashbacksEventGrid.AllowUserToAddRows = False
        Me.grdWashbacksEventGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdWashbacksEventGrid.AutoGenerateColumns = False
        Me.grdWashbacksEventGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdWashbacksEventGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colWashbacksEventEditActionDataGridViewLinkColumn, Me.colWashbacksEventDeleteActionDataGridViewLinkColumn, Me.colWashbacksEventEventIDDataGridViewTextBoxColumn, Me.colWashbacksEventSpeciesDescriptionDataGridViewTextBoxColumn, Me.colWashbacksEventEventTypeDataGridViewTextBoxColumn, Me.colWashbacksEventEventDateBindableDataGridViewTextBoxColumn, Me.colWashbacksEventEventCountDataGridViewTextBoxColumn, Me.colWashbacksEventCountyNameDataGridViewTextBoxColumn, Me.colWashbacksEventUnder5CmClslDataGridViewTextBoxColumn})
        Me.grdWashbacksEventGrid.DataSource = Me.WashbacksEventGridBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdWashbacksEventGrid.DefaultCellStyle = DataGridViewCellStyle8
        Me.grdWashbacksEventGrid.Location = New System.Drawing.Point(8, 20)
        Me.grdWashbacksEventGrid.MultiSelect = False
        Me.grdWashbacksEventGrid.Name = "grdWashbacksEventGrid"
        Me.grdWashbacksEventGrid.ReadOnly = True
        Me.grdWashbacksEventGrid.RowHeadersVisible = False
        Me.grdWashbacksEventGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdWashbacksEventGrid.Size = New System.Drawing.Size(976, 170)
        Me.grdWashbacksEventGrid.TabIndex = 4
        '
        'colWashbacksEventEditActionDataGridViewLinkColumn
        '
        Me.colWashbacksEventEditActionDataGridViewLinkColumn.DataPropertyName = "EditAction"
        Me.colWashbacksEventEditActionDataGridViewLinkColumn.Frozen = True
        Me.colWashbacksEventEditActionDataGridViewLinkColumn.HeaderText = ""
        Me.colWashbacksEventEditActionDataGridViewLinkColumn.Name = "colWashbacksEventEditActionDataGridViewLinkColumn"
        Me.colWashbacksEventEditActionDataGridViewLinkColumn.ReadOnly = True
        Me.colWashbacksEventEditActionDataGridViewLinkColumn.Width = 28
        '
        'colWashbacksEventDeleteActionDataGridViewLinkColumn
        '
        Me.colWashbacksEventDeleteActionDataGridViewLinkColumn.DataPropertyName = "DeleteAction"
        Me.colWashbacksEventDeleteActionDataGridViewLinkColumn.Frozen = True
        Me.colWashbacksEventDeleteActionDataGridViewLinkColumn.HeaderText = ""
        Me.colWashbacksEventDeleteActionDataGridViewLinkColumn.Name = "colWashbacksEventDeleteActionDataGridViewLinkColumn"
        Me.colWashbacksEventDeleteActionDataGridViewLinkColumn.ReadOnly = True
        Me.colWashbacksEventDeleteActionDataGridViewLinkColumn.Width = 40
        '
        'colWashbacksEventEventIDDataGridViewTextBoxColumn
        '
        Me.colWashbacksEventEventIDDataGridViewTextBoxColumn.DataPropertyName = "EventID"
        Me.colWashbacksEventEventIDDataGridViewTextBoxColumn.Frozen = True
        Me.colWashbacksEventEventIDDataGridViewTextBoxColumn.HeaderText = "EventID"
        Me.colWashbacksEventEventIDDataGridViewTextBoxColumn.Name = "colWashbacksEventEventIDDataGridViewTextBoxColumn"
        Me.colWashbacksEventEventIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.colWashbacksEventEventIDDataGridViewTextBoxColumn.Visible = False
        '
        'colWashbacksEventSpeciesDescriptionDataGridViewTextBoxColumn
        '
        Me.colWashbacksEventSpeciesDescriptionDataGridViewTextBoxColumn.DataPropertyName = "SpeciesDescription"
        Me.colWashbacksEventSpeciesDescriptionDataGridViewTextBoxColumn.HeaderText = "Species"
        Me.colWashbacksEventSpeciesDescriptionDataGridViewTextBoxColumn.Name = "colWashbacksEventSpeciesDescriptionDataGridViewTextBoxColumn"
        Me.colWashbacksEventSpeciesDescriptionDataGridViewTextBoxColumn.ReadOnly = True
        Me.colWashbacksEventSpeciesDescriptionDataGridViewTextBoxColumn.Width = 250
        '
        'colWashbacksEventEventTypeDataGridViewTextBoxColumn
        '
        Me.colWashbacksEventEventTypeDataGridViewTextBoxColumn.DataPropertyName = "EventType"
        Me.colWashbacksEventEventTypeDataGridViewTextBoxColumn.HeaderText = "Event Type"
        Me.colWashbacksEventEventTypeDataGridViewTextBoxColumn.Name = "colWashbacksEventEventTypeDataGridViewTextBoxColumn"
        Me.colWashbacksEventEventTypeDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colWashbacksEventEventDateBindableDataGridViewTextBoxColumn
        '
        Me.colWashbacksEventEventDateBindableDataGridViewTextBoxColumn.DataPropertyName = "EventDateBindable"
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.colWashbacksEventEventDateBindableDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle7
        Me.colWashbacksEventEventDateBindableDataGridViewTextBoxColumn.HeaderText = "Event Date"
        Me.colWashbacksEventEventDateBindableDataGridViewTextBoxColumn.Name = "colWashbacksEventEventDateBindableDataGridViewTextBoxColumn"
        Me.colWashbacksEventEventDateBindableDataGridViewTextBoxColumn.ReadOnly = True
        '
        'colWashbacksEventCountyNameDataGridViewTextBoxColumn
        '
        Me.colWashbacksEventCountyNameDataGridViewTextBoxColumn.DataPropertyName = "CountyName"
        Me.colWashbacksEventCountyNameDataGridViewTextBoxColumn.HeaderText = "County"
        Me.colWashbacksEventCountyNameDataGridViewTextBoxColumn.Name = "colWashbacksEventCountyNameDataGridViewTextBoxColumn"
        Me.colWashbacksEventCountyNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.colWashbacksEventCountyNameDataGridViewTextBoxColumn.Width = 150
        '
        'colWashbacksEventUnder5CmClslDataGridViewTextBoxColumn
        '
        Me.colWashbacksEventUnder5CmClslDataGridViewTextBoxColumn.DataPropertyName = "Under5CmClsl"
        Me.colWashbacksEventUnder5CmClslDataGridViewTextBoxColumn.HeaderText = "Under 5cm CLSL?"
        Me.colWashbacksEventUnder5CmClslDataGridViewTextBoxColumn.Name = "colWashbacksEventUnder5CmClslDataGridViewTextBoxColumn"
        Me.colWashbacksEventUnder5CmClslDataGridViewTextBoxColumn.ReadOnly = True
        '
        'btnAddWashbacksAcquiredEvent
        '
        Me.btnAddWashbacksAcquiredEvent.BackColor = System.Drawing.Color.MintCream
        Me.btnAddWashbacksAcquiredEvent.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddWashbacksAcquiredEvent.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddWashbacksAcquiredEvent.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddWashbacksAcquiredEvent.ForeColor = System.Drawing.Color.Blue
        Me.btnAddWashbacksAcquiredEvent.Location = New System.Drawing.Point(8, 0)
        Me.btnAddWashbacksAcquiredEvent.Name = "btnAddWashbacksAcquiredEvent"
        Me.btnAddWashbacksAcquiredEvent.Size = New System.Drawing.Size(180, 20)
        Me.btnAddWashbacksAcquiredEvent.TabIndex = 0
        Me.btnAddWashbacksAcquiredEvent.Text = "add ""washbacks acquired"" event"
        Me.btnAddWashbacksAcquiredEvent.UseVisualStyleBackColor = False
        '
        'picBannerBackground
        '
        Me.picBannerBackground.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picBannerBackground.Image = CType(resources.GetObject("picBannerBackground.Image"), System.Drawing.Image)
        Me.picBannerBackground.Location = New System.Drawing.Point(0, 0)
        Me.picBannerBackground.Name = "picBannerBackground"
        Me.picBannerBackground.Size = New System.Drawing.Size(1016, 38)
        Me.picBannerBackground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBannerBackground.TabIndex = 36
        Me.picBannerBackground.TabStop = False
        '
        'picBanner
        '
        Me.picBanner.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picBanner.BackColor = System.Drawing.Color.Transparent
        Me.picBanner.Image = CType(resources.GetObject("picBanner.Image"), System.Drawing.Image)
        Me.picBanner.Location = New System.Drawing.Point(112, 0)
        Me.picBanner.Name = "picBanner"
        Me.picBanner.Size = New System.Drawing.Size(792, 38)
        Me.picBanner.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picBanner.TabIndex = 37
        Me.picBanner.TabStop = False
        '
        'picLeftHeaderTurtle
        '
        Me.picLeftHeaderTurtle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picLeftHeaderTurtle.Image = CType(resources.GetObject("picLeftHeaderTurtle.Image"), System.Drawing.Image)
        Me.picLeftHeaderTurtle.Location = New System.Drawing.Point(184, 2)
        Me.picLeftHeaderTurtle.Name = "picLeftHeaderTurtle"
        Me.picLeftHeaderTurtle.Size = New System.Drawing.Size(39, 34)
        Me.picLeftHeaderTurtle.TabIndex = 38
        Me.picLeftHeaderTurtle.TabStop = False
        '
        'picRightHeaderTurtle
        '
        Me.picRightHeaderTurtle.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.picRightHeaderTurtle.Image = CType(resources.GetObject("picRightHeaderTurtle.Image"), System.Drawing.Image)
        Me.picRightHeaderTurtle.Location = New System.Drawing.Point(792, 2)
        Me.picRightHeaderTurtle.Name = "picRightHeaderTurtle"
        Me.picRightHeaderTurtle.Size = New System.Drawing.Size(39, 34)
        Me.picRightHeaderTurtle.TabIndex = 39
        Me.picRightHeaderTurtle.TabStop = False
        '
        'tabReportsTab
        '
        Me.tabReportsTab.Controls.Add(Me.tpgFwcReportsAndForms)
        Me.tabReportsTab.Controls.Add(Me.tpgOtherReports)
        Me.tabReportsTab.Location = New System.Drawing.Point(455, 43)
        Me.tabReportsTab.Name = "tabReportsTab"
        Me.tabReportsTab.SelectedIndex = 0
        Me.tabReportsTab.Size = New System.Drawing.Size(553, 305)
        Me.tabReportsTab.TabIndex = 2
        '
        'tpgFwcReportsAndForms
        '
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblObstructedNestingAttemptFormDirections)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnObstructedNestingAttemptFormDirectionsBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnObstructedNestingAttemptFormFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblObstructedNestingAttemptForm)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnObstructedNestingAttemptFormBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblDisorientationIncidentFormDirections)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnDisorientationIncidentFormDirectionsBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForWashbacks)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnPublicTurtleWatchSummaryFormFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblPublicTurtleWatchSummaryForm)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnPublicTurtleWatchSummaryFormBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnTurtleTransferFormFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnTaggingDataFormFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnTagRequestFormFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnStrandingAndSalvageFormFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblTurtleTransferForm)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblTaggingDataForm)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblTagRequestForm)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblStrandingAndSalvageForm)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnPublicTurtleWatchScheduleFormFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblPublicTurtleWatchScheduleForm)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblBeachRestorationProjectMonitoringTable)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblLine01)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnPapillomaFormFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblPapillomaForm)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnNighttimePublicHatchlingReleaseFormFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblNighttimePublicHatchlingReleaseForm)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnNecropsyFormFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblNecropsyForm)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnEducationalPresentationsUsingLiveTurtlesFormFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblEducationalPresentationsUsingLiveTurtlesForm)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnDisorientationIncidentFormFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblDisorientationIncidentForm)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnMarineTurtleHoldingFacilityQuarterlyReportFill)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnTurtleTransferFormBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnTaggingDataFormBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnTagRequestFormBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnStrandingAndSalvageFormBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnPublicTurtleWatchScheduleFormBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnPapillomaFormBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnNighttimePublicHatchlingReleaseFormBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnNecropsyFormBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnDisorientationIncidentFormBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnEducationalPresentationsUsingLiveTurtlesFormBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnBeachRestorationProjectMonitoringTableBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.btnMarineTurtleHoldingFacilityQuarterlyReportBlank)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForHatchlings)
        Me.tpgFwcReportsAndForms.Controls.Add(Me.lblMarineTurtleHoldingFacilityQuarterlyReport)
        Me.tpgFwcReportsAndForms.Location = New System.Drawing.Point(4, 22)
        Me.tpgFwcReportsAndForms.Name = "tpgFwcReportsAndForms"
        Me.tpgFwcReportsAndForms.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgFwcReportsAndForms.Size = New System.Drawing.Size(545, 279)
        Me.tpgFwcReportsAndForms.TabIndex = 0
        Me.tpgFwcReportsAndForms.Text = "FWC Reports and Forms"
        Me.tpgFwcReportsAndForms.UseVisualStyleBackColor = True
        '
        'lblObstructedNestingAttemptFormDirections
        '
        Me.lblObstructedNestingAttemptFormDirections.Location = New System.Drawing.Point(75, 251)
        Me.lblObstructedNestingAttemptFormDirections.Name = "lblObstructedNestingAttemptFormDirections"
        Me.lblObstructedNestingAttemptFormDirections.Size = New System.Drawing.Size(216, 20)
        Me.lblObstructedNestingAttemptFormDirections.TabIndex = 30
        Me.lblObstructedNestingAttemptFormDirections.Text = "Obstructed Nesting Attempt Form Directions"
        Me.lblObstructedNestingAttemptFormDirections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblObstructedNestingAttemptForm
        '
        Me.lblObstructedNestingAttemptForm.Location = New System.Drawing.Point(75, 227)
        Me.lblObstructedNestingAttemptForm.Name = "lblObstructedNestingAttemptForm"
        Me.lblObstructedNestingAttemptForm.Size = New System.Drawing.Size(184, 20)
        Me.lblObstructedNestingAttemptForm.TabIndex = 28
        Me.lblObstructedNestingAttemptForm.Text = "Obstructed Nesting Attempt Form"
        Me.lblObstructedNestingAttemptForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisorientationIncidentFormDirections
        '
        Me.lblDisorientationIncidentFormDirections.Location = New System.Drawing.Point(75, 131)
        Me.lblDisorientationIncidentFormDirections.Name = "lblDisorientationIncidentFormDirections"
        Me.lblDisorientationIncidentFormDirections.Size = New System.Drawing.Size(196, 20)
        Me.lblDisorientationIncidentFormDirections.TabIndex = 16
        Me.lblDisorientationIncidentFormDirections.Text = "Disorienation Incident Form Directions"
        Me.lblDisorientationIncidentFormDirections.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMarineTurtleCaptiveFacilityQuarterlyReportForWashbacks
        '
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForWashbacks.Location = New System.Drawing.Point(75, 51)
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForWashbacks.Name = "lblMarineTurtleCaptiveFacilityQuarterlyReportForWashbacks"
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForWashbacks.Size = New System.Drawing.Size(312, 20)
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForWashbacks.TabIndex = 8
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForWashbacks.Text = "Marine Turtle Captive Facility Quarterly Report for Washbacks"
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForWashbacks.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPublicTurtleWatchSummaryForm
        '
        Me.lblPublicTurtleWatchSummaryForm.Location = New System.Drawing.Point(366, 131)
        Me.lblPublicTurtleWatchSummaryForm.Name = "lblPublicTurtleWatchSummaryForm"
        Me.lblPublicTurtleWatchSummaryForm.Size = New System.Drawing.Size(176, 20)
        Me.lblPublicTurtleWatchSummaryForm.TabIndex = 39
        Me.lblPublicTurtleWatchSummaryForm.Text = "Public Turtle Watch Summary Form"
        Me.lblPublicTurtleWatchSummaryForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTurtleTransferForm
        '
        Me.lblTurtleTransferForm.Location = New System.Drawing.Point(366, 227)
        Me.lblTurtleTransferForm.Name = "lblTurtleTransferForm"
        Me.lblTurtleTransferForm.Size = New System.Drawing.Size(152, 20)
        Me.lblTurtleTransferForm.TabIndex = 51
        Me.lblTurtleTransferForm.Text = "Turtle Transfer Form"
        Me.lblTurtleTransferForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTaggingDataForm
        '
        Me.lblTaggingDataForm.Location = New System.Drawing.Point(366, 203)
        Me.lblTaggingDataForm.Name = "lblTaggingDataForm"
        Me.lblTaggingDataForm.Size = New System.Drawing.Size(152, 20)
        Me.lblTaggingDataForm.TabIndex = 48
        Me.lblTaggingDataForm.Text = "Tagging Data Form"
        Me.lblTaggingDataForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblTagRequestForm
        '
        Me.lblTagRequestForm.Location = New System.Drawing.Point(366, 179)
        Me.lblTagRequestForm.Name = "lblTagRequestForm"
        Me.lblTagRequestForm.Size = New System.Drawing.Size(152, 20)
        Me.lblTagRequestForm.TabIndex = 45
        Me.lblTagRequestForm.Text = "Tag Request Form"
        Me.lblTagRequestForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStrandingAndSalvageForm
        '
        Me.lblStrandingAndSalvageForm.Location = New System.Drawing.Point(366, 155)
        Me.lblStrandingAndSalvageForm.Name = "lblStrandingAndSalvageForm"
        Me.lblStrandingAndSalvageForm.Size = New System.Drawing.Size(152, 20)
        Me.lblStrandingAndSalvageForm.TabIndex = 42
        Me.lblStrandingAndSalvageForm.Text = "Stranding and Salvage Form"
        Me.lblStrandingAndSalvageForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPublicTurtleWatchScheduleForm
        '
        Me.lblPublicTurtleWatchScheduleForm.Location = New System.Drawing.Point(366, 107)
        Me.lblPublicTurtleWatchScheduleForm.Name = "lblPublicTurtleWatchScheduleForm"
        Me.lblPublicTurtleWatchScheduleForm.Size = New System.Drawing.Size(170, 20)
        Me.lblPublicTurtleWatchScheduleForm.TabIndex = 36
        Me.lblPublicTurtleWatchScheduleForm.Text = "Public Turtle Watch Sched Form"
        Me.lblPublicTurtleWatchScheduleForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblBeachRestorationProjectMonitoringTable
        '
        Me.lblBeachRestorationProjectMonitoringTable.Location = New System.Drawing.Point(75, 83)
        Me.lblBeachRestorationProjectMonitoringTable.Name = "lblBeachRestorationProjectMonitoringTable"
        Me.lblBeachRestorationProjectMonitoringTable.Size = New System.Drawing.Size(216, 20)
        Me.lblBeachRestorationProjectMonitoringTable.TabIndex = 11
        Me.lblBeachRestorationProjectMonitoringTable.Text = "Monitoring for Beach Restoration Projects"
        Me.lblBeachRestorationProjectMonitoringTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblLine01
        '
        Me.lblLine01.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblLine01.Location = New System.Drawing.Point(3, 75)
        Me.lblLine01.Name = "lblLine01"
        Me.lblLine01.Size = New System.Drawing.Size(534, 3)
        Me.lblLine01.TabIndex = 9
        '
        'lblPapillomaForm
        '
        Me.lblPapillomaForm.Location = New System.Drawing.Point(366, 83)
        Me.lblPapillomaForm.Name = "lblPapillomaForm"
        Me.lblPapillomaForm.Size = New System.Drawing.Size(173, 20)
        Me.lblPapillomaForm.TabIndex = 33
        Me.lblPapillomaForm.Text = "Papilloma Documentation Form"
        Me.lblPapillomaForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNighttimePublicHatchlingReleaseForm
        '
        Me.lblNighttimePublicHatchlingReleaseForm.Location = New System.Drawing.Point(75, 203)
        Me.lblNighttimePublicHatchlingReleaseForm.Name = "lblNighttimePublicHatchlingReleaseForm"
        Me.lblNighttimePublicHatchlingReleaseForm.Size = New System.Drawing.Size(184, 20)
        Me.lblNighttimePublicHatchlingReleaseForm.TabIndex = 25
        Me.lblNighttimePublicHatchlingReleaseForm.Text = "Nighttime Public Hatchling Release"
        Me.lblNighttimePublicHatchlingReleaseForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblNecropsyForm
        '
        Me.lblNecropsyForm.Location = New System.Drawing.Point(75, 179)
        Me.lblNecropsyForm.Name = "lblNecropsyForm"
        Me.lblNecropsyForm.Size = New System.Drawing.Size(184, 20)
        Me.lblNecropsyForm.TabIndex = 22
        Me.lblNecropsyForm.Text = "Necropsy Report Form"
        Me.lblNecropsyForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblEducationalPresentationsUsingLiveTurtlesForm
        '
        Me.lblEducationalPresentationsUsingLiveTurtlesForm.Location = New System.Drawing.Point(75, 155)
        Me.lblEducationalPresentationsUsingLiveTurtlesForm.Name = "lblEducationalPresentationsUsingLiveTurtlesForm"
        Me.lblEducationalPresentationsUsingLiveTurtlesForm.Size = New System.Drawing.Size(210, 20)
        Me.lblEducationalPresentationsUsingLiveTurtlesForm.TabIndex = 19
        Me.lblEducationalPresentationsUsingLiveTurtlesForm.Text = "Educational Presentations Using Turtles"
        Me.lblEducationalPresentationsUsingLiveTurtlesForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDisorientationIncidentForm
        '
        Me.lblDisorientationIncidentForm.Location = New System.Drawing.Point(75, 107)
        Me.lblDisorientationIncidentForm.Name = "lblDisorientationIncidentForm"
        Me.lblDisorientationIncidentForm.Size = New System.Drawing.Size(184, 20)
        Me.lblDisorientationIncidentForm.TabIndex = 14
        Me.lblDisorientationIncidentForm.Text = "Disorienation Incident Form"
        Me.lblDisorientationIncidentForm.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMarineTurtleCaptiveFacilityQuarterlyReportForHatchlings
        '
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForHatchlings.Location = New System.Drawing.Point(75, 27)
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForHatchlings.Name = "lblMarineTurtleCaptiveFacilityQuarterlyReportForHatchlings"
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForHatchlings.Size = New System.Drawing.Size(312, 20)
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForHatchlings.TabIndex = 5
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForHatchlings.Text = "Marine Turtle Captive Facility Quarterly Report for Hatchlings"
        Me.lblMarineTurtleCaptiveFacilityQuarterlyReportForHatchlings.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblMarineTurtleHoldingFacilityQuarterlyReport
        '
        Me.lblMarineTurtleHoldingFacilityQuarterlyReport.Location = New System.Drawing.Point(75, 3)
        Me.lblMarineTurtleHoldingFacilityQuarterlyReport.Name = "lblMarineTurtleHoldingFacilityQuarterlyReport"
        Me.lblMarineTurtleHoldingFacilityQuarterlyReport.Size = New System.Drawing.Size(243, 20)
        Me.lblMarineTurtleHoldingFacilityQuarterlyReport.TabIndex = 2
        Me.lblMarineTurtleHoldingFacilityQuarterlyReport.Text = "Marine Turtle Holding Facility Quarterly Report"
        Me.lblMarineTurtleHoldingFacilityQuarterlyReport.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tpgOtherReports
        '
        Me.tpgOtherReports.Controls.Add(Me.lnkHatchlingsWashbacksCountyReport)
        Me.tpgOtherReports.Controls.Add(Me.lnkTurtleTagReport)
        Me.tpgOtherReports.Controls.Add(Me.lnkTurtleInjuryReport)
        Me.tpgOtherReports.Location = New System.Drawing.Point(4, 22)
        Me.tpgOtherReports.Name = "tpgOtherReports"
        Me.tpgOtherReports.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgOtherReports.Size = New System.Drawing.Size(545, 279)
        Me.tpgOtherReports.TabIndex = 1
        Me.tpgOtherReports.Text = "Other Reports"
        Me.tpgOtherReports.UseVisualStyleBackColor = True
        '
        'lnkHatchlingsWashbacksCountyReport
        '
        Me.lnkHatchlingsWashbacksCountyReport.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkHatchlingsWashbacksCountyReport.AutoSize = True
        Me.lnkHatchlingsWashbacksCountyReport.Location = New System.Drawing.Point(7, 45)
        Me.lnkHatchlingsWashbacksCountyReport.Name = "lnkHatchlingsWashbacksCountyReport"
        Me.lnkHatchlingsWashbacksCountyReport.Size = New System.Drawing.Size(223, 13)
        Me.lnkHatchlingsWashbacksCountyReport.TabIndex = 2
        Me.lnkHatchlingsWashbacksCountyReport.TabStop = True
        Me.lnkHatchlingsWashbacksCountyReport.Text = "Hatchlings and Washbacks by County Report"
        Me.lnkHatchlingsWashbacksCountyReport.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkTurtleTagReport
        '
        Me.lnkTurtleTagReport.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkTurtleTagReport.AutoSize = True
        Me.lnkTurtleTagReport.Location = New System.Drawing.Point(7, 26)
        Me.lnkTurtleTagReport.Name = "lnkTurtleTagReport"
        Me.lnkTurtleTagReport.Size = New System.Drawing.Size(91, 13)
        Me.lnkTurtleTagReport.TabIndex = 1
        Me.lnkTurtleTagReport.TabStop = True
        Me.lnkTurtleTagReport.Text = "Turtle Tag Report"
        Me.lnkTurtleTagReport.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkTurtleInjuryReport
        '
        Me.lnkTurtleInjuryReport.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkTurtleInjuryReport.AutoSize = True
        Me.lnkTurtleInjuryReport.Location = New System.Drawing.Point(7, 7)
        Me.lnkTurtleInjuryReport.Name = "lnkTurtleInjuryReport"
        Me.lnkTurtleInjuryReport.Size = New System.Drawing.Size(97, 13)
        Me.lnkTurtleInjuryReport.TabIndex = 0
        Me.lnkTurtleInjuryReport.TabStop = True
        Me.lnkTurtleInjuryReport.Text = "Turtle Injury Report"
        Me.lnkTurtleInjuryReport.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'colTurtleEditActionDataGridViewLinkColumn
        '
        Me.colTurtleEditActionDataGridViewLinkColumn.DataPropertyName = "EditAction"
        Me.colTurtleEditActionDataGridViewLinkColumn.Frozen = True
        Me.colTurtleEditActionDataGridViewLinkColumn.HeaderText = ""
        Me.colTurtleEditActionDataGridViewLinkColumn.Name = "colTurtleEditActionDataGridViewLinkColumn"
        Me.colTurtleEditActionDataGridViewLinkColumn.ReadOnly = True
        Me.colTurtleEditActionDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTurtleEditActionDataGridViewLinkColumn.TrackVisitedState = False
        Me.colTurtleEditActionDataGridViewLinkColumn.Width = 28
        '
        'colTurtleDeleteActionDataGridViewLinkColumn
        '
        Me.colTurtleDeleteActionDataGridViewLinkColumn.DataPropertyName = "DeleteAction"
        Me.colTurtleDeleteActionDataGridViewLinkColumn.Frozen = True
        Me.colTurtleDeleteActionDataGridViewLinkColumn.HeaderText = ""
        Me.colTurtleDeleteActionDataGridViewLinkColumn.Name = "colTurtleDeleteActionDataGridViewLinkColumn"
        Me.colTurtleDeleteActionDataGridViewLinkColumn.ReadOnly = True
        Me.colTurtleDeleteActionDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTurtleDeleteActionDataGridViewLinkColumn.TrackVisitedState = False
        Me.colTurtleDeleteActionDataGridViewLinkColumn.Width = 40
        '
        'colTurtleTurtleIDDataGridViewTextBoxColumn
        '
        Me.colTurtleTurtleIDDataGridViewTextBoxColumn.DataPropertyName = "TurtleID"
        Me.colTurtleTurtleIDDataGridViewTextBoxColumn.Frozen = True
        Me.colTurtleTurtleIDDataGridViewTextBoxColumn.HeaderText = "TurtleID"
        Me.colTurtleTurtleIDDataGridViewTextBoxColumn.Name = "colTurtleTurtleIDDataGridViewTextBoxColumn"
        Me.colTurtleTurtleIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleTurtleIDDataGridViewTextBoxColumn.Visible = False
        '
        'colTurtleTurtleNameDataGridViewTextBoxColumn
        '
        Me.colTurtleTurtleNameDataGridViewTextBoxColumn.DataPropertyName = "TurtleName"
        Me.colTurtleTurtleNameDataGridViewTextBoxColumn.Frozen = True
        Me.colTurtleTurtleNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.colTurtleTurtleNameDataGridViewTextBoxColumn.Name = "colTurtleTurtleNameDataGridViewTextBoxColumn"
        Me.colTurtleTurtleNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleTurtleNameDataGridViewTextBoxColumn.Width = 118
        '
        'colTurtleSidNumberDataGridViewTextBoxColumn
        '
        Me.colTurtleSidNumberDataGridViewTextBoxColumn.DataPropertyName = "SidNumber"
        Me.colTurtleSidNumberDataGridViewTextBoxColumn.HeaderText = "SID #"
        Me.colTurtleSidNumberDataGridViewTextBoxColumn.Name = "colTurtleSidNumberDataGridViewTextBoxColumn"
        Me.colTurtleSidNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleSidNumberDataGridViewTextBoxColumn.Width = 104
        '
        'colTurtleSpeciesDataGridViewTextBoxColumn
        '
        Me.colTurtleSpeciesDataGridViewTextBoxColumn.DataPropertyName = "Species"
        Me.colTurtleSpeciesDataGridViewTextBoxColumn.HeaderText = "Species"
        Me.colTurtleSpeciesDataGridViewTextBoxColumn.Name = "colTurtleSpeciesDataGridViewTextBoxColumn"
        Me.colTurtleSpeciesDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleSpeciesDataGridViewTextBoxColumn.Width = 64
        '
        'colTurtleAcquiredFromDataGridViewTextBoxColumn
        '
        Me.colTurtleAcquiredFromDataGridViewTextBoxColumn.DataPropertyName = "AcquiredFrom"
        Me.colTurtleAcquiredFromDataGridViewTextBoxColumn.HeaderText = "Acquired From"
        Me.colTurtleAcquiredFromDataGridViewTextBoxColumn.Name = "colTurtleAcquiredFromDataGridViewTextBoxColumn"
        Me.colTurtleAcquiredFromDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleAcquiredFromDataGridViewTextBoxColumn.Visible = False
        '
        'colTurtleTurtleSizeDataGridViewTextBoxColumn
        '
        Me.colTurtleTurtleSizeDataGridViewTextBoxColumn.DataPropertyName = "TurtleSize"
        Me.colTurtleTurtleSizeDataGridViewTextBoxColumn.HeaderText = "Size"
        Me.colTurtleTurtleSizeDataGridViewTextBoxColumn.Name = "colTurtleTurtleSizeDataGridViewTextBoxColumn"
        Me.colTurtleTurtleSizeDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleTurtleSizeDataGridViewTextBoxColumn.Width = 84
        '
        'colTurtleStatusDataGridViewTextBoxColumn
        '
        Me.colTurtleStatusDataGridViewTextBoxColumn.DataPropertyName = "Status"
        Me.colTurtleStatusDataGridViewTextBoxColumn.HeaderText = "Status"
        Me.colTurtleStatusDataGridViewTextBoxColumn.Name = "colTurtleStatusDataGridViewTextBoxColumn"
        Me.colTurtleStatusDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleStatusDataGridViewTextBoxColumn.Width = 72
        '
        'colTurtleRelinquishedToDataGridViewTextBoxColumn
        '
        Me.colTurtleRelinquishedToDataGridViewTextBoxColumn.DataPropertyName = "RelinquishedTo"
        Me.colTurtleRelinquishedToDataGridViewTextBoxColumn.HeaderText = "RelinquishedTo"
        Me.colTurtleRelinquishedToDataGridViewTextBoxColumn.Name = "colTurtleRelinquishedToDataGridViewTextBoxColumn"
        Me.colTurtleRelinquishedToDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleRelinquishedToDataGridViewTextBoxColumn.Visible = False
        '
        'TurtleGridBindingSource
        '
        Me.TurtleGridBindingSource.DataSource = GetType(TurtleGeek.Roster.TurtleListItems)
        '
        'colTankTankIDDataGridViewTextBoxColumn
        '
        Me.colTankTankIDDataGridViewTextBoxColumn.DataPropertyName = "TankID"
        Me.colTankTankIDDataGridViewTextBoxColumn.HeaderText = "TankID"
        Me.colTankTankIDDataGridViewTextBoxColumn.Name = "colTankTankIDDataGridViewTextBoxColumn"
        Me.colTankTankIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTankTankIDDataGridViewTextBoxColumn.Visible = False
        '
        'colTankTankNameDataGridViewTextBoxColumn
        '
        Me.colTankTankNameDataGridViewTextBoxColumn.DataPropertyName = "TankName"
        Me.colTankTankNameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.colTankTankNameDataGridViewTextBoxColumn.Name = "colTankTankNameDataGridViewTextBoxColumn"
        Me.colTankTankNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTankTankNameDataGridViewTextBoxColumn.Width = 662
        '
        'TankGridBindingSource
        '
        Me.TankGridBindingSource.DataSource = GetType(TurtleGeek.Roster.TankListItems)
        '
        'colHatchlingsEventEventCountDataGridViewTextBoxColumn
        '
        Me.colHatchlingsEventEventCountDataGridViewTextBoxColumn.DataPropertyName = "EventCount"
        Me.colHatchlingsEventEventCountDataGridViewTextBoxColumn.HeaderText = "Event Count"
        Me.colHatchlingsEventEventCountDataGridViewTextBoxColumn.Name = "colHatchlingsEventEventCountDataGridViewTextBoxColumn"
        Me.colHatchlingsEventEventCountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'HatchlingsEventGridBindingSource
        '
        Me.HatchlingsEventGridBindingSource.DataSource = GetType(TurtleGeek.Roster.HatchlingsEventListItems)
        '
        'colWashbacksEventEventCountDataGridViewTextBoxColumn
        '
        Me.colWashbacksEventEventCountDataGridViewTextBoxColumn.DataPropertyName = "EventCount"
        Me.colWashbacksEventEventCountDataGridViewTextBoxColumn.HeaderText = "Event Count"
        Me.colWashbacksEventEventCountDataGridViewTextBoxColumn.Name = "colWashbacksEventEventCountDataGridViewTextBoxColumn"
        Me.colWashbacksEventEventCountDataGridViewTextBoxColumn.ReadOnly = True
        '
        'WashbacksEventGridBindingSource
        '
        Me.WashbacksEventGridBindingSource.DataSource = GetType(TurtleGeek.Roster.WashbacksEventListItems)
        '
        'MainForm
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(1016, 581)
        Me.Controls.Add(Me.tabReportsTab)
        Me.Controls.Add(Me.picRightHeaderTurtle)
        Me.Controls.Add(Me.picLeftHeaderTurtle)
        Me.Controls.Add(Me.picBanner)
        Me.Controls.Add(Me.btnEditOrganization)
        Me.Controls.Add(Me.tabMainFormTab)
        Me.Controls.Add(Me.grpOrganizationInformation)
        Me.Controls.Add(Me.sbrStatusBar)
        Me.Controls.Add(Me.picBannerBackground)
        Me.hlpHelpProvider.SetHelpKeyword(Me, "")
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Menu = Me.mnuMainMenu
        Me.Name = "MainForm"
        Me.hlpHelpProvider.SetShowHelp(Me, True)
        Me.StartPosition = System.Windows.Forms.FormStartPosition.Manual
        Me.Text = "ROSTER - Record of Sea Turtles Electronic Reports"
        Me.grpOrganizationInformation.ResumeLayout(False)
        Me.tabOrganizationInformationTab.ResumeLayout(False)
        Me.tpgGeneralInformation.ResumeLayout(False)
        Me.tpgHatchlingWashbackStartingBalances.ResumeLayout(False)
        Me.tpgHatchlingWashbackStartingBalances.PerformLayout()
        CType(Me.picMoreInfoFiltering, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabMainFormTab.ResumeLayout(False)
        Me.tpgTurtles.ResumeLayout(False)
        Me.tpgTurtles.PerformLayout()
        CType(Me.grdTurtleGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgTanks.ResumeLayout(False)
        CType(Me.grdTankGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgHatchlingsEvents.ResumeLayout(False)
        CType(Me.grdHatchlingsEventGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgWashbacksEvents.ResumeLayout(False)
        CType(Me.grdWashbacksEventGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBannerBackground, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBanner, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLeftHeaderTurtle, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRightHeaderTurtle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabReportsTab.ResumeLayout(False)
        Me.tpgFwcReportsAndForms.ResumeLayout(False)
        Me.tpgOtherReports.ResumeLayout(False)
        Me.tpgOtherReports.PerformLayout()
        CType(Me.TurtleGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TankGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.HatchlingsEventGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WashbacksEventGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mbIsLoading As Boolean = False
    Private msTurtleSortedColumnPropertyName As String = "SidNumber"
    Private moTurtleListSortDirection As System.ComponentModel.ListSortDirection = System.ComponentModel.ListSortDirection.Ascending
    Private msTankSortedColumnPropertyName As String = "TankName"
    Private moTankListSortDirection As System.ComponentModel.ListSortDirection = System.ComponentModel.ListSortDirection.Ascending
    Private msHatchlingsEventSortedColumnPropertyName As String = "EventDate"
    Private moHatchlingsEventListSortDirection As System.ComponentModel.ListSortDirection = System.ComponentModel.ListSortDirection.Descending
    Private msWashbacksEventSortedColumnPropertyName As String = "EventDate"
    Private moWashbacksEventListSortDirection As System.ComponentModel.ListSortDirection = System.ComponentModel.ListSortDirection.Descending

#Region " Main Form "

    Private Sub frmMainForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim bDefaultConnectionStringExists As Boolean = False
        Dim sNameValue As String = String.Empty
        Dim sOldConnectionString As String = String.Empty
        Dim sNewConnectionString As String = String.Empty
        Dim frmOrganizationInformation As OrganizationInformationDlg
        Dim frmSplash As New frmSplashForm
        Dim frmDatabaseSelection As DatabaseSelectionDlg
        Dim oConfiguration As Configuration
        Dim oAdoHelper As AdoHelper
        Dim cn As IDbConnection
        Dim oSize As System.Drawing.Size

        Try

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            mbIsLoading = True

            '----------------------------------------------------------------
            '-- initialize screen position
            '----------------------------------------------------------------
            oSize = My.Settings.MainFormSize
            If (oSize.Height = 0) AndAlso (oSize.Width = 0) Then
                Me.Size = New Size(1024, 768)
                Me.Top = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Height - Me.Height) / 2)
                Me.Left = Convert.ToInt32((Screen.PrimaryScreen.WorkingArea.Width - Me.Width) / 2)
            Else
                Me.Location = My.Settings.MainFormLocation
                Me.Size = My.Settings.MainFormSize
            End If

            '----------------------------------------------------------------
            '-- display the splash screen
            '----------------------------------------------------------------
            frmSplash.Show()
            frmSplash.BringToFront()
            frmSplash.SetMessage()

            '----------------------------------------------------------------
            '----------------------------------------------------------------
            frmSplash.SetMessage("Testing database connection...")

            '----------------------------------------------------------------
            '-- check the app.config file for connection string settings
            '----------------------------------------------------------------
            '-- new installs starting with 2.0.6 will have a blank "Default" connection string;
            '-- this will force a prompt for the user to select the database type
            '----------------------------------------------------------------
            '-- upgrade installs starting with 2.0.6 have no connection string;
            '-- this will assume that the previous database in use is SQLITE, 
            '-- so we will create a "Default" connection string for the existing SQLITE database
            '-- *** OR **
            '-- upgrade installs starting with 2.0.6 have an existing "Default" connection string;
            '-- this also means a previous SQLITE database is in use, 
            '-- so we do nothing as the connection string is as we want it
            '----------------------------------------------------------------
            oConfiguration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None)

            bDefaultConnectionStringExists = False
            For Each oConnectionStringSettings As ConnectionStringSettings In oConfiguration.ConnectionStrings.ConnectionStrings
                If (oConnectionStringSettings.Name = "Default") Then
                    bDefaultConnectionStringExists = True
                    Exit For
                End If
            Next

            '----------------------------------------------------------------
            '-- we changed to using connection strings in 2.0.4;
            '-- if the user's app.config file does NOT have a "Default" connection string, 
            '-- that means they are using SQLite, so set up the appropriate connection string
            '----------------------------------------------------------------
            If Not bDefaultConnectionStringExists Then
                oConfiguration.ConnectionStrings.ConnectionStrings.Add(New ConnectionStringSettings("Default", "Data Source=roster_data.db3;Version=3;New=False;Compress=True", "SQLite"))
                oConfiguration.Save(ConfigurationSaveMode.Modified)
                ConfigurationManager.RefreshSection("connectionStrings")
            End If

            '----------------------------------------------------------------
            '-- if the "Default" connection string is empty, 
            '-- that is the "first-use" key to indicate that the user can select 
            '-- between a new SQLite or a new Microsoft Access database
            '----------------------------------------------------------------
            If String.IsNullOrEmpty(oConfiguration.ConnectionStrings.ConnectionStrings("Default").ConnectionString) Then
                frmDatabaseSelection = New DatabaseSelectionDlg
                If (frmDatabaseSelection.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then

                    If (frmDatabaseSelection.DBMS = DatabaseTypeEnum.OleDb) Then
                        oConfiguration.ConnectionStrings.ConnectionStrings("Default").ConnectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=roster_data.mdb;User Id=admin;Password=;"
                        oConfiguration.ConnectionStrings.ConnectionStrings("Default").ProviderName = "OleDb"
                    Else
                        oConfiguration.ConnectionStrings.ConnectionStrings("Default").ConnectionString = "Data Source=roster_data.db3;Version=3;New=False;Compress=True"
                        oConfiguration.ConnectionStrings.ConnectionStrings("Default").ProviderName = "SQLite"
                    End If

                Else
                    Throw New ApplicationException("A database must be selected in order for ROSTER to run.  Exiting ROSTER.")
                End If
            End If

            '----------------------------------------------------------------
            '-- inject the current executing path into the connection string
            '----------------------------------------------------------------
            sOldConnectionString = oConfiguration.ConnectionStrings.ConnectionStrings("Default").ConnectionString

            If sOldConnectionString.Contains("Data Source=roster_data.") Then
                sNewConnectionString = sOldConnectionString.Replace("Data Source=roster_data.", "Data Source=" & GetExecutingDirectoryName() & "\roster_data.")
            Else
                If sOldConnectionString.Contains("\roster_data.") Then
                    sNewConnectionString = sOldConnectionString.Substring(0, sOldConnectionString.IndexOf("Data Source=") + "Data Source=".Length)
                    sNewConnectionString &= GetExecutingDirectoryName()
                    sNewConnectionString &= sOldConnectionString.Substring(sOldConnectionString.IndexOf("\roster_data."))
                Else
                    sNewConnectionString = sOldConnectionString
                End If
            End If

            oConfiguration.ConnectionStrings.ConnectionStrings("Default").ConnectionString = sNewConnectionString

            oConfiguration.Save(ConfigurationSaveMode.Modified)

            ConfigurationManager.RefreshSection("connectionStrings")

            ''----------------------------------------------------------------
            ''-- verify that the database file exists
            ''----------------------------------------------------------------
            'If Not System.IO.File.Exists(GetExecutingDirectoryName() & "\roster_data.db3") Then
            '    Throw New ApplicationException("Unable to find database file 'roster_data.db3'.  ROSTER requires this program.  It should have been created when ROSTER was installed.  Please contact customer support.")
            'End If

            '----------------------------------------------------------------
            '-- try opening a connection to the database; 
            '-- if it fails, we jump to the exception handler
            '----------------------------------------------------------------
            oAdoHelper = AdoHelper.CreateHelper()
            cn = oAdoHelper.GetConnection()
            cn.Open()
            cn.Close()
            cn.Dispose()
            cn = Nothing
            oAdoHelper = Nothing

            '----------------------------------------------------------------
            '-- update the database, if necessary
            '----------------------------------------------------------------
            frmSplash.SetMessage("Updating database...")
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
            Call UpdateDatabase()

            '----------------------------------------------------------------
            '-- restore last user settings
            '----------------------------------------------------------------
            frmSplash.SetMessage("Restoring user settings...")
            Me.chkShowInactiveTurtles.Checked = My.Settings.MainShowInactiveTurtles

            frmSplash.SetMessage("Loading...")
            '----------------------------------------------------------------
            '-- load current organization information 
            '----------------------------------------------------------------
            LoadOrganizationInformation()

            '----------------------------------------------------------------
            '-- load list boxes
            '----------------------------------------------------------------
            Me.cboFilterByList.DisplayMember = "Value"
            Me.cboFilterByList.ValueMember = "Key"
            Me.cboFilterByList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.TurtleListFilter, False)
            Me.cboFilterByList.SelectedIndex = 0

            Me.txtFilterByValue.Text = String.Empty
            Me.txtFilterByValue.Enabled = False

            '----------------------------------------------------------------
            '-- populate the TURTLE grid
            '----------------------------------------------------------------
            LoadTurtleGridData()

            '----------------------------------------------------------------
            '-- populate the TANK grid
            '----------------------------------------------------------------
            LoadTankGridData()

            '----------------------------------------------------------------
            '-- populate the HATCHLINGS EVENT grid
            '----------------------------------------------------------------
            LoadHatchlingsEventGridData()

            '----------------------------------------------------------------
            '-- populate the WASHBACKS EVENT grid
            '----------------------------------------------------------------
            LoadWashbacksEventGridData()

            '----------------------------------------------------------------
            '-- verify that the PDF files we need are there
            '----------------------------------------------------------------
            Call SetReportButtonState(btnBeachRestorationProjectMonitoringTableBlank, MASTER_BEACH_RESTORATION_PROJECT_MONITORING_PDF)

            Call SetReportButtonState(btnMarineTurtleHoldingFacilityQuarterlyReportBlank, MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_ALL_PAGES_PDF)
            Call SetReportButtonState(btnMarineTurtleHoldingFacilityQuarterlyReportFill, MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_1_PDF)
            Call SetReportButtonState(btnMarineTurtleHoldingFacilityQuarterlyReportFill, MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_2_PDF)
            Call SetReportButtonState(btnMarineTurtleHoldingFacilityQuarterlyReportFill, MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_3_PDF)

            Call SetReportButtonState(btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill, MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_HATCHLINGS_PDF)
            Call SetReportButtonState(btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank, MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_HATCHLINGS_PDF)

            Call SetReportButtonState(btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill, MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_WASHBACKS_PDF)
            Call SetReportButtonState(btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank, MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_WASHBACKS_PDF)

            Call SetReportButtonState(btnDisorientationIncidentFormBlank, MASTER_DISORIENTATION_INCIDENT_REPORT_FORM_PDF)
            Call SetReportButtonState(btnDisorientationIncidentFormFill, MASTER_DISORIENTATION_INCIDENT_REPORT_FORM_PDF)

            Call SetReportButtonState(btnEducationalPresentationsUsingLiveTurtlesFormBlank, MASTER_EDUCATIONAL_PRESENTATION_FORM_PDF)
            Call SetReportButtonState(btnEducationalPresentationsUsingLiveTurtlesFormFill, MASTER_EDUCATIONAL_PRESENTATION_FORM_PDF)

            Call SetReportButtonState(btnNecropsyFormBlank, MASTER_NECROPSY_FORM_PDF)
            Call SetReportButtonState(btnNecropsyFormFill, MASTER_NECROPSY_FORM_PDF)

            Call SetReportButtonState(btnNighttimePublicHatchlingReleaseFormBlank, MASTER_NIGHTTIME_PUBLIC_HATCHLING_RELEASE_FORM_PDF)
            Call SetReportButtonState(btnNighttimePublicHatchlingReleaseFormFill, MASTER_NIGHTTIME_PUBLIC_HATCHLING_RELEASE_FORM_PDF)

            Call SetReportButtonState(btnPapillomaFormBlank, MASTER_PAILLOMA_FORM_PDF)
            Call SetReportButtonState(btnPapillomaFormFill, MASTER_PAILLOMA_FORM_PDF)

            Call SetReportButtonState(btnPublicTurtleWatchScheduleFormBlank, MASTER_PUBLIC_TURTLE_WATCH_SCHEDULE_FORMS_PDF)
            Call SetReportButtonState(btnPublicTurtleWatchScheduleFormFill, MASTER_PUBLIC_TURTLE_WATCH_SCHEDULE_FORMS_PDF)

            Call SetReportButtonState(btnPublicTurtleWatchSummaryFormBlank, MASTER_PUBLIC_TURTLE_WATCH_SUMMARY_FORMS_PDF)
            Call SetReportButtonState(btnPublicTurtleWatchSummaryFormFill, MASTER_PUBLIC_TURTLE_WATCH_SUMMARY_FORMS_PDF)

            Call SetReportButtonState(btnStrandingAndSalvageFormBlank, MASTER_STRANDING_AND_SALVAGE_FORM_PDF)
            Call SetReportButtonState(btnStrandingAndSalvageFormFill, MASTER_STRANDING_AND_SALVAGE_FORM_PDF)

            Call SetReportButtonState(btnTagRequestFormBlank, MASTER_TAG_REQUEST_FORM_PDF)
            Call SetReportButtonState(btnTagRequestFormFill, MASTER_TAG_REQUEST_FORM_PDF)

            Call SetReportButtonState(btnTaggingDataFormBlank, MASTER_TAGGING_DATA_FORM_PDF)
            Call SetReportButtonState(btnTaggingDataFormFill, MASTER_TAGGING_DATA_FORM_PDF)

            Call SetReportButtonState(btnTurtleTransferFormBlank, MASTER_TURTLE_TRANSFER_FORM_PDF)
            Call SetReportButtonState(btnTurtleTransferFormFill, MASTER_TURTLE_TRANSFER_FORM_PDF)

            '----------------------------------------------------------------
            '-- hook in the Help File 
            '----------------------------------------------------------------
            gsHelpFileName = Application.StartupPath & "\roster_help.chm"
            hlpHelpProvider.HelpNamespace = gsHelpFileName

        Catch ex As Exception

            ErrorMessageBox.Show(ex)
            Me.Close()

        Finally

            frmSplash.SetMessage()

            If Not (frmSplash Is Nothing) Then
                frmSplash.Close()
                frmSplash = Nothing
            End If

            frmOrganizationInformation = Nothing

            mbIsLoading = False

            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub frmMainForm_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Try
            '----------------------------------------------------------------
            '-- save last user settings
            '----------------------------------------------------------------
            If Not Me.WindowState = FormWindowState.Minimized Then
                My.Settings.MainFormLocation = Me.Location
                My.Settings.MainFormSize = Me.Size
            End If

            My.Settings.MainShowInactiveTurtles = Me.chkShowInactiveTurtles.Checked

            My.Settings.Save()

            '----------------------------------------------------------------
            '-- "clean up" the database
            '----------------------------------------------------------------
            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                oAdoHelper.CleanDatabase()
            End Using

        Catch ex As Exception
            'ErrorMessageBox.Show(ex)
        End Try

    End Sub

    Private Sub cboFilterByList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboFilterByList.SelectedIndexChanged

        If mbIsLoading Then Exit Sub

        If (cboFilterByList.SelectedIndex <= 0) Then
            txtFilterByValue.Text = String.Empty
            txtFilterByValue.Enabled = False
            Call btnRefresh_Click(sender, New System.EventArgs)
        Else
            txtFilterByValue.Enabled = True
            txtFilterByValue.Focus()
            txtFilterByValue.SelectAll()
        End If

    End Sub

    Private Sub txtFilterByValue_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtFilterByValue.KeyDown
        If (e.KeyCode = Keys.Enter) Then
            Call btnRefresh_Click(sender, New System.EventArgs)
        End If
    End Sub

    Private Sub btnRefresh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRefresh.Click
        LoadTurtleGridData()
    End Sub

    Private Function TableExists(ByVal oAdoHelper As AdoHelper, ByVal oTransaction As IDbTransaction, ByVal sTableName As String) As Boolean

        '----------------------------------------------------------------
        '-- I hate coding by exception, but this is the most generic test  
        '-- for the existence of a table.  Also, Access does not have 
        '-- permissions to read the MSysObjects table, so until I figure something else out...
        '----------------------------------------------------------------

        'Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
        '    If (oAdoHelper.DatabaseType = TurtleGeek.Data.DatabaseTypeEnum.SQLite) Then
        '        Return (Convert.ToInt32(oAdoHelper.ExecuteScalar(CommandType.Text, "SELECT COUNT(*) FROM sqlite_master WHERE type = 'table' AND UPPER(name) = UPPER('" & sTableName & "')")) > 0)
        '    ElseIf ((oAdoHelper.DatabaseType = TurtleGeek.Data.DatabaseTypeEnum.OleDb) AndAlso (oAdoHelper.IsAccessDatabase)) Then
        '        Return (Convert.ToInt32(oAdoHelper.ExecuteScalar(CommandType.Text, "SELECT COUNT(*) FROM MSysObjects WHERE Type = 1 AND UCASE(Name) = UCASE('" & sTableName & "')")) > 0)
        '    End If
        'End Using

        Try

            '----------------------------------------------------------------
            '-- I hate coding by exception, but this is the most generic test  
            '-- for the existence of a column.  Also, SQLite does not have 
            '-- a mechanism to determine if a column exists, so until I figure something else out...
            '----------------------------------------------------------------
            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(oTransaction, CommandType.Text, "SELECT * FROM " & sTableName & " WHERE 1 = 2")

                dr.Close()
                Return True

            End Using

        Catch ex As Exception
            Return False
        End Try

    End Function

    Private Function ColumnExists(ByVal oAdoHelper As AdoHelper, ByVal oTransaction As IDbTransaction, ByVal sTableName As String, ByVal sColumnName As String) As Boolean

        If Not TableExists(oAdoHelper, oTransaction, sTableName) Then
            Return False
        End If

        Try

            '----------------------------------------------------------------
            '-- I hate coding by exception, but this is the most generic test  
            '-- for the existence of a column.  Also, SQLite does not have 
            '-- a mechanism to determine if a column exists, so until I figure something else out...
            '----------------------------------------------------------------
            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(oTransaction, CommandType.Text, "SELECT " & sColumnName & " FROM " & sTableName & " WHERE 1 = 2")

                dr.Close()
                Return True

            End Using

        Catch ex As Exception
            Return False
        End Try

    End Function

    Public Sub UpdateDatabase()

        '----------------------------------------------------------------
        '-- expecting sOldDatabaseVersion in major.minor.build format; 
        '-- we convert the major.minor.build format into a number 
        '-- that we can use to compare greater than or less than to
        '----------------------------------------------------------------

        Dim iOldDatabaseVersionAsNumber As Integer
        Dim sOldDatabaseVersion As String
        Dim sAppVersion As String = String.Empty
        Dim sCommandText As String = String.Empty
        Dim sGuidValue As String = String.Empty
        Dim oConnection As IDbConnection = Nothing
        Dim oTransaction As IDbTransaction = Nothing
        Dim oSqlToExecuteList As List(Of String) = Nothing

        Try
            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

                sOldDatabaseVersion = Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, "SELECT db_version FROM sys_info"))
                sAppVersion = My.Application.Info.Version.Major.ToString & "." & My.Application.Info.Version.Minor.ToString & "." & My.Application.Info.Version.Build.ToString
                iOldDatabaseVersionAsNumber = ConvertVersionToNumber(sOldDatabaseVersion)

                '----------------------------------------------------------------
                '-- do all database updates within a transaction
                '----------------------------------------------------------------
                oConnection = oAdoHelper.GetConnection()
                oConnection.Open()
                oTransaction = oConnection.BeginTransaction()

                '----------------------------------------------------------------
                '-- do database upgrades for 2.0.1 -- SQLITE ONLY
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.0.1")) Then

                    sCommandText = "CREATE TABLE IF NOT EXISTS sys_info (db_version VARCHAR(255)) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "INSERT INTO sys_info (db_version) VALUES ('" & sOldDatabaseVersion & "') "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.0.2 -- SQLITE ONLY
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.0.2")) Then

                    sCommandText = "ALTER TABLE turtle ADD COLUMN injury_boat_strike CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN injury_intestinal_impaction CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN injury_line_entanglement CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN injury_fish_hook CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN injury_upper_respiratory CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN injury_animal_bite CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN injury_fibropapilloma CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN injury_misc_epidemic CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN injury_doa CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN injury_other CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    'sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN injury_boat_strike CHAR(1) "
                    'oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    'sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN injury_intestinal_impaction CHAR(1) "
                    'oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    'sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN injury_line_entanglement CHAR(1) "
                    'oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    'sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN injury_fish_hook CHAR(1) "
                    'oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    'sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN injury_upper_respiratory CHAR(1) "
                    'oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    'sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN injury_animal_bite CHAR(1) "
                    'oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    'sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN injury_fibropapilloma CHAR(1) "
                    'oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    'sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN injury_misc_epidemic CHAR(1) "
                    'oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    'sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN injury_doa CHAR(1) "
                    'oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    'sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN injury_other CHAR(1) "
                    'oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.0.3 -- SQLITE ONLY
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.0.3")) Then

                    '-- none

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.0.4 -- SQLITE ONLY
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.0.4")) Then

                    '----------------------------------------------------------------
                    '----------------------------------------------------------------
                    sCommandText = "ALTER TABLE organization ADD COLUMN contact_name VARCHAR(255) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE organization ADD COLUMN hatchling_balance_as_of_date DATETIME "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE organization ADD COLUMN cc_hatchling_starting_balance INTEGER "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE organization ADD COLUMN cm_hatchling_starting_balance INTEGER "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE organization ADD COLUMN dc_hatchling_starting_balance INTEGER "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE organization ADD COLUMN other_hatchling_starting_balance INTEGER "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE organization ADD COLUMN unknown_hatchling_starting_balance INTEGER "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    '----------------------------------------------------------------
                    '----------------------------------------------------------------
                    sCommandText = "CREATE TABLE IF NOT EXISTS [hatchlings_acquired_event] ([hatchlings_acquired_event_id] VARCHAR(36) UNIQUE NOT NULL PRIMARY KEY, [species_code] CHAR(2) NULL, [event_date] DATE NOT NULL, [event_count] INTEGER NULL, [acquired_from_county] VARCHAR(255) NULL);"
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "CREATE TABLE IF NOT EXISTS [hatchlings_died_event] ([hatchlings_died_event_id] VARCHAR(36) UNIQUE NOT NULL PRIMARY KEY, [species_code] CHAR(2) NULL, [event_date] DATE NOT NULL, [event_count] INTEGER NULL);"
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "CREATE TABLE IF NOT EXISTS [hatchlings_released_event] ([hatchlings_released_event_id] VARCHAR(36) UNIQUE NOT NULL PRIMARY KEY, [species_code] CHAR(2) NULL, [event_date] DATE NOT NULL, [beach_event_count] INTEGER NULL, [offshore_event_count] INTEGER NULL);"
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.0.5
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.0.5")) Then

                    '-- none

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.0.6 -- need to accommodate both SQLITE and ACCESS starting with this version
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.0.6")) Then

                    '-- none

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.0.7 -- need to accommodate both SQLITE and ACCESS
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.0.7")) Then

                    '----------------------------------------------------------------
                    '-- data points for the TAGGING DATA FORM
                    '----------------------------------------------------------------
                    sCommandText = "ALTER TABLE turtle ADD COLUMN was_carrying_tags_when_enc CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN recapture_type CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN tag_return_address VARCHAR(255) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN capture_project_type CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN did_turtle_nest CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN capture_project_other VARCHAR(255) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN acquired_county VARCHAR(255) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN acquired_latitude SINGLE "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN acquired_longitude SINGLE "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN relinquished_county VARCHAR(255) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN relinquished_latitude SINGLE "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN relinquished_longitude SINGLE "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN inspected_for_tag_scars CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN tag_scars_located VARCHAR(255) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN scanned_for_pit_tags CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN pit_tags_scan_frequency VARCHAR(255) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN scanned_for_magnetic_wires CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN magnetic_wires_located VARCHAR(255) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN inspected_for_living_tags CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE turtle ADD COLUMN living_tags_located VARCHAR(255) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    '----------------------------------------------------------------
                    '-- data points for the TAGGING DATA FORM / TURTLE MEASUREMENTS
                    '----------------------------------------------------------------
                    sCommandText = "CREATE TABLE turtle_morphometric (turtle_morphometric_id VARCHAR(36) NOT NULL PRIMARY KEY, turtle_id VARCHAR(36) NOT NULL, date_measured DATETIME, scl_notch_notch_value SINGLE, scl_notch_notch_units CHAR(2), scl_notch_tip_value SINGLE, scl_notch_tip_units CHAR(2), scl_tip_tip_value SINGLE, scl_tip_tip_units CHAR(2), scw_value SINGLE, scw_units CHAR(2), ccl_notch_notch_value SINGLE, ccl_notch_notch_units CHAR(2), ccl_notch_tip_value SINGLE, ccl_notch_tip_units CHAR(2), ccl_tip_tip_value SINGLE, ccl_tip_tip_units CHAR(2), ccw_value SINGLE, ccw_units CHAR(2), weight_value SINGLE, weight_units CHAR(2)) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    '-- [I]mperial; [M]etric
                    sCommandText = "ALTER TABLE organization ADD COLUMN preferred_units_type CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.0.8 -- need to accommodate both SQLITE and ACCESS
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.0.8")) Then

                    '----------------------------------------------------------------
                    '-- add WASHBACK starting balance data fields to ORGANIZATION
                    '----------------------------------------------------------------
                    sCommandText = "ALTER TABLE organization ADD COLUMN washback_balance_as_of_date DATETIME "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE organization ADD COLUMN cc_washback_starting_balance INTEGER "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE organization ADD COLUMN cm_washback_starting_balance INTEGER "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE organization ADD COLUMN dc_washback_starting_balance INTEGER "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE organization ADD COLUMN other_washback_starting_balance INTEGER "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE organization ADD COLUMN unknown_washback_starting_balance INTEGER "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    '----------------------------------------------------------------
                    '-- add WASHBACK event tables
                    '----------------------------------------------------------------
                    sCommandText = "CREATE TABLE washbacks_acquired_event (washbacks_acquired_event_id VARCHAR(36) UNIQUE NOT NULL PRIMARY KEY, species_code CHAR(2) NULL, event_date DATETIME NOT NULL, event_count INTEGER NULL, acquired_from_county VARCHAR(255) NULL)"
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "CREATE TABLE washbacks_died_event (washbacks_died_event_id VARCHAR(36) UNIQUE NOT NULL PRIMARY KEY, species_code CHAR(2) NULL, event_date DATETIME NOT NULL, event_count INTEGER NULL)"
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "CREATE TABLE washbacks_released_event (washbacks_released_event_id VARCHAR(36) UNIQUE NOT NULL PRIMARY KEY, species_code CHAR(2) NULL, event_date DATETIME NOT NULL, beach_event_count INTEGER NULL, offshore_event_count INTEGER NULL)"
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.0.9 -- need to accommodate both SQLITE and ACCESS
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.0.9")) Then

                    '-- none

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.1.0 -- need to accommodate both SQLITE and ACCESS
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.1.0")) Then

                    '-- none

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.1.1 -- need to accommodate both SQLITE and ACCESS
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.1.1")) Then

                    ''----------------------------------------------------------------
                    ''-- data points for the TAGGING DATA FORM for DELETED turtle table
                    ''----------------------------------------------------------------
                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "was_carrying_tags_when_enc") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN was_carrying_tags_when_enc CHAR(1) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "recapture_type") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN recapture_type CHAR(1) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "tag_return_address") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN tag_return_address VARCHAR(255) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "was_carrying_tags_when_enc") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN capture_project_type CHAR(1) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "did_turtle_nest") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN did_turtle_nest CHAR(1) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "capture_project_other") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN capture_project_other VARCHAR(255) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "acquired_county") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN acquired_county VARCHAR(255) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "acquired_latitude") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN acquired_latitude SINGLE "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "acquired_longitude") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN acquired_longitude SINGLE "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "relinquished_county") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN relinquished_county VARCHAR(255) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "relinquished_latitude") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN relinquished_latitude SINGLE "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "relinquished_longitude") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN relinquished_longitude SINGLE "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "inspected_for_tag_scars") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN inspected_for_tag_scars CHAR(1) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "tag_scars_located") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN tag_scars_located VARCHAR(255) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "scanned_for_pit_tags") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN scanned_for_pit_tags CHAR(1) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "pit_tags_scan_frequency") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN pit_tags_scan_frequency VARCHAR(255) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "scanned_for_magnetic_wires") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN scanned_for_magnetic_wires CHAR(1) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "magnetic_wires_located") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN magnetic_wires_located VARCHAR(255) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "inspected_for_living_tags") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN inspected_for_living_tags CHAR(1) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "living_tags_located") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN living_tags_located VARCHAR(255) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    ''----------------------------------------------------------------
                    ''-- data points for the DELETED turtle measurements
                    ''----------------------------------------------------------------
                    'If Not TableExists(oAdoHelper, oTransaction, "deleted_turtle_morphometric") Then
                    '    sCommandText = "CREATE TABLE deleted_turtle_morphometric (turtle_morphometric_id VARCHAR(36) NOT NULL PRIMARY KEY, turtle_id VARCHAR(36) NOT NULL, date_measured DATETIME, scl_notch_notch_value SINGLE, scl_notch_notch_units CHAR(2), scl_notch_tip_value SINGLE, scl_notch_tip_units CHAR(2), scl_tip_tip_value SINGLE, scl_tip_tip_units CHAR(2), scw_value SINGLE, scw_units CHAR(2), ccl_notch_notch_value SINGLE, ccl_notch_notch_units CHAR(2), ccl_notch_tip_value SINGLE, ccl_notch_tip_units CHAR(2), ccl_tip_tip_value SINGLE, ccl_tip_tip_units CHAR(2), ccw_value SINGLE, ccw_units CHAR(2), weight_value SINGLE, weight_units CHAR(2)) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.1.2 -- need to accommodate both SQLITE and ACCESS
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.1.2")) Then

                    '-- none

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.1.3 -- need to accommodate both SQLITE and ACCESS
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.1.3")) Then

                    '----------------------------------------------------------------
                    '-- add hatchling and washback DOA event tables
                    '----------------------------------------------------------------
                    If Not TableExists(oAdoHelper, oTransaction, "hatchlings_doa_event") Then
                        sCommandText = "CREATE TABLE hatchlings_doa_event (hatchlings_doa_event_id VARCHAR(36) UNIQUE NOT NULL PRIMARY KEY, species_code CHAR(2) NULL, event_date DATETIME NOT NULL, event_count INTEGER NULL, doa_from_county VARCHAR(255) NULL)"
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    End If

                    If Not TableExists(oAdoHelper, oTransaction, "washbacks_doa_event") Then
                        sCommandText = "CREATE TABLE washbacks_doa_event (washbacks_doa_event_id VARCHAR(36) UNIQUE NOT NULL PRIMARY KEY, species_code CHAR(2) NULL, event_date DATETIME NOT NULL, event_count INTEGER NULL, doa_from_county VARCHAR(255) NULL)"
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    End If

                    '----------------------------------------------------------------
                    '-- add county table
                    '----------------------------------------------------------------
                    If Not TableExists(oAdoHelper, oTransaction, "county") Then

                        sCommandText = "CREATE TABLE county (county_id VARCHAR(36) UNIQUE NOT NULL PRIMARY KEY, county_name VARCHAR(255) NOT NULL)"
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Alachua') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Baker') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Bay') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Bradford') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Brevard') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Broward') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Calhoun') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Charlotte') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Citrus') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Clay') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Collier') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Columbia') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'DeSoto') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Dixie') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Duval') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Escambia') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Flagler') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Franklin') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Gadsden') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Gilchrist') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Glades') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Gulf') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Hamilton') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Hardee') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Hendry') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Hernando') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Highlands') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Hillsborough') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Holmes') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Indian River') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Jackson') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Jefferson') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Lafayette') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Lake') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Lee') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Leon') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Levy') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Liberty') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Madison') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Manatee') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Marion') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Martin') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Miami-Dade') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Monroe') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Nassau') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Okaloosa') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Okeechobee') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Orange') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Osceloa') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Palm Beach') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Pasco') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Pinellas') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Polk') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Putnam') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'St. Johns') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'St. Lucie') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Santa Rosa') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Sarasota') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Seminole') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Sumter') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Suwannee') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Taylor') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Union') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Volusia') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Wakulla') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Walton') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                        sGuidValue = Guid.NewGuid().ToString().Trim().ToUpper()
                        sCommandText = "INSERT INTO county (county_id, county_name) VALUES ('" & sGuidValue & "', 'Washington') "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    End If

                    '----------------------------------------------------------------
                    '-- standardize county name values
                    '----------------------------------------------------------------
                    oSqlToExecuteList = New List(Of String)()

                    UpdateDatabaseSetFixCountiesSql(oAdoHelper, oTransaction, "acquired_county", "turtle_id", "turtle", oSqlToExecuteList)
                    'UpdateDatabaseSetFixCountiesSql(oAdoHelper, oTransaction, "acquired_county", "turtle_id", "deleted_turtle", oSqlToExecuteList)
                    UpdateDatabaseSetFixCountiesSql(oAdoHelper, oTransaction, "relinquished_county", "turtle_id", "turtle", oSqlToExecuteList)
                    'UpdateDatabaseSetFixCountiesSql(oAdoHelper, oTransaction, "relinquished_county", "turtle_id", "deleted_turtle", oSqlToExecuteList)

                    UpdateDatabaseSetFixCountiesSql(oAdoHelper, oTransaction, "acquired_from_county", "hatchlings_acquired_event_id", "hatchlings_acquired_event", oSqlToExecuteList)
                    UpdateDatabaseSetFixCountiesSql(oAdoHelper, oTransaction, "doa_from_county", "hatchlings_doa_event_id", "hatchlings_doa_event", oSqlToExecuteList)
                    UpdateDatabaseSetFixCountiesSql(oAdoHelper, oTransaction, "acquired_from_county", "washbacks_acquired_event_id", "washbacks_acquired_event", oSqlToExecuteList)
                    UpdateDatabaseSetFixCountiesSql(oAdoHelper, oTransaction, "doa_from_county", "washbacks_doa_event_id", "washbacks_doa_event", oSqlToExecuteList)

                    For Each sSqlToExecute As String In oSqlToExecuteList
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sSqlToExecute)
                    Next

                    '----------------------------------------------------------------
                    '-- add initial TURTLE BROCHURE fields
                    '----------------------------------------------------------------
                    If Not ColumnExists(oAdoHelper, oTransaction, "turtle", "brochure_comments") Then
                        sCommandText = "ALTER TABLE turtle ADD COLUMN brochure_comments VARCHAR(255) "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "brochure_comments") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN brochure_comments VARCHAR(255) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    If Not ColumnExists(oAdoHelper, oTransaction, "turtle", "brochure_background_color") Then
                        sCommandText = "ALTER TABLE turtle ADD COLUMN brochure_background_color INT "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    End If

                    sCommandText = "UPDATE turtle SET brochure_background_color = -1 "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "brochure_background_color") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN brochure_background_color INT "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                    'sCommandText = "UPDATE deleted_turtle SET brochure_background_color = -1 "
                    'oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    If Not ColumnExists(oAdoHelper, oTransaction, "turtle", "brochure_image_file_attachment_id") Then
                        sCommandText = "ALTER TABLE turtle ADD COLUMN brochure_image_file_attachment_id VARCHAR(255) "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    End If

                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "brochure_image_file_attachment_id") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN brochure_image_file_attachment_id VARCHAR(255) "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.1.4 -- need to accommodate both SQLITE and ACCESS
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.1.4")) Then

                    '----------------------------------------------------------------
                    '-- data points washbacks under 5cm CLSL
                    '----------------------------------------------------------------
                    sCommandText = "ALTER TABLE washbacks_acquired_event ADD COLUMN under_5cm_clsl CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE washbacks_died_event ADD COLUMN under_5cm_clsl CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                    sCommandText = "ALTER TABLE washbacks_doa_event ADD COLUMN under_5cm_clsl CHAR(1) "
                    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)


                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.1.7 -- need to accommodate both SQLITE and ACCESS
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.1.7")) Then

                    '----------------------------------------------------------------
                    '-- data points for the TAGGING DATA FORM for TURTLE table
                    '----------------------------------------------------------------
                    If Not ColumnExists(oAdoHelper, oTransaction, "turtle", "date_captured") Then
                        sCommandText = "ALTER TABLE turtle ADD COLUMN date_captured DATETIME "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    End If

                    ''----------------------------------------------------------------
                    ''-- data points for the TAGGING DATA FORM for DELETED turtle table
                    ''----------------------------------------------------------------
                    'If Not ColumnExists(oAdoHelper, oTransaction, "deleted_turtle", "date_captured") Then
                    '    sCommandText = "ALTER TABLE deleted_turtle ADD COLUMN date_captured DATETIME "
                    '    oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    'End If

                End If

                '----------------------------------------------------------------
                '-- do database upgrades for 2.2.3
                '----------------------------------------------------------------
                If (iOldDatabaseVersionAsNumber < ConvertVersionToNumber("2.2.3")) Then

                    '----------------------------------------------------------------
                    '-- no longer using archive tables
                    '----------------------------------------------------------------
                    If TableExists(oAdoHelper, oTransaction, "deleted_turtle") Then
                        sCommandText = "DROP TABLE deleted_turtle "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    End If

                    If TableExists(oAdoHelper, oTransaction, "deleted_turtle_morphometric") Then
                        sCommandText = "DROP TABLE deleted_turtle_morphometric "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    End If

                    If TableExists(oAdoHelper, oTransaction, "deleted_turtle_tag") Then
                        sCommandText = "DROP TABLE deleted_turtle_tag "
                        oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)
                    End If
                End If

                '----------------------------------------------------------------
                '-- set the db_version regardless of upgrade status
                '----------------------------------------------------------------
                sCommandText = "DELETE FROM sys_info "
                oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                sCommandText = "INSERT INTO sys_info (db_version) VALUES ('" & sAppVersion & "') "
                oAdoHelper.ExecuteNonQuery(oTransaction, CommandType.Text, sCommandText)

                oTransaction.Commit()

            End Using

        Catch ex As Exception

            If Not (oTransaction Is Nothing) Then
                oTransaction.Rollback()
            End If

            ErrorMessageBox.Show(ex)
            Throw

        Finally

            If Not (oTransaction Is Nothing) Then
                oTransaction.Dispose()
                oTransaction = Nothing
            End If

            If Not (oConnection Is Nothing) Then
                If (oConnection.State <> ConnectionState.Closed) Then
                    oConnection.Close()
                End If
                oConnection.Dispose()
                oConnection = Nothing
            End If

        End Try

    End Sub

    Private Sub UpdateDatabaseSetFixCountiesSql(ByVal oAdoHelper As AdoHelper, ByVal oTransaction As IDbTransaction, ByVal sColumnNameCounty As String, ByVal sColumnNameId As String, ByVal sTableName As String, ByVal oSqlToExecuteList As List(Of String))

        Dim s As String = String.Empty
        Dim sCountyNameValue As String = String.Empty
        Dim sIdValue As String = String.Empty

        s = "SELECT " & sColumnNameId & ", " & sColumnNameCounty & " FROM " & sTableName & " "

        Using dr As SafeDataReader = oAdoHelper.ExecuteReader(oTransaction, CommandType.Text, s)

            While dr.Read()

                sIdValue = dr.GetString(sColumnNameId).Trim().ToUpper()
                sCountyNameValue = dr.GetString(sColumnNameCounty).Trim().ToUpper()

                If (String.IsNullOrEmpty(sCountyNameValue)) Then
                    oSqlToExecuteList.Add("UPDATE " & sTableName & " SET " & sColumnNameCounty & " = NULL WHERE " & sColumnNameId & " = '" & sIdValue & "'")
                Else
                    If (sCountyNameValue.StartsWith("BRE")) Then
                        oSqlToExecuteList.Add("UPDATE " & sTableName & " SET " & sColumnNameCounty & " = 'Brevard' WHERE " & sColumnNameId & " = '" & sIdValue & "'")
                    ElseIf (sCountyNameValue.StartsWith("FLA")) Then
                        oSqlToExecuteList.Add("UPDATE " & sTableName & " SET " & sColumnNameCounty & " = 'Flagler' WHERE " & sColumnNameId & " = '" & sIdValue & "'")
                    ElseIf (sCountyNameValue.StartsWith("IND")) Then
                        oSqlToExecuteList.Add("UPDATE " & sTableName & " SET " & sColumnNameCounty & " = 'Indian River' WHERE " & sColumnNameId & " = '" & sIdValue & "'")
                    ElseIf (sCountyNameValue.StartsWith("PIN")) Then
                        oSqlToExecuteList.Add("UPDATE " & sTableName & " SET " & sColumnNameCounty & " = 'Pinellas' WHERE " & sColumnNameId & " = '" & sIdValue & "'")
                    ElseIf (sCountyNameValue.StartsWith("ST J")) Then
                        oSqlToExecuteList.Add("UPDATE " & sTableName & " SET " & sColumnNameCounty & " = 'St. Johns' WHERE " & sColumnNameId & " = '" & sIdValue & "'")
                    ElseIf (sCountyNameValue.StartsWith("ST. J")) Then
                        oSqlToExecuteList.Add("UPDATE " & sTableName & " SET " & sColumnNameCounty & " = 'St. Johns' WHERE " & sColumnNameId & " = '" & sIdValue & "'")
                    ElseIf (sCountyNameValue.StartsWith("ST L")) Then
                        oSqlToExecuteList.Add("UPDATE " & sTableName & " SET " & sColumnNameCounty & " = 'St. Lucie' WHERE " & sColumnNameId & " = '" & sIdValue & "'")
                    ElseIf (sCountyNameValue.StartsWith("ST. L")) Then
                        oSqlToExecuteList.Add("UPDATE " & sTableName & " SET " & sColumnNameCounty & " = 'St. Lucie' WHERE " & sColumnNameId & " = '" & sIdValue & "'")
                    ElseIf (sCountyNameValue.StartsWith("VOL")) Then
                        oSqlToExecuteList.Add("UPDATE " & sTableName & " SET " & sColumnNameCounty & " = 'Volusia' WHERE " & sColumnNameId & " = '" & sIdValue & "'")
                    End If
                End If

            End While

        End Using ' dr

    End Sub

    Public Function ConvertVersionToNumber(ByVal sVersionAsMajorMinorRevision As String) As Integer

        Dim iVersionAsNumber As Integer = 0
        Dim oRegex As Regex
        Dim oMatch As Match

        If Not String.IsNullOrEmpty(sVersionAsMajorMinorRevision) Then

            oRegex = New Regex("([0-9]*)\.([0-9]*)\.([0-9]*)")

            oMatch = oRegex.Match(sVersionAsMajorMinorRevision)

            If oMatch.Success Then

                iVersionAsNumber = (Convert.ToInt32(oMatch.Groups(1).Value) * 10000) + (Convert.ToInt32(oMatch.Groups(2).Value) * 100) + Convert.ToInt32(oMatch.Groups(3).Value)

            End If

            oMatch = Nothing
            oRegex = Nothing

        End If

        Return iVersionAsNumber

    End Function

    Public Sub SetReportButtonState(ByVal oReportButton As Button, ByVal sReportFileName As String)

        If Not System.IO.File.Exists(sReportFileName) Then
            erpErrorProvider.SetError(oReportButton, "'" & sReportFileName & "' file not found")
            oReportButton.Enabled = False
            oReportButton.BackColor = Color.LightGray
        End If

    End Sub

#End Region

#Region " File Menu "

    Private Sub mnuFileExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuFileExit.Click

        Try

            Me.Close()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

#End Region

#Region " Admin Menu "

    Private Sub mnuAdminCounties_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdminCounties.Click

        Dim frm As CountyListForm = Nothing

        Try

            '----------------------------------------------------------------
            '-- display the County LIST form
            '----------------------------------------------------------------
            frm = New CountyListForm

            frm.ShowDialog(Me)


        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            If Not (frm Is Nothing) Then
                frm.Dispose()
                frm = Nothing
            End If

        End Try

    End Sub

    Private Sub mnuAdminLatitudeLongitudeHelper_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuAdminLatitudeLongitudeHelper.Click

        Dim frm As LatLonHelperForm = Nothing

        Try

            '----------------------------------------------------------------
            '-- display the LAT/LON HELPER form; default to Tequesta, FL
            '----------------------------------------------------------------
            frm = New LatLonHelperForm(My.Resources.app_ico, Application.ProductName, 26.9601, -80.101589)

            frm.ShowDialog(Me)


        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            If Not (frm Is Nothing) Then
                frm.Dispose()
                frm = Nothing
            End If

        End Try

    End Sub

#End Region

#Region " Help Menu "

    Private Sub mnuHelp_Popup(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelp.Popup

        '----------------------------------------------------------------
        '-- enabled/disable the Error Log menu items, 
        '-- depending on the existence of the Error Log file
        '----------------------------------------------------------------
        If Not System.IO.File.Exists("ErrorLog.txt") Then
            Me.mnuHelpViewErrorLog.Enabled = False
            Me.mnuHelpClearErrorLog.Enabled = False
        End If

    End Sub

    Private Sub mnuHelpContents_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpContents.Click
        Help.ShowHelp(Me, gsHelpFileName)
    End Sub

    Private Sub mnuHelpIndexClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpIndex.Click
        Help.ShowHelpIndex(Me, gsHelpFileName)
    End Sub

    Private Sub mnuHelpSearchClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpSearch.Click
        Help.ShowHelp(Me, gsHelpFileName, HelpNavigator.Find, "")
    End Sub

    Private Sub mnuHelpViewErrorLog_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelpViewErrorLog.Click

        Dim sErrorLogFile As String = String.Empty
        Dim sWindowsDirectory As String = String.Empty
        Dim sCommand As String = String.Empty

        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- verify that the All SQL Log file exists
            '----------------------------------------------------------------
            sErrorLogFile = ErrorLogWriter.ERROR_LOG_FILE_NAME

            If System.IO.File.Exists(sErrorLogFile) Then

                '----------------------------------------------------------------
                '-- set up to use Notepad to view the log file;
                '-- if unable to find Notepad, then just launch the file 
                '-- and have the system either run the application associated 
                '-- with the file extension -or- the system will prompt 
                '-- the user for which application to run to view the file
                '----------------------------------------------------------------
                sWindowsDirectory = System.Environment.GetFolderPath(Environment.SpecialFolder.System).Trim
                If Not (sWindowsDirectory.EndsWith("\")) Then
                    sWindowsDirectory &= "\"
                End If

                If (System.IO.File.Exists(sWindowsDirectory & "Notepad.exe")) Then
                    sCommand = sWindowsDirectory & "Notepad.exe " & sErrorLogFile
                Else
                    sCommand = sErrorLogFile
                End If

                '----------------------------------------------------------------
                '-- finally, launch the application to view the contents of the file
                '----------------------------------------------------------------
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                System.Diagnostics.Process.Start(sCommand)
                System.Windows.Forms.Cursor.Current = Cursors.Default
            Else
                '----------------------------------------------------------------
                '-- else, the error log file does NOT exist
                '----------------------------------------------------------------
                MessageBox.Show("Unable to find the error log file named '" & sErrorLogFile & "'.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch winex As System.ComponentModel.Win32Exception

            Try
                '----------------------------------------------------------------
                '-- try again, hoping that the filename extension 
                '-- is associated with something to display the file
                '----------------------------------------------------------------
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                System.Diagnostics.Process.Start(sErrorLogFile)
                System.Windows.Forms.Cursor.Current = Cursors.Default

            Catch ex As Exception
                System.Windows.Forms.Cursor.Current = Cursors.Default
                ErrorMessageBox.Show(ex)
            End Try

        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub mnuHelpClearErrorLog_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles mnuHelpClearErrorLog.Click

        Dim sErrorLogFile As String = String.Empty

        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- verify that the All SQL Log file exists
            '----------------------------------------------------------------
            sErrorLogFile = ErrorLogWriter.ERROR_LOG_FILE_NAME

            If System.IO.File.Exists(sErrorLogFile) Then

                '----------------------------------------------------------------
                '-- confirm the deletion
                '----------------------------------------------------------------
                If (System.Windows.Forms.DialogResult.Yes = MessageBox.Show("Clear the error log file?", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2)) Then
                    System.IO.File.Delete(sErrorLogFile)
                End If

            Else
                '----------------------------------------------------------------
                '-- else, the error log file does NOT exist
                '----------------------------------------------------------------
                MessageBox.Show("Unable to find the error log file named '" & sErrorLogFile & "'.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If

        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = Cursors.Default
            ErrorMessageBox.Show(ex)

        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub mnuHelpAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuHelpAbout.Click

        Dim frm As AboutBoxDlg

        Try

            '----------------------------------------------------------------
            '-- display the About ROSTER... dialog box
            '----------------------------------------------------------------
            frm = New AboutBoxDlg
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

#End Region

#Region " Organization "

    Private Sub LoadOrganizationInformation()

        Dim oOrganization As Organization

        oOrganization = Organization.GetOrganization

        '----------------------------------------------------------------
        '-- populate the ORGANIZATION Information labels
        '----------------------------------------------------------------
        Me.lblOrganizationName.Text = oOrganization.OrganizationName
        Me.lblAddress1.Text = oOrganization.Address1
        Me.lblAddress2.Text = oOrganization.Address2
        Me.lblCity.Text = oOrganization.City
        Me.lblState.Text = oOrganization.State
        Me.lblZipCode.Text = oOrganization.ZipCode
        Me.lblPhone.Text = oOrganization.Phone
        Me.lblFax.Text = oOrganization.Fax
        Me.lblEmailAddress.Text = oOrganization.EmailAddress
        Me.lblContactName.Text = oOrganization.ContactName
        Me.lblPermitNumber.Text = oOrganization.PermitNumber

        Me.lblHatchlingBalanceAsOfDate.Text = oOrganization.HatchlingBalanceAsOfDateString
        Me.lblCcHatchlingStartingBalance.Text = Convert.ToString(oOrganization.CcHatchlingStartingBalance)
        Me.lblCmHatchlingStartingBalance.Text = Convert.ToString(oOrganization.CmHatchlingStartingBalance)
        Me.lblDcHatchlingStartingBalance.Text = Convert.ToString(oOrganization.DcHatchlingStartingBalance)
        Me.lblOtherHatchlingStartingBalance.Text = Convert.ToString(oOrganization.OtherHatchlingStartingBalance)
        Me.lblUnknownHatchlingStartingBalance.Text = Convert.ToString(oOrganization.UnknownHatchlingStartingBalance)

        Me.lblWashbackBalanceAsOfDate.Text = oOrganization.WashbackBalanceAsOfDateString
        Me.lblCcWashbackStartingBalance.Text = Convert.ToString(oOrganization.CcWashbackStartingBalance)
        Me.lblCmWashbackStartingBalance.Text = Convert.ToString(oOrganization.CmWashbackStartingBalance)
        Me.lblDcWashbackStartingBalance.Text = Convert.ToString(oOrganization.DcWashbackStartingBalance)
        Me.lblOtherWashbackStartingBalance.Text = Convert.ToString(oOrganization.OtherWashbackStartingBalance)
        Me.lblUnknownWashbackStartingBalance.Text = Convert.ToString(oOrganization.UnknownWashbackStartingBalance)

        '----------------------------------------------------------------
        '-- display required field indicators for ORGANIZATION
        '----------------------------------------------------------------
        If (oOrganization.OrganizationName.Trim.Length = 0) Then
            erpErrorProvider.SetError(Me.lblOrganizationName, "Organization Name is required")
            erpErrorProvider.SetIconAlignment(Me.lblOrganizationName, ErrorIconAlignment.MiddleLeft)
            Me.lblOrganizationName.Text = "<Organization Name is required>"
        Else
            erpErrorProvider.SetError(Me.lblOrganizationName, "")
        End If

        If (oOrganization.PermitNumber.Trim.Length = 0) Then
            erpErrorProvider.SetError(Me.lblPermitNumber, "Permit Number is required")
            erpErrorProvider.SetIconAlignment(Me.lblPermitNumber, ErrorIconAlignment.MiddleLeft)
            Me.lblPermitNumber.Text = "<Permit Number is required>"
        Else
            erpErrorProvider.SetError(Me.lblPermitNumber, "")
        End If


    End Sub

    Private Sub btnEditOrganization_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEditOrganization.Click

        Dim frm As OrganizationInformationDlg

        Try

            frm = New OrganizationInformationDlg(Organization.GetOrganization)

            frm.ShowDialog(Me)
            '----------------------------------------------------------------
            '-- if okay, save and continue
            '----------------------------------------------------------------
            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                '----------------------------------------------------------------
                '-- populate the Organization Information labels
                '----------------------------------------------------------------
                LoadOrganizationInformation()

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

#End Region

#Region " FWC Forms and Reports "

    Private Sub btnBeachRestorationProjectMonitoringTableBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBeachRestorationProjectMonitoringTableBlank.Click

        Call CreateBlankPdf(MASTER_BEACH_RESTORATION_PROJECT_MONITORING_PDF)

    End Sub

    Private Sub btnMarineTurtleHoldingFacilityQuarterlyReportBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarineTurtleHoldingFacilityQuarterlyReportBlank.Click

        Call CreateBlankPdf(MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_ALL_PAGES_PDF)

    End Sub

    Private Sub btnMarineTurtleHoldingFacilityQuarterlyReportFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarineTurtleHoldingFacilityQuarterlyReportFill.Click

        Dim frm As MarineTurtleHoldingFacilityQuarterlyReportFormsDlg

        Try

            If Not System.IO.File.Exists(MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_1_PDF) Then
                MessageBox.Show("'" & MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_1_PDF & "' file not found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Not System.IO.File.Exists(MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_2_PDF) Then
                MessageBox.Show("'" & MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_2_PDF & "' file not found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            If Not System.IO.File.Exists(MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_3_PDF) Then
                MessageBox.Show("'" & MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_3_PDF & "' file not found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            frm = New MarineTurtleHoldingFacilityQuarterlyReportFormsDlg
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing
            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsBlank.Click

        Call CreateBlankPdf(MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_HATCHLINGS_PDF)

    End Sub

    Private Sub btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsFill.Click

        Dim frm As MarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsDlg

        Try

            If Not System.IO.File.Exists(MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_HATCHLINGS_PDF) Then
                MessageBox.Show("'" & MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_HATCHLINGS_PDF & "' file not found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            frm = New MarineTurtleCaptiveFacilityQuarterlyReportForHatchlingsDlg
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing
            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksBlank.Click

        Call CreateBlankPdf(MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_WASHBACKS_PDF)

    End Sub

    Private Sub btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnMarineTurtleCaptiveFacilityQuarterlyReportForWashbacksFill.Click

        Dim frm As MarineTurtleCaptiveFacilityQuarterlyReportForWashbacksDlg

        Try

            If Not System.IO.File.Exists(MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_WASHBACKS_PDF) Then
                MessageBox.Show("'" & MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_WASHBACKS_PDF & "' file not found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            frm = New MarineTurtleCaptiveFacilityQuarterlyReportForWashbacksDlg
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing
            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnDisorientationIncidentFormBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisorientationIncidentFormBlank.Click

        Call CreateBlankPdf(MASTER_DISORIENTATION_INCIDENT_REPORT_FORM_PDF)

    End Sub

    Private Sub btnDisorientationIncidentFormFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisorientationIncidentFormFill.Click

        Call ShowManualFillForm(MASTER_DISORIENTATION_INCIDENT_REPORT_FORM_PDF)

    End Sub

    Private Sub btnDisorientationIncidentFormDirectionsBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisorientationIncidentFormDirectionsBlank.Click

        Call CreateBlankPdf(MASTER_DISORIENTATION_INCIDENT_REPORT_FORM_DIRECTIONS_PDF)

    End Sub

    Private Sub btnObstructedNestingAttemptFormFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObstructedNestingAttemptFormFill.Click

        Call ShowManualFillForm(MASTER_OBSTRUCTED_NESTING_ATTEMPT_REPORT_FORM_PDF)

    End Sub

    Private Sub btnObstructedNestingAttemptFormBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObstructedNestingAttemptFormBlank.Click

        Call CreateBlankPdf(MASTER_OBSTRUCTED_NESTING_ATTEMPT_REPORT_FORM_PDF)

    End Sub

    Private Sub btnObstructedNestingAttemptFormDirectionsBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnObstructedNestingAttemptFormDirectionsBlank.Click

        Call CreateBlankPdf(MASTER_OBSTRUCTED_NESTING_ATTEMPT_REPORT_FORM_DIRECTIONS_PDF)

    End Sub

    Private Sub btnEducationalPresentationsUsingLiveTurtlesFormBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEducationalPresentationsUsingLiveTurtlesFormBlank.Click

        Call CreateBlankPdf(MASTER_EDUCATIONAL_PRESENTATION_FORM_PDF)

    End Sub

    Private Sub btnEducationalPresentationsUsingLiveTurtlesFormFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEducationalPresentationsUsingLiveTurtlesFormFill.Click

        Call ShowManualFillForm(MASTER_EDUCATIONAL_PRESENTATION_FORM_PDF)

    End Sub

    Private Sub btnNecropsyFormBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNecropsyFormBlank.Click

        Call CreateBlankPdf(MASTER_NECROPSY_FORM_PDF)

    End Sub

    Private Sub btnNecropsyFormFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNecropsyFormFill.Click

        Call ShowManualFillForm(MASTER_NECROPSY_FORM_PDF)

    End Sub

    Private Sub btnNighttimePublicHatchlingReleaseFormBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNighttimePublicHatchlingReleaseFormBlank.Click

        Call CreateBlankPdf(MASTER_NIGHTTIME_PUBLIC_HATCHLING_RELEASE_FORM_PDF)

    End Sub

    Private Sub btnNighttimePublicHatchlingReleaseFormFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNighttimePublicHatchlingReleaseFormFill.Click

        Call ShowManualFillForm(MASTER_NIGHTTIME_PUBLIC_HATCHLING_RELEASE_FORM_PDF)

    End Sub

    Private Sub btnPapillomaFormBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPapillomaFormBlank.Click

        Call CreateBlankPdf(MASTER_PAILLOMA_FORM_PDF)

    End Sub

    Private Sub btnPapillomaFormFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPapillomaFormFill.Click

        Call ShowManualFillForm(MASTER_PAILLOMA_FORM_PDF)

    End Sub

    Private Sub btnPublicTurtleWatchScheduleFormBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPublicTurtleWatchScheduleFormBlank.Click

        Call CreateBlankPdf(MASTER_PUBLIC_TURTLE_WATCH_SCHEDULE_FORMS_PDF)

    End Sub

    Private Sub btnPublicTurtleWatchScheduleFormFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPublicTurtleWatchScheduleFormFill.Click

        Call ShowManualFillForm(MASTER_PUBLIC_TURTLE_WATCH_SCHEDULE_FORMS_PDF)

    End Sub

    Private Sub btnPublicTurtleWatchSummaryFormBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPublicTurtleWatchSummaryFormBlank.Click

        Call CreateBlankPdf(MASTER_PUBLIC_TURTLE_WATCH_SUMMARY_FORMS_PDF)

    End Sub

    Private Sub btnPublicTurtleWatchSummaryFormFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPublicTurtleWatchSummaryFormFill.Click

        Call ShowManualFillForm(MASTER_PUBLIC_TURTLE_WATCH_SUMMARY_FORMS_PDF)

    End Sub

    Private Sub btnStrandingAndSalvageFormBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStrandingAndSalvageFormBlank.Click

        Call CreateBlankPdf(MASTER_STRANDING_AND_SALVAGE_FORM_PDF)

    End Sub

    Private Sub btnStrandingAndSalvageFormFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnStrandingAndSalvageFormFill.Click

        Call ShowManualFillForm(MASTER_STRANDING_AND_SALVAGE_FORM_PDF)

    End Sub

    Private Sub btnTagRequestFormBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTagRequestFormBlank.Click

        Call CreateBlankPdf(MASTER_TAG_REQUEST_FORM_PDF)

    End Sub

    Private Sub btnTagRequestFormFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTagRequestFormFill.Click

        Call ShowManualFillForm(MASTER_TAG_REQUEST_FORM_PDF)

    End Sub

    Private Sub btnTaggingDataFormBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaggingDataFormBlank.Click

        Call CreateBlankPdf(MASTER_TAGGING_DATA_FORM_PDF)

    End Sub

    Private Sub btnTaggingDataFormFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaggingDataFormFill.Click

        Dim frm As TaggingDataFormDlg

        Try

            If Not System.IO.File.Exists(MASTER_TAGGING_DATA_FORM_PDF) Then
                MessageBox.Show("'" & MASTER_TAGGING_DATA_FORM_PDF & "' file not found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            frm = New TaggingDataFormDlg
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing
            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnTurtleTransferFormBlank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTurtleTransferFormBlank.Click

        Call CreateBlankPdf(MASTER_TURTLE_TRANSFER_FORM_PDF)

    End Sub

    Private Sub btnTurtleTransferFormFill_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTurtleTransferFormFill.Click

        Call ShowManualFillForm(MASTER_TURTLE_TRANSFER_FORM_PDF)

    End Sub

    Private Sub CreateBlankPdf(ByVal vsMasterFormFileName As String)

        '----------------------------------------------------------------
        '-- create a blank, read-only copy of the PDF form
        '----------------------------------------------------------------

        Dim sTempFormFileName As String = String.Empty
        Dim sBlankFormFileName As String = String.Empty
        Dim oPdfReader As PdfReader
        Dim oPdfStamper As PdfStamper

        Try

            If Not System.IO.File.Exists(vsMasterFormFileName) Then
                MessageBox.Show("'" & vsMasterFormFileName & "' file not found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- determine the file name of the blank copy of the form
            '----------------------------------------------------------------
            sTempFormFileName = vsMasterFormFileName.Replace("MASTER - ", "TEMP - ").Replace(".master.pdf", ".temp.pdf")
            sBlankFormFileName = vsMasterFormFileName.Replace("MASTER - ", "BLANK - ").Replace(".master.pdf", ".blank.pdf")

            If System.IO.File.Exists(sTempFormFileName) Then
                System.IO.File.Delete(sTempFormFileName)
            End If

            If System.IO.File.Exists(sBlankFormFileName) Then
                System.IO.File.Delete(sBlankFormFileName)
            End If

            '----------------------------------------------------------------
            '-- open the master PDF file
            '----------------------------------------------------------------
            oPdfReader = New PdfReader(vsMasterFormFileName)

            '----------------------------------------------------------------
            '-- "flatten" the PDF form into the blank form make it read-only
            '----------------------------------------------------------------
            oPdfStamper = New PdfStamper(oPdfReader, New System.IO.FileStream(sTempFormFileName, IO.FileMode.Create))

            ''v-- add this to make the form READ-ONLY
            oPdfStamper.FormFlattening = True

            oPdfStamper.Close()
            oPdfStamper = Nothing

            oPdfReader.Close()
            oPdfReader = Nothing

            AppCommon.ConcatenatePdfFiles(sTempFormFileName, sBlankFormFileName)

            System.IO.File.Delete(sTempFormFileName)

            '----------------------------------------------------------------
            '-- display the blank, read-only PDF form in Adobe Reader
            '----------------------------------------------------------------
            System.Diagnostics.Process.Start(sBlankFormFileName)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub ShowManualFillForm(ByVal vsMasterFormFileName As String)

        ''Dim sFilledReportName As String = String.Empty
        ''Try
        ''    If Not System.IO.File.Exists(vsMasterFormFileName) Then
        ''        MessageBox.Show("'" & vsMasterFormFileName & "' file not found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
        ''        Exit Sub
        ''    End If
        ''    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
        ''    sFilledReportName = vsMasterFormFileName.Replace("MASTER - ", "FILLED - ").Replace(".master.pdf", " - " & Now.ToString("yyyyMMddHHmmss") & ".pdf")
        ''    System.IO.File.Copy(vsMasterFormFileName, sFilledReportName)
        ''    System.Diagnostics.Process.Start(sFilledReportName)
        ''Catch ex As Exception
        ''    ErrorMessageBox.Show(ex)
        ''Finally
        ''    System.Windows.Forms.Cursor.Current = Cursors.Default
        ''End Try

        Dim frm As ManualFillFormsDlg

        Try

            frm = New ManualFillFormsDlg(vsMasterFormFileName)

            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing
            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

#End Region

#Region " Other Reports "

#Region " Turtle Injury Report "

    Private Sub lnkTurtleInjuryReport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkTurtleInjuryReport.LinkClicked

        Try

            RunTurtleInjuryReport()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub lnkTurtleInjuryReport_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkTurtleInjuryReport.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                RunTurtleInjuryReport()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub RunTurtleInjuryReport()

        Dim frm As TurtleInjuryReportDlg

        Try

            frm = New TurtleInjuryReportDlg
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing
            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

#End Region

#Region " Turtle Tag Report "

    Private Sub lnkTurtleTagReport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkTurtleTagReport.LinkClicked

        Try

            RunTurtleTagReport()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub lnkTurtleTagReport_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkTurtleTagReport.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                RunTurtleTagReport()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub RunTurtleTagReport()

        Dim frm As TurtleTagReportDlg

        Try

            frm = New TurtleTagReportDlg
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing
            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

#End Region

#Region " Hatchlings and Washbacks Count Report "

    Private Sub lnkHatchlingsWashbacksCountReport_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkHatchlingsWashbacksCountyReport.LinkClicked

        Try

            RunHatchlingsWashbacksByCountyReport()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub lnkHatchlingsWashbacksCountReport_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkHatchlingsWashbacksCountyReport.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                RunHatchlingsWashbacksByCountyReport()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub RunHatchlingsWashbacksByCountyReport()

        Dim frm As HatchlingsWashbacksByCountyReportDlg

        Try

            frm = New HatchlingsWashbacksByCountyReportDlg
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing
            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

#End Region

#End Region

#Region " Turtles "

    Private Sub LoadTurtleGridData()

        Dim bShowInactiveTurtles As Boolean
        Dim sFilterByType As String = String.Empty
        Dim sFilterByValue As String = String.Empty

        Dim oSortedBindingList As Csla.SortedBindingList(Of TurtleListItem)

        Try
            Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- get filter information, if any
            '----------------------------------------------------------------
            bShowInactiveTurtles = Me.chkShowInactiveTurtles.Checked

            If (Me.cboFilterByList.SelectedIndex > 0) Then
                sFilterByType = CType(Me.cboFilterByList.SelectedItem, KeyValueInfo).Key
                sFilterByValue = Me.txtFilterByValue.Text.Trim
            End If

            '----------------------------------------------------------------
            '-- add the data to the grid
            '----------------------------------------------------------------
            If String.IsNullOrEmpty(msTurtleSortedColumnPropertyName) Then
                msTurtleSortedColumnPropertyName = "SidNumber"
            End If

            oSortedBindingList = New Csla.SortedBindingList(Of TurtleListItem)(TurtleListItems.GetListBySearchOptions(bShowInactiveTurtles, sFilterByType, sFilterByValue))
            oSortedBindingList.ApplySort(msTurtleSortedColumnPropertyName, moTurtleListSortDirection)

            Me.tpgTurtles.Text = "Sea Turtles (" & oSortedBindingList.Count.ToString & " of " & Turtle.TotalCount.ToString & ")"

            Me.TurtleGridBindingSource.DataSource = oSortedBindingList

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnAddTurtle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTurtle.Click

        CreateTurtle()

    End Sub

    Private Sub CreateTurtle()

        Dim frm As TurtleInformationDlg = Nothing

        Try
            frm = New TurtleInformationDlg(Turtle.NewTurtle())

            frm.ShowDialog(Me)

            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                LoadTurtleGridData()

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

    Private Sub EditTurtle()

        Dim sTurtleID As String = String.Empty
        Dim frm As TurtleInformationDlg = Nothing

        Try
            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdTurtleGrid.SelectedRows.Count > 0) Then

                sTurtleID = Convert.ToString(grdTurtleGrid.SelectedRows(0).Cells(Me.colTurtleTurtleIDDataGridViewTextBoxColumn.Name).Value)

                frm = New TurtleInformationDlg(Turtle.GetTurtle(sTurtleID))

                frm.ShowDialog(Me)

                If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                    LoadTurtleGridData()

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

    Private Sub DeleteTurtle()

        Dim sTurtleID As String = String.Empty

        Try
            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdTurtleGrid.SelectedRows.Count > 0) Then

                sTurtleID = Convert.ToString(grdTurtleGrid.SelectedRows(0).Cells(Me.colTurtleTurtleIDDataGridViewTextBoxColumn.Name).Value)

                If (MessageBox.Show("If you delete this record, the turtle will no longer appear on any reports.  If you are trying to change the turtle's status from Active to Inactive, edit that record and enter a value in the Date Relinquished field." & ControlChars.CrLf & ControlChars.CrLf & "Are you sure you want to delete this turtle record: '" & Convert.ToString(grdTurtleGrid.SelectedRows(0).Cells(Me.colTurtleTurtleNameDataGridViewTextBoxColumn.Name).Value) & "'?  This is a permanent action and cannot be undone.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then

                    Cursor.Current = Cursors.WaitCursor

                    Turtle.DeleteTurtle(sTurtleID)

                    LoadTurtleGridData()

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub chkShowInactiveTurtles_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkShowInactiveTurtles.CheckedChanged

        If mbIsLoading Then Exit Sub

        LoadTurtleGridData()

    End Sub

    Private Sub grdTurtleGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdTurtleGrid.CellClick

        Try

            '----------------------------------------------------------------
            '-- handle the EDIT or DELETE command
            '----------------------------------------------------------------
            If (e.RowIndex > -1) Then
                If Me.grdTurtleGrid.Columns(e.ColumnIndex).Name.Equals(Me.colTurtleEditActionDataGridViewLinkColumn.Name) Then
                    EditTurtle()
                ElseIf Me.grdTurtleGrid.Columns(e.ColumnIndex).Name.Equals(Me.colTurtleDeleteActionDataGridViewLinkColumn.Name) Then
                    DeleteTurtle()
                End If
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub grdTurtleGrid_ColumnDividerDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventArgs) Handles grdTurtleGrid.ColumnDividerDoubleClick

        If ((Me.grdTurtleGrid.Columns(e.ColumnIndex).Visible) AndAlso (Not Me.grdTurtleGrid.Columns(e.ColumnIndex).Frozen)) Then
            Me.grdTurtleGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Me.grdTurtleGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        End If

    End Sub

    Private Sub grdTurtleGrid_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdTurtleGrid.ColumnHeaderMouseClick

        Try

            '----------------------------------------------------------------
            '-- if we are re-sorting the same column, save the order
            '----------------------------------------------------------------
            If (String.Compare(msTurtleSortedColumnPropertyName, Me.grdTurtleGrid.Columns(e.ColumnIndex).DataPropertyName) = 0) Then
                If Me.grdTurtleGrid.SortOrder = SortOrder.Ascending Then
                    moTurtleListSortDirection = System.ComponentModel.ListSortDirection.Ascending
                Else
                    moTurtleListSortDirection = System.ComponentModel.ListSortDirection.Descending
                End If
            Else
                '----------------------------------------------------------------
                '-- otherwise, we are sorting a new column; default to ASCENDING
                '----------------------------------------------------------------
                moTurtleListSortDirection = System.ComponentModel.ListSortDirection.Ascending
            End If

            msTurtleSortedColumnPropertyName = Me.grdTurtleGrid.Columns(e.ColumnIndex).DataPropertyName

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub grdTurtleGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTurtleGrid.DoubleClick

        Dim oPoint As Point = Me.grdTurtleGrid.PointToClient(Cursor.Position)
        Dim oHitTestInfo As DataGridView.HitTestInfo = Me.grdTurtleGrid.HitTest(oPoint.X, oPoint.Y)

        '----------------------------------------------------------------
        '-- only edit the record if a data row cell was double-clicked
        '-- (we do this to allow a double click of the column separator to resize the column)
        '----------------------------------------------------------------
        If (oHitTestInfo.Type = DataGridViewHitTestType.Cell) Then
            EditTurtle()
        End If

    End Sub

#End Region

#Region " Tanks "

    Private Sub LoadTankGridData()

        Dim oSortedBindingList As Csla.SortedBindingList(Of TankListItem)

        Try
            Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- add the data to the grid
            '----------------------------------------------------------------
            If String.IsNullOrEmpty(msTankSortedColumnPropertyName) Then
                msTankSortedColumnPropertyName = "TankName"
            End If

            oSortedBindingList = New Csla.SortedBindingList(Of TankListItem)(TankListItems.GetList())
            oSortedBindingList.ApplySort(msTankSortedColumnPropertyName, moTankListSortDirection)

            Me.TankGridBindingSource.DataSource = oSortedBindingList

            Me.tpgTanks.Text = "Holding Tanks (" & oSortedBindingList.Count.ToString & ")"

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnAddTank_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTank.Click

        CreateTank()

    End Sub

    Private Sub CreateTank()

        Dim frm As TankInformationDlg = Nothing

        Try
            frm = New TankInformationDlg(Tank.NewTank())

            frm.ShowDialog(Me)

            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                LoadTankGridData()

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

    Private Sub EditTank()

        Dim sTankID As String = String.Empty
        Dim frm As TankInformationDlg = Nothing

        Try
            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdTankGrid.SelectedRows.Count > 0) Then

                sTankID = Convert.ToString(grdTankGrid.SelectedRows(0).Cells(Me.colTankTankIDDataGridViewTextBoxColumn.Name).Value)

                frm = New TankInformationDlg(Tank.GetTank(sTankID))

                frm.ShowDialog(Me)

                If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                    LoadTankGridData()

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

    Private Sub DeleteTank()

        Dim sTankID As String = String.Empty

        Try
            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdTankGrid.SelectedRows.Count > 0) Then

                sTankID = Convert.ToString(grdTankGrid.SelectedRows(0).Cells(Me.colTankTankIDDataGridViewTextBoxColumn.Name).Value)

                If (MessageBox.Show("Are you sure you want to delete this tank record: '" & Convert.ToString(grdTankGrid.SelectedRows(0).Cells(Me.colTankTankNameDataGridViewTextBoxColumn.Name).Value) & "'?  This is a permanent action and CANNOT be undone.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then

                    Cursor.Current = Cursors.WaitCursor

                    Tank.DeleteTank(sTankID)

                    LoadTankGridData()

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub grdTankGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdTankGrid.CellClick

        Try

            '----------------------------------------------------------------
            '-- handle the EDIT or DELETE command
            '----------------------------------------------------------------
            If (e.RowIndex > -1) Then
                If Me.grdTankGrid.Columns(e.ColumnIndex).Name.Equals(Me.colTankEditActionDataGridViewLinkColumn.Name) Then
                    EditTank()
                ElseIf Me.grdTankGrid.Columns(e.ColumnIndex).Name.Equals(Me.colTankDeleteActionDataGridViewLinkColumn.Name) Then
                    DeleteTank()
                End If
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub grdTankGrid_ColumnDividerDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventArgs) Handles grdTankGrid.ColumnDividerDoubleClick

        If ((Me.grdTankGrid.Columns(e.ColumnIndex).Visible) AndAlso (Not Me.grdTankGrid.Columns(e.ColumnIndex).Frozen)) Then
            Me.grdTankGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Me.grdTankGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        End If

    End Sub

    Private Sub grdTankGrid_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdTankGrid.ColumnHeaderMouseClick

        Try

            '----------------------------------------------------------------
            '-- if we are re-sorting the same column, save the order
            '----------------------------------------------------------------
            If (String.Compare(msTankSortedColumnPropertyName, Me.grdTankGrid.Columns(e.ColumnIndex).DataPropertyName) = 0) Then
                If Me.grdTankGrid.SortOrder = SortOrder.Ascending Then
                    moTankListSortDirection = System.ComponentModel.ListSortDirection.Ascending
                Else
                    moTankListSortDirection = System.ComponentModel.ListSortDirection.Descending
                End If
            Else
                '----------------------------------------------------------------
                '-- otherwise, we are sorting a new column; default to ASCENDING
                '----------------------------------------------------------------
                moTankListSortDirection = System.ComponentModel.ListSortDirection.Ascending
            End If

            msTankSortedColumnPropertyName = Me.grdTankGrid.Columns(e.ColumnIndex).DataPropertyName

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub grdTankGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTankGrid.DoubleClick

        Dim oPoint As Point = Me.grdTankGrid.PointToClient(Cursor.Position)
        Dim oHitTestInfo As DataGridView.HitTestInfo = Me.grdTankGrid.HitTest(oPoint.X, oPoint.Y)

        '----------------------------------------------------------------
        '-- only edit the record if a data row cell was double-clicked
        '-- (we do this to allow a double click of the column separator to resize the column)
        '----------------------------------------------------------------
        If (oHitTestInfo.Type = DataGridViewHitTestType.Cell) Then
            EditTank()
        End If

    End Sub

#End Region

#Region " Hatchlings Events "

    Private Sub LoadHatchlingsEventGridData()

        Dim oSortedBindingList As Csla.SortedBindingList(Of HatchlingsEventListItem)

        Try
            Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- add the data to the grid
            '----------------------------------------------------------------
            If String.IsNullOrEmpty(msHatchlingsEventSortedColumnPropertyName) Then
                msHatchlingsEventSortedColumnPropertyName = "HatchlingsEventName"
            End If

            oSortedBindingList = New Csla.SortedBindingList(Of HatchlingsEventListItem)(HatchlingsEventListItems.GetList())
            oSortedBindingList.ApplySort(msHatchlingsEventSortedColumnPropertyName, moHatchlingsEventListSortDirection)

            Me.tpgHatchlingsEvents.Text = "Hatchlings (" & oSortedBindingList.Count.ToString & ")"

            Me.HatchlingsEventGridBindingSource.DataSource = oSortedBindingList

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnAddHatchlingsAcquiredEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHatchlingsAcquiredEvent.Click

        CreateHatchlingsAcquiredEvent()

    End Sub

    Private Sub CreateHatchlingsAcquiredEvent()

        Dim frm As HatchlingsAcquiredEventInformationDlg = Nothing

        Try
            frm = New HatchlingsAcquiredEventInformationDlg(HatchlingsAcquiredEvent.NewHatchlingsAcquiredEvent())

            frm.ShowDialog(Me)

            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                LoadHatchlingsEventGridData()

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

    Private Sub btnAddHatchlingsDiedEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHatchlingsDiedEvent.Click

        CreateHatchlingsDiedEvent()

    End Sub

    Private Sub CreateHatchlingsDiedEvent()

        Dim frm As HatchlingsDiedEventInformationDlg = Nothing

        Try
            frm = New HatchlingsDiedEventInformationDlg(HatchlingsDiedEvent.NewHatchlingsDiedEvent())

            frm.ShowDialog(Me)

            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                LoadHatchlingsEventGridData()

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

    Private Sub btnAddHatchlingsReleasedEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHatchlingsReleasedEvent.Click

        CreateHatchlingsReleasedEvent()

    End Sub

    Private Sub CreateHatchlingsReleasedEvent()

        Dim frm As HatchlingsReleasedEventInformationDlg = Nothing

        Try
            frm = New HatchlingsReleasedEventInformationDlg(HatchlingsReleasedEvent.NewHatchlingsReleasedEvent())

            frm.ShowDialog(Me)

            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                LoadHatchlingsEventGridData()

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

    Private Sub btnAddHatchlingsDoaEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddHatchlingsDoaEvent.Click

        CreateHatchlingsDoaEvent()

    End Sub

    Private Sub CreateHatchlingsDoaEvent()

        Dim frm As HatchlingsDoaEventInformationDlg = Nothing

        Try
            frm = New HatchlingsDoaEventInformationDlg(HatchlingsDoaEvent.NewHatchlingsDoaEvent())

            frm.ShowDialog(Me)

            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                LoadHatchlingsEventGridData()

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

    Private Sub EditHatchlingsEvent()

        Dim sHatchlingsEventID As String = String.Empty
        Dim sHatchlingsEventType As String = String.Empty
        Dim frm As Form = Nothing

        Try
            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdHatchlingsEventGrid.SelectedRows.Count > 0) Then

                sHatchlingsEventID = Convert.ToString(grdHatchlingsEventGrid.SelectedRows(0).Cells(Me.colHatchlingsEventEventIDDataGridViewTextBoxColumn.Name).Value)
                sHatchlingsEventType = Convert.ToString(grdHatchlingsEventGrid.SelectedRows(0).Cells(Me.colHatchlingsEventEventTypeDataGridViewTextBoxColumn.Name).Value)

                Select Case sHatchlingsEventType
                    Case "Acquired"
                        frm = New HatchlingsAcquiredEventInformationDlg(HatchlingsAcquiredEvent.GetHatchlingsAcquiredEvent(sHatchlingsEventID))
                    Case "Died"
                        frm = New HatchlingsDiedEventInformationDlg(HatchlingsDiedEvent.GetHatchlingsDiedEvent(sHatchlingsEventID))
                    Case "Released"
                        frm = New HatchlingsReleasedEventInformationDlg(HatchlingsReleasedEvent.GetHatchlingsReleasedEvent(sHatchlingsEventID))
                    Case "DOA"
                        frm = New HatchlingsDoaEventInformationDlg(HatchlingsDoaEvent.GetHatchlingsDoaEvent(sHatchlingsEventID))
                    Case Else
                        Exit Sub
                End Select

                frm.ShowDialog(Me)

                If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                    LoadHatchlingsEventGridData()

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

    Private Sub DeleteHatchlingsEvent()

        Dim sHatchlingsEventID As String = String.Empty
        Dim sHatchlingsEventType As String = String.Empty
        Dim sTypeLabel As String = String.Empty

        Try
            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdHatchlingsEventGrid.SelectedRows.Count > 0) Then

                sHatchlingsEventID = Convert.ToString(grdHatchlingsEventGrid.SelectedRows(0).Cells(Me.colHatchlingsEventEventIDDataGridViewTextBoxColumn.Name).Value)
                sHatchlingsEventType = Convert.ToString(grdHatchlingsEventGrid.SelectedRows(0).Cells(Me.colHatchlingsEventEventTypeDataGridViewTextBoxColumn.Name).Value)

                Select Case sHatchlingsEventType
                    Case "Acquired"
                        sTypeLabel = sHatchlingsEventType.ToLower
                    Case "Died"
                        sTypeLabel = sHatchlingsEventType.ToLower
                    Case "Released"
                        sTypeLabel = sHatchlingsEventType.ToLower
                    Case "Doa"
                        sTypeLabel = sHatchlingsEventType.ToUpper
                    Case Else
                        sTypeLabel = sHatchlingsEventType
                End Select

                If (MessageBox.Show("Are you sure you want to delete this hatchlings '" & sTypeLabel & "' event record (count = " & Convert.ToString(grdHatchlingsEventGrid.SelectedRows(0).Cells(Me.colHatchlingsEventEventCountDataGridViewTextBoxColumn.Name).Value) & ")?  This is a permanent action and CANNOT be undone.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then

                    Cursor.Current = Cursors.WaitCursor

                    Select Case sHatchlingsEventType
                        Case "Acquired"
                            HatchlingsAcquiredEvent.DeleteHatchlingsAcquiredEvent(sHatchlingsEventID)
                        Case "Died"
                            HatchlingsDiedEvent.DeleteHatchlingsDiedEvent(sHatchlingsEventID)
                        Case "Released"
                            HatchlingsReleasedEvent.DeleteHatchlingsReleasedEvent(sHatchlingsEventID)
                        Case "DOA"
                            HatchlingsDoaEvent.DeleteHatchlingsDoaEvent(sHatchlingsEventID)
                        Case Else
                            Exit Sub
                    End Select

                    LoadHatchlingsEventGridData()

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub grdHatchlingsEventGrid_CellClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdHatchlingsEventGrid.CellClick

        Try

            '----------------------------------------------------------------
            '-- handle the EDIT or DELETE command
            '----------------------------------------------------------------
            If (e.RowIndex > -1) Then
                If Me.grdHatchlingsEventGrid.Columns(e.ColumnIndex).Name.Equals(Me.colHatchlingsEventEditActionDataGridViewLinkColumn.Name) Then
                    EditHatchlingsEvent()
                ElseIf Me.grdHatchlingsEventGrid.Columns(e.ColumnIndex).Name.Equals(Me.colHatchlingsEventDeleteActionDataGridViewLinkColumn.Name) Then
                    DeleteHatchlingsEvent()
                End If
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub grdHatchlingsEventGrid_ColumnDividerDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventArgs) Handles grdHatchlingsEventGrid.ColumnDividerDoubleClick

        If ((Me.grdHatchlingsEventGrid.Columns(e.ColumnIndex).Visible) AndAlso (Not Me.grdHatchlingsEventGrid.Columns(e.ColumnIndex).Frozen)) Then
            Me.grdHatchlingsEventGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Me.grdHatchlingsEventGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        End If

    End Sub

    Private Sub grdHatchlingsEventGrid_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdHatchlingsEventGrid.ColumnHeaderMouseClick

        Try

            '----------------------------------------------------------------
            '-- if we are re-sorting the same column, save the order
            '----------------------------------------------------------------
            If (String.Compare(msHatchlingsEventSortedColumnPropertyName, Me.grdHatchlingsEventGrid.Columns(e.ColumnIndex).DataPropertyName) = 0) Then
                If Me.grdHatchlingsEventGrid.SortOrder = SortOrder.Ascending Then
                    moHatchlingsEventListSortDirection = System.ComponentModel.ListSortDirection.Ascending
                Else
                    moHatchlingsEventListSortDirection = System.ComponentModel.ListSortDirection.Descending
                End If
            Else
                '----------------------------------------------------------------
                '-- otherwise, we are sorting a new column; default to ASCENDING
                '----------------------------------------------------------------
                moHatchlingsEventListSortDirection = System.ComponentModel.ListSortDirection.Ascending
            End If

            msHatchlingsEventSortedColumnPropertyName = Me.grdHatchlingsEventGrid.Columns(e.ColumnIndex).DataPropertyName

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub grdHatchlingsEventGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdHatchlingsEventGrid.DoubleClick

        Dim oPoint As Point = Me.grdHatchlingsEventGrid.PointToClient(Cursor.Position)
        Dim oHitTestInfo As DataGridView.HitTestInfo = Me.grdHatchlingsEventGrid.HitTest(oPoint.X, oPoint.Y)

        '----------------------------------------------------------------
        '-- only edit the record if a data row cell was double-clicked
        '-- (we do this to allow a double click of the column separator to resize the column)
        '----------------------------------------------------------------
        If (oHitTestInfo.Type = DataGridViewHitTestType.Cell) Then
            EditHatchlingsEvent()
        End If

    End Sub

#End Region

#Region " Washbacks Events "

    Private Sub LoadWashbacksEventGridData()

        Dim oSortedBindingList As Csla.SortedBindingList(Of WashbacksEventListItem)

        Try
            Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- add the data to the grid
            '----------------------------------------------------------------
            If String.IsNullOrEmpty(msWashbacksEventSortedColumnPropertyName) Then
                msWashbacksEventSortedColumnPropertyName = "WashbacksEventName"
            End If

            oSortedBindingList = New Csla.SortedBindingList(Of WashbacksEventListItem)(WashbacksEventListItems.GetList())
            oSortedBindingList.ApplySort(msWashbacksEventSortedColumnPropertyName, moWashbacksEventListSortDirection)

            Me.tpgWashbacksEvents.Text = "Washbacks (" & oSortedBindingList.Count.ToString & ")"

            Me.WashbacksEventGridBindingSource.DataSource = oSortedBindingList

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnAddWashbacksAcquiredEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWashbacksAcquiredEvent.Click

        CreateWashbacksAcquiredEvent()

    End Sub

    Private Sub CreateWashbacksAcquiredEvent()

        Dim frm As WashbacksAcquiredEventInformationDlg = Nothing

        Try
            frm = New WashbacksAcquiredEventInformationDlg(WashbacksAcquiredEvent.NewWashbacksAcquiredEvent())

            frm.ShowDialog(Me)

            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                LoadWashbacksEventGridData()

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

    Private Sub btnAddWashbacksDiedEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWashbacksDiedEvent.Click

        CreateWashbacksDiedEvent()

    End Sub

    Private Sub CreateWashbacksDiedEvent()

        Dim frm As WashbacksDiedEventInformationDlg = Nothing

        Try
            frm = New WashbacksDiedEventInformationDlg(WashbacksDiedEvent.NewWashbacksDiedEvent())

            frm.ShowDialog(Me)

            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                LoadWashbacksEventGridData()

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

    Private Sub btnAddWashbacksReleasedEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWashbacksReleasedEvent.Click

        CreateWashbacksReleasedEvent()

    End Sub

    Private Sub CreateWashbacksReleasedEvent()

        Dim frm As WashbacksReleasedEventInformationDlg = Nothing

        Try
            frm = New WashbacksReleasedEventInformationDlg(WashbacksReleasedEvent.NewWashbacksReleasedEvent())

            frm.ShowDialog(Me)

            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                LoadWashbacksEventGridData()

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

    Private Sub btnAddWashbacksDoaEvent_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddWashbacksDoaEvent.Click

        CreateWashbacksDoaEvent()

    End Sub

    Private Sub CreateWashbacksDoaEvent()

        Dim frm As WashbacksDoaEventInformationDlg = Nothing

        Try
            frm = New WashbacksDoaEventInformationDlg(WashbacksDoaEvent.NewWashbacksDoaEvent())

            frm.ShowDialog(Me)

            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                LoadWashbacksEventGridData()

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

    Private Sub EditWashbacksEvent()

        Dim sWashbacksEventID As String = String.Empty
        Dim sWashbacksEventType As String = String.Empty
        Dim frm As Form = Nothing

        Try
            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdWashbacksEventGrid.SelectedRows.Count > 0) Then

                sWashbacksEventID = Convert.ToString(grdWashbacksEventGrid.SelectedRows(0).Cells(Me.colWashbacksEventEventIDDataGridViewTextBoxColumn.Name).Value)
                sWashbacksEventType = Convert.ToString(grdWashbacksEventGrid.SelectedRows(0).Cells(Me.colWashbacksEventEventTypeDataGridViewTextBoxColumn.Name).Value)

                Select Case sWashbacksEventType
                    Case "Acquired"
                        frm = New WashbacksAcquiredEventInformationDlg(WashbacksAcquiredEvent.GetWashbacksAcquiredEvent(sWashbacksEventID))
                    Case "Died"
                        frm = New WashbacksDiedEventInformationDlg(WashbacksDiedEvent.GetWashbacksDiedEvent(sWashbacksEventID))
                    Case "Released"
                        frm = New WashbacksReleasedEventInformationDlg(WashbacksReleasedEvent.GetWashbacksReleasedEvent(sWashbacksEventID))
                    Case "DOA"
                        frm = New WashbacksDoaEventInformationDlg(WashbacksDoaEvent.GetWashbacksDoaEvent(sWashbacksEventID))
                    Case Else
                        Exit Sub
                End Select

                frm.ShowDialog(Me)

                If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                    LoadWashbacksEventGridData()

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

    Private Sub DeleteWashbacksEvent()

        Dim sWashbacksEventID As String = String.Empty
        Dim sWashbacksEventType As String = String.Empty
        Dim sTypeLabel As String = String.Empty

        Try
            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdWashbacksEventGrid.SelectedRows.Count > 0) Then

                sWashbacksEventID = Convert.ToString(grdWashbacksEventGrid.SelectedRows(0).Cells(Me.colWashbacksEventEventIDDataGridViewTextBoxColumn.Name).Value)
                sWashbacksEventType = Convert.ToString(grdWashbacksEventGrid.SelectedRows(0).Cells(Me.colWashbacksEventEventTypeDataGridViewTextBoxColumn.Name).Value)

                Select Case sWashbacksEventType
                    Case "Acquired"
                        sTypeLabel = sWashbacksEventType.ToLower
                    Case "Died"
                        sTypeLabel = sWashbacksEventType.ToLower
                    Case "Released"
                        sTypeLabel = sWashbacksEventType.ToLower
                    Case "Doa"
                        sTypeLabel = sWashbacksEventType.ToUpper
                    Case Else
                        sTypeLabel = sWashbacksEventType
                End Select

                If (MessageBox.Show("Are you sure you want to delete this hatchlings '" & sTypeLabel & "' event record (count = " & Convert.ToString(grdWashbacksEventGrid.SelectedRows(0).Cells(Me.colWashbacksEventEventCountDataGridViewTextBoxColumn.Name).Value) & ")?  This is a permanent action and CANNOT be undone.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then

                    Cursor.Current = Cursors.WaitCursor

                    Select Case sWashbacksEventType
                        Case "Acquired"
                            WashbacksAcquiredEvent.DeleteWashbacksAcquiredEvent(sWashbacksEventID)
                        Case "Died"
                            WashbacksDiedEvent.DeleteWashbacksDiedEvent(sWashbacksEventID)
                        Case "Released"
                            WashbacksReleasedEvent.DeleteWashbacksReleasedEvent(sWashbacksEventID)
                        Case "Doa"
                            WashbacksDoaEvent.DeleteWashbacksDoaEvent(sWashbacksEventID)
                        Case Else
                            Exit Sub
                    End Select

                    LoadWashbacksEventGridData()

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub grdWashbacksEventGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdWashbacksEventGrid.CellClick

        Try

            '----------------------------------------------------------------
            '-- handle the EDIT or DELETE command
            '----------------------------------------------------------------
            If (e.RowIndex > -1) Then
                If Me.grdWashbacksEventGrid.Columns(e.ColumnIndex).Name.Equals(Me.colWashbacksEventEditActionDataGridViewLinkColumn.Name) Then
                    EditWashbacksEvent()
                ElseIf Me.grdWashbacksEventGrid.Columns(e.ColumnIndex).Name.Equals(Me.colWashbacksEventDeleteActionDataGridViewLinkColumn.Name) Then
                    DeleteWashbacksEvent()
                End If
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub grdWashbacksEventGrid_ColumnDividerDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventArgs) Handles grdWashbacksEventGrid.ColumnDividerDoubleClick

        If ((Me.grdWashbacksEventGrid.Columns(e.ColumnIndex).Visible) AndAlso (Not Me.grdWashbacksEventGrid.Columns(e.ColumnIndex).Frozen)) Then
            Me.grdWashbacksEventGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Me.grdWashbacksEventGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        End If

    End Sub

    Private Sub grdWashbacksEventGrid_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdWashbacksEventGrid.ColumnHeaderMouseClick

        Try

            '----------------------------------------------------------------
            '-- if we are re-sorting the same column, save the order
            '----------------------------------------------------------------
            If (String.Compare(msWashbacksEventSortedColumnPropertyName, Me.grdWashbacksEventGrid.Columns(e.ColumnIndex).DataPropertyName) = 0) Then
                If Me.grdWashbacksEventGrid.SortOrder = SortOrder.Ascending Then
                    moWashbacksEventListSortDirection = System.ComponentModel.ListSortDirection.Ascending
                Else
                    moWashbacksEventListSortDirection = System.ComponentModel.ListSortDirection.Descending
                End If
            Else
                '----------------------------------------------------------------
                '-- otherwise, we are sorting a new column; default to ASCENDING
                '----------------------------------------------------------------
                moWashbacksEventListSortDirection = System.ComponentModel.ListSortDirection.Ascending
            End If

            msWashbacksEventSortedColumnPropertyName = Me.grdWashbacksEventGrid.Columns(e.ColumnIndex).DataPropertyName

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub grdWashbacksEventGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdWashbacksEventGrid.DoubleClick

        Dim oPoint As Point = Me.grdWashbacksEventGrid.PointToClient(Cursor.Position)
        Dim oHitTestInfo As DataGridView.HitTestInfo = Me.grdWashbacksEventGrid.HitTest(oPoint.X, oPoint.Y)

        '----------------------------------------------------------------
        '-- only edit the record if a data row cell was double-clicked
        '-- (we do this to allow a double click of the column separator to resize the column)
        '----------------------------------------------------------------
        If (oHitTestInfo.Type = DataGridViewHitTestType.Cell) Then
            EditWashbacksEvent()
        End If

    End Sub

#End Region

#Region " Miscellaneous functions "

    Private Sub picMoreInfoFiltering_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoFiltering.Click

        Dim sb As New StringBuilder
        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "Filtering the Sea Turtle List"

            sb.Append("You can filter the sea turtle lookup list by selecting a filter type, entering all or part of the value you are looking for, and clicking the 'refresh' button.")
            sb.Append(ControlChars.CrLf)
            sb.Append(ControlChars.CrLf)
            sb.Append("If the any part of the value you are looking for matches the data in the field you are filtering by, then the corresponding sea turtle record(s) will be displayed.")
            sb.Append(ControlChars.CrLf)
            sb.Append(ControlChars.CrLf)
            sb.Append("You can filter the list by:")
            sb.Append(ControlChars.CrLf)
            sb.Append(ControlChars.CrLf)
            sb.Append("   -- Turtle name")
            sb.Append(ControlChars.CrLf)
            sb.Append("   -- SID number")
            sb.Append(ControlChars.CrLf)
            sb.Append("   -- Stranding ID number")
            sb.Append(ControlChars.CrLf)
            sb.Append("   -- Tag number")
            sb.Append(ControlChars.CrLf)
            sb.Append(ControlChars.CrLf)
            sb.Append("To clear the filter, select 'Filter by <none>.'")
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

#End Region

End Class
