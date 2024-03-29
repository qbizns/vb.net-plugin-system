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
    Partial Public Class Sessions
        Inherits XPObject
        Dim fSessionBegainDatetime As DateTime
        <ValueConverter(GetType(DevExpress.Xpo.Metadata.UtcDateTimeConverter))> _
        Public Property SessionBegainDatetime() As DateTime
            Get
                Return fSessionBegainDatetime
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("SessionBegainDatetime", fSessionBegainDatetime, value)
            End Set
        End Property
        Dim fSessionEndDatetime As DateTime
        <ValueConverter(GetType(DevExpress.Xpo.Metadata.UtcDateTimeConverter))> _
        Public Property SessionEndDatetime() As DateTime
            Get
                Return fSessionEndDatetime
            End Get
            Set(ByVal value As DateTime)
                SetPropertyValue(Of DateTime)("SessionEndDatetime", fSessionEndDatetime, value)
            End Set
        End Property
        Dim fUser As SystemUsers
        <Association("SessionsReferencesSystemUsers")> _
        Public Property User() As SystemUsers
            Get
                Return fUser
            End Get
            Set(ByVal value As SystemUsers)
                SetPropertyValue(Of SystemUsers)("User", fUser, value)
            End Set
        End Property
        Dim fIPAddress As String
        Public Property IPAddress() As String
            Get
                Return fIPAddress
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("IPAddress", fIPAddress, value)
            End Set
        End Property
    End Class

End Namespace
