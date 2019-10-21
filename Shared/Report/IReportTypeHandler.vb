'Imports BCE.Data
Imports DevExpress.XtraBars
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.UserDesigner

Namespace BCE.AutoCount.Report
    Public Interface IReportTypeHandler
        Function GetReportClass() As Type

        Function GetDesignerDataSource(dbSetting As DBSetting) As Object

        Sub InitReport(report As XtraReport)

        Sub BeforePrint(report As XtraReport, e As System.Drawing.Printing.PrintEventArgs)

        Sub InitReportDesigner(dbSetting As DBSetting, xrDesignBarManager As XRDesignBarManager, editMenu As BarSubItem, designPanel As XRDesignPanel)
    End Interface
End Namespace