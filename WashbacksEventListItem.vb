Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class WashbacksEventListItem
    Inherits BusinessBase(Of WashbacksEventListItem)

    Private msEventID As String = String.Empty
    Private msSpeciesDescription As String = String.Empty
    Private mdtEventDate As Date = DateTime.MinValue
    Private msEventType As String = String.Empty
    Private miEventCount As Integer = 0
    Private msCountyName As String = String.Empty
    Private msUnder5CmClsl As String = String.Empty

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

    Public Property EventID() As String
        Get
            Return msEventID
        End Get
        Set(ByVal Value As String)
            msEventID = Value
        End Set
    End Property

    Public Property SpeciesDescription() As String
        Get
            Return msSpeciesDescription
        End Get
        Set(ByVal Value As String)
            msSpeciesDescription = Value
        End Set
    End Property

    Public Property EventDate() As Date
        Get
            Return DateAtMidnight(mdtEventDate)
        End Get
        Set(ByVal Value As Date)
            If HasDateValueChanged(mdtEventDate, Value) Then
                mdtEventDate = Value
                PropertyHasChanged("EventDate")
            End If
        End Set
    End Property

    Public ReadOnly Property EventDateString() As String
        Get
            Return DateAsString(mdtEventDate)
        End Get
    End Property

    Public ReadOnly Property EventDateBindable() As Nullable(Of DateTime)
        Get
            Return DateAsNullableDate(mdtEventDate)
        End Get
    End Property

    Public Property EventType() As String
        Get
            Return msEventType
        End Get
        Set(ByVal Value As String)
            msEventType = Value
        End Set
    End Property

    Public Property EventCount() As Integer
        Get
            Return miEventCount
        End Get
        Set(ByVal Value As Integer)
            miEventCount = Value
        End Set
    End Property

    Public Property CountyName() As String
        Get
            Return msCountyName
        End Get
        Set(ByVal Value As String)
            msCountyName = Value
        End Set
    End Property

    Public Property Under5CmClsl() As String
        Get
            Return msUnder5CmClsl
        End Get
        Set(ByVal Value As String)
            msUnder5CmClsl = Value
        End Set
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return msEventID
    End Function

    Public Overrides Function ToString() As String
        Return msEventType
    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

    Friend Sub New(ByVal sEventID As String, ByVal sSpeciesDescription As String, ByVal dtEventDate As Date, ByVal sEventType As String, ByVal iEventCount As Integer, ByVal sCountyName As String, ByVal sUnder5CmClsl As String)
        msEventID = sEventID
        msSpeciesDescription = sSpeciesDescription
        mdtEventDate = dtEventDate
        msEventType = sEventType
        miEventCount = iEventCount
        msCountyName = sCountyName
        msUnder5CmClsl = sUnder5CmClsl
    End Sub

End Class
