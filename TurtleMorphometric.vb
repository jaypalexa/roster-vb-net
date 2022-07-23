Option Explicit On
Option Strict On
Option Compare Text

<Serializable()> _
Public Class TurtleMorphometric
    Inherits BusinessBase(Of TurtleMorphometric)

#Region " Business Methods "

    Private msTurtleMorphometricID As String = String.Empty
    Private mdtDateMeasured As Date = DateTime.MinValue
    Private mfSclNotchNotchValue As Double = Nothing
    Private msSclNotchNotchUnits As String = String.Empty
    Private mfSclNotchTipValue As Double = Nothing
    Private msSclNotchTipUnits As String = String.Empty
    Private mfSclTipTipValue As Double = Nothing
    Private msSclTipTipUnits As String = String.Empty
    Private mfScwValue As Double = Nothing
    Private msScwUnits As String = String.Empty
    Private mfCclNotchNotchValue As Double = Nothing
    Private msCclNotchNotchUnits As String = String.Empty
    Private mfCclNotchTipValue As Double = Nothing
    Private msCclNotchTipUnits As String = String.Empty
    Private mfCclTipTipValue As Double = Nothing
    Private msCclTipTipUnits As String = String.Empty
    Private mfCcwValue As Double = Nothing
    Private msCcwUnits As String = String.Empty
    Private mfWeightValue As Double = Nothing
    Private msWeightUnits As String = String.Empty

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

    Public Property TurtleMorphometricID() As String
        Get
            Return msTurtleMorphometricID
        End Get
        Set(ByVal Value As String)
            If msTurtleMorphometricID <> Value Then
                msTurtleMorphometricID = Value
                PropertyHasChanged("TurtleMorphometricID")
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

    Public Property SclNotchNotchValue() As Double
        Get
            Return mfSclNotchNotchValue
        End Get
        Set(ByVal Value As Double)
            If mfSclNotchNotchValue <> Value Then
                mfSclNotchNotchValue = Value
                PropertyHasChanged("SclNotchNotchValue")
            End If
        End Set
    End Property

    Public Property SclNotchNotchValueString() As String
        Get
            If mfSclNotchNotchValue = 0 Then
                Return String.Empty
            Else
                Return mfSclNotchNotchValue.ToString
            End If
        End Get
        Set(ByVal Value As String)
            If mfSclNotchNotchValue <> Convert.ToDouble(Val(Value)) Then
                mfSclNotchNotchValue = Convert.ToDouble(Val(Value))
                PropertyHasChanged("SclNotchNotchValueString")
            End If
        End Set
    End Property

    Public Property SclNotchNotchUnits() As String
        Get
            Return msSclNotchNotchUnits
        End Get
        Set(ByVal Value As String)
            If msSclNotchNotchUnits <> Value Then
                msSclNotchNotchUnits = Value
                PropertyHasChanged("SclNotchNotchUnits")
            End If
        End Set
    End Property

    Public Property SclNotchTipValue() As Double
        Get
            Return mfSclNotchTipValue
        End Get
        Set(ByVal Value As Double)
            If mfSclNotchTipValue <> Value Then
                mfSclNotchTipValue = Value
                PropertyHasChanged("SclNotchTipValue")
            End If
        End Set
    End Property

    Public Property SclNotchTipValueString() As String
        Get
            If mfSclNotchTipValue = 0 Then
                Return String.Empty
            Else
                Return mfSclNotchTipValue.ToString
            End If
        End Get
        Set(ByVal Value As String)
            If mfSclNotchTipValue <> Convert.ToDouble(Val(Value)) Then
                mfSclNotchTipValue = Convert.ToDouble(Val(Value))
                PropertyHasChanged("SclNotchTipValueString")
            End If
        End Set
    End Property

    Public Property SclNotchTipUnits() As String
        Get
            Return msSclNotchTipUnits
        End Get
        Set(ByVal Value As String)
            If msSclNotchTipUnits <> Value Then
                msSclNotchTipUnits = Value
                PropertyHasChanged("SclNotchTipUnits")
            End If
        End Set
    End Property

    Public Property SclTipTipValue() As Double
        Get
            Return mfSclTipTipValue
        End Get
        Set(ByVal Value As Double)
            If mfSclTipTipValue <> Value Then
                mfSclTipTipValue = Value
                PropertyHasChanged("SclTipTipValue")
            End If
        End Set
    End Property

    Public Property SclTipTipValueString() As String
        Get
            If mfSclTipTipValue = 0 Then
                Return String.Empty
            Else
                Return mfSclTipTipValue.ToString
            End If
        End Get
        Set(ByVal Value As String)
            If mfSclTipTipValue <> Convert.ToDouble(Val(Value)) Then
                mfSclTipTipValue = Convert.ToDouble(Val(Value))
                PropertyHasChanged("SclTipTipValueString")
            End If
        End Set
    End Property

    Public Property SclTipTipUnits() As String
        Get
            Return msSclTipTipUnits
        End Get
        Set(ByVal Value As String)
            If msSclTipTipUnits <> Value Then
                msSclTipTipUnits = Value
                PropertyHasChanged("SclTipTipUnits")
            End If
        End Set
    End Property

    Public Property ScwValue() As Double
        Get
            Return mfScwValue
        End Get
        Set(ByVal Value As Double)
            If mfScwValue <> Value Then
                mfScwValue = Value
                PropertyHasChanged("ScwValue")
            End If
        End Set
    End Property

    Public Property ScwValueString() As String
        Get
            If mfScwValue = 0 Then
                Return String.Empty
            Else
                Return mfScwValue.ToString
            End If
        End Get
        Set(ByVal Value As String)
            If mfScwValue <> Convert.ToDouble(Val(Value)) Then
                mfScwValue = Convert.ToDouble(Val(Value))
                PropertyHasChanged("ScwValueString")
            End If
        End Set
    End Property

    Public Property ScwUnits() As String
        Get
            Return msScwUnits
        End Get
        Set(ByVal Value As String)
            If msScwUnits <> Value Then
                msScwUnits = Value
                PropertyHasChanged("ScwUnits")
            End If
        End Set
    End Property

    Public Property CclNotchNotchValue() As Double
        Get
            Return mfCclNotchNotchValue
        End Get
        Set(ByVal Value As Double)
            If mfCclNotchNotchValue <> Value Then
                mfCclNotchNotchValue = Value
                PropertyHasChanged("CclNotchNotchValue")
            End If
        End Set
    End Property

    Public Property CclNotchNotchValueString() As String
        Get
            If mfCclNotchNotchValue = 0 Then
                Return String.Empty
            Else
                Return mfCclNotchNotchValue.ToString
            End If
        End Get
        Set(ByVal Value As String)
            If mfCclNotchNotchValue <> Convert.ToDouble(Val(Value)) Then
                mfCclNotchNotchValue = Convert.ToDouble(Val(Value))
                PropertyHasChanged("CclNotchNotchValueString")
            End If
        End Set
    End Property

    Public Property CclNotchNotchUnits() As String
        Get
            Return msCclNotchNotchUnits
        End Get
        Set(ByVal Value As String)
            If msCclNotchNotchUnits <> Value Then
                msCclNotchNotchUnits = Value
                PropertyHasChanged("CclNotchNotchUnits")
            End If
        End Set
    End Property

    Public Property CclNotchTipValue() As Double
        Get
            Return mfCclNotchTipValue
        End Get
        Set(ByVal Value As Double)
            If mfCclNotchTipValue <> Value Then
                mfCclNotchTipValue = Value
                PropertyHasChanged("CclNotchTipValue")
            End If
        End Set
    End Property

    Public Property CclNotchTipValueString() As String
        Get
            If mfCclNotchTipValue = 0 Then
                Return String.Empty
            Else
                Return mfCclNotchTipValue.ToString
            End If
        End Get
        Set(ByVal Value As String)
            If mfCclNotchTipValue <> Convert.ToDouble(Val(Value)) Then
                mfCclNotchTipValue = Convert.ToDouble(Val(Value))
                PropertyHasChanged("CclNotchTipValueString")
            End If
        End Set
    End Property

    Public Property CclNotchTipUnits() As String
        Get
            Return msCclNotchTipUnits
        End Get
        Set(ByVal Value As String)
            If msCclNotchTipUnits <> Value Then
                msCclNotchTipUnits = Value
                PropertyHasChanged("CclNotchTipUnits")
            End If
        End Set
    End Property

    Public Property CclTipTipValue() As Double
        Get
            Return mfCclTipTipValue
        End Get
        Set(ByVal Value As Double)
            If mfCclTipTipValue <> Value Then
                mfCclTipTipValue = Value
                PropertyHasChanged("CclTipTipValue")
            End If
        End Set
    End Property

    Public Property CclTipTipValueString() As String
        Get
            If mfCclTipTipValue = 0 Then
                Return String.Empty
            Else
                Return mfCclTipTipValue.ToString
            End If
        End Get
        Set(ByVal Value As String)
            If mfCclTipTipValue <> Convert.ToDouble(Val(Value)) Then
                mfCclTipTipValue = Convert.ToDouble(Val(Value))
                PropertyHasChanged("CclTipTipValueString")
            End If
        End Set
    End Property

    Public Property CclTipTipUnits() As String
        Get
            Return msCclTipTipUnits
        End Get
        Set(ByVal Value As String)
            If msCclTipTipUnits <> Value Then
                msCclTipTipUnits = Value
                PropertyHasChanged("CclTipTipUnits")
            End If
        End Set
    End Property

    Public Property CcwValue() As Double
        Get
            Return mfCcwValue
        End Get
        Set(ByVal Value As Double)
            If mfCcwValue <> Value Then
                mfCcwValue = Value
                PropertyHasChanged("CcwValue")
            End If
        End Set
    End Property

    Public Property CcwValueString() As String
        Get
            If mfCcwValue = 0 Then
                Return String.Empty
            Else
                Return mfCcwValue.ToString
            End If
        End Get
        Set(ByVal Value As String)
            If mfCcwValue <> Convert.ToDouble(Val(Value)) Then
                mfCcwValue = Convert.ToDouble(Val(Value))
                PropertyHasChanged("CcwValueString")
            End If
        End Set
    End Property

    Public Property CcwUnits() As String
        Get
            Return msCcwUnits
        End Get
        Set(ByVal Value As String)
            If msCcwUnits <> Value Then
                msCcwUnits = Value
                PropertyHasChanged("CcwUnits")
            End If
        End Set
    End Property

    Public Property WeightValue() As Double
        Get
            Return mfWeightValue
        End Get
        Set(ByVal Value As Double)
            If mfWeightValue <> Value Then
                mfWeightValue = Value
                PropertyHasChanged("WeightValue")
            End If
        End Set
    End Property

    Public Property WeightValueString() As String
        Get
            If mfWeightValue = 0 Then
                Return String.Empty
            Else
                Return mfWeightValue.ToString
            End If
        End Get
        Set(ByVal Value As String)
            If mfWeightValue <> Convert.ToDouble(Val(Value)) Then
                mfWeightValue = Convert.ToDouble(Val(Value))
                PropertyHasChanged("WeightValueString")
            End If
        End Set
    End Property

    Public Property WeightUnits() As String
        Get
            Return msWeightUnits
        End Get
        Set(ByVal Value As String)
            If msWeightUnits <> Value Then
                msWeightUnits = Value
                PropertyHasChanged("WeightUnits")
            End If
        End Set
    End Property

    Protected Overrides Function GetIdValue() As Object

        Return msTurtleMorphometricID

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

    Friend Shared Function NewTurtleMorphometric() As TurtleMorphometric

        Dim oTurtleMorphometric As TurtleMorphometric
        oTurtleMorphometric = DataPortal.Create(Of TurtleMorphometric)()
        oTurtleMorphometric.MarkClean()
        Return oTurtleMorphometric

        'Return New TurtleMorphometric()

    End Function

    Friend Shared Function GetTurtleMorphometric(ByVal dr As SafeDataReader) As TurtleMorphometric

        Return New TurtleMorphometric(dr)

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

        msTurtleMorphometricID = Guid.NewGuid.ToString.ToUpper
        mdtDateMeasured = New Date(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)
        mfSclNotchNotchValue = Nothing
        msSclNotchNotchUnits = String.Empty
        mfSclNotchTipValue = Nothing
        msSclNotchTipUnits = String.Empty
        mfSclTipTipValue = Nothing
        msSclTipTipUnits = String.Empty
        mfScwValue = Nothing
        msScwUnits = String.Empty
        mfCclNotchNotchValue = Nothing
        msCclNotchNotchUnits = String.Empty
        mfCclNotchTipValue = Nothing
        msCclNotchTipUnits = String.Empty
        mfCclTipTipValue = Nothing
        msCclTipTipUnits = String.Empty
        mfCcwValue = Nothing
        msCcwUnits = String.Empty
        mfWeightValue = Nothing
        msWeightUnits = String.Empty

        ValidationRules.CheckRules()

        ''v-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew
        ''MarkClean()
        ''^-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew

    End Sub

    Private Sub Fetch(ByVal dr As SafeDataReader)

        With dr
            msTurtleMorphometricID = dr.GetString("turtle_morphometric_id")
            mdtDateMeasured = dr.GetDateTime("date_measured")
            mfSclNotchNotchValue = dr.GetDouble("scl_notch_notch_value")
            msSclNotchNotchUnits = dr.GetString("scl_notch_notch_units")
            mfSclNotchTipValue = dr.GetDouble("scl_notch_tip_value")
            msSclNotchTipUnits = dr.GetString("scl_notch_tip_units")
            mfSclTipTipValue = dr.GetDouble("scl_tip_tip_value")
            msSclTipTipUnits = dr.GetString("scl_tip_tip_units")
            mfScwValue = dr.GetDouble("scw_value")
            msScwUnits = dr.GetString("scw_units")
            mfCclNotchNotchValue = dr.GetDouble("ccl_notch_notch_value")
            msCclNotchNotchUnits = dr.GetString("ccl_notch_notch_units")
            mfCclNotchTipValue = dr.GetDouble("ccl_notch_tip_value")
            msCclNotchTipUnits = dr.GetString("ccl_notch_tip_units")
            mfCclTipTipValue = dr.GetDouble("ccl_tip_tip_value")
            msCclTipTipUnits = dr.GetString("ccl_tip_tip_units")
            mfCcwValue = dr.GetDouble("ccw_value")
            msCcwUnits = dr.GetString("ccw_units")
            mfWeightValue = dr.GetDouble("weight_value")
            msWeightUnits = dr.GetString("weight_units")
        End With

        MarkOld()

    End Sub

    Friend Sub Insert(ByVal oTurtle As Turtle)

        ' if we're not dirty then don't update the database
        If Not Me.IsDirty Then Exit Sub

        Dim s As String = String.Empty
        Dim cn As IDbConnection = CType(Csla.ApplicationContext.LocalContext("cn"), IDbConnection)

        Using cm As IDbCommand = cn.CreateCommand()
            s &= "INSERT INTO turtle_morphometric ("
            s &= "turtle_id, "
            s &= "date_measured, "
            s &= "scl_notch_notch_value, scl_notch_notch_units, "
            s &= "scl_notch_tip_value, scl_notch_tip_units, "
            s &= "scl_tip_tip_value, scl_tip_tip_units, "
            s &= "scw_value, scw_units, "
            s &= "ccl_notch_notch_value, ccl_notch_notch_units, "
            s &= "ccl_notch_tip_value, ccl_notch_tip_units, "
            s &= "ccl_tip_tip_value, ccl_tip_tip_units, "
            s &= "ccw_value, ccw_units, "
            s &= "weight_value, weight_units, "
            s &= "turtle_morphometric_id "
            s &= ") VALUES ("
            s &= "@turtle_id, "
            s &= "@date_measured, "
            s &= "@scl_notch_notch_value, @scl_notch_notch_units, "
            s &= "@scl_notch_tip_value, @scl_notch_tip_units, "
            s &= "@scl_tip_tip_value, @scl_tip_tip_units, "
            s &= "@scw_value, @scw_units, "
            s &= "@ccl_notch_notch_value, @ccl_notch_notch_units, "
            s &= "@ccl_notch_tip_value, @ccl_notch_tip_units, "
            s &= "@ccl_tip_tip_value, @ccl_tip_tip_units, "
            s &= "@ccw_value, @ccw_units, "
            s &= "@weight_value, @weight_units, "
            s &= "@turtle_morphometric_id "
            s &= ")"
            cm.CommandText = s
            DoInsertUpdate(cm, oTurtle.TurtleID)
        End Using

        MarkOld()

    End Sub

    Friend Sub Update(ByVal oTurtle As Turtle)

        ' if we're not dirty then don't update the database
        If Not Me.IsDirty Then Exit Sub

        Dim s As String = String.Empty
        Dim cn As IDbConnection = CType(Csla.ApplicationContext.LocalContext("cn"), IDbConnection)

        Using cm As IDbCommand = cn.CreateCommand()
            s &= "UPDATE turtle_morphometric SET "
            s &= "turtle_id = @turtle_id, "
            s &= "date_measured = @date_measured, "
            s &= "scl_notch_notch_value = @scl_notch_notch_value, "
            s &= "scl_notch_notch_units = @scl_notch_notch_units, "
            s &= "scl_notch_tip_value = @scl_notch_tip_value, "
            s &= "scl_notch_tip_units = @scl_notch_tip_units, "
            s &= "scl_tip_tip_value = @scl_tip_tip_value, "
            s &= "scl_tip_tip_units = @scl_tip_tip_units, "
            s &= "scw_value = @scw_value, "
            s &= "scw_units = @scw_units, "
            s &= "ccl_notch_notch_value = @ccl_notch_notch_value, "
            s &= "ccl_notch_notch_units = @ccl_notch_notch_units, "
            s &= "ccl_notch_tip_value = @ccl_notch_tip_value, "
            s &= "ccl_notch_tip_units = @ccl_notch_tip_units, "
            s &= "ccl_tip_tip_value = @ccl_tip_tip_value, "
            s &= "ccl_tip_tip_units = @ccl_tip_tip_units, "
            s &= "ccw_value = @ccw_value, "
            s &= "ccw_units = @ccw_units, "
            s &= "weight_value = @weight_value, "
            s &= "weight_units = @weight_units "
            s &= "WHERE turtle_morphometric_id = @turtle_morphometric_id "
            cm.CommandText = s
            DoInsertUpdate(cm, oTurtle.TurtleID)
        End Using

        MarkOld()

    End Sub

    Private Sub DoInsertUpdate(ByVal cm As IDbCommand, ByVal sTurtleId As String)

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            With cm

                .CommandType = CommandType.Text
                .Parameters.Add(oAdoHelper.GetParameter("@turtle_id", sTurtleId.ToUpper))
                .Parameters.Add(oAdoHelper.GetParameter("@date_measured", AdoHelper.DbSetDate(mdtDateMeasured)))
                .Parameters.Add(oAdoHelper.GetParameter("@scl_notch_notch_value", mfSclNotchNotchValue))
                .Parameters.Add(oAdoHelper.GetParameter("@scl_notch_notch_units", msSclNotchNotchUnits))
                .Parameters.Add(oAdoHelper.GetParameter("@scl_notch_tip_value", mfSclNotchTipValue))
                .Parameters.Add(oAdoHelper.GetParameter("@scl_notch_tip_units", msSclNotchTipUnits))
                .Parameters.Add(oAdoHelper.GetParameter("@scl_tip_tip_value", mfSclTipTipValue))
                .Parameters.Add(oAdoHelper.GetParameter("@scl_tip_tip_units", msSclTipTipUnits))
                .Parameters.Add(oAdoHelper.GetParameter("@scw_value", mfScwValue))
                .Parameters.Add(oAdoHelper.GetParameter("@scw_units", msScwUnits))
                .Parameters.Add(oAdoHelper.GetParameter("@ccl_notch_notch_value", mfCclNotchNotchValue))
                .Parameters.Add(oAdoHelper.GetParameter("@ccl_notch_notch_units", msCclNotchNotchUnits))
                .Parameters.Add(oAdoHelper.GetParameter("@ccl_notch_tip_value", mfCclNotchTipValue))
                .Parameters.Add(oAdoHelper.GetParameter("@ccl_notch_tip_units", msCclNotchTipUnits))
                .Parameters.Add(oAdoHelper.GetParameter("@ccl_tip_tip_value", mfCclTipTipValue))
                .Parameters.Add(oAdoHelper.GetParameter("@ccl_tip_tip_units", msCclTipTipUnits))
                .Parameters.Add(oAdoHelper.GetParameter("@ccw_value", mfCcwValue))
                .Parameters.Add(oAdoHelper.GetParameter("@ccw_units", msCcwUnits))
                .Parameters.Add(oAdoHelper.GetParameter("@weight_value", mfWeightValue))
                .Parameters.Add(oAdoHelper.GetParameter("@weight_units", msWeightUnits))
                .Parameters.Add(oAdoHelper.GetParameter("@turtle_morphometric_id", msTurtleMorphometricID))
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
                ''----------------------------------------------------------------
                ''-- archive the record being deleted
                ''----------------------------------------------------------------
                'cm.CommandType = CommandType.Text
                'cm.CommandText = "INSERT INTO deleted_turtle_morphometric SELECT * FROM turtle_morphometric WHERE " & oAdoHelper.UpperFunction & "(turtle_morphometric_id) = " & oAdoHelper.UpperFunction & "(@turtle_morphometric_id)"
                'cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_morphometric_id", msTurtleMorphometricID.ToUpper))
                'oAdoHelper.ExecuteNonQuery(cm)

                '----------------------------------------------------------------
                '-- delete the specified record
                '----------------------------------------------------------------
                cm.CommandText = "DELETE FROM turtle_morphometric WHERE " & oAdoHelper.UpperFunction & "(turtle_morphometric_id) = " & oAdoHelper.UpperFunction & "(@turtle_morphometric_id) "
                cm.CommandType = CommandType.Text
                cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_morphometric_id", msTurtleMorphometricID.ToUpper))
                oAdoHelper.ExecuteNonQuery(cm)
            End Using ' cm 

        End Using ' oAdoHelper

        MarkNew()

    End Sub

#End Region

#Region " Exists "

    Public Shared Function Exists(ByVal sTurtleMorphometricId As String) As Boolean

        Dim oExistsCommand As ExistsCommand

        oExistsCommand = DataPortal.Execute(Of ExistsCommand)(New ExistsCommand(sTurtleMorphometricId))

        Return oExistsCommand.Exists

    End Function

    <Serializable()> _
    Private Class ExistsCommand
        Inherits CommandBase

        Private msTurtleMorphometricId As String
        Private mbExists As Boolean

        Public ReadOnly Property Exists() As Boolean
            Get
                Return mbExists
            End Get
        End Property

        Public Sub New(ByVal sTurtleMorphometricId As String)
            msTurtleMorphometricId = sTurtleMorphometricId
        End Sub

        Protected Overrides Sub DataPortal_Execute()

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                Using cn As IDbConnection = oAdoHelper.GetConnection()
                    cn.Open()
                    Using cm As IDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "SELECT turtle_morphometric_id FROM turtle_morphometric WHERE " & oAdoHelper.UpperFunction & "(turtle_morphometric_id) = " & oAdoHelper.UpperFunction & "(@turtle_morphometric_id) "
                        cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_morphometric_id", msTurtleMorphometricId.ToUpper))
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
