Public Class FormWelcomeSplash

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        FormMain.Show()
        My.Settings.mode = "driver"
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        My.Settings.mode = "navigator"

        Me.Hide()
    End Sub

    Private Sub FormWelcomeSplash_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Opacity = 79
    End Sub
End Class