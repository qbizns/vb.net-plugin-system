Imports Salling
Imports System.Globalization
Imports DevExpress.Xpo
Imports DevExpress.LookAndFeel
Imports DevExpress.Skins
Imports DevExpress.UserSkins
Imports System.Management

Namespace Salling.SallingHost
    Friend NotInheritable Class Program
        Public Shared _ThreadSafeDataLayer As ThreadSafeDataLayer
        Public Shared _Session As Session
        Public Shared Property ThreadSafeDataLayer() As ThreadSafeDataLayer
            Get
                Return _ThreadSafeDataLayer
            End Get
            Set(ByVal value As ThreadSafeDataLayer)
                _ThreadSafeDataLayer = value
            End Set
        End Property


        Private Sub New()
        End Sub


        ''' <summary>
        ''' The main entry point for the application.
        ''' </summary>
        ''' 
        <LoaderOptimization(LoaderOptimization.MultiDomainHost)> _
        <STAThread>
        Shared Sub Main(args As String())
            Try
                AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf OnCurrentDomainAssemblyResolve

                BonusSkins.Register()
                SkinManager.EnableFormSkins()
                SkinManager.EnableMdiFormSkins()
                SkinManager.EnableFormSkinsIfNotVista()

                DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware()
                DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins()
                DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Metropolis")
                DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = DevExpress.XtraEditors.ScrollUIMode.Touch
                DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Segoe UI", 8)

                Application.EnableVisualStyles()
                Application.SetCompatibleTextRenderingDefault(False)

                Dim enUs As New System.Globalization.CultureInfo("en-US")
                System.Threading.Thread.CurrentThread.CurrentCulture = enUs
                System.Threading.Thread.CurrentThread.CurrentUICulture = enUs
                Application.CurrentCulture = CultureInfo.GetCultureInfo("en-us")


                UserLookAndFeel.Default.UseWindowsXPTheme = False
                UserLookAndFeel.Default.UseDefaultLookAndFeel = True
                UserLookAndFeel.Default.SetSkinStyle("Metropolis")

                DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
                DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = DevExpress.XtraEditors.ScrollUIMode.Touch



                If USBSecurity("SanDisk Cruzer Blade USB Device", "F0ECB80F") = False Then
                    If Process.GetProcessesByName(Process.GetCurrentProcess.ProcessName).Length > 1 Then
                        ' Tell the user he can only have on instance running
                        MessageBox.Show("Only one instance of this program can be open at a given time", "Duplicate instance detected", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                        ' Close the application
                        Application.Exit()
                    Else
                        _Session = New Session
                        ThreadSafeDataLayer = Salling.BASE.XPO.GetDataLayer()
                        Dim uow As UnitOfWork = New UnitOfWork(ThreadSafeDataLayer)


                        ' XpoDefault.Session = Nothing '_Session

                        Dim Administrator = Salling.BASE.ORM.SystemUsers.CreateAdminUser(uow, "Full Administrator", "The system Administrator", "Administrator", "123", True, True, True)
                        Dim AdministratorRole = Salling.BASE.ORM.Roles.CreateRoles(uow, "Administrator")
                        Salling.BASE.ORM.UserRoles.CreateUserRole(uow, AdministratorRole, Administrator)

                        Using TempStartUpProcess As StartUpProcess = New StartUpProcess()
                            Using StartUpProcess.Status.Subscribe(New StartUp())
                                Application.Run(New FrmMain())
                            End Using
                        End Using
                    End If

                Else
                    ' Tell the user he can only have on instance running
                    MessageBox.Show("You Use Illegal Copy Of This Software, Please Buy Your Copy", "Illegal Use Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                    ' Close the application
                    Application.Exit()
                End If
            Catch e As Exception
                MessageBox.Show(e.ToString(), "Salling", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End Sub

        Private Shared Function OnCurrentDomainAssemblyResolve(ByVal sender As Object, ByVal args As ResolveEventArgs) As System.Reflection.Assembly
            Dim partialName As String = DevExpress.Utils.AssemblyHelper.GetPartialName(args.Name).ToLower()

            If partialName = "log4net" OrElse partialName = "system.data.sqlite" OrElse partialName = "system.data.sqlite.ef6" Then
                Dim path As String = System.IO.Path.Combine(System.IO.Path.GetDirectoryName(GetType(Program).Assembly.Location), partialName & ".dll")
                Return System.Reflection.Assembly.LoadFrom(path)
            End If
            Return Nothing
        End Function

        Public Shared Function USBSecurity(ByVal Model As String, ByVal SN As String) As Boolean
            For Each drive As ManagementObject In New ManagementObjectSearcher("select * from Win32_DiskDrive where InterfaceType='USB'").[Get]()
                If drive("Model").ToString = Model.ToString Then
                    Dim volume As ManagementObject = CType(New ManagementObjectSearcher([String].Format("select FreeSpace, Size, VolumeName, VolumeSerialNumber from Win32_LogicalDisk where VolumeSerialNumber='{0}'", SN.ToString)).Get(0), ManagementObject)
                    If volume IsNot Nothing Then
                        Return True
                    Else
                        Return False
                    End If
                End If
            Next
            Return False
        End Function

    End Class

End Namespace
