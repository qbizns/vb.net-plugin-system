Imports Salling.Interface
Imports Salling.Core
Imports Salling.Configs
Imports System.Windows.Forms

Namespace Salling.Plugins
    <Slot("Workbench")> _
    <PluginInfo("Workbench", "none", "Syamand Mahrofy", "Armani Software Ltd.", "2009/08/24", "1.0.0.0")> _
    <PluginSettings(Run:=True, IsControl:=False)> _
    Public Class Start
        Inherits MarshalByRefObject
        Implements [Interface].IGraphical
        Implements Core.IPlugin



        Public ReadOnly Property Dashboard As UI.Dashboard Implements [Interface].IGraphical.Dashboard
            Get
                Return New MainDashboard
            End Get
        End Property

        Public Sub Initialize() Implements [Interface].IPlugin.Initialize
            Dashboard.Show()
        End Sub

        Public ReadOnly Property Permissions As List(Of KeyValuePair(Of ArrayList, ArrayList)) Implements [Interface].IPlugin.Permissions
            Get
                Dim _Perm As New List(Of KeyValuePair(Of ArrayList, ArrayList))

                _Perm.Add(New KeyValuePair(Of ArrayList, ArrayList)(New ArrayList(
                                {"FrmRooms", "Rooms", "Room Managment"}), New ArrayList(
                                {"ADD", "DEL", "EDT", "LST"}
                )))

                Return _Perm
            End Get
        End Property

        Public ReadOnly Property PluginDescription As String Implements [Interface].IPlugin.PluginDescription
            Get
                Return "Front Office managment solution for Stores"
            End Get
        End Property

        Public ReadOnly Property PluginGroup As String Implements [Interface].IPlugin.PluginGroup
            Get
                Return "Sales"
            End Get
        End Property

        Public ReadOnly Property PluginID As String Implements [Interface].IPlugin.PluginID
            Get
                Return "{3cf26f54-b802-4213-bf0c-b8df0b30538a}"
            End Get
        End Property

        Public ReadOnly Property PluginName As String Implements [Interface].IPlugin.PluginName
            Get
                Return "Point Of Sale"
            End Get
        End Property

        Public ReadOnly Property PluginVersion As String Implements [Interface].IPlugin.PluginVersion
            Get
                Return "1.0.0"
            End Get
        End Property

        ' Private MainConfig As New XMLConfig()
        Private _Plugins As New IPlugins()

        Public Property Config() As IConfigoration Implements Core.IPlugin.Config
            Get
                Return m_Config
            End Get
            Set(value As IConfigoration)
                m_Config = value
            End Set
        End Property
        Private m_Config As IConfigoration

        Public ReadOnly Property Plugins() As IPlugins Implements Core.IPlugin.Plugins
            Get
                Return _Plugins
            End Get
        End Property

        Public Sub Run(ParamArray parameters As Object()) Implements Core.IPlugin.Run
            Dim masterForm As New DevExpress.XtraEditors.XtraForm()
            For Each plg As Core.IPlugin In Plugins
                Dim setting As PluginSettingsAttribute = PluginSettingsAttribute.FromPlugin(plg)
                If (setting.IsControl) AndAlso (TypeOf plg.Value Is Control) Then
                    masterForm.Controls.Add(TryCast(plg.Value, Control))
                End If
            Next
            Application.Run(masterForm)
        End Sub

        Public Property Value() As Object Implements Core.IPlugin.Value
            Get
                Return m_Value
            End Get
            Set(value As Object)
                m_Value = value
            End Set
        End Property
        Private m_Value As Object

        Public Property Parent As Core.IPlugin Implements Core.IPlugin.Parent
    End Class
End Namespace