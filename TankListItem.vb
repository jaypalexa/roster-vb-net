Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class TankListItem
    Inherits BusinessBase(Of TankListItem)

    Private msTankID As String = String.Empty
    Private msTankName As String = String.Empty

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

    Public Property TankID() As String
        Get
            Return msTankID
        End Get
        Set(ByVal Value As String)
            msTankID = Value
        End Set
    End Property

    Public Property TankName() As String
        Get
            Return msTankName
        End Get
        Set(ByVal Value As String)
            msTankName = Value
        End Set
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return msTankID
    End Function

    Public Overrides Function ToString() As String
        Return msTankName
    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

    Friend Sub New(ByVal sTankID As String, ByVal sTankName As String)
        msTankID = sTankID
        msTankName = sTankName
    End Sub

End Class
