Option Explicit On
Option Strict On

<Serializable()> _
Public Class CodeTableList
    Inherits ReadOnlyListBase(Of CodeTableList, KeyValueInfo)

    Public Enum CodeTableType
        TagType
        TagLocation
        TurtleListFilter
        TurtleSize
        TurtleStatus
        Species
        SpeciesShort
        Sex
        CmIn
        KgLb
        HowWasSexDetermined
        StateCoordinatorNotified
        StrandingLocationShore
        InitialCondition
        Disposition
        BurialLocation
        PartsSalvagedType
        WeightAccuracyType
        Flipper
        FatColor
        EpibiotaShortList
        EpibiotaLongList
        DigestiveSystemContents
        PreferredUnitsType
        RecaptureType
        CaptureProjectType
        YesNoUndetermined
    End Enum

#Region " Factory Methods "

    Public Shared Function GetList(ByVal eCodeTableType As CodeTableType, ByVal bIncludeBlankLine As Boolean) As CodeTableList

        Return DataPortal.Fetch(Of CodeTableList)(New Criteria(eCodeTableType, bIncludeBlankLine))

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class Criteria

        Private meCodeTableType As CodeTableType
        Private mbIncludeBlankLine As Boolean

        Public ReadOnly Property CodeTableType() As CodeTableType
            Get
                Return meCodeTableType
            End Get
        End Property

        Public ReadOnly Property IncludeBlankLine() As Boolean
            Get
                Return mbIncludeBlankLine
            End Get
        End Property

        Public Sub New(ByVal eCodeTableType As CodeTableType, ByVal bIncludeBlankLine As Boolean)
            meCodeTableType = eCodeTableType
            mbIncludeBlankLine = bIncludeBlankLine
        End Sub

    End Class

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteria As Criteria)

        '-- key, value

        Dim s As String = String.Empty

        RaiseListChangedEvents = False

        IsReadOnly = False

        If oCriteria.IncludeBlankLine Then
            Me.Add(New KeyValueInfo(String.Empty, String.Empty))
        End If

        Select Case oCriteria.CodeTableType

            Case CodeTableType.TagType

                Me.Add(New KeyValueInfo("Inconel", "Inconel"))
                Me.Add(New KeyValueInfo("Monel", "Monel"))
                Me.Add(New KeyValueInfo("PIT", "PIT"))
                Me.Add(New KeyValueInfo("Roto", "Roto"))
                Me.Add(New KeyValueInfo("Other", "Other"))

            Case CodeTableType.TagLocation

                Me.Add(New KeyValueInfo("RFF", "RFF"))
                Me.Add(New KeyValueInfo("LFF", "LFF"))
                Me.Add(New KeyValueInfo("RRF", "RRF"))
                Me.Add(New KeyValueInfo("LRF", "LRF"))
                Me.Add(New KeyValueInfo("Other", "Other"))

            Case CodeTableType.TurtleListFilter

                Me.Add(New KeyValueInfo("none", "Filter by <none>"))
                Me.Add(New KeyValueInfo("name", "Filter by Name"))
                Me.Add(New KeyValueInfo("sid", "Filter by SID"))
                Me.Add(New KeyValueInfo("strandingid", "Filter by Stranding ID"))
                Me.Add(New KeyValueInfo("tag", "Filter by Tag"))

            Case CodeTableType.TurtleSize

                Me.Add(New KeyValueInfo("Hatchling", "Hatchling"))
                Me.Add(New KeyValueInfo("Post-hatchling", "Post-hatchling"))
                Me.Add(New KeyValueInfo("Juvenile", "Juvenile"))
                Me.Add(New KeyValueInfo("Subadult", "Subadult"))
                Me.Add(New KeyValueInfo("Adult", "Adult"))
                Me.Add(New KeyValueInfo("Unknown", "Unknown"))

            Case CodeTableType.TurtleStatus

                Me.Add(New KeyValueInfo("UR", "UR - Undergoing rehab"))
                Me.Add(New KeyValueInfo("ED", "ED - Educational display"))
                Me.Add(New KeyValueInfo("UO", "UO - Unknown origin"))
                Me.Add(New KeyValueInfo("PD", "PD - Permanently disabled"))
                Me.Add(New KeyValueInfo("PREACT", "PREACT - Pre-act animal"))
                Me.Add(New KeyValueInfo("RESEARCH", "RESEARCH (requires pre-approval)"))
                Me.Add(New KeyValueInfo("RFR", "RFR - Ready for release"))
                Me.Add(New KeyValueInfo("TSTR", "TSTR - Holding until reaches size"))
                Me.Add(New KeyValueInfo("Unknown", "Unknown"))

            Case CodeTableType.Species

                Me.Add(New KeyValueInfo("CC", "CC - Caretta caretta (Loggerhead)"))
                Me.Add(New KeyValueInfo("CM", "CM - Chelonia mydas (Green)"))
                Me.Add(New KeyValueInfo("DC", "DC - Dermochelys coriacea (Leatherback)"))
                Me.Add(New KeyValueInfo("EI", "EI - Eretmochelys imbricata (Hawksbill)"))
                Me.Add(New KeyValueInfo("LK", "LK - Lepidochelys kempii (Kemp's Ridley)"))
                Me.Add(New KeyValueInfo("LO", "LO - Lepidochelys olivacea (Olive Ridley)"))
                Me.Add(New KeyValueInfo("HB", "HB - Hybrid"))
                Me.Add(New KeyValueInfo("XX", "XX - Unknown"))

            Case CodeTableType.SpeciesShort

                Me.Add(New KeyValueInfo("CC", "CC - Caretta caretta (Loggerhead)"))
                Me.Add(New KeyValueInfo("CM", "CM - Chelonia mydas (Green)"))
                Me.Add(New KeyValueInfo("DC", "DC - Dermochelys coriacea (Leatherback)"))
                Me.Add(New KeyValueInfo("Other", "Other"))
                Me.Add(New KeyValueInfo("Unknown", "Unknown"))

            Case CodeTableType.Sex

                Me.Add(New KeyValueInfo("F", "F - Female"))
                Me.Add(New KeyValueInfo("M", "M - Male"))
                Me.Add(New KeyValueInfo("U", "U - Undetermined"))

            Case CodeTableType.CmIn

                Me.Add(New KeyValueInfo("cm", "cm"))
                Me.Add(New KeyValueInfo("in", "in"))

            Case CodeTableType.KgLb

                Me.Add(New KeyValueInfo("kg", "kg"))
                Me.Add(New KeyValueInfo("lb", "lb"))

            Case CodeTableType.HowWasSexDetermined

                Me.Add(New KeyValueInfo("N", "N - Necropsy"))
                Me.Add(New KeyValueInfo("T", "T - Tail Length (adult only)"))

            Case CodeTableType.StateCoordinatorNotified

                Me.Add(New KeyValueInfo("X", "X - Not Notified"))
                Me.Add(New KeyValueInfo("P", "P - Phone"))
                Me.Add(New KeyValueInfo("F", "F - Fax"))
                Me.Add(New KeyValueInfo("E", "E - E-mail"))

            Case CodeTableType.StrandingLocationShore

                Me.Add(New KeyValueInfo("O", "O - Offshore (Atlantic or Gulf beach)"))
                Me.Add(New KeyValueInfo("I", "I - Inshore (bay, river, sound, inlet, etc.)"))

            Case CodeTableType.InitialCondition

                Me.Add(New KeyValueInfo("0", "0 - Alive"))
                Me.Add(New KeyValueInfo("1", "1 - Fresh Dead"))
                Me.Add(New KeyValueInfo("2", "2 - Moderately Decomposed"))
                Me.Add(New KeyValueInfo("3", "3 - Severely Decomposed"))
                Me.Add(New KeyValueInfo("4", "4 - Dried Carcass"))
                Me.Add(New KeyValueInfo("5", "5 - Skeleton, Bones Only"))

            Case CodeTableType.Disposition

                Me.Add(New KeyValueInfo("1", "1 - Left On Beach Where Found"))
                Me.Add(New KeyValueInfo("2", "2 - Buried"))
                Me.Add(New KeyValueInfo("3", "3 - Salvaged"))
                Me.Add(New KeyValueInfo("4", "4 - Pulled Up On Beach/Dune"))
                Me.Add(New KeyValueInfo("6", "6 - Alive, Released"))
                Me.Add(New KeyValueInfo("7", "7 - Alive, Taken To Rehab Facility"))
                Me.Add(New KeyValueInfo("8", "8 - Left Floating, Not Recovered"))
                Me.Add(New KeyValueInfo("9", "9 - Disposition Unknown"))

            Case CodeTableType.BurialLocation

                Me.Add(New KeyValueInfo("N", "N - On Beach"))
                Me.Add(New KeyValueInfo("F", "F - Off Beach"))

            Case CodeTableType.PartsSalvagedType

                Me.Add(New KeyValueInfo("A", "A - All"))
                Me.Add(New KeyValueInfo("P", "P - Part(s)"))

            Case CodeTableType.WeightAccuracyType

                Me.Add(New KeyValueInfo("A", "A - Actual"))
                Me.Add(New KeyValueInfo("E", "E - Estimated"))

            Case CodeTableType.Flipper

                Me.Add(New KeyValueInfo("LFF", "LFF - Left Front Flipper"))
                Me.Add(New KeyValueInfo("LRF", "LRF - Left Rear Flipper"))
                Me.Add(New KeyValueInfo("RFF", "RFF - Right Front Flipper"))
                Me.Add(New KeyValueInfo("RRF", "RRF - Right Rear Flipper"))

            Case CodeTableType.PreferredUnitsType

                Me.Add(New KeyValueInfo("M", "M - Metric"))
                Me.Add(New KeyValueInfo("I", "I - Imperial"))

            Case CodeTableType.RecaptureType

                Me.Add(New KeyValueInfo("S", "S - Recapture of same project turtle"))
                Me.Add(New KeyValueInfo("D", "D - Recapture of different project turtle"))

            Case CodeTableType.CaptureProjectType

                Me.Add(New KeyValueInfo("N", "N - Nesting beach"))
                Me.Add(New KeyValueInfo("T", "T - Tangle net"))
                Me.Add(New KeyValueInfo("P", "P - Pound net"))
                Me.Add(New KeyValueInfo("H", "H - Hand catch"))
                Me.Add(New KeyValueInfo("S", "S - Stranding"))
                Me.Add(New KeyValueInfo("O", "O - Other"))

            Case CodeTableType.YesNoUndetermined

                Me.Add(New KeyValueInfo("Y", "Y - Yes"))
                Me.Add(New KeyValueInfo("N", "N - No"))
                Me.Add(New KeyValueInfo("U", "U - Undetermined"))

        End Select

        IsReadOnly = True

        RaiseListChangedEvents = True

    End Sub

#End Region

End Class
