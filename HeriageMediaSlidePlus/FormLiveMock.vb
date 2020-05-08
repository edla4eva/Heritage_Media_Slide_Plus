Public Class FormLiveMock

    Dim firstTime As Boolean = True
    Private Sub FormLive_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.Close()
    End Sub

    Private Sub FormLive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim scrn As Screen = Screen.FromControl(Me)
            Dim calW, calH, calProjectorW, calProjectorH As Integer
            Label1.Text = Me.Text & "Current Monitor: " & scrn.DeviceName & " No:" & Screen.AllScreens.Length.ToString
            Label1.Text = Me.Text & " Working area" & scrn.WorkingArea.ToString() & vbCrLf
            Label1.Text = Me.Text & " Bounds area" & scrn.Bounds.ToString()


            If CInt(objSlide.settings.Item("resolutionW")) <> scrn.Bounds.Width Then
                calW = CInt(objSlide.settings.Item("resolutionW"))
                calH = CInt(objSlide.settings.Item("resolutionH"))
            Else
                calW = scrn.Bounds.Width
                calH = scrn.Bounds.Height
            End If
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            Me.Width = calW ' 900
            Me.Height = calH '600
            Me.Left = -30000
            Me.Top = 0
            'TODO: get dimension of projector screen
            If Screen.AllScreens.Length > 1 Then
                'mul screen
                Me.Left = -30000 '
                'here we can chose to use a different resolution for projector
                'it can either be
                ' 2. same with PC & projector (set by user)
                '1. same; with PC bounds
                '3. different; PC fixed by user, projector bounds
                '4. different; PC (set by user), projector (another value set)
                '5. different; PC bounds, projrctor set by user

                Dim op As Integer
                op = CInt(objSlide.settings.Item("displayOption"))
                calProjectorW = CInt(objSlide.settings.Item("resolutionProjectorW"))
                calProjectorH = CInt(objSlide.settings.Item("resolutionProjectorH"))
                Select Case op
                    Case 1 'default
                        '2. same; with PC bounds
                        Me.Left = -30000
                        Me.Width = scrn.Bounds.Width
                        Me.Height = scrn.Bounds.Height
                    Case 2
                        '1. same with PC & projector (set by user)
                        Me.Left = -30000
                        Me.Width = calW
                        Me.Height = calH

                    Case 3
                        ''3. different; PC fixed by user, projector bounds
                        Me.Left = -30000
                        Me.Width = scrn.Bounds.Width
                        Me.Height = scrn.Bounds.Height
                    Case 4
                        '4. different; PC (set by user), projector (another value set)
                        Me.Left = -30000
                        Me.Width = calProjectorW
                        Me.Height = calProjectorH
                        Debug.Print("4. different; PC (set by user), projector (another value set)")
                    Case 5
                        '
                    Case Else 'One screen
                        Me.Left = -30000

                End Select


            End If
            'There is a flicker in display due to form resizing
            'This is corrected by triggering the paint event twice
            'the first time the form loads
            If firstTime = True Then
                Me.PictureBox1.Invalidate()
                Me.Invalidate()
                firstTime = False
            End If
        Catch ex As Exception
            'can cause error
            FormMain.TextBoxStatus.Text = ("Error occured while creating  preview slide!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured while creating slide!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, Me.Click
        Try
            Dim scrn As Screen = Screen.FromControl(Me)
            Dim pix As Integer
            Me.Text = "Curren Monitor: " & scrn.DeviceName
            Me.Text = Me.Text & "  " & scrn.Bounds.ToString()

            'TODO: get dimension of projector screen 
            pix = scrn.BitsPerPixel
            If Screen.AllScreens.Length > 1 Then
                'mul screen
                Me.Left = scrn.Bounds.Width
                'start scaling
                scrn = Screen.AllScreens(1)
                Debug.Print("pixels:" & scrn.BitsPerPixel)
                Debug.Print("Device name:" & scrn.DeviceName)
                Debug.Print("working area:" & scrn.WorkingArea.ToString)
                Debug.Print("bounds:" & scrn.Bounds.ToString)
            Else
                'single screen


            End If


        Catch ex As Exception
            'can cause error
            FormMain.TextBoxStatus.Text = ("Error occured while creating preview slide!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured while creating slide!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick, Me.DoubleClick
        Me.Visible = False
    End Sub

 

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        Try
            Dim tmpCF, tmpCB As System.Drawing.Color
            Dim fnt As Font


            ' If Me.Tag = "live" Then
            ' Else 'preview

            tmpCF = Color.FromArgb(Val(prevObjSlide.settings.Item("foreColor"))) 'case sensitive
            tmpCB = Color.FromArgb(Val(prevObjSlide.settings.Item("shadowColor"))) 'case sensitive
            fnt = New Font(prevObjSlide.settings.Item("fontFamily"), CSng(prevObjSlide.settings.Item("fontSize")), FontStyle.Bold)
            Dim bibleRef As String = prevObjSlide.bibleBook & " " & prevObjSlide.bibleChapter & ":" & prevObjSlide.bibleVerse & "(" & prevObjSlide.bibleVersion & ")"
            'If prevObjSlide.slideIsScripture = False Then bibleRef = Nothing 'Not showing us today :) TODO: show song title
            If prevObjSlide.scriptureStateNavDriMain(1) = False Then bibleRef = Nothing 'Not showing us today :) TODO: show song title
            'TODO: if background=off then trans=true
            If prevObjSlide.settings.Item("position") = "Lower Third" Then
                wm.drawTextOnSlideLowerThird(e, prevObjSlide.slideStr, fnt, tmpCB, tmpCF, bibleRef, Color.FromArgb(128, 0, 0, 30), Not prevObjSlide.useImageForLowerThird, prevObjSlide.settings.Item("resolutionW"), prevObjSlide.settings.Item("resolutionH"))

            Else
                wm.drawTextOnSlide(e, prevObjSlide.slideStr, fnt, tmpCB, tmpCF, bibleRef, , False, prevObjSlide.settings.Item("resolutionW"), prevObjSlide.settings.Item("resolutionH"))

            End If


            tmpCF = Nothing
            tmpCB = Nothing
            bibleRef = Nothing

            fnt = Nothing


        Catch ex As Exception
            'can cause error
            FormMain.TextBoxStatus.Text = ("Error occured while creating preview slide!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logError("Error occured while creating slide!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try

    End Sub

End Class