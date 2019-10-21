Namespace Salling.Devices
    Public NotInheritable Class SerialSettings
        Private myPortName As String
        Private myBaudRate As Integer
        Private myParity As Integer
        Private myDataBits As Integer
        Private myStopBits As Integer

        Public Property PortName() As String
            Get
                Return Me.myPortName
            End Get
            Set(value As String)
                If value Is Nothing Then
                    Throw New ArgumentNullException("value")
                End If
                Me.myPortName = value
            End Set
        End Property

        Public Property BaudRate() As Integer
            Get
                Return Me.myBaudRate
            End Get
            Set(value As Integer)
                If value <= 0 OrElse value > 256000 Then
                    Throw New ArgumentOutOfRangeException("value")
                End If
                Me.myBaudRate = value
            End Set
        End Property

        Public Property Parity() As Integer
            Get
                Return Me.myParity
            End Get
            Set(value As Integer)
                If value < 0 OrElse value > 4 Then
                    Throw New ArgumentOutOfRangeException("value")
                End If
                Me.myParity = value
            End Set
        End Property

        Public Property DataBits() As Integer
            Get
                Return Me.myDataBits
            End Get
            Set(value As Integer)
                If value < 5 OrElse value > 8 Then
                    Throw New ArgumentOutOfRangeException("value")
                End If
                Me.myDataBits = value
            End Set
        End Property

        Public Property StopBits() As Integer
            Get
                Return Me.myStopBits
            End Get
            Set(value As Integer)
                If value < 0 OrElse value > 2 Then
                    Throw New ArgumentOutOfRangeException("value")
                End If
                Me.myStopBits = value
            End Set
        End Property

        Public Sub New(portName As String)
            Me.PortName = portName
            Me.BaudRate = 9600
            Me.DataBits = 8
        End Sub

        Public Sub New(portName As String, baudRate As Integer, parity As Integer, dataBits As Integer, stopBits As Integer)
            Me.PortName = portName
            Me.BaudRate = baudRate
            Me.Parity = parity
            Me.DataBits = dataBits
            Me.StopBits = stopBits
        End Sub
    End Class
End Namespace