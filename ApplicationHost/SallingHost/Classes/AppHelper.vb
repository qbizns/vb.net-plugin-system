Namespace Salling.SallingHost
    Friend NotInheritable Class AppHelper

        Private Sub New()
        End Sub

        Public Shared Sub ProcessStart(ByVal name As String)
            ProcessStart(name, String.Empty)
        End Sub

        Public Shared Sub ProcessStart(ByVal name As String, ByVal arguments As String)
            Dim process As New System.Diagnostics.Process()
            process.StartInfo.FileName = name
            process.StartInfo.Arguments = arguments
            process.StartInfo.Verb = "Open"
            process.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Normal
            process.Start()
        End Sub

        Public Shared ReadOnly Property AppIcon() As Icon
            Get
                Return DevExpress.Utils.ResourceImageHelper.CreateIconFromResourcesEx("Template.Resources.AppIcon.ico", GetType(FrmMain).Assembly)
            End Get
        End Property

        Private Shared img As Image
        Public Shared ReadOnly Property AppImage() As Image
            Get
                If img Is Nothing Then
                    img = AppIcon.ToBitmap()
                End If
                Return img
            End Get
        End Property

        Private Shared wRef As WeakReference
        Public Shared Property MainForm() As FrmMain
            Get
                Return If(wRef IsNot Nothing, TryCast(wRef.Target, FrmMain), Nothing)
            End Get
            Set(ByVal value As FrmMain)
                wRef = New WeakReference(value)
            End Set
        End Property

        Public Shared Function GetDefaultSize() As Single
            Return 8.25F
        End Function
    End Class

End Namespace