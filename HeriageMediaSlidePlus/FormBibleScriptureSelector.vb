Public Class FormBibleScriptureSelector

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBoxScripture.Text = "Genesis"
    End Sub

    Private Sub FormBibleScriptureSelector_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Panel1.SuspendLayout()
        'Dim cnt As New Button()
        'cnt.Size = New System.Drawing.Size(231, 48)
        'cnt.Left = 0
        'cnt.Text = " On fly"
        'Me.Controls.Add(cnt)



        'Panel1.ResumeLayout()
    End Sub

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

    Private Sub ListBoxSuggest_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxSuggest.SelectedIndexChanged
        LabelBook.Text = ListBoxSuggest.SelectedItem.ToString
    End Sub

    Private Sub LabelSciptureRef_Click(sender As Object, e As EventArgs) Handles LabelSciptureRef.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        main_sub()

        'prevObjSlide.slideIsScripture = False  'this will trigger an event
    End Sub
End Class