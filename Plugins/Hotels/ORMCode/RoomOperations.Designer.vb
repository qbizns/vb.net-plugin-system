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

    Partial Public Class RoomOperations
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
        Dim fRoomType As String
        Public Property RoomType() As String
            Get
                Return fRoomType
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("RoomType", fRoomType, value)
            End Set
        End Property
        Dim fFloor As String
        Public Property Floor() As String
            Get
                Return fFloor
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("Floor", fFloor, value)
            End Set
        End Property
        Dim fSortKey As Integer
        Public Property SortKey() As Integer
            Get
                Return fSortKey
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("SortKey", fSortKey, value)
            End Set
        End Property
        Dim fRoomOwner As RoomOwner
        Public Property RoomOwner() As RoomOwner
            Get
                Return fRoomOwner
            End Get
            Set(ByVal value As RoomOwner)
                SetPropertyValue(Of RoomOwner)("RoomOwner", fRoomOwner, value)
            End Set
        End Property
        Dim fPhoneExtention As String
        Public Property PhoneExtention() As String
            Get
                Return fPhoneExtention
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("PhoneExtention", fPhoneExtention, value)
            End Set
        End Property
        Dim fDataExtention As String
        Public Property DataExtention() As String
            Get
                Return fDataExtention
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("DataExtention", fDataExtention, value)
            End Set
        End Property
        Dim fRoomProperty As String
        Public Property RoomProperty() As String
            Get
                Return fRoomProperty
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("RoomProperty", fRoomProperty, value)
            End Set
        End Property
        Dim fSuiteName As String
        Public Property SuiteName() As String
            Get
                Return fSuiteName
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("SuiteName", fSuiteName, value)
            End Set
        End Property
        Dim fTop As Integer
        Public Property Top() As Integer
            Get
                Return fTop
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Top", fTop, value)
            End Set
        End Property
        Dim fHeight As Integer
        Public Property Height() As Integer
            Get
                Return fHeight
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Height", fHeight, value)
            End Set
        End Property
        Dim fLeft As Integer
        Public Property Left() As Integer
            Get
                Return fLeft
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Left", fLeft, value)
            End Set
        End Property
        Dim fWidth As Integer
        Public Property Width() As Integer
            Get
                Return fWidth
            End Get
            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Width", fWidth, value)
            End Set
        End Property
        Dim fHouseKeeping As String
        Public Property HouseKeeping() As String
            Get
                Return fHouseKeeping
            End Get
            Set(ByVal value As String)
                SetPropertyValue(Of String)("HouseKeeping", fHouseKeeping, value)
            End Set
        End Property
    End Class

End Namespace
