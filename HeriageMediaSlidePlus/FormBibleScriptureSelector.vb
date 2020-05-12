Imports System.Xml
Imports System.Xml.Xsl

Public Class FormBibleScriptureSelector
    Dim xslMarkup As XDocument
    Dim xmlTree As XElement
    Dim newTree As XDocument = New XDocument()
    Private Sub Button1_Click(sender As Object, e As EventArgs)
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
    'You can create an XML tree, create an XmlReader from the XML tree, create a new document, 
    'and create an XmlWriter that will write into the new document. Then, you can invoke the XSLT transformation, 
    'passing the XmlReader and XmlWriter to the transformation. After the transformation successfully completes, 
    'the new XML tree is populated with the results of the transform.
    Private Sub ButtonTransformXML_Click(sender As Object, e As EventArgs) Handles ButtonTransformXML.Click
        'Dim xslMarkup As XDocument
        'Dim xmlTree As XElement
        'Dim newTree As XDocument = New XDocument()

        'load from files
        xslMarkup = XDocument.Load(USER_DIRECTORY & "\db\xsl.xsl")
        xmlTree = XElement.Load(USER_DIRECTORY & "\db\bbe.xml")

        BackgroundWorker1.RunWorkerAsync()

        'Using writer As XmlWriter = newTree.CreateWriter()
        '    ' Load the style sheet.
        '    Dim xslt As XslCompiledTransform = New XslCompiledTransform()
        '    xslt.Load(xslMarkup.CreateReader())

        '    ' Execute the transform and output the results to a writer.
        '    xslt.Transform(xmlTree.CreateReader(), writer)
        'End Using

        ''Console.WriteLine(newTree)

        'newTree.Save(USER_DIRECTORY & "\db\bible_version.xml")
        'TextBoxXML.Text = newTree.ToString
        'MsgBox("Done!")


        '#2 import to access database

        '#3 Cool: Silently use inno setup to copy the database to app Path


        'This example produces the following output:
        '        Xml()

        '<Root>
        '  <C1>Child1 data</C1>
        '  <C2>Child2 data</C2>
        '</Root>

    End Sub
    ''    Dim xslMarkup As XDocument = _
    ''    <?xml version='1.0'?>
    ''    <xsl:stylesheet xmlns:xsl='http://www.w3.org/1999/XSL/Transform' version='1.0'>
    ''        <xsl:template match='/Parent'>
    ''            <Root>
    ''                <C1>
    ''                    <xsl:value-of select='Child1'/>
    ''                </C1>
    ''                <C2>
    ''                    <xsl:value-of select='Child2'/>
    ''                </C2>
    ''            </Root>
    ''        </xsl:template>
    ''    </xsl:stylesheet>

    ''    Dim xmlTree As XElement = _
    ''        <Parent>
    ''            <Child1>Child1 data</Child1>
    ''            <Child2>Child2 data</Child2>
    ''        </Parent>

    ''    Dim newTree As XDocument = New XDocument()

    ''Using writer As XmlWriter = newTree.CreateWriter()
    ''    ' Load the style sheet.
    ''    Dim xslt As XslCompiledTransform = _
    ''        New XslCompiledTransform()
    ''    xslt.Load(xslMarkup.CreateReader())

    ''    ' Execute the transform and output the results to a writer.
    ''    xslt.Transform(xmlTree.CreateReader(), writer)
    ''End Using

    ''Console.WriteLine(newTree)

    ''This example produces the following output:
    ''XML

    ''<Root>
    ''  <C1>Child1 data</C1>
    ''  <C2>Child2 data</C2>
    ''</Root>

    Private Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles BackgroundWorker1.DoWork
        Using writer As XmlWriter = newTree.CreateWriter()
            ' Load the style sheet.
            Dim xslt As XslCompiledTransform = New XslCompiledTransform()
            xslt.Load(xslMarkup.CreateReader())

            ' Execute the transform and output the results to a writer.
            xslt.Transform(xmlTree.CreateReader(), writer)
        End Using

        'Console.WriteLine(newTree)

        newTree.Save(USER_DIRECTORY & "\db\bible_version.xml")
    End Sub

    Private Sub BackgroundWorker1_ProgressChanged(sender As Object, e As System.ComponentModel.ProgressChangedEventArgs) Handles BackgroundWorker1.ProgressChanged
        ProgressBar1.Increment(5)
    End Sub

    Private Sub BackgroundWorker1_RunWorkerCompleted(sender As Object, e As System.ComponentModel.RunWorkerCompletedEventArgs) Handles BackgroundWorker1.RunWorkerCompleted
        MsgBox("Done!")
    End Sub
End Class