Option Explicit On
Option Strict On

Public Class CountyEditForm

    Private mbIsLoading As Boolean
    Private mbIsOkayButtonClicked As Boolean = False
    Private WithEvents moCounty As County

    Public ReadOnly Property County() As County
        Get
            Return moCounty
        End Get
    End Property

    Public Sub New(ByVal oCounty As County)

        mbIsLoading = True

        InitializeComponent()

        moCounty = oCounty

        Me.CountyBindingSource.DataSource = moCounty

        mbIsLoading = False

    End Sub

    Private Sub CountyEditForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            Cursor.Current = Cursors.WaitCursor

            mbIsLoading = True

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            mbIsLoading = False

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub CountyEditForm_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing

        Dim bCancelFormClosingEvent As Boolean = False

        If mbIsOkayButtonClicked Then

            '----------------------------------------------------------------
            '-- form being closed via OK button; 
            '-- validate data values, commit to the database, etc.
            '----------------------------------------------------------------
            bCancelFormClosingEvent = Not DoSaveLogic()

        Else

            '----------------------------------------------------------------
            '-- must move focus off of any data field to register value change with underlying data-bound object...ugh...
            '----------------------------------------------------------------
            Me.btnCancel.Focus()

            '----------------------------------------------------------------
            '-- form being closed via Cancel button or Close [X] button; 
            '-- if object is dirty, prompt for save, etc.
            '----------------------------------------------------------------
            bCancelFormClosingEvent = Not DoCancelLogic()

        End If

        If bCancelFormClosingEvent Then

            '----------------------------------------------------------------
            '-- CANCEL the form closing event and return the user to the form
            '----------------------------------------------------------------
            e.Cancel = True
            mbIsOkayButtonClicked = False

        Else

            '----------------------------------------------------------------
            '-- PROCEED with the form closing event
            '----------------------------------------------------------------
            e.Cancel = False
            UnbindBindingSource(Me.CountyBindingSource, True, True)

        End If

    End Sub

    Private Sub CountyEditForm_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown

        Try

            '----------------------------------------------------------------
            '-- if the <ESCAPE> key was been pressed, 
            '-- react as if the Cancel button was pressed
            '----------------------------------------------------------------
            If (e.KeyCode = Keys.Escape) Then

                DoCancelLogic()

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click

        Try

            mbIsOkayButtonClicked = False

            Me.Close()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click

        Try

            mbIsOkayButtonClicked = True

            Me.Close()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Function DoCancelLogic() As Boolean

        Dim oDialogResult As System.Windows.Forms.DialogResult

        Try
            '----------------------------------------------------------------
            '-- if the object has changed 
            '-- but the user has clicked the Cancel button...
            '----------------------------------------------------------------
            If moCounty.IsDirty Then

                '----------------------------------------------------------------
                '-- prompt the user to save the changes
                '----------------------------------------------------------------
                oDialogResult = MessageBox.Show("Save changes?", My.Application.Info.Title, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question)

                Select Case oDialogResult

                    '----------------------------------------------------------------
                    '-- if the user wishes to save the changes, 
                    '-- attempt to validate and save the object
                    '----------------------------------------------------------------
                    Case System.Windows.Forms.DialogResult.Yes

                        Return DoSaveLogic()

                    Case System.Windows.Forms.DialogResult.No

                        '----------------------------------------------------------------
                        '-- if the user does NOT wish to save the changes, 
                        '-- do nothing; fall through, cancel changes, and close the form
                        '----------------------------------------------------------------

                    Case System.Windows.Forms.DialogResult.Cancel

                        '----------------------------------------------------------------
                        '-- if the user cancels the confirmation, 
                        '-- do NOT save the changes and return the user to the form
                        '----------------------------------------------------------------

                        Return False '<-- DO cancel the form closing event

                End Select

            End If

            '----------------------------------------------------------------
            '-- if the object changed but the user does NOT want to save the changes 
            '-- OR the object has NOT changed, 
            '-- then cancel the edit and continue closing the form
            '----------------------------------------------------------------
            Me.CountyBindingSource.RaiseListChangedEvents = False

            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel

            Return True     '<-- do NOT cancel the form closing event

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

            Return False    '<-- DO cancel the form closing event

        Finally

        End Try

    End Function

    Private Function DoSaveLogic() As Boolean

        '----------------------------------------------------------------
        '-- validate data and save object; 
        '-- if the data is NOT valid, do NOT leave the form
        '----------------------------------------------------------------
        Dim oTempCounty As County

        Try
            '----------------------------------------------------------------
            '-- stop the flow of events
            '----------------------------------------------------------------
            Me.CountyBindingSource.RaiseListChangedEvents = False

            '----------------------------------------------------------------
            '-- if the object has changed...
            '----------------------------------------------------------------
            If moCounty.IsDirty Then

                '----------------------------------------------------------------
                '-- if all of the validation rules have passed, 
                '-- then save the object... 
                '----------------------------------------------------------------
                If moCounty.IsValid Then

                    '----------------------------------------------------------------
                    '-- commit edits in memory
                    '----------------------------------------------------------------
                    Me.CountyBindingSource.EndEdit()

                    '----------------------------------------------------------------
                    '-- clone and save the object (it is the CSLA way)
                    '----------------------------------------------------------------
                    oTempCounty = moCounty.Clone
                    moCounty = oTempCounty.Save

                Else

                    '----------------------------------------------------------------
                    '-- else, display the list of broken rules
                    '-- but do NOT close the form
                    '----------------------------------------------------------------
                    MessageBox.Show(moCounty.BrokenRulesCollection.ToString, My.Application.Info.Title, MessageBoxButtons.OK, MessageBoxIcon.Exclamation)

                    '----------------------------------------------------------------
                    '-- CSLA/binding stuff
                    '----------------------------------------------------------------
                    Me.CountyBindingSource.RaiseListChangedEvents = True

                    Me.CountyBindingSource.ResetBindings(False)

                    Return False '<-- DO cancel the form closing event

                End If

            End If

            '----------------------------------------------------------------
            '-- if the object has NOT changed
            '-- OR if the data is valid and the object was saved,
            '-- then continue closing the form
            '----------------------------------------------------------------
            Me.DialogResult = System.Windows.Forms.DialogResult.OK

            Return True     '<-- do NOT cancel the form closing event

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

            Return False    '<-- DO cancel the form closing event

        Finally

        End Try

    End Function

    Private Sub TextBoxSelectAll(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtCountyName.Enter
        DirectCast(sender, TextBox).SelectAll()
    End Sub

    Private Sub HandleControlA(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtCountyName.KeyDown
        If e.Control AndAlso (e.KeyCode = Keys.A) Then
            DirectCast(sender, TextBox).SelectAll()
        End If
    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "MasterFilesCounty.htm")
    End Sub

End Class