Option Explicit On
Option Strict On
Option Compare Text

Public Class ConvertToDegreesDecimalMinutesForm

    '-- see --> http://home.online.no/~sigurdhu/Deg_formats.htm

    Private mbIsLoading As Boolean = True
    Private msApplicationProductName As String = String.Empty
    Private mdDdmDegrees As Double = 0
    Private mdDdmMinutes As Double = 0
    Private mdDdmFraction As Double = 0
    Private msDdmDirection As String = String.Empty
    Private meLocationType As LocationType = LocationType.Latitude

    Public Property DdmDegrees() As Double
        Get
            Return mdDdmDegrees
        End Get
        Set(ByVal value As Double)
            mdDdmDegrees = value
        End Set
    End Property

    Public Property DdmMinutes() As Double
        Get
            Return mdDdmMinutes
        End Get
        Set(ByVal value As Double)
            mdDdmMinutes = value
        End Set
    End Property

    Public Property DdmFraction() As Double
        Get
            Return mdDdmFraction
        End Get
        Set(ByVal value As Double)
            mdDdmFraction = value
        End Set
    End Property

    Public Property DdmDirection() As String
        Get
            Return msDdmDirection
        End Get
        Set(ByVal value As String)
            msDdmDirection = value
        End Set
    End Property

    Public Sub New(ByVal oFormIcon As System.Drawing.Icon, ByVal sApplicationProductName As String, ByVal dDdmDegrees As Double, ByVal dDdmMinutes As Double, ByVal dDdmFraction As Double, ByVal sDdmDirection As String, ByVal eLocationType As LocationType)

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
            Me.Text = sApplicationProductName & " - Convert To Degrees Decimal Minutes"
        Else
            Me.Text = "Convert To Degrees Decimal Minutes"
        End If

        msApplicationProductName = sApplicationProductName

        '----------------------------------------------------------------
        '-- set up the initial values
        '----------------------------------------------------------------
        mdDdmDegrees = dDdmDegrees
        mdDdmMinutes = dDdmMinutes
        mdDdmFraction = dDdmFraction
        msDdmDirection = sDdmDirection
        meLocationType = eLocationType

        If (msDdmDirection = "S" OrElse msDdmDirection = "W") Then
            Me.radDirectionNegative.Checked = True

            If (mdDdmDegrees > 0) Then
                mdDdmDegrees *= -1
            End If
        Else
            Me.radDirectionPositive.Checked = True
        End If

        Me.lblDegreesDecimalMinutesDegreesValue.Text = mdDdmDegrees.ToString
        Me.lblDegreesDecimalMinutesMinutesValue.Text = dDdmMinutes.ToString & "." & dDdmFraction.ToString

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

        ConvertFromDdm()

        mbIsLoading = False

    End Sub

    Private Sub ConvertToDegreesDecimalMinutesForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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

        mdDdmDegrees = Convert.ToDouble(Me.lblDegreesDecimalMinutesDegreesValue.Text)
        mdDdmMinutes = Convert.ToDouble(Me.lblDegreesDecimalMinutesMinutesValue.Text.Substring(0, Me.lblDegreesDecimalMinutesMinutesValue.Text.IndexOf(".")))
        mdDdmFraction = Convert.ToDouble(Me.lblDegreesDecimalMinutesMinutesValue.Text.Substring(Me.lblDegreesDecimalMinutesMinutesValue.Text.IndexOf(".") + 1))

        If (Me.radDirectionPositive.Checked) Then
            msDdmDirection = Me.radDirectionPositive.Text.Substring(0, 1)
        Else
            msDdmDirection = Me.radDirectionNegative.Text.Substring(0, 1)
        End If

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
        Me.pnlDirection.Enabled = Me.radConversionTypeDms.Checked
        Me.radDirectionPositive.Enabled = Me.radConversionTypeDms.Checked
        Me.radDirectionNegative.Enabled = Me.radConversionTypeDms.Checked

        Me.txtDdDecimalDegrees.Enabled = Me.radConversionTypeDd.Checked

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

        If (Val(Me.txtDdDecimalDegrees.Text) < -180) OrElse (180 < Val(Me.txtDdDecimalDegrees.Text)) Then
            Me.txtDdDecimalDegrees.BackColor = Drawing.Color.Yellow
        Else
            Me.txtDdDecimalDegrees.BackColor = Drawing.SystemColors.Window
        End If

    End Sub

    Private Sub radConversionTypeDms_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radConversionTypeDms.CheckedChanged
        If mbIsLoading Then Exit Sub
        SetConvertFromControlsState()
    End Sub

    Private Sub radConversionTypeDd_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radConversionTypeDd.CheckedChanged
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

        Me.txtDdDecimalDegrees.Text = String.Format("{0:##.00000}", (dDecimalDegrees))

        '----------------------------------------------------------------
        '--...to degrees decimal-minutes
        '----------------------------------------------------------------
        dDegreesDecimalMinutesDegrees = LatLonHelpers.ConvertDmsToDdmDegrees(dDegrees, Convert.ToDouble(Val(Me.txtDmsMinutes.Text)), Convert.ToDouble(Val(Me.txtDmsSeconds.Text)))

        Me.lblDegreesDecimalMinutesDegreesValue.Text = String.Format("{0:##}", (dDegreesDecimalMinutesDegrees))
        Me.lblDegreesDecimalMinutesMinutesValue.Text = String.Format("{0:##.00000}", (LatLonHelpers.ConvertDmsToDdmMinutes(Convert.ToDouble(Val(Me.txtDmsDegrees.Text)), Convert.ToDouble(Val(Me.txtDmsMinutes.Text)), Convert.ToDouble(Val(Me.txtDmsSeconds.Text)))))

        ValidateRanges()

    End Sub

    Private Sub ConvertFromDd()

        Dim dDecimalDegrees As Double
        Dim dDegrees As Double
        Dim dDegreesDecimalMinutesDegrees As Double

        '----------------------------------------------------------------
        '-- convert from decimal degrees...
        '----------------------------------------------------------------
        dDecimalDegrees = Convert.ToDouble(Val(Me.txtDdDecimalDegrees.Text))

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
        '-- ...to decimal degrees
        '----------------------------------------------------------------
        dDegreesDecimalMinutesDegrees = LatLonHelpers.ConvertDdToDdmDegrees(dDecimalDegrees)

        Me.lblDegreesDecimalMinutesDegreesValue.Text = String.Format("{0:##}", (dDegreesDecimalMinutesDegrees))
        Me.lblDegreesDecimalMinutesMinutesValue.Text = String.Format("{0:##.00000}", (LatLonHelpers.ConvertDdToDdmMinutes(dDecimalDegrees)))

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
        dDegreesDecimalMinutesDegrees = Convert.ToDouble(Val(Me.lblDegreesDecimalMinutesDegreesValue.Text))
        dDegreesDecimalMinutesMinutes = Convert.ToDouble(Val(Me.lblDegreesDecimalMinutesMinutesValue.Text))

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

        Me.txtDdDecimalDegrees.Text = String.Format("{0:##.00000}", (dDecimalDegrees))

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

    Private Sub HandleKeyUpDd(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtDdDecimalDegrees.KeyUp
        mbIsLoading = True
        ConvertFromDd()
        mbIsLoading = False
    End Sub

End Class