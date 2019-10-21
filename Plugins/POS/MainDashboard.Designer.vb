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
            Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            CType(Me.ApplicationLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.AdminFlyoutPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.AdminFlyoutPanel.SuspendLayout()
            CType(Me.DicFlyoutPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.DicFlyoutPanel.SuspendLayout()
            CType(Me.FlyoutPanelControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).BeginInit()
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
            'SimpleButton1
            '
            Me.SimpleButton1.Location = New System.Drawing.Point(620, 272)
            Me.SimpleButton1.Name = "SimpleButton1"
            Me.SimpleButton1.Size = New System.Drawing.Size(162, 79)
            Me.SimpleButton1.TabIndex = 20009
            Me.SimpleButton1.Text = "SimpleButton1"
            '
            'SimpleButton2
            '
            Me.SimpleButton2.Location = New System.Drawing.Point(620, 390)
            Me.SimpleButton2.Name = "SimpleButton2"
            Me.SimpleButton2.Size = New System.Drawing.Size(162, 79)
            Me.SimpleButton2.TabIndex = 20010
            Me.SimpleButton2.Text = "SimpleButton2"
            '
            'MainDashboard
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(850, 590)
            Me.Controls.Add(Me.SimpleButton2)
            Me.Controls.Add(Me.SimpleButton1)
            Me.Name = "MainDashboard"
            Me.Text = "MainDashboard"
            Me.Controls.SetChildIndex(Me.BtnExit, 0)
            Me.Controls.SetChildIndex(Me.BtnMinimize, 0)
            Me.Controls.SetChildIndex(Me.BtnUser, 0)
            Me.Controls.SetChildIndex(Me.BtnSettings, 0)
            Me.Controls.SetChildIndex(Me.BtnDataDictenary, 0)
            Me.Controls.SetChildIndex(Me.ApplicationLogo, 0)
            Me.Controls.SetChildIndex(Me.AdminFlyoutPanel, 0)
            Me.Controls.SetChildIndex(Me.DicFlyoutPanel, 0)
            Me.Controls.SetChildIndex(Me.SimpleButton1, 0)
            Me.Controls.SetChildIndex(Me.SimpleButton2, 0)
            CType(Me.ApplicationLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.AdminFlyoutPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.AdminFlyoutPanel.ResumeLayout(False)
            CType(Me.DicFlyoutPanel, System.ComponentModel.ISupportInitialize).EndInit()
            Me.DicFlyoutPanel.ResumeLayout(False)
            CType(Me.FlyoutPanelControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FlyoutPanelControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace