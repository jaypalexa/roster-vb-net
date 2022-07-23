Option Explicit On
Option Strict On
Option Compare Text

''' <summary>
''' Common business object validation rules
''' </summary>
''' <remarks></remarks>
Public NotInheritable Class Rules

    Public Shared Function DateValueRequired(ByVal target As Object, ByVal e As Csla.Validation.RuleArgs) As Boolean

        Dim oPropertyValue As Object = Nothing

        oPropertyValue = CallByName(target, e.PropertyName, CallType.Get)

        If (oPropertyValue Is Nothing) OrElse (oPropertyValue Is DBNull.Value) Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Shared Function IntegerValueRequired(ByVal target As Object, ByVal e As Csla.Validation.RuleArgs) As Boolean

        Dim sPropertyValue As String = String.Empty

        sPropertyValue = Convert.ToString(CallByName(target, e.PropertyName, CallType.Get))

        If Not String.IsNullOrEmpty(sPropertyValue) AndAlso (sPropertyValue.Trim.Length > 0) AndAlso Not Utilities.IsInteger(sPropertyValue) Then
            Return False
        Else
            Return True
        End If

    End Function

    Public Shared Function AtLeastOneChildRequired(ByVal target As Object, ByVal e As Csla.Validation.RuleArgs) As Boolean

        Dim iChildCount As Integer = 0
        Dim oChildCollection As Object = Nothing

        oChildCollection = CallByName(target, e.PropertyName, CallType.Get)
        iChildCount = Convert.ToInt32(CallByName(oChildCollection, "Count", CallType.Method))

        If (iChildCount <= 0) Then
            Return False
        Else
            Return True
        End If

    End Function

End Class
