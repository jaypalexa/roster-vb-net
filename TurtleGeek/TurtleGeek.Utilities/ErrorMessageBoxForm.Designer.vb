<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ErrorMessageBoxForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ErrorMessageBoxForm))
        Me.txtErrorMessageText = New System.Windows.Forms.TextBox
        Me.btnOK = New System.Windows.Forms.Button
        Me.lnkCopyToClipboard = New System.Windows.Forms.LinkLabel
        Me.lblApplicationException = New System.Windows.Forms.Label
        Me.picErrorImage = New System.Windows.Forms.PictureBox
        CType(Me.picErrorImage, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtErrorMessageText
        '
        Me.txtErrorMessageText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtErrorMessageText.Location = New System.Drawing.Point(9, 67)
        Me.txtErrorMessageText.Multiline = True
        Me.txtErrorMessageText.Name = "txtErrorMessageText"
        Me.txtErrorMessageText.ReadOnly = True
        Me.txtErrorMessageText.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtErrorMessageText.Size = New System.Drawing.Size(571, 458)
        Me.txtErrorMessageText.TabIndex = 4
        Me.txtErrorMessageText.TabStop = False
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(505, 538)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(75, 23)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'lnkCopyToClipboard
        '
        Me.lnkCopyToClipboard.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkCopyToClipboard.AutoSize = True
        Me.lnkCopyToClipboard.Location = New System.Drawing.Point(12, 543)
        Me.lnkCopyToClipboard.Name = "lnkCopyToClipboard"
        Me.lnkCopyToClipboard.Size = New System.Drawing.Size(88, 13)
        Me.lnkCopyToClipboard.TabIndex = 1
        Me.lnkCopyToClipboard.TabStop = True
        Me.lnkCopyToClipboard.Text = "copy to clipboard"
        '
        'lblApplicationException
        '
        Me.lblApplicationException.AutoSize = True
        Me.lblApplicationException.Location = New System.Drawing.Point(63, 25)
        Me.lblApplicationException.Name = "lblApplicationException"
        Me.lblApplicationException.Size = New System.Drawing.Size(191, 13)
        Me.lblApplicationException.TabIndex = 3
        Me.lblApplicationException.Text = "An application exception has occurred."
        '
        'picErrorImage
        '
        Me.picErrorImage.BackColor = System.Drawing.Color.Transparent
        Me.picErrorImage.BackgroundImage = CType(resources.GetObject("picErrorImage.BackgroundImage"), System.Drawing.Image)
        Me.picErrorImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.picErrorImage.InitialImage = Nothing
        Me.picErrorImage.Location = New System.Drawing.Point(9, 9)
        Me.picErrorImage.Name = "picErrorImage"
        Me.picErrorImage.Size = New System.Drawing.Size(48, 48)
        Me.picErrorImage.TabIndex = 4
        Me.picErrorImage.TabStop = False
        '
        'ErrorMessageBoxForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnOK
        Me.ClientSize = New System.Drawing.Size(592, 573)
        Me.Controls.Add(Me.picErrorImage)
        Me.Controls.Add(Me.lblApplicationException)
        Me.Controls.Add(Me.lnkCopyToClipboard)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txtErrorMessageText)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "ErrorMessageBoxForm"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Application Exception"
        CType(Me.picErrorImage, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtErrorMessageText As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lnkCopyToClipboard As System.Windows.Forms.LinkLabel
    Friend WithEvents lblApplicationException As System.Windows.Forms.Label
    Friend WithEvents picErrorImage As System.Windows.Forms.PictureBox
End Class
