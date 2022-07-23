Option Explicit On
Option Strict On
Option Compare Text

<Serializable()> _
Public Class TurtleListItems
    Inherits BusinessListBase(Of TurtleListItems, TurtleListItem)

    Public Enum LoadDateRangeType
        DateAcquired
        DateTagged
        DateRelinquished
    End Enum

#Region " Factory Methods "

    Public Shared Function NewList() As TurtleListItems

        Return DataPortal.Fetch(Of TurtleListItems)(New Criteria())

    End Function

    Public Shared Function GetListBySearchOptions(Optional ByVal bShowInactiveTurtles As Boolean = False, Optional ByVal sFilterByType As String = "", Optional ByVal sFilterByValue As String = "") As TurtleListItems

        Return DataPortal.Fetch(Of TurtleListItems)(New CriteriaBySearchOptions(bShowInactiveTurtles, sFilterByType, sFilterByValue))

    End Function

    Public Shared Function GetListByDatesInFacilityRange(Optional ByVal dtDateFrom As Date = #12:00:00 AM#, Optional ByVal dtDateThru As Date = #12:00:00 AM#) As TurtleListItems

        Return DataPortal.Fetch(Of TurtleListItems)(New CriteriaByDatesInFacilityRange(dtDateFrom, dtDateThru))

    End Function

    Public Shared Function GetListByDateRange(ByVal eLoadDateRangeType As LoadDateRangeType, ByVal bIncludeNonRelinquishedTurtles As Boolean, Optional ByVal dtDateFrom As Date = #12:00:00 AM#, Optional ByVal dtDateThru As Date = #12:00:00 AM#) As TurtleListItems

        Return DataPortal.Fetch(Of TurtleListItems)(New CriteriaByDateRange(eLoadDateRangeType, bIncludeNonRelinquishedTurtles, dtDateFrom, dtDateThru))

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

    <Serializable()> _
    Private Class CriteriaBySearchOptions

        Private mbShowInactiveTurtles As Boolean = False
        Private msFilterByType As String = String.Empty
        Private msFilterByValue As String = String.Empty

        Public ReadOnly Property ShowInactiveTurtles() As Boolean
            Get
                Return mbShowInactiveTurtles
            End Get
        End Property

        Public ReadOnly Property FilterByType() As String
            Get
                Return msFilterByType
            End Get
        End Property

        Public ReadOnly Property FilterByValue() As String
            Get
                Return msFilterByValue
            End Get
        End Property

        Public Sub New(Optional ByVal bShowInactiveTurtles As Boolean = False, Optional ByVal sFilterByType As String = "", Optional ByVal sFilterByValue As String = "")
            mbShowInactiveTurtles = bShowInactiveTurtles
            msFilterByType = sFilterByType
            msFilterByValue = sFilterByValue
        End Sub

    End Class

    <Serializable()> _
    Private Class CriteriaByDatesInFacilityRange

        Private mdtDateFrom As Date
        Private mdtDateThru As Date

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

        Public Sub New(ByVal dtDateFrom As Date, ByVal dtDateThru As Date)
            mdtDateFrom = dtDateFrom
            mdtDateThru = dtDateThru
        End Sub

    End Class

    <Serializable()> _
    Private Class CriteriaByDateRange

        Private meLoadDateRangeType As LoadDateRangeType
        Private mbIncludeNonRelinquishedTurtles As Boolean
        Private mdtDateFrom As Date
        Private mdtDateThru As Date

        Public Property LoadDateRangeType() As LoadDateRangeType
            Get
                Return meLoadDateRangeType
            End Get
            Set(ByVal Value As LoadDateRangeType)
                meLoadDateRangeType = Value
            End Set
        End Property

        Public Property IncludeNonRelinquishedTurtles() As Boolean
            Get
                Return mbIncludeNonRelinquishedTurtles
            End Get
            Set(ByVal Value As Boolean)
                mbIncludeNonRelinquishedTurtles = Value
            End Set
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

        Public Sub New(ByVal eLoadDateRangeType As LoadDateRangeType, ByVal bIncludeNonRelinquishedTurtles As Boolean, ByVal dtDateFrom As Date, ByVal dtDateThru As Date)
            meLoadDateRangeType = eLoadDateRangeType
            mbIncludeNonRelinquishedTurtles = bIncludeNonRelinquishedTurtles
            mdtDateFrom = dtDateFrom
            mdtDateThru = dtDateThru
        End Sub

    End Class

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteriaObject As Object)

        Dim s As String = String.Empty
        Dim sTagNumberListString As String = String.Empty
        Dim oCriteriaBySearchOptions As CriteriaBySearchOptions
        Dim oCriteriaByDatesInFacilityRange As CriteriaByDatesInFacilityRange
        Dim oCriteriaByDateRange As CriteriaByDateRange
        Dim oTempTurtleListItem As TurtleListItem

        RaiseListChangedEvents = False

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()

                Using cm As IDbCommand = cn.CreateCommand()

                    If (TypeOf oCriteriaObject Is CriteriaByDatesInFacilityRange) Then

                        oCriteriaByDatesInFacilityRange = DirectCast(oCriteriaObject, CriteriaByDatesInFacilityRange)

                        s = "SELECT * FROM turtle "
                        s &= "WHERE (date_acquired IS NOT NULL) AND (date_acquired <= @date_thru) "
                        s &= "AND ((date_relinquished IS NULL) OR ((date_relinquished IS NOT NULL) AND (@date_from <= date_relinquished)) ) "
                        s &= "ORDER BY sid_number, date_acquired, turtle_name "

                        cm.Parameters.Add(oAdoHelper.GetParameter("@date_thru", oCriteriaByDatesInFacilityRange.DateThru))
                        cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteriaByDatesInFacilityRange.DateFrom))

                    ElseIf (TypeOf oCriteriaObject Is CriteriaByDateRange) Then

                        oCriteriaByDateRange = DirectCast(oCriteriaObject, CriteriaByDateRange)

                        '----------------------------------------------------------------
                        '-- if option is DATE TAGGED
                        '----------------------------------------------------------------
                        If (oCriteriaByDateRange.LoadDateRangeType = LoadDateRangeType.DateTagged) Then

                            s = "SELECT DISTINCT turtle.* FROM turtle, turtle_tag "
                            s &= "WHERE turtle_tag.turtle_id = turtle.turtle_id "
                            s &= "AND ((turtle_tag.date_tagged IS NOT NULL) AND (turtle_tag.date_tagged <= @date_thru) AND (@date_from <= turtle_tag.date_tagged))  "
                            s &= "ORDER BY turtle_tag.date_tagged, turtle.sid_number, turtle.turtle_name "

                            cm.Parameters.Add(oAdoHelper.GetParameter("@date_thru", oCriteriaByDateRange.DateThru))
                            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteriaByDateRange.DateFrom))

                        Else

                            '----------------------------------------------------------------
                            '-- else option is DATE ACQUIRED -or- DATE RELINQUISHED
                            '----------------------------------------------------------------
                            s = "SELECT * FROM turtle "

                            If (oCriteriaByDateRange.LoadDateRangeType = LoadDateRangeType.DateAcquired) Then
                                s &= "WHERE ((date_acquired IS NULL) OR ((date_acquired IS NOT NULL) AND (@date_from <= date_acquired) AND (date_acquired <= @date_thru)) ) "
                            Else 'If (eLoadDateRangeType = LoadDateRangeType.DateRelinquished) Then
                                '----------------------------------------------------------------
                                '-- include/excluded relinquished turtles
                                '----------------------------------------------------------------
                                If oCriteriaByDateRange.IncludeNonRelinquishedTurtles Then
                                    s &= "WHERE ((date_relinquished IS NULL) OR ((date_relinquished IS NOT NULL) AND (@date_from <= date_relinquished) AND (date_relinquished <= @date_thru)) ) "
                                Else
                                    s &= "WHERE ( ((date_relinquished IS NOT NULL) AND (@date_from <= date_relinquished) AND (date_relinquished <= @date_thru)) ) "
                                End If
                            End If

                            If (oCriteriaByDateRange.LoadDateRangeType = LoadDateRangeType.DateAcquired) Then
                                s &= "ORDER BY date_acquired, sid_number, turtle_name "
                            Else 'If (eLoadDateRangeType = LoadDateRangeType.DateRelinquished) Then
                                s &= "ORDER BY date_relinquished, sid_number, turtle_name "
                            End If

                            cm.Parameters.Add(oAdoHelper.GetParameter("@date_from", oCriteriaByDateRange.DateFrom))
                            cm.Parameters.Add(oAdoHelper.GetParameter("@date_thru", oCriteriaByDateRange.DateThru))

                        End If

                    ElseIf (TypeOf oCriteriaObject Is CriteriaBySearchOptions) Then

                        oCriteriaBySearchOptions = DirectCast(oCriteriaObject, CriteriaBySearchOptions)

                        s = "SELECT * FROM turtle "
                        s &= "WHERE 1 = 1 "

                        If Not oCriteriaBySearchOptions.ShowInactiveTurtles Then
                            s &= "AND date_relinquished IS NULL "
                        End If

                        If Not (oCriteriaBySearchOptions.FilterByType Is Nothing) AndAlso Not (oCriteriaBySearchOptions.FilterByType.Trim.Length = 0) Then
                            If Not (oCriteriaBySearchOptions.FilterByValue Is Nothing) AndAlso Not (oCriteriaBySearchOptions.FilterByValue.Trim.Length = 0) Then
                                Select Case oCriteriaBySearchOptions.FilterByType.Trim.ToLower
                                    Case "name"
                                        s &= "AND " & oAdoHelper.UpperFunction & "(turtle_name) LIKE " & oAdoHelper.UpperFunction & "('%" & oCriteriaBySearchOptions.FilterByValue.Trim & "%') "
                                    Case "sid"
                                        s &= "AND " & oAdoHelper.UpperFunction & "(sid_number) LIKE " & oAdoHelper.UpperFunction & "('%" & oCriteriaBySearchOptions.FilterByValue.Trim & "%') "
                                    Case "strandingid"
                                        s &= "AND " & oAdoHelper.UpperFunction & "(stranding_id_number) LIKE " & oAdoHelper.UpperFunction & "('%" & oCriteriaBySearchOptions.FilterByValue.Trim & "%') "
                                    Case "tag"
                                        s &= "AND turtle_id IN ( SELECT turtle_id FROM turtle_tag WHERE " & oAdoHelper.UpperFunction & "(tag_number) LIKE " & oAdoHelper.UpperFunction & "('%" & oCriteriaBySearchOptions.FilterByValue.Trim & "%') ) "
                                End Select
                            End If
                        End If

                        s &= "ORDER BY sid_number, date_acquired, turtle_name "

                    Else

                        s = String.Empty

                    End If

                    If Not String.IsNullOrEmpty(s) Then

                        cm.CommandText = s
                        cm.CommandType = CommandType.Text

                        Using dr As SafeDataReader = oAdoHelper.ExecuteReader(cm)

                            While dr.Read()

                                Me.Add(New TurtleListItem(dr.GetString("turtle_id"), dr.GetString("turtle_name"), dr.GetString("sid_number"), dr.GetString("stranding_id_number"), dr.GetString("species"), dr.GetDateTime("date_acquired"), dr.GetString("acquired_from"), dr.GetString("acquired_county"), dr.GetString("turtle_size"), dr.GetString("status"), dr.GetDateTime("date_relinquished"), dr.GetString("relinquished_to"), String.Empty))

                            End While

                        End Using ' dr

                    End If

                End Using ' cm

            End Using ' cn 

        End Using ' oAdoHelper

        '----------------------------------------------------------------
        '-- for the main screen turtle grid, 
        '-- get the list of tag numbers for each turtle
        '----------------------------------------------------------------
        If (TypeOf oCriteriaObject Is CriteriaBySearchOptions) Then

            For Each oTempTurtleListItem In Me

                sTagNumberListString = String.Empty

                Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

                    Using cn As IDbConnection = oAdoHelper.GetConnection()

                        cn.Open()

                        Using cm As IDbCommand = cn.CreateCommand()

                            s = "SELECT tag_number FROM turtle_tag "
                            s &= "WHERE turtle_id = @turtle_id "

                            cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_id", oTempTurtleListItem.TurtleID))

                            cm.CommandText = s
                            cm.CommandType = CommandType.Text

                            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(cm)

                                While dr.Read()

                                    If Not String.IsNullOrEmpty(sTagNumberListString) Then
                                        sTagNumberListString &= ", "
                                    End If

                                    sTagNumberListString &= dr.GetString("tag_number")

                                End While

                            End Using ' dr

                        End Using ' cm

                    End Using ' cn 

                End Using ' oAdoHelper

                oTempTurtleListItem.TagNumberListString = sTagNumberListString

            Next

        End If

        RaiseListChangedEvents = True

    End Sub

#End Region

End Class
