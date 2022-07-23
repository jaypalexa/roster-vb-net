Option Explicit On
Option Strict On
Option Compare Text

<Serializable()> _
Public Class CaptiveFacilityWashbacksReportItem
    Inherits ReadOnlyBase(Of CaptiveFacilityWashbacksReportItem)

#Region " Business Methods "

    Private miCcWashbackStartingBalance As Integer
    Private miCmWashbackStartingBalance As Integer
    Private miDcWashbackStartingBalance As Integer
    Private miOtherWashbackStartingBalance As Integer
    Private miUnknownWashbackStartingBalance As Integer

    Private miCcWashbackAdditionsBeforeThisPeriod As Integer = 0
    Private miCcWashbackSubtractionsBeforeThisPeriod As Integer = 0
    Private miCcWashbacksAcquiredThisPeriod As Integer = 0
    Private miCcWashbacksDiedThisPeriod As Integer = 0
    Private miCcWashbacksReleasedOnTheBeachThisPeriod As Integer = 0
    Private miCcWashbacksReleasedOffshoreThisPeriod As Integer = 0
    Private miCcWashbacksDoaThisPeriod As Integer = 0

    Private miCmWashbackAdditionsBeforeThisPeriod As Integer = 0
    Private miCmWashbackSubtractionsBeforeThisPeriod As Integer = 0
    Private miCmWashbacksAcquiredThisPeriod As Integer = 0
    Private miCmWashbacksDiedThisPeriod As Integer = 0
    Private miCmWashbacksReleasedOnTheBeachThisPeriod As Integer = 0
    Private miCmWashbacksReleasedOffshoreThisPeriod As Integer = 0
    Private miCmWashbacksDoaThisPeriod As Integer = 0

    Private miDcWashbackAdditionsBeforeThisPeriod As Integer = 0
    Private miDcWashbackSubtractionsBeforeThisPeriod As Integer = 0
    Private miDcWashbacksAcquiredThisPeriod As Integer = 0
    Private miDcWashbacksDiedThisPeriod As Integer = 0
    Private miDcWashbacksReleasedOnTheBeachThisPeriod As Integer = 0
    Private miDcWashbacksReleasedOffshoreThisPeriod As Integer = 0
    Private miDcWashbacksDoaThisPeriod As Integer = 0

    Private miOtherWashbackAdditionsBeforeThisPeriod As Integer = 0
    Private miOtherWashbackSubtractionsBeforeThisPeriod As Integer = 0
    Private miOtherWashbacksAcquiredThisPeriod As Integer = 0
    Private miOtherWashbacksDiedThisPeriod As Integer = 0
    Private miOtherWashbacksReleasedOnTheBeachThisPeriod As Integer = 0
    Private miOtherWashbacksReleasedOffshoreThisPeriod As Integer = 0
    Private miOtherWashbacksDoaThisPeriod As Integer = 0

    Private miUnknownWashbackAdditionsBeforeThisPeriod As Integer = 0
    Private miUnknownWashbackSubtractionsBeforeThisPeriod As Integer = 0
    Private miUnknownWashbacksAcquiredThisPeriod As Integer = 0
    Private miUnknownWashbacksDiedThisPeriod As Integer = 0
    Private miUnknownWashbacksReleasedOnTheBeachThisPeriod As Integer = 0
    Private miUnknownWashbacksReleasedOffshoreThisPeriod As Integer = 0
    Private miUnknownWashbacksDoaThisPeriod As Integer = 0

    Public Property CcWashbackStartingBalance() As Integer
        Get
            Return miCcWashbackStartingBalance
        End Get
        Set(ByVal Value As Integer)
            miCcWashbackStartingBalance = Value
        End Set
    End Property

    Public Property CmWashbackStartingBalance() As Integer
        Get
            Return miCmWashbackStartingBalance
        End Get
        Set(ByVal Value As Integer)
            miCmWashbackStartingBalance = Value
        End Set
    End Property

    Public Property DcWashbackStartingBalance() As Integer
        Get
            Return miDcWashbackStartingBalance
        End Get
        Set(ByVal Value As Integer)
            miDcWashbackStartingBalance = Value
        End Set
    End Property

    Public Property OtherWashbackStartingBalance() As Integer
        Get
            Return miOtherWashbackStartingBalance
        End Get
        Set(ByVal Value As Integer)
            miOtherWashbackStartingBalance = Value
        End Set
    End Property

    Public Property UnknownWashbackStartingBalance() As Integer
        Get
            Return miUnknownWashbackStartingBalance
        End Get
        Set(ByVal Value As Integer)
            miUnknownWashbackStartingBalance = Value
        End Set
    End Property

    Public Property CcWashbackAdditionsBeforeThisPeriod() As Integer
        Get
            Return miCcWashbackAdditionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcWashbackAdditionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property CcWashbackSubtractionsBeforeThisPeriod() As Integer
        Get
            Return miCcWashbackSubtractionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcWashbackSubtractionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property CcWashbacksAcquiredThisPeriod() As Integer
        Get
            Return miCcWashbacksAcquiredThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcWashbacksAcquiredThisPeriod = Value
        End Set
    End Property

    Public Property CcWashbacksDiedThisPeriod() As Integer
        Get
            Return miCcWashbacksDiedThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcWashbacksDiedThisPeriod = Value
        End Set
    End Property

    Public Property CcWashbacksReleasedOnTheBeachThisPeriod() As Integer
        Get
            Return miCcWashbacksReleasedOnTheBeachThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcWashbacksReleasedOnTheBeachThisPeriod = Value
        End Set
    End Property

    Public Property CcWashbacksReleasedOffshoreThisPeriod() As Integer
        Get
            Return miCcWashbacksReleasedOffshoreThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcWashbacksReleasedOffshoreThisPeriod = Value
        End Set
    End Property

    Public Property CcWashbacksDoaThisPeriod() As Integer
        Get
            Return miCcWashbacksDoaThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCcWashbacksDoaThisPeriod = Value
        End Set
    End Property

    Public Property CmWashbackAdditionsBeforeThisPeriod() As Integer
        Get
            Return miCmWashbackAdditionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmWashbackAdditionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property CmWashbackSubtractionsBeforeThisPeriod() As Integer
        Get
            Return miCmWashbackSubtractionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmWashbackSubtractionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property CmWashbacksAcquiredThisPeriod() As Integer
        Get
            Return miCmWashbacksAcquiredThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmWashbacksAcquiredThisPeriod = Value
        End Set
    End Property

    Public Property CmWashbacksDiedThisPeriod() As Integer
        Get
            Return miCmWashbacksDiedThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmWashbacksDiedThisPeriod = Value
        End Set
    End Property

    Public Property CmWashbacksReleasedOnTheBeachThisPeriod() As Integer
        Get
            Return miCmWashbacksReleasedOnTheBeachThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmWashbacksReleasedOnTheBeachThisPeriod = Value
        End Set
    End Property

    Public Property CmWashbacksReleasedOffshoreThisPeriod() As Integer
        Get
            Return miCmWashbacksReleasedOffshoreThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmWashbacksReleasedOffshoreThisPeriod = Value
        End Set
    End Property

    Public Property CmWashbacksDoaThisPeriod() As Integer
        Get
            Return miCmWashbacksDoaThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miCmWashbacksDoaThisPeriod = Value
        End Set
    End Property

    Public Property DcWashbackAdditionsBeforeThisPeriod() As Integer
        Get
            Return miDcWashbackAdditionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcWashbackAdditionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property DcWashbackSubtractionsBeforeThisPeriod() As Integer
        Get
            Return miDcWashbackSubtractionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcWashbackSubtractionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property DcWashbacksAcquiredThisPeriod() As Integer
        Get
            Return miDcWashbacksAcquiredThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcWashbacksAcquiredThisPeriod = Value
        End Set
    End Property

    Public Property DcWashbacksDiedThisPeriod() As Integer
        Get
            Return miDcWashbacksDiedThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcWashbacksDiedThisPeriod = Value
        End Set
    End Property

    Public Property DcWashbacksReleasedOnTheBeachThisPeriod() As Integer
        Get
            Return miDcWashbacksReleasedOnTheBeachThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcWashbacksReleasedOnTheBeachThisPeriod = Value
        End Set
    End Property

    Public Property DcWashbacksReleasedOffshoreThisPeriod() As Integer
        Get
            Return miDcWashbacksReleasedOffshoreThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcWashbacksReleasedOffshoreThisPeriod = Value
        End Set
    End Property

    Public Property DcWashbacksDoaThisPeriod() As Integer
        Get
            Return miDcWashbacksDoaThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miDcWashbacksDoaThisPeriod = Value
        End Set
    End Property

    Public Property OtherWashbackAdditionsBeforeThisPeriod() As Integer
        Get
            Return miOtherWashbackAdditionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherWashbackAdditionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property OtherWashbackSubtractionsBeforeThisPeriod() As Integer
        Get
            Return miOtherWashbackSubtractionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherWashbackSubtractionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property OtherWashbacksAcquiredThisPeriod() As Integer
        Get
            Return miOtherWashbacksAcquiredThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherWashbacksAcquiredThisPeriod = Value
        End Set
    End Property

    Public Property OtherWashbacksDiedThisPeriod() As Integer
        Get
            Return miOtherWashbacksDiedThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherWashbacksDiedThisPeriod = Value
        End Set
    End Property

    Public Property OtherWashbacksReleasedOnTheBeachThisPeriod() As Integer
        Get
            Return miOtherWashbacksReleasedOnTheBeachThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherWashbacksReleasedOnTheBeachThisPeriod = Value
        End Set
    End Property

    Public Property OtherWashbacksReleasedOffshoreThisPeriod() As Integer
        Get
            Return miOtherWashbacksReleasedOffshoreThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherWashbacksReleasedOffshoreThisPeriod = Value
        End Set
    End Property

    Public Property OtherWashbacksDoaThisPeriod() As Integer
        Get
            Return miOtherWashbacksDoaThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miOtherWashbacksDoaThisPeriod = Value
        End Set
    End Property

    Public Property UnknownWashbackAdditionsBeforeThisPeriod() As Integer
        Get
            Return miUnknownWashbackAdditionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownWashbackAdditionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property UnknownWashbackSubtractionsBeforeThisPeriod() As Integer
        Get
            Return miUnknownWashbackSubtractionsBeforeThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownWashbackSubtractionsBeforeThisPeriod = Value
        End Set
    End Property

    Public Property UnknownWashbacksAcquiredThisPeriod() As Integer
        Get
            Return miUnknownWashbacksAcquiredThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownWashbacksAcquiredThisPeriod = Value
        End Set
    End Property

    Public Property UnknownWashbacksDiedThisPeriod() As Integer
        Get
            Return miUnknownWashbacksDiedThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownWashbacksDiedThisPeriod = Value
        End Set
    End Property

    Public Property UnknownWashbacksReleasedOnTheBeachThisPeriod() As Integer
        Get
            Return miUnknownWashbacksReleasedOnTheBeachThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownWashbacksReleasedOnTheBeachThisPeriod = Value
        End Set
    End Property

    Public Property UnknownWashbacksReleasedOffshoreThisPeriod() As Integer
        Get
            Return miUnknownWashbacksReleasedOffshoreThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownWashbacksReleasedOffshoreThisPeriod = Value
        End Set
    End Property

    Public Property UnknownWashbacksDoaThisPeriod() As Integer
        Get
            Return miUnknownWashbacksDoaThisPeriod
        End Get
        Set(ByVal Value As Integer)
            miUnknownWashbacksDoaThisPeriod = Value
        End Set
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return String.Empty
    End Function

