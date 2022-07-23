Option Explicit On 
Option Strict On
Option Compare Text

Public Class TankWaterInformationDlg
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents lblSeparator As System.Windows.Forms.Label
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents tipToolTip As System.Windows.Forms.ToolTip
    Friend WithEvents lblTemperature As System.Windows.Forms.Label
    Friend WithEvents txtTemperature As System.Windows.Forms.TextBox
    Friend WithEvents lblSalinity As System.Windows.Forms.Label
    Friend WithEvents lblDateMeasured As System.Windows.Forms.Label
    Friend WithEvents dtpDateMeasured As TurtleGeek.Controls.DateComboBox
    Friend WithEvents lblPh As System.Windows.Forms.Label
    Friend WithEvents txtSalinity As System.Windows.Forms.TextBox
    Friend WithEvents txtPh As System.Windows.Forms.TextBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TankWaterInformationDlg))
        Me.lblTemperature = New System.Windows.Forms.Label
        Me.txtTemperature = New System.Windows.Forms.TextBox
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.txtSalinity = New System.Windows.Forms.TextBox
        Me.lblSalinity = New System.Windows.Forms.Label
        Me.lblDateMeasured = New System.Windows.Forms.Label
        Me.dtpDateMeasured = New TurtleGeek.Controls.DateComboBox
        Me.tipToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblPh = New System.Windows.Forms.Label
        Me.txtPh = New System.Windows.Forms.TextBox
        Me.btnHelp = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lblTemperature
        '
        Me.lblTemperature.Location = New System.Drawing.Point(8, 48)
        Me.lblTemperature.Name = "lblTemperature"
        Me.lblTemperature.Size = New System.Drawing.Size(94, 20)
        Me.lblTemperature.TabIndex = 2
        Me.lblTemperature.Text = "Temperature:"
        Me.lblTemperature.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTemperature
        '
        Me.txtTemperature.Location = New System.Drawing.Point(112, 48)
        Me.txtTemperature.MaxLength = 255
        Me.txtTemperature.Name = "txtTemperature"
        Me.txtTemperature.Size = New System.Drawing.Size(216, 20)
        Me.txtTemperature.TabIndex = 3
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(8, 168)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(328, 2)
        Me.lblSeparator.TabIndex = 8
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(264, 184)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 10
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(184, 184)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 24)
        Me.btnOK.TabIndex = 9
        Me.btnOK.Text = "OK"
        '
        'txtSalinity
        '
        Me.txtSalinity.Location = New System.Drawing.Point(112, 80)
        Me.txtSalinity.MaxLength = 255
        Me.txtSalinity.Name = "txtSalinity"
        Me.txtSalinity.Size = New System.Drawing.Size(216, 20)
        Me.txtSalinity.TabIndex = 5
        '
        'lblSalinity
        '
        Me.lblSalinity.Location = New System.Drawing.Point(8, 80)
        Me.lblSalinity.Name = "lblSalinity"
        Me.lblSalinity.Size = New System.Drawing.Size(94, 20)
        Me.lblSalinity.TabIndex = 4
        Me.lblSalinity.Text = "Salinity (in ppt):"
        Me.lblSalinity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblDateMeasured
        '
        Me.lblDateMeasured.Location = New System.Drawing.Point(8, 16)
        Me.lblDateMeasured.Name = "lblDateMeasured"
        Me.lblDateMeasured.Size = New System.Drawing.Size(94, 20)
        Me.lblDateMeasured.TabIndex = 0
        Me.lblDateMeasured.Text = "Date measured:"
        Me.lblDateMeasured.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'dtpDateMeasured
        '
        Me.dtpDateMeasured.DateValue = New Date(2006, 5, 30, 23, 49, 39, 562)
        Me.dtpDateMeasured.Location = New System.Drawing.Point(112, 16)
        Me.dtpDateMeasured.Name = "dtpDateMeasured"
        Me.dtpDateMeasured.Size = New System.Drawing.Size(216, 20)
        Me.dtpDateMeasured.TabIndex = 1
        '
        'lblPh
        '
        Me.lblPh.Location = New System.Drawing.Point(8, 112)
        Me.lblPh.Name = "lblPh"
        Me.lblPh.Size = New System.Drawing.Size(94, 20)
        Me.lblPh.TabIndex = 6
        Me.lblPh.Text = "pH:"
        Me.lblPh.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtPh
        '
        Me.txtPh.Location = New System.Drawing.Point(112, 112)
        Me.txtPh.MaxLength = 255
        Me.txtPh.Name = "txtPh"
        Me.txtPh.Size = New System.Drawing.Size(216, 20)
        Me.txtPh.TabIndex = 7
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(8, 184)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 24)
        Me.btnHelp.TabIndex = 21
        Me.btnHelp.Text = "Help"
        '
        'TankWaterInformationDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(346, 223)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.lblPh)
        Me.Controls.Add(Me.txtPh)
        Me.Controls.Add(Me.txtSalinity)
        Me.Controls.Add(Me.txtTemperature)
        Me.Controls.Add(Me.lblDateMeasured)
        Me.Controls.Add(Me.lblSalinity)
        Me.Controls.Add(Me.lblTemperature)
        Me.Controls.Add(Me.dtpDateMeasured)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "TankWaterInformationDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Water Quality Measurement Information"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mbIsOkayButtonClicked As Boolean = False
    Private moTankWater As TankWater = Nothing

    Public Property TankWater() As TankWater
        Get
            Return moTankWater
        End Get
        Set(ByVal Value As TankWater)
            moTankWater = Value
        End Set
    End Property

    Public Sub New(ByVal oTankWater As TankWater)

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None

        moTankWater = oTankWater

    End Sub

    Private Sub frmTankWaterInformationDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try

            '*** ASSERTION ***
            If moTankWater Is Nothing Then
                Throw New ApplicationException("TankWater object must be set before opening this screen.")
            End If
            '*** ASSERTION ***

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- default to TODAY
            '----------------------------------------------------------------
            Me.dtpDateMeasured.DateValue = DateTime.Now

            '----------------------------------------------------------------
            '-- load the form fields with the data values
            '----------------------------------------------------------------
            moTankWater.BeginEdit()

            Me.txtTemperature.Text = moTankWater.Temperature
            Me.txtSalinity.Text = moTankWater.Salinity
            Me.txtPh.Text = moTankWater.Ph
            Me.dtpDateMeasured.DateValue = moTankWater.DateMeasured

            '----------------------------------------------------------------
            '-- display required field indicators 
            '----------------------------------------------------------------
            Me.DisplayBrokenRules(False)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub frmTankWaterInformationDlg_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        Dim bCancelFormClosingEvent As Boolean = False

        '------------------------------------------------------------ 
        '-- transfer the form data values into the business object 
        '------------------------------------------------------------ 
        Me.CopyFormValuesToBusinessObject()

        '------------------------------------------------------------ 
        '-- form being closed via OK button; 
        '-- validate data values, commit to the database, etc. 
        '------------------------------------------------------------ 
        If mbIsOkayButtonClicked Then
            bCancelFormClosingEvent = (Not DoSaveLogic())
        Else
            '------------------------------------------------------------ 
            '-- form being closed via Cancel button or Close [X] button; 
            '-- if object is dirty, prompt for save, etc. 
            '------------------------------------------------------------ 
            bCancelFormClosingEvent = (Not DoCancelLogic())
        End If

        '------------------------------------------------------------ 
        '-- CANCEL the form closing event and return the user to the form 
        '------------------------------------------------------------ 
        If bCancelFormClosingEvent Then
            e.Cancel = True
            mbIsOkayButtonClicked = False
        Else
            '------------------------------------------------------------ 
            '-- PROCEED with the form closing event 
            '------------------------------------------------------------ 
            e.Cancel = False
        End If

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            mbIsOkayButtonClicked = True
            Me.Close()
        Catch ex As Exception
            ErrorMessageBox.Show(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            mbIsOkayButtonClicked = False
            Me.Close()
        Catch ex As Exception
            ErrorMessageBox.Show(ex)
        End Try
    End Sub

    Private Function DoCancelLogic() As Boolean

        Dim oDialogResult As DialogResult

        Try
            '------------------------------------------------------------ 
            '-- if the object has changed 
            '-- but the user has clicked the Cancel button... 
            '------------------------------------------------------------ 
            If moTankWater.IsModified Then

                '------------------------------------------------------------ 
                '-- prompt the user to save the changes 
                '------------------------------------------------------------ 
                oDialogResult = MessageBox.Show("Save changes?", Application.ProductName, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                Select Case oDialogResult

                    Case DialogResult.Yes

                        '------------------------------------------------------------ 
                        '-- if the user wishes to save the changes, 
                        '-- attempt to validate and save the object 
                        '------------------------------------------------------------ 

                        Return DoSaveLogic()

                    Case DialogResult.No

                        '------------------------------------------------------------ 
                        '-- if the user does NOT wish to save the changes, 
                        '-- do nothing; fall through, cancel changes, and close the form 
                        '------------------------------------------------------------ 

                        Exit Select

                    Case DialogResult.Cancel

                        '------------------------------------------------------------ 
                        '-- if the user cancels the confirmation, 
                        '-- do NOT save the changes and return the user to the form 
                        '------------------------------------------------------------ 

                        '------------------------------------------------------------ 
                        '-- DO cancel the form closing event 
                        '------------------------------------------------------------ 
                        Return False

                End Select

            End If

            '------------------------------------------------------------ 
            '-- if the object changed but the user does NOT want to save the changes 
            '-- OR the object has NOT changed, 
            '-- then cancel the edit and continue closing the form 
            '------------------------------------------------------------ 
            moTankWater.CancelEdit()
            Me.DialogResult = DialogResult.Cancel

            '------------------------------------------------------------ 
            '-- do NOT cancel the form closing event 
            '------------------------------------------------------------ 
            Return True

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

            '------------------------------------------------------------ 
            '-- DO cancel the form closing event 
            '------------------------------------------------------------ 
            Return False

        End Try

    End Function

    Private Function DoSaveLogic() As Boolean
        '------------------------------------------------------------ 
        '-- validate data and save object; 
        '-- if the data is NOT valid, do NOT leave the form 
        '------------------------------------------------------------ 
        'Dim oTempTankWater As TankWater

        Try
            '------------------------------------------------------------ 
            '-- if the object has changed... 
            '------------------------------------------------------------ 
            If moTankWater.IsDirty Then

                '------------------------------------------------------------ 
                '-- if all of the validation rules have passed... 
                '------------------------------------------------------------ 
                If moTankWater.IsValid Then

                    '------------------------------------------------------------ 
                    '-- commit edits in memory
                    '------------------------------------------------------------ 
                    moTankWater.ApplyEdit()

                    '----------------------------------------------------------------
                    '-- clone and save the object (it is the CSLA way)
                    '----------------------------------------------------------------
                    'oTempTankWater = moTempTankWater.Clone
                    'moTempTankWater = oTempTankWater.Save

                Else

                    '------------------------------------------------------------ 
                    '-- else, display the list of broken rules, but do NOT close the form 
                    '------------------------------------------------------------ 
                    DisplayBrokenRules(True)

                    '------------------------------------------------------------ 
                    '-- DO cancel the form closing event 
                    '------------------------------------------------------------ 
                    Return False

                End If

            End If

            '------------------------------------------------------------ 
            '-- if the object has NOT changed 
            '-- OR if the data is valid and the object was saved, 
            '-- then continue closing the form 
            '------------------------------------------------------------ 
            Me.DialogResult = DialogResult.OK

            '------------------------------------------------------------ 
            '-- do NOT cancel the form closing event 
            '------------------------------------------------------------ 
            Return True

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

            '------------------------------------------------------------ 
            '-- DO cancel the form closing event 
            '------------------------------------------------------------ 
            Return False

        End Try

    End Function

    Private Sub DisplayBrokenRules(Optional ByVal bShowMessageBox As Boolean = False)

        Try

            'Dim i As Integer

            ''----------------------------------------------------------------
            ''-- clear all ErrorProvider messages
            ''----------------------------------------------------------------
            'erpErrorProvider.SetError(Me.txtOrganizationName, "")
            'erpErrorProvider.SetError(Me.txtPermitNumber, "")

            '----------------------------------------------------------------
            '-- indicate any broken rules to the user
            '----------------------------------------------------------------
            If (bShowMessageBox) Then
                MessageBox.Show(" *** The following data validation issue(s) must be resolved before this package can be saved: *** " & ControlChars.CrLf & ControlChars.CrLf & moTankWater.GetBrokenRulesString, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            'For i = 0 To moOrganization.BrokenRulesCollection.Count() - 1
            '    Select Case moOrganization.BrokenRulesCollection(i).Property
            '        Case "OrganizationName"
            '            erpErrorProvider.SetError(Me.txtOrganizationName, moOrganization.BrokenRulesCollection(i).Description)
            '        Case "PermitNumber"
            '            erpErrorProvider.SetError(Me.txtPermitNumber, moOrganization.BrokenRulesCollection(i).Description)
            '    End Select
            'Next

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub CopyFormValuesToBusinessObject()

        '------------------------------------------------------------ 
        '-- copy the data from the form fields into the business object 
        '------------------------------------------------------------ 
        moTankWater.DateMeasured = Me.dtpDateMeasured.DateValue
        moTankWater.Temperature = Me.txtTemperature.Text.Trim
        moTankWater.Salinity = Me.txtSalinity.Text.Trim
        moTankWater.Ph = Me.txtPh.Text.Trim

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "WaterMeasurements.htm")
    End Sub

End Class
