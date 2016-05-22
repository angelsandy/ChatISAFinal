Imports System.Threading
Imports System.Runtime.InteropServices

Friend Class WaveInHelper
    Public Shared Sub [Try](err As Integer)
        If err <> WaveNative.MMSYSERR_NOERROR Then
            Throw New Exception(err.ToString())
        End If
    End Sub
End Class

Public Delegate Sub BufferDoneEventHandler(data As IntPtr, size As Integer)

Friend Class WaveInBuffer
    Implements IDisposable
    Public NextBuffer As WaveInBuffer

    Private m_RecordEvent As New AutoResetEvent(False)
    Private m_WaveIn As IntPtr

    Private m_Header As WaveNative.WaveHdr
    Private m_HeaderData As Byte()
    Private m_HeaderHandle As GCHandle
    Private m_HeaderDataHandle As GCHandle

    Private m_Recording As Boolean

    Friend Shared Sub WaveInProc(hdrvr As IntPtr, uMsg As Integer, dwUser As Integer, ByRef wavhdr As WaveNative.WaveHdr, dwParam2 As Integer)
        If uMsg = WaveNative.MM_WIM_DATA Then
            Try
                Dim h As GCHandle = CType(wavhdr.dwUser, GCHandle)
                Dim buf As WaveInBuffer = DirectCast(h.Target, WaveInBuffer)
                buf.OnCompleted()
            Catch
            End Try
        End If
    End Sub

    Public Sub New(waveInHandle As IntPtr, size As Integer)
        m_WaveIn = waveInHandle

        m_HeaderHandle = GCHandle.Alloc(m_Header, GCHandleType.Pinned)
        m_Header.dwUser = CType(GCHandle.Alloc(Me), IntPtr)
        m_HeaderData = New Byte(size - 1) {}
        m_HeaderDataHandle = GCHandle.Alloc(m_HeaderData, GCHandleType.Pinned)
        m_Header.lpData = m_HeaderDataHandle.AddrOfPinnedObject()
        m_Header.dwBufferLength = size
        WaveInHelper.[Try](WaveNative.waveInPrepareHeader(m_WaveIn, m_Header, Marshal.SizeOf(m_Header)))
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
            WaveNative.waveInUnprepareHeader(m_WaveIn, m_Header, Marshal.SizeOf(m_Header))
            m_HeaderHandle.Free()
            m_Header.lpData = IntPtr.Zero
        End If
        m_RecordEvent.Close()
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

    Public Function Record() As Boolean
        SyncLock Me
            m_RecordEvent.Reset()
            m_Recording = WaveNative.waveInAddBuffer(m_WaveIn, m_Header, Marshal.SizeOf(m_Header)) = WaveNative.MMSYSERR_NOERROR
            Return m_Recording
        End SyncLock
    End Function

    Public Sub WaitFor()
        If m_Recording Then
            m_Recording = m_RecordEvent.WaitOne()
        Else
            Thread.Sleep(0)
        End If
    End Sub

    Private Sub OnCompleted()
        m_RecordEvent.[Set]()
        m_Recording = False
    End Sub
End Class

Public Class WaveInRecorder
    Implements IDisposable
    Private m_WaveIn As IntPtr
    Private m_Buffers As WaveInBuffer
    ' linked list
    Private m_CurrentBuffer As WaveInBuffer
    Private m_Thread As Thread
    Private m_DoneProc As BufferDoneEventHandler
    Private m_Finished As Boolean

    Private m_BufferProc As New WaveNative.WaveDelegate(AddressOf WaveInBuffer.WaveInProc)

    Public Shared ReadOnly Property DeviceCount() As Integer
        Get
            Return WaveNative.waveInGetNumDevs()
        End Get
    End Property

    Public Sub New(device As Integer, format As WaveFormat, bufferSize As Integer, bufferCount As Integer, doneProc As BufferDoneEventHandler)
        m_DoneProc = doneProc
        WaveInHelper.[Try](WaveNative.waveInOpen(m_WaveIn, device, format, m_BufferProc, 0, WaveNative.CALLBACK_FUNCTION))
        AllocateBuffers(bufferSize, bufferCount)
        For i As Integer = 0 To bufferCount - 1
            SelectNextBuffer()
            m_CurrentBuffer.Record()
        Next
        WaveInHelper.[Try](WaveNative.waveInStart(m_WaveIn))
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
                If m_WaveIn <> IntPtr.Zero Then
                    WaveNative.waveInReset(m_WaveIn)
                End If
                WaitForAllBuffers()
                m_Thread.Join()
                m_DoneProc = Nothing
                FreeBuffers()
                If m_WaveIn <> IntPtr.Zero Then
                    WaveNative.waveInClose(m_WaveIn)
                End If
            Finally
                m_Thread = Nothing
                m_WaveIn = IntPtr.Zero
            End Try
        End If
        GC.SuppressFinalize(Me)
    End Sub
    Private Sub ThreadProc()
        While Not m_Finished
            Advance()
            If m_DoneProc IsNot Nothing AndAlso Not m_Finished Then
                m_DoneProc(m_CurrentBuffer.Data, m_CurrentBuffer.Size)
            End If
            m_CurrentBuffer.Record()
        End While
    End Sub
    Private Sub AllocateBuffers(bufferSize As Integer, bufferCount As Integer)
        FreeBuffers()
        If bufferCount > 0 Then
            m_Buffers = New WaveInBuffer(m_WaveIn, bufferSize)
            Dim Prev As WaveInBuffer = m_Buffers
            Try
                For i As Integer = 1 To bufferCount - 1
                    Dim Buf As New WaveInBuffer(m_WaveIn, bufferSize)
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
            Dim First As WaveInBuffer = m_Buffers
            m_Buffers = Nothing

            Dim Current As WaveInBuffer = First
            Do
                Dim [Next] As WaveInBuffer = Current.NextBuffer
                Current.Dispose()
                Current = [Next]
            Loop While Current IsNot First
        End If
    End Sub
    Private Sub Advance()
        SelectNextBuffer()
        m_CurrentBuffer.WaitFor()
    End Sub
    Private Sub SelectNextBuffer()
        m_CurrentBuffer = If(m_CurrentBuffer Is Nothing, m_Buffers, m_CurrentBuffer.NextBuffer)
    End Sub
    Private Sub WaitForAllBuffers()
        Dim Buf As WaveInBuffer = m_Buffers
        While Buf.NextBuffer IsNot m_Buffers
            Buf.WaitFor()
            Buf = Buf.NextBuffer
        End While
    End Sub
End Class