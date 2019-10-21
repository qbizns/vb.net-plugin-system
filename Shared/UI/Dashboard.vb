Imports DevExpress.Skins
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraExport
Imports System.ComponentModel
Imports DevExpress.Xpo

Namespace Salling.UI

    Public Class Dashboard
        Public Shared _uow As UnitOfWork
        <Browsable(False)> _
        Public Shared Property uow() As UnitOfWork
            Get
                Return _uow
            End Get
            Set(ByVal value As UnitOfWork)
                _uow = value
                _uow.TrackPropertiesModifications = False
            End Set
        End Property

        Public Sub New()
            If System.ComponentModel.LicenseManager.UsageMode = System.ComponentModel.LicenseUsageMode.Runtime Then
                uow = Salling.BASE.XPOUtils.GetNewUnitOfWork
            End If
            'Me.uow = Salling.BASE.XPO.GetNewUnitOfWork()
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


            UserLookAndFeel.Default.UseWindowsXPTheme = False
            UserLookAndFeel.Default.UseDefaultLookAndFeel = True
            UserLookAndFeel.Default.SetSkinStyle("Metropolis")

            DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
            DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = DevExpress.XtraEditors.ScrollUIMode.Touch

            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.

            Me.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Me.WindowState = Windows.Forms.FormWindowState.Maximized
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None

        End Sub

        Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
            AdminFlyoutPanel.ShowBeakForm()
        End Sub

        Private Sub Dashboard_Load(sender As Object, e As EventArgs) Handles Me.Load
            'Me.uow = Salling.BASE.XPO.GetNewUnitOfWork()

            Dim ApplicationIntro As String = Application.StartupPath & "\Assets\logo.jpg"
            ' Check if it Exist
            If IO.File.Exists(ApplicationIntro) Then
                ' Convert it to image data
                Dim ApplicationIntroImage As Image = Image.FromFile(ApplicationIntro)
                Dim ApplicationIntroData() As Byte = ByteImageConverter.ToByteArray(ApplicationIntroImage, ApplicationIntroImage.RawFormat)
                ' Assign image to control
                ApplicationLogo.EditValue = ApplicationIntroData
            End If
        End Sub

        Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles BtnDataDictenary.Click
            DicFlyoutPanel.Width = Me.Width
            DicFlyoutPanel.Height = Me.Height
            DicFlyoutPanel.ShowBeakForm()
        End Sub


        Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
            Me.WindowState = Windows.Forms.FormWindowState.Minimized
        End Sub

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            Me.Dispose()
        End Sub
    End Class
End Namespace