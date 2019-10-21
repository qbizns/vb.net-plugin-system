Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports System.Reflection
Imports DevExpress.Utils
Imports DevExpress.Xpo

Namespace Salling.Plugins
    Public Class MainDashboard
        Public Sub New()
            MyBase.New()
            ' This call is required by the designer.
            InitializeComponent()

            ' Add any initialization after the InitializeComponent() call.
            Dim btn As SimpleButton = Nothing
            For Each ctrl As Control In Me.DataLayoutControl1.Controls
                If TypeOf ctrl Is SimpleButton Then
                    btn = DirectCast(ctrl, SimpleButton)
                    AddHandler btn.Click, AddressOf Me.Button_Click
                End If
            Next


            'AppDomain.CurrentDomain.GetAssemblies().SelectMany(t >= t.GetTypes()).Where(t => t.IsClass && t.Namespace == @namespace)
            'Assembly.GetExecutingAssembly().GetTypes().Where(Function(t) [String].Equals(t.[Namespace], "Salling.BASE.ORM", StringComparison.Ordinal)).ToArray()
            'Dim allClasses = Assembly.GetExecutingAssembly().GetTypes().Where(Function(a) a.IsClass AndAlso a.[Namespace] IsNot Nothing AndAlso a.[Namespace].Contains("..your namespace...")).ToList()


        End Sub

        Private Sub Button_Click(sender As Object, ByVal e As System.EventArgs)
            ' Handle your Button clicks here
            Dim _tag As String = DirectCast(sender, SimpleButton).Tag

            'DicFlyoutPanel.HideBeakForm()
            If _tag IsNot Nothing Then
                'Try
                Dim frm As DevExpress.XtraEditors.XtraForm = Assembly.GetExecutingAssembly.CreateInstance(String.Format("{0}.{1}", "Salling.Plugins", "Frm" & _tag.ToString), True, BindingFlags.Default, Nothing, New Object() {uow, Nothing}, Nothing, Nothing)
                If frm IsNot Nothing Then
                    'frm.MdiParent = Me
                    frm.WindowState = FormWindowState.Maximized
                    frm.StartPosition = FormStartPosition.CenterParent
                    frm.Show()
                    frm.Show()
                Else

                    Dim frm2 As New Salling.UI.DataEntry(uow, _tag, Nothing)
                    frm2.Show()
                End If

                'Catch ex As Exception
                '    MsgBox(ex.InnerException.ToString)
                'End Try

            Else
                'If e.Item.Caption.ToString <> "List View" Then
                '    Using (New WaitDialogForm(e.Item.Caption.ToString & " Loading. Please Wait...."))
                '        Dim frmListView As New ListView(uow, e.Item.Caption.ToString.Replace(" ", ""))
                '        frmListView.MdiParent = Me
                '        frmListView.WindowState = FormWindowState.Maximized
                '        frmListView.StartPosition = FormStartPosition.CenterParent
                '        frmListView.Show()
                '    End Using
                'End If

            End If

        End Sub

        Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
            Using (New WaitDialogForm("Accounts Loading. Please Wait...."))
                Dim frmListView As New UI.ListView(uow, "Salling.HOTELS.ORM.Accounts")
                ''frmListView.MdiParent = Me
                frmListView.WindowState = FormWindowState.Maximized
                frmListView.StartPosition = FormStartPosition.CenterParent
                frmListView.Show()
            End Using
        End Sub


    End Class
End Namespace