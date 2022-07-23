Option Explicit On
Option Strict On

<Serializable()> _
Public Class CountyInfo
    Inherits BusinessBase(Of CountyInfo)

    Private msCountyId As String = String.Empty
    Private msCountyName As String = String.Empty

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

    Public Property CountyId() As String
        Get
            Return msCountyId
        End Get
        Friend Set(ByVal value As String)
            msCountyId = value
        End Set
    End Property

    Public Property Name() As String
        Get
            Return msCountyName
        End Get
        Friend Set(ByVal value As String)
            msCountyName = value
        End Set
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return msCountyId
    End Function

    Public Overrides Function ToString() As String
        Return msCountyName
    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

    Friend Sub New(ByVal sCountyId As String, ByVal sCountyName As String)
        msCountyId = sCountyId
        msCountyName = sCountyName
    End Sub

End Class
