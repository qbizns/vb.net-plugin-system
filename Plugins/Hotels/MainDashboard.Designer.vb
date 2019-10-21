Namespace Salling.Plugins
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class MainDashboard
        Inherits UI.Dashboard

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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainDashboard))
            Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.BtnRoomTypes = New DevExpress.XtraEditors.SimpleButton()
            Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
            Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.ApplicationLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AdminFlyoutPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.AdminFlyoutPanel.SuspendLayout()
            CType(Me.DicFlyoutPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DicFlyoutPanel.SuspendLayout()
            CType(Me.FlyoutPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.FlyoutPanelControl2.SuspendLayout()
            CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DataLayoutControl1.SuspendLayout()
            CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'BtnUser
            '
            Me.BtnUser.Appearance.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
            Me.BtnUser.Appearance.ForeColor = System.Drawing.Color.Gray
            Me.BtnUser.Appearance.Options.UseFont = True
            Me.BtnUser.Appearance.Options.UseForeColor = True
            Me.BtnUser.Appearance.Options.UseTextOptions = True
            Me.BtnUser.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            '
            'ApplicationLogo
            '
            Me.ApplicationLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.ApplicationLogo.Properties.Appearance.Options.UseBackColor = True
            '
            'AdminFlyoutPanel
            '
            Me.AdminFlyoutPanel.Options.CloseOnOuterClick = True
            '
            'DicFlyoutPanel
            '
            Me.DicFlyoutPanel.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.DicFlyoutPanel.Appearance.Options.UseBackColor = True
            Me.DicFlyoutPanel.Options.AnimationType = DevExpress.Utils.Win.PopupToolWindowAnimation.Fade
            Me.DicFlyoutPanel.Options.CloseOnOuterClick = True
            Me.DicFlyoutPanel.OptionsBeakPanel.BackColor = System.Drawing.Color.Transparent
            Me.DicFlyoutPanel.OptionsBeakPanel.BorderColor = System.Drawing.Color.Transparent
            '
            'FlyoutPanelControl2
            '
            Me.FlyoutPanelControl2.Controls.Add(Me.DataLayoutControl1)
            '
            'BtnMinimize
            '
            Me.BtnMinimize.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.BtnMinimize.Appearance.ForeColor = System.Drawing.Color.Gray
            Me.BtnMinimize.Appearance.Options.UseFont = True
            Me.BtnMinimize.Appearance.Options.UseForeColor = True
            '
            'BtnExit
            '
            Me.BtnExit.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.BtnExit.Appearance.ForeColor = System.Drawing.Color.Gray
            Me.BtnExit.Appearance.Options.UseFont = True
            Me.BtnExit.Appearance.Options.UseForeColor = True
            '
            'BtnSettings
            '
            Me.BtnSettings.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.BtnSettings.Appearance.ForeColor = System.Drawing.Color.Gray
            Me.BtnSettings.Appearance.Options.UseFont = True
            Me.BtnSettings.Appearance.Options.UseForeColor = True
            '
            'BtnDataDictenary
            '
            Me.BtnDataDictenary.Appearance.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Bold)
            Me.BtnDataDictenary.Appearance.ForeColor = System.Drawing.Color.Gray
            Me.BtnDataDictenary.Appearance.Options.UseFont = True
            Me.BtnDataDictenary.Appearance.Options.UseForeColor = True
            '
            'DataLayoutControl1
            '
            Me.DataLayoutControl1.Controls.Add(Me.BtnRoomTypes)
            Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.DataLayoutControl1.Location = New System.Drawing.Point(2, 2)
            Me.DataLayoutControl1.Name = "DataLayoutControl1"
            Me.DataLayoutControl1.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = New System.Drawing.Rectangle(919, 272, 376, 350)
            Me.DataLayoutControl1.OptionsPrint.AppearanceGroupCaption.BackColor = System.Drawing.Color.LightGray
            Me.DataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Font = New System.Drawing.Font("Segoe UI", 10.25!)
            Me.DataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseBackColor = True
            Me.DataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseFont = True
            Me.DataLayoutControl1.OptionsPrint.AppearanceGroupCaption.Options.UseTextOptions = True
            Me.DataLayoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.DataLayoutControl1.OptionsPrint.AppearanceGroupCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.DataLayoutControl1.OptionsPrint.AppearanceItemCaption.Options.UseTextOptions = True
            Me.DataLayoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.DataLayoutControl1.OptionsPrint.AppearanceItemCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center
            Me.DataLayoutControl1.Root = Me.Root
            Me.DataLayoutControl1.Size = New System.Drawing.Size(553, 514)
            Me.DataLayoutControl1.TabIndex = 0
            Me.DataLayoutControl1.Text = "DataLayoutControl1"
            '
            'BtnRoomTypes
            '
            Me.BtnRoomTypes.AllowFocus = False
            Me.BtnRoomTypes.Appearance.Font = New System.Drawing.Font("Segoe UI Semibold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.BtnRoomTypes.Appearance.ForeColor = System.Drawing.Color.DimGray
            Me.BtnRoomTypes.Appearance.Options.UseFont = True
            Me.BtnRoomTypes.Appearance.Options.UseForeColor = True
            Me.BtnRoomTypes.Appearance.Options.UseTextOptions = True
            Me.BtnRoomTypes.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.BtnRoomTypes.Image = CType(resources.GetObject("BtnRoomTypes.Image"), System.Drawing.Image)
            Me.BtnRoomTypes.Location = New System.Drawing.Point(12, 12)
            Me.BtnRoomTypes.Name = "BtnRoomTypes"
            Me.BtnRoomTypes.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.[False]
            Me.BtnRoomTypes.Size = New System.Drawing.Size(529, 38)
            Me.BtnRoomTypes.StyleController = Me.DataLayoutControl1
            Me.BtnRoomTypes.TabIndex = 20009
            Me.BtnRoomTypes.Tag = "Salling.HOTELS.ORM.Accounts"
            Me.BtnRoomTypes.Text = "Accounts"
            Me.BtnRoomTypes.ToolTip = "Enter Your Hotel Room Types"
            Me.BtnRoomTypes.ToolTipIconType = DevExpress.Utils.ToolTipIconType.Information
            Me.BtnRoomTypes.ToolTipTitle = "Hotels Back Office"
            '
            'Root
            '
            Me.Root.CustomizationFormText = "Root"
            Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.Root.GroupBordersVisible = False
            Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
            Me.Root.Location = New System.Drawing.Point(0, 0)
            Me.Root.Name = "Root"
            Me.Root.Size = New System.Drawing.Size(553, 514)
            Me.Root.Text = "Root"
            Me.Root.TextVisible = False
            '
            'LayoutControlItem1
            '
            Me.LayoutControlItem1.Control = Me.BtnRoomTypes
            Me.LayoutControlItem1.CustomizationFormText = "LayoutControlItem1"
            Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlItem1.Name = "LayoutControlItem1"
            Me.LayoutControlItem1.Size = New System.Drawing.Size(533, 494)
            Me.LayoutControlItem1.Text = "LayoutControlItem1"
            Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
            Me.LayoutControlItem1.TextVisible = False
            '
            'SimpleButton1
            '
            Me.SimpleButton1.Location = New System.Drawing.Point(718, 250)
            Me.SimpleButton1.Name = "SimpleButton1"
            Me.SimpleButton1.Size = New System.Drawing.Size(75, 23)
            Me.SimpleButton1.TabIndex = 20009
            Me.SimpleButton1.Text = "SimpleButton1"
            '
            'MainDashboard
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(850, 590)
            Me.Controls.Add(Me.SimpleButton1)
            Me.Name = "MainDashboard"
            Me.Text = "MainDashboard"
            Me.Controls.SetChildIndex(Me.BtnExit, 0)
            Me.Controls.SetChildIndex(Me.BtnMinimize, 0)
            Me.Controls.SetChildIndex(Me.BtnSettings, 0)
            Me.Controls.SetChildIndex(Me.BtnDataDictenary, 0)
            Me.Controls.SetChildIndex(Me.BtnUser, 0)
            Me.Controls.SetChildIndex(Me.ApplicationLogo, 0)
            Me.Controls.SetChildIndex(Me.AdminFlyoutPanel, 0)
            Me.Controls.SetChildIndex(Me.DicFlyoutPanel, 0)
            Me.Controls.SetChildIndex(Me.SimpleButton1, 0)
            CType(Me.ApplicationLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AdminFlyoutPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.AdminFlyoutPanel.ResumeLayout(False)
            CType(Me.DicFlyoutPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DicFlyoutPanel.ResumeLayout(False)
            CType(Me.FlyoutPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.FlyoutPanelControl2.ResumeLayout(False)
            CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DataLayoutControl1.ResumeLayout(False)
            CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
        Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents BtnRoomTypes As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
        Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton


    End Class
End Namespace