Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class Tank
    Inherits BusinessBase(Of Tank)

#Region " Business Methods "

    Private msTankID As String = String.Empty
    Private msTankName As String = String.Empty
    Private moTankWaters As TankWaters = TankWaters.NewTankWaters()

    Public ReadOnly Property TankID() As String
        Get
            Return msTankID
        End Get
    End Property

    Public Property TankName() As String
        Get
            Return msTankName
        End Get
        Set(ByVal Value As String)
            If msTankName <> Value Then
                msTankName = Value
                PropertyHasChanged("TankName")
            End If
        End Set
    End Property

    Public ReadOnly Property TankWaters() As TankWaters
        Get
            Return moTankWaters
        End Get
    End Property

    Public Overrides ReadOnly Property IsValid() As Boolean
        Get
            Return MyBase.IsValid AndAlso moTankWaters.IsValid
        End Get
    End Property

    Public Overrides ReadOnly Property IsDirty() As Boolean
        Get
            Return MyBase.IsDirty OrElse moTankWaters.IsDirty
        End Get
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return msTankID
    End Function

    Public Function GetBrokenRulesString() As String

        Dim s As String = String.Empty

        s &= Me.BrokenRulesCollection.ToString

        If moTankWaters IsNot Nothing Then
            s &= moTankWaters.GetBrokenRulesString
        End If

        Return s

    End Function

#End Region

#Region " Validation Rules "

    Protected Overrides Sub AddBusinessRules()

        ValidationRules.AddRule(AddressOf Validation.CommonRules.StringRequired, New Validation.RuleArgs("TankName", "Tank Name"))
        ValidationRules.AddRule(AddressOf Validation.CommonRules.StringMaxLength, New Validation.CommonRules.MaxLengthRuleArgs("TankName", "Tank Name", 255))

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

    Public Shared Function NewTank() As Tank

        Dim oTank As Tank
        oTank = DataPortal.Create(Of Tank)()
        oTank.MarkClean()
        Return oTank

        'Return DataPortal.Create(Of Tank)()

    End Function

    Public Shared Function GetTank(ByVal sTankId As String) As Tank

        Return DataPortal.Fetch(Of Tank)(New Criteria(sTankId))

    End Function

    Public Shared Sub DeleteTank(ByVal sTankId As String)

        DataPortal.Delete(New Criteria(sTankId))

    End Sub

    Public Overrides Function Save() As Tank

        Return MyBase.Save

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class Criteria

        Private msTankId As String
        Public ReadOnly Property TankId() As String
            Get
                Return msTankID
            End Get
        End Property

        Public Sub New(ByVal sTankId As String)
            msTankID = sTankId
        End Sub
    End Class

    <RunLocal()> _
    Protected Overrides Sub DataPortal_Create()

        msTankID = Guid.NewGuid.ToString.ToUpper
        msTankName = String.Empty

        moTankWaters = TankWaters.NewTankWaters()

        ValidationRules.CheckRules()

        'v-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew
        'MarkClean()
        '^-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew

    End Sub

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteria As Criteria)

        Dim s As String = String.Empty

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            '----------------------------------------------------------------
            '-- get data for root object -- TANK
            '----------------------------------------------------------------
            s = "SELECT * FROM tank "
            s &= "WHERE " & oAdoHelper.UpperFunction & "(tank_id) = " & oAdoHelper.UpperFunction & "(@tank_id) "

            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(CommandType.Text, s, oAdoHelper.GetParameter("@tank_id", oCriteria.TankId))

                If dr.Read() Then

                    With dr
                        msTankID = .GetString("tank_id").Trim.ToUpper
                        msTankName = .GetString("tank_name")
                    End With

                End If

            End Using

            '----------------------------------------------------------------
            '-- get data for children -- TANK WATERS
            '----------------------------------------------------------------
            s = "SELECT * FROM tank_water "
            s &= "WHERE " & oAdoHelper.UpperFunction & "(tank_id) = " & oAdoHelper.UpperFunction & "(@tank_id) "

            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(CommandType.Text, s, oAdoHelper.GetParameter("@tank_id", oCriteria.TankId))

                moTankWaters = TankWaters.GetTankWaters(dr)

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

                        s = "INSERT INTO tank ("
                        s &= "tank_name, "
                        s &= "tank_id "
                        s &= ") VALUES ("
                        s &= "@tank_name, "
                        s &= "@tank_id "
                        s &= ")"

                        cm.CommandText = s
                        DoInsertUpdate(cm)

                    End Using ' cm

                    ' update child objects
                    moTankWaters.Update(Me)

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

                            s = "UPDATE tank SET "
                            s &= "tank_name = @tank_name "
                            s &= "WHERE " & oAdoHelper.UpperFunction & "(tank_id) = " & oAdoHelper.UpperFunction & "(@tank_id) "

                            cm.CommandText = s
                            DoInsertUpdate(cm)

                        End Using ' cm

                    End If

                    ' update child objects
                    moTankWaters.Update(Me)

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
                .Parameters.Add(oAdoHelper.GetParameter("@tank_name", msTankName))
                .Parameters.Add(oAdoHelper.GetParameter("@tank_id", msTankID.ToUpper))
                oAdoHelper.ExecuteNonQuery(cm)
            End With
        End Using

    End Sub

    Protected Overrides Sub DataPortal_DeleteSelf()

        DataPortal_Delete(New Criteria(msTankID))

    End Sub

    Private Overloads Sub DataPortal_Delete(ByVal oCriteria As Criteria)

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()

                Using ts As TransactionScope = New TransactionScope()

                    Using cm As IDbCommand = cn.CreateCommand()

                        '----------------------------------------------------------------
                        '-- cascade the deletion to the child items
                        '----------------------------------------------------------------
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "DELETE FROM tank_water WHERE " & oAdoHelper.UpperFunction & "(tank_id) = " & oAdoHelper.UpperFunction & "(@tank_id)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@tank_id", oCriteria.TankId))

                        oAdoHelper.ExecuteNonQuery(cm)

                        '----------------------------------------------------------------
                        '-- finally, delete the root record
                        '----------------------------------------------------------------
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "DELETE FROM tank WHERE " & oAdoHelper.UpperFunction & "(tank_id) = " & oAdoHelper.UpperFunction & "(@tank_id)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@tank_id", oCriteria.TankId))

                        oAdoHelper.ExecuteNonQuery(cm)

                    End Using ' cm

                End Using ' ts

            End Using ' cn

        End Using ' oAdoHelper

    End Sub

#End Region

#Region " Exists "

    Public Shared Function Exists(ByVal sTankId As String) As Boolean

        Dim oExistsCommand As ExistsCommand

        oExistsCommand = DataPortal.Execute(Of ExistsCommand)(New ExistsCommand(sTankId))

        Return oExistsCommand.Exists

    End Function

    <Serializable()> _
    Private Class ExistsCommand
        Inherits CommandBase

        Private msTankId As String
        Private mbExists As Boolean

        Public ReadOnly Property Exists() As Boolean
            Get
                Return mbExists
            End Get
        End Property

        Public Sub New(ByVal sTankId As String)
            msTankID = sTankId
        End Sub

        Protected Overrides Sub DataPortal_Execute()

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                Using cn As IDbConnection = oAdoHelper.GetConnection()
                    cn.Open()
                    Using cm As IDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "SELECT tank_id FROM tank WHERE " & oAdoHelper.UpperFunction & "(tank_id) = " & oAdoHelper.UpperFunction & "(@tank_id)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@tank_id", msTankId))
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
