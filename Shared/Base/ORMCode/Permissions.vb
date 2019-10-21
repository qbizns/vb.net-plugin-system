Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    Partial Public Class Permissions
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub

        Public Shared Function CreatePermission(ByVal uow As UnitOfWork, ByVal Code As String, ByVal Description As String) As Permissions
            Dim Permission As Permissions = uow.FindObject(Of Permissions)(CriteriaOperator.Parse(String.Format("Code == '{0}'", Code)))
            If Permission Is Nothing Then
                Permission = New Permissions(uow)
                Permission.Code = Code
                Permission.Description = Description
                Permission.Save()
                uow.CommitChanges()
            End If
            Return Permission
        End Function

    End Class

End Namespace
