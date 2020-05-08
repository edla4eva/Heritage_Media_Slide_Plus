Imports System.Windows.Forms

Public Class MDIParentMain

    Private Sub ShowNewForm(ByVal sender As Object, ByVal e As EventArgs) Handles NewToolStripMenuItem.Click, NewToolStripButton.Click, NewWindowToolStripMenuItem.Click
        On Error Resume Next
        FormEditor.Show()

    End Sub

    Private Sub OpenFile(ByVal sender As Object, ByVal e As EventArgs) Handles OpenToolStripMenuItem.Click, OpenToolStripButton.Click
        Try
            Dim OpenFileDialog As New OpenFileDialog
            OpenFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            OpenFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"
            If (OpenFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                Dim FileName As String = OpenFileDialog.FileName

                FormEditor.loadfile(FileName)
                FormEditor.Show()
            End If
        Catch ex As Exception
            'can cause error

            FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub SaveAsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles SaveAsToolStripMenuItem.Click
        Try
            Dim SaveFileDialog As New SaveFileDialog
            SaveFileDialog.InitialDirectory = My.Computer.FileSystem.SpecialDirectories.MyDocuments
            SaveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*"

            If (SaveFileDialog.ShowDialog(Me) = System.Windows.Forms.DialogResult.OK) Then
                Dim FileName As String = SaveFileDialog.FileName
                ' TODO: Add code here to save the current contents of the form to a file.
            End If
        Catch ex As Exception
            'can cause error

            FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub


    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        FormEditor.RichTextBox1.Cut()
    End Sub

    Private Sub CopyToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CopyToolStripMenuItem.Click
        ' Use My.Computer.Clipboard to insert the selected text or images into the clipboard
        FormEditor.RichTextBox1.Copy()
    End Sub

    Private Sub PasteToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles PasteToolStripMenuItem.Click
        'Use My.Computer.Clipboard.GetText() or My.Computer.Clipboard.GetData to retrieve information from the clipboard.
        FormEditor.RichTextBox1.Paste()
    End Sub

    Private Sub ToolBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ToolBarToolStripMenuItem.Click
        Me.ToolStrip.Visible = Me.ToolBarToolStripMenuItem.Checked
    End Sub

    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CascadeToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileVerticalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles TileHorizontalToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ArrangeIconsToolStripMenuItem.Click
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Private Sub CloseAllToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CloseAllToolStripMenuItem.Click
        On Error Resume Next
        ' Close all child forms of the parent.
        For Each ChildForm As Form In Me.MdiChildren
            ChildForm.Close()
        Next
    End Sub

    Private m_ChildFormNumber As Integer
   

    Private Sub MDIParentMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Debug.Print(My.Computer.FileSystem.CombinePath(My.Computer.FileSystem.SpecialDirectories.MyDocuments, "Heritage Media Slide Plus"))
        Me.PanelConnect.BackColor = Color.FromArgb(120, 255, 192, 192) 'refddish

#If DEBUG Then
        Me.ButtonbIbleDLL.Visible = True
#End If
        'TODO: Try this  Dim frm As New FormMain
        Dim scrSaver As New SplashScreen1
        scrSaver.Show()
        Me.Visible = False

        FormMain.Show()
        FormMain.Visible = False
        FormMain.MdiParent = Me
        Threading.Thread.Sleep(2000)
        scrSaver.Close()
        Me.Visible = True
        FormMain.Visible = True

        'FormEditor.Show()
        'FormEditor.Hide()



        'Catch ex As Exception
        '    'can cause error

        '    logerror=("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        'Finally
        '    'can cause error
        'End Try

    End Sub
  

    Private Sub ButtonNavigaor_Click(sender As Object, e As EventArgs)
        On Error Resume Next
        My.Settings.mode = "navigator"
        FormMain.Close()
        FormMain.Show()
    End Sub
    'Private Sub ButtonTabBibles_Click(sender As Object, e As EventArgs) Handles ButtonTabBibles.Click
    '    Dim conn As New OleDbConnection()


    '    Dim connStr As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\bibles\KJV.mdb"
    '    conn.ConnectionString = connStr ' "Data Source=.\SQLEXPRESS;AttachDbFilename=|DataDirectory|\Northwind.mdf;Integrated Security=True;User Instance=True"

    '    Dim cmd As New OleDbCommand
    '    cmd.CommandType = CommandType.Text
    '    'cmd.CommandText = "SELECT CustomerID, CompanyName FROM Customers WHERE CompanyName LIKE @bibleBook"
    '    'Genesis 1:1
    '    cmd.CommandText = "SELECT BIBLE.BIBLETEXT, BIBLE.BOOK, BIBLE.CHAPTER, BIBLE.VERSE "
    '    cmd.CommandText = cmd.CommandText & "FROM BIBLE "
    '    cmd.CommandText = cmd.CommandText & "WHERE (((BIBLE.BOOK)=1) AND "
    '    cmd.CommandText = cmd.CommandText & "((BIBLE.CHAPTER)=1) AND "
    '    cmd.CommandText = cmd.CommandText & "((BIBLE.VERSE)=1))"

    '    'Genesis 1 (ALL VERSES)
    '    cmd.CommandText = "SELECT BIBLE.BIBLETEXT, BIBLE.BOOK, BIBLE.CHAPTER, BIBLE.VERSE "
    '    cmd.CommandText = cmd.CommandText & "FROM BIBLE "
    '    cmd.CommandText = cmd.CommandText & "WHERE (((BIBLE.BOOK)=1) AND "
    '    cmd.CommandText = cmd.CommandText & "((BIBLE.CHAPTER)=1))"


    '    cmd.Connection = conn
    '    ' Create a SqlParameter for each parameter in the stored procedure.
    '    Dim bibleBookParam As New OleDbParameter("bibleBook", "1")
    '    cmd.Parameters.Add(bibleBookParam)

    '    Dim reader As OleDbDataReader
    '    Dim previousConnectionState As ConnectionState = conn.State
    '    ListBoxBibles.Items.Clear()  ';TODO: Remove UI suff

    '    Try
    '        If conn.State = ConnectionState.Closed Then
    '            conn.Open()
    '        End If
    '        reader = cmd.ExecuteReader()

    '        Using reader
    '            While reader.Read
    '                ' Process SprocResults datareader here.
    '                Console.WriteLine(reader.GetValue(0))
    '                ListBoxBibles.Items.Add(reader.GetValue(0)) '';TODO: Remove UI suff
    '                ListBoxBibles.Items.Add("") '';TODO: Remove UI suff add space
    '            End While
    '        End Using
    '    Finally
    '        If previousConnectionState = ConnectionState.Closed Then
    '            conn.Close()
    '        End If
    '    End Try

    '    'Genesis 1:1
    '    'SELECT BIBLE.BIBLETEXT, BIBLE.BOOK, BIBLE.CHAPTER, BIBLE.VERSE
    '    'FROM BIBLE
    '    'WHERE (((BIBLE.BOOK)=1) AND ((BIBLE.CHAPTER)=1) AND ((BIBLE.VERSE)=1));

    '    'ESHB -KingJames


    '    'BOOK	CHAPTER	VERSE	BIBLETEXT
    '    '0	0	0	King James Version
    '    '0	0	1	KJV
    '    '0	0	2	English
    '    '0	0	3	King James Version  - Public Domain
    '    '...
    '    '
    '    'BOOK	CHAPTER	VERSE	BIBLETEXT
    '    '0	0	4	This King James Version of the Bible was placed in the Public Domain (no copyright) on 1st September 2004 by Wai Kuen Mo of www.EasiSlides.com and is formatted to be used with the EasiSlides software. The limits of liability for using this Bible is contained in the End User Licence Agreement in the EasiSlides Software which can be downloaded from the website www.EasiSlides.com.
    '    '0	10	1	Genesis
    '    '0	10	2	Exodus
    '    '0	10	3	Leviticus

    '    'BOOK	CHAPTER	VERSE	BIBLETEXT
    '    '1	1	1	In the beginning God created the heaven and the earth.
    '    '1	1	2	"""And the earth was without form, and void; and darkness was upon the face of the deep. And the Spirit of God moved upon the face of the waters."""
    '    '1	1	3	"""And God said, Let there be light: and there was light."""

    'End Sub

    Private Sub ButtonDraw_Click(sender As Object, e As EventArgs) Handles ButtonDraw.Click
        Try
            ' FormDraw.Show()
            FormMain.drawTextOnScreen("And God said, Let there be light: and there was light.", 40)
            FormMain.drawTextOnScreen2("And God said, Let there be light: and there was light.", 40)
        Catch ex As Exception
            'can cause error

            FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try

    End Sub
    Private Sub ButtonbIbleDLL_Click(sender As Object, e As EventArgs) Handles ButtonbIbleDLL.Click
        FormBibleScriptureSelector.Show()
        'Try
        '    Dim cl As New HeritageMediaClassLibrary.ClassP()
        '    MessageBox.Show(cl.test() & " from dll")
        'Catch ex As Exception
        '    'can cause error

        '    FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        'Finally
        '    'can cause error
        'End Try

    End Sub



    Private Sub EditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditToolStripMenuItem.Click
        Try
            If FormMain.ListBoxMain.Focused = True Then
                FormEditor.RichTextBox1.Text = FormMain.ListBoxMain.SelectedItem.ToString
                FormEditor.Show()
            End If
        Catch ex As Exception
            'can cause error

            FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try

    End Sub

    Private Sub ButtonTabBibles_Click(sender As Object, e As EventArgs) Handles ButtonTabBibles.Click
        On Error Resume Next
        FormMain.TabControl2.SelectTab("TabPageBibles")

    End Sub

    Private Sub ButtonSearch_Click(sender As Object, e As EventArgs) Handles ButtonSearch.Click
        On Error Resume Next
        FormMain.TabControl2.SelectTab("TabPageSearch")
        FormMain.TextBoxSearch.Text = LabelSciptureRef.Text
        FormMain.ButtonSearchBible.PerformClick()
        '$TODO  Resize tab
        FormMain.TabControl2.Height = 289
    End Sub

    Private Sub SelectAllToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SelectAllToolStripMenuItem.Click
        On Error Resume Next
        'Me.ActiveMdiChild.ActiveControl
        FormEditor.RichTextBox1.SelectAll()
    End Sub

    Private Sub DriverModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DriverModeToolStripMenuItem.Click
        On Error Resume Next
        My.Settings.mode = "driver"
        FormMain.Close()
        FormMain.Show()
        FormMain.MdiParent = Me
    End Sub


    Private Sub NavigatorModeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NavigatorModeToolStripMenuItem.Click
        On Error Resume Next
        My.Settings.mode = "navigator"
        FormMain.Close()
        FormMain.Show()
        FormMain.MdiParent = Me
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        On Error Resume Next
        SplashScreen1.Show()
    End Sub

    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click, SaveToolStripButton.Click
        On Error Resume Next
        FormEditor.Show()
        FormEditor.ButtonSaveAs.PerformClick()
    End Sub

    Private Sub HelpToolStripButton_Click(sender As Object, e As EventArgs) Handles HelpToolStripButton.Click
        On Error Resume Next
        ' MsgBox("Heritage Media Slide Plus Help is under development")
        SplashScreen1.Show()
    End Sub

    Private Sub ButtonSongs_Click(sender As Object, e As EventArgs) Handles ButtonSongs.Click
        On Error Resume Next
        FormMain.TabControl2.SelectTab("TabPageSongs")
        '$TODO  Resize tab
    End Sub

    Private Sub ImportBibleToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportBibleToolStripMenuItem.Click
        Try
            FormMain.loadAllBibleVersions()
        Catch ex As Exception
            'can cause error

            FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try

    End Sub

    Private Sub ImportImageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ImportImageToolStripMenuItem.Click
        Try
            FormMain.TabControl1.SelectTab("TabPageBackgrounds")
            FormMain.ButtonNewImage.PerformClick()
        Catch ex As Exception
            'can cause error

            FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub RefreshImageListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshImageListToolStripMenuItem.Click
        Try
            FormMain.ButtonImportImage.PerformClick() 'buttons calls FormMain.addPictures
        Catch ex As Exception
            'can cause error

            FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub RefreshSongListToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshSongListToolStripMenuItem.Click
        Try
            FormMain.loadAllSongs()
        Catch ex As Exception
            'can cause error

            FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub LeftPanelToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftPanelToolStripMenuItem.Click
        On Error Resume Next
        If LeftPanelToolStripMenuItem.Checked = True Then
            LeftPanelToolStripMenuItem.Checked = False
        Else
            LeftPanelToolStripMenuItem.Checked = True

        End If
        Me.Panel1.Visible = LeftPanelToolStripMenuItem.Checked
    End Sub

#Region "UI Scripture"
    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyValue = Keys.OemPeriod Or e.KeyValue = Keys.OemSemicolon Or e.KeyValue = Keys.Right Then
            'accept the val
            If ListBoxSuggest.SelectedIndex >= 0 Then
                LabelBook.Text = ListBoxSuggest.SelectedItem.ToString
                LabelBook.Tag = "true"
            ElseIf LabelChapter.Tag = "true" And Val(TextBox2.Text) > 0 Then
                'this must be verse
                'check if verse is valid
                Dim cmChp, maxVerse, bookNum As Integer
                bookNum = prevObjSlide.book2Num(LabelBook.Text)
                cmChp = prevObjSlide.bibleCummSumOfChapters(bookNum - 1) - prevObjSlide.bibleMaxChapter(bookNum - 1) + Val(LabelChapter.Text)  'adjust for chap(-max) add uffset (+chp)
                maxVerse = prevObjSlide.bibleMaxVersesPerChapter(cmChp - 1)
                If Val(TextBox2.Text) <= maxVerse Then
                    LabelVerse.Text = TextBox2.Text
                    Me.TextBox2.Text = LabelSciptureRef.Text
                    LabelVerse.Tag = "true"
                    'reset
                    LabelChapter.Tag = "false"
                    LabelBook.Tag = "false"
                Else 'warn user
                    Dim tt As New ToolTip
                    tt.Show("Enter valid verse.", TextBox2)
                End If

            ElseIf LabelBook.Tag = "true" And Val(TextBox2.Text) > 0 Then
                'this is either a chapter or a verse

                LabelChapter.Text = TextBox2.Text
                LabelChapter.Tag = "true"

            End If
            ''''adjust UI
            ' ''LabelBook.Left = ListBoxSuggest.Left
            ' ''TextBox2.Left = TextBox2.Left + LabelBook.Text.Length * 1 'multiply by points
            ' ''TextBox2.Width = TextBox2.Width - TextBox2.Text.Length * 1

            'wait for next
            TextBox2.Text = ""
            LabelSciptureRef.Text = LabelBook.Text & " " & LabelChapter.Text & ":" & LabelVerse.Text
        ElseIf e.KeyValue = Keys.Escape Then
            'initialize
            TextBox2.Text = ""
            LabelBook.Text = "Genesis"
            LabelChapter.Text = "1"
            LabelVerse.Text = "1"
            LabelSciptureRef.Text = "Genesis 1:1"
            LabelChapter.Tag = "false"
            LabelBook.Tag = "false"
        ElseIf e.KeyValue = Keys.Down Then
            If ListBoxSuggest.SelectedIndex + 1 > 0 And ListBoxSuggest.SelectedIndex + 1 < ListBoxSuggest.Items.Count Then
                ListBoxSuggest.SelectedIndex = ListBoxSuggest.SelectedIndex + 1
            Else
                If ListBoxSuggest.Items.Count > 0 Then ListBoxSuggest.SelectedIndex = 0
            End If
        ElseIf e.KeyValue = Keys.Up Then
            If ListBoxSuggest.SelectedIndex - 1 > 0 Then
                ListBoxSuggest.SelectedIndex = ListBoxSuggest.SelectedIndex - 1
            Else
                If ListBoxSuggest.Items.Count > 0 Then ListBoxSuggest.SelectedIndex = 0
            End If

        ElseIf e.KeyValue = Keys.Enter Then
            'Automatically click on seach
            'TODO: do some checks
            Me.TextBox2.Text = LabelSciptureRef.Text
            Me.ButtonSearch.PerformClick()
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim tmpSearch As String() = prevObjSlide.bibleChaptersFull
        Dim enteredStr As String = TextBox2.Text
        'suggest autocomplete
        ListBoxSuggest.Items.Clear()
        For Each ss As String In tmpSearch
            If ss.ToUpper.Contains(enteredStr.ToUpper) Then

                'TextBox2.Enabled = False
                ListBoxSuggest.Items.Add(ss)
                'Exit For
            End If
            ''TODO: remove if problrmatic if exact select it
            'If ss.ToUpper = enteredStr.ToUpper Then ListBoxSuggest.SelectedIndex = ListBoxSuggest.Items.Count - 1
        Next

        TextBox2.Focus()
    End Sub
#End Region

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        On Error Resume Next
        FormMain.TabControl1.SelectTab("TabPageSettings")
        FormMain.btnConnect.PerformClick()
    End Sub
End Class
