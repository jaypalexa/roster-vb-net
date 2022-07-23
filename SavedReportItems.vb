Option Explicit On
Option Strict On
Option Compare Text

<Serializable()> _
Public Class SavedReportItems
    Inherits BusinessListBase(Of SavedReportItems, SavedReportItem)

#Region " Factory Methods "

    Public Shared Function GetList(ByVal sEditOrView As String, ByVal sFormName As String) As SavedReportItems

        Return DataPortal.Fetch(Of SavedReportItems)(New Criteria(sEditOrView, sFormName))

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class Criteria

        Private msEditOrView As String = String.Empty
        Private msFormName As String = String.Empty

        Public Property EditOrView() As String
            Get
                Return msEditOrView
            End Get
            Set(ByVal value As String)
                msEditOrView = value
            End Set
        End Property

        Public Property FormName() As String
            Get
                Return msFormName
            End Get
            Set(ByVal value As String)
                msFormName = value
            End Set
        End Property

        Public Sub New(ByVal sEditOrView As String, ByVal sFormName As String)
            msEditOrView = sEditOrView
            msFormName = sFormName
        End Sub

    End Class

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteria As Criteria)

        Dim iHour As Integer
        Dim sDisplayHour As String = String.Empty
        Dim sFileName As String = String.Empty
        Dim sTimestampPortion As String = String.Empty
        Dim sDateTime As String = String.Empty
        Dim oDirectoryInfo As New IO.DirectoryInfo(".")
        Dim oFileInfoArray As IO.FileInfo() = oDirectoryInfo.GetFiles("FILLED - " & oCriteria.FormName & " - *.pdf")
        Dim oFileInfo As IO.FileInfo

        RaiseListChangedEvents = False

        '----------------------------------------------------------------
        '-- parse the saved report filenames to get a list
        '----------------------------------------------------------------
        For Each oFileInfo In oFileInfoArray

            '----------------------------------------------------------------
            '-- create a grid row for each data record
            '----------------------------------------------------------------
            sFileName = oFileInfo.Name
            sTimestampPortion = sFileName.Replace("FILLED - " & oCriteria.FormName & " - ", "").Replace(".pdf", "")

            If (sTimestampPortion.Length = 14) Then

                iHour = Convert.ToInt32(sTimestampPortion.Substring(8, 2))
                sDateTime = sTimestampPortion.Substring(4, 2) & "/" & sTimestampPortion.Substring(6, 2) & "/" & sTimestampPortion.Substring(0, 4) & " " & "{HOUR}" & ":" & sTimestampPortion.Substring(10, 2) & ":" & sTimestampPortion.Substring(12, 2)

                Select Case iHour

                    Case 0, 12

                        sDisplayHour = "12"

                    Case Is < 12

                        sDisplayHour = iHour.ToString

                    Case Is > 12

                        sDisplayHour = (iHour - 12).ToString

                End Select

                sDateTime = sDateTime.Replace("{HOUR}", sDisplayHour)

                If (iHour < 12) Then
                    sDateTime &= " AM"
                Else
                    sDateTime &= " PM"
                End If

                If IsDate(sDateTime) Then

                    '----------------------------------------------------------------
                    '-- add item to collection
                    '----------------------------------------------------------------
                    Me.Add(New SavedReportItem(oCriteria.EditOrView, sFileName, Convert.ToDateTime(sDateTime), sDateTime))

                End If

            End If

        Next

        RaiseListChangedEvents = True

    End Sub

#End Region

End Class
