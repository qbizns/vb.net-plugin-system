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

    Partial Public Class Stations
        Inherits XPObject
        Dim fName As String
        Public Property Name() As String
            Get
                Return fName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Name", fName, value)
            End Set
        End Property
        Dim fModel As Models
        Public Property Model() As Models
            Get
                Return fModel
            End Get
            Set(ByVal value As Models)
                SetPropertyValue(Of Models)("Model", fModel, value)
            End Set
        End Property
    End Class

End Namespace