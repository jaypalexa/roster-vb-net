<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ConvertToDecimalDegreesForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ConvertToDecimalDegreesForm))
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblLatitudeDecimalDegreesLabel = New System.Windows.Forms.Label
        Me.lblDmsDegrees = New System.Windows.Forms.Label
        Me.txtDmsDegrees = New System.Windows.Forms.TextBox
        Me.txtDmsMinutes = New System.Windows.Forms.TextBox
        Me.lblDmsMinutes = New System.Windows.Forms.Label
        Me.txtDmsSeconds = New System.Windows.Forms.TextBox
        Me.lblDmsSeconds = New System.Windows.Forms.Label
        Me.radDirectionPositive = New System.Windows.Forms.RadioButton
        Me.radDirectionNegative = New System.Windows.Forms.RadioButton
        Me.pnlDirection = New System.Windows.Forms.Panel
        Me.lblDirection = New System.Windows.Forms.Label
        Me.tipToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.imlImageList = New System.Windows.Forms.ImageList(Me.components)
        Me.lblConvertLatitudeImageDmsDd = New System.Windows.Forms.Label
        Me.txtDdmDegrees = New System.Windows.Forms.TextBox
        Me.lblDegreesDecimalMintues = New System.Windows.Forms.Label
        Me.txtDdmMinutes = New System.Windows.Forms.TextBox
        Me.lblDecimalDegreesValue = New System.Windows.Forms.Label
        Me.radConversionTypeDms = New System.Windows.Forms.RadioButton
        Me.radConversionTypeDdm = New System.Windows.Forms.RadioButton
        Me.pnlDirection.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(4, 112)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(499, 2)
        Me.lblSeparator.TabIndex = 15
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(428, 122)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 18
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(348, 122)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 24)
        Me.btnOK.TabIndex = 17
        Me.btnOK.Text = "OK"
        '
        'lblLatitudeDecimalDegreesLabel
        '
        Me.lblLatitudeDecimalDegreesLabel.AutoSize = True
        Me.lblLatitudeDecimalDegreesLabel.Location = New System.Drawing.Point(369, 32)
        Me.lblLatitudeDecimalDegreesLabel.Name = "lblLatitudeDecimalDegreesLabel"
        Me.lblLatitudeDecimalDegreesLabel.Size = New System.Drawing.Size(89, 13)
        Me.lblLatitudeDecimalDegreesLabel.TabIndex = 13
        Me.lblLatitudeDecimalDegreesLabel.Text = "Decimal degrees:"
        '
        'lblDmsDegrees
        '
        Me.lblDmsDegrees.AutoSize = True
        Me.lblDmsDegrees.Location = New System.Drawing.Point(36, 11)
        Me.lblDmsDegrees.Name = "lblDmsDegrees"
        Me.lblDmsDegrees.Size = New System.Drawing.Size(50, 13)
        Me.lblDmsDegrees.TabIndex = 1
        Me.lblDmsDegrees.Text = "Degrees:"
        '
        'txtDmsDegrees
        '
        Me.txtDmsDegrees.Location = New System.Drawing.Point(39, 27)
        Me.txtDmsDegrees.MaxLength = 3
        Me.txtDmsDegrees.Name = "txtDmsDegrees"
        Me.txtDmsDegrees.Size = New System.Drawing.Size(49, 20)
        Me.txtDmsDegrees.TabIndex = 2
        '
        'txtDmsMinutes
        '
        Me.txtDmsMinutes.Location = New System.Drawing.Point(94, 27)
        Me.txtDmsMinutes.MaxLength = 2
        Me.txtDmsMinutes.Name = "txtDmsMinutes"
        Me.txtDmsMinutes.Size = New System.Drawing.Size(49, 20)
        Me.txtDmsMinutes.TabIndex = 4
        '
        'lblDmsMinutes
        '
        Me.lblDmsMinutes.AutoSize = True
        Me.lblDmsMinutes.Location = New System.Drawing.Point(91, 11)
        Me.lblDmsMinutes.Name = "lblDmsMinutes"
        Me.lblDmsMinutes.Size = New System.Drawing.Size(47, 13)
        Me.lblDmsMinutes.TabIndex = 3
        Me.lblDmsMinutes.Text = "Minutes:"
        '
        'txtDmsSeconds
        '
        Me.txtDmsSeconds.Location = New System.Drawing.Point(149, 27)
        Me.txtDmsSeconds.MaxLength = 7
        Me.txtDmsSeconds.Name = "txtDmsSeconds"
        Me.txtDmsSeconds.Size = New System.Drawing.Size(49, 20)
        Me.txtDmsSeconds.TabIndex = 6
        '
        'lblDmsSeconds
        '
        Me.lblDmsSeconds.AutoSize = True
        Me.lblDmsSeconds.Location = New System.Drawing.Point(146, 11)
        Me.lblDmsSeconds.Name = "lblDmsSeconds"
        Me.lblDmsSeconds.Size = New System.Drawing.Size(52, 13)
        Me.lblDmsSeconds.TabIndex = 5
        Me.lblDmsSeconds.Text = "Seconds:"
        '
        'radDirectionPositive
        '
        Me.radDirectionPositive.AutoSize = True
        Me.radDirectionPositive.Checked = True
        Me.radDirectionPositive.Location = New System.Drawing.Point(3, 3)
        Me.radDirectionPositive.Name = "radDirectionPositive"
        Me.radDirectionPositive.Size = New System.Drawing.Size(62, 17)
        Me.radDirectionPositive.TabIndex = 0
        Me.radDirectionPositive.TabStop = True
        Me.radDirectionPositive.Text = "Positive"
        Me.radDirectionPositive.UseVisualStyleBackColor = True
        '
        'radDirectionNegative
        '
        Me.radDirectionNegative.AutoSize = True
        Me.radDirectionNegative.Location = New System.Drawing.Point(3, 21)
        Me.radDirectionNegative.Name = "radDirectionNegative"
        Me.radDirectionNegative.Size = New System.Drawing.Size(68, 17)
        Me.radDirectionNegative.TabIndex = 1
        Me.radDirectionNegative.Text = "Negative"
        Me.radDirectionNegative.UseVisualStyleBackColor = True
        '
        'pnlDirection
        '
        Me.pnlDirection.Controls.Add(Me.radDirectionPositive)
        Me.pnlDirection.Controls.Add(Me.radDirectionNegative)
        Me.pnlDirection.Location = New System.Drawing.Point(204, 18)
        Me.pnlDirection.Name = "pnlDirection"
        Me.pnlDirection.Size = New System.Drawing.Size(76, 41)
        Me.pnlDirection.TabIndex = 7
        '
        'lblDirection
        '
        Me.lblDirection.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblDirection.AutoSize = True
        Me.lblDirection.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDirection.Location = New System.Drawing.Point(10, 126)
        Me.lblDirection.Name = "lblDirection"
        Me.lblDirection.Size = New System.Drawing.Size(73, 16)
        Me.lblDirection.TabIndex = 16
        Me.lblDirection.Text = "Direction"
        '
        'imlImageList
        '
        Me.imlImageList.ImageStream = CType(resources.GetObject("imlImageList.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.imlImageList.TransparentColor = System.Drawing.Color.Fuchsia
        Me.imlImageList.Images.SetKeyName(0, "two_way_arrow_bmp")
        Me.imlImageList.Images.SetKeyName(1, "right_arrow_bmp")
        '
        'lblConvertLatitudeImageDmsDd
        '
        Me.lblConvertLatitudeImageDmsDd.ImageKey = "right_arrow_bmp"
        Me.lblConvertLatitudeImageDmsDd.ImageList = Me.imlImageList
        Me.lblConvertLatitudeImageDmsDd.Location = New System.Drawing.Point(304, 48)
        Me.lblConvertLatitudeImageDmsDd.Name = "lblConvertLatitudeImageDmsDd"
        Me.lblConvertLatitudeImageDmsDd.Size = New System.Drawing.Size(58, 20)
        Me.lblConvertLatitudeImageDmsDd.TabIndex = 12
        '
        'txtDdmDegrees
        '
        Me.txtDdmDegrees.Enabled = False
        Me.txtDdmDegrees.Location = New System.Drawing.Point(39, 71)
        Me.txtDdmDegrees.MaxLength = 10
        Me.txtDdmDegrees.Name = "txtDdmDegrees"
        Me.txtDdmDegrees.Size = New System.Drawing.Size(49, 20)
        Me.txtDdmDegrees.TabIndex = 10
        '
        'lblDegreesDecimalMintues
        '
        Me.lblDegreesDecimalMintues.AutoSize = True
        Me.lblDegreesDecimalMintues.Enabled = False
        Me.lblDegreesDecimalMintues.Location = New System.Drawing.Point(36, 55)
        Me.lblDegreesDecimalMintues.Name = "lblDegreesDecimalMintues"
        Me.lblDegreesDecimalMintues.Size = New System.Drawing.Size(128, 13)
        Me.lblDegreesDecimalMintues.TabIndex = 9
        Me.lblDegreesDecimalMintues.Text = "Degrees decimal-minutes:"
        '
        'txtDdmMinutes
        '
        Me.txtDdmMinutes.Enabled = False
        Me.txtDdmMinutes.Location = New System.Drawing.Point(94, 71)
        Me.txtDdmMinutes.MaxLength = 10
        Me.txtDdmMinutes.Name = "txtDdmMinutes"
        Me.txtDdmMinutes.Size = New System.Drawing.Size(70, 20)
        Me.txtDdmMinutes.TabIndex = 11
        '
        'lblDecimalDegreesValue
        '
        Me.lblDecimalDegreesValue.BackColor = System.Drawing.Color.Gainsboro
        Me.lblDecimalDegreesValue.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDecimalDegreesValue.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDecimalDegreesValue.ForeColor = System.Drawing.Color.DarkBlue
        Me.lblDecimalDegreesValue.Location = New System.Drawing.Point(372, 48)
        Me.lblDecimalDegreesValue.Name = "lblDecimalDegreesValue"
        Me.lblDecimalDegreesValue.Size = New System.Drawing.Size(125, 20)
        Me.lblDecimalDegreesValue.TabIndex = 14
        Me.lblDecimalDegreesValue.Text = "--"
        Me.lblDecimalDegreesValue.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'radConversionTypeDms
        '
        Me.radConversionTypeDms.AutoSize = True
        Me.radConversionTypeDms.Checked = True
        Me.radConversionTypeDms.Location = New System.Drawing.Point(13, 30)
        Me.radConversionTypeDms.Name = "radConversionTypeDms"
        Me.radConversionTypeDms.Size = New System.Drawing.Size(14, 13)
        Me.radConversionTypeDms.TabIndex = 0
        Me.radConversionTypeDms.TabStop = True
        Me.radConversionTypeDms.UseVisualStyleBackColor = True
        '
        'radConversionTypeDdm
        '
        Me.radConversionTypeDdm.AutoSize = True
        Me.radConversionTypeDdm.Location = New System.Drawing.Point(13, 74)
        Me.radConversionTypeDdm.Name = "radConversionTypeDdm"
        Me.radConversionTypeDdm.Size = New System.Drawing.Size(14, 13)
        Me.radConversionTypeDdm.TabIndex = 8
        Me.radConversionTypeDdm.UseVisualStyleBackColor = True
        '
        'ConvertToDecimalDegreesForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 158)
        Me.Controls.Add(Me.radConversionTypeDdm)
        Me.Controls.Add(Me.radConversionTypeDms)
        Me.Controls.Add(Me.lblDecimalDegreesValue)
        Me.Controls.Add(Me.txtDdmMinutes)
        Me.Controls.Add(Me.txtDdmDegrees)
        Me.Controls.Add(Me.lblDegreesDecimalMintues)
        Me.Controls.Add(Me.lblConvertLatitudeImageDmsDd)
        Me.Controls.Add(Me.lblDirection)
        Me.Controls.Add(Me.pnlDirection)
        Me.Controls.Add(Me.txtDmsSeconds)
        Me.Controls.Add(Me.lblDmsSeconds)
        Me.Controls.Add(Me.txtDmsMinutes)
        Me.Controls.Add(Me.lblDmsMinutes)
        Me.Controls.Add(Me.txtDmsDegrees)
        Me.Controls.Add(Me.lblDmsDegrees)
        Me.Controls.Add(Me.lblLatitudeDecimalDegreesLabel)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ConvertToDecimalDegreesForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Convert To Decimal Degrees"
        Me.pnlDirection.ResumeLayout(False)
        Me.pnlDirection.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblSeparator As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblLatitudeDecimalDegreesLabel As System.Windows.Forms.Label
    Friend WithEvents lblDmsDegrees As System.Windows.Forms.Label
    Friend WithEvents txtDmsDegrees As System.Windows.Forms.TextBox
    Friend WithEvents txtDmsMinutes As System.Windows.Forms.TextBox
    Friend WithEvents lblDmsMinutes As System.Windows.Forms.Label
    Friend WithEvents txtDmsSeconds As System.Windows.Forms.TextBox
    Friend WithEvents lblDmsSeconds As System.Windows.Forms.Label
    Friend WithEvents radDirectionPositive As System.Windows.Forms.RadioButton
    Friend WithEvents radDirectionNegative As System.Windows.Forms.RadioButton
    Friend WithEvents pnlDirection As System.Windows.Forms.Panel
    Friend WithEvents lblDirection As System.Windows.Forms.Label
    Friend WithEvents tipToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents imlImageList As System.Windows.Forms.ImageList
    Friend WithEvents lblConvertLatitudeImageDmsDd As System.Windows.Forms.Label
    Friend WithEvents txtDdmDegrees As System.Windows.Forms.TextBox
    Friend WithEvents lblDegreesDecimalMintues As System.Windows.Forms.Label
    Friend WithEvents txtDdmMinutes As System.Windows.Forms.TextBox
    Friend WithEvents lblDecimalDegreesValue As System.Windows.Forms.Label
    Friend WithEvents radConversionTypeDms As System.Windows.Forms.RadioButton
    Friend WithEvents radConversionTypeDdm As System.Windows.Forms.RadioButton
End Class
