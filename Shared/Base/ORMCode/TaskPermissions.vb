Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    Partial Public Class TaskPermissions
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub

        Public Shared Function CreateTaskPermission(ByVal uow As UnitOfWork, ByVal Task As Tasks, ByVal Permission As Permissions) As TaskPermissions
            Dim TaskPermission As TaskPermissions = uow.FindObject(Of TaskPermissions)(CriteriaOperator.Parse(String.Format("Task == {0} AND Permission == {1}", Task.Oid, Permission.Oid)))
            If TaskPermission Is Nothing Then
                TaskPermission = New TaskPermissions(uow)
                TaskPermission.Task = Task
                TaskPermission.Permission = Permission
                TaskPermission.Save()
                uow.CommitChanges()

                'Using uow
                '    Dim getRecords As New XPCollection(Of Roles)(uow)
                '    For Each Role In getRecords
                '        ERP.BASE.ORM.RoleTaskPermessions.CreateRoleTaskPermession(uow, Role, TaskPermission)
                '    Next
                'End Using

            End If
            Return TaskPermission
        End Function

    End Class

End Namespace
