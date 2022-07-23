Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class WashbacksDoaEvent
    Inherits BusinessBase(Of WashbacksDoaEvent)

#Region " Business Methods "

    Private msWashbacksDoaEventID As String = String.Empty
    Private msSpeciesCode As String = String.Empty
    Private mdtEventDate As Date = DateTime.MinValue
    Private miEventCount As Integer = 0
    Private msDoaFromCounty As String = String.Empty
    Private mbUnder5CmClsl As Boolean = False

    Public ReadOnly Property WashbacksDoaEventID() As String
        Get
            Return msWashbacksDoaEventID
        End Get
    End Property

    Public Property SpeciesCode() As String
        Get
            Return msSpeciesCode
        End Get
        Set(ByVal Value As String)
            If msSpeciesCode <> Value Then
                msSpeciesCode = Value
                PropertyHasChanged("SpeciesCode")
            End If
        End Set
    End Property

    Public Property EventDate() As Date
        Get
            Return DateAtMidnight(mdtEventDate)
        End Get
        Set(ByVal Value As Date)
            If HasDateValueChanged(mdtEventDate, Value) Then
                mdtEventDate = Value
                PropertyHasChanged("EventDate")
            End If
        End Set
    End Property

    Public ReadOnly Property EventDateString() As String
        Get
            Return DateAsString(mdtEventDate)
        End Get
    End Property

    Public Property EventCount() As Integer
        Get
            Return miEventCount
        End Get
        Set(ByVal Value As Integer)
            If miEventCount <> Value Then
                miEventCount = Value
                PropertyHasChanged("EventCount")
            End If
        End Set
    End Property

    Public Property DoaFromCounty() As String
        Get
            Return msDoaFromCounty
        End Get
        Set(ByVal Value As String)
            If msDoaFromCounty <> Value Then
                msDoaFromCounty = Value
                PropertyHasChanged("DoaFromCounty")
            End If
        End Set
    End Property

    Public Property Under5CmClsl() As Boolean
        Get
            Return mbUnder5CmClsl
        End Get
        Set(ByVal Value As Boolean)
            If mbUnder5CmClsl <> Value Then
                mbUnder5CmClsl = Value
                PropertyHasChanged("Under5CmClsl")
            End If
        End Set
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return msWashbacksDoaEventID
    End Function

    Public Function GetBrokenRulesString() As String

        Dim s As String = String.Empty

        s &= Me.BrokenRulesCollection.ToString

        Return s

    End Function

#End Region

#Region " Validation Rules "

    Protected Overrides Sub AddBusinessRules()

        Dim oRuleArgs As Validation.RuleArgs

        oRuleArgs = New Validation.RuleArgs("EventCount")
        oRuleArgs.Description = "Event count value must be a positive whole number"
        ValidationRules.AddRule(AddressOf IntegerValueRequired, oRuleArgs)

    End Sub

#End Region

#Region " Authorization Rules "

    Protected Overrides Sub AddAuthorizationRules()

        ' add AuthorizationRules here

    End Sub

    Public Shared Function CanAddObject() As Boolean

        Return True

    End Function

    Public Shared Function CanGetObject() As Boolean

        Return True

    End Function

    Public Shared Function CanDeleteObject() As Boolean

        Return True

    End Function

    Public Shared Function CanEditObject() As Boolean

        Return True

    End Function

#End Region

