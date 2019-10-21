Imports DevExpress.Xpo
Imports DevExpress.XtraPrinting
Imports DevExpress.Utils
Imports System.Windows.Forms
Imports System.Drawing

Namespace Salling.UI
    Public Class ListView

        Private Sub ListView_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            'GridControl.MainView.SaveLayoutToXml(GridListLayoutXML)
        End Sub

        Private Sub ListView_Load(sender As Object, e As EventArgs) Handles Me.Load
            Me._xpcol = Salling.BASE.XPO.GetXpcollection(Me._table, Me.uow)

            lblTableName.Text = Me._table.ToString & " List."

            GridControl.UseEmbeddedNavigator = True
            ' Set GridControl Datasource to passed XpCollection
            GridControl.DataSource = Me._xpcol

            ' Show Footer for the grid
            GridView.OptionsView.ShowFooter = True
            GridView.OptionsLayout.Columns.RemoveOldColumns = False
            GridView.OptionsLayout.Columns.StoreAllOptions = True
            GridView.OptionsLayout.StoreAllOptions = True

            If IO.File.Exists(GridListLayoutXML) Then
                GridView.RestoreLayoutFromXml(GridListLayoutXML)
            Else
                ' Clear all GridView Columns
                GridView.Columns.Clear()
                ' Populate Columns depending on XpCollection displayable properties
                GridView.PopulateColumns()
                ' Make gridview columns best fit mode
                GridView.BestFitColumns()
            End If


        End Sub

        Private Sub BtnDelete_Click(sender As Object, e As EventArgs) Handles BtnDelete.Click
            ' Delete Current object
            Me.uow.Delete(BindingContext(Me._xpcol).Current)
            ' Commit Changes to Database
            Me.uow.CommitChanges()
        End Sub

        Private Sub BtnAddNew_Click(sender As Object, e As EventArgs) Handles BtnAddNew.Click
            Dim frm As New DataEntry(Me.uow, Me._table, Nothing)
            frm.opener = Me
            frm.Show()
        End Sub

        Private Sub BtnEdit_Click(sender As Object, e As EventArgs) Handles BtnEdit.Click
            Dim frm As New DataEntry(Me.uow, Me._table, CType(BindingContext(Me._xpcol).Current, Object))
            frm.opener = Me
            frm.Show()
        End Sub

        Private Sub BtnQuickFind_Click(sender As Object, e As EventArgs) Handles BtnQuickFind.Click
            Me.GridView.OptionsFind.AlwaysVisible = Not Me.GridView.OptionsFind.AlwaysVisible
        End Sub

        Private Sub BtnExportXls_Click(sender As Object, e As EventArgs) Handles BtnExportXls.Click
            Dim saveDialog = New SaveFileDialog() With {.Filter = "Excel (2003)(.xls)|*.xls|Excel (2010) (.xlsx)|*.xlsx"}
            If (saveDialog.ShowDialog() <> DialogResult.Cancel) Then
                Dim exportFilePath = saveDialog.FileName
                Me.GridView.ExportToXlsx(exportFilePath)
            End If
        End Sub

        Private Sub BtnExportDoc_Click(sender As Object, e As EventArgs) Handles BtnExportDoc.Click
            Dim saveDialog = New SaveFileDialog() With {.Filter = "RichText File (.rtf)|*.rtf"}
            If (saveDialog.ShowDialog() <> DialogResult.Cancel) Then
                Dim exportFilePath = saveDialog.FileName
                Me.GridView.ExportToRtf(exportFilePath)
            End If
        End Sub

        Private Sub BtnExportPdf_Click(sender As Object, e As EventArgs) Handles BtnExportPdf.Click
            Dim saveDialog = New SaveFileDialog() With {.Filter = "Pdf File (.pdf)|*.pdf"}
            If (saveDialog.ShowDialog() <> DialogResult.Cancel) Then
                Dim exportFilePath = saveDialog.FileName
                Me.GridView.ExportToPdf(exportFilePath)
            End If
        End Sub

        Private Sub BtnPrintView_Click(sender As Object, e As EventArgs) Handles BtnPrintView.Click
            'Me.GridView.ShowRibbonPrintPreview()
            Using (New WaitDialogForm("Report Loading. Please Wait...."))
                initReport().PreviewFormEx.Show()
            End Using
        End Sub

        Private Sub BtnPrint_Click(sender As Object, e As EventArgs) Handles BtnPrint.Click
            Using (New WaitDialogForm("We Printing now. Please Wait...."))
                Try
                    initReport().Print()
                Catch ex As Exception
                    MsgBox(ex.InnerException)
                End Try
            End Using
        End Sub

        Public Sub Reload()
            Me._xpcol.Reload()
        End Sub

        Private Sub FilterControl_FilterChanged(sender As Object, e As DevExpress.XtraEditors.FilterChangedEventArgs) Handles FilterControl.FilterChanged
            FilterControl.ApplyFilter()
        End Sub

        Public Function initReport() As PrintingSystem
            Dim ps As New PrintingSystem()

            Dim footer As New PageFooterArea()
            footer.Content.Add("[Date Printed]")
            footer.Content.Add("")
            footer.Content.Add("Page " + "[Page #]")
            footer.LineAlignment = BrickAlignment.Near
            Dim header As New PageHeaderArea()
            header.Content.Add("")
            Dim rptname As String = Me._table & " Report"
            header.Content.Add(rptname)
            header.Content.Add("")
            header.LineAlignment = BrickAlignment.Center
            header.Font = New Font("Times New Roman", 16, FontStyle.Bold)

            Dim link As New PrintableComponentLink(ps)
            link.Component = GridControl
            link.PageHeaderFooter = New PageHeaderFooter(header, footer)

            link.Landscape = True
            link.PaperKind = System.Drawing.Printing.PaperKind.A4
            'link.Margins = New System.Drawing.Printing.Margins(20, 20, 20, 20)

            link.CreateDocument()
            Return ps
        End Function


    End Class
End Namespace