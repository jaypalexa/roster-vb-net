Option Explicit On
Option Strict On

<Serializable()> _
Public Class CountyList
    Inherits BusinessListBase(Of CountyList, CountyInfo)

#Region " Factory Methods "

    Public Shared Function GetList(Optional ByVal bIncludeBlankLine As Boolean = False) As CountyList

        Return DataPortal.Fetch(Of CountyList)(New Criteria(bIncludeBlankLine))

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class Criteria

        Private mbIncludeBlankLine As Boolean = False

        Public ReadOnly Property IncludeBlankLine() As Boolean
            Get
                Return mbIncludeBlankLine
            End Get
        End Property

        Public Sub New(ByVal bIncludeBlankLine As Boolean)
            mbIncludeBlankLine = bIncludeBlankLine
        End Sub

    End Class

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteria As Criteria)

        Dim s As String = String.Empty

        RaiseListChangedEvents = False

        If oCriteria.IncludeBlankLine Then
            Me.Add(New CountyInfo(String.Empty, String.Empty))
        End If

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            s = "SELECT * FROM county "
            s &= "ORDER BY " & oAdoHelper.UpperFunction & "(county_name) "

            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(CommandType.Text, s)

                While dr.Read()

                    Me.Add(New CountyInfo(dr.GetString("county_id").ToUpper, dr.GetString("county_name")))

                End While

            End Using ' dr

        End Using ' oAdoHelper

        RaiseListChangedEvents = True

    End Sub

#End Region

End Class
