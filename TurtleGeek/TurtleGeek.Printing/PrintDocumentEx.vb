Option Strict On
Option Explicit On

Public Class PrintDocumentEx
    Inherits System.Drawing.Printing.PrintDocument

#Region " Enumerations "

    Public Enum AlignmentType
        Left = 0
        Center = 1
        Right = 2
    End Enum

    Public Enum PrintItemContentType
        Text = 0
        Image = 1
    End Enum

    Public Enum WriteActionType
        Write = 0
        WriteLine = 1
    End Enum

#End Region

#Region " Private Classes "

    Private Class PrintItem

        Private meContentType As PrintItemContentType = PrintItemContentType.Text
        Private meWriteAction As WriteActionType
        Private msTextString As String
        Private moImageObject As Image
        Private moFont As System.Drawing.Font
        Private meAlignment As AlignmentType
        Private mbHasBorder As Boolean
        Private mfXPos As Single = 0
        Private mfYPos As Single = 0
        Private mfImageHeight As Single = 0
        Private mfImageWidth As Single = 0

        Public Property ContentType() As PrintItemContentType
            Get
                Return meContentType
            End Get
            Set(ByVal value As PrintItemContentType)
                meContentType = value
            End Set
        End Property

        Public Property WriteAction() As WriteActionType
            Get
                Return meWriteAction
            End Get
            Set(ByVal value As WriteActionType)
                meWriteAction = value
            End Set
        End Property

        Public Property TextString() As String
            Get
                Return msTextString
            End Get
            Set(ByVal value As String)
                msTextString = value
            End Set
        End Property

        Public Property ImageObject() As Image
            Get
                Return moImageObject
            End Get
            Set(ByVal value As Image)
                moImageObject = value
            End Set
        End Property

        Public Property Font() As System.Drawing.Font
            Get
                Return moFont
            End Get
            Set(ByVal value As System.Drawing.Font)
                moFont = value
            End Set
        End Property

        Public Property Alignment() As AlignmentType
            Get
                Return meAlignment
            End Get
            Set(ByVal value As AlignmentType)
                meAlignment = value
            End Set
        End Property

        Public ReadOnly Property StringAlignment() As StringAlignment
            Get
                Select Case meAlignment
                    Case AlignmentType.Right
                        Return Drawing.StringAlignment.Far
                    Case AlignmentType.Center
                        Return Drawing.StringAlignment.Center
                    Case Else 'AlignmentType.Left
                        Return Drawing.StringAlignment.Near
                End Select
            End Get
        End Property

        Public Property HasBorder() As Boolean
            Get
                Return mbHasBorder
            End Get
            Set(ByVal value As Boolean)
                mbHasBorder = value
            End Set
        End Property

        Public Property XPos() As Single
            Get
                Return mfXPos
            End Get
            Set(ByVal value As Single)
                mfXPos = value
            End Set
        End Property

        Public Property YPos() As Single
            Get
                Return mfYPos
            End Get
            Set(ByVal value As Single)
                mfYPos = value
            End Set
        End Property

        Public Property ImageHeight() As Single
            Get
                Return mfImageHeight
            End Get
            Set(ByVal value As Single)
                mfImageHeight = value
            End Set
        End Property

        Public Property ImageWidth() As Single
            Get
                Return mfImageWidth
            End Get
            Set(ByVal value As Single)
                mfImageWidth = value
            End Set
        End Property

    End Class

    Private Class PrintItems
        Inherits CollectionBase

        Friend Sub Add(ByVal oPrintItem As PrintItem)
            List.Add(oPrintItem)
        End Sub

        Friend Sub Remove(ByVal oPrintItem As PrintItem)
            List.Remove(oPrintItem)
        End Sub

        Default Friend ReadOnly Property Item(ByVal iIndex As Integer) As PrintItem
            Get
                Return CType(List.Item(iIndex), PrintItem)
            End Get
        End Property

    End Class

#End Region

