<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CountyListForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CountyListForm))
        Me.grdCountyList = New System.Windows.Forms.DataGridView
        Me.colEditDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colDeleteDataGridViewLinkColumn = New System.Windows.Forms.DataGridViewLinkColumn
        Me.colCountyIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.colCountyNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.CountyListBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnCreateCounty = New System.Windows.Forms.Button
        Me.lblCounties = New System.Windows.Forms.Label
        Me.btnClose = New System.Windows.Forms.Button
        Me.btnHelp = New System.Windows.Forms.Button
        Me.lblSeparator = New System.Windows.Forms.Label
        CType(Me.grdCountyList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CountyListBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grdCountyList
        '
        Me.grdCountyList.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightYellow
        Me.grdCountyList.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.grdCountyList.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grdCountyList.AutoGenerateColumns = False
        Me.grdCountyList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.grdCountyList.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.colEditDataGridViewLinkColumn, Me.colDeleteDataGridViewLinkColumn, Me.colCountyIdDataGridViewTextBoxColumn, Me.colCountyNameDataGridViewTextBoxColumn})
        Me.grdCountyList.DataSource = Me.CountyListBindingSource
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.ActiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ActiveCaptionText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.grdCountyList.DefaultCellStyle = DataGridViewCellStyle2
        Me.grdCountyList.Location = New System.Drawing.Point(12, 25)
        Me.grdCountyList.MultiSelect = False
        Me.grdCountyList.Name = "grdCountyList"
        Me.grdCountyList.RowHeadersVisible = False
        Me.grdCountyList.RowHeadersWidth = 20
        Me.grdCountyList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.grdCountyList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grdCountyList.Size = New System.Drawing.Size(486, 225)
        Me.grdCountyList.TabIndex = 1
        '
        'colEditDataGridViewLinkColumn
        '
        Me.colEditDataGridViewLinkColumn.DataPropertyName = "EditAction"
        Me.colEditDataGridViewLinkColumn.Frozen = True
        Me.colEditDataGridViewLinkColumn.HeaderText = ""
        Me.colEditDataGridViewLinkColumn.Name = "colEditDataGridViewLinkColumn"
        Me.colEditDataGridViewLinkColumn.ReadOnly = True
        Me.colEditDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colEditDataGridViewLinkColumn.TrackVisitedState = False
        Me.colEditDataGridViewLinkColumn.Width = 28
        '
        'colDeleteDataGridViewLinkColumn
        '
        Me.colDeleteDataGridViewLinkColumn.DataPropertyName = "DeleteAction"
        Me.colDeleteDataGridViewLinkColumn.Frozen = True
        Me.colDeleteDataGridViewLinkColumn.HeaderText = ""
        Me.colDeleteDataGridViewLinkColumn.Name = "colDeleteDataGridViewLinkColumn"
        Me.colDeleteDataGridViewLinkColumn.ReadOnly = True
        Me.colDeleteDataGridViewLinkColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[False]
        Me.colDeleteDataGridViewLinkColumn.TrackVisitedState = False
        Me.colDeleteDataGridViewLinkColumn.Width = 40
        '
        'colCountyIdDataGridViewTextBoxColumn
        '
        Me.colCountyIdDataGridViewTextBoxColumn.DataPropertyName = "CountyId"
        Me.colCountyIdDataGridViewTextBoxColumn.HeaderText = "CountyId"
        Me.colCountyIdDataGridViewTextBoxColumn.Name = "colCountyIdDataGridViewTextBoxColumn"
        Me.colCountyIdDataGridViewTextBoxColumn.ReadOnly = True
        Me.colCountyIdDataGridViewTextBoxColumn.Visible = False
        '
        'colCountyNameDataGridViewTextBoxColumn
        '
        Me.colCountyNameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.colCountyNameDataGridViewTextBoxColumn.HeaderText = "County Name"
        Me.colCountyNameDataGridViewTextBoxColumn.Name = "colCountyNameDataGridViewTextBoxColumn"
        Me.colCountyNameDataGridViewTextBoxColumn.ReadOnly = True
        Me.colCountyNameDataGridViewTextBoxColumn.Width = 390
        '
        'CountyListBindingSource
        '
        Me.CountyListBindingSource.DataSource = GetType(TurtleGeek.Roster.CountyList)
        '
        'btnCreateCounty
        '
        Me.btnCreateCounty.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnCreateCounty.Location = New System.Drawing.Point(90, 271)
        Me.btnCreateCounty.Name = "btnCreateCounty"
        Me.btnCreateCounty.Size = New System.Drawing.Size(96, 24)
        Me.btnCreateCounty.TabIndex = 4
        Me.btnCreateCounty.Text = "&Add County..."
        Me.btnCreateCounty.UseVisualStyleBackColor = True
        '
        'lblCounties
        '
        Me.lblCounties.AutoSize = True
        Me.lblCounties.BackColor = System.Drawing.Color.Transparent
        Me.lblCounties.Location = New System.Drawing.Point(9, 9)
        Me.lblCounties.Name = "lblCounties"
        Me.lblCounties.Size = New System.Drawing.Size(51, 13)
        Me.lblCounties.TabIndex = 0
        Me.lblCounties.Text = "&Counties:"
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnClose.Location = New System.Drawing.Point(415, 272)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(72, 24)
        Me.btnClose.TabIndex = 5
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btnHelp.Location = New System.Drawing.Point(12, 271)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(72, 24)
        Me.btnHelp.TabIndex = 3
        Me.btnHelp.Text = "&Help"
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(7, 261)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(497, 2)
        Me.lblSeparator.TabIndex = 2
        '
        'CountyListForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 307)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.grdCountyList)
        Me.Controls.Add(Me.lblCounties)
        Me.Controls.Add(Me.btnCreateCounty)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MinimizeBox = False
        Me.Name = "CountyListForm"
        Me.ShowInTaskbar = False
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ROSTER - Counties"
        CType(Me.grdCountyList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CountyListBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grdCountyList As System.Windows.Forms.DataGridView
    Friend WithEvents btnCreateCounty As System.Windows.Forms.Button
    Friend WithEvents lblCounties As System.Windows.Forms.Label
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents CountyListBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents colEditDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colDeleteDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colCountyIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colCountyNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblSeparator As System.Windows.Forms.Label
End Class
