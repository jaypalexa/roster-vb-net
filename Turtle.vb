Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class Turtle
    Inherits BusinessBase(Of Turtle)

#Region " Business Methods "

    Private msTurtleID As String = String.Empty
    Private msTurtleName As String = String.Empty
    Private msSidNumber As String = String.Empty
    Private msStrandingIdNumber As String = String.Empty
    Private msSpecies As String = String.Empty
    Private mdtDateCaptured As Date = Date.MinValue
    Private mdtDateAcquired As Date = Date.MinValue
    Private msAcquiredFrom As String = String.Empty
    Private msTurtleSize As String = String.Empty
    Private msStatus As String = String.Empty
    Private mdtDateRelinquished As Date = Date.MinValue
    Private msRelinquishedTo As String = String.Empty
    Private msAnomalies As String = String.Empty
    Private msReportTagNumberFieldData As String = String.Empty '<-- used only when reporting

    Private mbInjuryBoatStrike As Boolean = False
    Private mbInjuryIntestinalImpaction As Boolean = False
    Private mbInjuryLineEntanglement As Boolean = False
    Private mbInjuryFishHook As Boolean = False
    Private mbInjuryUpperRespiratory As Boolean = False
    Private mbInjuryAnimalBite As Boolean = False
    Private mbInjuryFibropapilloma As Boolean = False
    Private mbInjuryMiscEpidemic As Boolean = False
    Private mbInjuryDoa As Boolean = False
    Private mbInjuryOther As Boolean = False

    Private mbWasCarryingTagsWhenEncountered As Boolean = False
    Private msRecaptureType As String = String.Empty
    Private msTagReturnAddress As String = String.Empty
    Private msCaptureProjectType As String = String.Empty
    Private msDidTurtleNest As String = String.Empty
    Private msCaptureProjectOther As String = String.Empty
    Private msAcquiredCounty As String = String.Empty
    Private mfAcquiredLatitude As Double = Nothing
    Private mfAcquiredLongitude As Double = Nothing
    Private msRelinquishedCounty As String = String.Empty
    Private mfRelinquishedLatitude As Double = Nothing
    Private mfRelinquishedLongitude As Double = Nothing
    Private mbInspectedForTagScars As Boolean = False
    Private msTagScarsLocated As String = String.Empty
    Private mbScannedForPitTags As Boolean = False
    Private msPitTagsScanFrequency As String = String.Empty
    Private mbScannedForMagneticWires As Boolean = False
    Private msMagneticWiresLocated As String = String.Empty
    Private mbInspectedForLivingTags As Boolean = False
    Private msLivingTagsLocated As String = String.Empty

    Private msBrochureComments As String = String.Empty
    Private miBrochureBackgroundColor As Integer = -1   '-- ARGB value; -1 = White
    Private msBrochureImageFileAttachmentId As String = String.Empty

    Private moTurtleTags As TurtleTags = TurtleTags.NewTurtleTags()
    Private moTurtleMorphometrics As TurtleMorphometrics = TurtleMorphometrics.NewTurtleMorphometrics()
    Private moFileAttachments As TurtleFileAttachments = TurtleFileAttachments.NewTurtleFileAttachments()

    Public ReadOnly Property TurtleID() As String
        Get
            Return msTurtleID
        End Get
    End Property

    Public Property TurtleName() As String
        Get
            Return msTurtleName
        End Get
        Set(ByVal Value As String)
            If msTurtleName <> Value Then
                msTurtleName = Value
                PropertyHasChanged("TurtleName")
            End If
        End Set
    End Property

    Public Property SidNumber() As String
        Get
            Return msSidNumber
        End Get
        Set(ByVal Value As String)
            If msSidNumber <> Value Then
                msSidNumber = Value
                PropertyHasChanged("SidNumber")
            End If
        End Set
    End Property

    Public Property StrandingIdNumber() As String
        Get
            Return msStrandingIdNumber
        End Get
        Set(ByVal Value As String)
            If msStrandingIdNumber <> Value Then
                msStrandingIdNumber = Value
                PropertyHasChanged("StrandingIdNumber")
            End If
        End Set
    End Property

    Public Property Species() As String
        Get
            Return msSpecies
        End Get
        Set(ByVal Value As String)
            If msSpecies <> Value Then
                msSpecies = Value
                PropertyHasChanged("Species")
            End If
        End Set
    End Property

    Public Property DateCaptured() As Date
        Get
            Return DateAtMidnight(mdtDateCaptured)
        End Get
        Set(ByVal Value As Date)
            If HasDateValueChanged(mdtDateCaptured, Value) Then
                mdtDateCaptured = Value
                PropertyHasChanged("DateCaptured")
            End If
        End Set
    End Property

    Public ReadOnly Property DateCapturedString() As String
        Get
            Return DateAsString(mdtDateCaptured)
        End Get
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

    Public Property AcquiredFrom() As String
        Get
            Return msAcquiredFrom
        End Get
        Set(ByVal Value As String)
            If msAcquiredFrom <> Value Then
                msAcquiredFrom = Value
                PropertyHasChanged("AcquiredFrom")
            End If
        End Set
    End Property

    Public Property TurtleSize() As String
        Get
            Return msTurtleSize
        End Get
        Set(ByVal Value As String)
            If msTurtleSize <> Value Then
                msTurtleSize = Value
                PropertyHasChanged("TurtleSize")
            End If
        End Set
    End Property

    Public Property Status() As String
        Get
            Return msStatus
        End Get
        Set(ByVal Value As String)
            If msStatus <> Value Then
                msStatus = Value
                PropertyHasChanged("Status")
            End If
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

    Public Property RelinquishedTo() As String
        Get
            Return msRelinquishedTo
        End Get
        Set(ByVal Value As String)
            If msRelinquishedTo <> Value Then
                msRelinquishedTo = Value
                PropertyHasChanged("RelinquishedTo")
            End If
        End Set
    End Property

    Public Property Anomalies() As String
        Get
            Return msAnomalies
        End Get
        Set(ByVal Value As String)
            If msAnomalies <> Value Then
                msAnomalies = Value
                PropertyHasChanged("Anomalies")
            End If
        End Set
    End Property

    Public Property ReportTagNumberFieldData() As String
        Get
            Return msReportTagNumberFieldData
        End Get
        Set(ByVal Value As String)
            If msReportTagNumberFieldData <> Value Then
                msReportTagNumberFieldData = Value
                PropertyHasChanged("ReportTagNumberFieldData")
            End If
        End Set
    End Property

    Public Property InjuryBoatStrike() As Boolean
        Get
            Return mbInjuryBoatStrike
        End Get
        Set(ByVal Value As Boolean)
            If mbInjuryBoatStrike <> Value Then
                mbInjuryBoatStrike = Value
                PropertyHasChanged("InjuryBoatStrike")
            End If
        End Set
    End Property

    Public Property InjuryIntestinalImpaction() As Boolean
        Get
            Return mbInjuryIntestinalImpaction
        End Get
        Set(ByVal Value As Boolean)
            If mbInjuryIntestinalImpaction <> Value Then
                mbInjuryIntestinalImpaction = Value
                PropertyHasChanged("InjuryIntestinalImpaction")
            End If
        End Set
    End Property

    Public Property InjuryLineEntanglement() As Boolean
        Get
            Return mbInjuryLineEntanglement
        End Get
        Set(ByVal Value As Boolean)
            If mbInjuryLineEntanglement <> Value Then
                mbInjuryLineEntanglement = Value
                PropertyHasChanged("InjuryLineEntanglement")
            End If
        End Set
    End Property

    Public Property InjuryFishHook() As Boolean
        Get
            Return mbInjuryFishHook
        End Get
        Set(ByVal Value As Boolean)
            If mbInjuryFishHook <> Value Then
                mbInjuryFishHook = Value
                PropertyHasChanged("InjuryFishHook")
            End If
        End Set
    End Property

    Public Property InjuryUpperRespiratory() As Boolean
        Get
            Return mbInjuryUpperRespiratory
        End Get
        Set(ByVal Value As Boolean)
            If mbInjuryUpperRespiratory <> Value Then
                mbInjuryUpperRespiratory = Value
                PropertyHasChanged("InjuryUpperRespiratory")
            End If
        End Set
    End Property

    Public Property InjuryAnimalBite() As Boolean
        Get
            Return mbInjuryAnimalBite
        End Get
        Set(ByVal Value As Boolean)
            If mbInjuryAnimalBite <> Value Then
                mbInjuryAnimalBite = Value
                PropertyHasChanged("InjuryAnimalBite")
            End If
        End Set
    End Property

    Public Property InjuryFibropapilloma() As Boolean
        Get
            Return mbInjuryFibropapilloma
        End Get
        Set(ByVal Value As Boolean)
            If mbInjuryFibropapilloma <> Value Then
                mbInjuryFibropapilloma = Value
                PropertyHasChanged("InjuryFibropapilloma")
            End If
        End Set
    End Property

    Public Property InjuryMiscEpidemic() As Boolean
        Get
            Return mbInjuryMiscEpidemic
        End Get
        Set(ByVal Value As Boolean)
            If mbInjuryMiscEpidemic <> Value Then
                mbInjuryMiscEpidemic = Value
                PropertyHasChanged("InjuryMiscEpidemic")
            End If
        End Set
    End Property

    Public Property InjuryDoa() As Boolean
        Get
            Return mbInjuryDoa
        End Get
        Set(ByVal Value As Boolean)
            If mbInjuryDoa <> Value Then
                mbInjuryDoa = Value
                PropertyHasChanged("InjuryDoa")
            End If
        End Set
    End Property

    Public Property InjuryOther() As Boolean
        Get
            Return mbInjuryOther
        End Get
        Set(ByVal Value As Boolean)
            If mbInjuryOther <> Value Then
                mbInjuryOther = Value
                PropertyHasChanged("InjuryOther")
            End If
        End Set
    End Property

    Public Property WasCarryingTagsWhenEncountered() As Boolean
        Get
            Return mbWasCarryingTagsWhenEncountered
        End Get
        Set(ByVal Value As Boolean)
            If mbWasCarryingTagsWhenEncountered <> Value Then
                mbWasCarryingTagsWhenEncountered = Value
                PropertyHasChanged("WasCarryingTagsWhenEncountered")
            End If
        End Set
    End Property

    Public Property RecaptureType() As String
        Get
            Return msRecaptureType
        End Get
        Set(ByVal Value As String)
            If msRecaptureType <> Value Then
                msRecaptureType = Value
                PropertyHasChanged("RecaptureType")
            End If
        End Set
    End Property

    Public Property TagReturnAddress() As String
        Get
            Return msTagReturnAddress
        End Get
        Set(ByVal Value As String)
            If msTagReturnAddress <> Value Then
                msTagReturnAddress = Value
                PropertyHasChanged("TagReturnAddress")
            End If
        End Set
    End Property

    Public Property CaptureProjectType() As String
        Get
            Return msCaptureProjectType
        End Get
        Set(ByVal Value As String)
            If msCaptureProjectType <> Value Then
                msCaptureProjectType = Value
                PropertyHasChanged("CaptureProjectType")
            End If
        End Set
    End Property

    Public Property DidTurtleNest() As String
        Get
            Return msDidTurtleNest
        End Get
        Set(ByVal Value As String)
            If msDidTurtleNest <> Value Then
                msDidTurtleNest = Value
                PropertyHasChanged("DidTurtleNest")
            End If
        End Set
    End Property

    Public Property CaptureProjectOther() As String
        Get
            Return msCaptureProjectOther
        End Get
        Set(ByVal Value As String)
            If msCaptureProjectOther <> Value Then
                msCaptureProjectOther = Value
                PropertyHasChanged("CaptureProjectOther")
            End If
        End Set
    End Property

    Public Property AcquiredCounty() As String
        Get
            Return msAcquiredCounty
        End Get
        Set(ByVal Value As String)
            If msAcquiredCounty <> Value Then
                msAcquiredCounty = Value
                PropertyHasChanged("AcquiredCounty")
            End If
        End Set
    End Property

    Public Property AcquiredLatitude() As Double
        Get
            Return mfAcquiredLatitude
        End Get
        Set(ByVal Value As Double)
            If mfAcquiredLatitude <> Value Then
                mfAcquiredLatitude = Value
                PropertyHasChanged("AcquiredLatitude")
            End If
        End Set
    End Property

    Public Property AcquiredLatitudeString() As String
        Get
            If mfAcquiredLatitude = 0 Then
                Return String.Empty
            Else
                Return mfAcquiredLatitude.ToString("0.00000")
            End If
        End Get
        Set(ByVal Value As String)
            If mfAcquiredLatitude <> Convert.ToDouble(Val(Value)) Then
                mfAcquiredLatitude = Convert.ToDouble(Val(Value))
                PropertyHasChanged("AcquiredLatitudeString")
            End If
        End Set
    End Property

    Public Property AcquiredLongitude() As Double
        Get
            Return mfAcquiredLongitude
        End Get
        Set(ByVal Value As Double)
            If mfAcquiredLongitude <> Value Then
                mfAcquiredLongitude = Value
                PropertyHasChanged("AcquiredLongitude")
            End If
        End Set
    End Property

    Public Property AcquiredLongitudeString() As String
        Get
            If mfAcquiredLongitude = 0 Then
                Return String.Empty
            Else
                Return mfAcquiredLongitude.ToString("0.00000")
            End If
        End Get
        Set(ByVal Value As String)
            If mfAcquiredLongitude <> Convert.ToDouble(Val(Value)) Then
                mfAcquiredLongitude = Convert.ToDouble(Val(Value))
                PropertyHasChanged("AcquiredLongitudeString")
            End If
        End Set
    End Property

    Public Property RelinquishedCounty() As String
        Get
            Return msRelinquishedCounty
        End Get
        Set(ByVal Value As String)
            If msRelinquishedCounty <> Value Then
                msRelinquishedCounty = Value
                PropertyHasChanged("RelinquishedCounty")
            End If
        End Set
    End Property

    Public Property RelinquishedLatitude() As Double
        Get
            Return mfRelinquishedLatitude
        End Get
        Set(ByVal Value As Double)
            If mfRelinquishedLatitude <> Value Then
                mfRelinquishedLatitude = Value
                PropertyHasChanged("RelinquishedLatitude")
            End If
        End Set
    End Property

    Public Property RelinquishedLatitudeString() As String
        Get
            If mfRelinquishedLatitude = 0 Then
                Return String.Empty
            Else
                Return mfRelinquishedLatitude.ToString("0.00000")
            End If
        End Get
        Set(ByVal Value As String)
            If mfRelinquishedLatitude <> Convert.ToDouble(Val(Value)) Then
                mfRelinquishedLatitude = Convert.ToDouble(Val(Value))
                PropertyHasChanged("RelinquishedLatitudeString")
            End If
        End Set
    End Property

    Public Property RelinquishedLongitude() As Double
        Get
            Return mfRelinquishedLongitude
        End Get
        Set(ByVal Value As Double)
            If mfRelinquishedLongitude <> Value Then
                mfRelinquishedLongitude = Value
                PropertyHasChanged("RelinquishedLongitude")
            End If
        End Set
    End Property

    Public Property RelinquishedLongitudeString() As String
        Get
            If mfRelinquishedLongitude = 0 Then
                Return String.Empty
            Else
                Return mfRelinquishedLongitude.ToString("0.00000")
            End If
        End Get
        Set(ByVal Value As String)
            If mfRelinquishedLongitude <> Convert.ToDouble(Val(Value)) Then
                mfRelinquishedLongitude = Convert.ToDouble(Val(Value))
                PropertyHasChanged("RelinquishedLongitudeString")
            End If
        End Set
    End Property

    Public Property InspectedForTagScars() As Boolean
        Get
            Return mbInspectedForTagScars
        End Get
        Set(ByVal Value As Boolean)
            If mbInspectedForTagScars <> Value Then
                mbInspectedForTagScars = Value
                PropertyHasChanged("InspectedForTagScars")
            End If
        End Set
    End Property

    Public Property TagScarsLocated() As String
        Get
            Return msTagScarsLocated
        End Get
        Set(ByVal Value As String)
            If msTagScarsLocated <> Value Then
                msTagScarsLocated = Value
                PropertyHasChanged("TagScarsLocated")
            End If
        End Set
    End Property

    Public Property ScannedForPitTags() As Boolean
        Get
            Return mbScannedForPitTags
        End Get
        Set(ByVal Value As Boolean)
            If mbScannedForPitTags <> Value Then
                mbScannedForPitTags = Value
                PropertyHasChanged("ScannedForPitTags")
            End If
        End Set
    End Property

    Public Property PitTagsScanFrequency() As String
        Get
            Return msPitTagsScanFrequency
        End Get
        Set(ByVal Value As String)
            If msPitTagsScanFrequency <> Value Then
                msPitTagsScanFrequency = Value
                PropertyHasChanged("PitTagsScanFrequency")
            End If
        End Set
    End Property

    Public Property ScannedForMagneticWires() As Boolean
        Get
            Return mbScannedForMagneticWires
        End Get
        Set(ByVal Value As Boolean)
            If mbScannedForMagneticWires <> Value Then
                mbScannedForMagneticWires = Value
                PropertyHasChanged("ScannedForMagneticWires")
            End If
        End Set
    End Property

    Public Property MagneticWiresLocated() As String
        Get
            Return msMagneticWiresLocated
        End Get
        Set(ByVal Value As String)
            If msMagneticWiresLocated <> Value Then
                msMagneticWiresLocated = Value
                PropertyHasChanged("MagneticWiresLocated")
            End If
        End Set
    End Property

    Public Property InspectedForLivingTags() As Boolean
        Get
            Return mbInspectedForLivingTags
        End Get
        Set(ByVal Value As Boolean)
            If mbInspectedForLivingTags <> Value Then
                mbInspectedForLivingTags = Value
                PropertyHasChanged("InspectedForLivingTags")
            End If
        End Set
    End Property

    Public Property LivingTagsLocated() As String
        Get
            Return msLivingTagsLocated
        End Get
        Set(ByVal Value As String)
            If msLivingTagsLocated <> Value Then
                msLivingTagsLocated = Value
                PropertyHasChanged("LivingTagsLocated")
            End If
        End Set
    End Property

    Public Property BrochureComments() As String
        Get
            Return msBrochureComments
        End Get
        Set(ByVal Value As String)
            If msBrochureComments <> Value Then
                msBrochureComments = Value
                PropertyHasChanged("BrochureComments")
            End If
        End Set
    End Property

    Public Property BrochureBackgroundColor() As Integer
        Get
            Return miBrochureBackgroundColor
        End Get
        Set(ByVal Value As Integer)
            If miBrochureBackgroundColor <> Value Then
                miBrochureBackgroundColor = Value
                PropertyHasChanged("BrochureBackgroundColor")
            End If
        End Set
    End Property

    Public Property BrochureImageFileAttachmentId() As String
        Get
            Return msBrochureImageFileAttachmentId
        End Get
        Set(ByVal Value As String)
            If msBrochureImageFileAttachmentId <> Value Then
                msBrochureImageFileAttachmentId = Value
                PropertyHasChanged("BrochureImageFileAttachmentId")
            End If
        End Set
    End Property

    Public ReadOnly Property TurtleTags() As TurtleTags
        Get
            Return moTurtleTags
        End Get
    End Property

    Public ReadOnly Property TurtleMorphometrics() As TurtleMorphometrics
        Get
            Return moTurtleMorphometrics
        End Get
    End Property

    Public ReadOnly Property FileAttachments() As TurtleFileAttachments
        Get
            Return moFileAttachments
        End Get
    End Property

    Public Overrides ReadOnly Property IsValid() As Boolean
        Get
            Return MyBase.IsValid AndAlso moTurtleTags.IsValid AndAlso moTurtleMorphometrics.IsValid AndAlso moFileAttachments.IsValid
        End Get
    End Property

    Public Overrides ReadOnly Property IsDirty() As Boolean
        Get
            Return MyBase.IsDirty OrElse moTurtleTags.IsDirty OrElse moTurtleMorphometrics.IsDirty OrElse moFileAttachments.IsDirty
        End Get
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return msTurtleID
    End Function

    Public Function GetBrokenRulesString() As String

        Dim s As String = String.Empty

        s &= Me.BrokenRulesCollection.ToString

        If moTurtleTags IsNot Nothing Then
            s &= moTurtleTags.GetBrokenRulesString
        End If

        If moTurtleMorphometrics IsNot Nothing Then
            s &= moTurtleMorphometrics.GetBrokenRulesString
        End If

        If moFileAttachments IsNot Nothing Then
            s &= moFileAttachments.GetBrokenRulesString
        End If

        Return s

    End Function

