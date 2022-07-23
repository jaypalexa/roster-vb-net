Option Explicit On 
Option Strict On
Option Compare Text

<Serializable()> _
Public Class Organization
    Inherits BusinessBase(Of Organization)

#Region " Business Methods "

    Private msOrganizationID As String = String.Empty
    Private msOrganizationName As String = String.Empty
    Private msAddress1 As String = String.Empty
    Private msAddress2 As String = String.Empty
    Private msCity As String = String.Empty
    Private msState As String = String.Empty
    Private msZipCode As String = String.Empty
    Private msPhone As String = String.Empty
    Private msFax As String = String.Empty
    Private msEmailAddress As String = String.Empty
    Private msPermitNumber As String = String.Empty
    Private msContactName As String = String.Empty
    Private mdtHatchlingBalanceAsOfDate As Date = DateTime.MinValue
    Private miCcHatchlingStartingBalance As Integer = 0
    Private miCmHatchlingStartingBalance As Integer = 0
    Private miDcHatchlingStartingBalance As Integer = 0
    Private miOtherHatchlingStartingBalance As Integer = 0
    Private miUnknownHatchlingStartingBalance As Integer = 0
    Private mdtWashbackBalanceAsOfDate As Date = DateTime.MinValue
    Private miCcWashbackStartingBalance As Integer = 0
    Private miCmWashbackStartingBalance As Integer = 0
    Private miDcWashbackStartingBalance As Integer = 0
    Private miOtherWashbackStartingBalance As Integer = 0
    Private miUnknownWashbackStartingBalance As Integer = 0
    Private msPreferredUnitsType As String = "M" ' [M]etric, [I]mperial

    Public ReadOnly Property OrganizationID() As String
        Get
            Return msOrganizationID
        End Get
    End Property

    Public Property OrganizationName() As String
        Get
            Return msOrganizationName
        End Get
        Set(ByVal Value As String)
            If msOrganizationName <> Value Then
                msOrganizationName = Value
                PropertyHasChanged("OrganizationName")
            End If
        End Set
    End Property

    Public Property Address1() As String
        Get
            Return msAddress1
        End Get
        Set(ByVal Value As String)
            If msAddress1 <> Value Then
                msAddress1 = Value
                PropertyHasChanged("Address1")
            End If
        End Set
    End Property

    Public Property Address2() As String
        Get
            Return msAddress2
        End Get
        Set(ByVal Value As String)
            If msAddress2 <> Value Then
                msAddress2 = Value
                PropertyHasChanged("Address2")
            End If
        End Set
    End Property

    Public Property City() As String
        Get
            Return msCity
        End Get
        Set(ByVal Value As String)
            If msCity <> Value Then
                msCity = Value
                PropertyHasChanged("City")
            End If
        End Set
    End Property

    Public Property State() As String
        Get
            Return msState.Trim.ToUpper
        End Get
        Set(ByVal Value As String)
            If msState <> Value Then
                msState = Value
                PropertyHasChanged("State")
            End If
        End Set
    End Property

    Public Property ZipCode() As String
        Get
            Return msZipCode
        End Get
        Set(ByVal Value As String)
            If msZipCode <> Value Then
                msZipCode = Value
                PropertyHasChanged("ZipCode")
            End If
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return msPhone
        End Get
        Set(ByVal Value As String)
            If msPhone <> Value Then
                msPhone = Value
                PropertyHasChanged("Phone")
            End If
        End Set
    End Property

    Public Property Fax() As String
        Get
            Return msFax
        End Get
        Set(ByVal Value As String)
            If msFax <> Value Then
                msFax = Value
                PropertyHasChanged("Fax")
            End If
        End Set
    End Property

    Public Property EmailAddress() As String
        Get
            Return msEmailAddress
        End Get
        Set(ByVal Value As String)
            If msEmailAddress <> Value Then
                msEmailAddress = Value
                PropertyHasChanged("EmailAddress")
            End If
        End Set
    End Property

    Public Property PermitNumber() As String
        Get
            Return msPermitNumber
        End Get
        Set(ByVal Value As String)
            If msPermitNumber <> Value Then
                msPermitNumber = Value
                PropertyHasChanged("PermitNumber")
            End If
        End Set
    End Property

    Public Property ContactName() As String
        Get
            Return msContactName
        End Get
        Set(ByVal Value As String)
            If msContactName <> Value Then
                msContactName = Value
                PropertyHasChanged("ContactName")
            End If
        End Set
    End Property

    Public Property HatchlingBalanceAsOfDate() As Date
        Get
            Return DateAtMidnight(mdtHatchlingBalanceAsOfDate)
        End Get
        Set(ByVal Value As Date)
            If HasDateValueChanged(mdtHatchlingBalanceAsOfDate, Value) Then
                mdtHatchlingBalanceAsOfDate = Value
                PropertyHasChanged("HatchlingBalanceAsOfDate")
            End If
        End Set
    End Property

    Public ReadOnly Property HatchlingBalanceAsOfDateString() As String
        Get
            Return DateAsString(mdtHatchlingBalanceAsOfDate)
        End Get
    End Property

    Public Property CcHatchlingStartingBalance() As Integer
        Get
            Return miCcHatchlingStartingBalance
        End Get
        Set(ByVal Value As Integer)
            If miCcHatchlingStartingBalance <> Value Then
                miCcHatchlingStartingBalance = Value
                PropertyHasChanged("CcHatchlingStartingBalance")
            End If
        End Set
    End Property

    Public Property CmHatchlingStartingBalance() As Integer
        Get
            Return miCmHatchlingStartingBalance
        End Get
        Set(ByVal Value As Integer)
            If miCmHatchlingStartingBalance <> Value Then
                miCmHatchlingStartingBalance = Value
                PropertyHasChanged("CmHatchlingStartingBalance")
            End If
        End Set
    End Property

    Public Property DcHatchlingStartingBalance() As Integer
        Get
            Return miDcHatchlingStartingBalance
        End Get
        Set(ByVal Value As Integer)
            If miDcHatchlingStartingBalance <> Value Then
                miDcHatchlingStartingBalance = Value
                PropertyHasChanged("DcHatchlingStartingBalance")
            End If
        End Set
    End Property

    Public Property OtherHatchlingStartingBalance() As Integer
        Get
            Return miOtherHatchlingStartingBalance
        End Get
        Set(ByVal Value As Integer)
            If miOtherHatchlingStartingBalance <> Value Then
                miOtherHatchlingStartingBalance = Value
                PropertyHasChanged("OtherHatchlingStartingBalance")
            End If
        End Set
    End Property

    Public Property UnknownHatchlingStartingBalance() As Integer
        Get
            Return miUnknownHatchlingStartingBalance
        End Get
        Set(ByVal Value As Integer)
            If miUnknownHatchlingStartingBalance <> Value Then
                miUnknownHatchlingStartingBalance = Value
                PropertyHasChanged("UnknownHatchlingStartingBalance")
            End If
        End Set
    End Property

    Public Property WashbackBalanceAsOfDate() As Date
        Get
            Return DateAtMidnight(mdtWashbackBalanceAsOfDate)
        End Get
        Set(ByVal Value As Date)
            If HasDateValueChanged(mdtWashbackBalanceAsOfDate, Value) Then
                mdtWashbackBalanceAsOfDate = Value
                PropertyHasChanged("WashbackBalanceAsOfDate")
            End If
        End Set
    End Property

    Public ReadOnly Property WashbackBalanceAsOfDateString() As String
        Get
            Return DateAsString(mdtWashbackBalanceAsOfDate)
        End Get
    End Property

    Public Property CcWashbackStartingBalance() As Integer
        Get
            Return miCcWashbackStartingBalance
        End Get
        Set(ByVal Value As Integer)
            If miCcWashbackStartingBalance <> Value Then
                miCcWashbackStartingBalance = Value
                PropertyHasChanged("CcWashbackStartingBalance")
            End If
        End Set
    End Property

    Public Property CmWashbackStartingBalance() As Integer
        Get
            Return miCmWashbackStartingBalance
        End Get
        Set(ByVal Value As Integer)
            If miCmWashbackStartingBalance <> Value Then
                miCmWashbackStartingBalance = Value
                PropertyHasChanged("CmWashbackStartingBalance")
            End If
        End Set
    End Property

    Public Property DcWashbackStartingBalance() As Integer
        Get
            Return miDcWashbackStartingBalance
        End Get
        Set(ByVal Value As Integer)
            If miDcWashbackStartingBalance <> Value Then
                miDcWashbackStartingBalance = Value
                PropertyHasChanged("DcWashbackStartingBalance")
            End If
        End Set
    End Property

    Public Property OtherWashbackStartingBalance() As Integer
        Get
            Return miOtherWashbackStartingBalance
        End Get
        Set(ByVal Value As Integer)
            If miOtherWashbackStartingBalance <> Value Then
                miOtherWashbackStartingBalance = Value
                PropertyHasChanged("OtherWashbackStartingBalance")
            End If
        End Set
    End Property

    Public Property UnknownWashbackStartingBalance() As Integer
        Get
            Return miUnknownWashbackStartingBalance
        End Get
        Set(ByVal Value As Integer)
            If miUnknownWashbackStartingBalance <> Value Then
                miUnknownWashbackStartingBalance = Value
                PropertyHasChanged("UnknownWashbackStartingBalance")
            End If
        End Set
    End Property

    Public Property PreferredUnitsType() As String
        Get
            If String.IsNullOrEmpty(msPreferredUnitsType) Then
                Return "M"
            Else
                Return msPreferredUnitsType
            End If
        End Get
        Set(ByVal Value As String)
            If msPreferredUnitsType <> Value Then
                msPreferredUnitsType = Value
                PropertyHasChanged("PreferredUnitsType")
            End If
        End Set
    End Property

    Protected Overrides Function GetIdValue() As Object
        Return msOrganizationID
    End Function

    Public Function GetBrokenRulesString() As String

        Dim s As String = String.Empty

        s &= Me.BrokenRulesCollection.ToString

        'If moMorphometrics IsNot Nothing Then
        '    s &= moMorphometrics.GetBrokenRulesString
        'End If

        Return s

    End Function

