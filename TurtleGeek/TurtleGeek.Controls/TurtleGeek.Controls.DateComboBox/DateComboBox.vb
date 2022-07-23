Option Explicit On
Option Strict On

<ToolboxBitmap(GetType(TurtleGeek.Controls.DateComboBox), "DateComboBox.bmp")> _
Public Class DateComboBox

    Private Const DEFAULT_DATE_FORMAT As String = "MM/dd/yyyy"
    Private DATE_NULL_VALUE As Date = Date.MinValue

    Private WithEvents moCalendarPopup As CalendarPopup

    Private mdtDateValue As Date = DATE_NULL_VALUE
    Private mdtMaxValue As Date = New Date(9998, 12, 31, 0, 0, 0)
    Private mdtMinValue As Date = New Date(1753, 1, 1, 0, 0, 0)

    Private moBackColor As Color = SystemColors.Window

    Private msValueOnEnter As String = String.Empty

    Public Sub New()
        ' This call is required by the Windows Form Designer.
        InitializeComponent()
    End Sub

    ''' <summary>
    ''' Gets or sets the background color for the control.
    ''' </summary>
    Public Shadows Property BackColor() As Color
        Get
            Return MyBase.BackColor
        End Get
        Set(ByVal value As Color)
            moBackColor = value
            'If Me.Enabled Then
            Me.mskDate.BackColor = moBackColor    'Color.FromArgb(255, value)
            MyBase.BackColor = moBackColor
            'Else
            '    Me.mskDate.BackColor = SystemColors.Control
            '    MyBase.BackColor = SystemColors.Control
            'End If
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets a value indicating whether the control can respond to user interaction.
    ''' </summary>
    Public Shadows Property Enabled() As Boolean
        Get
            Return MyBase.Enabled
        End Get
        Set(ByVal value As Boolean)
            Me.mskDate.Enabled = value
            Me.btnPopup.Enabled = value
            MyBase.Enabled = value

            If (value = True) Then
                Me.mskDate.BackColor = moBackColor
                MyBase.BackColor = moBackColor
            Else
                Me.mskDate.BackColor = System.Drawing.SystemColors.Control
                MyBase.BackColor = System.Drawing.SystemColors.Control
            End If

        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the foreground color of the control.
    ''' </summary>
    Public Shadows Property ForeColor() As Color
        Get
            Return Me.mskDate.ForeColor
        End Get
        Set(ByVal value As Color)
            Me.mskDate.ForeColor = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the maximum date value for the control.  Cannot be later than December 31, 9998.
    ''' </summary>
    Public Property MaxValue() As Date
        Get
            Return mdtMaxValue
        End Get
        Set(ByVal value As Date)
            mdtMaxValue = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the minimum date value for the control.  Cannot be earlier than January 1, 1753.
    ''' </summary>
    Public Property MinValue() As Date
        Get
            Return mdtMinValue
        End Get
        Set(ByVal value As Date)
            mdtMinValue = value
        End Set
    End Property

    ''' <summary>
    ''' Gets or sets the text as it is currently displayed to the user.
    ''' </summary>
    Public Shadows Property Text() As String

        Get
            Dim sTextValue As String
            Dim dtDateValue As Date

            sTextValue = Me.mskDate.Text

            If Not Date.TryParse(sTextValue, dtDateValue) Then
                sTextValue = sTextValue.Replace(" ", "_")
                If sTextValue = "__/__/" Then
                    sTextValue = "__/__/____"
                End If
            End If

            Return sTextValue

        End Get

        Set(ByVal value As String)

            Dim dtDateValue As Date = DATE_NULL_VALUE

            If Date.TryParse(value, dtDateValue) Then
                If (dtDateValue < mdtMinValue) OrElse (mdtMaxValue < dtDateValue) Then
                    Me.DateValue = DATE_NULL_VALUE
                Else
                    Me.DateValue = DateAtMidnight(dtDateValue)
                End If
            Else
                Me.DateValue = DATE_NULL_VALUE
            End If

            SetDateText()

        End Set

    End Property

    ''' <summary>
    ''' Gets or sets the date/time value associated with the control.
    ''' </summary>
    <System.ComponentModel.Browsable(False), System.ComponentModel.Bindable(True)> _
    Public Property DateValue() As Date
        Get
            Return DateAtMidnight(mdtDateValue)
        End Get
        Set(ByVal value As Date)
            mdtDateValue = value
            SetDateText()
        End Set
    End Property

    ''' <summary>
    ''' String representation of the date/time value associated with the control.
    ''' </summary>
    ''' <value></value>
    ''' <returns>Empty string if date/time value is null; else, date/time value in specified format.</returns>
    ''' <remarks></remarks>
    <System.ComponentModel.Browsable(False)> _
    Public ReadOnly Property DateString(Optional ByVal sFormatString As String = DEFAULT_DATE_FORMAT) As String
        Get
            Return DateAsString(mdtDateValue, sFormatString)
        End Get
    End Property

    Private Sub SetDateText()

        If (Me.DateValue < mdtMinValue) OrElse (mdtMaxValue < Me.DateValue) Then
            Me.mskDate.Text = "__/__/____"
        Else
            Me.mskDate.Text = Me.DateString
        End If

        If (msValueOnEnter <> Me.mskDate.Text) Then
            RaiseEvent ValueChanged(Me, New System.EventArgs())
            msValueOnEnter = Me.mskDate.Text
        End If

    End Sub

    Private Sub DateComboBox_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Enter
        Me.mskDate.Focus()
        Me.mskDate.SelectAll()
        msValueOnEnter = Me.mskDate.Text
    End Sub

    Private Sub DateComboBox_Resize(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Resize
        Me.Height = 20
    End Sub

    Private Sub btnPopup_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPopup.Click
        moCalendarPopup = New CalendarPopup(Me.mskDate, Me.MinValue, Me.MaxValue)
        AddHandler moCalendarPopup.CalendarClosed, AddressOf moCalendarPopup_CalendarClosed
        AddHandler moCalendarPopup.CalendarDateSelected, AddressOf moCalendarPopup_CalendarDateSelected
        moCalendarPopup.Show()
    End Sub

    Private Sub mskDate_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles mskDate.KeyDown
        RaiseEvent KeyPressEvent(Me, e)
    End Sub

    Private Sub mskDate_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles mskDate.MouseDown
        'Me.mskDate.Focus()
        'Me.mskDate.SelectAll()
    End Sub

    Private Sub mskDate_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mskDate.TextChanged
        RaiseEvent Change(Me, e)
    End Sub

    Private Sub mskDate_Validated(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mskDate.Validated

        'If (Me.mskDate.Text.Length = 0) OrElse (Me.mskDate.Text.Equals("  /  /")) Then Exit Sub

        SetDateText()

    End Sub

    Private Sub mskDate_Validating(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles mskDate.Validating

        'If (Me.mskDate.Text.Length = 0) OrElse (Me.mskDate.Text.Equals("  /  /")) Then Exit Sub

        Dim dtDateValue As Date = DATE_NULL_VALUE

        If Date.TryParse(Me.mskDate.Text, dtDateValue) Then
            If (dtDateValue < mdtMinValue) OrElse (mdtMaxValue < dtDateValue) Then
                Me.DateValue = DATE_NULL_VALUE
            Else
                Me.DateValue = dtDateValue
            End If
        Else
            Me.DateValue = DATE_NULL_VALUE
        End If

    End Sub

    Private Sub moCalendarPopup_CalendarClosed(ByVal sender As Object, ByVal e As System.EventArgs)

        Me.mskDate.Focus()
        Me.mskDate.SelectAll()

    End Sub

    Private Sub moCalendarPopup_CalendarDateSelected(ByVal sender As Object, ByVal e As DateSelectedEventArgs)

        If (e.DateValue < mdtMinValue) OrElse (mdtMaxValue < e.DateValue) Then
            Me.DateValue = DATE_NULL_VALUE
        Else
            Me.DateValue = e.DateValue
        End If

        SetDateText()

    End Sub

    ''' <summary>
    ''' Converts a given <b>Date</b> value to a <b>Nullable(Of Date)</b>.
    ''' </summary>
    ''' <param name="dtDateValue">The <b>Date</b> value to convert.</param>
    ''' <returns>If the <b>Date</b> value = <b>Date.MinValue</b>, the <b>Nothing</b> value is returned.  Otherwise, the original <b>Date</b> value is is returned.</returns>
    Private Function DateAsNullableDate(ByVal dtDateValue As Date) As Nullable(Of Date)
        If (dtDateValue < mdtMinValue) OrElse (mdtMaxValue < dtDateValue) Then
            'If dtDateValue.Equals(DATE_MIN_VALUE) OrElse dtDateValue.Equals(Date.MinValue) Then
            Return Nothing
        Else
            Return dtDateValue
        End If
    End Function

    ''' <summary>
    ''' Converts a given <b>Date</b> value to a <b>String</b>.
    ''' </summary>
    ''' <param name="dtDateValue">The <b>Date</b> value to convert.</param>
    ''' <param name="sFormatString">Optional.  A valid user-defined date format string.</param>
    ''' <returns>If the <b>Date</b> value = <b>Date.MinValue</b>, a blank string is returned.  Otherwise, the <b>Date</b> value is converted to a string and formatted as specified.  If no formatting is specified, the format will be "MM/dd/yyyy".</returns>
    Private Function DateAsString(ByVal dtDateValue As Date, Optional ByVal sFormatString As String = DEFAULT_DATE_FORMAT) As String
        If (dtDateValue < mdtMinValue) OrElse (mdtMaxValue < dtDateValue) Then
            'If dtDateValue.Equals(DATE_MIN_VALUE) OrElse dtDateValue.Equals(Date.MinValue) Then
            Return String.Empty
        Else
            Return dtDateValue.ToString(sFormatString)
        End If
    End Function

    ''' <summary>
    ''' Converts a given <b>Date</b> value to midnight of that date.
    ''' </summary>
    ''' <param name="oDateValue">The <b>Date</b> value to convert.</param>
    ''' <returns>The <b>Date</b> value shifted to midnight (00:00:00) of that date.</returns>
    Private Function DateAtMidnight(ByVal oDateValue As Date) As Date
        Return New Date(oDateValue.Year, oDateValue.Month, oDateValue.Day, 0, 0, 0)
    End Function

#Region "Events"
    Public Event Change As System.EventHandler ''(ByVal eventSender As System.Object, ByVal eventArgs As System.EventArgs)
    Public Event KeyDownEvent(ByVal eventSender As System.Object, ByVal eventArgs As KeyEventArgs)
    Public Event KeyPressEvent As System.Windows.Forms.KeyEventHandler
    Public Event ValueChanged As System.EventHandler
#End Region

End Class

Friend Class CalendarPopup
    Inherits Form

    Private moMonthCalendar As System.Windows.Forms.MonthCalendar

    Private moOwnerMaskedTextBox As System.Windows.Forms.MaskedTextBox
    Private mdtMaxValue As Date = Date.MaxValue
    Private mdtMinValue As Date = New Date(1753, 1, 1, 0, 0, 0)

    Private moTopBorder As System.Windows.Forms.Label
    Private moLeftBorder As System.Windows.Forms.Label
    Private moRightBorder As System.Windows.Forms.Label
    Private moBottomBorder As System.Windows.Forms.Label

    Public Sub New(ByVal owner As System.Windows.Forms.MaskedTextBox, ByVal dtMinValue As Date, ByVal dtMaxValue As Date)

        Dim dtDateValue As Date
        Dim oPoint As Point

        moOwnerMaskedTextBox = owner
        mdtMaxValue = dtMaxValue
        mdtMinValue = dtMinValue

        '----------------------------------------------------------------
        '-- dynamically create a new calendar control 
        '-- and position it and its parent form
        '----------------------------------------------------------------
        moMonthCalendar = New System.Windows.Forms.MonthCalendar()

        moMonthCalendar.MinDate = mdtMinValue
        moMonthCalendar.MaxDate = mdtMaxValue
        moMonthCalendar.Location = New System.Drawing.Point(74, 28)
        moMonthCalendar.Size = New System.Drawing.Size(178, 155)
        moMonthCalendar.Name = "mnthCal"
        moMonthCalendar.ShowToday = False           '<-- setting to True causes dispose error when "today" circle is clicked
        moMonthCalendar.ShowTodayCircle = False     '<-- setting to True causes dispose error when "today" circle is clicked
        moMonthCalendar.Show()
        moMonthCalendar.TabIndex = 1
        moMonthCalendar.Visible = True
        moMonthCalendar.MaxSelectionCount = 1

        Me.StartPosition = FormStartPosition.Manual
        Me.ShowInTaskbar = False
        Me.FormBorderStyle = FormBorderStyle.None

        oPoint = (owner.PointToScreen(owner.Location))

        Me.Controls.Add(moMonthCalendar)
        moMonthCalendar.Top = 1
        moMonthCalendar.Left = 1
        Me.Top = oPoint.Y + moOwnerMaskedTextBox.Height + 1
        Me.Left = oPoint.X - 6
        Me.Width = moMonthCalendar.Width + 2
        Me.Height = moMonthCalendar.Height - 32

        If Date.TryParse(moOwnerMaskedTextBox.Text, dtDateValue) Then
            moMonthCalendar.SelectionStart = Convert.ToDateTime(moOwnerMaskedTextBox.Text)
            moMonthCalendar.SelectionEnd = Convert.ToDateTime(moOwnerMaskedTextBox.Text)
        Else
            moMonthCalendar.SelectionStart = System.DateTime.Today
            moMonthCalendar.SelectionEnd = System.DateTime.Today
        End If

        '----------------------------------------------------------------
        '-- make a single pixel width black border
        '----------------------------------------------------------------
        moTopBorder = New System.Windows.Forms.Label
        Me.Controls.Add(moTopBorder)
        moTopBorder.BackColor = Color.Black
        moTopBorder.Height = 1
        moTopBorder.Top = 0
        moTopBorder.Left = 0
        moTopBorder.Width = Me.Width
        moTopBorder.BringToFront()

        moLeftBorder = New System.Windows.Forms.Label
        Me.Controls.Add(moLeftBorder)
        moLeftBorder.BackColor = Color.Black
        moLeftBorder.Width = 1
        moLeftBorder.Top = 0
        moLeftBorder.Left = 0
        moLeftBorder.Height = Me.Height
        moTopBorder.BringToFront()

        moRightBorder = New System.Windows.Forms.Label
        Me.Controls.Add(moRightBorder)
        moRightBorder.BackColor = Color.Black
        moRightBorder.Width = 1
        moRightBorder.Top = 0
        moRightBorder.Left = Me.Width - 1
        moRightBorder.Height = Me.Height
        moTopBorder.BringToFront()

        moBottomBorder = New System.Windows.Forms.Label
        Me.Controls.Add(moBottomBorder)
        moBottomBorder.BackColor = Color.Black
        moBottomBorder.Height = 1
        moBottomBorder.Top = Me.Height - 1
        moBottomBorder.Left = 0
        moBottomBorder.Width = Me.Width
        moBottomBorder.BringToFront()

        '----------------------------------------------------------------
        '-- add event handlers
        '----------------------------------------------------------------
        AddHandler Me.Deactivate, AddressOf MonthDropDown_Deactivate
        AddHandler Me.FormClosed, AddressOf MonthDropDown_FormClosed
        AddHandler moMonthCalendar.DateSelected, AddressOf moMonthCalendar_DateSelected
        AddHandler moMonthCalendar.KeyDown, AddressOf moMonthCalendar_KeyDown
        AddHandler moMonthCalendar.DateChanged, AddressOf moMonthCalendar_DateChanged

    End Sub

    Public Delegate Sub CalendarDateSelectedDelegate(ByVal sender As Object, ByVal eventArgs As DateSelectedEventArgs)
    Public Event CalendarDateSelected As CalendarDateSelectedDelegate

    Public Delegate Sub CalendarClosedDelegate(ByVal sender As Object, ByVal eventArgs As System.EventArgs)
    Public Event CalendarClosed As CalendarClosedDelegate

    Private Sub MonthDropDown_Deactivate(ByVal sender As Object, ByVal e As System.EventArgs)
        Me.Close()
    End Sub

    Private Sub MonthDropDown_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs)
        RaiseEvent CalendarClosed(Me, New System.EventArgs())
    End Sub

    Private Sub moMonthCalendar_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
        If (e.KeyCode = Keys.Escape) Then
            e.Handled = True
            Me.Close()
        End If
    End Sub

    Private Sub moMonthCalendar_DateChanged(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)
        '----------------------------------------------------------------
        '-- need to do this due to repainting weirdness
        '----------------------------------------------------------------
        moMonthCalendar.SelectionStart = e.Start
        moMonthCalendar.SelectionEnd = e.Start
    End Sub

    Private Sub moMonthCalendar_DateSelected(ByVal sender As Object, ByVal e As System.Windows.Forms.DateRangeEventArgs)
        RaiseEvent CalendarDateSelected(Me, New DateSelectedEventArgs(e.Start))
        Me.Close()
    End Sub

End Class

Friend Class DateSelectedEventArgs

    Private mdtDateValue As Date

    Public ReadOnly Property DateValue() As Date
        Get
            Return mdtDateValue
        End Get
    End Property

    Public Sub New(ByVal dtDateValue As Date)
        mdtDateValue = dtDateValue
    End Sub

End Class
