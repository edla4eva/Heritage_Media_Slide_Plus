

Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports WhatsAppApi.Account
Imports WhatsAppApi.Parser
Imports WhatsAppApi.Response


Public Class MessageHandler
    Private messageHistory As Dictionary(Of String, List(Of FMessage))
    Private userMessageDict As Dictionary(Of String, WhatsEventHandler.MessageRecievedHandler)

    Public Sub New()
        Me.messageHistory = New Dictionary(Of String, List(Of FMessage))()
        Me.userMessageDict = New Dictionary(Of String, WhatsEventHandler.MessageRecievedHandler)()
        WhatsEventHandler.MessageRecievedEvent += AddressOf WhatsEventHandlerOnMessageRecievedEvent
    End Sub

    Private Sub WhatsEventHandlerOnMessageRecievedEvent(ByVal mess As FMessage)
        If mess Is Nothing OrElse mess.identifier_key.remote_jid Is Nothing OrElse mess.identifier_key.remote_jid.Length = 0 Then Return
        If Not Me.messageHistory.ContainsKey(mess.identifier_key.remote_jid) Then Me.messageHistory.Add(mess.identifier_key.remote_jid, New List(Of FMessage)())
        Me.messageHistory(mess.identifier_key.remote_jid).Add(mess)
        Me.CheckIfUserRegisteredAndCreate(mess)
    End Sub

    Private Sub CheckIfUserRegisteredAndCreate(ByVal mess As FMessage)
        If Me.messageHistory.ContainsKey(mess.identifier_key.remote_jid) Then Return
        Dim jidSplit = mess.identifier_key.remote_jid.Split("@"c)
        Dim tmpWhatsUser As WhatsUser = New WhatsUser(jidSplit(0), jidSplit(1), mess.identifier_key.serverNickname)
        Dim tmpUser As User = New User(jidSplit(0), jidSplit(1))
        tmpUser.SetUser(tmpWhatsUser)
        Me.messageHistory.Add(mess.identifier_key.remote_jid, New List(Of FMessage)())
        Me.messageHistory(mess.identifier_key.remote_jid).Add(mess)
    End Sub

    Public Sub RegisterUser(ByVal user As User, ByVal messHandler As WhatsEventHandler.MessageRecievedHandler)
    End Sub
End Class


