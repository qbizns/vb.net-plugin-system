Imports DevExpress.XtraExport
Imports System.Windows.Forms
Imports System.Drawing
Imports DevExpress.Xpo
Imports System.ComponentModel

Namespace Salling.UI
    Public Class MainForm
        Public plugins As New DataTable
        Public SelectedAssembly As String = Nothing

        Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
            Me.Dispose()
        End Sub

        Private Sub BtnMinimize_Click(sender As Object, e As EventArgs) Handles BtnMinimize.Click
            Me.WindowState = Windows.Forms.FormWindowState.Minimized
        End Sub

        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
            'Me._uow = New UnitOfWork
            plugins.Columns.Add("PluginGroup", GetType(String))
            plugins.Columns.Add("PluginName", GetType(String))
            plugins.Columns.Add("PluginVersion", GetType(String))
            plugins.Columns.Add("PluginDescriptions", GetType(String))
            plugins.Columns.Add("LicenseType", GetType(String))
            plugins.Columns.Add("PluginImage", GetType(Image))
            plugins.Columns.Add("PluginPath", GetType(String))
            'plugins.Rows.Add(New Object() {"Accounting", "v 1.0.0.0", "We challenge you to compose a love letter to your city or town to showcase where you live! The rules are simple: keep it under one minute and make sure", "Enterprise", GetPluginLogo("Accounting")})
            'plugins.Rows.Add(New Object() {"Hotel Managment", "v 1.0.0.0", "We challenge you to compose a love letter to your city or town to showcase where you live! The rules are simple: keep it under one minute and make sure", "Enterprise", GetPluginLogo("Hotels")})




            GridPlugins.DataSource = plugins
        End Sub

        Public Function GetPluginLogo(ByVal PluginName As String) As Image
            'Dim ApplicationIntro As String = Application.StartupPath & "\Assets\Plugins\" & PluginName & ".jpg"
            Dim ApplicationIntro As String = IO.Path.Combine(Application.StartupPath, "Plugins", PluginName, PluginName & ".jpg")
            ' Check if it Exist
            If IO.File.Exists(ApplicationIntro) Then
                Return Image.FromFile(ApplicationIntro)
            End If
            Return Image.FromFile(Application.StartupPath & "\Assets\Plugins\default.jpg")
        End Function

        Private Sub PluginsView_ItemClick(sender As Object, e As DevExpress.XtraGrid.Views.Tile.TileViewItemClickEventArgs) Handles PluginsView.ItemClick
            SelectedAssembly = PluginsView.GetRowCellDisplayText(e.Item.RowHandle, PluginsView.Columns("PluginPath"))
        End Sub

        Private Sub BtnUser_Click(sender As Object, e As EventArgs) Handles BtnUser.Click
            FlyoutPanel.ShowBeakForm()
        End Sub

    End Class
End Namespace