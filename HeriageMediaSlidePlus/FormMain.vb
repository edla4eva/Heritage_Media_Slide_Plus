Imports Microsoft.VisualBasic.FileIO
Imports System.Data.OleDb
Imports System.Collections.ObjectModel
Imports System.IO

Imports System.Net.Sockets
Imports System.Threading
Imports System
Imports System.Net.Dns
Imports System.Drawing.Bitmap
Imports RapChatLib.RapChatLib

Public Class FormMain
    Dim eDirty As Boolean = False
    Dim eDirtyDriver As Boolean = False
    Dim myPicturebox() As PictureBox
    Dim counter As Integer = 0
    Dim pictuesAdded As Boolean = False


    'Dim clnt As New UNOLibs.Net.ClientClass
    'Dim clnt2 As New UNOLibs.Net.ClientClass
    'Dim WithEvents server As UNOLibs.Net.ServerClass
    'Dim WithEvents server2 As UNOLibs.Net.ServerClass


#Region "Main functions"
    Sub loadScriptures()
        Try
            'requery scripure with version
            Dim dp As String()
            Dim dIndex As Integer = 0
            'or call getBiblePassagesWithRef
            dp = prevObjSlide.getBiblePassages(prevObjSlide.book2Num(prevObjSlide.bibleBook), prevObjSlide.bibleChapter, prevObjSlide.bibleVersion)

            ' this could be annoying here, do it at UI. If Me.ListBoxBibles.SelectedItems.Count > 0 Then dIndex = Me.ListBoxBibles.SelectedIndex 'note it
            ListBoxBibles.Items.Clear()
            ListBoxBibles.Items.AddRange(dp)

            ''Dim items As New List(Of ListViewItem)
            ''dp2 = prevObjSlide.getBiblePassages2DArray(prevObjSlide.book2Num(prevObjSlide.bibleBook), prevObjSlide.bibleChapter, prevObjSlide.bibleVersion)
            ''For i As Integer = 0 To dp2.Length / 2 - 1 '100
            ''    items.Add(New ListViewItem(dp2(0, i), dp2(1, i)))
            ''Next
            '' ListViewBible.Items.AddRange(items.ToArray)

            'If Me.ListBoxBibles.Items.Count > dIndex Then
            '    Me.ListBoxBibles.SelectedIndex = dIndex 'select the verse
            'End If


            'load it
            refreshPrevSlides() 'instant preview
            '

        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Sub
    Private Sub loadBibleBooks()
        Try
            'load listboxes with chapter nos
            Me.ListBoxBook.Items.Clear()
            With prevObjSlide
                Dim dMax As Integer = .getbibleChaptersFull.Length  'STOP here
                Dim tmpNum(0 To dMax - 1) As String
                For i = 0 To dMax - 1
                    tmpNum(i) = prevObjSlide.getbibleChaptersFull(i).ToString
                Next

                ListBoxBook.Items.AddRange(tmpNum)
                'prevObjSlide.book2Num()
                tmpNum = Nothing
            End With
            If ListBoxBook.Items.Count > 0 Then ListBoxBook.SelectedIndex = 0 'select first book
            prevObjSlide.bibleBook = ListBoxBook.SelectedItem.ToString
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Sub
    Private Sub setUpDirectoriesAndCheck()
        Try
            Dim folderExists As Boolean
            Dim fullFilePath, fullDirPath As String
            Dim fileContents As String
            With My.Computer.FileSystem
                'Check main folder
                fullDirPath = .CombinePath(.SpecialDirectories.CurrentUserApplicationData, "Heritage Media Slide Plus")
                MsgBox(fullDirPath)
                Me.Close()
                folderExists = My.Computer.FileSystem.DirectoryExists(fullDirPath)
                If Not (folderExists = True) Then
                    'create it
                    .CreateDirectory("C:\NewDirectory")
                End If
                '  Check Images          
                fullDirPath = .CombinePath(.SpecialDirectories.CurrentUserApplicationData, "Heritage Media Slide Plus\images\thumbnails")
                folderExists = My.Computer.FileSystem.DirectoryExists(fullDirPath)
                If Not (folderExists = True) Then
                    'create it
                    .CreateDirectory("C:\NewDirectory")
                End If
            End With
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Sub
    Sub addPictures(generateThumbnails As Boolean, Optional overwrite As Boolean = False)
        Try
            '
            'clear picture box controls
            ' Me.Control.name.contains("myPicturebox")
            'mycontol.clear()
            Dim but1 As New Button
            Dim but2 As New Button
            Dim chk1 As New CheckBox
            Dim FlowLayoutPanelBackgrounds As New FlowLayoutPanel

            but1.Name = Me.ButtonNewImage.Name
            but1.Size = Me.ButtonNewImage.Size
            but1.Location = Me.ButtonNewImage.Location
            but1.Font = Me.ButtonNewImage.Font
            but1.Text = Me.ButtonNewImage.Text
            '
            but2.Name = Me.ButtonImportImage.Name
            but2.Size = Me.ButtonImportImage.Size
            but2.Location = Me.ButtonImportImage.Location
            but2.Font = Me.ButtonImportImage.Font
            but2.Text = Me.ButtonImportImage.Text
            '
            chk1.Name = Me.CheckBoxScaled.Name
            chk1.Size = Me.CheckBoxScaled.Size
            chk1.Location = Me.CheckBoxScaled.Location
            chk1.Font = Me.CheckBoxScaled.Font
            chk1.Text = Me.CheckBoxScaled.Text
            chk1.Checked = Me.CheckBoxScaled.Checked

            FlowLayoutPanelBackgrounds.Name = "FlowLayoutPanelBackgrounds"
            FlowLayoutPanelBackgrounds.Size = New System.Drawing.Size(283, 30289)
            FlowLayoutPanelBackgrounds.Location = New System.Drawing.Point(10, 36) '10,36


            Me.TabControl2.TabPages("TabPageBackgrounds").Controls.Clear()
            Me.TabControl2.TabPages("TabPageBackgrounds").Controls.Add(but1)
            Me.TabControl2.TabPages("TabPageBackgrounds").Controls.Add(but2)
            Me.TabControl2.TabPages("TabPageBackgrounds").Controls.Add(chk1)
            Me.TabControl2.TabPages("TabPageBackgrounds").Controls.Add(FlowLayoutPanelBackgrounds)

            AddHandler (but1.Click), AddressOf ButtonNewImage_Click
            AddHandler (but2.Click), AddressOf ButtonImportImage_Click
            AddHandler (chk1.CheckStateChanged), AddressOf CheckBoxScaled_CheckedChanged



            ''TODO: Fix error due to no access to files
            ''affects Image.save...int thumbnails folder
            '' ifn(My.Computer.Info.OSFullName.Contains("Windows 7") then
            'Dim fullFilePath, fullDirPath As String
            'Dim fileContents As String
            'With My.Computer.FileSystem

            'fullDirPath = .CombinePath(.SpecialDirectories.CurrentUserApplicationData, "Heritage Media Slide Plus")

            '    fullFilePath = .CombinePath(.SpecialDirectories.MyDocuments, "test.txt")
            '    fileContents = .ReadAllText(fullFilePath)
            'End With

            Dim fname() As String = {}
            Dim num As Object
            Dim noFiles As Integer = 0


            If generateThumbnails = True Then

                'generate the thumbnails
                'TODO: optimize
                For Each file In FileSystem.GetFiles(USER_DIRECTORY & "\images\")
                    counter = counter + 1
                    'TODO: Fixed generic GDI+ error
                    'Maybe it happens when image is in use
                    Try
                        'check if thumbnail already exists

                        If My.Computer.FileSystem.FileExists(USER_DIRECTORY & "\images\thumbnails\" & Path.GetFileName(file)) = True Then
                            'skip
                        ElseIf overwrite = True Then
                            wm.GetThumbnailFromImageFilename(file).Save(USER_DIRECTORY & "\images\thumbnails\" & Path.GetFileName(file))

                        Else
                            wm.GetThumbnailFromImageFilename(file).Save(USER_DIRECTORY & "\images\thumbnails\" & Path.GetFileName(file))

                        End If
                    Catch
                    End Try
                Next
            Else
                'TODO: optimize
                For Each file In FileSystem.GetFiles(USER_DIRECTORY & "\images\thumbnails\")
                    counter = counter + 1
                Next
            End If

            'Now display em
            ReDim myPicturebox(counter)
            noFiles = counter
            counter = 0
            For Each file In FileSystem.GetFiles(USER_DIRECTORY & "\images\thumbnails\")
                myPicturebox(counter) = New PictureBox
                myPicturebox(counter).Name = "myPicturebox(" & counter & ")"
                myPicturebox(counter).ImageLocation = file 'display thumnail
                myPicturebox(counter).Tag = USER_DIRECTORY & "\images\" & Path.GetFileName(file) 'note actual file
                myPicturebox(counter).Height = 60
                myPicturebox(counter).Width = 80
                myPicturebox(counter).BorderStyle = BorderStyle.Fixed3D
                myPicturebox(counter).SizeMode = PictureBoxSizeMode.StretchImage
                'position
                'myPicturebox(counter).Left = 5 '(counter + 1) * PictureBoxBackgrounds01.Width
                'myPicturebox(counter).Top = (counter) * myPicturebox(counter).Height
                'myPicturebox(counter).SizeMode = PictureBoxSizeMode.Normal

                ''Add the picture boxes
                'Me.TabControl1.TabPages("TabPageBackgrounds").Controls.Add(myPicturebox(counter))
                FlowLayoutPanelBackgrounds.Controls.Add(myPicturebox(counter))

                '------------------------------------------------------------------------------------
                '                                  Event handlers
                '------------------------------------------------------------------------------------
                AddHandler myPicturebox(counter).Click, AddressOf all_picture_boxes_clicked
                counter = counter + 1
            Next
            pictuesAdded = True

            fname = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Sub

    Public Sub loadAllSongs()
        Try
            Dim fileExists As Boolean
            Dim filename As String = Nothing
            ListBoxSongs.Items.Clear()
            For Each file In FileSystem.GetFiles(USER_DIRECTORY & "\lyrics\")
                filename = file

                fileExists = My.Computer.FileSystem.FileExists(file)

                If fileExists Then
                    ListBoxSongs.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
                End If
            Next
            objSlide.songfileName = filename
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Sub
    Public Sub loadAllServices()
        Try
            Dim fileExists As Boolean
            Dim filename As String = Nothing
            ListBoxService.Items.Clear()
            For Each file In FileSystem.GetFiles(USER_DIRECTORY & "\service\")
                filename = file
                fileExists = My.Computer.FileSystem.FileExists(file)
                If fileExists Then
                    ListBoxService.Items.Add(System.IO.Path.GetFileNameWithoutExtension(file))
                End If
            Next
            objSlide.songfileName = filename
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Sub
    Public Function searchBible(sS As String, searchOption As String, Optional addRef As Boolean = False) As String()
        Try
            'Note:
            '"THExxQUICKxxBROWNxxFOX".Split(new [] {"xx"}, StringSplitOptions.None);
            'parse search string for bible
            Dim ssAray As String() = {}
            Dim book, bookNum, chp, verse As String
            Dim pos1, pos2 As Integer
            'Or search for occurence in files
            Dim files As ReadOnlyCollection(Of String)
            Dim srr As String = ""
            If searchOption = "ref" Then '"OT" "NT"
                'TODO: simplify... ssee bookFromRef ignore space
                Dim bits As String()
                Dim chars As Char() = {" ", ":"}
                bits = sS.Split(chars)
                If bits.Length < 3 Then
                    MsgBox("Enter correct ref e.g Genesis 1:7. Note that there must be a single" &
                           "space after the book name but no spaces before or after the colon (:)" & vbCrLf & "Gen 1:4, joh 3:4, 1 Joh 1:2, 1 Pet 2:1, 1 Cor 3:2 are also allowed")
                    Return Nothing
                ElseIf bits.Length = 4 Then 'And Val(bits(0) > 0) And Val(bits(2)) > 0 And Val(bits(3)) > 0 Then  'Handle 1 John 1:6 Peter etc
                    book = bits(0) & " " & bits(1)
                    chp = bits(2)
                    verse = bits(3)
                ElseIf bits.Length = 3 And Val(bits(1)) > 0 And Val(bits(2)) > 0 And bits(0).Length >= 3 Then 'standard
                    book = bits(0)
                    chp = bits(1)
                    verse = bits(2)
                Else 'unknown
                    MsgBox("Enter correct ref e.g Genesis 1:7. Note that there must be a single" &
                           "space after the book name but no spaces before or after the colon (:)" & vbCrLf & "Gen 1:4, joh 3:4, 1 Joh 1:2, 1 Pet 2:1, 1 Cor 3:2 are also allowed")
                    Return Nothing
                End If



                'pos1 = sS.IndexOf(" ")
                'pos2 = sS.IndexOf(":", 0)
                ''cint(sS.Split({" "})(0))>0
                'If CInt(sS.Substring(pos2 - 2, 2)) > sS.Substring(pos2 - 1, 1) Then
                '    chp = sS.Substring(pos2 - 2, 2)
                '    book = Trim(sS.Substring(0, pos2 - 2)).TrimEnd
                '    book.TrimStart()
                'Else
                '    chp = sS.Substring(pos2 - 1, 1)
                '    book = (sS.Substring(0, pos2 - 1)).TrimEnd
                '    book.TrimStart()
                'End If
                'pos1 = pos2
                'verse = sS.Substring(pos1 + 1).Trim
                bookNum = prevObjSlide.book2Num(book) 'Gen=1,Exo=2,Lev=3
                If bookNum Is Nothing Then
                    MsgBox("Enter correct ref e.g Genesis 1:7. Note that there must be a single" &
                           "space after the book name but no spaces before or after the colon (:)" & vbCrLf & "Gen 1:4, joh 3:4, 1 Joh 1:2, 1 Pet 2:1, 1 Cor 3:2 are also allowed")
                    Return Nothing

                End If


                If addRef = True Then
                    ssAray = prevObjSlide.getBiblePassagesWithRef(bookNum, chp)
                Else
                    ssAray = prevObjSlide.getBiblePassages(bookNum, chp)
                End If


                Debug.Print(ssAray(CInt(verse - 1))) 'reurns full scrpture withref and  verse
                'Good load all passage and select the verse

                ListBoxBibles.Items.Clear()
                ListBoxBibles.Items.AddRange(ssAray)
                If ListBoxBibles.Items.Count > 0 Then ListBoxBibles.SelectedIndex = (verse - 1) 'Auto select the scripture

                '
                If CInt(verse) > 0 And CInt(chp) > 0 And CInt(bookNum) > 0 Then
                    prevObjSlide.bibleVerse = verse
                    prevObjSlide.bibleBook = prevObjSlide.num2Book(bookNum)
                    prevObjSlide.slideStr = ssAray(verse - 1)   'TODO: Just dumped this here in case
                Else
                    Return {}
                End If
            ElseIf searchOption = "NT" Then


                'yes=NT
                prevObjSlide.searchResultsSong = prevObjSlide.searchDBbiblePassage(sS, "Matthew", "Revelation")

            ElseIf searchOption = "OT" Then '"OT" "NT" Then
                'No=OT
                prevObjSlide.searchResultsSong = prevObjSlide.searchDBbiblePassage(sS, "Genesis", "Malachi")
            Else

            End If
            Return ssAray
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Function
    Public Function searchFiles(sS As String) As String()
        Try
            'parse search string for bible
            Dim ssAray As String() = {}
            Dim book As String

            'Or search for occurence in files
            Dim files As ReadOnlyCollection(Of String)
            Dim srr As String = ""

            If sS.Contains(":") Then
                MsgBox("Enter part of lyrics e.g Amazing grace")
            Else
                book = USER_DIRECTORY & "\lyrics\"
                files = My.Computer.FileSystem.GetFiles(book, FileIO.SearchOption.SearchAllSubDirectories, "*" & sS & "*.txt")
                Array.Clear(ssAray, 0, ssAray.Length)
                Array.Resize(ssAray, files.Count) 'TODO: triggers error when empty

                Dim i As Integer = 0
                For Each sr In files
                    srr = srr & vbCrLf & sr
                    ssAray(i) = Path.GetFileNameWithoutExtension(sr)
                    i = i + 1
                Next
                'MsgBox(srr)
            End If
            Return ssAray
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Function
    Public Function arrayToStr(dsr As String()) As String
        Try
            Dim srr As String = ""
            For Each sr In dsr
                srr = srr & vbCrLf & sr
            Next
            Return (srr)
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Function

    Public Function loadSong(dSongfileName As String, Optional defFileName As String = "songs") As String()
        Try
            Dim fileExists As Boolean
            Dim fields As String() = {""}
            Dim delimiter As String = ","
            Dim lines() As String = {}
            objSlide.song = {""}
            fileExists = My.Computer.FileSystem.FileExists(prevObjSlide.songfileName)
            If fileExists Then
                lines = IO.File.ReadAllLines(prevObjSlide.songfileName)
                'retrieve headers
                '[SONG TITLE]
                'Once Again
                '[AUTHOUR]
                'Unknown
                If lines(0).Contains("[SONG TITLE]") Then prevObjSlide.songTitle = lines(1)
                If lines(2).Contains("[AUTHOUR]") Then prevObjSlide.songAuthour = lines(3)
            Else

            End If

            Dim linesNew(0 To lines.Length - 4 - 1) As String
            If lines(0).Contains("[SONG TITLE]") And lines(2).Contains("[AUTHOUR]") Then
                Array.ConstrainedCopy(lines, 4, linesNew, 0, linesNew.Length)
            Else
                linesNew = lines
            End If



            Return linesNew
            lines = Nothing
            linesNew = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Function

    'Public Sub saveService(isItScripture As Boolean)
    '    If prevObjSlide.song Is Nothing Then Return 'some sanity checks
    '    If prevObjSlide.song.Count = 0 Then Return 'some sanity checks
    '    Dim fileExists As Boolean
    '    Dim AllLines(0 To prevObjSlide.song.Length - 1) As String
    '    Dim lines() As String = prevObjSlide.song
    '    Dim dSongfileName As String = Path.GetDirectoryName(prevObjSlide.songfileName) & "\song" & Format(ListBoxService.Items.Count, "000").ToString & " - " & Path.GetFileName(prevObjSlide.songfileName)
    '    fileExists = My.Computer.FileSystem.FileExists(dSongfileName)
    '    If fileExists Then My.Computer.FileSystem.DeleteFile(dSongfileName)
    '    'Format

    '    '[SCRIPTURE]
    '    'Genesis
    '    '1:
    '    '1:
    '    'KJV
    '    'In the beginning God created the heaven and the earth.

    '    If isItScripture = True Then 'lines(0).Contains("[Scripture]") Then
    '        ReDim Preserve AllLines(0 To prevObjSlide.song.Length + 5 - 1)  '5 additional lines for header\
    '        AllLines(0) = "[SCRIPTURE]"
    '        AllLines(1) = prevObjSlide.bibleBook  'second line
    '        AllLines(2) = prevObjSlide.bibleChapter
    '        AllLines(3) = prevObjSlide.bibleVerse
    '        AllLines(4) = prevObjSlide.bibleVersion

    '        Array.ConstrainedCopy(lines, 0, AllLines, 5, lines.Length)

    '        'write to Alllines file
    '        Dim strFileBible As String = ""
    '        For i = 0 To lines.Length - 1
    '            strFileBible = strFileBible & lines(i) & vbCrLf
    '        Next
    '        My.Computer.FileSystem.WriteAllText(dSongfileName, strFileBible, True)
    '        AllLines = Nothing
    '    Else
    '        'write lines() to file
    '        Dim strFile As String = ""
    '        For i = 0 To lines.Length - 1
    '            strFile = strFile & lines(i) & vbCrLf
    '        Next
    '        My.Computer.FileSystem.WriteAllText(dSongfileName, strFile, True)
    '        lines = Nothing

    '    End If
    '    'Add it to listbox
    '    ListBoxService.Items.Add(Path.GetFileNameWithoutExtension(dSongfileName))
    'End Sub

    Public Sub loadService(dSongfileName As String, Optional defFileName As String = "songs")
        Dim fileExists As Boolean
        objSlide.song = {"", ""}
        Dim fields As String() = {"", ""}
        Dim delimiter As String = ","
        fileExists = My.Computer.FileSystem.FileExists(prevObjSlide.songfileName)
        If fileExists Then
            Dim lines() As String = IO.File.ReadAllLines(prevObjSlide.songfileName)
            'Format

            '[SCRIPTURE]
            'Genesis
            '1:
            '1:
            'KJV
            'In the beginning God created the heaven and the earth.


            If lines(0).Contains("[Scripture]") Or lines(0).Contains("[SCRIPTURE]") Then
                prevObjSlide.prevBibleBook = lines(1) 'second line
                prevObjSlide.prevBibleChapter = lines(2)
                prevObjSlide.prevBibleVerse = lines(3)
                prevObjSlide.prevBibleVersion = lines(4)

                Dim linesNew(0 To lines.Length - 5 - 1) As String
                Array.ConstrainedCopy(lines, 5, linesNew, 0, lines.Length - 5)
                prevObjSlide.bibleText = prevObjSlide.Array2sTR(linesNew, False, False)

                prevObjSlide.scriptureStateNavDriMain(1) = True
                ListBoxDriver.Items.Clear()
                ListBoxDriver.Items.AddRange(wrapAndSplit(prevObjSlide.bibleText, prevObjSlide.settings.Item("charPerLine"), prevObjSlide.settings.Item("maxLine")))

                prevObjSlide.song = linesNew


            ElseIf lines(0).Contains("[SONG TITLE]") Then
                If lines(0).Contains("[SONG TITLE]") Then prevObjSlide.songTitle = lines(1)
                If lines(2).Contains("[AUTHOUR]") Then prevObjSlide.songAuthour = lines(3)

                Dim linesNew(0 To lines.Length - 4 - 1)
                If lines(0).Contains("[SONG TITLE]") And lines(2).Contains("[AUTHOUR]") Then
                    Array.ConstrainedCopy(lines, 4, linesNew, 0, linesNew.Length)

                    prevObjSlide.scriptureStateNavDriMain(1) = False
                    prevObjSlide.song = linesNew
                    ListBoxDriver.Items.Clear()
                    ListBoxDriver.Items.AddRange(linesNew)
                End If

            Else 'song without titlr
                prevObjSlide.scriptureStateNavDriMain(1) = False
                prevObjSlide.song = lines
                ListBoxDriver.Items.Clear()
                ListBoxDriver.Items.AddRange(lines)


            End If

        End If
    End Sub

    Public Sub loadAllBibleVersions()
        Try
            Dim dpassage As String() = prevObjSlide.loadAllBibleVersions()
            ListBoxBibleVersions.Items.Clear()
            For i = 0 To dpassage.Length - 1
                ListBoxBibleVersions.Items.Add(dpassage(i))
            Next
            'or
            'ListBoxBibleVersions.Items.Addrange(dpassage)
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Sub
    Public Sub setBackgroundFromSrc(destPicureBox As PictureBox, srcPicureBox As PictureBox, op As String)
        On Error Resume Next
        destPicureBox.Image = srcPicureBox.Image
    End Sub
    Public Sub setBackground(destPicureBox As PictureBox, op As String)
        'destPicureBox.BackgroundImage = Image
        'destPicureBox.Image = Image.FromFile("test.gif")

    End Sub
    Sub drawTextOnScreen(dStr As String, fontSize As Integer)
        On Error Resume Next
        'FontFamily
        Dim gr As Graphics = Graphics.FromHwnd(New IntPtr(0))
        gr.DrawString(dStr, New Font(Me.Font.FontFamily, fontSize, FontStyle.Regular), Brushes.Red, 50, 50)
        gr = Nothing
    End Sub
    Sub drawTextOnScreen2(dStr As String, fontSize As Integer)
        On Error Resume Next
        'FontFamily
        Dim gr As Graphics = Graphics.FromHwnd(New IntPtr(0))
        ' Screen.AllScreens(1).
        gr.DrawString(dStr, New Font(Me.Font.FontFamily, fontSize, FontStyle.Regular), Brushes.Red, 50, 50)
        gr = Nothing
    End Sub
    Sub refreshSlides()
        Try
            ' FormLiveMock.Tag = "preview"
            '-----------------------------
            'bitmap mth
            FormLive.PictureBox1.Image = objSlide.backgroundImage
            'Dim imgBM As New Bitmap(FormLive.PictureBox1.Image) 'image only
            Dim imgBM As New Bitmap(FormLive.PictureBox1.Width, FormLive.PictureBox1.Height + 100) 'test
            FormLive.PictureBox1.DrawToBitmap(imgBM, FormLive.PictureBox1.Bounds) 'this is where graphics is copied
            Me.PictureBoxLive.Image = imgBM

            'wm.MapDrawing(FormLive.PictureBox1.CreateGraphics, FormLive.PictureBox1.DisplayRectangle, Me.PictureBoxLive.DisplayRectangle, False)
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Sub
    Sub refreshPrevSlides()
        Try
            ' FormLiveMock.Tag = "preview"
            '-----------------------------

            FormLiveMock.PictureBox1.Image = prevObjSlide.backgroundImage 'Image.FromFile(prevObjSlide.previewImageFileName)

            'bitmap mth
            'Dim imgBM As New Bitmap(FormLiveMock.PictureBox1.Image)
            Dim imgBM As New Bitmap(FormLiveMock.PictureBox1.Width, FormLiveMock.PictureBox1.Height + 100)
            FormLiveMock.PictureBox1.DrawToBitmap(imgBM, FormLiveMock.PictureBox1.Bounds)
            Me.PictureBoxPreview.Image = imgBM


        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Sub
    Sub showLive()
        Try
            objSlide = prevObjSlide

            FormLive.Close() 'CHECK
            FormLive.PictureBox1.Image = objSlide.backgroundImage
            'FormLive.PictureBox1.Image = wm.CreateWatermark(objSlide.getBackgroundImage, objSlide.slideStr)
            FormLive.PictureBox1.Refresh()
            'FormLive.Refresh()
            FormLive.Visible = True
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Sub
    Sub nextSlide()
        FormLive.PictureBox1.Image = objSlide.backgroundImage
        'FormLive.PictureBox1.Image = wm.CreateWatermark(objSlide.getBackgroundImage, objSlide.slideStr)
        FormLive.PictureBox1.Refresh()
        'FormLive.Refresh()
        FormLive.Visible = True
    End Sub
    Function turnSlideOnOff() As Boolean
        Try
            If FormLive.Visible = True Then
                FormLive.Visible = False
                Return False
            Else
                FormLive.Visible = True
                Return True
            End If
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Function
#End Region
    Private Sub PictureBoxBackgrounds01_Click(sender As Object, e As EventArgs)
        'we dont need this

    End Sub

#Region "               Form              "
    Public Sub preloadMainform()
        Try
            'Put All the heavy jobs form main does at startup here
            'this will make the splash screen hide the delay
            Me.SplitContainer2.Panel1.BackColor = Color.FromArgb(120, 255, 192, 192) 'reddish
            Me.TabControl2.SelectTab("TabPageBibles")
            'TODO: Run Tests
            My.Application.SaveMySettingsOnExit = True
            Me.loadSettings()
            'Apply it
            'saveSettings()

            Me.loadAllSongs()
            Me.loadAllServices()
            'TODO:  Save to Document folder or local.app folder so that we can have  access to files in non admin mode
            'loadService("services")
            Me.loadAllBibleVersions()
            Me.loadScriptures() 'important

            Me.addPictures(False)

        Catch ex As Exception
            logError(" Error preloading FormMain. " & vbCrLf & ex.ToString)
        End Try
    End Sub
#Region "Custom Event Handlers"
    Sub prevObjSlide_myEventOnPropertyChanged(ByVal sender As Object, e As ClassAnswerEventArgs)
        ' MsgBox("Event prevObjSlide_myEventOnPropertyChanged just occured, ans is " & e.Ans.ToString & "variable state is :" & e.VariableChanged)  '
        'MsgBox("Sende ppties:  " & sender.ToString)
        'you can assess the properties and methods of the sender e.g
        ' sender.inputGreaterThan100

    End Sub
#End Region
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try

            Me.Visible = False
            preloadMainform()
            '---------------Do these in MDIMain
            'SplitContainer2.Panel1.BackColor = Color.FromArgb(120, 255, 192, 192) 'reddish
            'My.Application.SaveMySettingsOnExit = True
            'loadSettings()
            ''Apply it
            ''saveSettings()
            'loadAllSongs()
            'loadAllServices()
            ''TODO:  Save to Document folder or local.app folder so that we can have  access to files in non admin mode
            ''loadService("services")
            'loadAllBibleVersions()
            'loadScriptures() 'important
            'loadBackgroundImages()
            'addPictures(False)

            'Me.TabControl2.SelectTab("TabPageBibles")


            'Do this here, we are ready
            If Not (prevObjSlide.settings("mode") = "driver") Then
                Me.ButtonUse.Text = "Load"
                ButtonSendToDriver.BringToFront()
                LabelDriver.Visible = False
                LabelNavigator.Visible = False
                ButtonUseNavigaor.Visible = False
                ListBoxDriver.Left = ListBoxNavigaor.Left
                ListBoxDriver.Width = ListBoxNavigaor.Width + ListBoxDriver.Width
                ListBoxNavigaor.Visible = False
            Else
                'no need to do anything maintain defaults
            End If

            Me.ListBoxMain.SelectionMode = SelectionMode.MultiExtended
            Me.ListBoxDriver.SelectionMode = SelectionMode.MultiExtended
            Me.ListBoxNavigaor.SelectionMode = SelectionMode.MultiExtended

            'initialize active contents
            ' prevObjSlide.scriptureStateNavDriMain = {False, False, True}
            prevObjSlide.backgroundImage = prevObjSlide.getBackgroundImage
            objSlide.backgroundImage = prevObjSlide.backgroundImage
            prevObjSlide.songAuthour = "Chris Delvan Gwamna"
            prevObjSlide.songTitle = "Oh Lord hear my cry"
            prevObjSlide.slideStr = "Oh Oh Oh Oh Lord" & vbCr &
               "Hear my cry when I call" & vbCr &
              "Oh Oh Oh Oh Lord" & vbCr &
             "I cant go on without you"

            prevObjSlide.slideStr = prevObjSlide.slideStr & "" & vbCr &
                "Oh Oh Oh Oh Lord" & vbCr &
                "Hear my cry when I call" & vbCr &
                "Oh Oh Oh Oh Lord" & vbCr &
                "I cant go on without you"

            Me.ListBoxMain.SelectedIndex = 0
            Me.ListBoxDriver.SelectedIndex = 0

            AddHandler prevObjSlide.myEventOnPropertyChanged, AddressOf prevObjSlide_myEventOnPropertyChanged

            FormLiveMock.Show()
            refreshPrevSlides()
            refreshSlides()

            'refreshPrevSlides()
            Me.Visible = True
            '-------------- these initializations are not necessary (already defaults UI)----------------
            ' '' '' ''load Song
            '' '' ''ListBoxDriver.Items.Clear()
            '' '' ''ListBoxDriver.Items.AddRange(loadSong("songs"))
            '' '' ''loadBibleBooks()
            '' '' ''ListBoxChapter.SelectedIndex = 0
            '' '' ''ListBoxVerse.SelectedIndex = 0
            '' '' ''ListBoxBook.SelectedIndex = 0
            '-------------- these initializations are not necessary (already defaults UI)----------------


        Catch ex As Exception
            'can cause error
            logError("Error occured while loading main form!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try

        '------------------------------------------------------------------------------------
        '                                   Initialize Messaging
        '------------------------------------------------------------------------------------

        Dim ListThread As New Thread(New ThreadStart(AddressOf Listening)) 'Creates the thread

        Dim shostname As String
        Try
            ListThread.Start() 'Starts the thread
            shostname = System.Net.Dns.GetHostName
            Console.WriteLine("Your Machine Name = " & shostname)
            'Call Get IPAddress
            Console.WriteLine("Your IP = " & GetIPAddress())
            lblStatus.Text = ("My Computer: " & shostname & " - " & GetIPAddress())
            cmbAddress.Items.Add(GetIPAddress())
            cmbAddress.SelectedIndex = 0

        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured while creating network connection" & vbCrLf & "This error was caused because: " & ex.GetBaseException().Message)
            logError("Error occured while creating network connection!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try



    End Sub
    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Try
            Dim offlinestring As String = " Has gone Offline. You can No longer Message This User."
            If RichTextBox1.Text.Contains(offlinestring) Then
                End
            Else
                txtmessage.Text = txtName.Text & " Has gone Offline. You can No longer Message This User."
                btnSend.PerformClick()
            End If
        Catch ex As Exception

            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

#End Region
#Region "Main"
    Private Sub ListBoxMain_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxMain.SelectedIndexChanged
        Try
            If eDirty = False Then
                'TODO: do some additional manipulations 1. ignore blank, 2. up arrow previous
                eDirty = True       'Flag-we are now in the middle of an auto highlight process
                Call ListBoxMain_Click(sender, e)
                eDirty = False
            End If
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub
    Private Sub ListBoxMain_Click(sender As Object, e As EventArgs) Handles ListBoxMain.Click
#If DEBUG Then

#Else
        Try
#End If

        Dim strOut As String = ""
        Dim noItem As Integer = ListBoxMain.Items.Count - 1
        Dim c As Integer = 0
        For i = 0 To noItem

            If i = ListBoxMain.SelectedIndex Then
                c = ListBoxMain.SelectedIndex
                For j = c To noItem
                    If ListBoxMain.Items(j).ToString <> "" And ListBoxMain.Items(j).ToString.Contains("[") = False Then ListBoxMain.SetSelected(j, True)
                    If ListBoxMain.Items(j).ToString = "" Or ListBoxMain.Items(j).ToString.Contains("[") = True Then Exit For
                Next
                Exit For
            End If
        Next

        noItem = ListBoxMain.SelectedItems.Count
        For i = 0 To noItem - 1
            strOut = strOut & vbCrLf & ListBoxMain.SelectedItems.Item(i).ToString
        Next

        objSlide.slideStr = strOut 'Update content
        objSlide.scriptureStateNavDriMain = prevObjSlide.scriptureStateNavDriMain 'update state (scr or song)


        'NOTE: There must be harmony here NOTE: Scriptures dont sync with ref if this is not done
        'scriptures gets loaded automatically
        'so we must manually set the properties
        'for both objects
        'THIS IS THE EXCEPTION TO THE GENERAL RULE 
        'prevObjSlide.slideStr = strOut
        'it can also be a scripture
        'now preview MUST be updated
        If CheckBoxLive.Checked = True Then
            prevObjSlide.slideStr = strOut
            objSlide.bibleBook = prevObjSlide.bibleBook : objSlide.bibleChapter = prevObjSlide.bibleChapter
            objSlide.bibleVerse = prevObjSlide.bibleVerse : objSlide.bibleVersion = prevObjSlide.bibleVersion
            objSlide.bibleText = prevObjSlide.bibleText : objSlide.bibleRef = prevObjSlide.bibleRef
            'todo: refreshPrevSlides() 'so both are in sync and the same
        End If

        refreshSlides()
        nextSlide()


#If DEBUG Then

#Else
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured while selecting main content!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured while selecting main content!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
#End If

    End Sub



    Private Sub ButtonLive_Click(sender As Object, e As EventArgs) Handles ButtonLive.Click

        refreshSlides()
        showLive()
    End Sub




    Private Sub Form1_LocationChanged(sender As Object, e As EventArgs) Handles Me.LocationChanged
        'Update
        On Error Resume Next
        Dim scrn As Screen = Screen.FromControl(Me)
        TextBoxStatus.Text = "Curren Monitor: " & scrn.DeviceName
        TextBoxStatus.Text = TextBoxStatus.Text & vbCrLf & scrn.WorkingArea.ToString()
        TextBoxStatus.Text = TextBoxStatus.Text & vbCrLf & "Screen Dimension: " & scrn.Bounds.ToString()
        TextBoxStatus.Text = TextBoxStatus.Text & vbCrLf & "No of Screens: " & Screen.AllScreens.Length.ToString()
    End Sub






    Private Sub ListBoxSongs_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxSongs.DoubleClick
        Try
            If MessageBox.Show("Click YES to add to service " & vbCrLf & "Or" & vbCrLf & "Click NO to Edit the song", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                'Add  to service
                If ListBoxSongs.Items.Count = 0 Then Return
                ListBoxService.Items.Add(ListBoxSongs.SelectedItem)
                'saveService(False) 'TODO: fix

                MessageBox.Show("Added to service")
            Else
               
                'TODO: Edit song
                FormEditor.Show()
                FormEditor.loadfile(prevObjSlide.songfileName)
            End If
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured on song list!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured on song list!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ListBoxSongs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxSongs.SelectedIndexChanged
        Try
            If ListBoxSongs.Items.Count = 0 Then Return 'Remove uncessary headaches. Fixed error when listbox is empty
            'load from file
            prevObjSlide.songfileName = USER_DIRECTORY & "\lyrics\" & ListBoxSongs.SelectedItem & ".txt"
            prevObjSlide.scriptureStateNavDriMain(1) = False 'save state
            ListBoxDriver.Items.Clear()
            prevObjSlide.song = loadSong(prevObjSlide.songfileName)
            ListBoxDriver.Items.AddRange(prevObjSlide.song)


            'Auto add to service
            'saveService(False) 'TODO: fix
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured while loading song from file!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured whilw loading song from file!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub
    Private Sub panel4_Paint(ByVal sender As Object, ByVal e As PaintEventArgs) Handles Panel4.Paint
        On Error Resume Next
        Dim header2 As String = "This is a much, much longer Header"
        Dim description As String = "This is a description of the header."
        Dim header2Rect As RectangleF = New RectangleF()

        Using useFont As Font = New Font("Gotham Medium", 28, FontStyle.Bold)
            header2Rect.Location = New Point(30, 105)
            header2Rect.Size = New Size(600, (CInt(e.Graphics.MeasureString(header2, useFont, 600, StringFormat.GenericTypographic).Height)))
            e.Graphics.DrawString(header2, useFont, Brushes.Black, header2Rect)
        End Using

        Dim descrRect As RectangleF = New RectangleF()

        Using useFont As Font = New Font("Gotham Medium", 28, FontStyle.Italic)
            descrRect.Location = New Point(30, CInt(header2Rect.Bottom))
            descrRect.Size = New Size(600, (CInt(e.Graphics.MeasureString(description, useFont, 600, StringFormat.GenericTypographic).Height)))
            e.Graphics.DrawString(description.ToLower(), useFont, SystemBrushes.WindowText, descrRect)
        End Using
    End Sub


    Private Sub ButtonUseNavigaor_Click(sender As Object, e As EventArgs) Handles ButtonUseNavigaor.Click
        Try
            ListBoxDriver.Items.Clear()
            Dim i As Integer = 0

            If ListBoxNavigaor.Items(0).Contains("[Scripture]") Or ListBoxNavigaor.Items(0).Contains("[SCRIPTURE]") Then
                prevObjSlide.scriptureStateNavDriMain(1) = True
                prevObjSlide.scriptureStateNavDriMain(1) = True 'update state

                prevObjSlide.bibleBook = ListBoxNavigaor.Items(1)
                prevObjSlide.bibleChapter = ListBoxNavigaor.Items(2)
                prevObjSlide.bibleVerse = ListBoxNavigaor.Items(3)
                prevObjSlide.bibleVersion = ListBoxNavigaor.Items(4)
                If Not ListBoxNavigaor.Items.Count = 0 Then
                    For i = 5 To ListBoxNavigaor.Items.Count - 1
                        ListBoxDriver.Items.Add(ListBoxNavigaor.Items.Item(i))
                    Next
                End If
            ElseIf ListBoxNavigaor.Items(0).Contains("[Song Title]") Or ListBoxNavigaor.Items(0).Contains("[SONG TITLE]") Then
                If ListBoxNavigaor.Items.Item(0).Contains("[SONG TITLE]") Then prevObjSlide.songTitle = ListBoxNavigaor.Items.Item(1)
                If ListBoxNavigaor.Items.Item(2).Contains("[AUTHOUR]") Then prevObjSlide.songAuthour = ListBoxNavigaor.Items.Item(3)

                If Not ListBoxNavigaor.Items.Count = 0 Then
                    For i = 4 To ListBoxNavigaor.Items.Count - 1
                        ListBoxDriver.Items.Add(ListBoxNavigaor.Items.Item(i))
                    Next
                End If

            Else
                prevObjSlide.scriptureStateNavDriMain(1) = False
                If Not ListBoxNavigaor.Items.Count = 0 Then
                    For i = 0 To ListBoxNavigaor.Items.Count - 1
                        ListBoxDriver.Items.Add(ListBoxNavigaor.Items.Item(i))
                    Next
                End If

            End If


        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ButtonUse_Click(sender As Object, e As EventArgs) Handles ButtonUse.Click
        Try
            ListBoxMain.Items.Clear()
            ListBoxMain.Tag = "" 'TODO: if it is a scripture, store ref in tag, remove scripture ref from listbox
            'prevObjSlide.slideIsScripture = False
            prevObjSlide.scriptureStateNavDriMain(2) = prevObjSlide.scriptureStateNavDriMain(1) 'save state

            prevObjSlide.bibleBook = prevObjSlide.prevBibleBook
            prevObjSlide.bibleChapter = prevObjSlide.prevBibleChapter
            prevObjSlide.bibleVerse = prevObjSlide.prevBibleVerse
            prevObjSlide.bibleVersion = prevObjSlide.prevBibleVersion

            'TODO: Check the effect of this
            objSlide = prevObjSlide
            Dim i As Integer = 0
            For i = 0 To ListBoxDriver.Items.Count - 1
                If Not ListBoxDriver.Items.Count = 0 Then
                    ListBoxMain.Items.Add(ListBoxDriver.Items.Item(i))
                End If
            Next
            If ListBoxDriver.SelectedIndex >= 0 Then
                ListBoxMain.SetSelected(ListBoxDriver.SelectedIndex, True)
            Else
                If ListBoxMain.Items.Count > 0 Then ListBoxMain.SetSelected(0, True)
            End If

        Catch ex As Exception
            'can cause error
            MsgBox("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub





    Private Sub ButtonI_Click(sender As Object, e As EventArgs) Handles ButtonI.Click
        Try
            If turnSlideOnOff() = True Then

                If FormLive.Label1.Visible = False Then
                    FormLive.Label1.Visible = True
                    FormLive.FormBorderStyle = Windows.Forms.FormBorderStyle.Sizable

                Else
                    FormLive.Label1.Visible = False
                    FormLive.FormBorderStyle = Windows.Forms.FormBorderStyle.None
                    FormLive.Height = FormLive.Height + 100 '
                End If
            End If
        Catch ex As Exception
            'can cause error
            MsgBox("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ListBoxDriver_Click(sender As Object, e As EventArgs) Handles ListBoxDriver.Click
        Try
            Dim strOut As String = ""
            Dim noItem As Integer = ListBoxDriver.Items.Count - 1
            Dim c As Integer = 0
            For i = 0 To noItem

                If i = ListBoxDriver.SelectedIndex Then
                    c = ListBoxDriver.SelectedIndex
                    For j = c To noItem
                        If ListBoxDriver.Items(j).ToString <> "" And ListBoxDriver.Items(j).ToString.Contains("[") = False Then ListBoxDriver.SetSelected(j, True)
                        If ListBoxDriver.Items(j).ToString = "" Or ListBoxDriver.Items(j).ToString.Contains("[") = True Then Exit For

                    Next
                    Exit For
                End If
            Next

            noItem = ListBoxDriver.SelectedItems.Count
            For i = 0 To noItem - 1
                strOut = strOut & vbCrLf & ListBoxDriver.SelectedItems.Item(i).ToString
            Next

            prevObjSlide.slideStr = strOut
            refreshPrevSlides()
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ListBoxDriver_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxDriver.DoubleClick
        Try
            Dim sr As String = ""
            For Each item In ListBoxDriver.Items
                sr = sr + item + vbCrLf
            Next

            FormEditor.TextBoxAuthour.Clear()
            FormEditor.TextBoxTitle.Clear()
            FormEditor.Show()
            FormEditor.TextBoxTitle.Text = prevObjSlide.songTitle
            FormEditor.TextBoxAuthour.Text = prevObjSlide.songAuthour
            FormEditor.loadText(sr)
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearchBible.Click
        Try
            ListBoxSearch.Items.Clear()
            Dim bib As String() = {}
            'if 
            If TextBoxSearch.Text.Contains(":") Then
                bib = searchBible(TextBoxSearch.Text, "ref", True)  'searchOption="ref" "OT" "NT"
                ListBoxSearch.Items.AddRange(bib)
                ListBoxSearch.BringToFront()

                Me.RichTextBoxSearch.Text = prevObjSlide.Array2sTR(bib, False, True)
           
            Else
                Dim res As MsgBoxResult
                res = MsgBox("You did not enter a scripture reference e.g Gen 3:2" & vbCrLf &
                                                  "If you want to search the entire NT bible for the phrase click YES" & vbCrLf &
                                                  "If you want to search the entire OT bible for the phrase click NO" & vbCrLf &
                                                  "To cancel, click CANCEL", MsgBoxStyle.YesNoCancel)
                If res = MsgBoxResult.Yes Then
                    bib = searchBible(TextBoxSearch.Text, "NT", True)  'searchOption="ref" "OT" "NT"
                    ReDim bib(0 To prevObjSlide.searchResultsSong.Length - 1)
                    For i = 0 To prevObjSlide.searchResultsSong.Length - 1
                        If Not (prevObjSlide.searchResultsSong(i).passage) Is Nothing Then
                            bib(i) = (prevObjSlide.searchResultsSong(i).ref) & " " & (prevObjSlide.searchResultsSong(i).passage)
                        Else 'todo: avoid mismatch
                            bib(i) = " "
                        End If
                    Next
                    ListBoxSearchBible.Items.Clear()
                    ListBoxSearchBible.Items.AddRange(bib)
                    ListBoxSearchBible.BringToFront()

                    Me.RichTextBoxSearch.Text = prevObjSlide.Array2sTR(bib, False, True)


                ElseIf res = MsgBoxResult.No Then 'OT
                    bib = searchBible(TextBoxSearch.Text, "OT", True)  'searchOption="ref" "OT" "NT"

                    ReDim bib(0 To prevObjSlide.searchResultsSong.Length - 1)
                    For i = 0 To prevObjSlide.searchResultsSong.Length - 1
                        If Not (prevObjSlide.searchResultsSong(i).passage) Is Nothing Then
                            bib(i) = (prevObjSlide.searchResultsSong(i).ref) & " " & (prevObjSlide.searchResultsSong(i).passage)
                        Else 'todo: avoid mismatch
                            bib(i) = " "
                        End If

                    Next
                    ListBoxSearchBible.Items.Clear()
                    ListBoxSearchBible.Items.AddRange(bib)
                    ListBoxSearchBible.BringToFront()

                    Me.RichTextBoxSearch.Text = prevObjSlide.Array2sTR(bib, False, True)
                End If
            End If

 


        Catch ex As Exception
            'can cause error
            MsgBox("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Try
            If Listener.Pending = True Then
                Message = ""
                Client = Listener.AcceptTcpClient()

                Dim Reader As New StreamReader(Client.GetStream())
                While Reader.Peek > -1
                    Message = Message + Convert.ToChar(Reader.Read()).ToString
                End While
                Me.lblMessage.Text = Message
                Me.ListBoxNavigaor.Items.Clear()
                Me.ListBoxNavigaor.Items.AddRange(prevObjSlide.str2Array(Message))
                Me.RichTextBox1.Text = Me.RichTextBox1.Text & vbCrLf & Message

                'TODO: Implement full remote mode.
                'Remtoe user completel conrol slide.. driver computer serves as HDMI port closest o projector
                'If prevObjSlide.fullRemoteMode Then processRemoteCommand(Message)
                'function processRemoteCommand(Message as string)
                'is it scripture or song. Is it navigate back/foward is i select item(x)? 

            End If




            'If Listener1.Pending = True Then
            '    Message1 = ""
            '    Client1 = Listener1.AcceptTcpClient()

            '    Dim Reader1 As New StreamReader(Client1.GetStream())
            '    While Reader1.Peek > -1
            '        Message1 = Message1 + Reader1.Read().ToString ' Convert.ToChar(Reader1.Read()).ToString
            '    End While
            '    MsgBox(Message1)
            'End If

        Catch ex As Exception

        End Try
    End Sub



    Private Sub TabControl1_GotFocus(sender As Object, e As EventArgs) Handles TabControl1.GotFocus
        On Error Resume Next
        TabControl2.Height = 35 '35 or 289
    End Sub
    Private Sub TabControl2_GotFocus(sender As Object, e As EventArgs) Handles TabControl2.GotFocus
        On Error Resume Next
        'TabControl2.BringToFront('289)
        TabControl2.Height = (289)
        'TabControl1.SendToBack()

    End Sub
    'Private Sub ListViewBible_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListViewBible.SelectedIndexChanged, ListViewBible.Click
    '    Try
    '        'show formatted scripture in display
    '        Me.ListBoxMain.Items.Clear()
    '        'prevObjSlide.song(0) = ListBoxBibles.SelectedItem.ToString
    '        'Me.ListBoxMain.Items.AddRange(wrap(ListBoxBibles.SelectedItem.ToString, 40))
    '        prevObjSlide.bibleVerse = ListViewBible.SelectedIndices(0)

    '        prevObjSlide.slideIsScripture = True
    '        prevObjSlide.scriptureStateNavDriMain(2) = True 'save state


    '        Me.ListBoxMain.Items.AddRange(wrapAndSplit(ListViewBible.SelectedItems.Item(0).SubItems(0).Text, objSlide.settings.Item("charPerLine"), objSlide.settings.Item("maxLine")))
    '        'TODO: error if empty string 
    '    Catch ex As Exception
    '        'can cause error

    '        Me.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
    '    Finally
    '        'can cause error
    '    End Try

    'End Sub

    Private Sub ListBoxBibles_DoubleClick(sender As Object, e As EventArgs) Handles ListBoxBibles.DoubleClick
        On Error Resume Next
        Call ListBoxBibles_SelectedIndexChanged(sender, e)

    End Sub
    Private Sub ListBoxBibles_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxBibles.SelectedIndexChanged
        Try


            'Auto Add it to service
            'saveService(True) 'TODO: fix
            'load it
            'update verse
            If Me.ListBoxVerse.Items.Count >= Me.ListBoxBibles.SelectedIndex Then Me.ListBoxVerse.SelectedIndex = Me.ListBoxBibles.SelectedIndex
            'show formatted scripture in display
            If Me.CheckBoxLive.Checked = True Then 'live and preview
                'objSlide.slideIsScripture = True
                prevObjSlide.scriptureStateNavDriMain(2) = True 'save state
                objSlide.bibleVerse = (ListBoxBibles.SelectedIndex + 1) 'this is serious business NOTE: it must come before any listboxmain changes
                Me.ListBoxMain.Items.Clear()
                Me.ListBoxMain.Items.AddRange(wrapAndSplit(ListBoxBibles.SelectedItem.ToString, CInt(objSlide.settings.Item("charPerLine")), CInt(objSlide.settings.Item("maxLine"))))
                If Me.ListBoxMain.Items.Count > 1 Then
                    Me.ListBoxMain.SelectedIndex = 0 'select the verse
                End If


                'also harmonize with rpreview
                prevObjSlide.scriptureStateNavDriMain(1) = True 'save state
                prevObjSlide.bibleVerse = (ListBoxBibles.SelectedIndex + 1)
                Me.ListBoxDriver.Items.Clear()
                Me.ListBoxDriver.Items.AddRange(wrapAndSplit(ListBoxBibles.SelectedItem.ToString, CInt(objSlide.settings.Item("charPerLine")), CInt(objSlide.settings.Item("maxLine"))))
                If Me.ListBoxDriver.Items.Count > 1 Then
                    Me.ListBoxDriver.SelectedIndex = 0 'select the verse
                End If

            Else 'preview only

                ' prevObjSlide.slideIsScripture = True
                prevObjSlide.scriptureStateNavDriMain(1) = True 'save state
                prevObjSlide.prevBibleBook = prevObjSlide.bibleBook
                prevObjSlide.prevBibleChapter = prevObjSlide.bibleChapter
                prevObjSlide.prevBibleVerse = prevObjSlide.bibleVerse
                prevObjSlide.prevBibleVersion = prevObjSlide.bibleVersion

                prevObjSlide.bibleVerse = (ListBoxBibles.SelectedIndex + 1)
                Me.ListBoxDriver.Items.Clear()
                Me.ListBoxDriver.Items.AddRange(wrapAndSplit(ListBoxBibles.SelectedItem.ToString, CInt(objSlide.settings.Item("charPerLine")), CInt(objSlide.settings.Item("maxLine"))))
                If Me.ListBoxDriver.Items.Count > 1 Then
                    Me.ListBoxDriver.SelectedIndex = 0 'select the verse
                End If


            End If



            refreshPrevSlides() 'instant preview



        Catch ex As Exception
            'can cause error

            Me.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub
    Function wrapAndSplit(dstr As String, nochar As Integer, maxLines As Integer) As String()
        Try
            Dim lenStr, pos1, pos2, nolines, wordsPerLine, iCountW, iCountL As Integer
            Dim iParagraphs As Integer

            'Dim line() As String
            Dim words As String()
            Dim currWord, nexWord As String
            lenStr = dstr.Length
            'max x chars
            If (lenStr Mod nochar) = 0 Then
                nolines = (lenStr \ nochar)
            Else
                nolines = (lenStr \ nochar) + 1
            End If
            'Handle Error if empty word
            If dstr Is Nothing Or dstr = "" Then
                Return {""}
            End If
            words = dstr.Split(" ")
            If (words.Length Mod nolines) = 0 Then
                wordsPerLine = words.Length \ nolines 'no remainder
            Else
                wordsPerLine = (words.Length \ nolines) + 1
            End If

            'Now adjust no of lines to fit perfectly (IMPORTANT!)
            If (words.Length Mod wordsPerLine) = 0 Then
                nolines = words.Length \ wordsPerLine
            Else
                nolines = (words.Length \ wordsPerLine) + 1
            End If

            Dim line(0 To nolines - 1) As String 'Dim(3).lenght=4 bad   0 to 3 good
            'NO! Dont do this ---->try if more words can be crammed in
            iCountL = 0
            iCountW = 0
            Do While (iCountL <= line.Length - 1)

                nexWord = ""
                Do While (iCountW <= words.Length - 1) And ((iCountW - wordsPerLine * iCountL) <= (wordsPerLine - 1)) Or iCountW > 1000  'Note: wordsPerLine-1 bcos of array zero-index
                    line(iCountL) = line(iCountL) & " " & words(iCountW)
                    'DONT DO THIS-------> nexWord = (line(iCountL) & " " & words(iCountW + 1))
                    iCountW = iCountW + 1
                Loop
                iCountL = iCountL + 1
            Loop


            'now split lines int paragraphs
            iCountL = line.Length
            If iCountL > maxLines Then
                If (iCountL Mod maxLines) = 0 Then
                    iParagraphs = (iCountL \ maxLines)
                Else
                    iParagraphs = (iCountL \ maxLines) + 1
                End If


                Dim iStart, iCount, iStop As Integer
                Dim tmpLines(0 To iCountL + iParagraphs - 1 - 1) As String  'one space for 2 paragraphs, x spaces for x+1 paragraphs
                iStart = 0
                iStop = maxLines
                For j = 0 To iParagraphs - 1
                    'check wether max arry lenght exceeded
                    If j > tmpLines.Count Or iCount + 1 > tmpLines.Count Then Exit For
                    For i = iStart To iStop - 1
                        If i - j > line.Length - 1 Then Exit For
                        tmpLines(i) = line(i - j)
                        iCount = i
                    Next
                    If Not (iCount >= tmpLines.Length - 1) Then tmpLines(iCount) = tmpLines(iCount) & " ..." 'more to come except for last line
                    If Not (iStart = 0) Then tmpLines(iStart) = " ..." & tmpLines(iStart) 'there's stuff before this, except for first line

                    If Not (iCount + 1 >= tmpLines.Length - 1) Then tmpLines(iCount + 1) = "" 'paragraph space except last line
                    iStart = iCount + 2
                    iStop = iStart + maxLines
                Next

                'TODO: Now start examining  the text in each line
                'if there is a , . : or ;
                'break the line at that point and readjust accordingly


                line = tmpLines
                'ReDim tmpLines()
            End If

            Return line
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Function
    Function wrapAndSplitDBSongWithTags(dstr As String, nochar As Integer, maxLines As Integer) As String()
        Try
            'TODO: remove temp code
            '' ''Dim s() As Char = {}
            '' ''Dim tmpS As String() = dstr.Split(s)
            '' ''dstr = ""
            '' ''For i = 0 To tmpS.Length - 1
            '' ''    dstr = dstr & "  " & tmpS(i) & AscW(tmpS(i))
            '' ''Next
            '' ''FormEditor.RichTextBox1.Text = (dstr)
            '' ''FormEditor.Show()
            '' ''Return {"", ""}
            'end temp
            Dim lenStr, pos1, pos2, nolines, wordsPerLine, iCountW, iCountL, actualiCountL As Integer
            Dim iParagraphs As Integer

            'Dim line() As String
            Dim words As String()
            Dim currWord, nexWord As String
            lenStr = dstr.Length
            'max x chars
            If (lenStr Mod nochar) = 0 Then
                nolines = (lenStr \ nochar)
            Else
                nolines = (lenStr \ nochar) + 1
            End If
            'Handle Error if empty word
            If dstr Is Nothing Or dstr = "" Then
                Return {""}
            End If
            Dim sc() As Char = {}
            words = dstr.Split(sc)
            If (words.Length Mod nolines) = 0 Then
                wordsPerLine = words.Length \ nolines 'no remainder
            Else
                wordsPerLine = (words.Length \ nolines) + 1
            End If

            'Now adjust no of lines to fit perfectly (IMPORTANT!)
            If (words.Length Mod wordsPerLine) = 0 Then
                nolines = words.Length \ wordsPerLine
            Else
                nolines = (words.Length \ wordsPerLine) + 1
            End If

            Dim line(0 To nolines * 3 - 1) As String 'Three times the required space
            'NO! Dont do this ---->try if more words can be crammed in
            actualiCountL = 0
            iCountL = 0
            iCountW = 0
            Do While (iCountL <= line.Length - 1)

                nexWord = ""
                Do While (iCountW <= words.Length - 1) And ((iCountW - wordsPerLine * iCountL) <= (wordsPerLine - 1)) Or iCountW > 1000  'Note: wordsPerLine-1 bcos of array zero-index
                    'TODO: wordsperLine not working
                    'Important: This can also be used to break at ., ;, :, 
                    'break when we encounter "["
                    If Val(words(iCountW)) > 0 Or words(iCountW).Contains("[") Then
                        line(iCountL) = words(iCountW)
                        iCountW = iCountW + 1
                        Exit Do 'force next line
                    ElseIf words(iCountW).Contains(".") Or words(iCountW).Contains(";") Or words(iCountW).Contains(";") Then
                        line(iCountL) = line(iCountL) & " " & words(iCountW) ' add the word and go tonext line
                        iCountW = iCountW + 1
                        Exit Do 'force next line
                    Else
                        line(iCountL) = line(iCountL) & " " & words(iCountW)
                        iCountW = iCountW + 1
                    End If
                    'DONT DO THIS-------> nexWord = (line(iCountL) & " " & words(iCountW + 1))

                Loop
                iCountL = iCountL + 1
                If iCountW < words.Length - 1 Then actualiCountL = iCountL + 1
            Loop

            ReDim Preserve line(0 To actualiCountL - 1)
            iCountL = actualiCountL
            'now split lines int paragraphs
            iCountL = line.Length
            If iCountL > maxLines Then
                If (iCountL Mod maxLines) = 0 Then
                    iParagraphs = (iCountL \ maxLines)
                Else
                    iParagraphs = (iCountL \ maxLines) + 1
                End If


                Dim iStart, iCount, iStop As Integer
                Dim tmpLines(0 To iCountL + iParagraphs - 1 - 1) As String  'one space for 2 paragraphs, x spaces for x+1 paragraphs
                iStart = 0
                iStop = maxLines
                For j = 0 To iParagraphs - 1
                    'check wether max arry lenght exceeded
                    If j > tmpLines.Count Or iCount + 1 > tmpLines.Count Then Exit For
                    For i = iStart To iStop - 1
                        If i - j > line.Length - 1 Then Exit For
                        tmpLines(i) = line(i - j)
                        iCount = i
                    Next

                    If Not (iCount + 1 >= tmpLines.Length - 1) Then tmpLines(iCount + 1) = "" 'paragraph space except last line
                    iStart = iCount + 2
                    iStop = iStart + maxLines
                Next

                'TODO: Now start examining  the text in each line
                'if there is a , . : or ;
                'break the line at that point and readjust accordingly


                line = tmpLines
                'ReDim tmpLines()
            End If

            Return line



        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Function
    Function prepToSSend(txtmessage As String) As String
        Dim str As String()
        Dim dStr As String = ""
        str = txtmessage.Split({vbCr}, StringSplitOptions.None)
        For Each s As String In str
            dStr = dStr & s.Replace(vbLf, "") & "\"
        Next
        Return dStr
    End Function
    Function wrap(dstr As String, nochar As Integer) As String()
        Try
            Dim lenStr, pos1, pos2, nolines, wordsPerLine, iCountW, iCountL As Integer
            'Dim line() As String
            Dim words As String()
            Dim currWord, nexWord As String
            lenStr = dstr.Length
            'max x chars
            If (lenStr Mod nochar) = 0 Then
                nolines = Math.Truncate((lenStr / nochar))
            Else
                nolines = Math.Truncate((lenStr / nochar)) + 1
            End If
            words = dstr.Split(" ")  'TODO: Err idf empty word

            wordsPerLine = words.Length / nolines
            Dim line(nolines - 1) As String 'Dim(3).lenght=4   0 to 3
            'try if more words can be crammed in
            iCountL = 0
            iCountW = 0
            Do While (iCountL <= line.Length - 1)

                nexWord = ""
                Do While (iCountW <= words.Length - 1) And (iCountW - wordsPerLine * iCountL <= wordsPerLine) Or iCountW > 1000
                    line(iCountL) = line(iCountL) & " " & words(iCountW)
                    'nexWord = (line(iCountL) & " " & words(iCountW + 1))
                    iCountW = iCountW + 1
                Loop
                iCountL = iCountL + 1
            Loop

            Return line
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Function
    Private Sub ListBoxBibleVersions_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxBibleVersions.SelectedIndexChanged
        Dim tmpVersion As String = ""
        Try

            tmpVersion = prevObjSlide.bibleVersion
            prevObjSlide.bibleVersion = ListBoxBibleVersions.SelectedItem.ToString
            Dim dIndex As Integer = 0
            If Me.ListBoxBibles.SelectedItems.Count > 0 Then dIndex = Me.ListBoxBibles.SelectedIndex 'note it
            loadScriptures()

            If Me.ListBoxBibles.Items.Count > dIndex Then
                Me.ListBoxBibles.SelectedIndex = dIndex 'select the verse
            End If
            'restore bibleverse
            If ListBoxBibles.Items.Count > 0 Then ListBoxBibles.SelectedIndex = CInt(prevObjSlide.bibleVerse) - 1
        Catch ex As Exception
            'can cause error
            tmpVersion = prevObjSlide.bibleVersion 'recover from error
            Me.TextBoxSearch.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().ToString)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ButtonFont_Click(sender As Object, e As EventArgs) Handles ButtonFont.Click
        On Error Resume Next
        If FontDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Me.TextBoxFontFamily.Text = FontDialog1.Font.FontFamily.Name
            Me.TextBoxFontSize.Text = FontDialog1.Font.Size.ToString
        End If

    End Sub

    Private Sub ListBoxService_DragDrop(sender As Object, e As DragEventArgs) Handles ListBoxService.DragDrop
        'Try
        '    If (e.Data.GetDataPresent(DataFormats.StringFormat)) Then

        '        Dim str As String = CStr(e.Data.GetData(DataFormats.StringFormat))

        '        ListBoxService.Items.Add(str)
        '    End If
        'Catch ex As Exception
        '    'can cause error
        '    Me.TextBoxStatus.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        '    logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        'Finally
        '    'can cause error
        'End Try
    End Sub

    Private Sub ListBoxService_DragOver(sender As Object, e As DragEventArgs) Handles ListBoxService.DragOver
        'e.Effect = DragDropEffects.All

    End Sub

    Private Sub ListBoxService_MouseDown(sender As Object, e As MouseEventArgs) Handles ListBoxService.MouseDown
        'Try
        '    If ListBoxSearch.Items.Count = 0 Then Return

        '    Dim index As Integer = ListBoxService.IndexFromPoint(e.X, e.Y)
        '    Dim s As String = ListBoxService.Items(index).ToString()
        '    Dim dde1 As DragDropEffects = DoDragDrop(s, DragDropEffects.All)

        '    If (dde1 = DragDropEffects.All) Then

        '        ListBoxService.Items.RemoveAt(ListBoxService.IndexFromPoint(e.X, e.Y))
        '    End If
        'Catch ex As Exception
        '    'can cause error
        '    Me.TextBoxStatus.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        '    logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        'Finally
        '    'can cause error
        'End Try
    End Sub


    Private Sub ListBoxService_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxService.SelectedIndexChanged
        'todo: fix to avoid file access error
        'load from file
        prevObjSlide.songfileName = USER_DIRECTORY & "\service\" & ListBoxService.SelectedItem.ToString & ".txt"


        loadService(prevObjSlide.songfileName)


    End Sub



#End Region

    '----------------------------------------------------------------

    '                Network Communicaion for Multiuser

    '-----------------------------------------------------------------
#Region "Network Comm"








#Region "Functions"

    Public Shared Function GetIPAddress() As String
        Try
            Dim oAddr As System.Net.IPAddress
            Dim sAddr As String
            With System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName())
                oAddr = New System.Net.IPAddress(.AddressList(0).Address)
                sAddr = oAddr.ToString
            End With
            GetIPAddress = sAddr
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try

    End Function

    Private Sub Listening()
        Try
            Listener.Start()
            Listener1.Start()
        Catch ex As Exception 'TODO: Fix messaging error,  refused to work
            'Throw ex
            logError(ex.ToString)
        Finally
            'can cause error
        End Try

    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Show()
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        Try
            If cmbAddress.Text = "" Then 'txtName.Text = "" Or 
                MessageBox.Show("MULTIUSER: All Fields must be Filled", "Error Sending Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                'btnImage.PerformClick()
                Try
                    Client = New TcpClient(cmbAddress.Text, 65535)

                    Dim Writer As New StreamWriter(Client.GetStream())
                    Writer.Write(prepToSSend(txtmessage.Text)) 'txtName.Text & " Says:  " & 
                    Writer.Flush()
                    RichTextBox1.Text += "Local: " + (txtmessage.Text) + vbCrLf
                    txtmessage.Text = ""
                Catch ex As Exception
                    Console.WriteLine(ex)
                    Dim Errorresult As String = ex.Message
                    MessageBox.Show(Errorresult & vbCrLf & vbCrLf & "Please Review Client Address", "Error Sending Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            End If
        Catch ex As Exception
            'can cause error
            MsgBox("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub txtmessage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmessage.TextChanged
        Try
            If txtmessage.Text <> "" Then
                btnClear.Enabled = True
                btnSend.Enabled = True
            Else
                btnClear.Enabled = False
                btnSend.Enabled = False
            End If
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub


    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
        Try
            If cmbAddress.Text.Length < 4 Then
                MessageBox.Show("Please Enter a Valid Address", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else
                btnConnect.Text = "Connecting"
                Dim pingresult As String = "False"
                Try
                    pingresult = My.Computer.Network.Ping(cmbAddress.Text)
                Catch ex As Exception
                End Try
                If pingresult = "True" Then
                    btnConnect.Text = "Connected"
                    'TODO:           decouple UI ()
                    MDIParentMain.PanelConnect.BackColor = Color.FromArgb(120, 192, 255, 192) 'greenish
                    prevObjSlide.NetConneced = True
                Else
                    btnConnect.Text = "Disconnected"
                    MDIParentMain.PanelConnect.BackColor = Color.FromArgb(120, 255, 192, 192) 'reddish
                    prevObjSlide.NetConneced = False
                End If
            End If
        Catch ex As Exception
            'can cause error
            MsgBox("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub cmbAddress_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        btnConnect.Text = "Connect..."
    End Sub


    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtmessage.Text = ""
    End Sub
    Public Function StringToBitmap(ByVal sImageData As String) As Bitmap
        Try
            Dim ms As New MemoryStream(Convert.FromBase64String(sImageData))
            Dim bmp As Bitmap = Bitmap.FromStream(ms)
            Return bmp
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub ButtonClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ButtonClear.Click
        cmbAddress.Text = ""
        txtName.Text = ""
        txtmessage.Text = ""
        RichTextBox1.Text = ""
    End Sub

    Private Sub mnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        RichTextBox1.Cut()
    End Sub

    Private Sub mnuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        RichTextBox1.Copy()
    End Sub

    Private Sub mnuSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        On Error Resume Next
        RichTextBox1.SelectAll()
    End Sub

    Private Sub RichTextBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles RichTextBox1.MouseClick
        On Error Resume Next
        If e.Button = Windows.Forms.MouseButtons.Right Then
            cmsEditing.Show(e.Location)
        End If
    End Sub

    Private Sub RichTextBox1_MouseDown(sender As Object, e As MouseEventArgs) Handles RichTextBox1.MouseDown
        On Error Resume Next
        If e.Button = Windows.Forms.MouseButtons.Right Then
            cmsEditing.Show(e.Location)
        End If
    End Sub

    Private Sub RichTextBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseMove
        On Error Resume Next
        If RichTextBox1.SelectionLength > 0 Then

            cmsmCut.Enabled = True
            cmsmCopy.Enabled = True
        Else

            cmsmCut.Enabled = False
            cmsmCopy.Enabled = False
        End If
    End Sub

#End Region

#Region "Settings"

    Private Sub LabelForeColor_Click(sender As Object, e As EventArgs) Handles LabelForeColor.Click
        On Error Resume Next
        If clrFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            LabelForeColor.BackColor = clrFont.Color
        End If
    End Sub
    Private Sub LabelBacKColor_Click(sender As Object, e As EventArgs) Handles LabelBackColor.Click
        On Error Resume Next
        If clrFont.ShowDialog() = Windows.Forms.DialogResult.OK Then
            LabelBackColor.BackColor = clrFont.Color
        End If
    End Sub
    Private Sub ButtonAddIP_Click(sender As Object, e As EventArgs) Handles ButtonAddIP.Click
        On Error Resume Next
        Me.cmbAddress.Items.Add(txtIP.Text)
    End Sub

    Private Sub ButtonApplyFormatSettings_Click(sender As Object, e As EventArgs) Handles ButtonApplyFormatSettings.Click
        Try
            Dim tmpSettings As Dictionary(Of String, String)
            tmpSettings = prevObjSlide.getSettings()
            '    tmp.Add("mode", "driver")
            'tmp.Add("fontSize", "40")
            'tmp.Add("fontFamily", "Arial")
            'tmp.Add("max_Char", "160")
            'tmp.Add("charPerLine", "40")
            'tmp.Add("maxLine", "4")
            'tmp.Add("foreColor", "yellow")
            'tmp.Add("shadowColor", "black")
            'tmp.Add("backgroundImage", "")
            'tmp.Add("position", "full")
            'tmp.Add("resolutionW", "1366")
            'tmp.Add("resolutionH", "768")
            'tmp.Add("ip", "127.0.0.1")
            'tmp.Add("font", "Arial, 50.25pt, style=Bold") 'TODO: store FONT like this
            'tmp.Add("color", "255, 255 ,0")

            'tmp.Add("displayOption", "1")
            'tmp.Add("resolutionProjectorW", "1366")
            ' tmp.Add("resolutionProjectorH", "768")

            tmpSettings.Item("fontSize") = (Me.TextBoxFontSize.Text)
            tmpSettings.Item("fontFamily") = (Me.TextBoxFontFamily.Text)
            tmpSettings.Item("charPerLine") = (Me.TextBoxMaxCharsPerLine.Text)
            tmpSettings.Item("maxLine") = (Me.TextBoxMaxLines.Text)
            tmpSettings.Item("foreColor") = (Me.LabelForeColor.BackColor.ToArgb)
            tmpSettings.Item("shadowColor") = (Me.LabelBackColor.BackColor.ToArgb)
            If RadioButtonFull.Checked = True Then
                tmpSettings.Item("position") = RadioButtonFull.Text
            Else
                tmpSettings.Item("position") = RadioButtonLowerThird.Text
            End If

            tmpSettings.Item("resolutionW") = (Me.TextBoxResolutionW.Text)
            tmpSettings.Item("resolutionH") = (Me.TextBoxResolutionH.Text)
            'Add more
            tmpSettings.Item("ip") = cmbAddress.Text.ToString
            tmpSettings.Item("font") = FontDialog1.Font.ToString
            tmpSettings.Item("color") = LabelBackColor.BackColor.ToArgb.ToString

            tmpSettings.Item("displayOption") = comboboxdisplayOption.SelectedIndex + 1
            tmpSettings.Item("resolutionProjectorW") = Me.TextBoxProjectorResolutionW.Text
            tmpSettings.Item("resolutionProjectorH") = Me.TextBoxProjectorResolutionH.Text


            prevObjSlide.settings = tmpSettings
            refreshPrevSlides()
            saveSettings(tmpSettings)
            MsgBox("Settings applied sucessfully!")
        Catch ex As Exception
            'can cause error
            MsgBox("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub
    Sub saveSettings(tmpSettings As Dictionary(Of String, String))
        '    tmp.Add("mode", "driver")
        'tmp.Add("fontSize", "40")
        'tmp.Add("fontFamily", "Arial")
        'tmp.Add("max_Char", "160")
        'tmp.Add("charPerLine", "40")
        'tmp.Add("maxLine", "4")
        'tmp.Add("foreColor", "yellow")
        'tmp.Add("shadowColor", "black")
        'tmp.Add("backgroundImage", "")
        'tmp.Add("position", "full")
        'tmp.Add("resolutionW", "1366")
        'tmp.Add("resolutionH", "768")
        'tmp.Add("ip", "127.0.0.1")

        'tmp.Add("displayOption", "1")
        'tmp.Add("resolutionProjectorW", "1366")
        ' tmp.Add("resolutionProjectorH", "768")

        'tmp.Add("displayOption", "1")
        'tmp.Add("resolutionProjectorW", "1366")
        ' tmp.Add("resolutionProjectorH", "768")
        Try
            My.Settings.backgroundImage = tmpSettings.Item("backgroundImage") 'TODO
            My.Settings.charPerLine = tmpSettings.Item("charPerLine")
            My.Settings.fontFamily = tmpSettings.Item("fontFamily")
            My.Settings.fontSize = tmpSettings.Item("fontSize")
            My.Settings.foreColor = tmpSettings.Item("foreColor")
            My.Settings.ip = tmpSettings.Item("ip")
            My.Settings.max_Char = tmpSettings.Item("max_Char")
            My.Settings.maxLine = tmpSettings.Item("maxLine")
            My.Settings.mode = tmpSettings.Item("mode")
            My.Settings.position = tmpSettings.Item("position")
            'PC resolution
            My.Settings.ResolutionW = tmpSettings.Item("resolutionW")
            My.Settings.ResolutionH = tmpSettings.Item("resolutionH")

            My.Settings.shadowColor = tmpSettings.Item("shadowColor")

            My.Settings.displayOption = tmpSettings.Item("displayOption")
            My.Settings.resolutionProjectorW = tmpSettings.Item("resolutionProjectorW")
            My.Settings.resolutionProjectorH = tmpSettings.Item("resolutionProjectorH")

            'TODO: background image
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub
    Sub loadSettings() 'As Dictionary(Of String, String)
        Try
            Dim tmpSettings As New Dictionary(Of String, String)
            '    tmp.Add("mode", "driver")
            'tmp.Add("fontSize", "40")
            'tmp.Add("fontFamily", "Arial")
            'tmp.Add("max_Char", "160")
            'tmp.Add("charPerLine", "40")
            'tmp.Add("maxLine", "4")
            'tmp.Add("foreColor", "yellow")
            'tmp.Add("shadowColor", "black")
            'tmp.Add("backgroundImage", "")
            'tmp.Add("position", "full")
            'tmp.Add("resolutionW", "1366")
            'tmp.Add("resolutionH", "768")
            'tmp.Add("ip", "127.0.0.1")

            'tmp.Add("displayOption", "1")
            'tmp.Add("resolutionProjectorW", "1366")
            ' tmp.Add("resolutionProjectorH", "768")
            tmpSettings = prevObjSlide.settings
            tmpSettings.Item("backgroundImage") = My.Settings.backgroundImage
            tmpSettings.Item("charPerLine") = My.Settings.charPerLine
            tmpSettings.Item("fontFamily") = My.Settings.fontFamily
            tmpSettings.Item("fontSize") = My.Settings.fontSize
            tmpSettings.Item("foreColor") = My.Settings.foreColor
            tmpSettings.Item("ip") = My.Settings.ip
            tmpSettings.Item("max_Char") = My.Settings.max_Char
            tmpSettings.Item("maxLine") = My.Settings.maxLine
            tmpSettings.Item("mode") = My.Settings.mode
            tmpSettings.Item("position") = My.Settings.position
            tmpSettings.Item("resolutionW") = My.Settings.ResolutionW
            tmpSettings.Item("resolutionH") = My.Settings.ResolutionH
            tmpSettings.Item("shadowColor") = My.Settings.shadowColor

            tmpSettings.Item("displayOption") = My.Settings.displayOption
            tmpSettings.Item("resolutionProjectorW") = My.Settings.resolutionProjectorW
            tmpSettings.Item("resolutionProjectorH") = My.Settings.resolutionProjectorH

            'TODO: auto load (Not working yet: error due to change in dictionary preventing enumeration
            ' Iterate through a dictionary
            'For Each mykey As String In prevObjSlide.settings.Keys  '.Values
            'prevObjSlide.settings.Item(mykey) = My.Settings.Item(mykey)

            'Next


            prevObjSlide.settings = tmpSettings
            objSlide.settings = tmpSettings

            'now load them into UI
            loadSettingsIntoUI()

        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error loading settings!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured while loading settings!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub
    Sub loadSettingsIntoUI()
        Try
            Dim tmpSettings As New Dictionary(Of String, String)
            tmpSettings = prevObjSlide.settings

            Me.TextBoxFontSize.Text = tmpSettings.Item("fontSize")
            Me.TextBoxFontFamily.Text = tmpSettings.Item("fontFamily")
            Me.TextBoxMaxCharsPerLine.Text = tmpSettings.Item("charPerLine")
            Me.TextBoxMaxLines.Text = tmpSettings.Item("maxLine")
            Me.LabelForeColor.BackColor = Color.FromArgb(Val(tmpSettings.Item("foreColor")))
            Me.LabelBackColor.BackColor = Color.FromArgb(Val(tmpSettings.Item("shadowColor")))
            If tmpSettings.Item("position").ToUpper = (RadioButtonFull.Text.ToUpper) Then
                RadioButtonFull.Checked = True
                RadioButtonLowerThird.Checked = False
            Else
                RadioButtonFull.Checked = False
                RadioButtonLowerThird.Checked = True
            End If

            Me.TextBoxResolutionW.Text = tmpSettings.Item("resolutionW")
            Me.TextBoxResolutionH.Text = tmpSettings.Item("resolutionH")
            'Add more
            cmbAddress.Text = tmpSettings.Item("ip")
            'FontDialog1.Font = New Font(tmpSettings.Item("font")) 'Error prone
            'LabelBackColor.BackColor.ToArgb.ToString=tmpSettings.Item("color") 'Error pronr

            comboboxdisplayOption.SelectedIndex = CInt(tmpSettings.Item("displayOption")) - 1
            Me.TextBoxProjectorResolutionW.Text = tmpSettings.Item("resolutionProjectorW")
            Me.TextBoxProjectorResolutionH.Text = tmpSettings.Item("resolutionProjectorH")
        Catch ex As Exception
            'can cause error
            Throw ex
        Finally
            'can cause error
        End Try
    End Sub
    'Cool.     'We have a  one-liner that has some limitations
    Sub loadDefaultSettings()
        Try
            Dim mockObj As New ClassSlide()
            prevObjSlide.settings = mockObj.settings
            loadSettingsIntoUI()
            mockObj = Nothing
        Catch ex As Exception
            Throw ex
        Finally
            'can cause error
        End Try
    End Sub

#End Region
#Region "Test"
    Private Sub ButtonTest_Click(sender As Object, e As EventArgs) Handles ButtonTest.Click
        Me.txtmessage.Text = "Test message sent \ Confirm receipt of message"
        btnSend.PerformClick()
    End Sub
#End Region



#End Region


    Private Sub ListBoxSearchBible_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxSearchbible.SelectedIndexChanged
        Try
            Dim i As Integer = listboxsearchbible.selectedindex
 
            'save state
            prevObjSlide.scriptureStateNavDriMain(1) = True 'save state
            prevObjSlide.prevBibleBook = prevObjSlide.bookFromRef(prevObjSlide.searchResultsSong(i).ref)
            prevObjSlide.prevBibleChapter = prevObjSlide.chapterFromRef(prevObjSlide.searchResultsSong(i).ref)
            prevObjSlide.prevBibleVerse = prevObjSlide.verseFromRef(prevObjSlide.searchResultsSong(i).ref)
            'update
            prevObjSlide.bibleBook = prevObjSlide.prevBibleBook
            prevObjSlide.bibleChapter = prevObjSlide.prevBibleChapter
            prevObjSlide.bibleVerse = prevObjSlide.prevBibleVerse
            'NOTE: the order is important because listboxdriver_selectedindexchanged is fired
            'refereshslide will be fired and ref will sync with passage
            'otherwise they will be out of sync
            'order 1. update prevObjSlide.bibleBook etc 2. ListBoxDriver.Items.Add
            ListBoxDriver.Items.Clear()
            ListBoxDriver.Items.Add(prevObjSlide.searchResultsSong(i).passage)
            If ListBoxDriver.Items.Count > 0 Then ListBoxDriver.SelectedIndex = 0

            'Quietly Requery bible  to keep things in sync
            Try
                ListBoxBook.SelectedIndex = Val(prevObjSlide.bookNumFromRef(prevObjSlide.searchResultsSong(i).ref)) - 1 'make sure the exact book is selected
                ListBoxChapter.SelectedIndex = Val(prevObjSlide.chapterFromRef(prevObjSlide.searchResultsSong(i).ref)) - 1 'make sure the exact chapter is selected
                ListBoxVerse.SelectedIndex = Val(prevObjSlide.verseFromRef(prevObjSlide.searchResultsSong(i).ref)) - 1 'make sure the exact verse is selected
                loadScriptures()
                Me.TabControl2.SelectTab("TabPageBibles") 'show the bible
                ListBoxBibles.Enabled = True
                ListBoxBibles.SelectedIndex = Val(prevObjSlide.verseFromRef(prevObjSlide.searchResultsSong(i).ref)) - 1 'make sure the exact verse is selected
            Catch ex1 As Exception
                ListBoxBibles.Items.Clear()
            End Try
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub
    Private Sub ListBoxSearch_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxSearch.SelectedIndexChanged
        Try
            prevObjSlide.songfileName = USER_DIRECTORY & "\lyrics\" & ListBoxSearch.SelectedItems.Item(0).ToString & ".txt"

            prevObjSlide.scriptureStateNavDriMain(1) = False 'save state
            ListBoxDriver.Items.Clear()
            ListBoxDriver.Items.AddRange(loadSong(prevObjSlide.songfileName))


        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        'fillcombo(Me.ComboBoxBook, book)
        Me.ListBoxBook.Visible = True
        FormBibleScriptureSelector.Show()

        'UserControl for GUI fgen and Testcase
        ''Psalm one hundred and fifty highest chapter
        'Isaiah y sixty six chapters second highest chapter
        'psalm 119:17six highest verse
        'psalm 7: 89 next highest verse
    End Sub




    Private Sub all_picture_boxes_clicked(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Try
            Dim pic As PictureBox = DirectCast(sender, PictureBox)
            'MsgBox("pic clicked " & pic.Name)
            'setBackgroundFromSrc(PictureBoxPreview, pic, "scale")


            prevObjSlide.backgrounImageFileName = pic.Tag 'TODO: .tag
            prevObjSlide.backgroundImage = prevObjSlide.getBackgroundImage

            prevObjSlide.previewImageFileName = pic.ImageLocation

            ' ''generate the thumbnails for preview
            ' ''TODO: use correct dimention
            ''Dim file As String = (USER_DIRECTORY & "\images\preview\image.jpg")
            ''counter = counter + 1
            ' ''TODO: Fix generic GDI+ error
            ' ''Maybe it happens when image is in use
            ''Me.PictureBoxPreview.Image = Nothing   'possible fix
            ''Try
            ''    wm.GetThumbnailFromImageFilenameWithDim(pic.Tag, prevObjSlide.settings("resolutionW").ToString, prevObjSlide.settings("resolutionH").ToString).Save(file)
            ''    prevObjSlide.previewImageFileName = file
            ''Catch
            ''End Try


            refreshPrevSlides()
            refreshPrevSlides()
        Catch ex As Exception
            'can cause error
            MsgBox("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ButtonImportImage_Click(sender As Object, e As EventArgs) Handles ButtonImportImage.Click
        Try
            addPictures(True)
        Catch ex As Exception
            'can cause error
            MsgBox("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub


    Private Sub CheckBoxScaled_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxScaled.CheckedChanged
        On Error Resume Next
        If CheckBoxScaled.Checked Then
            FormLive.PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        Else

            FormLive.PictureBox1.SizeMode = PictureBoxSizeMode.Normal
        End If
    End Sub



    Private Sub CheckBoxTransparent_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxTransparent.CheckedChanged
        On Error Resume Next
        If CheckBoxTransparent.Checked = True Then
            FormLive.Opacity = 0.8
        Else
            FormLive.Opacity = 1
        End If
    End Sub

    Private Sub ListBoxBook_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxBook.SelectedIndexChanged
        Try
            ListBoxBibles.Enabled = False 'hold up
            ListBoxChapter.Enabled = True
            ListBoxVerse.Enabled = False

            prevObjSlide.bibleBook = ListBoxBook.SelectedItem.ToString
            'load listboxes with chapter nos
            'Me.ListBoxChapter.Items.Clear()
            'Clear passage we dont need missleading stuff
            Me.ListBoxBibles.Enabled = False '  Me.ListBoxBibles.Items.Clear()    'hold off
            With prevObjSlide
                Dim dMax As Integer = .getMaxChapter(ListBoxBook.SelectedIndex + 1)
                Dim tmpNum(0 To dMax - 1) As String
                For i = 0 To dMax - 1
                    tmpNum(i) = (i + 1).ToString
                Next

                ListBoxChapter.Items.AddRange(tmpNum)
                'prevObjSlide.book2Num()
                tmpNum = Nothing
            End With

            prevObjSlide.bibleBook = ListBoxBook.SelectedItem.ToString
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ListBoxChapter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxChapter.SelectedIndexChanged
        Try
            'disable, we don want user goofs
            ListBoxChapter.Enabled = False
            ListBoxVerse.Enabled = True
            Me.ListBoxBibles.Enabled = False

            'Clear passage we dont need missleading stuff
            'Me.ListBoxBibles.Items.Clear()

            prevObjSlide.bibleChapter = ListBoxChapter.SelectedItem.ToString
            'load listboxes with verse numbers

            'search db for
            'prevObjSlide.getFromDBMaxVerses(prevObjSlide.bibleBook, (ListBoxChapter.SelectedIndex + 1).ToString, prevObjSlide.bibleVersion)

            Me.ListBoxVerse.Items.Clear()
            With prevObjSlide
                Dim dMax As Integer
                dMax = .getFromDBMaxVerses(.bibleBook, (ListBoxChapter.SelectedIndex + 1).ToString, .bibleVersion)

                Dim tmpNum(0 To dMax - 1) As String
                For i = 0 To dMax - 1
                    tmpNum(i) = (i + 1).ToString
                Next

                ListBoxVerse.Items.AddRange(tmpNum)
                'prevObjSlide.book2Num()
                tmpNum = Nothing

                'TODO: Now query database to get precise no of verses
                'select max(verse) where chp=chp and book=book

                'remove extra items

            End With
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ListBoxVerse_Click(sender As Object, e As EventArgs) Handles ListBoxVerse.Click
        Try
            ListBoxBook.Enabled = True
            ListBoxChapter.Enabled = True
            ListBoxVerse.Enabled = True
            Me.ListBoxBibles.Enabled = True
            prevObjSlide.bibleVerse = ListBoxVerse.SelectedItem.ToString
            loadScriptures()

            ListBoxBibles.SelectedIndex = ListBoxVerse.SelectedIndex
            ListBoxBibles.SelectedIndex = ListBoxVerse.SelectedIndex
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ListBoxVerse_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxVerse.SelectedIndexChanged
        Try
            prevObjSlide.bibleVerse = ListBoxVerse.SelectedItem.ToString
            ListBoxBibles.SelectedIndex = ListBoxVerse.SelectedIndex
            ListBoxBibles.SelectedIndex = ListBoxVerse.SelectedIndex
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub
    Private Sub ButtonDefault_Click(sender As Object, e As EventArgs) Handles ButtonDefault.Click
        Try
            prevObjSlide.settings = prevObjSlide.getSettings(True)   'Smart!
            loadSettingsIntoUI()

            MsgBox("Default settings loaded sucessfully")
            ButtonApplyFormatSettings.PerformClick()
        Catch ex As Exception
            'can cause error
            MsgBox("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub
    Function GetDataWhere(strSQL As String, lyricsParam As OleDbParameter, Optional tableName As String = "SONG") As DataSet
        Try
            Dim con As New OleDbConnection
            con = prevObjSlide.getConn(, True)
            con.Open()

            Dim cmd As New OleDbCommand(strSQL, con)
            cmd.Parameters.Add(lyricsParam)
            Dim myDA As OleDbDataAdapter = New OleDbDataAdapter(cmd)
            Dim myDataSet As DataSet = New DataSet()
            myDA.Fill(myDataSet, tableName)
            con.Close()
            Return myDataSet '   dgw.DataSource = myDataSet.Tables("Room").DefaultView       'all room
        Catch ex As Exception
            Throw ex
        End Try
    End Function
    Private Sub ButtonDBSongs_Click(sender As Object, e As EventArgs) Handles ButtonDBSongs.Click
        Try
            'Search db and load up song titles
            ''Method 2
            Dim cmdStr As String = "SELECT SONG.SONGID, SONG.TITLE_1, SONG.LYRICS FROM SONG "
            'cmdStr = cmdStr & "WHERE (((SONG.LYRICS) Like " & dblQuote & "New Commandment*" & dblQuote & "));"   'suprising problem
            'cmdStr = cmdStr & "WHERE (((SONG.TITLE_1) = " & dblQuote & "A New Commandment" & dblQuote & " ));" 'worked
            cmdStr = cmdStr & "WHERE (SONG.TITLE_1 like @LYRICS);"
            ''TIP: Problem with OLEDB and Access. canot use Like  in query 
            ''FIXED: use % wildcard instead of *
            Dim lyricsParam As New OleDbParameter("@LYRICS", "%" & Me.TextBoxSearch.Text & "%")
            Dim ds As New DataSet
            ds = GetDataWhere(cmdStr, lyricsParam)
            ListBoxSearchSongsDB.DataSource = ds

            With ListBoxSearchSongsDB
                .DataSource = ds.Tables("SONG").DefaultView  'TODO:
                .DataSource = ds.Tables(0)
                .ValueMember = "TITLE_1"
                .DisplayMember = "TITLE_1"
            End With

            ListBoxSearchSongsDB.BringToFront()

            If ListBoxSearchSongsDB.Items.Count = 0 Then
                'try again
                cmdStr = "SELECT SONG.SONGID, SONG.TITLE_1, SONG.LYRICS FROM SONG "
                cmdStr = cmdStr & "WHERE (SONG.TITLE_1 like @LYRICS);"
                lyricsParam = New OleDbParameter("@LYRICS", "%" & Me.TextBoxSearch.Text & "%")
                ds = GetDataWhere(cmdStr, lyricsParam)
                ListBoxSearchSongsDB.DataSource = ds.Tables("SONG").DefaultView
                ListBoxSearchSongsDB.BringToFront()
            End If

            If ListBoxSearchSongsDB.Items.Count = 0 Then MsgBox("Nothing was found!")
        Catch ex As Exception
            'can cause error
            MsgBox("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ListBoxSearchSongsDB_Click(sender As Object, e As EventArgs) Handles ListBoxSearchSongsDB.Click
        'query the specific song
        Try
            If ListBoxSearchSongsDB.SelectedItems.Count = 0 Then Return
            Dim dStr As String = prevObjSlide.getFromDBSong(Trim(ListBoxSearchSongsDB.SelectedValue.ToString))


            'prevObjSlide.songfileName =  USER_DIRECTORY & "\lyrics\" & "searchSong.txt"
            'My.Computer.FileSystem.WriteAllText(prevObjSlide.songfileName, String.Empty, False)
            With prevObjSlide.settings
                'break it up
                prevObjSlide.song = wrapAndSplitDBSongWithTags(dStr, .Item("charPerLine"), .Item("maxLine"))
                'My.Computer.FileSystem.WriteAllText(prevObjSlide.songfileName, arrayToStr(prevObjSlide.song), False)
            End With
            ListBoxDriver.Items.Clear()
            prevObjSlide.scriptureStateNavDriMain(1) = False 'save state
            ListBoxDriver.Items.AddRange(prevObjSlide.song) 'we already have the song load em


        Catch ex As Exception
            'can cause error
            MsgBox("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ButtonFilesSongs_Click(sender As Object, e As EventArgs) Handles ButtonSearchSongFiles.Click
        Try
            ListBoxSearch.Items.Clear()
            ListBoxSearch.Items.AddRange(searchFiles(TextBoxSearch.Text))
            ListBoxSearch.BringToFront()
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured while searching" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured while searching!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ButtonNewImage_Click(sender As Object, e As EventArgs) Handles ButtonNewImage.Click
        Try
            Dim fD As New OpenFileDialog
            fD.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            fD.Filter = "Image Files (*.jpg)|*.jpg"
            If Not (fD.ShowDialog = Windows.Forms.DialogResult.Cancel) Then
                If fD.FileName.Length > 0 Then
                    'TODO: Possible Error
                    My.Computer.FileSystem.CopyFile(fD.FileName, My.Computer.FileSystem.SpecialDirectories.MyDocuments & "\HeritageMediaSlidePlus\images\" & Path.GetFileName(fD.FileName), True)
                End If
            End If
            'Add em
            Me.addPictures(True)
        Catch ex As Exception
            'can cause error
            MsgBox("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub



    Private Sub ButtonBlank_Click(sender As Object, e As EventArgs) Handles ButtonBlank.Click
        Try
            ListBoxMain.Items.Clear()
            prevObjSlide.slideStr = ""
            objSlide.slideStr = ""
            'objSlide.slideIsScripture = False
            'prevObjSlide.slideIsScripture = False
            prevObjSlide.scriptureStateNavDriMain(2) = False 'save state
            objSlide.scriptureStateNavDriMain(1) = False
            ListBoxMain.Items.Clear()
            ListBoxDriver.Items.Clear()
            refreshSlides()
            'refreshPrevSlides()
        Catch ex As Exception
            'can cause error
            MsgBox("Error occured! Cannot blank out the slide" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub RadioButtonFull_Click(sender As Object, e As EventArgs) Handles RadioButtonFull.Click
        On Error Resume Next
        MsgBox("Remember that maximum characters per line will be adjusted automatically" & vbCrLf &
       "Font size will be adjusted automatically. Click apply")
        Me.TextBoxMaxCharsPerLine.Text = CStr(CDbl(Me.TextBoxMaxCharsPerLine.Text) \ 3)
        'Me.TextBoxFontSize.Text = CStr(CDbl(Me.TextBoxFontSize.Text) * (70 / 50)) '70=x*50-----> x=70/50
        Me.TextBoxMaxLines.Text = 7
    End Sub
    Private Sub RadioButtonLowerThird_Click(sender As Object, e As EventArgs) Handles RadioButtonLowerThird.Click
        On Error Resume Next
        If MsgBox("Remember that maximum characters per line will be set to be adjusted automatically" & vbCrLf &
               "Font size will be adjusted automatically. Click apply" & vbCrLf &
       "Do you want to use background Image for lower third?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            prevObjSlide.useImageForLowerThird = True
        End If
        Me.TextBoxMaxCharsPerLine.Text = CStr(CInt(Me.TextBoxMaxCharsPerLine.Text) * 3)
        'Me.TextBoxFontSize.Text = CStr(CInt(Me.TextBoxFontSize.Text) * (50 / 70)) '70=x*50-----> x=70/50
        Me.TextBoxMaxLines.Text = 4
    End Sub

    Private Sub ListBoxDriver_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxDriver.SelectedIndexChanged
        Try
            If eDirtyDriver = False Then
                'TODO: do some additional manipulations 1. ignore blank, 2. up arrow previous
                eDirtyDriver = True       'Flag-we are now in the middle of an auto highlight process
                Call ListBoxDriver_Click(sender, e)
                eDirtyDriver = False
            End If
        Catch ex As Exception
            'can cause error
            Me.TextBoxStatus.Text = ("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub ButtonSendToDriver_Click(sender As Object, e As EventArgs) Handles ButtonSendToDriver.Click
        Dim serialStr As String = ""

        If prevObjSlide.NetConneced Then

            'Header
            If objSlide.scriptureStateNavDriMain(2) = True Then 'scripture
                serialStr = "[SCRIPTURE]" & vbCrLf
                serialStr = serialStr & objSlide.bibleBook & vbCrLf
                serialStr = serialStr & objSlide.bibleChapter & vbCrLf
                serialStr = serialStr & objSlide.bibleVerse & vbCrLf
                serialStr = serialStr & objSlide.bibleVersion & vbCrLf
            Else
                serialStr = "[SONG TITLE]" & vbCrLf
                serialStr = serialStr & objSlide.songTitle & vbCrLf
                serialStr = serialStr & "[AUTHOUR]" & vbCrLf
                serialStr = serialStr & objSlide.songAuthour & vbCrLf
            End If

            'prevObjSlide.Array2Str()
            For Each it In ListBoxMain.Items
                serialStr = serialStr & it.ToString.Replace(vbLf, "").Replace(vbCr, "") & "\"
            Next
            Me.txtmessage.Text = serialStr
            Me.btnSend.PerformClick()

            MsgBox("Sent to driver")
        Else
            MsgBox("Not connected to driver")
        End If

    End Sub


    Private Sub LabelExpand_Click(sender As Object, e As EventArgs) Handles LabelExpand.Click
        ' If LabelExpand.Text = "^" Then
        'LabelExpand.Text = "v"
        FormLayouts.Show()
        FormLayouts.TabControl2.SelectTab("TabPageBibles")
        FormLayouts.ListBoxBibles.Items.Clear()
        FormLayouts.ListBoxBibles.Items.AddRange(Me.ListBoxBibles.Items)
        Dim arrBible(0 To Me.ListBoxBibles.Items.Count - 1) As String
        For i = 0 To Me.ListBoxBibles.Items.Count - 1
            If Me.CheckBoxLive.Checked = True Then
                arrBible(i) = prevObjSlide.bibleBook & " " & prevObjSlide.bibleChapter & ":" & (i + 1).ToString & "  " & ListBoxBibles.Items(i).ToString
                arrBible(i) = objSlide.bibleBook & " " & objSlide.bibleChapter & ":" & (i + 1).ToString & "  " & ListBoxBibles.Items(i).ToString

            Else
                arrBible(i) = prevObjSlide.bibleBook & " " & prevObjSlide.bibleChapter & ":" & (i + 1).ToString & "  " & ListBoxBibles.Items(i).ToString

            End If
        Next
        FormLayouts.RichTextBoxSearch.Text = prevObjSlide.Array2sTR(arrBible, False, True)
        FormLayouts.RichTextBoxSearch.BringToFront()
        FormLayouts.TabControl2.SelectTab("TabPageSearch")
        'SplitContainerDriverTab.SplitterDistance = 0 '219
        ' Else
        'SplitContainerDriverTab.SplitterDistance = 219
        ' LabelExpand.Text = "^"
        'End If


    End Sub

    Private Sub RichTextBoxSearch_Click(sender As Object, e As EventArgs) Handles RichTextBoxSearch.Click
        Me.TabControl2.SelectTab("TabPageBibles")
    End Sub

    Private Sub FlowLayoutPanelLayouts_Click(sender As Object, e As EventArgs) Handles FlowLayoutPanelLayouts.Click
        addLayouts()
    End Sub


    Sub addLayouts()
        'vers number at beginning to text
        'reference on top centered
        'reference on top left
        'ReferenceEquals color
        Dim btn As Object
        For i = 0 To 10
            btn = New Button
            btn.Name = "ButtonNewCnt" & i.ToString
            btn.Text = "ButtonNewCnt"
            FlowLayoutPanelLayouts.Controls.Add(btn)
        Next

    End Sub

    Private Sub ButtonSaveLayout_Click(sender As Object, e As EventArgs) Handles ButtonSaveLayout.Click
        'save the current layout and state
        Dim svDlg As New SaveFileDialog

        Dim dir As String = USER_DIRECTORY & "\layouts\"
        svDlg.InitialDirectory = dir
        svDlg.AddExtension = True
        svDlg.DefaultExt = "xml"
        If svDlg.ShowDialog() <> Windows.Forms.DialogResult.Cancel Then
            Dim fn As String = svDlg.FileName
            ClassSerializer.SerializeObject(svDlg, fn)
        End If


    End Sub

    Private Sub ButtonLoadLayout_Click(sender As Object, e As EventArgs) Handles ButtonLoadLayout.Click
        'TODO: load the layout
    End Sub

    Private Sub ButtonDeleteLayout_Click(sender As Object, e As EventArgs) Handles ButtonDeleteLayout.Click
        'TODO: delete the layout
    End Sub

    Private Sub LabelExpandSearch_Click(sender As Object, e As EventArgs) Handles LabelExpandSearch.Click
        FormLayouts.Show()
        FormLayouts.RichTextBoxSearch.Text = (Me.RichTextBoxSearch.Text)
        FormLayouts.RichTextBoxSearch.Find(TextBoxSearch.Text)
        FormLayouts.RichTextBoxSearch.BringToFront()
        FormLayouts.TabControl2.SelectTab("TabPageSearch")
    End Sub
End Class
'


