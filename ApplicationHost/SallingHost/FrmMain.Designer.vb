Namespace Salling.SallingHost
    Partial Public Class FrmMain
        Inherits Salling.UI.MainForm
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

#Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            CType(Me.ApplicationLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FlyoutPanel, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.plugins, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ApplicationLogo
            '
            Me.ApplicationLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.ApplicationLogo.Properties.Appearance.Options.UseBackColor = True
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
            'FlyoutPanel
            '
            Me.FlyoutPanel.Options.CloseOnOuterClick = True
            '
            'ApplicationMainForm
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.ClientSize = New System.Drawing.Size(1028, 645)
            Me.Name = "ApplicationMainForm"
            Me.Text = "ApplicationMainForm"
            CType(Me.ApplicationLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FlyoutPanel, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.plugins, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)


        End Sub

#End Region

    End Class
End Namespace