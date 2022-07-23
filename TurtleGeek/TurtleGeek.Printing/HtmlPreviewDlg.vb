Option Strict On
Option Explicit On

Public Class HtmlPreviewDlg

    Public Sub New(ByVal sHtmlString As String)

        MyBase.New()

        InitializeComponent()

        Me.WebBrowser1.DocumentText = sHtmlString.ToString
        Me.WebBrowser1.Document.Write(sHtmlString.ToString)

    End Sub

    Private Sub HtmlPreviewDlg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Me.Visible = False
        Application.DoEvents()

        Me.Height = Screen.PrimaryScreen.WorkingArea.Height
        Me.Width = Screen.PrimaryScreen.WorkingArea.Width

        Me.Top = (Screen.PrimaryScreen.WorkingArea.Height - Me.Height) \ 2
        Me.Left = (Screen.PrimaryScreen.WorkingArea.Width - Me.Width) \ 2

    End Sub

End Class