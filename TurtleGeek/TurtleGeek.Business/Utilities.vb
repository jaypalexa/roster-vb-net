Option Explicit On 
Option Strict On
Option Compare Text

''' <summary>
''' Business object-related utilities
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class Utilities

    ''' <summary>
    ''' Converts a given <b>Date</b> value to a <b>Nullable(Of DateTime)</b>.
    ''' </summary>
    ''' <param name="oDateValue">The <b>Date</b> value to convert.</param>
    ''' <returns>If the <b>Date</b> value = <b>Date.MinValue</b>, the <b>Nothing</b> value is returned.  Otherwise, the original <b>Date</b> value is is returned.</returns>
    Public Shared Function DateAsNullableDate(ByVal oDateValue As Date) As Nullable(Of DateTime)
        If oDateValue.Equals(Date.MinValue) Then
            Return Nothing
        Else
            Return oDateValue
        End If
    End Function

    ''' <summary>
    ''' Converts a given <b>Date</b> value to a <b>String</b>.
    ''' </summary>
    ''' <param name="oDateValue">The <b>Date</b> value to convert.</param>
    ''' <param name="sFormatString">Optional.  A valid user-defined date format string.</param>
    ''' <returns>If the <b>Date</b> value = <b>Date.MinValue</b>, a blank string is returned.  Otherwise, the <b>Date</b> value is converted to a string and formatted as specified.  If no formatting is specified, the format will be "MM/dd/yyyy".</returns>
    Public Shared Function DateAsString(ByVal oDateValue As Date, Optional ByVal sFormatString As String = "MM/dd/yyyy") As String
        If oDateValue.Equals(Date.MinValue) Then
            Return String.Empty
        Else
            Return oDateValue.ToString(sFormatString)
        End If
    End Function

    ''' <summary>
    ''' Converts a given <b>Date</b> value to midnight of that date.
    ''' </summary>
    ''' <param name="oDateValue">The <b>Date</b> value to convert.</param>
    ''' <returns>The <b>Date</b> value shifted to midnight (00:00:00) of that date.</returns>
    Public Shared Function DateAtMidnight(ByVal oDateValue As Date) As Date
        Return New Date(oDateValue.Year, oDateValue.Month, oDateValue.Day, 0, 0, 0)
    End Function

    ''' <summary>
    ''' Determines whether two <b>Date</b> values are the same.
    ''' </summary>
    ''' <param name="oOldDateValue">The first <b>Date</b> value to compare.</param>
    ''' <param name="oNewDateValue">The second <b>Date</b> value to compare.</param>
    ''' <returns><b>True</b> if the values are different; else <b>False</b>.</returns>
    Public Shared Function HasDateValueChanged(ByVal oOldDateValue As Date, ByVal oNewDateValue As Date) As Boolean

        If (oOldDateValue.Year = oNewDateValue.Year) _
        AndAlso (oOldDateValue.Month = oNewDateValue.Month) _
        AndAlso (oOldDateValue.Day = oNewDateValue.Day) Then
            Return False
        Else
            Return True
        End If
    End Function

    ''' <summary>
    ''' Returns a consistent directory name of the executing assembly.
    ''' </summary>
    ''' <returns>The directory name of the executing assembly.</returns>
    Public Shared Function GetExecutingDirectoryName() As String

        Return System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().GetName().CodeBase).Replace("file:\", "")

    End Function

    ''' <summary>
    ''' Indicates whether a given string is a positive whole number.
    ''' </summary>
    ''' <param name="sStringToCheck">The <b>String</b> value to check.</param>
    ''' <returns><b>True</b> contains only digits; else <b>False</b>.</returns>
    Public Shared Function IsInteger(ByVal sStringToCheck As String) As Boolean

        If String.IsNullOrEmpty(sStringToCheck) Then
            Return False
        Else
            For i As Integer = 0 To sStringToCheck.Length - 1
                If Not Char.IsNumber(sStringToCheck(i)) Then
                    Return False
                End If
            Next
        End If

        Return True

    End Function

    Public Shared Sub UnbindBindingSource(ByVal oBindingSource As BindingSource, ByVal bIsCancel As Boolean, ByVal bIsRoot As Boolean)

        Dim oIEditableObject As System.ComponentModel.IEditableObject = TryCast(oBindingSource.Current, System.ComponentModel.IEditableObject)

        If bIsRoot Then
            oBindingSource.DataSource = Nothing
        End If

        If oIEditableObject IsNot Nothing Then
            If bIsCancel Then
                oIEditableObject.CancelEdit()
            Else
                oIEditableObject.EndEdit()
            End If
        End If

    End Sub

End Class
