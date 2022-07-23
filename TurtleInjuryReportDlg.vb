Option Explicit On 
Option Strict On
Option Compare Text

Public Class TurtleInjuryReportDlg
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents lblDescription As System.Windows.Forms.Label
    Friend WithEvents dtpDateFrom As TurtleGeek.Controls.DateComboBox
    Friend WithEvents dtpDateThru As TurtleGeek.Controls.DateComboBox
    Friend WithEvents lblDateFrom As System.Windows.Forms.Label
    Friend WithEvents lblDateThru As System.Windows.Forms.Label
    Friend WithEvents lblSeparator As System.Windows.Forms.Label
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TurtleInjuryReportDlg))
        Me.btnCreate = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblDescription = New System.Windows.Forms.Label
        Me.dtpDateFrom = New TurtleGeek.Controls.DateComboBox
        Me.dtpDateThru = New TurtleGeek.Controls.DateComboBox
        Me.lblDateFrom = New System.Windows.Forms.Label
        Me.lblDateThru = New System.Windows.Forms.Label
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnHelp = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.Location = New System.Drawing.Point(336, 200)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(72, 24)
        Me.btnCreate.TabIndex = 6
        Me.btnCreate.Text = "Create"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(416, 200)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 24)
        Me.btnClose.TabIndex = 7
        Me.btnClose.Text = "Close"
        '
        'lblDescription
        '
        Me.lblDescription.BackColor = System.Drawing.Color.MintCream
        Me.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDescription.ForeColor = System.Drawing.Color.Green
        Me.lblDescription.Location = New System.Drawing.Point(8, 8)
        Me.lblDescription.Name = "lblDescription"
        Me.lblDescription.Size = New System.Drawing.Size(480, 32)
        Me.lblDescription.TabIndex = 0
        Me.lblDescription.Text = "Indicate the desired date range and then click 'Create' to generate the report."
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.DateValue = New Date(2006, 5, 31, 23, 40, 21, 984)
        Me.dtpDateFrom.Location = New System.Drawing.Point(131, 80)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(96, 20)
        Me.dtpDateFrom.TabIndex = 2
        '
        'dtpDateThru
        '
        Me.dtpDateThru.DateValue = New Date(2006, 5, 31, 23, 35, 21, 281)
        Me.dtpDateThru.Location = New System.Drawing.Point(305, 80)
        Me.dtpDateThru.Name = "dtpDateThru"
        Me.dtpDateThru.Size = New System.Drawing.Size(96, 20)
        Me.dtpDateThru.TabIndex = 4
        '
        'lblDateFrom
        '
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.Location = New System.Drawing.Point(67, 84)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(56, 13)
        Me.lblDateFrom.TabIndex = 1
        Me.lblDateFrom.Text = "Date from:"
        '
        'lblDateThru
        '
        Me.lblDateThru.AutoSize = True
        Me.lblDateThru.Location = New System.Drawing.Point(249, 84)
        Me.lblDateThru.Name = "lblDateThru"
        Me.lblDateThru.Size = New System.Drawing.Size(54, 13)
        Me.lblDateThru.TabIndex = 3
        Me.lblDateThru.Text = "Date thru:"
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(8, 184)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(480, 2)
        Me.lblSeparator.TabIndex = 5
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(8, 200)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 24)
        Me.btnHelp.TabIndex = 8
        Me.btnHelp.Text = "Help"
        '
        'TurtleInjuryReportDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(498, 239)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.lblDateThru)
        Me.Controls.Add(Me.lblDateFrom)
        Me.Controls.Add(Me.dtpDateThru)
        Me.Controls.Add(Me.dtpDateFrom)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TurtleInjuryReportDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turtle Injury Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmTurtleInjuryReportDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim iCurrentMonth As Integer
        Dim iCurrentMonthDiff As Integer
        Dim dtDateTimeNow As Date
        Dim dtDateTimeLastMonthOfLastQuarter As Date

        '----------------------------------------------------------------
        '-- initialize the report dates to last quarter
        '----------------------------------------------------------------
        dtDateTimeNow = DateTime.Now

        iCurrentMonth = dtDateTimeNow.Month
        iCurrentMonthDiff = iCurrentMonth Mod 3
        If (iCurrentMonthDiff = 0) Then
            iCurrentMonthDiff = 3
        End If

        dtDateTimeLastMonthOfLastQuarter = New Date(dtDateTimeNow.AddMonths(-iCurrentMonthDiff).Year, dtDateTimeNow.AddMonths(-iCurrentMonthDiff).Month, DateTime.DaysInMonth(dtDateTimeNow.AddMonths(-iCurrentMonthDiff).Year, dtDateTimeNow.AddMonths(-iCurrentMonthDiff).Month), 0, 0, 0)

        dtpDateFrom.DateValue = New Date(dtDateTimeLastMonthOfLastQuarter.AddDays(1).AddMonths(-3).Year, dtDateTimeLastMonthOfLastQuarter.AddDays(1).AddMonths(-3).Month, 1, 0, 0, 0)
        dtpDateThru.DateValue = dtDateTimeLastMonthOfLastQuarter

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        Dim i As Integer
        Dim iLineCount As Integer
        Dim iTurtleCount As Integer = 0
        Dim iInjuryBoatStrikeCount As Integer = 0
        Dim iInjuryIntestinalImpactionCount As Integer = 0
        Dim iInjuryLineEntanglementCount As Integer = 0
        Dim iInjuryFishHookCount As Integer = 0
        Dim iInjuryUpperRespiratoryCount As Integer = 0
        Dim iInjuryAnimalBiteCount As Integer = 0
        Dim iInjuryFibropapillomaCount As Integer = 0
        Dim iInjuryMiscEpidemic As Integer = 0
        Dim iInjuryDoaCount As Integer = 0
        Dim iInjuryOtherCount As Integer = 0
        Dim iInjuryNoneCount As Integer = 0
        Dim sMonthsAndYearOfReport As String = String.Empty
        Dim sOrganizationAndPermitNumber As String = String.Empty
        Dim dtDateFrom As Date
        Dim dtDateThru As Date
        Dim dtTempDate As Date
        Dim oOrganization As Organization
        Dim oTurtle As Turtle
        Dim oTurtleListItems As TurtleListItems
        Dim oPrintDocumentEx As PrintDocumentEx

        Try

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- validate date range
            '----------------------------------------------------------------
            dtDateFrom = dtpDateFrom.DateValue
            dtDateThru = dtpDateThru.DateValue

            If (dtDateFrom.Equals(Date.MinValue)) Then
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                MessageBox.Show("Date From cannot be blank.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            If (dtDateThru.Equals(Date.MinValue)) Then
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                MessageBox.Show("Date Thru cannot be blank.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            '-- make the earlier date be first, if need be
            If (dtDateThru < dtDateFrom) Then
                dtTempDate = dtDateThru
                dtDateThru = dtDateFrom
                dtDateFrom = dtTempDate
            End If

            If (dtDateFrom.Year = dtDateThru.Year) Then
                sMonthsAndYearOfReport = dtDateFrom.ToString("dd") & " " & dtDateFrom.ToString("MMMM") & " - " & dtDateThru.ToString("dd") & " " & dtDateThru.ToString("MMMM") & " " & dtDateThru.Year.ToString
            Else
                sMonthsAndYearOfReport = dtDateFrom.ToString("dd") & " " & dtDateFrom.ToString("MMMM") & " " & dtDateFrom.Year.ToString & " - " & dtDateThru.ToString("dd") & " " & dtDateThru.ToString("MMMM") & " " & dtDateThru.Year.ToString
            End If

            '----------------------------------------------------------------
            '-- get ORGANIZATION data for report
            '----------------------------------------------------------------
            oOrganization = Organization.GetOrganization()
            sOrganizationAndPermitNumber = oOrganization.OrganizationName & " - " & oOrganization.PermitNumber
            oOrganization = Nothing

            '----------------------------------------------------------------
            '-- get TURTLE INJURY data for report
            '----------------------------------------------------------------
            oTurtleListItems = TurtleListItems.GetListByDatesInFacilityRange(dtDateFrom, dtDateThru)

            If (oTurtleListItems.Count = 0) Then
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                MessageBox.Show("No turtle data found for the indicated date range.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            '----------------------------------------------------------------
            '-- begin the report output
            '----------------------------------------------------------------
            oPrintDocumentEx = New PrintDocumentEx

            oPrintDocumentEx.DocumentName = "Turtle Injury Report"

            oPrintDocumentEx.WriteLine(oPrintDocumentEx.DocumentName, "Times New Roman", 12, True, , , PrintDocumentEx.AlignmentType.Center, False)
            oPrintDocumentEx.WriteLine(sMonthsAndYearOfReport, "Times New Roman", 12, True, , , PrintDocumentEx.AlignmentType.Center, False)
            oPrintDocumentEx.WriteLine(sOrganizationAndPermitNumber, "Times New Roman", 12, True, , , PrintDocumentEx.AlignmentType.Center, False)
            oPrintDocumentEx.WriteLine(String.Empty, "Times New Roman", 12, False)

            '----------------------------------------------------------------
            '-- aggregate injury data for all turtles
            '----------------------------------------------------------------
            For i = 0 To oTurtleListItems.Count - 1

                iTurtleCount += 1

                oTurtle = Turtle.GetTurtle(oTurtleListItems(i).TurtleID)

                If oTurtle.InjuryBoatStrike Then iInjuryBoatStrikeCount += 1
                If oTurtle.InjuryIntestinalImpaction Then iInjuryIntestinalImpactionCount += 1
                If oTurtle.InjuryLineEntanglement Then iInjuryLineEntanglementCount += 1
                If oTurtle.InjuryFishHook Then iInjuryFishHookCount += 1
                If oTurtle.InjuryUpperRespiratory Then iInjuryUpperRespiratoryCount += 1
                If oTurtle.InjuryAnimalBite Then iInjuryAnimalBiteCount += 1
                If oTurtle.InjuryFibropapilloma Then iInjuryFibropapillomaCount += 1
                If oTurtle.InjuryMiscEpidemic Then iInjuryMiscEpidemic += 1
                If oTurtle.InjuryDoa Then iInjuryDoaCount += 1
                If oTurtle.InjuryOther Then iInjuryOtherCount += 1

                If Not oTurtle.InjuryBoatStrike _
                AndAlso Not oTurtle.InjuryIntestinalImpaction _
                AndAlso Not oTurtle.InjuryLineEntanglement _
                AndAlso Not oTurtle.InjuryFishHook _
                AndAlso Not oTurtle.InjuryUpperRespiratory _
                AndAlso Not oTurtle.InjuryAnimalBite _
                AndAlso Not oTurtle.InjuryFibropapilloma _
                AndAlso Not oTurtle.InjuryMiscEpidemic _
                AndAlso Not oTurtle.InjuryDoa Then
                    iInjuryNoneCount += 1
                End If

            Next

            '----------------------------------------------------------------
            '-- output summary data
            '----------------------------------------------------------------
            oPrintDocumentEx.WriteLine("[Note:  A turtle may have more than one injury.]", fFontSize:=10)
            oPrintDocumentEx.WriteLine(String.Empty)

            oPrintDocumentEx.Write("Boat/Propeller strike:  ", fFontSize:=10, bBold:=True)
            oPrintDocumentEx.Write(iInjuryBoatStrikeCount.ToString & " of " & iTurtleCount.ToString & "  (" & ((iInjuryBoatStrikeCount / iTurtleCount) * 100).ToString("0.00") & "%)", fXPos:=250)
            oPrintDocumentEx.WriteLine(String.Empty)

            oPrintDocumentEx.Write("Intestinal impaction:  ", fFontSize:=10, bBold:=True)
            oPrintDocumentEx.Write(iInjuryIntestinalImpactionCount.ToString & " of " & iTurtleCount.ToString & "  (" & ((iInjuryIntestinalImpactionCount / iTurtleCount) * 100).ToString("0.00") & "%)", fXPos:=250)
            oPrintDocumentEx.WriteLine(String.Empty)

            oPrintDocumentEx.Write("Line/Net entanglement:  ", fFontSize:=10, bBold:=True)
            oPrintDocumentEx.Write(iInjuryLineEntanglementCount.ToString & " of " & iTurtleCount.ToString & "  (" & ((iInjuryLineEntanglementCount / iTurtleCount) * 100).ToString("0.00") & "%)", fXPos:=250)
            oPrintDocumentEx.WriteLine(String.Empty)

            oPrintDocumentEx.Write("Fish hook:  ", fFontSize:=10, bBold:=True)
            oPrintDocumentEx.Write(iInjuryFishHookCount.ToString & " of " & iTurtleCount.ToString & "  (" & ((iInjuryFishHookCount / iTurtleCount) * 100).ToString("0.00") & "%)", fXPos:=250)
            oPrintDocumentEx.WriteLine(String.Empty)

            oPrintDocumentEx.Write("Upper respiratory:  ", fFontSize:=10, bBold:=True)
            oPrintDocumentEx.Write(iInjuryUpperRespiratoryCount.ToString & " of " & iTurtleCount.ToString & "  (" & ((iInjuryUpperRespiratoryCount / iTurtleCount) * 100).ToString("0.00") & "%)", fXPos:=250)
            oPrintDocumentEx.WriteLine(String.Empty)

            oPrintDocumentEx.Write("Shark/Bird bite:  ", fFontSize:=10, bBold:=True)
            oPrintDocumentEx.Write(iInjuryAnimalBiteCount.ToString & " of " & iTurtleCount.ToString & "  (" & ((iInjuryAnimalBiteCount / iTurtleCount) * 100).ToString("0.00") & "%)", fXPos:=250)
            oPrintDocumentEx.WriteLine(String.Empty)

            oPrintDocumentEx.Write("Fibropapilloma:  ", fFontSize:=10, bBold:=True)
            oPrintDocumentEx.Write(iInjuryFibropapillomaCount.ToString & " of " & iTurtleCount.ToString & "  (" & ((iInjuryFibropapillomaCount / iTurtleCount) * 100).ToString("0.00") & "%)", fXPos:=250)
            oPrintDocumentEx.WriteLine(String.Empty)

            oPrintDocumentEx.Write("Misc. epidemic:  ", fFontSize:=10, bBold:=True)
            oPrintDocumentEx.Write(iInjuryMiscEpidemic.ToString & " of " & iTurtleCount.ToString & "  (" & ((iInjuryMiscEpidemic / iTurtleCount) * 100).ToString("0.00") & "%)", fXPos:=250)
            oPrintDocumentEx.WriteLine(String.Empty)

            oPrintDocumentEx.Write("DOA:  ", fFontSize:=10, bBold:=True)
            oPrintDocumentEx.Write(iInjuryDoaCount.ToString & " of " & iTurtleCount.ToString & "  (" & ((iInjuryDoaCount / iTurtleCount) * 100).ToString("0.00") & "%)", fXPos:=250)
            oPrintDocumentEx.WriteLine(String.Empty)

            oPrintDocumentEx.Write("Other:  ", fFontSize:=10, bBold:=True)
            oPrintDocumentEx.Write(iInjuryOtherCount.ToString & " of " & iTurtleCount.ToString & "  (" & ((iInjuryOtherCount / iTurtleCount) * 100).ToString("0.00") & "%)", fXPos:=250)
            oPrintDocumentEx.WriteLine(String.Empty)

            oPrintDocumentEx.Write("None:  ", fFontSize:=10, bBold:=True)
            oPrintDocumentEx.Write(iInjuryNoneCount.ToString & " of " & iTurtleCount.ToString & "  (" & ((iInjuryNoneCount / iTurtleCount) * 100).ToString("0.00") & "%)", fXPos:=250)
            oPrintDocumentEx.WriteLine(String.Empty)

            '----------------------------------------------------------------
            '-- DETAIL section
            '----------------------------------------------------------------
            oPrintDocumentEx.WriteLine(String.Empty)
            oPrintDocumentEx.WriteLine("Details", "Times New Roman", 11, True, , , PrintDocumentEx.AlignmentType.Center, True)

            '----------------------------------------------------------------
            '-- detail header
            '----------------------------------------------------------------
            WriteDetailHeader(oPrintDocumentEx)

            '----------------------------------------------------------------
            '-- output detail data
            '----------------------------------------------------------------
            iLineCount = 20

            For i = 0 To oTurtleListItems.Count - 1

                If (iLineCount > 44) Then
                    oPrintDocumentEx.NewPage()
                    WriteDetailHeader(oPrintDocumentEx)
                    iLineCount = 2
                End If

                oTurtle = Turtle.GetTurtle(oTurtleListItems(i).TurtleID)

                oPrintDocumentEx.Write(oTurtle.TurtleName, fFontSize:=10, bBold:=True)

                If oTurtle.InjuryBoatStrike Then
                    oPrintDocumentEx.Write("X", fXPos:=250)
                End If

                If oTurtle.InjuryIntestinalImpaction Then
                    oPrintDocumentEx.Write("X", fXPos:=300)
                End If

                If oTurtle.InjuryLineEntanglement Then
                    oPrintDocumentEx.Write("X", fXPos:=350)
                End If

                If oTurtle.InjuryFishHook Then
                    oPrintDocumentEx.Write("X", fXPos:=400)
                End If

                If oTurtle.InjuryUpperRespiratory Then
                    oPrintDocumentEx.Write("X", fXPos:=450)
                End If

                If oTurtle.InjuryAnimalBite Then
                    oPrintDocumentEx.Write("X", fXPos:=500)
                End If

                If oTurtle.InjuryFibropapilloma Then
                    oPrintDocumentEx.Write("X", fXPos:=550)
                End If

                If oTurtle.InjuryMiscEpidemic Then
                    oPrintDocumentEx.Write("X", fXPos:=600)
                End If

                If oTurtle.InjuryDoa Then
                    oPrintDocumentEx.Write("X", fXPos:=650)
                End If

                If oTurtle.InjuryOther Then
                    oPrintDocumentEx.Write("X", fXPos:=700)
                End If

                oPrintDocumentEx.WriteLine(String.Empty)

                iLineCount += 1

            Next

            oPrintDocumentEx.WriteLine(String.Empty)

            oPrintDocumentEx.Preview(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            oOrganization = Nothing
            oTurtleListItems = Nothing
            oTurtle = Nothing
            oPrintDocumentEx = Nothing

            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub WriteDetailHeader(ByVal oPrintDocumentEx As PrintDocumentEx)

        oPrintDocumentEx.Write("Turtle Name", fFontSize:=9, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("Strike", fXPos:=250, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("Intest", fXPos:=300, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("Tangle", fXPos:=350, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("Hook", fXPos:=400, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("UpResp", fXPos:=450, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("Bite", fXPos:=500, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("Pap", fXPos:=550, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("Epidem", fXPos:=600, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("DOA", fXPos:=650, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("Other", fXPos:=700, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.WriteLine(String.Empty)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "TurtleInjuryReport.htm")
    End Sub

End Class
