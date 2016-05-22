Imports System
Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System.Threading
Imports System.IO
Imports System.Collections
Imports System.Diagnostics

Public Class Server
    Dim serverIP As String

    Public IP As String
    Public serverSocket As Socket
    Public serverData(1024) As Byte
    Public serverInput As String
    Public serverStringData As String
    Public serverRecv As Integer

    Public Sub New(ByVal ServerIPP As String)
        serverData(1024) = New Byte
        serverIP = ServerIPP
    End Sub

    Public Sub sendMessage()
        serverSocket.Send(Encoding.ASCII.GetBytes(serverInput))
        serverInput = serverIP
    End Sub

    Public Sub sendUserDescription(ByVal userName As String, ByVal userState As String, ByVal tipo As String, ByVal nombreDestinoP As String)

        If tipo = "p" Then
            nombreDestinoP = "@" + nombreDestinoP
        End If


        Me.serverInput = userName + vbCrLf + userState + vbCrLf + tipo + vbCrLf + nombreDestinoP
        Me.serverSocket.Send(Encoding.ASCII.GetBytes(serverInput))

        serverInput = serverIP
    End Sub


End Class
