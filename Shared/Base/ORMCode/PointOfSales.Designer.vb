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
    Partial Public Class PointOfSales
        Inherits XPObject
        Dim fArPosName As String
        Public Property ArPosName() As String
            Get
                Return fArPosName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ArPosName", fArPosName, value)
            End Set
        End Property
        Dim fEnPosName As String
        Public Property EnPosName() As String
            Get
                Return fEnPosName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("EnPosName", fEnPosName, value)
            End Set
        End Property
        Dim fOutputBill As DocumentTypes
        Public Property OutputBill() As DocumentTypes
            Get
                Return fOutputBill
            End Get
            Set(ByVal value As DocumentTypes)
                SetPropertyValue(Of DocumentTypes)("OutputBill", fOutputBill, value)
            End Set
        End Property
        Dim fReturnedBill As DocumentTypes
        Public Property ReturnedBill() As DocumentTypes
            Get
                Return fReturnedBill
            End Get
            Set(ByVal value As DocumentTypes)
                SetPropertyValue(Of DocumentTypes)("ReturnedBill", fReturnedBill, value)
            End Set
        End Property
        Dim fCashAccount As ChartOfAccount
        Public Property CashAccount() As ChartOfAccount
            Get
                Return fCashAccount
            End Get
            Set(ByVal value As ChartOfAccount)
                SetPropertyValue(Of ChartOfAccount)("CashAccount", fCashAccount, value)
            End Set
        End Property
        Dim fClosingCashAccount As ChartOfAccount
        Public Property ClosingCashAccount() As ChartOfAccount
            Get
                Return fClosingCashAccount
            End Get
            Set(ByVal value As ChartOfAccount)
                SetPropertyValue(Of ChartOfAccount)("ClosingCashAccount", fClosingCashAccount, value)
            End Set
        End Property
        Dim fCurrency As Currencies
        Public Property Currency() As Currencies
            Get
                Return fCurrency
            End Get
            Set(ByVal value As Currencies)
                SetPropertyValue(Of Currencies)("Currency", fCurrency, value)
            End Set
        End Property
        Dim fIsHasCashDrawer As Boolean
        Public Property IsHasCashDrawer() As Boolean
            Get
                Return fIsHasCashDrawer
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsHasCashDrawer", fIsHasCashDrawer, value)
            End Set
        End Property
        Dim fIsHasClientScreen As Boolean
        Public Property IsHasClientScreen() As Boolean
            Get
                Return fIsHasClientScreen
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsHasClientScreen", fIsHasClientScreen, value)
            End Set
        End Property
        Dim fIsForceSelectSaleRep As Boolean
        Public Property IsForceSelectSaleRep() As Boolean
            Get
                Return fIsForceSelectSaleRep
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsForceSelectSaleRep", fIsForceSelectSaleRep, value)
            End Set
        End Property
        Dim fReturnPassword As String
        Public Property ReturnPassword() As String
            Get
                Return fReturnPassword
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ReturnPassword", fReturnPassword, value)
            End Set
        End Property
        Dim fIsPrintAfterSaving As Boolean
        Public Property IsPrintAfterSaving() As Boolean
            Get
                Return fIsPrintAfterSaving
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsPrintAfterSaving", fIsPrintAfterSaving, value)
            End Set
        End Property
        Dim fIsAutoSelectCustomer As Boolean
        Public Property IsAutoSelectCustomer() As Boolean
            Get
                Return fIsAutoSelectCustomer
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsAutoSelectCustomer", fIsAutoSelectCustomer, value)
            End Set
        End Property
        Dim fCustomer_ As String
        Public Property Customer_() As String
            Get
                Return fCustomer_
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Customer_", fCustomer_, value)
            End Set
        End Property
        Dim fWeightBarcode As String
        Public Property WeightBarcode() As String
            Get
                Return fWeightBarcode
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("WeightBarcode", fWeightBarcode, value)
            End Set
        End Property
        Dim fDeleteFromLeft As Integer
        Public Property DeleteFromLeft() As Integer
            Get
                Return fDeleteFromLeft
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("DeleteFromLeft", fDeleteFromLeft, value)
            End Set
        End Property
        Dim fDeleteFromRight As Integer
        Public Property DeleteFromRight() As Integer
            Get
                Return fDeleteFromRight
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("DeleteFromRight", fDeleteFromRight, value)
            End Set
        End Property
        Dim fPriceList_ As String
        Public Property PriceList_() As String
            Get
                Return fPriceList_
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PriceList_", fPriceList_, value)
            End Set
        End Property
    End Class

End Namespace