#End Region

#Region " Validation Rules "

    Protected Overrides Sub AddBusinessRules()

        'ValidationRules.AddRule(AddressOf Validation.CommonRules.StringRequired, New Validation.RuleArgs("TurtleName", "Turtle Name"))
        ValidationRules.AddRule(AddressOf Validation.CommonRules.StringMaxLength, New Validation.CommonRules.MaxLengthRuleArgs("TurtleName", "Turtle Name", 255))

    End Sub

#End Region

#Region " Authorization Rules "

    Protected Overrides Sub AddAuthorizationRules()

        ' add AuthorizationRules here

    End Sub

    Public Shared Function CanAddObject() As Boolean

        Return True

    End Function

    Public Shared Function CanGetObject() As Boolean

        Return True

    End Function

    Public Shared Function CanDeleteObject() As Boolean

        Return True

    End Function

    Public Shared Function CanEditObject() As Boolean

        Return True

    End Function

#End Region

#Region " Factory Methods "

    Public Shared Function NewTurtle() As Turtle

        Dim oTurtle As Turtle
        oTurtle = DataPortal.Create(Of Turtle)()
        oTurtle.MarkClean()
        Return oTurtle

        'Return DataPortal.Create(Of Turtle)()

    End Function

    Public Shared Function GetTurtle(ByVal sTurtleId As String) As Turtle

        Return DataPortal.Fetch(Of Turtle)(New Criteria(sTurtleId))

    End Function

    Public Shared Sub DeleteTurtle(ByVal sTurtleId As String)

        DataPortal.Delete(New Criteria(sTurtleId))

    End Sub

    Public Overrides Function Save() As Turtle

        Return MyBase.Save

    End Function

    Private Sub New()
        ' require use of factory methods
    End Sub

