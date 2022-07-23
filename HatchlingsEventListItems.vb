Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class HatchlingsEventListItems
    Inherits BusinessListBase(Of HatchlingsEventListItems, HatchlingsEventListItem)

#Region " Factory Methods "

    Public Shared Function GetList() As HatchlingsEventListItems

        Return DataPortal.Fetch(Of HatchlingsEventListItems)(New Criteria())

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class Criteria

        Public Sub New()
        End Sub

    End Class

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteria As Criteria)

        Dim s As String = String.Empty
        Dim sSpeciesDescription As String = String.Empty

        RaiseListChangedEvents = False

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            s = "SELECT hatchlings_acquired_event_id AS hatchlings_event_id, species_code, event_date, 'Acquired' AS event_type, event_count, acquired_from_county AS county_name "
            s &= "FROM hatchlings_acquired_event "
            s &= "UNION ALL "
            s &= "SELECT hatchlings_died_event_id AS hatchlings_event_id, species_code, event_date, 'Died' AS event_type, event_count, '' AS county_name "
            s &= "FROM hatchlings_died_event "
            s &= "UNION ALL "
            s &= "SELECT hatchlings_released_event_id AS hatchlings_event_id, species_code, event_date, 'Released' AS event_type, " & oAdoHelper.IsNullFunction("beach_event_count", "0") & " + " & oAdoHelper.IsNullFunction("offshore_event_count", "0") & " AS event_count, '' AS county_name "
            s &= "FROM hatchlings_released_event "
            s &= "UNION ALL "
            s &= "SELECT hatchlings_doa_event_id AS hatchlings_event_id, species_code, event_date, 'DOA' AS event_type, event_count, doa_from_county AS county_name "
            s &= "FROM hatchlings_doa_event "

            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(CommandType.Text, s)

                While dr.Read()

                    Select Case dr.GetString("species_code").Trim.ToUpper
                        Case "CC"
                            sSpeciesDescription = "CC - Caretta caretta (Loggerhead)"
                        Case "CM"
                            sSpeciesDescription = "CM - Chelonia mydas (Green)"
                        Case "DC"
                            sSpeciesDescription = "DC - Dermochelys coriacea (Leatherback)"
                        Case "EI"
                            sSpeciesDescription = "EI - Eretmochelys imbricata (Hawksbill)"
                        Case "HB"
                            sSpeciesDescription = "HB - Hybrid"
                        Case "LK"
                            sSpeciesDescription = "LK - Lepidochelys kempii (Kemp's Ridley)"
                        Case "LO"
                            sSpeciesDescription = "LO - Lepidochelys olivacea (Olive Ridley)"
                        Case "XX"
                            sSpeciesDescription = "XX - Unknown"
                        Case Else
                            sSpeciesDescription = dr.GetString("species_code").Trim.ToUpper
                    End Select

                    Me.Add(New HatchlingsEventListItem(dr.GetString("hatchlings_event_id"), sSpeciesDescription, dr.GetDateTime("event_date"), dr.GetString("event_type"), dr.GetInt32("event_count"), dr.GetString("county_name")))

                End While

            End Using ' dr

        End Using ' oAdoHelper

        RaiseListChangedEvents = True

    End Sub

#End Region

End Class
