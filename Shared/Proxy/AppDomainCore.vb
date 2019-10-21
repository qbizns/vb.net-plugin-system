Imports System.Collections.Generic
Imports System.Text
Imports System.IO
Imports System.Reflection

Namespace Salling
    Public Class AppDomainCore
        ''' <summary>
        ''' creates an instance of Appdomain in the Specified Name
        ''' </summary>
        ''' <param name="AppDoaminName"></param>
        Public Sub New(AppDoaminName As String)
            _DefaultAppdomainName = AppDoaminName
            LoadAppDomain()
        End Sub


        Private _DefaultAppDomain As AppDomain
        ''' <summary>
        ''' Gets the Currently Active Appdomain
        ''' </summary>
        Public ReadOnly Property DefaultAppDomain() As AppDomain
            Get
                Return _DefaultAppDomain
            End Get
        End Property

        Private _DefaultAppdomainName As String

        Public ReadOnly Property DefaultAppdomainName() As String
            Get
                Return _DefaultAppdomainName
            End Get
        End Property


        ''' <summary>
        ''' Creates a new Application Domain instance
        ''' </summary>
        ''' <returns></returns>
        Private Function LoadAppDomain() As Boolean
            ' Construct and initialize settings for a second AppDomain.
            'Dim ads As New AppDomainSetup()

            ' Create the second AppDomain.
            '_DefaultAppDomain = AppDomain.CreateDomain(DefaultAppdomainName, Nothing, ads)
            ' this statement makes the App to copy the Dll to an alternative location and loads form there 
            '             * and thus leaves the original file's locking for replacement.
            'Dim files As String = ads.ShadowCopyFiles()
            '_DefaultAppDomain.SetShadowCopyFiles()


            Dim startupPath As String = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location)
            Dim dllpath As String = System.Reflection.Assembly.GetExecutingAssembly().CodeBase
            Dim configFile As String = Path.Combine(startupPath, "Salling.exe.config")
            Dim assembly As String = Path.Combine(startupPath, "Salling.exe")

            Dim setup As New AppDomainSetup()

            setup.ApplicationName = DefaultAppdomainName
            'setup.PrivateBinPath = dllpath
            setup.ShadowCopyFiles = "true"

            setup.ConfigurationFile = configFile
            setup.DisallowApplicationBaseProbing = False
            setup.DisallowBindingRedirects = False
            setup.AppDomainInitializer = AddressOf InitDomain
            setup.AppDomainInitializerArguments = {dllpath}


            ' Create the application domain. The evidence of this
            ' running assembly is used for the new domain:
            '_DefaultAppDomain = AppDomain.CreateDomain(DefaultAppdomainName, AppDomain.CurrentDomain.Evidence, setup)
            _DefaultAppDomain = AppDomain.CreateDomain(DefaultAppdomainName, Nothing, setup)

            'AddHandler _DefaultAppDomain.AssemblyResolve, AddressOf OnCurrentDomainAssemblyResolve

            Return True
        End Function

        'Private Shared Function OnCurrentDomainAssemblyResolve(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
        '    Dim partialName As String = DevExpress.Utils.AssemblyHelper.GetPartialName(args.Name).ToLower()
        '    MsgBox(partialName)
        '    If partialName = "log4net" OrElse partialName = "system.data.sqlite" OrElse partialName = "system.data.sqlite.ef6" Then
        '        Dim path As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(GetType(Program).Assembly.Location), partialName & ".dll")
        '        MsgBox(path)
        '        Return System.Reflection.Assembly.LoadFrom(path)
        '    End If
        '    Return Nothing
        'End Function

        Private Shared Sub InitDomain(args As String())
            'Dim filename As String = Nothing
            'For Each arg As String In args
            '    Console.WriteLine(" {0}", arg)
            '    filename = arg
            'Next

            'Dim graph As MarshalByRefObject = DirectCast(AppDomain.CurrentDomain.CreateInstanceFromAndUnwrap("C:\\Users\\ahmed\\Documents\\Visual Studio 2013\\Projects\\bin\\Plugins\\Plugin1.dll", "Template.Plugins.Dashboard"), MarshalByRefObject)
            'If graph IsNot Nothing Then
            '    Dim frm As New System.Windows.Forms.Form
            '    frm.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            '    frm.WindowState = Windows.Forms.FormWindowState.Maximized
            '    frm.FormBorderStyle = Windows.Forms.FormBorderStyle.Fixed3D
            '    frm.Name = "test From Plugin"
            '    frm.Text = DirectCast(graph, [Interface].IGraphical).PluginName
            '    Dim db As UI.PluginDashboard = DirectCast(graph, UI.PluginDashboard)
            '    frm.Controls.Add(db)
            '    frm.Show()
            'End If









            '    Dim winFormControl = DirectCast(AppDomain.CurrentDomain.CreateInstanceAndUnwrap("WinFormApp", "WinFormApp.MainControl"), System.Windows.Forms.Control)
            '    Dim host = New WindowsFormsHost()
            '    host.Child = winFormControl
            '    Dim contract = FrameworkElementAdapters.ViewToContractAdapter(host)
            '    AppDomain.CurrentDomain.SetData(SlotName, contract)
        End Sub

        ''' <summary>
        ''' Clears the currently used Application domain if exists.
        ''' </summary>
        ''' <returns>Boolean regarding operation sucessfull or not</returns>
        Private Function ClearAppDomain() As Boolean
            Try
                AppDomain.Unload(DefaultAppDomain)
                _DefaultAppDomain = Nothing
                Return True
            Catch
                Return False
            End Try
        End Function

        Protected Overrides Sub Finalize()
            Try
                ClearAppDomain()
            Finally
                MyBase.Finalize()
            End Try
        End Sub
    End Class
End Namespace