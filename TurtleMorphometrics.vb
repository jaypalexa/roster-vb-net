Option Explicit On
Option Strict On
Option Compare Text

<Serializable()> _
Public Class TurtleMorphometrics
    Inherits BusinessListBase(Of TurtleMorphometrics, TurtleMorphometric)

#Region " Business Methods "

    Public Function GetItem(ByVal sTurtleMorphometricId As String) As TurtleMorphometric

        For Each oTurtleMorphometric As TurtleMorphometric In Me
            If oTurtleMorphometric.TurtleMorphometricID = sTurtleMorphometricId Then
                Return oTurtleMorphometric
            End If
        Next
        Return Nothing

    End Function

    'Public Function Assign() As TurtleMorphometric
    '    Dim oTurtleMorphometric As TurtleMorphometric
    '    oTurtleMorphometric = TurtleMorphometric.NewTurtleMorphometric()
    '    Me.Add(oTurtleMorphometric)
    '    Return oTurtleMorphometric
    'End Function

    Public Function CreateNew() As TurtleMorphometric

        Dim oTurtleMorphometric As TurtleMorphometric

        oTurtleMorphometric = TurtleMorphometric.NewTurtleMorphometric()

        Return oTurtleMorphometric

    End Function

    Public Overloads Sub Remove(ByVal sTurtleMorphometricId As String)

        If String.IsNullOrEmpty(sTurtleMorphometricId) Then Exit Sub

        For Each oTurtleMorphometric As TurtleMorphometric In Me
            If (oTurtleMorphometric.TurtleMorphometricID = sTurtleMorphometricId) Then
                Me.Remove(oTurtleMorphometric)
                Exit For
            End If
        Next

    End Sub

    Public Overloads Function Contains(ByVal sTurtleMorphometricId As String) As Boolean

        If String.IsNullOrEmpty(sTurtleMorphometricId) Then Exit Function

        For Each oTurtleMorphometric As TurtleMorphometric In Me
            If (String.Compare(oTurtleMorphometric.TurtleMorphometricID, sTurtleMorphometricId, True) = 0) Then
                Return True
            End If
        Next

        Return False

    End Function

    Public Overloads Function ContainsDeleted(ByVal sTurtleMorphometricId As String) As Boolean

        If String.IsNullOrEmpty(sTurtleMorphometricId) Then Exit Function

        For Each oTurtleMorphometric As TurtleMorphometric In DeletedList
            If (String.Compare(oTurtleMorphometric.TurtleMorphometricID, sTurtleMorphometricId, True) = 0) Then
                Return True
            End If
        Next

        Return False

    End Function

    Public Function GetBrokenRulesString() As String

        Dim s As String = String.Empty

        For Each oTurtleMorphometric As TurtleMorphometric In Me
            s &= ControlChars.NewLine & oTurtleMorphometric.GetBrokenRulesString
        Next

        Return s

    End Function

#End Region

#Region " Factory Methods "

    Friend Shared Function NewTurtleMorphometrics() As TurtleMorphometrics

        Return New TurtleMorphometrics

    End Function

    Friend Shared Function GetTurtleMorphometrics(ByVal dr As SafeDataReader) As TurtleMorphometrics

        Return New TurtleMorphometrics(dr)

    End Function

    Private Sub New()

        MarkAsChild()

    End Sub

    Private Sub New(ByVal dr As SafeDataReader)

        MarkAsChild()
        Fetch(dr)

    End Sub

#End Region

#Region " Data Access "

    Private Sub Fetch(ByVal dr As SafeDataReader)

        Me.RaiseListChangedEvents = False

        While dr.Read()
            Me.Add(TurtleMorphometric.GetTurtleMorphometric(dr))
        End While

        Me.RaiseListChangedEvents = True

    End Sub

    Friend Sub Update(ByVal oTurtle As Turtle)

        Me.RaiseListChangedEvents = False

        ' update (thus deleting) any deleted child objects
        For Each oTurtleMorphometric As TurtleMorphometric In DeletedList
            oTurtleMorphometric.DeleteSelf()
        Next
        ' now that they are deleted, remove them from memory too
        DeletedList.Clear()

        ' add/update any current child objects
        For Each oTurtleMorphometric As TurtleMorphometric In Me
            If oTurtleMorphometric.IsNew Then
                oTurtleMorphometric.Insert(oTurtle)
            Else
                oTurtleMorphometric.Update(oTurtle)
            End If
        Next

        Me.RaiseListChangedEvents = True

    End Sub

#End Region

End Class
