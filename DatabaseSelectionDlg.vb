Option Explicit On 
Option Strict On
Option Compare Text

Public Class DatabaseSelectionDlg
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
    Friend WithEvents colTagEditActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTagDeleteActionDataGridViewLinkColumn As System.Windows.Forms.DataGridViewLinkColumn
    Friend WithEvents colTagHatchlingsDiedEventTagIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagHatchlingsDiedEventIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagTagNumberDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagTypeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagLocationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagDateTaggedDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents colTagDateTaggedStringDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents radAccess As System.Windows.Forms.RadioButton
    Friend WithEvents radSqlite As System.Windows.Forms.RadioButton
    Friend WithEvents lblDatabaseSelection As System.Windows.Forms.Label
    Friend WithEvents lblSqlite As System.Windows.Forms.Label
    Friend WithEvents lblAccess As System.Windows.Forms.Label
    Friend WithEvents erpErrorProvider As System.Windows.Forms.ErrorProvider
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DatabaseSelectionDlg))
        Me.lblSeparator = New System.Windows.Forms.Label
        Me.btnCancel = New System.Windows.Forms.Button
        Me.btnOK = New System.Windows.Forms.Button
        Me.tipToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.erpErrorProvider = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.radSqlite = New System.Windows.Forms.RadioButton
        Me.radAccess = New System.Windows.Forms.RadioButton
        Me.lblSqlite = New System.Windows.Forms.Label
        Me.lblDatabaseSelection = New System.Windows.Forms.Label
        Me.lblAccess = New System.Windows.Forms.Label
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSeparator
        '
        Me.lblSeparator.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator.Location = New System.Drawing.Point(8, 223)
        Me.lblSeparator.Name = "lblSeparator"
        Me.lblSeparator.Size = New System.Drawing.Size(297, 2)
        Me.lblSeparator.TabIndex = 5
        '
        'btnCancel
        '
        Me.btnCancel.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(233, 239)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(72, 24)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel"
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.Location = New System.Drawing.Point(153, 239)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 24)
        Me.btnOK.TabIndex = 6
        Me.btnOK.Text = "OK"
        '
        'erpErrorProvider
        '
        Me.erpErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink
        Me.erpErrorProvider.ContainerControl = Me
        '
        'radSqlite
        '
        Me.radSqlite.AutoSize = True
        Me.radSqlite.Checked = True
        Me.radSqlite.Location = New System.Drawing.Point(12, 52)
        Me.radSqlite.Name = "radSqlite"
        Me.radSqlite.Size = New System.Drawing.Size(57, 17)
        Me.radSqlite.TabIndex = 1
        Me.radSqlite.TabStop = True
        Me.radSqlite.Text = "SQLite"
        Me.radSqlite.UseVisualStyleBackColor = True
        '
        'radAccess
        '
        Me.radAccess.AutoSize = True
        Me.radAccess.Location = New System.Drawing.Point(12, 131)
        Me.radAccess.Name = "radAccess"
        Me.radAccess.Size = New System.Drawing.Size(115, 17)
        Me.radAccess.TabIndex = 3
        Me.radAccess.Text = "Microsoft Access™"
        Me.radAccess.UseVisualStyleBackColor = True
        '
        'lblSqlite
        '
        Me.lblSqlite.Location = New System.Drawing.Point(30, 72)
        Me.lblSqlite.Name = "lblSqlite"
        Me.lblSqlite.Size = New System.Drawing.Size(273, 46)
        Me.lblSqlite.TabIndex = 2
        Me.lblSqlite.Text = "(default)  SQLite is a free, open-source database.  If you do not have a license " & _
            "for Microsoft Access™, then choose this option."
        '
        'lblDatabaseSelection
        '
        Me.lblDatabaseSelection.BackColor = System.Drawing.Color.MintCream
        Me.lblDatabaseSelection.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.lblDatabaseSelection.ForeColor = System.Drawing.Color.Blue
        Me.lblDatabaseSelection.Location = New System.Drawing.Point(12, 9)
        Me.lblDatabaseSelection.Name = "lblDatabaseSelection"
        Me.lblDatabaseSelection.Size = New System.Drawing.Size(291, 33)
        Me.lblDatabaseSelection.TabIndex = 0
        Me.lblDatabaseSelection.Text = "Select the database for the ROSTER application to use."
        Me.lblDatabaseSelection.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAccess
        '
        Me.lblAccess.Location = New System.Drawing.Point(30, 151)
        Me.lblAccess.Name = "lblAccess"
        Me.lblAccess.Size = New System.Drawing.Size(273, 46)
        Me.lblAccess.TabIndex = 4
        Me.lblAccess.Text = "Choose this option if you prefer to use a Microsoft Access™ database, if you have" & _
            " a license for it, and if you have it installed on your computer."
        '
        'DatabaseSelectionDlg
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(315, 278)
        Me.Controls.Add(Me.lblAccess)
        Me.Controls.Add(Me.lblDatabaseSelection)
        Me.Controls.Add(Me.lblSqlite)
        Me.Controls.Add(Me.radAccess)
        Me.Controls.Add(Me.radSqlite)
        Me.Controls.Add(Me.lblSeparator)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "DatabaseSelectionDlg"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ROSTER - Database Selection"
        CType(Me.erpErrorProvider, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private meDBMS As TurtleGeek.Data.DatabaseTypeEnum

    Public ReadOnly Property DBMS() As TurtleGeek.Data.DatabaseTypeEnum
        Get
            Return meDBMS
        End Get
    End Property

    Public Sub New()

        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.None

    End Sub

    Private Sub frmDatabaseSelectionDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            '----------------------------------------------------------------
            '----------------------------------------------------------------

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub frmDatabaseSelectionDlg_Closing(ByVal sender As Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles MyBase.Closing

        If Me.radAccess.Checked Then
            meDBMS = DatabaseTypeEnum.OleDb
        Else
            meDBMS = DatabaseTypeEnum.SQLite
        End If

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Try
            Me.DialogResult = System.Windows.Forms.DialogResult.OK
            Me.Close()
        Catch ex As Exception
            ErrorMessageBox.Show(ex)
        End Try
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Try
            Me.DialogResult = System.Windows.Forms.DialogResult.Cancel
            Me.Close()
        Catch ex As Exception
            ErrorMessageBox.Show(ex)
        End Try
    End Sub

End Class
