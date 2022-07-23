Option Explicit On
Option Strict On

<Serializable()> _
Public Class County
    Inherits BusinessBase(Of County)

#Region " Business Methods "

    Private msCountyId As String = String.Empty
    Private msCountyName As String = String.Empty

    <System.ComponentModel.DataObjectField(True, True)> _
    Public ReadOnly Property CountyId() As String
        Get
            Return msCountyId
        End Get
    End Property

    Public Property CountyName() As String
        Get
            Return msCountyName
        End Get
        Set(ByVal Value As String)
            If msCountyName <> Value Then
                msCountyName = Value
                PropertyHasChanged("CountyName")
            End If
        End Set
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return msCountyId
    End Function

#End Region

#Region " Validation Rules "

    Protected Overrides Sub AddBusinessRules()

        ValidationRules.AddRule(AddressOf Validation.CommonRules.StringRequired, New Validation.RuleArgs("CountyName", "County Name"))
        ValidationRules.AddRule(AddressOf Validation.CommonRules.StringMaxLength, New Validation.CommonRules.MaxLengthRuleArgs("CountyName", "County Name", 255))

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

    Public Shared Function NewCounty() As County

        Dim oCounty As County
        oCounty = DataPortal.Create(Of County)()
        oCounty.MarkClean()
        Return oCounty

        'Return DataPortal.Create(Of County)()

    End Function

    Public Shared Function GetCounty(ByVal sCountyId As String) As County

        Return DataPortal.Fetch(Of County)(New Criteria(sCountyId))

    End Function

    Public Shared Sub DeleteCounty(ByVal sCountyId As String)

        DataPortal.Delete(New Criteria(sCountyId))

    End Sub

    Public Overrides Function Save() As County

        Return MyBase.Save

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class Criteria

        Private msCountyId As String
        Public ReadOnly Property CountyId() As String
            Get
                Return msCountyId
            End Get
        End Property

        Public Sub New(ByVal sCountyId As String)
            msCountyId = sCountyId
        End Sub
    End Class

    <RunLocal()> _
    Protected Overrides Sub DataPortal_Create()

        msCountyId = Guid.NewGuid.ToString.ToUpper
        msCountyName = String.Empty

        ValidationRules.CheckRules()

        'v-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew
        'MarkClean()
        '^-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew

    End Sub

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteria As Criteria)

        Dim s As String = String.Empty

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            '----------------------------------------------------------------
            '-- get data for root object -- PROJECT
            '----------------------------------------------------------------
            s = "SELECT * FROM county "
            s &= "WHERE " & oAdoHelper.UpperFunction & "(county_id) = " & oAdoHelper.UpperFunction & "(@county_id) "
            s &= "ORDER BY " & oAdoHelper.UpperFunction & "(county_name) "

            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(CommandType.Text, s, oAdoHelper.GetParameter("@county_id", oCriteria.CountyId))

                If dr.Read() Then

                    With dr
                        msCountyId = .GetString("county_id").Trim.ToUpper
                        msCountyName = .GetString("county_name")
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

                        s = "INSERT INTO county ("
                        s &= "county_name, "
                        s &= "county_id "
                        s &= ") VALUES ("
                        s &= "@county_name, "
                        s &= "@county_id "
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

                            s = "UPDATE county SET "
                            s &= "county_name = @county_name "
                            s &= "WHERE " & oAdoHelper.UpperFunction & "(county_id) = " & oAdoHelper.UpperFunction & "(@county_id) "

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
                .Parameters.Add(oAdoHelper.GetParameter("@county_name", msCountyName))
                .Parameters.Add(oAdoHelper.GetParameter("@county_id", msCountyId.ToUpper))
                oAdoHelper.ExecuteNonQuery(cm)
            End With
        End Using

    End Sub

    Protected Overrides Sub DataPortal_DeleteSelf()

        DataPortal_Delete(New Criteria(msCountyId))

    End Sub

    Private Overloads Sub DataPortal_Delete(ByVal oCriteria As Criteria)

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()

                Using ts As TransactionScope = New TransactionScope()

                    Using cm As IDbCommand = cn.CreateCommand()

                        '----------------------------------------------------------------
                        '-- delete the root record
                        '----------------------------------------------------------------
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "DELETE FROM county WHERE " & oAdoHelper.UpperFunction & "(county_id) = " & oAdoHelper.UpperFunction & "(@county_id)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@county_id", oCriteria.CountyId))

                        oAdoHelper.ExecuteNonQuery(cm)

                    End Using ' cm

                End Using ' ts

            End Using ' cn

        End Using ' oAdoHelper

    End Sub

#End Region

#Region " Exists "

    Public Shared Function Exists(ByVal sCountyId As String) As Boolean

        Dim oExistsCommand As ExistsCommand

        oExistsCommand = DataPortal.Execute(Of ExistsCommand)(New ExistsCommand(sCountyId))

        Return oExistsCommand.Exists

    End Function

    <Serializable()> _
    Private Class ExistsCommand
        Inherits CommandBase

        Private msCountyId As String
        Private mbExists As Boolean

        Public ReadOnly Property Exists() As Boolean
            Get
                Return mbExists
            End Get
        End Property

        Public Sub New(ByVal sCountyId As String)
            msCountyId = sCountyId
        End Sub

        Protected Overrides Sub DataPortal_Execute()

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                Using cn As IDbConnection = oAdoHelper.GetConnection()
                    cn.Open()
                    Using cm As IDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "SELECT county_id FROM county WHERE " & oAdoHelper.UpperFunction & "(county_id) = " & oAdoHelper.UpperFunction & "(@county_id)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@county_id", msCountyId))
                        mbExists = Not String.IsNullOrEmpty(Convert.ToString(oAdoHelper.ExecuteScalar(cm)))
                    End Using
                End Using
            End Using

        End Sub

    End Class

#End Region

#Region " ExistsByName "

    Public Shared Function ExistsByName(ByVal sCountyName As String) As Boolean

        Dim oExistsByNameCommand As ExistsByNameCommand

        oExistsByNameCommand = DataPortal.Execute(Of ExistsByNameCommand)(New ExistsByNameCommand(sCountyName))

        Return oExistsByNameCommand.ExistsByName

    End Function

    <Serializable()> _
    Private Class ExistsByNameCommand
        Inherits CommandBase

        Private msCountyName As String
        Private mbExistsByName As Boolean

        Public ReadOnly Property ExistsByName() As Boolean
            Get
                Return mbExistsByName
            End Get
        End Property

        Public Sub New(ByVal sCountyName As String)
            msCountyName = sCountyName
        End Sub

        Protected Overrides Sub DataPortal_Execute()

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                Using cn As IDbConnection = oAdoHelper.GetConnection()
                    cn.Open()
                    Using cm As IDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "SELECT county_name FROM county WHERE " & oAdoHelper.UpperFunction & "(county_name) = " & oAdoHelper.UpperFunction & "(@county_name)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@county_name", msCountyName))
                        mbExistsByName = Not String.IsNullOrEmpty(Convert.ToString(oAdoHelper.ExecuteScalar(cm)))
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
        Set(ByVal value As Boolean)
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
