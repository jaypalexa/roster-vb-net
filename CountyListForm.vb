Option Explicit On
Option Strict On

Public Class CountyListForm

    Private Sub CountyListForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            Cursor.Current = Cursors.WaitCursor

            LoadCountyList()

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnClose_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClose.Click

        Try

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Me.Close()

        End Try

    End Sub

    Private Sub LoadCountyList()

        Dim oSortedBindingList As Csla.SortedBindingList(Of CountyInfo)

        Try
            Cursor.Current = Cursors.WaitCursor

            oSortedBindingList = New Csla.SortedBindingList(Of CountyInfo)(CountyList.GetList)
            oSortedBindingList.ApplySort("Name", System.ComponentModel.ListSortDirection.Ascending)

            Me.CountyListBindingSource.DataSource = oSortedBindingList

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub grdCountyList_CellContentClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grdCountyList.CellContentClick

        If (TypeOf (Me.grdCountyList.Columns(e.ColumnIndex)) Is DataGridViewLinkColumn) AndAlso (e.RowIndex > -1) Then

            If (Convert.ToString(Me.grdCountyList.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) = "edit") Then
                EditCounty(sender, New System.EventArgs())
            ElseIf (Convert.ToString(Me.grdCountyList.Rows(e.RowIndex).Cells(e.ColumnIndex).Value) = "delete") Then
                DeleteCounty(sender, New System.EventArgs())
            End If

        End If

    End Sub

    Private Sub grdCountyList_ColumnDividerDoubleClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewColumnDividerDoubleClickEventArgs) Handles grdCountyList.ColumnDividerDoubleClick

        If ((Me.grdCountyList.Columns(e.ColumnIndex).Visible) AndAlso (Not Me.grdCountyList.Columns(e.ColumnIndex).Frozen)) Then
            Me.grdCountyList.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            Me.grdCountyList.Columns(e.ColumnIndex).AutoSizeMode = DataGridViewAutoSizeColumnMode.NotSet
        End If

    End Sub

    Private Sub grdCountyList_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdCountyList.DoubleClick

        Dim oPoint As Point = Me.grdCountyList.PointToClient(Cursor.Position)
        Dim oHitTestInfo As DataGridView.HitTestInfo = Me.grdCountyList.HitTest(oPoint.X, oPoint.Y)

        '----------------------------------------------------------------
        '-- only edit the record if a data row cell was double-clicked
        '-- (we do this to allow a double click of the column separator to resize the column)
        '----------------------------------------------------------------
        If (oHitTestInfo.Type = DataGridViewHitTestType.Cell) Then
            EditCounty(sender, e)
        End If

    End Sub

    Public Sub CreateCounty(ByVal sender As Object, ByVal e As System.EventArgs) Handles btnCreateCounty.Click

        Dim frm As CountyEditForm = Nothing

        Try
            frm = New CountyEditForm(County.NewCounty())

            frm.ShowDialog(Me)

            If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                LoadCountyList()

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            If Not (frm Is Nothing) Then
                frm.Dispose()
                frm = Nothing
            End If

        End Try

    End Sub

    Public Sub EditCounty(ByVal sender As Object, ByVal e As System.EventArgs) Handles grdCountyList.DoubleClick

        Dim sCountyId As String = String.Empty
        Dim frm As CountyEditForm = Nothing

        Try

            If (grdCountyList.SelectedRows.Count > 0) Then

                sCountyId = Convert.ToString(grdCountyList.SelectedRows(0).Cells(Me.colCountyIdDataGridViewTextBoxColumn.Name).Value)

                frm = New CountyEditForm(County.GetCounty(sCountyId))

                frm.ShowDialog(Me)

                If (frm.DialogResult = System.Windows.Forms.DialogResult.OK) Then

                    LoadCountyList()

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            If Not (frm Is Nothing) Then
                frm.Dispose()
                frm = Nothing
            End If

        End Try

    End Sub

    Public Sub DeleteCounty(ByVal sender As Object, ByVal e As System.EventArgs)

        Dim sCountyId As String = String.Empty

        Try

            If (grdCountyList.SelectedRows.Count > 0) Then

                sCountyId = Convert.ToString(grdCountyList.SelectedRows(0).Cells(Me.colCountyIdDataGridViewTextBoxColumn.Name).Value)

                If (MessageBox.Show("Delete County '" & Convert.ToString(grdCountyList.SelectedRows(0).Cells(Me.colCountyNameDataGridViewTextBoxColumn.Name).Value) & "'?  This action CANNOT be undone.", My.Application.Info.Title, MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) = System.Windows.Forms.DialogResult.Yes) Then

                    Cursor.Current = Cursors.WaitCursor

                    County.DeleteCounty(sCountyId)

                    LoadCountyList()

                End If

            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnHelp_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHelp.Click
        Help.ShowHelp(Me, gsHelpFileName, "MasterFilesCounty.htm")
    End Sub

End Class