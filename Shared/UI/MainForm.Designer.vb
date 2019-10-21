Namespace Salling.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class MainForm
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
            Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim TileViewItemElement4 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim TileViewItemElement5 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Dim TileViewItemElement6 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
            Me.PluginName = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.LicenseType = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.PluginVersion = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.PluginDescriptions = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.PluginImage = New DevExpress.XtraGrid.Columns.TileViewColumn()
            Me.PanelControl1 = New DevExpress.XtraEditors.PanelControl()
            Me.FlyoutPanel = New DevExpress.Utils.FlyoutPanel()
            Me.FlyoutPanelControl1 = New DevExpress.Utils.FlyoutPanelControl()
            Me.BtnUser = New DevExpress.XtraEditors.SimpleButton()
            Me.PanelControl2 = New DevExpress.XtraEditors.PanelControl()
            Me.BtnMinimize = New DevExpress.XtraEditors.SimpleButton()
            Me.BtnExit = New DevExpress.XtraEditors.SimpleButton()
            Me.ApplicationLogo = New DevExpress.XtraEditors.PictureEdit()
            Me.PanelControl3 = New DevExpress.XtraEditors.PanelControl()
            Me.BtnNewPlugin = New DevExpress.XtraEditors.SimpleButton()
            Me.PanelControl4 = New DevExpress.XtraEditors.PanelControl()
            Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.PanelControl5 = New DevExpress.XtraEditors.PanelControl()
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.GridPlugins = New DevExpress.XtraGrid.GridControl()
            Me.PluginsView = New DevExpress.XtraGrid.Views.Tile.TileView()
            Me.PluginPath = New DevExpress.XtraGrid.Columns.TileViewColumn()
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl1.SuspendLayout()
            CType(Me.FlyoutPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.FlyoutPanel.SuspendLayout()
            CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.ApplicationLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl3.SuspendLayout()
            CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl4.SuspendLayout()
            CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PanelControl5.SuspendLayout()
            CType(Me.GridPlugins, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PluginsView, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'PluginName
            '
            Me.PluginName.Caption = "PluginName"
            Me.PluginName.FieldName = "PluginName"
            Me.PluginName.Name = "PluginName"
            Me.PluginName.UnboundType = DevExpress.Data.UnboundColumnType.[String]
            Me.PluginName.Visible = True
            Me.PluginName.VisibleIndex = 0
            '
            'LicenseType
            '
            Me.LicenseType.Caption = "LicenseType"
            Me.LicenseType.FieldName = "LicenseType"
            Me.LicenseType.Name = "LicenseType"
            Me.LicenseType.UnboundType = DevExpress.Data.UnboundColumnType.[String]
            Me.LicenseType.Visible = True
            Me.LicenseType.VisibleIndex = 2
            '
            'PluginVersion
            '
            Me.PluginVersion.Caption = "PluginVersion"
            Me.PluginVersion.FieldName = "PluginVersion"
            Me.PluginVersion.Name = "PluginVersion"
            Me.PluginVersion.UnboundType = DevExpress.Data.UnboundColumnType.[String]
            Me.PluginVersion.Visible = True
            Me.PluginVersion.VisibleIndex = 1
            '
            'PluginDescriptions
            '
            Me.PluginDescriptions.Caption = "PluginDescriptions"
            Me.PluginDescriptions.FieldName = "PluginDescriptions"
            Me.PluginDescriptions.Name = "PluginDescriptions"
            Me.PluginDescriptions.UnboundType = DevExpress.Data.UnboundColumnType.[String]
            Me.PluginDescriptions.Visible = True
            Me.PluginDescriptions.VisibleIndex = 3
            '
            'PluginImage
            '
            Me.PluginImage.Caption = "PluginImage"
            Me.PluginImage.FieldName = "PluginImage"
            Me.PluginImage.Name = "PluginImage"
            Me.PluginImage.UnboundType = DevExpress.Data.UnboundColumnType.[Object]
            Me.PluginImage.Visible = True
            Me.PluginImage.VisibleIndex = 4
            '
            'PanelControl1
            '
            Me.PanelControl1.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl1.Appearance.Options.UseBackColor = True
            Me.PanelControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.PanelControl1.Controls.Add(Me.FlyoutPanel)
            Me.PanelControl1.Controls.Add(Me.BtnUser)
            Me.PanelControl1.Controls.Add(Me.PanelControl2)
            Me.PanelControl1.Controls.Add(Me.BtnMinimize)
            Me.PanelControl1.Controls.Add(Me.BtnExit)
            Me.PanelControl1.Controls.Add(Me.ApplicationLogo)
            Me.PanelControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.PanelControl1.Location = New System.Drawing.Point(0, 0)
            Me.PanelControl1.Name = "PanelControl1"
            Me.PanelControl1.Size = New System.Drawing.Size(1028, 80)
            Me.PanelControl1.TabIndex = 0
            '
            'FlyoutPanel
            '
            Me.FlyoutPanel.Controls.Add(Me.FlyoutPanelControl1)
            Me.FlyoutPanel.Location = New System.Drawing.Point(319, 12)
            Me.FlyoutPanel.Name = "FlyoutPanel"
            Me.FlyoutPanel.Options.CloseOnOuterClick = True
            Me.FlyoutPanel.OwnerControl = Me.BtnUser
            Me.FlyoutPanel.Size = New System.Drawing.Size(450, 150)
            Me.FlyoutPanel.TabIndex = 0
            '
            'FlyoutPanelControl1
            '
            Me.FlyoutPanelControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FlyoutPanelControl1.FlyoutPanel = Me.FlyoutPanel
            Me.FlyoutPanelControl1.Location = New System.Drawing.Point(0, 0)
            Me.FlyoutPanelControl1.Name = "FlyoutPanelControl1"
            Me.FlyoutPanelControl1.Size = New System.Drawing.Size(450, 150)
            Me.FlyoutPanelControl1.TabIndex = 0
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
            Me.BtnUser.Location = New System.Drawing.Point(735, 12)
            Me.BtnUser.Margin = New System.Windows.Forms.Padding(0)
            Me.BtnUser.Name = "BtnUser"
            Me.BtnUser.Size = New System.Drawing.Size(163, 52)
            Me.BtnUser.TabIndex = 20002
            Me.BtnUser.Text = "Administrator"
            '
            'PanelControl2
            '
            Me.PanelControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PanelControl2.Appearance.BackColor = System.Drawing.Color.Silver
            Me.PanelControl2.Appearance.Options.UseBackColor = True
            Me.PanelControl2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.PanelControl2.Location = New System.Drawing.Point(0, 77)
            Me.PanelControl2.Name = "PanelControl2"
            Me.PanelControl2.Size = New System.Drawing.Size(1027, 1)
            Me.PanelControl2.TabIndex = 20001
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
            Me.BtnMinimize.Location = New System.Drawing.Point(904, 12)
            Me.BtnMinimize.Name = "BtnMinimize"
            Me.BtnMinimize.Size = New System.Drawing.Size(52, 52)
            Me.BtnMinimize.TabIndex = 20000
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
            Me.BtnExit.Location = New System.Drawing.Point(962, 12)
            Me.BtnExit.Name = "BtnExit"
            Me.BtnExit.Size = New System.Drawing.Size(52, 52)
            Me.BtnExit.TabIndex = 1000
            Me.BtnExit.Text = "X"
            '
            'ApplicationLogo
            '
            Me.ApplicationLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
            Me.ApplicationLogo.Location = New System.Drawing.Point(42, 12)
            Me.ApplicationLogo.Name = "ApplicationLogo"
            Me.ApplicationLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.ApplicationLogo.Properties.Appearance.Options.UseBackColor = True
            Me.ApplicationLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.ApplicationLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
            Me.ApplicationLogo.Properties.ZoomAccelerationFactor = 1.0R
            Me.ApplicationLogo.Size = New System.Drawing.Size(131, 52)
            Me.ApplicationLogo.TabIndex = 0
            '
            'PanelControl3
            '
            Me.PanelControl3.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PanelControl3.Appearance.BackColor = System.Drawing.Color.White
            Me.PanelControl3.Appearance.Options.UseBackColor = True
            Me.PanelControl3.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.PanelControl3.Controls.Add(Me.BtnNewPlugin)
            Me.PanelControl3.Location = New System.Drawing.Point(0, 234)
            Me.PanelControl3.Name = "PanelControl3"
            Me.PanelControl3.Size = New System.Drawing.Size(1028, 238)
            Me.PanelControl3.TabIndex = 2
            '
            'BtnNewPlugin
            '
            Me.BtnNewPlugin.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnNewPlugin.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
            Me.BtnNewPlugin.Image = CType(resources.GetObject("BtnNewPlugin.Image"), System.Drawing.Image)
            Me.BtnNewPlugin.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft
            Me.BtnNewPlugin.Location = New System.Drawing.Point(877, 18)
            Me.BtnNewPlugin.Name = "BtnNewPlugin"
            Me.BtnNewPlugin.Size = New System.Drawing.Size(139, 46)
            Me.BtnNewPlugin.TabIndex = 0
            Me.BtnNewPlugin.Text = "Install New Plugins"
            '
            'PanelControl4
            '
            Me.PanelControl4.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer), CType(CType(75, Byte), Integer))
            Me.PanelControl4.Appearance.Options.UseBackColor = True
            Me.PanelControl4.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.PanelControl4.Controls.Add(Me.LabelControl3)
            Me.PanelControl4.Controls.Add(Me.LabelControl2)
            Me.PanelControl4.Controls.Add(Me.PanelControl5)
            Me.PanelControl4.Dock = System.Windows.Forms.DockStyle.Bottom
            Me.PanelControl4.Location = New System.Drawing.Point(0, 505)
            Me.PanelControl4.Name = "PanelControl4"
            Me.PanelControl4.Size = New System.Drawing.Size(1028, 140)
            Me.PanelControl4.TabIndex = 3
            '
            'LabelControl3
            '
            Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
            Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.Gray
            Me.LabelControl3.Location = New System.Drawing.Point(42, 83)
            Me.LabelControl3.Name = "LabelControl3"
            Me.LabelControl3.Size = New System.Drawing.Size(425, 14)
            Me.LabelControl3.TabIndex = 3
            Me.LabelControl3.Text = "All trademarks or registered trademarks are property of their respective owners."
            '
            'LabelControl2
            '
            Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!)
            Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.Gray
            Me.LabelControl2.Location = New System.Drawing.Point(42, 64)
            Me.LabelControl2.Name = "LabelControl2"
            Me.LabelControl2.Size = New System.Drawing.Size(178, 14)
            Me.LabelControl2.TabIndex = 2
            Me.LabelControl2.Text = "Copyright © 2015 GulfDatas inc."
            '
            'PanelControl5
            '
            Me.PanelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.PanelControl5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer), CType(CType(158, Byte), Integer))
            Me.PanelControl5.Appearance.Options.UseBackColor = True
            Me.PanelControl5.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.PanelControl5.Controls.Add(Me.LabelControl1)
            Me.PanelControl5.Location = New System.Drawing.Point(42, 25)
            Me.PanelControl5.Name = "PanelControl5"
            Me.PanelControl5.Size = New System.Drawing.Size(131, 26)
            Me.PanelControl5.TabIndex = 0
            '
            'LabelControl1
            '
            Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!)
            Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.White
            Me.LabelControl1.Location = New System.Drawing.Point(10, 4)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(85, 16)
            Me.LabelControl1.TabIndex = 1
            Me.LabelControl1.Text = "VERSION 1.0.0"
            '
            'GridPlugins
            '
            Me.GridPlugins.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.GridPlugins.Location = New System.Drawing.Point(0, 79)
            Me.GridPlugins.MainView = Me.PluginsView
            Me.GridPlugins.Name = "GridPlugins"
            Me.GridPlugins.Size = New System.Drawing.Size(1028, 157)
            Me.GridPlugins.TabIndex = 4
            Me.GridPlugins.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.PluginsView})
            '
            'PluginsView
            '
            Me.PluginsView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.PluginName, Me.PluginVersion, Me.LicenseType, Me.PluginDescriptions, Me.PluginImage, Me.PluginPath})
            Me.PluginsView.GridControl = Me.GridPlugins
            Me.PluginsView.Name = "PluginsView"
            Me.PluginsView.OptionsTiles.ItemSize = New System.Drawing.Size(360, 180)
            Me.PluginsView.OptionsTiles.RowCount = 2
            TileViewItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(24, Byte), Integer), CType(CType(132, Byte), Integer), CType(CType(184, Byte), Integer))
            TileViewItemElement1.Appearance.Normal.Options.UseFont = True
            TileViewItemElement1.Appearance.Normal.Options.UseForeColor = True
            TileViewItemElement1.Column = Me.PluginName
            TileViewItemElement1.Text = "PluginName"
            TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
            TileViewItemElement1.TextLocation = New System.Drawing.Point(141, 5)
            TileViewItemElement2.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TileViewItemElement2.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
            TileViewItemElement2.Appearance.Normal.Options.UseFont = True
            TileViewItemElement2.Appearance.Normal.Options.UseForeColor = True
            TileViewItemElement2.Column = Me.LicenseType
            TileViewItemElement2.Text = "LicenseType"
            TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
            TileViewItemElement2.TextLocation = New System.Drawing.Point(143, 40)
            TileViewItemElement3.Appearance.Normal.ForeColor = System.Drawing.Color.Gray
            TileViewItemElement3.Appearance.Normal.Options.UseForeColor = True
            TileViewItemElement3.Column = Me.PluginVersion
            TileViewItemElement3.Text = "PluginVersion"
            TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
            TileViewItemElement3.TextLocation = New System.Drawing.Point(283, 40)
            TileViewItemElement4.Appearance.Normal.ForeColor = System.Drawing.Color.Silver
            TileViewItemElement4.Appearance.Normal.Options.UseForeColor = True
            TileViewItemElement4.Text = "______________________________________"
            TileViewItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
            TileViewItemElement4.TextLocation = New System.Drawing.Point(142, 45)
            TileViewItemElement5.Appearance.Normal.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            TileViewItemElement5.Appearance.Normal.ForeColor = System.Drawing.Color.DimGray
            TileViewItemElement5.Appearance.Normal.Options.UseFont = True
            TileViewItemElement5.Appearance.Normal.Options.UseForeColor = True
            TileViewItemElement5.Column = Me.PluginDescriptions
            TileViewItemElement5.Text = "PluginDescriptions"
            TileViewItemElement5.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
            TileViewItemElement5.TextLocation = New System.Drawing.Point(142, 65)
            TileViewItemElement6.Column = Me.PluginImage
            TileViewItemElement6.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.Manual
            TileViewItemElement6.ImageBorder = DevExpress.XtraEditors.TileItemElementImageBorderMode.None
            TileViewItemElement6.ImageLocation = New System.Drawing.Point(-1, -9)
            TileViewItemElement6.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.ZoomInside
            TileViewItemElement6.ImageSize = New System.Drawing.Size(160, 180)
            TileViewItemElement6.Text = "PluginImage"
            Me.PluginsView.TileTemplate.Add(TileViewItemElement1)
            Me.PluginsView.TileTemplate.Add(TileViewItemElement2)
            Me.PluginsView.TileTemplate.Add(TileViewItemElement3)
            Me.PluginsView.TileTemplate.Add(TileViewItemElement4)
            Me.PluginsView.TileTemplate.Add(TileViewItemElement5)
            Me.PluginsView.TileTemplate.Add(TileViewItemElement6)
            '
            'PluginPath
            '
            Me.PluginPath.Caption = "PluginPath"
            Me.PluginPath.FieldName = "PluginPath"
            Me.PluginPath.Name = "PluginPath"
            Me.PluginPath.UnboundType = DevExpress.Data.UnboundColumnType.[String]
            Me.PluginPath.Visible = True
            Me.PluginPath.VisibleIndex = 5
            '
            'MainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1028, 645)
            Me.Controls.Add(Me.GridPlugins)
            Me.Controls.Add(Me.PanelControl4)
            Me.Controls.Add(Me.PanelControl3)
            Me.Controls.Add(Me.PanelControl1)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "MainForm"
            Me.Text = "MainForm"
            CType(Me.PanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl1.ResumeLayout(False)
            CType(Me.FlyoutPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.FlyoutPanel.ResumeLayout(False)
            CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.ApplicationLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PanelControl3, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl3.ResumeLayout(False)
            CType(Me.PanelControl4, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl4.ResumeLayout(False)
            Me.PanelControl4.PerformLayout()
            CType(Me.PanelControl5, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PanelControl5.ResumeLayout(False)
            Me.PanelControl5.PerformLayout()
            CType(Me.GridPlugins, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PluginsView, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents PanelControl1 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents PanelControl3 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents PanelControl4 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents PanelControl5 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Public WithEvents ApplicationLogo As DevExpress.XtraEditors.PictureEdit
        Friend WithEvents BtnMinimize As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents BtnExit As DevExpress.XtraEditors.SimpleButton
        Public WithEvents GridPlugins As DevExpress.XtraGrid.GridControl
        Public WithEvents PluginsView As DevExpress.XtraGrid.Views.Tile.TileView
        Public WithEvents PluginVersion As DevExpress.XtraGrid.Columns.TileViewColumn
        Public WithEvents LicenseType As DevExpress.XtraGrid.Columns.TileViewColumn
        Public WithEvents PluginDescriptions As DevExpress.XtraGrid.Columns.TileViewColumn
        Public WithEvents PluginImage As DevExpress.XtraGrid.Columns.TileViewColumn
        Public WithEvents PluginName As DevExpress.XtraGrid.Columns.TileViewColumn
        Friend WithEvents PanelControl2 As DevExpress.XtraEditors.PanelControl
        Friend WithEvents FlyoutPanelControl1 As DevExpress.Utils.FlyoutPanelControl
        Public WithEvents BtnUser As DevExpress.XtraEditors.SimpleButton
        Public WithEvents FlyoutPanel As DevExpress.Utils.FlyoutPanel
        Public WithEvents BtnNewPlugin As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents PluginPath As DevExpress.XtraGrid.Columns.TileViewColumn
    End Class
End Namespace