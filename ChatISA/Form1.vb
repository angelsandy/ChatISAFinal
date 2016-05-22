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


Public Class Form1

    Dim server As Server
    Dim MyUser As User
    Dim waitingMessage As Thread
    Dim chatOn As Boolean
    Dim serverIP As String = "192.168.43.53"

    Delegate Sub AddListItem(myString As String)
    Public myDelegate As AddListItem

    Public Sub New()
        server = New Server(serverIP)
        waitingMessage = New Thread(New ThreadStart(AddressOf WaittingMessage))
        chatOn = True

        InitializeComponent()
    End Sub

    Public Sub New(ByVal NameP As String, ByVal nombreDestinoP As String, ByVal StateP As String, ByVal IPP As String, ByVal tipoP As String)
        serverIP = IPP

        MyUser = New User
        MyUser.NameDestino = nombreDestinoP
        MyUser.userName = NameP
        'Me.lbl_nombre.Text = nombreDestinoP
        MyUser.tipo = tipoP

        Select Case StateP
            Case "Conectado"
                MyUser.userState = Enums.UserState.Conectado
            Case "Ausente"
                MyUser.userState = Enums.UserState.Ausente
            Case "Ocupado"
                MyUser.userState = Enums.UserState.Ocupado
        End Select

        server = New Server(serverIP)
        server.IP = IPP
        waitingMessage = New Thread(New ThreadStart(AddressOf WaittingMessage))
        chatOn = True
        InitializeComponent()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        launchClient()
    End Sub

    Public Sub WaittingMessage()
        While chatOn
            server.serverData(1024) = New Byte
            server.serverRecv = 0
            server.serverStringData = ""
            server.serverRecv = server.serverSocket.Receive(server.serverData)

            server.serverStringData = Encoding.ASCII.GetString(server.serverData, 0, server.serverRecv)
            If server.serverStringData <> "" Then
                SetText(server.serverStringData)
            End If
        End While
    End Sub

    Public Sub launchClient()
        Dim ipep As New IPEndPoint(IPAddress.Parse(serverIP), 8888)
        server.serverSocket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

        Try
            server.serverSocket.Connect(ipep)
        Catch ex As Exception
            MessageBox.Show("Imposible conectar con el servidor" + Environment.NewLine + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Application.Exit()
            Return
        End Try
        server.sendUserDescription(MyUser.userName, MyUser.userState.ToString(), MyUser.tipo, MyUser.NameDestino)
        waitingMessage.Start()

    End Sub

    Private Sub Send_Click(sender As Object, e As EventArgs) Handles Send.Click
        server.serverInput = MyUser.userName + ":" + "@" + MyUser.NameDestino + ":" + txtb_mensaje.Text + vbLf
        server.sendMessage()
        txtb_mensaje.Text = ""
        txtb_mensaje.Focus()

    End Sub

    Private Sub SetText(ByVal text As String)
        If rTBChat.InvokeRequired Then
            Dim d As New SetTextCallback(AddressOf SetText)
            'Invoke(d) as object 
            Me.Invoke(d, New Object() {text})
        Else
            Me.rTBChat.AppendText(text)
        End If
    End Sub


    Public Delegate Sub SetTextCallback(ByVal message As String)

    Private Sub Cerrar11_Click(sender As Object, e As EventArgs) Handles Cerrar11.Click
        Try
            server.serverSocket.Send(Encoding.ASCII.GetBytes("exit"))
            chatOn = False
        Catch ex As Exception

        End Try

        If waitingMessage.IsAlive Then
            waitingMessage.Join()
        End If
        Application.Exit()
    End Sub


    'Public Sub SetStyle(ByVal c As Control, ByVal Style As ControlStyles, ByVal value As Boolean
    'End Sub



    'Public input As String
    'Private stringData As String
    'Dim data(1024) As Byte
    'Dim clientip As String
    'Dim ipep As IPEndPoint
    'Dim server As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    'Dim client As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
    'Dim recv As Integer
    'Private numbre As Integer
    'Dim yPos As Integer
    'Dim auxiliarMensaje As String
    'Dim nCaracteres As Integer

    'Dim userName As String

    'Public Sub New(_userName As String)

    '    ' Llamada necesaria para el diseñador.
    '    InitializeComponent()

    '    ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
    '    userName = _userName

    'End Sub

    ''cerrar la aplicacion
    'Private Sub Cerrar11_Click(sender As Object, e As EventArgs) Handles Cerrar11.Click
    '    server.Shutdown(SocketShutdown.Both)
    '    server.Close()
    '    Application.Exit()
    'End Sub

    ''boton de archivo
    'Private Sub Enviar1_Click(sender As Object, e As EventArgs) Handles Enviar1.Click
    '    OpenFileDialog1.Filter = "Text File (*.txt)| * .txt; | PDF File (*.pdf)| * .pdf;| Word File (*.doc,*.docx)| *.doc;*.docx;  "
    '    If OpenFileDialog1.ShowDialog = DialogResult.OK Then
    '        msg.Text = OpenFileDialog1.FileName
    '    End If
    'End Sub

    ''conectar con el servidor
    'Private Sub conectar()
    '    Try
    '        server.Connect(ipep)
    '    Catch e As SocketException
    '        MsgBox("Imposible conectar con el servidor" & e.ToString(), MsgBoxStyle.OkOnly, "Error")
    '        Me.Close()
    '    End Try
    'End Sub

    '' cargar el form
    'Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    yPos = 10
    '    'ipep = New IPEndPoint(IPAddress.Parse("127.0.0.1"), 1900)
    '    'ipep = New IPEndPoint(IPAddress.Parse("192.168.1.111"), 1900)
    '    ipep = New IPEndPoint(IPAddress.Parse("192.168.1.65"), 1900)
    '    server.ReceiveTimeout = 50
    '    conectar()
    '    login.txtb_correo.Text = userName

    'End Sub

    ''boton enviar
    'Private Sub Send_Click(sender As Object, e As EventArgs) Handles Send.Click
    '    envioDatos()

    '    msg.Clear()
    '    data(1024) = New Byte
    'End Sub

    'Private Sub msg_TextChanged(sender As Object, e As EventArgs) Handles msg.TextChanged

    'End Sub

    'Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
    '    Try
    '        recv = server.Receive(data)
    '    Catch
    '        Exit Sub
    '    End Try
    '    stringData = Encoding.ASCII.GetString(data, 0, recv)

    '    If stringData <> Nothing Then
    '        'labelmagico(stringData)
    '    End If
    'End Sub
    'Private Sub textBox1_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) _
    'Handles msg.KeyDown
    '    Select Case e.KeyData
    '        Case Keys.Enter
    '            envioDatos()
    '    End Select
    '    'If e.KeyCode = Keys.Enter AndAlso e.Control Then
    '    '    msg.Text = msg.Text + vbCrLf
    '    'End If

    'End Sub
    'Public Sub envioDatos()
    '    input = msg.Text
    '    server.Send(Encoding.ASCII.GetBytes(input))
    '    'labelmagico(msg.Text)
    '    'listboxDinamico()
    '    listbox2()

    '    msg.Clear()
    'End Sub

    'Public Sub listbox2()
    '    RichTextBox1.AppendText(userName & ": " & msg.Text & vbCrLf)

    '    For i As Integer = 0 To RichTextBox1.Lines.Length - 1
    '        Dim first As Integer = RichTextBox1.GetFirstCharIndexFromLine(i)
    '        RichTextBox1.Select(first, RichTextBox1.Lines(i).Length)
    '        'Dim var As String = RichTextBox1.Lines(i).Contains("nombre")
    '        RichTextBox1.SelectionBackColor = If((RichTextBox1.Lines(i).Contains(userName)), Color.Blue, Color.Beige)
    '        RichTextBox1.SelectionColor = If((RichTextBox1.Lines(i).Contains(userName)), Color.White, Color.Black)
    '    Next
    '    msg.Text = ""
    'End Sub

    'Public Sub listboxDinamico()
    '    RichTextBox1.AppendText(msg.Text & vbCrLf)

    '    For i As Integer = 0 To RichTextBox1.Lines.Length - 1
    '        Dim lines() As String = RichTextBox1.Lines
    '        RichTextBox1.Lines = lines

    '        RichTextBox1.Select(RichTextBox1.GetFirstCharIndexFromLine(i), lines(i).Length)
    '        RichTextBox1.SelectionColor = colorForLine(lines(i))
    '    Next
    '    msg.Text = ""
    'End Sub

    'Function colorForLine(line As String)
    '    Dim var As Color
    '    If line.Contains("nombre") Then
    '        var = Color.Green
    '    End If
    '    Return var
    'End Function

    'Public Function nombreUsuario(userName As String)
    '    login.txtb_correo.Text = userName
    '    Return userName
    'End Function

    ''Public Sub labelmagico(aux As String)

    ''    Dim cadena(9) As String
    ''    Dim lblAux As New Label()
    ''    lblAux.AutoSize = True
    ''    lblAux.Text = aux
    ''    'Para contar el numero de bloques de memoria 
    ''    If (Len(lblAux.Text) Mod 20) > 0 Then
    ''        auxiliarMensaje = (Len(lblAux.Text) / 20)
    ''    End If
    ''    For i As Integer = 0 To auxiliarMensaje - 1
    ''        Dim lblAux2 As New Label()
    ''        lblAux2.AutoSize = True

    ''        cadena(i) = Mid(lblAux.Text, 1 + i * 20, 20)
    ''        lblAux2.Text = cadena(i) + vbCr
    ''        lblAux2.Location = New Point(10, yPos + 25)
    ''        yPos += 25
    ''        Me.Controls.Add(lblAux2)
    ''        GroupBox1.Controls.Add(lblAux2)
    ''    Next

    ''    lblAux.Location = New Point(10, yPos)
    ''    Me.Controls.Add(lblAux)
    ''    yPos += 25
    ''    GroupBox1.Controls.Add(lblAux)

    ''    msg.Text = ""
    ''    ' Add the Groupbox to the form.
    ''    Me.Controls.Add(GroupBox1)
    ''    PictureBox1.SendToBack()


    ''End Sub


    Private Sub btn_camara_Click(sender As Object, e As EventArgs) Handles btn_camara.Click

        'videoLlamada.RELOJWEBCAM.Enabled = True
        videoLlamada.Show()
    End Sub

End Class
