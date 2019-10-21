Namespace Salling.SallingHost
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Login
        Inherits Salling.UI.Login

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
            CType(Me.ImgBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ImgBrand
            '
            '
            'TxtUsername
            '
            Me.TxtUsername.EditValue = "administrator"
            '
            'TxtPassword
            '
            Me.TxtPassword.EditValue = "123"
            '
            'BtnLogin
            '
            '
            'BtnCancel
            '
            '
            'Login
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(753, 407)
            Me.Name = "Login"
            CType(Me.ImgBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
    End Class
End Namespace