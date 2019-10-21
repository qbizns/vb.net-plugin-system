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
    Partial Public Class Currencies
        Inherits XPObject
        Dim fArCurrencyName As String
        Public Property ArCurrencyName() As String
            Get
                Return fArCurrencyName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ArCurrencyName", fArCurrencyName, value)
            End Set
        End Property
        Dim fEnCurrencyName As String
        Public Property EnCurrencyName() As String
            Get
                Return fEnCurrencyName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("EnCurrencyName", fEnCurrencyName, value)
            End Set
        End Property
        Dim fCountry_ As String
        Public Property Country_() As String
            Get
                Return fCountry_
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Country_", fCountry_, value)
            End Set
        End Property
        Dim fCurrencySingle As String
        Public Property CurrencySingle() As String
            Get
                Return fCurrencySingle
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("CurrencySingle", fCurrencySingle, value)
            End Set
        End Property
        Dim fCurrencyPlural As String
        Public Property CurrencyPlural() As String
            Get
                Return fCurrencyPlural
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("CurrencyPlural", fCurrencyPlural, value)
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
        Dim fFracsUnit As Integer
        Public Property FracsUnit() As Integer
            Get
                Return fFracsUnit
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("FracsUnit", fFracsUnit, value)
            End Set
        End Property
        Dim fCurrencyCode As String
        Public Property CurrencyCode() As String
            Get
                Return fCurrencyCode
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("CurrencyCode", fCurrencyCode, value)
            End Set
        End Property
        Dim fFractionSingle As String
        Public Property FractionSingle() As String
            Get
                Return fFractionSingle
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("FractionSingle", fFractionSingle, value)
            End Set
        End Property
        Dim fFractionPlural As String
        Public Property FractionPlural() As String
            Get
                Return fFractionPlural
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("FractionPlural", fFractionPlural, value)
            End Set
        End Property
        Dim fEquivalent As Integer
        Public Property Equivalent() As Integer
            Get
                Return fEquivalent
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Equivalent", fEquivalent, value)
            End Set
        End Property
        <Association("CurrencyUnitReferencesCurrencies", GetType(CurrencyUnit)), Aggregated()> _
        Public ReadOnly Property CurrencyUnits() As XPCollection(Of CurrencyUnit)
            Get
                Return GetCollection(Of CurrencyUnit)("CurrencyUnits")
            End Get
        End Property
    End Class

End Namespace