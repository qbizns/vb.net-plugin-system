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
    Partial Public Class RoleTaskPermessions
        Inherits XPObject
        Dim fRole As Roles
        <Association("RoleTaskPermessionsReferencesRoles")> _
        Public Property Role() As Roles
            Get
                Return fRole
            End Get
            Set(ByVal value As Roles)
                SetPropertyValue(Of Roles)("Role", fRole, value)
            End Set
        End Property
        Dim fTaskPermission As TaskPermissions
        <Association("RoleTaskPermessionsReferencesTaskPermissions")> _
        Public Property TaskPermission() As TaskPermissions
            Get
                Return fTaskPermission
            End Get
            Set(ByVal value As TaskPermissions)
                SetPropertyValue(Of TaskPermissions)("TaskPermission", fTaskPermission, value)
            End Set
        End Property
    End Class

End Namespace