#End Region

#Region " Validation Rules "

    Protected Overrides Sub AddBusinessRules()

        Dim oRuleArgs As Validation.RuleArgs

        ValidationRules.AddRule(AddressOf Validation.CommonRules.StringRequired, New Validation.RuleArgs("OrganizationName", "Organization Name"))
        ValidationRules.AddRule(AddressOf Validation.CommonRules.StringMaxLength, New Validation.CommonRules.MaxLengthRuleArgs("OrganizationName", "Organization Name", 255))

        ValidationRules.AddRule(AddressOf Validation.CommonRules.StringRequired, New Validation.RuleArgs("PermitNumber", "Permit Number"))
        ValidationRules.AddRule(AddressOf Validation.CommonRules.StringMaxLength, New Validation.CommonRules.MaxLengthRuleArgs("PermitNumber", "Permit Number", 255))

        oRuleArgs = New Validation.RuleArgs("CcHatchlingStartingBalance")
        oRuleArgs.Description = "Loggerhead hatchling starting balance value must be a positive whole number"
        ValidationRules.AddRule(AddressOf IntegerValueRequired, oRuleArgs)

        oRuleArgs = New Validation.RuleArgs("CmHatchlingStartingBalance")
        oRuleArgs.Description = "Green hatchling starting balance value must be a positive whole number"
        ValidationRules.AddRule(AddressOf IntegerValueRequired, oRuleArgs)

        oRuleArgs = New Validation.RuleArgs("DcHatchlingStartingBalance")
        oRuleArgs.Description = "Leatherback hatchling starting balance value must be a positive whole number"
        ValidationRules.AddRule(AddressOf IntegerValueRequired, oRuleArgs)

        oRuleArgs = New Validation.RuleArgs("OtherHatchlingStartingBalance")
        oRuleArgs.Description = "Other hatchling starting balance value must be a positive whole number"
        ValidationRules.AddRule(AddressOf IntegerValueRequired, oRuleArgs)

        oRuleArgs = New Validation.RuleArgs("UnknownHatchlingStartingBalance")
        oRuleArgs.Description = "Unknown hatchling starting balance value must be a positive whole number"
        ValidationRules.AddRule(AddressOf IntegerValueRequired, oRuleArgs)

        oRuleArgs = New Validation.RuleArgs("CcWashbackStartingBalance")
        oRuleArgs.Description = "Loggerhead washback starting balance value must be a positive whole number"
        ValidationRules.AddRule(AddressOf IntegerValueRequired, oRuleArgs)

        oRuleArgs = New Validation.RuleArgs("CmWashbackStartingBalance")
        oRuleArgs.Description = "Green washback starting balance value must be a positive whole number"
        ValidationRules.AddRule(AddressOf IntegerValueRequired, oRuleArgs)

        oRuleArgs = New Validation.RuleArgs("DcWashbackStartingBalance")
        oRuleArgs.Description = "Leatherback washback starting balance value must be a positive whole number"
        ValidationRules.AddRule(AddressOf IntegerValueRequired, oRuleArgs)

        oRuleArgs = New Validation.RuleArgs("OtherWashbackStartingBalance")
        oRuleArgs.Description = "Other washback starting balance value must be a positive whole number"
        ValidationRules.AddRule(AddressOf IntegerValueRequired, oRuleArgs)

        oRuleArgs = New Validation.RuleArgs("UnknownWashbackStartingBalance")
        oRuleArgs.Description = "Unknown washback starting balance value must be a positive whole number"
        ValidationRules.AddRule(AddressOf IntegerValueRequired, oRuleArgs)

    End Sub

