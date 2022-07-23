Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class TurtleListItem
    Inherits BusinessBase(Of TurtleListItem)

    Private msTurtleID As String = String.Empty
    Private msTurtleName As String = String.Empty
    Private msSidNumber As String = String.Empty
    Private msStrandingIdNumber As String = String.Empty
    Private msSpecies As String = String.Empty
    Private mdtDateAcquired As Date = DateTime.MinValue
    Private msAcquiredFrom As String = String.Empty
    Private msAcquiredCounty As String = String.Empty
    Private msTurtleSize As String = String.Empty
    Private msStatus As String = String.Empty
    Private mdtDateRelinquished As Date = DateTime.MinValue
    Private msRelinquishedTo As String = String.Empty
    Private msReportTagNumberFieldData As String = String.Empty '<-- used only when reporting
    Private msTagNumberListString As String = String.Empty

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

    Public Property TurtleID() As String
        Get
            Return msTurtleID
        End Get
        Set(ByVal Value As String)
            msTurtleID = Value
        End Set
    End Property

    Public Property TurtleName() As String
        Get
            Return msTurtleName
        End Get
        Set(ByVal Value As String)
            msTurtleName = Value
        End Set
    End Property

    Public Property SidNumber() As String
        Get
            Return msSidNumber
        End Get
        Set(ByVal Value As String)
            msSidNumber = Value
        End Set
    End Property

    Public Property StrandingIdNumber() As String
        Get
            Return msStrandingIdNumber
        End Get
        Set(ByVal Value As String)
            msStrandingIdNumber = Value
        End Set
    End Property

    Public Property Species() As String
        Get
            Return msSpecies
        End Get
        Set(ByVal Value As String)
            msSpecies = Value
        End Set
    End Property

    Public Property DateAcquired() As Date
        Get
            Return DateAtMidnight(mdtDateAcquired)
        End Get
        Set(ByVal Value As Date)
            If HasDateValueChanged(mdtDateAcquired, Value) Then
                mdtDateAcquired = Value
                PropertyHasChanged("DateAcquired")
            End If
        End Set
    End Property

    Public ReadOnly Property DateAcquiredString() As String
        Get
            Return DateAsString(mdtDateAcquired)
        End Get
    End Property

    Public ReadOnly Property DateAcquiredBindable() As Nullable(Of DateTime)
        Get
            Return DateAsNullableDate(mdtDateAcquired)
        End Get
    End Property

    Public Property AcquiredFrom() As String
        Get
            Return msAcquiredFrom
        End Get
        Set(ByVal Value As String)
            msAcquiredFrom = Value
        End Set
    End Property

    Public Property AcquiredCounty() As String
        Get
            Return msAcquiredCounty
        End Get
        Set(ByVal Value As String)
            msAcquiredCounty = Value
        End Set
    End Property

    Public Property TurtleSize() As String
        Get
            Return msTurtleSize
        End Get
        Set(ByVal Value As String)
            msTurtleSize = Value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return msStatus
        End Get
        Set(ByVal Value As String)
            msStatus = Value
        End Set
    End Property

    Public Property DateRelinquished() As Date
        Get
            Return DateAtMidnight(mdtDateRelinquished)
        End Get
        Set(ByVal Value As Date)
            If HasDateValueChanged(mdtDateRelinquished, Value) Then
                mdtDateRelinquished = Value
                PropertyHasChanged("DateRelinquished")
            End If
        End Set
    End Property

    Public ReadOnly Property DateRelinquishedString() As String
        Get
            Return DateAsString(mdtDateRelinquished)
        End Get
    End Property

    Public ReadOnly Property DateRelinquishedBindable() As Nullable(Of DateTime)
        Get
            Return DateAsNullableDate(mdtDateRelinquished)
        End Get
    End Property

    Public Property RelinquishedTo() As String
        Get
            Return msRelinquishedTo
        End Get
        Set(ByVal Value As String)
            msRelinquishedTo = Value
        End Set
    End Property

    Public Property ReportTagNumberFieldData() As String
        Get
            Return msReportTagNumberFieldData
        End Get
        Set(ByVal Value As String)
            msReportTagNumberFieldData = Value
        End Set
    End Property

    Public Property TagNumberListString() As String
        Get
            Return msTagNumberListString
        End Get
        Set(ByVal Value As String)
            msTagNumberListString = Value
        End Set
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return msTurtleID
    End Function

    Public Overrides Function ToString() As String
        Return msTurtleName
    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

    Friend Sub New(ByVal sTurtleID As String, ByVal sTurtleName As String, ByVal sSidNumber As String, ByVal sStrandingIdNumber As String, ByVal sSpecies As String, ByVal dtDateAcquired As Date, ByVal sAcquiredFrom As String, ByVal sAcquiredCounty As String, ByVal sTurtleSize As String, ByVal sStatus As String, ByVal dtDateRelinquished As Date, ByVal sRelinquishedTo As String, ByVal sReportTagNumberFieldData As String)
        msTurtleID = sTurtleID
        msTurtleName = sTurtleName
        msSidNumber = sSidNumber
        msStrandingIdNumber = sStrandingIdNumber
        msSpecies = sSpecies
        mdtDateAcquired = dtDateAcquired
        msAcquiredFrom = sAcquiredFrom
        msAcquiredCounty = sAcquiredCounty
        msTurtleSize = sTurtleSize
        msStatus = sStatus
        mdtDateRelinquished = dtDateRelinquished
        msRelinquishedTo = sRelinquishedTo
        msReportTagNumberFieldData = sReportTagNumberFieldData
    End Sub

End Class
