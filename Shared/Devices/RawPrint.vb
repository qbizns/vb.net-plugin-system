Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Text

Namespace Salling.Devices
    Public NotInheritable Class RawPrint
        Private myStream As New MemoryStream()
        Private myEncoding As Encoding = Encoding.ASCII
        Private myPrinterName As String
        Private myDocumentName As String

        Public Property PrinterName() As String
            Get
                Return Me.myPrinterName
            End Get
            Set(value As String)
                If value Is Nothing Then
                    Throw New ArgumentNullException("value")
                End If
                Me.myPrinterName = value
            End Set
        End Property

        Public Property DocumentName() As String
            Get
                Return Me.myDocumentName
            End Get
            Set(value As String)
                If value Is Nothing Then
                    Throw New ArgumentNullException("value")
                End If
                Me.myDocumentName = value
            End Set
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

        Public Sub New(printerName As String, documentName As String)
            Me.PrinterName = printerName
            Me.DocumentName = documentName
        End Sub

        Public Sub Clear()
            Me.myStream = New MemoryStream()
        End Sub

        Public Sub Write(buffer As Byte())
            If buffer Is Nothing Then
                Throw New ArgumentNullException("buffer")
            End If
            Me.myStream.Write(buffer, 0, buffer.Length)
        End Sub

        Public Sub Write(str As String)
            If str Is Nothing Then
                Throw New ArgumentNullException("str")
            End If
            Me.Write(Me.Encoding.GetBytes(str))
        End Sub

        Public Sub WriteLine()
            Me.myStream.WriteByte(CByte(10))
        End Sub

        Public Sub WriteLine(str As String)
            Me.Write(str)
            Me.WriteLine()
        End Sub

        Public Sub Print()
            Dim phPrinter As IntPtr
            If Not RawPrint.NativeMethods.OpenPrinter(Me.PrinterName, phPrinter, IntPtr.Zero) Then
                Throw New IOException(Convert.ToString("Failed to open printer: ") & Me.PrinterName)
            End If
            Dim flag As Boolean = False
            If RawPrint.NativeMethods.StartDocPrinter(phPrinter, 1UI, New RawPrint.DOC_INFO_1() With {.pDocName = Me.DocumentName, .pDataType = "RAW"}) Then
                If RawPrint.NativeMethods.StartPagePrinter(phPrinter) Then
                    Dim pBuf As Byte() = Me.myStream.ToArray()
                    Dim pcWritten As UInteger
                    flag = RawPrint.NativeMethods.WritePrinter(phPrinter, pBuf, CUInt(pBuf.Length), pcWritten)
                    RawPrint.NativeMethods.EndPagePrinter(phPrinter)
                End If
                RawPrint.NativeMethods.EndDocPrinter(phPrinter)
            End If
            RawPrint.NativeMethods.ClosePrinter(phPrinter)
            If Not flag Then
                Throw New IOException("Failed to print data.")
            End If
        End Sub

        Private Structure DOC_INFO_1
            Public pDocName As String
            Public pOutputFile As String
            Public pDataType As String
        End Structure

        Private NotInheritable Class NativeMethods
            Private Sub New()
            End Sub

            <DllImport("winspool.drv")> _
            Friend Shared Function OpenPrinter(pPrinterName As String, ByRef phPrinter As IntPtr, pDefault As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("winspool.drv")> _
            Friend Shared Function ClosePrinter(hPrinter As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("winspool.drv")> _
            Friend Shared Function StartDocPrinter(hPrinter As IntPtr, level As UInteger, ByRef pDocInfo As RawPrint.DOC_INFO_1) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("winspool.drv")> _
            Friend Shared Function EndDocPrinter(hPrinter As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("winspool.drv")> _
            Friend Shared Function StartPagePrinter(hPrinter As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("winspool.drv")> _
            Friend Shared Function EndPagePrinter(hPrinter As IntPtr) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function

            <DllImport("winspool.drv")> _
            Friend Shared Function WritePrinter(hPrinter As IntPtr, pBuf As Byte(), cbBuf As UInteger, ByRef pcWritten As UInteger) As <MarshalAs(UnmanagedType.Bool)> Boolean
            End Function
        End Class
    End Class
End Namespace