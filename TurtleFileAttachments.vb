Option Explicit On
Option Strict On

<Serializable()> _
Public Class TurtleFileAttachments
    Inherits BusinessListBase(Of TurtleFileAttachments, TurtleFileAttachment)

#Region " Business Methods "

    Public Function GetItem(ByVal sTurtleFileAttachmentId As String) As TurtleFileAttachment

        For Each oTurtleFileAttachment As TurtleFileAttachment In Me
            If oTurtleFileAttachment.TurtleFileAttachmentId = sTurtleFileAttachmentId Then
                Return oTurtleFileAttachment
            End If
        Next
        Return Nothing

    End Function

    Public Function CreateNew() As TurtleFileAttachment

        Dim oTurtleFileAttachment As TurtleFileAttachment

        oTurtleFileAttachment = TurtleFileAttachment.NewTurtleFileAttachment()

        Return oTurtleFileAttachment

    End Function

    Public Overloads Sub Remove(ByVal sTurtleFileAttachmentId As String)

        If String.IsNullOrEmpty(sTurtleFileAttachmentId) Then Exit Sub

        For Each oTurtleFileAttachment As TurtleFileAttachment In Me
            If (oTurtleFileAttachment.TurtleFileAttachmentId = sTurtleFileAttachmentId) Then
                Me.Remove(oTurtleFileAttachment)
                Exit For
            End If
        Next

    End Sub

    Public Overloads Function Contains(ByVal sTurtleFileAttachmentId As String) As Boolean

        If String.IsNullOrEmpty(sTurtleFileAttachmentId) Then Exit Function

        For Each oTurtleFileAttachment As TurtleFileAttachment In Me
            If (String.Compare(oTurtleFileAttachment.TurtleFileAttachmentId, sTurtleFileAttachmentId, True) = 0) Then
                Return True
            End If
        Next

        Return False

    End Function

    Public Overloads Function ContainsDeleted(ByVal sTurtleFileAttachmentId As String) As Boolean

        If String.IsNullOrEmpty(sTurtleFileAttachmentId) Then Exit Function

        For Each oTurtleFileAttachment As TurtleFileAttachment In DeletedList
            If (String.Compare(oTurtleFileAttachment.TurtleFileAttachmentId, sTurtleFileAttachmentId, True) = 0) Then
                Return True
            End If
        Next

        Return False

    End Function

    Public Function GetBrokenRulesString() As String

        Dim s As String = String.Empty

        For Each oTurtleFileAttachment As TurtleFileAttachment In Me
            s &= ControlChars.NewLine & oTurtleFileAttachment.GetBrokenRulesString
        Next

        Return s

    End Function

#End Region

#Region " Factory Methods "

    Friend Shared Function NewTurtleFileAttachments() As TurtleFileAttachments

        Return New TurtleFileAttachments

    End Function

    Friend Shared Function GetTurtleFileAttachments(ByVal sTurtleId As String) As TurtleFileAttachments

        Return New TurtleFileAttachments(sTurtleId)

    End Function

    Private Sub New()

        MarkAsChild()

    End Sub

    Private Sub New(ByVal sTurtleId As String)

        MarkAsChild()
        Fetch(sTurtleId)

    End Sub

#End Region

#Region " Data Access "

    Private Sub Fetch(ByVal sTurtleId As String)

        '-- the TurtleId is the name of the main folder
        '-- the TurtleFileAttachmentId is the name of the subfolder which holds one attachment file

        Dim sTurtleDirectory As String = String.Empty
        Dim sAttachmentDirectoryName As String = String.Empty
        Dim oAttachmentDirectories() As String

        Dim oAttachmentDirectoryInfo As DirectoryInfo
        Dim oAttachmentFileInfoArray As FileInfo()
        Dim oAttachmentFileInfo As FileInfo

        sTurtleDirectory = GetExecutingDirectoryName() & "\attachments\" & Convert.ToString(sTurtleId)

        If Not Directory.Exists(sTurtleDirectory) Then Exit Sub

        Me.RaiseListChangedEvents = False

        '-- get the list of attachment subdirectories underneath the Turtle directory
        oAttachmentDirectories = Directory.GetDirectories(sTurtleDirectory)

        '-- for each attachment folder, get the attachment file name within it
        For Each sAttachmentDirectoryName In oAttachmentDirectories

            oAttachmentDirectoryInfo = New DirectoryInfo(sAttachmentDirectoryName)
            oAttachmentFileInfoArray = oAttachmentDirectoryInfo.GetFiles()

            '-- for each attachment file name, load the business object values
            For Each oAttachmentFileInfo In oAttachmentFileInfoArray
                Me.Add(TurtleFileAttachment.GetTurtleFileAttachment(Path.GetFileName(sAttachmentDirectoryName), oAttachmentFileInfo.FullName, String.Empty, oAttachmentFileInfo.CreationTime, String.Empty, oAttachmentFileInfo.LastWriteTime))
            Next

        Next

        Me.RaiseListChangedEvents = True

    End Sub

    Friend Sub Update(ByVal oTurtle As Turtle)

        Me.RaiseListChangedEvents = False

        ' update (thus deleting) any deleted child objects
        For Each oTurtleFileAttachment As TurtleFileAttachment In DeletedList
            oTurtleFileAttachment.DeleteSelf(oTurtle.TurtleID)
        Next
        ' now that they are deleted, remove them from memory too
        DeletedList.Clear()

        ' add/update any current child objects
        For Each oTurtleFileAttachment As TurtleFileAttachment In Me
            If oTurtleFileAttachment.IsNew Then
                '-- only doing inserts (copying file from one location to another)
                '-- and deletes (removing files)
                oTurtleFileAttachment.Insert(oTurtle.TurtleID)
            End If
        Next

        Me.RaiseListChangedEvents = True

    End Sub

#End Region

End Class
