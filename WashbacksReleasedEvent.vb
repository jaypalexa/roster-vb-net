Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class WashbacksReleasedEvent
    Inherits BusinessBase(Of WashbacksReleasedEvent)

#Region " Business Methods "

    Private msWashbacksReleasedEventID As String = String.Empty
    Private msSpeciesCode As String = String.Empty
    Private mdtEventDate As Date = DateTime.MinValue
    Private miBeachEventCount As Integer = 0
    Private miOffshoreEventCount As Integer = 0

    Public ReadOnly Property WashbacksReleasedEventID() As String
        Get
            Return msWashbacksReleasedEventID
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

    Public Property BeachEventCount() As Integer
        Get
            Return miBeachEventCount
        End Get
        Set(ByVal Value As Integer)
            If miBeachEventCount <> Value Then
                miBeachEventCount = Value
                PropertyHasChanged("BeachEventCount")
            End If
        End Set
    End Property

    Public Property OffshoreEventCount() As Integer
        Get
            Return miOffshoreEventCount
        End Get
        Set(ByVal Value As Integer)
            If miOffshoreEventCount <> Value Then
                miOffshoreEventCount = Value
                PropertyHasChanged("OffshoreEventCount")
            End If
        End Set
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return msWashbacksReleasedEventID
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

        oRuleArgs = New Validation.RuleArgs("BeachEventCount")
        oRuleArgs.Description = "Beach event count value must be a positive whole number"
        ValidationRules.AddRule(AddressOf IntegerValueRequired, oRuleArgs)

        oRuleArgs = New Validation.RuleArgs("OffshoreEventCount")
        oRuleArgs.Description = "Offshore event count value must be a positive whole number"
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

    Public Shared Function NewWashbacksReleasedEvent() As WashbacksReleasedEvent

        Dim oWashbacksReleasedEvent As WashbacksReleasedEvent
        oWashbacksReleasedEvent = DataPortal.Create(Of WashbacksReleasedEvent)()
        oWashbacksReleasedEvent.MarkClean()
        Return oWashbacksReleasedEvent

        'Return DataPortal.Create(Of WashbacksReleasedEvent)()

    End Function

    Public Shared Function GetWashbacksReleasedEvent(ByVal sWashbacksReleasedEventId As String) As WashbacksReleasedEvent

        Return DataPortal.Fetch(Of WashbacksReleasedEvent)(New Criteria(sWashbacksReleasedEventId))

    End Function

    Public Shared Sub DeleteWashbacksReleasedEvent(ByVal sWashbacksReleasedEventId As String)

        DataPortal.Delete(New Criteria(sWashbacksReleasedEventId))

    End Sub

    Public Overrides Function Save() As WashbacksReleasedEvent

        Return MyBase.Save

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class Criteria

        Private msWashbacksReleasedEventId As String
        Public ReadOnly Property WashbacksReleasedEventId() As String
            Get
                Return msWashbacksReleasedEventId
            End Get
        End Property

        Public Sub New(ByVal sWashbacksReleasedEventId As String)
            msWashbacksReleasedEventId = sWashbacksReleasedEventId
        End Sub
    End Class

    <RunLocal()> _
    Protected Overrides Sub DataPortal_Create()

        msWashbacksReleasedEventID = Guid.NewGuid.ToString.ToUpper
        msSpeciesCode = "XX"
        mdtEventDate = New DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
        miBeachEventCount = 0

        ValidationRules.CheckRules()

        'v-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew
        'MarkClean()
        '^-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew

    End Sub

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteria As Criteria)

        Dim s As String = String.Empty

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            s = "SELECT * FROM washbacks_released_event "
            s &= "WHERE " & oAdoHelper.UpperFunction & "(washbacks_released_event_id) = " & oAdoHelper.UpperFunction & "(@washbacks_released_event_id) "

            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(CommandType.Text, s, oAdoHelper.GetParameter("@washbacks_released_event_id", oCriteria.WashbacksReleasedEventId))

                If dr.Read() Then

                    With dr
                        msWashbacksReleasedEventID = .GetString("washbacks_released_event_id").Trim.ToUpper
                        msSpeciesCode = .GetString("species_code").Trim.ToUpper
                        mdtEventDate = dr.GetDateTime("event_date")
                        miBeachEventCount = dr.GetInt32("beach_event_count")
                        miOffshoreEventCount = dr.GetInt32("offshore_event_count")
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

                        s &= "INSERT INTO washbacks_released_event ("
                        s &= "species_code, event_date, beach_event_count, offshore_event_count, "
                        s &= "washbacks_released_event_id "
                        s &= ") VALUES ("
                        s &= "@species_code, @event_date, @beach_event_count, @offshore_event_count, "
                        s &= "@washbacks_released_event_id "
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

                            s &= "UPDATE washbacks_released_event SET "
                            s &= "event_date = @event_date, "
                            s &= "beach_event_count = @beach_event_count, "
                            s &= "offshore_event_count = @offshore_event_count "
                            s &= "WHERE " & oAdoHelper.UpperFunction & "(washbacks_released_event_id) = " & oAdoHelper.UpperFunction & "(@washbacks_released_event_id) "

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
                .Parameters.Add(oAdoHelper.GetParameter("@beach_event_count", miBeachEventCount))
                .Parameters.Add(oAdoHelper.GetParameter("@offshore_event_count", miOffshoreEventCount))
                .Parameters.Add(oAdoHelper.GetParameter("@washbacks_released_event_id", msWashbacksReleasedEventID))
                oAdoHelper.ExecuteNonQuery(cm)
            End With
        End Using

    End Sub

    Protected Overrides Sub DataPortal_DeleteSelf()

        DataPortal_Delete(New Criteria(msWashbacksReleasedEventID))

    End Sub

    Private Overloads Sub DataPortal_Delete(ByVal oCriteria As Criteria)

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()

                Using ts As TransactionScope = New TransactionScope()

                    Using cm As IDbCommand = cn.CreateCommand()

                        cm.CommandType = CommandType.Text
                        cm.CommandText = "DELETE FROM washbacks_released_event WHERE " & oAdoHelper.UpperFunction & "(washbacks_released_event_id) = " & oAdoHelper.UpperFunction & "(@washbacks_released_event_id)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@washbacks_released_event_id", oCriteria.WashbacksReleasedEventId.ToUpper))
                        oAdoHelper.ExecuteNonQuery(cm)

                    End Using ' cm

                End Using ' ts

            End Using ' cn

        End Using ' oAdoHelper

    End Sub

#End Region

#Region " Exists "

    Public Shared Function Exists(ByVal sWashbacksReleasedEventId As String) As Boolean

        Dim oExistsCommand As ExistsCommand

        oExistsCommand = DataPortal.Execute(Of ExistsCommand)(New ExistsCommand(sWashbacksReleasedEventId))

        Return oExistsCommand.Exists

    End Function

    <Serializable()> _
    Private Class ExistsCommand
        Inherits CommandBase

        Private msWashbacksReleasedEventId As String
        Private mbExists As Boolean

        Public ReadOnly Property Exists() As Boolean
            Get
                Return mbExists
            End Get
        End Property

        Public Sub New(ByVal sWashbacksReleasedEventId As String)
            msWashbacksReleasedEventID = sWashbacksReleasedEventId
        End Sub

        Protected Overrides Sub DataPortal_Execute()

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                Using cn As IDbConnection = oAdoHelper.GetConnection()
                    cn.Open()
                    Using cm As IDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "SELECT washbacks_released_event_id FROM washbacks_released_event WHERE " & oAdoHelper.UpperFunction & "(washbacks_released_event_id) = " & oAdoHelper.UpperFunction & "(@washbacks_released_event_id)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@washbacks_released_event_id", msWashbacksReleasedEventId))
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
