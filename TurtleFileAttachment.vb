Option Explicit On
Option Strict On

<Serializable()> _
Public Class TurtleFileAttachment
    Inherits BusinessBase(Of TurtleFileAttachment)

#Region " Business Methods "

    Private msTurtleFileAttachmentId As String = String.Empty
    Private msFullFileName As String = String.Empty
    Private msCreatedBy As String = String.Empty
    Private mdtDateCreated As DateTime
    Private msModifiedBy As String = String.Empty
    Private mdtDateModified As DateTime

    Public ReadOnly Property EditAction() As String
        Get
            '-- for use in data grid columns
            Return "view"
        End Get
    End Property

    Public ReadOnly Property DeleteAction() As String
        Get
            '-- for use in data grid columns
            Return "delete"
        End Get
    End Property

    Public ReadOnly Property CopyToAction() As String
        Get
            '-- for use in data grid columns
            Return "copy to"
        End Get
    End Property

    Public Property TurtleFileAttachmentId() As String
        Get
            Return msTurtleFileAttachmentId
        End Get
        Set(ByVal value As String)
            If msTurtleFileAttachmentId <> value Then
                msTurtleFileAttachmentId = value
                PropertyHasChanged("TurtleFileAttachmentId")
            End If
        End Set
    End Property

    Public ReadOnly Property BaseFileName() As String
        Get
            Return Path.GetFileName(msFullFileName)
        End Get
    End Property

    ''' <summary>
    ''' When the TurtleFileAttachment object is new (that is, before the object has been saved), the FullFileName is the original path and file name.  Once the Ticket Attachment object has been saved (that is, the file has been copied to our storage folder), the FullFileName is our storage path (.exe path -> TicketId -> TurtleFileAttachmentId -> filename.ext).
    ''' </summary>
    Public Property FullFileName() As String
        Get
            Return msFullFileName
        End Get
        Set(ByVal value As String)
            If msFullFileName <> value Then
                msFullFileName = value
                PropertyHasChanged("FullFileName")
            End If
        End Set
    End Property

    Public ReadOnly Property CreatedBy() As String
        Get
            Return msCreatedBy
        End Get
    End Property

    Public ReadOnly Property DateCreated() As DateTime
        Get
            Return mdtDateCreated
        End Get
    End Property

    Public ReadOnly Property ModifiedBy() As String
        Get
            Return msModifiedBy
        End Get
    End Property

    Public ReadOnly Property DateModified() As DateTime
        Get
            Return mdtDateModified
        End Get
    End Property

    Public ReadOnly Property DateCreatedString(ByVal sDateTimeFormat As String) As String
        Get
            If Not mdtDateCreated.Equals(Nothing) And Not mdtDateCreated.Equals(DBNull.Value) Then
                Return Convert.ToDateTime(mdtDateCreated).ToString(sDateTimeFormat)
            Else
                Return String.Empty
            End If
        End Get
    End Property

    Protected Overrides Function GetIdValue() As Object

        Return msTurtleFileAttachmentId

    End Function

    Public Function GetBrokenRulesString() As String
        Return Me.BrokenRulesCollection.ToString
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

    Friend Shared Function NewTurtleFileAttachment() As TurtleFileAttachment

        Dim oTurtleFileAttachment As TurtleFileAttachment
        oTurtleFileAttachment = DataPortal.Create(Of TurtleFileAttachment)()
        oTurtleFileAttachment.MarkClean()
        Return oTurtleFileAttachment

        'Return New TurtleFileAttachment()

    End Function

    Friend Shared Function GetTurtleFileAttachment(ByVal sTurtleFileAttachmentId As String, ByVal sFullFileName As String, ByVal sCreatedBy As String, ByVal dtDateCreated As DateTime, ByVal sModifiedBy As String, ByVal dtDateModified As DateTime) As TurtleFileAttachment

        Return New TurtleFileAttachment(sTurtleFileAttachmentId, sFullFileName, sCreatedBy, dtDateCreated, sModifiedBy, dtDateModified)

    End Function

    Friend Sub DeleteTurtleFileAttachment(ByVal sTurtleId As String)

        DeleteSelf(sTurtleId)

        '----------------------------------------------------------------
        '-- for some CSLA reason, DataPortal.Delete marks the object is dirty, 
        '-- even if we have a MarkClean() in the object's DataPortal_Delete routine; 
        '-- therefore, we put a MarkClean() here...ugh...
        '----------------------------------------------------------------
        MarkClean()
        Reset()

    End Sub

    Private Sub New()

        MarkAsChild()

    End Sub

    Private Sub New(ByVal sTurtleFileAttachmentId As String, ByVal sFullFileName As String, ByVal sCreatedBy As String, ByVal dtDateCreated As DateTime, ByVal sModifiedBy As String, ByVal dtDateModified As DateTime)

        MarkAsChild()
        Fetch(sTurtleFileAttachmentId, sFullFileName, sCreatedBy, dtDateCreated, sModifiedBy, dtDateModified)

    End Sub

#End Region

#Region " Data Access "

    <RunLocal()> _
    Protected Overrides Sub DataPortal_Create()

        msTurtleFileAttachmentId = Guid.NewGuid.ToString.ToUpper
        msFullFileName = String.Empty
        mdtDateCreated = DateTime.Now
        mdtDateModified = DateTime.Now

        ValidationRules.CheckRules()

        ''v-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew
        ''MarkClean()
        ''^-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew

    End Sub

    Private Sub Fetch(ByVal sTurtleFileAttachmentId As String, ByVal sFullFileName As String, ByVal sCreatedBy As String, ByVal dtDateCreated As DateTime, ByVal sModifiedBy As String, ByVal dtDateModified As DateTime)

        msTurtleFileAttachmentId = sTurtleFileAttachmentId
        msFullFileName = sFullFileName
        mdtDateCreated = dtDateCreated
        msCreatedBy = sCreatedBy
        mdtDateCreated = dtDateCreated
        msModifiedBy = sModifiedBy
        mdtDateModified = dtDateModified

        MarkOld()

    End Sub

    Friend Sub Insert(ByVal sTurtleId As String)

        '-- the TurtleId is the name of the main folder
        '-- the TurtleFileAttachmentId is the name of the subfolder which holds one attachment file

        ' if we're not dirty then don't update the database
        If Not Me.IsDirty Then Exit Sub

        If String.IsNullOrEmpty(msFullFileName) Then Exit Sub

        If Not File.Exists(msFullFileName) Then Exit Sub

        Dim sTurtleDirectory As String = String.Empty
        Dim sAttachmentDirectory As String = String.Empty

        sTurtleDirectory = GetExecutingDirectoryName() & "\attachments\" & Convert.ToString(sTurtleId)

        '----------------------------------------------------------------------
        '-- create the Turtle folder if it does not already exist
        '----------------------------------------------------------------------
        If Not Directory.Exists(sTurtleDirectory) Then
            Directory.CreateDirectory(sTurtleDirectory)
        End If

        sAttachmentDirectory = sTurtleDirectory & "\" & msTurtleFileAttachmentId

        '----------------------------------------------------------------------
        '-- on inserts, the attachment folder should not exist, 
        '-- but we check it any because I am anal
        '----------------------------------------------------------------------
        If Not Directory.Exists(sAttachmentDirectory) Then
            Directory.CreateDirectory(sAttachmentDirectory)
        End If

        '----------------------------------------------------------------------
        '-- copy the indicated file to our storage location; 
        '-- change the file path to our storage location
        '----------------------------------------------------------------------
        File.Copy(msFullFileName, sAttachmentDirectory & "\" & Path.GetFileName(msFullFileName), True)
        msFullFileName = sAttachmentDirectory & "\" & Path.GetFileName(msFullFileName)

        MarkOld()

    End Sub

    Friend Sub DeleteSelf(ByVal sTurtleId As String)

        '-- the TurtleId is the name of the main folder
        '-- the TurtleFileAttachmentId is the name of the subfolder which holds one attachment file

        ' if we're not dirty then don't update the database
        If Not Me.IsDirty Then Exit Sub

        ' if we're new then don't update the database
        If Me.IsNew Then Exit Sub

        If String.IsNullOrEmpty(msFullFileName) Then Exit Sub

        Dim sTurtleDirectory As String = String.Empty
        Dim sAttachmentDirectory As String = String.Empty

        sTurtleDirectory = GetExecutingDirectoryName() & "\attachments\" & Convert.ToString(sTurtleId)
        sAttachmentDirectory = sTurtleDirectory & "\" & msTurtleFileAttachmentId

        '----------------------------------------------------------------------
        '-- delete the attachment file AND folder
        '----------------------------------------------------------------------
        If File.Exists(msFullFileName) Then
            File.Delete(msFullFileName)
        End If

        If Directory.Exists(sAttachmentDirectory) Then
            Directory.Delete(sAttachmentDirectory, True)
        End If

        '----------------------------------------------------------------------
        '-- if this was the last attachment for this Turtle, 
        '-- then delete the Turtle folder
        '----------------------------------------------------------------------
        If Directory.Exists(sTurtleDirectory) Then
            If (Directory.GetDirectories(sTurtleDirectory).Length = 0) Then
                Directory.Delete(sTurtleDirectory, True)
            End If
        End If

        MarkNew()

    End Sub

#End Region

#Region " Exists "

    Public Shared Function Exists(ByVal sTicketId As String, ByVal sTurtleFileAttachmentId As String) As Boolean

        Dim oExistsCommand As ExistsCommand

        oExistsCommand = DataPortal.Execute(Of ExistsCommand)(New ExistsCommand(sTicketId, sTurtleFileAttachmentId))

        Return oExistsCommand.Exists

    End Function

    <Serializable()> _
    Private Class ExistsCommand
        Inherits CommandBase

        Private msTicketId As String
        Private msTurtleFileAttachmentId As String
        Private mbExists As Boolean

        Public ReadOnly Property Exists() As Boolean
            Get
                Return mbExists
            End Get
        End Property

        Public Sub New(ByVal sTicketId As String, ByVal sTurtleFileAttachmentId As String)
            msTicketId = sTicketId
            msTurtleFileAttachmentId = sTurtleFileAttachmentId
        End Sub

        <RunLocal()> _
        Protected Overrides Sub DataPortal_Execute()

            Dim sAttachmentDirectory As String = String.Empty

            sAttachmentDirectory = GetExecutingDirectoryName() & "\attachments\" & msTicketId & "\" & msTurtleFileAttachmentId

            mbExists = Directory.Exists(sAttachmentDirectory)

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