#End Region

#Region " Authorization Rules "

    Protected Overrides Sub AddAuthorizationRules()

        '' add AuthorizationRules here
        'AuthorizationRules.AllowWrite("ProjectId", "Administrator", "Project Manager")
        'AuthorizationRules.AllowWrite("Name", "Administrator", "Project Manager")

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

    'Public Shared Function NewOrganization() As Organization
    '    Dim oOrganization As Organization
    '    oOrganization = DataPortal.Create(Of Organization)()
    '    oOrganization.MarkClean()
    '    Return oOrganization
    'End Function

    Public Shared Function GetOrganization() As Organization

        Return DataPortal.Fetch(Of Organization)(New Criteria())

    End Function

    Public Shared Sub DeleteOrganization(ByVal sOrganizationId As String)

        DataPortal.Delete(New Criteria())

    End Sub

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

    <RunLocal()> _
    Protected Overrides Sub DataPortal_Create()

        msOrganizationID = Guid.NewGuid.ToString.ToUpper
        msOrganizationName = String.Empty
        msAddress1 = String.Empty
        msAddress2 = String.Empty
        msCity = String.Empty
        msState = String.Empty
        msZipCode = String.Empty
        msPhone = String.Empty
        msFax = String.Empty
        msEmailAddress = String.Empty
        msPermitNumber = String.Empty
        msContactName = String.Empty
        mdtHatchlingBalanceAsOfDate = DateTime.MinValue
        miCcHatchlingStartingBalance = 0
        miCmHatchlingStartingBalance = 0
        miDcHatchlingStartingBalance = 0
        miOtherHatchlingStartingBalance = 0
        miUnknownHatchlingStartingBalance = 0
        mdtWashbackBalanceAsOfDate = DateTime.MinValue
        miCcWashbackStartingBalance = 0
        miCmWashbackStartingBalance = 0
        miDcWashbackStartingBalance = 0
        miOtherWashbackStartingBalance = 0
        miUnknownWashbackStartingBalance = 0
        msPreferredUnitsType = "M"

        ValidationRules.CheckRules()

        'v-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew
        'MarkClean()
        '^-- this gets overridden by a call in SimpleDataPortal.Create to MarkNew

    End Sub

    Private Overloads Sub DataPortal_Fetch(ByVal oCriteria As Criteria)

        Dim s As String = String.Empty

        If Organization.Exists Then

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

                s = "SELECT * FROM organization"

                Using dr As SafeDataReader = oAdoHelper.ExecuteReader(CommandType.Text, s)

                    If dr.Read() Then

                        msOrganizationID = dr.GetString("organization_id")
                        msOrganizationName = dr.GetString("organization_name")
                        msAddress1 = dr.GetString("address_1")
                        msAddress2 = dr.GetString("address_2")
                        msCity = dr.GetString("city")
                        Me.State = dr.GetString("state")
                        msZipCode = dr.GetString("zip_code")
                        msPhone = dr.GetString("phone")
                        msFax = dr.GetString("fax")
                        msEmailAddress = dr.GetString("email_address")
                        msPermitNumber = dr.GetString("permit_number")
                        msContactName = dr.GetString("contact_name")
                        mdtHatchlingBalanceAsOfDate = dr.GetDateTime("hatchling_balance_as_of_date")
                        miCcHatchlingStartingBalance = dr.GetInt32("cc_hatchling_starting_balance")
                        miCmHatchlingStartingBalance = dr.GetInt32("cm_hatchling_starting_balance")
                        miDcHatchlingStartingBalance = dr.GetInt32("dc_hatchling_starting_balance")
                        miOtherHatchlingStartingBalance = dr.GetInt32("other_hatchling_starting_balance")
                        miUnknownHatchlingStartingBalance = dr.GetInt32("unknown_hatchling_starting_balance")
                        mdtWashbackBalanceAsOfDate = dr.GetDateTime("washback_balance_as_of_date")
                        miCcWashbackStartingBalance = dr.GetInt32("cc_washback_starting_balance")
                        miCmWashbackStartingBalance = dr.GetInt32("cm_washback_starting_balance")
                        miDcWashbackStartingBalance = dr.GetInt32("dc_washback_starting_balance")
                        miOtherWashbackStartingBalance = dr.GetInt32("other_washback_starting_balance")
                        miUnknownWashbackStartingBalance = dr.GetInt32("unknown_washback_starting_balance")
                        msPreferredUnitsType = dr.GetString("preferred_units_type")
                        If String.IsNullOrEmpty(msPreferredUnitsType) Then
                            msPreferredUnitsType = "M"
                        End If

                        ValidationRules.CheckRules()

                    End If

                End Using

            End Using

        Else

            msOrganizationID = Guid.NewGuid.ToString.ToUpper
            msOrganizationName = String.Empty
            msAddress1 = String.Empty
            msAddress2 = String.Empty
            msCity = String.Empty
            msState = String.Empty
            msZipCode = String.Empty
            msPhone = String.Empty
            msFax = String.Empty
            msEmailAddress = String.Empty
            msPermitNumber = String.Empty
            msContactName = String.Empty
            mdtHatchlingBalanceAsOfDate = DateTime.MinValue
            miCcHatchlingStartingBalance = 0
            miCmHatchlingStartingBalance = 0
            miDcHatchlingStartingBalance = 0
            miOtherHatchlingStartingBalance = 0
            miUnknownHatchlingStartingBalance = 0
            mdtWashbackBalanceAsOfDate = DateTime.MinValue
            miCcWashbackStartingBalance = 0
            miCmWashbackStartingBalance = 0
            miDcWashbackStartingBalance = 0
            miOtherWashbackStartingBalance = 0
            miUnknownWashbackStartingBalance = 0
            msPreferredUnitsType = "M"

            ValidationRules.CheckRules()

        End If

    End Sub

    Protected Overrides Sub DataPortal_Insert()

        DoInsertUpdate()

    End Sub

    Protected Overrides Sub DataPortal_Update()

        DoInsertUpdate()

    End Sub

    Private Sub DoInsertUpdate()

        Dim s As String = String.Empty

        If Organization.Exists Then

            s &= "UPDATE organization SET "
            s &= "organization_name = @organization_name, "
            s &= "address_1 = @address_1, "
            s &= "address_2 = @address_2, "
            s &= "city = @city, "
            s &= "state = @state, "
            s &= "zip_code = @zip_code, "
            s &= "phone = @phone, "
            s &= "fax = @fax, "
            s &= "email_address = @email_address, "
            s &= "permit_number = @permit_number, "
            s &= "contact_name = @contact_name, "
            s &= "hatchling_balance_as_of_date = @hatchling_balance_as_of_date, "
            s &= "cc_hatchling_starting_balance = @cc_hatchling_starting_balance, "
            s &= "cm_hatchling_starting_balance = @cm_hatchling_starting_balance, "
            s &= "dc_hatchling_starting_balance = @dc_hatchling_starting_balance, "
            s &= "other_hatchling_starting_balance = @other_hatchling_starting_balance, "
            s &= "unknown_hatchling_starting_balance = @unknown_hatchling_starting_balance, "
            s &= "washback_balance_as_of_date = @washback_balance_as_of_date, "
            s &= "cc_washback_starting_balance = @cc_washback_starting_balance, "
            s &= "cm_washback_starting_balance = @cm_washback_starting_balance, "
            s &= "dc_washback_starting_balance = @dc_washback_starting_balance, "
            s &= "other_washback_starting_balance = @other_washback_starting_balance, "
            s &= "unknown_washback_starting_balance = @unknown_washback_starting_balance, "
            s &= "preferred_units_type = @preferred_units_type "
            s &= "WHERE organization_id = @organization_id "

        Else

            s &= "INSERT INTO organization ("
            s &= "organization_name, address_1, address_2, city, state, zip_code, "
            s &= "phone, fax, email_address, permit_number, contact_name, "
            s &= "hatchling_balance_as_of_date, cc_hatchling_starting_balance, cm_hatchling_starting_balance,"
            s &= "dc_hatchling_starting_balance, other_hatchling_starting_balance, unknown_hatchling_starting_balance,"
            s &= "washback_balance_as_of_date, cc_washback_starting_balance, cm_washback_starting_balance,"
            s &= "dc_washback_starting_balance, other_washback_starting_balance, unknown_washback_starting_balance,"
            s &= "preferred_units_type, "
            s &= "organization_id "
            s &= ") VALUES ("
            s &= "@organization_name, @address_1, @address_2, @city, @state, @zip_code, "
            s &= "@phone, @fax, @email_address, @permit_number, @contact_name, "
            s &= "@hatchling_balance_as_of_date, @cc_hatchling_starting_balance, @cm_hatchling_starting_balance,"
            s &= "@dc_hatchling_starting_balance, @other_hatchling_starting_balance, @unknown_hatchling_starting_balance,"
            s &= "@washback_balance_as_of_date, @cc_washback_starting_balance, @cm_washback_starting_balance,"
            s &= "@dc_washback_starting_balance, @other_washback_starting_balance, @unknown_washback_starting_balance,"
            s &= "@preferred_units_type, "
            s &= "@organization_id "
            s &= ") "

        End If

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()

                If MyBase.IsDirty Then

                    Using cm As IDbCommand = cn.CreateCommand()

                        With cm
                            .CommandType = CommandType.Text
                            .CommandText = s
                            .Parameters.Add(oAdoHelper.GetParameter("@organization_name", msOrganizationName))
                            .Parameters.Add(oAdoHelper.GetParameter("@address_1", msAddress1))
                            .Parameters.Add(oAdoHelper.GetParameter("@address_2", msAddress2))
                            .Parameters.Add(oAdoHelper.GetParameter("@city", msCity))
                            .Parameters.Add(oAdoHelper.GetParameter("@state", Me.State))
                            .Parameters.Add(oAdoHelper.GetParameter("@zip_code", msZipCode))
                            .Parameters.Add(oAdoHelper.GetParameter("@phone", msPhone))
                            .Parameters.Add(oAdoHelper.GetParameter("@fax", msFax))
                            .Parameters.Add(oAdoHelper.GetParameter("@email_address", msEmailAddress))
                            .Parameters.Add(oAdoHelper.GetParameter("@permit_number", msPermitNumber))
                            .Parameters.Add(oAdoHelper.GetParameter("@contact_name", msContactName))
                            '.Parameters.Add(oAdoHelper.GetParameter("@hatchling_balance_as_of_date", Me.HatchlingBalanceAsOfDate))
                            .Parameters.Add(oAdoHelper.GetParameter("@hatchling_balance_as_of_date", AdoHelper.DbSetDate(mdtHatchlingBalanceAsOfDate)))
                            .Parameters.Add(oAdoHelper.GetParameter("@cc_hatchling_starting_balance", miCcHatchlingStartingBalance))
                            .Parameters.Add(oAdoHelper.GetParameter("@cm_hatchling_starting_balance", miCmHatchlingStartingBalance))
                            .Parameters.Add(oAdoHelper.GetParameter("@dc_hatchling_starting_balance", miDcHatchlingStartingBalance))
                            .Parameters.Add(oAdoHelper.GetParameter("@other_hatchling_starting_balance", miOtherHatchlingStartingBalance))
                            .Parameters.Add(oAdoHelper.GetParameter("@unknown_hatchling_starting_balance", miUnknownHatchlingStartingBalance))
                            '.Parameters.Add(oAdoHelper.GetParameter("@washback_balance_as_of_date", Me.WashbackBalanceAsOfDate))
                            .Parameters.Add(oAdoHelper.GetParameter("@washback_balance_as_of_date", AdoHelper.DbSetDate(mdtWashbackBalanceAsOfDate)))
                            .Parameters.Add(oAdoHelper.GetParameter("@cc_washback_starting_balance", miCcWashbackStartingBalance))
                            .Parameters.Add(oAdoHelper.GetParameter("@cm_washback_starting_balance", miCmWashbackStartingBalance))
                            .Parameters.Add(oAdoHelper.GetParameter("@dc_washback_starting_balance", miDcWashbackStartingBalance))
                            .Parameters.Add(oAdoHelper.GetParameter("@other_washback_starting_balance", miOtherWashbackStartingBalance))
                            .Parameters.Add(oAdoHelper.GetParameter("@unknown_washback_starting_balance", miUnknownWashbackStartingBalance))
                            .Parameters.Add(oAdoHelper.GetParameter("@preferred_units_type", msPreferredUnitsType))
                            .Parameters.Add(oAdoHelper.GetParameter("@organization_id", msOrganizationID))
                            oAdoHelper.ExecuteNonQuery(cm)
                        End With ' cm 

                    End Using ' cm

                End If

            End Using ' cn 

        End Using ' oAdoHelper

    End Sub

    Protected Overrides Sub DataPortal_DeleteSelf()

        DataPortal_Delete(New Criteria())

    End Sub

    Private Overloads Sub DataPortal_Delete(ByVal oCriteria As Criteria)

        Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()

            Using cn As IDbConnection = oAdoHelper.GetConnection()

                cn.Open()

                Using ts As TransactionScope = New TransactionScope()

                    Using cm As IDbCommand = cn.CreateCommand()

                        '----------------------------------------------------------------
                        '-- finally, delete the root record
                        '----------------------------------------------------------------
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "DELETE FROM organization"

                        oAdoHelper.ExecuteNonQuery(cm)

                    End Using ' cm

                End Using ' ts

            End Using ' cn

        End Using ' oAdoHelper

    End Sub

#End Region

#Region " Exists "

    Public Shared Function Exists() As Boolean

        Dim oExistsCommand As ExistsCommand

        oExistsCommand = DataPortal.Execute(Of ExistsCommand)(New ExistsCommand())

        Return oExistsCommand.Exists

    End Function

    <Serializable()> _
    Private Class ExistsCommand
        Inherits CommandBase

        Private mbExists As Boolean

        Public ReadOnly Property Exists() As Boolean
            Get
                Return mbExists
            End Get
        End Property

        Public Sub New()
        End Sub

        Protected Overrides Sub DataPortal_Execute()

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                Using cn As IDbConnection = oAdoHelper.GetConnection()
                    cn.Open()
                    Using cm As IDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = "SELECT organization_id FROM organization"
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

End Class
