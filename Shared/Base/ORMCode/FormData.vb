Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    Partial Public Class FormData
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub

        Public Shared Function CreateFormData(ByVal uow As UnitOfWork, ByVal FormName As String, Optional ByVal Language As String = "en_US", _
                                              Optional ByVal LayoutData As String = Nothing, Optional ByVal Configurations As String = Nothing) As FormData
            Dim FormData As FormData = uow.FindObject(Of FormData)(CriteriaOperator.Parse(String.Format("FormName == '{0}'", FormName)))
            If FormData Is Nothing Then
                FormData = New FormData(uow)
                FormData.FormName = FormName
                FormData.Language = Language
                FormData.LayoutData = LayoutData
                FormData.Configurations = Configurations
                FormData.Save()
                uow.CommitChanges()
            Else
                FormData.FormName = FormName
                FormData.Language = Language
                FormData.LayoutData = LayoutData
                FormData.Configurations = Configurations
                FormData.Save()
                uow.CommitChanges()
            End If
            Return FormData
        End Function

        Public Shared Function GetFormData(ByVal uow As UnitOfWork, ByVal FormName As String, ByVal Language As String) As FormData
            Dim FormData As FormData = uow.FindObject(Of FormData)(CriteriaOperator.Parse(String.Format("FormName == '{0}' AND Language == '{1}'", FormName, Language)))
            If FormData Is Nothing Then
                Return Nothing
            Else
                Return FormData
            End If
        End Function

    End Class

End Namespace
