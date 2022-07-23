Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class TankWater
    Inherits BusinessBase(Of TankWater)

#Region " Business Methods "

    Private msTankWaterID As String = String.Empty
    Private msTemperature As String = String.Empty
    Private msSalinity As String = String.Empty
    Private msPh As String = String.Empty
    Private mdtDateMeasured As Date = DateTime.MinValue

    Public ReadOnly Property EditAction() As String
        Get
            '-- for use in data grid columns
            Return "edit"
        End Get
    End Property

    Public ReadOnly Property DeleteAction() As String
        Get
            '-- for use in data grid columns
            Return "delete"
        End Get
    End Property

    Public Property TankWaterID() As String
        Get
            Return msTankWaterID
        End Get
        Set(ByVal Value As String)
            If msTankWaterID <> Value Then
                msTankWaterID = Value
                PropertyHasChanged("TankWaterID")
            End If
        End Set
    End Property

    Public Property Temperature() As String
        Get
            Return msTemperature
        End Get
        Set(ByVal Value As String)
            If msTemperature <> Value Then
                msTemperature = Value
                PropertyHasChanged("Temperature")
            End If
        End Set
    End Property

    Public Property Salinity() As String
        Get
            Return msSalinity
        End Get
        Set(ByVal Value As String)
            If msSalinity <> Value Then
                msSalinity = Value
                PropertyHasChanged("Salinity")
            End If
        End Set
    End Property

    Public Property Ph() As String
        Get
            Return msPh
        End Get
        Set(ByVal Value As String)
            If msPh <> Value Then
                msPh = Value
                PropertyHasChanged("Ph")
            End If
        End Set
    End Property

    Public Property DateMeasured() As Date
        Get
            Return DateAtMidnight(mdtDateMeasured)
        End Get
        Set(ByVal Value As Date)
            If HasDateValueChanged(mdtDateMeasured, Value) Then
                mdtDateMeasured = Value
                PropertyHasChanged("DateMeasured")
            End If
        End Set
    End Property

    Public ReadOnly Property DateMeasuredString() As String
        Get
            Return DateAsString(mdtDateMeasured)
        End Get
    End Property

    Public ReadOnly Property DateMeasuredBindable() As Nullable(Of DateTime)
        Get
            Return DateAsNullableDate(mdtDateMeasured)
        End Get
    End Property

    Protected Overrides Function GetIdValue() As Object

        Return msTankWaterID

    End Function

    Public Function GetBrokenRulesString() As String

        Dim s As String = String.Empty

        s &= Me.BrokenRulesCollection.ToString

        'If moMorphometrics IsNot Nothing Then
        '    s &= moMorphometrics.GetBrokenRulesString
        'End If

        Return s

    End Function

#End Region

#Region " Validation Rules "

    Protected Overrides Sub AddBusinessRules()

    End Sub

#End Region

#Region " Authorization Rules "

    Protected Overrides Sub AddAuthorizationRules()

    End Sub

#End Region

#Region " Factory Methods "

    Friend Shared Function NewTankWater() As TankWater

        Dim oTankWater As TankWater
        oTankWater = DataPortal.Create(Of TankWater)()
        oTankWater.MarkClean()
        Return oTankWater

        'Return New TankWater()

    End Function

    Friend Shared Function GetTankWater(ByVal dr As SafeDataReader) As TankWater

        Return New TankWater(dr)

    End Function

    Private Sub New()

        MarkAsChild()

    End Sub

    Private Sub New(ByVal dr As SafeDataReader)

        MarkAsChild()
        Fetch(dr)

    End Sub

#End Region

