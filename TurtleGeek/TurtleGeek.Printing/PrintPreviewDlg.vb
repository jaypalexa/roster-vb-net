Option Strict On
Option Explicit On 

Public Class PrintPreviewDlg
    Inherits System.Windows.Forms.Form

    Private mbIsInitializing As Boolean
    Private mbIsLoading As Boolean
    Private WithEvents moPrintDocumentEx As PrintDocumentEx

    Public Sub New(ByVal oPrintDocumentEx As PrintDocumentEx)

        MyBase.New()

        mbIsInitializing = True

        InitializeComponent()

        moPrintDocumentEx = New PrintDocumentEx()
        moPrintDocumentEx = oPrintDocumentEx

        mbIsInitializing = False

    End Sub

    Private Sub PrintPreviewDlg_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try

            '------------------------------------------------------------------
            '------------------------------------------------------------------
            Cursor.Current = Cursors.WaitCursor : Application.DoEvents()
            mbIsLoading = True

            Me.Text = My.Application.Info.Title & " - Print Preview"

            moPrintDocumentEx.IsPreview = True
            pvwPrintPreviewControl.Document = moPrintDocumentEx
            pvwPrintPreviewControl.Refresh()

            '------------------------------------------------------------------
            '------------------------------------------------------------------
            cboZoomList.Items.Clear()
            cboZoomList.Items.Add("50%")
            cboZoomList.Items.Add("75%")
            cboZoomList.Items.Add("100%")
            cboZoomList.Items.Add("150%")
            cboZoomList.Items.Add("200%")
            cboZoomList.SelectedIndex = 2   '<- default to 100%

            '------------------------------------------------------------------
            '------------------------------------------------------------------
            If moPrintDocumentEx.Copies <= 0 Then
                moPrintDocumentEx.Copies = 1
            End If

            If moPrintDocumentEx.Copies >= 999 Then
                moPrintDocumentEx.Copies = 999
            End If

            nudCopies.Minimum = 1
            nudCopies.Maximum = 999
            nudCopies.Value = moPrintDocumentEx.Copies

            '------------------------------------------------------------------
            '------------------------------------------------------------------
            Me.WindowState = FormWindowState.Maximized

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            mbIsLoading = False
            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub SetPageButtonState()
        lblPage.Text = (pvwPrintPreviewControl.StartPage + 1).ToString & " of " & moPrintDocumentEx.PageCount.ToString
        btnFirstPage.Enabled = CBool(pvwPrintPreviewControl.StartPage > 0)
        btnPreviousPage.Enabled = CBool(pvwPrintPreviewControl.StartPage > 0)
        btnNextPage.Enabled = CBool(pvwPrintPreviewControl.StartPage < moPrintDocumentEx.PageCount - 1)
        btnLastPage.Enabled = CBool(pvwPrintPreviewControl.StartPage < moPrintDocumentEx.PageCount - 1)
    End Sub

    Protected Overrides Sub Finalize()
        moPrintDocumentEx = Nothing
        MyBase.Finalize()
    End Sub

    Private Sub cboZoomList_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboZoomList.SelectedIndexChanged

        '*** ASSERTION ***
        If mbIsInitializing = True Then Exit Sub
        '*** ASSERTION ***

        If Val(cboZoomList.Text & "") > 0 Then
            pvwPrintPreviewControl.Zoom = Val(cboZoomList.Text & "") / 100
        Else
            pvwPrintPreviewControl.Zoom = 1.0
        End If

    End Sub

    Private Sub btnFirstPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFirstPage.Click
        pvwPrintPreviewControl.StartPage = 0
        Call SetPageButtonState()
    End Sub

    Private Sub btnPreviousPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPreviousPage.Click
        pvwPrintPreviewControl.StartPage = pvwPrintPreviewControl.StartPage - 1
        Call SetPageButtonState()
    End Sub

    Private Sub btnNextPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNextPage.Click
        pvwPrintPreviewControl.StartPage = pvwPrintPreviewControl.StartPage + 1
        Call SetPageButtonState()
    End Sub

    Private Sub btnLastPage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLastPage.Click
        If (moPrintDocumentEx.PageCount > 0) Then
            pvwPrintPreviewControl.StartPage = moPrintDocumentEx.PageCount - 1
        Else
            pvwPrintPreviewControl.StartPage = 0
        End If
        Call SetPageButtonState()
    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub

    Private Sub moPrintDocumentEx_EndPrint(ByVal sender As System.Object, ByVal e As System.Drawing.Printing.PrintEventArgs) Handles moPrintDocumentEx.EndPrint
        Call SetPageButtonState()
    End Sub

    Private Sub btnPrint_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPrint.Click

        Dim i As Integer
        Dim iCopies As Integer
        Dim dlg As New System.Windows.Forms.PrintDialog()

        moPrintDocumentEx.PrinterSettings.Copies = CShort(nudCopies.Value)
        dlg.PrinterSettings = New System.Drawing.Printing.PrinterSettings()
        dlg.PrinterSettings = moPrintDocumentEx.PrinterSettings()

        dlg.Document = moPrintDocumentEx
        dlg.AllowPrintToFile = False
        dlg.AllowSelection = False
        dlg.AllowSomePages = False

        If (dlg.ShowDialog = DialogResult.OK) Then

            'The Print method of the PrintDocument class prints to the default printer, 
            'using default settings, unless specified otherwise. 
            'You specify otherwise using the PrintDialog class, 
            'which is part of the System.Windows.Forms.CommonDialog namespace. 
            'PrintDialog lets you select a printer, 
            'choose which portion of a document to print, 
            'select the number of copies, and optionally print to a file.

            'The PrintDialog class's PrinterSettings property lets you place properties 
            'such as copies, from page, and to page into a document-specific PrinterSettings object. 
            'In other words, individual PrintDocument objects have a PrinterSettings object 
            'specifying the number of copies, the range of pages to print, 
            'the name of the printer to be used, and information about the printer itself. 

            'A bug in the PrinterSettings class causes the Copies property 
            'to always return a value of 1, regardless of how many copies you enter in the PrintDialog. 
            'However, the PrintDocument.Print() method still prints the correct number of copies, 
            'so the bug only shows up if you try to retrieve the value and use it somewhere else. 
            'The system uses these settings when you execute the Print method. 
            'You may supply either an actual PrinterSettings object or a Document object. 

            '------------------------------------------------------------------
            '-- the number of copies isn't sticking, 
            '--  (that is, the number being displayed 
            '--  is not the number being printed)
            '--  so get the displayed value, reset the PrinterSettings (just in case),
            '--  and printer copies "by hand" via loop
            '------------------------------------------------------------------
            iCopies = dlg.PrinterSettings.Copies
            dlg.PrinterSettings.Copies = 1
            For i = 1 To iCopies
                moPrintDocumentEx.IsPreview = False
                moPrintDocumentEx.Print()
            Next

        End If

    End Sub

End Class