#Region " Member Variables "

    Private Const NEW_PAGE_DIRECTIVE As String = "{{NEW_PAGE}}"

    Private moPrintItems As PrintItems
    Private moFont As System.Drawing.Font
    Private miCopies As Short
    Private miPageCount As Integer
    Private miCurrentPrintItemIndex As Integer
    Private mbIsPreview As Boolean
    Private moPageColor As Color = Color.White

    Public Property IsPreview() As Boolean
        Get
            Return mbIsPreview
        End Get
        Set(ByVal value As Boolean)
            mbIsPreview = value
        End Set
    End Property

    Public Property PageColor() As Color
        Get
            Return moPageColor
        End Get
        Set(ByVal value As Color)
            moPageColor = value
        End Set
    End Property

#End Region

#Region " Constructors "

    Public Sub New()

        '----------------------------------------------------------------
        '-- default constructor
        '----------------------------------------------------------------
        Call Me.New(1)

    End Sub

    Public Sub New(ByVal iCopies As Short)

        '----------------------------------------------------------------
        '-- call base class constructor
        '----------------------------------------------------------------
        MyBase.New()

        '----------------------------------------------------------------
        '-- apparently there is no page counter, so keep track of our own...
        '----------------------------------------------------------------
        miPageCount = 0

        '----------------------------------------------------------------
        '-- initialize the collection that holds the print item objects
        '----------------------------------------------------------------
        moPrintItems = New PrintItems()

        '----------------------------------------------------------------
        '-- set the number of copies to print
        '----------------------------------------------------------------
        Copies = iCopies
        Me.PrinterSettings.Copies = Copies

        '----------------------------------------------------------------
        '-- set the default font
        '----------------------------------------------------------------
        moFont = New Font("Arial", 10, FontStyle.Regular)

    End Sub

#End Region

#Region " Properties "

    Public Property Copies() As Short
        Get
            Return miCopies
        End Get
        Set(ByVal value As Short)
            If (value <= 0) Then
                miCopies = 1
            Else
                miCopies = value
            End If
        End Set
    End Property

    Public ReadOnly Property PageCount() As Integer
        Get
            Return miPageCount
        End Get
    End Property

#End Region

