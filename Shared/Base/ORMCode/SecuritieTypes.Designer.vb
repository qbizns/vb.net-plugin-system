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
    Partial Public Class SecuritieTypes
        Inherits XPObject
        Dim fArTypeName As String
        Public Property ArTypeName() As String
            Get
                Return fArTypeName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ArTypeName", fArTypeName, value)
            End Set
        End Property
        Dim fEnTypeName As String
        Public Property EnTypeName() As String
            Get
                Return fEnTypeName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("EnTypeName", fEnTypeName, value)
            End Set
        End Property
        Dim fARAccount As ChartOfAccount
        Public Property ARAccount() As ChartOfAccount
            Get
                Return fARAccount
            End Get
            Set(ByVal value As ChartOfAccount)
                SetPropertyValue(Of ChartOfAccount)("ARAccount", fARAccount, value)
            End Set
        End Property
        Dim fAPAccount As ChartOfAccount
        Public Property APAccount() As ChartOfAccount
            Get
                Return fAPAccount
            End Get
            Set(ByVal value As ChartOfAccount)
                SetPropertyValue(Of ChartOfAccount)("APAccount", fAPAccount, value)
            End Set
        End Property
        Dim fUnderCollectionAccount As ChartOfAccount
        Public Property UnderCollectionAccount() As ChartOfAccount
            Get
                Return fUnderCollectionAccount
            End Get
            Set(ByVal value As ChartOfAccount)
                SetPropertyValue(Of ChartOfAccount)("UnderCollectionAccount", fUnderCollectionAccount, value)
            End Set
        End Property
        Dim fForwardAccount As ChartOfAccount
        Public Property ForwardAccount() As ChartOfAccount
            Get
                Return fForwardAccount
            End Get
            Set(ByVal value As ChartOfAccount)
                SetPropertyValue(Of ChartOfAccount)("ForwardAccount", fForwardAccount, value)
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
        Dim fCommissionAccount As ChartOfAccount
        Public Property CommissionAccount() As ChartOfAccount
            Get
                Return fCommissionAccount
            End Get
            Set(ByVal value As ChartOfAccount)
                SetPropertyValue(Of ChartOfAccount)("CommissionAccount", fCommissionAccount, value)
            End Set
        End Property
        Dim fContraCommissionAccount As ChartOfAccount
        Public Property ContraCommissionAccount() As ChartOfAccount
            Get
                Return fContraCommissionAccount
            End Get
            Set(ByVal value As ChartOfAccount)
                SetPropertyValue(Of ChartOfAccount)("ContraCommissionAccount", fContraCommissionAccount, value)
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
        Dim fBank As Banks
        Public Property Bank() As Banks
            Get
                Return fBank
            End Get
            Set(ByVal value As Banks)
                SetPropertyValue(Of Banks)("Bank", fBank, value)
            End Set
        End Property
        Dim fIsGenerateVoucher As Boolean
        Public Property IsGenerateVoucher() As Boolean
            Get
                Return fIsGenerateVoucher
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsGenerateVoucher", fIsGenerateVoucher, value)
            End Set
        End Property
        Dim fIsReceiveSecurity As Boolean
        Public Property IsReceiveSecurity() As Boolean
            Get
                Return fIsReceiveSecurity
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsReceiveSecurity", fIsReceiveSecurity, value)
            End Set
        End Property
        Dim fIsPaySecurity As Boolean
        Public Property IsPaySecurity() As Boolean
            Get
                Return fIsPaySecurity
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsPaySecurity", fIsPaySecurity, value)
            End Set
        End Property
        Dim fIsCanBeCollected As Boolean
        Public Property IsCanBeCollected() As Boolean
            Get
                Return fIsCanBeCollected
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsCanBeCollected", fIsCanBeCollected, value)
            End Set
        End Property
        Dim fIsCanBeEndorsed As Boolean
        Public Property IsCanBeEndorsed() As Boolean
            Get
                Return fIsCanBeEndorsed
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsCanBeEndorsed", fIsCanBeEndorsed, value)
            End Set
        End Property
        Dim fIsCanReturnToOrigin As Boolean
        Public Property IsCanReturnToOrigin() As Boolean
            Get
                Return fIsCanReturnToOrigin
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsCanReturnToOrigin", fIsCanReturnToOrigin, value)
            End Set
        End Property
        Dim fIsDirectCollection As Boolean
        Public Property IsDirectCollection() As Boolean
            Get
                Return fIsDirectCollection
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("IsDirectCollection", fIsDirectCollection, value)
            End Set
        End Property
        Dim fSecurityVoucher As VoucherTypes
        Public Property SecurityVoucher() As VoucherTypes
            Get
                Return fSecurityVoucher
            End Get
            Set(ByVal value As VoucherTypes)
                SetPropertyValue(Of VoucherTypes)("SecurityVoucher", fSecurityVoucher, value)
            End Set
        End Property
        Dim fReceiptVoucher As VoucherTypes
        Public Property ReceiptVoucher() As VoucherTypes
            Get
                Return fReceiptVoucher
            End Get
            Set(ByVal value As VoucherTypes)
                SetPropertyValue(Of VoucherTypes)("ReceiptVoucher", fReceiptVoucher, value)
            End Set
        End Property
        Dim fPayVoucher As VoucherTypes
        Public Property PayVoucher() As VoucherTypes
            Get
                Return fPayVoucher
            End Get
            Set(ByVal value As VoucherTypes)
                SetPropertyValue(Of VoucherTypes)("PayVoucher", fPayVoucher, value)
            End Set
        End Property
        Dim fUnderCollectionVoucher As VoucherTypes
        Public Property UnderCollectionVoucher() As VoucherTypes
            Get
                Return fUnderCollectionVoucher
            End Get
            Set(ByVal value As VoucherTypes)
                SetPropertyValue(Of VoucherTypes)("UnderCollectionVoucher", fUnderCollectionVoucher, value)
            End Set
        End Property
        Dim fEndorsedVoucher As VoucherTypes
        Public Property EndorsedVoucher() As VoucherTypes
            Get
                Return fEndorsedVoucher
            End Get
            Set(ByVal value As VoucherTypes)
                SetPropertyValue(Of VoucherTypes)("EndorsedVoucher", fEndorsedVoucher, value)
            End Set
        End Property
        Dim fForwardVoucher As VoucherTypes
        Public Property ForwardVoucher() As VoucherTypes
            Get
                Return fForwardVoucher
            End Get
            Set(ByVal value As VoucherTypes)
                SetPropertyValue(Of VoucherTypes)("ForwardVoucher", fForwardVoucher, value)
            End Set
        End Property
    End Class

End Namespace