#Region " Factory Methods "

    Public Shared Function NewWashbacksDoaEvent() As WashbacksDoaEvent

        Dim oWashbacksDoaEvent As WashbacksDoaEvent
        oWashbacksDoaEvent = DataPortal.Create(Of WashbacksDoaEvent)()
        oWashbacksDoaEvent.MarkClean()
        Return oWashbacksDoaEvent

        'Return DataPortal.Create(Of WashbacksDoaEvent)()

    End Function

    Public Shared Function GetWashbacksDoaEvent(ByVal sWashbacksDoaEventId As String) As WashbacksDoaEvent

        Return DataPortal.Fetch(Of WashbacksDoaEvent)(New Criteria(sWashbacksDoaEventId))

    End Function

    Public Shared Sub DeleteWashbacksDoaEvent(ByVal sWashbacksDoaEventId As String)

        DataPortal.Delete(New Criteria(sWashbacksDoaEventId))

    End Sub

    Public Overrides Function Save() As WashbacksDoaEvent

        Return MyBase.Save

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class Criteria

        Private msWashbacksDoaEventId As String
        Public ReadOnly Property WashbacksDoaEventId() As String
            Get
                Return msWashbacksDoaEventId
            End Get
        End Property

        Public Sub New(ByVal sWashbacksDoaEventId As String)
            msWashbacksDoaEventId = sWashbacksDoaEventId
        End Sub
    End Class

    <RunLocal()> _
    Protected Overrides Sub DataPortal_Create()

        msWashbacksDoaEventID = Guid.NewGuid.ToString.ToUpper
        msSpeciesCode = "XX"
        mdtEventDate = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
        miEventCount = 0
        msDoaFromCounty = String.Empty
        mbUnder5CmClsl = False

        ValidationRules.CheckRules()

        'v-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew
        'MarkClean()
        '^-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew

    End Sub

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteria As Criteria)

        Dim s As String = String.Empty

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            s = "SELECT * FROM washbacks_doa_event "
            s &= "WHERE " & oAdoHelper.UpperFunction & "(washbacks_doa_event_id) = " & oAdoHelper.UpperFunction & "(@washbacks_doa_event_id) "

            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(CommandType.Text, s, oAdoHelper.GetParameter("@washbacks_doa_event_id", oCriteria.WashbacksDoaEventId))

                If dr.Read() Then

                    With dr
                        msWashbacksDoaEventID = .GetString("washbacks_doa_event_id").Trim.ToUpper
                        msSpeciesCode = .GetString("species_code").Trim.ToUpper
                        mdtEventDate = dr.GetDateTime("event_date")
                        miEventCount = dr.GetInt32("event_count")
                        msDoaFromCounty = .GetString("doa_from_county")
                        mbUnder5CmClsl = dr.GetBooleanString("under_5cm_clsl")
                    End With

                End If

            End Using

        End Using

    End Sub

    Protected Overrides Sub DataPortal_Insert()

        Dim s As String = String.Empty

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()
                Csla.ApplicationContext.LocalContext("cn") = cn

                Using ts As TransactionScope = New TransactionScope()

                    Using cm As IDbCommand = cn.CreateCommand()

                        s &= "INSERT INTO washbacks_doa_event ("
                        s &= "species_code, event_date, event_count, doa_from_county, "
                        s &= "washbacks_doa_event_id, under_5cm_clsl "
                        s &= ") VALUES ("
                        s &= "@species_code, @event_date, @event_count, @doa_from_county, "
                        s &= "@washbacks_doa_event_id, @under_5cm_clsl "
                        s &= ")"

                        cm.CommandText = s
                        DoInsertUpdate(cm)

                    End Using ' cm

                    ' removing of item only needed for local data portal
                    If (Csla.ApplicationContext.ExecutionLocation = ExecutionLocations.Client) Then
                        Csla.ApplicationContext.LocalContext.Remove("cn")
                    End If

                End Using ' ts

            End Using ' cn 

        End Using ' oAdoHelper

    End Sub

    Protected Overrides Sub DataPortal_Update()

        Dim s As String = String.Empty

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()
                Csla.ApplicationContext.LocalContext("cn") = cn

                Using ts As TransactionScope = New TransactionScope()

                    If MyBase.IsDirty Then

                        Using cm As IDbCommand = cn.CreateCommand()

                            s &= "UPDATE washbacks_doa_event SET "
                            s &= "species_code = @species_code, "
                            s &= "event_date = @event_date, "
                            s &= "event_count = @event_count, "
                            s &= "doa_from_county = @doa_from_county, "
                            s &= "under_5cm_clsl = @under_5cm_clsl "
                            s &= "WHERE " & oAdoHelper.UpperFunction & "(washbacks_doa_event_id) = " & oAdoHelper.UpperFunction & "(@washbacks_doa_event_id) "

                            cm.CommandText = s
                            DoInsertUpdate(cm)

                        End Using ' cm

                    End If

                    ' removing of item only needed for local data portal
                    If (Csla.ApplicationContext.ExecutionLocation = ExecutionLocations.Client) Then
                        Csla.ApplicationContext.LocalContext.Remove("cn")
                    End If

                End Using ' ts

            End Using ' cn 

        End Using ' oAdoHelper

    End Sub

    Private Sub DoInsertUpdate(ByVal cm As IDbCommand)

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
            With cm
                .CommandType = CommandType.Text
                .Parameters.Add(oAdoHelper.GetParameter("@species_code", msSpeciesCode))
                .Parameters.Add(oAdoHelper.GetParameter("@event_date", AdoHelper.DbSetDate(mdtEventDate)))
                .Parameters.Add(oAdoHelper.GetParameter("@event_count", miEventCount))
                .Parameters.Add(oAdoHelper.GetParameter("@doa_from_county", msDoaFromCounty))
                .Parameters.Add(oAdoHelper.GetParameter("@under_5cm_clsl", AdoHelper.DbSetBooleanString(mbUnder5CmClsl)))
                .Parameters.Add(oAdoHelper.GetParameter("@washbacks_doa_event_id", msWashbacksDoaEventID))
                oAdoHelper.ExecuteNonQuery(cm)
            End With
        End Using

    End Sub

    Protected Overrides Sub DataPortal_DeleteSelf()

        DataPortal_Delete(New Criteria(msWashbacksDoaEventID))

    End Sub

    Private Overloads Sub DataPortal_Delete(ByVal oCriteria As Criteria)

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()

                Using ts As TransactionScope = New TransactionScope()

                    Using cm As IDbCommand = cn.CreateCommand()

                        cm.CommandType = CommandType.Text
                        cm.CommandText = "DELETE FROM washbacks_doa_event WHERE " & oAdoHelper.UpperFunction & "(washbacks_doa_event_id) = " & oAdoHelper.UpperFunction & "(@washbacks_doa_event_id)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@washbacks_doa_event_id", oCriteria.WashbacksDoaEventId.ToUpper))
                        oAdoHelper.ExecuteNonQuery(cm)

                    End Using ' cm

                End Using ' ts

            End Using ' cn

        End Using ' oAdoHelper

    End Sub