#Region " Methods "

    Public Sub Write(ByVal sTextString As String, Optional ByVal sFontFamily As String = "", Optional ByVal fFontSize As Single = 0, Optional ByVal bBold As Boolean = False, Optional ByVal bUnderline As Boolean = False, Optional ByVal bItalic As Boolean = False, Optional ByVal fXPos As Single = 0)

        Call AddPrintItemText(WriteActionType.Write, sTextString, sFontFamily, fFontSize, bBold, bUnderline, bItalic, AlignmentType.Left, False, fXPos)

    End Sub

    Public Sub Write(ByVal sTextString As String, ByVal oFont As Font, Optional ByVal fXPos As Single = 0)

        Call AddPrintItemText(WriteActionType.Write, sTextString, oFont, AlignmentType.Left, False, fXPos)

    End Sub

    Public Sub WriteLine(ByVal sTextString As String, Optional ByVal sFontFamily As String = "", Optional ByVal fFontSize As Single = 0, Optional ByVal bBold As Boolean = False, Optional ByVal bUnderline As Boolean = False, Optional ByVal bItalic As Boolean = False, Optional ByVal eAlignment As AlignmentType = AlignmentType.Left, Optional ByVal bHasBorder As Boolean = False, Optional ByVal fXPos As Single = 0)

        Call AddPrintItemText(WriteActionType.WriteLine, sTextString, sFontFamily, fFontSize, bBold, bUnderline, bItalic, eAlignment, bHasBorder, fXPos)

    End Sub

    Public Sub WriteLine(ByVal sTextString As String, ByVal oFont As Font, Optional ByVal eAlignment As AlignmentType = AlignmentType.Left, Optional ByVal bHasBorder As Boolean = False, Optional ByVal fXPos As Single = 0)

        Call AddPrintItemText(WriteActionType.WriteLine, sTextString, oFont, eAlignment, bHasBorder, fXPos)

    End Sub

    Public Sub NewPage()

        Call WriteLine(NEW_PAGE_DIRECTIVE)

    End Sub

    Private Sub AddPrintItemText(ByVal eWriteActionType As WriteActionType, ByVal sTextString As String, Optional ByVal sFontFamily As String = "", Optional ByVal fFontSize As Single = 0, Optional ByVal bBold As Boolean = False, Optional ByVal bUnderline As Boolean = False, Optional ByVal bItalic As Boolean = False, Optional ByVal eAlignment As AlignmentType = AlignmentType.Left, Optional ByVal bHasBorder As Boolean = False, Optional ByVal fXPos As Single = 0)

        Static sCurrentFontFamily As String
        Static fCurrentFontSize As Single
        Dim oFont As System.Drawing.Font
        Dim oFontStyle As New System.Drawing.FontStyle()

        'moFont = New Font("Arial", 10, FontStyle.Regular)

        If bBold Then
            oFontStyle = oFontStyle Or FontStyle.Bold
        End If

        If bUnderline Then
            oFontStyle = oFontStyle Or FontStyle.Underline
        End If

        If bItalic Then
            oFontStyle = oFontStyle Or FontStyle.Italic
        End If

        If String.IsNullOrEmpty(sFontFamily) Then
            If Not String.IsNullOrEmpty(sCurrentFontFamily) Then
                sFontFamily = sCurrentFontFamily
            Else
                sFontFamily = "Arial"
            End If
        End If

        sCurrentFontFamily = sFontFamily

        If (fFontSize = 0) Then
            If (fCurrentFontSize <> 0) Then
                fFontSize = fCurrentFontSize
            Else
                fFontSize = 10
            End If
        End If

        fCurrentFontSize = fFontSize

        oFont = New Font(sFontFamily, fFontSize, oFontStyle)

        Call AddPrintItemText(eWriteActionType, sTextString, oFont, eAlignment, bHasBorder, fXPos)

    End Sub

    Private Sub AddPrintItemText(ByVal eWriteActionType As WriteActionType, ByVal sTextString As String, ByVal oFont As Font, Optional ByVal eAlignment As AlignmentType = AlignmentType.Left, Optional ByVal bHasBorder As Boolean = False, Optional ByVal fXPos As Single = 0)

        Dim oPrintItem As PrintItem

        oPrintItem = New PrintItem()

        oPrintItem.ContentType = PrintItemContentType.Text
        oPrintItem.WriteAction = eWriteActionType
        oPrintItem.TextString = sTextString
        oPrintItem.Font = oFont
        oPrintItem.Alignment = eAlignment
        oPrintItem.HasBorder = bHasBorder
        oPrintItem.XPos = fXPos

        moPrintItems.Add(oPrintItem)

        oPrintItem = Nothing

    End Sub

    Public Sub WriteImage(ByVal oImageObject As Image, Optional ByVal bHasBorder As Boolean = False, Optional ByVal fXPos As Single = 0, Optional ByVal fYPos As Single = -1, Optional ByVal fImageHeight As Single = -1, Optional ByVal fImageWidth As Single = 0)

        Call AddPrintItemImage(WriteActionType.Write, oImageObject, bHasBorder, fXPos, fYPos, fImageHeight, fImageWidth)

    End Sub

    Private Sub AddPrintItemImage(ByVal eWriteActionType As WriteActionType, ByVal oImageObject As Image, Optional ByVal bHasBorder As Boolean = False, Optional ByVal fXPos As Single = -1, Optional ByVal fYPos As Single = -1, Optional ByVal fImageHeight As Single = 0, Optional ByVal fImageWidth As Single = 0)

        Dim oPrintItem As PrintItem

        oPrintItem = New PrintItem()

        oPrintItem.ContentType = PrintItemContentType.Image
        oPrintItem.WriteAction = eWriteActionType
        oPrintItem.ImageObject = oImageObject
        'oPrintItem.TextString = sTextString
        'oPrintItem.Font = oFont
        'oPrintItem.Alignment = eAlignment
        oPrintItem.HasBorder = bHasBorder
        oPrintItem.XPos = fXPos
        oPrintItem.YPos = fYPos
        oPrintItem.ImageHeight = fImageHeight
        oPrintItem.ImageWidth = fImageWidth

        moPrintItems.Add(oPrintItem)

        oPrintItem = Nothing

    End Sub

    ''' <summary>
    ''' Displays the rendered print document in a print preview window.
    ''' </summary>
    ''' <param name="frmParentForm">The top-level window that will own the modal dialog.</param>
    ''' <remarks></remarks>
    Public Sub Preview(ByVal frmParentForm As Form)

        Dim frm As PrintPreviewDlg

        frm = New PrintPreviewDlg(Me)
        frm.ShowDialog(frmParentForm)
        frm = Nothing

    End Sub

    Protected Overrides Sub OnBeginPrint(ByVal e As System.Drawing.Printing.PrintEventArgs)

        '----------------------------------------------------------------
        '-- call base class method
        '----------------------------------------------------------------
        MyBase.OnBeginPrint(e)

        '----------------------------------------------------------------
        '-- reset internal page counter
        '----------------------------------------------------------------
        miPageCount = 0

        '----------------------------------------------------------------
        '-- keep track of which Print Item we are rendering...
        '----------------------------------------------------------------
        miCurrentPrintItemIndex = 0

    End Sub

    Protected Overrides Sub OnPrintPage(ByVal e As System.Drawing.Printing.PrintPageEventArgs)

        '----------------------------------------------------------------
        '-- call base class method
        '----------------------------------------------------------------
        MyBase.OnPrintPage(e)

        '----------------------------------------------------------------
        '-- local class-specific logic...
        '----------------------------------------------------------------
        Dim bWriteThisLine As Boolean

        Dim i As Integer
        Dim fLastX As Single
        Dim fLastY As Single
        Dim fNextY As Single
        Dim fItemHeight As Single
        Dim fTempX As Single
        Dim fTempY As Single
        Dim fTempHeight As Single
        Dim fTempWidth As Single
        Dim oPrintItem As PrintItem

        Dim oLayoutRectangleF As RectangleF
        Dim oTextSizeF As SizeF
        Dim iCharactersFitted As Integer
        Dim iLinesFilled As Integer
        Dim oStringFormat As New StringFormat

        '----------------------------------------------------------------
        '-- increment the page count
        '----------------------------------------------------------------
        miPageCount = miPageCount + 1

        '----------------------------------------------------------------
        '-- set the backcolor of the page
        '----------------------------------------------------------------
        e.Graphics.FillRectangle(New System.Drawing.SolidBrush(Me.PageColor), e.PageBounds)

        '----------------------------------------------------------------
        '-- initializations for the starting of a page
        '----------------------------------------------------------------
        fLastY = e.MarginBounds.Top
        fLastX = e.MarginBounds.Left

        '----------------------------------------------------------------
        '-- for each "print item" that we have collected...
        '----------------------------------------------------------------
        For i = miCurrentPrintItemIndex To (moPrintItems.Count - 1)

            oPrintItem = CType(moPrintItems(i), PrintItem)

            If (oPrintItem.ContentType = PrintItemContentType.Image) Then

                If (oPrintItem.XPos = -1) OrElse (oPrintItem.YPos = -1) Then
                    '----------------------------------------------------------------
                    '-- XPos or YPos of -1 means RELATIVE
                    '----------------------------------------------------------------
                    If (oPrintItem.XPos > 0) Then
                        fLastX = oPrintItem.XPos
                    End If

                    fTempX = fLastX
                    fTempY = fLastY

                    fLastX += oPrintItem.ImageWidth
                    fLastY += oPrintItem.ImageHeight

                Else
                    '----------------------------------------------------------------
                    '-- XPos or YPos of > -1 means ABSOLUTE
                    '----------------------------------------------------------------
                    If (oPrintItem.XPos < 0) Then
                        fTempX = 0 + e.MarginBounds.Left
                    Else
                        fTempX = oPrintItem.XPos + e.MarginBounds.Left
                    End If

                    If (oPrintItem.YPos < 0) Then
                        fTempY = 0 + e.MarginBounds.Top
                    Else
                        fTempY = oPrintItem.YPos + e.MarginBounds.Top
                    End If

                End If

                If (oPrintItem.ImageHeight < 0) Then
                    fTempHeight = 0
                Else
                    fTempHeight = oPrintItem.ImageHeight
                End If

                If (oPrintItem.ImageWidth < 0) Then
                    fTempWidth = 0
                Else
                    fTempWidth = oPrintItem.ImageWidth
                End If

                '----------------------------------------------------------------
                '-- render the IMAGE here
                '----------------------------------------------------------------
                If (oPrintItem.ImageObject IsNot Nothing) Then
                    e.Graphics.DrawImage(oPrintItem.ImageObject, fTempX, fTempY, fTempHeight, fTempWidth)
                End If

                '----------------------------------------------------------------
                '-- draw an image border, if requested
                '----------------------------------------------------------------
                If oPrintItem.HasBorder Then
                    e.Graphics.DrawRectangle(Pens.Black, fTempX, fTempY, fTempWidth, fTempHeight)
                End If

            Else 'If (oPrintItem.ContentType = PrintItemContentType.Text) Then

                '----------------------------------------------------------------
                '-- we must have at least a space for text rendering height calculations to work
                '----------------------------------------------------------------
                oPrintItem.TextString = Convert.ToString(IIf(String.IsNullOrEmpty(oPrintItem.TextString), " ", oPrintItem.TextString))

                '----------------------------------------------------------------
                '-- if we encounter a NEW PAGE directive, break and print another page
                '----------------------------------------------------------------
                If (oPrintItem.TextString = NEW_PAGE_DIRECTIVE) Then
                    miCurrentPrintItemIndex = i + 1
                    e.HasMorePages = True
                    Exit Sub
                End If

                '----------------------------------------------------------------
                '-- set the string alignment, wrap at words, and do not draw partial lines
                '----------------------------------------------------------------
                oStringFormat.Alignment = oPrintItem.StringAlignment
                oStringFormat.FormatFlags = StringFormatFlags.LineLimit
                oStringFormat.Trimming = StringTrimming.Word

                '----------------------------------------------------------------
                '-- set the starting x position
                '----------------------------------------------------------------
                If (oPrintItem.XPos > 0) Then
                    fLastX = oPrintItem.XPos
                End If

                '----------------------------------------------------------------
                '-- get the remaining rendering area available on the page
                '----------------------------------------------------------------
                oLayoutRectangleF = New RectangleF(fLastX, fLastY, e.MarginBounds.Width, e.MarginBounds.Bottom - fLastY)

                If (oLayoutRectangleF.Height < 1) Then
                    oLayoutRectangleF.Height = 1
                End If

                '----------------------------------------------------------------
                '-- get the size of the text block and see how many characters will fit
                '----------------------------------------------------------------
                oTextSizeF = e.Graphics.MeasureString(oPrintItem.TextString, oPrintItem.Font, New SizeF(oLayoutRectangleF.Width, oLayoutRectangleF.Height), oStringFormat, iCharactersFitted, iLinesFilled)

                If mbIsPreview Then
                    fItemHeight = Convert.ToSingle(oTextSizeF.Height + (e.Graphics.MeasureString("M", oPrintItem.Font).Height * 0.1))
                    bWriteThisLine = (iCharactersFitted > 0)
                Else
                    '----------------------------------------------------------------
                    '-- *** KLUDGE EXTRAORDINAIRE ***
                    '----------------------------------------------------------------
                    '-- if we are PRINTING (not previewing), 
                    '-- then increase the text size height by a fudge factor of x%
                    '----------------------------------------------------------------
                    fItemHeight = Convert.ToSingle((oTextSizeF.Height * 1.033) + (e.Graphics.MeasureString("M", oPrintItem.Font).Height * 0.1))
                    fNextY = fLastY + fItemHeight
                    bWriteThisLine = (fNextY < e.MarginBounds.Bottom)
                End If

                '----------------------------------------------------------------
                '-- if at least one text block character fit into the rendering area...
                '----------------------------------------------------------------
                If bWriteThisLine Then

                    '----------------------------------------------------------------
                    '-- WRITE the text block for THIS ITEM
                    '----------------------------------------------------------------
                    e.Graphics.DrawString(oPrintItem.TextString, oPrintItem.Font, Brushes.Black, oLayoutRectangleF, oStringFormat)

                    '----------------------------------------------------------------
                    '-- draw a border rectangle, if requested (for WriteLine only)
                    '----------------------------------------------------------------
                    If oPrintItem.HasBorder Then
                        e.Graphics.DrawRectangle(Pens.Black, oLayoutRectangleF.Left, oLayoutRectangleF.Top, (oLayoutRectangleF.Right - oLayoutRectangleF.Left), oTextSizeF.Height)
                    End If

                    '----------------------------------------------------------------
                    '-- set the NEXT (x, y) starting position
                    '----------------------------------------------------------------
                    If (oPrintItem.WriteAction = WriteActionType.WriteLine) Then

                        '----------------------------------------------------------------
                        '-- for a COMPLETE line...
                        '----------------------------------------------------------------

                        '----------------------------------------------------------------
                        '-- increase the location down the page where we can start; add a little interparagraph spacing.
                        '----------------------------------------------------------------
                        fLastY += fItemHeight

                        '----------------------------------------------------------------
                        '-- move the start of the line all the way back over
                        '----------------------------------------------------------------
                        fLastX = e.MarginBounds.Left

                    Else 'If (oPrintItem.WriteAction = WriteActionType.Write) Then

                        '----------------------------------------------------------------
                        '-- for a PARTIAL line...
                        '----------------------------------------------------------------

                        '----------------------------------------------------------------
                        '-- stay on the same line (do not move down the page)
                        '----------------------------------------------------------------
                        ''fLastY = fLastY

                        '----------------------------------------------------------------
                        '-- move the start of the next text block to the end of this text block
                        '----------------------------------------------------------------
                        fLastX += oTextSizeF.Width

                    End If

                End If

                '----------------------------------------------------------------
                '-- if PREVIEWING on screen...
                '----------------------------------------------------------------
                If mbIsPreview Then

                    '----------------------------------------------------------------
                    '-- if some of the paragraph did not fit on the page...
                    '----------------------------------------------------------------
                    If (iCharactersFitted < oPrintItem.TextString.Length) Then

                        '----------------------------------------------------------------
                        '-- print the remainder of the text block on the next page
                        '----------------------------------------------------------------
                        miCurrentPrintItemIndex = i
                        moPrintItems(miCurrentPrintItemIndex).TextString = oPrintItem.TextString.Substring(iCharactersFitted)
                        e.HasMorePages = True
                        Exit Sub

                    End If

                Else
                    '----------------------------------------------------------------
                    '-- else PRINTING to printer...
                    '----------------------------------------------------------------

                    '----------------------------------------------------------------
                    '-- if we have passed the end of the page...
                    '----------------------------------------------------------------
                    If (fNextY >= e.MarginBounds.Bottom) Then

                        '----------------------------------------------------------------
                        '-- we need this block when PRINTING (not previewing); 
                        '-- it seems to treat the device context as a running canvas
                        '-- where the characters always fit...???
                        '----------------------------------------------------------------
                        miCurrentPrintItemIndex = i
                        'moPrintItems(miCurrentPrintItemIndex).TextString = oPrintItem.TextString.Substring(iCharactersFitted)
                        e.HasMorePages = True
                        Exit Sub

                    End If

                End If

            End If

        Next

    End Sub

#End Region

End Class
