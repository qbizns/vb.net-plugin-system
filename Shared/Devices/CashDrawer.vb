Namespace Salling.Devices
    Public NotInheritable Class CashDrawer
        Private myPortName As String
        Private mySerialSettings As SerialSettings
        Private myCommand As String
        Private myCommandBytes As Byte()

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

        Public Property OpenDrawerCommand() As String
            Get
                Return Me.myCommand
            End Get
            Set(value As String)
                If value Is Nothing Then
                    Throw New ArgumentNullException("value")
                End If
                Me.myCommandBytes = CashDrawer.ParseCommand(value)
                Me.myCommand = value
            End Set
        End Property

        Public Sub New(portName As String, command As String)
            If portName Is Nothing Then
                Throw New ArgumentNullException("portName")
            End If
            If command Is Nothing Then
                Throw New ArgumentNullException("command")
            End If
            Me.PortName = portName
            Me.OpenDrawerCommand = command
        End Sub

        Public Sub New(setting As SerialSettings, command As String)
            If setting Is Nothing Then
                Throw New ArgumentNullException("setting")
            End If
            If command Is Nothing Then
                Throw New ArgumentNullException("command")
            End If
            Me.SerialSettings = setting
            Me.OpenDrawerCommand = command
        End Sub

        Public Shared Function ParseCommand(command As String) As Byte()
            command = command.Trim()
            If command.Length = 0 Then
                Return New Byte(-1) {}
            End If
            Dim strArray As String() = command.Split(" "c)
            Dim length As Integer = 0
            For index As Integer = 0 To strArray.Length - 1
                If strArray(index).Length > 0 Then
                    length += 1
                End If
            Next
            Dim numArray As Byte() = New Byte(length - 1) {}
            Dim num As Integer = 0
            For index As Integer = 0 To strArray.Length - 1
                If strArray(index).Length > 0 Then
                    numArray(System.Math.Max(System.Threading.Interlocked.Increment(num), num - 1)) = Convert.ToByte(strArray(index), 16)
                End If
            Next
            Return numArray
        End Function

        Private Sub SendCommand(buffer As Byte(), documentName As String)
            If Me.SerialSettings Is Nothing Then
                If Me.PortName Is Nothing Then
                    Throw New InvalidOperationException("Parallel port or printer name is not defined.")
                End If
                If PortIO.IsLptPort(Me.PortName) Then
                    Using portIo__1 As New PortIO(Me.PortName)
                        portIo__1.Write(buffer)
                    End Using
                Else
                    Dim rawPrint As New RawPrint(Me.PortName, documentName)
                    rawPrint.Write(buffer)
                    rawPrint.Print()
                End If
            Else
                Using portIo__1 As New PortIO(Me.SerialSettings)
                    portIo__1.Write(buffer)
                End Using
            End If
        End Sub

        Public Sub OpenDrawer()
            Me.SendCommand(Me.myCommandBytes, "Open Cash Drawer")
        End Sub
    End Class
End Namespace