Imports System.Threading
Imports System.Runtime.InteropServices

Friend Class WaveOutHelper
    Public Shared Sub [Try](err As Integer)
        If err <> WaveNative.MMSYSERR_NOERROR Then
            Throw New Exception(err.ToString())
        End If
    End Sub
End Class

Public Delegate Sub BufferFillEventHandler(data As IntPtr, size As Integer)

Friend Class WaveOutBuffer
    Implements IDisposable
    Public NextBuffer As WaveOutBuffer

    Private m_PlayEvent As New AutoResetEvent(False)
    Private m_WaveOut As IntPtr

    Private m_Header As WaveNative.WaveHdr
    Private m_HeaderData As Byte()
    Private m_HeaderHandle As GCHandle
    Private m_HeaderDataHandle As GCHandle

    Private m_Playing As Boolean

    Friend Shared Sub WaveOutProc(hdrvr As IntPtr, uMsg As Integer, dwUser As Integer, ByRef wavhdr As WaveNative.WaveHdr, dwParam2 As Integer)
        If uMsg = WaveNative.MM_WOM_DONE Then
            Try
                Dim h As GCHandle = CType(wavhdr.dwUser, GCHandle)
                Dim buf As WaveOutBuffer = DirectCast(h.Target, WaveOutBuffer)
                buf.OnCompleted()
            Catch
            End Try
        End If
    End Sub

    Public Sub New(waveOutHandle As IntPtr, size As Integer)
        m_WaveOut = waveOutHandle

        m_HeaderHandle = GCHandle.Alloc(m_Header, GCHandleType.Pinned)
        m_Header.dwUser = CType(GCHandle.Alloc(Me), IntPtr)
        m_HeaderData = New Byte(size - 1) {}
        m_HeaderDataHandle = GCHandle.Alloc(m_HeaderData, GCHandleType.Pinned)
        m_Header.lpData = m_HeaderDataHandle.AddrOfPinnedObject()
        m_Header.dwBufferLength = size
        WaveOutHelper.[Try](WaveNative.waveOutPrepareHeader(m_WaveOut, m_Header, Marshal.SizeOf(m_Header)))
    End Sub
    Protected Overrides Sub Finalize()
        Try
            Dispose()
        Finally
            MyBase.Finalize()
        End Try
    End Sub
    Public Sub Dispose() Implements IDisposable.Dispose
        If m_Header.lpData <> IntPtr.Zero Then
            WaveNative.waveOutUnprepareHeader(m_WaveOut, m_Header, Marshal.SizeOf(m_Header))
            m_HeaderHandle.Free()
            m_Header.lpData = IntPtr.Zero
        End If
        m_PlayEvent.Close()
        If m_HeaderDataHandle.IsAllocated Then
            m_HeaderDataHandle.Free()
        End If
        GC.SuppressFinalize(Me)
    End Sub

    Public ReadOnly Property Size() As Integer
        Get
            Return m_Header.dwBufferLength
        End Get
    End Property

    Public ReadOnly Property Data() As IntPtr
        Get
            Return m_Header.lpData
        End Get
    End Property

    Public Function Play() As Boolean
        SyncLock Me
            m_PlayEvent.Reset()
            m_Playing = WaveNative.waveOutWrite(m_WaveOut, m_Header, Marshal.SizeOf(m_Header)) = WaveNative.MMSYSERR_NOERROR
            Return m_Playing
        End SyncLock
    End Function
    Public Sub WaitFor()
        If m_Playing Then
            m_Playing = m_PlayEvent.WaitOne()
        Else
            Thread.Sleep(0)
        End If
    End Sub
    Public Sub OnCompleted()
        m_PlayEvent.[Set]()
        m_Playing = False
    End Sub
End Class

