Imports System.Runtime.InteropServices

Public Enum WaveFormats
    Pcm = 1
    Float = 3
End Enum

<StructLayout(LayoutKind.Sequential)> _
Public Class WaveFormat
    Public wFormatTag As Short
    Public nChannels As Short
    Public nSamplesPerSec As Integer
    Public nAvgBytesPerSec As Integer
    Public nBlockAlign As Short
    Public wBitsPerSample As Short
    Public cbSize As Short

    Public Sub New(rate As Integer, bits As Integer, channels As Integer)
        wFormatTag = CShort(WaveFormats.Pcm)
        nChannels = CShort(channels)
        nSamplesPerSec = rate
        wBitsPerSample = CShort(bits)
        cbSize = 0

        nBlockAlign = CShort(channels * (bits \ 8))
        nAvgBytesPerSec = nSamplesPerSec * nBlockAlign
    End Sub
End Class

Friend Class WaveNative
    ' consts
    Public Const MMSYSERR_NOERROR As Integer = 0
    ' no error
    Public Const MM_WOM_OPEN As Integer = &H3BB
    Public Const MM_WOM_CLOSE As Integer = &H3BC
    Public Const MM_WOM_DONE As Integer = &H3BD

    Public Const MM_WIM_OPEN As Integer = &H3BE
    Public Const MM_WIM_CLOSE As Integer = &H3BF
    Public Const MM_WIM_DATA As Integer = &H3C0

    Public Const CALLBACK_FUNCTION As Integer = &H30000
    ' dwCallback is a FARPROC 
    Public Const TIME_MS As Integer = &H1
    ' time in milliseconds 
    Public Const TIME_SAMPLES As Integer = &H2
    ' number of wave samples 
    Public Const TIME_BYTES As Integer = &H4
    ' current byte offset 
    ' callbacks
    Public Delegate Sub WaveDelegate(hdrvr As IntPtr, uMsg As Integer, dwUser As Integer, ByRef wavhdr As WaveHdr, dwParam2 As Integer)

    ' structs 

    <StructLayout(LayoutKind.Sequential)> _
    Public Structure WaveHdr
        Public lpData As IntPtr
        ' pointer to locked data buffer
        Public dwBufferLength As Integer
        ' length of data buffer
        Public dwBytesRecorded As Integer
        ' used for input only
        Public dwUser As IntPtr
        ' for client's use
        Public dwFlags As Integer
        ' assorted flags (see defines)
        Public dwLoops As Integer
        ' loop control counter
        Public lpNext As IntPtr
        ' PWaveHdr, reserved for driver
        Public reserved As Integer
        ' reserved for driver
    End Structure

    Private Const mmdll As String = "winmm.dll"

    ' WaveOut calls
    <DllImport(mmdll)> _
    Public Shared Function waveOutGetNumDevs() As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutPrepareHeader(hWaveOut As IntPtr, ByRef lpWaveOutHdr As WaveHdr, uSize As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutUnprepareHeader(hWaveOut As IntPtr, ByRef lpWaveOutHdr As WaveHdr, uSize As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutWrite(hWaveOut As IntPtr, ByRef lpWaveOutHdr As WaveHdr, uSize As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutOpen(ByRef hWaveOut As IntPtr, uDeviceID As Integer, lpFormat As WaveFormat, dwCallback As WaveDelegate, dwInstance As Integer, dwFlags As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutReset(hWaveOut As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutClose(hWaveOut As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutPause(hWaveOut As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutRestart(hWaveOut As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutGetPosition(hWaveOut As IntPtr, ByRef lpInfo As Integer, uSize As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutSetVolume(hWaveOut As IntPtr, dwVolume As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveOutGetVolume(hWaveOut As IntPtr, ByRef dwVolume As Integer) As Integer
    End Function

    ' WaveIn calls
    <DllImport(mmdll)> _
    Public Shared Function waveInGetNumDevs() As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInAddBuffer(hwi As IntPtr, ByRef pwh As WaveHdr, cbwh As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInClose(hwi As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInOpen(ByRef phwi As IntPtr, uDeviceID As Integer, lpFormat As WaveFormat, dwCallback As WaveDelegate, dwInstance As Integer, dwFlags As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInPrepareHeader(hWaveIn As IntPtr, ByRef lpWaveInHdr As WaveHdr, uSize As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInUnprepareHeader(hWaveIn As IntPtr, ByRef lpWaveInHdr As WaveHdr, uSize As Integer) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInReset(hwi As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInStart(hwi As IntPtr) As Integer
    End Function
    <DllImport(mmdll)> _
    Public Shared Function waveInStop(hwi As IntPtr) As Integer
    End Function
End Class

