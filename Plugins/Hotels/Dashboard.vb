Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports System.Reflection

Namespace Salling.Plugins
    Public Class Dashboard
        Public Sub New()
            MyBase.New()
            InitializeComponent()

            Dim btn As SimpleButton = Nothing
            For Each ctrl As Control In Me.Controls
                If TypeOf ctrl Is SimpleButton Then
                    btn = DirectCast(ctrl, SimpleButton)
                    AddHandler btn.Click, AddressOf Me.Button_Click
                End If
            Next

        End Sub

        Private Sub Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
            ' Handle your Button clicks here
            Dim _tag As String = DirectCast(sender, SimpleButton).Tag

            If _tag IsNot Nothing Then
                'Try
                Dim frm As DevExpress.XtraEditors.XtraForm = Assembly.GetExecutingAssembly.CreateInstance(String.Format("{0}.{1}", "Salling.Plugins", "Frm" & _tag.ToString), True, BindingFlags.Default, Nothing, New Object() {Nothing, Nothing}, Nothing, Nothing)
                If frm IsNot Nothing Then
                    'frm.MdiParent = Me
                    frm.WindowState = FormWindowState.Maximized
                    frm.StartPosition = FormStartPosition.CenterParent
                    frm.Show()
                    frm.Show()
                Else

                    ' Dim frm2 As New Template.UI.Entry(MyBase.uow, _tag, Nothing)
                    'frm2.Show()
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

    End Class
End Namespace
