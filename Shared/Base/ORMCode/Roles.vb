Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    Partial Public Class Roles
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub

        Public Shared Function CreateRoles(ByVal uow As UnitOfWork, ByVal RoleName As String) As Roles
            Dim Roles As Roles = uow.FindObject(Of Roles)(CriteriaOperator.Parse(String.Format("RoleName == '{0}'", RoleName)))
            If Roles Is Nothing Then
                Roles = New Roles(uow)
                Roles.RoleName = RoleName
                Roles.Save()
                uow.CommitChanges()
            End If
            Return Roles
        End Function

    End Class

End Namespace
