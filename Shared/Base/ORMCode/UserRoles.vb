Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    Partial Public Class UserRoles
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub

        Public Shared Function CreateUserRole(ByVal uow As UnitOfWork, ByVal Role As Roles, ByVal User As SystemUsers) As UserRoles
            Dim UserRole As UserRoles = uow.FindObject(Of UserRoles)(CriteriaOperator.Parse(String.Format("Role == {0} AND User == {1}", Role.Oid, User.Oid)))
            If UserRole Is Nothing Then
                UserRole = New UserRoles(uow)
                UserRole.Role = Role
                UserRole.User = User
                UserRole.Save()
                uow.CommitChanges()
            End If
            Return UserRole
        End Function

    End Class

End Namespace
