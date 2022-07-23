Option Explicit On
Option Strict On
Option Compare Text

<Serializable()> _
Public Class TurtleTags
    Inherits BusinessListBase(Of TurtleTags, TurtleTag)

#Region " Business Methods "

    Public Function GetItem(ByVal sTurtleTagId As String) As TurtleTag

        For Each oTurtleTag As TurtleTag In Me
            If oTurtleTag.TurtleTagID = sTurtleTagId Then
                Return oTurtleTag
            End If
        Next
        Return Nothing

    End Function

    'Public Function Assign() As TurtleTag
    '    Dim oTurtleTag As TurtleTag
    '    oTurtleTag = TurtleTag.NewTurtleTag()
    '    Me.Add(oTurtleTag)
    '    Return oTurtleTag
    'End Function

    Public Function CreateNew() As TurtleTag

        Dim oTurtleTag As TurtleTag

        oTurtleTag = TurtleTag.NewTurtleTag()

        Return oTurtleTag

    End Function

    Public Overloads Sub Remove(ByVal sTurtleTagId As String)

        If String.IsNullOrEmpty(sTurtleTagId) Then Exit Sub

        For Each oTurtleTag As TurtleTag In Me
            If (oTurtleTag.TurtleTagID = sTurtleTagId) Then
                Me.Remove(oTurtleTag)
                Exit For
            End If
        Next

    End Sub

    Public Overloads Function Contains(ByVal sTurtleTagId As String) As Boolean

        If String.IsNullOrEmpty(sTurtleTagId) Then Exit Function

        For Each oTurtleTag As TurtleTag In Me
            If (String.Compare(oTurtleTag.TurtleTagID, sTurtleTagId, True) = 0) Then
                Return True
            End If
        Next

        Return False

    End Function

    Public Overloads Function ContainsDeleted(ByVal sTurtleTagId As String) As Boolean

        If String.IsNullOrEmpty(sTurtleTagId) Then Exit Function

        For Each oTurtleTag As TurtleTag In DeletedList
            If (String.Compare(oTurtleTag.TurtleTagID, sTurtleTagId, True) = 0) Then
                Return True
            End If
        Next

        Return False

    End Function

    Public Function GetBrokenRulesString() As String

        Dim s As String = String.Empty

        For Each oTurtleTag As TurtleTag In Me
            s &= ControlChars.NewLine & oTurtleTag.GetBrokenRulesString
        Next

        Return s

    End Function

    Public Function GetTagNumberListString() As String

        Dim s As String = String.Empty

        Try

            '----------------------------------------------------------------
            '-- return a string of tag numbers for the turtle in context
            '----------------------------------------------------------------
            For Each oTurtleTag As TurtleTag In Me
                If (s.Length > 0) Then
                    s &= ", "
                End If
                s &= oTurtleTag.TagNumber
            Next

            Return s

        Catch ex As Exception

            ErrorMessageBox.Show(ex)
            Throw

        End Try

    End Function

#End Region

#Region " Factory Methods "

    Friend Shared Function NewTurtleTags() As TurtleTags

        Return New TurtleTags

    End Function

    Friend Shared Function GetTurtleTags(ByVal dr As SafeDataReader) As TurtleTags

        Return New TurtleTags(dr)

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
            Me.Add(TurtleTag.GetTurtleTag(dr))
        End While

        Me.RaiseListChangedEvents = True

    End Sub

    Friend Sub Update(ByVal oTurtle As Turtle)

        Me.RaiseListChangedEvents = False

        ' update (thus deleting) any deleted child objects
        For Each oTurtleTag As TurtleTag In DeletedList
            oTurtleTag.DeleteSelf()
        Next
        ' now that they are deleted, remove them from memory too
        DeletedList.Clear()

        ' add/update any current child objects
        For Each oTurtleTag As TurtleTag In Me
            If oTurtleTag.IsNew Then
                oTurtleTag.Insert(oTurtle)
            Else
                oTurtleTag.Update(oTurtle)
            End If
        Next

        Me.RaiseListChangedEvents = True

    End Sub

#End Region

End Class
