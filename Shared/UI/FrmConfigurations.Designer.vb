Namespace Salling.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class FrmConfigurations
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
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmConfigurations))
            Me.BtnClose = New DevExpress.XtraEditors.SimpleButton()
            Me.BtnSave = New DevExpress.XtraEditors.SimpleButton()
            Me.SuspendLayout()
            '
            'BtnClose
            '
            Me.BtnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.BtnClose.Image = CType(resources.GetObject("BtnClose.Image"), System.Drawing.Image)
            Me.BtnClose.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleRight
            Me.BtnClose.Location = New System.Drawing.Point(12, 536)
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
            Me.BtnSave.Location = New System.Drawing.Point(109, 536)
            Me.BtnSave.Name = "BtnSave"
            Me.BtnSave.Size = New System.Drawing.Size(124, 37)
            Me.BtnSave.TabIndex = 25
            Me.BtnSave.Text = "حــفظ الإعدادات"
            '
            'Settings
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(811, 585)
            Me.Controls.Add(Me.BtnClose)
            Me.Controls.Add(Me.BtnSave)
            Me.MaximizeBox = False
            Me.MinimizeBox = False
            Me.Name = "Settings"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Settings"
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents BtnClose As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents BtnSave As DevExpress.XtraEditors.SimpleButton
    End Class
End Namespace