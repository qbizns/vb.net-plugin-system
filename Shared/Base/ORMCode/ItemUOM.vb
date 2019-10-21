Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    Partial Public Class ItemUOM
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub

        Public Shared Function CreateItemUOM(ByVal uow As UnitOfWork, _
                                   ByVal Item As Items, _
                                   ByVal UnitName As String, _
                                   ByVal Rate As Decimal, _
                                   ByVal Price As Decimal, _
                                   ByVal Cost As Decimal, _
                                   ByVal MinSalePrice As Decimal, _
                                   ByVal BalQty As Decimal, _
                                   ByVal MinQty As Decimal, _
                                   ByVal MaxQty As Decimal, _
                                   ByVal ReOrderLevel As Decimal, _
                                   ByVal ReorderQty As Decimal
                                   ) As ItemUOM
            'Dim ItemUOM As ItemUOM = uow.FindObject(Of ItemUOM)(CriteriaOperator.Parse(String.Format("ItemName == '{0}'", ItemName)))
            'If ItemUOM Is Nothing Then
            Dim ItemUOM As ItemUOM = New ItemUOM(uow)
            ItemUOM.Item = Item
            ItemUOM.UnitName = UnitName
            ItemUOM.Rate = Rate
            ItemUOM.Price = Price
            ItemUOM.Cost = Cost
            ItemUOM.BalQty = BalQty
            ItemUOM.MinQty = MinQty
            ItemUOM.MaxQty = MaxQty
            ItemUOM.ReorderLevel = ReorderLevel
            ItemUOM.ReorderQty = ReorderQty
            ItemUOM.Save()
            uow.CommitChanges()
            'End If
            Return ItemUOM
        End Function

    End Class

End Namespace
