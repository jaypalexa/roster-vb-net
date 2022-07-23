Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class TankWaterListItem
    Inherits BusinessBase(Of TankWaterListItem)

    Private msTankWaterID As String = String.Empty
    Private msTankID As String = String.Empty
    Private msTankName As String = String.Empty
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
            msTankWaterID = Value
        End Set
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

    Public Property Temperature() As String
        Get
            Return msTemperature
        End Get
        Set(ByVal Value As String)
            msTemperature = Value
        End Set
    End Property

    Public Property Salinity() As String
        Get
            Return msSalinity
        End Get
        Set(ByVal Value As String)
            msSalinity = Value
        End Set
    End Property

    Public Property Ph() As String
        Get
            Return msPh
        End Get
        Set(ByVal Value As String)
            msPh = Value
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

    Public Overrides Function ToString() As String
        Return msTankWaterID
    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

    Friend Sub New(ByVal sTankWaterID As String, ByVal sTankID As String, ByVal sTankName As String, ByVal sTemperature As String, ByVal sSalinity As String, ByVal sPh As String, ByVal dtDateMeasured As Date)
        msTankWaterID = sTankWaterID
        msTankID = sTankID
        msTankName = sTankName
        msTemperature = sTemperature
        msSalinity = sSalinity
        msPh = sPh
        mdtDateMeasured = dtDateMeasured
    End Sub

End Class
