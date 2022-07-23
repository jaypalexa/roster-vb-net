Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class TankWaters
    Inherits BusinessListBase(Of TankWaters, TankWater)

#Region " Business Methods "

    Public Function GetItem(ByVal sTankWaterId As String) As TankWater

        For Each oTankWater As TankWater In Me
            If oTankWater.TankWaterID = sTankWaterId Then
                Return oTankWater
            End If
        Next
        Return Nothing

    End Function

    'Public Function Assign() As TankWater
    '    Dim oTankWater As TankWater
    '    oTankWater = TankWater.NewTankWater()
    '    Me.Add(oTankWater)
    '    Return oTankWater
    'End Function

    Public Function CreateNew() As TankWater

        Dim oTankWater As TankWater

        oTankWater = TankWater.NewTankWater()

        Return oTankWater

    End Function

    Public Overloads Sub Remove(ByVal sTankWaterId As String)

        If String.IsNullOrEmpty(sTankWaterId) Then Exit Sub

        For Each oTankWater As TankWater In Me
            If (oTankWater.TankWaterID = sTankWaterId) Then
                Me.Remove(oTankWater)
                Exit For
            End If
        Next

    End Sub

    Public Overloads Function Contains(ByVal sTankWaterId As String) As Boolean

        If String.IsNullOrEmpty(sTankWaterId) Then Exit Function

        For Each oTankWater As TankWater In Me
            If (String.Compare(oTankWater.TankWaterID, sTankWaterId, True) = 0) Then
                Return True
            End If
        Next

        Return False

    End Function

    Public Overloads Function ContainsDeleted(ByVal sTankWaterId As String) As Boolean

        If String.IsNullOrEmpty(sTankWaterId) Then Exit Function

        For Each oTankWater As TankWater In DeletedList
            If (String.Compare(oTankWater.TankWaterID, sTankWaterId, True) = 0) Then
                Return True
            End If
        Next

        Return False

    End Function

    Public Function GetBrokenRulesString() As String

        Dim s As String = String.Empty

        For Each oTankWater As TankWater In Me
            s &= ControlChars.NewLine & oTankWater.GetBrokenRulesString
        Next

        Return s

    End Function

#End Region

#Region " Factory Methods "

    Friend Shared Function NewTankWaters() As TankWaters

        Return New TankWaters

    End Function

    Friend Shared Function GetTankWaters(ByVal dr As SafeDataReader) As TankWaters

        Return New TankWaters(dr)

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
            Me.Add(TankWater.GetTankWater(dr))
        End While

        Me.RaiseListChangedEvents = True

    End Sub

    Friend Sub Update(ByVal oTank As Tank)

        Me.RaiseListChangedEvents = False

        ' update (thus deleting) any deleted child objects
        For Each oTankWater As TankWater In DeletedList
            oTankWater.DeleteSelf()
        Next
        ' now that they are deleted, remove them from memory too
        DeletedList.Clear()

        ' add/update any current child objects
        For Each oTankWater As TankWater In Me
            If oTankWater.IsNew Then
                oTankWater.Insert(oTank)
            Else
                oTankWater.Update(oTank)
            End If
        Next

        Me.RaiseListChangedEvents = True

    End Sub

#End Region

End Class
