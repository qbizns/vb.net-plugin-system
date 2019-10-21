Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    Partial Public Class GridLayouts
        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub
        Public Overrides Sub AfterConstruction()
            MyBase.AfterConstruction()
        End Sub

        Public Shared Function CreateGridLayout(ByVal uow As UnitOfWork, ByVal FormName As String, ByVal GridName As String, Optional ByVal Language As String = "en_US", _
                                      Optional ByVal LayoutData As String = Nothing) As GridLayouts
            Dim GridLayout As GridLayouts = uow.FindObject(Of GridLayouts)(CriteriaOperator.Parse(String.Format("FormName == '{0}' AND GridName == '{1}' AND Language == '{2}'", FormName, GridName, Language)))
            If GridLayout Is Nothing Then
                GridLayout = New GridLayouts(uow)
                GridLayout.FormName = FormName
                GridLayout.GridName = GridName
                GridLayout.Language = Language
                GridLayout.LayoutData = LayoutData
                GridLayout.Save()
                uow.CommitChanges()
            Else
                GridLayout.FormName = FormName
                GridLayout.GridName = GridName
                GridLayout.Language = Language
                GridLayout.LayoutData = LayoutData
                GridLayout.Save()
                uow.CommitChanges()
            End If
            Return GridLayout
        End Function

        Public Shared Function GetGridLayout(ByVal uow As UnitOfWork, ByVal FormName As String, ByVal GridName As String, ByVal Language As String) As GridLayouts
            Dim GridLayout As GridLayouts = uow.FindObject(Of GridLayouts)(CriteriaOperator.Parse(String.Format("FormName == '{0}' AND GridName == '{1}' AND Language == '{2}'", FormName, GridName, Language)))
            If GridLayout Is Nothing Then
                Return Nothing
            Else
                Return GridLayout
            End If
        End Function

    End Class

End Namespace
