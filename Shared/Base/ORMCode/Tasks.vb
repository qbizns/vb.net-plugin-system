Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    Partial Public Class Tasks
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub

        Public Shared Function CreatePluginTask(ByVal uow As UnitOfWork, ByVal plugin As Plugins, ByVal Scope As String, ByVal Target As String, ByVal Code As String, ByVal TaskName As String) As Tasks
            Dim Taskcode As String = String.Format("{0}_{1}", plugin.PluginName, Code)
            Dim Task As Tasks = uow.FindObject(Of Tasks)(CriteriaOperator.Parse(String.Format("Code == '{0}'", Taskcode)))
            If Task Is Nothing Then
                Task = New Tasks(uow)
                Task.Plugin = plugin
                Task.Scope = Scope
                Task.Target = Target
                Task.Code = Taskcode
                Task.TaskName = TaskName
                Task.Save()
                uow.CommitChanges()
            End If
            Return Task
        End Function


    End Class

End Namespace
