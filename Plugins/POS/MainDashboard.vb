Imports DevExpress.Utils
Imports System.Windows.Forms

Namespace Salling.Plugins
    Public Class MainDashboard

        Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
            Using (New WaitDialogForm("Accounts Loading. Please Wait...."))
                Dim frmListView As New UI.ListView(uow, "Salling.BASE.ORM.Items")
                ''frmListView.MdiParent = Me
                frmListView.WindowState = FormWindowState.Maximized
                frmListView.StartPosition = FormStartPosition.CenterParent
                frmListView.Show()
            End Using
        End Sub

        Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
            Using (New WaitDialogForm("Point Of Sale Loading. Please Wait...."))
                Dim frmpos As New PointOfSale(uow)
                ''frmListView.MdiParent = Me
                frmpos.WindowState = FormWindowState.Maximized
                frmpos.StartPosition = FormStartPosition.CenterParent
                frmpos.Show()
            End Using
        End Sub
    End Class
End Namespace