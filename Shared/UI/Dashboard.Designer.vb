Namespace Salling.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Dashboard
        Inherits DevExpress.XtraEditors.XtraForm

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
            Me.BtnMinimize = New DevExpress.XtraEditors.SimpleButton()
            Me.BtnExit = New DevExpress.XtraEditors.SimpleButton()
            Me.BtnUser = New DevExpress.XtraEditors.SimpleButton()
            Me.BtnSettings = New DevExpress.XtraEditors.SimpleButton()
            Me.BtnDataDictenary = New DevExpress.XtraEditors.SimpleButton()
            Me.ApplicationLogo = New DevExpress.XtraEditors.PictureEdit()
            Me.AdminFlyoutPanel = New DevExpress.Utils.FlyoutPanel()
            Me.FlyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
            Me.DicFlyoutPanel = New DevExpress.Utils.FlyoutPanel()
            Me.FlyoutPanelControl2 = New DevExpress.Utils.FlyoutPanelControl()
            CType(Me.ApplicationLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AdminFlyoutPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.AdminFlyoutPanel.SuspendLayout()
            CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DicFlyoutPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DicFlyoutPanel.SuspendLayout()
            CType(Me.FlyoutPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'BtnMinimize
            '
            Me.BtnMinimize.AllowFocus = False
            Me.BtnMinimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnMinimize.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.BtnMinimize.Appearance.ForeColor = System.Drawing.Color.Gray
            Me.BtnMinimize.Appearance.Options.UseFont = True
            Me.BtnMinimize.Appearance.Options.UseForeColor = True
            Me.BtnMinimize.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
            Me.BtnMinimize.Location = New System.Drawing.Point(741, 2)
            Me.BtnMinimize.Name = "BtnMinimize"
            Me.BtnMinimize.Size = New System.Drawing.Size(52, 52)
            Me.BtnMinimize.TabIndex = 20002
            Me.BtnMinimize.Text = "_"
            '
            'BtnExit
            '
            Me.BtnExit.AllowFocus = False
            Me.BtnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnExit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.BtnExit.Appearance.ForeColor = System.Drawing.Color.Gray
            Me.BtnExit.Appearance.Options.UseFont = True
            Me.BtnExit.Appearance.Options.UseForeColor = True
            Me.BtnExit.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
            Me.BtnExit.Location = New System.Drawing.Point(796, 2)
            Me.BtnExit.Name = "BtnExit"
            Me.BtnExit.Size = New System.Drawing.Size(52, 52)
            Me.BtnExit.TabIndex = 20001
            Me.BtnExit.Text = "X"
            '
            'BtnUser
            '
            Me.BtnUser.AllowFocus = False
            Me.BtnUser.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnUser.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.BtnUser.Appearance.ForeColor = System.Drawing.Color.Gray
            Me.BtnUser.Appearance.Options.UseFont = True
            Me.BtnUser.Appearance.Options.UseForeColor = True
            Me.BtnUser.Appearance.Options.UseTextOptions = True
            Me.BtnUser.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.BtnUser.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
            Me.BtnUser.Image = CType(resources.GetObject("BtnUser.Image"), System.Drawing.Image)
            Me.BtnUser.Location = New System.Drawing.Point(575, 2)
            Me.BtnUser.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnUser.Name = "BtnUser"
            Me.BtnUser.Size = New System.Drawing.Size(163, 52)
            Me.BtnUser.TabIndex = 20003
            Me.BtnUser.Text = "Administrator"
            '
            'BtnSettings
            '
            Me.BtnSettings.AllowFocus = False
            Me.BtnSettings.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.BtnSettings.Appearance.ForeColor = System.Drawing.Color.Gray
            Me.BtnSettings.Appearance.Options.UseFont = True
            Me.BtnSettings.Appearance.Options.UseForeColor = True
            Me.BtnSettings.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
            Me.BtnSettings.Image = CType(resources.GetObject("BtnSettings.Image"), System.Drawing.Image)
            Me.BtnSettings.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.BtnSettings.Location = New System.Drawing.Point(194, 2)
            Me.BtnSettings.Name = "BtnSettings"
            Me.BtnSettings.Size = New System.Drawing.Size(52, 52)
            Me.BtnSettings.TabIndex = 20004
            '
            'BtnDataDictenary
            '
            Me.BtnDataDictenary.AllowFocus = False
            Me.BtnDataDictenary.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.BtnDataDictenary.Appearance.ForeColor = System.Drawing.Color.Gray
            Me.BtnDataDictenary.Appearance.Options.UseFont = True
            Me.BtnDataDictenary.Appearance.Options.UseForeColor = True
            Me.BtnDataDictenary.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
            Me.BtnDataDictenary.Image = CType(resources.GetObject("BtnDataDictenary.Image"), System.Drawing.Image)
            Me.BtnDataDictenary.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleCenter
            Me.BtnDataDictenary.Location = New System.Drawing.Point(139, 2)
            Me.BtnDataDictenary.Name = "BtnDataDictenary"
            Me.BtnDataDictenary.Size = New System.Drawing.Size(52, 52)
            Me.BtnDataDictenary.TabIndex = 20005
            '
            'ApplicationLogo
            '
            Me.ApplicationLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ApplicationLogo.EditValue = CType(resources.GetObject("ApplicationLogo.EditValue"), Object)
            Me.ApplicationLogo.Location = New System.Drawing.Point(2, 2)
            Me.ApplicationLogo.Name = "ApplicationLogo"
            Me.ApplicationLogo.Properties.AllowFocused = False
            Me.ApplicationLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.ApplicationLogo.Properties.Appearance.Options.UseBackColor = True
            Me.ApplicationLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.ApplicationLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
            Me.ApplicationLogo.Size = New System.Drawing.Size(131, 52)
            Me.ApplicationLogo.TabIndex = 20006
            '
            'AdminFlyoutPanel
            '
            Me.AdminFlyoutPanel.Controls.Add(Me.FlyoutPanelControl1)
            Me.AdminFlyoutPanel.Location = New System.Drawing.Point(575, 60)
            Me.AdminFlyoutPanel.Name = "AdminFlyoutPanel"
            Me.AdminFlyoutPanel.Options.CloseOnOuterClick = True
            Me.AdminFlyoutPanel.OwnerControl = Me.BtnUser
            Me.AdminFlyoutPanel.Size = New System.Drawing.Size(450, 150)
            Me.AdminFlyoutPanel.TabIndex = 20007
            '
            'FlyoutPanelControl1
            '
            Me.FlyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FlyoutPanelControl1.FlyoutPanel = Me.AdminFlyoutPanel
            Me.FlyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
            Me.FlyoutPanelControl1.Name = "FlyoutPanelControl1"
            Me.FlyoutPanelControl1.Size = New System.Drawing.Size(450, 150)
            Me.FlyoutPanelControl1.TabIndex = 0
            '
            'DicFlyoutPanel
            '
            Me.DicFlyoutPanel.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.DicFlyoutPanel.Appearance.Options.UseBackColor = True
            Me.DicFlyoutPanel.Controls.Add(Me.FlyoutPanelControl2)
            Me.DicFlyoutPanel.Location = New System.Drawing.Point(12, 60)
            Me.DicFlyoutPanel.Name = "DicFlyoutPanel"
            Me.DicFlyoutPanel.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
            Me.DicFlyoutPanel.Options.CloseOnOuterClick = True
            Me.DicFlyoutPanel.OptionsBeakPanel.BackColor = System.Drawing.Color.Transparent
            Me.DicFlyoutPanel.OptionsBeakPanel.BorderColor = System.Drawing.Color.Transparent
            Me.DicFlyoutPanel.OwnerControl = Me.BtnDataDictenary
            Me.DicFlyoutPanel.Size = New System.Drawing.Size(557, 518)
            Me.DicFlyoutPanel.TabIndex = 20008
            '
            'FlyoutPanelControl2
            '
            Me.FlyoutPanelControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FlyoutPanelControl2.FlyoutPanel = Me.DicFlyoutPanel
            Me.FlyoutPanelControl2.Location = New System.Drawing.Point(0, 0)
            Me.FlyoutPanelControl2.Name = "FlyoutPanelControl2"
            Me.FlyoutPanelControl2.Size = New System.Drawing.Size(557, 518)
            Me.FlyoutPanelControl2.TabIndex = 0
            '
            'Dashboard
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(850, 590)
            Me.Controls.Add(Me.DicFlyoutPanel)
            Me.Controls.Add(Me.AdminFlyoutPanel)
            Me.Controls.Add(Me.ApplicationLogo)
            Me.Controls.Add(Me.BtnDataDictenary)
            Me.Controls.Add(Me.BtnSettings)
            Me.Controls.Add(Me.BtnUser)
            Me.Controls.Add(Me.BtnMinimize)
            Me.Controls.Add(Me.BtnExit)
            Me.Name = "Dashboard"
            Me.Text = "Dashboard"
            CType(Me.ApplicationLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AdminFlyoutPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.AdminFlyoutPanel.ResumeLayout(False)
            CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DicFlyoutPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DicFlyoutPanel.ResumeLayout(False)
            CType(Me.FlyoutPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Public WithEvents BtnUser As DevExpress.XtraEditors.SimpleButton
        Public WithEvents ApplicationLogo As DevExpress.XtraEditors.PictureEdit
        Public WithEvents AdminFlyoutPanel As DevExpress.Utils.FlyoutPanel
        Public WithEvents DicFlyoutPanel As DevExpress.Utils.FlyoutPanel
        Public WithEvents FlyoutPanelControl2 As DevExpress.Utils.FlyoutPanelControl
        Public WithEvents BtnMinimize As DevExpress.XtraEditors.SimpleButton
        Public WithEvents BtnExit As DevExpress.XtraEditors.SimpleButton
        Public WithEvents BtnSettings As DevExpress.XtraEditors.SimpleButton
        Public WithEvents BtnDataDictenary As DevExpress.XtraEditors.SimpleButton
        Public WithEvents FlyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
    End Class
End Namespace