'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    <DeferredDeletion(True)> _
    Partial Public Class ItemUOM
        Inherits XPObject
        Dim fItem As Items
        <Association("ItemUOMReferencesItems")> _
        Public Property Item() As Items
            Get
                Return fItem
            End Get
            Set(ByVal value As Items)
                SetPropertyValue(Of Items)("Item", fItem, value)
            End Set
        End Property
        Dim fUnitName As String
        Public Property UnitName() As String
            Get
                Return fUnitName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("UnitName", fUnitName, value)
            End Set
        End Property
        Dim fRate As Decimal
        Public Property Rate() As Decimal
            Get
                Return fRate
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("Rate", fRate, value)
            End Set
        End Property
        Dim fPrice As Decimal
        Public Property Price() As Decimal
            Get
                Return fPrice
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("Price", fPrice, value)
            End Set
        End Property
        Dim fCost As Decimal
        Public Property Cost() As Decimal
            Get
                Return fCost
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("Cost", fCost, value)
            End Set
        End Property
        Dim fBalQty As Decimal
        Public Property BalQty() As Decimal
            Get
                Return fBalQty
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("BalQty", fBalQty, value)
            End Set
        End Property
        Dim fMinQty As Decimal
        Public Property MinQty() As Decimal
            Get
                Return fMinQty
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("MinQty", fMinQty, value)
            End Set
        End Property
        Dim fMaxQty As Decimal
        Public Property MaxQty() As Decimal
            Get
                Return fMaxQty
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("MaxQty", fMaxQty, value)
            End Set
        End Property
        Dim fReorderLevel As Integer
        Public Property ReorderLevel() As Integer
            Get
                Return fReorderLevel
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ReorderLevel", fReorderLevel, value)
            End Set
        End Property
        Dim fReorderQty As Integer
        Public Property ReorderQty() As Integer
            Get
                Return fReorderQty
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ReorderQty", fReorderQty, value)
            End Set
        End Property
    End Class

End Namespace