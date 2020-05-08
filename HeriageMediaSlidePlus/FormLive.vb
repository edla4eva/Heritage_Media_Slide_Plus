Public Class FormLive
    Dim firstTime As Boolean = True
    Private Sub FormLive_DoubleClick(sender As Object, e As EventArgs) Handles Me.DoubleClick
        Me.Close()
    End Sub

    Private Sub FormLive_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        On Error Resume Next
        Dim scrn As Screen = Screen.FromControl(Me)
        Dim calW, calH, calProjectorW, calProjectorH As Integer
        Label1.Text = Me.Text & "Current Monitor: " & scrn.DeviceName & " No:" & Screen.AllScreens.Length.ToString
        Label1.Text = Me.Text & " Working area" & scrn.WorkingArea.ToString() & vbCrLf
        Label1.Text = Me.Text & " Bounds area" & scrn.Bounds.ToString()


        Me.TopMost = True 'TODO: Make topmost
#If DEBUG Then
        Me.TopMost = False 'TODO: Make topmost
#End If

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
        Me.Left = 0
        Me.Top = 0
        'TODO: get dimension of projector screen
        If Screen.AllScreens.Length > 1 Then
            'mul screen
            Me.Left = calW '
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
                    Me.Left = scrn.Bounds.Width
                    Me.Width = scrn.Bounds.Width
                    Me.Height = scrn.Bounds.Height
                Case 2
                    '1. same with PC & projector (set by user)
                    Me.Left = calW
                    Me.Width = calW
                    Me.Height = calH

                Case 3
                    ''3. different; PC fixed by user, projector bounds
                    Me.Left = calW
                    Me.Width = scrn.Bounds.Width
                    Me.Height = scrn.Bounds.Height
                Case 4
                    '4. different; PC (set by user), projector (another value set)
                    Me.Left = calW
                    Me.Width = calProjectorW
                    Me.Height = calProjectorH
                    Debug.Print("4. different; PC (set by user), projector (another value set)")
                Case 5
                    '
                Case Else 'One screen
                    Me.Left = 0

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
    End Sub


    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click, Me.Click
        On Error Resume Next
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

            'bounds is the resolution of the projector hdmi
            ' MsgBox("pixels:" & scrn.BitsPerPixel & vbCrLf &
            '"Device name:" & scrn.DeviceName & vbCrLf &
            ' "working area:" & scrn.WorkingArea.ToString & vbCrLf &
            '"bounds:" & scrn.Bounds.ToString & vbCrLf &
            '"maximized size of form " & Me.MaximumSize.ToString())
            ' 'objSlide.width = scrn.Bounds.Width
            ' 'objSlide.height = scrn.Bounds.Height

            FormMain.TextBoxStatus.Text = ("pixels:" & scrn.BitsPerPixel & vbCrLf &
           "Device name:" & scrn.DeviceName & vbCrLf &
            "working area:" & scrn.WorkingArea.ToString & vbCrLf &
           "bounds:" & scrn.Bounds.ToString & vbCrLf &
           "maximized size of form " & Me.MaximumSize.ToString() & vbCrLf &
           "maximized bounds of form " & Me.MaximizedBounds.ToString)


        Else
            'single screen

            FormMain.TextBoxStatus.Text = ("pixels:" & scrn.BitsPerPixel & vbCrLf &
           "Device name:" & scrn.DeviceName & vbCrLf &
            "working area:" & scrn.WorkingArea.ToString & vbCrLf &
           "bounds:" & scrn.Bounds.ToString & vbCrLf &
           "maximized size of form " & Me.MaximumSize.ToString() & vbCrLf &
           "maximized bounds of form " & Me.MaximizedBounds.ToString)

        End If


        'next slide
    End Sub

    Private Sub PictureBox1_DoubleClick(sender As Object, e As EventArgs) Handles PictureBox1.DoubleClick, Me.DoubleClick
        Me.Visible = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Me.TopMost = True
    End Sub

    Private Sub PictureBox1_Paint(sender As Object, e As PaintEventArgs) Handles PictureBox1.Paint
        Try
            Dim tmpCF, tmpCB As System.Drawing.Color
            Dim fnt As Font

            tmpCF = Color.FromArgb(Val(objSlide.settings.Item("foreColor"))) 'case sensitive
            tmpCB = Color.FromArgb(Val(objSlide.settings.Item("shadowColor"))) 'case sensitive
            fnt = New Font(objSlide.settings.Item("fontFamily"), CSng(objSlide.settings.Item("fontSize")), FontStyle.Bold)
            Dim bibleRef As String = objSlide.bibleBook & " " & objSlide.bibleChapter & ":" & objSlide.bibleVerse & "(" & objSlide.bibleVersion & ")"
            ' If objSlide.slideIsScripture = False Then bibleRef = Nothing 'Not showing us today :) TODO: show song title
            If objSlide.scriptureStateNavDriMain(2) = False Then bibleRef = Nothing 'Not showing us today :) TODO: show song title
            'TODO: if background=off then trans=true
            If objSlide.settings.Item("position") = "Lower Third" Then
                wm.drawTextOnSlideLowerThird(e, objSlide.slideStr, fnt, tmpCB, tmpCF, bibleRef, Color.FromArgb(128, 0, 0, 30), Not objSlide.useImageForLowerThird, objSlide.settings.Item("resolutionW"), objSlide.settings.Item("resolutionH"))

            Else
                wm.drawTextOnSlide(e, objSlide.slideStr, fnt, tmpCB, tmpCF, bibleRef, , False, objSlide.settings.Item("resolutionW"), objSlide.settings.Item("resolutionH"))

            End If


            tmpCF = Nothing
            tmpCB = Nothing
            bibleRef = Nothing

            fnt = Nothing



        Catch ex As Exception
            'can cause error
            FormMain.TextBoxStatus.Text = ("Error occured while creating slide!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
            logerror("Error occured while creating slide!" & vbCrLf & "This error was caused because:" & ex.GetBaseException().Message)
        Finally
            'can cause error
        End Try

    End Sub


    Private Sub FormLive_Paint(sender As Object, e As PaintEventArgs) Handles Me.Paint

    End Sub
End Class