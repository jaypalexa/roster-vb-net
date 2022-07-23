Option Explicit On
Option Strict On

<Serializable()> _
Public Class KeyValueInfo
    Inherits Csla.ReadOnlyBase(Of KeyValueInfo)

    Private msKey As String = String.Empty
    Private msValue As String = String.Empty

    Public Property Key() As String
        Get
            Return msKey
        End Get
        Friend Set(ByVal sKey As String)
            msKey = sKey
        End Set
    End Property

    Public Property Value() As String
        Get
            Return msValue
        End Get
        Friend Set(ByVal sValue As String)
            msValue = sValue
        End Set
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return msKey
    End Function

    Public Overrides Function ToString() As String
        Return msValue
    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

    Public Sub New(ByVal sKey As String, ByVal sValue As String)
        msKey = sKey
        msValue = sValue
    End Sub

End Class