#Region " Data Access "

    <RunLocal()> _
    Protected Overrides Sub DataPortal_Create()

        msTankWaterID = Guid.NewGuid.ToString.ToUpper
        msTemperature = String.Empty
        msSalinity = String.Empty
        msPh = String.Empty
        mdtDateMeasured = New Date(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)

        ValidationRules.CheckRules()

        ''v-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew
        ''MarkClean()
        ''^-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew

    End Sub

    Private Sub Fetch(ByVal dr As SafeDataReader)

        With dr
            msTankWaterID = dr.GetString("tank_water_id")
            msTemperature = dr.GetString("temperature")
            msSalinity = dr.GetString("salinity")
            msPh = dr.GetString("ph")
            mdtDateMeasured = dr.GetDateTime("date_measured")
        End With

        MarkOld()

    End Sub

    Friend Sub Insert(ByVal oTank As Tank)

        ' if we're not dirty then don't update the database
        If Not Me.IsDirty Then Exit Sub

        Dim s As String = String.Empty
        Dim cn As IDbConnection = CType(Csla.ApplicationContext.LocalContext("cn"), IDbConnection)

        Using cm As IDbCommand = cn.CreateCommand()
            s &= "INSERT INTO tank_water ("
            s &= "tank_id, temperature, salinity, ph, date_measured, tank_water_id "
            s &= ") VALUES ("
            s &= "@tank_id, @temperature, @salinity, @ph, @date_measured, @tank_water_id "
            s &= ")"
            cm.CommandText = s
            DoInsertUpdate(cm, oTank.TankID)
        End Using

        MarkOld()

    End Sub

    Friend Sub Update(ByVal oTank As Tank)

        ' if we're not dirty then don't update the database
        If Not Me.IsDirty Then Exit Sub

        Dim s As String = String.Empty
        Dim cn As IDbConnection = CType(Csla.ApplicationContext.LocalContext("cn"), IDbConnection)

        Using cm As IDbCommand = cn.CreateCommand()
            s &= "UPDATE tank_water SET "
            s &= "tank_id = @tank_id, "
            s &= "temperature = @temperature, "
            s &= "salinity = @salinity, "
            s &= "ph = @ph, "
            s &= "date_measured = @date_measured "
            s &= "WHERE tank_water_id = @tank_water_id "
            cm.CommandText = s
            DoInsertUpdate(cm, oTank.TankID)
        End Using

        MarkOld()

    End Sub

    Private Sub DoInsertUpdate(ByVal cm As IDbCommand, ByVal sTankId As String)

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            With cm

                .CommandType = CommandType.Text
                .Parameters.Add(oAdoHelper.GetParameter("@tank_id", sTankId.ToUpper))
                .Parameters.Add(oAdoHelper.GetParameter("@temperature", Val(msTemperature).ToString))
                .Parameters.Add(oAdoHelper.GetParameter("@salinity", Val(msSalinity).ToString))
                .Parameters.Add(oAdoHelper.GetParameter("@ph", Val(msPh).ToString))
                .Parameters.Add(oAdoHelper.GetParameter("@date_measured", AdoHelper.DbSetDate(mdtDateMeasured)))
                .Parameters.Add(oAdoHelper.GetParameter("@tank_water_id", msTankWaterID))
                oAdoHelper.ExecuteNonQuery(cm)

            End With ' cm

        End Using ' oAdoHelper

    End Sub

    Friend Sub DeleteSelf()

        ' if we're not dirty then don't update the database
        If Not Me.IsDirty Then Exit Sub

        ' if we're new then don't update the database
        If Me.IsNew Then Exit Sub

        Dim cn As IDbConnection = CType(Csla.ApplicationContext.LocalContext("cn"), IDbConnection)

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cm As IDbCommand = cn.CreateCommand()
                cm.CommandText = "DELETE FROM tank_water WHERE " & oAdoHelper.UpperFunction & "(tank_water_id) = " & oAdoHelper.UpperFunction & "(@tank_water_id) "
                cm.CommandType = CommandType.Text
                cm.Parameters.Add(oAdoHelper.GetParameter("@tank_water_id", msTankWaterID.ToUpper))
                oAdoHelper.ExecuteNonQuery(cm)
            End Using ' cm 

        End Using ' oAdoHelper

        MarkNew()

    End Sub

#End Region

#Region " Exists "

    Public Shared Function Exists(ByVal sTankWaterId As String) As Boolean

        Dim oExistsCommand As ExistsCommand

        oExistsCommand = DataPortal.Execute(Of ExistsCommand)(New ExistsCommand(sTankWaterId))

        Return oExistsCommand.Exists

    End Function

    <Serializable()> _
    Private Class ExistsCommand
        Inherits CommandBase

        Private msTankWaterId As String
        Private mbExists As Boolean

        Public ReadOnly Property Exists() As Boolean
            Get
                Return mbExists
            End Get
        End Property

        Public Sub New(ByVal sTankWaterId As String)
            msTankWaterID = sTankWaterId
        End Sub

        Protected Overrides Sub DataPortal_Execute()

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                Using cn As IDbConnection = oAdoHelper.GetConnection()
                    cn.Open()
                    Using cm As IDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "SELECT tank_water_id FROM tank_water WHERE " & oAdoHelper.UpperFunction & "(tank_water_id) = " & oAdoHelper.UpperFunction & "(@tank_water_id) "
                        cm.Parameters.Add(oAdoHelper.GetParameter("@tank_water_id", msTankWaterId.ToUpper))
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
