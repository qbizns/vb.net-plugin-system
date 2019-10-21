Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Net

Namespace Salling.Security
    Public Class Users
        Public Shared uow As New UnitOfWork
        Public Shared CurrentUser As Salling.BASE.ORM.SystemUsers
        Public Shared CurrentUserSession As Salling.BASE.ORM.Sessions
        Public Shared IsAuthenticated As Boolean = False

        Public Shared Function GetCurrentUser() As Salling.BASE.ORM.SystemUsers
            Return CurrentUser
        End Function

        Public Shared Function AuthonicateUser(ByVal Username As String, ByVal Password As String) As Salling.BASE.ORM.SystemUsers
            CurrentUser = uow.FindObject(Of Salling.BASE.ORM.SystemUsers)(CriteriaOperator.Parse("Username == '" + Username + "' AND Password == '" + Password + "'"))
            If CurrentUser Is Nothing Then
                Return Nothing
            Else
                IsAuthenticated = True
                RecordSession()
                Return CurrentUser
            End If
        End Function

        Public Shared Sub RecordSession()
            CurrentUser.IsOnline = True

            CurrentUserSession = New Salling.BASE.ORM.Sessions(uow)
            CurrentUserSession.SessionBegainDatetime = Date.Now
            CurrentUserSession.SessionEndDatetime = Nothing
            CurrentUserSession.User = CurrentUser
            CurrentUserSession.IPAddress = System.Net.Dns.GetHostEntry(System.Net.Dns.GetHostName().ToString()).AddressList(1).ToString()

            uow.CommitChanges()
        End Sub

        Public Shared Sub MakeUserOffline()
            CurrentUser.IsOnline = False
            CurrentUserSession.SessionEndDatetime = Date.Now
            uow.CommitChanges()
        End Sub

        Public Shared Function Can(ByVal Action As String) As Boolean
            'Dim name As String = System.Reflection.Assembly.GetEntryAssembly().GetName().Name
            Dim assmname As String = System.Reflection.Assembly.GetCallingAssembly().GetName().Name ' The DLL Name
            Dim stackFrame As New Diagnostics.StackFrame(1) ' The Form Name
            MsgBox(assmname & " ---- " & stackFrame.GetMethod.DeclaringType.Name.ToString)

            'Dim urole As Template.BASE.ORM.UserRoles = uow.FindObject(Of Template.BASE.ORM.UserRoles)(CriteriaOperator.Parse(String.Format("User == {0}", CurrentUser.Oid)))
            'For Each Role In urole.Role.RolesRoleTaskPermessionsCollection
            '    If Action = Role.TaskPermission.Task.Code & "_" & Role.TaskPermission.Permission.Code Then
            '        Return True
            '    Else
            '        Return False
            '    End If
            'Next Role
            Return False
        End Function

    End Class
End Namespace