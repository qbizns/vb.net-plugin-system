'Imports BCE.Application
'Imports BCE.AutoCount
'Imports BCE.AutoCount.ActivityStream
'Imports BCE.AutoCount.Authentication
'Imports BCE.AutoCount.Common
'Imports BCE.AutoCount.Controller
'Imports BCE.AutoCount.LicenseControl
'Imports BCE.AutoCount.RegistryID.Misc
'Imports BCE.AutoCount.Scripting
'Imports BCE.AutoCount.Settings
'Imports BCE.Data
'Imports BCE.Localization
'Imports BCE.Messaging
'Imports BCE.Misc
Imports Salling.Report.Scripting
Imports DevExpress.XtraPrinting
Imports DevExpress.XtraReports
Imports DevExpress.XtraReports.UI
Imports Microsoft.Win32
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing.Printing
Imports System.Globalization
Imports System.IO
Imports System.IO.MemoryMappedFiles
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
Imports System.Xml.Serialization

Namespace Salling.Report
    Public Class ReportTool
        Private Shared myUseRibbonPreviewForm As Boolean = True
        Private Shared myScriptObject As ScriptObject

        Public Shared Property UseRibbonPreviewForm() As Boolean
            Get
                Return ReportTool.myUseRibbonPreviewForm
            End Get
            Set(value As Boolean)
                ReportTool.myUseRibbonPreviewForm = value
            End Set
        End Property

        Friend Shared Function GetScriptObject(dbSetting As DBSetting) As ScriptObject
            If ReportTool.myScriptObject Is Nothing Then
                ReportTool.myScriptObject = Salling.Report.Scripting.ScriptManager.CreateObject(dbSetting, "ReportTool")
            End If
            Return ReportTool.myScriptObject
        End Function

        Friend Shared Sub FilterTable(dbSetting As DBSetting, table As DataTable, controller As ModuleController)
            If Not table.Columns.Contains("Show") Then
                table.Columns.Add("Show", GetType(Boolean))
            End If
            Dim [boolean] As Boolean = DBRegistry.Create(dbSetting).GetBoolean(DirectCast(New UseTaxType(), IRegistryID))
            For Each dataRow As DataRow In DirectCast(table.Rows, InternalDataCollectionBase)
                If dataRow.RowState <> DataRowState.Deleted Then
                    Dim attributes As String = dataRow("Attributes").ToString()
                    dataRow("Show") = DirectCast(CBool(If(ReportTool.IsAttributeMatch(controller, [boolean], attributes), 1, 0)), Object)
                End If
            Next
            table.AcceptChanges()
        End Sub

        Private Shared Function IsAttributeMatch(controller As ModuleController, useTaxType As Boolean, attributes As String) As Boolean
            Dim flag As Boolean = True
            If attributes = "AlwaysShow" OrElse attributes = "AlwaysHide" Then
                If attributes = "AlwaysHide" Then
                    flag = False
                End If
            ElseIf attributes.Length > 0 Then
                Dim str1 As String = attributes
                Dim chArray1 As Char() = New Char(0) {","c}
                For Each str2 As String In str1.Split(chArray1)
                    Dim chArray2 As Char() = New Char(0) {"="c}
                    Dim strArray As String() = str2.Split(chArray2)
                    If strArray.Length = 2 Then
                        If strArray(0) = "Project" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.Project.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Department" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.Department.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Multi-Currency" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.MultiCurrency.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Advanced Multi-Currency" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.AdvancedCurrency.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Multi-Location" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.MultiLocationStock.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Multi-UOM" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.MultiUOM.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Item Batch No" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.BatchNo.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Bonus Point" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.BonusPoint.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "FOC" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.FOC.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "BOM" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.BOM.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Consignment" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.Consignment.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Advanced Financial Report" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.AdvancedFinancialReport.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Filter By Agent" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.FilterByAgent.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Serial No" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.SerialNo.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Landing Cost" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.LandingCost.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Item Package" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.ItemPackage.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Multi-Dimensional Price Book" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.MultiDimensionalPriceBook.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "GST" Then
                            If ReportTool.IsNotMatch(strArray(1), useTaxType) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Budget" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.Budget.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Multi-Level Assembly" Then
                            If ReportTool.IsNotMatch(strArray(1), controller.MultiLevelAssembly.Enable) Then
                                flag = False
                            End If
                        ElseIf strArray(0) = "Express Edition" AndAlso ReportTool.IsNotMatch(strArray(1), controller.ExpressEdition.Has) Then
                            flag = False
                        End If
                    End If
                    If Not flag Then
                        Exit For
                    End If
                Next
            End If
            Return flag
        End Function

        Private Shared Function IsNotMatch(value As String, moduleEnable As Boolean) As Boolean
            Return value = "Yes" Xor moduleEnable
        End Function

        Friend Shared Sub NoFilterTable(table As DataTable)
            If Not table.Columns.Contains("Show") Then
                table.Columns.Add("Show", GetType(Boolean))
            End If
            For Each dataRow As DataRow In DirectCast(table.Rows, InternalDataCollectionBase)
                If dataRow.RowState <> DataRowState.Deleted Then
                    dataRow("Show") = DirectCast(True, Object)
                End If
            Next
            table.AcceptChanges()
        End Sub

        Private Shared Function ExtractAlphabetWords(text As String) As String()
            Dim length As Integer = text.Length
            Dim index As Integer = 0
            Dim list As New List(Of String)()
            While index < length
                If Char.IsLetter(text(index)) Then
                    Dim stringBuilder As New StringBuilder()
                    While index < length AndAlso Char.IsLetter(text(index))
                        stringBuilder.Append(text(System.Math.Max(System.Threading.Interlocked.Increment(index), index - 1)))
                    End While
                    list.Add(stringBuilder.ToString())
                Else
                    index += 1
                End If
            End While
            Return list.ToArray()
        End Function

        Private Shared Function IsValidCompanyNameInReportHeader(companyName As String, reportHeaderRtf As String) As Boolean
            Dim text As String = Rtf.RichTextToPlainText(reportHeaderRtf).Trim()
            If text.Length = 0 Then
                Return True
            End If
            Dim alphabetWords1 As String() = ReportTool.ExtractAlphabetWords(companyName)
            Dim alphabetWords2 As String() = ReportTool.ExtractAlphabetWords(text)
            For Each strA As String In alphabetWords1
                Dim flag As Boolean = False
                For Each strB As String In alphabetWords2
                    If String.Compare(strA, strB, True, CultureInfo.InvariantCulture) = 0 Then
                        flag = True
                        Exit For
                    End If
                Next
                If Not flag Then
                    Return False
                End If
            Next
            Return True
        End Function

        Private Shared Function IsValidReportHeader(dbSetting As DBSetting) As Boolean
            Dim moduleControl__1 As ModuleControl = ModuleControl.[Get](dbSetting)
            Dim companyProfile As BasicCompanyProfile = GeneralSetting.GetOrCreate(dbSetting).CompanyProfile
            If companyProfile Is Nothing OrElse moduleControl__1 Is Nothing OrElse Not moduleControl__1.ModuleController.IsRegistered OrElse (Not moduleControl__1.ModuleController.Sales.Enable AndAlso Not moduleControl__1.ModuleController.Purchase.Enable OrElse ReportTool.IsValidCompanyNameInReportHeader(DirectCast(companyProfile.CompanyName, String), DirectCast(companyProfile.ReportHeader, String))) Then
                Return True
            End If
            AppMessage.ShowErrorMessage(Localizer.GetString(DirectCast(ReportToolStringId.InvalidReportHeader, [Enum])))
            Return False
        End Function

        Private Shared Sub ApplyReportOption(report As XtraReport, reportOption As BasicReportOption)
            If reportOption.UseReportMargin Then
                Dim reportUnit__1 As ReportUnit = report.ReportUnit
                report.ReportUnit = ReportUnit.TenthsOfAMillimeter
                report.Margins.Left = reportOption.ReportMarginLeft
                report.Margins.Right = reportOption.ReportMarginRight
                report.Margins.Top = reportOption.ReportMarginTop
                report.Margins.Bottom = reportOption.ReportMarginBottom
                report.ReportUnit = reportUnit__1
            End If
            If reportOption.ResizeLetterToA4 AndAlso report.PaperKind = PaperKind.Letter Then
                report.PaperKind = PaperKind.A4
                If Not report.Landscape Then
                    Dim reportUnit__1 As ReportUnit = report.ReportUnit
                    report.ReportUnit = ReportUnit.TenthsOfAMillimeter
                    If report.Margins.Left >= 30 Then
                        report.Margins.Left -= 30
                    End If
                    If report.Margins.Right >= 29 Then
                        report.Margins.Right -= 29
                    End If
                    report.ReportUnit = reportUnit__1
                End If
            ElseIf report.PaperKind = PaperKind.[Custom] Then
                report.PaperName = reportOption.CustomPaperName
                report.PrintingSystem.PageSettings.PaperKind = PaperKind.[Custom]
            End If
            report.PrintingSystem.ShowMarginsWarning = reportOption.ShowReportMarginWarning
            report.ShowPrintMarginsWarning = reportOption.ShowReportMarginWarning
            If Not reportOption.AlwaysPrintInBlack Then
                Return
            End If
            ReportTool.SetBlack(DirectCast(report, XtraReportBase))
        End Sub

        Public Shared Sub PrintReport(type As String, dataSource As Object, dbSetting As DBSetting, bUseDefault As Boolean, reportOption As BasicReportOption, reportInfo As ReportInfo)
            If dbSetting Is Nothing Then
                Throw New ArgumentNullException("dbSetting")
            End If
            If reportOption Is Nothing Then
                Throw New ArgumentNullException("reportOption")
            End If
            If reportInfo Is Nothing Then
                Throw New ArgumentNullException("reportInfo")
            End If
            If Not ReportTool.IsValidReportHeader(dbSetting) Then
                Return
            End If
            reportInfo.SetDBSetting(dbSetting)
            Try
                Dim reports As List(Of NameReportEntity) = ReportTool.GetReports(type, dataSource, dbSetting, bUseDefault)
                If reports.Count = 0 Then
                    Return
                End If
                Dim printerSettings As PrinterSettings = DirectCast(Nothing, PrinterSettings)
                If reportOption.ShowPrintDialog Then
                    Using printDialog As New PrintDialog()
                        printDialog.UseEXDialog = True
                        printDialog.AllowSomePages = True
                        printDialog.PrinterSettings = New PrinterSettings()
                        Dim printerName As String = printDialog.PrinterSettings.PrinterName
                        printDialog.PrinterSettings.PrinterName = reportOption.PrinterName
                        If reports.Count >= 1 Then
                            Dim report As XtraReport = reports(0).Report
                            If report.PrinterName IsNot Nothing AndAlso report.PrinterName.Length > 0 Then
                                printDialog.PrinterSettings.PrinterName = report.PrinterName
                            End If
                        End If
                        If Not printDialog.PrinterSettings.IsValid Then
                            printDialog.PrinterSettings.PrinterName = printerName
                        End If
                        If printDialog.ShowDialog() <> DialogResult.OK Then
                            Return
                        End If
                        printerSettings = printDialog.PrinterSettings
                    End Using
                End If
                Dim str As String = "ADMIN"
                Dim orCreate As UserAuthentication = UserAuthentication.GetOrCreate(dbSetting)
                If orCreate.IsLogin Then
                    str = orCreate.LoginUserID
                End If
                For index As Integer = 0 To reports.Count - 1
                    Dim nameReportEntity As NameReportEntity = reports(index)
                    Dim report As XtraReport = nameReportEntity.Report
                    Dim name As String = nameReportEntity.Name
                    ReportTool.ApplyReportOption(report, reportOption)
                    Dim printFix As New ReportTool.PrintFix(report, name, dbSetting, printerSettings, reportOption.PrinterName, reportInfo, _
                        True)
                    Dim scriptObject As ScriptObject = ReportTool.GetScriptObject(dbSetting)
                    Dim beforePrintEventArgs As New ReportTool.BeforePrintEventArgs(dbSetting, type, report, name, printerSettings, reportOption, _
                        reportInfo, printFix)
                    scriptObject.RunMethod("BeforePrint", New Type(0) {beforePrintEventArgs.[GetType]()}, DirectCast(beforePrintEventArgs, Object))
                    If beforePrintEventArgs.AllowPrint Then
                        XtraReportExtensions.Print(DirectCast(report, IReport))
                        Dim afterPrintEventArgs As New ReportTool.AfterPrintEventArgs(dbSetting, type, report, name, printerSettings, reportOption, _
                            reportInfo, printFix)
                        scriptObject.RunMethod("AfterPrint", New Type(0) {afterPrintEventArgs.[GetType]()}, DirectCast(afterPrintEventArgs, Object))
                        Activity.Log(dbSetting, reportInfo.DocType, reportInfo.DocKey, 0L, Localizer.GetString(DirectCast(ReportToolStringId.Print_ActivityStream, [Enum]), DirectCast(str, Object), DirectCast(reportInfo.ReportTitle, Object), DirectCast(name, Object)), reportInfo.CriteriaText)
                        AuditTrail.Log(dbSetting, reportInfo.DocType, reportInfo.DocKey, AuditTrail.EventType.Print, Localizer.GetString(DirectCast(ReportToolStringId.Print_AuditTrail, [Enum]), DirectCast(reportInfo.ReportTitle, Object), DirectCast(name, Object)), reportInfo.CriteriaText)
                    End If
                Next
            Catch ex As InvalidPrinterException
                AppMessage.ShowErrorMessage(ex.Message)
            Catch ex As Win32Exception
                AppMessage.ShowErrorMessage(Localizer.GetString(DirectCast(ReportToolStringId.AccessDeniedToPrinter, [Enum]), DirectCast(ex.Message, Object)))
            Catch ex As ExternalException
                AppMessage.ShowErrorMessage(ex.Message)
            Catch ex As AccessViolationException
                AppMessage.ShowErrorMessage(ex.Message)
            Catch ex As AppException
                AppMessage.ShowErrorMessage(ex.Message)
            End Try
        End Sub

        Public Shared Sub PrintReportByName(reportName As String, dataSource As Object, dbSetting As DBSetting, reportOption As BasicReportOption, reportInfo As ReportInfo)
            If dbSetting Is Nothing Then
                Throw New ArgumentNullException("dbSetting")
            End If
            If reportOption Is Nothing Then
                Throw New ArgumentNullException("reportOption")
            End If
            If reportInfo Is Nothing Then
                Throw New ArgumentNullException("reportInfo")
            End If
            If Not ReportTool.IsValidReportHeader(dbSetting) Then
                Return
            End If
            reportInfo.SetDBSetting(dbSetting)
            Try
                Dim reportByName As ReportTemplate = ReportTool.GetReportByName(reportName, dataSource, dbSetting)
                If reportByName Is Nothing Then
                    Return
                End If
                Dim report As XtraReport = reportByName.Report
                Dim printerSettings As PrinterSettings = DirectCast(Nothing, PrinterSettings)
                If reportOption.ShowPrintDialog Then
                    Using printDialog As New PrintDialog()
                        printDialog.UseEXDialog = True
                        printDialog.AllowSomePages = True
                        printDialog.PrinterSettings = New PrinterSettings()
                        Dim printerName As String = printDialog.PrinterSettings.PrinterName
                        printDialog.PrinterSettings.PrinterName = reportOption.PrinterName
                        If report.PrinterName IsNot Nothing AndAlso report.PrinterName.Length > 0 Then
                            printDialog.PrinterSettings.PrinterName = report.PrinterName
                        End If
                        If Not printDialog.PrinterSettings.IsValid Then
                            printDialog.PrinterSettings.PrinterName = printerName
                        End If
                        If printDialog.ShowDialog() <> DialogResult.OK Then
                            Return
                        End If
                        printerSettings = printDialog.PrinterSettings
                    End Using
                End If
                ReportTool.ApplyReportOption(report, reportOption)
                Dim printFix As New ReportTool.PrintFix(report, reportName, dbSetting, printerSettings, reportOption.PrinterName, reportInfo, _
                    True)
                Dim scriptObject As ScriptObject = ReportTool.GetScriptObject(dbSetting)
                Dim beforePrintEventArgs As New ReportTool.BeforePrintEventArgs(dbSetting, reportByName.ReportType, report, reportName, printerSettings, reportOption, _
                    reportInfo, printFix)
                scriptObject.RunMethod("BeforePrint", New Type(0) {beforePrintEventArgs.[GetType]()}, DirectCast(beforePrintEventArgs, Object))
                If Not beforePrintEventArgs.AllowPrint Then
                    Return
                End If
                XtraReportExtensions.Print(DirectCast(report, IReport))
                Dim afterPrintEventArgs As New ReportTool.AfterPrintEventArgs(dbSetting, reportByName.ReportType, report, reportName, printerSettings, reportOption, _
                    reportInfo, printFix)
                scriptObject.RunMethod("AfterPrint", New Type(0) {afterPrintEventArgs.[GetType]()}, DirectCast(afterPrintEventArgs, Object))
                Dim str As String = "ADMIN"
                Dim orCreate As UserAuthentication = UserAuthentication.GetOrCreate(dbSetting)
                If orCreate.IsLogin Then
                    str = orCreate.LoginUserID
                End If
                Activity.Log(dbSetting, reportInfo.DocType, reportInfo.DocKey, 0L, Localizer.GetString(DirectCast(ReportToolStringId.Print_ActivityStream, [Enum]), DirectCast(str, Object), DirectCast(reportInfo.ReportTitle, Object), DirectCast(reportName, Object)), reportInfo.CriteriaText)
                AuditTrail.Log(dbSetting, reportInfo.DocType, reportInfo.DocKey, AuditTrail.EventType.Print, Localizer.GetString(DirectCast(ReportToolStringId.Print_AuditTrail, [Enum]), DirectCast(reportInfo.ReportTitle, Object), DirectCast(reportName, Object)), reportInfo.CriteriaText)
            Catch ex As Win32Exception
                AppMessage.ShowErrorMessage(Localizer.GetString(DirectCast(ReportToolStringId.AccessDeniedToPrinter, [Enum]), DirectCast(ex.Message, Object)))
            Catch ex As ExternalException
                AppMessage.ShowErrorMessage(ex.Message)
            Catch ex As AccessViolationException
                AppMessage.ShowErrorMessage(ex.Message)
            Catch ex As AppException
                AppMessage.ShowErrorMessage(ex.Message)
            End Try
        End Sub

        Public Shared Sub PreviewReport(type As String, dataSource As Object, dbSetting As DBSetting, bUseDefault As Boolean, bShowModal As Boolean, reportOption As BasicReportOption, _
            reportInfo As ReportInfo)
            If dbSetting Is Nothing Then
                Throw New ArgumentNullException("dbSetting")
            End If
            If reportOption Is Nothing Then
                Throw New ArgumentNullException("reportOption")
            End If
            If reportInfo Is Nothing Then
                Throw New ArgumentNullException("reportInfo")
            End If
            If Not ReportTool.IsValidReportHeader(dbSetting) Then
                Return
            End If
            reportInfo.SetDBSetting(dbSetting)
            Try
                Dim reports As List(Of NameReportEntity) = ReportTool.GetReports(type, dataSource, dbSetting, bUseDefault)
                Dim str As String = "ADMIN"
                Dim orCreate As UserAuthentication = UserAuthentication.GetOrCreate(dbSetting)
                If orCreate.IsLogin Then
                    str = orCreate.LoginUserID
                End If
                For index As Integer = 0 To reports.Count - 1
                    Dim nameReportEntity As NameReportEntity = reports(index)
                    Dim report As XtraReport = nameReportEntity.Report
                    Dim name As String = nameReportEntity.Name
                    ReportTool.ApplyReportOption(report, reportOption)
                    Dim printFix As New ReportTool.PrintFix(report, name, dbSetting, DirectCast(Nothing, PrinterSettings), reportOption.PrinterName, reportInfo, _
                        False)
                    Activity.Log(dbSetting, reportInfo.DocType, reportInfo.DocKey, 0L, Localizer.GetString(DirectCast(ReportToolStringId.PreviewUsingReportTemplate, [Enum]), DirectCast(str, Object), DirectCast(reportInfo.ReportTitle, Object), DirectCast(name, Object)), reportInfo.CriteriaText)
                    AuditTrail.Log(dbSetting, reportInfo.DocType, reportInfo.DocKey, AuditTrail.EventType.Print, Localizer.GetString(DirectCast(ReportToolStringId.PreviewUsing, [Enum]), DirectCast(reportInfo.ReportTitle, Object), DirectCast(name, Object)), reportInfo.CriteriaText)
                    If ReportTool.myUseRibbonPreviewForm Then
                        If bShowModal Then
                            Using formRibbonPreview As New FormRibbonPreview(dbSetting, report, name, reportInfo, reportOption, printFix)
                                Dim num As Integer = CInt(formRibbonPreview.ShowDialog())
                            End Using
                        Else
							New ThreadForm(GetType(FormRibbonPreview).AssemblyQualifiedName, New Type(5) {GetType(DBSetting), GetType(XtraReport), GetType(String), GetType(ReportInfo), GetType(BasicReportOption), GetType(ReportTool.PrintFix)}, New Object(5) {DirectCast(dbSetting, Object), DirectCast(report, Object), DirectCast(name, Object), DirectCast(reportInfo, Object), DirectCast(reportOption, Object), DirectCast(printFix, Object)}).Show()
                        End If
                    ElseIf bShowModal Then
                        Using formPreview As New FormPreview(dbSetting, report, name, reportInfo, reportOption, printFix)
                            Dim num As Integer = CInt(formPreview.ShowDialog())
                        End Using
                    Else
						New ThreadForm(GetType(FormPreview).AssemblyQualifiedName, New Type(5) {GetType(DBSetting), GetType(XtraReport), GetType(String), GetType(ReportInfo), GetType(BasicReportOption), GetType(ReportTool.PrintFix)}, New Object(5) {DirectCast(dbSetting, Object), DirectCast(report, Object), DirectCast(name, Object), DirectCast(reportInfo, Object), DirectCast(reportOption, Object), DirectCast(printFix, Object)}).Show()
                    End If
                Next
            Catch ex As ExternalException
                AppMessage.ShowErrorMessage(ex.Message)
            Catch ex As AccessViolationException
                AppMessage.ShowErrorMessage(ex.Message)
            Catch ex As AppException
                AppMessage.ShowErrorMessage(ex.Message)
            End Try
        End Sub

        Public Shared Sub PreviewReportByName(reportName As String, dataSource As Object, dbSetting As DBSetting, bShowModal As Boolean, reportOption As BasicReportOption, reportInfo As ReportInfo)
            If dbSetting Is Nothing Then
                Throw New ArgumentNullException("dbSetting")
            End If
            If reportOption Is Nothing Then
                Throw New ArgumentNullException("reportOption")
            End If
            If reportInfo Is Nothing Then
                Throw New ArgumentNullException("reportInfo")
            End If
            If Not ReportTool.IsValidReportHeader(dbSetting) Then
                Return
            End If
            reportInfo.SetDBSetting(dbSetting)
            Try
                Dim reportByName As ReportTemplate = ReportTool.GetReportByName(reportName, dataSource, dbSetting)
                If reportByName Is Nothing Then
                    Return
                End If
                Dim report As XtraReport = reportByName.Report
                ReportTool.ApplyReportOption(report, reportOption)
                Dim printFix As New ReportTool.PrintFix(report, reportName, dbSetting, DirectCast(Nothing, PrinterSettings), reportOption.PrinterName, reportInfo, _
                    False)
                Dim str As String = "ADMIN"
                Dim orCreate As UserAuthentication = UserAuthentication.GetOrCreate(dbSetting)
                If orCreate.IsLogin Then
                    str = orCreate.LoginUserID
                End If
                Activity.Log(dbSetting, reportInfo.DocType, reportInfo.DocKey, 0L, Localizer.GetString(DirectCast(ReportToolStringId.PreviewUsingReportTemplate, [Enum]), DirectCast(str, Object), DirectCast(reportInfo.ReportTitle, Object), DirectCast(reportName, Object)), reportInfo.CriteriaText)
                AuditTrail.Log(dbSetting, reportInfo.DocType, reportInfo.DocKey, AuditTrail.EventType.Print, Localizer.GetString(DirectCast(ReportToolStringId.PreviewUsing, [Enum]), DirectCast(reportInfo.ReportTitle, Object), DirectCast(reportName, Object)), reportInfo.CriteriaText)
                If ReportTool.myUseRibbonPreviewForm Then
                    If bShowModal Then
                        Using formRibbonPreview As New FormRibbonPreview(dbSetting, report, reportName, reportInfo, reportOption, printFix)
                            Dim num As Integer = CInt(formRibbonPreview.ShowDialog())
                        End Using
                    Else
						New ThreadForm(GetType(FormRibbonPreview).AssemblyQualifiedName, New Type(5) {GetType(DBSetting), GetType(XtraReport), GetType(String), GetType(ReportInfo), GetType(BasicReportOption), GetType(ReportTool.PrintFix)}, New Object(5) {DirectCast(dbSetting, Object), DirectCast(report, Object), DirectCast(reportName, Object), DirectCast(reportInfo, Object), DirectCast(reportOption, Object), DirectCast(printFix, Object)}).Show()
                    End If
                ElseIf bShowModal Then
                    Using formPreview As New FormPreview(dbSetting, report, reportName, reportInfo, reportOption, printFix)
                        Dim num As Integer = CInt(formPreview.ShowDialog())
                    End Using
                Else
					New ThreadForm(GetType(FormPreview).AssemblyQualifiedName, New Type(5) {GetType(DBSetting), GetType(XtraReport), GetType(String), GetType(ReportInfo), GetType(BasicReportOption), GetType(ReportTool.PrintFix)}, New Object(5) {DirectCast(dbSetting, Object), DirectCast(report, Object), DirectCast(reportName, Object), DirectCast(reportInfo, Object), DirectCast(reportOption, Object), DirectCast(printFix, Object)}).Show()
                End If
            Catch ex As ExternalException
                AppMessage.ShowErrorMessage(ex.Message)
            Catch ex As AccessViolationException
                AppMessage.ShowErrorMessage(ex.Message)
            Catch ex As AppException
                AppMessage.ShowErrorMessage(ex.Message)
            End Try
        End Sub

        Public Shared Sub ExportReportByName(reportName As String, dataSource As Object, dbSetting As DBSetting, reportOption As BasicReportOption, reportInfo As ReportInfo, fileName As String, _
            exportFormat__1 As ExportFormat)
            If dbSetting Is Nothing Then
                Throw New ArgumentNullException("dbSetting")
            End If
            If reportOption Is Nothing Then
                Throw New ArgumentNullException("reportOption")
            End If
            If reportInfo Is Nothing Then
                Throw New ArgumentNullException("reportInfo")
            End If
            reportInfo.SetDBSetting(dbSetting)
            Dim reportByName As ReportTemplate = ReportTool.GetReportByName(reportName, dataSource, dbSetting)
            If reportByName Is Nothing Then
                Return
            End If
            Dim report As XtraReport = reportByName.Report
            ReportTool.ApplyReportOption(report, reportOption)
            Dim printFix As New ReportTool.PrintFix(report, reportName, dbSetting, DirectCast(Nothing, PrinterSettings), reportOption.PrinterName, reportInfo, _
                True)
            If exportFormat__1 = ExportFormat.Csv Then
                report.ExportToCsv(fileName)
            ElseIf exportFormat__1 = ExportFormat.Html Then
                report.ExportToHtml(fileName)
            ElseIf exportFormat__1 = ExportFormat.Image Then
                report.ExportToImage(fileName)
            ElseIf exportFormat__1 = ExportFormat.Mht Then
                report.ExportToMht(fileName)
            ElseIf exportFormat__1 = ExportFormat.Pdf Then
                report.ExportToPdf(fileName)
            ElseIf exportFormat__1 = ExportFormat.Rtf Then
                report.ExportToRtf(fileName)
            ElseIf exportFormat__1 = ExportFormat.Text Then
                report.ExportToText(fileName)
            Else
                report.ExportToXls(fileName)
            End If
        End Sub

        Public Shared Sub EmailReport(type As String, dataSource As Object, dbSetting As DBSetting, bUseDefault As Boolean, reportOption As BasicReportOption, reportInfo As ReportInfo)
            If dbSetting Is Nothing Then
                Throw New ArgumentNullException("dbSetting")
            End If
            If reportOption Is Nothing Then
                Throw New ArgumentNullException("reportOption")
            End If
            If reportInfo Is Nothing Then
                Throw New ArgumentNullException("reportInfo")
            End If
            reportInfo.SetDBSetting(dbSetting)
            Dim arrayList As New ArrayList()
            Try
                Dim reports As List(Of NameReportEntity) = ReportTool.GetReports(type, dataSource, dbSetting, bUseDefault)
                For index As Integer = 0 To reports.Count - 1
                    Dim nameReportEntity As NameReportEntity = reports(index)
                    Dim report As XtraReport = nameReportEntity.Report
                    Dim name As String = nameReportEntity.Name
                    ReportTool.ApplyReportOption(report, reportOption)
                    report.CreateDocument()
                    Dim tempFileName As String = Path.GetTempFileName()
                    report.PrintingSystem.ExportToPdf(tempFileName)
                    arrayList.Add(DirectCast(New Object(1) {DirectCast(tempFileName, Object), DirectCast(name, Object)}, Object))
                Next
                If arrayList.Count = 0 Then
                    Return
                End If
                Try
                    Dim emailData As New EmailData(reportInfo.EmailAndFaxInfo)
                    emailData.PathNameEntities = New PathAndFileNameEntity(arrayList.Count - 1) {}
                    Dim stringBuilder As New StringBuilder()
                    For index As Integer = 0 To arrayList.Count - 1
                        Dim objArray As Object() = DirectCast(arrayList(index), Object())
                        emailData.PathNameEntities(index).Path = DirectCast(objArray(0), String)
                        emailData.PathNameEntities(index).FileName = DirectCast(objArray(1), String) & Convert.ToString(".pdf")
                        If index > 0 Then
                            stringBuilder.Append(",")
                        End If
                        stringBuilder.Append(DirectCast(objArray(1), String))
                    Next
                    If Not ReportTool.SendMailByMAPI(ReportTool.IsMicrosoftOutlook64Bit(), emailData) Then
                        AppMessage.ShowErrorMessage(Localizer.GetString(DirectCast(ReportToolStringId.FailToSendMail, [Enum])))
                    Else
                        Dim str1 As String = "ADMIN"
                        Dim orCreate As UserAuthentication = UserAuthentication.GetOrCreate(dbSetting)
                        If orCreate.IsLogin Then
                            str1 = orCreate.LoginUserID
                        End If
                        Dim str2 As String = stringBuilder.ToString()
                        Activity.Log(dbSetting, reportInfo.DocType, reportInfo.DocKey, 0L, Localizer.GetString(DirectCast(ReportToolStringId.SendEmail_ActivityStream, [Enum]), DirectCast(str1, Object), DirectCast(reportInfo.EmailAndFaxInfo.Email, Object), DirectCast(str2, Object), DirectCast(Localizer.GetString(DirectCast(ReportToolStringId.PdfFormat, [Enum])), Object), DirectCast(reportInfo.ReportTitle, Object)), reportInfo.CriteriaText)
                        AuditTrail.Log(dbSetting, reportInfo.DocType, reportInfo.DocKey, AuditTrail.EventType.Print, Localizer.GetString(DirectCast(ReportToolStringId.SendEmail_AuditTrail, [Enum]), DirectCast(reportInfo.EmailAndFaxInfo.Email, Object), DirectCast(str2, Object), DirectCast(Localizer.GetString(DirectCast(ReportToolStringId.XlsFormat, [Enum])), Object), DirectCast(reportInfo.ReportTitle, Object)), reportInfo.CriteriaText)
                    End If
                Catch ex As IOException
                    AppMessage.ShowErrorMessage(ex.Message)
                End Try
            Catch ex As AppException
                AppMessage.ShowErrorMessage(ex.Message)
            Catch ex As ExternalException
                AppMessage.ShowErrorMessage(ex.Message)
            Catch ex As AccessViolationException
                AppMessage.ShowErrorMessage(ex.Message)
            Finally
                For index As Integer = 0 To arrayList.Count - 1
                    File.Delete(DirectCast(DirectCast(arrayList(index), Object())(0), String))
                Next
            End Try
        End Sub

        Public Shared Function SendMailByMAPI(isX64 As Boolean, emailData As EmailData) As Boolean
            Dim startupFile As String = BCE.Application.PathHelper.GetStartupFile(If(isX64, "SendMailByMAPI.exe", "SendMailByMAPI_x86.exe"))
            If File.Exists(startupFile) Then
                Dim mapName As String = Guid.NewGuid().ToString()
                Using [new] As MemoryMappedFile = MemoryMappedFile.CreateNew(mapName, 10000L)
                    Using viewStream As MemoryMappedViewStream = [new].CreateViewStream()
						New XmlSerializer(GetType(EmailData)).Serialize(DirectCast(viewStream, Stream), DirectCast(emailData, Object))
                    End Using
                    Dim process As New Process()
                    process.StartInfo.FileName = startupFile
                    process.StartInfo.UseShellExecute = False
                    process.StartInfo.CreateNoWindow = True
                    process.StartInfo.Arguments = String.Format("""{0}""", DirectCast(mapName, Object))
                    process.Start()
                    process.WaitForExit()
                    Return process.ExitCode = 0
                End Using
            Else
                Dim mail As New Mail()
                If emailData.EmailAndFaxInfo.Email IsNot Nothing Then
                    Dim email As String = emailData.EmailAndFaxInfo.Email
                    Dim chArray As Char() = New Char(1) {","c, ";"c}
                    For Each str1 As String In email.Split(chArray)
                        Dim str2 As String = str1.Trim()
                        If str2.Length > 0 Then
                            mail.AddRecipient(str2, str2, False)
                        End If
                    Next
                End If
                If emailData.EmailAndFaxInfo.CCEmail IsNot Nothing Then
                    Dim ccEmail As String = emailData.EmailAndFaxInfo.CCEmail
                    Dim chArray As Char() = New Char(1) {","c, ";"c}
                    For Each str1 As String In ccEmail.Split(chArray)
                        Dim str2 As String = str1.Trim()
                        If str2.Length > 0 Then
                            mail.AddRecipient(str2, str2, True)
                        End If
                    Next
                End If
                For index As Integer = 0 To emailData.PathNameEntities.Length - 1
                    Dim andFileNameEntity As PathAndFileNameEntity = emailData.PathNameEntities(index)
                    mail.AddAttachment(andFileNameEntity.Path, andFileNameEntity.FileName)
                Next
                mail.SetSubject(emailData.EmailAndFaxInfo.Subject)
                mail.SetBody(emailData.EmailAndFaxInfo.EmailBody)
                Return mail.Send(IntPtr.Zero, True)
            End If
        End Function

        Friend Shared Function IsMicrosoftOutlook64Bit() As Boolean
            Dim registryKey As RegistryKey = If(Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Office\15.0\Outlook"), Registry.LocalMachine.OpenSubKey("SOFTWARE\Microsoft\Office\14.0\Outlook"))
            If registryKey Is Nothing Then
                Return False
            End If
            Dim obj As Object = registryKey.GetValue("Bitness")
            If obj IsNot Nothing Then
                Return String.Compare(obj.ToString(), "x64", True) = 0
            End If
            Return False
        End Function

        Private Shared Sub FilterDenyList(table As DataTable, dbSetting As DBSetting)
            Dim reportDbUtil__1 As ReportDBUtil = ReportDBUtil.Create(dbSetting)
            Dim loginUserId As String = UserAuthentication.GetOrCreate(dbSetting).LoginUserID
            Dim userGroups As ArrayList = reportDbUtil__1.GetUserGroups(loginUserId)
            For Each dataRow As DataRow In DirectCast(table.Rows, InternalDataCollectionBase)
                If dataRow.RowState <> DataRowState.Deleted AndAlso CBool(dataRow("Show")) Then
                    Dim denyList As String = reportDbUtil__1.GetDenyList(dataRow("ReportName").ToString())
                    Dim chArray As Char() = New Char(0) {Environment.NewLine(0)}
                    For Each str As String In denyList.Split(chArray)
                        Dim strA As String = str.Trim()
                        If String.Compare(strA, loginUserId, True) = 0 Then
                            dataRow("Show") = DirectCast(False, Object)
                            Exit For
                        End If
                        Dim flag As Boolean = False
                        For index As Integer = 0 To userGroups.Count - 1
                            If String.Compare(strA, DirectCast(userGroups(index), String), True) = 0 Then
                                dataRow("Show") = DirectCast(False, Object)
                                flag = True
                                Exit For
                            End If
                        Next
                        If flag Then
                            Exit For
                        End If
                    Next
                End If
            Next
            table.AcceptChanges()
        End Sub

        Private Shared Function GetReports(type As String, dataSource As Object, dbSetting As DBSetting, bUseDefault As Boolean) As List(Of NameReportEntity)
            If type Is Nothing Then
                Throw New ArgumentNullException("type")
            End If
            Dim instance As AutoCountReport = AutoCountReport.GetInstance()
            Dim list As New List(Of NameReportEntity)()
            If bUseDefault Then
                Dim defaultReport As String = ReportDBUtil.Create(dbSetting).GetDefaultReport(type)
                If defaultReport.Length > 0 Then
                    Try
                        Dim reportDbUtil__1 As ReportDBUtil = ReportDBUtil.Create(dbSetting)
                        Dim loginUserId As String = UserAuthentication.GetOrCreate(dbSetting).LoginUserID
                        Dim userGroups As ArrayList = reportDbUtil__1.GetUserGroups(loginUserId)
                        Dim strArray As String() = reportDbUtil__1.GetDenyList(defaultReport).Split(Environment.NewLine(0))
                        Dim flag1 As Boolean = True
                        For index1 As Integer = 0 To strArray.Length - 1
                            Dim strA As String = strArray(index1).Trim()
                            If String.Compare(strA, loginUserId, True) = 0 Then
                                flag1 = False
                                Exit For
                            End If
                            Dim flag2 As Boolean = False
                            For index2 As Integer = 0 To userGroups.Count - 1
                                If String.Compare(strA, DirectCast(userGroups(index2), String), True) = 0 Then
                                    flag1 = False
                                    flag2 = True
                                    Exit For
                                End If
                            Next
                            If flag2 Then
                                Exit For
                            End If
                        Next
                        If flag1 Then
                            Dim report As ReportTemplate = instance.GetReport(defaultReport, dataSource, dbSetting, True)
                            list.Add(New NameReportEntity(report.Report, defaultReport))
                            Return list
                        End If
                    Catch ex As Exception
                    End Try
                End If
            End If
            Dim reportList As DataTable = instance.GetReportList(type, dbSetting)
            ReportTool.FilterTable(dbSetting, reportList, ModuleControl.GetOrCreate(dbSetting).ModuleController)
            ReportTool.FilterDenyList(reportList, dbSetting)
            Dim dataView As New DataView(reportList)
            dataView.RowFilter = "Show=true"
            Dim strArray1 As String() = DirectCast(Nothing, String())
            If dataView.Count = 0 Then
                AppMessage.ShowMessage(DirectCast(Nothing, IWin32Window), Localizer.GetString(DirectCast(ReportToolStringId.NoReportFound, [Enum])))
            ElseIf dataView.Count = 1 Then
                strArray1 = New String(0) {dataView(0)("ReportName").ToString()}
            Else
                Using formSelectReport As New FormSelectReport(reportList, dbSetting)
                    If formSelectReport.ShowDialog() = DialogResult.OK Then
                        strArray1 = formSelectReport.SelectedReports
                    End If
                End Using
            End If
            If strArray1 IsNot Nothing Then
                For index As Integer = 0 To strArray1.Length - 1
                    Dim report As ReportTemplate = instance.GetReport(strArray1(index), dataSource, dbSetting, True)
                    list.Add(New NameReportEntity(report.Report, strArray1(index)))
                Next
            End If
            Return list
        End Function

        Private Shared Function GetReportByName(name As String, dataSource As Object, dbSetting As DBSetting) As ReportTemplate
            If name Is Nothing Then
                Throw New ArgumentNullException("name")
            End If
            Dim instance As AutoCountReport = AutoCountReport.GetInstance()
            Dim reportDbUtil__1 As ReportDBUtil = ReportDBUtil.Create(dbSetting)
            Dim loginUserId As String = UserAuthentication.GetOrCreate(dbSetting).LoginUserID
            Dim userGroups As ArrayList = reportDbUtil__1.GetUserGroups(loginUserId)
            Dim strArray As String() = reportDbUtil__1.GetDenyList(name).Split(Environment.NewLine(0))
            Dim flag1 As Boolean = True
            For index1 As Integer = 0 To strArray.Length - 1
                Dim strA As String = strArray(index1).Trim()
                If String.Compare(strA, loginUserId, True) = 0 Then
                    flag1 = False
                    Exit For
                End If
                Dim flag2 As Boolean = False
                For index2 As Integer = 0 To userGroups.Count - 1
                    If String.Compare(strA, DirectCast(userGroups(index2), String), True) = 0 Then
                        flag1 = False
                        flag2 = True
                        Exit For
                    End If
                Next
                If flag2 Then
                    Exit For
                End If
            Next
            If flag1 Then
                Return instance.GetReport(name, dataSource, dbSetting, True)
            End If
            AppMessage.ShowMessage(DirectCast(Nothing, IWin32Window), Localizer.GetString(DirectCast(ReportToolStringId.CannotOpenReport, [Enum]), DirectCast(name, Object)))
            Return DirectCast(Nothing, ReportTemplate)
        End Function

        Private Shared Sub SetBlack(report As XtraReportBase)
            For Each band As Band In DirectCast(report.Bands, CollectionBase)
                Dim detailReportBand As DetailReportBand = TryCast(band, DetailReportBand)
                If detailReportBand Is Nothing Then
                    For Each control As XRControl In DirectCast(band.Controls, CollectionBase)
                        ReportTool.SetControlBlack(control)
                    Next
                Else
                    ReportTool.SetBlack(DirectCast(detailReportBand, XtraReportBase))
                End If
            Next
        End Sub

        Private Shared Sub SetControlBlack(control As XRControl)
            Dim xrSubreport As XRSubreport = TryCast(control, XRSubreport)
            If xrSubreport Is Nothing Then
                control.ForeColor = System.Drawing.Color.Black
                For Each control1 As XRControl In DirectCast(control.Controls, CollectionBase)
                    ReportTool.SetControlBlack(control1)
                Next
            Else
                If xrSubreport.ReportSource Is Nothing Then
                    Return
                End If
                ReportTool.SetBlack(DirectCast(xrSubreport.ReportSource, XtraReportBase))
            End If
        End Sub

        Public Shared Sub DesignReport(type As String, dbSetting As DBSetting)
            Dim formDesignReport As FormDesignReport = DirectCast(Nothing, FormDesignReport)
            Try
                formDesignReport = New FormDesignReport(type, dbSetting)
                Dim num As Integer = CInt(formDesignReport.ShowDialog())
            Catch ex As AppException
                AppMessage.ShowErrorMessage(DirectCast(Nothing, IWin32Window), ex.Message)
            Finally
                If formDesignReport IsNot Nothing Then
                    formDesignReport.Dispose()
                End If
            End Try
        End Sub

        Public Shared Sub DesignReport(type As String, dataSource As Object, dbSetting As DBSetting)
            Dim formDesignReport As FormDesignReport = DirectCast(Nothing, FormDesignReport)
            Try
                formDesignReport = New FormDesignReport(type, dataSource, dbSetting)
                Dim num As Integer = CInt(formDesignReport.ShowDialog())
            Catch ex As AppException
                AppMessage.ShowErrorMessage(DirectCast(Nothing, IWin32Window), ex.Message)
            Finally
                If formDesignReport IsNot Nothing Then
                    formDesignReport.Dispose()
                End If
            End Try
        End Sub

        Public Shared Function DesignUserReportByName(owner As IWin32Window, reportName As String, dbSetting As DBSetting) As Boolean
            If dbSetting.ExecuteScalar("SELECT ReportType FROM Report WHERE ReportName=?", DirectCast(reportName, Object)) Is Nothing Then
                Return False
            End If
            Dim dataSource As Object = DirectCast(Nothing, Object)
            Dim report1 As ReportTemplate = AutoCountReport.GetInstance().GetReport(reportName, dataSource, dbSetting, False)
            If report1 Is Nothing Then
                Return False
            End If
            Dim report2 As XtraReport = report1.Report
            Return New ReportDesigner(report1, reportName, dbSetting).ShowDialog(owner) = DialogResult.OK
        End Function

        Public Shared Function IsReportTypeEnabled(dbSetting As DBSetting, type As String, controller As ModuleController) As Boolean
            Dim attributes As String = ""
            Dim dataRow As DataRow = AutoCountReport.GetInstance().GetReportTypeTable().Rows.Find(DirectCast(type, Object))
            If dataRow IsNot Nothing Then
                attributes = dataRow("Attributes").ToString()
            End If
            Dim [boolean] As Boolean = DBRegistry.Create(dbSetting).GetBoolean(DirectCast(New UseTaxType(), IRegistryID))
            Return ReportTool.IsAttributeMatch(controller, [boolean], attributes)
        End Function

        Public Shared Function SelectReport(type As String, dataSource As Object, dbSetting As DBSetting, bUseDefault As Boolean, reportOption As BasicReportOption) As List(Of NameReportEntity)
            Try
                Dim reports As List(Of NameReportEntity) = ReportTool.GetReports(type, dataSource, dbSetting, bUseDefault)
                For index As Integer = 0 To reports.Count - 1
                    ReportTool.ApplyReportOption(reports(index).Report, reportOption)
                Next
                Return reports
            Catch ex As AppException
                AppMessage.ShowErrorMessage(ex.Message)
            Catch ex As ExternalException
                AppMessage.ShowErrorMessage(ex.Message)
            Catch ex As AccessViolationException
                AppMessage.ShowErrorMessage(ex.Message)
            End Try
            Return DirectCast(Nothing, List(Of NameReportEntity))
        End Function

        Public Class PrintFix
            Private myReportName As String
            Private myTableName As String
            Private myDocKeys As String
            Private myDBSetting As DBSetting
            Private myPrinterSettings As PrinterSettings
            Private myPrinterName As String
            Private myPrimaryKeyName As String
            Private myReportInfo As ReportInfo
            Private myReport As XtraReport
            Private myUserAuthentication As UserAuthentication

            Public Property PrinterSettings() As PrinterSettings
                Get
                    Return Me.myPrinterSettings
                End Get
                Set(value As PrinterSettings)
                    Me.myPrinterSettings = value
                End Set
            End Property

            Public Property PrinterName() As String
                Get
                    Return Me.myPrinterName
                End Get
                Set(value As String)
                    Me.myPrinterName = value
                End Set
            End Property

            Public Sub New(report As XtraReport, reportName As String, dbSetting As DBSetting, printerSettings As PrinterSettings, printerName As String, reportInfo As ReportInfo, _
                createDocument As Boolean)
                Dim tableName As String = ""
                Dim primaryKeyName As String = ""
                If reportInfo IsNot Nothing Then
                    tableName = reportInfo.UpdatePrintCountTableName
                    primaryKeyName = reportInfo.UpdatePrintCountPrimaryKeyName
                End If
                Me.Initialize(report, reportName, tableName, dbSetting, printerSettings, printerName, _
                    primaryKeyName, reportInfo, createDocument)
            End Sub

            Private Sub Initialize(report As XtraReport, reportName As String, tableName As String, dbSetting As DBSetting, printerSettings As PrinterSettings, printerName As String, _
                primaryKeyName As String, reportInfo As ReportInfo, createDocument As Boolean)
                Me.myReport = report
                Me.myReportName = reportName
                Me.myTableName = tableName
                Me.myDBSetting = dbSetting
                Me.myPrinterSettings = printerSettings
                Me.myPrinterName = printerName
                Me.myPrimaryKeyName = primaryKeyName
                Me.myReportInfo = reportInfo
                Me.myUserAuthentication = UserAuthentication.GetOrCreate(dbSetting)
                Me.BuildDocKeys(report)
                Me.myReport.PrintingSystem.StartPrint += New PrintDocumentEventHandler(AddressOf Me.StartPrint)
                If Not createDocument Then
                    Return
                End If
                report.CreateDocument()
            End Sub

            Private Sub BuildDocKeys(report As XtraReport)
                Me.myDocKeys = ""
                If Me.myTableName Is Nothing OrElse Me.myTableName.Length <= 0 OrElse (Me.myPrimaryKeyName Is Nothing OrElse Me.myPrimaryKeyName.Length <= 0) Then
                    Return
                End If
                Dim stringBuilder As New StringBuilder()
                Dim dataTable As DataTable = If(DirectCast(report.DataSource, DataSet).Tables("Master"), DirectCast(report.DataSource, DataSet).Tables(0))
                If dataTable IsNot Nothing Then
                    For Each dataRow As DataRow In DirectCast(dataTable.Rows, InternalDataCollectionBase)
                        If dataRow.RowState <> DataRowState.Deleted Then
                            stringBuilder.Append(dataRow(Me.myPrimaryKeyName))
                            stringBuilder.Append(vbLf & vbCr)
                        End If
                    Next
                End If
                If stringBuilder.Length <= 0 Then
                    Return
                End If
                Me.myDocKeys = stringBuilder.ToString(0, stringBuilder.Length - 2)
            End Sub

            Private Sub IncreasePrintCount()
                If Me.myTableName Is Nothing OrElse Me.myTableName.Length <= 0 OrElse (Me.myPrimaryKeyName Is Nothing OrElse Me.myPrimaryKeyName.Length <= 0) Then
                    Return
                End If
                If Me.myDocKeys.Length <= 0 Then
                    Return
                End If
                Try
                    Me.myDBSetting.ExecuteNonQuery(String.Format("UPDATE {0} SET PrintCount=PrintCount+1 WHERE {1} IN (SELECT * FROM LIST2(?))", DirectCast(Me.myTableName, Object), DirectCast(Me.myPrimaryKeyName, Object)), DirectCast(Me.myDocKeys, Object))
                Catch
                End Try
            End Sub

            Private Sub StartPrint(sender As Object, e As PrintDocumentEventArgs)
                If e.PrintDocument Is Nothing Then
                    Return
                End If
                e.PrintDocument.DocumentName = Me.myReportName
                If Me.myPrinterSettings IsNot Nothing Then
                    e.PrintDocument.PrinterSettings = Me.myPrinterSettings
                ElseIf Me.myPrinterName.Length > 0 Then
                    Dim printerName As String = e.PrintDocument.PrinterSettings.PrinterName
                    e.PrintDocument.PrinterSettings.PrinterName = Me.myPrinterName
                    If Not e.PrintDocument.PrinterSettings.IsValid Then
                        e.PrintDocument.PrinterSettings.PrinterName = printerName
                    End If
                End If
                Me.IncreasePrintCount()
            End Sub
        End Class

        Public Class PrintEventArgs
            Private myDBSetting As DBSetting
            Private myReportType As String
            Private myReport As XtraReport
            Private myReportName As String
            Private myPrinterSettings As PrinterSettings
            Private myReportOption As BasicReportOption
            Private myReportInfo As ReportInfo
            Private myPrintFix As ReportTool.PrintFix

            Public ReadOnly Property DBSetting() As DBSetting
                Get
                    Return Me.myDBSetting
                End Get
            End Property

            Public ReadOnly Property ReportType() As String
                Get
                    Return Me.myReportType
                End Get
            End Property

            Public ReadOnly Property Report() As XtraReport
                Get
                    Return Me.myReport
                End Get
            End Property

            Public ReadOnly Property ReportName() As String
                Get
                    Return Me.myReportName
                End Get
            End Property

            Public ReadOnly Property PrinterSettings() As PrinterSettings
                Get
                    Return Me.myPrinterSettings
                End Get
            End Property

            Public ReadOnly Property ReportOption() As BasicReportOption
                Get
                    Return Me.myReportOption
                End Get
            End Property

            Public ReadOnly Property ReportInfo() As ReportInfo
                Get
                    Return Me.myReportInfo
                End Get
            End Property

            Public ReadOnly Property PrintFix() As ReportTool.PrintFix
                Get
                    Return Me.myPrintFix
                End Get
            End Property

            Public Sub New(dbSetting As DBSetting, reportType As String, report As XtraReport, reportName As String, printerSettings As PrinterSettings, reportOption As BasicReportOption, _
                reportInfo As ReportInfo, printFix As ReportTool.PrintFix)
                Me.myDBSetting = dbSetting
                Me.myReportType = reportType
                Me.myReport = report
                Me.myReportName = reportName
                Me.myPrinterSettings = printerSettings
                Me.myReportOption = reportOption
                Me.myReportInfo = reportInfo
                Me.myPrintFix = printFix
            End Sub

            Public Sub Print()
                XtraReportExtensions.Print(DirectCast(Me.myReport, IReport))
            End Sub

            Public Sub Print(printerName As String)
                XtraReportExtensions.Print(DirectCast(Me.myReport, IReport), printerName)
            End Sub
        End Class

        Public Class BeforePrintEventArgs
            Inherits ReportTool.PrintEventArgs
            Private myAllowPrint As Boolean = True

            Public Property AllowPrint() As Boolean
                Get
                    Return Me.myAllowPrint
                End Get
                Set(value As Boolean)
                    Me.myAllowPrint = value
                End Set
            End Property

            Public Sub New(dbSetting As DBSetting, reportType As String, report As XtraReport, reportName As String, printerSettings As PrinterSettings, reportOption As BasicReportOption, _
                reportInfo As ReportInfo, printFix As ReportTool.PrintFix)
                MyBase.New(dbSetting, reportType, report, reportName, printerSettings, reportOption, _
                    reportInfo, printFix)
            End Sub
        End Class

        Public Class AfterPrintEventArgs
            Inherits ReportTool.PrintEventArgs
            Public Sub New(dbSetting As DBSetting, reportType As String, report As XtraReport, reportName As String, printerSettings As PrinterSettings, reportOption As BasicReportOption, _
                reportInfo As ReportInfo, printFix As ReportTool.PrintFix)
                MyBase.New(dbSetting, reportType, report, reportName, printerSettings, reportOption, _
                    reportInfo, printFix)
            End Sub
        End Class
    End Class
End Namespace