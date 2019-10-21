Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    Partial Public Class Items
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub


        Public Shared Function CreateItem(ByVal uow As UnitOfWork, _
                                           ByVal Code As String, _
                                           ByVal BarCode As String, _
                                           ByVal ArItemName As String, _
                                           ByVal EnItemName As String, _
                                           ByVal Company As String, _
                                           ByVal Descriptions As String, _
                                           ByVal IsBatchNumber As Boolean, _
                                           ByVal ISBonuesPoints As Boolean, _
                                           ByVal IsDiscounted As Boolean, _
                                           ByVal IsSerialNumber As Boolean, _
                                           ByVal IsStockControl As Boolean, _
                                           ByVal ItemImage As System.Drawing.Image, _
                                           ByVal CostingMethod As Integer, _
                                           ByVal BaseUOM As ItemUOM, _
                                           ByVal SaleUOM As ItemUOM, _
                                           ByVal PurchaseUOM As ItemUOM
                                           ) As Items
            Dim Items As Items = uow.FindObject(Of Items)(CriteriaOperator.Parse(String.Format("Barcode == '{0}' AND Code == '{1}'", BarCode, Code)))
            If Items Is Nothing Then
                Items = New Items(uow)
                Items.Code = Code
                Items.Barcode = BarCode
                Items.ArItemName = ArItemName
                Items.EnItemName = EnItemName
                Items.Company = Company
                Items.Descriptions = Descriptions
                Items.IsBatchNumber = IsBatchNumber
                Items.IsBonuesPoints = ISBonuesPoints
                Items.IsDiscounted = IsDiscounted
                Items.IsSerialNumber = IsSerialNumber
                Items.IsStockControl = IsStockControl
                Items.ItemImage = ItemImage
                Items.CostingMethod = CostingMethod
                Items.BaseUOM = BaseUOM
                Items.SaleUOM = SaleUOM
                Items.PurchaseUOM = PurchaseUOM
                Items.Save()
                uow.CommitChanges()
            End If
            Return Items
        End Function

    End Class

End Namespace
