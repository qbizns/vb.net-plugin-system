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
Namespace Salling.HOTELS.ORM

    <DeferredDeletion(True)> _
    Partial Public Class ExtraCharges
        Inherits XPObject
        Dim fName As String
        Public Property Name() As String
            Get
                Return fName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Name", fName, value)
            End Set
        End Property
        Dim fDescription As String
        Public Property Description() As String
            Get
                Return fDescription
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Description", fDescription, value)
            End Set
        End Property
        Dim fCategory As ExtraChargeCategories
        Public Property Category() As ExtraChargeCategories
            Get
                Return fCategory
            End Get
            Set(ByVal value As ExtraChargeCategories)
                SetPropertyValue(Of ExtraChargeCategories)("Category", fCategory, value)
            End Set
        End Property
        Dim fChargeType As String
        Public Property ChargeType() As String
            Get
                Return fChargeType
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ChargeType", fChargeType, value)
            End Set
        End Property
        Dim fRate As Double
        Public Property Rate() As Double
            Get
                Return fRate
            End Get
            Set(ByVal value As Double)
                SetPropertyValue(Of Double)("Rate", fRate, value)
            End Set
        End Property
        Dim fPostType As String
        Public Property PostType() As String
            Get
                Return fPostType
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PostType", fPostType, value)
            End Set
        End Property
        Dim fQtyType As String
        Public Property QtyType() As String
            Get
                Return fQtyType
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("QtyType", fQtyType, value)
            End Set
        End Property
        Dim fVoucherNoGenerate As Boolean
        Public Property VoucherNoGenerate() As Boolean
            Get
                Return fVoucherNoGenerate
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("VoucherNoGenerate", fVoucherNoGenerate, value)
            End Set
        End Property
        Dim fVoucherNoType As String
        Public Property VoucherNoType() As String
            Get
                Return fVoucherNoType
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("VoucherNoType", fVoucherNoType, value)
            End Set
        End Property
        Dim fGiveNotification As Boolean
        Public Property GiveNotification() As Boolean
            Get
                Return fGiveNotification
            End Get
            Set(ByVal value As Boolean)
                SetPropertyValue(Of Boolean)("GiveNotification", fGiveNotification, value)
            End Set
        End Property
        Dim fPrefix As String
        Public Property Prefix() As String
            Get
                Return fPrefix
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Prefix", fPrefix, value)
            End Set
        End Property
        Dim fStartFrom As Integer
        Public Property StartFrom() As Integer
            Get
                Return fStartFrom
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("StartFrom", fStartFrom, value)
            End Set
        End Property
        Dim fPrefixSetting As String
        Public Property PrefixSetting() As String
            Get
                Return fPrefixSetting
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PrefixSetting", fPrefixSetting, value)
            End Set
        End Property
    End Class

End Namespace