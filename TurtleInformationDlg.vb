Option Explicit On 
Option Strict On
Option Compare Text

Public Class TurtleInformationDlg
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
    Friend WithEvents tabTurtleTab As System.Windows.Forms.TabControl
    Friend WithEvents tpgTurtleTabGeneralInformation As System.Windows.Forms.TabPage
    Friend WithEvents tpgTurtleTabTags As System.Windows.Forms.TabPage
    Friend WithEvents picMoreInfoRelinquishedTo As System.Windows.Forms.PictureBox
    Friend WithEvents picMoreInfoStatus As System.Windows.Forms.PictureBox
    Friend WithEvents picMoreInfoSize As System.Windows.Forms.PictureBox
    Friend WithEvents picMoreInfoAcquiredFrom As System.Windows.Forms.PictureBox
    Friend WithEvents lblRelinquishedTo As System.Windows.Forms.Label
    Friend WithEvents txtRelinquishedTo As System.Windows.Forms.TextBox
    Friend WithEvents lblAcquiredFrom As System.Windows.Forms.Label
    Friend WithEvents txtAcquiredFrom As System.Windows.Forms.TextBox
    Friend WithEvents picMoreInfoSidNumber As System.Windows.Forms.PictureBox
    Friend WithEvents dtpDateRelinquished As TurtleGeek.Controls.DateComboBox
    Friend WithEvents dtpDateAcquired As TurtleGeek.Controls.DateComboBox
    Friend WithEvents cboStatusList As System.Windows.Forms.ComboBox
    Friend WithEvents lblStatus As System.Windows.Forms.Label
    Friend WithEvents lblSpecies As System.Windows.Forms.Label
    Friend WithEvents lblDateRelinquished As System.Windows.Forms.Label
    Friend WithEvents lblSize As System.Windows.Forms.Label
    Friend WithEvents lblDateAcquired As System.Windows.Forms.Label
    Friend WithEvents lblSidNumber As System.Windows.Forms.Label
    Friend WithEvents txtSidNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtTurtleName As System.Windows.Forms.TextBox
    Friend WithEvents lblTurtleName As System.Windows.Forms.Label
    Friend WithEvents cboSizeList As System.Windows.Forms.ComboBox
    Friend WithEvents cboSpeciesList As System.Windows.Forms.ComboBox
    Friend WithEvents picMoreInfoStrandingIdNumber As System.Windows.Forms.PictureBox
    Friend WithEvents lblStrandingIdNumber As System.Windows.Forms.Label
    Friend WithEvents lblAnomalies As System.Windows.Forms.Label
    Friend WithEvents picMoreInfoAnomalies As System.Windows.Forms.PictureBox
    Friend WithEvents txtStrandingIdNumber As System.Windows.Forms.TextBox
    Friend WithEvents txtAnomalies As System.Windows.Forms.TextBox
    Friend WithEvents btnAddTag As System.Windows.Forms.Button
    Friend WithEvents grpInjuries As System.Windows.Forms.GroupBox
    Friend WithEvents chkInjuryOther As System.Windows.Forms.CheckBox
    Friend WithEvents chkInjuryDoa As System.Windows.Forms.CheckBox
    Friend WithEvents chkInjuryMiscEpidemic As System.Windows.Forms.CheckBox
    Friend WithEvents chkInjuryFibropapilloma As System.Windows.Forms.CheckBox
    Friend WithEvents chkInjuryAnimalBite As System.Windows.Forms.CheckBox
    Friend WithEvents chkInjuryUpperRespiratory As System.Windows.Forms.CheckBox
    Friend WithEvents chkInjuryFishHook As System.Windows.Forms.CheckBox
    Friend WithEvents chkInjuryLineEntanglement As System.Windows.Forms.CheckBox
    Friend WithEvents chkInjuryIntestinalImpaction As System.Windows.Forms.CheckBox
    Friend WithEvents chkInjuryBoatStrike As System.Windows.Forms.CheckBox
    Friend WithEvents btnTaggingDataForm As System.Windows.Forms.Button
    Friend WithEvents TurtleTagGridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents grdTurtleTagGrid As System.Windows.Forms.DataGridView
    Friend WithEvents erpErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents tpgTurtleTabMorphometrics As System.Windows.Forms.TabPage
    Friend WithEvents TurtleMorphometricGridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnAddMorphometric As System.Windows.Forms.Button
    Friend WithEvents grdTurtleMorphometricGrid As System.Windows.Forms.DataGridView
    Friend WithEvents txtAcquiredLongitude As System.Windows.Forms.TextBox
    Friend WithEvents txtAcquiredLatitude As System.Windows.Forms.TextBox
    Friend WithEvents txtRelinquishedLongitude As System.Windows.Forms.TextBox
    Friend WithEvents txtRelinquishedLatitude As System.Windows.Forms.TextBox
    Friend WithEvents grpInitialEncounter As System.Windows.Forms.GroupBox
    Friend WithEvents lblCaptureProjectOther As System.Windows.Forms.Label
    Friend WithEvents txtCaptureProjectOther As System.Windows.Forms.TextBox
    Friend WithEvents cboCaptureProjectTypeList As System.Windows.Forms.ComboBox
    Friend WithEvents lblProjectType As System.Windows.Forms.Label
    Friend WithEvents cboRecaptureTypeList As System.Windows.Forms.ComboBox
    Friend WithEvents lblRecaptureType As System.Windows.Forms.Label
    Friend WithEvents chkWasTurtleCarryingTagsWhenEncountered As System.Windows.Forms.CheckBox
    Friend WithEvents grpInspectedScanned As System.Windows.Forms.GroupBox
    Friend WithEvents lblDidTurtleNest As System.Windows.Forms.Label
    Friend WithEvents cboDidTurtleNestList As System.Windows.Forms.ComboBox
    Friend WithEvents txtLivingTagsLocated As System.Windows.Forms.TextBox
    Friend WithEvents lblLivingTagsLocated As System.Windows.Forms.Label
    Friend WithEvents chkInspectedForLivingTags As System.Windows.Forms.CheckBox
    Friend WithEvents txtMagneticWiresLocated As System.Windows.Forms.TextBox
    Friend WithEvents lblMagneticWiresLocated As System.Windows.Forms.Label
    Friend WithEvents chkScannedForMagneticWires As System.Windows.Forms.CheckBox
    Friend WithEvents txtPitTagsFrequency As System.Windows.Forms.TextBox
    Friend WithEvents lblPitTagsFrequency As System.Windows.Forms.Label
    Friend WithEvents chkScannedForPitTags As System.Windows.Forms.CheckBox
    Friend WithEvents txtTagScarsLocated As System.Windows.Forms.TextBox
    Friend WithEvents lblTagScarsLocated As System.Windows.Forms.Label
    Friend WithEvents chkInspectedForTagScars As System.Windows.Forms.CheckBox
    Friend WithEvents picRelinquishedLatLonMap As System.Windows.Forms.PictureBox
    Friend WithEvents picAcquiredLatitudeLongitudeMap As System.Windows.Forms.PictureBox
    Friend WithEvents lblRelinquishedSlash As System.Windows.Forms.Label
    Friend WithEvents lnkRelinquishedLongitude As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkRelinquishedLatitude As System.Windows.Forms.LinkLabel
    Friend WithEvents lblRelinquishedDecDeg As System.Windows.Forms.Label
    Friend WithEvents lblAcquiredSlash As System.Windows.Forms.Label
    Friend WithEvents lnkAcquiredLongitude As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkAcquiredLatitude As System.Windows.Forms.LinkLabel
    Friend WithEvents lblAcquiredDecDeg As System.Windows.Forms.Label
    Friend WithEvents colTagEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTagDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTagTurtleTagIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagTagNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagLocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagDateTaggedBindableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents lblTagReturnAddress As System.Windows.Forms.Label
    Friend WithEvents txtTagReturnAddress As System.Windows.Forms.TextBox
    Friend WithEvents picMoreInfoAcquiredCounty As System.Windows.Forms.PictureBox
    Friend WithEvents picMoreInfoRelinquishedLatLon As System.Windows.Forms.PictureBox
    Friend WithEvents picMoreInfoRelinquishedCounty As System.Windows.Forms.PictureBox
    Friend WithEvents picMoreInfoAcquiredLatLon As System.Windows.Forms.PictureBox
    Friend WithEvents picMoreInfoInitialEncounterInformation As System.Windows.Forms.PictureBox
    Friend WithEvents tabMorphometricsTab As System.Windows.Forms.TabControl
    Friend WithEvents tpgMeasurements As System.Windows.Forms.TabPage
    Friend WithEvents colMorphometricEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colMorphometricDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricSclNotchNotchValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricSclNotchNotchUnitsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricSclNotchTipValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricSclNotchTipUnitsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricSclTipTipValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricSclTipTipUnitsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricScwValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricScwUnitsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricCclNotchNotchValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricCclNotchNotchUnitsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricCclNotchTipValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricCclNotchTipUnitsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricCclTipTipValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricCclTipTipUnitsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricCcwValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricCcwUnitsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricWeightValueDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colMorphometricWeightUnitsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents tpgGraphs As System.Windows.Forms.TabPage
    Friend WithEvents chkGraphSclNotchTip As System.Windows.Forms.CheckBox
    Friend WithEvents chkGraphSclNotchNotch As System.Windows.Forms.CheckBox
    Friend WithEvents graphMorphometrics As TurtleGeek.Graphics.Windows.PlotSurface2D
    Friend WithEvents chkGraphSclTipTip As System.Windows.Forms.CheckBox
    Friend WithEvents pnlGraphChoices As System.Windows.Forms.Panel
    Friend WithEvents chkGraphCcw As System.Windows.Forms.CheckBox
    Friend WithEvents chkGraphCclNotchNotch As System.Windows.Forms.CheckBox
    Friend WithEvents chkGraphCclTipTip As System.Windows.Forms.CheckBox
    Friend WithEvents chkGraphCclNotchTip As System.Windows.Forms.CheckBox
    Friend WithEvents chkGraphScw As System.Windows.Forms.CheckBox
    Friend WithEvents chkGraphWeight As System.Windows.Forms.CheckBox
    Friend WithEvents lnkPrintMorphometricsGraph As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkCopyToClipboardMorphometricsGraph As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkRelinquishedCounty As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkAcquiredCounty As System.Windows.Forms.LinkLabel
    Friend WithEvents cboRelinquishedCountyList As System.Windows.Forms.ComboBox
    Friend WithEvents cboAcquiredCountyList As System.Windows.Forms.ComboBox
    Friend WithEvents tpgTurtleTabAttachments As System.Windows.Forms.TabPage
    Friend WithEvents btnAddTurtleFileAttachment As System.Windows.Forms.Button
    Friend WithEvents btnDeleteAllTurtleFileAttachments As System.Windows.Forms.Button
    Friend WithEvents lblPicturePreview As System.Windows.Forms.Label
    Friend WithEvents picAttachmentPreview As System.Windows.Forms.PictureBox
    Friend WithEvents grdTurtleFileAttachmentList As System.Windows.Forms.DataGridView
    Friend WithEvents TurtleAttachmentGridBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lnkUseImageInBrochure As System.Windows.Forms.LinkLabel
    Friend WithEvents tpgTurtleTabBrochure As System.Windows.Forms.TabPage
    Friend WithEvents txtBrochureComments As System.Windows.Forms.TextBox
    Friend WithEvents lblBrochureComments As System.Windows.Forms.Label
    Friend WithEvents btnPrintBrochure As System.Windows.Forms.Button
    Friend WithEvents lblBrochureImage As System.Windows.Forms.Label
    Friend WithEvents picBrochureImage As System.Windows.Forms.PictureBox
    Friend WithEvents lnkBrochureClearImage As System.Windows.Forms.LinkLabel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents picBrochureBackgroundColorWhite As System.Windows.Forms.PictureBox
    Friend WithEvents radBrochureBackgroundColorWhite As System.Windows.Forms.RadioButton
    Friend WithEvents picBrochureBackgroundColorTan As System.Windows.Forms.PictureBox
    Friend WithEvents radBrochureBackgroundColorTan As System.Windows.Forms.RadioButton
    Friend WithEvents picBrochureBackgroundColorMistyRose As System.Windows.Forms.PictureBox
    Friend WithEvents radBrochureBackgroundColorMistyRose As System.Windows.Forms.RadioButton
    Friend WithEvents picBrochureBackgroundColorOrange As System.Windows.Forms.PictureBox
    Friend WithEvents radBrochureBackgroundColorOrange As System.Windows.Forms.RadioButton
    Friend WithEvents picBrochureBackgroundColorLightGray As System.Windows.Forms.PictureBox
    Friend WithEvents radBrochureBackgroundColorLightGray As System.Windows.Forms.RadioButton
    Friend WithEvents picBrochureBackgroundColorLavender As System.Windows.Forms.PictureBox
    Friend WithEvents radBrochureBackgroundColorLavender As System.Windows.Forms.RadioButton
    Friend WithEvents picBrochureBackgroundColorLightCyan As System.Windows.Forms.PictureBox
    Friend WithEvents radBrochureBackgroundColorLightCyan As System.Windows.Forms.RadioButton
    Friend WithEvents picBrochureBackgroundColorPaleGreen As System.Windows.Forms.PictureBox
    Friend WithEvents radBrochureBackgroundColorPaleGreen As System.Windows.Forms.RadioButton
    Friend WithEvents picBrochureBackgroundColorLightYellow As System.Windows.Forms.PictureBox
    Friend WithEvents radBrochureBackgroundColorLightYellow As System.Windows.Forms.RadioButton
    Friend WithEvents colTurtleFileAttachmentEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTurtleFileAttachmentDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTurtleFileAttachmentCopyToActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleFileAttachmentIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleFileAttachmentBaseFileNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTurtleFileAttachmentDateCreatedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents picMoreInfoDateCaptured As System.Windows.Forms.PictureBox
    Friend WithEvents dtpDateCaptured As TurtleGeek.Controls.DateComboBox
    Friend WithEvents lblDateCaptured As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TurtleInformationDlg))
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle19 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle18 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle20 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle21 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.tipToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.picMoreInfoRelinquishedTo = New System.Windows.Forms.PictureBox
        Me.picMoreInfoStatus = New System.Windows.Forms.PictureBox
        Me.picMoreInfoSize = New System.Windows.Forms.PictureBox
        Me.picMoreInfoAcquiredFrom = New System.Windows.Forms.PictureBox
        Me.picMoreInfoSidNumber = New System.Windows.Forms.PictureBox
        Me.picMoreInfoStrandingIdNumber = New System.Windows.Forms.PictureBox
        Me.picMoreInfoAnomalies = New System.Windows.Forms.PictureBox
        Me.picAcquiredLatitudeLongitudeMap = New System.Windows.Forms.PictureBox
        Me.picRelinquishedLatLonMap = New System.Windows.Forms.PictureBox
        Me.lnkAcquiredLatitude = New System.Windows.Forms.LinkLabel
        Me.lnkAcquiredLongitude = New System.Windows.Forms.LinkLabel
        Me.lnkRelinquishedLongitude = New System.Windows.Forms.LinkLabel
        Me.lnkRelinquishedLatitude = New System.Windows.Forms.LinkLabel
        Me.picMoreInfoAcquiredCounty = New System.Windows.Forms.PictureBox
        Me.picMoreInfoAcquiredLatLon = New System.Windows.Forms.PictureBox
        Me.picMoreInfoRelinquishedLatLon = New System.Windows.Forms.PictureBox
        Me.picMoreInfoRelinquishedCounty = New System.Windows.Forms.PictureBox
        Me.picMoreInfoInitialEncounterInformation = New System.Windows.Forms.PictureBox
        Me.lnkAcquiredCounty = New System.Windows.Forms.LinkLabel
        Me.lnkRelinquishedCounty = New System.Windows.Forms.LinkLabel
        Me.tabTurtleTab = New System.Windows.Forms.TabControl
        Me.tpgTurtleTabGeneralInformation = New System.Windows.Forms.TabPage
        Me.cboRelinquishedCountyList = New System.Windows.Forms.ComboBox
        Me.cboAcquiredCountyList = New System.Windows.Forms.ComboBox
        Me.lblRelinquishedSlash = New System.Windows.Forms.Label
        Me.lblRelinquishedDecDeg = New System.Windows.Forms.Label
        Me.lblAcquiredSlash = New System.Windows.Forms.Label
        Me.txtRelinquishedLongitude = New System.Windows.Forms.TextBox
        Me.txtRelinquishedLatitude = New System.Windows.Forms.TextBox
        Me.txtAcquiredLongitude = New System.Windows.Forms.TextBox
        Me.lblAcquiredDecDeg = New System.Windows.Forms.Label
        Me.txtAcquiredLatitude = New System.Windows.Forms.TextBox
        Me.grpInjuries = New System.Windows.Forms.GroupBox
        Me.chkInjuryOther = New System.Windows.Forms.CheckBox
        Me.chkInjuryDoa = New System.Windows.Forms.CheckBox
        Me.chkInjuryMiscEpidemic = New System.Windows.Forms.CheckBox
        Me.chkInjuryFibropapilloma = New System.Windows.Forms.CheckBox
        Me.chkInjuryAnimalBite = New System.Windows.Forms.CheckBox
        Me.chkInjuryUpperRespiratory = New System.Windows.Forms.CheckBox
        Me.chkInjuryFishHook = New System.Windows.Forms.CheckBox
        Me.chkInjuryLineEntanglement = New System.Windows.Forms.CheckBox
        Me.chkInjuryIntestinalImpaction = New System.Windows.Forms.CheckBox
        Me.chkInjuryBoatStrike = New System.Windows.Forms.CheckBox
        Me.txtAnomalies = New System.Windows.Forms.TextBox
        Me.lblAnomalies = New System.Windows.Forms.Label
        Me.lblStrandingIdNumber = New System.Windows.Forms.Label
        Me.txtStrandingIdNumber = New System.Windows.Forms.TextBox
        Me.lblRelinquishedTo = New System.Windows.Forms.Label
        Me.txtRelinquishedTo = New System.Windows.Forms.TextBox
        Me.lblAcquiredFrom = New System.Windows.Forms.Label
        Me.txtAcquiredFrom = New System.Windows.Forms.TextBox
        Me.dtpDateRelinquished = New TurtleGeek.Controls.DateComboBox
        Me.dtpDateAcquired = New TurtleGeek.Controls.DateComboBox
        Me.cboStatusList = New System.Windows.Forms.ComboBox
        Me.lblStatus = New System.Windows.Forms.Label
        Me.lblSpecies = New System.Windows.Forms.Label
        Me.lblDateRelinquished = New System.Windows.Forms.Label
        Me.lblSize = New System.Windows.Forms.Label
        Me.lblDateAcquired = New System.Windows.Forms.Label
        Me.lblSidNumber = New System.Windows.Forms.Label
        Me.txtSidNumber = New System.Windows.Forms.TextBox
        Me.txtTurtleName = New System.Windows.Forms.TextBox
        Me.lblTurtleName = New System.Windows.Forms.Label
        Me.cboSizeList = New System.Windows.Forms.ComboBox
        Me.cboSpeciesList = New System.Windows.Forms.ComboBox
        Me.tpgTurtleTabTags = New System.Windows.Forms.TabPage
        Me.grpInitialEncounter = New System.Windows.Forms.GroupBox
        Me.lblTagReturnAddress = New System.Windows.Forms.Label
        Me.txtTagReturnAddress = New System.Windows.Forms.TextBox
        Me.lblDidTurtleNest = New System.Windows.Forms.Label
        Me.cboDidTurtleNestList = New System.Windows.Forms.ComboBox
        Me.grpInspectedScanned = New System.Windows.Forms.GroupBox
        Me.txtLivingTagsLocated = New System.Windows.Forms.TextBox
        Me.lblLivingTagsLocated = New System.Windows.Forms.Label
        Me.chkInspectedForLivingTags = New System.Windows.Forms.CheckBox
        Me.txtMagneticWiresLocated = New System.Windows.Forms.TextBox
        Me.lblMagneticWiresLocated = New System.Windows.Forms.Label
        Me.chkScannedForMagneticWires = New System.Windows.Forms.CheckBox
        Me.txtPitTagsFrequency = New System.Windows.Forms.TextBox
        Me.lblPitTagsFrequency = New System.Windows.Forms.Label
        Me.chkScannedForPitTags = New System.Windows.Forms.CheckBox
        Me.txtTagScarsLocated = New System.Windows.Forms.TextBox
        Me.lblTagScarsLocated = New System.Windows.Forms.Label
        Me.chkInspectedForTagScars = New System.Windows.Forms.CheckBox
        Me.cboRecaptureTypeList = New System.Windows.Forms.ComboBox
        Me.lblRecaptureType = New System.Windows.Forms.Label
        Me.chkWasTurtleCarryingTagsWhenEncountered = New System.Windows.Forms.CheckBox
        Me.lblCaptureProjectOther = New System.Windows.Forms.Label
        Me.txtCaptureProjectOther = New System.Windows.Forms.TextBox
        Me.cboCaptureProjectTypeList = New System.Windows.Forms.ComboBox
        Me.lblProjectType = New System.Windows.Forms.Label
        Me.grdTurtleTagGrid = New System.Windows.Forms.DataGridView
        Me.colTagEditActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colTagDeleteActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colTagTurtleTagIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTagTagNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTagTypeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTagLocationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTagDateTaggedBindableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TurtleTagGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAddTag = New System.Windows.Forms.Button
        Me.tpgTurtleTabMorphometrics = New System.Windows.Forms.TabPage
        Me.tabMorphometricsTab = New System.Windows.Forms.TabControl
        Me.tpgMeasurements = New System.Windows.Forms.TabPage
        Me.grdTurtleMorphometricGrid = New System.Windows.Forms.DataGridView
        Me.colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricEditActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colMorphometricDeleteActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricSclNotchNotchValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricSclNotchNotchUnitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricSclNotchTipValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricSclNotchTipUnitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricSclTipTipValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricSclTipTipUnitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricScwValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricScwUnitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricCclNotchNotchValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricCclNotchNotchUnitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricCclNotchTipValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricCclNotchTipUnitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricCclTipTipValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricCclTipTipUnitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricCcwValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricCcwUnitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricWeightValueDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colMorphometricWeightUnitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TurtleMorphometricGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnAddMorphometric = New System.Windows.Forms.Button
        Me.tpgGraphs = New System.Windows.Forms.TabPage
        Me.lnkCopyToClipboardMorphometricsGraph = New System.Windows.Forms.LinkLabel
        Me.lnkPrintMorphometricsGraph = New System.Windows.Forms.LinkLabel
        Me.pnlGraphChoices = New System.Windows.Forms.Panel
        Me.chkGraphWeight = New System.Windows.Forms.CheckBox
        Me.chkGraphCcw = New System.Windows.Forms.CheckBox
        Me.chkGraphCclNotchNotch = New System.Windows.Forms.CheckBox
        Me.chkGraphCclTipTip = New System.Windows.Forms.CheckBox
        Me.chkGraphCclNotchTip = New System.Windows.Forms.CheckBox
        Me.chkGraphScw = New System.Windows.Forms.CheckBox
        Me.chkGraphSclNotchNotch = New System.Windows.Forms.CheckBox
        Me.chkGraphSclTipTip = New System.Windows.Forms.CheckBox
        Me.chkGraphSclNotchTip = New System.Windows.Forms.CheckBox
        Me.graphMorphometrics = New TurtleGeek.Graphics.Windows.PlotSurface2D
        Me.tpgTurtleTabAttachments = New System.Windows.Forms.TabPage
        Me.lnkUseImageInBrochure = New System.Windows.Forms.LinkLabel
        Me.picAttachmentPreview = New System.Windows.Forms.PictureBox
        Me.btnAddTurtleFileAttachment = New System.Windows.Forms.Button
        Me.btnDeleteAllTurtleFileAttachments = New System.Windows.Forms.Button
        Me.lblPicturePreview = New System.Windows.Forms.Label
        Me.grdTurtleFileAttachmentList = New System.Windows.Forms.DataGridView
        Me.colTurtleFileAttachmentEditActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colTurtleFileAttachmentDeleteActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colTurtleFileAttachmentCopyToActionDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTurtleFileAttachmentIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTurtleFileAttachmentBaseFileNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colTurtleFileAttachmentDateCreatedDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.TurtleAttachmentGridBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.tpgTurtleTabBrochure = New System.Windows.Forms.TabPage
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.picBrochureBackgroundColorOrange = New System.Windows.Forms.PictureBox
        Me.radBrochureBackgroundColorOrange = New System.Windows.Forms.RadioButton
        Me.picBrochureBackgroundColorLightGray = New System.Windows.Forms.PictureBox
        Me.radBrochureBackgroundColorLightGray = New System.Windows.Forms.RadioButton
        Me.picBrochureBackgroundColorLavender = New System.Windows.Forms.PictureBox
        Me.radBrochureBackgroundColorLavender = New System.Windows.Forms.RadioButton
        Me.picBrochureBackgroundColorLightCyan = New System.Windows.Forms.PictureBox
        Me.radBrochureBackgroundColorLightCyan = New System.Windows.Forms.RadioButton
        Me.picBrochureBackgroundColorPaleGreen = New System.Windows.Forms.PictureBox
        Me.radBrochureBackgroundColorPaleGreen = New System.Windows.Forms.RadioButton
        Me.picBrochureBackgroundColorLightYellow = New System.Windows.Forms.PictureBox
        Me.radBrochureBackgroundColorLightYellow = New System.Windows.Forms.RadioButton
        Me.picBrochureBackgroundColorTan = New System.Windows.Forms.PictureBox
        Me.radBrochureBackgroundColorTan = New System.Windows.Forms.RadioButton
        Me.picBrochureBackgroundColorMistyRose = New System.Windows.Forms.PictureBox
        Me.radBrochureBackgroundColorMistyRose = New System.Windows.Forms.RadioButton
        Me.picBrochureBackgroundColorWhite = New System.Windows.Forms.PictureBox
        Me.radBrochureBackgroundColorWhite = New System.Windows.Forms.RadioButton
        Me.lnkBrochureClearImage = New System.Windows.Forms.LinkLabel
        Me.btnPrintBrochure = New System.Windows.Forms.Button
        Me.lblBrochureImage = New System.Windows.Forms.Label
        Me.picBrochureImage = New System.Windows.Forms.PictureBox
        Me.txtBrochureComments = New System.Windows.Forms.TextBox
        Me.lblBrochureComments = New System.Windows.Forms.Label
        Me.btnHelp = New System.Windows.Forms.Button
        Me.btnTaggingDataForm = New System.Windows.Forms.Button
        Me.erpErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.dtpDateCaptured = New TurtleGeek.Controls.DateComboBox
        Me.lblDateCaptured = New System.Windows.Forms.Label
        Me.picMoreInfoDateCaptured = New System.Windows.Forms.PictureBox
        CType(Me.picMoreInfoRelinquishedTo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoreInfoStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoreInfoSize, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoreInfoAcquiredFrom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoreInfoSidNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoreInfoStrandingIdNumber, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoreInfoAnomalies, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picAcquiredLatitudeLongitudeMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRelinquishedLatLonMap, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoreInfoAcquiredCounty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoreInfoAcquiredLatLon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoreInfoRelinquishedLatLon, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoreInfoRelinquishedCounty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoreInfoInitialEncounterInformation, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabTurtleTab.SuspendLayout()
        Me.tpgTurtleTabGeneralInformation.SuspendLayout()
        Me.grpInjuries.SuspendLayout()
        Me.tpgTurtleTabTags.SuspendLayout()
        Me.grpInitialEncounter.SuspendLayout()
        Me.grpInspectedScanned.SuspendLayout()
        CType(Me.grdTurtleTagGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurtleTagGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgTurtleTabMorphometrics.SuspendLayout()
        Me.tabMorphometricsTab.SuspendLayout()
        Me.tpgMeasurements.SuspendLayout()
        CType(Me.grdTurtleMorphometricGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurtleMorphometricGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgGraphs.SuspendLayout()
        Me.pnlGraphChoices.SuspendLayout()
        Me.tpgTurtleTabAttachments.SuspendLayout()
        CType(Me.picAttachmentPreview, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.grdTurtleFileAttachmentList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TurtleAttachmentGridBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tpgTurtleTabBrochure.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.picBrochureBackgroundColorOrange, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrochureBackgroundColorLightGray, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrochureBackgroundColorLavender, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrochureBackgroundColorLightCyan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrochureBackgroundColorPaleGreen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrochureBackgroundColorLightYellow, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrochureBackgroundColorTan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrochureBackgroundColorMistyRose, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrochureBackgroundColorWhite, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBrochureImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMoreInfoDateCaptured, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(8, 443)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(706, 2)
        Me.lblSeparator.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(642, 459)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(562, 459)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 24)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'picMoreInfoRelinquishedTo
        '
        Me.picMoreInfoRelinquishedTo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoRelinquishedTo.Image = CType(resources.GetObject("picMoreInfoRelinquishedTo.Image"), System.Drawing.Image)
        Me.picMoreInfoRelinquishedTo.Location = New System.Drawing.Point(128, 324)
        Me.picMoreInfoRelinquishedTo.Name = "picMoreInfoRelinquishedTo"
        Me.picMoreInfoRelinquishedTo.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoRelinquishedTo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoRelinquishedTo.TabIndex = 50
        Me.picMoreInfoRelinquishedTo.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoRelinquishedTo, "More information about relinquished to")
        '
        'picMoreInfoStatus
        '
        Me.picMoreInfoStatus.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoStatus.Image = CType(resources.GetObject("picMoreInfoStatus.Image"), System.Drawing.Image)
        Me.picMoreInfoStatus.Location = New System.Drawing.Point(128, 137)
        Me.picMoreInfoStatus.Name = "picMoreInfoStatus"
        Me.picMoreInfoStatus.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoStatus.TabIndex = 49
        Me.picMoreInfoStatus.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoStatus, "More information about status")
        '
        'picMoreInfoSize
        '
        Me.picMoreInfoSize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoSize.Image = CType(resources.GetObject("picMoreInfoSize.Image"), System.Drawing.Image)
        Me.picMoreInfoSize.Location = New System.Drawing.Point(128, 115)
        Me.picMoreInfoSize.Name = "picMoreInfoSize"
        Me.picMoreInfoSize.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoSize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoSize.TabIndex = 48
        Me.picMoreInfoSize.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoSize, "More information about size")
        '
        'picMoreInfoAcquiredFrom
        '
        Me.picMoreInfoAcquiredFrom.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoAcquiredFrom.Image = CType(resources.GetObject("picMoreInfoAcquiredFrom.Image"), System.Drawing.Image)
        Me.picMoreInfoAcquiredFrom.Location = New System.Drawing.Point(128, 218)
        Me.picMoreInfoAcquiredFrom.Name = "picMoreInfoAcquiredFrom"
        Me.picMoreInfoAcquiredFrom.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoAcquiredFrom.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoAcquiredFrom.TabIndex = 47
        Me.picMoreInfoAcquiredFrom.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoAcquiredFrom, "More information about acquired from")
        '
        'picMoreInfoSidNumber
        '
        Me.picMoreInfoSidNumber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoSidNumber.Image = CType(resources.GetObject("picMoreInfoSidNumber.Image"), System.Drawing.Image)
        Me.picMoreInfoSidNumber.Location = New System.Drawing.Point(128, 43)
        Me.picMoreInfoSidNumber.Name = "picMoreInfoSidNumber"
        Me.picMoreInfoSidNumber.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoSidNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoSidNumber.TabIndex = 46
        Me.picMoreInfoSidNumber.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoSidNumber, "More information about SID number")
        '
        'picMoreInfoStrandingIdNumber
        '
        Me.picMoreInfoStrandingIdNumber.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoStrandingIdNumber.Image = CType(resources.GetObject("picMoreInfoStrandingIdNumber.Image"), System.Drawing.Image)
        Me.picMoreInfoStrandingIdNumber.Location = New System.Drawing.Point(128, 66)
        Me.picMoreInfoStrandingIdNumber.Name = "picMoreInfoStrandingIdNumber"
        Me.picMoreInfoStrandingIdNumber.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoStrandingIdNumber.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoStrandingIdNumber.TabIndex = 53
        Me.picMoreInfoStrandingIdNumber.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoStrandingIdNumber, "More information about Stranding ID number")
        '
        'picMoreInfoAnomalies
        '
        Me.picMoreInfoAnomalies.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoAnomalies.Image = CType(resources.GetObject("picMoreInfoAnomalies.Image"), System.Drawing.Image)
        Me.picMoreInfoAnomalies.Location = New System.Drawing.Point(479, 2)
        Me.picMoreInfoAnomalies.Name = "picMoreInfoAnomalies"
        Me.picMoreInfoAnomalies.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoAnomalies.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoAnomalies.TabIndex = 56
        Me.picMoreInfoAnomalies.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoAnomalies, "More information about anomalies")
        '
        'picAcquiredLatitudeLongitudeMap
        '
        Me.picAcquiredLatitudeLongitudeMap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picAcquiredLatitudeLongitudeMap.Image = CType(resources.GetObject("picAcquiredLatitudeLongitudeMap.Image"), System.Drawing.Image)
        Me.picAcquiredLatitudeLongitudeMap.Location = New System.Drawing.Point(363, 261)
        Me.picAcquiredLatitudeLongitudeMap.Name = "picAcquiredLatitudeLongitudeMap"
        Me.picAcquiredLatitudeLongitudeMap.Size = New System.Drawing.Size(18, 18)
        Me.picAcquiredLatitudeLongitudeMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picAcquiredLatitudeLongitudeMap.TabIndex = 97
        Me.picAcquiredLatitudeLongitudeMap.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picAcquiredLatitudeLongitudeMap, "Show latitude and longitude location on a map (must be connected to the Internet)" & _
                "")
        '
        'picRelinquishedLatLonMap
        '
        Me.picRelinquishedLatLonMap.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picRelinquishedLatLonMap.Image = CType(resources.GetObject("picRelinquishedLatLonMap.Image"), System.Drawing.Image)
        Me.picRelinquishedLatLonMap.Location = New System.Drawing.Point(363, 367)
        Me.picRelinquishedLatLonMap.Name = "picRelinquishedLatLonMap"
        Me.picRelinquishedLatLonMap.Size = New System.Drawing.Size(18, 18)
        Me.picRelinquishedLatLonMap.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picRelinquishedLatLonMap.TabIndex = 98
        Me.picRelinquishedLatLonMap.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picRelinquishedLatLonMap, "Show latitude and longitude location on a map (must be connected to the Internet)" & _
                "")
        '
        'lnkAcquiredLatitude
        '
        Me.lnkAcquiredLatitude.AutoSize = True
        Me.lnkAcquiredLatitude.Location = New System.Drawing.Point(16, 263)
        Me.lnkAcquiredLatitude.Name = "lnkAcquiredLatitude"
        Me.lnkAcquiredLatitude.Size = New System.Drawing.Size(22, 13)
        Me.lnkAcquiredLatitude.TabIndex = 20
        Me.lnkAcquiredLatitude.TabStop = True
        Me.lnkAcquiredLatitude.Text = "Lat"
        Me.tipToolTip.SetToolTip(Me.lnkAcquiredLatitude, "Convert from degrees/minutes/seconds")
        '
        'lnkAcquiredLongitude
        '
        Me.lnkAcquiredLongitude.AutoSize = True
        Me.lnkAcquiredLongitude.Location = New System.Drawing.Point(47, 263)
        Me.lnkAcquiredLongitude.Name = "lnkAcquiredLongitude"
        Me.lnkAcquiredLongitude.Size = New System.Drawing.Size(25, 13)
        Me.lnkAcquiredLongitude.TabIndex = 22
        Me.lnkAcquiredLongitude.TabStop = True
        Me.lnkAcquiredLongitude.Text = "Lon"
        Me.tipToolTip.SetToolTip(Me.lnkAcquiredLongitude, "Convert from degrees/minutes/seconds")
        '
        'lnkRelinquishedLongitude
        '
        Me.lnkRelinquishedLongitude.AutoSize = True
        Me.lnkRelinquishedLongitude.Location = New System.Drawing.Point(47, 369)
        Me.lnkRelinquishedLongitude.Name = "lnkRelinquishedLongitude"
        Me.lnkRelinquishedLongitude.Size = New System.Drawing.Size(25, 13)
        Me.lnkRelinquishedLongitude.TabIndex = 34
        Me.lnkRelinquishedLongitude.TabStop = True
        Me.lnkRelinquishedLongitude.Text = "Lon"
        Me.tipToolTip.SetToolTip(Me.lnkRelinquishedLongitude, "Convert from degrees/minutes/seconds")
        '
        'lnkRelinquishedLatitude
        '
        Me.lnkRelinquishedLatitude.AutoSize = True
        Me.lnkRelinquishedLatitude.Location = New System.Drawing.Point(16, 369)
        Me.lnkRelinquishedLatitude.Name = "lnkRelinquishedLatitude"
        Me.lnkRelinquishedLatitude.Size = New System.Drawing.Size(22, 13)
        Me.lnkRelinquishedLatitude.TabIndex = 32
        Me.lnkRelinquishedLatitude.TabStop = True
        Me.lnkRelinquishedLatitude.Text = "Lat"
        Me.tipToolTip.SetToolTip(Me.lnkRelinquishedLatitude, "Convert from degrees/minutes/seconds")
        '
        'picMoreInfoAcquiredCounty
        '
        Me.picMoreInfoAcquiredCounty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoAcquiredCounty.Image = CType(resources.GetObject("picMoreInfoAcquiredCounty.Image"), System.Drawing.Image)
        Me.picMoreInfoAcquiredCounty.Location = New System.Drawing.Point(128, 240)
        Me.picMoreInfoAcquiredCounty.Name = "picMoreInfoAcquiredCounty"
        Me.picMoreInfoAcquiredCounty.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoAcquiredCounty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoAcquiredCounty.TabIndex = 106
        Me.picMoreInfoAcquiredCounty.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoAcquiredCounty, "More information about acquired from")
        '
        'picMoreInfoAcquiredLatLon
        '
        Me.picMoreInfoAcquiredLatLon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoAcquiredLatLon.Image = CType(resources.GetObject("picMoreInfoAcquiredLatLon.Image"), System.Drawing.Image)
        Me.picMoreInfoAcquiredLatLon.Location = New System.Drawing.Point(128, 263)
        Me.picMoreInfoAcquiredLatLon.Name = "picMoreInfoAcquiredLatLon"
        Me.picMoreInfoAcquiredLatLon.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoAcquiredLatLon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoAcquiredLatLon.TabIndex = 107
        Me.picMoreInfoAcquiredLatLon.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoAcquiredLatLon, "More information about acquired from")
        '
        'picMoreInfoRelinquishedLatLon
        '
        Me.picMoreInfoRelinquishedLatLon.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoRelinquishedLatLon.Image = CType(resources.GetObject("picMoreInfoRelinquishedLatLon.Image"), System.Drawing.Image)
        Me.picMoreInfoRelinquishedLatLon.Location = New System.Drawing.Point(128, 369)
        Me.picMoreInfoRelinquishedLatLon.Name = "picMoreInfoRelinquishedLatLon"
        Me.picMoreInfoRelinquishedLatLon.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoRelinquishedLatLon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoRelinquishedLatLon.TabIndex = 109
        Me.picMoreInfoRelinquishedLatLon.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoRelinquishedLatLon, "More information about acquired from")
        '
        'picMoreInfoRelinquishedCounty
        '
        Me.picMoreInfoRelinquishedCounty.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoRelinquishedCounty.Image = CType(resources.GetObject("picMoreInfoRelinquishedCounty.Image"), System.Drawing.Image)
        Me.picMoreInfoRelinquishedCounty.Location = New System.Drawing.Point(128, 346)
        Me.picMoreInfoRelinquishedCounty.Name = "picMoreInfoRelinquishedCounty"
        Me.picMoreInfoRelinquishedCounty.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoRelinquishedCounty.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoRelinquishedCounty.TabIndex = 108
        Me.picMoreInfoRelinquishedCounty.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoRelinquishedCounty, "More information about acquired from")
        '
        'picMoreInfoInitialEncounterInformation
        '
        Me.picMoreInfoInitialEncounterInformation.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoInitialEncounterInformation.Image = CType(resources.GetObject("picMoreInfoInitialEncounterInformation.Image"), System.Drawing.Image)
        Me.picMoreInfoInitialEncounterInformation.Location = New System.Drawing.Point(285, 0)
        Me.picMoreInfoInitialEncounterInformation.Name = "picMoreInfoInitialEncounterInformation"
        Me.picMoreInfoInitialEncounterInformation.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoInitialEncounterInformation.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoInitialEncounterInformation.TabIndex = 51
        Me.picMoreInfoInitialEncounterInformation.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoInitialEncounterInformation, "More information about relinquished to")
        '
        'lnkAcquiredCounty
        '
        Me.lnkAcquiredCounty.AutoSize = True
        Me.lnkAcquiredCounty.Location = New System.Drawing.Point(16, 241)
        Me.lnkAcquiredCounty.Name = "lnkAcquiredCounty"
        Me.lnkAcquiredCounty.Size = New System.Drawing.Size(43, 13)
        Me.lnkAcquiredCounty.TabIndex = 18
        Me.lnkAcquiredCounty.TabStop = True
        Me.lnkAcquiredCounty.Text = "County:"
        Me.tipToolTip.SetToolTip(Me.lnkAcquiredCounty, "Add new county")
        '
        'lnkRelinquishedCounty
        '
        Me.lnkRelinquishedCounty.AutoSize = True
        Me.lnkRelinquishedCounty.Location = New System.Drawing.Point(16, 346)
        Me.lnkRelinquishedCounty.Name = "lnkRelinquishedCounty"
        Me.lnkRelinquishedCounty.Size = New System.Drawing.Size(43, 13)
        Me.lnkRelinquishedCounty.TabIndex = 30
        Me.lnkRelinquishedCounty.TabStop = True
        Me.lnkRelinquishedCounty.Text = "County:"
        Me.tipToolTip.SetToolTip(Me.lnkRelinquishedCounty, "Add new county")
        '
        'tabTurtleTab
        '
        Me.tabTurtleTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabTurtleTab.Controls.Add(Me.tpgTurtleTabGeneralInformation)
        Me.tabTurtleTab.Controls.Add(Me.tpgTurtleTabTags)
        Me.tabTurtleTab.Controls.Add(Me.tpgTurtleTabMorphometrics)
        Me.tabTurtleTab.Controls.Add(Me.tpgTurtleTabAttachments)
        Me.tabTurtleTab.Controls.Add(Me.tpgTurtleTabBrochure)
        Me.tabTurtleTab.Location = New System.Drawing.Point(8, 8)
        Me.tabTurtleTab.Name = "tabTurtleTab"
        Me.tabTurtleTab.SelectedIndex = 0
        Me.tabTurtleTab.Size = New System.Drawing.Size(706, 419)
        Me.tabTurtleTab.TabIndex = 0
        '
        'tpgTurtleTabGeneralInformation
        '
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picMoreInfoDateCaptured)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.dtpDateCaptured)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblDateCaptured)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.cboRelinquishedCountyList)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.cboAcquiredCountyList)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lnkRelinquishedCounty)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lnkAcquiredCounty)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lnkAcquiredLongitude)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lnkRelinquishedLongitude)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lnkRelinquishedLatitude)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lnkAcquiredLatitude)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picMoreInfoRelinquishedLatLon)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picMoreInfoRelinquishedCounty)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picMoreInfoAcquiredLatLon)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picMoreInfoAcquiredCounty)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblRelinquishedSlash)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblRelinquishedDecDeg)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblAcquiredSlash)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picRelinquishedLatLonMap)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picAcquiredLatitudeLongitudeMap)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.txtRelinquishedLongitude)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.txtRelinquishedLatitude)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.txtAcquiredLongitude)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblAcquiredDecDeg)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.txtAcquiredLatitude)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.grpInjuries)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picMoreInfoAnomalies)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.txtAnomalies)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblAnomalies)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picMoreInfoStrandingIdNumber)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblStrandingIdNumber)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.txtStrandingIdNumber)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picMoreInfoRelinquishedTo)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picMoreInfoStatus)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picMoreInfoSize)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picMoreInfoAcquiredFrom)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblRelinquishedTo)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.txtRelinquishedTo)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblAcquiredFrom)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.txtAcquiredFrom)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.picMoreInfoSidNumber)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.dtpDateRelinquished)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.dtpDateAcquired)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.cboStatusList)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblStatus)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblSpecies)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblDateRelinquished)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblSize)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblDateAcquired)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblSidNumber)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.txtSidNumber)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.txtTurtleName)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.lblTurtleName)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.cboSizeList)
        Me.tpgTurtleTabGeneralInformation.Controls.Add(Me.cboSpeciesList)
        Me.tpgTurtleTabGeneralInformation.Location = New System.Drawing.Point(4, 22)
        Me.tpgTurtleTabGeneralInformation.Name = "tpgTurtleTabGeneralInformation"
        Me.tpgTurtleTabGeneralInformation.Size = New System.Drawing.Size(698, 393)
        Me.tpgTurtleTabGeneralInformation.TabIndex = 0
        Me.tpgTurtleTabGeneralInformation.Text = "General Information"
        Me.tpgTurtleTabGeneralInformation.UseVisualStyleBackColor = True
        '
        'cboRelinquishedCountyList
        '
        Me.cboRelinquishedCountyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRelinquishedCountyList.FormattingEnabled = True
        Me.cboRelinquishedCountyList.Location = New System.Drawing.Point(144, 343)
        Me.cboRelinquishedCountyList.Name = "cboRelinquishedCountyList"
        Me.cboRelinquishedCountyList.Size = New System.Drawing.Size(216, 21)
        Me.cboRelinquishedCountyList.TabIndex = 31
        '
        'cboAcquiredCountyList
        '
        Me.cboAcquiredCountyList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboAcquiredCountyList.FormattingEnabled = True
        Me.cboAcquiredCountyList.Location = New System.Drawing.Point(144, 237)
        Me.cboAcquiredCountyList.Name = "cboAcquiredCountyList"
        Me.cboAcquiredCountyList.Size = New System.Drawing.Size(216, 21)
        Me.cboAcquiredCountyList.TabIndex = 19
        '
        'lblRelinquishedSlash
        '
        Me.lblRelinquishedSlash.AutoSize = True
        Me.lblRelinquishedSlash.Location = New System.Drawing.Point(36, 369)
        Me.lblRelinquishedSlash.Name = "lblRelinquishedSlash"
        Me.lblRelinquishedSlash.Size = New System.Drawing.Size(12, 13)
        Me.lblRelinquishedSlash.TabIndex = 33
        Me.lblRelinquishedSlash.Text = "/"
        Me.lblRelinquishedSlash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblRelinquishedDecDeg
        '
        Me.lblRelinquishedDecDeg.AutoSize = True
        Me.lblRelinquishedDecDeg.Location = New System.Drawing.Point(71, 369)
        Me.lblRelinquishedDecDeg.Name = "lblRelinquishedDecDeg"
        Me.lblRelinquishedDecDeg.Size = New System.Drawing.Size(55, 13)
        Me.lblRelinquishedDecDeg.TabIndex = 35
        Me.lblRelinquishedDecDeg.Text = "(dec deg):"
        Me.lblRelinquishedDecDeg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAcquiredSlash
        '
        Me.lblAcquiredSlash.AutoSize = True
        Me.lblAcquiredSlash.Location = New System.Drawing.Point(36, 263)
        Me.lblAcquiredSlash.Name = "lblAcquiredSlash"
        Me.lblAcquiredSlash.Size = New System.Drawing.Size(12, 13)
        Me.lblAcquiredSlash.TabIndex = 21
        Me.lblAcquiredSlash.Text = "/"
        Me.lblAcquiredSlash.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRelinquishedLongitude
        '
        Me.txtRelinquishedLongitude.Location = New System.Drawing.Point(260, 366)
        Me.txtRelinquishedLongitude.MaxLength = 255
        Me.txtRelinquishedLongitude.Name = "txtRelinquishedLongitude"
        Me.txtRelinquishedLongitude.Size = New System.Drawing.Size(100, 20)
        Me.txtRelinquishedLongitude.TabIndex = 37
        '
        'txtRelinquishedLatitude
        '
        Me.txtRelinquishedLatitude.Location = New System.Drawing.Point(144, 366)
        Me.txtRelinquishedLatitude.MaxLength = 255
        Me.txtRelinquishedLatitude.Name = "txtRelinquishedLatitude"
        Me.txtRelinquishedLatitude.Size = New System.Drawing.Size(100, 20)
        Me.txtRelinquishedLatitude.TabIndex = 36
        '
        'txtAcquiredLongitude
        '
        Me.txtAcquiredLongitude.Location = New System.Drawing.Point(260, 260)
        Me.txtAcquiredLongitude.MaxLength = 255
        Me.txtAcquiredLongitude.Name = "txtAcquiredLongitude"
        Me.txtAcquiredLongitude.Size = New System.Drawing.Size(100, 20)
        Me.txtAcquiredLongitude.TabIndex = 25
        '
        'lblAcquiredDecDeg
        '
        Me.lblAcquiredDecDeg.AutoSize = True
        Me.lblAcquiredDecDeg.Location = New System.Drawing.Point(71, 263)
        Me.lblAcquiredDecDeg.Name = "lblAcquiredDecDeg"
        Me.lblAcquiredDecDeg.Size = New System.Drawing.Size(55, 13)
        Me.lblAcquiredDecDeg.TabIndex = 23
        Me.lblAcquiredDecDeg.Text = "(dec deg):"
        Me.lblAcquiredDecDeg.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAcquiredLatitude
        '
        Me.txtAcquiredLatitude.Location = New System.Drawing.Point(144, 260)
        Me.txtAcquiredLatitude.MaxLength = 255
        Me.txtAcquiredLatitude.Name = "txtAcquiredLatitude"
        Me.txtAcquiredLatitude.Size = New System.Drawing.Size(100, 20)
        Me.txtAcquiredLatitude.TabIndex = 24
        '
        'grpInjuries
        '
        Me.grpInjuries.Controls.Add(Me.chkInjuryOther)
        Me.grpInjuries.Controls.Add(Me.chkInjuryDoa)
        Me.grpInjuries.Controls.Add(Me.chkInjuryMiscEpidemic)
        Me.grpInjuries.Controls.Add(Me.chkInjuryFibropapilloma)
        Me.grpInjuries.Controls.Add(Me.chkInjuryAnimalBite)
        Me.grpInjuries.Controls.Add(Me.chkInjuryUpperRespiratory)
        Me.grpInjuries.Controls.Add(Me.chkInjuryFishHook)
        Me.grpInjuries.Controls.Add(Me.chkInjuryLineEntanglement)
        Me.grpInjuries.Controls.Add(Me.chkInjuryIntestinalImpaction)
        Me.grpInjuries.Controls.Add(Me.chkInjuryBoatStrike)
        Me.grpInjuries.Location = New System.Drawing.Point(415, 104)
        Me.grpInjuries.Name = "grpInjuries"
        Me.grpInjuries.Size = New System.Drawing.Size(184, 212)
        Me.grpInjuries.TabIndex = 40
        Me.grpInjuries.TabStop = False
        Me.grpInjuries.Text = "Injuries"
        '
        'chkInjuryOther
        '
        Me.chkInjuryOther.AutoSize = True
        Me.chkInjuryOther.Location = New System.Drawing.Point(6, 190)
        Me.chkInjuryOther.Name = "chkInjuryOther"
        Me.chkInjuryOther.Size = New System.Drawing.Size(52, 17)
        Me.chkInjuryOther.TabIndex = 9
        Me.chkInjuryOther.Text = "Other"
        Me.chkInjuryOther.UseVisualStyleBackColor = True
        '
        'chkInjuryDoa
        '
        Me.chkInjuryDoa.AutoSize = True
        Me.chkInjuryDoa.Location = New System.Drawing.Point(6, 171)
        Me.chkInjuryDoa.Name = "chkInjuryDoa"
        Me.chkInjuryDoa.Size = New System.Drawing.Size(49, 17)
        Me.chkInjuryDoa.TabIndex = 8
        Me.chkInjuryDoa.Text = "DOA"
        Me.chkInjuryDoa.UseVisualStyleBackColor = True
        '
        'chkInjuryMiscEpidemic
        '
        Me.chkInjuryMiscEpidemic.AutoSize = True
        Me.chkInjuryMiscEpidemic.Location = New System.Drawing.Point(6, 152)
        Me.chkInjuryMiscEpidemic.Name = "chkInjuryMiscEpidemic"
        Me.chkInjuryMiscEpidemic.Size = New System.Drawing.Size(96, 17)
        Me.chkInjuryMiscEpidemic.TabIndex = 7
        Me.chkInjuryMiscEpidemic.Text = "Misc. epidemic"
        Me.chkInjuryMiscEpidemic.UseVisualStyleBackColor = True
        '
        'chkInjuryFibropapilloma
        '
        Me.chkInjuryFibropapilloma.AutoSize = True
        Me.chkInjuryFibropapilloma.Location = New System.Drawing.Point(6, 133)
        Me.chkInjuryFibropapilloma.Name = "chkInjuryFibropapilloma"
        Me.chkInjuryFibropapilloma.Size = New System.Drawing.Size(93, 17)
        Me.chkInjuryFibropapilloma.TabIndex = 6
        Me.chkInjuryFibropapilloma.Text = "Fibropapilloma"
        Me.chkInjuryFibropapilloma.UseVisualStyleBackColor = True
        '
        'chkInjuryAnimalBite
        '
        Me.chkInjuryAnimalBite.AutoSize = True
        Me.chkInjuryAnimalBite.Location = New System.Drawing.Point(6, 114)
        Me.chkInjuryAnimalBite.Name = "chkInjuryAnimalBite"
        Me.chkInjuryAnimalBite.Size = New System.Drawing.Size(97, 17)
        Me.chkInjuryAnimalBite.TabIndex = 5
        Me.chkInjuryAnimalBite.Text = "Shark/Bird bite"
        Me.chkInjuryAnimalBite.UseVisualStyleBackColor = True
        '
        'chkInjuryUpperRespiratory
        '
        Me.chkInjuryUpperRespiratory.AutoSize = True
        Me.chkInjuryUpperRespiratory.Location = New System.Drawing.Point(6, 95)
        Me.chkInjuryUpperRespiratory.Name = "chkInjuryUpperRespiratory"
        Me.chkInjuryUpperRespiratory.Size = New System.Drawing.Size(106, 17)
        Me.chkInjuryUpperRespiratory.TabIndex = 4
        Me.chkInjuryUpperRespiratory.Text = "Upper respiratory"
        Me.chkInjuryUpperRespiratory.UseVisualStyleBackColor = True
        '
        'chkInjuryFishHook
        '
        Me.chkInjuryFishHook.AutoSize = True
        Me.chkInjuryFishHook.Location = New System.Drawing.Point(6, 76)
        Me.chkInjuryFishHook.Name = "chkInjuryFishHook"
        Me.chkInjuryFishHook.Size = New System.Drawing.Size(72, 17)
        Me.chkInjuryFishHook.TabIndex = 3
        Me.chkInjuryFishHook.Text = "Fish hook"
        Me.chkInjuryFishHook.UseVisualStyleBackColor = True
        '
        'chkInjuryLineEntanglement
        '
        Me.chkInjuryLineEntanglement.AutoSize = True
        Me.chkInjuryLineEntanglement.Location = New System.Drawing.Point(6, 57)
        Me.chkInjuryLineEntanglement.Name = "chkInjuryLineEntanglement"
        Me.chkInjuryLineEntanglement.Size = New System.Drawing.Size(135, 17)
        Me.chkInjuryLineEntanglement.TabIndex = 2
        Me.chkInjuryLineEntanglement.Text = "Line/Net entanglement"
        Me.chkInjuryLineEntanglement.UseVisualStyleBackColor = True
        '
        'chkInjuryIntestinalImpaction
        '
        Me.chkInjuryIntestinalImpaction.AutoSize = True
        Me.chkInjuryIntestinalImpaction.Location = New System.Drawing.Point(6, 38)
        Me.chkInjuryIntestinalImpaction.Name = "chkInjuryIntestinalImpaction"
        Me.chkInjuryIntestinalImpaction.Size = New System.Drawing.Size(116, 17)
        Me.chkInjuryIntestinalImpaction.TabIndex = 1
        Me.chkInjuryIntestinalImpaction.Text = "Intestinal impaction"
        Me.chkInjuryIntestinalImpaction.UseVisualStyleBackColor = True
        '
        'chkInjuryBoatStrike
        '
        Me.chkInjuryBoatStrike.AutoSize = True
        Me.chkInjuryBoatStrike.Location = New System.Drawing.Point(6, 19)
        Me.chkInjuryBoatStrike.Name = "chkInjuryBoatStrike"
        Me.chkInjuryBoatStrike.Size = New System.Drawing.Size(122, 17)
        Me.chkInjuryBoatStrike.TabIndex = 0
        Me.chkInjuryBoatStrike.Text = "Boat/Propeller strike"
        Me.chkInjuryBoatStrike.UseVisualStyleBackColor = True
        '
        'txtAnomalies
        '
        Me.txtAnomalies.Location = New System.Drawing.Point(415, 16)
        Me.txtAnomalies.MaxLength = 255
        Me.txtAnomalies.Multiline = True
        Me.txtAnomalies.Name = "txtAnomalies"
        Me.txtAnomalies.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtAnomalies.Size = New System.Drawing.Size(184, 80)
        Me.txtAnomalies.TabIndex = 39
        '
        'lblAnomalies
        '
        Me.lblAnomalies.Location = New System.Drawing.Point(415, 0)
        Me.lblAnomalies.Name = "lblAnomalies"
        Me.lblAnomalies.Size = New System.Drawing.Size(64, 16)
        Me.lblAnomalies.TabIndex = 38
        Me.lblAnomalies.Text = "Anomalies:"
        Me.lblAnomalies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStrandingIdNumber
        '
        Me.lblStrandingIdNumber.Location = New System.Drawing.Point(16, 62)
        Me.lblStrandingIdNumber.Name = "lblStrandingIdNumber"
        Me.lblStrandingIdNumber.Size = New System.Drawing.Size(112, 20)
        Me.lblStrandingIdNumber.TabIndex = 4
        Me.lblStrandingIdNumber.Text = "Stranding ID number:"
        Me.lblStrandingIdNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStrandingIdNumber
        '
        Me.txtStrandingIdNumber.Location = New System.Drawing.Point(144, 62)
        Me.txtStrandingIdNumber.MaxLength = 255
        Me.txtStrandingIdNumber.Name = "txtStrandingIdNumber"
        Me.txtStrandingIdNumber.Size = New System.Drawing.Size(216, 20)
        Me.txtStrandingIdNumber.TabIndex = 5
        '
        'lblRelinquishedTo
        '
        Me.lblRelinquishedTo.Location = New System.Drawing.Point(16, 320)
        Me.lblRelinquishedTo.Name = "lblRelinquishedTo"
        Me.lblRelinquishedTo.Size = New System.Drawing.Size(112, 20)
        Me.lblRelinquishedTo.TabIndex = 28
        Me.lblRelinquishedTo.Text = "Relinquished to:"
        Me.lblRelinquishedTo.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtRelinquishedTo
        '
        Me.txtRelinquishedTo.Location = New System.Drawing.Point(144, 320)
        Me.txtRelinquishedTo.MaxLength = 255
        Me.txtRelinquishedTo.Name = "txtRelinquishedTo"
        Me.txtRelinquishedTo.Size = New System.Drawing.Size(216, 20)
        Me.txtRelinquishedTo.TabIndex = 29
        '
        'lblAcquiredFrom
        '
        Me.lblAcquiredFrom.Location = New System.Drawing.Point(16, 214)
        Me.lblAcquiredFrom.Name = "lblAcquiredFrom"
        Me.lblAcquiredFrom.Size = New System.Drawing.Size(112, 20)
        Me.lblAcquiredFrom.TabIndex = 16
        Me.lblAcquiredFrom.Text = "Acquired from:"
        Me.lblAcquiredFrom.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAcquiredFrom
        '
        Me.txtAcquiredFrom.Location = New System.Drawing.Point(144, 214)
        Me.txtAcquiredFrom.MaxLength = 255
        Me.txtAcquiredFrom.Name = "txtAcquiredFrom"
        Me.txtAcquiredFrom.Size = New System.Drawing.Size(216, 20)
        Me.txtAcquiredFrom.TabIndex = 17
        '
        'dtpDateRelinquished
        '
        Me.dtpDateRelinquished.BackColor = System.Drawing.SystemColors.Window
        Me.dtpDateRelinquished.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dtpDateRelinquished.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtpDateRelinquished.DateValue = New Date(2006, 5, 30, 0, 0, 0, 0)
        Me.dtpDateRelinquished.Location = New System.Drawing.Point(144, 297)
        Me.dtpDateRelinquished.MaxValue = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateRelinquished.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateRelinquished.Name = "dtpDateRelinquished"
        Me.dtpDateRelinquished.Size = New System.Drawing.Size(216, 20)
        Me.dtpDateRelinquished.TabIndex = 27
        '
        'dtpDateAcquired
        '
        Me.dtpDateAcquired.BackColor = System.Drawing.SystemColors.Window
        Me.dtpDateAcquired.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dtpDateAcquired.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtpDateAcquired.DateValue = New Date(2006, 5, 30, 0, 0, 0, 0)
        Me.dtpDateAcquired.Location = New System.Drawing.Point(144, 191)
        Me.dtpDateAcquired.MaxValue = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateAcquired.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateAcquired.Name = "dtpDateAcquired"
        Me.dtpDateAcquired.Size = New System.Drawing.Size(216, 20)
        Me.dtpDateAcquired.TabIndex = 15
        '
        'cboStatusList
        '
        Me.cboStatusList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboStatusList.Location = New System.Drawing.Point(144, 133)
        Me.cboStatusList.Name = "cboStatusList"
        Me.cboStatusList.Size = New System.Drawing.Size(216, 21)
        Me.cboStatusList.TabIndex = 11
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(16, 133)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(112, 20)
        Me.lblStatus.TabIndex = 10
        Me.lblStatus.Text = "Status:"
        Me.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSpecies
        '
        Me.lblSpecies.Location = New System.Drawing.Point(16, 85)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(112, 20)
        Me.lblSpecies.TabIndex = 6
        Me.lblSpecies.Text = "Species:"
        Me.lblSpecies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateRelinquished
        '
        Me.lblDateRelinquished.Location = New System.Drawing.Point(16, 297)
        Me.lblDateRelinquished.Name = "lblDateRelinquished"
        Me.lblDateRelinquished.Size = New System.Drawing.Size(112, 20)
        Me.lblDateRelinquished.TabIndex = 26
        Me.lblDateRelinquished.Text = "Date relinquished:"
        Me.lblDateRelinquished.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSize
        '
        Me.lblSize.Location = New System.Drawing.Point(16, 109)
        Me.lblSize.Name = "lblSize"
        Me.lblSize.Size = New System.Drawing.Size(112, 20)
        Me.lblSize.TabIndex = 8
        Me.lblSize.Text = "Size:"
        Me.lblSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateAcquired
        '
        Me.lblDateAcquired.Location = New System.Drawing.Point(16, 191)
        Me.lblDateAcquired.Name = "lblDateAcquired"
        Me.lblDateAcquired.Size = New System.Drawing.Size(112, 20)
        Me.lblDateAcquired.TabIndex = 14
        Me.lblDateAcquired.Text = "Date acquired:"
        Me.lblDateAcquired.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSidNumber
        '
        Me.lblSidNumber.Location = New System.Drawing.Point(16, 39)
        Me.lblSidNumber.Name = "lblSidNumber"
        Me.lblSidNumber.Size = New System.Drawing.Size(112, 20)
        Me.lblSidNumber.TabIndex = 2
        Me.lblSidNumber.Text = "SID number:"
        Me.lblSidNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtSidNumber
        '
        Me.txtSidNumber.Location = New System.Drawing.Point(144, 39)
        Me.txtSidNumber.MaxLength = 255
        Me.txtSidNumber.Name = "txtSidNumber"
        Me.txtSidNumber.Size = New System.Drawing.Size(216, 20)
        Me.txtSidNumber.TabIndex = 3
        '
        'txtTurtleName
        '
        Me.txtTurtleName.Location = New System.Drawing.Point(144, 16)
        Me.txtTurtleName.MaxLength = 255
        Me.txtTurtleName.Name = "txtTurtleName"
        Me.txtTurtleName.Size = New System.Drawing.Size(216, 20)
        Me.txtTurtleName.TabIndex = 1
        '
        'lblTurtleName
        '
        Me.lblTurtleName.Location = New System.Drawing.Point(16, 16)
        Me.lblTurtleName.Name = "lblTurtleName"
        Me.lblTurtleName.Size = New System.Drawing.Size(112, 20)
        Me.lblTurtleName.TabIndex = 0
        Me.lblTurtleName.Text = "Turtle name:"
        Me.lblTurtleName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboSizeList
        '
        Me.cboSizeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSizeList.Location = New System.Drawing.Point(144, 109)
        Me.cboSizeList.Name = "cboSizeList"
        Me.cboSizeList.Size = New System.Drawing.Size(216, 21)
        Me.cboSizeList.TabIndex = 9
        '
        'cboSpeciesList
        '
        Me.cboSpeciesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpeciesList.Location = New System.Drawing.Point(144, 85)
        Me.cboSpeciesList.Name = "cboSpeciesList"
        Me.cboSpeciesList.Size = New System.Drawing.Size(216, 21)
        Me.cboSpeciesList.TabIndex = 7
        '
        'tpgTurtleTabTags
        '
        Me.tpgTurtleTabTags.Controls.Add(Me.grpInitialEncounter)
        Me.tpgTurtleTabTags.Controls.Add(Me.grdTurtleTagGrid)
        Me.tpgTurtleTabTags.Controls.Add(Me.btnAddTag)
        Me.tpgTurtleTabTags.Location = New System.Drawing.Point(4, 22)
        Me.tpgTurtleTabTags.Name = "tpgTurtleTabTags"
        Me.tpgTurtleTabTags.Size = New System.Drawing.Size(698, 370)
        Me.tpgTurtleTabTags.TabIndex = 1
        Me.tpgTurtleTabTags.Text = "Tags"
        Me.tpgTurtleTabTags.UseVisualStyleBackColor = True
        '
        'grpInitialEncounter
        '
        Me.grpInitialEncounter.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grpInitialEncounter.Controls.Add(Me.picMoreInfoInitialEncounterInformation)
        Me.grpInitialEncounter.Controls.Add(Me.lblTagReturnAddress)
        Me.grpInitialEncounter.Controls.Add(Me.txtTagReturnAddress)
        Me.grpInitialEncounter.Controls.Add(Me.lblDidTurtleNest)
        Me.grpInitialEncounter.Controls.Add(Me.cboDidTurtleNestList)
        Me.grpInitialEncounter.Controls.Add(Me.grpInspectedScanned)
        Me.grpInitialEncounter.Controls.Add(Me.cboRecaptureTypeList)
        Me.grpInitialEncounter.Controls.Add(Me.lblRecaptureType)
        Me.grpInitialEncounter.Controls.Add(Me.chkWasTurtleCarryingTagsWhenEncountered)
        Me.grpInitialEncounter.Controls.Add(Me.lblCaptureProjectOther)
        Me.grpInitialEncounter.Controls.Add(Me.txtCaptureProjectOther)
        Me.grpInitialEncounter.Controls.Add(Me.cboCaptureProjectTypeList)
        Me.grpInitialEncounter.Controls.Add(Me.lblProjectType)
        Me.grpInitialEncounter.Location = New System.Drawing.Point(8, 169)
        Me.grpInitialEncounter.Name = "grpInitialEncounter"
        Me.grpInitialEncounter.Size = New System.Drawing.Size(682, 198)
        Me.grpInitialEncounter.TabIndex = 2
        Me.grpInitialEncounter.TabStop = False
        Me.grpInitialEncounter.Text = "Initial encounter information (used on Tagging Data Form)"
        '
        'lblTagReturnAddress
        '
        Me.lblTagReturnAddress.AutoSize = True
        Me.lblTagReturnAddress.Location = New System.Drawing.Point(17, 78)
        Me.lblTagReturnAddress.Name = "lblTagReturnAddress"
        Me.lblTagReturnAddress.Size = New System.Drawing.Size(99, 13)
        Me.lblTagReturnAddress.TabIndex = 3
        Me.lblTagReturnAddress.Text = "Tag return address:"
        '
        'txtTagReturnAddress
        '
        Me.txtTagReturnAddress.Location = New System.Drawing.Point(132, 75)
        Me.txtTagReturnAddress.MaxLength = 255
        Me.txtTagReturnAddress.Name = "txtTagReturnAddress"
        Me.txtTagReturnAddress.Size = New System.Drawing.Size(241, 20)
        Me.txtTagReturnAddress.TabIndex = 4
        '
        'lblDidTurtleNest
        '
        Me.lblDidTurtleNest.AutoSize = True
        Me.lblDidTurtleNest.Location = New System.Drawing.Point(17, 145)
        Me.lblDidTurtleNest.Name = "lblDidTurtleNest"
        Me.lblDidTurtleNest.Size = New System.Drawing.Size(170, 13)
        Me.lblDidTurtleNest.TabIndex = 7
        Me.lblDidTurtleNest.Text = "If ""Nesting beach,"" did turtle nest?"
        '
        'cboDidTurtleNestList
        '
        Me.cboDidTurtleNestList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboDidTurtleNestList.Location = New System.Drawing.Point(193, 141)
        Me.cboDidTurtleNestList.Name = "cboDidTurtleNestList"
        Me.cboDidTurtleNestList.Size = New System.Drawing.Size(180, 21)
        Me.cboDidTurtleNestList.TabIndex = 8
        '
        'grpInspectedScanned
        '
        Me.grpInspectedScanned.Controls.Add(Me.txtLivingTagsLocated)
        Me.grpInspectedScanned.Controls.Add(Me.lblLivingTagsLocated)
        Me.grpInspectedScanned.Controls.Add(Me.chkInspectedForLivingTags)
        Me.grpInspectedScanned.Controls.Add(Me.txtMagneticWiresLocated)
        Me.grpInspectedScanned.Controls.Add(Me.lblMagneticWiresLocated)
        Me.grpInspectedScanned.Controls.Add(Me.chkScannedForMagneticWires)
        Me.grpInspectedScanned.Controls.Add(Me.txtPitTagsFrequency)
        Me.grpInspectedScanned.Controls.Add(Me.lblPitTagsFrequency)
        Me.grpInspectedScanned.Controls.Add(Me.chkScannedForPitTags)
        Me.grpInspectedScanned.Controls.Add(Me.txtTagScarsLocated)
        Me.grpInspectedScanned.Controls.Add(Me.lblTagScarsLocated)
        Me.grpInspectedScanned.Controls.Add(Me.chkInspectedForTagScars)
        Me.grpInspectedScanned.Location = New System.Drawing.Point(390, 14)
        Me.grpInspectedScanned.Name = "grpInspectedScanned"
        Me.grpInspectedScanned.Size = New System.Drawing.Size(286, 121)
        Me.grpInspectedScanned.TabIndex = 9
        Me.grpInspectedScanned.TabStop = False
        Me.grpInspectedScanned.Text = "Turtle was inspected and/or scanned for"
        '
        'txtLivingTagsLocated
        '
        Me.txtLivingTagsLocated.Location = New System.Drawing.Point(174, 96)
        Me.txtLivingTagsLocated.MaxLength = 255
        Me.txtLivingTagsLocated.Name = "txtLivingTagsLocated"
        Me.txtLivingTagsLocated.Size = New System.Drawing.Size(106, 20)
        Me.txtLivingTagsLocated.TabIndex = 11
        '
        'lblLivingTagsLocated
        '
        Me.lblLivingTagsLocated.AutoSize = True
        Me.lblLivingTagsLocated.Location = New System.Drawing.Point(109, 99)
        Me.lblLivingTagsLocated.Name = "lblLivingTagsLocated"
        Me.lblLivingTagsLocated.Size = New System.Drawing.Size(52, 13)
        Me.lblLivingTagsLocated.TabIndex = 10
        Me.lblLivingTagsLocated.Text = "Located?"
        '
        'chkInspectedForLivingTags
        '
        Me.chkInspectedForLivingTags.AutoSize = True
        Me.chkInspectedForLivingTags.Location = New System.Drawing.Point(6, 97)
        Me.chkInspectedForLivingTags.Name = "chkInspectedForLivingTags"
        Me.chkInspectedForLivingTags.Size = New System.Drawing.Size(77, 17)
        Me.chkInspectedForLivingTags.TabIndex = 9
        Me.chkInspectedForLivingTags.Text = "Living tags"
        Me.chkInspectedForLivingTags.UseVisualStyleBackColor = True
        '
        'txtMagneticWiresLocated
        '
        Me.txtMagneticWiresLocated.Location = New System.Drawing.Point(174, 70)
        Me.txtMagneticWiresLocated.MaxLength = 255
        Me.txtMagneticWiresLocated.Name = "txtMagneticWiresLocated"
        Me.txtMagneticWiresLocated.Size = New System.Drawing.Size(106, 20)
        Me.txtMagneticWiresLocated.TabIndex = 8
        '
        'lblMagneticWiresLocated
        '
        Me.lblMagneticWiresLocated.AutoSize = True
        Me.lblMagneticWiresLocated.Location = New System.Drawing.Point(109, 73)
        Me.lblMagneticWiresLocated.Name = "lblMagneticWiresLocated"
        Me.lblMagneticWiresLocated.Size = New System.Drawing.Size(52, 13)
        Me.lblMagneticWiresLocated.TabIndex = 7
        Me.lblMagneticWiresLocated.Text = "Located?"
        '
        'chkScannedForMagneticWires
        '
        Me.chkScannedForMagneticWires.AutoSize = True
        Me.chkScannedForMagneticWires.Location = New System.Drawing.Point(6, 71)
        Me.chkScannedForMagneticWires.Name = "chkScannedForMagneticWires"
        Me.chkScannedForMagneticWires.Size = New System.Drawing.Size(97, 17)
        Me.chkScannedForMagneticWires.TabIndex = 6
        Me.chkScannedForMagneticWires.Text = "Magnetic wires"
        Me.chkScannedForMagneticWires.UseVisualStyleBackColor = True
        '
        'txtPitTagsFrequency
        '
        Me.txtPitTagsFrequency.Location = New System.Drawing.Point(174, 44)
        Me.txtPitTagsFrequency.MaxLength = 255
        Me.txtPitTagsFrequency.Name = "txtPitTagsFrequency"
        Me.txtPitTagsFrequency.Size = New System.Drawing.Size(106, 20)
        Me.txtPitTagsFrequency.TabIndex = 5
        '
        'lblPitTagsFrequency
        '
        Me.lblPitTagsFrequency.AutoSize = True
        Me.lblPitTagsFrequency.Location = New System.Drawing.Point(98, 46)
        Me.lblPitTagsFrequency.Name = "lblPitTagsFrequency"
        Me.lblPitTagsFrequency.Size = New System.Drawing.Size(63, 13)
        Me.lblPitTagsFrequency.TabIndex = 4
        Me.lblPitTagsFrequency.Text = "Frequency?"
        '
        'chkScannedForPitTags
        '
        Me.chkScannedForPitTags.AutoSize = True
        Me.chkScannedForPitTags.Location = New System.Drawing.Point(6, 45)
        Me.chkScannedForPitTags.Name = "chkScannedForPitTags"
        Me.chkScannedForPitTags.Size = New System.Drawing.Size(66, 17)
        Me.chkScannedForPitTags.TabIndex = 3
        Me.chkScannedForPitTags.Text = "PIT tags"
        Me.chkScannedForPitTags.UseVisualStyleBackColor = True
        '
        'txtTagScarsLocated
        '
        Me.txtTagScarsLocated.Location = New System.Drawing.Point(174, 18)
        Me.txtTagScarsLocated.MaxLength = 255
        Me.txtTagScarsLocated.Name = "txtTagScarsLocated"
        Me.txtTagScarsLocated.Size = New System.Drawing.Size(106, 20)
        Me.txtTagScarsLocated.TabIndex = 2
        '
        'lblTagScarsLocated
        '
        Me.lblTagScarsLocated.AutoSize = True
        Me.lblTagScarsLocated.Location = New System.Drawing.Point(109, 21)
        Me.lblTagScarsLocated.Name = "lblTagScarsLocated"
        Me.lblTagScarsLocated.Size = New System.Drawing.Size(52, 13)
        Me.lblTagScarsLocated.TabIndex = 1
        Me.lblTagScarsLocated.Text = "Located?"
        '
        'chkInspectedForTagScars
        '
        Me.chkInspectedForTagScars.AutoSize = True
        Me.chkInspectedForTagScars.Location = New System.Drawing.Point(6, 19)
        Me.chkInspectedForTagScars.Name = "chkInspectedForTagScars"
        Me.chkInspectedForTagScars.Size = New System.Drawing.Size(73, 17)
        Me.chkInspectedForTagScars.TabIndex = 0
        Me.chkInspectedForTagScars.Text = "Tag scars"
        Me.chkInspectedForTagScars.UseVisualStyleBackColor = True
        '
        'cboRecaptureTypeList
        '
        Me.cboRecaptureTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboRecaptureTypeList.Location = New System.Drawing.Point(132, 48)
        Me.cboRecaptureTypeList.Name = "cboRecaptureTypeList"
        Me.cboRecaptureTypeList.Size = New System.Drawing.Size(241, 21)
        Me.cboRecaptureTypeList.TabIndex = 2
        '
        'lblRecaptureType
        '
        Me.lblRecaptureType.AutoSize = True
        Me.lblRecaptureType.Location = New System.Drawing.Point(17, 51)
        Me.lblRecaptureType.Name = "lblRecaptureType"
        Me.lblRecaptureType.Size = New System.Drawing.Size(109, 13)
        Me.lblRecaptureType.TabIndex = 1
        Me.lblRecaptureType.Text = "If yes, recapture type:"
        '
        'chkWasTurtleCarryingTagsWhenEncountered
        '
        Me.chkWasTurtleCarryingTagsWhenEncountered.AutoSize = True
        Me.chkWasTurtleCarryingTagsWhenEncountered.Location = New System.Drawing.Point(12, 28)
        Me.chkWasTurtleCarryingTagsWhenEncountered.Name = "chkWasTurtleCarryingTagsWhenEncountered"
        Me.chkWasTurtleCarryingTagsWhenEncountered.Size = New System.Drawing.Size(268, 17)
        Me.chkWasTurtleCarryingTagsWhenEncountered.TabIndex = 0
        Me.chkWasTurtleCarryingTagsWhenEncountered.Text = "Was turtle carrying tags when initially encountered?"
        Me.chkWasTurtleCarryingTagsWhenEncountered.UseVisualStyleBackColor = True
        '
        'lblCaptureProjectOther
        '
        Me.lblCaptureProjectOther.AutoSize = True
        Me.lblCaptureProjectOther.Location = New System.Drawing.Point(17, 168)
        Me.lblCaptureProjectOther.Name = "lblCaptureProjectOther"
        Me.lblCaptureProjectOther.Size = New System.Drawing.Size(101, 13)
        Me.lblCaptureProjectOther.TabIndex = 9
        Me.lblCaptureProjectOther.Text = "If ""Other,"" describe:"
        '
        'txtCaptureProjectOther
        '
        Me.txtCaptureProjectOther.Location = New System.Drawing.Point(124, 165)
        Me.txtCaptureProjectOther.MaxLength = 255
        Me.txtCaptureProjectOther.Name = "txtCaptureProjectOther"
        Me.txtCaptureProjectOther.Size = New System.Drawing.Size(249, 20)
        Me.txtCaptureProjectOther.TabIndex = 10
        '
        'cboCaptureProjectTypeList
        '
        Me.cboCaptureProjectTypeList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboCaptureProjectTypeList.Location = New System.Drawing.Point(81, 114)
        Me.cboCaptureProjectTypeList.Name = "cboCaptureProjectTypeList"
        Me.cboCaptureProjectTypeList.Size = New System.Drawing.Size(139, 21)
        Me.cboCaptureProjectTypeList.TabIndex = 6
        '
        'lblProjectType
        '
        Me.lblProjectType.AutoSize = True
        Me.lblProjectType.Location = New System.Drawing.Point(9, 117)
        Me.lblProjectType.Name = "lblProjectType"
        Me.lblProjectType.Size = New System.Drawing.Size(66, 13)
        Me.lblProjectType.TabIndex = 5
        Me.lblProjectType.Text = "Project type:"
        '
        'grdTurtleTagGrid
        '
        Me.grdTurtleTagGrid.AllowUserToAddRows = False
        Me.grdTurtleTagGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTurtleTagGrid.AutoGenerateColumns = False
        Me.grdTurtleTagGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdTurtleTagGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTagEditActionDataGridViewLinkColumn, Me.colTagDeleteActionDataGridViewLinkColumn, Me.colTagTurtleTagIDDataGridViewTextBoxColumn, Me.colTagTagNumberDataGridViewTextBoxColumn, Me.colTagTypeDataGridViewTextBoxColumn, Me.colTagLocationDataGridViewTextBoxColumn, Me.colTagDateTaggedBindableDataGridViewTextBoxColumn})
        Me.grdTurtleTagGrid.DataSource = Me.TurtleTagGridBindingSource
        DataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle16.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdTurtleTagGrid.DefaultCellStyle = DataGridViewCellStyle16
        Me.grdTurtleTagGrid.Location = New System.Drawing.Point(8, 20)
        Me.grdTurtleTagGrid.MultiSelect = False
        Me.grdTurtleTagGrid.Name = "grdTurtleTagGrid"
        Me.grdTurtleTagGrid.ReadOnly = True
        Me.grdTurtleTagGrid.RowHeadersVisible = False
        Me.grdTurtleTagGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTurtleTagGrid.Size = New System.Drawing.Size(682, 143)
        Me.grdTurtleTagGrid.TabIndex = 1
        '
        'colTagEditActionDataGridViewLinkColumn
        '
        Me.colTagEditActionDataGridViewLinkColumn.DataPropertyName = "EditAction"
        Me.colTagEditActionDataGridViewLinkColumn.Frozen = True
        Me.colTagEditActionDataGridViewLinkColumn.HeaderText = ""
        Me.colTagEditActionDataGridViewLinkColumn.Name = "colTagEditActionDataGridViewLinkColumn"
        Me.colTagEditActionDataGridViewLinkColumn.ReadOnly = True
        Me.colTagEditActionDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTagEditActionDataGridViewLinkColumn.TrackVisitedState = False
        Me.colTagEditActionDataGridViewLinkColumn.Width = 28
        '
        'colTagDeleteActionDataGridViewLinkColumn
        '
        Me.colTagDeleteActionDataGridViewLinkColumn.DataPropertyName = "DeleteAction"
        Me.colTagDeleteActionDataGridViewLinkColumn.Frozen = True
        Me.colTagDeleteActionDataGridViewLinkColumn.HeaderText = ""
        Me.colTagDeleteActionDataGridViewLinkColumn.Name = "colTagDeleteActionDataGridViewLinkColumn"
        Me.colTagDeleteActionDataGridViewLinkColumn.ReadOnly = True
        Me.colTagDeleteActionDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTagDeleteActionDataGridViewLinkColumn.TrackVisitedState = False
        Me.colTagDeleteActionDataGridViewLinkColumn.Width = 40
        '
        'colTagTurtleTagIDDataGridViewTextBoxColumn
        '
        Me.colTagTurtleTagIDDataGridViewTextBoxColumn.DataPropertyName = "TurtleTagID"
        Me.colTagTurtleTagIDDataGridViewTextBoxColumn.HeaderText = "TurtleTagID"
        Me.colTagTurtleTagIDDataGridViewTextBoxColumn.Name = "colTagTurtleTagIDDataGridViewTextBoxColumn"
        Me.colTagTurtleTagIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTagTurtleTagIDDataGridViewTextBoxColumn.Visible = False
        '
        'colTagTagNumberDataGridViewTextBoxColumn
        '
        Me.colTagTagNumberDataGridViewTextBoxColumn.DataPropertyName = "TagNumber"
        Me.colTagTagNumberDataGridViewTextBoxColumn.HeaderText = "Tag Number"
        Me.colTagTagNumberDataGridViewTextBoxColumn.Name = "colTagTagNumberDataGridViewTextBoxColumn"
        Me.colTagTagNumberDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTagTagNumberDataGridViewTextBoxColumn.Width = 120
        '
        'colTagTypeDataGridViewTextBoxColumn
        '
        Me.colTagTypeDataGridViewTextBoxColumn.DataPropertyName = "TagType"
        Me.colTagTypeDataGridViewTextBoxColumn.HeaderText = "Tag Type"
        Me.colTagTypeDataGridViewTextBoxColumn.Name = "colTagTypeDataGridViewTextBoxColumn"
        Me.colTagTypeDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTagTypeDataGridViewTextBoxColumn.Width = 120
        '
        'colTagLocationDataGridViewTextBoxColumn
        '
        Me.colTagLocationDataGridViewTextBoxColumn.DataPropertyName = "Location"
        Me.colTagLocationDataGridViewTextBoxColumn.HeaderText = "Location"
        Me.colTagLocationDataGridViewTextBoxColumn.Name = "colTagLocationDataGridViewTextBoxColumn"
        Me.colTagLocationDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTagLocationDataGridViewTextBoxColumn.Width = 120
        '
        'colTagDateTaggedBindableDataGridViewTextBoxColumn
        '
        Me.colTagDateTaggedBindableDataGridViewTextBoxColumn.DataPropertyName = "DateTaggedBindable"
        DataGridViewCellStyle15.Format = "d"
        Me.colTagDateTaggedBindableDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle15
        Me.colTagDateTaggedBindableDataGridViewTextBoxColumn.HeaderText = "Date Tagged"
        Me.colTagDateTaggedBindableDataGridViewTextBoxColumn.Name = "colTagDateTaggedBindableDataGridViewTextBoxColumn"
        Me.colTagDateTaggedBindableDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTagDateTaggedBindableDataGridViewTextBoxColumn.Width = 120
        '
        'TurtleTagGridBindingSource
        '
        Me.TurtleTagGridBindingSource.DataSource = GetType(TurtleGeek.Roster.TurtleTags)
        '
        'btnAddTag
        '
        Me.btnAddTag.BackColor = System.Drawing.Color.MintCream
        Me.btnAddTag.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddTag.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddTag.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddTag.ForeColor = System.Drawing.Color.Blue
        Me.btnAddTag.Location = New System.Drawing.Point(8, 0)
        Me.btnAddTag.Name = "btnAddTag"
        Me.btnAddTag.Size = New System.Drawing.Size(37, 20)
        Me.btnAddTag.TabIndex = 0
        Me.btnAddTag.Text = "add"
        Me.btnAddTag.UseVisualStyleBackColor = False
        '
        'tpgTurtleTabMorphometrics
        '
        Me.tpgTurtleTabMorphometrics.Controls.Add(Me.tabMorphometricsTab)
        Me.tpgTurtleTabMorphometrics.Location = New System.Drawing.Point(4, 22)
        Me.tpgTurtleTabMorphometrics.Name = "tpgTurtleTabMorphometrics"
        Me.tpgTurtleTabMorphometrics.Size = New System.Drawing.Size(698, 370)
        Me.tpgTurtleTabMorphometrics.TabIndex = 2
        Me.tpgTurtleTabMorphometrics.Text = "Morphometrics"
        Me.tpgTurtleTabMorphometrics.UseVisualStyleBackColor = True
        '
        'tabMorphometricsTab
        '
        Me.tabMorphometricsTab.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.tabMorphometricsTab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabMorphometricsTab.Controls.Add(Me.tpgMeasurements)
        Me.tabMorphometricsTab.Controls.Add(Me.tpgGraphs)
        Me.tabMorphometricsTab.Location = New System.Drawing.Point(8, 3)
        Me.tabMorphometricsTab.Name = "tabMorphometricsTab"
        Me.tabMorphometricsTab.SelectedIndex = 0
        Me.tabMorphometricsTab.Size = New System.Drawing.Size(687, 364)
        Me.tabMorphometricsTab.TabIndex = 0
        '
        'tpgMeasurements
        '
        Me.tpgMeasurements.Controls.Add(Me.grdTurtleMorphometricGrid)
        Me.tpgMeasurements.Controls.Add(Me.btnAddMorphometric)
        Me.tpgMeasurements.Location = New System.Drawing.Point(4, 4)
        Me.tpgMeasurements.Name = "tpgMeasurements"
        Me.tpgMeasurements.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgMeasurements.Size = New System.Drawing.Size(679, 338)
        Me.tpgMeasurements.TabIndex = 0
        Me.tpgMeasurements.Text = "Measurements"
        Me.tpgMeasurements.UseVisualStyleBackColor = True
        '
        'grdTurtleMorphometricGrid
        '
        Me.grdTurtleMorphometricGrid.AllowUserToAddRows = False
        Me.grdTurtleMorphometricGrid.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTurtleMorphometricGrid.AutoGenerateColumns = False
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdTurtleMorphometricGrid.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle17
        Me.grdTurtleMorphometricGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grdTurtleMorphometricGrid.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn, Me.colMorphometricEditActionDataGridViewLinkColumn, Me.colMorphometricDeleteActionDataGridViewLinkColumn, Me.colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn, Me.colMorphometricSclNotchNotchValueDataGridViewTextBoxColumn, Me.colMorphometricSclNotchNotchUnitsDataGridViewTextBoxColumn, Me.colMorphometricSclNotchTipValueDataGridViewTextBoxColumn, Me.colMorphometricSclNotchTipUnitsDataGridViewTextBoxColumn, Me.colMorphometricSclTipTipValueDataGridViewTextBoxColumn, Me.colMorphometricSclTipTipUnitsDataGridViewTextBoxColumn, Me.colMorphometricScwValueDataGridViewTextBoxColumn, Me.colMorphometricScwUnitsDataGridViewTextBoxColumn, Me.colMorphometricCclNotchNotchValueDataGridViewTextBoxColumn, Me.colMorphometricCclNotchNotchUnitsDataGridViewTextBoxColumn, Me.colMorphometricCclNotchTipValueDataGridViewTextBoxColumn, Me.colMorphometricCclNotchTipUnitsDataGridViewTextBoxColumn, Me.colMorphometricCclTipTipValueDataGridViewTextBoxColumn, Me.colMorphometricCclTipTipUnitsDataGridViewTextBoxColumn, Me.colMorphometricCcwValueDataGridViewTextBoxColumn, Me.colMorphometricCcwUnitsDataGridViewTextBoxColumn, Me.colMorphometricWeightValueDataGridViewTextBoxColumn, Me.colMorphometricWeightUnitsDataGridViewTextBoxColumn})
        Me.grdTurtleMorphometricGrid.DataSource = Me.TurtleMorphometricGridBindingSource
        DataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle19.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle19.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle19.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.LightYellow
        DataGridViewCellStyle19.SelectionForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdTurtleMorphometricGrid.DefaultCellStyle = DataGridViewCellStyle19
        Me.grdTurtleMorphometricGrid.Location = New System.Drawing.Point(0, 20)
        Me.grdTurtleMorphometricGrid.MultiSelect = False
        Me.grdTurtleMorphometricGrid.Name = "grdTurtleMorphometricGrid"
        Me.grdTurtleMorphometricGrid.ReadOnly = True
        Me.grdTurtleMorphometricGrid.RowHeadersVisible = False
        Me.grdTurtleMorphometricGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTurtleMorphometricGrid.Size = New System.Drawing.Size(670, 314)
        Me.grdTurtleMorphometricGrid.TabIndex = 1
        '
        'colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn
        '
        Me.colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn.DataPropertyName = "DateMeasuredBindable"
        DataGridViewCellStyle18.Format = "d"
        Me.colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn.DefaultCellStyle = DataGridViewCellStyle18
        Me.colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn.Frozen = True
        Me.colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn.HeaderText = "Date Measured"
        Me.colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn.Name = "colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn"
        Me.colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn.Width = 70
        '
        'colMorphometricEditActionDataGridViewLinkColumn
        '
        Me.colMorphometricEditActionDataGridViewLinkColumn.DataPropertyName = "EditAction"
        Me.colMorphometricEditActionDataGridViewLinkColumn.Frozen = True
        Me.colMorphometricEditActionDataGridViewLinkColumn.HeaderText = ""
        Me.colMorphometricEditActionDataGridViewLinkColumn.Name = "colMorphometricEditActionDataGridViewLinkColumn"
        Me.colMorphometricEditActionDataGridViewLinkColumn.ReadOnly = True
        Me.colMorphometricEditActionDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colMorphometricEditActionDataGridViewLinkColumn.TrackVisitedState = False
        Me.colMorphometricEditActionDataGridViewLinkColumn.Width = 28
        '
        'colMorphometricDeleteActionDataGridViewLinkColumn
        '
        Me.colMorphometricDeleteActionDataGridViewLinkColumn.DataPropertyName = "DeleteAction"
        Me.colMorphometricDeleteActionDataGridViewLinkColumn.Frozen = True
        Me.colMorphometricDeleteActionDataGridViewLinkColumn.HeaderText = ""
        Me.colMorphometricDeleteActionDataGridViewLinkColumn.Name = "colMorphometricDeleteActionDataGridViewLinkColumn"
        Me.colMorphometricDeleteActionDataGridViewLinkColumn.ReadOnly = True
        Me.colMorphometricDeleteActionDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colMorphometricDeleteActionDataGridViewLinkColumn.TrackVisitedState = False
        Me.colMorphometricDeleteActionDataGridViewLinkColumn.Width = 40
        '
        'colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn
        '
        Me.colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn.DataPropertyName = "TurtleMorphometricID"
        Me.colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn.Frozen = True
        Me.colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn.HeaderText = "TurtleMorphometricID"
        Me.colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn.Name = "colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn"
        Me.colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn.Visible = False
        Me.colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn.Width = 5
        '
        'colMorphometricSclNotchNotchValueDataGridViewTextBoxColumn
        '
        Me.colMorphometricSclNotchNotchValueDataGridViewTextBoxColumn.DataPropertyName = "SclNotchNotchValueString"
        Me.colMorphometricSclNotchNotchValueDataGridViewTextBoxColumn.HeaderText = "SCL notch-notch"
        Me.colMorphometricSclNotchNotchValueDataGridViewTextBoxColumn.Name = "colMorphometricSclNotchNotchValueDataGridViewTextBoxColumn"
        Me.colMorphometricSclNotchNotchValueDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricSclNotchNotchValueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMorphometricSclNotchNotchValueDataGridViewTextBoxColumn.Width = 70
        '
        'colMorphometricSclNotchNotchUnitsDataGridViewTextBoxColumn
        '
        Me.colMorphometricSclNotchNotchUnitsDataGridViewTextBoxColumn.DataPropertyName = "SclNotchNotchUnits"
        Me.colMorphometricSclNotchNotchUnitsDataGridViewTextBoxColumn.HeaderText = "SclNotchNotchUnits"
        Me.colMorphometricSclNotchNotchUnitsDataGridViewTextBoxColumn.Name = "colMorphometricSclNotchNotchUnitsDataGridViewTextBoxColumn"
        Me.colMorphometricSclNotchNotchUnitsDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricSclNotchNotchUnitsDataGridViewTextBoxColumn.Visible = False
        '
        'colMorphometricSclNotchTipValueDataGridViewTextBoxColumn
        '
        Me.colMorphometricSclNotchTipValueDataGridViewTextBoxColumn.DataPropertyName = "SclNotchTipValueString"
        Me.colMorphometricSclNotchTipValueDataGridViewTextBoxColumn.HeaderText = "SCL notch-tip"
        Me.colMorphometricSclNotchTipValueDataGridViewTextBoxColumn.Name = "colMorphometricSclNotchTipValueDataGridViewTextBoxColumn"
        Me.colMorphometricSclNotchTipValueDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricSclNotchTipValueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMorphometricSclNotchTipValueDataGridViewTextBoxColumn.Width = 60
        '
        'colMorphometricSclNotchTipUnitsDataGridViewTextBoxColumn
        '
        Me.colMorphometricSclNotchTipUnitsDataGridViewTextBoxColumn.DataPropertyName = "SclNotchTipUnits"
        Me.colMorphometricSclNotchTipUnitsDataGridViewTextBoxColumn.HeaderText = "SclNotchTipUnits"
        Me.colMorphometricSclNotchTipUnitsDataGridViewTextBoxColumn.Name = "colMorphometricSclNotchTipUnitsDataGridViewTextBoxColumn"
        Me.colMorphometricSclNotchTipUnitsDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricSclNotchTipUnitsDataGridViewTextBoxColumn.Visible = False
        '
        'colMorphometricSclTipTipValueDataGridViewTextBoxColumn
        '
        Me.colMorphometricSclTipTipValueDataGridViewTextBoxColumn.DataPropertyName = "SclTipTipValueString"
        Me.colMorphometricSclTipTipValueDataGridViewTextBoxColumn.HeaderText = "SCL tip-tip"
        Me.colMorphometricSclTipTipValueDataGridViewTextBoxColumn.Name = "colMorphometricSclTipTipValueDataGridViewTextBoxColumn"
        Me.colMorphometricSclTipTipValueDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricSclTipTipValueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMorphometricSclTipTipValueDataGridViewTextBoxColumn.Width = 55
        '
        'colMorphometricSclTipTipUnitsDataGridViewTextBoxColumn
        '
        Me.colMorphometricSclTipTipUnitsDataGridViewTextBoxColumn.DataPropertyName = "SclTipTipUnits"
        Me.colMorphometricSclTipTipUnitsDataGridViewTextBoxColumn.HeaderText = "SclTipTipUnits"
        Me.colMorphometricSclTipTipUnitsDataGridViewTextBoxColumn.Name = "colMorphometricSclTipTipUnitsDataGridViewTextBoxColumn"
        Me.colMorphometricSclTipTipUnitsDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricSclTipTipUnitsDataGridViewTextBoxColumn.Visible = False
        '
        'colMorphometricScwValueDataGridViewTextBoxColumn
        '
        Me.colMorphometricScwValueDataGridViewTextBoxColumn.DataPropertyName = "ScwValueString"
        Me.colMorphometricScwValueDataGridViewTextBoxColumn.HeaderText = "SCW"
        Me.colMorphometricScwValueDataGridViewTextBoxColumn.Name = "colMorphometricScwValueDataGridViewTextBoxColumn"
        Me.colMorphometricScwValueDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricScwValueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMorphometricScwValueDataGridViewTextBoxColumn.Width = 45
        '
        'colMorphometricScwUnitsDataGridViewTextBoxColumn
        '
        Me.colMorphometricScwUnitsDataGridViewTextBoxColumn.DataPropertyName = "ScwUnits"
        Me.colMorphometricScwUnitsDataGridViewTextBoxColumn.HeaderText = "ScwUnits"
        Me.colMorphometricScwUnitsDataGridViewTextBoxColumn.Name = "colMorphometricScwUnitsDataGridViewTextBoxColumn"
        Me.colMorphometricScwUnitsDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricScwUnitsDataGridViewTextBoxColumn.Visible = False
        '
        'colMorphometricCclNotchNotchValueDataGridViewTextBoxColumn
        '
        Me.colMorphometricCclNotchNotchValueDataGridViewTextBoxColumn.DataPropertyName = "CclNotchNotchValueString"
        Me.colMorphometricCclNotchNotchValueDataGridViewTextBoxColumn.HeaderText = "CCL notch-notch"
        Me.colMorphometricCclNotchNotchValueDataGridViewTextBoxColumn.Name = "colMorphometricCclNotchNotchValueDataGridViewTextBoxColumn"
        Me.colMorphometricCclNotchNotchValueDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricCclNotchNotchValueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMorphometricCclNotchNotchValueDataGridViewTextBoxColumn.Width = 70
        '
        'colMorphometricCclNotchNotchUnitsDataGridViewTextBoxColumn
        '
        Me.colMorphometricCclNotchNotchUnitsDataGridViewTextBoxColumn.DataPropertyName = "CclNotchNotchUnits"
        Me.colMorphometricCclNotchNotchUnitsDataGridViewTextBoxColumn.HeaderText = "CclNotchNotchUnits"
        Me.colMorphometricCclNotchNotchUnitsDataGridViewTextBoxColumn.Name = "colMorphometricCclNotchNotchUnitsDataGridViewTextBoxColumn"
        Me.colMorphometricCclNotchNotchUnitsDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricCclNotchNotchUnitsDataGridViewTextBoxColumn.Visible = False
        '
        'colMorphometricCclNotchTipValueDataGridViewTextBoxColumn
        '
        Me.colMorphometricCclNotchTipValueDataGridViewTextBoxColumn.DataPropertyName = "CclNotchTipValueString"
        Me.colMorphometricCclNotchTipValueDataGridViewTextBoxColumn.HeaderText = "CCL notch-tip"
        Me.colMorphometricCclNotchTipValueDataGridViewTextBoxColumn.Name = "colMorphometricCclNotchTipValueDataGridViewTextBoxColumn"
        Me.colMorphometricCclNotchTipValueDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricCclNotchTipValueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMorphometricCclNotchTipValueDataGridViewTextBoxColumn.Width = 60
        '
        'colMorphometricCclNotchTipUnitsDataGridViewTextBoxColumn
        '
        Me.colMorphometricCclNotchTipUnitsDataGridViewTextBoxColumn.DataPropertyName = "CclNotchTipUnits"
        Me.colMorphometricCclNotchTipUnitsDataGridViewTextBoxColumn.HeaderText = "CclNotchTipUnits"
        Me.colMorphometricCclNotchTipUnitsDataGridViewTextBoxColumn.Name = "colMorphometricCclNotchTipUnitsDataGridViewTextBoxColumn"
        Me.colMorphometricCclNotchTipUnitsDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricCclNotchTipUnitsDataGridViewTextBoxColumn.Visible = False
        '
        'colMorphometricCclTipTipValueDataGridViewTextBoxColumn
        '
        Me.colMorphometricCclTipTipValueDataGridViewTextBoxColumn.DataPropertyName = "CclTipTipValueString"
        Me.colMorphometricCclTipTipValueDataGridViewTextBoxColumn.HeaderText = "CCL tip-tip"
        Me.colMorphometricCclTipTipValueDataGridViewTextBoxColumn.Name = "colMorphometricCclTipTipValueDataGridViewTextBoxColumn"
        Me.colMorphometricCclTipTipValueDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricCclTipTipValueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMorphometricCclTipTipValueDataGridViewTextBoxColumn.Width = 55
        '
        'colMorphometricCclTipTipUnitsDataGridViewTextBoxColumn
        '
        Me.colMorphometricCclTipTipUnitsDataGridViewTextBoxColumn.DataPropertyName = "CclTipTipUnits"
        Me.colMorphometricCclTipTipUnitsDataGridViewTextBoxColumn.HeaderText = "CclTipTipUnits"
        Me.colMorphometricCclTipTipUnitsDataGridViewTextBoxColumn.Name = "colMorphometricCclTipTipUnitsDataGridViewTextBoxColumn"
        Me.colMorphometricCclTipTipUnitsDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricCclTipTipUnitsDataGridViewTextBoxColumn.Visible = False
        '
        'colMorphometricCcwValueDataGridViewTextBoxColumn
        '
        Me.colMorphometricCcwValueDataGridViewTextBoxColumn.DataPropertyName = "CcwValueString"
        Me.colMorphometricCcwValueDataGridViewTextBoxColumn.HeaderText = "CCW"
        Me.colMorphometricCcwValueDataGridViewTextBoxColumn.Name = "colMorphometricCcwValueDataGridViewTextBoxColumn"
        Me.colMorphometricCcwValueDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricCcwValueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMorphometricCcwValueDataGridViewTextBoxColumn.Width = 45
        '
        'colMorphometricCcwUnitsDataGridViewTextBoxColumn
        '
        Me.colMorphometricCcwUnitsDataGridViewTextBoxColumn.DataPropertyName = "CcwUnits"
        Me.colMorphometricCcwUnitsDataGridViewTextBoxColumn.HeaderText = "CcwUnits"
        Me.colMorphometricCcwUnitsDataGridViewTextBoxColumn.Name = "colMorphometricCcwUnitsDataGridViewTextBoxColumn"
        Me.colMorphometricCcwUnitsDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricCcwUnitsDataGridViewTextBoxColumn.Visible = False
        '
        'colMorphometricWeightValueDataGridViewTextBoxColumn
        '
        Me.colMorphometricWeightValueDataGridViewTextBoxColumn.DataPropertyName = "WeightValueString"
        Me.colMorphometricWeightValueDataGridViewTextBoxColumn.HeaderText = "Weight"
        Me.colMorphometricWeightValueDataGridViewTextBoxColumn.Name = "colMorphometricWeightValueDataGridViewTextBoxColumn"
        Me.colMorphometricWeightValueDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricWeightValueDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        Me.colMorphometricWeightValueDataGridViewTextBoxColumn.Width = 50
        '
        'colMorphometricWeightUnitsDataGridViewTextBoxColumn
        '
        Me.colMorphometricWeightUnitsDataGridViewTextBoxColumn.DataPropertyName = "WeightUnits"
        Me.colMorphometricWeightUnitsDataGridViewTextBoxColumn.HeaderText = "WeightUnits"
        Me.colMorphometricWeightUnitsDataGridViewTextBoxColumn.Name = "colMorphometricWeightUnitsDataGridViewTextBoxColumn"
        Me.colMorphometricWeightUnitsDataGridViewTextBoxColumn.ReadOnly = True
        Me.colMorphometricWeightUnitsDataGridViewTextBoxColumn.Visible = False
        '
        'TurtleMorphometricGridBindingSource
        '
        Me.TurtleMorphometricGridBindingSource.DataSource = GetType(TurtleGeek.Roster.TurtleMorphometrics)
        '
        'btnAddMorphometric
        '
        Me.btnAddMorphometric.BackColor = System.Drawing.Color.MintCream
        Me.btnAddMorphometric.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnAddMorphometric.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAddMorphometric.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAddMorphometric.ForeColor = System.Drawing.Color.Blue
        Me.btnAddMorphometric.Location = New System.Drawing.Point(0, 0)
        Me.btnAddMorphometric.Name = "btnAddMorphometric"
        Me.btnAddMorphometric.Size = New System.Drawing.Size(37, 20)
        Me.btnAddMorphometric.TabIndex = 0
        Me.btnAddMorphometric.Text = "add"
        Me.btnAddMorphometric.UseVisualStyleBackColor = False
        '
        'tpgGraphs
        '
        Me.tpgGraphs.Controls.Add(Me.lnkCopyToClipboardMorphometricsGraph)
        Me.tpgGraphs.Controls.Add(Me.lnkPrintMorphometricsGraph)
        Me.tpgGraphs.Controls.Add(Me.pnlGraphChoices)
        Me.tpgGraphs.Controls.Add(Me.graphMorphometrics)
        Me.tpgGraphs.Location = New System.Drawing.Point(4, 4)
        Me.tpgGraphs.Name = "tpgGraphs"
        Me.tpgGraphs.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgGraphs.Size = New System.Drawing.Size(679, 338)
        Me.tpgGraphs.TabIndex = 1
        Me.tpgGraphs.Text = "Graphs"
        Me.tpgGraphs.UseVisualStyleBackColor = True
        '
        'lnkCopyToClipboardMorphometricsGraph
        '
        Me.lnkCopyToClipboardMorphometricsGraph.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkCopyToClipboardMorphometricsGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkCopyToClipboardMorphometricsGraph.AutoSize = True
        Me.lnkCopyToClipboardMorphometricsGraph.Location = New System.Drawing.Point(560, 260)
        Me.lnkCopyToClipboardMorphometricsGraph.Name = "lnkCopyToClipboardMorphometricsGraph"
        Me.lnkCopyToClipboardMorphometricsGraph.Size = New System.Drawing.Size(88, 13)
        Me.lnkCopyToClipboardMorphometricsGraph.TabIndex = 1
        Me.lnkCopyToClipboardMorphometricsGraph.TabStop = True
        Me.lnkCopyToClipboardMorphometricsGraph.Text = "copy to clipboard"
        Me.lnkCopyToClipboardMorphometricsGraph.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lnkPrintMorphometricsGraph
        '
        Me.lnkPrintMorphometricsGraph.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkPrintMorphometricsGraph.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkPrintMorphometricsGraph.AutoSize = True
        Me.lnkPrintMorphometricsGraph.Location = New System.Drawing.Point(652, 260)
        Me.lnkPrintMorphometricsGraph.Name = "lnkPrintMorphometricsGraph"
        Me.lnkPrintMorphometricsGraph.Size = New System.Drawing.Size(27, 13)
        Me.lnkPrintMorphometricsGraph.TabIndex = 2
        Me.lnkPrintMorphometricsGraph.TabStop = True
        Me.lnkPrintMorphometricsGraph.Text = "print"
        Me.lnkPrintMorphometricsGraph.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'pnlGraphChoices
        '
        Me.pnlGraphChoices.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pnlGraphChoices.BackColor = System.Drawing.Color.White
        Me.pnlGraphChoices.Controls.Add(Me.chkGraphWeight)
        Me.pnlGraphChoices.Controls.Add(Me.chkGraphCcw)
        Me.pnlGraphChoices.Controls.Add(Me.chkGraphCclNotchNotch)
        Me.pnlGraphChoices.Controls.Add(Me.chkGraphCclTipTip)
        Me.pnlGraphChoices.Controls.Add(Me.chkGraphCclNotchTip)
        Me.pnlGraphChoices.Controls.Add(Me.chkGraphScw)
        Me.pnlGraphChoices.Controls.Add(Me.chkGraphSclNotchNotch)
        Me.pnlGraphChoices.Controls.Add(Me.chkGraphSclTipTip)
        Me.pnlGraphChoices.Controls.Add(Me.chkGraphSclNotchTip)
        Me.pnlGraphChoices.Location = New System.Drawing.Point(0, 279)
        Me.pnlGraphChoices.Name = "pnlGraphChoices"
        Me.pnlGraphChoices.Size = New System.Drawing.Size(679, 59)
        Me.pnlGraphChoices.TabIndex = 3
        '
        'chkGraphWeight
        '
        Me.chkGraphWeight.AutoSize = True
        Me.chkGraphWeight.Checked = True
        Me.chkGraphWeight.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGraphWeight.ForeColor = System.Drawing.Color.Violet
        Me.chkGraphWeight.Location = New System.Drawing.Point(440, 3)
        Me.chkGraphWeight.Name = "chkGraphWeight"
        Me.chkGraphWeight.Size = New System.Drawing.Size(60, 17)
        Me.chkGraphWeight.TabIndex = 8
        Me.chkGraphWeight.Text = "Weight"
        Me.chkGraphWeight.UseVisualStyleBackColor = True
        '
        'chkGraphCcw
        '
        Me.chkGraphCcw.AutoSize = True
        Me.chkGraphCcw.Checked = True
        Me.chkGraphCcw.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGraphCcw.ForeColor = System.Drawing.Color.MediumTurquoise
        Me.chkGraphCcw.Location = New System.Drawing.Point(366, 3)
        Me.chkGraphCcw.Name = "chkGraphCcw"
        Me.chkGraphCcw.Size = New System.Drawing.Size(51, 17)
        Me.chkGraphCcw.TabIndex = 7
        Me.chkGraphCcw.Text = "CCW"
        Me.chkGraphCcw.UseVisualStyleBackColor = True
        '
        'chkGraphCclNotchNotch
        '
        Me.chkGraphCclNotchNotch.AutoSize = True
        Me.chkGraphCclNotchNotch.Checked = True
        Me.chkGraphCclNotchNotch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGraphCclNotchNotch.ForeColor = System.Drawing.Color.LightGreen
        Me.chkGraphCclNotchNotch.Location = New System.Drawing.Point(231, 3)
        Me.chkGraphCclNotchNotch.Name = "chkGraphCclNotchNotch"
        Me.chkGraphCclNotchNotch.Size = New System.Drawing.Size(106, 17)
        Me.chkGraphCclNotchNotch.TabIndex = 4
        Me.chkGraphCclNotchNotch.Text = "CCL notch-notch"
        Me.chkGraphCclNotchNotch.UseVisualStyleBackColor = True
        '
        'chkGraphCclTipTip
        '
        Me.chkGraphCclTipTip.AutoSize = True
        Me.chkGraphCclTipTip.Checked = True
        Me.chkGraphCclTipTip.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGraphCclTipTip.ForeColor = System.Drawing.Color.DarkGreen
        Me.chkGraphCclTipTip.Location = New System.Drawing.Point(231, 39)
        Me.chkGraphCclTipTip.Name = "chkGraphCclTipTip"
        Me.chkGraphCclTipTip.Size = New System.Drawing.Size(74, 17)
        Me.chkGraphCclTipTip.TabIndex = 6
        Me.chkGraphCclTipTip.Text = "CCL tip-tip"
        Me.chkGraphCclTipTip.UseVisualStyleBackColor = True
        '
        'chkGraphCclNotchTip
        '
        Me.chkGraphCclNotchTip.AutoSize = True
        Me.chkGraphCclNotchTip.Checked = True
        Me.chkGraphCclNotchTip.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGraphCclNotchTip.ForeColor = System.Drawing.Color.LimeGreen
        Me.chkGraphCclNotchTip.Location = New System.Drawing.Point(231, 21)
        Me.chkGraphCclNotchTip.Name = "chkGraphCclNotchTip"
        Me.chkGraphCclNotchTip.Size = New System.Drawing.Size(90, 17)
        Me.chkGraphCclNotchTip.TabIndex = 5
        Me.chkGraphCclNotchTip.Text = "CCL notch-tip"
        Me.chkGraphCclNotchTip.UseVisualStyleBackColor = True
        '
        'chkGraphScw
        '
        Me.chkGraphScw.AutoSize = True
        Me.chkGraphScw.Checked = True
        Me.chkGraphScw.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGraphScw.ForeColor = System.Drawing.Color.DarkOrange
        Me.chkGraphScw.Location = New System.Drawing.Point(145, 3)
        Me.chkGraphScw.Name = "chkGraphScw"
        Me.chkGraphScw.Size = New System.Drawing.Size(51, 17)
        Me.chkGraphScw.TabIndex = 3
        Me.chkGraphScw.Text = "SCW"
        Me.chkGraphScw.UseVisualStyleBackColor = True
        '
        'chkGraphSclNotchNotch
        '
        Me.chkGraphSclNotchNotch.AutoSize = True
        Me.chkGraphSclNotchNotch.Checked = True
        Me.chkGraphSclNotchNotch.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGraphSclNotchNotch.ForeColor = System.Drawing.Color.LightCoral
        Me.chkGraphSclNotchNotch.Location = New System.Drawing.Point(9, 3)
        Me.chkGraphSclNotchNotch.Name = "chkGraphSclNotchNotch"
        Me.chkGraphSclNotchNotch.Size = New System.Drawing.Size(106, 17)
        Me.chkGraphSclNotchNotch.TabIndex = 0
        Me.chkGraphSclNotchNotch.Text = "SCL notch-notch"
        Me.chkGraphSclNotchNotch.UseVisualStyleBackColor = True
        '
        'chkGraphSclTipTip
        '
        Me.chkGraphSclTipTip.AutoSize = True
        Me.chkGraphSclTipTip.Checked = True
        Me.chkGraphSclTipTip.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGraphSclTipTip.ForeColor = System.Drawing.Color.DarkRed
        Me.chkGraphSclTipTip.Location = New System.Drawing.Point(9, 39)
        Me.chkGraphSclTipTip.Name = "chkGraphSclTipTip"
        Me.chkGraphSclTipTip.Size = New System.Drawing.Size(74, 17)
        Me.chkGraphSclTipTip.TabIndex = 2
        Me.chkGraphSclTipTip.Text = "SCL tip-tip"
        Me.chkGraphSclTipTip.UseVisualStyleBackColor = True
        '
        'chkGraphSclNotchTip
        '
        Me.chkGraphSclNotchTip.AutoSize = True
        Me.chkGraphSclNotchTip.Checked = True
        Me.chkGraphSclNotchTip.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkGraphSclNotchTip.ForeColor = System.Drawing.Color.Red
        Me.chkGraphSclNotchTip.Location = New System.Drawing.Point(9, 21)
        Me.chkGraphSclNotchTip.Name = "chkGraphSclNotchTip"
        Me.chkGraphSclNotchTip.Size = New System.Drawing.Size(90, 17)
        Me.chkGraphSclNotchTip.TabIndex = 1
        Me.chkGraphSclNotchTip.Text = "SCL notch-tip"
        Me.chkGraphSclNotchTip.UseVisualStyleBackColor = True
        '
        'graphMorphometrics
        '
        Me.graphMorphometrics.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.graphMorphometrics.AutoScaleAutoGeneratedAxes = False
        Me.graphMorphometrics.AutoScaleTitle = False
        Me.graphMorphometrics.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.graphMorphometrics.DateTimeToolTip = False
        Me.graphMorphometrics.Legend = Nothing
        Me.graphMorphometrics.LegendZOrder = -1
        Me.graphMorphometrics.Location = New System.Drawing.Point(0, 0)
        Me.graphMorphometrics.Name = "graphMorphometrics"
        Me.graphMorphometrics.RightMenu = Nothing
        Me.graphMorphometrics.ShowCoordinates = False
        Me.graphMorphometrics.Size = New System.Drawing.Size(679, 273)
        Me.graphMorphometrics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.None
        Me.graphMorphometrics.TabIndex = 0
        Me.graphMorphometrics.Text = "PlotSurface2D1"
        Me.graphMorphometrics.Title = ""
        Me.graphMorphometrics.TitleFont = New System.Drawing.Font("Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.graphMorphometrics.XAxis1 = Nothing
        Me.graphMorphometrics.XAxis2 = Nothing
        Me.graphMorphometrics.YAxis1 = Nothing
        Me.graphMorphometrics.YAxis2 = Nothing
        '
        'tpgTurtleTabAttachments
        '
        Me.tpgTurtleTabAttachments.Controls.Add(Me.lnkUseImageInBrochure)
        Me.tpgTurtleTabAttachments.Controls.Add(Me.picAttachmentPreview)
        Me.tpgTurtleTabAttachments.Controls.Add(Me.btnAddTurtleFileAttachment)
        Me.tpgTurtleTabAttachments.Controls.Add(Me.btnDeleteAllTurtleFileAttachments)
        Me.tpgTurtleTabAttachments.Controls.Add(Me.lblPicturePreview)
        Me.tpgTurtleTabAttachments.Controls.Add(Me.grdTurtleFileAttachmentList)
        Me.tpgTurtleTabAttachments.Location = New System.Drawing.Point(4, 22)
        Me.tpgTurtleTabAttachments.Name = "tpgTurtleTabAttachments"
        Me.tpgTurtleTabAttachments.Size = New System.Drawing.Size(698, 370)
        Me.tpgTurtleTabAttachments.TabIndex = 3
        Me.tpgTurtleTabAttachments.Text = "Attachments"
        Me.tpgTurtleTabAttachments.UseVisualStyleBackColor = True
        '
        'lnkUseImageInBrochure
        '
        Me.lnkUseImageInBrochure.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkUseImageInBrochure.AutoSize = True
        Me.lnkUseImageInBrochure.Location = New System.Drawing.Point(479, 214)
        Me.lnkUseImageInBrochure.Name = "lnkUseImageInBrochure"
        Me.lnkUseImageInBrochure.Size = New System.Drawing.Size(211, 13)
        Me.lnkUseImageInBrochure.TabIndex = 5
        Me.lnkUseImageInBrochure.TabStop = True
        Me.lnkUseImageInBrochure.Text = "(click here to use above image in brochure)"
        '
        'picAttachmentPreview
        '
        Me.picAttachmentPreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.picAttachmentPreview.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.picAttachmentPreview.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picAttachmentPreview.Location = New System.Drawing.Point(477, 15)
        Me.picAttachmentPreview.Name = "picAttachmentPreview"
        Me.picAttachmentPreview.Size = New System.Drawing.Size(214, 178)
        Me.picAttachmentPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAttachmentPreview.TabIndex = 5
        Me.picAttachmentPreview.TabStop = False
        '
        'btnAddTurtleFileAttachment
        '
        Me.btnAddTurtleFileAttachment.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnAddTurtleFileAttachment.BackColor = System.Drawing.SystemColors.Control
        Me.btnAddTurtleFileAttachment.Location = New System.Drawing.Point(12, 344)
        Me.btnAddTurtleFileAttachment.Name = "btnAddTurtleFileAttachment"
        Me.btnAddTurtleFileAttachment.Size = New System.Drawing.Size(164, 23)
        Me.btnAddTurtleFileAttachment.TabIndex = 2
        Me.btnAddTurtleFileAttachment.Text = "Add Attac&hment..."
        Me.btnAddTurtleFileAttachment.UseVisualStyleBackColor = False
        '
        'btnDeleteAllTurtleFileAttachments
        '
        Me.btnDeleteAllTurtleFileAttachments.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnDeleteAllTurtleFileAttachments.BackColor = System.Drawing.SystemColors.Control
        Me.btnDeleteAllTurtleFileAttachments.Location = New System.Drawing.Point(182, 344)
        Me.btnDeleteAllTurtleFileAttachments.Name = "btnDeleteAllTurtleFileAttachments"
        Me.btnDeleteAllTurtleFileAttachments.Size = New System.Drawing.Size(164, 23)
        Me.btnDeleteAllTurtleFileAttachments.TabIndex = 3
        Me.btnDeleteAllTurtleFileAttachments.Text = "&Delete All Attachments"
        Me.btnDeleteAllTurtleFileAttachments.UseVisualStyleBackColor = False
        '
        'lblPicturePreview
        '
        Me.lblPicturePreview.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblPicturePreview.AutoSize = True
        Me.lblPicturePreview.Location = New System.Drawing.Point(487, 199)
        Me.lblPicturePreview.Name = "lblPicturePreview"
        Me.lblPicturePreview.Size = New System.Drawing.Size(192, 13)
        Me.lblPicturePreview.TabIndex = 4
        Me.lblPicturePreview.Text = "Preview (image files only -- .jpg or .bmp)"
        '
        'grdTurtleFileAttachmentList
        '
        Me.grdTurtleFileAttachmentList.AllowDrop = True
        DataGridViewCellStyle20.BackColor = System.Drawing.Color.LightYellow
        Me.grdTurtleFileAttachmentList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle20
        Me.grdTurtleFileAttachmentList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdTurtleFileAttachmentList.AutoGenerateColumns = False
        Me.grdTurtleFileAttachmentList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdTurtleFileAttachmentList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colTurtleFileAttachmentEditActionDataGridViewLinkColumn, Me.colTurtleFileAttachmentDeleteActionDataGridViewLinkColumn, Me.colTurtleFileAttachmentCopyToActionDataGridViewLinkColumn, Me.colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn, Me.colTurtleFileAttachmentIdDataGridViewTextBoxColumn, Me.colTurtleFileAttachmentBaseFileNameDataGridViewTextBoxColumn, Me.colTurtleFileAttachmentDateCreatedDataGridViewTextBoxColumn})
        Me.grdTurtleFileAttachmentList.DataSource = Me.TurtleAttachmentGridBindingSource
        DataGridViewCellStyle21.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle21.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle21.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle21.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle21.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle21.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.grdTurtleFileAttachmentList.DefaultCellStyle = DataGridViewCellStyle21
        Me.grdTurtleFileAttachmentList.Location = New System.Drawing.Point(12, 15)
        Me.grdTurtleFileAttachmentList.MultiSelect = False
        Me.grdTurtleFileAttachmentList.Name = "grdTurtleFileAttachmentList"
        Me.grdTurtleFileAttachmentList.ReadOnly = True
        Me.grdTurtleFileAttachmentList.RowHeadersVisible = False
        Me.grdTurtleFileAttachmentList.RowHeadersWidth = 20
        Me.grdTurtleFileAttachmentList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdTurtleFileAttachmentList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdTurtleFileAttachmentList.Size = New System.Drawing.Size(454, 323)
        Me.grdTurtleFileAttachmentList.TabIndex = 0
        '
        'colTurtleFileAttachmentEditActionDataGridViewLinkColumn
        '
        Me.colTurtleFileAttachmentEditActionDataGridViewLinkColumn.DataPropertyName = "EditAction"
        Me.colTurtleFileAttachmentEditActionDataGridViewLinkColumn.Frozen = True
        Me.colTurtleFileAttachmentEditActionDataGridViewLinkColumn.HeaderText = ""
        Me.colTurtleFileAttachmentEditActionDataGridViewLinkColumn.Name = "colTurtleFileAttachmentEditActionDataGridViewLinkColumn"
        Me.colTurtleFileAttachmentEditActionDataGridViewLinkColumn.ReadOnly = True
        Me.colTurtleFileAttachmentEditActionDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTurtleFileAttachmentEditActionDataGridViewLinkColumn.TrackVisitedState = False
        Me.colTurtleFileAttachmentEditActionDataGridViewLinkColumn.Width = 32
        '
        'colTurtleFileAttachmentDeleteActionDataGridViewLinkColumn
        '
        Me.colTurtleFileAttachmentDeleteActionDataGridViewLinkColumn.DataPropertyName = "DeleteAction"
        Me.colTurtleFileAttachmentDeleteActionDataGridViewLinkColumn.Frozen = True
        Me.colTurtleFileAttachmentDeleteActionDataGridViewLinkColumn.HeaderText = ""
        Me.colTurtleFileAttachmentDeleteActionDataGridViewLinkColumn.Name = "colTurtleFileAttachmentDeleteActionDataGridViewLinkColumn"
        Me.colTurtleFileAttachmentDeleteActionDataGridViewLinkColumn.ReadOnly = True
        Me.colTurtleFileAttachmentDeleteActionDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTurtleFileAttachmentDeleteActionDataGridViewLinkColumn.TrackVisitedState = False
        Me.colTurtleFileAttachmentDeleteActionDataGridViewLinkColumn.Width = 40
        '
        'colTurtleFileAttachmentCopyToActionDataGridViewLinkColumn
        '
        Me.colTurtleFileAttachmentCopyToActionDataGridViewLinkColumn.DataPropertyName = "CopyToAction"
        Me.colTurtleFileAttachmentCopyToActionDataGridViewLinkColumn.Frozen = True
        Me.colTurtleFileAttachmentCopyToActionDataGridViewLinkColumn.HeaderText = ""
        Me.colTurtleFileAttachmentCopyToActionDataGridViewLinkColumn.Name = "colTurtleFileAttachmentCopyToActionDataGridViewLinkColumn"
        Me.colTurtleFileAttachmentCopyToActionDataGridViewLinkColumn.ReadOnly = True
        Me.colTurtleFileAttachmentCopyToActionDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colTurtleFileAttachmentCopyToActionDataGridViewLinkColumn.TrackVisitedState = False
        Me.colTurtleFileAttachmentCopyToActionDataGridViewLinkColumn.Width = 47
        '
        'colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn
        '
        Me.colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn.DataPropertyName = "FullFileName"
        Me.colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn.Frozen = True
        Me.colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn.HeaderText = "FullFileName"
        Me.colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn.Name = "colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn"
        Me.colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn.Visible = False
        '
        'colTurtleFileAttachmentIdDataGridViewTextBoxColumn
        '
        Me.colTurtleFileAttachmentIdDataGridViewTextBoxColumn.DataPropertyName = "TurtleFileAttachmentId"
        Me.colTurtleFileAttachmentIdDataGridViewTextBoxColumn.Frozen = True
        Me.colTurtleFileAttachmentIdDataGridViewTextBoxColumn.HeaderText = "TurtleFileAttachmentId"
        Me.colTurtleFileAttachmentIdDataGridViewTextBoxColumn.Name = "colTurtleFileAttachmentIdDataGridViewTextBoxColumn"
        Me.colTurtleFileAttachmentIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleFileAttachmentIdDataGridViewTextBoxColumn.Visible = False
        '
        'colTurtleFileAttachmentBaseFileNameDataGridViewTextBoxColumn
        '
        Me.colTurtleFileAttachmentBaseFileNameDataGridViewTextBoxColumn.DataPropertyName = "BaseFileName"
        Me.colTurtleFileAttachmentBaseFileNameDataGridViewTextBoxColumn.HeaderText = "File Name"
        Me.colTurtleFileAttachmentBaseFileNameDataGridViewTextBoxColumn.Name = "colTurtleFileAttachmentBaseFileNameDataGridViewTextBoxColumn"
        Me.colTurtleFileAttachmentBaseFileNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleFileAttachmentBaseFileNameDataGridViewTextBoxColumn.Width = 178
        '
        'colTurtleFileAttachmentDateCreatedDataGridViewTextBoxColumn
        '
        Me.colTurtleFileAttachmentDateCreatedDataGridViewTextBoxColumn.DataPropertyName = "DateCreated"
        Me.colTurtleFileAttachmentDateCreatedDataGridViewTextBoxColumn.HeaderText = "Date Added"
        Me.colTurtleFileAttachmentDateCreatedDataGridViewTextBoxColumn.Name = "colTurtleFileAttachmentDateCreatedDataGridViewTextBoxColumn"
        Me.colTurtleFileAttachmentDateCreatedDataGridViewTextBoxColumn.ReadOnly = True
        Me.colTurtleFileAttachmentDateCreatedDataGridViewTextBoxColumn.Width = 132
        '
        'TurtleAttachmentGridBindingSource
        '
        Me.TurtleAttachmentGridBindingSource.AllowNew = False
        Me.TurtleAttachmentGridBindingSource.DataSource = GetType(TurtleGeek.Roster.TurtleFileAttachments)
        '
        'tpgTurtleTabBrochure
        '
        Me.tpgTurtleTabBrochure.Controls.Add(Me.GroupBox1)
        Me.tpgTurtleTabBrochure.Controls.Add(Me.lnkBrochureClearImage)
        Me.tpgTurtleTabBrochure.Controls.Add(Me.btnPrintBrochure)
        Me.tpgTurtleTabBrochure.Controls.Add(Me.lblBrochureImage)
        Me.tpgTurtleTabBrochure.Controls.Add(Me.picBrochureImage)
        Me.tpgTurtleTabBrochure.Controls.Add(Me.txtBrochureComments)
        Me.tpgTurtleTabBrochure.Controls.Add(Me.lblBrochureComments)
        Me.tpgTurtleTabBrochure.Location = New System.Drawing.Point(4, 22)
        Me.tpgTurtleTabBrochure.Name = "tpgTurtleTabBrochure"
        Me.tpgTurtleTabBrochure.Size = New System.Drawing.Size(698, 370)
        Me.tpgTurtleTabBrochure.TabIndex = 4
        Me.tpgTurtleTabBrochure.Text = "Brochure"
        Me.tpgTurtleTabBrochure.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.picBrochureBackgroundColorOrange)
        Me.GroupBox1.Controls.Add(Me.radBrochureBackgroundColorOrange)
        Me.GroupBox1.Controls.Add(Me.picBrochureBackgroundColorLightGray)
        Me.GroupBox1.Controls.Add(Me.radBrochureBackgroundColorLightGray)
        Me.GroupBox1.Controls.Add(Me.picBrochureBackgroundColorLavender)
        Me.GroupBox1.Controls.Add(Me.radBrochureBackgroundColorLavender)
        Me.GroupBox1.Controls.Add(Me.picBrochureBackgroundColorLightCyan)
        Me.GroupBox1.Controls.Add(Me.radBrochureBackgroundColorLightCyan)
        Me.GroupBox1.Controls.Add(Me.picBrochureBackgroundColorPaleGreen)
        Me.GroupBox1.Controls.Add(Me.radBrochureBackgroundColorPaleGreen)
        Me.GroupBox1.Controls.Add(Me.picBrochureBackgroundColorLightYellow)
        Me.GroupBox1.Controls.Add(Me.radBrochureBackgroundColorLightYellow)
        Me.GroupBox1.Controls.Add(Me.picBrochureBackgroundColorTan)
        Me.GroupBox1.Controls.Add(Me.radBrochureBackgroundColorTan)
        Me.GroupBox1.Controls.Add(Me.picBrochureBackgroundColorMistyRose)
        Me.GroupBox1.Controls.Add(Me.radBrochureBackgroundColorMistyRose)
        Me.GroupBox1.Controls.Add(Me.picBrochureBackgroundColorWhite)
        Me.GroupBox1.Controls.Add(Me.radBrochureBackgroundColorWhite)
        Me.GroupBox1.Location = New System.Drawing.Point(257, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(365, 96)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Brochure background color"
        '
        'picBrochureBackgroundColorOrange
        '
        Me.picBrochureBackgroundColorOrange.BackColor = System.Drawing.Color.Orange
        Me.picBrochureBackgroundColorOrange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBrochureBackgroundColorOrange.Location = New System.Drawing.Point(258, 68)
        Me.picBrochureBackgroundColorOrange.Name = "picBrochureBackgroundColorOrange"
        Me.picBrochureBackgroundColorOrange.Size = New System.Drawing.Size(16, 16)
        Me.picBrochureBackgroundColorOrange.TabIndex = 19
        Me.picBrochureBackgroundColorOrange.TabStop = False
        '
        'radBrochureBackgroundColorOrange
        '
        Me.radBrochureBackgroundColorOrange.AutoSize = True
        Me.radBrochureBackgroundColorOrange.Location = New System.Drawing.Point(280, 68)
        Me.radBrochureBackgroundColorOrange.Name = "radBrochureBackgroundColorOrange"
        Me.radBrochureBackgroundColorOrange.Size = New System.Drawing.Size(60, 17)
        Me.radBrochureBackgroundColorOrange.TabIndex = 8
        Me.radBrochureBackgroundColorOrange.TabStop = True
        Me.radBrochureBackgroundColorOrange.Text = "Orange"
        Me.radBrochureBackgroundColorOrange.UseVisualStyleBackColor = True
        '
        'picBrochureBackgroundColorLightGray
        '
        Me.picBrochureBackgroundColorLightGray.BackColor = System.Drawing.Color.LightGray
        Me.picBrochureBackgroundColorLightGray.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBrochureBackgroundColorLightGray.Location = New System.Drawing.Point(258, 45)
        Me.picBrochureBackgroundColorLightGray.Name = "picBrochureBackgroundColorLightGray"
        Me.picBrochureBackgroundColorLightGray.Size = New System.Drawing.Size(16, 16)
        Me.picBrochureBackgroundColorLightGray.TabIndex = 17
        Me.picBrochureBackgroundColorLightGray.TabStop = False
        '
        'radBrochureBackgroundColorLightGray
        '
        Me.radBrochureBackgroundColorLightGray.AutoSize = True
        Me.radBrochureBackgroundColorLightGray.Location = New System.Drawing.Point(280, 45)
        Me.radBrochureBackgroundColorLightGray.Name = "radBrochureBackgroundColorLightGray"
        Me.radBrochureBackgroundColorLightGray.Size = New System.Drawing.Size(73, 17)
        Me.radBrochureBackgroundColorLightGray.TabIndex = 7
        Me.radBrochureBackgroundColorLightGray.TabStop = True
        Me.radBrochureBackgroundColorLightGray.Text = "Light Gray"
        Me.radBrochureBackgroundColorLightGray.UseVisualStyleBackColor = True
        '
        'picBrochureBackgroundColorLavender
        '
        Me.picBrochureBackgroundColorLavender.BackColor = System.Drawing.Color.Lavender
        Me.picBrochureBackgroundColorLavender.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBrochureBackgroundColorLavender.Location = New System.Drawing.Point(258, 22)
        Me.picBrochureBackgroundColorLavender.Name = "picBrochureBackgroundColorLavender"
        Me.picBrochureBackgroundColorLavender.Size = New System.Drawing.Size(16, 16)
        Me.picBrochureBackgroundColorLavender.TabIndex = 15
        Me.picBrochureBackgroundColorLavender.TabStop = False
        '
        'radBrochureBackgroundColorLavender
        '
        Me.radBrochureBackgroundColorLavender.AutoSize = True
        Me.radBrochureBackgroundColorLavender.Location = New System.Drawing.Point(280, 22)
        Me.radBrochureBackgroundColorLavender.Name = "radBrochureBackgroundColorLavender"
        Me.radBrochureBackgroundColorLavender.Size = New System.Drawing.Size(70, 17)
        Me.radBrochureBackgroundColorLavender.TabIndex = 6
        Me.radBrochureBackgroundColorLavender.TabStop = True
        Me.radBrochureBackgroundColorLavender.Text = "Lavender"
        Me.radBrochureBackgroundColorLavender.UseVisualStyleBackColor = True
        '
        'picBrochureBackgroundColorLightCyan
        '
        Me.picBrochureBackgroundColorLightCyan.BackColor = System.Drawing.Color.LightCyan
        Me.picBrochureBackgroundColorLightCyan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBrochureBackgroundColorLightCyan.Location = New System.Drawing.Point(133, 68)
        Me.picBrochureBackgroundColorLightCyan.Name = "picBrochureBackgroundColorLightCyan"
        Me.picBrochureBackgroundColorLightCyan.Size = New System.Drawing.Size(16, 16)
        Me.picBrochureBackgroundColorLightCyan.TabIndex = 13
        Me.picBrochureBackgroundColorLightCyan.TabStop = False
        '
        'radBrochureBackgroundColorLightCyan
        '
        Me.radBrochureBackgroundColorLightCyan.AutoSize = True
        Me.radBrochureBackgroundColorLightCyan.Location = New System.Drawing.Point(155, 68)
        Me.radBrochureBackgroundColorLightCyan.Name = "radBrochureBackgroundColorLightCyan"
        Me.radBrochureBackgroundColorLightCyan.Size = New System.Drawing.Size(75, 17)
        Me.radBrochureBackgroundColorLightCyan.TabIndex = 5
        Me.radBrochureBackgroundColorLightCyan.TabStop = True
        Me.radBrochureBackgroundColorLightCyan.Text = "Light Cyan"
        Me.radBrochureBackgroundColorLightCyan.UseVisualStyleBackColor = True
        '
        'picBrochureBackgroundColorPaleGreen
        '
        Me.picBrochureBackgroundColorPaleGreen.BackColor = System.Drawing.Color.PaleGreen
        Me.picBrochureBackgroundColorPaleGreen.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBrochureBackgroundColorPaleGreen.Location = New System.Drawing.Point(133, 45)
        Me.picBrochureBackgroundColorPaleGreen.Name = "picBrochureBackgroundColorPaleGreen"
        Me.picBrochureBackgroundColorPaleGreen.Size = New System.Drawing.Size(16, 16)
        Me.picBrochureBackgroundColorPaleGreen.TabIndex = 11
        Me.picBrochureBackgroundColorPaleGreen.TabStop = False
        '
        'radBrochureBackgroundColorPaleGreen
        '
        Me.radBrochureBackgroundColorPaleGreen.AutoSize = True
        Me.radBrochureBackgroundColorPaleGreen.Location = New System.Drawing.Point(155, 45)
        Me.radBrochureBackgroundColorPaleGreen.Name = "radBrochureBackgroundColorPaleGreen"
        Me.radBrochureBackgroundColorPaleGreen.Size = New System.Drawing.Size(78, 17)
        Me.radBrochureBackgroundColorPaleGreen.TabIndex = 4
        Me.radBrochureBackgroundColorPaleGreen.TabStop = True
        Me.radBrochureBackgroundColorPaleGreen.Text = "Pale Green"
        Me.radBrochureBackgroundColorPaleGreen.UseVisualStyleBackColor = True
        '
        'picBrochureBackgroundColorLightYellow
        '
        Me.picBrochureBackgroundColorLightYellow.BackColor = System.Drawing.Color.LightYellow
        Me.picBrochureBackgroundColorLightYellow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBrochureBackgroundColorLightYellow.Location = New System.Drawing.Point(133, 22)
        Me.picBrochureBackgroundColorLightYellow.Name = "picBrochureBackgroundColorLightYellow"
        Me.picBrochureBackgroundColorLightYellow.Size = New System.Drawing.Size(16, 16)
        Me.picBrochureBackgroundColorLightYellow.TabIndex = 9
        Me.picBrochureBackgroundColorLightYellow.TabStop = False
        '
        'radBrochureBackgroundColorLightYellow
        '
        Me.radBrochureBackgroundColorLightYellow.AutoSize = True
        Me.radBrochureBackgroundColorLightYellow.Location = New System.Drawing.Point(155, 22)
        Me.radBrochureBackgroundColorLightYellow.Name = "radBrochureBackgroundColorLightYellow"
        Me.radBrochureBackgroundColorLightYellow.Size = New System.Drawing.Size(82, 17)
        Me.radBrochureBackgroundColorLightYellow.TabIndex = 3
        Me.radBrochureBackgroundColorLightYellow.TabStop = True
        Me.radBrochureBackgroundColorLightYellow.Text = "Light Yellow"
        Me.radBrochureBackgroundColorLightYellow.UseVisualStyleBackColor = True
        '
        'picBrochureBackgroundColorTan
        '
        Me.picBrochureBackgroundColorTan.BackColor = System.Drawing.Color.Tan
        Me.picBrochureBackgroundColorTan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBrochureBackgroundColorTan.Location = New System.Drawing.Point(14, 68)
        Me.picBrochureBackgroundColorTan.Name = "picBrochureBackgroundColorTan"
        Me.picBrochureBackgroundColorTan.Size = New System.Drawing.Size(16, 16)
        Me.picBrochureBackgroundColorTan.TabIndex = 5
        Me.picBrochureBackgroundColorTan.TabStop = False
        '
        'radBrochureBackgroundColorTan
        '
        Me.radBrochureBackgroundColorTan.AutoSize = True
        Me.radBrochureBackgroundColorTan.Location = New System.Drawing.Point(36, 68)
        Me.radBrochureBackgroundColorTan.Name = "radBrochureBackgroundColorTan"
        Me.radBrochureBackgroundColorTan.Size = New System.Drawing.Size(44, 17)
        Me.radBrochureBackgroundColorTan.TabIndex = 2
        Me.radBrochureBackgroundColorTan.TabStop = True
        Me.radBrochureBackgroundColorTan.Text = "Tan"
        Me.radBrochureBackgroundColorTan.UseVisualStyleBackColor = True
        '
        'picBrochureBackgroundColorMistyRose
        '
        Me.picBrochureBackgroundColorMistyRose.BackColor = System.Drawing.Color.MistyRose
        Me.picBrochureBackgroundColorMistyRose.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBrochureBackgroundColorMistyRose.Location = New System.Drawing.Point(14, 45)
        Me.picBrochureBackgroundColorMistyRose.Name = "picBrochureBackgroundColorMistyRose"
        Me.picBrochureBackgroundColorMistyRose.Size = New System.Drawing.Size(16, 16)
        Me.picBrochureBackgroundColorMistyRose.TabIndex = 3
        Me.picBrochureBackgroundColorMistyRose.TabStop = False
        '
        'radBrochureBackgroundColorMistyRose
        '
        Me.radBrochureBackgroundColorMistyRose.AutoSize = True
        Me.radBrochureBackgroundColorMistyRose.Location = New System.Drawing.Point(36, 45)
        Me.radBrochureBackgroundColorMistyRose.Name = "radBrochureBackgroundColorMistyRose"
        Me.radBrochureBackgroundColorMistyRose.Size = New System.Drawing.Size(77, 17)
        Me.radBrochureBackgroundColorMistyRose.TabIndex = 1
        Me.radBrochureBackgroundColorMistyRose.TabStop = True
        Me.radBrochureBackgroundColorMistyRose.Text = "Misty Rose"
        Me.radBrochureBackgroundColorMistyRose.UseVisualStyleBackColor = True
        '
        'picBrochureBackgroundColorWhite
        '
        Me.picBrochureBackgroundColorWhite.BackColor = System.Drawing.Color.White
        Me.picBrochureBackgroundColorWhite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBrochureBackgroundColorWhite.Location = New System.Drawing.Point(14, 22)
        Me.picBrochureBackgroundColorWhite.Name = "picBrochureBackgroundColorWhite"
        Me.picBrochureBackgroundColorWhite.Size = New System.Drawing.Size(16, 16)
        Me.picBrochureBackgroundColorWhite.TabIndex = 1
        Me.picBrochureBackgroundColorWhite.TabStop = False
        '
        'radBrochureBackgroundColorWhite
        '
        Me.radBrochureBackgroundColorWhite.AutoSize = True
        Me.radBrochureBackgroundColorWhite.Location = New System.Drawing.Point(36, 22)
        Me.radBrochureBackgroundColorWhite.Name = "radBrochureBackgroundColorWhite"
        Me.radBrochureBackgroundColorWhite.Size = New System.Drawing.Size(53, 17)
        Me.radBrochureBackgroundColorWhite.TabIndex = 0
        Me.radBrochureBackgroundColorWhite.TabStop = True
        Me.radBrochureBackgroundColorWhite.Text = "White"
        Me.radBrochureBackgroundColorWhite.UseVisualStyleBackColor = True
        '
        'lnkBrochureClearImage
        '
        Me.lnkBrochureClearImage.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lnkBrochureClearImage.AutoSize = True
        Me.lnkBrochureClearImage.Location = New System.Drawing.Point(202, 121)
        Me.lnkBrochureClearImage.Name = "lnkBrochureClearImage"
        Me.lnkBrochureClearImage.Size = New System.Drawing.Size(36, 13)
        Me.lnkBrochureClearImage.TabIndex = 4
        Me.lnkBrochureClearImage.TabStop = True
        Me.lnkBrochureClearImage.Text = "(clear)"
        '
        'btnPrintBrochure
        '
        Me.btnPrintBrochure.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPrintBrochure.Location = New System.Drawing.Point(561, 334)
        Me.btnPrintBrochure.Name = "btnPrintBrochure"
        Me.btnPrintBrochure.Size = New System.Drawing.Size(124, 24)
        Me.btnPrintBrochure.TabIndex = 6
        Me.btnPrintBrochure.Text = "Print Brochure"
        '
        'lblBrochureImage
        '
        Me.lblBrochureImage.AutoSize = True
        Me.lblBrochureImage.Location = New System.Drawing.Point(11, 121)
        Me.lblBrochureImage.Name = "lblBrochureImage"
        Me.lblBrochureImage.Size = New System.Drawing.Size(181, 13)
        Me.lblBrochureImage.TabIndex = 2
        Me.lblBrochureImage.Text = "Brochure image:   (from Attachments)"
        '
        'picBrochureImage
        '
        Me.picBrochureImage.BackColor = System.Drawing.SystemColors.AppWorkspace
        Me.picBrochureImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picBrochureImage.Location = New System.Drawing.Point(14, 137)
        Me.picBrochureImage.Name = "picBrochureImage"
        Me.picBrochureImage.Size = New System.Drawing.Size(220, 220)
        Me.picBrochureImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picBrochureImage.TabIndex = 35
        Me.picBrochureImage.TabStop = False
        '
        'txtBrochureComments
        '
        Me.txtBrochureComments.Location = New System.Drawing.Point(14, 28)
        Me.txtBrochureComments.MaxLength = 255
        Me.txtBrochureComments.Multiline = True
        Me.txtBrochureComments.Name = "txtBrochureComments"
        Me.txtBrochureComments.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtBrochureComments.Size = New System.Drawing.Size(220, 80)
        Me.txtBrochureComments.TabIndex = 1
        '
        'lblBrochureComments
        '
        Me.lblBrochureComments.AutoSize = True
        Me.lblBrochureComments.Location = New System.Drawing.Point(11, 12)
        Me.lblBrochureComments.Name = "lblBrochureComments"
        Me.lblBrochureComments.Size = New System.Drawing.Size(104, 13)
        Me.lblBrochureComments.TabIndex = 0
        Me.lblBrochureComments.Text = "Brochure comments:"
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(8, 459)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 24)
        Me.btnHelp.TabIndex = 4
        Me.btnHelp.Text = "Help"
        '
        'btnTaggingDataForm
        '
        Me.btnTaggingDataForm.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnTaggingDataForm.Location = New System.Drawing.Point(86, 459)
        Me.btnTaggingDataForm.Name = "btnTaggingDataForm"
        Me.btnTaggingDataForm.Size = New System.Drawing.Size(124, 24)
        Me.btnTaggingDataForm.TabIndex = 5
        Me.btnTaggingDataForm.Text = "Tagging Data Form..."
        '
        'erpErrorProvider
        '
        Me.erpErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.erpErrorProvider.ContainerControl = Me
        '
        'dtpDateCaptured
        '
        Me.dtpDateCaptured.BackColor = System.Drawing.SystemColors.Window
        Me.dtpDateCaptured.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dtpDateCaptured.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtpDateCaptured.DateValue = New Date(2006, 5, 30, 0, 0, 0, 0)
        Me.dtpDateCaptured.Location = New System.Drawing.Point(144, 168)
        Me.dtpDateCaptured.MaxValue = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateCaptured.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateCaptured.Name = "dtpDateCaptured"
        Me.dtpDateCaptured.Size = New System.Drawing.Size(216, 20)
        Me.dtpDateCaptured.TabIndex = 13
        '
        'lblDateCaptured
        '
        Me.lblDateCaptured.Location = New System.Drawing.Point(16, 168)
        Me.lblDateCaptured.Name = "lblDateCaptured"
        Me.lblDateCaptured.Size = New System.Drawing.Size(112, 20)
        Me.lblDateCaptured.TabIndex = 12
        Me.lblDateCaptured.Text = "Date captured:"
        Me.lblDateCaptured.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'picMoreInfoDateCaptured
        '
        Me.picMoreInfoDateCaptured.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picMoreInfoDateCaptured.Image = CType(resources.GetObject("picMoreInfoDateCaptured.Image"), System.Drawing.Image)
        Me.picMoreInfoDateCaptured.Location = New System.Drawing.Point(128, 172)
        Me.picMoreInfoDateCaptured.Name = "picMoreInfoDateCaptured"
        Me.picMoreInfoDateCaptured.Size = New System.Drawing.Size(12, 12)
        Me.picMoreInfoDateCaptured.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picMoreInfoDateCaptured.TabIndex = 112
        Me.picMoreInfoDateCaptured.TabStop = False
        Me.tipToolTip.SetToolTip(Me.picMoreInfoDateCaptured, "More information about acquired from")
        '
        'TurtleInformationDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(724, 498)
        Me.Controls.Add(Me.btnTaggingDataForm)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.tabTurtleTab)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TurtleInformationDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sea Turtle Information"
        CType(Me.picMoreInfoRelinquishedTo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoreInfoStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoreInfoSize, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoreInfoAcquiredFrom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoreInfoSidNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoreInfoStrandingIdNumber, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoreInfoAnomalies, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picAcquiredLatitudeLongitudeMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRelinquishedLatLonMap, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoreInfoAcquiredCounty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoreInfoAcquiredLatLon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoreInfoRelinquishedLatLon, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoreInfoRelinquishedCounty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoreInfoInitialEncounterInformation, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabTurtleTab.ResumeLayout(False)
        Me.tpgTurtleTabGeneralInformation.ResumeLayout(False)
        Me.tpgTurtleTabGeneralInformation.PerformLayout()
        Me.grpInjuries.ResumeLayout(False)
        Me.grpInjuries.PerformLayout()
        Me.tpgTurtleTabTags.ResumeLayout(False)
        Me.grpInitialEncounter.ResumeLayout(False)
        Me.grpInitialEncounter.PerformLayout()
        Me.grpInspectedScanned.ResumeLayout(False)
        Me.grpInspectedScanned.PerformLayout()
        CType(Me.grdTurtleTagGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurtleTagGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgTurtleTabMorphometrics.ResumeLayout(False)
        Me.tabMorphometricsTab.ResumeLayout(False)
        Me.tpgMeasurements.ResumeLayout(False)
        CType(Me.grdTurtleMorphometricGrid, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurtleMorphometricGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgGraphs.ResumeLayout(False)
        Me.tpgGraphs.PerformLayout()
        Me.pnlGraphChoices.ResumeLayout(False)
        Me.pnlGraphChoices.PerformLayout()
        Me.tpgTurtleTabAttachments.ResumeLayout(False)
        Me.tpgTurtleTabAttachments.PerformLayout()
        CType(Me.picAttachmentPreview, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.grdTurtleFileAttachmentList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TurtleAttachmentGridBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tpgTurtleTabBrochure.ResumeLayout(False)
        Me.tpgTurtleTabBrochure.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picBrochureBackgroundColorOrange, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrochureBackgroundColorLightGray, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrochureBackgroundColorLavender, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrochureBackgroundColorLightCyan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrochureBackgroundColorPaleGreen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrochureBackgroundColorLightYellow, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrochureBackgroundColorTan, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrochureBackgroundColorMistyRose, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrochureBackgroundColorWhite, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBrochureImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMoreInfoDateCaptured, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mbIsLoading As Boolean = False
    Private mbIsOkayButtonClicked As Boolean = False
    Private moTurtle As Turtle
    Private msTagSortedColumnPropertyName As String = "TagNumber"
    Private msMorphometricsSortedColumnPropertyName As String = "DateMeasuredBindable"
    Private moListSortDirection As System.ComponentModel.ListSortDirection = System.ComponentModel.ListSortDirection.Ascending

    Public Sub New(ByVal oTurtle As Turtle)

        MyBase.New()

        mbIsLoading = True

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None

        moTurtle = oTurtle

        mbIsLoading = False

    End Sub

    Private Sub frmTurtleInformationDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim i As Integer
        Dim sFileAttachmentId As String = String.Empty
        Dim sFullFileName As String = String.Empty

        Try
            '*** ASSERTION ***
            If moTurtle Is Nothing Then
                Throw New ApplicationException("Turtle object must be set before opening this screen.")
            End If
            '*** ASSERTION ***

            mbIsLoading = True

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- load list boxes
            '----------------------------------------------------------------
            Me.cboSpeciesList.DisplayMember = "Value"
            Me.cboSpeciesList.ValueMember = "Key"
            Me.cboSpeciesList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.Species, True)

            Me.cboSizeList.DisplayMember = "Value"
            Me.cboSizeList.ValueMember = "Key"
            Me.cboSizeList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.TurtleSize, True)

            Me.cboStatusList.DisplayMember = "Value"
            Me.cboStatusList.ValueMember = "Key"
            Me.cboStatusList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.TurtleStatus, True)

            Me.cboAcquiredCountyList.DisplayMember = "Value"
            Me.cboAcquiredCountyList.ValueMember = "Key"
            Me.cboAcquiredCountyList.DataSource = CountyList.GetList(True)

            Me.cboRelinquishedCountyList.DisplayMember = "Value"
            Me.cboRelinquishedCountyList.ValueMember = "Key"
            Me.cboRelinquishedCountyList.DataSource = CountyList.GetList(True)

            Me.cboRecaptureTypeList.DisplayMember = "Value"
            Me.cboRecaptureTypeList.ValueMember = "Key"
            Me.cboRecaptureTypeList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.RecaptureType, True)

            Me.cboCaptureProjectTypeList.DisplayMember = "Value"
            Me.cboCaptureProjectTypeList.ValueMember = "Key"
            Me.cboCaptureProjectTypeList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.CaptureProjectType, True)

            Me.cboDidTurtleNestList.DisplayMember = "Value"
            Me.cboDidTurtleNestList.ValueMember = "Key"
            Me.cboDidTurtleNestList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.YesNoUndetermined, True)

            '----------------------------------------------------------------
            '-- default to TODAY
            '----------------------------------------------------------------
            'Me.dtpDateCaptured.DateValue = DateTime.Now
            Me.dtpDateAcquired.DateValue = DateTime.Now
            Me.dtpDateRelinquished.DateValue = DateTime.Now

            '----------------------------------------------------------------
            '-- load the form fields with the data values
            '----------------------------------------------------------------
            moTurtle.BeginEdit()

            Me.txtTurtleName.Text = moTurtle.TurtleName
            Me.txtSidNumber.Text = moTurtle.SidNumber
            Me.txtStrandingIdNumber.Text = moTurtle.StrandingIdNumber
            Me.cboSpeciesList.SelectedIndex = cboSpeciesList.FindString(moTurtle.Species)
            Me.dtpDateCaptured.DateValue = moTurtle.DateCaptured
            Me.dtpDateAcquired.DateValue = moTurtle.DateAcquired
            Me.txtAcquiredFrom.Text = moTurtle.AcquiredFrom
            Me.cboSizeList.SelectedIndex = cboSizeList.FindString(moTurtle.TurtleSize)
            Me.cboStatusList.SelectedIndex = cboStatusList.FindString(moTurtle.Status)
            Me.dtpDateRelinquished.DateValue = moTurtle.DateRelinquished
            Me.txtRelinquishedTo.Text = moTurtle.RelinquishedTo
            Me.txtAnomalies.Text = moTurtle.Anomalies

            Me.chkInjuryBoatStrike.Checked = moTurtle.InjuryBoatStrike
            Me.chkInjuryIntestinalImpaction.Checked = moTurtle.InjuryIntestinalImpaction
            Me.chkInjuryLineEntanglement.Checked = moTurtle.InjuryLineEntanglement
            Me.chkInjuryFishHook.Checked = moTurtle.InjuryFishHook
            Me.chkInjuryUpperRespiratory.Checked = moTurtle.InjuryUpperRespiratory
            Me.chkInjuryAnimalBite.Checked = moTurtle.InjuryAnimalBite
            Me.chkInjuryFibropapilloma.Checked = moTurtle.InjuryFibropapilloma
            Me.chkInjuryMiscEpidemic.Checked = moTurtle.InjuryMiscEpidemic
            Me.chkInjuryDoa.Checked = moTurtle.InjuryDoa
            Me.chkInjuryOther.Checked = moTurtle.InjuryOther

            Me.cboAcquiredCountyList.SelectedIndex = cboAcquiredCountyList.FindString(moTurtle.AcquiredCounty)
            Me.txtAcquiredLatitude.Text = moTurtle.AcquiredLatitudeString
            Me.txtAcquiredLongitude.Text = moTurtle.AcquiredLongitudeString
            Me.cboRelinquishedCountyList.SelectedIndex = cboRelinquishedCountyList.FindString(moTurtle.RelinquishedCounty)
            Me.txtRelinquishedLatitude.Text = moTurtle.RelinquishedLatitudeString
            Me.txtRelinquishedLongitude.Text = moTurtle.RelinquishedLongitudeString

            Me.chkWasTurtleCarryingTagsWhenEncountered.Checked = moTurtle.WasCarryingTagsWhenEncountered

            If Me.chkWasTurtleCarryingTagsWhenEncountered.Checked Then
                Me.lblRecaptureType.Enabled = True
                Me.cboRecaptureTypeList.Enabled = True
                Me.cboRecaptureTypeList.SelectedIndex = cboRecaptureTypeList.FindString(moTurtle.RecaptureType)
                Me.lblTagReturnAddress.Enabled = True
                Me.txtTagReturnAddress.Enabled = True
                Me.txtTagReturnAddress.Text = moTurtle.TagReturnAddress
            Else
                Me.lblRecaptureType.Enabled = False
                Me.cboRecaptureTypeList.SelectedIndex = -1
                Me.cboRecaptureTypeList.Enabled = False
                Me.txtTagReturnAddress.Text = String.Empty
                Me.txtTagReturnAddress.Enabled = False
                Me.lblTagReturnAddress.Enabled = False
            End If

            Me.cboCaptureProjectTypeList.SelectedIndex = cboCaptureProjectTypeList.FindString(moTurtle.CaptureProjectType)

            If (moTurtle.CaptureProjectType = "N") Then
                Me.lblDidTurtleNest.Enabled = True
                Me.cboDidTurtleNestList.Enabled = True
                Me.cboDidTurtleNestList.SelectedIndex = cboDidTurtleNestList.FindString(moTurtle.DidTurtleNest)
            Else
                Me.lblDidTurtleNest.Enabled = False
                Me.cboDidTurtleNestList.SelectedIndex = -1
                Me.cboDidTurtleNestList.Enabled = False
            End If

            If (moTurtle.CaptureProjectType = "O") Then
                Me.lblCaptureProjectOther.Enabled = True
                Me.txtCaptureProjectOther.Enabled = True
                Me.txtCaptureProjectOther.Text = moTurtle.CaptureProjectOther
            Else
                Me.lblCaptureProjectOther.Enabled = False
                Me.txtCaptureProjectOther.Text = String.Empty
                Me.txtCaptureProjectOther.Enabled = False
            End If

            Me.chkInspectedForTagScars.Checked = moTurtle.InspectedForTagScars

            If Me.chkInspectedForTagScars.Checked Then
                Me.lblTagScarsLocated.Enabled = True
                Me.txtTagScarsLocated.Enabled = True
                Me.txtTagScarsLocated.Text = moTurtle.TagScarsLocated
            Else
                Me.lblTagScarsLocated.Enabled = False
                Me.txtTagScarsLocated.Text = String.Empty
                Me.txtTagScarsLocated.Enabled = False
            End If

            Me.chkScannedForPitTags.Checked = moTurtle.ScannedForPitTags

            If Me.chkScannedForPitTags.Checked Then
                Me.lblPitTagsFrequency.Enabled = True
                Me.txtPitTagsFrequency.Enabled = True
                Me.txtPitTagsFrequency.Text = moTurtle.PitTagsScanFrequency
            Else
                Me.lblPitTagsFrequency.Enabled = False
                Me.txtPitTagsFrequency.Text = String.Empty
                Me.txtPitTagsFrequency.Enabled = False
            End If

            Me.chkScannedForMagneticWires.Checked = moTurtle.ScannedForMagneticWires

            If Me.chkScannedForMagneticWires.Checked Then
                Me.lblMagneticWiresLocated.Enabled = True
                Me.txtMagneticWiresLocated.Enabled = True
                Me.txtMagneticWiresLocated.Text = moTurtle.MagneticWiresLocated
            Else
                Me.lblMagneticWiresLocated.Enabled = False
                Me.txtMagneticWiresLocated.Text = String.Empty
                Me.txtMagneticWiresLocated.Enabled = False
            End If

            Me.chkInspectedForLivingTags.Checked = moTurtle.InspectedForLivingTags

            If Me.chkInspectedForLivingTags.Checked Then
                Me.lblLivingTagsLocated.Enabled = True
                Me.txtLivingTagsLocated.Enabled = True
                Me.txtLivingTagsLocated.Text = moTurtle.LivingTagsLocated
            Else
                Me.lblLivingTagsLocated.Enabled = False
                Me.txtLivingTagsLocated.Text = String.Empty
                Me.txtLivingTagsLocated.Enabled = False
            End If

            Me.txtBrochureComments.Text = moTurtle.BrochureComments

            If (moTurtle.BrochureBackgroundColor = Color.MistyRose.ToArgb) Then
                Me.radBrochureBackgroundColorMistyRose.Checked = True
            ElseIf (moTurtle.BrochureBackgroundColor = Color.Tan.ToArgb) Then
                Me.radBrochureBackgroundColorTan.Checked = True
            ElseIf (moTurtle.BrochureBackgroundColor = Color.LightYellow.ToArgb) Then
                Me.radBrochureBackgroundColorLightYellow.Checked = True
            ElseIf (moTurtle.BrochureBackgroundColor = Color.PaleGreen.ToArgb) Then
                Me.radBrochureBackgroundColorPaleGreen.Checked = True
            ElseIf (moTurtle.BrochureBackgroundColor = Color.LightCyan.ToArgb) Then
                Me.radBrochureBackgroundColorLightCyan.Checked = True
            ElseIf (moTurtle.BrochureBackgroundColor = Color.Lavender.ToArgb) Then
                Me.radBrochureBackgroundColorLavender.Checked = True
            ElseIf (moTurtle.BrochureBackgroundColor = Color.LightGray.ToArgb) Then
                Me.radBrochureBackgroundColorLightGray.Checked = True
            ElseIf (moTurtle.BrochureBackgroundColor = Color.Orange.ToArgb) Then
                Me.radBrochureBackgroundColorOrange.Checked = True
            Else
                Me.radBrochureBackgroundColorWhite.Checked = True
            End If

            ClearBrochureImage()
            Me.picAttachmentPreview.Tag = String.Empty

            For i = 0 To moTurtle.FileAttachments.Count - 1
                sFileAttachmentId = moTurtle.FileAttachments(i).TurtleFileAttachmentId.Trim().ToUpper()
                sFullFileName = moTurtle.FileAttachments(i).FullFileName
                If (sFileAttachmentId = moTurtle.BrochureImageFileAttachmentId.Trim().ToUpper()) Then
                    If Not (String.IsNullOrEmpty(sFullFileName)) _
                    AndAlso ((sFullFileName.Trim.ToUpper.EndsWith(".JPG")) OrElse (sFullFileName.Trim.ToUpper.EndsWith(".BMP"))) _
                    AndAlso (File.Exists(moTurtle.FileAttachments(i).FullFileName)) Then
                        Me.picBrochureImage.Image = Image.FromFile(sFullFileName)
                        Me.picBrochureImage.Tag = sFileAttachmentId
                        Exit For
                    End If
                End If
            Next

            '----------------------------------------------------------------
            '-- populate the TURTLE TAG grid
            '----------------------------------------------------------------
            LoadTurtleTagGridData()

            '----------------------------------------------------------------
            '-- populate the TURTLE MORPHOMETRIC grid
            '----------------------------------------------------------------
            LoadTurtleMorphometricGridData()

            '----------------------------------------------------------------
            '-- populate the TURTLE ATTACHMENTS grid
            '----------------------------------------------------------------
            LoadTurtleAttachmentGridData()

            '----------------------------------------------------------------
            '-- display required field indicators 
            '----------------------------------------------------------------
            Me.DisplayBrokenRules(False)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            mbIsLoading = False

        End Try

    End Sub

    Private Sub frmTurtleInformationDlg_Activated(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Activated
        Me.txtTurtleName.Focus()
    End Sub

    Private Sub frmTurtleInformationDlg_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

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
            If moTurtle.IsDirty Then

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
            moTurtle.CancelEdit()
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
        Dim oTempTurtle As Turtle

        Try
            '------------------------------------------------------------ 
            '-- if the object has changed... 
            '------------------------------------------------------------ 
            If moTurtle.IsDirty Then

                '------------------------------------------------------------ 
                '-- if all of the validation rules have passed... 
                '------------------------------------------------------------ 
                If moTurtle.IsValid Then

                    '----------------------------------------------------------------
                    '-- commit edits in memory
                    '----------------------------------------------------------------
                    moTurtle.ApplyEdit()

                    '----------------------------------------------------------------
                    '-- clone and save the object (it is the CSLA way)
                    '----------------------------------------------------------------
                    oTempTurtle = moTurtle.Clone
                    moTurtle = oTempTurtle.Save

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
                MessageBox.Show(" *** The following data validation issue(s) must be resolved before this package can be saved: *** " & ControlChars.CrLf & ControlChars.CrLf & moTurtle.GetBrokenRulesString, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        moTurtle.TurtleName = Me.txtTurtleName.Text.Trim
        moTurtle.SidNumber = Me.txtSidNumber.Text.Trim
        moTurtle.StrandingIdNumber = Me.txtStrandingIdNumber.Text.Trim

        If cboSpeciesList.SelectedIndex > -1 Then
            moTurtle.Species = CType(Me.cboSpeciesList.SelectedItem, KeyValueInfo).Key
        End If

        moTurtle.DateCaptured = Me.dtpDateCaptured.DateValue

        moTurtle.DateAcquired = Me.dtpDateAcquired.DateValue
        moTurtle.AcquiredFrom = Me.txtAcquiredFrom.Text.Trim

        If (cboSizeList.SelectedIndex > -1) Then
            moTurtle.TurtleSize = CType(Me.cboSizeList.SelectedItem, KeyValueInfo).Key
        End If

        If (cboStatusList.SelectedIndex > -1) Then
            moTurtle.Status = CType(Me.cboStatusList.SelectedItem, KeyValueInfo).Key
        End If

        moTurtle.DateRelinquished = Me.dtpDateRelinquished.DateValue
        moTurtle.RelinquishedTo = Me.txtRelinquishedTo.Text.Trim

        moTurtle.Anomalies = Me.txtAnomalies.Text.Trim

        moTurtle.InjuryBoatStrike = Me.chkInjuryBoatStrike.Checked
        moTurtle.InjuryIntestinalImpaction = Me.chkInjuryIntestinalImpaction.Checked
        moTurtle.InjuryLineEntanglement = Me.chkInjuryLineEntanglement.Checked
        moTurtle.InjuryFishHook = Me.chkInjuryFishHook.Checked
        moTurtle.InjuryUpperRespiratory = Me.chkInjuryUpperRespiratory.Checked
        moTurtle.InjuryAnimalBite = Me.chkInjuryAnimalBite.Checked
        moTurtle.InjuryFibropapilloma = Me.chkInjuryFibropapilloma.Checked
        moTurtle.InjuryMiscEpidemic = Me.chkInjuryMiscEpidemic.Checked
        moTurtle.InjuryDoa = Me.chkInjuryDoa.Checked
        moTurtle.InjuryOther = Me.chkInjuryOther.Checked

        moTurtle.AcquiredCounty = Me.cboAcquiredCountyList.Text
        moTurtle.AcquiredLatitudeString = Me.txtAcquiredLatitude.Text
        moTurtle.AcquiredLongitudeString = Me.txtAcquiredLongitude.Text

        moTurtle.RelinquishedCounty = Me.cboRelinquishedCountyList.Text
        moTurtle.RelinquishedLatitudeString = Me.txtRelinquishedLatitude.Text
        moTurtle.RelinquishedLongitudeString = Me.txtRelinquishedLongitude.Text

        moTurtle.WasCarryingTagsWhenEncountered = Me.chkWasTurtleCarryingTagsWhenEncountered.Checked

        If moTurtle.WasCarryingTagsWhenEncountered Then
            If (Me.cboRecaptureTypeList.SelectedIndex > -1) Then
                moTurtle.RecaptureType = CType(Me.cboRecaptureTypeList.SelectedItem, KeyValueInfo).Key
            End If
            moTurtle.TagReturnAddress = Me.txtTagReturnAddress.Text
        End If

        If (Me.cboCaptureProjectTypeList.SelectedIndex > -1) Then
            moTurtle.CaptureProjectType = CType(Me.cboCaptureProjectTypeList.SelectedItem, KeyValueInfo).Key
            If (moTurtle.CaptureProjectType = "N") Then
                If (Me.cboDidTurtleNestList.SelectedIndex > -1) Then
                    moTurtle.DidTurtleNest = CType(Me.cboDidTurtleNestList.SelectedItem, KeyValueInfo).Key
                End If
                moTurtle.CaptureProjectOther = String.Empty
            ElseIf (moTurtle.CaptureProjectType = "O") Then
                moTurtle.CaptureProjectOther = Me.txtCaptureProjectOther.Text
                moTurtle.DidTurtleNest = String.Empty
            End If
        Else
            moTurtle.DidTurtleNest = String.Empty
            moTurtle.CaptureProjectOther = String.Empty
        End If

        moTurtle.InspectedForTagScars = Me.chkInspectedForTagScars.Checked

        If moTurtle.InspectedForTagScars Then
            moTurtle.TagScarsLocated = Me.txtTagScarsLocated.Text
        Else
            moTurtle.TagScarsLocated = String.Empty
        End If

        moTurtle.ScannedForPitTags = Me.chkScannedForPitTags.Checked

        If moTurtle.ScannedForPitTags Then
            moTurtle.PitTagsScanFrequency = Me.txtPitTagsFrequency.Text
        Else
            moTurtle.PitTagsScanFrequency = String.Empty
        End If

        moTurtle.ScannedForMagneticWires = Me.chkScannedForMagneticWires.Checked

        If moTurtle.ScannedForMagneticWires Then
            moTurtle.MagneticWiresLocated = Me.txtMagneticWiresLocated.Text
        Else
            moTurtle.MagneticWiresLocated = String.Empty
        End If

        moTurtle.InspectedForLivingTags = Me.chkInspectedForLivingTags.Checked

        If moTurtle.InspectedForLivingTags Then
            moTurtle.LivingTagsLocated = Me.txtLivingTagsLocated.Text
        Else
            moTurtle.LivingTagsLocated = String.Empty
        End If

        moTurtle.BrochureComments = Me.txtBrochureComments.Text

        If (Me.radBrochureBackgroundColorMistyRose.Checked) Then
            moTurtle.BrochureBackgroundColor = Color.MistyRose.ToArgb
        ElseIf (Me.radBrochureBackgroundColorTan.Checked) Then
            moTurtle.BrochureBackgroundColor = Color.Tan.ToArgb
        ElseIf (Me.radBrochureBackgroundColorLightYellow.Checked) Then
            moTurtle.BrochureBackgroundColor = Color.LightYellow.ToArgb
        ElseIf (Me.radBrochureBackgroundColorPaleGreen.Checked) Then
            moTurtle.BrochureBackgroundColor = Color.PaleGreen.ToArgb
        ElseIf (Me.radBrochureBackgroundColorLightCyan.Checked) Then
            moTurtle.BrochureBackgroundColor = Color.LightCyan.ToArgb
        ElseIf (Me.radBrochureBackgroundColorLavender.Checked) Then
            moTurtle.BrochureBackgroundColor = Color.Lavender.ToArgb
        ElseIf (Me.radBrochureBackgroundColorLightGray.Checked) Then
            moTurtle.BrochureBackgroundColor = Color.LightGray.ToArgb
        ElseIf (Me.radBrochureBackgroundColorOrange.Checked) Then
            moTurtle.BrochureBackgroundColor = Color.Orange.ToArgb
        Else
            moTurtle.BrochureBackgroundColor = Color.White.ToArgb
        End If

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        If Me.tabTurtleTab.SelectedIndex = 0 Then
            Help.ShowHelp(Me, gsHelpFileName, "SeaTurtleInformationScreen.htm")
        ElseIf Me.tabTurtleTab.SelectedIndex = 1 Then
            Help.ShowHelp(Me, gsHelpFileName, "SeaTurtleInformationScreenTags.htm")
        ElseIf Me.tabTurtleTab.SelectedIndex = 2 Then
            Help.ShowHelp(Me, gsHelpFileName, "SeaTurtleInformationScreenMorphometrics.htm")
        ElseIf Me.tabTurtleTab.SelectedIndex = 3 Then
            Help.ShowHelp(Me, gsHelpFileName, "SeaTurtleInformationScreenAttachments.htm")
        ElseIf Me.tabTurtleTab.SelectedIndex = 4 Then
            Help.ShowHelp(Me, gsHelpFileName, "SeaTurtleInformationScreenBrochure.htm")
        End If

    End Sub

    Private Sub btnTaggingDataForm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTaggingDataForm.Click

        Dim frm As TaggingDataFormDlg = Nothing

        Try

            '------------------------------------------------------------ 
            '-- transfer the form data values into the business object 
            '------------------------------------------------------------ 
            Me.CopyFormValuesToBusinessObject()

            If Not System.IO.File.Exists(MASTER_TAGGING_DATA_FORM_PDF) Then
                MessageBox.Show("'" & MASTER_TAGGING_DATA_FORM_PDF & "' file not found", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Exit Sub
            End If

            frm = New TaggingDataFormDlg(moTurtle)
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

#Region " Miscellaneous functions "

    Private Sub picMoreInfoSidNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoSidNumber.Click

        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "SID Number"
            frm.BodyText = "This is a State Identification number assigned to each turtle held at your facility (excluding hatchlings listed on the hatchling report form)." & ControlChars.CrLf & ControlChars.CrLf & "Each time you receive a new turtle, contact the FWC office in Tequesta at (561) 575-5407 to obtain an SID number for that animal." & ControlChars.CrLf & ControlChars.CrLf & "This information will be displayed on the Marine Turtle Holding Facility Quarterly Report."
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub picMoreInfoStrandingIdNumber_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoStrandingIdNumber.Click

        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "Stranding ID Number"
            frm.BodyText = "The Stranding ID Number is taken from the STSSN form and consists of the observer's initials (if no middle initial, use 'X'), 2-digit year, 2-digit month, 2-digit day, and 2-digit turtle-by-day number." & ControlChars.CrLf & ControlChars.CrLf & "This information will be displayed on the Marine Turtle Holding Facility Quarterly Report."
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub picMoreInfoDateCaptured_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoDateCaptured.Click

        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "Date Captured"
            frm.BodyText = "Enter this value only if it is different from Date Acquired." & ControlChars.CrLf & ControlChars.CrLf & "This information will be displayed on the Tagging Data Form."
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub picMoreInfoAcquiredFrom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoAcquiredFrom.Click

        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "Acquired From"
            frm.BodyText = "Indicate where the turtle came from (e.g., stranding, received from another facility, dropped off anonymously, etc.)" & ControlChars.CrLf & ControlChars.CrLf & "This information will be displayed on the Marine Turtle Holding Facility Quarterly Report."
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub picMoreInfoSize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoSize.Click

        Dim s As String = String.Empty
        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "Size Codes"

            s = String.Empty
            s &= "Hatchling = < 5 cm carapace length (CL) for CC, CM, LK, EI and LO" & ControlChars.CrLf & ControlChars.CrLf
            s &= "Post-hatchling = > 5 cm CL and < 10 cm CL for CC, CM, LK, EI and LO" & ControlChars.CrLf & ControlChars.CrLf
            s &= "Juvenile = > 10 cm CL and (1) < 45 cm CL for LK and LO, (2) < 50 cm CL for EI, (3) < 60 cm CL for CC and CM" & ControlChars.CrLf & ControlChars.CrLf
            s &= "Subadult = > 45 cm CL and < 60 cm CL for LK and LO, (2) > 50 cm and < 70 cm CL for EI, (3) > 60 cm and < 90 cm CL for CC and CM" & ControlChars.CrLf & ControlChars.CrLf
            s &= "Adult = > 60 cm CL for LK and LO, (2) > 70 cm CL for EI, (3) > 90 cm CL for CC and CM" & ControlChars.CrLf & ControlChars.CrLf
            s &= ControlChars.CrLf & ControlChars.CrLf & "This information will be displayed on the Marine Turtle Holding Facility Quarterly Report."

            frm.BodyText = s
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub picMoreInfoStatus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoStatus.Click

        Dim s As String = String.Empty
        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "Status Codes"

            s = String.Empty
            s &= "UR = undergoing rehabilitation" & ControlChars.CrLf & ControlChars.CrLf
            s &= "ED = educational display animal (only loggerheads can be held solely for educational display.  If you list any other species (e.g., a green turtle) as an educational display, you must list another code as the primary purpose for holding." & ControlChars.CrLf & ControlChars.CrLf
            s &= "UO = unknown origin or other origin (i.e., turtles that are not from the Western Atlantic Ocean or the Gulf of Mexico)" & ControlChars.CrLf & ControlChars.CrLf
            s &= "PD = permanently disabled (indicate disability on initial report)" & ControlChars.CrLf & ControlChars.CrLf
            s &= "PREACT = pre-act animal (turtles that have been held in captivity since before 1978)" & ControlChars.CrLf & ControlChars.CrLf
            s &= "RESEARCH = turtles being held for research (requires pre-approval)" & ControlChars.CrLf & ControlChars.CrLf
            s &= "RFR = turtles that are ready for release" & ControlChars.CrLf & ControlChars.CrLf
            s &= "TSTR = an otherwise healthy turtle being held until it reaches the appropriate size class for release in Florida waters" & ControlChars.CrLf & ControlChars.CrLf
            s &= ControlChars.CrLf & ControlChars.CrLf & "This information will be displayed on the Marine Turtle Holding Facility Quarterly Report."

            frm.BodyText = s
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub picMoreInfoRelinquishedTo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoRelinquishedTo.Click

        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "Relinquished To"
            frm.BodyText = "Indicate if the turtle was released, transferred to another facility, or died." & ControlChars.CrLf & ControlChars.CrLf & "This information will be displayed on the Marine Turtle Holding Facility Quarterly Report."
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub picMoreInfoAnomalies_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoAnomalies.Click

        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "Anomalies"
            frm.BodyText = "Provide information regarding any injuries, deformations, markings, etc." & ControlChars.CrLf & ControlChars.CrLf & "This information will be displayed on the Marine Turtle Holding Facility Quarterly Report."
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub picMoreInfoAcquiredCounty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoAcquiredCounty.Click

        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "Acquired County"
            frm.BodyText = "This information will be displayed on the Tagging Data Form."
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub picMoreInfoAcquiredLatLon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoAcquiredLatLon.Click

        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "Acquired Lat/Lon"
            frm.BodyText = "This information will be displayed on the Tagging Data Form."
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub picMoreInfoRelinquishedCounty_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoRelinquishedCounty.Click

        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "Relinquished County"
            frm.BodyText = "This information will be displayed on the Tagging Data Form."
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub picMoreInfoRelinquishedLatLon_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoRelinquishedLatLon.Click

        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "Relinquished lat/lon"
            frm.BodyText = "This information will be displayed on the Tagging Data Form."
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub picMoreInfoInitialEncounterInformation_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picMoreInfoInitialEncounterInformation.Click

        Dim frm As GenericMoreInfoDlg

        Try

            frm = New GenericMoreInfoDlg
            frm.HeaderText = "Initial Encounter Information"
            frm.BodyText = "This information will be displayed on the Tagging Data Form."
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

    Private Sub chkWasTurtleCarryingTagsWhenEncountered_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkWasTurtleCarryingTagsWhenEncountered.CheckedChanged

        If mbIsLoading Then Exit Sub

        If Me.chkWasTurtleCarryingTagsWhenEncountered.Checked Then
            Me.lblRecaptureType.Enabled = True
            Me.cboRecaptureTypeList.Enabled = True
            Me.cboRecaptureTypeList.SelectedIndex = cboRecaptureTypeList.FindString(moTurtle.RecaptureType)
        Else
            Me.lblRecaptureType.Enabled = False
            Me.cboRecaptureTypeList.SelectedIndex = -1
            Me.cboRecaptureTypeList.Enabled = False
        End If

    End Sub

    Private Sub cboCaptureProjectTypeList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboCaptureProjectTypeList.SelectedIndexChanged

        If mbIsLoading Then Exit Sub

        Dim sCaptureProjectType As String = String.Empty

        If (Me.cboCaptureProjectTypeList.SelectedIndex > -1) Then

            sCaptureProjectType = CType(Me.cboCaptureProjectTypeList.SelectedItem, KeyValueInfo).Key

            If (sCaptureProjectType = "N") Then

                Me.lblDidTurtleNest.Enabled = True
                Me.cboDidTurtleNestList.Enabled = True
                Me.lblCaptureProjectOther.Enabled = False
                Me.txtCaptureProjectOther.Enabled = False

            ElseIf (sCaptureProjectType = "O") Then

                Me.lblDidTurtleNest.Enabled = False
                Me.cboDidTurtleNestList.Enabled = False
                Me.lblCaptureProjectOther.Enabled = True
                Me.txtCaptureProjectOther.Enabled = True

            Else

                Me.lblDidTurtleNest.Enabled = False
                Me.cboDidTurtleNestList.Enabled = False
                Me.lblCaptureProjectOther.Enabled = False
                Me.txtCaptureProjectOther.Enabled = False

            End If

        Else

            Me.lblDidTurtleNest.Enabled = False
            Me.cboDidTurtleNestList.Enabled = False
            Me.lblCaptureProjectOther.Enabled = False
            Me.txtCaptureProjectOther.Enabled = False

        End If

    End Sub

    Private Sub chkInspectedForTagScars_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInspectedForTagScars.CheckedChanged

        If mbIsLoading Then Exit Sub

        If Me.chkInspectedForTagScars.Checked Then
            Me.lblTagScarsLocated.Enabled = True
            Me.txtTagScarsLocated.Enabled = True
        Else
            Me.lblTagScarsLocated.Enabled = False
            Me.txtTagScarsLocated.Enabled = False
        End If

    End Sub

    Private Sub chkScannedForPitTags_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkScannedForPitTags.CheckedChanged

        If mbIsLoading Then Exit Sub

        If Me.chkScannedForPitTags.Checked Then
            Me.lblPitTagsFrequency.Enabled = True
            Me.txtPitTagsFrequency.Enabled = True
        Else
            Me.lblPitTagsFrequency.Enabled = False
            Me.txtPitTagsFrequency.Enabled = False
        End If

    End Sub

    Private Sub chkScannedForMagneticWires_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkScannedForMagneticWires.CheckedChanged

        If mbIsLoading Then Exit Sub

        If Me.chkScannedForMagneticWires.Checked Then
            Me.lblMagneticWiresLocated.Enabled = True
            Me.txtMagneticWiresLocated.Enabled = True
        Else
            Me.lblMagneticWiresLocated.Enabled = False
            Me.txtMagneticWiresLocated.Enabled = False
        End If

    End Sub

    Private Sub chkInspectedForLivingTags_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkInspectedForLivingTags.CheckedChanged

        If mbIsLoading Then Exit Sub

        If Me.chkInspectedForLivingTags.Checked Then
            Me.lblLivingTagsLocated.Enabled = True
            Me.txtLivingTagsLocated.Enabled = True
        Else
            Me.lblLivingTagsLocated.Enabled = False
            Me.txtLivingTagsLocated.Enabled = False
        End If

    End Sub

    Private Sub picAcquiredLatitudeLongitudeMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picAcquiredLatitudeLongitudeMap.Click

        Dim oLatLonMapItems As LatLonMapItems
        Dim frm As TurtleGeek.Geo.LatLonMapForm = Nothing

        Try
            oLatLonMapItems = New LatLonMapItems
            oLatLonMapItems.Add(New LatLonMapItem(Convert.ToDouble(Val(Me.txtAcquiredLatitude.Text)), Convert.ToDouble(Val(Me.txtAcquiredLongitude.Text)), Me.txtTurtleName.Text, "Latitude:  " & Me.txtAcquiredLatitude.Text & "<br>Longitude:  " & Me.txtAcquiredLongitude.Text))

            frm = New TurtleGeek.Geo.LatLonMapForm(oLatLonMapItems, Me.Icon, Application.ProductName & " - Latitude/Longitude Map")
            frm.ShowDialog()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            oLatLonMapItems = Nothing

            If Not (frm Is Nothing) Then
                frm.Dispose()
                frm = Nothing
            End If

        End Try

    End Sub

    Private Sub picRelinquishedLatLonMap_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picRelinquishedLatLonMap.Click

        Dim oLatLonMapItems As LatLonMapItems
        Dim frm As TurtleGeek.Geo.LatLonMapForm = Nothing

        Try
            oLatLonMapItems = New LatLonMapItems
            oLatLonMapItems.Add(New LatLonMapItem(Convert.ToDouble(Val(Me.txtRelinquishedLatitude.Text)), Convert.ToDouble(Val(Me.txtRelinquishedLongitude.Text)), Me.txtTurtleName.Text, "Latitude:  " & Me.txtRelinquishedLatitude.Text & "<br>Longitude:  " & Me.txtRelinquishedLongitude.Text))

            frm = New TurtleGeek.Geo.LatLonMapForm(oLatLonMapItems, Me.Icon, Application.ProductName & " - Latitude/Longitude Map")
            frm.ShowDialog()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            oLatLonMapItems = Nothing

            If Not (frm Is Nothing) Then
                frm.Dispose()
                frm = Nothing
            End If

        End Try

    End Sub

    Private Sub lnkAcquiredLatitude_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAcquiredLatitude.LinkClicked
        ShowAcquiredLatitudeConvertToDecimalDegreesForm()
    End Sub

    Private Sub lnkAcquiredLatitude_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkAcquiredLatitude.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                ShowAcquiredLatitudeConvertToDecimalDegreesForm()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub ShowAcquiredLatitudeConvertToDecimalDegreesForm()

        Dim frm As ConvertToDecimalDegreesForm

        Try
            frm = New ConvertToDecimalDegreesForm(My.Resources.app_ico, Application.ProductName, Convert.ToDouble(Val(Me.txtAcquiredLatitude.Text)), LocationType.Latitude)

            If (frm.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                'Me.txtAcquiredLatitude.Text = frm.DecimalDegrees.ToString()
                Me.txtAcquiredLatitude.Text = String.Format("{0:##.00000}", (frm.DecimalDegrees))
                moTurtle.AcquiredLatitudeString = Me.txtAcquiredLatitude.Text
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub lnkAcquiredLongitude_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAcquiredLongitude.LinkClicked
        ShowAcquiredLongitudeConvertToDecimalDegreesForm()
    End Sub

    Private Sub lnkAcquiredLongitude_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkAcquiredLongitude.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                ShowAcquiredLongitudeConvertToDecimalDegreesForm()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub ShowAcquiredLongitudeConvertToDecimalDegreesForm()

        Dim frm As ConvertToDecimalDegreesForm

        Try
            frm = New ConvertToDecimalDegreesForm(My.Resources.app_ico, Application.ProductName, Convert.ToDouble(Val(Me.txtAcquiredLongitude.Text)), LocationType.Longitude)

            If (frm.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                'Me.txtAcquiredLongitude.Text = frm.DecimalDegrees.ToString()
                Me.txtAcquiredLongitude.Text = String.Format("{0:##.00000}", (frm.DecimalDegrees))
                moTurtle.AcquiredLongitudeString = Me.txtAcquiredLongitude.Text
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub lnkRelinquishedLatitude_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkRelinquishedLatitude.LinkClicked
        ShowRelinquishedLatitudeConvertToDecimalDegreesForm()
    End Sub

    Private Sub lnkRelinquishedLatitude_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkRelinquishedLatitude.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                ShowRelinquishedLatitudeConvertToDecimalDegreesForm()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub ShowRelinquishedLatitudeConvertToDecimalDegreesForm()

        Dim frm As ConvertToDecimalDegreesForm

        Try
            frm = New ConvertToDecimalDegreesForm(My.Resources.app_ico, Application.ProductName, Convert.ToDouble(Val(Me.txtRelinquishedLatitude.Text)), LocationType.Latitude)

            If (frm.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                'Me.txtRelinquishedLatitude.Text = frm.DecimalDegrees.ToString()
                Me.txtRelinquishedLatitude.Text = String.Format("{0:##.00000}", (frm.DecimalDegrees))
                moTurtle.RelinquishedLatitudeString = Me.txtRelinquishedLatitude.Text
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub lnkRelinquishedLongitude_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkRelinquishedLongitude.LinkClicked
        ShowRelinquishedLongitudeConvertToDecimalDegreesForm()
    End Sub

    Private Sub lnkRelinquishedLongitude_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkRelinquishedLongitude.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                ShowRelinquishedLongitudeConvertToDecimalDegreesForm()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub ShowRelinquishedLongitudeConvertToDecimalDegreesForm()

        Dim frm As ConvertToDecimalDegreesForm

        Try
            frm = New ConvertToDecimalDegreesForm(My.Resources.app_ico, Application.ProductName, Convert.ToDouble(Val(Me.txtRelinquishedLongitude.Text)), LocationType.Longitude)

            If (frm.ShowDialog() = System.Windows.Forms.DialogResult.OK) Then
                'Me.txtRelinquishedLongitude.Text = frm.DecimalDegrees.ToString()
                Me.txtRelinquishedLongitude.Text = String.Format("{0:##.00000}", (frm.DecimalDegrees))
                moTurtle.RelinquishedLongitudeString = Me.txtRelinquishedLongitude.Text
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub lnkAcquiredCounty_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAcquiredCounty.LinkClicked
        AddAcquiredCounty()
    End Sub

    Private Sub lnkAcquiredCounty_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkAcquiredCounty.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                AddAcquiredCounty()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub AddAcquiredCounty()

        Dim frm As CountyEditForm = Nothing

        Try
            frm = New CountyEditForm(County.NewCounty())

            frm.ShowDialog(Me)

            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                Me.cboAcquiredCountyList.DataSource = CountyList.GetList(True)
                Me.cboAcquiredCountyList.Text = frm.County.CountyName

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

    Private Sub lnkRelinquishedCounty_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkRelinquishedCounty.LinkClicked
        AddRelinquishedCounty()
    End Sub

    Private Sub lnkRelinquishedCounty_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkRelinquishedCounty.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                AddRelinquishedCounty()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub AddRelinquishedCounty()

        Dim frm As CountyEditForm = Nothing

        Try
            frm = New CountyEditForm(County.NewCounty())

            frm.ShowDialog(Me)

            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                Me.cboRelinquishedCountyList.DataSource = CountyList.GetList(True)
                Me.cboRelinquishedCountyList.Text = frm.County.CountyName

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

#End Region

#Region " Turtle Tags "

    Private Sub LoadTurtleTagGridData()

        Dim oSortedBindingList As Csla.SortedBindingList(Of TurtleTag)

        Try
            Cursor.Current = Cursors.WaitCursor

            oSortedBindingList = New Csla.SortedBindingList(Of TurtleTag)(moTurtle.TurtleTags)

            If String.IsNullOrEmpty(msTagSortedColumnPropertyName) Then
                msTagSortedColumnPropertyName = "TagNumber"
            End If

            oSortedBindingList.ApplySort(msTagSortedColumnPropertyName, moListSortDirection)

            Me.grdTurtleTagGrid.DataSource = oSortedBindingList

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnAddTag_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTag.Click

        CreateTurtleTag()

    End Sub

    Private Sub CreateTurtleTag()

        Dim frm As TurtleTagInformationDlg = Nothing

        Try
            '----------------------------------------------------------------
            '-- instantiate and display the edit form
            '----------------------------------------------------------------
            frm = New TurtleTagInformationDlg(TurtleTag.NewTurtleTag())
            frm.ShowDialog(Me)

            '----------------------------------------------------------------
            '-- if the user chose to save the child object, 
            '-- then add the child object to the parent object's collection
            '----------------------------------------------------------------
            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                '-- this updates the parent object (which will handle the update of the child)
                moTurtle.TurtleTags.Add(frm.TurtleTag)

                '-- this updates the grid
                LoadTurtleTagGridData()

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

    Private Sub EditTurtleTag()

        Dim sTurtleTagID As String = String.Empty
        Dim frm As TurtleTagInformationDlg = Nothing

        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdTurtleTagGrid.SelectedRows.Count > 0) Then

                sTurtleTagID = Convert.ToString(grdTurtleTagGrid.SelectedRows(0).Cells(Me.colTagTurtleTagIDDataGridViewTextBoxColumn.Name).Value)

                '----------------------------------------------------------------
                '-- instantiate and display the edit form
                '----------------------------------------------------------------
                frm = New TurtleTagInformationDlg(moTurtle.TurtleTags.GetItem(sTurtleTagID))

                frm.ShowDialog(Me)

                '-- if okay, save and continue
                If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                    LoadTurtleTagGridData()

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

    Private Sub DeleteTurtleTag()

        Dim sTurtleTagID As String = String.Empty

        Try
            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdTurtleTagGrid.SelectedRows.Count > 0) Then

                sTurtleTagID = Convert.ToString(grdTurtleTagGrid.SelectedRows(0).Cells(Me.colTagTurtleTagIDDataGridViewTextBoxColumn.Name).Value)

                If (MessageBox.Show("Are you sure you want to delete the tag information for '" & Convert.ToString(grdTurtleTagGrid.SelectedRows(0).Cells(Me.colTagTagNumberDataGridViewTextBoxColumn.Name).Value) & "' from this turtle record?  This is a permanent action and CANNOT be undone.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then

                    '-- this updates the parent object (which will handle the deletion of the child)
                    moTurtle.TurtleTags.Remove(sTurtleTagID)

                    '-- this updates the grid
                    LoadTurtleTagGridData()

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub grdTurtleTagGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdTurtleTagGrid.CellClick

        Try

            '----------------------------------------------------------------
            '-- handle the EDIT or DELETE command
            '----------------------------------------------------------------
            If (e.RowIndex > -1) Then
                If Me.grdTurtleTagGrid.Columns(e.ColumnIndex).Name.Equals(Me.colTagEditActionDataGridViewLinkColumn.Name) Then
                    EditTurtleTag()
                ElseIf Me.grdTurtleTagGrid.Columns(e.ColumnIndex).Name.Equals(Me.colTagDeleteActionDataGridViewLinkColumn.Name) Then
                    DeleteTurtleTag()
                End If
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub grdTurtleTagGrid_ColumnDividerDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventArgs) Handles grdTurtleTagGrid.ColumnDividerDoubleClick

        If ((Me.grdTurtleTagGrid.Columns(e.ColumnIndex).Visible) AndAlso (Not Me.grdTurtleTagGrid.Columns(e.ColumnIndex).Frozen)) Then
            Me.grdTurtleTagGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Me.grdTurtleTagGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        End If

    End Sub

    Private Sub grdTurtleTagGrid_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdTurtleTagGrid.ColumnHeaderMouseClick

        Try

            '----------------------------------------------------------------
            '-- if we are re-sorting the same column, save the order
            '----------------------------------------------------------------
            If (String.Compare(msTagSortedColumnPropertyName, Me.grdTurtleTagGrid.Columns(e.ColumnIndex).DataPropertyName) = 0) Then
                If Me.grdTurtleTagGrid.SortOrder = SortOrder.Ascending Then
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

            msTagSortedColumnPropertyName = Me.grdTurtleTagGrid.Columns(e.ColumnIndex).DataPropertyName

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub grdTurtleTagDataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTurtleTagGrid.DoubleClick

        Dim oPoint As Point = Me.grdTurtleTagGrid.PointToClient(Cursor.Position)
        Dim oHitTestInfo As DataGridView.HitTestInfo = Me.grdTurtleTagGrid.HitTest(oPoint.X, oPoint.Y)

        '----------------------------------------------------------------
        '-- only edit the record if a data row cell was double-clicked
        '-- (we do this to allow a double click of the column separator to resize the column)
        '----------------------------------------------------------------
        If (oHitTestInfo.Type = DataGridViewHitTestType.Cell) Then
            EditTurtleTag()
        End If

    End Sub

#End Region

#Region " Turtle Morphometrics "

    Private Sub LoadTurtleMorphometricGridData()

        Dim oSortedBindingList As Csla.SortedBindingList(Of TurtleMorphometric)

        Try
            Cursor.Current = Cursors.WaitCursor

            oSortedBindingList = New Csla.SortedBindingList(Of TurtleMorphometric)(moTurtle.TurtleMorphometrics)

            If String.IsNullOrEmpty(msMorphometricsSortedColumnPropertyName) Then
                msMorphometricsSortedColumnPropertyName = "DateMeasuredBindable"
            End If

            oSortedBindingList.ApplySort(msMorphometricsSortedColumnPropertyName, moListSortDirection)

            Me.grdTurtleMorphometricGrid.DataSource = oSortedBindingList

            RefreshMorphometricsGraph()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnAddMorphometric_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddMorphometric.Click

        CreateTurtleMorphometric()

    End Sub

    Private Sub CreateTurtleMorphometric()

        Dim frm As TurtleMorphometricInformationDlg = Nothing

        Try
            '----------------------------------------------------------------
            '-- instantiate and display the edit form
            '----------------------------------------------------------------
            frm = New TurtleMorphometricInformationDlg(TurtleMorphometric.NewTurtleMorphometric())
            frm.ShowDialog(Me)

            '----------------------------------------------------------------
            '-- if the user chose to save the child object, 
            '-- then add the child object to the parent object's collection
            '----------------------------------------------------------------
            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                '-- this updates the parent object (which will handle the update of the child)
                moTurtle.TurtleMorphometrics.Add(frm.TurtleMorphometric)

                '-- this updates the grid
                LoadTurtleMorphometricGridData()

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

    Private Sub EditTurtleMorphometric()

        Dim sTurtleMorphometricID As String = String.Empty
        Dim frm As TurtleMorphometricInformationDlg = Nothing

        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdTurtleMorphometricGrid.SelectedRows.Count > 0) Then

                sTurtleMorphometricID = Convert.ToString(grdTurtleMorphometricGrid.SelectedRows(0).Cells(Me.colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn.Name).Value)

                '----------------------------------------------------------------
                '-- instantiate and display the edit form
                '----------------------------------------------------------------
                frm = New TurtleMorphometricInformationDlg(moTurtle.TurtleMorphometrics.GetItem(sTurtleMorphometricID))

                frm.ShowDialog(Me)

                '-- if okay, save and continue
                If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                    LoadTurtleMorphometricGridData()

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

    Private Sub DeleteTurtleMorphometric()

        Dim sTurtleMorphometricID As String = String.Empty

        Try
            '----------------------------------------------------------------
            '-- if an item is selected...
            '----------------------------------------------------------------
            If (grdTurtleMorphometricGrid.SelectedRows.Count > 0) Then

                sTurtleMorphometricID = Convert.ToString(grdTurtleMorphometricGrid.SelectedRows(0).Cells(Me.colMorphometricTurtleMorphometricIDDataGridViewTextBoxColumn.Name).Value)

                If (MessageBox.Show("Are you sure you want to delete the morphometric information for '" & Convert.ToString(grdTurtleMorphometricGrid.SelectedRows(0).Cells(Me.colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn.Name).FormattedValue) & "' from this turtle record?  This is a permanent action and CANNOT be undone.", Application.ProductName, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then

                    '-- this updates the parent object (which will handle the deletion of the child)
                    moTurtle.TurtleMorphometrics.Remove(sTurtleMorphometricID)

                    '-- this updates the grid
                    LoadTurtleMorphometricGridData()

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub grdTurtleMorphometricGrid_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdTurtleMorphometricGrid.CellClick

        Try

            '----------------------------------------------------------------
            '-- handle the EDIT or DELETE command
            '----------------------------------------------------------------
            If (e.RowIndex > -1) Then
                If Me.grdTurtleMorphometricGrid.Columns(e.ColumnIndex).Name.Equals(Me.colMorphometricEditActionDataGridViewLinkColumn.Name) Then
                    EditTurtleMorphometric()
                ElseIf Me.grdTurtleMorphometricGrid.Columns(e.ColumnIndex).Name.Equals(Me.colMorphometricDeleteActionDataGridViewLinkColumn.Name) Then
                    DeleteTurtleMorphometric()
                End If
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub grdTurtleMorphometricGrid_ColumnDividerDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventArgs) Handles grdTurtleMorphometricGrid.ColumnDividerDoubleClick

        If ((Me.grdTurtleMorphometricGrid.Columns(e.ColumnIndex).Visible) AndAlso (Not Me.grdTurtleMorphometricGrid.Columns(e.ColumnIndex).Frozen)) Then
            Me.grdTurtleMorphometricGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Me.grdTurtleMorphometricGrid.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        End If

    End Sub

    Private Sub grdTurtleMorphometricGrid_ColumnHeaderMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles grdTurtleMorphometricGrid.ColumnHeaderMouseClick

        Try

            '----------------------------------------------------------------
            '-- if we are re-sorting the same column, save the order
            '----------------------------------------------------------------
            If (String.Compare(msMorphometricsSortedColumnPropertyName, Me.grdTurtleMorphometricGrid.Columns(e.ColumnIndex).DataPropertyName) = 0) Then
                If Me.grdTurtleMorphometricGrid.SortOrder = SortOrder.Ascending Then
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

            msMorphometricsSortedColumnPropertyName = Me.grdTurtleMorphometricGrid.Columns(e.ColumnIndex).DataPropertyName

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub grdTurtleMorphometricDataGrid_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTurtleMorphometricGrid.DoubleClick

        Dim oPoint As Point = Me.grdTurtleMorphometricGrid.PointToClient(Cursor.Position)
        Dim oHitTestInfo As DataGridView.HitTestInfo = Me.grdTurtleMorphometricGrid.HitTest(oPoint.X, oPoint.Y)

        '----------------------------------------------------------------
        '-- only edit the record if a data row cell was double-clicked
        '-- (we do this to allow a double click of the column separator to resize the column)
        '----------------------------------------------------------------
        If (oHitTestInfo.Type = DataGridViewHitTestType.Cell) Then
            EditTurtleMorphometric()
        End If

    End Sub

    Private Sub RefreshMorphometricsGraph()

        '****************************************************************
        '-- load the GRAPHS
        '****************************************************************
        Dim i As Integer
        Dim oSortedBindingListForGraph As Csla.SortedBindingList(Of TurtleMorphometric)
        Dim oLegend As Legend

        Dim oSclNotchNotchLinePlot As LinePlot = New LinePlot
        Dim oSclNotchNotchXData As ArrayList = New ArrayList
        Dim oSclNotchNotchYData As ArrayList = New ArrayList

        Dim oSclNotchTipLinePlot As LinePlot = New LinePlot
        Dim oSclNotchTipXData As ArrayList = New ArrayList
        Dim oSclNotchTipYData As ArrayList = New ArrayList

        Dim oSclTipTipLinePlot As LinePlot = New LinePlot
        Dim oSclTipTipXData As ArrayList = New ArrayList
        Dim oSclTipTipYData As ArrayList = New ArrayList

        Dim oScwLinePlot As LinePlot = New LinePlot
        Dim oScwXData As ArrayList = New ArrayList
        Dim oScwYData As ArrayList = New ArrayList

        Dim oCclNotchNotchLinePlot As LinePlot = New LinePlot
        Dim oCclNotchNotchXData As ArrayList = New ArrayList
        Dim oCclNotchNotchYData As ArrayList = New ArrayList

        Dim oCclNotchTipLinePlot As LinePlot = New LinePlot
        Dim oCclNotchTipXData As ArrayList = New ArrayList
        Dim oCclNotchTipYData As ArrayList = New ArrayList

        Dim oCclTipTipLinePlot As LinePlot = New LinePlot
        Dim oCclTipTipXData As ArrayList = New ArrayList
        Dim oCclTipTipYData As ArrayList = New ArrayList

        Dim oCcwLinePlot As LinePlot = New LinePlot
        Dim oCcwXData As ArrayList = New ArrayList
        Dim oCcwYData As ArrayList = New ArrayList

        Dim oWeightLinePlot As LinePlot = New LinePlot
        Dim oWeightXData As ArrayList = New ArrayList
        Dim oWeightYData As ArrayList = New ArrayList

        Try

            If moTurtle.TurtleMorphometrics Is Nothing Then Exit Sub

            oSortedBindingListForGraph = New Csla.SortedBindingList(Of TurtleMorphometric)(moTurtle.TurtleMorphometrics)
            oSortedBindingListForGraph.ApplySort("DateMeasured", System.ComponentModel.ListSortDirection.Ascending)

            graphMorphometrics.Clear()
            graphMorphometrics.Title = "Morphometrics Graph"
            graphMorphometrics.BackColor = Color.Empty

            '----------------------------------------------------------------
            '-- SCL NOTCH-NOTCH GRAPH
            '----------------------------------------------------------------
            If Me.chkGraphSclNotchNotch.Checked Then

                oSclNotchNotchXData.Clear()
                oSclNotchNotchYData.Clear()

                For i = 0 To oSortedBindingListForGraph.Count - 1
                    If (oSortedBindingListForGraph(i).SclNotchNotchValue > 0) Then
                        oSclNotchNotchXData.Add(oSortedBindingListForGraph(i).DateMeasured)
                        oSclNotchNotchYData.Add(oSortedBindingListForGraph(i).SclNotchNotchValue)
                    End If
                Next

                If (oSclNotchNotchXData.Count > 0) Then

                    oSclNotchNotchLinePlot.AbscissaData = oSclNotchNotchXData
                    oSclNotchNotchLinePlot.DataSource = oSclNotchNotchYData
                    oSclNotchNotchLinePlot.Color = Color.LightCoral
                    oSclNotchNotchLinePlot.Label = "SCL notch-notch"
                    graphMorphometrics.Add(oSclNotchNotchLinePlot)

                    graphMorphometrics.XAxis1.Label = "Date"
                    graphMorphometrics.YAxis1.Label = "Measurement"

                End If

            End If

            '----------------------------------------------------------------
            '-- SCL NOTCH-TIP GRAPH
            '----------------------------------------------------------------
            If Me.chkGraphSclNotchTip.Checked Then

                oSclNotchTipXData.Clear()
                oSclNotchTipYData.Clear()

                For i = 0 To oSortedBindingListForGraph.Count - 1
                    If (oSortedBindingListForGraph(i).SclNotchTipValue > 0) Then
                        oSclNotchTipXData.Add(oSortedBindingListForGraph(i).DateMeasured)
                        oSclNotchTipYData.Add(oSortedBindingListForGraph(i).SclNotchTipValue)
                    End If
                Next

                If (oSclNotchTipXData.Count > 0) Then

                    oSclNotchTipLinePlot.AbscissaData = oSclNotchTipXData
                    oSclNotchTipLinePlot.DataSource = oSclNotchTipYData
                    oSclNotchTipLinePlot.Color = Color.Red
                    oSclNotchTipLinePlot.Label = "SCL notch-tip"
                    graphMorphometrics.Add(oSclNotchTipLinePlot)

                    graphMorphometrics.XAxis1.Label = "Date"
                    graphMorphometrics.YAxis1.Label = "Measurement"

                End If

            End If

            '----------------------------------------------------------------
            '-- SCL TIP-TIP GRAPH
            '----------------------------------------------------------------
            If Me.chkGraphSclTipTip.Checked Then

                oSclTipTipXData.Clear()
                oSclTipTipYData.Clear()

                For i = 0 To oSortedBindingListForGraph.Count - 1
                    If (oSortedBindingListForGraph(i).SclTipTipValue > 0) Then
                        oSclTipTipXData.Add(oSortedBindingListForGraph(i).DateMeasured)
                        oSclTipTipYData.Add(oSortedBindingListForGraph(i).SclTipTipValue)
                    End If
                Next

                If (oSclTipTipXData.Count > 0) Then

                    oSclTipTipLinePlot.AbscissaData = oSclTipTipXData
                    oSclTipTipLinePlot.DataSource = oSclTipTipYData
                    oSclTipTipLinePlot.Color = Color.DarkRed
                    oSclTipTipLinePlot.Label = "SCL tip-tip"
                    graphMorphometrics.Add(oSclTipTipLinePlot)

                    graphMorphometrics.XAxis1.Label = "Date"
                    graphMorphometrics.YAxis1.Label = "Measurement"

                End If

            End If

            '----------------------------------------------------------------
            '-- SCW GRAPH
            '----------------------------------------------------------------
            If Me.chkGraphScw.Checked Then

                oScwXData.Clear()
                oScwYData.Clear()

                For i = 0 To oSortedBindingListForGraph.Count - 1
                    If (oSortedBindingListForGraph(i).ScwValue > 0) Then
                        oScwXData.Add(oSortedBindingListForGraph(i).DateMeasured)
                        oScwYData.Add(oSortedBindingListForGraph(i).ScwValue)
                    End If
                Next

                If (oScwXData.Count > 0) Then

                    oScwLinePlot.AbscissaData = oScwXData
                    oScwLinePlot.DataSource = oScwYData
                    oScwLinePlot.Color = Color.DarkOrange
                    oScwLinePlot.Label = "SCW"
                    graphMorphometrics.Add(oScwLinePlot)

                    graphMorphometrics.XAxis1.Label = "Date"
                    graphMorphometrics.YAxis1.Label = "Measurement"

                End If

            End If

            '----------------------------------------------------------------
            '-- CCL NOTCH-NOTCH GRAPH
            '----------------------------------------------------------------
            If Me.chkGraphCclNotchNotch.Checked Then

                oCclNotchNotchXData.Clear()
                oCclNotchNotchYData.Clear()

                For i = 0 To oSortedBindingListForGraph.Count - 1
                    If (oSortedBindingListForGraph(i).CclNotchNotchValue > 0) Then
                        oCclNotchNotchXData.Add(oSortedBindingListForGraph(i).DateMeasured)
                        oCclNotchNotchYData.Add(oSortedBindingListForGraph(i).CclNotchNotchValue)
                    End If
                Next

                If (oCclNotchNotchXData.Count > 0) Then

                    oCclNotchNotchLinePlot.AbscissaData = oCclNotchNotchXData
                    oCclNotchNotchLinePlot.DataSource = oCclNotchNotchYData
                    oCclNotchNotchLinePlot.Color = Color.LightGreen
                    oCclNotchNotchLinePlot.Label = "CCL notch-notch"
                    graphMorphometrics.Add(oCclNotchNotchLinePlot)

                    graphMorphometrics.XAxis1.Label = "Date"
                    graphMorphometrics.YAxis1.Label = "Measurement"

                End If

            End If

            '----------------------------------------------------------------
            '-- CCL NOTCH-TIP GRAPH
            '----------------------------------------------------------------
            If Me.chkGraphCclNotchTip.Checked Then

                oCclNotchTipXData.Clear()
                oCclNotchTipYData.Clear()

                For i = 0 To oSortedBindingListForGraph.Count - 1
                    If (oSortedBindingListForGraph(i).CclNotchTipValue > 0) Then
                        oCclNotchTipXData.Add(oSortedBindingListForGraph(i).DateMeasured)
                        oCclNotchTipYData.Add(oSortedBindingListForGraph(i).CclNotchTipValue)
                    End If
                Next

                If (oCclNotchTipXData.Count > 0) Then

                    oCclNotchTipLinePlot.AbscissaData = oCclNotchTipXData
                    oCclNotchTipLinePlot.DataSource = oCclNotchTipYData
                    oCclNotchTipLinePlot.Color = Color.LimeGreen
                    oCclNotchTipLinePlot.Label = "CCL notch-tip"
                    graphMorphometrics.Add(oCclNotchTipLinePlot)

                    graphMorphometrics.XAxis1.Label = "Date"
                    graphMorphometrics.YAxis1.Label = "Measurement"

                End If

            End If

            '----------------------------------------------------------------
            '-- CCL TIP-TIP GRAPH
            '----------------------------------------------------------------
            If Me.chkGraphCclTipTip.Checked Then

                oCclTipTipXData.Clear()
                oCclTipTipYData.Clear()

                For i = 0 To oSortedBindingListForGraph.Count - 1
                    If (oSortedBindingListForGraph(i).CclTipTipValue > 0) Then
                        oCclTipTipXData.Add(oSortedBindingListForGraph(i).DateMeasured)
                        oCclTipTipYData.Add(oSortedBindingListForGraph(i).CclTipTipValue)
                    End If
                Next

                If (oCclTipTipXData.Count > 0) Then

                    oCclTipTipLinePlot.AbscissaData = oCclTipTipXData
                    oCclTipTipLinePlot.DataSource = oCclTipTipYData
                    oCclTipTipLinePlot.Color = Color.DarkGreen
                    oCclTipTipLinePlot.Label = "CCL tip-tip"
                    graphMorphometrics.Add(oCclTipTipLinePlot)

                    graphMorphometrics.XAxis1.Label = "Date"
                    graphMorphometrics.YAxis1.Label = "Measurement"

                End If

            End If

            '----------------------------------------------------------------
            '-- CCW GRAPH
            '----------------------------------------------------------------
            If Me.chkGraphCcw.Checked Then

                oCcwXData.Clear()
                oCcwYData.Clear()

                For i = 0 To oSortedBindingListForGraph.Count - 1
                    If (oSortedBindingListForGraph(i).CcwValue > 0) Then
                        oCcwXData.Add(oSortedBindingListForGraph(i).DateMeasured)
                        oCcwYData.Add(oSortedBindingListForGraph(i).CcwValue)
                    End If
                Next

                If (oCcwXData.Count > 0) Then

                    oCcwLinePlot.AbscissaData = oCcwXData
                    oCcwLinePlot.DataSource = oCcwYData
                    oCcwLinePlot.Color = Color.MediumTurquoise
                    oCcwLinePlot.Label = "CCW"
                    graphMorphometrics.Add(oCcwLinePlot)

                    graphMorphometrics.XAxis1.Label = "Date"
                    graphMorphometrics.YAxis1.Label = "Measurement"

                End If

            End If

            '----------------------------------------------------------------
            '-- WEIGHT GRAPH
            '----------------------------------------------------------------
            If Me.chkGraphWeight.Checked Then

                oWeightXData.Clear()
                oWeightYData.Clear()

                For i = 0 To oSortedBindingListForGraph.Count - 1
                    If (oSortedBindingListForGraph(i).WeightValue > 0) Then
                        oWeightXData.Add(oSortedBindingListForGraph(i).DateMeasured)
                        oWeightYData.Add(oSortedBindingListForGraph(i).WeightValue)
                    End If
                Next

                If (oWeightXData.Count > 0) Then

                    oWeightLinePlot.AbscissaData = oWeightXData
                    oWeightLinePlot.DataSource = oWeightYData
                    oWeightLinePlot.Color = Color.Violet
                    oWeightLinePlot.Label = "Weight"
                    graphMorphometrics.Add(oWeightLinePlot)

                    graphMorphometrics.XAxis1.Label = "Date"
                    graphMorphometrics.YAxis1.Label = "Measurement"

                End If

            End If

            '----------------------------------------------------------------
            '-- GRAPH LEGEND
            '----------------------------------------------------------------
            oLegend = New Legend()
            oLegend.AttachTo(TurtleGeek.Graphics.PlotSurface2D.XAxisPosition.Top, TurtleGeek.Graphics.PlotSurface2D.YAxisPosition.Left)
            oLegend.VerticalEdgePlacement = Legend.Placement.Inside
            oLegend.HorizontalEdgePlacement = Legend.Placement.Inside
            oLegend.YOffset = 8

            graphMorphometrics.Legend = oLegend
            graphMorphometrics.LegendZOrder = 1 '// default zorder for adding idrawables is 0, so this puts legend on top.

            graphMorphometrics.Refresh()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub chkGraphSclNotchNotch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGraphSclNotchNotch.CheckedChanged
        If mbIsLoading Then Exit Sub
        RefreshMorphometricsGraph()
    End Sub

    Private Sub chkGraphSclNotchTip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGraphSclNotchTip.CheckedChanged
        If mbIsLoading Then Exit Sub
        RefreshMorphometricsGraph()
    End Sub

    Private Sub chkGraphSclTipTip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGraphSclTipTip.CheckedChanged
        If mbIsLoading Then Exit Sub
        RefreshMorphometricsGraph()
    End Sub

    Private Sub chkGraphScw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGraphScw.CheckedChanged
        If mbIsLoading Then Exit Sub
        RefreshMorphometricsGraph()
    End Sub

    Private Sub chkGraphCclNotchNotch_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGraphCclNotchNotch.CheckedChanged
        If mbIsLoading Then Exit Sub
        RefreshMorphometricsGraph()
    End Sub

    Private Sub chkGraphCclNotchTip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGraphCclNotchTip.CheckedChanged
        If mbIsLoading Then Exit Sub
        RefreshMorphometricsGraph()
    End Sub

    Private Sub chkGraphCclTipTip_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGraphCclTipTip.CheckedChanged
        If mbIsLoading Then Exit Sub
        RefreshMorphometricsGraph()
    End Sub

    Private Sub chkGraphCcw_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGraphCcw.CheckedChanged
        If mbIsLoading Then Exit Sub
        RefreshMorphometricsGraph()
    End Sub

    Private Sub chkGraphWeight_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkGraphWeight.CheckedChanged
        If mbIsLoading Then Exit Sub
        RefreshMorphometricsGraph()
    End Sub

    Private Sub lnkPrintMorphometricsGraph_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkPrintMorphometricsGraph.LinkClicked
        PrintMorphometricsGraph()
    End Sub

    Private Sub lnkPrintMorphometricsGraph_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkPrintMorphometricsGraph.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                PrintMorphometricsGraph()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub PrintMorphometricsGraph()
        Me.graphMorphometrics.Print(True, Me.Icon, "ROSTER - Morphometrics Graph")
    End Sub

    Private Sub lnkCopyToClipboardMorphometricsGraph_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCopyToClipboardMorphometricsGraph.LinkClicked
        Me.graphMorphometrics.CopyToClipboard()
        MessageBox.Show("Graph copied to clipboard", My.Application.Info.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub lnkCopyToClipboardMorphometricsGraph_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkCopyToClipboardMorphometricsGraph.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                AddAcquiredCounty()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

#End Region

#Region " Turtle Attachments "

    Private Sub LoadTurtleAttachmentGridData()

        Dim oSortedBindingList As Csla.SortedBindingList(Of TurtleFileAttachment)

        Try
            Cursor.Current = Cursors.WaitCursor

            oSortedBindingList = New Csla.SortedBindingList(Of TurtleFileAttachment)(moTurtle.FileAttachments)
            oSortedBindingList.ApplySort("DateCreated", System.ComponentModel.ListSortDirection.Ascending)

            Me.TurtleAttachmentGridBindingSource.DataSource = oSortedBindingList

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

        '----------------------------------------------------------------------
        '-- set status of DELETE ALL ATTACHMENTS button
        '----------------------------------------------------------------------
        Me.btnDeleteAllTurtleFileAttachments.Enabled = (moTurtle.FileAttachments.Count > 0)

    End Sub

    Private Sub ViewAttachment()

        Dim sFullFileName As String = String.Empty

        Try

            If (Me.grdTurtleFileAttachmentList.SelectedRows.Count > 0) Then

                sFullFileName = Convert.ToString(Me.grdTurtleFileAttachmentList.SelectedRows(0).Cells(Me.colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn.Name).Value)

                '----------------------------------------------------------------------
                '-- shell out the attachment file name;
                '-- we are depending on Windows to launch the application 
                '-- that is associated with the extension of the attachment file name
                '----------------------------------------------------------------------
                If File.Exists(sFullFileName) Then
                    Process.Start(sFullFileName)
                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub DeleteAttachment()

        Dim sTurtleFileAttachmentId As String = String.Empty

        Try

            If (Me.grdTurtleFileAttachmentList.SelectedRows.Count > 0) Then

                '----------------------------------------------------------------
                '-- prompt user to confirm deletion of selected attachment
                '-- from our storage location (NOT the original file)
                '----------------------------------------------------------------
                If (MessageBox.Show("Delete this attachment?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then

                    sTurtleFileAttachmentId = Convert.ToString(Me.grdTurtleFileAttachmentList.SelectedRows(0).Cells(Me.colTurtleFileAttachmentIdDataGridViewTextBoxColumn.Name).Value)

                    '----------------------------------------------------------------
                    '-- delete the selected attachment
                    '----------------------------------------------------------------
                    moTurtle.FileAttachments.Remove(sTurtleFileAttachmentId)

                    '----------------------------------------------------------------
                    '-- refresh the attachment list
                    '----------------------------------------------------------------
                    LoadTurtleAttachmentGridData()

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub CopyAttachment()

        Dim sBaseFileName As String = String.Empty
        Dim sFullFileName As String = String.Empty
        Dim sCopyToFullFileName As String = String.Empty
        Dim oSaveFileDialog As SaveFileDialog = Nothing

        Try

            If (Me.grdTurtleFileAttachmentList.SelectedRows.Count > 0) Then

                sFullFileName = Convert.ToString(Me.grdTurtleFileAttachmentList.SelectedRows(0).Cells(Me.colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn.Name).Value)
                sBaseFileName = Convert.ToString(Me.grdTurtleFileAttachmentList.SelectedRows(0).Cells(Me.colTurtleFileAttachmentBaseFileNameDataGridViewTextBoxColumn.Name).Value)

                '----------------------------------------------------------------------
                '-- shell out the attachment file name;
                '-- we are depending on Windows to launch the application 
                '-- that is associated with the extension of the attachment file name
                '----------------------------------------------------------------------
                If File.Exists(sFullFileName) Then

                    '----------------------------------------------------------------
                    '-- prompt user to indicate the location to copy the attachment to
                    '----------------------------------------------------------------
                    oSaveFileDialog = New SaveFileDialog()

                    oSaveFileDialog.Title = "Copy Attachment To"
                    oSaveFileDialog.FileName = sBaseFileName
                    oSaveFileDialog.Filter = "All Files (*.*)|*.*"
                    oSaveFileDialog.CheckPathExists = True
                    oSaveFileDialog.OverwritePrompt = True
                    oSaveFileDialog.ValidateNames = True

                    '----------------------------------------------------------------
                    '-- if the user selected one or more files to attach...
                    '----------------------------------------------------------------
                    If (oSaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then

                        Cursor.Current = Cursors.WaitCursor

                        sCopyToFullFileName = oSaveFileDialog.FileName

                        '----------------------------------------------------------------
                        '-- copy the selected file
                        '----------------------------------------------------------------
                        File.Copy(sFullFileName, sCopyToFullFileName, True)

                    End If

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub btnAddTurtleFileAttachment_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddTurtleFileAttachment.Click

        Dim sFileName As String = String.Empty
        Dim sFileNames() As String
        Dim oOpenFileDialog As OpenFileDialog = Nothing
        Dim oTurtleFileAttachment As TurtleFileAttachment

        Try

            '----------------------------------------------------------------
            '-- prompt user to select one or more files to "attach"
            '-- to this turtle record; we copy the file from the original location 
            '-- to our storage location (.exe folder -> turtle_id -> attachment_id -> filename.ext)
            '----------------------------------------------------------------
            oOpenFileDialog = New OpenFileDialog()

            oOpenFileDialog.Title = "Select File(s) To Attach To This Turtle Record"
            oOpenFileDialog.Multiselect = True

            '----------------------------------------------------------------
            '-- if the user selected one or more files to attach...
            '----------------------------------------------------------------
            If (oOpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then

                Cursor.Current = Cursors.WaitCursor

                sFileNames = oOpenFileDialog.FileNames

                '----------------------------------------------------------------
                '-- add each file name to our collection
                '----------------------------------------------------------------
                For Each sFileName In sFileNames

                    oTurtleFileAttachment = moTurtle.FileAttachments.CreateNew()

                    oTurtleFileAttachment.FullFileName = sFileName

                    moTurtle.FileAttachments.Add(oTurtleFileAttachment)

                Next

                '----------------------------------------------------------------
                '-- refresh the attachment list
                '----------------------------------------------------------------
                LoadTurtleAttachmentGridData()

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            If oOpenFileDialog IsNot Nothing Then
                oOpenFileDialog.Dispose()
                oOpenFileDialog = Nothing
            End If

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub grdTurtleFileAttachmentList_DragDrop(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grdTurtleFileAttachmentList.DragDrop

        Dim sFileNamesArray As String()
        Dim oTurtleFileAttachment As TurtleFileAttachment

        Try
            sFileNamesArray = DirectCast(e.Data.GetData(DataFormats.FileDrop), String())

            For Each sFileName As String In sFileNamesArray

                If File.Exists(sFileName) AndAlso Not Directory.Exists(sFileName) Then

                    oTurtleFileAttachment = moTurtle.FileAttachments.CreateNew()

                    oTurtleFileAttachment.FullFileName = sFileName

                    moTurtle.FileAttachments.Add(oTurtleFileAttachment)

                End If

            Next

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub grdTurtleFileAttachmentList_DragEnter(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles grdTurtleFileAttachmentList.DragEnter

        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        Else
            e.Effect = DragDropEffects.None
        End If

    End Sub

    Private Sub btnDeleteAllTurtleFileAttachments_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDeleteAllTurtleFileAttachments.Click

        Dim i As Integer

        Try
            '----------------------------------------------------------------
            '-- if we have any attachments...
            '----------------------------------------------------------------
            If (moTurtle.FileAttachments.Count > 0) Then

                '----------------------------------------------------------------
                '-- prompt user to confirm deletion of selected attachment
                '-- from our storage location (NOT the original file)
                '----------------------------------------------------------------
                If (MessageBox.Show("Delete all attachments associated with this turtle record?", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question) = System.Windows.Forms.DialogResult.Yes) Then

                    Cursor.Current = Cursors.WaitCursor

                    '----------------------------------------------------------------
                    '-- delete each attachment in our collection
                    '----------------------------------------------------------------
                    For i = moTurtle.FileAttachments.Count - 1 To 0 Step -1

                        moTurtle.FileAttachments.RemoveAt(0)

                    Next

                    '----------------------------------------------------------------
                    '-- refresh the attachment list
                    '----------------------------------------------------------------
                    LoadTurtleAttachmentGridData()

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub grdTurtleFileAttachmentList_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdTurtleFileAttachmentList.CellContentClick

        Try

            If (TypeOf (Me.grdTurtleFileAttachmentList.Columns(e.ColumnIndex)) Is DataGridViewLinkColumn) AndAlso (e.RowIndex > -1) Then

                If (Convert.ToString(Me.grdTurtleFileAttachmentList.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) = "view") Then
                    ViewAttachment()
                ElseIf (Convert.ToString(Me.grdTurtleFileAttachmentList.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) = "delete") Then
                    DeleteAttachment()
                ElseIf (Convert.ToString(Me.grdTurtleFileAttachmentList.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) = "copy to") Then
                    CopyAttachment()
                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub grdTurtleFileAttachmentList_SelectionChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdTurtleFileAttachmentList.SelectionChanged

        PreviewAttachment()

    End Sub

    Private Sub PreviewAttachment()

        Dim sFileAttachmentId As String = String.Empty
        Dim sFullFileName As String = String.Empty

        Try

            If (Me.grdTurtleFileAttachmentList.SelectedRows.Count > 0) Then

                sFileAttachmentId = Convert.ToString(Me.grdTurtleFileAttachmentList.SelectedRows(0).Cells(Me.colTurtleFileAttachmentIdDataGridViewTextBoxColumn.Name).Value)
                sFullFileName = Convert.ToString(Me.grdTurtleFileAttachmentList.SelectedRows(0).Cells(Me.colTurtleFileAttachmentFullFileNameDataGridViewTextBoxColumn.Name).Value)

                '----------------------------------------------------------------------
                '-- if the file exists and it is a supported image format file, 
                '-- then load the image into the preview picture box
                '----------------------------------------------------------------------
                If File.Exists(sFullFileName) _
                AndAlso ((sFullFileName.Trim.ToUpper.EndsWith(".JPG")) OrElse (sFullFileName.Trim.ToUpper.EndsWith(".BMP"))) Then
                    Me.picAttachmentPreview.Image = Image.FromFile(sFullFileName)
                Else
                    Me.picAttachmentPreview.Image = Nothing
                End If

                Me.picAttachmentPreview.Tag = sFileAttachmentId

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

#End Region

#Region " Turtle Brochure "

    Private Sub lnkUseImageInBrochure_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkUseImageInBrochure.LinkClicked
        SetBrochureImageFileAttachmentId()
    End Sub

    Private Sub lnkUseImageInBrochure_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkUseImageInBrochure.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                SetBrochureImageFileAttachmentId()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub SetBrochureImageFileAttachmentId()
        If (Me.picAttachmentPreview.Image IsNot Nothing) Then
            Me.picBrochureImage.Image = Me.picAttachmentPreview.Image
            moTurtle.BrochureImageFileAttachmentId = Convert.ToString(Me.picAttachmentPreview.Tag)
        End If
    End Sub

    Private Sub lnkBrochureBackgroundColor_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs)
        ShowBrochureBackcolorDialog()
    End Sub

    Private Sub lnkBrochureBackgroundColor_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs)

        Try

            If (e.KeyCode = Keys.Space) Then
                ShowBrochureBackcolorDialog()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub ShowBrochureBackcolorDialog()

        Dim oColorDialog As ColorDialog = Nothing

        Try

            '----------------------------------------------------------------
            '-- prompt user to select a color for the brochure background
            '----------------------------------------------------------------
            oColorDialog = New ColorDialog()

            oColorDialog.AllowFullOpen = True
            oColorDialog.AnyColor = True

            '----------------------------------------------------------------
            '-- if the user selected one or more files to attach...
            '----------------------------------------------------------------
            If (oColorDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then

                Cursor.Current = Cursors.WaitCursor

                'Me.picBrochureBackgroundColor.BackColor = oColorDialog.Color

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            If oColorDialog IsNot Nothing Then
                oColorDialog.Dispose()
                oColorDialog = Nothing
            End If

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub lnkBrochureClearImage_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkBrochureClearImage.LinkClicked
        ClearBrochureImage()
    End Sub

    Private Sub lnkBrochureClearImage_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkBrochureClearImage.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                ClearBrochureImage()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub ClearBrochureImage()

        Dim iImageWidth As Integer = Me.picBrochureImage.ClientSize.Width
        Dim iImageHeight As Integer = Me.picBrochureImage.ClientSize.Height

        '------------------------------------------------------------ 
        '-- do nothing if we have no size;
        '-- this happens, for example, if the form is minimized
        '------------------------------------------------------------ 
        'If iImageWidth < 1 Or iImageHeight < 1 Then Exit Sub

        '------------------------------------------------------------ 
        '-- make a Bitmap and Graphics to fit
        '------------------------------------------------------------ 
        Dim oTempBitmap As New Bitmap(iImageWidth, iImageHeight)
        Dim oTempBitmapGraphics As System.Drawing.Graphics = System.Drawing.Graphics.FromImage(oTempBitmap)

        Dim oWhiteBrush As New System.Drawing.SolidBrush(Color.White)
        oTempBitmapGraphics.FillRectangle(oWhiteBrush, Me.picBrochureImage.ClientRectangle)

        '------------------------------------------------------------ 
        '-- display the result
        '------------------------------------------------------------ 
        Me.picBrochureImage.Image = oTempBitmap

        '------------------------------------------------------------ 
        '-- free resources
        '------------------------------------------------------------ 
        oWhiteBrush.Dispose()
        oTempBitmapGraphics.Dispose()

        Me.picBrochureImage.Tag = String.Empty

    End Sub

    Private Sub btnPrintBrochure_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrintBrochure.Click

        Dim i As Integer
        Dim iEarliestRecordRowIndex As Integer = -1
        Dim sArrivalWeightValueAndUnits As String = String.Empty
        Dim oEarliestDate As Date = Date.MaxValue
        Dim oTempDate As Date = Date.MinValue
        Dim oPrintDocumentEx As PrintDocumentEx

        Try

            '------------------------------------------------------------ 
            '-- transfer the form data values into the business object 
            '------------------------------------------------------------ 
            Me.CopyFormValuesToBusinessObject()

            '----------------------------------------------------------------
            '-- get the arrival weight value and units
            '----------------------------------------------------------------
            For i = 0 To grdTurtleMorphometricGrid.Rows.Count - 1
                oTempDate = Convert.ToDateTime(grdTurtleMorphometricGrid.Rows(i).Cells(Me.colMorphometricDateMeasuredBindableDataGridViewTextBoxColumn.Name).Value)

                If (oTempDate < oEarliestDate) Then
                    iEarliestRecordRowIndex = i
                End If

                sArrivalWeightValueAndUnits = Convert.ToString(grdTurtleMorphometricGrid.Rows(i).Cells(Me.colMorphometricWeightValueDataGridViewTextBoxColumn.Name).Value)
                sArrivalWeightValueAndUnits &= " " & Convert.ToString(grdTurtleMorphometricGrid.Rows(i).Cells(Me.colMorphometricWeightUnitsDataGridViewTextBoxColumn.Name).Value)
            Next

            If (iEarliestRecordRowIndex = -1) Then
                sArrivalWeightValueAndUnits = "<none recorded>"
            End If

            '----------------------------------------------------------------
            '-- begin the report output
            '----------------------------------------------------------------
            oPrintDocumentEx = New PrintDocumentEx

            oPrintDocumentEx.DocumentName = "Turtle Brochure for " & moTurtle.TurtleName
            oPrintDocumentEx.PageColor = Color.FromArgb(moTurtle.BrochureBackgroundColor)

            oPrintDocumentEx.WriteImage(Me.picBrochureImage.Image, bHasBorder:=True, fXPos:=1, fYPos:=1, fImageHeight:=240, fImageWidth:=240)

            oPrintDocumentEx.Write("Turtle Name:", "Arial", 12, True, False, False, 360)
            oPrintDocumentEx.Write(moTurtle.TurtleName, "Arial", 12, False, False, False, 510)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)

            oPrintDocumentEx.Write("Species:", "Arial", 12, True, False, False, 360)
            'oPrintDocumentEx.Write(moTurtle.Species, "Arial", 12, False, False, False, 510)
            oPrintDocumentEx.Write(Me.cboSpeciesList.Text, "Arial", 12, False, False, False, 510)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)

            oPrintDocumentEx.Write("Size:", "Arial", 12, True, False, False, 360)
            oPrintDocumentEx.Write(Me.cboSizeList.Text, "Arial", 12, False, False, False, 510)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)

            oPrintDocumentEx.Write("Arrival Weight:", "Arial", 12, True, False, False, 360)
            oPrintDocumentEx.Write(sArrivalWeightValueAndUnits, "Arial", 12, False, False, False, 510)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)

            oPrintDocumentEx.Write("Stranding Date:", "Arial", 12, True, False, False, 360)
            oPrintDocumentEx.Write(moTurtle.DateAcquiredString, "Arial", 12, False, False, False, 510)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)

            oPrintDocumentEx.Write("Location Found:", "Arial", 12, True, False, False, 360)
            oPrintDocumentEx.Write(moTurtle.AcquiredFrom, "Arial", 12, False, False, False, 510)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=12)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)

            oPrintDocumentEx.Write("County:", "Arial", 12, True, False, False, 360)
            oPrintDocumentEx.Write(moTurtle.AcquiredCounty, "Arial", 12, False, False, False, 510)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)

            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)
            oPrintDocumentEx.WriteLine(String.Empty, fFontSize:=8)

            oPrintDocumentEx.WriteLine("Comments:", "Arial", 12, True, False, False)
            oPrintDocumentEx.WriteLine(moTurtle.BrochureComments, "Arial", 12, False, False, False)
            oPrintDocumentEx.WriteLine(String.Empty)

            oPrintDocumentEx.Preview(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            oPrintDocumentEx = Nothing

        End Try

    End Sub

#End Region

End Class
