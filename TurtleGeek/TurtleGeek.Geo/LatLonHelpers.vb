Option Explicit On
Option Strict On

Public Enum LocationType
    Latitude
    Longitude
End Enum

Public Enum ConversionType
    FromDegreesMinutesSeconds
    FromDegreesDecimalMinutes
    FromDecimalDegrees
End Enum

Public NotInheritable Class LatLonHelpers

    Private Sub New()
        '-- prevent direct creation of this object (all methods are shared)
    End Sub

    ''' <summary>
    ''' Convert degrees-minutes-seconds to decimal degrees
    ''' </summary>
    ''' <param name="dDegrees">The degrees value</param>
    ''' <param name="dMinutes">The minutes value</param>
    ''' <param name="dSeconds">The seconds value</param>
    ''' <returns>The converted decimal degrees value</returns>
    Public Shared Function ConvertDmsToDd(ByVal dDegrees As Double, ByVal dMinutes As Double, ByVal dSeconds As Double) As Double

        '----------------------------------------------------------------
        '-- convert from degrees/minutes/seconds to degrees decimal
        '----------------------------------------------------------------
        If (dDegrees < 0) Then
            dMinutes = Math.Abs(dMinutes) * -1
            dSeconds = Math.Abs(dSeconds) * -1
        End If

        Return dDegrees + (dMinutes / 60) + (dSeconds / 3600)

    End Function

    ''' <summary>
    ''' Convert degrees-minutes-seconds to degrees decimal-minutes (degrees portion)
    ''' </summary>
    ''' <param name="dDegrees">The degrees value</param>
    ''' <param name="dMinutes">The minutes value</param>
    ''' <param name="dSeconds">The seconds value</param>
    ''' <returns>The degrees portion of the conversion</returns>
    Public Shared Function ConvertDmsToDdmDegrees(ByVal dDegrees As Double, ByVal dMinutes As Double, ByVal dSeconds As Double) As Double

        '----------------------------------------------------------------
        '-- convert degrees-minutes-seconds to degrees decimal-minutes (degrees portion)
        '----------------------------------------------------------------
        Return dDegrees

    End Function

    ''' <summary>
    ''' Convert degrees-minutes-seconds to degrees decimal-minutes (minutes portion)
    ''' </summary>
    ''' <param name="dDegrees">The degrees value</param>
    ''' <param name="dMinutes">The minutes value</param>
    ''' <param name="dSeconds">The seconds value</param>
    ''' <returns>The minutes portion of the conversion</returns>
    Public Shared Function ConvertDmsToDdmMinutes(ByVal dDegrees As Double, ByVal dMinutes As Double, ByVal dSeconds As Double) As Double

        '----------------------------------------------------------------
        '-- convert degrees-minutes-seconds to degrees decimal-minutes (minutes portion)
        '----------------------------------------------------------------
        Return dMinutes + (dSeconds / 60)

    End Function

    ''' <summary>
    ''' Convert decimal degrees to degrees-minutes-seconds (degrees portion)
    ''' </summary>
    ''' <param name="dDecimalDegrees">Decimal degress value</param>
    ''' <returns>The degrees portion of the conversion</returns>
    Public Shared Function ConvertDdToDmsDegrees(ByVal dDecimalDegrees As Double) As Double

        'From decimal-degrees (d) to Degrees Minutes decimal-seconds (D M s)
        'D = TRUNC(d)
        'M = TRUNC((d - D) x 60)
        's = (d - D - M/60) x 3600 = (d - D) x 3600 - M x 60

        '----------------------------------------------------------------
        '-- convert from degrees decimal to degrees/minutes/seconds - DEGREES
        '----------------------------------------------------------------
        dDecimalDegrees = dDecimalDegrees
        Dim dDecDegAbs As Double = Math.Truncate(dDecimalDegrees)

        Return dDecDegAbs

    End Function

    ''' <summary>
    ''' Convert decimal degrees to degrees-minutes-seconds (minutes portion)
    ''' </summary>
    ''' <param name="dDecimalDegrees">Decimal degress value</param>
    ''' <returns>The minutes portion of the conversion</returns>
    Public Shared Function ConvertDdToDmsMinutes(ByVal dDecimalDegrees As Double) As Double


        'From decimal-degrees (d) to Degrees Minutes decimal-seconds (D M s)
        'D = TRUNC(d)
        'M = TRUNC((d - D) x 60)
        's = (d - D - M/60) x 3600 = (d - D) x 3600 - M x 60

        '----------------------------------------------------------------
        '-- convert from degrees decimal to degrees/minutes/seconds - MINUTES
        '----------------------------------------------------------------
        dDecimalDegrees = dDecimalDegrees
        Dim dDecDegAbs As Double = Math.Truncate(dDecimalDegrees)
        Dim dMinutesDecimal As Double = Math.Truncate(Convert.ToDouble(String.Format("{0:##.0000}", (dDecimalDegrees - dDecDegAbs) * 60)))

        Return Math.Abs(dMinutesDecimal)

    End Function

    ''' <summary>
    ''' Convert decimal degrees to degrees-minutes-seconds (seconds portion)
    ''' </summary>
    ''' <param name="dDecimalDegrees">Decimal degress value</param>
    ''' <returns>The seconds portion of the conversion</returns>
    Public Shared Function ConvertDdToDmsSeconds(ByVal dDecimalDegrees As Double) As Double

        'From decimal-degrees (d) to Degrees Minutes decimal-seconds (D M s)
        'D = TRUNC(d)
        'M = TRUNC((d - D) x 60)
        's = (d - D - M/60) x 3600 = (d - D) x 3600 - M x 60

        '----------------------------------------------------------------
        '-- convert from degrees decimal to degrees/minutes/seconds - SECONDS
        '----------------------------------------------------------------
        dDecimalDegrees = dDecimalDegrees
        Dim dDecDegAbs As Double = Math.Truncate(dDecimalDegrees)
        Dim dMinutesDecimal As Double = Math.Truncate(Convert.ToDouble(String.Format("{0:##.0000}", (dDecimalDegrees - dDecDegAbs) * 60)))
        Dim dSecondsDecimal As Double = (dDecimalDegrees - dDecDegAbs - dMinutesDecimal / 60) * 3600

        Return Convert.ToDouble(String.Format("{0:##.0000}", Math.Abs(dSecondsDecimal)))

    End Function

    ''' <summary>
    ''' Convert decimal degrees to degrees decimal-minutes (degrees portion)
    ''' </summary>
    ''' <param name="dDecimalDegrees">Decimal degress value</param>
    ''' <returns>The degrees portion of the conversion</returns>
    Public Shared Function ConvertDdToDdmDegrees(ByVal dDecimalDegrees As Double) As Double

        'From decimal-degrees (d) to Degrees decimal-minutes (D m)
        'D = TRUNC(d)
        'm = (d - D) * 60

        '----------------------------------------------------------------
        '-- convert from degrees decimal to degrees/minutes/seconds - DEGREES
        '----------------------------------------------------------------
        dDecimalDegrees = dDecimalDegrees
        Dim dDecDegAbs As Double = Math.Truncate(dDecimalDegrees)

        Return dDecDegAbs

    End Function

    ''' <summary>
    ''' Convert decimal degrees to degrees decimal-minutes (minutes portion)
    ''' </summary>
    ''' <param name="dDecimalDegrees">Decimal degress value</param>
    ''' <returns>The minutes portion of the conversion</returns>
    Public Shared Function ConvertDdToDdmMinutes(ByVal dDecimalDegrees As Double) As Double

        'From decimal-degrees (d) to Degrees decimal-minutes (D m)
        'D = TRUNC(d)
        'm = (d - D) * 60

        '----------------------------------------------------------------
        '-- convert from degrees decimal to degrees/minutes/seconds - MINUTES
        '----------------------------------------------------------------
        dDecimalDegrees = dDecimalDegrees
        Dim dDecDegAbs As Double = Math.Truncate(dDecimalDegrees)
        Dim dMinutesDecimal As Double = Convert.ToDouble(String.Format("{0:##.0000}", (dDecimalDegrees - dDecDegAbs) * 60))

        Return Math.Abs(dMinutesDecimal)

    End Function

    ''' <summary>
    ''' Convert degrees decimal-minutes to decimal degrees
    ''' </summary>
    ''' <param name="dDegrees">Degrees value</param>
    ''' <param name="dMinutes">Decimal minutes value</param>
    ''' <returns>The decimal degrees value</returns>
    Public Shared Function ConvertDdmToDd(ByVal dDegrees As Double, ByVal dMinutes As Double) As Double

        '----------------------------------------------------------------
        '-- convert from degrees decimal-minutes to decimal degrees
        '----------------------------------------------------------------
        If (dDegrees < 0) Then
            dMinutes = dMinutes * -1
        End If

        Return dDegrees + (dMinutes / 60)

    End Function

    ''' <summary>
    ''' Convert degrees decimal-minutes to degrees-minutes-seconds (degrees portion)
    ''' </summary>
    ''' <param name="dDegrees">Degrees value</param>
    ''' <param name="dMinutes">Decimal minutes value</param>
    ''' <returns>The degrees portion of the conversion</returns>
    Public Shared Function ConvertDdmToDmsDegrees(ByVal dDegrees As Double, ByVal dMinutes As Double) As Double

        'From Degrees decimal-minutes (D m) to Degrees Minutes decimal-seconds (D M s)
        'D = D
        'M = TRUNC(m)
        's = (m - M) * 60

        Return dDegrees

    End Function

    ''' <summary>
    ''' Convert degrees decimal-minutes to degrees-minutes-seconds (minutes portion)
    ''' </summary>
    ''' <param name="dDegrees">Degrees value</param>
    ''' <param name="dMinutes">Decimal minutes value</param>
    ''' <returns>The minutes portion of the conversion</returns>
    Public Shared Function ConvertDdmToDmsMinutes(ByVal dDegrees As Double, ByVal dMinutes As Double) As Double

        'From Degrees decimal-minutes (D m) to Degrees Minutes decimal-seconds (D M s)
        'D = D
        'M = TRUNC(m)
        's = (m - M) * 60

        Return Math.Abs(Math.Truncate(dMinutes))

    End Function

    ''' <summary>
    ''' Convert degrees decimal-minutes to degrees-minutes-seconds (seconds portion)
    ''' </summary>
    ''' <param name="dDegrees">Degrees value</param>
    ''' <param name="dMinutes">Decimal minutes value</param>
    ''' <returns>The seconds portion of the conversion</returns>
    Public Shared Function ConvertDdmToDmsSeconds(ByVal dDegrees As Double, ByVal dMinutes As Double) As Double

        'From Degrees decimal-minutes (D m) to Degrees Minutes decimal-seconds (D M s)
        'D = D
        'M = TRUNC(m)
        's = (m - M) * 60

        Return Convert.ToDouble(String.Format("{0:##.0000}", Math.Abs((dMinutes - Math.Truncate(dMinutes)) * 60)))

    End Function


End Class
