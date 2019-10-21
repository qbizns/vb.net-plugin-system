Imports System.Collections.Generic
Imports System.Linq
Imports System.Text

Namespace Salling.Core
    ''' <summary>
    ''' This attribute use for define slots of any plug-ins
    ''' </summary>
    <AttributeUsage(AttributeTargets.[Class], Inherited:=False, AllowMultiple:=False)> _
    Public NotInheritable Class SlotAttribute
        Inherits Attribute
        Public Sub New(SlotName As String)
            Me.SlotName = SlotName
        End Sub

        Public Property SlotName() As String
            Get
                Return m_SlotName
            End Get
            Set(value As String)
                m_SlotName = Value
            End Set
        End Property
        Private m_SlotName As String

        Public Shared Function FromPlugin(plugin As IPlugin) As SlotAttribute
            Dim attributes As Object() = plugin.[GetType]().GetCustomAttributes(GetType(SlotAttribute), False)
            If attributes.Length > 0 Then
                Return TryCast(attributes(0), SlotAttribute)
            End If
            Return Nothing
        End Function
    End Class
    ''' <summary>
    ''' This attribute use for define exts of any plug-ins
    ''' </summary>
    <AttributeUsage(AttributeTargets.[Class], Inherited:=False, AllowMultiple:=True)> _
    Public NotInheritable Class ExtentionAttribute
        Inherits Attribute
        Public Sub New(ExtentionName As String)
            Me.ExtentionName = ExtentionName
        End Sub

        Public Property ExtentionName() As String
            Get
                Return m_ExtentionName
            End Get
            Set(value As String)
                m_ExtentionName = Value
            End Set
        End Property
        Private m_ExtentionName As String


        Public Shared Function FromPlugin(plugin As IPlugin) As List(Of ExtentionAttribute)
            Dim Result As New List(Of ExtentionAttribute)()
            Dim attributes As Object() = plugin.[GetType]().GetCustomAttributes(GetType(ExtentionAttribute), False)
            If attributes.Length > 0 Then
                For Each attribute As Object In attributes
                    Result.Add(DirectCast(attribute, ExtentionAttribute))
                Next
            End If
            Return Result
        End Function
    End Class
    ''' <summary>
    ''' This attribute can be used for set any plug-in info into that plug-in
    ''' </summary>
    <AttributeUsage(AttributeTargets.[Class], Inherited:=True, AllowMultiple:=False)> _
    Public NotInheritable Class PluginInfoAttribute
        Inherits Attribute

        Public Sub New(Title As String, Descreption As String, Author As String, Company As String, DateCreated As String, Version As String)
            _title = Title
            _descreption = Descreption
            _author = Author
            _company = Company
            _dateCreated = DateTime.Parse(DateCreated)
            _version = New Version(Version)
        End Sub

        Private _version As Version = Nothing

        Private _title As String = String.Empty

        Private _descreption As String = String.Empty

        Private _author As String = String.Empty

        Private _company As String = String.Empty

        Private _dateCreated As DateTime

        Public ReadOnly Property Title() As String
            Get
                Return _title
            End Get
        End Property

        Public ReadOnly Property Descreption() As String
            Get
                Return _descreption
            End Get
        End Property

        Public ReadOnly Property Version() As Version
            Get
                Return _version
            End Get
        End Property

        Public ReadOnly Property Author() As String
            Get
                Return _author
            End Get
        End Property

        Public ReadOnly Property Company() As String
            Get
                Return _company
            End Get
        End Property

        Public ReadOnly Property DateCreated() As DateTime
            Get
                Return _dateCreated
            End Get
        End Property

        Public Shared Function FromPlugin(plugin As IPlugin) As PluginInfoAttribute
            Dim attributes As Object() = plugin.[GetType]().GetCustomAttributes(GetType(PluginInfoAttribute), False)
            If attributes.Length > 0 Then
                Return TryCast(attributes(0), PluginInfoAttribute)
            End If
            Return Nothing
        End Function

    End Class
    ''' <summary>
    ''' This attribute views type and work type of any plug-in
    ''' </summary>
    <AttributeUsage(AttributeTargets.[Class], Inherited:=True, AllowMultiple:=False)> _
    Public NotInheritable Class PluginSettingsAttribute
        Inherits Attribute
        Public Property Run() As Boolean
            Get
                Return m_Run
            End Get
            Set(value As Boolean)
                m_Run = Value
            End Set
        End Property
        Private m_Run As Boolean

        Public Property IsControl() As Boolean
            Get
                Return m_IsControl
            End Get
            Set(value As Boolean)
                m_IsControl = Value
            End Set
        End Property
        Private m_IsControl As Boolean

        Public Shared Function FromPlugin(plugin As IPlugin) As PluginSettingsAttribute
            Dim attributes As Object() = plugin.[GetType]().GetCustomAttributes(GetType(PluginSettingsAttribute), False)
            If attributes.Length > 0 Then
                Return TryCast(attributes(0), PluginSettingsAttribute)
            End If
            Return Nothing
        End Function

    End Class
    ''' <summary>
    ''' This interface is base of any config class
    ''' </summary>
    Public Interface IConfigoration
        Inherits IDictionary(Of String, Object)
        Sub Save(ParamArray Parameters As Object())
        Sub Load(ParamArray Parameters As Object())
        Function Exist(Key As String) As Boolean
    End Interface
    ''' <summary>
    ''' This interface is base of any pluf-in that created by users
    ''' </summary>
    Public Interface IPlugin
        ReadOnly Property Plugins() As IPlugins
        Property Parent() As IPlugin
        Property Value() As Object
        Property Config() As IConfigoration
        Sub Run(ParamArray parameters As Object())
    End Interface
    ''' <summary>
    ''' This class use with "Plug-in Engine" to run system
    ''' </summary>
    Public Interface IHost
        ReadOnly Property Plugins() As IPlugins

        Property Config() As IConfigoration

        Sub Run(ParamArray Parameters As Object())
    End Interface
    ''' <summary>
    ''' This is a collection of plug-ins that use for child 
    ''' plug-ins
    ''' </summary>
    Public Class IPlugins
        Inherits List(Of IPlugin)
        Public Function GetExtentionIndexes(slot As SlotAttribute) As Integer()
            Return GetExtentionIndexes(slot.SlotName)
        End Function

        Public Function GetExtentionIndexes(ExtentionName As String) As Integer()
            Dim result As New List(Of Integer)()
            For i As Integer = 0 To Count - 1
                Dim extentions As List(Of ExtentionAttribute) = ExtentionAttribute.FromPlugin(Me(i))
                If extentions.Count = 0 Then
                    Continue For
                End If
                Dim find As Boolean = extentions.Exists(New Predicate(Of ExtentionAttribute)(Function(extention As ExtentionAttribute) (extention.ExtentionName = ExtentionName)))
                If find Then
                    result.Add(i)
                End If
            Next
            Return result.ToArray()
        End Function


    End Class
    ''' <summary>
    ''' This is sample host that its enough for run system
    ''' with engine.
    ''' </summary>
    Public Class Host
        Implements IHost
        Private _Plugins As New IPlugins()

        Public Property Config() As IConfigoration Implements IHost.Config
            Get
                Return m_Config
            End Get
            Set(value As IConfigoration)
                m_Config = value
            End Set
        End Property
        Private m_Config As IConfigoration

        Public ReadOnly Property Plugins() As IPlugins Implements IHost.Plugins
            Get
                Return _Plugins
            End Get
        End Property

        Private Sub CreateConnections()
            For Each plugin As IPlugin In Plugins
                Dim slot As SlotAttribute = SlotAttribute.FromPlugin(plugin)
                Dim ExtentionIndexes As Integer() = Plugins.GetExtentionIndexes(slot)
                If ExtentionIndexes.Length = 0 Then
                    Continue For
                End If
                For Each ExtentionIndex As Integer In ExtentionIndexes
                    plugin.Plugins.Add(Plugins(ExtentionIndex))
                    Plugins(ExtentionIndex).Parent = plugin
                Next
            Next
        End Sub

        Public Sub Run(ParamArray Parameters As Object()) Implements IHost.Run
            CreateConnections()

            For Each plugin As IPlugin In Plugins
                Dim setting As PluginSettingsAttribute = PluginSettingsAttribute.FromPlugin(plugin)
                If setting Is Nothing Then
                    Continue For
                End If
                If setting.Run Then
                    plugin.Run()
                End If
            Next
        End Sub

    End Class

End Namespace