#End Region

#Region " Data Access "

    <Serializable()> _
    Private Class Criteria

        Private msTurtleId As String
        Public ReadOnly Property TurtleId() As String
            Get
                Return msTurtleId
            End Get
        End Property

        Public Sub New(ByVal sTurtleId As String)
            msTurtleId = sTurtleId
        End Sub
    End Class

    <RunLocal()> _
    Protected Overrides Sub DataPortal_Create()

        msTurtleID = Guid.NewGuid.ToString.ToUpper
        msTurtleName = String.Empty
        msSidNumber = String.Empty
        msSpecies = String.Empty
        mdtDateCaptured = Date.MinValue
        mdtDateAcquired = DateAtMidnight(Date.Now)
        msAcquiredFrom = String.Empty
        msTurtleSize = String.Empty
        msStatus = String.Empty
        mdtDateRelinquished = Date.MinValue
        msRelinquishedTo = String.Empty
        msReportTagNumberFieldData = String.Empty
        mbInjuryBoatStrike = False
        mbInjuryIntestinalImpaction = False
        mbInjuryLineEntanglement = False
        mbInjuryFishHook = False
        mbInjuryUpperRespiratory = False
        mbInjuryAnimalBite = False
        mbInjuryFibropapilloma = False
        mbInjuryMiscEpidemic = False
        mbInjuryDoa = False
        mbInjuryOther = False

        mbWasCarryingTagsWhenEncountered = False
        msRecaptureType = String.Empty
        msTagReturnAddress = String.Empty
        msCaptureProjectType = String.Empty
        msDidTurtleNest = String.Empty
        msCaptureProjectOther = String.Empty
        msAcquiredCounty = String.Empty
        mfAcquiredLatitude = Nothing
        mfAcquiredLongitude = Nothing
        msRelinquishedCounty = String.Empty
        mfRelinquishedLatitude = Nothing
        mfRelinquishedLongitude = Nothing
        mbInspectedForTagScars = False
        msTagScarsLocated = String.Empty
        mbScannedForPitTags = False
        msPitTagsScanFrequency = String.Empty
        mbScannedForMagneticWires = False
        msMagneticWiresLocated = String.Empty
        mbInspectedForLivingTags = False
        msLivingTagsLocated = String.Empty

        msBrochureComments = String.Empty
        miBrochureBackgroundColor = -1   '-- ARGB value; -1 = White
        msBrochureImageFileAttachmentId = String.Empty

        moTurtleTags = TurtleTags.NewTurtleTags()
        moTurtleMorphometrics = TurtleMorphometrics.NewTurtleMorphometrics()
        moFileAttachments = TurtleFileAttachments.NewTurtleFileAttachments()

        ValidationRules.CheckRules()

        'v-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew
        'MarkClean()
        '^-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew

    End Sub

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteria As Criteria)

        Dim s As String = String.Empty

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            '----------------------------------------------------------------
            '-- get data for root object -- TURTLE
            '----------------------------------------------------------------
            s = "SELECT * FROM turtle "
            s &= "WHERE " & oAdoHelper.UpperFunction & "(turtle_id) = " & oAdoHelper.UpperFunction & "(@turtle_id) "

            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(CommandType.Text, s, oAdoHelper.GetParameter("@turtle_id", oCriteria.TurtleId))

                If dr.Read() Then

                    With dr
                        msTurtleID = .GetString("turtle_id").Trim.ToUpper
                        msTurtleName = .GetString("turtle_name")
                        msSidNumber = dr.GetString("sid_number")
                        msStrandingIdNumber = dr.GetString("stranding_id_number")
                        msSpecies = dr.GetString("species")
                        mdtDateCaptured = dr.GetDateTime("date_captured")
                        mdtDateAcquired = dr.GetDateTime("date_acquired")
                        msAcquiredFrom = dr.GetString("acquired_from")
                        msTurtleSize = dr.GetString("turtle_size")
                        msStatus = dr.GetString("status")
                        mdtDateRelinquished = dr.GetDateTime("date_relinquished")
                        msRelinquishedTo = dr.GetString("relinquished_to")
                        msAnomalies = dr.GetString("anomalies")
                        mbInjuryBoatStrike = dr.GetBooleanString("injury_boat_strike")
                        mbInjuryIntestinalImpaction = dr.GetBooleanString("injury_intestinal_impaction")
                        mbInjuryLineEntanglement = dr.GetBooleanString("injury_line_entanglement")
                        mbInjuryFishHook = dr.GetBooleanString("injury_fish_hook")
                        mbInjuryUpperRespiratory = dr.GetBooleanString("injury_upper_respiratory")
                        mbInjuryAnimalBite = dr.GetBooleanString("injury_animal_bite")
                        mbInjuryFibropapilloma = dr.GetBooleanString("injury_fibropapilloma")
                        mbInjuryMiscEpidemic = dr.GetBooleanString("injury_misc_epidemic")
                        mbInjuryDoa = dr.GetBooleanString("injury_doa")
                        mbInjuryOther = dr.GetBooleanString("injury_other")
                        mbWasCarryingTagsWhenEncountered = dr.GetBooleanString("was_carrying_tags_when_enc")
                        msRecaptureType = dr.GetString("recapture_type")
                        msTagReturnAddress = dr.GetString("tag_return_address")
                        msCaptureProjectType = dr.GetString("capture_project_type")
                        msDidTurtleNest = dr.GetString("did_turtle_nest")
                        msCaptureProjectOther = dr.GetString("capture_project_other")
                        msAcquiredCounty = dr.GetString("acquired_county")
                        mfAcquiredLatitude = dr.GetDouble("acquired_latitude")
                        mfAcquiredLongitude = dr.GetDouble("acquired_longitude")
                        msRelinquishedCounty = dr.GetString("relinquished_county")
                        mfRelinquishedLatitude = dr.GetDouble("relinquished_latitude")
                        mfRelinquishedLongitude = dr.GetDouble("relinquished_longitude")
                        mbInspectedForTagScars = dr.GetBooleanString("inspected_for_tag_scars")
                        msTagScarsLocated = dr.GetString("tag_scars_located")
                        mbScannedForPitTags = dr.GetBooleanString("scanned_for_pit_tags")
                        msPitTagsScanFrequency = dr.GetString("pit_tags_scan_frequency")
                        mbScannedForMagneticWires = dr.GetBooleanString("scanned_for_magnetic_wires")
                        msMagneticWiresLocated = dr.GetString("magnetic_wires_located")
                        mbInspectedForLivingTags = dr.GetBooleanString("inspected_for_living_tags")
                        msLivingTagsLocated = dr.GetString("living_tags_located")
                        msBrochureComments = dr.GetString("brochure_comments")
                        miBrochureBackgroundColor = dr.GetInt32("brochure_background_color")
                        msBrochureImageFileAttachmentId = dr.GetString("brochure_image_file_attachment_id")
                    End With

                End If

            End Using

            '----------------------------------------------------------------
            '-- get data for children -- TURTLE TAGS
            '----------------------------------------------------------------
            s = "SELECT * FROM turtle_tag "
            s &= "WHERE " & oAdoHelper.UpperFunction & "(turtle_id) = " & oAdoHelper.UpperFunction & "(@turtle_id) "

            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(CommandType.Text, s, oAdoHelper.GetParameter("@turtle_id", oCriteria.TurtleId))

                moTurtleTags = TurtleTags.GetTurtleTags(dr)

            End Using

            '----------------------------------------------------------------
            '-- get data for children -- TURTLE MORPHOMETRICS
            '----------------------------------------------------------------
            s = "SELECT * FROM turtle_morphometric "
            s &= "WHERE " & oAdoHelper.UpperFunction & "(turtle_id) = " & oAdoHelper.UpperFunction & "(@turtle_id) "

            Using dr As SafeDataReader = oAdoHelper.ExecuteReader(CommandType.Text, s, oAdoHelper.GetParameter("@turtle_id", oCriteria.TurtleId))

                moTurtleMorphometrics = TurtleMorphometrics.GetTurtleMorphometrics(dr)

            End Using

            '----------------------------------------------------------------
            '-- get data for children -- FILE ATTACHMENTS
            '----------------------------------------------------------------
            moFileAttachments = TurtleFileAttachments.GetTurtleFileAttachments(oCriteria.TurtleId)

        End Using

    End Sub

    Protected Overrides Sub DataPortal_Insert()

        Dim s As String = String.Empty

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()
                Csla.ApplicationContext.LocalContext("cn") = cn

                Using ts As TransactionScope = New TransactionScope()

                    Using cm As IDbCommand = cn.CreateCommand()

                        s &= "INSERT INTO turtle ("
                        s &= "turtle_name, sid_number, stranding_id_number, species, date_captured, date_acquired, acquired_from, turtle_size, status, "
                        s &= "date_relinquished, relinquished_to, anomalies, "
                        s &= "injury_boat_strike, injury_intestinal_impaction, injury_line_entanglement, injury_fish_hook, injury_upper_respiratory, "
                        s &= "injury_animal_bite, injury_fibropapilloma, injury_misc_epidemic, injury_doa, injury_other, "
                        s &= "was_carrying_tags_when_enc, recapture_type, tag_return_address, capture_project_type, did_turtle_nest, capture_project_other, "
                        s &= "acquired_county, acquired_latitude, acquired_longitude, "
                        s &= "relinquished_county, relinquished_latitude, relinquished_longitude, "
                        s &= "inspected_for_tag_scars, tag_scars_located, scanned_for_pit_tags, pit_tags_scan_frequency, "
                        s &= "scanned_for_magnetic_wires, magnetic_wires_located, inspected_for_living_tags, living_tags_located, "
                        s &= "brochure_comments, brochure_background_color, brochure_image_file_attachment_id, "
                        s &= "turtle_id "
                        s &= ") VALUES ("
                        s &= "@turtle_name, @sid_number, @stranding_id_number, @species, @date_captured, @date_acquired, @acquired_from, @turtle_size, @status, "
                        s &= "@date_relinquished, @relinquished_to, @anomalies, "
                        s &= "@injury_boat_strike, @injury_intestinal_impaction, @injury_line_entanglement, @injury_fish_hook, @injury_upper_respiratory, "
                        s &= "@injury_animal_bite, @injury_fibropapilloma, @injury_misc_epidemic, @injury_doa, @injury_other, "
                        s &= "@was_carrying_tags_when_enc, @recapture_type, @tag_return_address, @capture_project_type, @did_turtle_nest, @capture_project_other, "
                        s &= "@acquired_county, @acquired_latitude, @acquired_longitude, "
                        s &= "@relinquished_county, @relinquished_latitude, @relinquished_longitude, "
                        s &= "@inspected_for_tag_scars, @tag_scars_located, @scanned_for_pit_tags, @pit_tags_scan_frequency, "
                        s &= "@scanned_for_magnetic_wires, @magnetic_wires_located, @inspected_for_living_tags, @living_tags_located, "
                        s &= "@brochure_comments, @brochure_background_color, @brochure_image_file_attachment_id, "
                        s &= "@turtle_id "
                        s &= ")"

                        cm.CommandText = s
                        DoInsertUpdate(cm)

                    End Using ' cm

                    ' update child objects
                    moTurtleTags.Update(Me)
                    moTurtleMorphometrics.Update(Me)
                    moFileAttachments.Update(Me)

                    ' removing of item only needed for local data portal
                    If (Csla.ApplicationContext.ExecutionLocation = ExecutionLocations.Client) Then
                        Csla.ApplicationContext.LocalContext.Remove("cn")
                    End If

                End Using ' ts

            End Using ' cn 

        End Using ' oAdoHelper

    End Sub

    Protected Overrides Sub DataPortal_Update()

        Dim s As String = String.Empty

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()
                Csla.ApplicationContext.LocalContext("cn") = cn

                Using ts As TransactionScope = New TransactionScope()

                    If MyBase.IsDirty Then

                        Using cm As IDbCommand = cn.CreateCommand()

                            s &= "UPDATE turtle SET "
                            s &= "turtle_name = @turtle_name, "
                            s &= "sid_number = @sid_number, "
                            s &= "stranding_id_number = @stranding_id_number, "
                            s &= "species = @species, "
                            s &= "date_captured = @date_captured, "
                            s &= "date_acquired = @date_acquired, "
                            s &= "acquired_from = @acquired_from, "
                            s &= "turtle_size = @turtle_size, "
                            s &= "status = @status, "
                            s &= "date_relinquished = @date_relinquished, "
                            s &= "relinquished_to = @relinquished_to, "
                            s &= "anomalies = @anomalies, "
                            s &= "injury_boat_strike = @injury_boat_strike, "
                            s &= "injury_intestinal_impaction = @injury_intestinal_impaction, "
                            s &= "injury_line_entanglement = @injury_line_entanglement, "
                            s &= "injury_fish_hook = @injury_fish_hook, "
                            s &= "injury_upper_respiratory = @injury_upper_respiratory, "
                            s &= "injury_animal_bite = @injury_animal_bite, "
                            s &= "injury_fibropapilloma = @injury_fibropapilloma, "
                            s &= "injury_misc_epidemic = @injury_misc_epidemic, "
                            s &= "injury_doa = @injury_doa, "
                            s &= "injury_other = @injury_other, "
                            s &= "was_carrying_tags_when_enc = @was_carrying_tags_when_enc, "
                            s &= "recapture_type = @recapture_type, "
                            s &= "tag_return_address = @tag_return_address, "
                            s &= "capture_project_type = @capture_project_type, "
                            s &= "did_turtle_nest = @did_turtle_nest, "
                            s &= "capture_project_other = @capture_project_other, "
                            s &= "acquired_county = @acquired_county, "
                            s &= "acquired_latitude = @acquired_latitude, "
                            s &= "acquired_longitude = @acquired_longitude, "
                            s &= "relinquished_county = @relinquished_county, "
                            s &= "relinquished_latitude = @relinquished_latitude, "
                            s &= "relinquished_longitude = @relinquished_longitude, "
                            s &= "inspected_for_tag_scars = @inspected_for_tag_scars, "
                            s &= "tag_scars_located = @tag_scars_located, "
                            s &= "scanned_for_pit_tags = @scanned_for_pit_tags, "
                            s &= "pit_tags_scan_frequency = @pit_tags_scan_frequency, "
                            s &= "scanned_for_magnetic_wires = @scanned_for_magnetic_wires, "
                            s &= "magnetic_wires_located = @magnetic_wires_located, "
                            s &= "inspected_for_living_tags = @inspected_for_living_tags, "
                            s &= "living_tags_located = @living_tags_located, "
                            s &= "brochure_comments = @brochure_comments, "
                            s &= "brochure_background_color = @brochure_background_color, "
                            s &= "brochure_image_file_attachment_id = @brochure_image_file_attachment_id "
                            s &= "WHERE " & oAdoHelper.UpperFunction & "(turtle_id) = " & oAdoHelper.UpperFunction & "(@turtle_id) "

                            cm.CommandText = s
                            DoInsertUpdate(cm)

                        End Using ' cm

                    End If

                    ' update child objects
                    moTurtleTags.Update(Me)
                    moTurtleMorphometrics.Update(Me)
                    moFileAttachments.Update(Me)

                    ' removing of item only needed for local data portal
                    If (Csla.ApplicationContext.ExecutionLocation = ExecutionLocations.Client) Then
                        Csla.ApplicationContext.LocalContext.Remove("cn")
                    End If

                End Using ' ts

            End Using ' cn 

        End Using ' oAdoHelper

    End Sub

    Private Sub DoInsertUpdate(ByVal cm As IDbCommand)

        If Not mbWasCarryingTagsWhenEncountered Then
            msRecaptureType = String.Empty
            msTagReturnAddress = String.Empty
        End If

        If String.IsNullOrEmpty(msCaptureProjectType) Then
            msDidTurtleNest = String.Empty
            msCaptureProjectOther = String.Empty
        ElseIf (msCaptureProjectType = "N") Then
            msCaptureProjectOther = String.Empty
        ElseIf (msCaptureProjectType = "O") Then
            msDidTurtleNest = String.Empty
        End If

        If Not mbInspectedForTagScars Then
            msTagScarsLocated = String.Empty
        End If

        If Not mbScannedForPitTags Then
            msPitTagsScanFrequency = String.Empty
        End If

        If Not mbScannedForMagneticWires Then
            msMagneticWiresLocated = String.Empty
        End If

        If Not mbInspectedForLivingTags Then
            msLivingTagsLocated = String.Empty
        End If

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
            With cm
                .CommandType = CommandType.Text
                .Parameters.Add(oAdoHelper.GetParameter("@turtle_name", msTurtleName))
                .Parameters.Add(oAdoHelper.GetParameter("@sid_number", msSidNumber))
                .Parameters.Add(oAdoHelper.GetParameter("@stranding_id_number", msStrandingIdNumber))
                .Parameters.Add(oAdoHelper.GetParameter("@species", msSpecies))
                .Parameters.Add(oAdoHelper.GetParameter("@date_captured", AdoHelper.DbSetDate(mdtDateCaptured)))
                .Parameters.Add(oAdoHelper.GetParameter("@date_acquired", AdoHelper.DbSetDate(mdtDateAcquired)))
                .Parameters.Add(oAdoHelper.GetParameter("@acquired_from", msAcquiredFrom))
                .Parameters.Add(oAdoHelper.GetParameter("@turtle_size", msTurtleSize))
                .Parameters.Add(oAdoHelper.GetParameter("@status", msStatus))
                .Parameters.Add(oAdoHelper.GetParameter("@date_relinquished", AdoHelper.DbSetDate(mdtDateRelinquished)))
                .Parameters.Add(oAdoHelper.GetParameter("@relinquished_to", msRelinquishedTo))
                .Parameters.Add(oAdoHelper.GetParameter("@anomalies", msAnomalies))
                .Parameters.Add(oAdoHelper.GetParameter("@injury_boat_strike", AdoHelper.DbSetBooleanString(mbInjuryBoatStrike)))
                .Parameters.Add(oAdoHelper.GetParameter("@injury_intestinal_impaction", AdoHelper.DbSetBooleanString(mbInjuryIntestinalImpaction)))
                .Parameters.Add(oAdoHelper.GetParameter("@injury_line_entanglement", AdoHelper.DbSetBooleanString(mbInjuryLineEntanglement)))
                .Parameters.Add(oAdoHelper.GetParameter("@injury_fish_hook", AdoHelper.DbSetBooleanString(mbInjuryFishHook)))
                .Parameters.Add(oAdoHelper.GetParameter("@injury_upper_respiratory", AdoHelper.DbSetBooleanString(mbInjuryUpperRespiratory)))
                .Parameters.Add(oAdoHelper.GetParameter("@injury_animal_bite", AdoHelper.DbSetBooleanString(mbInjuryAnimalBite)))
                .Parameters.Add(oAdoHelper.GetParameter("@injury_fibropapilloma", AdoHelper.DbSetBooleanString(mbInjuryFibropapilloma)))
                .Parameters.Add(oAdoHelper.GetParameter("@injury_misc_epidemic", AdoHelper.DbSetBooleanString(mbInjuryMiscEpidemic)))
                .Parameters.Add(oAdoHelper.GetParameter("@injury_doa", AdoHelper.DbSetBooleanString(mbInjuryDoa)))
                .Parameters.Add(oAdoHelper.GetParameter("@injury_other", AdoHelper.DbSetBooleanString(mbInjuryOther)))
                .Parameters.Add(oAdoHelper.GetParameter("@was_carrying_tags_when_enc", AdoHelper.DbSetBooleanString(mbWasCarryingTagsWhenEncountered)))
                .Parameters.Add(oAdoHelper.GetParameter("@recapture_type", msRecaptureType))
                .Parameters.Add(oAdoHelper.GetParameter("@tag_return_address", msTagReturnAddress))
                .Parameters.Add(oAdoHelper.GetParameter("@capture_project_type", msCaptureProjectType))
                .Parameters.Add(oAdoHelper.GetParameter("@did_turtle_nest", msDidTurtleNest))
                .Parameters.Add(oAdoHelper.GetParameter("@capture_project_other", msCaptureProjectOther))
                .Parameters.Add(oAdoHelper.GetParameter("@acquired_county", msAcquiredCounty))
                .Parameters.Add(oAdoHelper.GetParameter("@acquired_latitude", mfAcquiredLatitude))
                .Parameters.Add(oAdoHelper.GetParameter("@acquired_longitude", mfAcquiredLongitude))
                .Parameters.Add(oAdoHelper.GetParameter("@relinquished_county", msRelinquishedCounty))
                .Parameters.Add(oAdoHelper.GetParameter("@relinquished_latitude", mfRelinquishedLatitude))
                .Parameters.Add(oAdoHelper.GetParameter("@relinquished_longitude", mfRelinquishedLongitude))
                .Parameters.Add(oAdoHelper.GetParameter("@inspected_for_tag_scars", AdoHelper.DbSetBooleanString(mbInspectedForTagScars)))
                .Parameters.Add(oAdoHelper.GetParameter("@tag_scars_located", msTagScarsLocated))
                .Parameters.Add(oAdoHelper.GetParameter("@scanned_for_pit_tags", AdoHelper.DbSetBooleanString(mbScannedForPitTags)))
                .Parameters.Add(oAdoHelper.GetParameter("@pit_tags_scan_frequency", msPitTagsScanFrequency))
                .Parameters.Add(oAdoHelper.GetParameter("@scanned_for_magnetic_wires", AdoHelper.DbSetBooleanString(mbScannedForMagneticWires)))
                .Parameters.Add(oAdoHelper.GetParameter("@magnetic_wires_located", msMagneticWiresLocated))
                .Parameters.Add(oAdoHelper.GetParameter("@inspected_for_living_tags", AdoHelper.DbSetBooleanString(mbInspectedForLivingTags)))
                .Parameters.Add(oAdoHelper.GetParameter("@living_tags_located", msLivingTagsLocated))
                .Parameters.Add(oAdoHelper.GetParameter("@brochure_comments", msBrochureComments))
                .Parameters.Add(oAdoHelper.GetParameter("@brochure_background_color", miBrochureBackgroundColor))
                .Parameters.Add(oAdoHelper.GetParameter("@brochure_image_file_attachment_id", msBrochureImageFileAttachmentId))
                .Parameters.Add(oAdoHelper.GetParameter("@turtle_id", msTurtleID))
                oAdoHelper.ExecuteNonQuery(cm)
            End With
        End Using

    End Sub

    Protected Overrides Sub DataPortal_DeleteSelf()

        DataPortal_Delete(New Criteria(msTurtleID))

    End Sub

    Private Overloads Sub DataPortal_Delete(ByVal oCriteria As Criteria)

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()

                Using ts As TransactionScope = New TransactionScope()

                    Using cm As IDbCommand = cn.CreateCommand()

                        '----------------------------------------------------------------
                        '-- cascade the deletion to the child items
                        '----------------------------------------------------------------
                        'cm.CommandType = CommandType.Text
                        'cm.CommandText = "INSERT INTO deleted_turtle_morphometric SELECT * FROM turtle_morphometric WHERE " & oAdoHelper.UpperFunction & "(turtle_id) = " & oAdoHelper.UpperFunction & "(@turtle_id)"
                        'cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_id", oCriteria.TurtleId.ToUpper))
                        'oAdoHelper.ExecuteNonQuery(cm)

                        cm.CommandType = CommandType.Text
                        cm.CommandText = "DELETE FROM turtle_morphometric WHERE " & oAdoHelper.UpperFunction & "(turtle_id) = " & oAdoHelper.UpperFunction & "(@turtle_id)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_id", oCriteria.TurtleId.ToUpper))
                        oAdoHelper.ExecuteNonQuery(cm)

                        ''----------------------------------------------------------------
                        ''-- archive the record being deleted
                        ''----------------------------------------------------------------
                        'cm.CommandType = CommandType.Text
                        'cm.CommandText = "INSERT INTO deleted_turtle_tag SELECT * FROM turtle_tag WHERE " & oAdoHelper.UpperFunction & "(turtle_id) = " & oAdoHelper.UpperFunction & "(@turtle_id)"
                        'cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_id", oCriteria.TurtleId.ToUpper))
                        'oAdoHelper.ExecuteNonQuery(cm)

                        cm.CommandType = CommandType.Text
                        cm.CommandText = "DELETE FROM turtle_tag WHERE " & oAdoHelper.UpperFunction & "(turtle_id) = " & oAdoHelper.UpperFunction & "(@turtle_id)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_id", oCriteria.TurtleId.ToUpper))
                        oAdoHelper.ExecuteNonQuery(cm)

                        ''----------------------------------------------------------------
                        ''-- archive the record being deleted
                        ''----------------------------------------------------------------
                        'cm.CommandType = CommandType.Text
                        'cm.CommandText = "INSERT INTO deleted_turtle SELECT * FROM turtle WHERE " & oAdoHelper.UpperFunction & "(turtle_id) = " & oAdoHelper.UpperFunction & "(@turtle_id)"
                        'cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_id", oCriteria.TurtleId.ToUpper))
                        'oAdoHelper.ExecuteNonQuery(cm)

                        '----------------------------------------------------------------
                        '-- finally, delete the root record
                        '----------------------------------------------------------------
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "DELETE FROM turtle WHERE " & oAdoHelper.UpperFunction & "(turtle_id) = " & oAdoHelper.UpperFunction & "(@turtle_id)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_id", oCriteria.TurtleId.ToUpper))
                        oAdoHelper.ExecuteNonQuery(cm)

                    End Using ' cm

                End Using ' ts

            End Using ' cn

        End Using ' oAdoHelper

    End Sub

