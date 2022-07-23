Option Explicit On
Option Strict On
Option Compare Text

Public Class LatLonMapItem

    Private mdLatitudeDecimalDegrees As Double
    Private mdLongitudeDecimalDegrees As Double
    Private msTitle As String = String.Empty
    Private msDescription As String = String.Empty

    Public Property LatitudeDecimalDegrees() As Double
        Get
            Return mdLatitudeDecimalDegrees
        End Get
        Set(ByVal value As Double)
            mdLatitudeDecimalDegrees = value
        End Set
    End Property

    Public Property LongitudeDecimalDegrees() As Double
        Get
            Return mdLongitudeDecimalDegrees
        End Get
        Set(ByVal value As Double)
            mdLongitudeDecimalDegrees = value
        End Set
    End Property

    Public Property Title() As String
        Get
            Return msTitle
        End Get
        Set(ByVal value As String)
            msTitle = value
        End Set
    End Property

    Public Property Description() As String
        Get
            Return msDescription
        End Get
        Set(ByVal value As String)
            msDescription = value
        End Set
    End Property

    Public Sub New()
        mdLatitudeDecimalDegrees = 0
        mdLongitudeDecimalDegrees = 0
        msTitle = String.Empty
        msDescription = String.Empty
    End Sub

    Public Sub New(ByVal dLatitudeDecimalDegrees As Double, ByVal dLongitudeDecimalDegrees As Double, Optional ByVal sTitle As String = "", Optional ByVal sDescription As String = "")
        mdLatitudeDecimalDegrees = dLatitudeDecimalDegrees
        mdLongitudeDecimalDegrees = dLongitudeDecimalDegrees
        msTitle = sTitle
        msDescription = sDescription
    End Sub

End Class
