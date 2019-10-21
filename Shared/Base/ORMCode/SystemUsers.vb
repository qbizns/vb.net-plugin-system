Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    Partial Public Class SystemUsers
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()

            'FechaDocumento = New DateTime(Now.Year, Now.Month, Now.Day, 0, 0, 0, 0)
        End Sub

        Public Shared Function CreateAdminUser(ByVal uow As UnitOfWork, _
                                               ByVal FullName As String, _
                                               ByVal Description As String, _
                                               ByVal Username As String, _
                                               ByVal Password As String, _
                                               ByVal IsAdmin As Boolean, _
                                               ByVal IsActive As Boolean, _
                                               ByVal ChangePasswordAfterLogon As Boolean) As SystemUsers
            Dim admin As SystemUsers = uow.FindObject(Of SystemUsers)(CriteriaOperator.Parse(String.Format("Username == '{0}'", Username)))
            If admin Is Nothing Then
                admin = New SystemUsers(uow)
                admin.FullName = FullName
                admin.Descriptions = Description
                admin.Username = Username
                admin.Password = Password
                admin.IsAdmin = IsAdmin
                admin.IsActive = IsActive
                admin.IsOnline = False
                admin.ChangePasswordAfterLogon = ChangePasswordAfterLogon
                admin.Save()
                uow.CommitChanges()
            End If
            Return admin
        End Function
    End Class

End Namespace
