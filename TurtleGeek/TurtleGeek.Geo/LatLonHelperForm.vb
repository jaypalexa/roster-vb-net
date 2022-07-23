Option Explicit On
Option Strict On
Option Compare Text

Public Class LatLonHelperForm

    '-- see --> http://home.online.no/~sigurdhu/Deg_formats.htm

    Private mbIsLoading As Boolean = True
    Private msApplicationProductName As String = String.Empty
    Private mdStartingLatitudeDecimalDegrees As Double = 0
    Private mdStartingLongitudeDecimalDegrees As Double = 0

    Public Sub New(ByVal oFormIcon As System.Drawing.Icon, Optional ByVal sApplicationProductName As String = "", Optional ByVal dStartingLatitudeDecimalDegrees As Double = 0, Optional ByVal dStartingLongitudeDecimalDegrees As Double = 0)

        '----------------------------------------------------------------
        '-- the very first thing we must do is call the base class constructor
        '----------------------------------------------------------------
        MyBase.New()

        '----------------------------------------------------------------
        '-- this call is required by the Windows Form Designer
        '----------------------------------------------------------------
        InitializeComponent()

        Me.Icon = oFormIcon

        If Not String.IsNullOrEmpty(sApplicationProductName) Then
            Me.Text = sApplicationProductName & " - Latitude/Longitude Helper"
        Else
            Me.Text = "Latitude/Longitude Helper"
        End If

        msApplicationProductName = sApplicationProductName

        mdStartingLatitudeDecimalDegrees = dStartingLatitudeDecimalDegrees
        mdStartingLongitudeDecimalDegrees = dStartingLongitudeDecimalDegrees

    End Sub

    Private Sub LatLonHelperForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        mbIsLoading = True

        Me.txtLatitudeDecimalDegrees.Text = Convert.ToString(mdStartingLatitudeDecimalDegrees)
        ConvertFromDd(LocationType.Latitude)

        Me.txtLongitudeDecimalDegrees.Text = Convert.ToString(mdStartingLongitudeDecimalDegrees)
        ConvertFromDd(LocationType.Longitude)

        mbIsLoading = False

    End Sub

    Private Sub LatLonHelperForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

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
        Me.DialogResult = System.Windows.Forms.DialogResult.OK
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub ValidateRanges()

        If (Val(Me.txtLatitudeDmsDegrees.Text) < -180) OrElse (180 < Val(Me.txtLatitudeDmsDegrees.Text)) Then
            Me.txtLatitudeDmsDegrees.BackColor = Drawing.Color.Yellow
        Else
            Me.txtLatitudeDmsDegrees.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtLatitudeDmsMinutes.Text) < 0) OrElse (59 < Val(Me.txtLatitudeDmsMinutes.Text)) Then
            Me.txtLatitudeDmsMinutes.BackColor = Drawing.Color.Yellow
        Else
            Me.txtLatitudeDmsMinutes.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtLatitudeDmsSeconds.Text) < 0) OrElse (59.9999999 < Val(Me.txtLatitudeDmsSeconds.Text)) Then
            Me.txtLatitudeDmsSeconds.BackColor = Drawing.Color.Yellow
        Else
            Me.txtLatitudeDmsSeconds.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtLongitudeDmsDegrees.Text) < -180) OrElse (180 < Val(Me.txtLongitudeDmsDegrees.Text)) Then
            Me.txtLongitudeDmsDegrees.BackColor = Drawing.Color.Yellow
        Else
            Me.txtLongitudeDmsDegrees.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtLongitudeDmsMinutes.Text) < 0) OrElse (59 < Val(Me.txtLongitudeDmsMinutes.Text)) Then
            Me.txtLongitudeDmsMinutes.BackColor = Drawing.Color.Yellow
        Else
            Me.txtLongitudeDmsMinutes.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtLongitudeDmsSeconds.Text) < 0) OrElse (59.9999999 < Val(Me.txtLongitudeDmsSeconds.Text)) Then
            Me.txtLongitudeDmsSeconds.BackColor = Drawing.Color.Yellow
        Else
            Me.txtLongitudeDmsSeconds.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtLatitudeDdmDegrees.Text) < -180) OrElse (180 < Val(Me.txtLatitudeDdmDegrees.Text)) Then
            Me.txtLatitudeDdmDegrees.BackColor = Drawing.Color.Yellow
        Else
            Me.txtLatitudeDdmDegrees.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtLatitudeDdmMinutes.Text) < 0) OrElse (59.9999999 < Val(Me.txtLatitudeDdmMinutes.Text)) Then
            Me.txtLatitudeDdmMinutes.BackColor = Drawing.Color.Yellow
        Else
            Me.txtLatitudeDdmMinutes.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtLongitudeDdmDegrees.Text) < -180) OrElse (180 < Val(Me.txtLongitudeDdmDegrees.Text)) Then
            Me.txtLongitudeDdmDegrees.BackColor = Drawing.Color.Yellow
        Else
            Me.txtLongitudeDdmDegrees.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtLongitudeDdmMinutes.Text) < 0) OrElse (59.9999999 < Val(Me.txtLongitudeDdmMinutes.Text)) Then
            Me.txtLongitudeDdmMinutes.BackColor = Drawing.Color.Yellow
        Else
            Me.txtLongitudeDdmMinutes.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtLatitudeDecimalDegrees.Text) < -180) OrElse (180 < Val(Me.txtLatitudeDecimalDegrees.Text)) Then
            Me.txtLatitudeDecimalDegrees.BackColor = Drawing.Color.Yellow
        Else
            Me.txtLatitudeDecimalDegrees.BackColor = Drawing.SystemColors.Window
        End If

        If (Val(Me.txtLongitudeDecimalDegrees.Text) < -180) OrElse (180 < Val(Me.txtLongitudeDecimalDegrees.Text)) Then
            Me.txtLongitudeDecimalDegrees.BackColor = Drawing.Color.Yellow
        Else
            Me.txtLongitudeDecimalDegrees.BackColor = Drawing.SystemColors.Window
        End If

    End Sub

    Private Sub ConvertFromDms(ByVal eLocationType As LocationType)

        '----------------------------------------------------------------
        '-- convert from degrees/minutes/seconds...
        '----------------------------------------------------------------
        Dim dDegrees As Double
        Dim dDecimalDegrees As Double
        Dim dDegreesDecimalMinutesDegrees As Double

        If (eLocationType = LocationType.Latitude) Then

            dDegrees = Convert.ToDouble(Val(Me.txtLatitudeDmsDegrees.Text))

            If Me.radSouth.Checked Then
                dDegrees = Math.Abs(dDegrees) * -1
            End If

            '----------------------------------------------------------------
            '-- ...to decimal degrees
            '----------------------------------------------------------------
            dDecimalDegrees = LatLonHelpers.ConvertDmsToDd(dDegrees, Convert.ToDouble(Val(Me.txtLatitudeDmsMinutes.Text)), Convert.ToDouble(Val(Me.txtLatitudeDmsSeconds.Text)))

            Me.txtLatitudeDecimalDegrees.Text = String.Format("{0:##.00000}", (dDecimalDegrees))

            '----------------------------------------------------------------
            '--...to degrees decimal-minutes
            '----------------------------------------------------------------
            dDegreesDecimalMinutesDegrees = LatLonHelpers.ConvertDmsToDdmDegrees(dDegrees, Convert.ToDouble(Val(Me.txtLatitudeDmsMinutes.Text)), Convert.ToDouble(Val(Me.txtLatitudeDmsSeconds.Text)))

            Me.txtLatitudeDdmDegrees.Text = String.Format("{0:##}", (dDegreesDecimalMinutesDegrees))
            Me.txtLatitudeDdmMinutes.Text = String.Format("{0:##.00000}", (LatLonHelpers.ConvertDmsToDdmMinutes(Convert.ToDouble(Val(Me.txtLatitudeDmsDegrees.Text)), Convert.ToDouble(Val(Me.txtLatitudeDmsMinutes.Text)), Convert.ToDouble(Val(Me.txtLatitudeDmsSeconds.Text)))))

        Else

            dDegrees = Convert.ToDouble(Val(Me.txtLongitudeDmsDegrees.Text))

            If Me.radWest.Checked Then
                dDegrees = Math.Abs(dDegrees) * -1
            End If

            '----------------------------------------------------------------
            '-- ...to decimal degrees
            '----------------------------------------------------------------
            dDecimalDegrees = LatLonHelpers.ConvertDmsToDd(dDegrees, Convert.ToDouble(Val(Me.txtLongitudeDmsMinutes.Text)), Convert.ToDouble(Val(Me.txtLongitudeDmsSeconds.Text)))

            Me.txtLongitudeDecimalDegrees.Text = String.Format("{0:##.00000}", (dDecimalDegrees))

            '----------------------------------------------------------------
            '--...to degrees decimal-minutes
            '----------------------------------------------------------------
            dDegreesDecimalMinutesDegrees = LatLonHelpers.ConvertDmsToDdmDegrees(dDegrees, Convert.ToDouble(Val(Me.txtLongitudeDmsMinutes.Text)), Convert.ToDouble(Val(Me.txtLongitudeDmsSeconds.Text)))

            Me.txtLongitudeDdmDegrees.Text = String.Format("{0:##}", (dDegreesDecimalMinutesDegrees))
            Me.txtLongitudeDdmMinutes.Text = String.Format("{0:##.00000}", (LatLonHelpers.ConvertDmsToDdmMinutes(Convert.ToDouble(Val(Me.txtLongitudeDmsDegrees.Text)), Convert.ToDouble(Val(Me.txtLongitudeDmsMinutes.Text)), Convert.ToDouble(Val(Me.txtLongitudeDmsSeconds.Text)))))

        End If

        ValidateRanges()

    End Sub

    Private Sub ConvertFromDd(ByVal eLocationType As LocationType)

        Dim dDecimalDegrees As Double
        Dim dDegrees As Double
        Dim dDegreesDecimalMinutesDegrees As Double

        '----------------------------------------------------------------
        '-- convert from decimal degrees...
        '----------------------------------------------------------------
        If (eLocationType = LocationType.Latitude) Then

            dDecimalDegrees = Convert.ToDouble(Val(Me.txtLatitudeDecimalDegrees.Text))

            '----------------------------------------------------------------
            '-- ...to degrees-minutes-seconds
            '----------------------------------------------------------------
            dDegrees = LatLonHelpers.ConvertDdToDmsDegrees(dDecimalDegrees)

            Me.txtLatitudeDmsDegrees.Text = Convert.ToString(Math.Abs(dDegrees))
            Me.txtLatitudeDmsMinutes.Text = Convert.ToString(LatLonHelpers.ConvertDdToDmsMinutes(dDecimalDegrees))
            Me.txtLatitudeDmsSeconds.Text = Convert.ToString(LatLonHelpers.ConvertDdToDmsSeconds(dDecimalDegrees))

            If (dDegrees < 0) Then
                Me.radSouth.Checked = True
            Else
                Me.radNorth.Checked = True
            End If

            '----------------------------------------------------------------
            '-- ...to decimal degrees
            '----------------------------------------------------------------
            dDegreesDecimalMinutesDegrees = LatLonHelpers.ConvertDdToDdmDegrees(dDecimalDegrees)

            Me.txtLatitudeDdmDegrees.Text = String.Format("{0:##}", (dDegreesDecimalMinutesDegrees))
            Me.txtLatitudeDdmMinutes.Text = String.Format("{0:##.00000}", (LatLonHelpers.ConvertDdToDdmMinutes(dDecimalDegrees)))

        Else

            dDecimalDegrees = Convert.ToDouble(Val(Me.txtLongitudeDecimalDegrees.Text))

            '----------------------------------------------------------------
            '-- ...to degrees-minutes-seconds
            '----------------------------------------------------------------
            dDegrees = LatLonHelpers.ConvertDdToDmsDegrees(dDecimalDegrees)

            Me.txtLongitudeDmsDegrees.Text = Convert.ToString(Math.Abs(dDegrees))
            Me.txtLongitudeDmsMinutes.Text = Convert.ToString(LatLonHelpers.ConvertDdToDmsMinutes(dDecimalDegrees))
            Me.txtLongitudeDmsSeconds.Text = Convert.ToString(LatLonHelpers.ConvertDdToDmsSeconds(dDecimalDegrees))

            If (dDegrees < 0) Then
                Me.radWest.Checked = True
            Else
                Me.radEast.Checked = True
            End If

            '----------------------------------------------------------------
            '-- ...to decimal degrees
            '----------------------------------------------------------------
            dDegreesDecimalMinutesDegrees = LatLonHelpers.ConvertDdToDdmDegrees(dDecimalDegrees)

            Me.txtLongitudeDdmDegrees.Text = String.Format("{0:##}", (dDegreesDecimalMinutesDegrees))
            Me.txtLongitudeDdmMinutes.Text = String.Format("{0:##.00000}", (LatLonHelpers.ConvertDdToDdmMinutes(dDecimalDegrees)))

        End If

        ValidateRanges()

    End Sub

    Private Sub ConvertFromDdm(ByVal eLocationType As LocationType)

        Dim dDegreesDecimalMinutesDegrees As Double
        Dim dDegreesDecimalMinutesMinutes As Double
        Dim dDecimalDegrees As Double
        Dim dDegrees As Double

        '----------------------------------------------------------------
        '-- convert from degrees decimal-minutes...
        '----------------------------------------------------------------
        If (eLocationType = LocationType.Latitude) Then

            '----------------------------------------------------------------
            '-- ...to degrees-minutes-seconds
            '----------------------------------------------------------------
            dDegreesDecimalMinutesDegrees = Convert.ToDouble(Val(Me.txtLatitudeDdmDegrees.Text))
            dDegreesDecimalMinutesMinutes = Convert.ToDouble(Val(Me.txtLatitudeDdmMinutes.Text))

            dDegrees = LatLonHelpers.ConvertDdmToDmsDegrees(dDegreesDecimalMinutesDegrees, dDegreesDecimalMinutesMinutes)

            Me.txtLatitudeDmsDegrees.Text = Convert.ToString(Math.Abs(dDegrees))
            Me.txtLatitudeDmsMinutes.Text = Convert.ToString(LatLonHelpers.ConvertDdmToDmsMinutes(dDegreesDecimalMinutesDegrees, dDegreesDecimalMinutesMinutes))
            Me.txtLatitudeDmsSeconds.Text = Convert.ToString(LatLonHelpers.ConvertDdmToDmsSeconds(dDegreesDecimalMinutesDegrees, dDegreesDecimalMinutesMinutes))

            If (dDegreesDecimalMinutesDegrees < 0) Then
                Me.radSouth.Checked = True
            Else
                Me.radNorth.Checked = True
            End If

            '----------------------------------------------------------------
            '-- ...to decimal degrees
            '----------------------------------------------------------------
            dDecimalDegrees = LatLonHelpers.ConvertDdmToDd(dDegreesDecimalMinutesDegrees, dDegreesDecimalMinutesMinutes)

            Me.txtLatitudeDecimalDegrees.Text = String.Format("{0:##.00000}", (dDecimalDegrees))

        Else

            '----------------------------------------------------------------
            '-- ...to degrees-minutes-seconds
            '----------------------------------------------------------------
            dDegreesDecimalMinutesDegrees = Convert.ToDouble(Val(Me.txtLongitudeDdmDegrees.Text))
            dDegreesDecimalMinutesMinutes = Convert.ToDouble(Val(Me.txtLongitudeDdmMinutes.Text))

            dDegrees = LatLonHelpers.ConvertDdmToDmsDegrees(dDegreesDecimalMinutesDegrees, dDegreesDecimalMinutesMinutes)

            Me.txtLongitudeDmsDegrees.Text = Convert.ToString(Math.Abs(dDegrees))
            Me.txtLongitudeDmsMinutes.Text = Convert.ToString(LatLonHelpers.ConvertDdmToDmsMinutes(dDegreesDecimalMinutesDegrees, dDegreesDecimalMinutesMinutes))
            Me.txtLongitudeDmsSeconds.Text = Convert.ToString(LatLonHelpers.ConvertDdmToDmsSeconds(dDegreesDecimalMinutesDegrees, dDegreesDecimalMinutesMinutes))

            If (dDegreesDecimalMinutesDegrees < 0) Then
                Me.radWest.Checked = True
            Else
                Me.radEast.Checked = True
            End If

            '----------------------------------------------------------------
            '-- ...to decimal degrees
            '----------------------------------------------------------------
            dDecimalDegrees = LatLonHelpers.ConvertDdmToDd(dDegreesDecimalMinutesDegrees, dDegreesDecimalMinutesMinutes)

            Me.txtLongitudeDecimalDegrees.Text = String.Format("{0:##.00000}", (dDecimalDegrees))

        End If

        ValidateRanges()

    End Sub

    Private Sub lnkMapIt_LinkClicked(ByVal sender As Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkMapIt.LinkClicked

        Dim oLatLonMapItems As LatLonMapItems
        Dim frm As LatLonMapForm

        Try
            oLatLonMapItems = New LatLonMapItems
            oLatLonMapItems.Add(New LatLonMapItem(Convert.ToDouble(Val(Me.txtLatitudeDecimalDegrees.Text)), Convert.ToDouble(Val(Me.txtLongitudeDecimalDegrees.Text))))

            frm = New LatLonMapForm(oLatLonMapItems, Me.Icon, msApplicationProductName, mdStartingLatitudeDecimalDegrees, mdStartingLongitudeDecimalDegrees)

            frm.ShowDialog(Me)

        Finally
            frm = Nothing
            oLatLonMapItems = Nothing
        End Try

    End Sub

    Private Sub HandleIntegerKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLatitudeDmsDegrees.KeyPress, txtLatitudeDmsMinutes.KeyPress, txtLongitudeDmsDegrees.KeyPress, txtLongitudeDmsMinutes.KeyPress

        If (Char.IsNumber(e.KeyChar) = False) Then
            If (e.KeyChar = CChar(ChrW(Keys.Back))) OrElse (e.KeyChar = CChar(ChrW(Keys.Space))) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub HandleDecimalKeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtLatitudeDmsSeconds.KeyPress, txtLongitudeDmsSeconds.KeyPress

        If (Char.IsNumber(e.KeyChar) = False) Then
            If (e.KeyChar = CChar(ChrW(Keys.Back))) OrElse (e.KeyChar = CChar(".")) OrElse (e.KeyChar = CChar(ChrW(Keys.Space))) Then
                e.Handled = False
            Else
                e.Handled = True
            End If
        End If

    End Sub

    Private Sub HandleKeyUpLatitudeDms(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLatitudeDmsDegrees.KeyUp, txtLatitudeDmsMinutes.KeyUp, txtLatitudeDmsSeconds.KeyUp
        ConvertFromDms(LocationType.Latitude)
    End Sub

    Private Sub HandleKeyUpLongitudeDms(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLongitudeDmsDegrees.KeyUp, txtLongitudeDmsMinutes.KeyUp, txtLongitudeDmsSeconds.KeyUp
        ConvertFromDms(LocationType.Longitude)
    End Sub

    Private Sub radNorthSouth_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radNorth.CheckedChanged, radSouth.CheckedChanged

        If mbIsLoading Then Exit Sub

        ConvertFromDms(LocationType.Latitude)

    End Sub

    Private Sub radEastWest_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles radEast.CheckedChanged, radWest.CheckedChanged

        If mbIsLoading Then Exit Sub

        ConvertFromDms(LocationType.Longitude)

    End Sub

    Private Sub HandleKeyUpLatitudeDd(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLatitudeDecimalDegrees.KeyUp
        mbIsLoading = True
        ConvertFromDd(LocationType.Latitude)
        mbIsLoading = False
    End Sub

    Private Sub HandleKeyUpLongitudeDd(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLongitudeDecimalDegrees.KeyUp
        mbIsLoading = True
        ConvertFromDd(LocationType.Longitude)
        mbIsLoading = False
    End Sub

    Private Sub HandleKeyUpLatitudeDdm(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLatitudeDdmDegrees.KeyUp, txtLatitudeDdmMinutes.KeyUp
        mbIsLoading = True
        ConvertFromDdm(LocationType.Latitude)
        mbIsLoading = False
    End Sub

    Private Sub HandleKeyUpLongitudeDdm(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtLongitudeDdmDegrees.KeyUp, txtLongitudeDdmMinutes.KeyUp
        mbIsLoading = True
        ConvertFromDdm(LocationType.Longitude)
        mbIsLoading = False
    End Sub

    Private Sub lnkLatitudeCopyDms_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkLatitudeCopyDms.LinkClicked
        Clipboard.SetText(Me.txtLatitudeDmsDegrees.Text & "°" & " " & Me.txtLatitudeDmsMinutes.Text & "'" & " " & Me.txtLatitudeDmsSeconds.Text & """" & Convert.ToString(IIf(Me.radNorth.Checked, "N", "W")))
    End Sub

    Private Sub lnkLongitudeCopyDms_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkLongitudeCopyDms.LinkClicked
        Clipboard.SetText(Me.txtLongitudeDmsDegrees.Text & "°" & " " & Me.txtLongitudeDmsMinutes.Text & "'" & " " & Me.txtLongitudeDmsSeconds.Text & """" & Convert.ToString(IIf(Me.radWest.Checked, "W", "E")))
    End Sub

    Private Sub lnkLatitudeCopyDdm_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkLatitudeCopyDdm.LinkClicked
        Clipboard.SetText(Me.txtLatitudeDdmDegrees.Text & "°" & " " & Me.txtLatitudeDdmMinutes.Text & "'")
    End Sub

    Private Sub lnkLongitudeCopyDdm_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkLongitudeCopyDdm.LinkClicked
        Clipboard.SetText(Me.txtLongitudeDdmDegrees.Text & "°" & " " & Me.txtLongitudeDdmMinutes.Text & "'")
    End Sub

End Class