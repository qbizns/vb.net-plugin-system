'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated by a tool.
'
'     Changes to this file may cause incorrect behavior and will be lost if
'     the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------
Imports System
Imports DevExpress.Xpo
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports System.ComponentModel
Namespace Salling.BASE.ORM

    <DeferredDeletion(True)> _
    Partial Public Class BusinessProcesses
        Inherits XPObject
        Dim fDocumentType As DocumentTypes
        Public Property DocumentType() As DocumentTypes
            Get
                Return fDocumentType
            End Get
            Set(ByVal value As DocumentTypes)
                SetPropertyValue(Of DocumentTypes)("DocumentType", fDocumentType, value)
            End Set
        End Property
        Dim fProcessName As String
        Public Property ProcessName() As String
            Get
                Return fProcessName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ProcessName", fProcessName, value)
            End Set
        End Property
        Dim fProcessDescription As String
        <Size(SizeAttribute.Unlimited)> _
        Public Property ProcessDescription() As String
            Get
                Return fProcessDescription
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("ProcessDescription", fProcessDescription, value)
            End Set
        End Property
    End Class

End Namespace