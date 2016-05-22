Imports System.IO
Imports System.Collections

Public Class FifoStream
    Inherits Stream
    Private Const BlockSize As Integer = 65536
    Private Const MaxBlocksInCache As Integer = (3 * 1024 * 1024) / BlockSize

    Private m_Size As Integer
    Private m_RPos As Integer
    Private m_WPos As Integer
    Private m_UsedBlocks As New Stack()
    Private m_Blocks As New ArrayList()

    Private Function AllocBlock() As Byte()
        Dim Result As Byte() = Nothing
        Result = If(m_UsedBlocks.Count > 0, DirectCast(m_UsedBlocks.Pop(), Byte()), New Byte(BlockSize - 1) {})
        Return Result
    End Function
    Private Sub FreeBlock(block As Byte())
        If m_UsedBlocks.Count < MaxBlocksInCache Then
            m_UsedBlocks.Push(block)
        End If
    End Sub
    Private Function GetWBlock() As Byte()
        Dim Result As Byte() = Nothing
        If m_WPos < BlockSize AndAlso m_Blocks.Count > 0 Then
            Result = DirectCast(m_Blocks(m_Blocks.Count - 1), Byte())
        Else
            Result = AllocBlock()
            m_Blocks.Add(Result)
            m_WPos = 0
        End If
        Return Result
    End Function

    ' Stream members
    Public Overrides ReadOnly Property CanRead() As Boolean
        Get
            Return True
        End Get
    End Property
    Public Overrides ReadOnly Property CanSeek() As Boolean
        Get
            Return False
        End Get
    End Property
    Public Overrides ReadOnly Property CanWrite() As Boolean
        Get
            Return True
        End Get
    End Property
    Public Overrides ReadOnly Property Length() As Long
        Get
            SyncLock Me
                Return m_Size
            End SyncLock
        End Get
    End Property
    Public Overrides Property Position() As Long
        Get
            Throw New InvalidOperationException()
        End Get
        Set(value As Long)
            Throw New InvalidOperationException()
        End Set
    End Property
    Public Overrides Sub Close()
        Flush()
    End Sub
    Public Overrides Sub Flush()
        SyncLock Me
            For Each block As Byte() In m_Blocks
                FreeBlock(block)
            Next
            m_Blocks.Clear()
            m_RPos = 0
            m_WPos = 0
            m_Size = 0
        End SyncLock
    End Sub
    Public Overrides Sub SetLength(len As Long)
        Throw New InvalidOperationException()
    End Sub
    Public Overrides Function Seek(pos As Long, o As SeekOrigin) As Long
        Throw New InvalidOperationException()
    End Function
    Public Overrides Function Read(buf As Byte(), ofs As Integer, count As Integer) As Integer
        SyncLock Me
            Dim Result As Integer = Peek(buf, ofs, count)
            Advance(Result)
            Return Result
        End SyncLock
    End Function
    Public Overrides Sub Write(buf As Byte(), ofs As Integer, count As Integer)
        SyncLock Me
            Dim Left As Integer = count
            While Left > 0
                Dim ToWrite As Integer = Math.Min(BlockSize - m_WPos, Left)
                Array.Copy(buf, ofs + count - Left, GetWBlock(), m_WPos, ToWrite)
                m_WPos += ToWrite
                Left -= ToWrite
            End While
            m_Size += count
        End SyncLock
    End Sub

    ' extra stuff
    Public Function Advance(count As Integer) As Integer
        SyncLock Me
            Dim SizeLeft As Integer = count
            While SizeLeft > 0 AndAlso m_Size > 0
                If m_RPos = BlockSize Then
                    m_RPos = 0
                    FreeBlock(DirectCast(m_Blocks(0), Byte()))
                    m_Blocks.RemoveAt(0)
                End If
                Dim ToFeed As Integer = If(m_Blocks.Count = 1, Math.Min(m_WPos - m_RPos, SizeLeft), Math.Min(BlockSize - m_RPos, SizeLeft))
                m_RPos += ToFeed
                SizeLeft -= ToFeed
                m_Size -= ToFeed
            End While
            Return count - SizeLeft
        End SyncLock
    End Function
    Public Function Peek(buf As Byte(), ofs As Integer, count As Integer) As Integer
        SyncLock Me
            Dim SizeLeft As Integer = count
            Dim TempBlockPos As Integer = m_RPos
            Dim TempSize As Integer = m_Size

            Dim CurrentBlock As Integer = 0
            While SizeLeft > 0 AndAlso TempSize > 0
                If TempBlockPos = BlockSize Then
                    TempBlockPos = 0
                    CurrentBlock += 1
                End If
                Dim Upper As Integer = If(CurrentBlock < m_Blocks.Count - 1, BlockSize, m_WPos)
                Dim ToFeed As Integer = Math.Min(Upper - TempBlockPos, SizeLeft)
                Array.Copy(DirectCast(m_Blocks(CurrentBlock), Byte()), TempBlockPos, buf, ofs + count - SizeLeft, ToFeed)
                SizeLeft -= ToFeed
                TempBlockPos += ToFeed
                TempSize -= ToFeed
            End While
            Return count - SizeLeft
        End SyncLock
    End Function
End Class

