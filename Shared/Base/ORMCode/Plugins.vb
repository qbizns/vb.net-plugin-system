Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    Partial Public Class Plugins
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub

        Public Shared Function CreatePlugin(ByVal uow As UnitOfWork, ByVal GUID As Guid, ByVal PluginName As String, ByVal Description As String) As Plugins
            Dim Plugin As Plugins = uow.FindObject(Of Plugins)(CriteriaOperator.Parse(String.Format("PluginName == '{0}'", PluginName)))
            If Plugin Is Nothing Then
                Plugin = New Plugins(uow)
                Plugin.GUID = GUID
                Plugin.PluginName = PluginName
                Plugin.Description = Description
                Plugin.IsEnabled = True
                Plugin.Save()
                uow.CommitChanges()
            End If
            Return Plugin
        End Function

    End Class

End Namespace