#End Region

#Region " Exists "

    Public Shared Function Exists(ByVal sWashbacksDoaEventId As String) As Boolean

        Dim oExistsCommand As ExistsCommand

        oExistsCommand = DataPortal.Execute(Of ExistsCommand)(New ExistsCommand(sWashbacksDoaEventId))

        Return oExistsCommand.Exists

    End Function

    <Serializable()> _
    Private Class ExistsCommand
        Inherits CommandBase

        Private msWashbacksDoaEventId As String
        Private mbExists As Boolean

        Public ReadOnly Property Exists() As Boolean
            Get
                Return mbExists
            End Get
        End Property

        Public Sub New(ByVal sWashbacksDoaEventId As String)
            msWashbacksDoaEventID = sWashbacksDoaEventId
        End Sub

        Protected Overrides Sub DataPortal_Execute()

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                Using cn As IDbConnection = oAdoHelper.GetConnection()
                    cn.Open()
                    Using cm As IDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "SELECT washbacks_doa_event_id FROM washbacks_doa_event WHERE " & oAdoHelper.UpperFunction & "(washbacks_doa_event_id) = " & oAdoHelper.UpperFunction & "(@washbacks_doa_event_id)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@washbacks_doa_event_id", msWashbacksDoaEventId))
                        mbExists = Not String.IsNullOrEmpty(Convert.ToString(oAdoHelper.ExecuteScalar(cm)))
                    End Using
                End Using
            End Using

        End Sub

    End Class

#End Region

#Region " IsModified "

    '----------------------------------------------------------------
    '-- support for determining if changes were made to the object
    '-- since a developer-specified checkpoint in time
    '----------------------------------------------------------------
    '-- (IsDirty does not suffice for this, especially when 
    '--  working with business object children....)
    '----------------------------------------------------------------

    Private mbIsModified As Boolean = False

    Public Property IsModified() As Boolean
        Get
            Return mbIsModified
        End Get
        Set(ByVal Value As Boolean)
            mbIsModified = value
        End Set
    End Property

    Private Sub Me_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles Me.PropertyChanged
        If Not String.IsNullOrEmpty(e.PropertyName) Then
            mbIsModified = True
        End If
    End Sub

#End Region

End Class
