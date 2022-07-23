Option Explicit On 
Option Strict On
Option Compare Text

Public Class WashbacksDiedEventInformationDlg
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
    Friend WithEvents lblEventCount As System.Windows.Forms.Label
    Friend WithEvents txtEventCount As System.Windows.Forms.TextBox
    Friend WithEvents dtpEventDate As TurtleGeek.Controls.DateComboBox
    Friend WithEvents lblEventDate As System.Windows.Forms.Label
    Friend WithEvents colTagEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTagDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTagWashbacksDiedEventTagIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagWashbacksDiedEventIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagTagNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagLocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagDateTaggedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagDateTaggedStringDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents erpErrorProvider As System.Windows.Forms.ErrorProvider
    Friend WithEvents lblSpecies As System.Windows.Forms.Label
    Friend WithEvents cboSpeciesList As System.Windows.Forms.ComboBox
    Friend WithEvents chkUnder5cmClsl As System.Windows.Forms.CheckBox
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(WashbacksDiedEventInformationDlg))
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.tipToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.lblEventCount = New System.Windows.Forms.Label
        Me.txtEventCount = New System.Windows.Forms.TextBox
        Me.dtpEventDate = New TurtleGeek.Controls.DateComboBox
        Me.lblEventDate = New System.Windows.Forms.Label
        Me.btnHelp = New System.Windows.Forms.Button
        Me.erpErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.lblSpecies = New System.Windows.Forms.Label
        Me.cboSpeciesList = New System.Windows.Forms.ComboBox
        Me.chkUnder5cmClsl = New System.Windows.Forms.CheckBox
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(8, 133)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(297, 2)
        Me.lblSeparator.TabIndex = 7
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(233, 149)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 9
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(153, 149)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 24)
        Me.btnOK.TabIndex = 8
        Me.btnOK.Text = "OK"
        '
        'lblEventCount
        '
        Me.lblEventCount.AutoSize = True
        Me.lblEventCount.Location = New System.Drawing.Point(12, 68)
        Me.lblEventCount.Name = "lblEventCount"
        Me.lblEventCount.Size = New System.Drawing.Size(68, 13)
        Me.lblEventCount.TabIndex = 4
        Me.lblEventCount.Text = "Event count:"
        Me.lblEventCount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEventCount
        '
        Me.txtEventCount.Location = New System.Drawing.Point(87, 65)
        Me.txtEventCount.MaxLength = 255
        Me.txtEventCount.Name = "txtEventCount"
        Me.txtEventCount.Size = New System.Drawing.Size(210, 20)
        Me.txtEventCount.TabIndex = 5
        '
        'dtpEventDate
        '
        Me.dtpEventDate.BackColor = System.Drawing.SystemColors.Window
        Me.dtpEventDate.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.dtpEventDate.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dtpEventDate.DateValue = New Date(2006, 5, 30, 0, 0, 0, 0)
        Me.dtpEventDate.Location = New System.Drawing.Point(87, 39)
        Me.dtpEventDate.MaxValue = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.dtpEventDate.MinValue = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.dtpEventDate.Name = "dtpEventDate"
        Me.dtpEventDate.Size = New System.Drawing.Size(210, 20)
        Me.dtpEventDate.TabIndex = 3
        '
        'lblEventDate
        '
        Me.lblEventDate.AutoSize = True
        Me.lblEventDate.Location = New System.Drawing.Point(12, 43)
        Me.lblEventDate.Name = "lblEventDate"
        Me.lblEventDate.Size = New System.Drawing.Size(62, 13)
        Me.lblEventDate.TabIndex = 2
        Me.lblEventDate.Text = "Event date:"
        Me.lblEventDate.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(8, 149)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 24)
        Me.btnHelp.TabIndex = 10
        Me.btnHelp.Text = "Help"
        '
        'erpErrorProvider
        '
        Me.erpErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.erpErrorProvider.ContainerControl = Me
        '
        'lblSpecies
        '
        Me.lblSpecies.AutoSize = True
        Me.lblSpecies.Location = New System.Drawing.Point(12, 15)
        Me.lblSpecies.Name = "lblSpecies"
        Me.lblSpecies.Size = New System.Drawing.Size(48, 13)
        Me.lblSpecies.TabIndex = 0
        Me.lblSpecies.Text = "Species:"
        Me.lblSpecies.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'cboSpeciesList
        '
        Me.cboSpeciesList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSpeciesList.Location = New System.Drawing.Point(87, 12)
        Me.cboSpeciesList.Name = "cboSpeciesList"
        Me.cboSpeciesList.Size = New System.Drawing.Size(210, 21)
        Me.cboSpeciesList.TabIndex = 1
        '
        'chkUnder5cmClsl
        '
        Me.chkUnder5cmClsl.AutoSize = True
        Me.chkUnder5cmClsl.Location = New System.Drawing.Point(87, 93)
        Me.chkUnder5cmClsl.Name = "chkUnder5cmClsl"
        Me.chkUnder5cmClsl.Size = New System.Drawing.Size(107, 17)
        Me.chkUnder5cmClsl.TabIndex = 6
        Me.chkUnder5cmClsl.Text = "Under 5cm CLSL"
        Me.chkUnder5cmClsl.UseVisualStyleBackColor = True
        '
        'WashbacksDiedEventInformationDlg
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(315, 188)
        Me.Controls.Add(Me.chkUnder5cmClsl)
        Me.Controls.Add(Me.lblSpecies)
        Me.Controls.Add(Me.cboSpeciesList)
        Me.Controls.Add(Me.lblEventCount)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.txtEventCount)
        Me.Controls.Add(Me.dtpEventDate)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.lblEventDate)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "WashbacksDiedEventInformationDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Washbacks Died Event"
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private mbIsOkayButtonClicked As Boolean = False
    Private moWashbacksDiedEvent As WashbacksDiedEvent

    Public Sub New(ByVal oWashbacksDiedEvent As WashbacksDiedEvent)

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None

        moWashbacksDiedEvent = oWashbacksDiedEvent

    End Sub

    Private Sub frmWashbacksDiedEventInformationDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            '*** ASSERTION ***
            If moWashbacksDiedEvent Is Nothing Then
                Throw New ApplicationException("WashbacksDiedEvent object must be set before opening this screen.")
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
            moWashbacksDiedEvent.BeginEdit()

            Me.cboSpeciesList.SelectedIndex = cboSpeciesList.FindString(moWashbacksDiedEvent.SpeciesCode)

            Me.dtpEventDate.DateValue = moWashbacksDiedEvent.EventDate

            If (moWashbacksDiedEvent.EventCount = 0) Then
                Me.txtEventCount.Text = String.Empty
            Else
                Me.txtEventCount.Text = Convert.ToString(moWashbacksDiedEvent.EventCount)
            End If

            Me.chkUnder5cmClsl.Checked = moWashbacksDiedEvent.Under5CmClsl

            '----------------------------------------------------------------
            '-- display required field indicators 
            '----------------------------------------------------------------
            Me.DisplayBrokenRules(False)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub frmWashbacksDiedEventInformationDlg_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

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
            If moWashbacksDiedEvent.IsDirty Then

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
            moWashbacksDiedEvent.CancelEdit()
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
        Dim oTempWashbacksDiedEvent As WashbacksDiedEvent

        Try
            '------------------------------------------------------------ 
            '-- if the object has changed... 
            '------------------------------------------------------------ 
            If moWashbacksDiedEvent.IsDirty Then

                '------------------------------------------------------------ 
                '-- if all of the validation rules have passed... 
                '------------------------------------------------------------ 
                If moWashbacksDiedEvent.IsValid Then

                    '----------------------------------------------------------------
                    '-- commit edits in memory
                    '----------------------------------------------------------------
                    moWashbacksDiedEvent.ApplyEdit()

                    '----------------------------------------------------------------
                    '-- clone and save the object (it is the CSLA way)
                    '----------------------------------------------------------------
                    oTempWashbacksDiedEvent = moWashbacksDiedEvent.Clone
                    moWashbacksDiedEvent = oTempWashbacksDiedEvent.Save

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
            erpErrorProvider.SetError(Me.txtEventCount, "")

            '----------------------------------------------------------------
            '-- indicate any broken rules to the user
            '----------------------------------------------------------------
            If (bShowMessageBox) Then
                MessageBox.Show(" *** The following data validation issue(s) must be resolved before this package can be saved: *** " & ControlChars.CrLf & ControlChars.CrLf & moWashbacksDiedEvent.GetBrokenRulesString, Application.ProductName, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

            For i = 0 To moWashbacksDiedEvent.BrokenRulesCollection.Count() - 1
                Select Case moWashbacksDiedEvent.BrokenRulesCollection(i).Property
                    Case "EventCount"
                        erpErrorProvider.SetError(Me.txtEventCount, moWashbacksDiedEvent.BrokenRulesCollection(i).Description)
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
            moWashbacksDiedEvent.SpeciesCode = CType(Me.cboSpeciesList.SelectedItem, KeyValueInfo).Key
        End If

        moWashbacksDiedEvent.EventDate = Me.dtpEventDate.DateValue
        moWashbacksDiedEvent.EventCount = Convert.ToInt32(Val(Me.txtEventCount.Text.Trim))
        moWashbacksDiedEvent.Under5CmClsl = Me.chkUnder5cmClsl.Checked

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "WashbacksDiedEventScreen.htm")
    End Sub

End Class