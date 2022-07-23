Option Explicit On
Option Strict On
Option Compare Text

<Serializable()> _
Public Class TurtleTag
    Inherits BusinessBase(Of TurtleTag)

#Region " Business Methods "

    Private msTurtleTagID As String = String.Empty
    Private msTagNumber As String = String.Empty
    Private msTagType As String = String.Empty
    Private msLocation As String = String.Empty
    Private mdtDateTagged As Date = DateTime.MinValue

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

    Public Property TurtleTagID() As String
        Get
            Return msTurtleTagID
        End Get
        Set(ByVal Value As String)
            If msTurtleTagID <> Value Then
                msTurtleTagID = Value
                PropertyHasChanged("TurtleTagID")
            End If
        End Set
    End Property

    Public Property TagNumber() As String
        Get
            Return msTagNumber
        End Get
        Set(ByVal Value As String)
            If msTagNumber <> Value Then
                msTagNumber = Value
                PropertyHasChanged("TagNumber")
            End If
        End Set
    End Property

    Public Property TagType() As String
        Get
            Return msTagType
        End Get
        Set(ByVal Value As String)
            If msTagType <> Value Then
                msTagType = Value
                PropertyHasChanged("TagType")
            End If
        End Set
    End Property

    Public Property Location() As String
        Get
            Return msLocation
        End Get
        Set(ByVal Value As String)
            If msLocation <> Value Then
                msLocation = Value
                PropertyHasChanged("Location")
            End If
        End Set
    End Property

    Public Property DateTagged() As Date
        Get
            Return DateAtMidnight(mdtDateTagged)
        End Get
        Set(ByVal Value As Date)
            If HasDateValueChanged(mdtDateTagged, Value) Then
                mdtDateTagged = Value
                PropertyHasChanged("DateTagged")
            End If
        End Set
    End Property

    Public ReadOnly Property DateTaggedString() As String
        Get
            Return DateAsString(mdtDateTagged)
        End Get
    End Property

    Public ReadOnly Property DateTaggedBindable() As Nullable(Of DateTime)
        Get
            Return DateAsNullableDate(mdtDateTagged)
        End Get
    End Property

    Protected Overrides Function GetIdValue() As Object

        Return msTurtleTagID

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

    Friend Shared Function NewTurtleTag() As TurtleTag

        Dim oTurtleTag As TurtleTag
        oTurtleTag = DataPortal.Create(Of TurtleTag)()
        oTurtleTag.MarkClean()
        Return oTurtleTag

        'Return New TurtleTag()

    End Function

    Friend Shared Function GetTurtleTag(ByVal dr As SafeDataReader) As TurtleTag

        Return New TurtleTag(dr)

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

        msTurtleTagID = Guid.NewGuid.ToString.ToUpper
        msTagNumber = String.Empty
        msTagType = String.Empty
        msLocation = String.Empty
        mdtDateTagged = New Date(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day)

        ValidationRules.CheckRules()

        ''v-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew
        ''MarkClean()
        ''^-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew

    End Sub

    Private Sub Fetch(ByVal dr As SafeDataReader)

        With dr
            msTurtleTagID = dr.GetString("turtle_tag_id")
            msTagNumber = dr.GetString("tag_number")
            msTagType = dr.GetString("tag_type")
            msLocation = dr.GetString("location")
            mdtDateTagged = dr.GetDateTime("date_tagged")
        End With

        MarkOld()

    End Sub

    Friend Sub Insert(ByVal oTurtle As Turtle)

        ' if we're not dirty then don't update the database
        If Not Me.IsDirty Then Exit Sub

        Dim s As String = String.Empty
        Dim cn As IDbConnection = CType(Csla.ApplicationContext.LocalContext("cn"), IDbConnection)

        Using cm As IDbCommand = cn.CreateCommand()
            s &= "INSERT INTO turtle_tag ("
            s &= "turtle_id, tag_number, tag_type, location, date_tagged, turtle_tag_id "
            s &= ") VALUES ("
            s &= "@turtle_id, @tag_number, @tag_type, @location, @date_tagged, @turtle_tag_id "
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
            s &= "UPDATE turtle_tag SET "
            s &= "turtle_id = @turtle_id, "
            s &= "tag_number = @tag_number, "
            s &= "tag_type = @tag_type, "
            s &= "location = @location, "
            s &= "date_tagged = @date_tagged "
            s &= "WHERE turtle_tag_id = @turtle_tag_id "
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
                .Parameters.Add(oAdoHelper.GetParameter("@tag_number", msTagNumber))
                .Parameters.Add(oAdoHelper.GetParameter("@tag_type", msTagType))
                .Parameters.Add(oAdoHelper.GetParameter("@location", msLocation))
                .Parameters.Add(oAdoHelper.GetParameter("@date_tagged", AdoHelper.DbSetDate(mdtDateTagged)))
                .Parameters.Add(oAdoHelper.GetParameter("@turtle_tag_id", msTurtleTagID))
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
                'cm.CommandText = "INSERT INTO deleted_turtle_tag SELECT * FROM turtle_tag WHERE " & oAdoHelper.UpperFunction & "(turtle_tag_id) = " & oAdoHelper.UpperFunction & "(@turtle_tag_id)"
                'cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_tag_id", msTurtleTagID.ToUpper))
                'oAdoHelper.ExecuteNonQuery(cm)

                '----------------------------------------------------------------
                '-- delete the specified record
                '----------------------------------------------------------------
                cm.CommandText = "DELETE FROM turtle_tag WHERE " & oAdoHelper.UpperFunction & "(turtle_tag_id) = " & oAdoHelper.UpperFunction & "(@turtle_tag_id) "
                cm.CommandType = CommandType.Text
                cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_tag_id", msTurtleTagID.ToUpper))
                oAdoHelper.ExecuteNonQuery(cm)
            End Using ' cm 

        End Using ' oAdoHelper

        MarkNew()

    End Sub

#End Region

#Region " Exists "

    Public Shared Function Exists(ByVal sTurtleTagId As String) As Boolean

        Dim oExistsCommand As ExistsCommand

        oExistsCommand = DataPortal.Execute(Of ExistsCommand)(New ExistsCommand(sTurtleTagId))

        Return oExistsCommand.Exists

    End Function

    <Serializable()> _
    Private Class ExistsCommand
        Inherits CommandBase

        Private msTurtleTagId As String
        Private mbExists As Boolean

        Public ReadOnly Property Exists() As Boolean
            Get
                Return mbExists
            End Get
        End Property

        Public Sub New(ByVal sTurtleTagId As String)
            msTurtleTagId = sTurtleTagId
        End Sub

        Protected Overrides Sub DataPortal_Execute()

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                Using cn As IDbConnection = oAdoHelper.GetConnection()
                    cn.Open()
                    Using cm As IDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "SELECT turtle_tag_id FROM turtle_tag WHERE " & oAdoHelper.UpperFunction & "(turtle_tag_id) = " & oAdoHelper.UpperFunction & "(@turtle_tag_id) "
                        cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_tag_id", msTurtleTagId.ToUpper))
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
