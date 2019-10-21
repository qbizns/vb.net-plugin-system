Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Helpers
Imports DevExpress.Xpo.Metadata
Imports System.Collections.Generic
Imports System.Configuration
Imports System.Linq
Imports System

Namespace Salling.BASE

    Public NotInheritable Class XPOUtils
        Private Sub New()
        End Sub
        Shared ReadOnly xpoNames As New Dictionary(Of Boolean, String)() From { _
            {False, "XPOSession"}, _
            {True, "XPOUnitOfWork"} _
        }

        Public Shared Function GetNew(transactional As Boolean) As Session
            Return If(transactional, GetNewUnitOfWork(), GetNewSession())
        End Function

        Public Shared Function GetNewSession() As Session
            Return New Session(DataLayer)
        End Function

        Public Shared Function GetNewUnitOfWork() As UnitOfWork
            Return New UnitOfWork(DataLayer)
        End Function

        '' Cached versions specifically for Web requests
        'Public Shared Function GetSession(context As HttpContext) As Session
        '    Return GetSession(New HttpContextWrapper(context), False)
        'End Function
        'Public Shared Function GetSession(context As HttpContextBase) As Session
        '    Return GetSession(context, False)
        'End Function

        'Public Shared Function GetUnitOfWork(context As HttpContext) As UnitOfWork
        '    Return TryCast(GetSession(New HttpContextWrapper(context), True), UnitOfWork)
        'End Function

        'Public Shared Function GetUnitOfWork(context As HttpContextBase) As UnitOfWork
        '    Return TryCast(GetSession(context, True), UnitOfWork)
        'End Function

        'Public Shared Function GetSession(context As HttpContext, transactional As Boolean) As Session
        '    Return GetSession(New HttpContextWrapper(context), transactional)
        'End Function
        'Public Shared Function GetSession(context As HttpContextBase, transactional As Boolean) As Session
        '    If context IsNot Nothing Then
        '        If context.Items(xpoNames(transactional)) Is Nothing Then
        '            Dim s As Session = GetNew(transactional)
        '            AddHandler s.Disposed, AddressOf s_Disposed
        '            context.Items(xpoNames(transactional)) = s
        '        End If
        '        Return TryCast(context.Items(xpoNames(transactional)), Session)
        '    End If
        '    Return GetNew(transactional)
        'End Function

        'Private Shared Sub s_Disposed(sender As Object, e As EventArgs)
        '    Dim transactional As Boolean = TypeOf sender Is UnitOfWork

        '    If (HttpContext.Current IsNot Nothing) AndAlso (sender IsNot Nothing) AndAlso (DirectCast(HttpContext.Current.Items(xpoNames(transactional)), Session).Equals(DirectCast(sender, Session))) Then
        '        HttpContext.Current.Items(xpoNames(transactional)) = Nothing
        '    End If
        'End Sub

        Public Shared Sub Commit(obj As Object)
            If obj Is Nothing Then
                Return
            End If

            Dim wrk As UnitOfWork = TryCast(obj, UnitOfWork)
            If wrk IsNot Nothing Then
                wrk.CommitChanges()
            Else
                Dim dataObject As ISessionProvider = TryCast(obj, ISessionProvider)
                If dataObject IsNot Nothing Then
                    wrk = TryCast(dataObject.Session, UnitOfWork)
                    If wrk IsNot Nothing Then
                        wrk.CommitChanges()
                    End If
                    dataObject.Session.Save(dataObject)
                End If
            End If
        End Sub

        Public Shared Sub Rollback(obj As Object)
            If obj Is Nothing Then
                Return
            End If

            Dim wrk As UnitOfWork = TryCast(obj, UnitOfWork)
            If wrk IsNot Nothing Then
                wrk.RollbackTransaction()
            Else
                Dim dataObject As ISessionProvider = TryCast(obj, ISessionProvider)
                If dataObject IsNot Nothing Then
                    wrk = TryCast(dataObject.Session, UnitOfWork)
                    If wrk IsNot Nothing Then
                        wrk.RollbackTransaction()
                    End If
                End If
            End If
        End Sub

        Shared _XpoDataLayer As IDataLayer
        Public Shared ReadOnly Property DataLayer() As IDataLayer
            Get
                If _XpoDataLayer Is Nothing Then
                    SyncLock GetType(XPOUtils)
                        _XpoDataLayer = GetDataLayer()
                    End SyncLock
                End If
                Return _XpoDataLayer
            End Get
        End Property

        Private Shared Function GetDataLayer() As IDataLayer
            ' set XpoDefault.Session to null to prevent accidental use of XPO default session
            XpoDefault.Session = Nothing
            'ReflectionClassInfo.SuppressSuspiciousMemberInheritanceCheck = True
            ' Needed to run in Medium Trust Security Context
            XpoDefault.UseFastAccessors = False
            XpoDefault.IdentityMapBehavior = IdentityMapBehavior.Strong

            Dim conn As String = AccessConnectionProvider.GetConnectionString("Salling.mdb", "admin", "")
            'Dim conn As String = ConfigurationManager.ConnectionStrings("DefaultConnection").ConnectionString
            If [String].IsNullOrEmpty(conn) Then
                Throw New Exception("No ConnectionString 'DefaultConnection' is specified in the web.config")
            End If


            Dim dataDictionary As XPDictionary = New ReflectionDictionary()
            Dim dataStore As IDataStore = XpoDefault.GetConnectionProvider(conn, AutoCreateOption.DatabaseAndSchema)
            ' Initialize the XPO dictionary by going though all assemblies.
            dataDictionary.GetDataStoreSchema(AppDomain.CurrentDomain.GetAssemblies())
            ' make sure everything exists in the db
            Using dataLayer As New SimpleDataLayer(dataStore)
                Using session As New Session(dataLayer)
                    ' place code here to patch metadata
                    session.UpdateSchema()
                    session.CreateObjectTypeRecords()
                    'XpoDefault.DataLayer = new ThreadSafeDataLayer(session.Dictionary, new DataCacheNode(new DataCacheRoot(dataStore)));
                    XpoDefault.DataLayer = New ThreadSafeDataLayer(session.Dictionary, dataStore)
                End Using
            End Using
            Dim result As IDataLayer = New ThreadSafeDataLayer(dataDictionary, dataStore)

            Return result
        End Function
    End Class
End Namespace
