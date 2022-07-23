Option Explicit On
Option Strict On

<Serializable()> _
Public Class HatchlingsWashbacksCountyList
    Inherits ReadOnlyListBase(Of HatchlingsWashbacksCountyList, KeyValueInfo)

#Region " Factory Methods "

    Public Shared Function GetList(ByVal bIncludeBlankLine As Boolean, ByVal dtDateFrom As Date, ByVal dtDateThru As Date) As HatchlingsWashbacksCountyList

        Return DataPortal.Fetch(Of HatchlingsWashbacksCountyList)(New Criteria(bIncludeBlankLine, dtDateFrom, dtDateThru))

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class Criteria

        Private mbIncludeBlankLine As Boolean
        Private mdtDateFrom As Date
        Private mdtDateThru As Date

        Public ReadOnly Property IncludeBlankLine() As Boolean
            Get
                Return mbIncludeBlankLine
            End Get
        End Property

        Public Property DateFrom() As Date
            Get
                Return mdtDateFrom
            End Get
            Set(ByVal Value As Date)
                mdtDateFrom = Value
            End Set
        End Property

        Public Property DateThru() As Date
            Get
                Return mdtDateThru
            End Get
            Set(ByVal Value As Date)
                mdtDateThru = Value
            End Set
        End Property

        Public Sub New(ByVal bIncludeBlankLine As Boolean, ByVal dtDateFrom As Date, ByVal dtDateThru As Date)
            mbIncludeBlankLine = bIncludeBlankLine
            mdtDateFrom = dtDateFrom
            mdtDateThru = dtDateThru
        End Sub

    End Class

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteria As Criteria)

        '-- key, value

        Dim s As String = String.Empty

        RaiseListChangedEvents = False

        IsReadOnly = False

        If oCriteria.IncludeBlankLine Then
            Me.Add(New KeyValueInfo(String.Empty, String.Empty))
        End If

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()

                Using cm As IDbCommand = cn.CreateCommand()

                    s = "SELECT DISTINCT " & oAdoHelper.UpperFunction & "(acquired_from_county) AS county_name "
                    s &= "FROM hatchlings_acquired_event "
                    s &= "WHERE (@hatchlings_acquired_date_from <= event_date) "
                    s &= "AND (event_date <= @hatchlings_acquired_date_thru) "
                    s &= "UNION "
                    s &= "SELECT DISTINCT " & oAdoHelper.UpperFunction & "(doa_from_county) AS county_name "
                    s &= "FROM hatchlings_doa_event "
                    s &= "WHERE (@hatchlings_doa_date_from <= event_date) "
                    s &= "AND (event_date <= @hatchlings_doa_date_thru) "
                    s &= "UNION "
                    s &= "SELECT DISTINCT " & oAdoHelper.UpperFunction & "(acquired_from_county) AS county_name "
                    s &= "FROM washbacks_acquired_event "
                    s &= "WHERE (@washbacks_acquired_date_from <= event_date) "
                    s &= "AND (event_date <= @washbacks_acquired_date_thru) "
                    s &= "UNION "
                    s &= "SELECT DISTINCT " & oAdoHelper.UpperFunction & "(doa_from_county) AS county_name "
                    s &= "FROM washbacks_doa_event "
                    s &= "WHERE (@washbacks_doa_date_from <= event_date) "
                    s &= "AND (event_date <= @washbacks_doa_date_thru) "
                    s &= "ORDER BY 1 "

                    cm.Parameters.Add(oAdoHelper.GetParameter("@hatchlings_acquired_date_from", oCriteria.DateFrom))
                    cm.Parameters.Add(oAdoHelper.GetParameter("@hatchlings_acquired_date_thru", oCriteria.DateThru))
                    cm.Parameters.Add(oAdoHelper.GetParameter("@hatchlings_doa_date_from", oCriteria.DateFrom))
                    cm.Parameters.Add(oAdoHelper.GetParameter("@hatchlings_doa_date_thru", oCriteria.DateThru))
                    cm.Parameters.Add(oAdoHelper.GetParameter("@washbacks_acquired_date_from", oCriteria.DateFrom))
                    cm.Parameters.Add(oAdoHelper.GetParameter("@washbacks_acquired_date_thru", oCriteria.DateThru))
                    cm.Parameters.Add(oAdoHelper.GetParameter("@washbacks_doa_date_from", oCriteria.DateFrom))
                    cm.Parameters.Add(oAdoHelper.GetParameter("@washbacks_doa_date_thru", oCriteria.DateThru))

                    cm.CommandText = s
                    cm.CommandType = CommandType.Text

                    Using dr As SafeDataReader = oAdoHelper.ExecuteReader(cm)

                        While dr.Read()

                            Me.Add(New KeyValueInfo(dr.GetString("county_name"), dr.GetString("county_name")))

                        End While

                    End Using ' dr

                End Using ' cm

            End Using ' cn 

        End Using ' oAdoHelper

        IsReadOnly = True

        RaiseListChangedEvents = True

    End Sub

#End Region

End Class
