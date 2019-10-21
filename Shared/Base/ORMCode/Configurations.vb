Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    Partial Public Class Configurations
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub

        Public Shared Function CreateConfigurations(ByVal uow As UnitOfWork, _
                                                   ByVal Scope As String, _
                                                   ByVal _Configuration As String) As Configurations
            Dim Configuration As Configurations = uow.FindObject(Of Configurations)(CriteriaOperator.Parse(String.Format("Scope == '{0}'", Scope)))
            If Configuration Is Nothing Then
                Configuration = New Configurations(uow)
                Configuration.Scope = Scope
                Configuration.Configuration = _Configuration
                Configuration.Save()
                uow.CommitChanges()
            End If
            Return Configuration
        End Function

        Public Shared Function UpdateConfigurations(ByVal uow As UnitOfWork, _
                                                    ByVal Scope As String, _
                                                    ByVal _Configuration As String) As Configurations
            Dim Configuration As Configurations = uow.FindObject(Of Configurations)(CriteriaOperator.Parse(String.Format("Scope == '{0}'", Scope)))
            If Configuration IsNot Nothing Then
                Configuration.Configuration = _Configuration
                Configuration.Save()
                uow.CommitChanges()
            End If
            Return Configuration
        End Function

        Public Shared Function GetConfigurationByScope(ByVal uow As UnitOfWork, _
                                                       ByVal Scope As String) As Configurations
            Dim Configuration As Configurations = uow.FindObject(Of Configurations)(CriteriaOperator.Parse(String.Format("Scope == '{0}'", Scope)))
            If Configuration Is Nothing Then
                Return Nothing
            Else
                Return Configuration
            End If
        End Function

        Public Shared Function _config(ByVal Scope As String, ByVal config As String) As Object
            Dim uow As New UnitOfWork
            Dim Configuration As Configurations = uow.FindObject(Of Configurations)(CriteriaOperator.Parse(String.Format("Scope == '{0}'", Scope)))
            If Configuration Is Nothing Then
                Return Nothing
            Else
                Dim doc As New System.Xml.XmlDocument
                doc.LoadXml(Configuration.Configuration)
                Dim items = doc.GetElementsByTagName(config)

                For Each item As System.Xml.XmlElement In Items
                    Return item.InnerText
                Next
            End If
            Return Nothing
        End Function
    End Class

End Namespace
