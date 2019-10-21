Namespace Salling.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PluginDashboard
        Inherits DevExpress.XtraEditors.XtraUserControl

        'UserControl overrides dispose to clean up the component list.
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
            Me.NavBarControl1 = New DevExpress.XtraNavBar.NavBarControl()
            Me.NavBarGroup1 = New DevExpress.XtraNavBar.NavBarGroup()
            CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'NavBarControl1
            '
            Me.NavBarControl1.ActiveGroup = Me.NavBarGroup1
            Me.NavBarControl1.Dock = System.Windows.Forms.DockStyle.Left
            Me.NavBarControl1.Groups.AddRange(New DevExpress.XtraNavBar.NavBarGroup() {Me.NavBarGroup1})
            Me.NavBarControl1.Location = New System.Drawing.Point(0, 0)
            Me.NavBarControl1.Name = "NavBarControl1"
            Me.NavBarControl1.OptionsNavPane.ExpandedWidth = 212
            Me.NavBarControl1.Size = New System.Drawing.Size(212, 555)
            Me.NavBarControl1.TabIndex = 0
            Me.NavBarControl1.Text = "NavBarControl1"
            '
            'NavBarGroup1
            '
            Me.NavBarGroup1.Caption = "Plugin Name"
            Me.NavBarGroup1.Expanded = True
            Me.NavBarGroup1.Name = "NavBarGroup1"
            '
            'PluginDashboard
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.Controls.Add(Me.NavBarControl1)
            Me.Name = "PluginDashboard"
            Me.Size = New System.Drawing.Size(827, 555)
            CType(Me.NavBarControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Public WithEvents NavBarControl1 As DevExpress.XtraNavBar.NavBarControl
        Public WithEvents NavBarGroup1 As DevExpress.XtraNavBar.NavBarGroup

    End Class
End Namespace