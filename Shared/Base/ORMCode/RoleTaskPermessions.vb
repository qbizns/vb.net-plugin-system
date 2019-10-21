Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    Partial Public Class RoleTaskPermessions
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub

        Public Shared Function CreateRoleTaskPermession(ByVal uow As UnitOfWork, ByVal Role As Roles, ByVal TaskPermission As TaskPermissions) As RoleTaskPermessions
            Dim RoleTaskPermession As RoleTaskPermessions = uow.FindObject(Of RoleTaskPermessions)(CriteriaOperator.Parse(String.Format("Role == {0} AND TaskPermission == {1}", Role.Oid, TaskPermission.Oid)))
            If RoleTaskPermession Is Nothing Then
                RoleTaskPermession = New RoleTaskPermessions(uow)
                RoleTaskPermession.Role = Role
                RoleTaskPermession.TaskPermission = TaskPermission
                RoleTaskPermession.Save()
                uow.CommitChanges()
            End If
            Return RoleTaskPermession
        End Function

    End Class

End Namespace
