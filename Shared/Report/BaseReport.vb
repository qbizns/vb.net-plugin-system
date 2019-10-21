'Imports BCE.AutoCount.Authentication
'Imports BCE.AutoCount.Settings
'Imports BCE.Data
Imports DevExpress.XtraReports.Serialization
Imports DevExpress.XtraReports.UI
Imports System.Collections
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Globalization

Namespace Salling.Report
    Public Class BaseReport
        Inherits XtraReport
        Private myReportType As String = ""
        Private myScriptVersion As String = ""
        Private myAlwaysSetPaddingToZero As Boolean = True
        Private myTagFunctions As New List(Of ITagFunction)()
        Private Shared myLastSerializedDBSetting As DBSetting
        Private myDBSetting As DBSetting
        Private myDecimalSetting As DecimalSetting
        Private myGeneralSetting As GeneralSetting
        Private myUserAuthentication As UserAuthentication
        Private myEnableDebugMode As Boolean
        Private myDataSet As DataSet
        Private myReportOptionTable As DataTable

        <DefaultValue("")> _
        <Browsable(False)> _
        Public Property ReportType() As String
            Get
                Return Me.myReportType
            End Get
            Set(value As String)
                Me.myReportType = value
            End Set
        End Property

        <DefaultValue("")> _
        <Browsable(False)> _
        Public Property ScriptVersion() As String
            Get
                Return Me.myScriptVersion
            End Get
            Set(value As String)
                Me.myScriptVersion = value
            End Set
        End Property

        <Browsable(False)> _
        Public ReadOnly Property DBSetting() As DBSetting
            Get
                Return Me.myDBSetting
            End Get
        End Property

        <Browsable(False)> _
        Public ReadOnly Property DecimalSetting() As DecimalSetting
            Get
                Return Me.myDecimalSetting
            End Get
        End Property

        <Browsable(False)> _
        Public ReadOnly Property GeneralSetting() As GeneralSetting
            Get
                Return Me.myGeneralSetting
            End Get
        End Property

        <Browsable(False)> _
        Public ReadOnly Property UserAuthentication() As UserAuthentication
            Get
                Return Me.myUserAuthentication
            End Get
        End Property

        <Category("Behavior")> _
        <DefaultValue(True)> _
        <Description("Always set padding to zero")> _
        <Browsable(True)> _
        <EditorBrowsable(EditorBrowsableState.Always)> _
        Public Property AlwaysSetPaddingToZero() As Boolean
            Get
                Return Me.myAlwaysSetPaddingToZero
            End Get
            Set(value As Boolean)
                Me.myAlwaysSetPaddingToZero = value
            End Set
        End Property

        <Category("Debug")> _
        <Browsable(True)> _
        <EditorBrowsable(EditorBrowsableState.Always)> _
        <DefaultValue(False)> _
        <Description("Enable Debug Mode")> _
        Public Property EnableDebugMode() As Boolean
            Get
                Return Me.myEnableDebugMode
            End Get
            Set(value As Boolean)
                Me.myEnableDebugMode = value
            End Set
        End Property

        Public ReadOnly Property DataSet() As DataSet
            Get
                Return Me.myDataSet
            End Get
        End Property

        Public ReadOnly Property ReportOptionTable() As DataTable
            Get
                Return Me.myReportOptionTable
            End Get
        End Property

        Public Sub New()
            Me.Name = "Report"
        End Sub

        Friend Sub SetDBSetting(dbSetting As DBSetting)
            If dbSetting.Equals(DirectCast(Me.myDBSetting, Object)) Then
                Return
            End If
            Me.myDBSetting = dbSetting
            Me.myDecimalSetting = DecimalSetting.GetOrCreate(dbSetting)
            Me.myGeneralSetting = GeneralSetting.GetOrCreate(dbSetting)
            Me.myUserAuthentication = UserAuthentication.GetOrCreate(dbSetting)
        End Sub

        Protected Overrides Sub SerializeProperties(serializer As XRSerializer)
            MyBase.SerializeProperties(serializer)
            serializer.SerializeString("ReportType", Me.ReportType)
            serializer.SerializeString("ScriptVersion", Me.ScriptVersion)
            serializer.SerializeBoolean("AlwaysSetPaddingToZero", Me.myAlwaysSetPaddingToZero)
            serializer.SerializeBoolean("EnableDebugMode", Me.myEnableDebugMode)
            BaseReport.myLastSerializedDBSetting = Me.myDBSetting
        End Sub

        Protected Overrides Sub DeserializeProperties(serializer As XRSerializer)
            MyBase.DeserializeProperties(serializer)
            Me.ReportType = serializer.DeserializeString("ReportType", "")
            Me.ScriptVersion = serializer.DeserializeString("ScriptVersion", "")
            Me.myAlwaysSetPaddingToZero = serializer.DeserializeBoolean("AlwaysSetPaddingToZero", True)
            Me.myEnableDebugMode = serializer.DeserializeBoolean("EnableDebugMode", False)
            If BaseReport.myLastSerializedDBSetting Is Nothing Then
                Return
            End If
            Me.SetDBSetting(BaseReport.myLastSerializedDBSetting)
        End Sub

        Protected Overrides Sub OnBeforePrint(e As System.Drawing.Printing.PrintEventArgs)
            MyBase.OnBeforePrint(e)
            Dim reportTypeHandler As IReportTypeHandler = AutoCountReport.GetReportTypeHandler(Me.ReportType)
            If reportTypeHandler IsNot Nothing Then
                reportTypeHandler.BeforePrint(DirectCast(Me, XtraReport), e)
            End If
            Me.ProcessSpecialTags(Me)
        End Sub

        Protected Overrides Sub OnAfterPrint(e As EventArgs)
            MyBase.OnAfterPrint(e)
            For Each tagFunction As ITagFunction In Me.myTagFunctions
                tagFunction.RemoveFunction()
            Next
            Me.myTagFunctions.Clear()
        End Sub

        Protected Overrides Sub OnDataSourceChanging()
            MyBase.OnDataSourceChanging()
            Me.myDataSet = DirectCast(Me.DataSource, DataSet)
            If Me.myDataSet Is Nothing Then
                Me.myReportOptionTable = DirectCast(Nothing, DataTable)
            Else
                Me.myReportOptionTable = Me.myDataSet.Tables("Report Option")
            End If
        End Sub

        Public Function FindControlByDataMember(dataMember As String, propertyName As String) As XRControl
            Return BaseReport.FindControlByDataMember(DirectCast(Me, XtraReport), dataMember, propertyName)
        End Function

        Public Shared Function FindControlByDataMember(report As XtraReport, dataMember As String, propertyName As String) As XRControl
            For Each band As Band In DirectCast(report.Bands, CollectionBase)
                Dim xrControl As XRControl = BaseReport.TraverseBand(band, dataMember, propertyName)
                If xrControl IsNot Nothing Then
                    Return xrControl
                End If
            Next
            Return DirectCast(Nothing, XRControl)
        End Function

        Private Shared Function TraverseBand(band As Band, dataMember As String, propertyName As String) As XRControl
            Dim xrControl1 As XRControl = BaseReport.TraverseControls(band.Controls, dataMember, propertyName)
            If xrControl1 IsNot Nothing Then
                Return xrControl1
            End If
            If TypeOf band Is DetailReportBand Then
                For Each band1 As Band In DirectCast(DirectCast(band, XtraReportBase).Bands, CollectionBase)
                    Dim xrControl2 As XRControl = BaseReport.TraverseBand(band1, dataMember, propertyName)
                    If xrControl2 IsNot Nothing Then
                        Return xrControl2
                    End If
                Next
            End If
            Return DirectCast(Nothing, XRControl)
        End Function

        Private Shared Function TraverseControls(collection As XRControlCollection, dataMember As String, propertyName As String) As XRControl
            For Each xrControl1 As XRControl In DirectCast(collection, CollectionBase)
                For index As Integer = 0 To xrControl1.DataBindings.Count - 1
                    Dim xrBinding As XRBinding = xrControl1.DataBindings(index)
                    If String.Compare(xrBinding.DataMember, dataMember, True, CultureInfo.InvariantCulture) = 0 AndAlso String.Compare(xrBinding.PropertyName, propertyName, True, CultureInfo.InvariantCulture) = 0 Then
                        Return xrControl1
                    End If
                Next
                If TypeOf xrControl1 Is XRPanel Then
                    Dim xrControl2 As XRControl = BaseReport.TraverseControls(xrControl1.Controls, dataMember, propertyName)
                    If xrControl2 IsNot Nothing Then
                        Return xrControl2
                    End If
                End If
            Next
            Return DirectCast(Nothing, XRControl)
        End Function

        Private Sub ProcessSpecialTags(report As BaseReport)
            For Each band As Band In DirectCast(report.Bands, CollectionBase)
                Me.ProcessSpecialTags_TraverseBand(band)
            Next
        End Sub

        Private Sub ProcessSpecialTags_TraverseBand(band As Band)
            Me.ProcessSpecialTags_TraverseControls(band.Controls)
            If Not (TypeOf band Is DetailReportBand) Then
                Return
            End If
            For Each band1 As Band In DirectCast(DirectCast(band, XtraReportBase).Bands, CollectionBase)
                Me.ProcessSpecialTags_TraverseBand(band1)
            Next
        End Sub

        Private Sub ProcessSpecialTags_TraverseControls(collection As XRControlCollection)
            For Each label As XRControl In DirectCast(collection, CollectionBase)
                If label.Tag IsNot Nothing AndAlso TypeOf label.Tag Is String Then
                    Dim strArray As String() = DirectCast(label.Tag, String).Trim().Split(":"c)
                    If strArray(0).Length > 0 AndAlso CInt(strArray(0)(0)) = 64 Then
                        If String.Compare(strArray(0), "@PrintOnLastPageOnly", True, CultureInfo.InvariantCulture) = 0 Then
                            Me.myTagFunctions.Add(DirectCast(New PrintOnLastPageOnlyFunction(Me, label), ITagFunction))
                        ElseIf String.Compare(strArray(0), "@PrintOnEveryPageExceptLastPage", True, CultureInfo.InvariantCulture) = 0 Then
                            Me.myTagFunctions.Add(DirectCast(New PrintOnEveryPageExceptLastPageFunction(Me, label), ITagFunction))
                        ElseIf String.Compare(strArray(0), "@PageTotal", True, CultureInfo.InvariantCulture) = 0 Then
                            Dim controlName As String = ""
                            If strArray.Length >= 2 Then
                                controlName = strArray(1)
                            End If
                            Me.myTagFunctions.Add(DirectCast(New PageTotalFunction(Me, label, controlName), ITagFunction))
                        ElseIf String.Compare(strArray(0), "@BFPageTotal", True, CultureInfo.InvariantCulture) = 0 Then
                            Dim controlName As String = ""
                            If strArray.Length >= 2 Then
                                controlName = strArray(1)
                            End If
                            Me.myTagFunctions.Add(DirectCast(New BFPageTotalFunction(Me, label, controlName), ITagFunction))
                        ElseIf String.Compare(strArray(0), "@MultiCurrencySum", True, CultureInfo.InvariantCulture) = 0 AndAlso TypeOf label Is XRLabel Then
                            Me.myTagFunctions.Add(DirectCast(New MultiCurrencySumFunction(Me, DirectCast(label, XRLabel)), ITagFunction))
                        End If
                    End If
                End If
                If TypeOf label Is XRPanel Then
                    Me.ProcessSpecialTags_TraverseControls(label.Controls)
                End If
            Next
        End Sub
    End Class
End Namespace