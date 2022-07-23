Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class TankListItems
    Inherits BusinessListBase(Of TankListItems, TankListItem)

#Region " Factory Methods "

    Public Shared Function GetList() As TankListItems

        Return DataPortal.Fetch(Of TankListItems)(New Criteria())

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class Criteria

        Public Sub New()
        End Sub

    End Class

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteria As Criteria)

        Dim s As String = String.Empty

        RaiseListChangedEvents = False

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            s = "SELECT * FROM tank "
            s &= "ORDER BY tank_name "

            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(CommandType.Text, s)

                While dr.Read()

                    Me.Add(New TankListItem(dr.GetString("tank_id"), dr.GetString("tank_name")))

                End While

            End Using ' dr

        End Using ' oAdoHelper

        RaiseListChangedEvents = True

    End Sub

#End Region

End Class
