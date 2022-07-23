Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class TankWaterListItems
    Inherits BusinessListBase(Of TankWaterListItems, TankWaterListItem)

#Region " Factory Methods "

    Public Shared Function GetListByTank(ByVal sTankID As String) As TankWaterListItems

        Return DataPortal.Fetch(Of TankWaterListItems)(New CriteriaByTank(sTankID))

    End Function

    Public Shared Function GetListByDateRange(ByVal dtDateFrom As Date, ByVal dtDateThru As Date, ByVal sSortByType As String) As TankWaterListItems

        Return DataPortal.Fetch(Of TankWaterListItems)(New CriteriaByDateRange(dtDateFrom, dtDateThru, sSortByType))

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class CriteriaByTank

        Private msTankID As String

        Public Property TankID() As String
            Get
                Return msTankID
            End Get
            Set(ByVal Value As String)
                msTankID = value
            End Set
        End Property

        Public Sub New(ByVal sTankID As String)
            msTankID = sTankID
        End Sub

    End Class

    <Serializable()> _
    Private Class CriteriaByDateRange

        Private mdtDateFrom As Date
        Private mdtDateThru As Date
        Private msSortByType As String = String.Empty

        Public Property DateFrom() As Date
            Get
                Return mdtDateFrom
            End Get
            Set(ByVal Value As Date)
                mdtDateFrom = value
            End Set
        End Property

        Public Property DateThru() As Date
            Get
                Return mdtDateThru
            End Get
            Set(ByVal Value As Date)
                mdtDateThru = value
            End Set
        End Property

        Public Property SortByType() As String
            Get
                Return msSortByType
            End Get
            Set(ByVal Value As String)
                msSortByType = value
            End Set
        End Property

        Public Sub New(ByVal dtDateFrom As Date, ByVal dtDateThru As Date, ByVal sSortByType As String)
            mdtDateFrom = dtDateFrom
            mdtDateThru = dtDateThru
            msSortByType = sSortByType
        End Sub

    End Class

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteriaObject As Object)

        Dim s As String = String.Empty
        Dim oCriteriaByTank As CriteriaByTank
        Dim oCriteriaByDateRange As CriteriaByDateRange

        RaiseListChangedEvents = False

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()

                Using cm As IDbCommand = cn.CreateCommand()

                    If (TypeOf oCriteriaObject Is CriteriaByTank) Then

                        oCriteriaByTank = DirectCast(oCriteriaObject, CriteriaByTank)

                        s = "SELECT tank_water.*, tank.tank_name "
                        s &= "FROM tank_water, tank "
                        s &= "WHERE tank_water.tank_id = @tank_id "
                        s &= "AND tank_water.tank_id = tank.tank_id "
                        s &= "ORDER BY tank_water.date_measured DESC "

                        cm.Parameters.Add(oAdoHelper.GetParameter("@tank_id", oCriteriaByTank.TankID.ToUpper))

                    Else

                        oCriteriaByDateRange = DirectCast(oCriteriaObject, CriteriaByDateRange)

                        s = "SELECT tank_water.*, tank.tank_name "
                        s &= "FROM tank_water, tank "
                        s &= "WHERE tank_water.tank_id = tank.tank_id "
                        s &= "AND tank_water.date_measured BETWEEN @date_from AND @date_thru "
                        If (oCriteriaByDateRange.SortByType.Trim.ToLower = "name") Then
                            s &= "ORDER BY tank.tank_name, tank_water.date_measured "
                        Else
                            s &= "ORDER BY tank_water.date_measured, tank.tank_name "
                        End If

                        cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteriaByDateRange.DateFrom))
                        cm.Parameters.Add(oAdoHelper.GetParameter("@date_thru", oCriteriaByDateRange.DateThru))

                    End If

                    cm.CommandText = s
                    cm.CommandType = CommandType.Text

                    Using dr As SafeDataReader = oAdoHelper.ExecuteReader(cm)

                        While dr.Read()

                            Me.Add(New TankWaterListItem(dr.GetString("tank_water_id"), dr.GetString("tank_id"), dr.GetString("tank_name"), dr.GetString("temperature"), dr.GetString("salinity"), dr.GetString("ph"), dr.GetDateTime("date_measured")))

                        End While

                    End Using ' dr

                End Using ' cm

            End Using ' cn 

        End Using ' oAdoHelper

        RaiseListChangedEvents = True

    End Sub

#End Region

End Class
