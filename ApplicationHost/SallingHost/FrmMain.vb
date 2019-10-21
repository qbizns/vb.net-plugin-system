Imports System.ComponentModel
Imports System.Text
Imports System.Threading
Imports DevExpress.Utils
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Xpo

Namespace Salling.SallingHost
    Partial Public Class FrmMain
        Public DefaultProxy As Proxy.IProxy

        Dim loginResult As DialogResult

        Shared Sub New()
            DevExpress.UserSkins.BonusSkins.Register()
            DevExpress.Skins.SkinManager.EnableFormSkins()
        End Sub
        Public Sub New()
            InitializeComponent()
            AppHelper.MainForm = Me
            StartUpProcess.OnStart("ERP System Startup...")

            ' This call is required by the designer.
            InitializeComponent()
            ' Add any initialization after the InitializeComponent() call.

            Thread.Sleep(100)
            StartUpProcess.OnRunning("Configuring Application Domain")
            Thread.Sleep(100)
            StartUpProcess.OnRunning("Connect Databse Server")
            Thread.Sleep(100)
            StartUpProcess.OnRunning("Load User Roles and Permissions")
            Thread.Sleep(100)
            StartUpProcess.OnRunning("Initializing...")
            Icon = AppHelper.AppIcon

            If Salling.Security.Users.IsAuthenticated = False Then
                Using form As New Login
                    loginResult = form.ShowDialog()
                End Using
                AddHandler Me.Shown, AddressOf ApplicationMainForm_Shown
            End If

        End Sub

        Private Sub ApplicationMainForm_Shown(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Shown
            Select Case loginResult
                Case Windows.Forms.DialogResult.Yes
                    Using (New WaitDialogForm(" Loading. Please Wait...."))
                        Login.Close()
                        Me.WindowState = FormWindowState.Maximized
                        Me.Visible = True
                    End Using
                Case Windows.Forms.DialogResult.No
                    Application.Exit()
                Case Else
                    Application.Exit()
            End Select
        End Sub

        Protected Overrides Sub OnLoad(ByVal e As EventArgs)
            MyBase.OnLoad(e)
            StartUpProcess.OnRunning("Successfully loaded.")
        End Sub

        Protected Overrides Sub OnShown(ByVal e As EventArgs)
            MyBase.OnShown(e)
            StartUpProcess.OnComplete()
        End Sub

        Protected Overrides Sub OnClosed(ByVal e As EventArgs)
            MyBase.OnClosed(e)
        End Sub

        Private Sub ApplicationMainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
            ' *** Load application Brand Image
            ' Application Brand Path
            Dim ApplicationIntro As String = Application.StartupPath & "\Assets\logo.jpg"
            ' Check if it Exist
            If IO.File.Exists(ApplicationIntro) Then
                ' Convert it to image data
                Dim ApplicationIntroImage As Image = Image.FromFile(ApplicationIntro)
                Dim ApplicationIntroData() As Byte = ByteImageConverter.ToByteArray(ApplicationIntroImage, ApplicationIntroImage.RawFormat)
                ' Assign image to control
                ApplicationLogo.EditValue = ApplicationIntroData
            End If
            Me.Visible = False

            Using uow As New UnitOfWork
                Dim _Plugins As New XPCollection(Of Salling.BASE.ORM.Plugins)(uow)
                For Each item In _Plugins
                    plugins.Rows.Add(New Object() { _
                        item.PluginName, _
                        item.PluginName, _
                        "v 1.0.0.0", _
                        item.Description, _
                        "Enterprise", _
                        GetPluginLogo(item.PluginName.Replace(" ", "")), _
                        IO.Path.Combine(Application.StartupPath, "Plugins", item.PluginName.Replace(" ", ""), item.PluginName.Replace(" ", "") & ".dll")
                    })
                Next
            End Using

            plugins.Rows.Add(New Object() { _
                "Hotels", _
                "Back Office", _
                "v 1.0.0.0", _
                "Hospitility Managment System", _
                "Enterprise", _
                GetPluginLogo("hotels"), _
                IO.Path.Combine(Application.StartupPath, "Plugins", "Hotels", "Hotels.dll")
            })

            plugins.Rows.Add(New Object() { _
                "Point Of Sale", _
                "Point Of Sale", _
                "v 1.0.0.0", _
                "SuperMarket Control System", _
                "Enterprise", _
                GetPluginLogo("POS"), _
                IO.Path.Combine(Application.StartupPath, "Plugins", "POS", "POS.dll")
            })

            'plugins.Rows.Add(New Object() {"Point Of Sale", "v 1.0.0.0", "We challenge you to compose a love letter to your city or town to showcase where you live! The rules are simple: keep it under one minute and make sure", "Enterprise", GetPluginLogo("Point-of-sale"), Application.StartupPath & "\Plugins\Plugin1.dll"})
            'plugins.Rows.Add(New Object() {"WareHouse", "v 1.0.0.0", "We challenge you to compose a love letter to your city or town to showcase where you live! The rules are simple: keep it under one minute and make sure", "Enterprise", GetPluginLogo("Warehouse")})
            'plugins.Rows.Add(New Object() {"Sales", "v 1.0.0.0", "We challenge you to compose a love letter to your city or town to showcase where you live! The rules are simple: keep it under one minute and make sure", "Enterprise", GetPluginLogo("Sales")})
            'plugins.Rows.Add(New Object() {"Purchases", "v 1.0.0.0", "We challenge you to compose a love letter to your city or town to showcase where you live! The rules are simple: keep it under one minute and make sure", "Enterprise", GetPluginLogo("Purchases")})
            'plugins.Rows.Add(New Object() {"Administration", "v 1.0.0.0", "We challenge you to compose a love letter to your city or town to showcase where you live! The rules are simple: keep it under one minute and make sure", "Enterprise", GetPluginLogo("Administration")})
            'plugins.Rows.Add(New Object() {"Manufacturing", "v 1.0.0.0", "We challenge you to compose a love letter to your city or town to showcase where you live! The rules are simple: keep it under one minute and make sure", "Enterprise", GetPluginLogo("Manufacturing")})
            'plugins.Rows.Add(New Object() {"Payroll", "v 1.0.0.0", "We challenge you to compose a love letter to your city or town to showcase where you live! The rules are simple: keep it under one minute and make sure", "Enterprise", GetPluginLogo("Payroll")})



        End Sub

        Private Sub ApplicationMainForm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
            Salling.Security.Users.MakeUserOffline()
            ' Exit the entiry Application When click on X button or close the main screen of system
            Application.Exit()
        End Sub

        Private Sub PluginsView_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles PluginsView.ItemClick
            Using (New WaitDialogForm("Loading Application Interfaces. Please Wait...."))
                DefaultProxy = New Proxy.IProxy(MyBase.SelectedAssembly, "Domain_" + System.IO.Path.GetFileNameWithoutExtension(MyBase.SelectedAssembly))
                DefaultProxy.Initialize()
            End Using
        End Sub

        Private Sub BtnNewPlugin_Click(sender As Object, e As EventArgs) Handles BtnNewPlugin.Click
            'Dim PluginImportarForm As New PluginImporter(New UnitOfWork)
            'PluginImportarForm.Show()
        End Sub




    End Class
End Namespace