Namespace Salling.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class Login
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
            Me.ImgBrand = New DevExpress.XtraEditors.PictureEdit()
            Me.TxtUsername = New DevExpress.XtraEditors.TextEdit()
            Me.TxtPassword = New DevExpress.XtraEditors.TextEdit()
            Me.BtnLogin = New DevExpress.XtraEditors.SimpleButton()
            Me.BtnCancel = New DevExpress.XtraEditors.SimpleButton()
            Me.LblUsername = New DevExpress.XtraEditors.LabelControl()
            Me.LblPassword = New DevExpress.XtraEditors.LabelControl()
            CType(Me.ImgBrand.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'ImgBrand
            '
            Me.ImgBrand.Location = New System.Drawing.Point(0, -1)
            Me.ImgBrand.Margin = New System.Windows.Forms.Padding(0)
            Me.ImgBrand.Name = "ImgBrand"
            Me.ImgBrand.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.ImgBrand.Size = New System.Drawing.Size(755, 220)
            Me.ImgBrand.TabIndex = 0
            '
            'TxtUsername
            '
            Me.TxtUsername.Location = New System.Drawing.Point(539, 234)
            Me.TxtUsername.Name = "TxtUsername"
            Me.TxtUsername.Size = New System.Drawing.Size(202, 20)
            Me.TxtUsername.TabIndex = 1
            '
            'TxtPassword
            '
            Me.TxtPassword.Location = New System.Drawing.Point(539, 260)
            Me.TxtPassword.Name = "TxtPassword"
            Me.TxtPassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
            Me.TxtPassword.Size = New System.Drawing.Size(202, 20)
            Me.TxtPassword.TabIndex = 2
            '
            'BtnLogin
            '
            Me.BtnLogin.Location = New System.Drawing.Point(640, 372)
            Me.BtnLogin.Name = "BtnLogin"
            Me.BtnLogin.Size = New System.Drawing.Size(101, 23)
            Me.BtnLogin.TabIndex = 3
            Me.BtnLogin.Text = "Login"
            '
            'BtnCancel
            '
            Me.BtnCancel.Location = New System.Drawing.Point(539, 372)
            Me.BtnCancel.Name = "BtnCancel"
            Me.BtnCancel.Size = New System.Drawing.Size(95, 23)
            Me.BtnCancel.TabIndex = 4
            Me.BtnCancel.Text = "Cancel"
            '
            'LblUsername
            '
            Me.LblUsername.Location = New System.Drawing.Point(467, 237)
            Me.LblUsername.Name = "LblUsername"
            Me.LblUsername.Size = New System.Drawing.Size(55, 13)
            Me.LblUsername.TabIndex = 5
            Me.LblUsername.Text = "Username :"
            '
            'LblPassword
            '
            Me.LblPassword.Location = New System.Drawing.Point(469, 263)
            Me.LblPassword.Name = "LblPassword"
            Me.LblPassword.Size = New System.Drawing.Size(53, 13)
            Me.LblPassword.TabIndex = 6
            Me.LblPassword.Text = "Password :"
            '
            'Login
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(753, 407)
            Me.Controls.Add(Me.LblPassword)
            Me.Controls.Add(Me.LblUsername)
            Me.Controls.Add(Me.BtnCancel)
            Me.Controls.Add(Me.BtnLogin)
            Me.Controls.Add(Me.TxtPassword)
            Me.Controls.Add(Me.TxtUsername)
            Me.Controls.Add(Me.ImgBrand)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Login"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            CType(Me.ImgBrand.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtUsername.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TxtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Public WithEvents ImgBrand As DevExpress.XtraEditors.PictureEdit
        Public WithEvents TxtUsername As DevExpress.XtraEditors.TextEdit
        Public WithEvents TxtPassword As DevExpress.XtraEditors.TextEdit
        Public WithEvents BtnLogin As DevExpress.XtraEditors.SimpleButton
        Public WithEvents BtnCancel As DevExpress.XtraEditors.SimpleButton
        Public WithEvents LblUsername As DevExpress.XtraEditors.LabelControl
        Public WithEvents LblPassword As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace