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

    Partial Public Class PropertyManagement
        Inherits XPObject
        Dim fPropertyName As String
        Public Property PropertyName() As String
            Get
                Return fPropertyName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PropertyName", fPropertyName, value)
            End Set
        End Property
        Dim fAddress As String
        Public Property Address() As String
            Get
                Return fAddress
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Address", fAddress, value)
            End Set
        End Property
        Dim fCity As String
        Public Property City() As String
            Get
                Return fCity
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("City", fCity, value)
            End Set
        End Property
        Dim fZip As String
        Public Property Zip() As String
            Get
                Return fZip
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Zip", fZip, value)
            End Set
        End Property
        Dim fState As String
        Public Property State() As String
            Get
                Return fState
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("State", fState, value)
            End Set
        End Property
        Dim fCountry As Countries
        Public Property Country() As Countries
            Get
                Return fCountry
            End Get
            Set(ByVal value As Countries)
                SetPropertyValue(Of Countries)("Country", fCountry, value)
            End Set
        End Property
        Dim fPhone As String
        Public Property Phone() As String
            Get
                Return fPhone
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Phone", fPhone, value)
            End Set
        End Property
        Dim fFax As String
        Public Property Fax() As String
            Get
                Return fFax
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Fax", fFax, value)
            End Set
        End Property
        Dim fRsrvPhone As String
        Public Property RsrvPhone() As String
            Get
                Return fRsrvPhone
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("RsrvPhone", fRsrvPhone, value)
            End Set
        End Property
        Dim fEmail As String
        Public Property Email() As String
            Get
                Return fEmail
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Email", fEmail, value)
            End Set
        End Property
        Dim fWebsite As String
        Public Property Website() As String
            Get
                Return fWebsite
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Website", fWebsite, value)
            End Set
        End Property
        Dim fPropertyType As String
        Public Property PropertyType() As String
            Get
                Return fPropertyType
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PropertyType", fPropertyType, value)
            End Set
        End Property
        Dim fPropertyGrade As String
        Public Property PropertyGrade() As String
            Get
                Return fPropertyGrade
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PropertyGrade", fPropertyGrade, value)
            End Set
        End Property
        Dim fRegistration As String
        Public Property Registration() As String
            Get
                Return fRegistration
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Registration", fRegistration, value)
            End Set
        End Property
        Dim fLogo As String
        Public Property Logo() As String
            Get
                Return fLogo
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Logo", fLogo, value)
            End Set
        End Property
    End Class

End Namespace