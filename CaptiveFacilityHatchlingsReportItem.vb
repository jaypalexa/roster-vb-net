Option Explicit On
Option Strict On
Option Compare Text

<Serializable()> _
Public Class CaptiveFacilityHatchlingsReportItem
    Inherits ReadOnlyBase(Of CaptiveFacilityHatchlingsReportItem)

#Region " Business Methods "

    Private miCcHatchlingStartingBalance As Integer
    Private miCmHatchlingStartingBalance As Integer
    Private miDcHatchlingStartingBalance As Integer
    Private miOtherHatchlingStartingBalance As Integer
    Private miUnknownHatchlingStartingBalance As Integer

    Private miCcHatchlingAdditionsBeforeThisPeriod As Integer = 0
    Private miCcHatchlingSubtractionsBeforeThisPeriod As Integer = 0
    Private miCcHatchlingsAcquiredThisPeriod As Integer = 0
    Private miCcHatchlingsDiedThisPeriod As Integer = 0
    Private miCcHatchlingsReleasedOnTheBeachThisPeriod As Integer = 0
    Private miCcHatchlingsReleasedOffshoreThisPeriod As Integer = 0
    Private miCcHatchlingsDoaThisPeriod As Integer = 0

    Private miCmHatchlingAdditionsBeforeThisPeriod As Integer = 0
    Private miCmHatchlingSubtractionsBeforeThisPeriod As Integer = 0
    Private miCmHatchlingsAcquiredThisPeriod As Integer = 0
    Private miCmHatchlingsDiedThisPeriod As Integer = 0
    Private miCmHatchlingsReleasedOnTheBeachThisPeriod As Integer = 0
    Private miCmHatchlingsReleasedOffshoreThisPeriod As Integer = 0
    Private miCmHatchlingsDoaThisPeriod As Integer = 0

    Private miDcHatchlingAdditionsBeforeThisPeriod As Integer = 0
    Private miDcHatchlingSubtractionsBeforeThisPeriod As Integer = 0
    Private miDcHatchlingsAcquiredThisPeriod As Integer = 0
    Private miDcHatchlingsDiedThisPeriod As Integer = 0
    Private miDcHatchlingsReleasedOnTheBeachThisPeriod As Integer = 0
    Private miDcHatchlingsReleasedOffshoreThisPeriod As Integer = 0
    Private miDcHatchlingsDoaThisPeriod As Integer = 0

    Private miOtherHatchlingAdditionsBeforeThisPeriod As Integer = 0
    Private miOtherHatchlingSubtractionsBeforeThisPeriod As Integer = 0
    Private miOtherHatchlingsAcquiredThisPeriod As Integer = 0
    Private miOtherHatchlingsDiedThisPeriod As Integer = 0
    Private miOtherHatchlingsReleasedOnTheBeachThisPeriod As Integer = 0
    Private miOtherHatchlingsReleasedOffshoreThisPeriod As Integer = 0
    Private miOtherHatchlingsDoaThisPeriod As Integer = 0

    Private miUnknownHatchlingAdditionsBeforeThisPeriod As Integer = 0
    Private miUnknownHatchlingSubtractionsBeforeThisPeriod As Integer = 0
    Private miUnknownHatchlingsAcquiredThisPeriod As Integer = 0
    Private miUnknownHatchlingsDiedThisPeriod As Integer = 0
    Private miUnknownHatchlingsReleasedOnTheBeachThisPeriod As Integer = 0
    Private miUnknownHatchlingsReleasedOffshoreThisPeriod As Integer = 0
    Private miUnknownHatchlingsDoaThisPeriod As Integer = 0

    Public Property CcHatchlingStartingBalance() As Integer
        Get
            Return miCcHatchlingStartingBalance
        End Get
        Set(ByVal Value As Integer)
            miCcHatchlingStartingBalance = Value
        End Set
    End Property

    Public Property CmHatchlingStartingBalance() As Integer
        Get
            Return miCmHatchlingStartingBalance
        End Get
        Set(ByVal Value As Integer)
            miCmHatchlingStartingBalance = Value
        End Set
    End Property

    Public Property DcHatchlingStartingBalance() As Integer
        Get
            Return miDcHatchlingStartingBalance
        End Get
        Set(ByVal Value As Integer)
            miDcHatchlingStartingBalance = Value
        End Set
    End Property

    Public Property OtherHatchlingStartingBalance() As Integer
        Get
            Return miOtherHatchlingStartingBalance
        End Get
        Set(ByVal Value As Integer)
            miOtherHatchlingStartingBalance = Value
        End Set
    End Property

    Public Property UnknownHatchlingStartingBalance() As Integer
        Get
            Return miUnknownHatchlingStartingBalance
        End Get
        Set(ByVal Value As Integer)
            miUnknownHatchlingStartingBalance = Value
        End Set
    End Property

    Public Property CcHatchlingAdditionsBeforeThisPeriod() As Integer
        Get
            Return miCcHatchlingAdditionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcHatchlingAdditionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property CcHatchlingSubtractionsBeforeThisPeriod() As Integer
        Get
            Return miCcHatchlingSubtractionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcHatchlingSubtractionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property CcHatchlingsAcquiredThisPeriod() As Integer
        Get
            Return miCcHatchlingsAcquiredThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcHatchlingsAcquiredThisPeriod = Value
        End Set
    End Property

    Public Property CcHatchlingsDiedThisPeriod() As Integer
        Get
            Return miCcHatchlingsDiedThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcHatchlingsDiedThisPeriod = Value
        End Set
    End Property

    Public Property CcHatchlingsReleasedOnTheBeachThisPeriod() As Integer
        Get
            Return miCcHatchlingsReleasedOnTheBeachThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcHatchlingsReleasedOnTheBeachThisPeriod = Value
        End Set
    End Property

    Public Property CcHatchlingsReleasedOffshoreThisPeriod() As Integer
        Get
            Return miCcHatchlingsReleasedOffshoreThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcHatchlingsReleasedOffshoreThisPeriod = Value
        End Set
    End Property

    Public Property CcHatchlingsDoaThisPeriod() As Integer
        Get
            Return miCcHatchlingsDoaThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcHatchlingsDoaThisPeriod = Value
        End Set
    End Property

    Public Property CmHatchlingAdditionsBeforeThisPeriod() As Integer
        Get
            Return miCmHatchlingAdditionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmHatchlingAdditionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property CmHatchlingSubtractionsBeforeThisPeriod() As Integer
        Get
            Return miCmHatchlingSubtractionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmHatchlingSubtractionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property CmHatchlingsAcquiredThisPeriod() As Integer
        Get
            Return miCmHatchlingsAcquiredThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmHatchlingsAcquiredThisPeriod = Value
        End Set
    End Property

    Public Property CmHatchlingsDiedThisPeriod() As Integer
        Get
            Return miCmHatchlingsDiedThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmHatchlingsDiedThisPeriod = Value
        End Set
    End Property

    Public Property CmHatchlingsReleasedOnTheBeachThisPeriod() As Integer
        Get
            Return miCmHatchlingsReleasedOnTheBeachThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmHatchlingsReleasedOnTheBeachThisPeriod = Value
        End Set
    End Property

    Public Property CmHatchlingsReleasedOffshoreThisPeriod() As Integer
        Get
            Return miCmHatchlingsReleasedOffshoreThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmHatchlingsReleasedOffshoreThisPeriod = Value
        End Set
    End Property

    Public Property CmHatchlingsDoaThisPeriod() As Integer
        Get
            Return miCmHatchlingsDoaThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmHatchlingsDoaThisPeriod = Value
        End Set
    End Property

    Public Property DcHatchlingAdditionsBeforeThisPeriod() As Integer
        Get
            Return miDcHatchlingAdditionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcHatchlingAdditionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property DcHatchlingSubtractionsBeforeThisPeriod() As Integer
        Get
            Return miDcHatchlingSubtractionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcHatchlingSubtractionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property DcHatchlingsAcquiredThisPeriod() As Integer
        Get
            Return miDcHatchlingsAcquiredThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcHatchlingsAcquiredThisPeriod = Value
        End Set
    End Property

    Public Property DcHatchlingsDiedThisPeriod() As Integer
        Get
            Return miDcHatchlingsDiedThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcHatchlingsDiedThisPeriod = Value
        End Set
    End Property

    Public Property DcHatchlingsReleasedOnTheBeachThisPeriod() As Integer
        Get
            Return miDcHatchlingsReleasedOnTheBeachThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcHatchlingsReleasedOnTheBeachThisPeriod = Value
        End Set
    End Property

    Public Property DcHatchlingsReleasedOffshoreThisPeriod() As Integer
        Get
            Return miDcHatchlingsReleasedOffshoreThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcHatchlingsReleasedOffshoreThisPeriod = Value
        End Set
    End Property

    Public Property DcHatchlingsDoaThisPeriod() As Integer
        Get
            Return miDcHatchlingsDoaThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcHatchlingsDoaThisPeriod = Value
        End Set
    End Property

    Public Property OtherHatchlingAdditionsBeforeThisPeriod() As Integer
        Get
            Return miOtherHatchlingAdditionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherHatchlingAdditionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property OtherHatchlingSubtractionsBeforeThisPeriod() As Integer
        Get
            Return miOtherHatchlingSubtractionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherHatchlingSubtractionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property OtherHatchlingsAcquiredThisPeriod() As Integer
        Get
            Return miOtherHatchlingsAcquiredThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherHatchlingsAcquiredThisPeriod = Value
        End Set
    End Property

    Public Property OtherHatchlingsDiedThisPeriod() As Integer
        Get
            Return miOtherHatchlingsDiedThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherHatchlingsDiedThisPeriod = Value
        End Set
    End Property

    Public Property OtherHatchlingsReleasedOnTheBeachThisPeriod() As Integer
        Get
            Return miOtherHatchlingsReleasedOnTheBeachThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherHatchlingsReleasedOnTheBeachThisPeriod = Value
        End Set
    End Property

    Public Property OtherHatchlingsReleasedOffshoreThisPeriod() As Integer
        Get
            Return miOtherHatchlingsReleasedOffshoreThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherHatchlingsReleasedOffshoreThisPeriod = Value
        End Set
    End Property

    Public Property OtherHatchlingsDoaThisPeriod() As Integer
        Get
            Return miOtherHatchlingsDoaThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherHatchlingsDoaThisPeriod = Value
        End Set
    End Property

    Public Property UnknownHatchlingAdditionsBeforeThisPeriod() As Integer
        Get
            Return miUnknownHatchlingAdditionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownHatchlingAdditionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property UnknownHatchlingSubtractionsBeforeThisPeriod() As Integer
        Get
            Return miUnknownHatchlingSubtractionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownHatchlingSubtractionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property UnknownHatchlingsAcquiredThisPeriod() As Integer
        Get
            Return miUnknownHatchlingsAcquiredThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownHatchlingsAcquiredThisPeriod = Value
        End Set
    End Property

    Public Property UnknownHatchlingsDiedThisPeriod() As Integer
        Get
            Return miUnknownHatchlingsDiedThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownHatchlingsDiedThisPeriod = Value
        End Set
    End Property

    Public Property UnknownHatchlingsReleasedOnTheBeachThisPeriod() As Integer
        Get
            Return miUnknownHatchlingsReleasedOnTheBeachThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownHatchlingsReleasedOnTheBeachThisPeriod = Value
        End Set
    End Property

    Public Property UnknownHatchlingsReleasedOffshoreThisPeriod() As Integer
        Get
            Return miUnknownHatchlingsReleasedOffshoreThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownHatchlingsReleasedOffshoreThisPeriod = Value
        End Set
    End Property

    Public Property UnknownHatchlingsDoaThisPeriod() As Integer
        Get
            Return miUnknownHatchlingsDoaThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownHatchlingsDoaThisPeriod = Value
        End Set
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return String.Empty
    End Function

