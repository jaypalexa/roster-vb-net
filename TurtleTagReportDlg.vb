Option Explicit On 
Option Strict On
Option Compare Text

Public Class TurtleTagReportDlg
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
    Friend WithEvents chkIncludeNonRelinquishedTurtles As System.Windows.Forms.CheckBox
    Friend WithEvents radDateTypeRelinquished As System.Windows.Forms.RadioButton
    Friend WithEvents radDateTypeAcquired As System.Windows.Forms.RadioButton
    Friend WithEvents radDateTypeTagged As System.Windows.Forms.RadioButton
    Friend WithEvents chkLff As System.Windows.Forms.CheckBox
    Friend WithEvents grpTagTypeAndLocationOptions As System.Windows.Forms.GroupBox
    Friend WithEvents grpDateFilterOptions As System.Windows.Forms.GroupBox
    Friend WithEvents chkPit As System.Windows.Forms.CheckBox
    Friend WithEvents chkRrf As System.Windows.Forms.CheckBox
    Friend WithEvents chkLrf As System.Windows.Forms.CheckBox
    Friend WithEvents chkRff As System.Windows.Forms.CheckBox
    Friend WithEvents lblFlipperTagsLine2 As System.Windows.Forms.Label
    Friend WithEvents lblFlipperTagsLine1 As System.Windows.Forms.Label
    Friend WithEvents lblFlipperTags As System.Windows.Forms.Label
    Friend WithEvents chkIncludeStrandingIdNumber As System.Windows.Forms.CheckBox
    Friend WithEvents grpOtherReportOptions As System.Windows.Forms.GroupBox
    Friend WithEvents btnCreate As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TurtleTagReportDlg))
        Me.btnCreate = New System.Windows.Forms.Button
        Me.btnClose = New System.Windows.Forms.Button
        Me.lblDescription = New System.Windows.Forms.Label
        Me.dtpDateFrom = New TurtleGeek.Controls.DateComboBox
        Me.dtpDateThru = New TurtleGeek.Controls.DateComboBox
        Me.lblDateFrom = New System.Windows.Forms.Label
        Me.lblDateThru = New System.Windows.Forms.Label
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnHelp = New System.Windows.Forms.Button
        Me.chkIncludeNonRelinquishedTurtles = New System.Windows.Forms.CheckBox
        Me.radDateTypeRelinquished = New System.Windows.Forms.RadioButton
        Me.radDateTypeAcquired = New System.Windows.Forms.RadioButton
        Me.radDateTypeTagged = New System.Windows.Forms.RadioButton
        Me.chkLff = New System.Windows.Forms.CheckBox
        Me.grpTagTypeAndLocationOptions = New System.Windows.Forms.GroupBox
        Me.lblFlipperTagsLine2 = New System.Windows.Forms.Label
        Me.lblFlipperTagsLine1 = New System.Windows.Forms.Label
        Me.chkPit = New System.Windows.Forms.CheckBox
        Me.lblFlipperTags = New System.Windows.Forms.Label
        Me.chkRrf = New System.Windows.Forms.CheckBox
        Me.chkLrf = New System.Windows.Forms.CheckBox
        Me.chkRff = New System.Windows.Forms.CheckBox
        Me.grpDateFilterOptions = New System.Windows.Forms.GroupBox
        Me.chkIncludeStrandingIdNumber = New System.Windows.Forms.CheckBox
        Me.grpOtherReportOptions = New System.Windows.Forms.GroupBox
        Me.grpTagTypeAndLocationOptions.SuspendLayout()
        Me.grpDateFilterOptions.SuspendLayout()
        Me.grpOtherReportOptions.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnCreate
        '
        Me.btnCreate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCreate.Location = New System.Drawing.Point(336, 260)
        Me.btnCreate.Name = "btnCreate"
        Me.btnCreate.Size = New System.Drawing.Size(72, 24)
        Me.btnCreate.TabIndex = 5
        Me.btnCreate.Text = "Create"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(416, 260)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 24)
        Me.btnClose.TabIndex = 6
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
        Me.lblDescription.Text = "Select the desired report options and then click 'Create' to generate the report." & _
            ""
        Me.lblDescription.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'dtpDateFrom
        '
        Me.dtpDateFrom.BackColor = System.Drawing.SystemColors.Window
        Me.dtpDateFrom.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dtpDateFrom.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtpDateFrom.DateValue = New Date(2006, 5, 31, 0, 0, 0, 0)
        Me.dtpDateFrom.Location = New System.Drawing.Point(204, 18)
        Me.dtpDateFrom.MaxValue = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateFrom.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateFrom.Name = "dtpDateFrom"
        Me.dtpDateFrom.Size = New System.Drawing.Size(96, 20)
        Me.dtpDateFrom.TabIndex = 4
        '
        'dtpDateThru
        '
        Me.dtpDateThru.BackColor = System.Drawing.SystemColors.Window
        Me.dtpDateThru.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dtpDateThru.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtpDateThru.DateValue = New Date(2006, 5, 31, 0, 0, 0, 0)
        Me.dtpDateThru.Location = New System.Drawing.Point(378, 18)
        Me.dtpDateThru.MaxValue = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpDateThru.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpDateThru.Name = "dtpDateThru"
        Me.dtpDateThru.Size = New System.Drawing.Size(96, 20)
        Me.dtpDateThru.TabIndex = 6
        '
        'lblDateFrom
        '
        Me.lblDateFrom.AutoSize = True
        Me.lblDateFrom.Location = New System.Drawing.Point(140, 22)
        Me.lblDateFrom.Name = "lblDateFrom"
        Me.lblDateFrom.Size = New System.Drawing.Size(56, 13)
        Me.lblDateFrom.TabIndex = 3
        Me.lblDateFrom.Text = "Date from:"
        '
        'lblDateThru
        '
        Me.lblDateThru.AutoSize = True
        Me.lblDateThru.Location = New System.Drawing.Point(322, 22)
        Me.lblDateThru.Name = "lblDateThru"
        Me.lblDateThru.Size = New System.Drawing.Size(54, 13)
        Me.lblDateThru.TabIndex = 5
        Me.lblDateThru.Text = "Date thru:"
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(8, 244)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(480, 2)
        Me.lblSeparator.TabIndex = 4
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(8, 260)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 24)
        Me.btnHelp.TabIndex = 7
        Me.btnHelp.Text = "Help"
        '
        'chkIncludeNonRelinquishedTurtles
        '
        Me.chkIncludeNonRelinquishedTurtles.AutoSize = True
        Me.chkIncludeNonRelinquishedTurtles.Enabled = False
        Me.chkIncludeNonRelinquishedTurtles.Location = New System.Drawing.Point(143, 56)
        Me.chkIncludeNonRelinquishedTurtles.Name = "chkIncludeNonRelinquishedTurtles"
        Me.chkIncludeNonRelinquishedTurtles.Size = New System.Drawing.Size(172, 17)
        Me.chkIncludeNonRelinquishedTurtles.TabIndex = 7
        Me.chkIncludeNonRelinquishedTurtles.Text = "Include non-relinquished turtles"
        Me.chkIncludeNonRelinquishedTurtles.UseVisualStyleBackColor = True
        '
        'radDateTypeRelinquished
        '
        Me.radDateTypeRelinquished.AutoSize = True
        Me.radDateTypeRelinquished.Checked = True
        Me.radDateTypeRelinquished.Location = New System.Drawing.Point(6, 56)
        Me.radDateTypeRelinquished.Name = "radDateTypeRelinquished"
        Me.radDateTypeRelinquished.Size = New System.Drawing.Size(112, 17)
        Me.radDateTypeRelinquished.TabIndex = 2
        Me.radDateTypeRelinquished.TabStop = True
        Me.radDateTypeRelinquished.Text = "Date Relinquished"
        Me.radDateTypeRelinquished.UseVisualStyleBackColor = True
        '
        'radDateTypeAcquired
        '
        Me.radDateTypeAcquired.AutoSize = True
        Me.radDateTypeAcquired.Location = New System.Drawing.Point(6, 18)
        Me.radDateTypeAcquired.Name = "radDateTypeAcquired"
        Me.radDateTypeAcquired.Size = New System.Drawing.Size(93, 17)
        Me.radDateTypeAcquired.TabIndex = 0
        Me.radDateTypeAcquired.Text = "Date Acquired"
        Me.radDateTypeAcquired.UseVisualStyleBackColor = True
        '
        'radDateTypeTagged
        '
        Me.radDateTypeTagged.AutoSize = True
        Me.radDateTypeTagged.Location = New System.Drawing.Point(6, 37)
        Me.radDateTypeTagged.Name = "radDateTypeTagged"
        Me.radDateTypeTagged.Size = New System.Drawing.Size(88, 17)
        Me.radDateTypeTagged.TabIndex = 1
        Me.radDateTypeTagged.Text = "Date Tagged"
        Me.radDateTypeTagged.UseVisualStyleBackColor = True
        '
        'chkLff
        '
        Me.chkLff.AutoSize = True
        Me.chkLff.Location = New System.Drawing.Point(6, 59)
        Me.chkLff.Name = "chkLff"
        Me.chkLff.Size = New System.Drawing.Size(44, 17)
        Me.chkLff.TabIndex = 3
        Me.chkLff.Text = "LFF"
        Me.chkLff.UseVisualStyleBackColor = True
        '
        'grpTagTypeAndLocationOptions
        '
        Me.grpTagTypeAndLocationOptions.Controls.Add(Me.lblFlipperTagsLine2)
        Me.grpTagTypeAndLocationOptions.Controls.Add(Me.lblFlipperTagsLine1)
        Me.grpTagTypeAndLocationOptions.Controls.Add(Me.chkPit)
        Me.grpTagTypeAndLocationOptions.Controls.Add(Me.lblFlipperTags)
        Me.grpTagTypeAndLocationOptions.Controls.Add(Me.chkRrf)
        Me.grpTagTypeAndLocationOptions.Controls.Add(Me.chkLrf)
        Me.grpTagTypeAndLocationOptions.Controls.Add(Me.chkRff)
        Me.grpTagTypeAndLocationOptions.Controls.Add(Me.chkLff)
        Me.grpTagTypeAndLocationOptions.Location = New System.Drawing.Point(8, 131)
        Me.grpTagTypeAndLocationOptions.Name = "grpTagTypeAndLocationOptions"
        Me.grpTagTypeAndLocationOptions.Size = New System.Drawing.Size(200, 102)
        Me.grpTagTypeAndLocationOptions.TabIndex = 2
        Me.grpTagTypeAndLocationOptions.TabStop = False
        Me.grpTagTypeAndLocationOptions.Text = "Tag type and location options"
        '
        'lblFlipperTagsLine2
        '
        Me.lblFlipperTagsLine2.BackColor = System.Drawing.Color.White
        Me.lblFlipperTagsLine2.Location = New System.Drawing.Point(72, 50)
        Me.lblFlipperTagsLine2.Name = "lblFlipperTagsLine2"
        Me.lblFlipperTagsLine2.Size = New System.Drawing.Size(120, 1)
        Me.lblFlipperTagsLine2.TabIndex = 2
        '
        'lblFlipperTagsLine1
        '
        Me.lblFlipperTagsLine1.BackColor = System.Drawing.Color.DimGray
        Me.lblFlipperTagsLine1.Location = New System.Drawing.Point(71, 49)
        Me.lblFlipperTagsLine1.Name = "lblFlipperTagsLine1"
        Me.lblFlipperTagsLine1.Size = New System.Drawing.Size(120, 1)
        Me.lblFlipperTagsLine1.TabIndex = 8
        '
        'chkPit
        '
        Me.chkPit.AutoSize = True
        Me.chkPit.Location = New System.Drawing.Point(6, 19)
        Me.chkPit.Name = "chkPit"
        Me.chkPit.Size = New System.Drawing.Size(43, 17)
        Me.chkPit.TabIndex = 0
        Me.chkPit.Text = "PIT"
        Me.chkPit.UseVisualStyleBackColor = True
        '
        'lblFlipperTags
        '
        Me.lblFlipperTags.AutoSize = True
        Me.lblFlipperTags.Location = New System.Drawing.Point(4, 42)
        Me.lblFlipperTags.Name = "lblFlipperTags"
        Me.lblFlipperTags.Size = New System.Drawing.Size(61, 13)
        Me.lblFlipperTags.TabIndex = 1
        Me.lblFlipperTags.Text = "Flipper tags"
        '
        'chkRrf
        '
        Me.chkRrf.AutoSize = True
        Me.chkRrf.Location = New System.Drawing.Point(94, 78)
        Me.chkRrf.Name = "chkRrf"
        Me.chkRrf.Size = New System.Drawing.Size(48, 17)
        Me.chkRrf.TabIndex = 6
        Me.chkRrf.Text = "RRF"
        Me.chkRrf.UseVisualStyleBackColor = True
        '
        'chkLrf
        '
        Me.chkLrf.AutoSize = True
        Me.chkLrf.Location = New System.Drawing.Point(94, 59)
        Me.chkLrf.Name = "chkLrf"
        Me.chkLrf.Size = New System.Drawing.Size(46, 17)
        Me.chkLrf.TabIndex = 5
        Me.chkLrf.Text = "LRF"
        Me.chkLrf.UseVisualStyleBackColor = True
        '
        'chkRff
        '
        Me.chkRff.AutoSize = True
        Me.chkRff.Location = New System.Drawing.Point(6, 78)
        Me.chkRff.Name = "chkRff"
        Me.chkRff.Size = New System.Drawing.Size(46, 17)
        Me.chkRff.TabIndex = 4
        Me.chkRff.Text = "RFF"
        Me.chkRff.UseVisualStyleBackColor = True
        '
        'grpDateFilterOptions
        '
        Me.grpDateFilterOptions.Controls.Add(Me.radDateTypeRelinquished)
        Me.grpDateFilterOptions.Controls.Add(Me.radDateTypeAcquired)
        Me.grpDateFilterOptions.Controls.Add(Me.chkIncludeNonRelinquishedTurtles)
        Me.grpDateFilterOptions.Controls.Add(Me.radDateTypeTagged)
        Me.grpDateFilterOptions.Controls.Add(Me.lblDateFrom)
        Me.grpDateFilterOptions.Controls.Add(Me.dtpDateFrom)
        Me.grpDateFilterOptions.Controls.Add(Me.lblDateThru)
        Me.grpDateFilterOptions.Controls.Add(Me.dtpDateThru)
        Me.grpDateFilterOptions.Location = New System.Drawing.Point(8, 43)
        Me.grpDateFilterOptions.Name = "grpDateFilterOptions"
        Me.grpDateFilterOptions.Size = New System.Drawing.Size(480, 82)
        Me.grpDateFilterOptions.TabIndex = 1
        Me.grpDateFilterOptions.TabStop = False
        Me.grpDateFilterOptions.Text = "Date filter options"
        '
        'chkIncludeStrandingIdNumber
        '
        Me.chkIncludeStrandingIdNumber.AutoSize = True
        Me.chkIncludeStrandingIdNumber.Location = New System.Drawing.Point(6, 19)
        Me.chkIncludeStrandingIdNumber.Name = "chkIncludeStrandingIdNumber"
        Me.chkIncludeStrandingIdNumber.Size = New System.Drawing.Size(161, 17)
        Me.chkIncludeStrandingIdNumber.TabIndex = 0
        Me.chkIncludeStrandingIdNumber.Text = "Include Stranding ID number"
        Me.chkIncludeStrandingIdNumber.UseVisualStyleBackColor = True
        '
        'grpOtherReportOptions
        '
        Me.grpOtherReportOptions.Controls.Add(Me.chkIncludeStrandingIdNumber)
        Me.grpOtherReportOptions.Location = New System.Drawing.Point(214, 131)
        Me.grpOtherReportOptions.Name = "grpOtherReportOptions"
        Me.grpOtherReportOptions.Size = New System.Drawing.Size(200, 102)
        Me.grpOtherReportOptions.TabIndex = 3
        Me.grpOtherReportOptions.TabStop = False
        Me.grpOtherReportOptions.Text = "Other report options"
        '
        'TurtleTagReportDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnClose
        Me.ClientSize = New System.Drawing.Size(498, 299)
        Me.Controls.Add(Me.grpOtherReportOptions)
        Me.Controls.Add(Me.grpDateFilterOptions)
        Me.Controls.Add(Me.grpTagTypeAndLocationOptions)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.lblDescription)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnCreate)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TurtleTagReportDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Turtle Tag Report"
        Me.grpTagTypeAndLocationOptions.ResumeLayout(False)
        Me.grpTagTypeAndLocationOptions.PerformLayout()
        Me.grpDateFilterOptions.ResumeLayout(False)
        Me.grpDateFilterOptions.PerformLayout()
        Me.grpOtherReportOptions.ResumeLayout(False)
        Me.grpOtherReportOptions.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub frmTurtleTagReportDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim iCurrentMonth As Integer
        Dim iCurrentMonthDiff As Integer
        Dim dtDateTimeNow As Date
        Dim dtDateTimeLastMonthOfLastQuarter As Date

        '----------------------------------------------------------------
        '-- retrieve last user settings
        '----------------------------------------------------------------

        If String.IsNullOrEmpty(My.Settings.TurtleTagReportDateFrom) _
        AndAlso String.IsNullOrEmpty(My.Settings.TurtleTagReportDateFrom) Then

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

        Else

            dtpDateFrom.DateValue = CDate(My.Settings.TurtleTagReportDateFrom)
            dtpDateThru.DateValue = CDate(My.Settings.TurtleTagReportDateThru)

        End If

        If (My.Settings.TurtleTagReportDateType = "Acquired") Then
            Me.radDateTypeAcquired.Checked = True
        ElseIf (My.Settings.TurtleTagReportDateType = "Tagged") Then
            Me.radDateTypeTagged.Checked = True
        Else 'If (My.Settings.TurtleTagReportDateType = "Relinquished") Then
            Me.radDateTypeRelinquished.Checked = True
        End If

        If (My.Settings.TurtleTagReportIncludeRelinquishedTurtles = "True") _
        AndAlso (Me.radDateTypeRelinquished.Checked = True) Then
            Me.chkIncludeNonRelinquishedTurtles.Checked = True
        Else
            Me.chkIncludeNonRelinquishedTurtles.Checked = False
        End If

        If (My.Settings.TurtleTagReportIncludeStrandingIdNumber = "True") Then
            Me.chkIncludeStrandingIdNumber.Checked = True
        Else
            Me.chkIncludeStrandingIdNumber.Checked = False
        End If

        If (My.Settings.TurtleTagReportPit = "False") Then
            Me.chkPit.Checked = False
        Else
            Me.chkPit.Checked = True
        End If

        If (My.Settings.TurtleTagReportLff = "False") Then
            Me.chkLff.Checked = False
        Else
            Me.chkLff.Checked = True
        End If

        If (My.Settings.TurtleTagReportRff = "False") Then
            Me.chkRff.Checked = False
        Else
            Me.chkRff.Checked = True
        End If

        If (My.Settings.TurtleTagReportLrf = "False") Then
            Me.chkLrf.Checked = False
        Else
            Me.chkLrf.Checked = True
        End If

        If (My.Settings.TurtleTagReportRrf = "False") Then
            Me.chkRrf.Checked = False
        Else
            Me.chkRrf.Checked = True
        End If

    End Sub

    Private Sub btnCreate_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCreate.Click

        Dim bWriteExtraLine As Boolean
        Dim bIncludeStrandingIdNumber As Boolean
        Dim iTurtleIndex As Integer
        Dim iTurtleTagIndex As Integer
        Dim sMonthsAndYearOfReport As String = String.Empty
        Dim sOrganizationAndPermitNumber As String = String.Empty
        Dim sRffTagNumber As String = String.Empty
        Dim sLffTagNumber As String = String.Empty
        Dim sRrfTagNumber As String = String.Empty
        Dim sLrfTagNumber As String = String.Empty
        Dim sRffDateTagged As String = String.Empty
        Dim sLffDateTagged As String = String.Empty
        Dim sRrfDateTagged As String = String.Empty
        Dim sLrfDateTagged As String = String.Empty
        Dim dtDateFrom As Date
        Dim dtDateThru As Date
        Dim dtTempDate As Date
        Dim oOrganization As Organization = Nothing
        Dim oTurtle As Turtle = Nothing
        Dim oTurtleListItems As TurtleListItems = Nothing
        Dim oTurtleTag As TurtleTag = Nothing
        Dim oPrintDocumentEx As PrintDocumentEx = Nothing

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

            bIncludeStrandingIdNumber = Me.chkIncludeStrandingIdNumber.Checked

            '----------------------------------------------------------------
            '-- get ORGANIZATION data for report
            '----------------------------------------------------------------
            oOrganization = Organization.GetOrganization()
            sOrganizationAndPermitNumber = oOrganization.OrganizationName & " - " & oOrganization.PermitNumber
            oOrganization = Nothing

            '----------------------------------------------------------------
            '-- get TURTLE TAG data for report
            '----------------------------------------------------------------
            If radDateTypeAcquired.Checked Then
                oTurtleListItems = TurtleListItems.GetListByDateRange(TurtleListItems.LoadDateRangeType.DateAcquired, False, dtDateFrom, dtDateThru)
            ElseIf radDateTypeTagged.Checked Then
                oTurtleListItems = TurtleListItems.GetListByDateRange(TurtleListItems.LoadDateRangeType.DateTagged, False, dtDateFrom, dtDateThru)
            ElseIf radDateTypeRelinquished.Checked Then
                oTurtleListItems = TurtleListItems.GetListByDateRange(TurtleListItems.LoadDateRangeType.DateRelinquished, Me.chkIncludeNonRelinquishedTurtles.Checked, dtDateFrom, dtDateThru)
            End If

            If (oTurtleListItems.Count = 0) Then
                System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                MessageBox.Show("No turtle data found for the indicated date range.", Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                Exit Sub
            End If

            '----------------------------------------------------------------
            '-- begin the report output
            '----------------------------------------------------------------
            oPrintDocumentEx = New PrintDocumentEx

            oPrintDocumentEx.DocumentName = "Turtle Tag Report"

            oPrintDocumentEx.WriteLine(oPrintDocumentEx.DocumentName, "Times New Roman", 12, True, , , PrintDocumentEx.AlignmentType.Center, False)
            oPrintDocumentEx.WriteLine(sMonthsAndYearOfReport, "Times New Roman", 12, True, , , PrintDocumentEx.AlignmentType.Center, False)
            oPrintDocumentEx.WriteLine(sOrganizationAndPermitNumber, "Times New Roman", 12, True, , , PrintDocumentEx.AlignmentType.Center, False)
            oPrintDocumentEx.WriteLine(String.Empty, "Times New Roman", 12, False)

            '----------------------------------------------------------------
            '-- column headers 
            '----------------------------------------------------------------
            oPrintDocumentEx.Write("SID #", fFontSize:=9, bBold:=True, bUnderline:=True)
            oPrintDocumentEx.Write("Turtle Name", fXPos:=150, bBold:=True, bUnderline:=True)
            oPrintDocumentEx.Write("Tag Location / Number", fXPos:=290, bBold:=True, bUnderline:=True)
            oPrintDocumentEx.Write("Date Tagged", fXPos:=500, bBold:=True, bUnderline:=True)
            oPrintDocumentEx.Write("Date Released", fXPos:=575, bBold:=True, bUnderline:=True)

            If bIncludeStrandingIdNumber Then
                oPrintDocumentEx.Write("Stranding ID", fXPos:=660, bBold:=True, bUnderline:=True)
            End If

            oPrintDocumentEx.WriteLine(String.Empty)

            '----------------------------------------------------------------
            '-- output detail data
            '----------------------------------------------------------------
            For iTurtleIndex = 0 To oTurtleListItems.Count - 1

                oTurtle = Turtle.GetTurtle(oTurtleListItems(iTurtleIndex).TurtleID)

                '-- SID #
                oPrintDocumentEx.Write(oTurtle.SidNumber, fFontSize:=10)

                '-- Turtle Name
                oPrintDocumentEx.Write(oTurtle.TurtleName, fXPos:=150)

                '-- Stranding ID #
                If bIncludeStrandingIdNumber Then
                    oPrintDocumentEx.Write(oTurtle.StrandingIdNumber, fXPos:=660)
                End If

                sRffTagNumber = String.Empty
                sLffTagNumber = String.Empty
                sRrfTagNumber = String.Empty
                sLrfTagNumber = String.Empty
                sRffDateTagged = String.Empty
                sLffDateTagged = String.Empty
                sRrfDateTagged = String.Empty
                sLrfDateTagged = String.Empty

                '-- for FLIPPER TAGS...
                If (oTurtle.TurtleTags.Count > 0) Then

                    For iTurtleTagIndex = 0 To oTurtle.TurtleTags.Count - 1

                        oTurtleTag = oTurtle.TurtleTags(iTurtleTagIndex)

                        If Not oTurtleTag.TagType.Trim.ToUpper.Contains("PIT") Then

                            If (oTurtleTag.Location.Trim.ToUpper = "RFF") Then
                                sRffTagNumber = oTurtleTag.TagNumber
                                sRffDateTagged = oTurtleTag.DateTaggedString
                            End If

                            If (oTurtleTag.Location.Trim.ToUpper = "LFF") Then
                                sLffTagNumber = oTurtleTag.TagNumber
                                sLffDateTagged = oTurtleTag.DateTaggedString
                            End If

                            If (oTurtleTag.Location.Trim.ToUpper = "RRF") Then
                                sRrfTagNumber = oTurtleTag.TagNumber
                                sRrfDateTagged = oTurtleTag.DateTaggedString
                            End If

                            If (oTurtleTag.Location.Trim.ToUpper = "LRF") Then
                                sLrfTagNumber = oTurtleTag.TagNumber
                                sLrfDateTagged = oTurtleTag.DateTaggedString
                            End If

                        End If

                    Next iTurtleTagIndex

                End If

                '-- Date Released
                oPrintDocumentEx.Write(oTurtle.DateRelinquishedString, fXPos:=575)

                '-- FLIPPER TAG Numbers, Locations, Dates
                bWriteExtraLine = True

                If Not String.IsNullOrEmpty(sRffTagNumber) AndAlso Me.chkRff.Checked Then
                    oPrintDocumentEx.Write("RFF: ", fXPos:=290, bBold:=True)
                    oPrintDocumentEx.Write(sRffTagNumber, fXPos:=325)
                    oPrintDocumentEx.Write(sRffDateTagged, fXPos:=500)
                    oPrintDocumentEx.WriteLine(String.Empty)
                    bWriteExtraLine = False
                End If

                If Not String.IsNullOrEmpty(sLffTagNumber) AndAlso Me.chkLff.Checked Then
                    oPrintDocumentEx.Write("LFF: ", fXPos:=290, bBold:=True)
                    oPrintDocumentEx.Write(sLffTagNumber, fXPos:=325)
                    oPrintDocumentEx.Write(sLffDateTagged, fXPos:=500)
                    oPrintDocumentEx.WriteLine(String.Empty)
                    bWriteExtraLine = False
                End If

                If Not String.IsNullOrEmpty(sRrfTagNumber) AndAlso Me.chkRrf.Checked Then
                    oPrintDocumentEx.Write("RRF: ", fXPos:=290, bBold:=True)
                    oPrintDocumentEx.Write(sRrfTagNumber, fXPos:=325)
                    oPrintDocumentEx.Write(sRrfDateTagged, fXPos:=500)
                    oPrintDocumentEx.WriteLine(String.Empty)
                    bWriteExtraLine = False
                End If

                If Not String.IsNullOrEmpty(sLrfTagNumber) AndAlso Me.chkLrf.Checked Then
                    oPrintDocumentEx.Write("LRF: ", fXPos:=290, bBold:=True)
                    oPrintDocumentEx.Write(sLrfTagNumber, fXPos:=325)
                    oPrintDocumentEx.Write(sLrfDateTagged, fXPos:=500)
                    oPrintDocumentEx.WriteLine(String.Empty)
                    bWriteExtraLine = False
                End If

                '-- for PIT TAGS
                If (oTurtle.TurtleTags.Count > 0) Then

                    For iTurtleTagIndex = 0 To oTurtle.TurtleTags.Count - 1

                        oTurtleTag = oTurtle.TurtleTags(iTurtleTagIndex)

                        If oTurtleTag.TagType.Trim.ToUpper.Contains("PIT") Then

                            If Not String.IsNullOrEmpty(oTurtleTag.TagNumber) AndAlso Me.chkPit.Checked Then
                                oPrintDocumentEx.Write("PIT: ", fXPos:=290, bBold:=True)
                                oPrintDocumentEx.Write(oTurtleTag.TagNumber, fXPos:=325)
                                oPrintDocumentEx.Write(oTurtleTag.DateTaggedString, fXPos:=500)
                                oPrintDocumentEx.WriteLine(String.Empty)
                                bWriteExtraLine = False
                            End If

                        End If

                    Next iTurtleTagIndex

                End If

                If bWriteExtraLine Then
                    oPrintDocumentEx.WriteLine(String.Empty)
                End If

                oPrintDocumentEx.WriteLine(New String("-"c, 135))

            Next iTurtleIndex

            oPrintDocumentEx.Preview(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            oOrganization = Nothing
            oTurtleListItems = Nothing
            oTurtle = Nothing
            oTurtleTag = Nothing
            oPrintDocumentEx = Nothing

            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        '----------------------------------------------------------------
        '-- save user settings
        '----------------------------------------------------------------
        If Me.radDateTypeAcquired.Checked Then
            My.Settings.TurtleTagReportDateType = "Acquired"
        ElseIf Me.radDateTypeTagged.Checked Then
            My.Settings.TurtleTagReportDateType = "Tagged"
        Else 'If Me.radDateTypeRelinquished.Checked Then
            My.Settings.TurtleTagReportDateType = "Relinquished"
        End If

        My.Settings.TurtleTagReportIncludeRelinquishedTurtles = Me.chkIncludeNonRelinquishedTurtles.Checked.ToString
        My.Settings.TurtleTagReportIncludeStrandingIdNumber = Me.chkIncludeStrandingIdNumber.Checked.ToString

        My.Settings.TurtleTagReportDateFrom = Me.dtpDateFrom.DateValue.ToString
        My.Settings.TurtleTagReportDateThru = Me.dtpDateThru.DateValue.ToString

        My.Settings.TurtleTagReportPit = Me.chkPit.Checked.ToString
        My.Settings.TurtleTagReportLff = Me.chkLff.Checked.ToString
        My.Settings.TurtleTagReportRff = Me.chkRff.Checked.ToString
        My.Settings.TurtleTagReportLrf = Me.chkLrf.Checked.ToString
        My.Settings.TurtleTagReportRrf = Me.chkRrf.Checked.ToString

        My.Settings.Save()

        Me.Close()

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "TurtleTagReport.htm")
    End Sub

    Private Sub radDateTypeRelinquished_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDateTypeRelinquished.CheckedChanged
        Me.chkIncludeNonRelinquishedTurtles.Enabled = Me.radDateTypeRelinquished.Checked
    End Sub

End Class
