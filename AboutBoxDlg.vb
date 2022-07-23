Option Explicit On 
Option Strict On
Option Compare Text

Imports Microsoft.Win32

Public Class AboutBoxDlg
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

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
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents lblAppName As System.Windows.Forms.Label
    Friend WithEvents lblAppVersion As System.Windows.Forms.Label
    Friend WithEvents lnkAdobeReader As System.Windows.Forms.LinkLabel
    Friend WithEvents lblOriginal01 As System.Windows.Forms.Label
    Friend WithEvents lblOriginal03 As System.Windows.Forms.Label
    Friend WithEvents lblOriginal02 As System.Windows.Forms.Label
    Friend WithEvents lnkOriginalForms As System.Windows.Forms.LinkLabel
    Friend WithEvents picGetAdobeReader As System.Windows.Forms.PictureBox
    Friend WithEvents picFwcLogo As System.Windows.Forms.PictureBox
    Friend WithEvents picRosterLogo As System.Windows.Forms.PictureBox
    Friend WithEvents lblOriginal04 As System.Windows.Forms.Label
    Friend WithEvents lnkSqliteAdministrator As System.Windows.Forms.LinkLabel
    Friend WithEvents picGetSqliteAdministrator As System.Windows.Forms.PictureBox
    Friend WithEvents lblSeparator2 As System.Windows.Forms.Label
    Friend WithEvents lnkTurtleGeek As System.Windows.Forms.LinkLabel
    Friend WithEvents lblSeparator1 As System.Windows.Forms.Label
    Friend WithEvents lnkEndUserLicenseAgreement As System.Windows.Forms.LinkLabel
    Friend WithEvents lblAppCopyright As System.Windows.Forms.Label
    Friend WithEvents lblGraphicsCourtesyOf As System.Windows.Forms.Label
    Friend WithEvents lblAdobeDescription As System.Windows.Forms.Label
    Friend WithEvents lblSqliteAdministratorDescription As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AboutBoxDlg))
        Me.lblSeparator2 = New System.Windows.Forms.Label
        Me.btnOK = New System.Windows.Forms.Button
        Me.lblAppName = New System.Windows.Forms.Label
        Me.lblAppVersion = New System.Windows.Forms.Label
        Me.lblOriginal01 = New System.Windows.Forms.Label
        Me.lnkAdobeReader = New System.Windows.Forms.LinkLabel
        Me.lblAdobeDescription = New System.Windows.Forms.Label
        Me.lblOriginal03 = New System.Windows.Forms.Label
        Me.lblOriginal02 = New System.Windows.Forms.Label
        Me.lnkOriginalForms = New System.Windows.Forms.LinkLabel
        Me.picGetAdobeReader = New System.Windows.Forms.PictureBox
        Me.picFwcLogo = New System.Windows.Forms.PictureBox
        Me.picRosterLogo = New System.Windows.Forms.PictureBox
        Me.lblOriginal04 = New System.Windows.Forms.Label
        Me.picGetSqliteAdministrator = New System.Windows.Forms.PictureBox
        Me.lblSqliteAdministratorDescription = New System.Windows.Forms.Label
        Me.lnkSqliteAdministrator = New System.Windows.Forms.LinkLabel
        Me.lblAppCopyright = New System.Windows.Forms.Label
        Me.lnkTurtleGeek = New System.Windows.Forms.LinkLabel
        Me.lblSeparator1 = New System.Windows.Forms.Label
        Me.lnkEndUserLicenseAgreement = New System.Windows.Forms.LinkLabel
        Me.lblGraphicsCourtesyOf = New System.Windows.Forms.Label
        CType(Me.picGetAdobeReader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picFwcLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picRosterLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picGetSqliteAdministrator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblSeparator2
        '
        Me.lblSeparator2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator2.Location = New System.Drawing.Point(9, 376)
        Me.lblSeparator2.Name = "lblSeparator2"
        Me.lblSeparator2.Size = New System.Drawing.Size(584, 2)
        Me.lblSeparator2.TabIndex = 16
        '
        'btnOK
        '
        Me.btnOK.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnOK.Location = New System.Drawing.Point(520, 392)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(72, 24)
        Me.btnOK.TabIndex = 0
        Me.btnOK.Text = "OK"
        '
        'lblAppName
        '
        Me.lblAppName.AutoSize = True
        Me.lblAppName.Font = New System.Drawing.Font("Verdana", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppName.Location = New System.Drawing.Point(64, 16)
        Me.lblAppName.Name = "lblAppName"
        Me.lblAppName.Size = New System.Drawing.Size(138, 18)
        Me.lblAppName.TabIndex = 1
        Me.lblAppName.Text = "<lblAppName>"
        Me.lblAppName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblAppVersion
        '
        Me.lblAppVersion.AutoSize = True
        Me.lblAppVersion.Font = New System.Drawing.Font("Verdana", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppVersion.Location = New System.Drawing.Point(64, 36)
        Me.lblAppVersion.Name = "lblAppVersion"
        Me.lblAppVersion.Size = New System.Drawing.Size(113, 16)
        Me.lblAppVersion.TabIndex = 2
        Me.lblAppVersion.Text = "<lblAppVersion>"
        Me.lblAppVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblOriginal01
        '
        Me.lblOriginal01.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOriginal01.AutoSize = True
        Me.lblOriginal01.Location = New System.Drawing.Point(112, 120)
        Me.lblOriginal01.Name = "lblOriginal01"
        Me.lblOriginal01.Size = New System.Drawing.Size(152, 13)
        Me.lblOriginal01.TabIndex = 7
        Me.lblOriginal01.Text = "Original reports and forms from:"
        '
        'lnkAdobeReader
        '
        Me.lnkAdobeReader.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkAdobeReader.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkAdobeReader.AutoSize = True
        Me.lnkAdobeReader.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkAdobeReader.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.lnkAdobeReader.Location = New System.Drawing.Point(112, 248)
        Me.lnkAdobeReader.Name = "lnkAdobeReader"
        Me.lnkAdobeReader.Size = New System.Drawing.Size(127, 13)
        Me.lnkAdobeReader.TabIndex = 13
        Me.lnkAdobeReader.TabStop = True
        Me.lnkAdobeReader.Text = "Download Adobe Reader"
        Me.lnkAdobeReader.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkAdobeReader.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lblAdobeDescription
        '
        Me.lblAdobeDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblAdobeDescription.AutoSize = True
        Me.lblAdobeDescription.Location = New System.Drawing.Point(112, 232)
        Me.lblAdobeDescription.Name = "lblAdobeDescription"
        Me.lblAdobeDescription.Size = New System.Drawing.Size(343, 13)
        Me.lblAdobeDescription.TabIndex = 12
        Me.lblAdobeDescription.Text = "This program requires Adobe Reader to preview, print, and fill out forms."
        '
        'lblOriginal03
        '
        Me.lblOriginal03.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOriginal03.AutoSize = True
        Me.lblOriginal03.Location = New System.Drawing.Point(112, 158)
        Me.lblOriginal03.Name = "lblOriginal03"
        Me.lblOriginal03.Size = New System.Drawing.Size(289, 13)
        Me.lblOriginal03.TabIndex = 9
        Me.lblOriginal03.Text = "Marine Turtle Conservation Guidelines -- Appendix A - Forms"
        '
        'lblOriginal02
        '
        Me.lblOriginal02.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOriginal02.AutoSize = True
        Me.lblOriginal02.Location = New System.Drawing.Point(112, 142)
        Me.lblOriginal02.Name = "lblOriginal02"
        Me.lblOriginal02.Size = New System.Drawing.Size(241, 13)
        Me.lblOriginal02.TabIndex = 8
        Me.lblOriginal02.Text = "Florida Fish and Wildlife Conservation Commission"
        '
        'lnkOriginalForms
        '
        Me.lnkOriginalForms.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkOriginalForms.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkOriginalForms.AutoSize = True
        Me.lnkOriginalForms.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkOriginalForms.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.lnkOriginalForms.Location = New System.Drawing.Point(112, 174)
        Me.lnkOriginalForms.Name = "lnkOriginalForms"
        Me.lnkOriginalForms.Size = New System.Drawing.Size(387, 13)
        Me.lnkOriginalForms.TabIndex = 10
        Me.lnkOriginalForms.TabStop = True
        Me.lnkOriginalForms.Text = "http://myfwc.com/wildlifehabitats/managed/sea-turtles/conservation-guidelines/"
        Me.lnkOriginalForms.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkOriginalForms.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'picGetAdobeReader
        '
        Me.picGetAdobeReader.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picGetAdobeReader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGetAdobeReader.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picGetAdobeReader.Image = CType(resources.GetObject("picGetAdobeReader.Image"), System.Drawing.Image)
        Me.picGetAdobeReader.Location = New System.Drawing.Point(16, 230)
        Me.picGetAdobeReader.Name = "picGetAdobeReader"
        Me.picGetAdobeReader.Size = New System.Drawing.Size(90, 33)
        Me.picGetAdobeReader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picGetAdobeReader.TabIndex = 35
        Me.picGetAdobeReader.TabStop = False
        '
        'picFwcLogo
        '
        Me.picFwcLogo.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picFwcLogo.BackColor = System.Drawing.Color.White
        Me.picFwcLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picFwcLogo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picFwcLogo.Image = CType(resources.GetObject("picFwcLogo.Image"), System.Drawing.Image)
        Me.picFwcLogo.Location = New System.Drawing.Point(16, 120)
        Me.picFwcLogo.Name = "picFwcLogo"
        Me.picFwcLogo.Size = New System.Drawing.Size(88, 97)
        Me.picFwcLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picFwcLogo.TabIndex = 36
        Me.picFwcLogo.TabStop = False
        '
        'picRosterLogo
        '
        Me.picRosterLogo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picRosterLogo.Image = CType(resources.GetObject("picRosterLogo.Image"), System.Drawing.Image)
        Me.picRosterLogo.Location = New System.Drawing.Point(16, 16)
        Me.picRosterLogo.Name = "picRosterLogo"
        Me.picRosterLogo.Size = New System.Drawing.Size(46, 40)
        Me.picRosterLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize
        Me.picRosterLogo.TabIndex = 37
        Me.picRosterLogo.TabStop = False
        '
        'lblOriginal04
        '
        Me.lblOriginal04.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblOriginal04.AutoSize = True
        Me.lblOriginal04.Location = New System.Drawing.Point(112, 198)
        Me.lblOriginal04.Name = "lblOriginal04"
        Me.lblOriginal04.Size = New System.Drawing.Size(206, 13)
        Me.lblOriginal04.TabIndex = 11
        Me.lblOriginal04.Text = "FWC office in Tequesta -- (561) 575-5407 "
        '
        'picGetSqliteAdministrator
        '
        Me.picGetSqliteAdministrator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.picGetSqliteAdministrator.BackColor = System.Drawing.Color.White
        Me.picGetSqliteAdministrator.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picGetSqliteAdministrator.Cursor = System.Windows.Forms.Cursors.Hand
        Me.picGetSqliteAdministrator.Image = CType(resources.GetObject("picGetSqliteAdministrator.Image"), System.Drawing.Image)
        Me.picGetSqliteAdministrator.Location = New System.Drawing.Point(16, 280)
        Me.picGetSqliteAdministrator.Name = "picGetSqliteAdministrator"
        Me.picGetSqliteAdministrator.Size = New System.Drawing.Size(88, 75)
        Me.picGetSqliteAdministrator.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picGetSqliteAdministrator.TabIndex = 39
        Me.picGetSqliteAdministrator.TabStop = False
        Me.picGetSqliteAdministrator.Visible = False
        '
        'lblSqliteAdministratorDescription
        '
        Me.lblSqliteAdministratorDescription.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblSqliteAdministratorDescription.AutoSize = True
        Me.lblSqliteAdministratorDescription.Location = New System.Drawing.Point(112, 280)
        Me.lblSqliteAdministratorDescription.Name = "lblSqliteAdministratorDescription"
        Me.lblSqliteAdministratorDescription.Size = New System.Drawing.Size(364, 13)
        Me.lblSqliteAdministratorDescription.TabIndex = 14
        Me.lblSqliteAdministratorDescription.Text = "Use SQLite Administrator to access the SQLite database used by ROSTER."
        Me.lblSqliteAdministratorDescription.Visible = False
        '
        'lnkSqliteAdministrator
        '
        Me.lnkSqliteAdministrator.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkSqliteAdministrator.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkSqliteAdministrator.AutoSize = True
        Me.lnkSqliteAdministrator.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkSqliteAdministrator.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.lnkSqliteAdministrator.Location = New System.Drawing.Point(112, 296)
        Me.lnkSqliteAdministrator.Name = "lnkSqliteAdministrator"
        Me.lnkSqliteAdministrator.Size = New System.Drawing.Size(153, 13)
        Me.lnkSqliteAdministrator.TabIndex = 15
        Me.lnkSqliteAdministrator.TabStop = True
        Me.lnkSqliteAdministrator.Text = "Download SQLite Administrator"
        Me.lnkSqliteAdministrator.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkSqliteAdministrator.Visible = False
        Me.lnkSqliteAdministrator.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lblAppCopyright
        '
        Me.lblAppCopyright.AutoSize = True
        Me.lblAppCopyright.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAppCopyright.Location = New System.Drawing.Point(64, 55)
        Me.lblAppCopyright.Name = "lblAppCopyright"
        Me.lblAppCopyright.Size = New System.Drawing.Size(92, 13)
        Me.lblAppCopyright.TabIndex = 3
        Me.lblAppCopyright.Text = "<lblAppCopyright>"
        Me.lblAppCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lnkTurtleGeek
        '
        Me.lnkTurtleGeek.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkTurtleGeek.AutoSize = True
        Me.lnkTurtleGeek.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkTurtleGeek.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.lnkTurtleGeek.Location = New System.Drawing.Point(64, 80)
        Me.lnkTurtleGeek.Name = "lnkTurtleGeek"
        Me.lnkTurtleGeek.Size = New System.Drawing.Size(144, 13)
        Me.lnkTurtleGeek.TabIndex = 4
        Me.lnkTurtleGeek.TabStop = True
        Me.lnkTurtleGeek.Text = "www.TurtleGeek.com"
        Me.lnkTurtleGeek.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkTurtleGeek.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lblSeparator1
        '
        Me.lblSeparator1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblSeparator1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblSeparator1.Location = New System.Drawing.Point(8, 104)
        Me.lblSeparator1.Name = "lblSeparator1"
        Me.lblSeparator1.Size = New System.Drawing.Size(584, 2)
        Me.lblSeparator1.TabIndex = 6
        '
        'lnkEndUserLicenseAgreement
        '
        Me.lnkEndUserLicenseAgreement.ActiveLinkColor = System.Drawing.Color.Blue
        Me.lnkEndUserLicenseAgreement.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lnkEndUserLicenseAgreement.AutoSize = True
        Me.lnkEndUserLicenseAgreement.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lnkEndUserLicenseAgreement.LinkBehavior = System.Windows.Forms.LinkBehavior.AlwaysUnderline
        Me.lnkEndUserLicenseAgreement.Location = New System.Drawing.Point(6, 398)
        Me.lnkEndUserLicenseAgreement.Name = "lnkEndUserLicenseAgreement"
        Me.lnkEndUserLicenseAgreement.Size = New System.Drawing.Size(376, 13)
        Me.lnkEndUserLicenseAgreement.TabIndex = 17
        Me.lnkEndUserLicenseAgreement.TabStop = True
        Me.lnkEndUserLicenseAgreement.Text = "Use of this software is subject to the terms of the End-User License Agreement"
        Me.lnkEndUserLicenseAgreement.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.lnkEndUserLicenseAgreement.VisitedLinkColor = System.Drawing.Color.Blue
        '
        'lblGraphicsCourtesyOf
        '
        Me.lblGraphicsCourtesyOf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblGraphicsCourtesyOf.AutoSize = True
        Me.lblGraphicsCourtesyOf.Font = New System.Drawing.Font("Verdana", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGraphicsCourtesyOf.Location = New System.Drawing.Point(279, 82)
        Me.lblGraphicsCourtesyOf.Name = "lblGraphicsCourtesyOf"
        Me.lblGraphicsCourtesyOf.Size = New System.Drawing.Size(287, 13)
        Me.lblGraphicsCourtesyOf.TabIndex = 5
        Me.lblGraphicsCourtesyOf.Text = "[> Graphics courtesy of Megan Ortowski <]"
        '
        'AboutBoxDlg
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.CancelButton = Me.btnOK
        Me.ClientSize = New System.Drawing.Size(602, 431)
        Me.Controls.Add(Me.lblGraphicsCourtesyOf)
        Me.Controls.Add(Me.lnkEndUserLicenseAgreement)
        Me.Controls.Add(Me.lblSeparator1)
        Me.Controls.Add(Me.lnkTurtleGeek)
        Me.Controls.Add(Me.lblAppCopyright)
        Me.Controls.Add(Me.lblSqliteAdministratorDescription)
        Me.Controls.Add(Me.lnkSqliteAdministrator)
        Me.Controls.Add(Me.lblOriginal04)
        Me.Controls.Add(Me.lnkOriginalForms)
        Me.Controls.Add(Me.lblOriginal02)
        Me.Controls.Add(Me.lblOriginal03)
        Me.Controls.Add(Me.lnkAdobeReader)
        Me.Controls.Add(Me.lblAdobeDescription)
        Me.Controls.Add(Me.lblOriginal01)
        Me.Controls.Add(Me.lblAppName)
        Me.Controls.Add(Me.lblAppVersion)
        Me.Controls.Add(Me.picGetSqliteAdministrator)
        Me.Controls.Add(Me.picRosterLogo)
        Me.Controls.Add(Me.picFwcLogo)
        Me.Controls.Add(Me.picGetAdobeReader)
        Me.Controls.Add(Me.lblSeparator2)
        Me.Controls.Add(Me.btnOK)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "AboutBoxDlg"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "About ROSTER"
        CType(Me.picGetAdobeReader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picFwcLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picRosterLogo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picGetSqliteAdministrator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

#End Region

    Private Sub frmAboutBoxDlg_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim s As String = String.Empty

        Try
            System.Windows.Forms.Cursor.Current = Cursors.WaitCursor

            'Me.lblAppName.Text = Application.ProductName
            Me.lblAppName.Text = "ROSTER - Record of Sea Turtles Electronic Reports"
            Me.lblAppVersion.Text = "Version " & Application.ProductVersion
            Me.lblAppCopyright.Text = Application.CompanyName

            Using oAdoHelper As AdoHelper = AdoHelper.CreateHelper()
                Me.picGetSqliteAdministrator.Visible = (oAdoHelper.DBMS = DatabaseTypeEnum.SQLite)
                Me.lblSqliteAdministratorDescription.Visible = (oAdoHelper.DBMS = DatabaseTypeEnum.SQLite)
                Me.lnkSqliteAdministrator.Visible = (oAdoHelper.DBMS = DatabaseTypeEnum.SQLite)
            End Using

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            System.Windows.Forms.Cursor.Current = Cursors.Default

        End Try

    End Sub

    Private Sub btnOK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub lnkTurtleGeek_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkTurtleGeek.LinkClicked
        NavigateToTurtleGeekWebsite()
    End Sub

    Private Sub lnkTurtleGeek_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkTurtleGeek.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                NavigateToTurtleGeekWebsite()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub NavigateToTurtleGeekWebsite()

        Try
            System.Diagnostics.Process.Start("http://www.TurtleGeek.com")

        Catch wex As System.ComponentModel.Win32Exception
            '----------------------------------------------------------------
            '-- if we get a Win32Exception (probably "Application Not Found"), 
            '-- try to get the location of the Internet Explorer application 
            '-- out of the Registry; if that value is bad, try a hardcoded path; 
            '-- if *that* is bad, show an error message box
            '----------------------------------------------------------------
            '-- the need for this actually occurred on a machine that had 
            '-- installed FireFox as a browser and then uninstalled it; 
            '-- the assocation for "http://www.???.com" still pointed 
            '-- to FireFox, which did not exist any longer
            '----------------------------------------------------------------
            Dim oRegistryKey As RegistryKey
            Dim sInternetExplorer As String

            oRegistryKey = Registry.LocalMachine
            Try
                oRegistryKey = oRegistryKey.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\IEXPLORE.EXE")
                sInternetExplorer = CType(oRegistryKey.GetValue(""), String)

                If Not (System.IO.File.Exists(sInternetExplorer)) Then
                    sInternetExplorer = "C:\Program Files\Internet Explorer\iexplore.exe"
                End If

                If (System.IO.File.Exists(sInternetExplorer)) Then
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    System.Diagnostics.Process.Start("""" & sInternetExplorer & """", "http://www.TurtleGeek.com")
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                Else
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                    ErrorMessageBox.Show(wex)
                End If

            Catch ex As Exception
                System.Windows.Forms.Cursor.Current = Cursors.Default
                ErrorMessageBox.Show(ex)
            Finally
                oRegistryKey.Close()
                oRegistryKey = Nothing
            End Try


        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = Cursors.Default
            ErrorMessageBox.Show(ex)

        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub picFwcLogo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picFwcLogo.Click
        GetOriginalForms()
    End Sub

    Private Sub lnkOriginalForms_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkOriginalForms.LinkClicked
        GetOriginalForms()
    End Sub

    Private Sub lnkOriginalForms_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkOriginalForms.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                GetOriginalForms()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub GetOriginalForms()

        Try
            System.Diagnostics.Process.Start("http://myfwc.com/wildlifehabitats/managed/sea-turtles/conservation-guidelines/")

        Catch wex As System.ComponentModel.Win32Exception
            '----------------------------------------------------------------
            '-- if we get a Win32Exception (probably "Application Not Found"), 
            '-- try to get the location of the Internet Explorer application 
            '-- out of the Registry; if that value is bad, try a hardcoded path; 
            '-- if *that* is bad, show an error message box
            '----------------------------------------------------------------
            '-- the need for this actually occurred on a machine that had 
            '-- installed FireFox as a browser and then uninstalled it; 
            '-- the assocation for "http://www.???.com" still pointed 
            '-- to FireFox, which did not exist any longer
            '----------------------------------------------------------------
            Dim oRegistryKey As RegistryKey
            Dim sInternetExplorer As String

            oRegistryKey = Registry.LocalMachine
            Try
                oRegistryKey = oRegistryKey.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\IEXPLORE.EXE")
                sInternetExplorer = CType(oRegistryKey.GetValue(""), String)

                If Not (System.IO.File.Exists(sInternetExplorer)) Then
                    sInternetExplorer = "C:\Program Files\Internet Explorer\iexplore.exe"
                End If

                If (System.IO.File.Exists(sInternetExplorer)) Then
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    System.Diagnostics.Process.Start("""" & sInternetExplorer & """", "http://www.floridaconservation.org/seaturtle/Guidelines/MarineTurtleGuidelines.htm")
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                Else
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                    ErrorMessageBox.Show(wex)
                End If

            Catch ex As Exception
                System.Windows.Forms.Cursor.Current = Cursors.Default
                ErrorMessageBox.Show(ex)
            Finally
                oRegistryKey.Close()
                oRegistryKey = Nothing
            End Try


        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = Cursors.Default
            ErrorMessageBox.Show(ex)

        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub picGetAdobeReader_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picGetAdobeReader.Click
        GetAdobeReader()
    End Sub

    Private Sub lnkAdobeReader_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkAdobeReader.LinkClicked
        GetAdobeReader()
    End Sub

    Private Sub lnkAdobeReader_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkAdobeReader.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                GetAdobeReader()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub GetAdobeReader()

        Try
            System.Diagnostics.Process.Start("https://get.adobe.com/reader/")

        Catch wex As System.ComponentModel.Win32Exception
            '----------------------------------------------------------------
            '-- if we get a Win32Exception (probably "Application Not Found"), 
            '-- try to get the location of the Internet Explorer application 
            '-- out of the Registry; if that value is bad, try a hardcoded path; 
            '-- if *that* is bad, show an error message box
            '----------------------------------------------------------------
            '-- the need for this actually occurred on a machine that had 
            '-- installed FireFox as a browser and then uninstalled it; 
            '-- the assocation for "http://www.???.com" still pointed 
            '-- to FireFox, which did not exist any longer
            '----------------------------------------------------------------
            Dim oRegistryKey As RegistryKey
            Dim sInternetExplorer As String

            oRegistryKey = Registry.LocalMachine
            Try
                oRegistryKey = oRegistryKey.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\IEXPLORE.EXE")
                sInternetExplorer = CType(oRegistryKey.GetValue(""), String)

                If Not (System.IO.File.Exists(sInternetExplorer)) Then
                    sInternetExplorer = "C:\Program Files\Internet Explorer\iexplore.exe"
                End If

                If (System.IO.File.Exists(sInternetExplorer)) Then
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    System.Diagnostics.Process.Start("""" & sInternetExplorer & """", "http://www.adobe.com/products/acrobat/readstep2.html")
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                Else
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                    ErrorMessageBox.Show(wex)
                End If

            Catch ex As Exception
                System.Windows.Forms.Cursor.Current = Cursors.Default
                ErrorMessageBox.Show(ex)
            Finally
                oRegistryKey.Close()
                oRegistryKey = Nothing
            End Try


        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = Cursors.Default
            ErrorMessageBox.Show(ex)

        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub picGetSqliteAdministrator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles picGetSqliteAdministrator.Click
        GetSqliteAdministrator()
    End Sub

    Private Sub lnkSqliteAdministrator_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkSqliteAdministrator.LinkClicked
        GetSqliteAdministrator()
    End Sub

    Private Sub lnkSqliteAdministrator_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkSqliteAdministrator.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                GetSqliteAdministrator()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub GetSqliteAdministrator()

        Try
            System.Diagnostics.Process.Start("http://sqliteadmin.orbmu2k.de/")

        Catch wex As System.ComponentModel.Win32Exception
            '----------------------------------------------------------------
            '-- if we get a Win32Exception (probably "Application Not Found"), 
            '-- try to get the location of the Internet Explorer application 
            '-- out of the Registry; if that value is bad, try a hardcoded path; 
            '-- if *that* is bad, show an error message box
            '----------------------------------------------------------------
            '-- the need for this actually occurred on a machine that had 
            '-- installed FireFox as a browser and then uninstalled it; 
            '-- the assocation for "http://www.???.com" still pointed 
            '-- to FireFox, which did not exist any longer
            '----------------------------------------------------------------
            Dim oRegistryKey As RegistryKey
            Dim sInternetExplorer As String

            oRegistryKey = Registry.LocalMachine
            Try
                oRegistryKey = oRegistryKey.CreateSubKey("SOFTWARE\Microsoft\Windows\CurrentVersion\App Paths\IEXPLORE.EXE")
                sInternetExplorer = CType(oRegistryKey.GetValue(""), String)

                If Not (System.IO.File.Exists(sInternetExplorer)) Then
                    sInternetExplorer = "C:\Program Files\Internet Explorer\iexplore.exe"
                End If

                If (System.IO.File.Exists(sInternetExplorer)) Then
                    System.Windows.Forms.Cursor.Current = Cursors.WaitCursor
                    System.Diagnostics.Process.Start("""" & sInternetExplorer & """", "http://sqliteadmin.orbmu2k.de/")
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                Else
                    System.Windows.Forms.Cursor.Current = Cursors.Default
                    ErrorMessageBox.Show(wex)
                End If

            Catch ex As Exception
                System.Windows.Forms.Cursor.Current = Cursors.Default
                ErrorMessageBox.Show(ex)
            Finally
                oRegistryKey.Close()
                oRegistryKey = Nothing
            End Try


        Catch ex As Exception
            System.Windows.Forms.Cursor.Current = Cursors.Default
            ErrorMessageBox.Show(ex)

        Finally
            System.Windows.Forms.Cursor.Current = Cursors.Default
        End Try

    End Sub

    Private Sub lnkEndUserLicenseAgreement_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles lnkEndUserLicenseAgreement.LinkClicked
        ShowEulaDialogBox()
    End Sub

    Private Sub lnkEndUserLicenseAgreement_PreviewKeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PreviewKeyDownEventArgs) Handles lnkEndUserLicenseAgreement.PreviewKeyDown

        Try

            If (e.KeyCode = Keys.Space) Then
                ShowEulaDialogBox()
            End If

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

        End Try

    End Sub

    Private Sub ShowEulaDialogBox()

        Dim frm As EulaDlg

        Try

            frm = New EulaDlg
            frm.ShowDialog(Me)

        Catch ex As Exception

            ErrorMessageBox.Show(ex)

        Finally

            frm = Nothing

        End Try

    End Sub

End Class
