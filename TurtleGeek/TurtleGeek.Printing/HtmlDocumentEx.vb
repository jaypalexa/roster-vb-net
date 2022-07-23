Option Strict On
Option Explicit On

Public Class HtmlDocumentEx

    ''' <summary>
    ''' Renders the specified HTML in a print preview window.
    ''' </summary>
    ''' <param name="frmParentForm">The top-level window that will own the modal dialog.</param>
    ''' <remarks></remarks>
    Public Sub Preview(ByVal frmParentForm As Form, ByVal sHtmlString As String)

        Dim frm As HtmlPreviewDlg

        frm = New HtmlPreviewDlg(sHtmlString)
        frm.Visible = False
        Application.DoEvents()
        frm.Show(frmParentForm)
        frm.Visible = False
        Application.DoEvents()
        frm.WebBrowser1.ShowPrintPreviewDialog()
        frm = Nothing

    End Sub

End Class
