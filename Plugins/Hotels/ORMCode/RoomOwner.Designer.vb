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

    Partial Public Class RoomOwner
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
        Dim fState As String
        Public Property State() As String
            Get
                Return fState
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("State", fState, value)
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
        Dim fCountery As Countries
        Public Property Countery() As Countries
            Get
                Return fCountery
            End Get
            Set(ByVal value As Countries)
                SetPropertyValue(Of Countries)("Countery", fCountery, value)
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
        Dim fEmail As String
        Public Property Email() As String
            Get
                Return fEmail
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Email", fEmail, value)
            End Set
        End Property
        Dim fPlan As String
        Public Property Plan() As String
            Get
                Return fPlan
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Plan", fPlan, value)
            End Set
        End Property
        Dim fValue As String
        Public Property Value() As String
            Get
                Return fValue
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Value", fValue, value)
            End Set
        End Property
    End Class

End Namespace
