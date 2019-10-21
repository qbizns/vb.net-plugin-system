Imports System.Globalization
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Namespace Salling.Devices
    Public NotInheritable Class PortIO
        Implements IDisposable
        Private myEncoding As Encoding = Encoding.ASCII
        Private Const GENERIC_READ As UInteger = 2147483648UI
        Private Const GENERIC_WRITE As UInteger = 1073741824UI
        Private Const OPEN_EXISTING As UInteger = 3UI
        Private Const INVALID_HANDLE_VALUE As Integer = -1
        Private myHandle As IntPtr
        Private myPortName As String
        Private mySerialSettings As SerialSettings

        Public ReadOnly Property IsOpen() As Boolean
            Get
                Return Me.myHandle <> IntPtr.Zero
            End Get
        End Property

        Public Property Encoding() As Encoding
            Get
                Return Me.myEncoding
            End Get
            Set(value As Encoding)
                If value Is Nothing Then
                    Throw New ArgumentNullException("value")
                End If
                Me.myEncoding = value
            End Set
        End Property

        Public Property PortName() As String
            Get
                Return Me.myPortName
            End Get
            Set(value As String)
                Me.myPortName = value
            End Set
        End Property

        Public Property SerialSettings() As SerialSettings
            Get
                Return Me.mySerialSettings
            End Get
            Set(value As SerialSettings)
                Me.mySerialSettings = value
            End Set
        End Property

        Public ReadOnly Property CDHolding() As Boolean
            Get
                Return (128 And Me.GetStatus()) <> 0
            End Get
        End Property

        Public ReadOnly Property CtsHolding() As Boolean
            Get
                Return (16 And Me.GetStatus()) <> 0
            End Get
        End Property

        Public ReadOnly Property DsrHolding() As Boolean
            Get
                Return (32 And Me.GetStatus()) <> 0
            End Get
        End Property

        Public Sub New(portName As String)
            If portName Is Nothing Then
                Throw New ArgumentNullException("portName")
            End If
            Me.PortName = portName
            Me.Open()
        End Sub

        Public Sub New(setting As SerialSettings)
            If setting Is Nothing Then
                Throw New ArgumentNullException("setting")
            End If
            Me.SerialSettings = setting
            Me.Open()
        End Sub

        Protected Overrides Sub Finalize()
            Try
                Me.Dispose(False)
            Finally
                MyBase.Finalize()
            End Try
        End Sub

        Public Sub Dispose() Implements IDisposable.Dispose
            Me.Dispose(True)
            GC.SuppressFinalize(DirectCast(Me, Object))
        End Sub

        Private Sub Dispose(disposing As Boolean)
            Try
                Me.Close2(False)
            Catch
            End Try
        End Sub

        Private Function GetStatus() As Integer
            If Not Me.IsOpen Then
                Throw New InvalidOperationException("Port is not open.")
            End If
            Dim lpModemStat As Integer = 0
            If Not PortIO.NativeMethods.GetCommModemStatus(Me.myHandle, lpModemStat) Then
                Throw New IOException("GetCommModemStatus failed.")
            End If
            Return lpModemStat
        End Function

        Private Sub Close2(throwExceptionIfFails As Boolean)
            If Not Me.IsOpen Then
                Return
            End If
            Dim flag As Boolean = PortIO.NativeMethods.CloseHandle(Me.myHandle)
            Me.myHandle = IntPtr.Zero
            If Not flag AndAlso throwExceptionIfFails Then
                Throw New IOException("Failed to close port.")
            End If
        End Sub

        Public Sub Open()
            If Me.IsOpen Then
                Throw New InvalidOperationException("Port is open.")
            End If
            Dim lpFileName As String = If(Me.SerialSettings IsNot Nothing, Me.SerialSettings.PortName, Me.PortName)
            If Not lpFileName.EndsWith(":") Then
                lpFileName += ":"
            End If
            Me.myHandle = PortIO.NativeMethods.CreateFile(lpFileName, 3221225472UI, 0UI, IntPtr.Zero, 3UI, 0UI, IntPtr.Zero)
            If Me.myHandle = (IntPtr.Zero) - 1 Then
                Me.myHandle = IntPtr.Zero
                Throw New IOException(Convert.ToString("Failed to open port: ") & Me.PortName)
            End If
            If Me.SerialSettings Is Nothing Then
                Return
            End If
            Dim lpDCB As New PortIO.DCB()
            If Not PortIO.NativeMethods.GetCommState(Me.myHandle, lpDCB) Then
                Throw New IOException("GetCommState failed.")
            End If
            lpDCB.baudRate = Me.SerialSettings.BaudRate
            lpDCB.byteSize = CByte(Me.SerialSettings.DataBits)
            lpDCB.parity = CByte(Me.SerialSettings.Parity)
            lpDCB.stopBits = CByte(Me.SerialSettings.StopBits)
            If Not PortIO.NativeMethods.SetCommState(Me.myHandle, lpDCB) Then
                Throw New IOException("SetCommState failed.")
            End If
        End Sub

        Public Sub Close()
            Me.Close2(True)
        End Sub

        Public Function Read(buffer As Byte()) As Integer
            If buffer Is Nothing Then
                Throw New ArgumentNullException("buffer")
            End If
            If Not Me.IsOpen Then
                Throw New InvalidOperationException("Port is not open.")
            End If
            Dim lpNumberOfBytesRead As UInteger
            If Not PortIO.NativeMethods.ReadFile(Me.myHandle, buffer, CUInt(buffer.Length), lpNumberOfBytesRead, IntPtr.Zero) Then
                Throw New IOException("Failed to read data from port.")
            End If
            Return CInt(lpNumberOfBytesRead)
        End Function

        Public Function Read() As Byte
            Dim buffer As Byte() = New Byte(0) {}
            Me.Read(buffer)
            Return buffer(0)
        End Function

        Public Sub Write(buffer As Byte())
            If buffer Is Nothing Then
                Throw New ArgumentNullException("buffer")
            End If
            If Not Me.IsOpen Then
                Throw New InvalidOperationException("Port is not open.")
            End If
            Dim lpNumberOfBytesWritten As UInteger
            If Not PortIO.NativeMethods.WriteFile(Me.myHandle, buffer, CUInt(buffer.Length), lpNumberOfBytesWritten, IntPtr.Zero) Then
                Throw New IOException("Failed to write data to port.")
            End If
        End Sub

        Public Sub Write(str As String)
            If str Is Nothing Then
                Throw New ArgumentNullException("str")
            End If
            Me.Write(Me.Encoding.GetBytes(str))
        End Sub

        Public Shared Function IsLptPort(portName As String) As Boolean
            If portName Is Nothing Then
                Throw New ArgumentNullException("portName")
            End If
            Dim flag1 As Boolean = False
            Dim str As String = portName.ToLower(CultureInfo.InvariantCulture)
            If str.StartsWith("lpt") Then
                Dim num As Integer = If(str.EndsWith(":"), str.Length - 1, str.Length)
                If num - 3 > 0 Then
                    Dim flag2 As Boolean = True
                    For index As Integer = 3 To num - 1
                        If CInt(AscW(str(index))) < 48 OrElse CInt(AscW(str(index))) > 57 Then
                            flag2 = False
                            Exit For
                        End If
                    Next
                    If flag2 Then
                        flag1 = True
                    End If
                End If
            End If
            Return flag1
        End Function

        Private Structure DCB
            Public dcbLength As Integer
            Public baudRate As Integer
            Public bitfield As Integer
            Public wReserved As Short
            Public xonLim As Short
            Public xoffLim As Short
            Public byteSize As Byte
            Public parity As Byte
            Public stopBits As Byte
            Public xonChar As Byte
            Public xoffChar As Byte
            Public errorChar As Byte
            Public eofChar As Byte
            Public evtChar As Byte
            Public wReserved1 As Short
        End Structure

        Private NotInheritable Class NativeMethods
            Private Sub New()
            End Sub

            <DllImport("kernel32.dll")> _
            Friend Shared Function CreateFile(lpFileName As String, dwDesiredAccess As UInteger, dwShareMode As UInteger, lpSecurityAttributes As IntPtr, dwCreationDisposition As UInteger, dwFlagsAndAttributes As UInteger, _
                hTemplateFile As IntPtr) As IntPtr
            End Function

            <DllImport("kernel32.dll")> _
            Friend Shared Function CloseHandle(hObject As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("kernel32.dll")> _
            Friend Shared Function ReadFile(hFile As IntPtr, lpBuffer As Byte(), nNumberOfBytesToRead As UInteger, ByRef lpNumberOfBytesRead As UInteger, lpOverlapped As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("kernel32.dll")> _
            Friend Shared Function WriteFile(hFile As IntPtr, lpBuffer As Byte(), nNumberOfBytesToWrite As UInteger, ByRef lpNumberOfBytesWritten As UInteger, lpOverlapped As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("kernel32.dll")> _
            Friend Shared Function GetCommState(hFile As IntPtr, ByRef lpDCB As PortIO.DCB) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("kernel32.dll")> _
            Friend Shared Function SetCommState(hFile As IntPtr, ByRef lpDCB As PortIO.DCB) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("kernel32.dll")> _
            Friend Shared Function GetCommModemStatus(hFile As IntPtr, ByRef lpModemStat As Integer) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function
        End Class
    End Class
End Namespace