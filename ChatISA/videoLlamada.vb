Imports System.Net.Sockets
Imports System.Text.Encoding
Imports System.Net
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.InteropServices
Imports System.Speech.Recognition
Imports System.Drawing.Imaging
Imports System.Threading



Public Class videoLlamada
    Dim YO As New TcpClient
    'Dim NS As NetworkStream
    Dim var As WaveOutHelper

    'Dim INICIADO As Boolean = False

    Public Const WM_CAP As Short = &H400S
    Public Const WM_CAP_DLG_VIDEOFORMAT As Integer = WM_CAP + 41
    Public Const WM_CAP_DRIVER_CONNECT As Integer = WM_CAP + 10
    Public Const WM_CAP_DRIVER_DISCONNECT As Integer = WM_CAP + 11
    Public Const WM_CAP_EDIT_COPY As Integer = WM_CAP + 30
    Public Const WM_CAP_SEQUENCE As Integer = WM_CAP + 62
    Public Const WM_CAP_FILE_SAVEAS As Integer = WM_CAP + 23
    Public Const WM_CAP_SET_PREVIEW As Integer = WM_CAP + 50
    Public Const WM_CAP_SET_PREVIEWRATE As Integer = WM_CAP + 52
    Public Const WM_CAP_SET_SCALE As Integer = WM_CAP + 53
    Public Const WS_CHILD As Integer = &H40000000
    Public Const WS_VISIBLE As Integer = &H10000000
    Public Const SWP_NOMOVE As Short = &H2S
    Public Const SWP_NOSIZE As Short = 1
    Public Const SWP_NOZORDER As Short = &H4S
    Public Const HWND_BOTTOM As Short = 1
    Public Const WM_CAP_STOP As Integer = WM_CAP + 68

    'Dim ARCHIVO_RECIBIDO As String = "C:\ULTIMA_GRABACION_RECIBIDA.WAV"
    'Dim ARCHIVO_ENVIADO As String = "C:\ULTIMA_GRABACION_ENVIADA.WAV"

    Public iDevice As Integer = 0 ' Current device ID
    Public hHwnd As Integer ' Handle to preview window

    Public Declare Function SendMessage Lib "user32" Alias "SendMessageA" _
        (ByVal hwnd As Integer, ByVal wMsg As Integer, ByVal wParam As Integer, _
        <MarshalAs(UnmanagedType.AsAny)> ByVal lParam As Object) As Integer

    Public Declare Function SetWindowPos Lib "user32" Alias "SetWindowPos" (ByVal hwnd As Integer, _
        ByVal hWndInsertAfter As Integer, ByVal x As Integer, ByVal y As Integer, _
        ByVal cx As Integer, ByVal cy As Integer, ByVal wFlags As Integer) As Integer

    Public Declare Function DestroyWindow Lib "user32" (ByVal hndw As Integer) As Boolean

    Public Declare Function capCreateCaptureWindowA Lib "avicap32.dll" _
        (ByVal lpszWindowName As String, ByVal dwStyle As Integer, _
        ByVal x As Integer, ByVal y As Integer, ByVal nWidth As Integer, _
        ByVal nHeight As Short, ByVal hWndParent As Integer, _
        ByVal nID As Integer) As Integer

    Public Declare Function capGetDriverDescriptionA Lib "avicap32.dll" (ByVal wDriver As Short, _
        ByVal lpszName As String, ByVal cbName As Integer, ByVal lpszVer As String, _
        ByVal cbVer As Integer) As Boolean


    Dim DATOS As IDataObject
    Dim IMAGENCAMARA As Image

    Dim ENVIANTE As New UdpClient() 'WEBCAM
    Dim RECEPTOR As New UdpClient(2000) 'WEBCAM

    Dim ENVIANTEAUDIO As New UdpClient() ' AUDIO
    Dim RECEPTORAUDIO As New UdpClient(4000) ' AUDIO

    Dim SERVIDOR As TcpListener
    Dim CLIENTE As TcpClient
    Dim ARCHIVO As String

    Dim BM As Bitmap
    Dim BM2 As Bitmap
    Dim DIBUJO As Graphics
    Dim AJUSTETAMAÑO As Integer = 4

    '-----------
    'Dim YO As TcpListener
    Dim REMOTO As TcpClient
    Dim RECIBE As Thread
    Dim NS As NetworkStream
    Dim IMAGEN As Image
    Dim INICIADO As Boolean = False
    '-------------


    Private Const TAMAÑOBUFFER As Integer = 1024

    Dim REC As New SpeechRecognitionEngine

    <DllImport("winmm.dll")> _
    Private Shared Function mciSendString(ByVal command As String, ByVal buffer As String, ByVal bufferSize As Integer, ByVal hwndCallback As IntPtr) As Integer
    End Function

    '**************    
    Private Sub videoLlamada_FormClosed(sender As Object, e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed
        'CIERRA EL NETWORSTREAM Y EL TCPCLIENT ANTES DE CERRAR EL FORMULARIO
        Try
            NS.Dispose()
        Catch ex As Exception
        End Try
        Try
            YO.Close()
            RECIBE.Abort()
        Catch ex As Exception
        End Try
    End Sub

    Private Sub videoLlamada_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Dim imagen1 As New Image

        RECEPTOR.Client.ReceiveTimeout = 100 'TIEMPO PARA PASAR A ESPERA
        RECEPTOR.Client.Blocking = False 'RECEPTOR NO BLOQUEADO

        RECEPTORAUDIO.Client.ReceiveTimeout = 100 'TIEMPO PARA PASAR A ESPERA
        RECEPTORAUDIO.Client.Blocking = False 'RECEPTOR NO BLOQUEADO

        RELOJRECIBEAUDIO.Enabled = True
        'IMAGENCAMARA = New Image()
        'conexion()
    End Sub

    Private Sub Form_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        SendMessage(hHwnd, WM_CAP_DRIVER_DISCONNECT, iDevice, 0)
        RECEPTOR.Close()
        RECEPTORAUDIO.Close()
        'ENVIANTE.Close()
        'RECEPTOR.Close()

    End Sub
    '*****************
    Public Sub OpenPreviewWindow()
        hHwnd = capCreateCaptureWindowA(iDevice, WS_VISIBLE Or WS_CHILD, 0, 0, 640, _
           480, PictureboxVISOR.Handle.ToInt32, 0)
        Dim contador As Integer = 0

        For i = 1 To 10
            Dim conectado As Integer = SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0)
            'SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0)
            If conectado = 1 Then 'SendMessage(hHwnd, WM_CAP_DRIVER_CONNECT, iDevice, 0) Then
                SendMessage(hHwnd, WM_CAP_SET_SCALE, True, 0)
                SendMessage(hHwnd, WM_CAP_SET_PREVIEWRATE, 66, 0)
                SendMessage(hHwnd, WM_CAP_SET_PREVIEW, True, 0)
                SetWindowPos(hHwnd, HWND_BOTTOM, 0, 0, PictureboxVISOR.Width, PictureboxVISOR.Height, SWP_NOMOVE Or SWP_NOZORDER)
                btn_iniciar.Visible = False
            Else
                contador = 1
            End If
        Next
        If contador = 10 Then
            DestroyWindow(hHwnd)
            MsgBox("No puedo conectar la camara")
        End If
    End Sub

    '***************
    Private Sub btn_iniciar_Click(sender As Object, e As EventArgs) Handles btn_iniciar.Click
        Try
            OpenPreviewWindow()
            INICIADO = True
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    '***************
    Private Sub RELOJWEBCAM_Tick(sender As System.Object, e As System.EventArgs) Handles RELOJWEBCAM.Tick
        ' Copy image to clipboard
        Dim BF As New BinaryFormatter
        Try
            NS = YO.GetStream
            If NS.DataAvailable Then
                PictureBoxRECIBIR.Image = BF.Deserialize(NS)
            End If
        Catch ex As Exception
        End Try
        'ENVIA LAS IMAGENES AL SERVIDOR
        If INICIADO = True Then
            Try
                SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)
                Dim DATOS = Clipboard.GetDataObject
                Dim IMAGEN As Image = CType(DATOS.GetData(GetType(Bitmap)), Image)
                Dim MS As New MemoryStream
                IMAGEN.Save(MS, Imaging.ImageFormat.Jpeg)
                IMAGEN = Image.FromStream(MS)
                NS = YO.GetStream
                BF.Serialize(NS, IMAGEN)
            Catch ex As Exception
            End Try
        End If
    End Sub

    Public Sub conexion()
        Me.RELOJWEBCAM.Enabled = True
    End Sub

    'Private Sub RELOJDETECCION_Tick(sender As System.Object, e As System.EventArgs) Handles RELOJDETECCION.Tick
    '    ' Copy image to clipboard
    '    '
    '    SendMessage(hHwnd, WM_CAP_EDIT_COPY, 0, 0)

    '    ' Get image from clipboard and convert it to a bitmap
    '    '
    '    DATOS = Clipboard.GetDataObject()

    '    IMAGENCAMARA = CType(DATOS.GetData(GetType(System.Drawing.Bitmap)), Image)
    '    'ENVIANTE.Connect(LabelIP.Text, 2000) 'SE CONECTA CON EL RECEPTOR
    '    Dim ARRAY As New MemoryStream()
    '    IMAGENCAMARA.Save(ARRAY, Imaging.ImageFormat.Jpeg)
    '    Dim IMAGEN_ARRAY As Byte() = ARRAY.ToArray
    '    ENVIANTE.Send(IMAGEN_ARRAY, IMAGEN_ARRAY.Length) 'ENVIA EL MENSAJE

    '    Try
    '        Dim IP As IPEndPoint = New IPEndPoint(IPAddress.Any, 0) 'RECIBIRA DESDE CUALQUIER IP, POR CUALQUIER PUERTO
    '        Dim RECIBEMENSAJE As Byte() = RECEPTOR.Receive(IP) 'RECIBE EL MENSAJE EN BYTES

    '        Dim IMAGEN As New MemoryStream(RECIBEMENSAJE)
    '        Dim IMAGENRECIBIDA As Image = Image.FromStream(IMAGEN)
    '        'DETECCION_DE_MOVIMIENTO_REMOTO.PictureBoxRECIBIR.Image = IMAGENRECIBIDA
    '    Catch ex As Exception

    '    End Try
    'End Sub


    Private Sub RELOJRECIBEAUDIO_Tick(sender As System.Object, e As System.EventArgs) Handles RELOJRECIBEAUDIO.Tick
        Try

            Dim IP As IPEndPoint = New IPEndPoint(IPAddress.Any, 0) 'RECIBIRA DESDE CUALQUIER IP, POR CUALQUIER PUERTO
            Dim RECIBEMENSAJE As Byte() = RECEPTORAUDIO.Receive(IP) 'RECIBE EL MENSAJE EN BYTES


            If My.Computer.FileSystem.FileExists("ULTIMA_GRABACION_RECIBIDA.WAV") Then
                MsgBox("File found.")
            Else
                MsgBox("File not found.")
            End If

            'System.IO.File.WriteAllBytes(ARCHIVO_RECIBIDO, RECIBEMENSAJE) 'CODIFICA EN BYTES
            'My.Computer.Audio.Play(ARCHIVO_RECIBIDO, AudioPlayMode.WaitToComplete)
            'My.Computer.FileSystem.DeleteFile(ARCHIVO_RECIBIDO)

        Catch ex As Exception

        End Try
    End Sub



    'Private Sub btn_hablar_MouseDown(sender As Object, e As EventArgs) Handles btn_hablar.Click
    '    'btn_hablar.BackColor = Color.Red
    '    'mciSendString("open new Type waveaudio Alias recsound", "", 0, 0)
    '    'mciSendString("record recsound", "", 0, 0)

    'End Sub

    'Private Sub btn_hablar_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles btn_hablar.MouseUp
    '    btn_hablar.BackColor = Color.Black
    '    mciSendString("save recsound " & ARCHIVO_ENVIADO, "", 0, 0)
    '    mciSendString("close recsound ", "", 0, 0)
    '    'ENVIANTEAUDIO.Connect(LabelIP.Text, 4000)  'SE CONECTA CON EL RECEPTOR
    '    Dim VOZ_ENVIAR As Byte() = System.IO.File.ReadAllBytes(ARCHIVO_ENVIADO) 'CODIFICA EN BYTES
    '    ENVIANTEAUDIO.Send(VOZ_ENVIAR, VOZ_ENVIAR.Length) 'ENVIA EL MENSAJE
    '    My.Computer.FileSystem.DeleteFile(ARCHIVO_ENVIADO)
    'End Sub


    Private m_Player As WaveOutPlayer
    Private m_Recorder As WaveInRecorder
    Private m_Fifo As New FifoStream()

    Private m_PlayBuffer As Byte()
    Private m_RecBuffer As Byte()
    Private r As Socket
    Private t As Thread
    Private connected As Boolean = False
    Dim PUERTO As Integer = 9000

    Private Sub btn_hablar_Click(sender As Object, e As EventArgs) Handles btn_hablar.Click
        btn_finAudio.Enabled = True
        btn_hablar.Enabled = False
        If connected = False Then
            t.Start()
            connected = True
        End If

        Start()
    End Sub

    Private Sub Start()
        [Stop]()
        Try
            Dim fmt As New WaveFormat(44100, 16, 2)
            m_Player = New WaveOutPlayer(-1, fmt, 16384, 3, New BufferFillEventHandler(AddressOf Filler))
            m_Recorder = New WaveInRecorder(-1, fmt, 16384, 3, New BufferDoneEventHandler(AddressOf Voice_Out))
        Catch
            [Stop]()
            Throw
        End Try
    End Sub

    Private Sub [Stop]()
        If m_Player IsNot Nothing Then
            Try
                m_Player.Dispose()
            Finally
                m_Player = Nothing
            End Try
        End If
        If m_Recorder IsNot Nothing Then
            Try
                m_Recorder.Dispose()
            Finally
                m_Recorder = Nothing
            End Try
        End If
        m_Fifo.Flush()
        ' clear all pending data
    End Sub

    Private Sub Filler(data As IntPtr, size As Integer)
        If m_PlayBuffer Is Nothing OrElse m_PlayBuffer.Length < size Then
            m_PlayBuffer = New Byte(size - 1) {}
        End If
        If m_Fifo.Length >= size Then
            m_Fifo.Read(m_PlayBuffer, 0, size)
        Else
            For i As Integer = 0 To m_PlayBuffer.Length - 1
                m_PlayBuffer(i) = 0
            Next
        End If
        System.Runtime.InteropServices.Marshal.Copy(m_PlayBuffer, 0, data, size)
        ' m_Fifo ==> m_PlayBuffer==> data ==> Speakers
    End Sub

    Private Sub Voice_Out(data As IntPtr, size As Integer)
        'for Recorder
        If m_RecBuffer Is Nothing OrElse m_RecBuffer.Length < size Then
            m_RecBuffer = New Byte(size - 1) {}
        End If
        System.Runtime.InteropServices.Marshal.Copy(data, m_RecBuffer, 0, size)
        'Microphone ==> data ==> m_RecBuffer ==> m_Fifo
        r.SendTo(m_RecBuffer, New IPEndPoint(IPAddress.Parse("192.168.0.84"), PUERTO))
    End Sub

    '*****************
    Private Sub btn_conexionCamara_Click(sender As Object, e As EventArgs) Handles btn_conexionCamara.Click
        Try
            'Dim DATOS As String = My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\SERVIDOR.txt")
            ' Dim DATOSSERVIDOR() As String = DATOS.Split(":")
            Dim IPSERVIDOR As String = "192.168.43.19"
            'Dim PUERTO As Integer = "192.168.43.19"
            YO.Connect(IPSERVIDOR, PUERTO)
            RELOJWEBCAM.Interval = 1000
            RELOJWEBCAM.Start()
            btn_conexionCamara.Visible = False
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    '************
    'Public Sub RECIBIR()
    '    'ESPERANDO IMAGENES DEL CLIENTE
    '    Dim BF As New BinaryFormatter
    '    Try
    '        While True
    '            REMOTO = YO.AcceptTcpClient()
    '            NS = REMOTO.GetStream
    '            While REMOTO.Connected = True
    '                Try
    '                    PictureBoxRECIBIR.Image = BF.Deserialize(NS)
    '                Catch ex As Exception
    '                End Try
    '            End While
    '        End While
    '    Catch ex As Exception
    '    End Try
    'End Sub

End Class