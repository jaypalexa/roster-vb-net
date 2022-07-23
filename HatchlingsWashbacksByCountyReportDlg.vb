Option Explicit On 
Option Strict On
Option Compare Text

Public Class HatchlingsWashbacksByCountyReportDlg
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HatchlingsWashbacksByCountyReportDlg))
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
        Me.dtpDateFrom.BackColor = System.Drawing.SystemColors.Window
        Me.dtpDateFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dtpDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtpDateFrom.DateValue = New Date(2006, 5, 31, 0, 0, 0, 0)
        Me.dtpDateFrom.Location = New System.Drawing.Point(131, 80)
        Me.dtpDateFrom.MaxValue = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateFrom.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(96, 20)
        Me.dtpDateFrom.TabIndex = 2
        '
        'dtpDateThru
        '
        Me.dtpDateThru.BackColor = System.Drawing.SystemColors.Window
        Me.dtpDateThru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dtpDateThru.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtpDateThru.DateValue = New Date(2006, 5, 31, 0, 0, 0, 0)
        Me.dtpDateThru.Location = New System.Drawing.Point(305, 80)
        Me.dtpDateThru.MaxValue = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateThru.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
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
        'HatchlingsWashbacksByCountyReportDlg
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
        Me.Name = "HatchlingsWashbacksByCountyReportDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hatchlings and Washbacks By County Report"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Const HATCHLINGS_ACQUIRED_X_POS As Single = 300
    Private Const HATCHLINGS_DOA_X_POS As Single = 375
    Private Const WASHBACKS_ACQUIRED_UNDER_5CM_X_POS As Single = 450
    Private Const WASHBACKS_ACQUIRED_OVER_5CM_X_POS As Single = 525
    Private Const WASHBACKS_DOA_UNDER_5CM_X_POS As Single = 600
    Private Const WASHBACKS_DOA_OVER_5CM_X_POS As Single = 675

    Private Sub frmHatchlingsWashbacksAcquiredByCountyReportDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
        Dim iEventCount As Integer = 0
        Dim iGrandTotalHatchlingsAcquired As Integer = 0
        Dim iGrandTotalHatchlingsDoa As Integer = 0
        Dim iGrandTotalWashbacksUnder5cmAcquired As Integer = 0
        Dim iGrandTotalWashbacksOver5cmAcquired As Integer = 0
        Dim iGrandTotalWashbacksUnder5cmDoa As Integer = 0
        Dim iGrandTotalWashbacksOver5cmDoa As Integer = 0
        Dim iSubTotalHatchlingsAcquired As Integer = 0
        Dim iSubTotalHatchlingsDoa As Integer = 0
        Dim iSubTotalWashbacksUnder5cmAcquired As Integer = 0
        Dim iSubTotalWashbacksOver5cmAcquired As Integer = 0
        Dim iSubTotalWashbacksUnder5cmDoa As Integer = 0
        Dim iSubTotalWashbacksOver5cmDoa As Integer = 0
        Dim s As String = String.Empty
        Dim sMonthsAndYearOfReport As String = String.Empty
        Dim sOrganizationAndPermitNumber As String = String.Empty
        Dim sCountyName As String = String.Empty
        Dim dtDateFrom As Date
        Dim dtDateThru As Date
        Dim dtTempDate As Date
        Dim oKeyValueInfo As KeyValueInfo
        Dim oOrganization As Organization
        Dim oHatchlingsWashbacksCountyList As HatchlingsWashbacksCountyList
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
            '-- begin the report output
            '----------------------------------------------------------------
            oPrintDocumentEx = New PrintDocumentEx

            oPrintDocumentEx.DocumentName = "Hatchlings and Washbacks by County Report"

            oPrintDocumentEx.WriteLine(oPrintDocumentEx.DocumentName, "Times New Roman", 12, True, , , PrintDocumentEx.AlignmentType.Center, False)
            oPrintDocumentEx.WriteLine(sMonthsAndYearOfReport, "Times New Roman", 12, True, , , PrintDocumentEx.AlignmentType.Center, False)
            oPrintDocumentEx.WriteLine(sOrganizationAndPermitNumber, "Times New Roman", 12, True, , , PrintDocumentEx.AlignmentType.Center, False)
            oPrintDocumentEx.WriteLine(String.Empty, "Times New Roman", 12, False)

            '----------------------------------------------------------------
            '-- get report data
            '----------------------------------------------------------------
            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

                '----------------------------------------------------------------
                '-- aggregate data for all counties
                '----------------------------------------------------------------
                WriteSectionHeader(oPrintDocumentEx, "** ALL COUNTIES **")

                '----------------------------------------------------------------
                '-- ALL COUNTIES:  CC
                '----------------------------------------------------------------
                oPrintDocumentEx.Write("Cc", fFontSize:=10, bBold:=True)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
                s &= "WHERE species_code = 'CC' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_ACQUIRED_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
                s &= "WHERE species_code = 'CC' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_DOA_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                s &= "WHERE species_code = 'CC' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'Y' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                s &= "WHERE species_code = 'CC' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'N' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                s &= "WHERE species_code = 'CC' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'Y' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                s &= "WHERE species_code = 'CC' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'N' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)

                oPrintDocumentEx.WriteLine(String.Empty)

                '----------------------------------------------------------------
                '-- ALL COUNTIES:  CM
                '----------------------------------------------------------------
                oPrintDocumentEx.Write("Cm", fFontSize:=10, bBold:=True)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
                s &= "WHERE species_code = 'CM' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_ACQUIRED_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
                s &= "WHERE species_code = 'CM' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_DOA_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                s &= "WHERE species_code = 'CM' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'Y' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                s &= "WHERE species_code = 'CM' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'N' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                s &= "WHERE species_code = 'CM' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'Y' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                s &= "WHERE species_code = 'CM' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'N' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)

                oPrintDocumentEx.WriteLine(String.Empty)

                '----------------------------------------------------------------
                '-- ALL COUNTIES:  DC
                '----------------------------------------------------------------
                oPrintDocumentEx.Write("Dc", fFontSize:=10, bBold:=True)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
                s &= "WHERE species_code = 'DC' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_ACQUIRED_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
                s &= "WHERE species_code = 'DC' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_DOA_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                s &= "WHERE species_code = 'DC' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'Y' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                s &= "WHERE species_code = 'DC' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'N' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                s &= "WHERE species_code = 'DC' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'Y' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                s &= "WHERE species_code = 'DC' "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'N' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)

                oPrintDocumentEx.WriteLine(String.Empty)

                '----------------------------------------------------------------
                '-- ALL COUNTIES:  OTHER
                '----------------------------------------------------------------
                oPrintDocumentEx.Write("Other", fFontSize:=10, bBold:=True)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
                s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_ACQUIRED_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
                s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_DOA_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'Y' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'N' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'Y' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'N' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)

                oPrintDocumentEx.WriteLine(String.Empty)

                '----------------------------------------------------------------
                '-- ALL COUNTIES:  UNKNOWN
                '----------------------------------------------------------------
                oPrintDocumentEx.Write("Unknown", fFontSize:=10, bBold:=True)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
                s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_ACQUIRED_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
                s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_DOA_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'Y' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'N' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'Y' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
                s &= "AND (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'N' "
                iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)

                oPrintDocumentEx.WriteLine(String.Empty)

                '----------------------------------------------------------------
                '-- ALL COUNTIES:  GRAND TOTAL
                '----------------------------------------------------------------
                oPrintDocumentEx.Write("** GRAND TOTAL **", fFontSize:=10, bBold:=True)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
                s &= "WHERE (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                iGrandTotalHatchlingsAcquired = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iGrandTotalHatchlingsAcquired), fXPos:=HATCHLINGS_ACQUIRED_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
                s &= "WHERE (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                iGrandTotalHatchlingsDoa = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iGrandTotalHatchlingsDoa), fXPos:=HATCHLINGS_DOA_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                s &= "WHERE (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'Y' "
                iGrandTotalWashbacksUnder5cmAcquired = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iGrandTotalWashbacksUnder5cmAcquired), fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                s &= "WHERE (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'N' "
                iGrandTotalWashbacksOver5cmAcquired = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iGrandTotalWashbacksOver5cmAcquired), fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                s &= "WHERE (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'Y' "
                iGrandTotalWashbacksUnder5cmDoa = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iGrandTotalWashbacksUnder5cmDoa), fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)

                s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                s &= "WHERE (@date_from <= event_date) "
                s &= "AND (event_date <= @date_thru) "
                s &= "AND under_5cm_clsl = 'N' "
                iGrandTotalWashbacksOver5cmDoa = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru)))))

                oPrintDocumentEx.Write(Convert.ToString(iGrandTotalWashbacksOver5cmDoa), fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)

                oPrintDocumentEx.WriteLine(String.Empty)

                '----------------------------------------------------------------
                '----------------------------------------------------------------
                oPrintDocumentEx.WriteLine(String.Empty)

                '----------------------------------------------------------------
                '-- get data for each individual county
                '----------------------------------------------------------------
                oHatchlingsWashbacksCountyList = HatchlingsWashbacksCountyList.GetList(False, dtDateFrom, dtDateThru)

                '----------------------------------------------------------------
                '-- output detail data
                '----------------------------------------------------------------
                iLineCount = 16

                For i = 0 To oHatchlingsWashbacksCountyList.Count - 1

                    oKeyValueInfo = oHatchlingsWashbacksCountyList(i)
                    sCountyName = oKeyValueInfo.Value

                    If (iLineCount > 45) Then
                        oPrintDocumentEx.NewPage()
                        iLineCount = 0
                    End If

                    WriteSectionHeader(oPrintDocumentEx, sCountyName)

                    '----------------------------------------------------------------
                    '-- SPECIFIC COUNTY:  CC
                    '----------------------------------------------------------------
                    oPrintDocumentEx.Write("Cc", fFontSize:=10, bBold:=True)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
                    s &= "WHERE species_code = 'CC' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_ACQUIRED_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
                    s &= "WHERE species_code = 'CC' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_DOA_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                    s &= "WHERE species_code = 'CC' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'Y' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                    s &= "WHERE species_code = 'CC' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'N' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                    s &= "WHERE species_code = 'CC' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'Y' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                    s &= "WHERE species_code = 'CC' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'N' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)

                    oPrintDocumentEx.WriteLine(String.Empty)

                    '----------------------------------------------------------------
                    '-- SPECIFIC COUNTY:  CM
                    '----------------------------------------------------------------
                    oPrintDocumentEx.Write("Cm", fFontSize:=10, bBold:=True)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
                    s &= "WHERE species_code = 'CM' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_ACQUIRED_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
                    s &= "WHERE species_code = 'CM' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_DOA_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                    s &= "WHERE species_code = 'CM' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'Y' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                    s &= "WHERE species_code = 'CM' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'N' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                    s &= "WHERE species_code = 'CM' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'Y' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                    s &= "WHERE species_code = 'CM' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'N' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)

                    oPrintDocumentEx.WriteLine(String.Empty)

                    '----------------------------------------------------------------
                    '-- SPECIFIC COUNTY:  DC
                    '----------------------------------------------------------------
                    oPrintDocumentEx.Write("Dc", fFontSize:=10, bBold:=True)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
                    s &= "WHERE species_code = 'DC' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_ACQUIRED_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
                    s &= "WHERE species_code = 'DC' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_DOA_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                    s &= "WHERE species_code = 'DC' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'Y' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                    s &= "WHERE species_code = 'DC' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'N' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                    s &= "WHERE species_code = 'DC' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'Y' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                    s &= "WHERE species_code = 'DC' "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'N' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)

                    oPrintDocumentEx.WriteLine(String.Empty)

                    '----------------------------------------------------------------
                    '-- SPECIFIC COUNTY:  OTHER
                    '----------------------------------------------------------------
                    oPrintDocumentEx.Write("Other", fFontSize:=10, bBold:=True)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
                    s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_ACQUIRED_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
                    s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_DOA_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                    s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'Y' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                    s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'N' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                    s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'Y' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                    s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'N' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)

                    oPrintDocumentEx.WriteLine(String.Empty)

                    '----------------------------------------------------------------
                    '-- SPECIFIC COUNTY:  UNKNOWN
                    '----------------------------------------------------------------
                    oPrintDocumentEx.Write("Unknown", fFontSize:=10, bBold:=True)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
                    s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_ACQUIRED_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
                    s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=HATCHLINGS_DOA_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                    s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'Y' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                    s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'N' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                    s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'Y' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                    s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
                    s &= "AND (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'Y' "
                    iEventCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iEventCount), fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)

                    oPrintDocumentEx.WriteLine(String.Empty)

                    '----------------------------------------------------------------
                    '-- SPECIFIC COUNTY:  SUBTOTAL
                    '----------------------------------------------------------------
                    oPrintDocumentEx.Write("-- SUBTOTAL --", fFontSize:=10, bBold:=True)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
                    s &= "WHERE (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    iSubTotalHatchlingsAcquired = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iSubTotalHatchlingsAcquired), fXPos:=HATCHLINGS_ACQUIRED_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
                    s &= "WHERE (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    iSubTotalHatchlingsDoa = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iSubTotalHatchlingsDoa), fXPos:=HATCHLINGS_DOA_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                    s &= "WHERE (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'Y' "
                    iSubTotalWashbacksUnder5cmAcquired = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iSubTotalWashbacksUnder5cmAcquired), fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
                    s &= "WHERE (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(acquired_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'N' "
                    iSubTotalWashbacksOver5cmAcquired = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iSubTotalWashbacksOver5cmAcquired), fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                    s &= "WHERE (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'Y' "
                    iSubTotalWashbacksUnder5cmDoa = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iSubTotalWashbacksUnder5cmDoa), fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)

                    s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
                    s &= "WHERE (@date_from <= event_date) "
                    s &= "AND (event_date <= @date_thru) "
                    s &= "AND UPPER(doa_from_county) = UPPER(@county_name) "
                    s &= "AND under_5cm_clsl = 'N' "
                    iSubTotalWashbacksOver5cmDoa = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", dtDateFrom), oAdoHelper.GetParameter("@date_thru", dtDateThru), oAdoHelper.GetParameter("@county_name", sCountyName)))))

                    oPrintDocumentEx.Write(Convert.ToString(iSubTotalWashbacksOver5cmDoa), fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)

                    oPrintDocumentEx.WriteLine(String.Empty)

                    '----------------------------------------------------------------
                    '-- SPECIFIC COUNTY:  % OF GRAND TOTAL
                    '----------------------------------------------------------------
                    oPrintDocumentEx.Write("% of Grand Total", fFontSize:=10, bBold:=True)

                    If (iGrandTotalHatchlingsAcquired > 0) Then
                        oPrintDocumentEx.Write(Format((iSubTotalHatchlingsAcquired / iGrandTotalHatchlingsAcquired) * 100, "0.00") & "%", fXPos:=HATCHLINGS_ACQUIRED_X_POS)
                    Else
                        oPrintDocumentEx.Write("0.00%", fXPos:=HATCHLINGS_ACQUIRED_X_POS)
                    End If

                    If (iGrandTotalHatchlingsDoa > 0) Then
                        oPrintDocumentEx.Write(Format((iSubTotalHatchlingsDoa / iGrandTotalHatchlingsDoa) * 100, "0.00") & "%", fXPos:=HATCHLINGS_DOA_X_POS)
                    Else
                        oPrintDocumentEx.Write("0.00%", fXPos:=HATCHLINGS_DOA_X_POS)
                    End If

                    If (iGrandTotalWashbacksUnder5cmAcquired > 0) Then
                        oPrintDocumentEx.Write(Format((iSubTotalWashbacksUnder5cmAcquired / iGrandTotalWashbacksUnder5cmAcquired) * 100, "0.00") & "%", fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)
                    Else
                        oPrintDocumentEx.Write("0.00%", fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS)
                    End If

                    If (iGrandTotalWashbacksOver5cmAcquired > 0) Then
                        oPrintDocumentEx.Write(Format((iSubTotalWashbacksOver5cmAcquired / iGrandTotalWashbacksOver5cmAcquired) * 100, "0.00") & "%", fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)
                    Else
                        oPrintDocumentEx.Write("0.00%", fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS)
                    End If

                    If (iGrandTotalWashbacksUnder5cmDoa > 0) Then
                        oPrintDocumentEx.Write(Format((iSubTotalWashbacksUnder5cmDoa / iGrandTotalWashbacksUnder5cmDoa) * 100, "0.00") & "%", fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)
                    Else
                        oPrintDocumentEx.Write("0.00%", fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS)
                    End If

                    If (iGrandTotalWashbacksOver5cmDoa > 0) Then
                        oPrintDocumentEx.Write(Format((iSubTotalWashbacksOver5cmDoa / iGrandTotalWashbacksOver5cmDoa) * 100, "0.00") & "%", fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)
                    Else
                        oPrintDocumentEx.Write("0.00%", fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS)
                    End If

                    oPrintDocumentEx.WriteLine(String.Empty)

                    '----------------------------------------------------------------
                    '----------------------------------------------------------------
                    oPrintDocumentEx.WriteLine(String.Empty)

                    iLineCount += 11

                Next

                oPrintDocumentEx.WriteLine(String.Empty)

                oPrintDocumentEx.Preview(Me)

            End Using

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            oOrganization = Nothing
            oHatchlingsWashbacksCountyList = Nothing
            oPrintDocumentEx = Nothing

            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub WriteSectionHeader(ByVal oPrintDocumentEx As PrintDocumentEx, ByVal sCountyName As String)

        oPrintDocumentEx.Write("[ " & sCountyName & " ]", fFontSize:=10, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.Write("Hatchlings", fFontSize:=9, fXPos:=HATCHLINGS_ACQUIRED_X_POS, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.Write("Hatchlings", fFontSize:=9, fXPos:=HATCHLINGS_DOA_X_POS, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.Write("Washbacks", fFontSize:=9, fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.Write("Washbacks", fFontSize:=9, fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.Write("Washbacks", fFontSize:=9, fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.Write("Washbacks", fFontSize:=9, fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.WriteLine(String.Empty)

        oPrintDocumentEx.Write("", fFontSize:=10, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.Write("Acquired", fFontSize:=9, fXPos:=HATCHLINGS_ACQUIRED_X_POS, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("DOA", fFontSize:=9, fXPos:=HATCHLINGS_DOA_X_POS, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("Acquired", fFontSize:=9, fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.Write("Acquired", fFontSize:=9, fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.Write("DOA", fFontSize:=9, fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.Write("DOA", fFontSize:=9, fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.WriteLine(String.Empty)

        oPrintDocumentEx.Write("", fFontSize:=10, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.Write("", fFontSize:=9, fXPos:=HATCHLINGS_ACQUIRED_X_POS, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.Write("", fFontSize:=9, fXPos:=HATCHLINGS_ACQUIRED_X_POS, bBold:=True, bUnderline:=False)
        oPrintDocumentEx.Write("(< 5cm)", fFontSize:=9, fXPos:=WASHBACKS_ACQUIRED_UNDER_5CM_X_POS, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("(>= 5cm)", fFontSize:=9, fXPos:=WASHBACKS_ACQUIRED_OVER_5CM_X_POS, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("(< 5cm)", fFontSize:=9, fXPos:=WASHBACKS_DOA_UNDER_5CM_X_POS, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.Write("(>= 5cm)", fFontSize:=9, fXPos:=WASHBACKS_DOA_OVER_5CM_X_POS, bBold:=True, bUnderline:=True)
        oPrintDocumentEx.WriteLine(String.Empty)

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Me.Close()

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "HatchlingsAndWashbacksByCountyReport.htm")
    End Sub

End Class
