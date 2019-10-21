Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports System.Text
Imports System.IO
Imports System.Xml
Imports DevExpress.Skins
Imports System.Drawing
Imports DevExpress.LookAndFeel
Imports DevExpress.UserSkins
Imports DevExpress.XtraExport

Namespace Salling.UI
    Public Class FrmConfigurations

        Public OptionDataset As New DataSet
        Public SpinEditControls As New List(Of Control)
        Public ToggleSwitchControls As New List(Of Control)
        Public ComboBoxEditControls As New List(Of Control)

        Public Shared _uow As UnitOfWork
        <Browsable(False)> _
        Public Shared Property uow() As UnitOfWork
            Get
                Return _uow
            End Get
            Set(ByVal value As UnitOfWork)
                _uow = value
                _uow.TrackPropertiesModifications = False
            End Set
        End Property

        Public Shared _Scope As String
        <Browsable(False)> _
        Public Shared Property Scope() As String
            Get
                Return _Scope
            End Get
            Set(ByVal value As String)
                _Scope = value
            End Set
        End Property

        Public Sub New(ByVal oscope As String)
            uow = Salling.BASE.XPOUtils.GetNewUnitOfWork
            Scope = oscope

            BonusSkins.Register()
            SkinManager.EnableFormSkins()
            SkinManager.EnableMdiFormSkins()
            SkinManager.EnableFormSkinsIfNotVista()

            DevExpress.XtraEditors.WindowsFormsSettings.SetDPIAware()
            DevExpress.XtraEditors.WindowsFormsSettings.EnableFormSkins()
            DevExpress.XtraEditors.WindowsFormsSettings.DefaultLookAndFeel.SetSkinStyle("Metropolis")
            DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = DevExpress.XtraEditors.ScrollUIMode.Touch
            DevExpress.Utils.AppearanceObject.DefaultFont = New Font("Segoe UI", 8)

            Application.EnableVisualStyles()


            UserLookAndFeel.Default.UseWindowsXPTheme = False
            UserLookAndFeel.Default.UseDefaultLookAndFeel = True
            UserLookAndFeel.Default.SetSkinStyle("Metropolis")

            DevExpress.XtraEditors.WindowsFormsSettings.AllowPixelScrolling = DevExpress.Utils.DefaultBoolean.True
            DevExpress.XtraEditors.WindowsFormsSettings.ScrollUIMode = DevExpress.XtraEditors.ScrollUIMode.Touch

            InitializeComponent()

            Me.StartPosition = Windows.Forms.FormStartPosition.CenterScreen
            Me.WindowState = Windows.Forms.FormWindowState.Maximized
            Me.FormBorderStyle = Windows.Forms.FormBorderStyle.None
        End Sub

        Private Sub Settings_Load(sender As Object, e As EventArgs) Handles Me.Load
            Dim dataTable As DataTable = New DataTable(Scope)
            Dim sb As New StringBuilder()
            Using sw As New StringWriter(sb)
                Using writer = XmlWriter.Create(sw)
                    writer.WriteStartDocument()
                    writer.WriteStartElement("Config")
                    writer.WriteStartElement(Scope)

                    For Each SpinEdit As DevExpress.XtraEditors.SpinEdit In FindControlRecursive(SpinEditControls, Me, GetType(DevExpress.XtraEditors.SpinEdit))
                        If SpinEdit.Tag Is "setting" Then
                            writer.WriteStartElement(SpinEdit.Name)
                            writer.WriteValue(SpinEdit.Value)
                            writer.WriteEndElement()
                            dataTable.Columns.Add(SpinEdit.Name, Type.GetType("System.Int32"))
                        End If
                    Next

                    For Each ToggleSwitch As DevExpress.XtraEditors.ToggleSwitch In FindControlRecursive(ToggleSwitchControls, Me, GetType(DevExpress.XtraEditors.ToggleSwitch))
                        If ToggleSwitch.Tag Is "setting" Then
                            writer.WriteStartElement(ToggleSwitch.Name)
                            writer.WriteValue(ToggleSwitch.EditValue)
                            writer.WriteEndElement()
                            dataTable.Columns.Add(ToggleSwitch.Name, Type.GetType("System.Boolean"))
                        End If
                    Next

                    For Each ComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit In FindControlRecursive(ComboBoxEditControls, Me, GetType(DevExpress.XtraEditors.ComboBoxEdit))
                        If ComboBoxEdit.Tag Is "setting" Then
                            writer.WriteStartElement(ComboBoxEdit.Name)
                            writer.WriteString(ComboBoxEdit.EditValue.ToString)
                            writer.WriteEndElement()
                            dataTable.Columns.Add(ComboBoxEdit.Name, Type.GetType("System.String"))
                        End If
                    Next

                    writer.WriteEndElement()
                    writer.WriteEndElement()
                    writer.WriteEndDocument()
                    writer.Close()

                End Using
            End Using

            Dim config As Salling.BASE.ORM.Configurations = Salling.BASE.ORM.Configurations.CreateConfigurations(_uow, _Scope, sb.ToString)
            OptionDataset.Tables.Add(dataTable)

            Dim reader As System.Xml.XmlTextReader = New System.Xml.XmlTextReader(New System.IO.StringReader(config.Configuration))
            reader.Read()
            OptionDataset.ReadXml(reader, XmlReadMode.IgnoreSchema)

            InitBinding()

        End Sub

        Public Function GetSettingXmlFromForm() As String
            Dim sb As New StringBuilder()
            Using sw As New StringWriter(sb)
                Using writer = XmlWriter.Create(sw)
                    writer.WriteStartDocument()
                    writer.WriteStartElement("Config")

                    writer.WriteStartElement(_Scope)

                    For Each SpinEdit As DevExpress.XtraEditors.SpinEdit In FindControlRecursive(SpinEditControls, Me, GetType(DevExpress.XtraEditors.SpinEdit))
                        If SpinEdit.Tag Is "setting" Then
                            writer.WriteStartElement(SpinEdit.Name)
                            writer.WriteValue(SpinEdit.Value)
                            writer.WriteEndElement()
                        End If
                    Next

                    For Each ToggleSwitch As DevExpress.XtraEditors.ToggleSwitch In FindControlRecursive(ToggleSwitchControls, Me, GetType(DevExpress.XtraEditors.ToggleSwitch))
                        If ToggleSwitch.Tag Is "setting" Then
                            writer.WriteStartElement(ToggleSwitch.Name)
                            writer.WriteValue(ToggleSwitch.EditValue)
                            writer.WriteEndElement()
                        End If
                    Next

                    For Each ComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit In FindControlRecursive(ComboBoxEditControls, Me, GetType(DevExpress.XtraEditors.ComboBoxEdit))
                        If ComboBoxEdit.Tag Is "setting" Then
                            writer.WriteStartElement(ComboBoxEdit.Name)
                            writer.WriteString(ComboBoxEdit.EditValue.ToString)
                            writer.WriteEndElement()
                        End If
                    Next

                    writer.WriteEndElement()
                    writer.WriteEndElement()
                    writer.WriteEndDocument()
                    writer.Close()

                End Using
            End Using
            Return sb.ToString
        End Function

        Public Sub InitBinding()
            For Each SpinEdit As DevExpress.XtraEditors.SpinEdit In SpinEditControls
                SpinEdit.DataBindings.Clear()
                SpinEdit.DataBindings.Add("EditValue", OptionDataset.Tables(_Scope), SpinEdit.Name, True, DataSourceUpdateMode.OnPropertyChanged)
            Next

            For Each ToggleSwitch As DevExpress.XtraEditors.ToggleSwitch In ToggleSwitchControls
                ToggleSwitch.DataBindings.Clear()
                ToggleSwitch.DataBindings.Add("EditValue", OptionDataset.Tables(_Scope), ToggleSwitch.Name, True, DataSourceUpdateMode.OnPropertyChanged)
            Next

            For Each ComboBoxEdit As DevExpress.XtraEditors.ComboBoxEdit In ComboBoxEditControls
                ComboBoxEdit.DataBindings.Clear()
                ComboBoxEdit.DataBindings.Add("EditValue", OptionDataset.Tables(_Scope), ComboBoxEdit.Name, True, DataSourceUpdateMode.OnPropertyChanged)
            Next
        End Sub

        Public Shared Function FindControlRecursive(ByVal list As List(Of Control), ByVal parent As Control, ByVal ctrlType As System.Type) As List(Of Control)
            If parent Is Nothing Then Return list
            If parent.GetType Is ctrlType Then
                list.Add(parent)
            End If
            For Each child As Control In parent.Controls
                FindControlRecursive(list, child, ctrlType)
            Next
            Return list
        End Function

        Private Sub BtnClose_Click(sender As Object, e As EventArgs) Handles BtnClose.Click
            Me.Dispose()
        End Sub

        Private Sub BtnSave_Click(sender As Object, e As EventArgs) Handles BtnSave.Click
            Salling.BASE.ORM.Configurations.UpdateConfigurations(uow, Scope, GetSettingXmlFromForm())
            MsgBox("تم حفظ التعديلات")
            Me.Close()
        End Sub

    End Class
End Namespace