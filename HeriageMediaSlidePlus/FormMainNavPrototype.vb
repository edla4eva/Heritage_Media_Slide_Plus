Imports Microsoft.VisualBasic.FileIO
Imports System.Data.OleDb
Imports System.Collections.ObjectModel

Public Class FormMainNavPrototype

    Private Sub ButtonNavigaor_Click(sender As Object, e As EventArgs)
        FormMessage.Show()

        MDIParentMain.PanelConnect.BackColor = Color.FromArgb(120, 255, 192, 192) 'refddish

    End Sub
    Private Sub ButtonLive_Click(sender As Object, e As EventArgs) Handles ButtonSendToDriver.Click
        Dim serialStr As String = ""

        If prevObjSlide.NetConneced Then

            'prevObjSlide.Array2Str()
            For Each it In ListBoxMain.Items
                serialStr = serialStr & it.ToString.Replace(vbLf, "").Replace(vbCr, "") & "\"
            Next
            FormMessage.txtmessage.Text = serialStr
            FormMessage.btnSend.PerformClick()
        Else
            MsgBox("Not connected to driver")
        End If

    End Sub

    '------------------------------------------------

    Private Sub ListBoxSongs_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBoxSongs.SelectedIndexChanged

    End Sub

    Private Sub FormMainNav_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.MdiParent = MDIParentMain
    End Sub
End Class
'