#End Region

#Region " Factory Methods "

    Public Shared Function GetCaptiveFacilityHatchlingsReportItem(ByVal dtDateFrom As Date, ByVal dtDateThru As Date) As CaptiveFacilityHatchlingsReportItem

        Return DataPortal.Fetch(Of CaptiveFacilityHatchlingsReportItem)(New Criteria(dtDateFrom, dtDateThru))

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class Criteria

        Private mdtDateFrom As Date
        Private mdtDateThru As Date

        Public ReadOnly Property DateFrom() As Date
            Get
                Return mdtDateFrom
            End Get
        End Property

        Public ReadOnly Property DateThru() As Date
            Get
                Return mdtDateThru
            End Get
        End Property

        Public Sub New(ByVal dtDateFrom As Date, ByVal dtDateThru As Date)
            mdtDateFrom = dtDateFrom
            mdtDateThru = dtDateThru
        End Sub
    End Class

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteria As Criteria)

        Dim s As String = String.Empty
        Dim dtStartingBalanceDate As Date = Date.MinValue
        Dim cm As IDbCommand

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            cm = oAdoHelper.GetConnection.CreateCommand()

            '----------------------------------------------------------------
            '-- get starting balances
            '----------------------------------------------------------------
            s = "SELECT * FROM organization "
            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(CommandType.Text, s)
                If dr.Read() Then
                    dtStartingBalanceDate = dr.GetDateTime("hatchling_balance_as_of_date")
                    If (dtStartingBalanceDate <> Date.MinValue) AndAlso (dtStartingBalanceDate < oCriteria.DateFrom) Then
                        miCcHatchlingStartingBalance = dr.GetInt32("cc_hatchling_starting_balance")
                        miCmHatchlingStartingBalance = dr.GetInt32("cm_hatchling_starting_balance")
                        miDcHatchlingStartingBalance = dr.GetInt32("dc_hatchling_starting_balance")
                        miOtherHatchlingStartingBalance = dr.GetInt32("other_hatchling_starting_balance")
                        miUnknownHatchlingStartingBalance = dr.GetInt32("unknown_hatchling_starting_balance")
                    End If
                End If
            End Using

            '----------------------------------------------------------------
            '----------------------------------------------------------------
            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miCcHatchlingAdditionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_died_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miCcHatchlingSubtractionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & " + " & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miCcHatchlingSubtractionsBeforeThisPeriod += Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCcHatchlingsAcquiredThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_died_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCcHatchlingsDiedThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCcHatchlingsReleasedOnTheBeachThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCcHatchlingsReleasedOffshoreThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCcHatchlingsDoaThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            '----------------------------------------------------------------
            '----------------------------------------------------------------
            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miCmHatchlingAdditionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_died_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miCmHatchlingSubtractionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & " + " & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miCmHatchlingSubtractionsBeforeThisPeriod += Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCmHatchlingsAcquiredThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_died_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCmHatchlingsDiedThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCmHatchlingsReleasedOnTheBeachThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCmHatchlingsReleasedOffshoreThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCmHatchlingsDoaThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            '----------------------------------------------------------------
            '----------------------------------------------------------------
            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miDcHatchlingAdditionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_died_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miDcHatchlingSubtractionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & " + " & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miDcHatchlingSubtractionsBeforeThisPeriod += Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miDcHatchlingsAcquiredThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_died_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miDcHatchlingsDiedThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miDcHatchlingsReleasedOnTheBeachThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miDcHatchlingsReleasedOffshoreThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miDcHatchlingsDoaThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            '----------------------------------------------------------------
            '----------------------------------------------------------------
            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miOtherHatchlingAdditionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_died_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miOtherHatchlingSubtractionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & " + " & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miOtherHatchlingSubtractionsBeforeThisPeriod += Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miOtherHatchlingsAcquiredThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_died_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miOtherHatchlingsDiedThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miOtherHatchlingsReleasedOnTheBeachThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miOtherHatchlingsReleasedOffshoreThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miOtherHatchlingsDoaThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            '----------------------------------------------------------------
            '----------------------------------------------------------------
            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miUnknownHatchlingAdditionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_died_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miUnknownHatchlingSubtractionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & " + " & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miUnknownHatchlingSubtractionsBeforeThisPeriod += Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_acquired_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miUnknownHatchlingsAcquiredThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_died_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miUnknownHatchlingsDiedThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miUnknownHatchlingsReleasedOnTheBeachThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM hatchlings_released_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miUnknownHatchlingsReleasedOffshoreThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM hatchlings_doa_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miUnknownHatchlingsDoaThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

        End Using ' oAdoHelper

    End Sub

#End Region

End Class
