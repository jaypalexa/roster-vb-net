<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountyEditForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CountyEditForm))
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblCountyName = New System.Windows.Forms.Label
        Me.txtCountyName = New System.Windows.Forms.TextBox
        Me.CountyBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.errCountyErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnHelp = New System.Windows.Forms.Button
        CType(Me.CountyBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.errCountyErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.Location = New System.Drawing.Point(224, 71)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 4
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(146, 71)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 24)
        Me.btnOK.TabIndex = 3
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lblCountyName
        '
        Me.lblCountyName.AutoSize = True
        Me.lblCountyName.Location = New System.Drawing.Point(9, 9)
        Me.lblCountyName.Name = "lblCountyName"
        Me.lblCountyName.Size = New System.Drawing.Size(72, 13)
        Me.lblCountyName.TabIndex = 0
        Me.lblCountyName.Text = "County &name:"
        '
        'txtCountyName
        '
        Me.txtCountyName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CountyBindingSource, "CountyName", True))
        Me.txtCountyName.Location = New System.Drawing.Point(12, 25)
        Me.txtCountyName.MaxLength = 255
        Me.txtCountyName.Name = "txtCountyName"
        Me.txtCountyName.Size = New System.Drawing.Size(284, 20)
        Me.txtCountyName.TabIndex = 1
        '
        'CountyBindingSource
        '
        Me.CountyBindingSource.DataSource = GetType(TurtleGeek.Roster.County)
        '
        'errCountyErrorProvider
        '
        Me.errCountyErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.errCountyErrorProvider.ContainerControl = Me
        Me.errCountyErrorProvider.DataSource = Me.CountyBindingSource
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(12, 63)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(290, 2)
        Me.lblSeparator.TabIndex = 2
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(12, 71)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 24)
        Me.btnHelp.TabIndex = 5
        Me.btnHelp.Text = "&Help"
        '
        'CountyEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(313, 107)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.txtCountyName)
        Me.Controls.Add(Me.lblCountyName)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.KeyPreview = True
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "CountyEditForm"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ROSTER - County"
        CType(Me.CountyBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.errCountyErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblCountyName As System.Windows.Forms.Label
    Friend WithEvents txtCountyName As System.Windows.Forms.TextBox
    Friend WithEvents errCountyErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents CountyBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lblSeparator As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
End Class
