Imports System.IO
Public Class FormEditor
    Dim path As String = Nothing
    Public Sub loadfile(fullPath As String, Optional auth As String = "", Optional title As String = "")

        Try
            'If Not (fullPath = Nothing) Then
            '    Using sr As New StreamReader(fullPath)
            '        RichTextBox1.Text = sr.ReadToEnd()
            '    End Using
            'End If



            Dim fileExists As Boolean
            Dim lines() As String = {}

            fileExists = My.Computer.FileSystem.FileExists(fullPath)
            If fileExists Then
                lines = IO.File.ReadAllLines(fullPath)
                'retrieve headers
                '[SONG TITLE]
                'Once Again
                '[AUTHOUR]
                'Unknown
                'TODO: is this required?
                TextBoxAuthour.Text = auth
                TextBoxTitle.Text = title
                If lines(0).Contains("[SONG TITLE]") Then TextBoxAuthour.Text = lines(1)
                If lines(2).Contains("[AUTHOUR]") Then TextBoxAuthour.Text = lines(3)
            Else

            End If

            Dim linesNew(0 To lines.Length - 4 - 1) As String
            If lines(0).Contains("[SONG TITLE]") And lines(2).Contains("[AUTHOUR]") Then
                Array.ConstrainedCopy(lines, 4, linesNew, 0, linesNew.Length)
            Else
                linesNew = lines
            End If
            RichTextBox1.Text = prevObjSlide.Array2sTR(linesNew, False, True)
            lines = Nothing
            linesNew = Nothing

        Catch ex As Exception
            Throw ex
        End Try
    End Sub
    Public Sub loadText(txt As String)
        RichTextBox1.Text = txt
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles ButtonLoadFile.Click
        Try
            Dim fo As New OpenFileDialog
            fo.Filter = "Text Files|*.txt"
            fo.FilterIndex = 1
            fo.ShowDialog()
            If (fo.FileName = Nothing) Then
                MsgBox("No file selected.")
            Else
                path = fo.FileName
                Using sr As New StreamReader(fo.FileName)
                    RichTextBox1.Text = sr.ReadToEnd()
                End Using
            End If
        Catch ex As Exception
            'can cause error

            FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles ButtonSave.Click
        Try
            If TextBoxAuthour.Text = "" Or TextBoxTitle.Text = "" Then
                MsgBox("Please enter the song title and authour")
                Return
            End If
            If TextBoxAuthour.Text.Contains(":") Or TextBoxAuthour.Text.Contains("/") Or TextBoxAuthour.Text.Contains("\") Or
                TextBoxTitle.Text.Contains(":") Or TextBoxTitle.Text.Contains("/") Or TextBoxTitle.Text.Contains("\") Then
                MsgBox("Please the song title and authour names cannot contain :, / or \ characters")
                Return
            End If
            '[SONG TITLE]
            'Once Again
            '[AUTHOUR]
            'Unknown
            Dim songStr As String = ""
            prevObjSlide.songfileName = USER_DIRECTORY & "\lyrics\" & Me.TextBoxAuthour.Text & "-" & Me.TextBoxTitle.Text & ".txt"
            songStr = songStr & "[SONG TITLE]" & vbCr
            songStr = songStr & Me.TextBoxTitle.Text & vbCr
            songStr = songStr & "[AUTHOUR]" & vbCr
            songStr = songStr & Me.TextBoxAuthour.Text & vbCr
            songStr = songStr & RichTextBox1.Text
            prevObjSlide.songTitle = Me.TextBoxTitle.Text
            prevObjSlide.songAuthour = Me.TextBoxAuthour.Text

            If My.Computer.FileSystem.FileExists(prevObjSlide.songfileName) Then
                My.Computer.FileSystem.WriteAllText(prevObjSlide.songfileName, songStr, False)
            Else
                path = Nothing
                'creaate it
                My.Computer.FileSystem.WriteAllText(prevObjSlide.songfileName, String.Empty, False)
                My.Computer.FileSystem.WriteAllText(prevObjSlide.songfileName, songStr, False)
            End If

            'If (Not path = Nothing) Then
            '    Using sw As New StreamWriter(path)
            '        sw.Write("[SONG TITLE]")
            '        sw.Write(Me.TextBoxTitle)
            '        prevObjSlide.songTitle = Me.TextBoxTitle
            '        sw.Write("[AUTHOUR]")
            '        sw.Write(Me.TextBoxAuthour)
            '        prevObjSlide.songAuthour = Me.TextBoxAuthour

            '        sw.Write(RichTextBox1.Text)
            '    End Using
            'End If

            FormMain.ListBoxDriver.Items.AddRange(prevObjSlide.str2Array(RichTextBox1.Text))
            MsgBox("Saved!")
        Catch ex As Exception
            'can cause error

            FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles ButtonSaveAs.Click
        Try
            Dim fs As New SaveFileDialog
            fs.Filter = "Text Files|*.txt"
            fs.FilterIndex = 1
            fs.ShowDialog()

            If TextBoxAuthour.Text = "" Or TextBoxTitle.Text = "" Then
                MsgBox("Please enter the song title and authour")
                Return
            End If
            If TextBoxAuthour.Text.Contains(":") Or TextBoxAuthour.Text.Contains("/") Or TextBoxAuthour.Text.Contains("\") Or
                TextBoxTitle.Text.Contains(":") Or TextBoxTitle.Text.Contains("/") Or TextBoxTitle.Text.Contains("\") Then
                MsgBox("Please the song title and authour names cannot contain :, / or \ characters")
                Return
            End If
            '[SONG TITLE]
            'Once Again
            '[AUTHOUR]
            'Unknown
            Dim songStr As String = ""
            prevObjSlide.songfileName = fs.FileName
            songStr = songStr & "[SONG TITLE]" & vbCr
            songStr = songStr & Me.TextBoxTitle.Text & vbCr
            songStr = songStr & "[AUTHOUR]" & vbCr
            songStr = songStr & Me.TextBoxAuthour.Text & vbCr
            songStr = songStr & RichTextBox1.Text
            prevObjSlide.songTitle = Me.TextBoxTitle.Text
            prevObjSlide.songAuthour = Me.TextBoxAuthour.Text

            If My.Computer.FileSystem.FileExists(prevObjSlide.songfileName) Then
                My.Computer.FileSystem.WriteAllText(prevObjSlide.songfileName, songStr, False)
            Else
                path = Nothing
                'creaate it
                My.Computer.FileSystem.WriteAllText(prevObjSlide.songfileName, String.Empty, False)
                My.Computer.FileSystem.WriteAllText(prevObjSlide.songfileName, songStr, False)
            End If


            FormMain.ListBoxDriver.Items.AddRange(prevObjSlide.str2Array(RichTextBox1.Text))


            'If (Not fs.FileName = Nothing) Then
            '    Using sw As New StreamWriter(fs.FileName)
            '        sw.Write(RichTextBox1.Text)
            '    End Using
            'End If
            MsgBox("Saved!")

        Catch ex As Exception
            'can cause error

            FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParentMain
    End Sub



    Private Sub ButtonShowDB_Click(sender As Object, e As EventArgs) Handles ButtonShowDB.Click
        Try
            Dim mydataset As DataSet = prevObjSlide.getFromDBSongsDataset()
            DataGridView1.DataSource = mydataset.Tables("SONG").DefaultView
            DataGridView1.Visible = True
        Catch ex As Exception
            'can cause error
            FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try

    End Sub

    Private Sub RadioButtonDB_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButtonDB.CheckedChanged
        ButtonSaveDB.Enabled = RadioButtonDB.Checked
    End Sub

    Private Sub ButtonSaveDB_Click(sender As Object, e As EventArgs) Handles ButtonSaveDB.Click
        Try
            Dim suc As Boolean = prevObjSlide.insertIntoDBSong(Me.TextBoxTitle.Text, Me.RichTextBox1.Text, Me.TextBoxAuthour.Text)
            MsgBox("Added successfully!")
        Catch ex As Exception
            'can cause error

            FormMain.TextBoxStatus.Text = ("Error!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try

    End Sub

    Private Sub DataGridView1_RowEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.RowEnter
        On Error Resume Next
        TextBoxTitle.Text = DataGridView1.SelectedRows(0).Cells("TITLE_1").Value.ToString
        TextBoxAuthour.Text = DataGridView1.SelectedRows(0).Cells("WRITER").Value.ToString
        RichTextBox1.Text = DataGridView1.SelectedRows(0).Cells("LYRICS").Value.ToString

    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        On Error Resume Next
        TextBoxTitle.Text = DataGridView1.SelectedRows(0).Cells("TITLE_1").Value.ToString
        TextBoxAuthour.Text = DataGridView1.SelectedRows(0).Cells("WRITER").Value.ToString
        RichTextBox1.Text = DataGridView1.SelectedRows(0).Cells("LYRICS").Value.ToString

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class
