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
Namespace Salling.HOTELS.ORM

    <DeferredDeletion(True)> _
    Partial Public Class FollowUpTypes
        Inherits XPObject
        Dim fType As String
        Public Property Type() As String
            Get
                Return fType
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Type", fType, value)
            End Set
        End Property
        Dim fColor As String
        Public Property Color() As String
            Get
                Return fColor
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Color", fColor, value)
            End Set
        End Property
    End Class

End Namespace
