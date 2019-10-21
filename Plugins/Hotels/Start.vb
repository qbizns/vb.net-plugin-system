Namespace Salling.Plugins
    <Serializable> _
    Public Class Start
        Inherits MarshalByRefObject
        Implements [Interface].IGraphical


        Public ReadOnly Property Dashboard As UI.Dashboard Implements [Interface].IGraphical.Dashboard
            Get
                Return New MainDashboard
            End Get
        End Property

        Public Sub Initialize() Implements [Interface].IPlugin.Initialize
            'Dim frm As New DevExpress.XtraEditors.XtraForm
            'frm.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            'frm.WindowState = Windows.Forms.FormWindowState.Maximized
            'frm.FormBorderStyle = Windows.Forms.FormBorderStyle.None
            'frm.Name = "test From Plugin2"
            'frm.Text = "test From Plugin2"
            ''frm.Controls.Add(New Dashboard())
            'frm.Show()
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
        Public ReadOnly Property PluginGroup As String Implements [Interface].IPlugin.PluginGroup
            Get
                Return "Hotel Managment System"
            End Get
        End Property

        Public ReadOnly Property PluginDescription As String Implements [Interface].IPlugin.PluginDescription
            Get
                Return "Back Office managment solution for hotels"
            End Get
        End Property

        Public ReadOnly Property PluginID As String Implements [Interface].IPlugin.PluginID
            Get
                Return "{3cf26f54-b802-4213-bf0c-b8df0b30538a}"
            End Get
        End Property

        Public ReadOnly Property PluginName As String Implements [Interface].IPlugin.PluginName
            Get
                Return "Back Office"
            End Get
        End Property

        Public ReadOnly Property PluginVersion As String Implements [Interface].IPlugin.PluginVersion
            Get
                Return "1.0.0"
            End Get
        End Property


    End Class
End Namespace