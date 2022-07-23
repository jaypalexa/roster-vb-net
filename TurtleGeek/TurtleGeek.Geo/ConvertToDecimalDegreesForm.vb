Option Explicit On
Option Strict On
Option Compare Text

Public Class ConvertToDecimalDegreesForm

    '-- see --> http://home.online.no/~sigurdhu/Deg_formats.htm

    Private mbIsLoading As Boolean = True
    Private msApplicationProductName As String = String.Empty
    Private mdDecimalDegrees As Double = 0
    Private meLocationType As LocationType = LocationType.Latitude

    Public Property DecimalDegrees() As Double
        Get
            Return mdDecimalDegrees
        End Get
        Set(ByVal value As Double)
            mdDecimalDegrees = value
        End Set
    End Property

    Public Sub New(ByVal oFormIcon As System.Drawing.Icon, ByVal sApplicationProductName As String, ByVal dDecimalDegrees As Double, ByVal eLocationType As LocationType)

        '----------------------------------------------------------------
        '-- the very first thing we must do is call the base class constructor
        '----------------------------------------------------------------
        MyBase.New()

        mbIsLoading = True

        '----------------------------------------------------------------
        '-- this call is required by the Windows Form Designer
        '----------------------------------------------------------------
        InitializeComponent()

        Me.Icon = oFormIcon

        If Not String.IsNullOrEmpty(sApplicationProductName) Then
            Me.Text = sApplicationProductName & " - Convert To Decimal Degrees"
        Else
            Me.Text = "Convert To Decimal Degrees"
        End If

        msApplicationProductName = sApplicationProductName

        '----------------------------------------------------------------
        '-- set up the initial values
        '----------------------------------------------------------------
        mdDecimalDegrees = dDecimalDegrees
        meLocationType = eLocationType

        'Me.lblDecimalDegreesValue.Text = mdDecimalDegrees.ToString
        Me.lblDecimalDegreesValue.Text = String.Format("{0:##.00000}", (mdDecimalDegrees))

        If (meLocationType = LocationType.Latitude) Then
            Me.lblDirection.Text = "Latitude"
            Me.radDirectionPositive.Text = "North"
            Me.radDirectionNegative.Text = "South"
        Else 'If (meLocationType = LocationType.Longitude) Then
            Me.lblDirection.Text = "Longitude"
            Me.radDirectionPositive.Text = "East"
            Me.radDirectionNegative.Text = "West"
        End If

        Me.radConversionTypeDms.Checked = True

        SetConvertFromControlsState()

        ConvertFromDd()

        mbIsLoading = False

    End Sub

    Private Sub ConvertToDecimalDegreesForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        '----------------------------------------------------------------
        '-- if the <ESCAPE> key was been pressed, 
        '-- react as if the Cancel button was pressed
        '----------------------------------------------------------------
        If (e.KeyCode = Keys.Escape) Then

            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()

        End If

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        mdDecimalDegrees = Convert.ToDouble(Me.lblDecimalDegreesValue.Text)
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub SetConvertFromControlsState()

        Me.lblDmsDegrees.Enabled = Me.radConversionTypeDms.Checked
        Me.txtDmsDegrees.Enabled = Me.radConversionTypeDms.Checked
        Me.lblDmsMinutes.Enabled = Me.radConversionTypeDms.Checked
        Me.txtDmsMinutes.Enabled = Me.radConversionTypeDms.Checked
        Me.lblDmsSeconds.Enabled = Me.radConversionTypeDms.Checked
        Me.txtDmsSeconds.Enabled = Me.radConversionTypeDms.Checked

        'Me.pnlDirection.Enabled = Me.radConversionTypeDms.Checked
        'Me.radDirectionPositive.Enabled = Me.radConversionTypeDms.Checked
        'Me.radDirectionNegative.Enabled = Me.radConversionTypeDms.Checked

        Me.lblDegreesDecimalMintues.Enabled = Me.radConversionTypeDdm.Checked
        Me.txtDdmDegrees.Enabled = Me.radConversionTypeDdm.Checked
        Me.txtDdmMinutes.Enabled = Me.radConversionTypeDdm.Checked

        If (Me.radConversionTypeDms.Checked) Then
            Me.pnlDirection.Top = 18
        Else
            Me.pnlDirection.Top = 61
        End If

    End Sub

    Private Sub ValidateRanges()

        If (Val(Me.txtDmsDegrees.Text) < -180) OrElse (180 < Val(Me.txtDmsDegrees.Text)) Then
            Me.txtDmsDegrees.BackColor = Drawing.Color.Yellow
        Else
            Me.txtDmsDegrees.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtDmsMinutes.Text) < 0) OrElse (59 < Val(Me.txtDmsMinutes.Text)) Then
            Me.txtDmsMinutes.BackColor = Drawing.Color.Yellow
        Else
            Me.txtDmsMinutes.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtDmsSeconds.Text) < 0) OrElse (59.9999999 < Val(Me.txtDmsSeconds.Text)) Then
            Me.txtDmsSeconds.BackColor = Drawing.Color.Yellow
        Else
            Me.txtDmsSeconds.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtDdmDegrees.Text) < -180) OrElse (180 < Val(Me.txtDdmDegrees.Text)) Then
            Me.txtDdmDegrees.BackColor = Drawing.Color.Yellow
        Else
            Me.txtDdmDegrees.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtDdmMinutes.Text) < 0) OrElse (59.9999999 < Val(Me.txtDdmMinutes.Text)) Then
            Me.txtDdmMinutes.BackColor = Drawing.Color.Yellow
        Else
            Me.txtDdmMinutes.BackColor = Drawing.SystemColors.Window
        End If

    End Sub

    Private Sub radConversionTypeDms_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radConversionTypeDms.CheckedChanged
        If mbIsLoading Then Exit Sub
        SetConvertFromControlsState()
    End Sub

    Private Sub radConversionTypeDdm_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radConversionTypeDdm.CheckedChanged
        If mbIsLoading Then Exit Sub
        SetConvertFromControlsState()
    End Sub

    Private Sub ConvertFromDms()

        '----------------------------------------------------------------
        '-- convert from degrees/minutes/seconds...
        '----------------------------------------------------------------
        Dim dDegrees As Double
        Dim dDecimalDegrees As Double
        Dim dDegreesDecimalMinutesDegrees As Double

        dDegrees = Convert.ToDouble(Val(Me.txtDmsDegrees.Text))

        If Me.radDirectionNegative.Checked Then
            dDegrees = Math.Abs(dDegrees) * -1
        End If

        '----------------------------------------------------------------
        '-- ...to decimal degrees
        '----------------------------------------------------------------
        dDecimalDegrees = LatLonHelpers.ConvertDmsToDd(dDegrees, Convert.ToDouble(Val(Me.txtDmsMinutes.Text)), Convert.ToDouble(Val(Me.txtDmsSeconds.Text)))

        Me.lblDecimalDegreesValue.Text = String.Format("{0:##.00000}", (dDecimalDegrees))

        '----------------------------------------------------------------
        '--...to degrees decimal-minutes
        '----------------------------------------------------------------
        dDegreesDecimalMinutesDegrees = LatLonHelpers.ConvertDmsToDdmDegrees(dDegrees, Convert.ToDouble(Val(Me.txtDmsMinutes.Text)), Convert.ToDouble(Val(Me.txtDmsSeconds.Text)))

        Me.txtDdmDegrees.Text = String.Format("{0:##}", (dDegreesDecimalMinutesDegrees))
        Me.txtDdmMinutes.Text = String.Format("{0:##.00000}", (LatLonHelpers.ConvertDmsToDdmMinutes(Convert.ToDouble(Val(Me.txtDmsDegrees.Text)), Convert.ToDouble(Val(Me.txtDmsMinutes.Text)), Convert.ToDouble(Val(Me.txtDmsSeconds.Text)))))

        ValidateRanges()

    End Sub

    Private Sub ConvertFromDd()

        Dim dDecimalDegrees As Double
        Dim dDegrees As Double
        Dim dDegreesDecimalMinutesDegrees As Double

        '----------------------------------------------------------------
        '-- convert from decimal degrees...
        '----------------------------------------------------------------
        dDecimalDegrees = Convert.ToDouble(Val(Me.lblDecimalDegreesValue.Text))

        '----------------------------------------------------------------
        '-- ...to degrees-minutes-seconds
        '----------------------------------------------------------------
        dDegrees = LatLonHelpers.ConvertDdToDmsDegrees(dDecimalDegrees)

        Me.txtDmsDegrees.Text = Convert.ToString(Math.Abs(dDegrees))
        Me.txtDmsMinutes.Text = Convert.ToString(LatLonHelpers.ConvertDdToDmsMinutes(dDecimalDegrees))
        Me.txtDmsSeconds.Text = Convert.ToString(LatLonHelpers.ConvertDdToDmsSeconds(dDecimalDegrees))

        If (dDegrees < 0) Then
            Me.radDirectionNegative.Checked = True
        Else
            Me.radDirectionPositive.Checked = True
        End If

        '----------------------------------------------------------------
        '-- ...to degrees decimal minutes
        '----------------------------------------------------------------
        dDegreesDecimalMinutesDegrees = LatLonHelpers.ConvertDdToDdmDegrees(dDecimalDegrees)

        Me.txtDdmDegrees.Text = String.Format("{0:##}", (dDegreesDecimalMinutesDegrees))
        Me.txtDdmMinutes.Text = String.Format("{0:##.00000}", (LatLonHelpers.ConvertDdToDdmMinutes(dDecimalDegrees)))

        ValidateRanges()

    End Sub

    Private Sub ConvertFromDdm()

        Dim dDegreesDecimalMinutesDegrees As Double
        Dim dDegreesDecimalMinutesMinutes As Double
        Dim dDecimalDegrees As Double
        Dim dDegrees As Double

        '----------------------------------------------------------------
        '-- convert from degrees decimal-minutes...
        '----------------------------------------------------------------

        '----------------------------------------------------------------
        '-- ...to degrees-minutes-seconds
        '----------------------------------------------------------------
        dDegreesDecimalMinutesDegrees = Convert.ToDouble(Val(Me.txtDdmDegrees.Text))
        dDegreesDecimalMinutesMinutes = Convert.ToDouble(Val(Me.txtDdmMinutes.Text))

        dDegrees = LatLonHelpers.ConvertDdmToDmsDegrees(dDegreesDecimalMinutesDegrees, dDegreesDecimalMinutesMinutes)

        Me.txtDmsDegrees.Text = Convert.ToString(Math.Abs(dDegrees))
        Me.txtDmsMinutes.Text = Convert.ToString(LatLonHelpers.ConvertDdmToDmsMinutes(dDegreesDecimalMinutesDegrees, dDegreesDecimalMinutesMinutes))
        Me.txtDmsSeconds.Text = Convert.ToString(LatLonHelpers.ConvertDdmToDmsSeconds(dDegreesDecimalMinutesDegrees, dDegreesDecimalMinutesMinutes))

        If (dDegreesDecimalMinutesDegrees < 0) Then
            Me.radDirectionNegative.Checked = True
        Else
            Me.radDirectionPositive.Checked = True
        End If

        '----------------------------------------------------------------
        '-- ...to decimal degrees
        '----------------------------------------------------------------
        dDecimalDegrees = LatLonHelpers.ConvertDdmToDd(dDegreesDecimalMinutesDegrees, dDegreesDecimalMinutesMinutes)

        Me.lblDecimalDegreesValue.Text = String.Format("{0:##.00000}", (dDecimalDegrees))

        ValidateRanges()

    End Sub

    Private Sub HandleIntegerKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDmsDegrees.KeyPress, txtDmsMinutes.KeyPress

        If (Char.IsNumber(e.KeyChar) = False) Then
            If (e.KeyChar = CChar(ChrW(Keys.Back))) OrElse (e.KeyChar = CChar(ChrW(Keys.Space))) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub HandleDecimalKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtDmsSeconds.KeyPress

        If (Char.IsNumber(e.KeyChar) = False) Then
            If (e.KeyChar = CChar(ChrW(Keys.Back))) OrElse (e.KeyChar = CChar(".")) OrElse (e.KeyChar = CChar(ChrW(Keys.Space))) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub HandleKeyUpDms(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDmsDegrees.KeyUp, txtDmsMinutes.KeyUp, txtDmsSeconds.KeyUp
        ConvertFromDms()
    End Sub

    Private Sub radDirectionPositiveNegative_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radDirectionPositive.CheckedChanged, radDirectionNegative.CheckedChanged
        If mbIsLoading Then Exit Sub
        ConvertFromDms()
    End Sub

    Private Sub HandleKeyUpDdm(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDdmDegrees.KeyUp, txtDdmMinutes.KeyUp
        mbIsLoading = True
        ConvertFromDdm()
        mbIsLoading = False
    End Sub

End Class