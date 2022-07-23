Option Explicit On 
Option Strict On
Option Compare Text

Public Class WashbacksReleasedEventInformationDlg
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
    Friend WithEvents lblReleasedOnBeach As System.Windows.Forms.Label
    Friend WithEvents txtBeachEventCount As System.Windows.Forms.TextBox
    Friend WithEvents dtpEventDate As TurtleGeek.Controls.DateComboBox
    Friend WithEvents lblEventDate As System.Windows.Forms.Label
    Friend WithEvents colTagEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTagDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTagWashbacksReleasedEventTagIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagWashbacksReleasedEventIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagTagNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagLocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagDateTaggedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagDateTaggedStringDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents erpErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblReleasedOffshore As System.Windows.Forms.Label
    Friend WithEvents txtOffshoreEventCount As System.Windows.Forms.TextBox
    Friend WithEvents lblTotalEventCount As System.Windows.Forms.Label
    Friend WithEvents txtTotalEventCount As System.Windows.Forms.TextBox
    Friend WithEvents lblSpecies As System.Windows.Forms.Label
    Friend WithEvents cboSpeciesList As System.Windows.Forms.ComboBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WashbacksReleasedEventInformationDlg))
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.tipToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblReleasedOnBeach = New System.Windows.Forms.Label
        Me.txtBeachEventCount = New System.Windows.Forms.TextBox
        Me.dtpEventDate = New TurtleGeek.Controls.DateComboBox
        Me.lblEventDate = New System.Windows.Forms.Label
        Me.btnHelp = New System.Windows.Forms.Button
        Me.erpErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblReleasedOffshore = New System.Windows.Forms.Label
        Me.txtOffshoreEventCount = New System.Windows.Forms.TextBox
        Me.lblTotalEventCount = New System.Windows.Forms.Label
        Me.txtTotalEventCount = New System.Windows.Forms.TextBox
        Me.lblSpecies = New System.Windows.Forms.Label
        Me.cboSpeciesList = New System.Windows.Forms.ComboBox
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(8, 159)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(297, 2)
        Me.lblSeparator.TabIndex = 10
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(233, 175)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 12
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(153, 175)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 24)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        '
        'lblReleasedOnBeach
        '
        Me.lblReleasedOnBeach.AutoSize = True
        Me.lblReleasedOnBeach.Location = New System.Drawing.Point(13, 67)
        Me.lblReleasedOnBeach.Name = "lblReleasedOnBeach"
        Me.lblReleasedOnBeach.Size = New System.Drawing.Size(103, 13)
        Me.lblReleasedOnBeach.TabIndex = 4
        Me.lblReleasedOnBeach.Text = "Released on beach:"
        Me.lblReleasedOnBeach.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBeachEventCount
        '
        Me.txtBeachEventCount.Location = New System.Drawing.Point(122, 64)
        Me.txtBeachEventCount.MaxLength = 7
        Me.txtBeachEventCount.Name = "txtBeachEventCount"
        Me.txtBeachEventCount.Size = New System.Drawing.Size(175, 20)
        Me.txtBeachEventCount.TabIndex = 5
        '
        'dtpEventDate
        '
        Me.dtpEventDate.DateValue = New Date(2006, 5, 30, 23, 49, 39, 562)
        Me.dtpEventDate.Location = New System.Drawing.Point(122, 38)
        Me.dtpEventDate.Name = "dtpEventDate"
        Me.dtpEventDate.Size = New System.Drawing.Size(175, 20)
        Me.dtpEventDate.TabIndex = 3
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Location = New System.Drawing.Point(13, 42)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(62, 13)
        Me.lblEventDate.TabIndex = 2
        Me.lblEventDate.Text = "Event date:"
        Me.lblEventDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(8, 175)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 24)
        Me.btnHelp.TabIndex = 13
        Me.btnHelp.Text = "Help"
        '
        'erpErrorProvider
        '
        Me.erpErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.erpErrorProvider.ContainerControl = Me
        '
        'lblReleasedOffshore
        '
        Me.lblReleasedOffshore.AutoSize = True
        Me.lblReleasedOffshore.Location = New System.Drawing.Point(13, 93)
        Me.lblReleasedOffshore.Name = "lblReleasedOffshore"
        Me.lblReleasedOffshore.Size = New System.Drawing.Size(96, 13)
        Me.lblReleasedOffshore.TabIndex = 6
        Me.lblReleasedOffshore.Text = "Released offshore:"
        Me.lblReleasedOffshore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtOffshoreEventCount
        '
        Me.txtOffshoreEventCount.Location = New System.Drawing.Point(122, 90)
        Me.txtOffshoreEventCount.MaxLength = 7
        Me.txtOffshoreEventCount.Name = "txtOffshoreEventCount"
        Me.txtOffshoreEventCount.Size = New System.Drawing.Size(175, 20)
        Me.txtOffshoreEventCount.TabIndex = 7
        '
        'lblTotalEventCount
        '
        Me.lblTotalEventCount.AutoSize = True
        Me.lblTotalEventCount.Location = New System.Drawing.Point(13, 119)
        Me.lblTotalEventCount.Name = "lblTotalEventCount"
        Me.lblTotalEventCount.Size = New System.Drawing.Size(94, 13)
        Me.lblTotalEventCount.TabIndex = 8
        Me.lblTotalEventCount.Text = "Total event count:"
        Me.lblTotalEventCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtTotalEventCount
        '
        Me.txtTotalEventCount.BackColor = System.Drawing.Color.LightYellow
        Me.txtTotalEventCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTotalEventCount.ForeColor = System.Drawing.Color.DarkBlue
        Me.txtTotalEventCount.Location = New System.Drawing.Point(122, 116)
        Me.txtTotalEventCount.MaxLength = 255
        Me.txtTotalEventCount.Name = "txtTotalEventCount"
        Me.txtTotalEventCount.ReadOnly = True
        Me.txtTotalEventCount.Size = New System.Drawing.Size(175, 20)
        Me.txtTotalEventCount.TabIndex = 9
        Me.txtTotalEventCount.TabStop = False
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Location = New System.Drawing.Point(13, 15)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(48, 13)
        Me.lblSpecies.TabIndex = 0
        Me.lblSpecies.Text = "Species:"
        Me.lblSpecies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboSpeciesList
        '
        Me.cboSpeciesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpeciesList.Location = New System.Drawing.Point(122, 12)
        Me.cboSpeciesList.Name = "cboSpeciesList"
        Me.cboSpeciesList.Size = New System.Drawing.Size(175, 21)
        Me.cboSpeciesList.TabIndex = 1
        '
        'WashbacksReleasedEventInformationDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(315, 214)
        Me.Controls.Add(Me.lblSpecies)
        Me.Controls.Add(Me.cboSpeciesList)
        Me.Controls.Add(Me.lblTotalEventCount)
        Me.Controls.Add(Me.txtTotalEventCount)
        Me.Controls.Add(Me.lblReleasedOffshore)
        Me.Controls.Add(Me.txtOffshoreEventCount)
        Me.Controls.Add(Me.lblReleasedOnBeach)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.txtBeachEventCount)
        Me.Controls.Add(Me.dtpEventDate)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.lblEventDate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WashbacksReleasedEventInformationDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Washbacks Released Event"
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mbIsOkayButtonClicked As Boolean = False
    Private moWashbacksReleasedEvent As WashbacksReleasedEvent

    Public Sub New(ByVal oWashbacksReleasedEvent As WashbacksReleasedEvent)

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None

        moWashbacksReleasedEvent = oWashbacksReleasedEvent

    End Sub

    Private Sub frmWashbacksReleasedEventInformationDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            '*** ASSERTION ***
            If moWashbacksReleasedEvent Is Nothing Then
                Throw New ApplicationException("WashbacksReleasedEvent object must be set before opening this screen.")
            End If
            '*** ASSERTION ***

            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '-- default to TODAY
            '----------------------------------------------------------------
            Me.dtpEventDate.DateValue = DateTime.Now

            '----------------------------------------------------------------
            '-- load list boxes
            '----------------------------------------------------------------
            Me.cboSpeciesList.DisplayMember = "Value"
            Me.cboSpeciesList.ValueMember = "Key"
            Me.cboSpeciesList.DataSource = CodeTableList.GetList(CodeTableList.CodeTableType.Species, True)

            '----------------------------------------------------------------
            '-- load the form fields with the data values
            '----------------------------------------------------------------
            moWashbacksReleasedEvent.BeginEdit()

            Me.cboSpeciesList.SelectedIndex = cboSpeciesList.FindString(moWashbacksReleasedEvent.SpeciesCode)

            Me.dtpEventDate.DateValue = moWashbacksReleasedEvent.EventDate

            If (moWashbacksReleasedEvent.BeachEventCount = 0) Then
                Me.txtBeachEventCount.Text = String.Empty
            Else
                Me.txtBeachEventCount.Text = Convert.ToString(moWashbacksReleasedEvent.BeachEventCount)
            End If

            If (moWashbacksReleasedEvent.OffshoreEventCount = 0) Then
                Me.txtOffshoreEventCount.Text = String.Empty
            Else
                Me.txtOffshoreEventCount.Text = Convert.ToString(moWashbacksReleasedEvent.OffshoreEventCount)
            End If

            UpdateTotalEventCount()

            '----------------------------------------------------------------
            '-- display required field indicators 
            '----------------------------------------------------------------
            Me.DisplayBrokenRules(False)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub frmWashbacksReleasedEventInformationDlg_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

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
            If moWashbacksReleasedEvent.IsDirty Then

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
            moWashbacksReleasedEvent.CancelEdit()
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
        Dim oTempWashbacksReleasedEvent As WashbacksReleasedEvent

        Try
            '------------------------------------------------------------ 
            '-- if the object has changed... 
            '------------------------------------------------------------ 
            If moWashbacksReleasedEvent.IsDirty Then

                '------------------------------------------------------------ 
                '-- if all of the validation rules have passed... 
                '------------------------------------------------------------ 
                If moWashbacksReleasedEvent.IsValid Then

                    '----------------------------------------------------------------
                    '-- commit edits in memory
                    '----------------------------------------------------------------
                    moWashbacksReleasedEvent.ApplyEdit()

                    '----------------------------------------------------------------
                    '-- clone and save the object (it is the CSLA way)
                    '----------------------------------------------------------------
                    oTempWashbacksReleasedEvent = moWashbacksReleasedEvent.Clone
                    moWashbacksReleasedEvent = oTempWashbacksReleasedEvent.Save

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

            Dim i As Integer

            '----------------------------------------------------------------
            '-- clear all ErrorProvider messages
            '----------------------------------------------------------------
            erpErrorProvider.SetError(Me.txtBeachEventCount, "")
            erpErrorProvider.SetError(Me.txtOffshoreEventCount, "")

            '----------------------------------------------------------------
            '-- indicate any broken rules to the user
            '----------------------------------------------------------------
            If (bShowMessageBox) Then
                MessageBox.Show(" *** The following data validation issue(s) must be resolved before this package can be saved: *** " & ControlChars.CrLf & ControlChars.CrLf & moWashbacksReleasedEvent.GetBrokenRulesString, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            For i = 0 To moWashbacksReleasedEvent.BrokenRulesCollection.Count() - 1
                Select Case moWashbacksReleasedEvent.BrokenRulesCollection(i).Property
                    Case "BeachEventCount"
                        erpErrorProvider.SetError(Me.txtBeachEventCount, moWashbacksReleasedEvent.BrokenRulesCollection(i).Description)
                    Case "OffshoreEventCount"
                        erpErrorProvider.SetError(Me.txtOffshoreEventCount, moWashbacksReleasedEvent.BrokenRulesCollection(i).Description)
                End Select
            Next

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        End Try

    End Sub

    Private Sub CopyFormValuesToBusinessObject()

        '------------------------------------------------------------ 
        '-- copy the data from the form fields into the business object 
        '------------------------------------------------------------ 
        If cboSpeciesList.SelectedIndex > -1 Then
            moWashbacksReleasedEvent.SpeciesCode = CType(Me.cboSpeciesList.SelectedItem, KeyValueInfo).Key
        End If

        moWashbacksReleasedEvent.EventDate = Me.dtpEventDate.DateValue
        moWashbacksReleasedEvent.BeachEventCount = Convert.ToInt32(Val(Me.txtBeachEventCount.Text.Trim))
        moWashbacksReleasedEvent.OffshoreEventCount = Convert.ToInt32(Val(Me.txtOffshoreEventCount.Text.Trim))

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "WashbacksReleasedEventScreen.htm")
    End Sub

    Private Sub txtBeachEventCount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtBeachEventCount.TextChanged
        UpdateTotalEventCount()
    End Sub

    Private Sub txtOffshoreEventCount_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOffshoreEventCount.TextChanged
        UpdateTotalEventCount()
    End Sub

    Private Sub UpdateTotalEventCount()

        Dim iTotalEventCount As Integer = 0

        iTotalEventCount = Convert.ToInt32(Val(Me.txtBeachEventCount.Text.Trim)) + Convert.ToInt32(Val(Me.txtOffshoreEventCount.Text.Trim))

        If (iTotalEventCount = 0) Then
            Me.txtTotalEventCount.Text = String.Empty
        Else
            Me.txtTotalEventCount.Text = Convert.ToString(iTotalEventCount)
        End If

    End Sub

End Class
