Imports Salling.Interface
Imports System.Collections.Generic
Imports System.Text
Imports System.Reflection
Imports System.IO
Imports DevExpress.Xpo
Imports System.ComponentModel

Namespace Salling.Proxy
    Public Class IProxy
        Implements [Interface].IGraphical
        Public Shared _appDomainController As AppDomainCore
        Public Shared _assemblyController As AssemblyCore
        Public Shared _proxy As [Interface].IGraphical

        ''' <summary>
        ''' Gets the currenlty Active Appdomain Name
        ''' </summary>
        Public ReadOnly Property DefaultAppDomain() As String
            Get
                Return _appDomainController.DefaultAppdomainName
            End Get
        End Property

        ''' <summary>
        ''' Gets the Default Assembly's FileName
        ''' </summary>
        Public ReadOnly Property DefaultAssemblyFileName() As String
            Get
                Return _assemblyController.ActiveAssemblyFile
            End Get
        End Property

        ''' <summary>
        ''' Creates an instance of the proxy.
        ''' </summary>
        ''' <param name="AssemblyFileName">Name of Assembly File to be loaded</param>
        ''' <param name="AppDomainName">Friendly Name for the new Appdomain</param>
        Public Sub New(AssemblyFileName As String, AppDomainName As String)
            Init(AssemblyFileName, AppDomainName, "Salling.Plugins.Start")
        End Sub

        ''' <summary>
        ''' Creates an instance of the proxy.
        ''' </summary>
        ''' <param name="AssemblyFileName">Name of Assembly File to be loaded</param>
        ''' <param name="AppDomainName">Friendly Name for the new Appdomain</param>
        ''' <param name="CurrentType">Name of Object type that is to loaded from the Assembly</param>
        Public Sub New(AssemblyFileName As String, AppDomainName As String, CurrentType As String)
            Init(AssemblyFileName, AppDomainName, CurrentType)
        End Sub

        Private Function Init(AssemblyFileName As String, AppDomainName As String, CurrentType As String) As Boolean
            'Creates an instance of Assembly controller and Appdomain controller
            _assemblyController = New AssemblyCore(AssemblyFileName, CurrentType)
            _appDomainController = New AppDomainCore(AppDomainName)
            Return True
        End Function

        Public ReadOnly Property PluginGroup As String Implements IPlugin.PluginGroup
            Get
                _proxy = DirectCast(_appDomainController.DefaultAppDomain.CreateInstanceFromAndUnwrap(_assemblyController.DefaultAssemblyFileName, _assemblyController.CurrentType), [Interface].IGraphical)
                If _proxy IsNot Nothing Then
                    Return _proxy.PluginGroup
                End If
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property PluginID As String Implements IPlugin.PluginID
            Get
                _proxy = DirectCast(_appDomainController.DefaultAppDomain.CreateInstanceFromAndUnwrap(_assemblyController.DefaultAssemblyFileName, _assemblyController.CurrentType), [Interface].IGraphical)
                If _proxy IsNot Nothing Then
                    Return _proxy.PluginID
                End If
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property PluginName As String Implements IPlugin.PluginName
            Get
                _proxy = DirectCast(_appDomainController.DefaultAppDomain.CreateInstanceFromAndUnwrap(_assemblyController.DefaultAssemblyFileName, _assemblyController.CurrentType), [Interface].IGraphical)
                If _proxy IsNot Nothing Then
                    Return _proxy.PluginName
                End If
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property PluginDescription As String Implements IPlugin.PluginDescription
            Get
                _proxy = DirectCast(_appDomainController.DefaultAppDomain.CreateInstanceFromAndUnwrap(_assemblyController.DefaultAssemblyFileName, _assemblyController.CurrentType), [Interface].IGraphical)
                If _proxy IsNot Nothing Then
                    Return _proxy.PluginDescription
                End If
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property PluginVersion As String Implements IPlugin.PluginVersion
            Get
                _proxy = DirectCast(_appDomainController.DefaultAppDomain.CreateInstanceFromAndUnwrap(_assemblyController.DefaultAssemblyFileName, _assemblyController.CurrentType), [Interface].IGraphical)
                If _proxy IsNot Nothing Then
                    Return _proxy.PluginVersion
                End If
                Return Nothing
            End Get
        End Property

        Public Sub Initialize() Implements IPlugin.Initialize
            _proxy = DirectCast(_appDomainController.DefaultAppDomain.CreateInstanceFromAndUnwrap(_assemblyController.DefaultAssemblyFileName, _assemblyController.CurrentType), [Interface].IGraphical)
            If _proxy IsNot Nothing Then
                _proxy.Initialize()
            End If
        End Sub

        Public ReadOnly Property Permissions As List(Of KeyValuePair(Of ArrayList, ArrayList)) Implements IPlugin.Permissions
            Get
                _proxy = DirectCast(_appDomainController.DefaultAppDomain.CreateInstanceFromAndUnwrap(_assemblyController.DefaultAssemblyFileName, _assemblyController.CurrentType), [Interface].IGraphical)
                If _proxy IsNot Nothing Then
                    Return _proxy.Permissions
                End If
                Return Nothing
            End Get
        End Property

        Public ReadOnly Property Dashboard As UI.Dashboard Implements IGraphical.Dashboard
            Get
                _proxy = DirectCast(_appDomainController.DefaultAppDomain.CreateInstanceFromAndUnwrap(_assemblyController.DefaultAssemblyFileName, _assemblyController.CurrentType), [Interface].IGraphical)
                If _proxy IsNot Nothing Then
                    Return _proxy.Dashboard
                End If
                Return Nothing
            End Get
        End Property

    End Class

End Namespace