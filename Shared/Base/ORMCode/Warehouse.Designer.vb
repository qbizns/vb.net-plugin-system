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
    Partial Public Class Warehouse
        Inherits XPObject
        Dim fCode As String
        Public Property Code() As String
            Get
                Return fCode
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Code", fCode, value)
            End Set
        End Property
        Dim fArName As String
        Public Property ArName() As String
            Get
                Return fArName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ArName", fArName, value)
            End Set
        End Property
        Dim fEnName As String
        Public Property EnName() As String
            Get
                Return fEnName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("EnName", fEnName, value)
            End Set
        End Property
        Dim fParentWarehouse As Warehouse
        Public Property ParentWarehouse() As Warehouse
            Get
                Return fParentWarehouse
            End Get
            Set(ByVal value As Warehouse)
                SetPropertyValue(Of Warehouse)("ParentWarehouse", fParentWarehouse, value)
            End Set
        End Property
        Dim fAddress As String
        <Size(SizeAttribute.Unlimited)> _
        Public Property Address() As String
            Get
                Return fAddress
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Address", fAddress, value)
            End Set
        End Property
        Dim fMobile As String
        Public Property Mobile() As String
            Get
                Return fMobile
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Mobile", fMobile, value)
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
        Dim fManInCharge As String
        Public Property ManInCharge() As String
            Get
                Return fManInCharge
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ManInCharge", fManInCharge, value)
            End Set
        End Property
        Dim fCloseAccount As ChartOfAccount
        Public Property CloseAccount() As ChartOfAccount
            Get
                Return fCloseAccount
            End Get
            Set(ByVal value As ChartOfAccount)
                SetPropertyValue(Of ChartOfAccount)("CloseAccount", fCloseAccount, value)
            End Set
        End Property
        Dim fNotes As String
        Public Property Notes() As String
            Get
                Return fNotes
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Notes", fNotes, value)
            End Set
        End Property
    End Class

End Namespace
