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
    Partial Public Class Roles
        Inherits XPObject
        Dim fRoleName As String
        Public Property RoleName() As String
            Get
                Return fRoleName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("RoleName", fRoleName, value)
            End Set
        End Property
        Dim fDescriptions As String
        Public Property Descriptions() As String
            Get
                Return fDescriptions
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Descriptions", fDescriptions, value)
            End Set
        End Property
        <Association("UserRolesReferencesRoles", GetType(UserRoles)), Aggregated()> _
        Public ReadOnly Property RolesUserCollection() As XPCollection(Of UserRoles)
            Get
                Return GetCollection(Of UserRoles)("RolesUserCollection")
            End Get
        End Property
        <Association("RoleTaskPermessionsReferencesRoles", GetType(RoleTaskPermessions)), Aggregated()> _
        Public ReadOnly Property RolesRoleTaskPermessionsCollection() As XPCollection(Of RoleTaskPermessions)
            Get
                Return GetCollection(Of RoleTaskPermessions)("RolesRoleTaskPermessionsCollection")
            End Get
        End Property
    End Class

End Namespace