#End Region

#Region " Exists "

    Public Shared Function Exists(ByVal sTurtleId As String) As Boolean

        Dim oExistsCommand As ExistsCommand

        oExistsCommand = DataPortal.Execute(Of ExistsCommand)(New ExistsCommand(sTurtleId))

        Return oExistsCommand.Exists

    End Function

    <Serializable()> _
    Private Class ExistsCommand
        Inherits CommandBase

        Private msTurtleId As String
        Private mbExists As Boolean

        Public ReadOnly Property Exists() As Boolean
            Get
                Return mbExists
            End Get
        End Property

        Public Sub New(ByVal sTurtleId As String)
            msTurtleID = sTurtleId
        End Sub

        Protected Overrides Sub DataPortal_Execute()

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                Using cn As IDbConnection = oAdoHelper.GetConnection()
                    cn.Open()
                    Using cm As IDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "SELECT turtle_id FROM turtle WHERE " & oAdoHelper.UpperFunction & "(turtle_id) = " & oAdoHelper.UpperFunction & "(@turtle_id)"
                        cm.Parameters.Add(oAdoHelper.GetParameter("@turtle_id", msTurtleID))
                        mbExists = Not String.IsNullOrEmpty(Convert.ToString(oAdoHelper.ExecuteScalar(cm)))
                    End Using
                End Using
            End Using

        End Sub

    End Class

