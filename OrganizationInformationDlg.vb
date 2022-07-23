Option Explicit On 
Option Strict On
Option Compare Text

Public Class OrganizationInformationDlg
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
    Friend WithEvents lblOrganizationName As System.Windows.Forms.Label
    Friend WithEvents txtOrganizationName As System.Windows.Forms.TextBox
    Friend WithEvents txtPermitNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblSeparator As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblPermitNumber As System.Windows.Forms.Label
    Friend WithEvents txtAddress1 As System.Windows.Forms.TextBox
    Friend WithEvents txtAddress2 As System.Windows.Forms.TextBox
    Friend WithEvents txtCity As System.Windows.Forms.TextBox
    Friend WithEvents lblCity As System.Windows.Forms.Label
    Friend WithEvents txtState As System.Windows.Forms.TextBox
    Friend WithEvents lblState As System.Windows.Forms.Label
    Friend WithEvents lblZipCode As System.Windows.Forms.Label
    Friend WithEvents lblAddress As System.Windows.Forms.Label
    Friend WithEvents txtZipCode As System.Windows.Forms.TextBox
    Friend WithEvents txtPhone As System.Windows.Forms.TextBox
    Friend WithEvents lblPhone As System.Windows.Forms.Label
    Friend WithEvents lblFax As System.Windows.Forms.Label
    Friend WithEvents lblEmailAddress As System.Windows.Forms.Label
    Friend WithEvents txtFax As System.Windows.Forms.TextBox
    Friend WithEvents txtEmailAddress As System.Windows.Forms.TextBox
    Friend WithEvents erpErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents txtContactName As System.Windows.Forms.TextBox
    Friend WithEvents lblContactName As System.Windows.Forms.Label
    Friend WithEvents tabOrganizationInformation As System.Windows.Forms.TabControl
    Friend WithEvents tpgGeneralInformation As System.Windows.Forms.TabPage
    Friend WithEvents tpgHatchlingStartingBalancings As System.Windows.Forms.TabPage
    Friend WithEvents lblHatchlingBalanceAsOfDate As System.Windows.Forms.Label
    Friend WithEvents dtpHatchlingBalanceAsOfDate As TurtleGeek.Controls.DateComboBox
    Friend WithEvents lblDcHatchlingStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblCmHatchlingStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblCcHatchlingStartingBalance As System.Windows.Forms.Label
    Friend WithEvents grpHatchlingStartingBalances As System.Windows.Forms.GroupBox
    Friend WithEvents txtUnknownHatchlingStartingBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtOtherHatchlingStartingBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtDcHatchlingStartingBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtCmHatchlingStartingBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtCcHatchlingStartingBalance As System.Windows.Forms.TextBox
    Friend WithEvents lblUnknownHatchlingStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblOtherHatchlingStartingBalance As System.Windows.Forms.Label
    Friend WithEvents tpgPreferences As System.Windows.Forms.TabPage
    Friend WithEvents grpUnitsType As System.Windows.Forms.GroupBox
    Friend WithEvents radUnitsTypeImperial As System.Windows.Forms.RadioButton
    Friend WithEvents radUnitsTypeMetric As System.Windows.Forms.RadioButton
    Friend WithEvents grpWashbackStartingBalances As System.Windows.Forms.GroupBox
    Friend WithEvents txtUnknownWashbackStartingBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtOtherWashbackStartingBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtDcWashbackStartingBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtCmWashbackStartingBalance As System.Windows.Forms.TextBox
    Friend WithEvents txtCcWashbackStartingBalance As System.Windows.Forms.TextBox
    Friend WithEvents lblCcWashbackStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblUnknownWashbackStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblCmWashabackStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblOtherWashbackStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblDcWashbackStartingBalance As System.Windows.Forms.Label
    Friend WithEvents lblWashbackBalanceAsOfDate As System.Windows.Forms.Label
    Friend WithEvents dtpWashbackBalanceAsOfDate As TurtleGeek.Controls.DateComboBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(OrganizationInformationDlg))
        Me.lblOrganizationName = New System.Windows.Forms.Label
        Me.lblPermitNumber = New System.Windows.Forms.Label
        Me.txtOrganizationName = New System.Windows.Forms.TextBox
        Me.txtPermitNumber = New System.Windows.Forms.TextBox
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtAddress1 = New System.Windows.Forms.TextBox
        Me.lblAddress = New System.Windows.Forms.Label
        Me.txtAddress2 = New System.Windows.Forms.TextBox
        Me.txtCity = New System.Windows.Forms.TextBox
        Me.lblCity = New System.Windows.Forms.Label
        Me.txtState = New System.Windows.Forms.TextBox
        Me.lblState = New System.Windows.Forms.Label
        Me.txtZipCode = New System.Windows.Forms.TextBox
        Me.lblZipCode = New System.Windows.Forms.Label
        Me.txtPhone = New System.Windows.Forms.TextBox
        Me.lblPhone = New System.Windows.Forms.Label
        Me.lblFax = New System.Windows.Forms.Label
        Me.txtFax = New System.Windows.Forms.TextBox
        Me.txtEmailAddress = New System.Windows.Forms.TextBox
        Me.lblEmailAddress = New System.Windows.Forms.Label
        Me.erpErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnHelp = New System.Windows.Forms.Button
        Me.txtContactName = New System.Windows.Forms.TextBox
        Me.lblContactName = New System.Windows.Forms.Label
        Me.tabOrganizationInformation = New System.Windows.Forms.TabControl
        Me.tpgGeneralInformation = New System.Windows.Forms.TabPage
        Me.tpgHatchlingStartingBalancings = New System.Windows.Forms.TabPage
        Me.grpWashbackStartingBalances = New System.Windows.Forms.GroupBox
        Me.txtUnknownWashbackStartingBalance = New System.Windows.Forms.TextBox
        Me.txtOtherWashbackStartingBalance = New System.Windows.Forms.TextBox
        Me.txtDcWashbackStartingBalance = New System.Windows.Forms.TextBox
        Me.txtCmWashbackStartingBalance = New System.Windows.Forms.TextBox
        Me.txtCcWashbackStartingBalance = New System.Windows.Forms.TextBox
        Me.lblCcWashbackStartingBalance = New System.Windows.Forms.Label
        Me.lblUnknownWashbackStartingBalance = New System.Windows.Forms.Label
        Me.lblCmWashabackStartingBalance = New System.Windows.Forms.Label
        Me.lblOtherWashbackStartingBalance = New System.Windows.Forms.Label
        Me.lblDcWashbackStartingBalance = New System.Windows.Forms.Label
        Me.lblWashbackBalanceAsOfDate = New System.Windows.Forms.Label
        Me.dtpWashbackBalanceAsOfDate = New TurtleGeek.Controls.DateComboBox
        Me.grpHatchlingStartingBalances = New System.Windows.Forms.GroupBox
        Me.txtUnknownHatchlingStartingBalance = New System.Windows.Forms.TextBox
        Me.txtOtherHatchlingStartingBalance = New System.Windows.Forms.TextBox
        Me.txtDcHatchlingStartingBalance = New System.Windows.Forms.TextBox
        Me.txtCmHatchlingStartingBalance = New System.Windows.Forms.TextBox
        Me.txtCcHatchlingStartingBalance = New System.Windows.Forms.TextBox
        Me.lblCcHatchlingStartingBalance = New System.Windows.Forms.Label
        Me.lblUnknownHatchlingStartingBalance = New System.Windows.Forms.Label
        Me.lblCmHatchlingStartingBalance = New System.Windows.Forms.Label
        Me.lblOtherHatchlingStartingBalance = New System.Windows.Forms.Label
        Me.lblDcHatchlingStartingBalance = New System.Windows.Forms.Label
        Me.lblHatchlingBalanceAsOfDate = New System.Windows.Forms.Label
        Me.dtpHatchlingBalanceAsOfDate = New TurtleGeek.Controls.DateComboBox
        Me.tpgPreferences = New System.Windows.Forms.TabPage
        Me.grpUnitsType = New System.Windows.Forms.GroupBox
        Me.radUnitsTypeImperial = New System.Windows.Forms.RadioButton
        Me.radUnitsTypeMetric = New System.Windows.Forms.RadioButton
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabOrganizationInformation.SuspendLayout()
        Me.tpgGeneralInformation.SuspendLayout()
        Me.tpgHatchlingStartingBalancings.SuspendLayout()
        Me.grpWashbackStartingBalances.SuspendLayout()
        Me.grpHatchlingStartingBalances.SuspendLayout()
        Me.tpgPreferences.SuspendLayout()
        Me.grpUnitsType.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblOrganizationName
        '
        Me.lblOrganizationName.AutoSize = True
        Me.lblOrganizationName.Location = New System.Drawing.Point(6, 11)
        Me.lblOrganizationName.Name = "lblOrganizationName"
        Me.lblOrganizationName.Size = New System.Drawing.Size(98, 13)
        Me.lblOrganizationName.TabIndex = 0
        Me.lblOrganizationName.Text = "Organization name:"
        Me.lblOrganizationName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPermitNumber
        '
        Me.lblPermitNumber.AutoSize = True
        Me.lblPermitNumber.Location = New System.Drawing.Point(8, 193)
        Me.lblPermitNumber.Name = "lblPermitNumber"
        Me.lblPermitNumber.Size = New System.Drawing.Size(77, 13)
        Me.lblPermitNumber.TabIndex = 19
        Me.lblPermitNumber.Text = "Permit number:"
        Me.lblPermitNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOrganizationName
        '
        Me.txtOrganizationName.Location = New System.Drawing.Point(113, 8)
        Me.txtOrganizationName.MaxLength = 255
        Me.txtOrganizationName.Name = "txtOrganizationName"
        Me.txtOrganizationName.Size = New System.Drawing.Size(438, 20)
        Me.txtOrganizationName.TabIndex = 1
        '
        'txtPermitNumber
        '
        Me.txtPermitNumber.Location = New System.Drawing.Point(113, 190)
        Me.txtPermitNumber.MaxLength = 255
        Me.txtPermitNumber.Name = "txtPermitNumber"
        Me.txtPermitNumber.Size = New System.Drawing.Size(438, 20)
        Me.txtPermitNumber.TabIndex = 20
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(8, 256)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(584, 2)
        Me.lblSeparator.TabIndex = 1
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(520, 272)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(440, 272)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 24)
        Me.btnOK.TabIndex = 2
        Me.btnOK.Text = "OK"
        '
        'txtAddress1
        '
        Me.txtAddress1.Location = New System.Drawing.Point(113, 34)
        Me.txtAddress1.MaxLength = 255
        Me.txtAddress1.Name = "txtAddress1"
        Me.txtAddress1.Size = New System.Drawing.Size(438, 20)
        Me.txtAddress1.TabIndex = 3
        '
        'lblAddress
        '
        Me.lblAddress.AutoSize = True
        Me.lblAddress.Location = New System.Drawing.Point(8, 37)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(48, 13)
        Me.lblAddress.TabIndex = 2
        Me.lblAddress.Text = "Address:"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAddress2
        '
        Me.txtAddress2.Location = New System.Drawing.Point(113, 60)
        Me.txtAddress2.MaxLength = 255
        Me.txtAddress2.Name = "txtAddress2"
        Me.txtAddress2.Size = New System.Drawing.Size(438, 20)
        Me.txtAddress2.TabIndex = 4
        '
        'txtCity
        '
        Me.txtCity.Location = New System.Drawing.Point(113, 86)
        Me.txtCity.MaxLength = 255
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(191, 20)
        Me.txtCity.TabIndex = 6
        '
        'lblCity
        '
        Me.lblCity.AutoSize = True
        Me.lblCity.Location = New System.Drawing.Point(8, 89)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(27, 13)
        Me.lblCity.TabIndex = 5
        Me.lblCity.Text = "City:"
        Me.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtState
        '
        Me.txtState.Location = New System.Drawing.Point(360, 86)
        Me.txtState.MaxLength = 2
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(32, 20)
        Me.txtState.TabIndex = 8
        '
        'lblState
        '
        Me.lblState.AutoSize = True
        Me.lblState.Location = New System.Drawing.Point(320, 89)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(35, 13)
        Me.lblState.TabIndex = 7
        Me.lblState.Text = "State:"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtZipCode
        '
        Me.txtZipCode.Location = New System.Drawing.Point(432, 86)
        Me.txtZipCode.MaxLength = 255
        Me.txtZipCode.Name = "txtZipCode"
        Me.txtZipCode.Size = New System.Drawing.Size(119, 20)
        Me.txtZipCode.TabIndex = 10
        '
        'lblZipCode
        '
        Me.lblZipCode.AutoSize = True
        Me.lblZipCode.Location = New System.Drawing.Point(399, 89)
        Me.lblZipCode.Name = "lblZipCode"
        Me.lblZipCode.Size = New System.Drawing.Size(27, 13)
        Me.lblZipCode.TabIndex = 9
        Me.lblZipCode.Text = "ZIP:"
        Me.lblZipCode.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPhone
        '
        Me.txtPhone.Location = New System.Drawing.Point(113, 112)
        Me.txtPhone.MaxLength = 255
        Me.txtPhone.Name = "txtPhone"
        Me.txtPhone.Size = New System.Drawing.Size(191, 20)
        Me.txtPhone.TabIndex = 12
        '
        'lblPhone
        '
        Me.lblPhone.AutoSize = True
        Me.lblPhone.Location = New System.Drawing.Point(8, 115)
        Me.lblPhone.Name = "lblPhone"
        Me.lblPhone.Size = New System.Drawing.Size(41, 13)
        Me.lblPhone.TabIndex = 11
        Me.lblPhone.Text = "Phone:"
        Me.lblPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFax
        '
        Me.lblFax.AutoSize = True
        Me.lblFax.Location = New System.Drawing.Point(320, 115)
        Me.lblFax.Name = "lblFax"
        Me.lblFax.Size = New System.Drawing.Size(27, 13)
        Me.lblFax.TabIndex = 13
        Me.lblFax.Text = "Fax:"
        Me.lblFax.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFax
        '
        Me.txtFax.Location = New System.Drawing.Point(360, 112)
        Me.txtFax.MaxLength = 255
        Me.txtFax.Name = "txtFax"
        Me.txtFax.Size = New System.Drawing.Size(191, 20)
        Me.txtFax.TabIndex = 14
        '
        'txtEmailAddress
        '
        Me.txtEmailAddress.Location = New System.Drawing.Point(113, 138)
        Me.txtEmailAddress.MaxLength = 255
        Me.txtEmailAddress.Name = "txtEmailAddress"
        Me.txtEmailAddress.Size = New System.Drawing.Size(438, 20)
        Me.txtEmailAddress.TabIndex = 16
        '
        'lblEmailAddress
        '
        Me.lblEmailAddress.AutoSize = True
        Me.lblEmailAddress.Location = New System.Drawing.Point(8, 141)
        Me.lblEmailAddress.Name = "lblEmailAddress"
        Me.lblEmailAddress.Size = New System.Drawing.Size(38, 13)
        Me.lblEmailAddress.TabIndex = 15
        Me.lblEmailAddress.Text = "E-mail:"
        Me.lblEmailAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'erpErrorProvider
        '
        Me.erpErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.erpErrorProvider.ContainerControl = Me
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(8, 272)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 24)
        Me.btnHelp.TabIndex = 4
        Me.btnHelp.Text = "&Help"
        '
        'txtContactName
        '
        Me.txtContactName.Location = New System.Drawing.Point(113, 164)
        Me.txtContactName.MaxLength = 255
        Me.txtContactName.Name = "txtContactName"
        Me.txtContactName.Size = New System.Drawing.Size(438, 20)
        Me.txtContactName.TabIndex = 18
        '
        'lblContactName
        '
        Me.lblContactName.AutoSize = True
        Me.lblContactName.Location = New System.Drawing.Point(8, 167)
        Me.lblContactName.Name = "lblContactName"
        Me.lblContactName.Size = New System.Drawing.Size(76, 13)
        Me.lblContactName.TabIndex = 17
        Me.lblContactName.Text = "Contact name:"
        Me.lblContactName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tabOrganizationInformation
        '
        Me.tabOrganizationInformation.Controls.Add(Me.tpgGeneralInformation)
        Me.tabOrganizationInformation.Controls.Add(Me.tpgHatchlingStartingBalancings)
        Me.tabOrganizationInformation.Controls.Add(Me.tpgPreferences)
        Me.tabOrganizationInformation.Location = New System.Drawing.Point(8, 8)
        Me.tabOrganizationInformation.Name = "tabOrganizationInformation"
        Me.tabOrganizationInformation.SelectedIndex = 0
        Me.tabOrganizationInformation.Size = New System.Drawing.Size(581, 241)
        Me.tabOrganizationInformation.TabIndex = 0
        '
        'tpgGeneralInformation
        '
        Me.tpgGeneralInformation.Controls.Add(Me.lblOrganizationName)
        Me.tpgGeneralInformation.Controls.Add(Me.txtOrganizationName)
        Me.tpgGeneralInformation.Controls.Add(Me.lblAddress)
        Me.tpgGeneralInformation.Controls.Add(Me.txtAddress1)
        Me.tpgGeneralInformation.Controls.Add(Me.txtAddress2)
        Me.tpgGeneralInformation.Controls.Add(Me.lblCity)
        Me.tpgGeneralInformation.Controls.Add(Me.txtCity)
        Me.tpgGeneralInformation.Controls.Add(Me.lblState)
        Me.tpgGeneralInformation.Controls.Add(Me.txtState)
        Me.tpgGeneralInformation.Controls.Add(Me.lblZipCode)
        Me.tpgGeneralInformation.Controls.Add(Me.txtZipCode)
        Me.tpgGeneralInformation.Controls.Add(Me.lblPhone)
        Me.tpgGeneralInformation.Controls.Add(Me.txtPhone)
        Me.tpgGeneralInformation.Controls.Add(Me.lblEmailAddress)
        Me.tpgGeneralInformation.Controls.Add(Me.txtEmailAddress)
        Me.tpgGeneralInformation.Controls.Add(Me.lblFax)
        Me.tpgGeneralInformation.Controls.Add(Me.txtFax)
        Me.tpgGeneralInformation.Controls.Add(Me.lblPermitNumber)
        Me.tpgGeneralInformation.Controls.Add(Me.txtPermitNumber)
        Me.tpgGeneralInformation.Controls.Add(Me.lblContactName)
        Me.tpgGeneralInformation.Controls.Add(Me.txtContactName)
        Me.tpgGeneralInformation.Location = New System.Drawing.Point(4, 22)
        Me.tpgGeneralInformation.Name = "tpgGeneralInformation"
        Me.tpgGeneralInformation.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgGeneralInformation.Size = New System.Drawing.Size(573, 215)
        Me.tpgGeneralInformation.TabIndex = 0
        Me.tpgGeneralInformation.Text = "General Information"
        Me.tpgGeneralInformation.UseVisualStyleBackColor = True
        '
        'tpgHatchlingStartingBalancings
        '
        Me.tpgHatchlingStartingBalancings.Controls.Add(Me.grpWashbackStartingBalances)
        Me.tpgHatchlingStartingBalancings.Controls.Add(Me.lblWashbackBalanceAsOfDate)
        Me.tpgHatchlingStartingBalancings.Controls.Add(Me.dtpWashbackBalanceAsOfDate)
        Me.tpgHatchlingStartingBalancings.Controls.Add(Me.grpHatchlingStartingBalances)
        Me.tpgHatchlingStartingBalancings.Controls.Add(Me.lblHatchlingBalanceAsOfDate)
        Me.tpgHatchlingStartingBalancings.Controls.Add(Me.dtpHatchlingBalanceAsOfDate)
        Me.tpgHatchlingStartingBalancings.Location = New System.Drawing.Point(4, 22)
        Me.tpgHatchlingStartingBalancings.Name = "tpgHatchlingStartingBalancings"
        Me.tpgHatchlingStartingBalancings.Padding = New System.Windows.Forms.Padding(3)
        Me.tpgHatchlingStartingBalancings.Size = New System.Drawing.Size(573, 215)
        Me.tpgHatchlingStartingBalancings.TabIndex = 1
        Me.tpgHatchlingStartingBalancings.Text = "Hatchling and Washback Starting Balances"
        Me.tpgHatchlingStartingBalancings.UseVisualStyleBackColor = True
        '
        'grpWashbackStartingBalances
        '
        Me.grpWashbackStartingBalances.Controls.Add(Me.txtUnknownWashbackStartingBalance)
        Me.grpWashbackStartingBalances.Controls.Add(Me.txtOtherWashbackStartingBalance)
        Me.grpWashbackStartingBalances.Controls.Add(Me.txtDcWashbackStartingBalance)
        Me.grpWashbackStartingBalances.Controls.Add(Me.txtCmWashbackStartingBalance)
        Me.grpWashbackStartingBalances.Controls.Add(Me.txtCcWashbackStartingBalance)
        Me.grpWashbackStartingBalances.Controls.Add(Me.lblCcWashbackStartingBalance)
        Me.grpWashbackStartingBalances.Controls.Add(Me.lblUnknownWashbackStartingBalance)
        Me.grpWashbackStartingBalances.Controls.Add(Me.lblCmWashabackStartingBalance)
        Me.grpWashbackStartingBalances.Controls.Add(Me.lblOtherWashbackStartingBalance)
        Me.grpWashbackStartingBalances.Controls.Add(Me.lblDcWashbackStartingBalance)
        Me.grpWashbackStartingBalances.Location = New System.Drawing.Point(274, 32)
        Me.grpWashbackStartingBalances.Name = "grpWashbackStartingBalances"
        Me.grpWashbackStartingBalances.Size = New System.Drawing.Size(233, 153)
        Me.grpWashbackStartingBalances.TabIndex = 5
        Me.grpWashbackStartingBalances.TabStop = False
        Me.grpWashbackStartingBalances.Text = "Washback starting balance values"
        '
        'txtUnknownWashbackStartingBalance
        '
        Me.txtUnknownWashbackStartingBalance.Location = New System.Drawing.Point(114, 123)
        Me.txtUnknownWashbackStartingBalance.MaxLength = 8
        Me.txtUnknownWashbackStartingBalance.Name = "txtUnknownWashbackStartingBalance"
        Me.txtUnknownWashbackStartingBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtUnknownWashbackStartingBalance.TabIndex = 9
        '
        'txtOtherWashbackStartingBalance
        '
        Me.txtOtherWashbackStartingBalance.Location = New System.Drawing.Point(114, 97)
        Me.txtOtherWashbackStartingBalance.MaxLength = 8
        Me.txtOtherWashbackStartingBalance.Name = "txtOtherWashbackStartingBalance"
        Me.txtOtherWashbackStartingBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtOtherWashbackStartingBalance.TabIndex = 7
        '
        'txtDcWashbackStartingBalance
        '
        Me.txtDcWashbackStartingBalance.Location = New System.Drawing.Point(114, 71)
        Me.txtDcWashbackStartingBalance.MaxLength = 8
        Me.txtDcWashbackStartingBalance.Name = "txtDcWashbackStartingBalance"
        Me.txtDcWashbackStartingBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtDcWashbackStartingBalance.TabIndex = 5
        '
        'txtCmWashbackStartingBalance
        '
        Me.txtCmWashbackStartingBalance.Location = New System.Drawing.Point(114, 45)
        Me.txtCmWashbackStartingBalance.MaxLength = 8
        Me.txtCmWashbackStartingBalance.Name = "txtCmWashbackStartingBalance"
        Me.txtCmWashbackStartingBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtCmWashbackStartingBalance.TabIndex = 3
        '
        'txtCcWashbackStartingBalance
        '
        Me.txtCcWashbackStartingBalance.Location = New System.Drawing.Point(114, 19)
        Me.txtCcWashbackStartingBalance.MaxLength = 8
        Me.txtCcWashbackStartingBalance.Name = "txtCcWashbackStartingBalance"
        Me.txtCcWashbackStartingBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtCcWashbackStartingBalance.TabIndex = 1
        '
        'lblCcWashbackStartingBalance
        '
        Me.lblCcWashbackStartingBalance.AutoSize = True
        Me.lblCcWashbackStartingBalance.Location = New System.Drawing.Point(6, 22)
        Me.lblCcWashbackStartingBalance.Name = "lblCcWashbackStartingBalance"
        Me.lblCcWashbackStartingBalance.Size = New System.Drawing.Size(89, 13)
        Me.lblCcWashbackStartingBalance.TabIndex = 0
        Me.lblCcWashbackStartingBalance.Text = "Loggerhead (Cc):"
        '
        'lblUnknownWashbackStartingBalance
        '
        Me.lblUnknownWashbackStartingBalance.AutoSize = True
        Me.lblUnknownWashbackStartingBalance.Location = New System.Drawing.Point(6, 126)
        Me.lblUnknownWashbackStartingBalance.Name = "lblUnknownWashbackStartingBalance"
        Me.lblUnknownWashbackStartingBalance.Size = New System.Drawing.Size(56, 13)
        Me.lblUnknownWashbackStartingBalance.TabIndex = 8
        Me.lblUnknownWashbackStartingBalance.Text = "Unknown:"
        '
        'lblCmWashabackStartingBalance
        '
        Me.lblCmWashabackStartingBalance.AutoSize = True
        Me.lblCmWashabackStartingBalance.Location = New System.Drawing.Point(6, 48)
        Me.lblCmWashabackStartingBalance.Name = "lblCmWashabackStartingBalance"
        Me.lblCmWashabackStartingBalance.Size = New System.Drawing.Size(63, 13)
        Me.lblCmWashabackStartingBalance.TabIndex = 2
        Me.lblCmWashabackStartingBalance.Text = "Green (Cm):"
        '
        'lblOtherWashbackStartingBalance
        '
        Me.lblOtherWashbackStartingBalance.AutoSize = True
        Me.lblOtherWashbackStartingBalance.Location = New System.Drawing.Point(6, 100)
        Me.lblOtherWashbackStartingBalance.Name = "lblOtherWashbackStartingBalance"
        Me.lblOtherWashbackStartingBalance.Size = New System.Drawing.Size(36, 13)
        Me.lblOtherWashbackStartingBalance.TabIndex = 6
        Me.lblOtherWashbackStartingBalance.Text = "Other:"
        '
        'lblDcWashbackStartingBalance
        '
        Me.lblDcWashbackStartingBalance.AutoSize = True
        Me.lblDcWashbackStartingBalance.Location = New System.Drawing.Point(6, 74)
        Me.lblDcWashbackStartingBalance.Name = "lblDcWashbackStartingBalance"
        Me.lblDcWashbackStartingBalance.Size = New System.Drawing.Size(93, 13)
        Me.lblDcWashbackStartingBalance.TabIndex = 4
        Me.lblDcWashbackStartingBalance.Text = "Leatherback (Dc):"
        '
        'lblWashbackBalanceAsOfDate
        '
        Me.lblWashbackBalanceAsOfDate.AutoSize = True
        Me.lblWashbackBalanceAsOfDate.Location = New System.Drawing.Point(280, 10)
        Me.lblWashbackBalanceAsOfDate.Name = "lblWashbackBalanceAsOfDate"
        Me.lblWashbackBalanceAsOfDate.Size = New System.Drawing.Size(75, 13)
        Me.lblWashbackBalanceAsOfDate.TabIndex = 3
        Me.lblWashbackBalanceAsOfDate.Text = "Balance as of:"
        '
        'dtpWashbackBalanceAsOfDate
        '
        Me.dtpWashbackBalanceAsOfDate.DateValue = New Date(2006, 5, 31, 23, 40, 21, 984)
        Me.dtpWashbackBalanceAsOfDate.Location = New System.Drawing.Point(388, 6)
        Me.dtpWashbackBalanceAsOfDate.Name = "dtpWashbackBalanceAsOfDate"
        Me.dtpWashbackBalanceAsOfDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpWashbackBalanceAsOfDate.TabIndex = 4
        '
        'grpHatchlingStartingBalances
        '
        Me.grpHatchlingStartingBalances.Controls.Add(Me.txtUnknownHatchlingStartingBalance)
        Me.grpHatchlingStartingBalances.Controls.Add(Me.txtOtherHatchlingStartingBalance)
        Me.grpHatchlingStartingBalances.Controls.Add(Me.txtDcHatchlingStartingBalance)
        Me.grpHatchlingStartingBalances.Controls.Add(Me.txtCmHatchlingStartingBalance)
        Me.grpHatchlingStartingBalances.Controls.Add(Me.txtCcHatchlingStartingBalance)
        Me.grpHatchlingStartingBalances.Controls.Add(Me.lblCcHatchlingStartingBalance)
        Me.grpHatchlingStartingBalances.Controls.Add(Me.lblUnknownHatchlingStartingBalance)
        Me.grpHatchlingStartingBalances.Controls.Add(Me.lblCmHatchlingStartingBalance)
        Me.grpHatchlingStartingBalances.Controls.Add(Me.lblOtherHatchlingStartingBalance)
        Me.grpHatchlingStartingBalances.Controls.Add(Me.lblDcHatchlingStartingBalance)
        Me.grpHatchlingStartingBalances.Location = New System.Drawing.Point(9, 32)
        Me.grpHatchlingStartingBalances.Name = "grpHatchlingStartingBalances"
        Me.grpHatchlingStartingBalances.Size = New System.Drawing.Size(233, 153)
        Me.grpHatchlingStartingBalances.TabIndex = 2
        Me.grpHatchlingStartingBalances.TabStop = False
        Me.grpHatchlingStartingBalances.Text = "Hatchling starting balance values"
        '
        'txtUnknownHatchlingStartingBalance
        '
        Me.txtUnknownHatchlingStartingBalance.Location = New System.Drawing.Point(114, 123)
        Me.txtUnknownHatchlingStartingBalance.MaxLength = 8
        Me.txtUnknownHatchlingStartingBalance.Name = "txtUnknownHatchlingStartingBalance"
        Me.txtUnknownHatchlingStartingBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtUnknownHatchlingStartingBalance.TabIndex = 9
        '
        'txtOtherHatchlingStartingBalance
        '
        Me.txtOtherHatchlingStartingBalance.Location = New System.Drawing.Point(114, 97)
        Me.txtOtherHatchlingStartingBalance.MaxLength = 8
        Me.txtOtherHatchlingStartingBalance.Name = "txtOtherHatchlingStartingBalance"
        Me.txtOtherHatchlingStartingBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtOtherHatchlingStartingBalance.TabIndex = 7
        '
        'txtDcHatchlingStartingBalance
        '
        Me.txtDcHatchlingStartingBalance.Location = New System.Drawing.Point(114, 71)
        Me.txtDcHatchlingStartingBalance.MaxLength = 8
        Me.txtDcHatchlingStartingBalance.Name = "txtDcHatchlingStartingBalance"
        Me.txtDcHatchlingStartingBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtDcHatchlingStartingBalance.TabIndex = 5
        '
        'txtCmHatchlingStartingBalance
        '
        Me.txtCmHatchlingStartingBalance.Location = New System.Drawing.Point(114, 45)
        Me.txtCmHatchlingStartingBalance.MaxLength = 8
        Me.txtCmHatchlingStartingBalance.Name = "txtCmHatchlingStartingBalance"
        Me.txtCmHatchlingStartingBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtCmHatchlingStartingBalance.TabIndex = 3
        '
        'txtCcHatchlingStartingBalance
        '
        Me.txtCcHatchlingStartingBalance.Location = New System.Drawing.Point(114, 19)
        Me.txtCcHatchlingStartingBalance.MaxLength = 8
        Me.txtCcHatchlingStartingBalance.Name = "txtCcHatchlingStartingBalance"
        Me.txtCcHatchlingStartingBalance.Size = New System.Drawing.Size(100, 20)
        Me.txtCcHatchlingStartingBalance.TabIndex = 1
        '
        'lblCcHatchlingStartingBalance
        '
        Me.lblCcHatchlingStartingBalance.AutoSize = True
        Me.lblCcHatchlingStartingBalance.Location = New System.Drawing.Point(6, 22)
        Me.lblCcHatchlingStartingBalance.Name = "lblCcHatchlingStartingBalance"
        Me.lblCcHatchlingStartingBalance.Size = New System.Drawing.Size(89, 13)
        Me.lblCcHatchlingStartingBalance.TabIndex = 0
        Me.lblCcHatchlingStartingBalance.Text = "Loggerhead (Cc):"
        '
        'lblUnknownHatchlingStartingBalance
        '
        Me.lblUnknownHatchlingStartingBalance.AutoSize = True
        Me.lblUnknownHatchlingStartingBalance.Location = New System.Drawing.Point(6, 126)
        Me.lblUnknownHatchlingStartingBalance.Name = "lblUnknownHatchlingStartingBalance"
        Me.lblUnknownHatchlingStartingBalance.Size = New System.Drawing.Size(56, 13)
        Me.lblUnknownHatchlingStartingBalance.TabIndex = 8
        Me.lblUnknownHatchlingStartingBalance.Text = "Unknown:"
        '
        'lblCmHatchlingStartingBalance
        '
        Me.lblCmHatchlingStartingBalance.AutoSize = True
        Me.lblCmHatchlingStartingBalance.Location = New System.Drawing.Point(6, 48)
        Me.lblCmHatchlingStartingBalance.Name = "lblCmHatchlingStartingBalance"
        Me.lblCmHatchlingStartingBalance.Size = New System.Drawing.Size(63, 13)
        Me.lblCmHatchlingStartingBalance.TabIndex = 2
        Me.lblCmHatchlingStartingBalance.Text = "Green (Cm):"
        '
        'lblOtherHatchlingStartingBalance
        '
        Me.lblOtherHatchlingStartingBalance.AutoSize = True
        Me.lblOtherHatchlingStartingBalance.Location = New System.Drawing.Point(6, 100)
        Me.lblOtherHatchlingStartingBalance.Name = "lblOtherHatchlingStartingBalance"
        Me.lblOtherHatchlingStartingBalance.Size = New System.Drawing.Size(36, 13)
        Me.lblOtherHatchlingStartingBalance.TabIndex = 6
        Me.lblOtherHatchlingStartingBalance.Text = "Other:"
        '
        'lblDcHatchlingStartingBalance
        '
        Me.lblDcHatchlingStartingBalance.AutoSize = True
        Me.lblDcHatchlingStartingBalance.Location = New System.Drawing.Point(6, 74)
        Me.lblDcHatchlingStartingBalance.Name = "lblDcHatchlingStartingBalance"
        Me.lblDcHatchlingStartingBalance.Size = New System.Drawing.Size(93, 13)
        Me.lblDcHatchlingStartingBalance.TabIndex = 4
        Me.lblDcHatchlingStartingBalance.Text = "Leatherback (Dc):"
        '
        'lblHatchlingBalanceAsOfDate
        '
        Me.lblHatchlingBalanceAsOfDate.AutoSize = True
        Me.lblHatchlingBalanceAsOfDate.Location = New System.Drawing.Point(15, 10)
        Me.lblHatchlingBalanceAsOfDate.Name = "lblHatchlingBalanceAsOfDate"
        Me.lblHatchlingBalanceAsOfDate.Size = New System.Drawing.Size(75, 13)
        Me.lblHatchlingBalanceAsOfDate.TabIndex = 0
        Me.lblHatchlingBalanceAsOfDate.Text = "Balance as of:"
        '
        'dtpHatchlingBalanceAsOfDate
        '
        Me.dtpHatchlingBalanceAsOfDate.DateValue = New Date(2006, 5, 31, 23, 40, 21, 984)
        Me.dtpHatchlingBalanceAsOfDate.Location = New System.Drawing.Point(123, 6)
        Me.dtpHatchlingBalanceAsOfDate.Name = "dtpHatchlingBalanceAsOfDate"
        Me.dtpHatchlingBalanceAsOfDate.Size = New System.Drawing.Size(100, 20)
        Me.dtpHatchlingBalanceAsOfDate.TabIndex = 1
        '
        'tpgPreferences
        '
        Me.tpgPreferences.Controls.Add(Me.grpUnitsType)
        Me.tpgPreferences.Location = New System.Drawing.Point(4, 22)
        Me.tpgPreferences.Name = "tpgPreferences"
        Me.tpgPreferences.Size = New System.Drawing.Size(573, 215)
        Me.tpgPreferences.TabIndex = 2
        Me.tpgPreferences.Text = "Preferences"
        Me.tpgPreferences.UseVisualStyleBackColor = True
        '
        'grpUnitsType
        '
        Me.grpUnitsType.Controls.Add(Me.radUnitsTypeImperial)
        Me.grpUnitsType.Controls.Add(Me.radUnitsTypeMetric)
        Me.grpUnitsType.Location = New System.Drawing.Point(9, 9)
        Me.grpUnitsType.Name = "grpUnitsType"
        Me.grpUnitsType.Size = New System.Drawing.Size(177, 72)
        Me.grpUnitsType.TabIndex = 0
        Me.grpUnitsType.TabStop = False
        Me.grpUnitsType.Text = "Units type"
        '
        'radUnitsTypeImperial
        '
        Me.radUnitsTypeImperial.AutoSize = True
        Me.radUnitsTypeImperial.Location = New System.Drawing.Point(6, 43)
        Me.radUnitsTypeImperial.Name = "radUnitsTypeImperial"
        Me.radUnitsTypeImperial.Size = New System.Drawing.Size(144, 17)
        Me.radUnitsTypeImperial.TabIndex = 1
        Me.radUnitsTypeImperial.TabStop = True
        Me.radUnitsTypeImperial.Text = "Imperial (inches, lbs, etc.)"
        Me.radUnitsTypeImperial.UseVisualStyleBackColor = True
        '
        'radUnitsTypeMetric
        '
        Me.radUnitsTypeMetric.AutoSize = True
        Me.radUnitsTypeMetric.Location = New System.Drawing.Point(6, 20)
        Me.radUnitsTypeMetric.Name = "radUnitsTypeMetric"
        Me.radUnitsTypeMetric.Size = New System.Drawing.Size(119, 17)
        Me.radUnitsTypeMetric.TabIndex = 0
        Me.radUnitsTypeMetric.TabStop = True
        Me.radUnitsTypeMetric.Text = "Metric (cm, kg, etc.)"
        Me.radUnitsTypeMetric.UseVisualStyleBackColor = True
        '
        'OrganizationInformationDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(602, 311)
        Me.Controls.Add(Me.tabOrganizationInformation)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "OrganizationInformationDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Organization Information"
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabOrganizationInformation.ResumeLayout(False)
        Me.tpgGeneralInformation.ResumeLayout(False)
        Me.tpgGeneralInformation.PerformLayout()
        Me.tpgHatchlingStartingBalancings.ResumeLayout(False)
        Me.tpgHatchlingStartingBalancings.PerformLayout()
        Me.grpWashbackStartingBalances.ResumeLayout(False)
        Me.grpWashbackStartingBalances.PerformLayout()
        Me.grpHatchlingStartingBalances.ResumeLayout(False)
        Me.grpHatchlingStartingBalances.PerformLayout()
        Me.tpgPreferences.ResumeLayout(False)
        Me.grpUnitsType.ResumeLayout(False)
        Me.grpUnitsType.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private mbIsOkayButtonClicked As Boolean = False
    Private moOrganization As Organization = Nothing

    Public Sub New(ByVal oOrganization As Organization)

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None

        moOrganization = oOrganization

    End Sub

    Private Sub frmOrganizationInformationDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            '*** ASSERTION ***
            If moOrganization Is Nothing Then
                Throw New ApplicationException("Organization object must be set before opening this screen.")
            End If
            '*** ASSERTION ***

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            ''----------------------------------------------------------------
            ''-- kludge to initialize the date time picker
            ''----------------------------------------------------------------
            'Me.dtpHatchlingBalanceAsOfDate.DateValue = DateTime.Now
            'Me.dtpHatchlingBalanceAsOfDate.DateValue = DateTime.MinValue

            'Me.dtpWashbackBalanceAsOfDate.DateValue = DateTime.Now
            'Me.dtpWashbackBalanceAsOfDate.DateValue = DateTime.MinValue

            '----------------------------------------------------------------
            '-- fill the form fields with the object property values
            '----------------------------------------------------------------
            moOrganization.BeginEdit()

            Me.txtOrganizationName.Text = moOrganization.OrganizationName
            Me.txtAddress1.Text = moOrganization.Address1
            Me.txtAddress2.Text = moOrganization.Address2
            Me.txtCity.Text = moOrganization.City
            Me.txtState.Text = moOrganization.State
            Me.txtZipCode.Text = moOrganization.ZipCode
            Me.txtPhone.Text = moOrganization.Phone
            Me.txtFax.Text = moOrganization.Fax
            Me.txtEmailAddress.Text = moOrganization.EmailAddress
            Me.txtPermitNumber.Text = moOrganization.PermitNumber
            Me.txtContactName.Text = moOrganization.ContactName
            Me.dtpHatchlingBalanceAsOfDate.DateValue = moOrganization.HatchlingBalanceAsOfDate
            Me.txtCcHatchlingStartingBalance.Text = Convert.ToString(moOrganization.CcHatchlingStartingBalance)
            Me.txtCmHatchlingStartingBalance.Text = Convert.ToString(moOrganization.CmHatchlingStartingBalance)
            Me.txtDcHatchlingStartingBalance.Text = Convert.ToString(moOrganization.DcHatchlingStartingBalance)
            Me.txtOtherHatchlingStartingBalance.Text = Convert.ToString(moOrganization.OtherHatchlingStartingBalance)
            Me.txtUnknownHatchlingStartingBalance.Text = Convert.ToString(moOrganization.UnknownHatchlingStartingBalance)
            Me.dtpWashbackBalanceAsOfDate.DateValue = moOrganization.WashbackBalanceAsOfDate
            Me.txtCcWashbackStartingBalance.Text = Convert.ToString(moOrganization.CcWashbackStartingBalance)
            Me.txtCmWashbackStartingBalance.Text = Convert.ToString(moOrganization.CmWashbackStartingBalance)
            Me.txtDcWashbackStartingBalance.Text = Convert.ToString(moOrganization.DcWashbackStartingBalance)
            Me.txtOtherWashbackStartingBalance.Text = Convert.ToString(moOrganization.OtherWashbackStartingBalance)
            Me.txtUnknownWashbackStartingBalance.Text = Convert.ToString(moOrganization.UnknownWashbackStartingBalance)

            If moOrganization.PreferredUnitsType = "I" Then
                Me.radUnitsTypeImperial.Checked = True
            Else
                Me.radUnitsTypeMetric.Checked = True
            End If

            '----------------------------------------------------------------
            '-- display required field indicators 
            '----------------------------------------------------------------
            Me.DisplayBrokenRules(False)

            txtOrganizationName.Focus()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub frmOrganizationInformationDlg_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

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
            If moOrganization.IsDirty Then

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
            moOrganization.CancelEdit()
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

        Dim oTempOrganization As Organization

        Try
            '------------------------------------------------------------ 
            '-- if the object has changed... 
            '------------------------------------------------------------ 
            If moOrganization.IsDirty Then

                '------------------------------------------------------------ 
                '-- if all of the validation rules have passed... 
                '------------------------------------------------------------ 
                If moOrganization.IsValid Then

                    '------------------------------------------------------------ 
                    '-- ...then save the values to the database 
                    '------------------------------------------------------------ 
                    moOrganization.ApplyEdit()

                    '----------------------------------------------------------------
                    '-- clone and save the object (it is the CSLA way)
                    '----------------------------------------------------------------
                    oTempOrganization = moOrganization.Clone
                    moOrganization = oTempOrganization.Save

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

            Dim i As Integer

            '----------------------------------------------------------------
            '-- clear all ErrorProvider messages
            '----------------------------------------------------------------
            erpErrorProvider.SetError(Me.txtOrganizationName, "")
            erpErrorProvider.SetError(Me.txtPermitNumber, "")
            erpErrorProvider.SetError(Me.txtCcHatchlingStartingBalance, "")
            erpErrorProvider.SetError(Me.txtCmHatchlingStartingBalance, "")
            erpErrorProvider.SetError(Me.txtDcHatchlingStartingBalance, "")
            erpErrorProvider.SetError(Me.txtOtherHatchlingStartingBalance, "")
            erpErrorProvider.SetError(Me.txtUnknownHatchlingStartingBalance, "")
            erpErrorProvider.SetError(Me.txtCcWashbackStartingBalance, "")
            erpErrorProvider.SetError(Me.txtCmWashbackStartingBalance, "")
            erpErrorProvider.SetError(Me.txtDcWashbackStartingBalance, "")
            erpErrorProvider.SetError(Me.txtOtherWashbackStartingBalance, "")
            erpErrorProvider.SetError(Me.txtUnknownWashbackStartingBalance, "")

            '----------------------------------------------------------------
            '-- indicate any broken rules to the user
            '----------------------------------------------------------------
            If (bShowMessageBox) Then
                MessageBox.Show(" *** The following data validation issue(s) must be resolved before this package can be saved: *** " & ControlChars.CrLf & ControlChars.CrLf & moOrganization.GetBrokenRulesString, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            For i = 0 To moOrganization.BrokenRulesCollection.Count() - 1
                Select Case moOrganization.BrokenRulesCollection(i).Property
                    Case "OrganizationName"
                        erpErrorProvider.SetError(Me.txtOrganizationName, moOrganization.BrokenRulesCollection(i).Description)
                    Case "PermitNumber"
                        erpErrorProvider.SetError(Me.txtPermitNumber, moOrganization.BrokenRulesCollection(i).Description)
                    Case "CcHatchlingStartingBalance"
                        erpErrorProvider.SetError(Me.txtCcHatchlingStartingBalance, moOrganization.BrokenRulesCollection(i).Description)
                    Case "CmHatchlingStartingBalance"
                        erpErrorProvider.SetError(Me.txtCmHatchlingStartingBalance, moOrganization.BrokenRulesCollection(i).Description)
                    Case "DcHatchlingStartingBalance"
                        erpErrorProvider.SetError(Me.txtDcHatchlingStartingBalance, moOrganization.BrokenRulesCollection(i).Description)
                    Case "OtherHatchlingStartingBalance"
                        erpErrorProvider.SetError(Me.txtOtherHatchlingStartingBalance, moOrganization.BrokenRulesCollection(i).Description)
                    Case "UnknownHatchlingStartingBalance"
                        erpErrorProvider.SetError(Me.txtUnknownHatchlingStartingBalance, moOrganization.BrokenRulesCollection(i).Description)
                    Case "CcWashbackStartingBalance"
                        erpErrorProvider.SetError(Me.txtCcWashbackStartingBalance, moOrganization.BrokenRulesCollection(i).Description)
                    Case "CmWashbackStartingBalance"
                        erpErrorProvider.SetError(Me.txtCmWashbackStartingBalance, moOrganization.BrokenRulesCollection(i).Description)
                    Case "DcWashbackStartingBalance"
                        erpErrorProvider.SetError(Me.txtDcWashbackStartingBalance, moOrganization.BrokenRulesCollection(i).Description)
                    Case "OtherWashbackStartingBalance"
                        erpErrorProvider.SetError(Me.txtOtherWashbackStartingBalance, moOrganization.BrokenRulesCollection(i).Description)
                    Case "UnknownWashbackStartingBalance"
                        erpErrorProvider.SetError(Me.txtUnknownWashbackStartingBalance, moOrganization.BrokenRulesCollection(i).Description)
                End Select
            Next

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub CopyFormValuesToBusinessObject()

        '------------------------------------------------------------ 
        '-- copy the data from the form fields into the business object 
        '------------------------------------------------------------ 
        moOrganization.OrganizationName = Me.txtOrganizationName.Text.Trim
        moOrganization.PermitNumber = Me.txtPermitNumber.Text.Trim
        moOrganization.Address1 = Me.txtAddress1.Text.Trim
        moOrganization.Address2 = Me.txtAddress2.Text.Trim
        moOrganization.City = Me.txtCity.Text.Trim
        moOrganization.State = Me.txtState.Text.Trim
        moOrganization.ZipCode = Me.txtZipCode.Text.Trim
        moOrganization.Phone = Me.txtPhone.Text.Trim
        moOrganization.Fax = Me.txtFax.Text.Trim
        moOrganization.EmailAddress = Me.txtEmailAddress.Text.Trim
        moOrganization.ContactName = Me.txtContactName.Text.Trim

        moOrganization.HatchlingBalanceAsOfDate = Me.dtpHatchlingBalanceAsOfDate.DateValue
        moOrganization.CcHatchlingStartingBalance = Convert.ToInt32(Val(Me.txtCcHatchlingStartingBalance.Text.Trim))
        moOrganization.CmHatchlingStartingBalance = Convert.ToInt32(Val(Me.txtCmHatchlingStartingBalance.Text.Trim))
        moOrganization.DcHatchlingStartingBalance = Convert.ToInt32(Val(Me.txtDcHatchlingStartingBalance.Text.Trim))
        moOrganization.OtherHatchlingStartingBalance = Convert.ToInt32(Val(Me.txtOtherHatchlingStartingBalance.Text.Trim))
        moOrganization.UnknownHatchlingStartingBalance = Convert.ToInt32(Val(Me.txtUnknownHatchlingStartingBalance.Text.Trim))

        moOrganization.WashbackBalanceAsOfDate = Me.dtpWashbackBalanceAsOfDate.DateValue
        moOrganization.CcWashbackStartingBalance = Convert.ToInt32(Val(Me.txtCcWashbackStartingBalance.Text.Trim))
        moOrganization.CmWashbackStartingBalance = Convert.ToInt32(Val(Me.txtCmWashbackStartingBalance.Text.Trim))
        moOrganization.DcWashbackStartingBalance = Convert.ToInt32(Val(Me.txtDcWashbackStartingBalance.Text.Trim))
        moOrganization.OtherWashbackStartingBalance = Convert.ToInt32(Val(Me.txtOtherWashbackStartingBalance.Text.Trim))
        moOrganization.UnknownWashbackStartingBalance = Convert.ToInt32(Val(Me.txtUnknownWashbackStartingBalance.Text.Trim))

        If (Me.radUnitsTypeImperial.Checked = True) Then
            moOrganization.PreferredUnitsType = "I"
        Else
            moOrganization.PreferredUnitsType = "M"
        End If

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "ChangingOrganizationInformation.htm")
    End Sub

End Class
