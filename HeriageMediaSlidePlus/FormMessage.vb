
Imports System.Net.Sockets
Imports System.Threading
Imports System.IO
Imports System
Imports System.Net.Dns
Imports System.Drawing.Bitmap
Imports RapChatLib.RapChatLib
Public Class FormMessage

#Region "Form"

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '------------------------------------------------------------------------------------
        '                                   Initialize Messaging
        '------------------------------------------------------------------------------------
        Me.MdiParent = MDIParentMain
        Dim ListThread As New Thread(New ThreadStart(AddressOf Listening)) 'Creates the thread
        ListThread.Start() 'Starts the thread
        Dim shostname As String
        shostname = System.Net.Dns.GetHostName
        Console.WriteLine("Your Machine Name = " & shostname)
        'Call Get IPAddress
        Console.WriteLine("Your IP = " & GetIPAddress())
        lblStatus.Text = ("My Computer: " & shostname & " - " & GetIPAddress())
        cmbAddress.Items.Add(GetIPAddress())
        cmbAddress.SelectedIndex = 0
    End Sub

    Private Sub Form1_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Dim offlinestring As String = " Has gone Offline. You can No longer Message This User."
        If RichTextBox1.Text.Contains(offlinestring) Then
            End
        Else
            txtmessage.Text = txtName.Text & " Has gone Offline. You can No longer Message This User."
            btnSend.PerformClick()
        End If
    End Sub

#End Region

#Region "Functions"

    Public Shared Function GetIPAddress() As String
        Dim oAddr As System.Net.IPAddress
        Dim sAddr As String
        With System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName())
            oAddr = New System.Net.IPAddress(.AddressList(0).Address)
            sAddr = oAddr.ToString
        End With
        GetIPAddress = sAddr
    End Function

    Private Sub Listening()
        Listener.Start()
        Listener1.Start()
    End Sub
    Private Sub NotifyIcon1_MouseDoubleClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Me.Show()
    End Sub
    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If Listener.Pending = True Then
            Message = ""
            Client = Listener.AcceptTcpClient()

            Dim Reader As New StreamReader(Client.GetStream())
            While Reader.Peek > -1
                Message = Message + Convert.ToChar(Reader.Read()).ToString
            End While
            RichTextBox1.ForeColor = Color.Black
            RichTextBox1.Text += Message + vbCrLf
            lblStatus.Text = ("Last Message Received At " & My.Computer.Clock.LocalTime)
        End If
        If Listener1.Pending = True Then
            Message1 = ""
            Client1 = Listener1.AcceptTcpClient()

            Dim Reader1 As New StreamReader(Client1.GetStream())
            While Reader1.Peek > -1
                Message1 = Message1 + Convert.ToChar(Reader1.Read()).ToString
            End While
            PicClient.Image = StringToBitmap(Message1)
        End If
    End Sub

    Private Sub btnSend_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSend.Click
        If cmbAddress.Text = "" Then 'txtName.Text = "" Or 
            logError("All Fields must be Filled") ', "Error Sending Message") ', MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            'btnImage.PerformClick()
            Try
                Client = New TcpClient(cmbAddress.Text, 65535)

                Dim Writer As New StreamWriter(Client.GetStream())
                Writer.Write(txtmessage.Text) 'txtName.Text & " Says:  " & 
                Writer.Flush()
                RichTextBox1.Text += "Local: " + (txtmessage.Text) + vbCrLf
                txtmessage.Text = ""
            Catch ex As Exception
                Console.WriteLine(ex)
                Dim Errorresult As String = ex.Message
                logError(Errorresult & vbCrLf & vbCrLf & "Please Review Client Address") ', "Error Sending Message", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try

        End If
    End Sub

    Private Sub txtmessage_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtmessage.TextChanged
        If txtmessage.Text <> "" Then
            btnClear.Enabled = True
            btnSend.Enabled = True
        Else
            btnClear.Enabled = False
            btnSend.Enabled = False
        End If
    End Sub


    Private Sub btnConnect_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConnect.Click
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
                MDIParentMain.PanelConnect.BackColor = Color.FromArgb(120, 255, 192, 192) 'refddish
                prevObjSlide.NetConneced = False
            End If
        End If

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

    Private Sub mnuCut_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCut.Click
        RichTextBox1.Cut()
    End Sub

    Private Sub mnuCopy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuCopy.Click
        RichTextBox1.Copy()
    End Sub

    Private Sub mnuSelectAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuSelectAll.Click
        RichTextBox1.SelectAll()
    End Sub

    Private Sub RichTextBox1_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RichTextBox1.MouseMove
        If RichTextBox1.SelectionLength > 0 Then
            mnuCut.Enabled = True
            mnuCopy.Enabled = True
            cmsmCut.Enabled = True
            cmsmCopy.Enabled = True
        Else
            mnuCut.Enabled = False
            mnuCopy.Enabled = False
            cmsmCut.Enabled = False
            cmsmCopy.Enabled = False
        End If
    End Sub

#End Region

#Region "Settings"

    Private Sub ButtonAddIP_Click(sender As Object, e As EventArgs) Handles ButtonAddIP.Click

        Me.cmbAddress.Items.Add(txtIP.Text)
    End Sub

#End Region

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.txtmessage.Text = "Test message sent \ Confirm receipt of message"
        btnSend.PerformClick()
    End Sub

End Class