#End Region

#Region " Factory Methods "

    Public Shared Function GetCaptiveFacilityWashbacksReportItem(ByVal dtDateFrom As Date, ByVal dtDateThru As Date) As CaptiveFacilityWashbacksReportItem

        Return DataPortal.Fetch(Of CaptiveFacilityWashbacksReportItem)(New Criteria(dtDateFrom, dtDateThru))

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
                    dtStartingBalanceDate = dr.GetDateTime("washback_balance_as_of_date")
                    If (dtStartingBalanceDate <> Date.MinValue) AndAlso (dtStartingBalanceDate < oCriteria.DateFrom) Then
                        miCcWashbackStartingBalance = dr.GetInt32("cc_washback_starting_balance")
                        miCmWashbackStartingBalance = dr.GetInt32("cm_washback_starting_balance")
                        miDcWashbackStartingBalance = dr.GetInt32("dc_washback_starting_balance")
                        miOtherWashbackStartingBalance = dr.GetInt32("other_washback_starting_balance")
                        miUnknownWashbackStartingBalance = dr.GetInt32("unknown_washback_starting_balance")
                    End If
                End If
            End Using

            '----------------------------------------------------------------
            '----------------------------------------------------------------
            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miCcWashbackAdditionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_died_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miCcWashbackSubtractionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & " + " & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miCcWashbackSubtractionsBeforeThisPeriod += Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCcWashbacksAcquiredThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_died_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCcWashbacksDiedThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCcWashbacksReleasedOnTheBeachThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCcWashbacksReleasedOffshoreThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
            s &= "WHERE species_code = 'CC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCcWashbacksDoaThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            '----------------------------------------------------------------
            '----------------------------------------------------------------
            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miCmWashbackAdditionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_died_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miCmWashbackSubtractionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & " + " & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miCmWashbackSubtractionsBeforeThisPeriod += Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCmWashbacksAcquiredThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_died_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCmWashbacksDiedThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCmWashbacksReleasedOnTheBeachThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCmWashbacksReleasedOffshoreThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
            s &= "WHERE species_code = 'CM' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miCmWashbacksDoaThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            '----------------------------------------------------------------
            '----------------------------------------------------------------
            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miDcWashbackAdditionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_died_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miDcWashbackSubtractionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & " + " & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miDcWashbackSubtractionsBeforeThisPeriod += Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miDcWashbacksAcquiredThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_died_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miDcWashbacksDiedThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miDcWashbacksReleasedOnTheBeachThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miDcWashbacksReleasedOffshoreThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
            s &= "WHERE species_code = 'DC' "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miDcWashbacksDoaThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            '----------------------------------------------------------------
            '----------------------------------------------------------------
            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miOtherWashbackAdditionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_died_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miOtherWashbackSubtractionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & " + " & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miOtherWashbackSubtractionsBeforeThisPeriod += Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miOtherWashbacksAcquiredThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_died_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miOtherWashbacksDiedThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miOtherWashbacksReleasedOnTheBeachThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miOtherWashbacksReleasedOffshoreThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
            s &= "WHERE species_code IN ('LK', 'LO', 'EI', 'HB') "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miOtherWashbacksDoaThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            '----------------------------------------------------------------
            '----------------------------------------------------------------
            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miUnknownWashbackAdditionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_died_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miUnknownWashbackSubtractionsBeforeThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            cm.CommandType = CommandType.Text
            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & " + " & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND event_date < @date_from "
            If (dtStartingBalanceDate <> Date.MinValue) Then
                s &= "AND @starting_balance_date < event_date "
                cm.Parameters.Add(oAdoHelper.GetParameter("@starting_balance_date", dtStartingBalanceDate))
            End If
            cm.CommandText = s
            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom))
            miUnknownWashbackSubtractionsBeforeThisPeriod += Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(cm))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_acquired_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miUnknownWashbacksAcquiredThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_died_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miUnknownWashbacksDiedThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("beach_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miUnknownWashbacksReleasedOnTheBeachThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("offshore_event_count", "0") & ") FROM washbacks_released_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miUnknownWashbacksReleasedOffshoreThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

            s = "SELECT SUM(" & oAdoHelper.IsNullFunction("event_count", "0") & ") FROM washbacks_doa_event "
            s &= "WHERE ( (species_code IN ('XX', '  ', ' ')) OR (species_code IS NULL) ) "
            s &= "AND (@date_from <= event_date) "
            s &= "AND (event_date <= @date_thru) "
            miUnknownWashbacksDoaThisPeriod = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s, oAdoHelper.GetParameter("@date_from", oCriteria.DateFrom), oAdoHelper.GetParameter("@date_thru", oCriteria.DateThru)))))

        End Using ' oAdoHelper

    End Sub

#End Region

End Class
