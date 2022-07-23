Option Explicit On
Option Strict On
Option Compare Text

<Serializable()> _
Public Class SavedReportItem
    Inherits BusinessBase(Of SavedReportItem)

    Private msEditAction As String = String.Empty
    Private msReportFileName As String = String.Empty
    Private mdtDateOfReport As Date = Date.MinValue
    Private msDisplayDateOfReport As String = String.Empty

    Public Property EditAction() As String
        Get
            '-- for use in data grid columns
            Return msEditAction
        End Get
        Set(ByVal Value As String)
            msEditAction = Value
        End Set
    End Property

    Public ReadOnly Property DeleteAction() As String
        Get
            '-- for use in data grid columns
            Return "delete"
        End Get
    End Property

    Public Property ReportFileName() As String
        Get
            Return msReportFileName
        End Get
        Set(ByVal Value As String)
            msReportFileName = Value
        End Set
    End Property

    Public Property DateOfReport() As Date
        Get
            Return mdtDateOfReport
        End Get
        Set(ByVal Value As Date)
            mdtDateOfReport = Value
        End Set
    End Property

    Public Property DisplayDateOfReport() As String
        Get
            Return msDisplayDateOfReport
        End Get
        Set(ByVal Value As String)
            msDisplayDateOfReport = Value
        End Set
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return msReportFileName
    End Function

    Public Overrides Function ToString() As String
        Return msReportFileName
    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

    Friend Sub New(ByVal sEditAction As String, ByVal sReportFileName As String, ByVal dtDateOfReport As Date, ByVal sDisplayDateOfReport As String)
        msEditAction = sEditAction
        msReportFileName = sReportFileName
        mdtDateOfReport = dtDateOfReport
        msDisplayDateOfReport = sDisplayDateOfReport
    End Sub

End Class
