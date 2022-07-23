Option Explicit On
Option Strict On
Option Compare Text

Imports System.IO

Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports iTextSharp.text.Document
Imports iTextSharp.text.pdf.PRAcroForm
Imports iTextSharp.text.pdf.PdfCopy
Imports iTextSharp.text.pdf.PdfImportedPage
Imports iTextSharp.text.pdf.PdfReader
Imports iTextSharp.text.pdf.SimpleBookmark

Module AppCommon

    Public gsHelpFileName As String = String.Empty

    Public Const CONNECTION_STRING As String = "Data Source=roster_data.db3;Version=3;New=False;Compress=True"

    Public Const MASTER_BEACH_RESTORATION_PROJECT_MONITORING_PDF As String = "MASTER - Beach Restoration Project Monitoring.master.pdf"
    Public Const MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_ALL_PAGES_PDF As String = "MASTER - Marine Turtle Holding Facility Quarterly Report.master.pdf"
    Public Const MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_1_PDF As String = "MASTER - Marine Turtle Holding Facility Quarterly Report Page 1.master.pdf"
    Public Const MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_2_PDF As String = "MASTER - Marine Turtle Holding Facility Quarterly Report Page 2.master.pdf"
    Public Const MASTER_MARINE_TURTLE_HOLDING_FACILITY_QUARTERLY_REPORT_PAGE_3_PDF As String = "MASTER - Marine Turtle Holding Facility Quarterly Report Page 3.master.pdf"
    Public Const MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_HATCHLINGS_PDF As String = "MASTER - Marine Turtle Captive Facility Quarterly Report For Hatchlings.master.pdf"
    Public Const MASTER_MARINE_TURTLE_CAPTIVE_FACILITY_QUARTERLY_REPORT_FOR_WASHBACKS_PDF As String = "MASTER - Marine Turtle Captive Facility Quarterly Report For Washbacks.master.pdf"
    Public Const MASTER_DISORIENTATION_INCIDENT_REPORT_FORM_PDF As String = "MASTER - Disorientation Incident Report form.master.pdf"
    Public Const MASTER_DISORIENTATION_INCIDENT_REPORT_FORM_DIRECTIONS_PDF As String = "MASTER - Disorientation Incident Report form directions.master.pdf"
    Public Const MASTER_EDUCATIONAL_PRESENTATION_FORM_PDF As String = "MASTER - Educational Presentation form.master.pdf"
    Public Const MASTER_NECROPSY_FORM_PDF As String = "MASTER - Necropsy form.master.pdf"
    Public Const MASTER_NIGHTTIME_PUBLIC_HATCHLING_RELEASE_FORM_PDF As String = "MASTER - Nighttime Public Hatchling Release form.master.pdf"
    Public Const MASTER_OBSTRUCTED_NESTING_ATTEMPT_REPORT_FORM_PDF As String = "MASTER - Obstructed Nesting Attempt Report form.master.pdf"
    Public Const MASTER_OBSTRUCTED_NESTING_ATTEMPT_REPORT_FORM_DIRECTIONS_PDF As String = "MASTER - Obstructed Nesting Attempt Report form directions.master.pdf"
    Public Const MASTER_PAILLOMA_FORM_PDF As String = "MASTER - Papilloma form.master.pdf"
    Public Const MASTER_PUBLIC_TURTLE_WATCH_SCHEDULE_FORMS_PDF As String = "MASTER - Public Turtle Watch Schedule form.master.pdf"
    Public Const MASTER_PUBLIC_TURTLE_WATCH_SUMMARY_FORMS_PDF As String = "MASTER - Public Turtle Watch Summary form.master.pdf"
    Public Const MASTER_STRANDING_AND_SALVAGE_FORM_PDF As String = "MASTER - Stranding and Salvage form.master.pdf"
    Public Const MASTER_TAG_REQUEST_FORM_PDF As String = "MASTER - Tag Request form.master.pdf"
    Public Const MASTER_TAGGING_DATA_FORM_PDF As String = "MASTER - Tagging Data form.master.pdf"
    Public Const MASTER_TURTLE_TRANSFER_FORM_PDF As String = "MASTER - Turtle Transfer form.master.pdf"

    Public Sub ConcatenatePdfFiles(ByVal vsSourceFileName As String, ByVal vsDestinationFileName As String)

        Dim sPageArray As String()

        '----------------------------------------------------------------
        '-- add the source page and destination page
        '-- to the page array to be passed 
        '-- to the function which performs the concatenation
        '----------------------------------------------------------------
        ReDim Preserve sPageArray(1)

        sPageArray(0) = vsSourceFileName
        sPageArray(1) = vsDestinationFileName

        Call ConcatenatePdfFiles(sPageArray)

    End Sub

    Public Sub ConcatenatePdfFiles(ByVal args As String())

        If args.Length < 2 Then
            'System.err.println("arguments: file1 [file2 ...] destfile")
        Else

            Try
                Dim pageOffset As Integer = 0
                Dim master As New ArrayList
                Dim f As Integer = 0
                Dim outFile As String = args(UBound(args))
                Dim document As Document = Nothing
                Dim writer As PdfCopy = Nothing

                While f < UBound(args)
                    ' we create a reader for a certain document
                    Dim reader As New PdfReader(args(f))
                    reader.ConsolidateNamedDestinations()
                    ' we retrieve the total number of pages
                    Dim n As Integer = reader.NumberOfPages()
                    Dim bookmarks As System.Collections.ArrayList = SimpleBookmark.GetBookmark(reader)
                    If Not (bookmarks Is Nothing) Then
                        If pageOffset <> 0 Then
                            SimpleBookmark.ShiftPageNumbers(bookmarks, pageOffset, Nothing)
                        End If
                        master.AddRange(bookmarks)
                    End If
                    pageOffset += n

                    If f = 0 Then
                        ' step 1: creation of a document-object
                        document = New Document(reader.GetPageSizeWithRotation(1))
                        ' step 2: we create a writer that listens to the document
                        writer = New PdfCopy(document, New FileStream(outFile, FileMode.Create))
                        ' step 3: we open the document
                        document.Open()
                    End If
                    ' step 4: we add content
                    Dim page As PdfImportedPage
                    Dim i As Integer
                    i = 0
                    While i < n
                        i += 1
                        page = writer.GetImportedPage(reader, i)
                        writer.AddPage(page)
                    End While
                    Dim form As PRAcroForm = reader.AcroForm()
                    If Not (form Is Nothing) Then
                        writer.CopyAcroForm(reader)
                    End If
                    f += 1
                End While

                'If master.Count() > 0 Then
                '   writer.SetOutlines(master)
                'End If

                ' step 5: we close the document
                document.Close()
            Catch ex As System.Exception
                ErrorMessageBox.Show(ex)
            End Try
        End If

    End Sub

    Public Sub DisplayFieldNamesInPdfForm(ByVal sMasterReportName As String)

        Dim sFilledReportName As String = String.Empty
        Dim sKey As String = String.Empty
        Dim oPdfReader As PdfReader = Nothing
        Dim oPdfStamper As PdfStamper = Nothing
        Dim oAcroFields As AcroFields = Nothing
        Dim oPdfDictionary As PdfDictionary = Nothing

        Try

            '----------------------------------------------------------------
            '-- displays the field names within a PDF form
            '----------------------------------------------------------------
            oPdfReader = New PdfReader(sMasterReportName)
            oPdfDictionary = DirectCast(PdfReader.GetPdfObject(oPdfReader.Catalog.Get(PdfName.ACROFORM)), PdfDictionary)
            oPdfDictionary.Remove(New PdfName("XFA"))

            sFilledReportName = sMasterReportName.Replace("MASTER - ", "FILLED - ").Replace(".master.pdf", " - " & Now.ToString("yyyyMMddHHmmss") & ".pdf")
            oPdfStamper = New PdfStamper(oPdfReader, New System.IO.FileStream(sFilledReportName, IO.FileMode.Create))

            oAcroFields = oPdfStamper.AcroFields()

            For Each sKey In oAcroFields.Fields.Keys
                oAcroFields.SetField(sKey, sKey)
            Next

            System.Diagnostics.Process.Start(sFilledReportName)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            oAcroFields = Nothing

            oPdfStamper.Close()
            oPdfStamper = Nothing

            oPdfReader.Close()
            oPdfReader = Nothing

        End Try

    End Sub

    Public Function WrapLine(ByVal vsLineToWrap As String, ByVal viMaxLineLength As Integer) As String()

        Dim iCurrentLineLength As Integer = 0
        Dim sLineToWrap As String = String.Empty
        Dim sCurrentWord As String = String.Empty
        Dim sCurrentLine As String = String.Empty
        Dim oWordArray As String()
        Dim oLineArrayList As ArrayList
        Dim oReturnStringArray() As String = Nothing

        sLineToWrap = vsLineToWrap

        sLineToWrap = sLineToWrap.Replace(ControlChars.CrLf, " ")
        sLineToWrap = sLineToWrap.Replace(ControlChars.Lf, " ")
        sLineToWrap = sLineToWrap.Replace(ControlChars.Cr, " ")
        sLineToWrap = sLineToWrap.Replace(ControlChars.Tab, " ")
        'sLineToWrap = sLineToWrap.Replace(".", ". ")
        sLineToWrap = sLineToWrap.Replace(",", ", ")
        sLineToWrap = sLineToWrap.Replace(";", "; ")
        sLineToWrap = sLineToWrap.Replace(":", ": ")
        sLineToWrap = sLineToWrap.Replace("!", "! ")
        sLineToWrap = sLineToWrap.Replace("?", "? ")

        oWordArray = sLineToWrap.Split(" "c)
        oLineArrayList = New ArrayList(CInt(sLineToWrap.Length / viMaxLineLength))

        For Each sCurrentWord In oWordArray

            If (sCurrentWord.Trim.Length > 0) Then

                If ((iCurrentLineLength + sCurrentWord.Length + 1) < viMaxLineLength) Then

                    If (sCurrentLine.Trim.Length > 0) Then
                        sCurrentLine &= " "
                    End If
                    sCurrentLine &= sCurrentWord
                    iCurrentLineLength += sCurrentWord.Length + 1
                Else
                    oLineArrayList.Add(sCurrentLine)
                    sCurrentLine = sCurrentWord
                    iCurrentLineLength = sCurrentWord.Length
                End If

            End If

        Next sCurrentWord

        If (sCurrentLine.Trim.Length > 0) Then
            oLineArrayList.Add(sCurrentLine)
        End If

        If (oLineArrayList.Count > 0) Then
            ReDim oReturnStringArray(oLineArrayList.Count - 1)
            oLineArrayList.CopyTo(oReturnStringArray)
        End If

        Return oReturnStringArray

    End Function

#Region " Common Business Rules - Validation Rules "

    Public Function NewPasswordsMustMatch(ByVal target As Object, ByVal e As Csla.Validation.RuleArgs) As Boolean

        '???TODO:  figure out why I can't put these in the UserPassword class itself

        Dim sNewPassword As String = String.Empty
        Dim sConfirmNewPassword As String = String.Empty

        sNewPassword = Convert.ToString(CallByName(target, "NewPassword", CallType.Get))
        sConfirmNewPassword = Convert.ToString(CallByName(target, "ConfirmNewPassword", CallType.Get))

        If (String.Compare(sNewPassword, sConfirmNewPassword, True) <> 0) Then
            Return False
        Else
            Return True
        End If

    End Function

#End Region

End Module