#End Region

#Region " IsModified "

    '----------------------------------------------------------------
    '-- support for determining if changes were made to the object
    '-- since a developer-specified checkpoint in time
    '----------------------------------------------------------------
    '-- (IsDirty does not suffice for this, especially when 
    '--  working with business object children....)
    '----------------------------------------------------------------

    Private mbIsModified As Boolean = False

    Public Property IsModified() As Boolean
        Get
            Return mbIsModified
        End Get
        Set(ByVal Value As Boolean)
            mbIsModified = value
        End Set
    End Property

    Private Sub Me_PropertyChanged(ByVal sender As Object, ByVal e As System.ComponentModel.PropertyChangedEventArgs) Handles Me.PropertyChanged
        If Not String.IsNullOrEmpty(e.PropertyName) Then
            mbIsModified = True
        End If
    End Sub

#End Region

#Region " TotalCount "

    Public Shared Function TotalCount() As Integer

        Dim oTotalCountCommand As TotalCountCommand

        oTotalCountCommand = DataPortal.Execute(Of TotalCountCommand)(New TotalCountCommand())

        Return oTotalCountCommand.TotalCount

    End Function

    <Serializable()> _
    Private Class TotalCountCommand
        Inherits CommandBase

        Private miTotalCount As Integer

        Public ReadOnly Property TotalCount() As Integer
            Get
                Return miTotalCount
            End Get
        End Property

        Protected Overrides Sub DataPortal_Execute()

            Dim s As String = String.Empty

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

                s = "SELECT COUNT(*) FROM turtle"

                miTotalCount = Convert.ToInt32(Val(Convert.ToString(oAdoHelper.ExecuteScalar(CommandType.Text, s))))

            End Using ' oAdoHelper

        End Sub

    End Class

#End Region

End Class
