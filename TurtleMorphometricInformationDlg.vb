Option Explicit On 
Option Strict On
Option Compare Text

Public Class TurtleMorphometricInformationDlg
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
    Friend WithEvents lblSclNotchNotch As System.Windows.Forms.Label
    Friend WithEvents txtSclNotchNotchValue As System.Windows.Forms.TextBox
    Friend WithEvents lblUnits As System.Windows.Forms.Label
    Friend WithEvents lblDateMeasured As System.Windows.Forms.Label
    Friend WithEvents dtpDateMeasured As TurtleGeek.Controls.DateComboBox
    Friend WithEvents cboSclNotchNotchUnitsList As System.Windows.Forms.ComboBox
    Friend WithEvents cboSclNotchTipUnitsList As System.Windows.Forms.ComboBox
    Friend WithEvents txtSclNotchTipValue As System.Windows.Forms.TextBox
    Friend WithEvents lblSclNotchTip As System.Windows.Forms.Label
    Friend WithEvents cboSclTipTipUnitsList As System.Windows.Forms.ComboBox
    Friend WithEvents txtSclTipTipValue As System.Windows.Forms.TextBox
    Friend WithEvents lblSclTipTip As System.Windows.Forms.Label
    Friend WithEvents cboScwUnitsList As System.Windows.Forms.ComboBox
    Friend WithEvents txtScwValue As System.Windows.Forms.TextBox
    Friend WithEvents lblScw As System.Windows.Forms.Label
    Friend WithEvents lblValue As System.Windows.Forms.Label
    Friend WithEvents cboCcwUnitsList As System.Windows.Forms.ComboBox
    Friend WithEvents txtCcwValue As System.Windows.Forms.TextBox
    Friend WithEvents lblCcw As System.Windows.Forms.Label
    Friend WithEvents cboCclTipTipUnitsList As System.Windows.Forms.ComboBox
    Friend WithEvents txtCclTipTipValue As System.Windows.Forms.TextBox
    Friend WithEvents lblCclTipTip As System.Windows.Forms.Label
    Friend WithEvents cboCclNotchTipUnitsList As System.Windows.Forms.ComboBox
    Friend WithEvents txtCclNotchTipValue As System.Windows.Forms.TextBox
    Friend WithEvents lblCclNotchTip As System.Windows.Forms.Label
    Friend WithEvents cboCclNotchNotchUnitsList As System.Windows.Forms.ComboBox
    Friend WithEvents txtCclNotchNotchValue As System.Windows.Forms.TextBox
    Friend WithEvents lblCclNotchNotch As System.Windows.Forms.Label
    Friend WithEvents cboWeightUnitsList As System.Windows.Forms.ComboBox
    Friend WithEvents txtWeightValue As System.Windows.Forms.TextBox
    Friend WithEvents lblWeight As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TurtleMorphometricInformationDlg))
        Me.lblSclNotchNotch = New System.Windows.Forms.Label
        Me.txtSclNotchNotchValue = New System.Windows.Forms.TextBox
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblUnits = New System.Windows.Forms.Label
        Me.lblDateMeasured = New System.Windows.Forms.Label
        Me.dtpDateMeasured = New TurtleGeek.Controls.DateComboBox
        Me.tipToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.cboSclNotchNotchUnitsList = New System.Windows.Forms.ComboBox
        Me.btnHelp = New System.Windows.Forms.Button
        Me.cboSclNotchTipUnitsList = New System.Windows.Forms.ComboBox
        Me.txtSclNotchTipValue = New System.Windows.Forms.TextBox
        Me.lblSclNotchTip = New System.Windows.Forms.Label
        Me.cboSclTipTipUnitsList = New System.Windows.Forms.ComboBox
        Me.txtSclTipTipValue = New System.Windows.Forms.TextBox
        Me.lblSclTipTip = New System.Windows.Forms.Label
        Me.cboScwUnitsList = New System.Windows.Forms.ComboBox
        Me.txtScwValue = New System.Windows.Forms.TextBox
        Me.lblScw = New System.Windows.Forms.Label
        Me.lblValue = New System.Windows.Forms.Label
        Me.cboCcwUnitsList = New System.Windows.Forms.ComboBox
        Me.txtCcwValue = New System.Windows.Forms.TextBox
        Me.lblCcw = New System.Windows.Forms.Label
        Me.cboCclTipTipUnitsList = New System.Windows.Forms.ComboBox
        Me.txtCclTipTipValue = New System.Windows.Forms.TextBox
        Me.lblCclTipTip = New System.Windows.Forms.Label
        Me.cboCclNotchTipUnitsList = New System.Windows.Forms.ComboBox
        Me.txtCclNotchTipValue = New System.Windows.Forms.TextBox
        Me.lblCclNotchTip = New System.Windows.Forms.Label
        Me.cboCclNotchNotchUnitsList = New System.Windows.Forms.ComboBox
        Me.txtCclNotchNotchValue = New System.Windows.Forms.TextBox
        Me.lblCclNotchNotch = New System.Windows.Forms.Label
        Me.cboWeightUnitsList = New System.Windows.Forms.ComboBox
        Me.txtWeightValue = New System.Windows.Forms.TextBox
        Me.lblWeight = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'lblSclNotchNotch
        '
        Me.lblSclNotchNotch.AutoSize = True
        Me.lblSclNotchNotch.Location = New System.Drawing.Point(8, 57)
        Me.lblSclNotchNotch.Name = "lblSclNotchNotch"
        Me.lblSclNotchNotch.Size = New System.Drawing.Size(90, 13)
        Me.lblSclNotchNotch.TabIndex = 4
        Me.lblSclNotchNotch.Text = "SCL notch-notch:"
        Me.lblSclNotchNotch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tipToolTip.SetToolTip(Me.lblSclNotchNotch, "Straight Carapace Length (notch-notch)")
        '
        'txtSclNotchNotchValue
        '
        Me.txtSclNotchNotchValue.Location = New System.Drawing.Point(112, 54)
        Me.txtSclNotchNotchValue.MaxLength = 10
        Me.txtSclNotchNotchValue.Name = "txtSclNotchNotchValue"
        Me.txtSclNotchNotchValue.Size = New System.Drawing.Size(100, 20)
        Me.txtSclNotchNotchValue.TabIndex = 5
        Me.tipToolTip.SetToolTip(Me.txtSclNotchNotchValue, "Straight Carapace Length (notch-notch) value")
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(8, 317)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(328, 2)
        Me.lblSeparator.TabIndex = 31
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(264, 333)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 33
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(184, 333)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 24)
        Me.btnOK.TabIndex = 32
        Me.btnOK.Text = "OK"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(215, 37)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(34, 13)
        Me.lblUnits.TabIndex = 3
        Me.lblUnits.Text = "Units:"
        Me.lblUnits.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateMeasured
        '
        Me.lblDateMeasured.AutoSize = True
        Me.lblDateMeasured.Location = New System.Drawing.Point(8, 16)
        Me.lblDateMeasured.Name = "lblDateMeasured"
        Me.lblDateMeasured.Size = New System.Drawing.Size(82, 13)
        Me.lblDateMeasured.TabIndex = 0
        Me.lblDateMeasured.Text = "Date measured:"
        Me.lblDateMeasured.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDateMeasured
        '
        Me.dtpDateMeasured.DateValue = New Date(2006, 5, 30, 23, 49, 39, 562)
        Me.dtpDateMeasured.Location = New System.Drawing.Point(112, 12)
        Me.dtpDateMeasured.Name = "dtpDateMeasured"
        Me.dtpDateMeasured.Size = New System.Drawing.Size(216, 20)
        Me.dtpDateMeasured.TabIndex = 1
        '
        'cboSclNotchNotchUnitsList
        '
        Me.cboSclNotchNotchUnitsList.Location = New System.Drawing.Point(218, 53)
        Me.cboSclNotchNotchUnitsList.Name = "cboSclNotchNotchUnitsList"
        Me.cboSclNotchNotchUnitsList.Size = New System.Drawing.Size(100, 21)
        Me.cboSclNotchNotchUnitsList.TabIndex = 6
        Me.tipToolTip.SetToolTip(Me.cboSclNotchNotchUnitsList, "Straight Carapace Length (notch-notch) units")
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(8, 333)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 24)
        Me.btnHelp.TabIndex = 34
        Me.btnHelp.Text = "Help"
        '
        'cboSclNotchTipUnitsList
        '
        Me.cboSclNotchTipUnitsList.Location = New System.Drawing.Point(218, 80)
        Me.cboSclNotchTipUnitsList.Name = "cboSclNotchTipUnitsList"
        Me.cboSclNotchTipUnitsList.Size = New System.Drawing.Size(100, 21)
        Me.cboSclNotchTipUnitsList.TabIndex = 9
        Me.tipToolTip.SetToolTip(Me.cboSclNotchTipUnitsList, "Straight Carapace Length (notch-tip) units")
        '
        'txtSclNotchTipValue
        '
        Me.txtSclNotchTipValue.Location = New System.Drawing.Point(112, 81)
        Me.txtSclNotchTipValue.MaxLength = 10
        Me.txtSclNotchTipValue.Name = "txtSclNotchTipValue"
        Me.txtSclNotchTipValue.Size = New System.Drawing.Size(100, 20)
        Me.txtSclNotchTipValue.TabIndex = 8
        Me.tipToolTip.SetToolTip(Me.txtSclNotchTipValue, "Straight Carapace Length (notch-tip) value")
        '
        'lblSclNotchTip
        '
        Me.lblSclNotchTip.AutoSize = True
        Me.lblSclNotchTip.Location = New System.Drawing.Point(8, 84)
        Me.lblSclNotchTip.Name = "lblSclNotchTip"
        Me.lblSclNotchTip.Size = New System.Drawing.Size(74, 13)
        Me.lblSclNotchTip.TabIndex = 7
        Me.lblSclNotchTip.Text = "SCL notch-tip:"
        Me.lblSclNotchTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tipToolTip.SetToolTip(Me.lblSclNotchTip, "Straight Carapace Length (notch-tip)")
        '
        'cboSclTipTipUnitsList
        '
        Me.cboSclTipTipUnitsList.Location = New System.Drawing.Point(218, 107)
        Me.cboSclTipTipUnitsList.Name = "cboSclTipTipUnitsList"
        Me.cboSclTipTipUnitsList.Size = New System.Drawing.Size(100, 21)
        Me.cboSclTipTipUnitsList.TabIndex = 12
        Me.tipToolTip.SetToolTip(Me.cboSclTipTipUnitsList, "Straight Carapace Length (tip-tip) units")
        '
        'txtSclTipTipValue
        '
        Me.txtSclTipTipValue.Location = New System.Drawing.Point(112, 108)
        Me.txtSclTipTipValue.MaxLength = 10
        Me.txtSclTipTipValue.Name = "txtSclTipTipValue"
        Me.txtSclTipTipValue.Size = New System.Drawing.Size(100, 20)
        Me.txtSclTipTipValue.TabIndex = 11
        Me.tipToolTip.SetToolTip(Me.txtSclTipTipValue, "Straight Carapace Length (tip-tip) value")
        '
        'lblSclTipTip
        '
        Me.lblSclTipTip.AutoSize = True
        Me.lblSclTipTip.Location = New System.Drawing.Point(8, 111)
        Me.lblSclTipTip.Name = "lblSclTipTip"
        Me.lblSclTipTip.Size = New System.Drawing.Size(58, 13)
        Me.lblSclTipTip.TabIndex = 10
        Me.lblSclTipTip.Text = "SCL tip-tip:"
        Me.lblSclTipTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tipToolTip.SetToolTip(Me.lblSclTipTip, "Straight Carapace Length (tip-tip)")
        '
        'cboScwUnitsList
        '
        Me.cboScwUnitsList.Location = New System.Drawing.Point(218, 133)
        Me.cboScwUnitsList.Name = "cboScwUnitsList"
        Me.cboScwUnitsList.Size = New System.Drawing.Size(100, 21)
        Me.cboScwUnitsList.TabIndex = 15
        Me.tipToolTip.SetToolTip(Me.cboScwUnitsList, "Straight Carapace Width units")
        '
        'txtScwValue
        '
        Me.txtScwValue.Location = New System.Drawing.Point(112, 134)
        Me.txtScwValue.MaxLength = 10
        Me.txtScwValue.Name = "txtScwValue"
        Me.txtScwValue.Size = New System.Drawing.Size(100, 20)
        Me.txtScwValue.TabIndex = 14
        Me.tipToolTip.SetToolTip(Me.txtScwValue, "Straight Carapace Width value")
        '
        'lblScw
        '
        Me.lblScw.AutoSize = True
        Me.lblScw.Location = New System.Drawing.Point(8, 137)
        Me.lblScw.Name = "lblScw"
        Me.lblScw.Size = New System.Drawing.Size(35, 13)
        Me.lblScw.TabIndex = 13
        Me.lblScw.Text = "SCW:"
        Me.lblScw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tipToolTip.SetToolTip(Me.lblScw, "Straight Carapace Width")
        '
        'lblValue
        '
        Me.lblValue.AutoSize = True
        Me.lblValue.Location = New System.Drawing.Point(109, 38)
        Me.lblValue.Name = "lblValue"
        Me.lblValue.Size = New System.Drawing.Size(37, 13)
        Me.lblValue.TabIndex = 2
        Me.lblValue.Text = "Value:"
        Me.lblValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboCcwUnitsList
        '
        Me.cboCcwUnitsList.Location = New System.Drawing.Point(218, 239)
        Me.cboCcwUnitsList.Name = "cboCcwUnitsList"
        Me.cboCcwUnitsList.Size = New System.Drawing.Size(100, 21)
        Me.cboCcwUnitsList.TabIndex = 27
        Me.tipToolTip.SetToolTip(Me.cboCcwUnitsList, "Curved Carapace Width units")
        '
        'txtCcwValue
        '
        Me.txtCcwValue.Location = New System.Drawing.Point(112, 240)
        Me.txtCcwValue.MaxLength = 10
        Me.txtCcwValue.Name = "txtCcwValue"
        Me.txtCcwValue.Size = New System.Drawing.Size(100, 20)
        Me.txtCcwValue.TabIndex = 26
        Me.tipToolTip.SetToolTip(Me.txtCcwValue, "Curved Carapace Width value")
        '
        'lblCcw
        '
        Me.lblCcw.AutoSize = True
        Me.lblCcw.Location = New System.Drawing.Point(8, 243)
        Me.lblCcw.Name = "lblCcw"
        Me.lblCcw.Size = New System.Drawing.Size(35, 13)
        Me.lblCcw.TabIndex = 25
        Me.lblCcw.Text = "CCW:"
        Me.lblCcw.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tipToolTip.SetToolTip(Me.lblCcw, "Curved Carapace Width")
        '
        'cboCclTipTipUnitsList
        '
        Me.cboCclTipTipUnitsList.Location = New System.Drawing.Point(218, 213)
        Me.cboCclTipTipUnitsList.Name = "cboCclTipTipUnitsList"
        Me.cboCclTipTipUnitsList.Size = New System.Drawing.Size(100, 21)
        Me.cboCclTipTipUnitsList.TabIndex = 24
        Me.tipToolTip.SetToolTip(Me.cboCclTipTipUnitsList, "Curved Carapace Length (tip-tip) units")
        '
        'txtCclTipTipValue
        '
        Me.txtCclTipTipValue.Location = New System.Drawing.Point(112, 214)
        Me.txtCclTipTipValue.MaxLength = 10
        Me.txtCclTipTipValue.Name = "txtCclTipTipValue"
        Me.txtCclTipTipValue.Size = New System.Drawing.Size(100, 20)
        Me.txtCclTipTipValue.TabIndex = 23
        Me.tipToolTip.SetToolTip(Me.txtCclTipTipValue, "Curved Carapace Length (tip-tip) value")
        '
        'lblCclTipTip
        '
        Me.lblCclTipTip.AutoSize = True
        Me.lblCclTipTip.Location = New System.Drawing.Point(8, 217)
        Me.lblCclTipTip.Name = "lblCclTipTip"
        Me.lblCclTipTip.Size = New System.Drawing.Size(58, 13)
        Me.lblCclTipTip.TabIndex = 22
        Me.lblCclTipTip.Text = "CCL tip-tip:"
        Me.lblCclTipTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tipToolTip.SetToolTip(Me.lblCclTipTip, "Curved Carapace Length (tip-tip)")
        '
        'cboCclNotchTipUnitsList
        '
        Me.cboCclNotchTipUnitsList.Location = New System.Drawing.Point(218, 186)
        Me.cboCclNotchTipUnitsList.Name = "cboCclNotchTipUnitsList"
        Me.cboCclNotchTipUnitsList.Size = New System.Drawing.Size(100, 21)
        Me.cboCclNotchTipUnitsList.TabIndex = 21
        Me.tipToolTip.SetToolTip(Me.cboCclNotchTipUnitsList, "Curved Carapace Length (notch-tip) units")
        '
        'txtCclNotchTipValue
        '
        Me.txtCclNotchTipValue.Location = New System.Drawing.Point(112, 187)
        Me.txtCclNotchTipValue.MaxLength = 10
        Me.txtCclNotchTipValue.Name = "txtCclNotchTipValue"
        Me.txtCclNotchTipValue.Size = New System.Drawing.Size(100, 20)
        Me.txtCclNotchTipValue.TabIndex = 20
        Me.tipToolTip.SetToolTip(Me.txtCclNotchTipValue, "Curved Carapace Length (notch-tip) value")
        '
        'lblCclNotchTip
        '
        Me.lblCclNotchTip.AutoSize = True
        Me.lblCclNotchTip.Location = New System.Drawing.Point(8, 190)
        Me.lblCclNotchTip.Name = "lblCclNotchTip"
        Me.lblCclNotchTip.Size = New System.Drawing.Size(74, 13)
        Me.lblCclNotchTip.TabIndex = 19
        Me.lblCclNotchTip.Text = "CCL notch-tip:"
        Me.lblCclNotchTip.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tipToolTip.SetToolTip(Me.lblCclNotchTip, "Curved Carapace Length (notch-tip)")
        '
        'cboCclNotchNotchUnitsList
        '
        Me.cboCclNotchNotchUnitsList.Location = New System.Drawing.Point(218, 159)
        Me.cboCclNotchNotchUnitsList.Name = "cboCclNotchNotchUnitsList"
        Me.cboCclNotchNotchUnitsList.Size = New System.Drawing.Size(100, 21)
        Me.cboCclNotchNotchUnitsList.TabIndex = 18
        Me.tipToolTip.SetToolTip(Me.cboCclNotchNotchUnitsList, "Curved Carapace Length (notch-notch) units")
        '
        'txtCclNotchNotchValue
        '
        Me.txtCclNotchNotchValue.Location = New System.Drawing.Point(112, 160)
        Me.txtCclNotchNotchValue.MaxLength = 10
        Me.txtCclNotchNotchValue.Name = "txtCclNotchNotchValue"
        Me.txtCclNotchNotchValue.Size = New System.Drawing.Size(100, 20)
        Me.txtCclNotchNotchValue.TabIndex = 17
        Me.tipToolTip.SetToolTip(Me.txtCclNotchNotchValue, "Curved Carapace Length (notch-notch) value")
        '
        'lblCclNotchNotch
        '
        Me.lblCclNotchNotch.AutoSize = True
        Me.lblCclNotchNotch.Location = New System.Drawing.Point(8, 163)
        Me.lblCclNotchNotch.Name = "lblCclNotchNotch"
        Me.lblCclNotchNotch.Size = New System.Drawing.Size(90, 13)
        Me.lblCclNotchNotch.TabIndex = 16
        Me.lblCclNotchNotch.Text = "CCL notch-notch:"
        Me.lblCclNotchNotch.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.tipToolTip.SetToolTip(Me.lblCclNotchNotch, "Curved Carapace Length (notch-notch)")
        '
        'cboWeightUnitsList
        '
        Me.cboWeightUnitsList.Location = New System.Drawing.Point(218, 266)
        Me.cboWeightUnitsList.Name = "cboWeightUnitsList"
        Me.cboWeightUnitsList.Size = New System.Drawing.Size(100, 21)
        Me.cboWeightUnitsList.TabIndex = 30
        '
        'txtWeightValue
        '
        Me.txtWeightValue.Location = New System.Drawing.Point(112, 267)
        Me.txtWeightValue.MaxLength = 10
        Me.txtWeightValue.Name = "txtWeightValue"
        Me.txtWeightValue.Size = New System.Drawing.Size(100, 20)
        Me.txtWeightValue.TabIndex = 29
        '
        'lblWeight
        '
        Me.lblWeight.AutoSize = True
        Me.lblWeight.Location = New System.Drawing.Point(8, 270)
        Me.lblWeight.Name = "lblWeight"
        Me.lblWeight.Size = New System.Drawing.Size(44, 13)
        Me.lblWeight.TabIndex = 28
        Me.lblWeight.Text = "Weight:"
        Me.lblWeight.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'TurtleMorphometricInformationDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(346, 372)
        Me.Controls.Add(Me.cboWeightUnitsList)
        Me.Controls.Add(Me.txtWeightValue)
        Me.Controls.Add(Me.lblWeight)
        Me.Controls.Add(Me.cboCcwUnitsList)
        Me.Controls.Add(Me.txtCcwValue)
        Me.Controls.Add(Me.lblCcw)
        Me.Controls.Add(Me.cboCclTipTipUnitsList)
        Me.Controls.Add(Me.txtCclTipTipValue)
        Me.Controls.Add(Me.lblCclTipTip)
        Me.Controls.Add(Me.cboCclNotchTipUnitsList)
        Me.Controls.Add(Me.txtCclNotchTipValue)
        Me.Controls.Add(Me.lblCclNotchTip)
        Me.Controls.Add(Me.cboCclNotchNotchUnitsList)
        Me.Controls.Add(Me.txtCclNotchNotchValue)
        Me.Controls.Add(Me.lblCclNotchNotch)
        Me.Controls.Add(Me.lblValue)
        Me.Controls.Add(Me.cboScwUnitsList)
        Me.Controls.Add(Me.txtScwValue)
        Me.Controls.Add(Me.lblScw)
        Me.Controls.Add(Me.cboSclTipTipUnitsList)
        Me.Controls.Add(Me.txtSclTipTipValue)
        Me.Controls.Add(Me.lblSclTipTip)
        Me.Controls.Add(Me.cboSclNotchTipUnitsList)
        Me.Controls.Add(Me.txtSclNotchTipValue)
        Me.Controls.Add(Me.lblSclNotchTip)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.cboSclNotchNotchUnitsList)
        Me.Controls.Add(Me.lblDateMeasured)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.txtSclNotchNotchValue)
        Me.Controls.Add(Me.lblSclNotchNotch)
        Me.Controls.Add(Me.dtpDateMeasured)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TurtleMorphometricInformationDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Morphometric Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mbIsOkayButtonClicked As Boolean = False
    Private moTurtleMorphometric As TurtleMorphometric

    Public Property TurtleMorphometric() As TurtleMorphometric
        Get
            Return moTurtleMorphometric
        End Get
        Set(ByVal Value As TurtleMorphometric)
            moTurtleMorphometric = Value
        End Set
    End Property

    Public Sub New(ByVal oTurtleMorphometric As TurtleMorphometric)

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None

        moTurtleMorphometric = oTurtleMorphometric

    End Sub

    Private Sub frmTurtleMorphometricInformationDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim oOrganization As Organization

        Try

            '*** ASSERTION ***
            If moTurtleMorphometric Is Nothing Then
                Throw New ApplicationException("TurtleMorphometric object must be set before opening this screen.")
            End If
            '*** ASSERTION ***

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            oOrganization = Organization.GetOrganization()

            '----------------------------------------------------------------
            '-- populate the comboboxes
            '----------------------------------------------------------------
            Me.cboSclNotchNotchUnitsList.DisplayMember = "Value"
            Me.cboSclNotchNotchUnitsList.ValueMember = "Key"
            Me.cboSclNotchNotchUnitsList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.CmIn, False)

            Me.cboSclNotchTipUnitsList.DisplayMember = "Value"
            Me.cboSclNotchTipUnitsList.ValueMember = "Key"
            Me.cboSclNotchTipUnitsList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.CmIn, False)

            Me.cboSclTipTipUnitsList.DisplayMember = "Value"
            Me.cboSclTipTipUnitsList.ValueMember = "Key"
            Me.cboSclTipTipUnitsList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.CmIn, False)

            Me.cboScwUnitsList.DisplayMember = "Value"
            Me.cboScwUnitsList.ValueMember = "Key"
            Me.cboScwUnitsList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.CmIn, False)

            Me.cboCclNotchNotchUnitsList.DisplayMember = "Value"
            Me.cboCclNotchNotchUnitsList.ValueMember = "Key"
            Me.cboCclNotchNotchUnitsList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.CmIn, False)

            Me.cboCclNotchTipUnitsList.DisplayMember = "Value"
            Me.cboCclNotchTipUnitsList.ValueMember = "Key"
            Me.cboCclNotchTipUnitsList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.CmIn, False)

            Me.cboCclTipTipUnitsList.DisplayMember = "Value"
            Me.cboCclTipTipUnitsList.ValueMember = "Key"
            Me.cboCclTipTipUnitsList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.CmIn, False)

            Me.cboCcwUnitsList.DisplayMember = "Value"
            Me.cboCcwUnitsList.ValueMember = "Key"
            Me.cboCcwUnitsList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.CmIn, False)

            Me.cboWeightUnitsList.DisplayMember = "Value"
            Me.cboWeightUnitsList.ValueMember = "Key"
            Me.cboWeightUnitsList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.KgLb, False)

            '----------------------------------------------------------------
            '-- default to TODAY
            '----------------------------------------------------------------
            Me.dtpDateMeasured.DateValue = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)

            '----------------------------------------------------------------
            '-- load the form fields with the data values
            '----------------------------------------------------------------
            moTurtleMorphometric.BeginEdit()

            Me.dtpDateMeasured.DateValue = moTurtleMorphometric.DateMeasured

            Me.txtSclNotchNotchValue.Text = moTurtleMorphometric.SclNotchNotchValueString

            If String.IsNullOrEmpty(moTurtleMorphometric.SclNotchNotchValueString) Then
                If (oOrganization.PreferredUnitsType = "M") Then
                    Me.cboSclNotchNotchUnitsList.Text = "cm"
                Else
                    Me.cboSclNotchNotchUnitsList.Text = "in"
                End If
            Else
                Me.cboSclNotchNotchUnitsList.Text = moTurtleMorphometric.SclNotchNotchUnits
            End If

            Me.txtSclNotchTipValue.Text = moTurtleMorphometric.SclNotchTipValueString

            If String.IsNullOrEmpty(moTurtleMorphometric.SclNotchTipValueString) Then
                If (oOrganization.PreferredUnitsType = "M") Then
                    Me.cboSclNotchTipUnitsList.Text = "cm"
                Else
                    Me.cboSclNotchTipUnitsList.Text = "in"
                End If
            Else
                Me.cboSclNotchTipUnitsList.Text = moTurtleMorphometric.SclNotchTipUnits
            End If

            Me.txtSclTipTipValue.Text = moTurtleMorphometric.SclTipTipValueString

            If String.IsNullOrEmpty(moTurtleMorphometric.SclTipTipValueString) Then
                If (oOrganization.PreferredUnitsType = "M") Then
                    Me.cboSclTipTipUnitsList.Text = "cm"
                Else
                    Me.cboSclTipTipUnitsList.Text = "in"
                End If
            Else
                Me.cboSclTipTipUnitsList.Text = moTurtleMorphometric.SclTipTipUnits
            End If

            Me.txtScwValue.Text = moTurtleMorphometric.ScwValueString

            If String.IsNullOrEmpty(moTurtleMorphometric.CcwValueString) Then
                If (oOrganization.PreferredUnitsType = "M") Then
                    Me.cboCcwUnitsList.Text = "cm"
                Else
                    Me.cboCcwUnitsList.Text = "in"
                End If
            Else
                Me.cboCcwUnitsList.Text = moTurtleMorphometric.CcwUnits
            End If

            Me.txtCclNotchNotchValue.Text = moTurtleMorphometric.CclNotchNotchValueString

            If String.IsNullOrEmpty(moTurtleMorphometric.CclNotchNotchValueString) Then
                If (oOrganization.PreferredUnitsType = "M") Then
                    Me.cboCclNotchNotchUnitsList.Text = "cm"
                Else
                    Me.cboCclNotchNotchUnitsList.Text = "in"
                End If
            Else
                Me.cboCclNotchNotchUnitsList.Text = moTurtleMorphometric.CclNotchNotchUnits
            End If

            Me.txtCclNotchTipValue.Text = moTurtleMorphometric.CclNotchTipValueString

            If String.IsNullOrEmpty(moTurtleMorphometric.CclNotchTipValueString) Then
                If (oOrganization.PreferredUnitsType = "M") Then
                    Me.cboCclNotchTipUnitsList.Text = "cm"
                Else
                    Me.cboCclNotchTipUnitsList.Text = "in"
                End If
            Else
                Me.cboCclNotchTipUnitsList.Text = moTurtleMorphometric.CclNotchTipUnits
            End If

            Me.txtCclTipTipValue.Text = moTurtleMorphometric.CclTipTipValueString

            If String.IsNullOrEmpty(moTurtleMorphometric.CclTipTipValueString) Then
                If (oOrganization.PreferredUnitsType = "M") Then
                    Me.cboCclTipTipUnitsList.Text = "cm"
                Else
                    Me.cboCclTipTipUnitsList.Text = "in"
                End If
            Else
                Me.cboCclTipTipUnitsList.Text = moTurtleMorphometric.CclTipTipUnits
            End If

            Me.txtCcwValue.Text = moTurtleMorphometric.CcwValueString

            If String.IsNullOrEmpty(moTurtleMorphometric.CcwValueString) Then
                If (oOrganization.PreferredUnitsType = "M") Then
                    Me.cboCcwUnitsList.Text = "cm"
                Else
                    Me.cboCcwUnitsList.Text = "in"
                End If
            Else
                Me.cboCcwUnitsList.Text = moTurtleMorphometric.CcwUnits
            End If

            Me.txtWeightValue.Text = moTurtleMorphometric.WeightValueString

            If String.IsNullOrEmpty(moTurtleMorphometric.WeightValueString) Then
                If (oOrganization.PreferredUnitsType = "M") Then
                    Me.cboWeightUnitsList.Text = "kg"
                Else
                    Me.cboWeightUnitsList.Text = "lb"
                End If
            Else
                Me.cboWeightUnitsList.Text = moTurtleMorphometric.WeightUnits
            End If

            '----------------------------------------------------------------
            '-- display required field indicators 
            '----------------------------------------------------------------
            Me.DisplayBrokenRules(False)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub frmTurtleMorphometricInformationDlg_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

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
            If moTurtleMorphometric.IsModified Then

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
            moTurtleMorphometric.CancelEdit()
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
        'Dim oTempTurtleMorphometric As TurtleMorphometric

        Try
            '------------------------------------------------------------ 
            '-- if the object has changed... 
            '------------------------------------------------------------ 
            If moTurtleMorphometric.IsDirty Then

                '------------------------------------------------------------ 
                '-- if all of the validation rules have passed... 
                '------------------------------------------------------------ 
                If moTurtleMorphometric.IsValid Then

                    '------------------------------------------------------------ 
                    '-- commit edits in memory
                    '------------------------------------------------------------ 
                    moTurtleMorphometric.ApplyEdit()

                    '----------------------------------------------------------------
                    '-- clone and save the object (it is the CSLA way)
                    '----------------------------------------------------------------
                    'oTempTurtleMorphometric = moTempTurtleMorphometric.Clone
                    'moTempTurtleMorphometric = oTempTurtleMorphometric.Save

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
                MessageBox.Show(" *** The following data validation issue(s) must be resolved before this package can be saved: *** " & ControlChars.CrLf & ControlChars.CrLf & moTurtleMorphometric.GetBrokenRulesString, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
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
        moTurtleMorphometric.DateMeasured = Me.dtpDateMeasured.DateValue

        moTurtleMorphometric.SclNotchNotchValueString = Me.txtSclNotchNotchValue.Text.Trim

        If String.IsNullOrEmpty(moTurtleMorphometric.SclNotchNotchValueString) Then
            moTurtleMorphometric.SclNotchNotchUnits = String.Empty
        Else
            moTurtleMorphometric.SclNotchNotchUnits = Me.cboSclNotchNotchUnitsList.Text.Trim
        End If

        moTurtleMorphometric.SclNotchTipValueString = Me.txtSclNotchTipValue.Text.Trim

        If String.IsNullOrEmpty(moTurtleMorphometric.SclNotchTipValueString) Then
            moTurtleMorphometric.SclNotchTipUnits = String.Empty
        Else
            moTurtleMorphometric.SclNotchTipUnits = Me.cboSclNotchTipUnitsList.Text.Trim
        End If

        moTurtleMorphometric.SclTipTipValueString = Me.txtSclTipTipValue.Text.Trim

        If String.IsNullOrEmpty(moTurtleMorphometric.SclTipTipValueString) Then
            moTurtleMorphometric.SclTipTipUnits = String.Empty
        Else
            moTurtleMorphometric.SclTipTipUnits = Me.cboSclTipTipUnitsList.Text.Trim
        End If

        moTurtleMorphometric.ScwValueString = Me.txtScwValue.Text.Trim

        If String.IsNullOrEmpty(moTurtleMorphometric.ScwValueString) Then
            moTurtleMorphometric.ScwUnits = String.Empty
        Else
            moTurtleMorphometric.ScwUnits = Me.cboScwUnitsList.Text.Trim
        End If

        moTurtleMorphometric.CclNotchNotchValueString = Me.txtCclNotchNotchValue.Text.Trim

        If String.IsNullOrEmpty(moTurtleMorphometric.CclNotchNotchValueString) Then
            moTurtleMorphometric.CclNotchNotchUnits = String.Empty
        Else
            moTurtleMorphometric.CclNotchNotchUnits = Me.cboCclNotchNotchUnitsList.Text.Trim
        End If

        moTurtleMorphometric.CclNotchTipValueString = Me.txtCclNotchTipValue.Text.Trim

        If String.IsNullOrEmpty(moTurtleMorphometric.CclNotchTipValueString) Then
            moTurtleMorphometric.CclNotchTipUnits = String.Empty
        Else
            moTurtleMorphometric.CclNotchTipUnits = Me.cboCclNotchTipUnitsList.Text.Trim
        End If

        moTurtleMorphometric.CclTipTipValueString = Me.txtCclTipTipValue.Text.Trim

        If String.IsNullOrEmpty(moTurtleMorphometric.CclTipTipValueString) Then
            moTurtleMorphometric.CclTipTipUnits = String.Empty
        Else
            moTurtleMorphometric.CclTipTipUnits = Me.cboCclTipTipUnitsList.Text.Trim
        End If

        moTurtleMorphometric.CcwValueString = Me.txtCcwValue.Text.Trim

        If String.IsNullOrEmpty(moTurtleMorphometric.CcwValueString) Then
            moTurtleMorphometric.CcwUnits = String.Empty
        Else
            moTurtleMorphometric.CcwUnits = Me.cboCcwUnitsList.Text.Trim
        End If

        moTurtleMorphometric.WeightValueString = Me.txtWeightValue.Text.Trim

        If String.IsNullOrEmpty(moTurtleMorphometric.WeightValueString) Then
            moTurtleMorphometric.WeightUnits = String.Empty
        Else
            moTurtleMorphometric.WeightUnits = Me.cboWeightUnitsList.Text.Trim
        End If

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "MorphometricInformationScreen.htm")
    End Sub

End Class
