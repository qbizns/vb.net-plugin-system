Imports DevExpress
Namespace Salling.SallingHost
    Friend Class StartUp
        Implements IObserver(Of String)

        Private Sub IObserverGeneric_OnCompleted() Implements IObserver(Of String).OnCompleted
            XtraSplashScreen.SplashScreenManager.CloseForm(False, 0, AppHelper.MainForm)
        End Sub

        Private Sub IObserverGeneric_OnNext(ByVal status As String) Implements IObserver(Of String).OnNext
            If DevExpress.XtraSplashScreen.SplashScreenManager.Default Is Nothing Then
                XtraSplashScreen.SplashScreenManager.ShowForm(AppHelper.MainForm, GetType(SplashScreen), True, True)
                XtraSplashScreen.SplashScreenManager.Default.SendCommand(SplashScreen.SplashScreenCommand.UpdateLabel, status)
            Else
                XtraSplashScreen.SplashScreenManager.Default.SendCommand(SplashScreen.SplashScreenCommand.UpdateLabel, status)

            End If
        End Sub

        Private Sub IObserverGeneric_OnError(ByVal [error] As Exception) Implements IObserver(Of String).OnError
            Throw [error]
        End Sub

    End Class

End Namespace
