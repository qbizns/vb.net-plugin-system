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
    Partial Public Class ChartOfAccount
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
        Dim fAccountClass As String
        Public Property AccountClass() As String
            Get
                Return fAccountClass
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("AccountClass", fAccountClass, value)
            End Set
        End Property
        Dim fAccountType As String
        Public Property AccountType() As String
            Get
                Return fAccountType
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("AccountType", fAccountType, value)
            End Set
        End Property
        Dim fParentAccount As ChartOfAccount
        Public Property ParentAccount() As ChartOfAccount
            Get
                Return fParentAccount
            End Get
            Set(ByVal value As ChartOfAccount)
                SetPropertyValue(Of ChartOfAccount)("ParentAccount", fParentAccount, value)
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
        Dim fMaxLimit As Decimal
        Public Property MaxLimit() As Decimal
            Get
                Return fMaxLimit
            End Get
            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("MaxLimit", fMaxLimit, value)
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