Public Class WaveOutPlayer
    Implements IDisposable
    Private m_WaveOut As IntPtr
    Private m_Buffers As WaveOutBuffer
    ' linked list
    Private m_CurrentBuffer As WaveOutBuffer
    Private m_Thread As Thread
    Private m_FillProc As BufferFillEventHandler
    Private m_Finished As Boolean
    Private m_zero As Byte

    Private m_BufferProc As New WaveNative.WaveDelegate(AddressOf WaveOutBuffer.WaveOutProc)

    Public Shared ReadOnly Property DeviceCount() As Integer
        Get
            Return WaveNative.waveOutGetNumDevs()
        End Get
    End Property

    Public Sub New(device As Integer, format As WaveFormat, bufferSize As Integer, bufferCount As Integer, fillProc As BufferFillEventHandler)
        m_zero = If(format.wBitsPerSample = 8, CByte(128), CByte(0))
        m_FillProc = fillProc
        WaveOutHelper.[Try](WaveNative.waveOutOpen(m_WaveOut, device, format, m_BufferProc, 0, WaveNative.CALLBACK_FUNCTION))
        AllocateBuffers(bufferSize, bufferCount)
        m_Thread = New Thread(New ThreadStart(AddressOf ThreadProc))
        m_Thread.Start()
    End Sub
    Protected Overrides Sub Finalize()
        Try
            Dispose()
        Finally
            MyBase.Finalize()
        End Try
    End Sub
    Public Sub Dispose() Implements IDisposable.Dispose
        If m_Thread IsNot Nothing Then
            Try
                m_Finished = True
                If m_WaveOut <> IntPtr.Zero Then
                    WaveNative.waveOutReset(m_WaveOut)
                End If
                m_Thread.Join()
                m_FillProc = Nothing
                FreeBuffers()
                If m_WaveOut <> IntPtr.Zero Then
                    WaveNative.waveOutClose(m_WaveOut)
                End If
            Finally
                m_Thread = Nothing
                m_WaveOut = IntPtr.Zero
            End Try
        End If
        GC.SuppressFinalize(Me)
    End Sub
    Private Sub ThreadProc()
        While Not m_Finished
            Advance()
            If m_FillProc IsNot Nothing AndAlso Not m_Finished Then
                m_FillProc(m_CurrentBuffer.Data, m_CurrentBuffer.Size)
            Else
                ' zero out buffer
                Dim v As Byte = m_zero
                Dim b As Byte() = New Byte(m_CurrentBuffer.Size - 1) {}
                For i As Integer = 0 To b.Length - 1
                    b(i) = v
                Next

                Marshal.Copy(b, 0, m_CurrentBuffer.Data, b.Length)
            End If
            m_CurrentBuffer.Play()
        End While
        WaitForAllBuffers()
    End Sub
    Private Sub AllocateBuffers(bufferSize As Integer, bufferCount As Integer)
        FreeBuffers()
        If bufferCount > 0 Then
            m_Buffers = New WaveOutBuffer(m_WaveOut, bufferSize)
            Dim Prev As WaveOutBuffer = m_Buffers
            Try
                For i As Integer = 1 To bufferCount - 1
                    Dim Buf As New WaveOutBuffer(m_WaveOut, bufferSize)
                    Prev.NextBuffer = Buf
                    Prev = Buf
                Next
            Finally
                Prev.NextBuffer = m_Buffers
            End Try
        End If
    End Sub
    Private Sub FreeBuffers()
        m_CurrentBuffer = Nothing
        If m_Buffers IsNot Nothing Then
            Dim First As WaveOutBuffer = m_Buffers
            m_Buffers = Nothing

            Dim Current As WaveOutBuffer = First
            Do
                Dim [Next] As WaveOutBuffer = Current.NextBuffer
                Current.Dispose()
                Current = [Next]
            Loop While Current IsNot First
        End If
    End Sub
    Private Sub Advance()
        m_CurrentBuffer = If(m_CurrentBuffer Is Nothing, m_Buffers, m_CurrentBuffer.NextBuffer)
        m_CurrentBuffer.WaitFor()
    End Sub
    Private Sub WaitForAllBuffers()
        Dim Buf As WaveOutBuffer = m_Buffers
        While Buf.NextBuffer IsNot m_Buffers
            Buf.WaitFor()
            Buf = Buf.NextBuffer
        End While
    End Sub
End Class

