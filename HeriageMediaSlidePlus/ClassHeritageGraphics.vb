
Imports System
Imports System.Collections.Generic
Imports System.Drawing
Imports System.Drawing.Drawing2D
Imports System.Drawing.Imaging
Imports System.Linq
Imports System.Text
Imports System.Threading.Tasks

Public Class ClassHeritageGraphics
    '    1,920 x 1,080 pixels
    'HD: 720p image resolution (1,280 x 720 pixels – approximately 1 million total pixels) 
    'Full HD: 1080p image resolution (1,920 x 1,080 pixels – approximately 2 million total pixels) 
    'Ultra HD: 4K image resolution (3,840 x 2,160 pixels – approximately 8 million total pixels)

    '' ''Public Function CreateWatermark_Original(ByVal imgPhoto As System.Drawing.Image, ByVal Copyright As String) As System.Drawing.Image
    '' ''    Dim g As Graphics = Graphics.FromImage(imgPhoto)
    '' ''    g.SmoothingMode = SmoothingMode.HighQuality
    '' ''    g.InterpolationMode = InterpolationMode.HighQualityBicubic
    '' ''    g.PixelOffsetMode = PixelOffsetMode.HighQuality

    '' ''    For Each pItem As PropertyItem In imgPhoto.PropertyItems
    '' ''        imgPhoto.SetPropertyItem(pItem)
    '' ''    Next

    '' ''    Dim phWidth As Integer = imgPhoto.Width
    '' ''    Dim phHeight As Integer = imgPhoto.Height

    '' ''    Dim bmPhoto As Bitmap = New Bitmap(phWidth, phHeight, PixelFormat.Format24bppRgb)
    '' ''    bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution)

    '' ''    Dim grPhoto As Graphics = Graphics.FromImage(bmPhoto)
    '' ''    grPhoto.SmoothingMode = SmoothingMode.AntiAlias
    '' ''    grPhoto.DrawImage(imgPhoto, New Rectangle(0, 0, phWidth, phHeight), 0, 0, phWidth, phHeight, GraphicsUnit.Pixel)
    '' ''    Dim sizes As Integer() = New Integer() {72, 42, 36, 32, 24, 18, 16}
    '' ''    Dim crFont As Font = Nothing
    '' ''    Dim crSize As SizeF = New SizeF()

    '' ''    For i As Integer = 0 To 7 - 1
    '' ''        crFont = New Font("arial", sizes(i), FontStyle.Bold)
    '' ''        crSize = grPhoto.MeasureString(Copyright, crFont)
    '' ''        If CUShort(crSize.Width) < CUShort(phWidth) Then Exit For
    '' ''    Next

    '' ''    'crFont = New Font("arial", sizes(0), FontStyle.Bold)
    '' ''    'crSize = grPhoto.MeasureString(Copyright, crFont)

    '' ''    Dim yPixlesFromBottom As Integer = CInt((phHeight * 0.95))
    '' ''    Dim yPosFromBottom As Single = ((phHeight - yPixlesFromBottom) - (crSize.Height / 2))
    '' ''    Dim xCenterOfImg As Single = (phWidth / 2)
    '' ''    Dim StrFormat As StringFormat = New StringFormat()
    '' ''    StrFormat.Alignment = StringAlignment.Near
    '' ''    Dim semiTransBrush2 As SolidBrush = New SolidBrush(System.Drawing.Color.FromArgb(255, 0, 0, 0))
    '' ''    grPhoto.DrawString(Copyright, crFont, semiTransBrush2, New PointF(xCenterOfImg + 1, yPosFromBottom + 1), StrFormat)
    '' ''    Dim semiTransBrush As SolidBrush = New SolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255))
    '' ''    grPhoto.DrawString(Copyright, crFont, semiTransBrush, New PointF(xCenterOfImg, yPosFromBottom), StrFormat)
    '' ''    imgPhoto = bmPhoto
    '' ''    Return imgPhoto
    '' ''End Function


    '' ''Public Function CreateWatermark(ByVal imgPhoto As System.Drawing.Image, ByVal Copyright As String, Optional crfont As Font = Nothing, Optional semiTBrushFore As SolidBrush = Nothing, Optional semiTBrushBack As SolidBrush = Nothing) As System.Drawing.Image
    '' ''    Dim g As Graphics = Graphics.FromImage(imgPhoto)
    '' ''    g.SmoothingMode = SmoothingMode.HighQuality
    '' ''    g.InterpolationMode = InterpolationMode.HighQualityBicubic
    '' ''    g.PixelOffsetMode = PixelOffsetMode.HighQuality

    '' ''    'get parameters
    '' ''    If crfont Is Nothing Then crfont = New Font("arial", 180, FontStyle.Bold)
    '' ''    If semiTBrushBack Is Nothing Then semiTBrushBack = New SolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 255))
    '' ''    If semiTBrushFore Is Nothing Then semiTBrushFore = New SolidBrush(System.Drawing.Color.FromArgb(255, 255, 255, 0))

    '' ''    For Each pItem As PropertyItem In imgPhoto.PropertyItems
    '' ''        imgPhoto.SetPropertyItem(pItem)
    '' ''    Next

    '' ''    Dim phWidth As Integer = imgPhoto.Width
    '' ''    Dim phHeight As Integer = imgPhoto.Height
    '' ''    Dim bmPhoto As Bitmap = New Bitmap(phWidth, phHeight, imgPhoto.PixelFormat) ' PixelFormat.Format24bppRgb)
    '' ''    bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution)
    '' ''    Dim grPhoto As Graphics = Graphics.FromImage(bmPhoto)
    '' ''    grPhoto.SmoothingMode = SmoothingMode.AntiAlias
    '' ''    grPhoto.DrawImage(imgPhoto, New Rectangle(0, 0, phWidth, phHeight), 0, 0, phWidth, phHeight, GraphicsUnit.Pixel)
    '' ''    Dim sizes As Integer() = New Integer() {72, 42, 36, 32, 24, 18, 16}
    '' ''    'Dim crFont As Font = New Font("arial", 40, FontStyle.Bold)
    '' ''    Dim crSize As SizeF = New SizeF()


    '' ''    Dim StrFormat As StringFormat = New StringFormat()
    '' ''    StrFormat.Alignment = StringAlignment.Near

    '' ''    Dim rect2 As New Rectangle(150, 10, 130, 140)
    '' ''    Dim flags As TextFormatFlags = TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.WordBreak

    '' ''    rect2.X = grPhoto.VisibleClipBounds.X + 50
    '' ''    rect2.Y = grPhoto.VisibleClipBounds.Y + 50
    '' ''    rect2.Width = grPhoto.VisibleClipBounds.Width - 100
    '' ''    rect2.Height = grPhoto.VisibleClipBounds.Height - 100

    '' ''    TextRenderer.DrawText(grPhoto, Copyright, crfont, rect2, semiTBrushBack.Color, flags) 'shadow
    '' ''    rect2.X = rect2.X - 2
    '' ''    rect2.Y = rect2.Y - 2
    '' ''    rect2.Width = grPhoto.VisibleClipBounds.Width - 100
    '' ''    rect2.Height = grPhoto.VisibleClipBounds.Height - 100
    '' ''    'grPhoto.DrawString(Copyright, crFont, semiTransBrush2, New PointF(xCenterOfImg + 1, yPosFromBottom + 1), StrFormat)

    '' ''    ' grPhoto.DrawString(Copyright, crFont, semiTransBrush, New PointF(xCenterOfImg, yPosFromBottom), StrFormat)
    '' ''    TextRenderer.DrawText(grPhoto, Copyright, crfont, rect2, semiTBrushFore.Color, flags) 'shadow

    '' ''    imgPhoto = bmPhoto
    '' ''    Return imgPhoto
    '' ''    g = Nothing
    '' ''    semiTBrushBack = Nothing
    '' ''    semiTBrushFore = Nothing
    '' ''    crfont = Nothing
    '' ''    crSize = Nothing
    '' ''    rect2 = Nothing
    '' ''    grPhoto = Nothing

    '' ''End Function
    Public Function ThumbnailCallback() As Boolean
        Return True
    End Function
    Public Function GetThumbnail(e As PaintEventArgs, fn As String) As Image
        Try
            Dim callback As Image.GetThumbnailImageAbort = New Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
            Using img As Image = New Bitmap(fn)
                Dim thumbNail As Image = img.GetThumbnailImage(100, 100, callback, New IntPtr())
                e.Graphics.DrawImage(thumbNail, 1, 1, thumbNail.Width, thumbNail.Height)
            End Using
            Return Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Function
    Public Function ThumbnailImgFileCallback() As Boolean
        Return True
    End Function
    Public Function GetThumbnailFromImageFilename(fn As String) As Image
        Try
            Dim callback As Image.GetThumbnailImageAbort = New Image.GetThumbnailImageAbort(AddressOf ThumbnailImgFileCallback)
            Using img As Image = New Bitmap(fn)
                Dim thumbNail As Image = img.GetThumbnailImage(100, 100, callback, New IntPtr())

                Return thumbNail
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Public Function GetThumbnailFromImageFilenameWithDim(fn As String, width As Integer, height As Integer) As Image
        Try
            Dim callback As Image.GetThumbnailImageAbort = New Image.GetThumbnailImageAbort(AddressOf ThumbnailImgFileCallback)
            Using img As Image = New Bitmap(fn)
                Dim thumbNail As Image = img.GetThumbnailImage(width, height, callback, New IntPtr())

                Return thumbNail
            End Using
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    Public Function ThumbnailImgCallback() As Boolean
        Return True
    End Function
    Public Function GetThumbnailFromImage(img As Image) As Image
        Try
            Dim callback As Image.GetThumbnailImageAbort = New Image.GetThumbnailImageAbort(AddressOf ThumbnailImgCallback)
            Dim thumbNail As Image = img.GetThumbnailImage(100, 100, callback, New IntPtr())
            Return thumbNail
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function

    Public Function drawTextOnThumbNail(imageWidth As Integer, imageHeight As Integer, dScaleRealPerPreview As Double, Imagefn As String,
                                         text2 As String,
                                         Optional dfont As Font = Nothing,
                                         Optional shadowColor As Color = Nothing,
                                         Optional foreColor As Color = Nothing,
                                         Optional bibleRef As String = Nothing) As Image
        Try
            Dim callback As Image.GetThumbnailImageAbort = New Image.GetThumbnailImageAbort(AddressOf ThumbnailCallback)
            Dim imgPhoto As Image = New Bitmap(Imagefn)
            imgPhoto = imgPhoto.GetThumbnailImage(imageWidth, imageHeight, callback, New IntPtr())

            ''---Start WM
            Dim g As Graphics = Graphics.FromImage(imgPhoto)
            g.SmoothingMode = SmoothingMode.HighQuality
            g.InterpolationMode = InterpolationMode.HighQualityBicubic
            g.PixelOffsetMode = PixelOffsetMode.HighQuality

            For Each pItem As PropertyItem In imgPhoto.PropertyItems
                imgPhoto.SetPropertyItem(pItem)
            Next

            Dim phWidth As Integer = imgPhoto.Width
            Dim phHeight As Integer = imgPhoto.Height
            Dim bmPhoto As Bitmap = New Bitmap(phWidth, phHeight, imgPhoto.PixelFormat) ' PixelFormat.Format24bppRgb)
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution)

            Dim grPhoto As Graphics = Graphics.FromImage(bmPhoto)
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias
            grPhoto.DrawImage(imgPhoto, New Rectangle(0, 0, phWidth, phHeight), 0, 0, phWidth, phHeight, GraphicsUnit.Pixel)

            '---Stop WM merge



            Dim rect2 As New Rectangle(150, 10, 130, 140)
            rect2.X = g.VisibleClipBounds.X + 10 ' 50 'TODO: make margin variable
            rect2.Y = g.VisibleClipBounds.Y + 10 ' 50
            rect2.Width = g.VisibleClipBounds.Width - 50 '100
            rect2.Height = g.VisibleClipBounds.Height - 50 ' 100

            Dim flags As TextFormatFlags = TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.WordBreak

            Dim font2 As New Font("Arial", 50, FontStyle.Bold, GraphicsUnit.Point) 'default font
            If Not (dfont Is Nothing) Then font2 = dfont 'parameter font
            font2 = New Font(font2.FontFamily, CInt(font2.Size * dScaleRealPerPreview)) 'scale it
            If shadowColor = Nothing Then shadowColor = Color.Black
            If foreColor = Nothing Then foreColor = Color.Yellow

            'Draw the text and the surrounding rectangle.
            '############## Scale font  ################"


            'e.graphics.Clear(SystemColors.Black)
            TextRenderer.DrawText(g, text2, font2, rect2, shadowColor, flags) 'shadow
            rect2.X = rect2.X - 2
            rect2.Y = rect2.Y - 2
            rect2.Width = g.VisibleClipBounds.Width - 50 '100
            rect2.Height = g.VisibleClipBounds.Height - 50 '100
            TextRenderer.DrawText(g, text2, font2, rect2, foreColor, flags)

            'Optionally print bibleref
            If Not (bibleRef = Nothing) Then
                flags = TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.WordBreak
                font2 = New Font(font2.FontFamily, CSng(Math.Truncate(font2.Size * 0.8))) '80% size
                rect2.X = g.VisibleClipBounds.X + 25 '25 pixels from left
                rect2.Y = g.VisibleClipBounds.Height - 77  '77 pixels from buttom 77px=50points
                rect2.Width = rect2.Width   'shadow=+0, outline=-x
                rect2.Height = 77 '77 pixels


                'now draw text
                TextRenderer.DrawText(g, bibleRef, font2, rect2, foreColor, flags)


            End If


            font2 = Nothing
            rect2 = Nothing

            Return imgPhoto

            'return the thumnail
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Function

    ''' <summary>draws Text On Slidebackground Image and reurns d Image .</summary>
    ''' <param name="e">Object from a paint event </param>
    Public Function drawTextOnSlide(e As Object, text2 As String, Optional dfont As Font = Nothing,
                                    Optional shadowColor As Color = Nothing, Optional foreColor As Color = Nothing,
                                    Optional bibleRef As String = Nothing, Optional bkgrndColor As Color = Nothing,
                                    Optional makeTransparent As Boolean = False,
                                    Optional resW As Integer = 1366, Optional resH As Integer = 768) As Image
        ' Dim text2 As String = "Use TextFormatFlags and Rectangle objects to" & " center text in a rectangle."
        Try

            Dim font2 As New Font("Arial", 50, FontStyle.Bold, GraphicsUnit.Point)
            Dim rect2 As New Rectangle(150, 10, 130, 140)

            rect2.X = e.graphics.VisibleClipBounds.X + 3
            rect2.Y = e.graphics.VisibleClipBounds.y + 5
            rect2.Width = e.graphics.VisibleClipBounds.width - 6
            rect2.Height = e.graphics.VisibleClipBounds.height - 20
            ' Create a TextFormatFlags with word wrapping, horizontal center and
            ' vertical center specified.
            Dim flags As TextFormatFlags = TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.WordBreak

            If Not (dfont Is Nothing) Then font2 = dfont
            If shadowColor = Nothing Then shadowColor = Color.Black
            If foreColor = Nothing Then foreColor = Color.Yellow

            'Draw the text and the surrounding rectangle.
            'e.Graphics.SmoothingMode.HighQuality = True   'TODO: triggers error
            If makeTransparent = True Then e.graphics.Clear(Color.Transparent)
            If Not (bkgrndColor = Nothing) Then e.graphics.Clear(bkgrndColor)
            TextRenderer.DrawText(e.Graphics, text2, font2, rect2, shadowColor, flags) 'shadow
            rect2.X = rect2.X - 2
            rect2.Y = rect2.Y - 2
            rect2.Width = rect2.Width   'shadow=+0, outline=-x
            rect2.Height = rect2.Height

            TextRenderer.DrawText(e.Graphics, text2, font2, rect2, foreColor, flags)
            'e.Graphics.DrawRectangle(Pens.White, rect2)


            'Optionally print bibleref
            If Not (bibleRef = Nothing) Then
                flags = TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.WordBreak
                font2 = New Font(font2.FontFamily, CSng(Math.Truncate(font2.Size * 0.8))) '80% size
                rect2.X = e.graphics.VisibleClipBounds.x + 25 '25 pixels from left
                rect2.Y = e.graphics.VisibleClipBounds.height - 77  '77 pixels from buttom 77px=50points
                rect2.Width = rect2.Width   'shadow=+0, outline=-x
                rect2.Height = 77 '77 pixels
                TextRenderer.DrawText(e.Graphics, bibleRef, font2, rect2, foreColor, flags)
            End If


            font2 = Nothing
            rect2 = Nothing

            'return the thumnail and save it


            'Using grPhoto As Graphics = Graphics.FromImage(bmPhoto)
            'Using grPhoto As Graphics = e.graphics.clone

            'End Using
            Return Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function



    ''' <summary>draws Text On Slidebackground Image and reurns d Image .</summary>
    ''' <param name="e">Object from a paint event </param>
    ''' <param name="bkgrndColor">backgroun color of lower third portion </param>
    ''' <param name="foreColor">Text fore color, also used for border of lower thid box </param>
    ''' <param name="textBackground">If true, a dark blueish semi transparent color is used for text background fit box </param>
    ''' <param name="lowerThirdBorder">if true, filled box is drawn in lower third portion </param>
    Public Function drawTextOnSlideLowerThird(e As Object, text2 As String, Optional dfont As Font = Nothing,
                                    Optional shadowColor As Color = Nothing, Optional foreColor As Color = Nothing,
                                    Optional bibleRef As String = Nothing, Optional bkgrndColor As Color = Nothing,
                                    Optional makeTransparent As Boolean = False,
                                    Optional resW As Integer = 1366, Optional resH As Integer = 768,
                                    Optional lowerThirdBorder As Boolean = False,
                                    Optional textBackground As Boolean = True) As Image
        ' Dim text2 As String = "Use TextFormatFlags and Rectangle objects to" & " center text in a rectangle."
        Try
            Dim font2 As New Font("Arial", 50 / 2, FontStyle.Bold, GraphicsUnit.Point)
            Dim rect2 As New Rectangle(150, 10, 130, 140)

            'Lower Third
            rect2.X = e.graphics.VisibleClipBounds.X + 25
            rect2.Y = (e.graphics.VisibleClipBounds.height + 25) * (2 / 3)
            rect2.Width = e.graphics.VisibleClipBounds.width - 50
            rect2.Height = (e.graphics.VisibleClipBounds.height - 50) / 3
            ' Create a TextFormatFlags with word wrapping, horizontal center and
            ' vertical center specified.
            Dim flags As TextFormatFlags = TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.WordBreak

            If Not (dfont Is Nothing) Then font2 = dfont
            'Adjust font for lower third
            font2 = New Font(font2.FontFamily, font2.Size / 2)
            If shadowColor = Nothing Then shadowColor = Color.Black
            If foreColor = Nothing Then foreColor = Color.Yellow

            'Draw the text and lower third
            'e.Graphics.SmoothingMode.HighQuality = True   'TODO: triggers error
            'Make transparent
            e.graphics.Clear(Color.Transparent)
            ' bkgrndColor is used for lower third--- If Not (bkgrndColor = Nothing) Then e.graphics.Clear(bkgrndColor)
            TextRenderer.DrawText(e.Graphics, text2, font2, rect2, shadowColor, flags) 'shadow



            rect2.X = rect2.X - 2
            rect2.Y = rect2.Y - 2
            rect2.Width = rect2.Width   'shadow=+0, outline=-x
            rect2.Height = rect2.Height
            Dim g As Graphics
            Dim myBrush As SolidBrush = New SolidBrush(bkgrndColor)  'lower third color

            'OPTIONAL - draw lower third rectangle
            'If lowerThirdBorder = True Then
            e.graphics.DrawRectangle(New Pen(bkgrndColor), rect2)
            e.graphics.FillRectangle(myBrush, rect2)
            ' End If


            ' ''Text background shade
            Dim myTextBrush As SolidBrush = New SolidBrush(Color.FromArgb(128, 0, 0, 34))  'TODO: get lower third color from user
            Dim textRect As New Rectangle(rect2.Location, TextRenderer.MeasureText(text2, font2))
            ' ''textRect.Size = TextRenderer.MeasureText(text2, font2)
            ' ''center it to align with text
            ''If textBackground = True Then
            ''    textRect.Location = New Point(rect2.X + (rect2.Width / 2) - textRect.Width / 2, rect2.Y + (rect2.Height / 2) - (textRect.Height / 2))
            ''    'textRect.Y = rect2.X + (rect2.Height / 2)
            ''    ' textRect.X = rect2.Y '- (textRect.Width / 2)
            ''    'textRect.Top = rect2.Top
            ''    e.graphics.DrawRectangle(New Pen(myTextBrush), textRect)
            ''    e.graphics.FillRectangle(myTextBrush, textRect)
            ''End If



            TextRenderer.DrawText(e.Graphics, text2, font2, rect2, foreColor, flags)




            'Optionally print bibleref (At top(or bottom) of Lower Third)
            If Not (bibleRef = Nothing) Then
                flags = TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.WordBreak
                font2 = New Font(font2.FontFamily, CSng(Math.Round(font2.Size * 0.8))) '80%  size
                rect2.X = e.graphics.VisibleClipBounds.x + 25 '25 pixels from left
                rect2.Y = rect2.Y + 2 ' rect2.Y + 25 -> top+margin;  e.graphics.VisibleClipBounds.height - 77-->   '77 pixels from buttom 77px=50points
                rect2.Width = rect2.Width   'shadow=+0, outline=-x
                rect2.Height = rect2.Height / 9 '77 pixels   'Todo: variable

                'Text background shade
                If textBackground = True Then
                    ''myTextBrush = New SolidBrush(Color.FromArgb(128, 0, 0, 34))  'lower third color
                    ''textRect = New Rectangle(rect2.Location, TextRenderer.MeasureText(bibleRef, font2))
                    ' ''textRect.Size = TextRenderer.MeasureText(text2, font2)
                    ' ''textRect.Top = rect2.Top
                    ''e.graphics.DrawRectangle(New Pen(Color.FromArgb(128, 0, 0, 34)), textRect)
                    ''e.graphics.FillRectangle(myTextBrush, textRect)
                End If
                'now draw the text
                TextRenderer.DrawText(e.Graphics, bibleRef, font2, rect2, foreColor, flags)
            End If


            font2 = Nothing
            rect2 = Nothing

            'return the thumnail and save it


            'Using grPhoto As Graphics = Graphics.FromImage(bmPhoto)
            'Using grPhoto As Graphics = e.graphics.clone

            'End Using
            Return Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function


    ''' <summary>draws Text On Slidebackground Image and reurns d Image .</summary>
    ''' <param name="e">Object from a paint event </param>
    ''' <param name="bkgrndColor">backgroun color of lower third portion </param>
    ''' <param name="foreColor">Text fore color, also used for border of lower thid box </param>
    ''' <param name="textBackground">If true, a dark blueish semi transparent color is used for text background fit box </param>
    ''' <param name="lowerThirdBorder">if true, filled box is drawn in lower third portion </param>
    Public Function drawTextOnSlideLowerThirdGRAPH(e As Object, text2 As String, Optional dfont As Font = Nothing,
                                    Optional shadowColor As Color = Nothing, Optional foreColor As Color = Nothing,
                                    Optional bibleRef As String = Nothing, Optional bkgrndColor As Color = Nothing,
                                    Optional makeTransparent As Boolean = False,
                                    Optional resW As Integer = 1366, Optional resH As Integer = 768,
                                    Optional lowerThirdBorder As Boolean = False,
                                    Optional textBackground As Boolean = True) As Image
        ' Dim text2 As String = "Use TextFormatFlags and Rectangle objects to" & " center text in a rectangle."
        Try
            Dim font2 As New Font("Arial", 50 / 2, FontStyle.Bold, GraphicsUnit.Point)
            Dim rect2 As New Rectangle(150, 10, 130, 140)

            'Lower Third
            rect2.X = e.VisibleClipBounds.X + 25
            rect2.Y = (e.VisibleClipBounds.height + 25) * (2 / 3)
            rect2.Width = e.VisibleClipBounds.width - 50
            rect2.Height = (e.VisibleClipBounds.height - 50) / 3
            ' Create a TextFormatFlags with word wrapping, horizontal center and
            ' vertical center specified.
            Dim flags As TextFormatFlags = TextFormatFlags.HorizontalCenter Or TextFormatFlags.VerticalCenter Or TextFormatFlags.WordBreak

            If Not (dfont Is Nothing) Then font2 = dfont
            'Adjust font for lower third
            font2 = New Font(font2.FontFamily, font2.Size / 2)
            If shadowColor = Nothing Then shadowColor = Color.Black
            If foreColor = Nothing Then foreColor = Color.Yellow

            'Draw the text and lower third
            'e.SmoothingMode.HighQuality = True   'TODO: triggers error

            'Make transparent
            If makeTransparent = True Then e.Clear(Color.Transparent)
            ' bkgrndColor is used for lower third--- If Not (bkgrndColor = Nothing) Then e.Clear(bkgrndColor)
            TextRenderer.DrawText(e, text2, font2, rect2, shadowColor, flags) 'shadow



            rect2.X = rect2.X - 2
            rect2.Y = rect2.Y - 2
            rect2.Width = rect2.Width   'shadow=+0, outline=-x
            rect2.Height = rect2.Height
            Dim g As Graphics
            Dim myBrush As SolidBrush = New SolidBrush(bkgrndColor)  'lower third color

            'OPTIONAL - draw lower third rectangle
            If makeTransparent = True Then
                e.DrawRectangle(New Pen(bkgrndColor), rect2)
                e.FillRectangle(myBrush, rect2)
            End If


            ' ''Text background shade
            Dim myTextBrush As SolidBrush = New SolidBrush(Color.FromArgb(128, 0, 0, 34))  'TODO: get lower third color from user
            Dim textRect As New Rectangle(rect2.Location, TextRenderer.MeasureText(text2, font2))
            ' ''textRect.Size = TextRenderer.MeasureText(text2, font2)
            ' ''center it to align with text
            ''If textBackground = True Then
            ''    textRect.Location = New Point(rect2.X + (rect2.Width / 2) - textRect.Width / 2, rect2.Y + (rect2.Height / 2) - (textRect.Height / 2))
            ''    'textRect.Y = rect2.X + (rect2.Height / 2)
            ''    ' textRect.X = rect2.Y '- (textRect.Width / 2)
            ''    'textRect.Top = rect2.Top
            ''    e.DrawRectangle(New Pen(myTextBrush), textRect)
            ''    e.FillRectangle(myTextBrush, textRect)
            ''End If



            TextRenderer.DrawText(e, text2, font2, rect2, foreColor, flags)




            'Optionally print bibleref (At top(or bottom) of Lower Third)
            If Not (bibleRef = Nothing) Then
                flags = TextFormatFlags.Left Or TextFormatFlags.VerticalCenter Or TextFormatFlags.WordBreak
                font2 = New Font(font2.FontFamily, CSng(Math.Round(font2.Size * 0.8))) '80%  size
                rect2.X = e.VisibleClipBounds.x + 25 '25 pixels from left
                rect2.Y = rect2.Y + 2 ' rect2.Y + 25 -> top+margin;  e.VisibleClipBounds.height - 77-->   '77 pixels from buttom 77px=50points
                rect2.Width = rect2.Width   'shadow=+0, outline=-x
                rect2.Height = rect2.Height / 9 '77 pixels   'Todo: variable

                'Text background shade
                If textBackground = True Then
                    ''myTextBrush = New SolidBrush(Color.FromArgb(128, 0, 0, 34))  'lower third color
                    ''textRect = New Rectangle(rect2.Location, TextRenderer.MeasureText(bibleRef, font2))
                    ' ''textRect.Size = TextRenderer.MeasureText(text2, font2)
                    ' ''textRect.Top = rect2.Top
                    ''e.DrawRectangle(New Pen(Color.FromArgb(128, 0, 0, 34)), textRect)
                    ''e.FillRectangle(myTextBrush, textRect)
                End If
                'now draw the text
                TextRenderer.DrawText(e, bibleRef, font2, rect2, foreColor, flags)
            End If


            font2 = Nothing
            rect2 = Nothing

            'return the thumnail and save it


            'Using grPhoto As Graphics = Graphics.FromImage(bmPhoto)
            'Using grPhoto As Graphics = e.clone

            'End Using
            Return Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Function
    ' Map a drawing coordinate rectangle to a graphics object
    ' rectangle.
    Public Sub MapDrawing(ByVal gr As Graphics, ByVal _
        drawing_rect As RectangleF, ByVal target_rect As  _
        RectangleF, Optional ByVal stretch As Boolean = False)
        gr.ResetTransform()

        ' Center the drawing area at the origin.
        Dim drawing_cx As Single = (drawing_rect.Left + _
            drawing_rect.Right) / 2
        Dim drawing_cy As Single = (drawing_rect.Top + _
            drawing_rect.Bottom) / 2
        gr.TranslateTransform(-drawing_cx, -drawing_cy)

        ' Scale.
        ' Get scale factors for both directions.
        Dim scale_x As Single = target_rect.Width / _
            drawing_rect.Width
        Dim scale_y As Single = target_rect.Height / _
            drawing_rect.Height
        If (Not stretch) Then
            ' To preserve the aspect ratio, use the smaller
            ' scale factor.
            scale_x = Math.Min(scale_x, scale_y)
            scale_y = scale_x
        End If
        gr.ScaleTransform(scale_x, scale_y, _
            System.Drawing.Drawing2D.MatrixOrder.Append)

        ' Translate to center over the drawing area.
        Dim graphics_cx As Single = (target_rect.Left + _
            target_rect.Right) / 2
        Dim graphics_cy As Single = (target_rect.Top + _
            target_rect.Bottom) / 2
        gr.TranslateTransform(graphics_cx, graphics_cy, _
            System.Drawing.Drawing2D.MatrixOrder.Append)
    End Sub
End Class
