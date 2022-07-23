<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DateComboBox
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DateComboBox))
        Me.mskDate = New System.Windows.Forms.MaskedTextBox
        Me.btnPopup = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'mskDate
        '
        Me.mskDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mskDate.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mskDate.Location = New System.Drawing.Point(1, 1)
        Me.mskDate.Margin = New System.Windows.Forms.Padding(0)
        Me.mskDate.Mask = "00/00/0000"
        Me.mskDate.Name = "mskDate"
        Me.mskDate.Size = New System.Drawing.Size(76, 13)
        Me.mskDate.TabIndex = 0
        Me.mskDate.ValidatingType = GetType(Date)
        '
        'btnPopup
        '
        Me.btnPopup.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnPopup.BackgroundImage = CType(resources.GetObject("btnPopup.BackgroundImage"), System.Drawing.Image)
        Me.btnPopup.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btnPopup.FlatAppearance.BorderSize = 0
        Me.btnPopup.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnPopup.Location = New System.Drawing.Point(79, 0)
        Me.btnPopup.Name = "btnPopup"
        Me.btnPopup.Size = New System.Drawing.Size(16, 16)
        Me.btnPopup.TabIndex = 1
        Me.btnPopup.TabStop = False
        Me.btnPopup.UseVisualStyleBackColor = True
        '
        'DateComboBox
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Window
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Controls.Add(Me.btnPopup)
        Me.Controls.Add(Me.mskDate)
        Me.Name = "DateComboBox"
        Me.Size = New System.Drawing.Size(100, 20)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents mskDate As System.Windows.Forms.MaskedTextBox
    Friend WithEvents btnPopup As System.Windows.Forms.Button

End Class

