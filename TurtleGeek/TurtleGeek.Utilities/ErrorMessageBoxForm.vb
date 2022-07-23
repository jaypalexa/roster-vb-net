Public Class ErrorMessageBoxForm

    Private Sub lnkCopyToClipboard_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkCopyToClipboard.LinkClicked
        Clipboard.Clear()
        Clipboard.SetText(Me.txtErrorMessageText.Text)
    End Sub

End Class