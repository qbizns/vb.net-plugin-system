Namespace Salling.SallingHost
    Public Class SplashScreen
        Sub New()
            InitializeComponent()
        End Sub

        Public Overrides Sub ProcessCommand(ByVal cmd As System.Enum, ByVal arg As Object)
            MyBase.ProcessCommand(cmd, arg)
            If cmd.GetType() Is SplashScreenCommand.UpdateLabel.GetType() Then
                labelControl2.Text = arg.ToString
            End If

        End Sub

        Public Enum SplashScreenCommand
            UpdateLabel
        End Enum
    End Class
End Namespace