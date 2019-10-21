Imports System.ComponentModel
Imports DevExpress.Xpo
Imports DevExpress.UserSkins
Imports System.Drawing
Imports DevExpress.Skins
Imports System.Windows.Forms
Imports DevExpress.LookAndFeel

Namespace Salling.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Config
        Inherits DevExpress.XtraEditors.XtraForm

        Public Shared _Scope As String = "SYS"
        <Browsable(False)> _
        Public Shared Property Scope() As String
            Get
                Return _Scope
            End Get
            Set(ByVal value As String)
                _Scope = value
            End Set
        End Property

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

        End Sub

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Config))
            Me.BtnClose = New DevExpress.XtraEditors.SimpleButton()
            Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            '
            'BtnClose
            '
            Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
            Me.BtnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
            Me.BtnClose.Location = New System.Drawing.Point(12, 554)
            Me.BtnClose.Name = "BtnClose"
            Me.BtnClose.Size = New System.Drawing.Size(91, 37)
            Me.BtnClose.TabIndex = 26
            Me.BtnClose.Text = "إلغاء الأمر"
            '
            'BtnSave
            '
            Me.BtnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.BtnSave.Image = CType(resources.GetObject("BtnSave.Image"), System.Drawing.Image)
            Me.BtnSave.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
            Me.BtnSave.Location = New System.Drawing.Point(109, 554)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New System.Drawing.Size(124, 37)
            Me.BtnSave.TabIndex = 25
            Me.BtnSave.Text = "حــفظ الإعدادات"
            '
            'Config
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(811, 603)
            Me.Controls.Add(Me.BtnClose)
            Me.Controls.Add(Me.BtnSave)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Config"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Settings"
            Me.ResumeLayout(False)

        End Sub
        Public WithEvents BtnClose As DevExpress.XtraEditors.SimpleButton
        Public WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton

    End Class
End Namespace