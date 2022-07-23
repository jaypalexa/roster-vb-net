Option Explicit On
Option Strict On

Public NotInheritable Class EmailHelpers

    Private Sub New()
        '-- prevent direct creation of this object (all methods are shared)
    End Sub

    Public Shared Function IsValidEmailAddress(ByVal sEmailAddress As String) As Boolean

        Dim oRegex As System.Text.RegularExpressions.Regex

        oRegex = New System.Text.RegularExpressions.Regex("^[\w][\w\.-]*[\w]@[\w][\w\.-]*[\w]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")

        Return oRegex.IsMatch(sEmailAddress)

    End Function

    Public Shared Function GetEmailAddress(ByVal sDisplayNameAndAddress As String) As String

        '-- returns the e-mail address portion of a display name + address string
        '-- example:  "John Doe <john.doe@yahoo.com>" returns "john.doe@yahoo.com"

        Dim i As Integer
        Dim sAddress As String = String.Empty
        Dim oSplitResultsArray() As String
        Dim oRegex As System.Text.RegularExpressions.Regex

        oRegex = New System.Text.RegularExpressions.Regex("[<>]")

        oSplitResultsArray = oRegex.Split(sDisplayNameAndAddress)

        For i = 0 To oSplitResultsArray.Length - 1

            sAddress = oSplitResultsArray(i)

            If IsValidEmailAddress(sAddress) Then
                Return sAddress
            End If

        Next

        '-- if we get here, the input string did not have a valid e-mail address in it
        Return String.Empty

    End Function

End Class
