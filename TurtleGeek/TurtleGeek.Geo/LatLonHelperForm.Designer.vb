<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LatLonHelperForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LatLonHelperForm))
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblLatitudeDecimalDegreesLabel = New System.Windows.Forms.Label
        Me.lblLatitudeDegrees = New System.Windows.Forms.Label
        Me.txtLatitudeDmsDegrees = New System.Windows.Forms.TextBox
        Me.txtLatitudeDmsMinutes = New System.Windows.Forms.TextBox
        Me.lblLatitudeMinutes = New System.Windows.Forms.Label
        Me.txtLatitudeDmsSeconds = New System.Windows.Forms.TextBox
        Me.lblLatitudeSeconds = New System.Windows.Forms.Label
        Me.radNorth = New System.Windows.Forms.RadioButton
        Me.radSouth = New System.Windows.Forms.RadioButton
        Me.txtLatitudeDecimalDegrees = New System.Windows.Forms.TextBox
        Me.pnlLatitude = New System.Windows.Forms.Panel
        Me.pnlLongitude = New System.Windows.Forms.Panel
        Me.radWest = New System.Windows.Forms.RadioButton
        Me.radEast = New System.Windows.Forms.RadioButton
        Me.lnkLatitudeCopyDms = New System.Windows.Forms.LinkLabel
        Me.lblLatitude = New System.Windows.Forms.Label
        Me.lblLongitude = New System.Windows.Forms.Label
        Me.tipToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lnkLongitudeCopyDms = New System.Windows.Forms.LinkLabel
        Me.lnkMapIt = New System.Windows.Forms.LinkLabel
        Me.lnkLatitudeCopyDdm = New System.Windows.Forms.LinkLabel
        Me.lnkLongitudeCopyDdm = New System.Windows.Forms.LinkLabel
        Me.txtLongitudeDecimalDegrees = New System.Windows.Forms.TextBox
        Me.txtLongitudeDmsSeconds = New System.Windows.Forms.TextBox
        Me.lblLongitudeSeconds = New System.Windows.Forms.Label
        Me.txtLongitudeDmsMinutes = New System.Windows.Forms.TextBox
        Me.lblLongitudeMinutes = New System.Windows.Forms.Label
        Me.txtLongitudeDmsDegrees = New System.Windows.Forms.TextBox
        Me.lblLongitudeDegrees = New System.Windows.Forms.Label
        Me.lblLongitudeDecimalDegrees = New System.Windows.Forms.Label
        Me.imlImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.lblConvertLatitudeImageDmsDd = New System.Windows.Forms.Label
        Me.lblConvertLongitudeImageDmsDd = New System.Windows.Forms.Label
        Me.lblConvertLatitudeImageDdDdm = New System.Windows.Forms.Label
        Me.txtLatitudeDdmDegrees = New System.Windows.Forms.TextBox
        Me.lblLatitudeDegreesDecimalMintuesLabel = New System.Windows.Forms.Label
        Me.lblConvertLongitudeImageDdDdm = New System.Windows.Forms.Label
        Me.txtLongitudeDdmDegrees = New System.Windows.Forms.TextBox
        Me.lblLongitudeDegreesDecimalMinutes = New System.Windows.Forms.Label
        Me.txtLatitudeDdmMinutes = New System.Windows.Forms.TextBox
        Me.txtLongitudeDdmMinutes = New System.Windows.Forms.TextBox
        Me.pnlLatitude.SuspendLayout()
        Me.pnlLongitude.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(4, 198)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(631, 2)
        Me.lblSeparator.TabIndex = 34
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(560, 208)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 37
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(480, 208)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 24)
        Me.btnOK.TabIndex = 36
        Me.btnOK.Text = "OK"
        '
        'lblLatitudeDecimalDegreesLabel
        '
        Me.lblLatitudeDecimalDegreesLabel.AutoSize = True
        Me.lblLatitudeDecimalDegreesLabel.Location = New System.Drawing.Point(332, 19)
        Me.lblLatitudeDecimalDegreesLabel.Name = "lblLatitudeDecimalDegreesLabel"
        Me.lblLatitudeDecimalDegreesLabel.Size = New System.Drawing.Size(89, 13)
        Me.lblLatitudeDecimalDegreesLabel.TabIndex = 10
        Me.lblLatitudeDecimalDegreesLabel.Text = "Decimal degrees:"
        '
        'lblLatitudeDegrees
        '
        Me.lblLatitudeDegrees.AutoSize = True
        Me.lblLatitudeDegrees.Location = New System.Drawing.Point(103, 19)
        Me.lblLatitudeDegrees.Name = "lblLatitudeDegrees"
        Me.lblLatitudeDegrees.Size = New System.Drawing.Size(50, 13)
        Me.lblLatitudeDegrees.TabIndex = 2
        Me.lblLatitudeDegrees.Text = "Degrees:"
        '
        'txtLatitudeDmsDegrees
        '
        Me.txtLatitudeDmsDegrees.Location = New System.Drawing.Point(106, 35)
        Me.txtLatitudeDmsDegrees.MaxLength = 3
        Me.txtLatitudeDmsDegrees.Name = "txtLatitudeDmsDegrees"
        Me.txtLatitudeDmsDegrees.Size = New System.Drawing.Size(49, 20)
        Me.txtLatitudeDmsDegrees.TabIndex = 3
        '
        'txtLatitudeDmsMinutes
        '
        Me.txtLatitudeDmsMinutes.Location = New System.Drawing.Point(161, 35)
        Me.txtLatitudeDmsMinutes.MaxLength = 2
        Me.txtLatitudeDmsMinutes.Name = "txtLatitudeDmsMinutes"
        Me.txtLatitudeDmsMinutes.Size = New System.Drawing.Size(49, 20)
        Me.txtLatitudeDmsMinutes.TabIndex = 5
        '
        'lblLatitudeMinutes
        '
        Me.lblLatitudeMinutes.AutoSize = True
        Me.lblLatitudeMinutes.Location = New System.Drawing.Point(158, 19)
        Me.lblLatitudeMinutes.Name = "lblLatitudeMinutes"
        Me.lblLatitudeMinutes.Size = New System.Drawing.Size(47, 13)
        Me.lblLatitudeMinutes.TabIndex = 4
        Me.lblLatitudeMinutes.Text = "Minutes:"
        '
        'txtLatitudeDmsSeconds
        '
        Me.txtLatitudeDmsSeconds.Location = New System.Drawing.Point(216, 35)
        Me.txtLatitudeDmsSeconds.MaxLength = 7
        Me.txtLatitudeDmsSeconds.Name = "txtLatitudeDmsSeconds"
        Me.txtLatitudeDmsSeconds.Size = New System.Drawing.Size(49, 20)
        Me.txtLatitudeDmsSeconds.TabIndex = 7
        '
        'lblLatitudeSeconds
        '
        Me.lblLatitudeSeconds.AutoSize = True
        Me.lblLatitudeSeconds.Location = New System.Drawing.Point(213, 19)
        Me.lblLatitudeSeconds.Name = "lblLatitudeSeconds"
        Me.lblLatitudeSeconds.Size = New System.Drawing.Size(52, 13)
        Me.lblLatitudeSeconds.TabIndex = 6
        Me.lblLatitudeSeconds.Text = "Seconds:"
        '
        'radNorth
        '
        Me.radNorth.AutoSize = True
        Me.radNorth.Checked = True
        Me.radNorth.Location = New System.Drawing.Point(3, 3)
        Me.radNorth.Name = "radNorth"
        Me.radNorth.Size = New System.Drawing.Size(51, 17)
        Me.radNorth.TabIndex = 0
        Me.radNorth.TabStop = True
        Me.radNorth.Text = "North"
        Me.radNorth.UseVisualStyleBackColor = True
        '
        'radSouth
        '
        Me.radSouth.AutoSize = True
        Me.radSouth.Location = New System.Drawing.Point(3, 21)
        Me.radSouth.Name = "radSouth"
        Me.radSouth.Size = New System.Drawing.Size(53, 17)
        Me.radSouth.TabIndex = 1
        Me.radSouth.Text = "South"
        Me.radSouth.UseVisualStyleBackColor = True
        '
        'txtLatitudeDecimalDegrees
        '
        Me.txtLatitudeDecimalDegrees.Location = New System.Drawing.Point(335, 35)
        Me.txtLatitudeDecimalDegrees.MaxLength = 10
        Me.txtLatitudeDecimalDegrees.Name = "txtLatitudeDecimalDegrees"
        Me.txtLatitudeDecimalDegrees.Size = New System.Drawing.Size(100, 20)
        Me.txtLatitudeDecimalDegrees.TabIndex = 11
        '
        'pnlLatitude
        '
        Me.pnlLatitude.Controls.Add(Me.radNorth)
        Me.pnlLatitude.Controls.Add(Me.radSouth)
        Me.pnlLatitude.Location = New System.Drawing.Point(15, 28)
        Me.pnlLatitude.Name = "pnlLatitude"
        Me.pnlLatitude.Size = New System.Drawing.Size(68, 41)
        Me.pnlLatitude.TabIndex = 1
        '
        'pnlLongitude
        '
        Me.pnlLongitude.Controls.Add(Me.radWest)
        Me.pnlLongitude.Controls.Add(Me.radEast)
        Me.pnlLongitude.Location = New System.Drawing.Point(15, 127)
        Me.pnlLongitude.Name = "pnlLongitude"
        Me.pnlLongitude.Size = New System.Drawing.Size(68, 41)
        Me.pnlLongitude.TabIndex = 18
        '
        'radWest
        '
        Me.radWest.AutoSize = True
        Me.radWest.Checked = True
        Me.radWest.Location = New System.Drawing.Point(3, 3)
        Me.radWest.Name = "radWest"
        Me.radWest.Size = New System.Drawing.Size(50, 17)
        Me.radWest.TabIndex = 0
        Me.radWest.TabStop = True
        Me.radWest.Text = "West"
        Me.radWest.UseVisualStyleBackColor = True
        '
        'radEast
        '
        Me.radEast.AutoSize = True
        Me.radEast.Location = New System.Drawing.Point(3, 21)
        Me.radEast.Name = "radEast"
        Me.radEast.Size = New System.Drawing.Size(46, 17)
        Me.radEast.TabIndex = 1
        Me.radEast.Text = "East"
        Me.radEast.UseVisualStyleBackColor = True
        '
        'lnkLatitudeCopyDms
        '
        Me.lnkLatitudeCopyDms.AutoSize = True
        Me.lnkLatitudeCopyDms.Location = New System.Drawing.Point(143, 58)
        Me.lnkLatitudeCopyDms.Name = "lnkLatitudeCopyDms"
        Me.lnkLatitudeCopyDms.Size = New System.Drawing.Size(88, 13)
        Me.lnkLatitudeCopyDms.TabIndex = 8
        Me.lnkLatitudeCopyDms.TabStop = True
        Me.lnkLatitudeCopyDms.Text = "copy to clipboard"
        Me.tipToolTip.SetToolTip(Me.lnkLatitudeCopyDms, "Copy the degrees/minutes/seconds to the Windows clipboard")
        '
        'lblLatitude
        '
        Me.lblLatitude.AutoSize = True
        Me.lblLatitude.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLatitude.Location = New System.Drawing.Point(12, 9)
        Me.lblLatitude.Name = "lblLatitude"
        Me.lblLatitude.Size = New System.Drawing.Size(73, 16)
        Me.lblLatitude.TabIndex = 0
        Me.lblLatitude.Text = "Latitude:"
        '
        'lblLongitude
        '
        Me.lblLongitude.AutoSize = True
        Me.lblLongitude.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLongitude.Location = New System.Drawing.Point(12, 108)
        Me.lblLongitude.Name = "lblLongitude"
        Me.lblLongitude.Size = New System.Drawing.Size(85, 16)
        Me.lblLongitude.TabIndex = 17
        Me.lblLongitude.Text = "Longitude:"
        '
        'lnkLongitudeCopyDms
        '
        Me.lnkLongitudeCopyDms.AutoSize = True
        Me.lnkLongitudeCopyDms.Location = New System.Drawing.Point(143, 159)
        Me.lnkLongitudeCopyDms.Name = "lnkLongitudeCopyDms"
        Me.lnkLongitudeCopyDms.Size = New System.Drawing.Size(88, 13)
        Me.lnkLongitudeCopyDms.TabIndex = 25
        Me.lnkLongitudeCopyDms.TabStop = True
        Me.lnkLongitudeCopyDms.Text = "copy to clipboard"
        Me.tipToolTip.SetToolTip(Me.lnkLongitudeCopyDms, "Copy the degrees/minutes/seconds to the Windows clipboard")
        '
        'lnkMapIt
        '
        Me.lnkMapIt.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkMapIt.AutoSize = True
        Me.lnkMapIt.Location = New System.Drawing.Point(12, 214)
        Me.lnkMapIt.Name = "lnkMapIt"
        Me.lnkMapIt.Size = New System.Drawing.Size(35, 13)
        Me.lnkMapIt.TabIndex = 35
        Me.lnkMapIt.TabStop = True
        Me.lnkMapIt.Text = "map it"
        Me.tipToolTip.SetToolTip(Me.lnkMapIt, "Map the latitude and longitude point")
        '
        'lnkLatitudeCopyDdm
        '
        Me.lnkLatitudeCopyDdm.AutoSize = True
        Me.lnkLatitudeCopyDdm.Location = New System.Drawing.Point(523, 58)
        Me.lnkLatitudeCopyDdm.Name = "lnkLatitudeCopyDdm"
        Me.lnkLatitudeCopyDdm.Size = New System.Drawing.Size(88, 13)
        Me.lnkLatitudeCopyDdm.TabIndex = 16
        Me.lnkLatitudeCopyDdm.TabStop = True
        Me.lnkLatitudeCopyDdm.Text = "copy to clipboard"
        Me.tipToolTip.SetToolTip(Me.lnkLatitudeCopyDdm, "Copy the degrees/minutes/seconds to the Windows clipboard")
        '
        'lnkLongitudeCopyDdm
        '
        Me.lnkLongitudeCopyDdm.AutoSize = True
        Me.lnkLongitudeCopyDdm.Location = New System.Drawing.Point(523, 159)
        Me.lnkLongitudeCopyDdm.Name = "lnkLongitudeCopyDdm"
        Me.lnkLongitudeCopyDdm.Size = New System.Drawing.Size(88, 13)
        Me.lnkLongitudeCopyDdm.TabIndex = 33
        Me.lnkLongitudeCopyDdm.TabStop = True
        Me.lnkLongitudeCopyDdm.Text = "copy to clipboard"
        Me.tipToolTip.SetToolTip(Me.lnkLongitudeCopyDdm, "Copy the degrees/minutes/seconds to the Windows clipboard")
        '
        'txtLongitudeDecimalDegrees
        '
        Me.txtLongitudeDecimalDegrees.Location = New System.Drawing.Point(335, 136)
        Me.txtLongitudeDecimalDegrees.MaxLength = 10
        Me.txtLongitudeDecimalDegrees.Name = "txtLongitudeDecimalDegrees"
        Me.txtLongitudeDecimalDegrees.Size = New System.Drawing.Size(100, 20)
        Me.txtLongitudeDecimalDegrees.TabIndex = 28
        '
        'txtLongitudeDmsSeconds
        '
        Me.txtLongitudeDmsSeconds.Location = New System.Drawing.Point(216, 136)
        Me.txtLongitudeDmsSeconds.MaxLength = 7
        Me.txtLongitudeDmsSeconds.Name = "txtLongitudeDmsSeconds"
        Me.txtLongitudeDmsSeconds.Size = New System.Drawing.Size(49, 20)
        Me.txtLongitudeDmsSeconds.TabIndex = 24
        '
        'lblLongitudeSeconds
        '
        Me.lblLongitudeSeconds.AutoSize = True
        Me.lblLongitudeSeconds.Location = New System.Drawing.Point(213, 120)
        Me.lblLongitudeSeconds.Name = "lblLongitudeSeconds"
        Me.lblLongitudeSeconds.Size = New System.Drawing.Size(52, 13)
        Me.lblLongitudeSeconds.TabIndex = 23
        Me.lblLongitudeSeconds.Text = "Seconds:"
        '
        'txtLongitudeDmsMinutes
        '
        Me.txtLongitudeDmsMinutes.Location = New System.Drawing.Point(161, 136)
        Me.txtLongitudeDmsMinutes.MaxLength = 2
        Me.txtLongitudeDmsMinutes.Name = "txtLongitudeDmsMinutes"
        Me.txtLongitudeDmsMinutes.Size = New System.Drawing.Size(49, 20)
        Me.txtLongitudeDmsMinutes.TabIndex = 22
        '
        'lblLongitudeMinutes
        '
        Me.lblLongitudeMinutes.AutoSize = True
        Me.lblLongitudeMinutes.Location = New System.Drawing.Point(158, 120)
        Me.lblLongitudeMinutes.Name = "lblLongitudeMinutes"
        Me.lblLongitudeMinutes.Size = New System.Drawing.Size(47, 13)
        Me.lblLongitudeMinutes.TabIndex = 21
        Me.lblLongitudeMinutes.Text = "Minutes:"
        '
        'txtLongitudeDmsDegrees
        '
        Me.txtLongitudeDmsDegrees.Location = New System.Drawing.Point(106, 136)
        Me.txtLongitudeDmsDegrees.MaxLength = 3
        Me.txtLongitudeDmsDegrees.Name = "txtLongitudeDmsDegrees"
        Me.txtLongitudeDmsDegrees.Size = New System.Drawing.Size(49, 20)
        Me.txtLongitudeDmsDegrees.TabIndex = 20
        '
        'lblLongitudeDegrees
        '
        Me.lblLongitudeDegrees.AutoSize = True
        Me.lblLongitudeDegrees.Location = New System.Drawing.Point(103, 120)
        Me.lblLongitudeDegrees.Name = "lblLongitudeDegrees"
        Me.lblLongitudeDegrees.Size = New System.Drawing.Size(50, 13)
        Me.lblLongitudeDegrees.TabIndex = 19
        Me.lblLongitudeDegrees.Text = "Degrees:"
        '
        'lblLongitudeDecimalDegrees
        '
        Me.lblLongitudeDecimalDegrees.AutoSize = True
        Me.lblLongitudeDecimalDegrees.Location = New System.Drawing.Point(332, 120)
        Me.lblLongitudeDecimalDegrees.Name = "lblLongitudeDecimalDegrees"
        Me.lblLongitudeDecimalDegrees.Size = New System.Drawing.Size(89, 13)
        Me.lblLongitudeDecimalDegrees.TabIndex = 27
        Me.lblLongitudeDecimalDegrees.Text = "Decimal degrees:"
        '
        'imlImageList
        '
        Me.imlImageList.ImageStream = CType(resources.GetObject("imlImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlImageList.TransparentColor = System.Drawing.Color.Fuchsia
        Me.imlImageList.Images.SetKeyName(0, "two_way_arrow_bmp")
        '
        'lblConvertLatitudeImageDmsDd
        '
        Me.lblConvertLatitudeImageDmsDd.ImageKey = "two_way_arrow_bmp"
        Me.lblConvertLatitudeImageDmsDd.ImageList = Me.imlImageList
        Me.lblConvertLatitudeImageDmsDd.Location = New System.Drawing.Point(271, 35)
        Me.lblConvertLatitudeImageDmsDd.Name = "lblConvertLatitudeImageDmsDd"
        Me.lblConvertLatitudeImageDmsDd.Size = New System.Drawing.Size(58, 20)
        Me.lblConvertLatitudeImageDmsDd.TabIndex = 9
        '
        'lblConvertLongitudeImageDmsDd
        '
        Me.lblConvertLongitudeImageDmsDd.ImageKey = "two_way_arrow_bmp"
        Me.lblConvertLongitudeImageDmsDd.ImageList = Me.imlImageList
        Me.lblConvertLongitudeImageDmsDd.Location = New System.Drawing.Point(271, 136)
        Me.lblConvertLongitudeImageDmsDd.Name = "lblConvertLongitudeImageDmsDd"
        Me.lblConvertLongitudeImageDmsDd.Size = New System.Drawing.Size(58, 20)
        Me.lblConvertLongitudeImageDmsDd.TabIndex = 26
        '
        'lblConvertLatitudeImageDdDdm
        '
        Me.lblConvertLatitudeImageDdDdm.ImageKey = "two_way_arrow_bmp"
        Me.lblConvertLatitudeImageDdDdm.ImageList = Me.imlImageList
        Me.lblConvertLatitudeImageDdDdm.Location = New System.Drawing.Point(441, 35)
        Me.lblConvertLatitudeImageDdDdm.Name = "lblConvertLatitudeImageDdDdm"
        Me.lblConvertLatitudeImageDdDdm.Size = New System.Drawing.Size(58, 20)
        Me.lblConvertLatitudeImageDdDdm.TabIndex = 12
        '
        'txtLatitudeDdmDegrees
        '
        Me.txtLatitudeDdmDegrees.Location = New System.Drawing.Point(505, 35)
        Me.txtLatitudeDdmDegrees.MaxLength = 10
        Me.txtLatitudeDdmDegrees.Name = "txtLatitudeDdmDegrees"
        Me.txtLatitudeDdmDegrees.Size = New System.Drawing.Size(49, 20)
        Me.txtLatitudeDdmDegrees.TabIndex = 14
        '
        'lblLatitudeDegreesDecimalMintuesLabel
        '
        Me.lblLatitudeDegreesDecimalMintuesLabel.AutoSize = True
        Me.lblLatitudeDegreesDecimalMintuesLabel.Location = New System.Drawing.Point(502, 19)
        Me.lblLatitudeDegreesDecimalMintuesLabel.Name = "lblLatitudeDegreesDecimalMintuesLabel"
        Me.lblLatitudeDegreesDecimalMintuesLabel.Size = New System.Drawing.Size(128, 13)
        Me.lblLatitudeDegreesDecimalMintuesLabel.TabIndex = 13
        Me.lblLatitudeDegreesDecimalMintuesLabel.Text = "Degrees decimal-minutes:"
        '
        'lblConvertLongitudeImageDdDdm
        '
        Me.lblConvertLongitudeImageDdDdm.ImageKey = "two_way_arrow_bmp"
        Me.lblConvertLongitudeImageDdDdm.ImageList = Me.imlImageList
        Me.lblConvertLongitudeImageDdDdm.Location = New System.Drawing.Point(441, 136)
        Me.lblConvertLongitudeImageDdDdm.Name = "lblConvertLongitudeImageDdDdm"
        Me.lblConvertLongitudeImageDdDdm.Size = New System.Drawing.Size(58, 20)
        Me.lblConvertLongitudeImageDdDdm.TabIndex = 29
        '
        'txtLongitudeDdmDegrees
        '
        Me.txtLongitudeDdmDegrees.Location = New System.Drawing.Point(505, 136)
        Me.txtLongitudeDdmDegrees.MaxLength = 10
        Me.txtLongitudeDdmDegrees.Name = "txtLongitudeDdmDegrees"
        Me.txtLongitudeDdmDegrees.Size = New System.Drawing.Size(49, 20)
        Me.txtLongitudeDdmDegrees.TabIndex = 31
        '
        'lblLongitudeDegreesDecimalMinutes
        '
        Me.lblLongitudeDegreesDecimalMinutes.AutoSize = True
        Me.lblLongitudeDegreesDecimalMinutes.Location = New System.Drawing.Point(502, 120)
        Me.lblLongitudeDegreesDecimalMinutes.Name = "lblLongitudeDegreesDecimalMinutes"
        Me.lblLongitudeDegreesDecimalMinutes.Size = New System.Drawing.Size(128, 13)
        Me.lblLongitudeDegreesDecimalMinutes.TabIndex = 30
        Me.lblLongitudeDegreesDecimalMinutes.Text = "Degrees decimal-minutes:"
        '
        'txtLatitudeDdmMinutes
        '
        Me.txtLatitudeDdmMinutes.Location = New System.Drawing.Point(560, 35)
        Me.txtLatitudeDdmMinutes.MaxLength = 10
        Me.txtLatitudeDdmMinutes.Name = "txtLatitudeDdmMinutes"
        Me.txtLatitudeDdmMinutes.Size = New System.Drawing.Size(70, 20)
        Me.txtLatitudeDdmMinutes.TabIndex = 15
        '
        'txtLongitudeDdmMinutes
        '
        Me.txtLongitudeDdmMinutes.Location = New System.Drawing.Point(560, 136)
        Me.txtLongitudeDdmMinutes.MaxLength = 10
        Me.txtLongitudeDdmMinutes.Name = "txtLongitudeDdmMinutes"
        Me.txtLongitudeDdmMinutes.Size = New System.Drawing.Size(70, 20)
        Me.txtLongitudeDdmMinutes.TabIndex = 32
        '
        'LatLonHelperForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(644, 244)
        Me.Controls.Add(Me.lnkLongitudeCopyDdm)
        Me.Controls.Add(Me.lnkLatitudeCopyDdm)
        Me.Controls.Add(Me.txtLongitudeDdmMinutes)
        Me.Controls.Add(Me.txtLatitudeDdmMinutes)
        Me.Controls.Add(Me.lblConvertLongitudeImageDdDdm)
        Me.Controls.Add(Me.txtLongitudeDdmDegrees)
        Me.Controls.Add(Me.lblLongitudeDegreesDecimalMinutes)
        Me.Controls.Add(Me.lblConvertLatitudeImageDdDdm)
        Me.Controls.Add(Me.txtLatitudeDdmDegrees)
        Me.Controls.Add(Me.lblLatitudeDegreesDecimalMintuesLabel)
        Me.Controls.Add(Me.lblConvertLongitudeImageDmsDd)
        Me.Controls.Add(Me.lblConvertLatitudeImageDmsDd)
        Me.Controls.Add(Me.lnkLongitudeCopyDms)
        Me.Controls.Add(Me.txtLongitudeDecimalDegrees)
        Me.Controls.Add(Me.txtLongitudeDmsSeconds)
        Me.Controls.Add(Me.lblLongitudeSeconds)
        Me.Controls.Add(Me.txtLongitudeDmsMinutes)
        Me.Controls.Add(Me.lblLongitudeMinutes)
        Me.Controls.Add(Me.txtLongitudeDmsDegrees)
        Me.Controls.Add(Me.lblLongitudeDegrees)
        Me.Controls.Add(Me.lblLongitudeDecimalDegrees)
        Me.Controls.Add(Me.lnkMapIt)
        Me.Controls.Add(Me.lblLongitude)
        Me.Controls.Add(Me.lblLatitude)
        Me.Controls.Add(Me.pnlLatitude)
        Me.Controls.Add(Me.pnlLongitude)
        Me.Controls.Add(Me.lnkLatitudeCopyDms)
        Me.Controls.Add(Me.txtLatitudeDecimalDegrees)
        Me.Controls.Add(Me.txtLatitudeDmsSeconds)
        Me.Controls.Add(Me.lblLatitudeSeconds)
        Me.Controls.Add(Me.txtLatitudeDmsMinutes)
        Me.Controls.Add(Me.lblLatitudeMinutes)
        Me.Controls.Add(Me.txtLatitudeDmsDegrees)
        Me.Controls.Add(Me.lblLatitudeDegrees)
        Me.Controls.Add(Me.lblLatitudeDecimalDegreesLabel)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LatLonHelperForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Latitude/Longitude Helper"
        Me.pnlLatitude.ResumeLayout(False)
        Me.pnlLatitude.PerformLayout()
        Me.pnlLongitude.ResumeLayout(False)
        Me.pnlLongitude.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeparator As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblLatitudeDecimalDegreesLabel As System.Windows.Forms.Label
    Friend WithEvents lblLatitudeDegrees As System.Windows.Forms.Label
    Friend WithEvents txtLatitudeDmsDegrees As System.Windows.Forms.TextBox
    Friend WithEvents txtLatitudeDmsMinutes As System.Windows.Forms.TextBox
    Friend WithEvents lblLatitudeMinutes As System.Windows.Forms.Label
    Friend WithEvents txtLatitudeDmsSeconds As System.Windows.Forms.TextBox
    Friend WithEvents lblLatitudeSeconds As System.Windows.Forms.Label
    Friend WithEvents radNorth As System.Windows.Forms.RadioButton
    Friend WithEvents radSouth As System.Windows.Forms.RadioButton
    Friend WithEvents txtLatitudeDecimalDegrees As System.Windows.Forms.TextBox
    Friend WithEvents pnlLatitude As System.Windows.Forms.Panel
    Friend WithEvents pnlLongitude As System.Windows.Forms.Panel
    Friend WithEvents radWest As System.Windows.Forms.RadioButton
    Friend WithEvents radEast As System.Windows.Forms.RadioButton
    Friend WithEvents lnkLatitudeCopyDms As System.Windows.Forms.LinkLabel
    Friend WithEvents lblLatitude As System.Windows.Forms.Label
    Friend WithEvents lblLongitude As System.Windows.Forms.Label
    Friend WithEvents tipToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lnkMapIt As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkLongitudeCopyDms As System.Windows.Forms.LinkLabel
    Friend WithEvents txtLongitudeDecimalDegrees As System.Windows.Forms.TextBox
    Friend WithEvents txtLongitudeDmsSeconds As System.Windows.Forms.TextBox
    Friend WithEvents lblLongitudeSeconds As System.Windows.Forms.Label
    Friend WithEvents txtLongitudeDmsMinutes As System.Windows.Forms.TextBox
    Friend WithEvents lblLongitudeMinutes As System.Windows.Forms.Label
    Friend WithEvents txtLongitudeDmsDegrees As System.Windows.Forms.TextBox
    Friend WithEvents lblLongitudeDegrees As System.Windows.Forms.Label
    Friend WithEvents lblLongitudeDecimalDegrees As System.Windows.Forms.Label
    Friend WithEvents imlImageList As System.Windows.Forms.ImageList
    Friend WithEvents lblConvertLatitudeImageDmsDd As System.Windows.Forms.Label
    Friend WithEvents lblConvertLongitudeImageDmsDd As System.Windows.Forms.Label
    Friend WithEvents lblConvertLatitudeImageDdDdm As System.Windows.Forms.Label
    Friend WithEvents txtLatitudeDdmDegrees As System.Windows.Forms.TextBox
    Friend WithEvents lblLatitudeDegreesDecimalMintuesLabel As System.Windows.Forms.Label
    Friend WithEvents lblConvertLongitudeImageDdDdm As System.Windows.Forms.Label
    Friend WithEvents txtLongitudeDdmDegrees As System.Windows.Forms.TextBox
    Friend WithEvents lblLongitudeDegreesDecimalMinutes As System.Windows.Forms.Label
    Friend WithEvents txtLatitudeDdmMinutes As System.Windows.Forms.TextBox
    Friend WithEvents txtLongitudeDdmMinutes As System.Windows.Forms.TextBox
    Friend WithEvents lnkLatitudeCopyDdm As System.Windows.Forms.LinkLabel
    Friend WithEvents lnkLongitudeCopyDdm As System.Windows.Forms.LinkLabel
End Class
