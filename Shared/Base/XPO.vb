Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.Xpo.Metadata
Imports DevExpress.Data.Filtering
Imports System.Threading
Imports System.Reflection
Imports System.ComponentModel

Namespace Salling.BASE
    Public NotInheritable Class XPO

        Private Shared lockObject As New Object()

        Private Shared _uow As UnitOfWork
        <Browsable(False)> _
        Public Shared Property uow() As UnitOfWork
            Get
                Return _uow
            End Get
            Set(ByVal value As UnitOfWork)
                _uow = value
                _uow.TrackPropertiesModifications = False
            End Set
        End Property


        Private Shared fDataLayer As IDataLayer
        Private Shared ReadOnly Property DataLayer() As IDataLayer
            Get
                If fDataLayer Is Nothing Then
                    SyncLock lockObject
                        If Thread.VolatileRead(fDataLayer) Is Nothing Then
                            Thread.VolatileWrite(fDataLayer, GetDataLayer())
                        End If
                    End SyncLock
                End If
                Return fDataLayer
            End Get
        End Property

        Public Shared Function GetNewSession() As Session
            Return New Session(DataLayer)
        End Function

        Public Shared Function GetNewUnitOfWork() As UnitOfWork
            Return New UnitOfWork(DataLayer)
        End Function

        Public Shared Function GetDataLayer() As ThreadSafeDataLayer
            XpoDefault.UseFastAccessors = False
            XpoDefault.IdentityMapBehavior = IdentityMapBehavior.Strong

            XpoDefault.Session = Nothing

            ' MSACCESS Provider
            Dim conn As String = AccessConnectionProvider.GetConnectionString("Salling.mdb", "admin", "")
            'Dim conn As String = SQLiteConnectionProvider.GetConnectionString("Salling.db")
            ' MYSQL Provider
            'Dim conn As String = MySqlConnectionProvider.GetConnectionString("localhost", "root", "", "Salling")
            ' MSSQL Provider
            'Dim conn As String = MSSqlConnectionProvider.GetConnectionString("(local)", "Salling")
            XpoDefault.DataLayer = XpoDefault.GetDataLayer(conn, AutoCreateOption.DatabaseAndSchema)
            XpoDefault.Dictionary = XpoDefault.GetDictionary()

            Dim DataAssemblies As New List(Of Reflection.Assembly)
            DataAssemblies.Add(GetType(Salling.BASE.ORM.SystemUsers).Assembly)

            Dim ds As IDataStore = XpoDefault.GetConnectionProvider(conn, AutoCreateOption.DatabaseAndSchema, Nothing)

            Using sdl As New SimpleDataLayer(ds)
                Using uow As New UnitOfWork(sdl)
                    uow.CreateObjectTypeRecords(DataAssemblies.ToArray)
                    uow.UpdateSchema(DataAssemblies.ToArray)
                End Using
            End Using

            Dim AssDict As New Metadata.ReflectionDictionary()
            AssDict.CollectClassInfos(DataAssemblies.ToArray)
            Dim tsdl As New ThreadSafeDataLayer(AssDict, ds)
            uow = New UnitOfWork(tsdl)
            Return tsdl
        End Function

        Public Shared Function GetXPDataView(query As String) As DevExpress.Xpo.XPDataView
            Dim dv As New XPDataView()
            Dim data As SelectedData = GetNewSession.ExecuteQueryWithMetadata(query)
            For Each row As SelectStatementResultRow In data.ResultSet(0).Rows
                dv.AddProperty(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dv.LoadData(New SelectedData(data.ResultSet(1)))
            Return dv
        End Function

        Public Shared Function GetXpcollection(table As String, unitofwork As UnitOfWork) As XPCollection
            Dim parts As String() = table.Split(New String() {"."}, StringSplitOptions.None)
            Dim _namespace As String = String.Format("{0}.{1}.{2}", parts(0), parts(1), parts(2))
            For Each asm As Assembly In AppDomain.CurrentDomain.GetAssemblies()
                For Each typelist In asm.GetTypes().Where(Function(t) t.IsClass AndAlso t.[Namespace] IsNot Nothing AndAlso t.[Namespace].Contains(_namespace))
                    If (typelist.Name = parts(3)) Then
                        Return New XPCollection(unitofwork, typelist)
                    End If
                Next
            Next
            Return New XPCollection
        End Function

        Public Shared Function GetObject(objName As String) As Type
            Dim parts As String() = objName.Split(New String() {"."}, StringSplitOptions.None)
            Dim _namespace As String = String.Format("{0}.{1}.{2}", parts(0), parts(1), parts(2))
            For Each asm As Assembly In AppDomain.CurrentDomain.GetAssemblies()
                For Each typelist In asm.GetTypes().Where(Function(t) t.IsClass AndAlso t.[Namespace] IsNot Nothing AndAlso t.[Namespace].Contains(_namespace))
                    If (typelist.Name = parts(3)) Then
                        Return typelist
                    End If
                Next
            Next
            Return Nothing
        End Function

        Public Shared Function ReturnEnum(enumTxt As String) As Array
            Return Type.GetType(enumTxt).GetEnumValues
        End Function

        Public Shared Function GetActiveConnectionString() As String
            Return XpoDefault.DataLayer.Connection.ConnectionString
        End Function

    End Class
End Namespace
