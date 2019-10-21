Imports System.ComponentModel
Imports DevExpress.Xpo
Imports System.Windows.Forms
Imports System.Drawing
Imports System.Xml
Imports System.Reflection
Imports DevExpress.Xpo.Metadata
Imports System.Text
Imports System.IO
Imports System.Text.RegularExpressions
Imports DevExpress.Data.Filtering

Namespace Salling.UI

    Public Class DataEntry
        Inherits DevExpress.XtraEditors.XtraForm
        Private components As System.ComponentModel.IContainer

        Private ConfigXML As String = ""
        Private FormLayoutXML As String = ""
        Private GridLayoutXML As String = ""
        Public opener As Form


        Friend WithEvents DataLayoutControl As DevExpress.XtraDataLayout.DataLayoutControl
        Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
        Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents btnSave As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents Bar As DevExpress.XtraEditors.PictureEdit
        Friend WithEvents FormName As DevExpress.XtraEditors.LabelControl
        Friend WithEvents FormLogo As DevExpress.XtraEditors.PictureEdit

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

        Private _xpcol As XPCollection
        <Browsable(False)> _
        Public Property xpcol() As XPCollection
            Get
                Return _xpcol
            End Get
            Set(ByVal value As XPCollection)
                Me._xpcol = value
                Me._xpcol.LoadingEnabled = False
                Me._xpcol.Session = uow
            End Set
        End Property

        Private _table As String
        <Browsable(False)> _
        Public Property table() As String
            Get
                Return _table
            End Get
            Set(ByVal value As String)
                Me._table = value
            End Set
        End Property

        Private _formlayout As String = Nothing
        <Browsable(False)> _
        Public Property formlayout() As String
            Get
                Return _formlayout
            End Get
            Set(ByVal value As String)
                Me._formlayout = value
            End Set
        End Property

        Private _configuration As String = Nothing
        <Browsable(False)> _
        Public Property configuration() As String
            Get
                Return _configuration
            End Get
            Set(ByVal value As String)
                Me._configuration = value
            End Set
        End Property

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        Public Sub New(ouow As UnitOfWork, xtable As String, Optional obj As Object = Nothing)
            InitializeComponent()
            uow = ouow
            Me.xpcol = Salling.BASE.XPO.GetXpcollection(xtable, uow)
            Me.table = xtable

            If obj Is Nothing Then
                Me.BindingContext(Me.xpcol).AddNew()
            Else
                uow.Reload(obj)
                Me.xpcol.Add(obj)
            End If

            FillDataLayoutControl()
            'initfonts()
            initGfx()

            SaveRetriveLayout("startup")



            'FormLayoutXML = Salling.BASE.ORM.FormData.GetFormData(uow, xtable, Application.CurrentCulture.ToString).LayoutData

            'Dim s As New IO.MemoryStream()
            'Dim w As New IO.StreamWriter(s)
            'w.AutoFlush = True
            'w.Write(FormLayoutXML)
            's.Position = 0

            'If FormLayoutXML IsNot Nothing Then
            '    Try
            '        DataLayoutControl.RestoreLayoutFromStream(s)
            '    Catch ex As Exception
            '        Throw New Exception("Wrong data format", ex)
            '    End Try
            'End If













            'ConfigXML = Salling.BASE.ORM.FormData.GetFormData(uow, xtable, Application.CurrentCulture.ToString).Configurations.ToString

            'If ConfigXML IsNot Nothing Then

            '    Dim XMLDoc As XmlDocument = New XmlDocument()
            '    XMLDoc.Load(ConfigXML)
            '    Dim Config As XmlNode = XMLDoc.DocumentElement.SelectSingleNode("/Configurations")

            '    For Each node As XmlNode In Config
            '        Me.Width = node.Item("Width").InnerText
            '        Me.Height = node.Item("Height").InnerText
            '    Next
            '    Dim ConfigXMLs As New IO.MemoryStream()
            '    Dim ConfigXMLw As New IO.StreamWriter(s)
            '    ConfigXMLw.AutoFlush = True
            '    ConfigXMLw.Write(ConfigXML)
            '    ConfigXMLs.Position = 0

            'Dim oDs As New DataSet

            'oDs.ReadXml(New StringReader(ConfigXML))
            'Me.Width = CInt(oDs.Tables("Configurations").Rows(0).Item("Width").ToString)
            'Me.Height = CInt(oDs.Tables("Configurations").Rows(0).Item("Height").ToString)
            'End If
            initForm()
        End Sub

#Region "   Fonts and Icons"
        Private Sub initfonts()
            Dim privateFonts As New System.Drawing.Text.PrivateFontCollection()
            privateFonts.AddFontFile(AppDomain.CurrentDomain.BaseDirectory & "\assets\fonts\OpenSans-ExtraBold.ttf")
            Dim font As New System.Drawing.Font(privateFonts.Families(0), 9)
            FormName.Font = font

            Dim ItemprivateFonts As New System.Drawing.Text.PrivateFontCollection()
            ItemprivateFonts.AddFontFile(AppDomain.CurrentDomain.BaseDirectory & "\assets\fonts\OpenSans-Regular.ttf")
            Dim itemfont As New System.Drawing.Font(ItemprivateFonts.Families(0), 9)

            For Each it As DevExpress.XtraLayout.BaseLayoutItem In DataLayoutControl.Items
                it.AppearanceItemCaption.Font = itemfont
            Next

        End Sub

        Private Sub initGfx()
            Dim back As New Bitmap(AppDomain.CurrentDomain.BaseDirectory & "\assets\ui\top.png")
            Dim frmlogo As New Bitmap(AppDomain.CurrentDomain.BaseDirectory & "\assets\logo\settings.png")

            'set the size of your graphic base on the background 
            Dim BMP As New Bitmap(back.Width, back.Height)

            'create a graphic base on that
            Dim GR As Graphics = Graphics.FromImage(BMP)

            'draw onto your bmp starting from the background
            GR.DrawImage(back, 0, 0)

            'set X,y to the coordinate you want your girl to appear
            GR.DrawImage(frmlogo, 46, 21, 65, 58)

            'clear the picturebox
            FormLogo.Image = Nothing

            'now that we have draw all our image onto the same bitmap, assign it to your picturebox element
            FormLogo.Image = BMP

            Bar.Image = System.Drawing.Image.FromFile(AppDomain.CurrentDomain.BaseDirectory & "\assets\ui\bar.png")
        End Sub

#End Region

#Region "   Layout"
        Private Sub FillDataLayoutControl()
            DataLayoutControl.DataSource = Me.xpcol
            DataLayoutControl.BeginUpdate()

            For Each member As MemberInfo In Salling.BASE.XPO.GetObject(Me.table).GetMembers
                If (member.MemberType.ToString = "Property") Then
                    If (member.Name <> "This" And member.Name <> "Loading" And member.Name <> "ClassInfo" And member.Name <> "Session" And member.Name <> "IsLoading" And member.Name <> "IsDeleted") Then
                        Dim m As XPMemberInfo = Me.xpcol.ObjectClassInfo.GetMember(member.Name)
                        Console.WriteLine(member.Name.ToString & " -- " & member.MemberType.ToString & " ---> " & m.MemberType.ToString)

                        Select Case m.MemberType.ToString

                            Case "System.String"
                                'String
                                If m.Name.ToString.Contains("Image") Then
                                    'Picture
                                    Dim Obj_PictureEdit As _PictureEdit = New _PictureEdit(m.Name.ToString, xpcol, DataLayoutControl)
                                ElseIf m.Name.ToString = "Notes" Then
                                    'MemoEdit
                                    Dim Obj_MemoEdit As _MemoEdit = New _MemoEdit(m.Name.ToString, xpcol, DataLayoutControl)
                                Else
                                    'TextEdit
                                    Dim Obj_TextEdit As _TextEdit = New _TextEdit(m.Name.ToString, xpcol, DataLayoutControl)
                                End If

                            Case "System.Decimal"
                                'Currency
                                Dim Obj_CurrencyDecimal As _Currency = New _Currency(m.Name.ToString, xpcol, DataLayoutControl)

                            Case "System.Double"
                                'Currency
                                Dim Obj_CurrencyDouble As _Currency = New _Currency(m.Name.ToString, xpcol, DataLayoutControl)

                            Case "System.Boolean"
                                'True/False
                                Dim Obj_CheckEdit As _CheckEdit = New _CheckEdit(m.Name.ToString, xpcol, DataLayoutControl)

                            Case "System.UInt32", "System.Int32", "System.Int16", "System.UInt16", "System.Int64", "System.UInt64"
                                ' U32 Number
                                Dim Obj_SpinEditUInt32 As _SpinEdit = New _SpinEdit(m.Name.ToString, xpcol, DataLayoutControl)

                            Case "System.DateTime"
                                'DateTime
                                Dim Obj_DateEdit As _DateEdit = New _DateEdit(m.Name.ToString, xpcol, DataLayoutControl)

                            Case "System.Byte[]"
                                ' Picture
                                Dim Obj_PicturByteEEdit As _PictureEdit = New _PictureEdit(m.Name.ToString, xpcol, DataLayoutControl)

                            Case "System.Byte"
                            Case "System.SByte"
                            Case "System.Char"
                            Case "System.Single"
                            Case "System.Guid"
                            Case "System.Enum"
                            Case "System.TimeSpan"
                            Case "Unlimited size string"
                                ' MemoEdit
                                Dim Obj_Unlimited_size_string As _MemoEdit = New _MemoEdit(m.Name.ToString, xpcol, DataLayoutControl)

                            Case Else
                                'Enum LookupEdit
                                If m.MemberType.ToString.Contains("+") Then

                                Else

                                    Dim regex = New Regex("\bSalling\b.*\bORM")
                                    Dim match = regex.Match(m.MemberType.ToString)
                                    If match.Success Then

                                        If m.MemberType.ToString.Substring(0, 8) = "Salling." Then
                                            ' LookUpEdit
                                            Dim Obj_LookUpEdit As _LookUpEdit = New _LookUpEdit(m, xpcol, DataLayoutControl, uow, Me)

                                        ElseIf m.MemberType.ToString.Substring(0, 27) = "DevExpress.Xpo.XPCollection" Then
                                            ' Grid Control
                                            Dim Obj_GridControl As _GridControl = New _GridControl(m, Me.table, xpcol, DataLayoutControl, uow)

                                        End If

                                    End If
                                End If

                        End Select

                    End If
                End If
            Next
            DataLayoutControl.EndUpdate()
        End Sub

        Private Sub initForm()
            FormName.Text = Regex.Replace(table, "(\\B[A-Z])", " $1")
            Me.CenterToScreen()
        End Sub

        Private Sub SaveRetriveLayout(ByVal mode As String)
            For Each it As DevExpress.XtraLayout.BaseLayoutItem In DataLayoutControl.Items
                it.AppearanceItemCaption.Font = Nothing
            Next

            Dim newLayout As New IO.MemoryStream()
            DataLayoutControl.SaveLayoutToStream(newLayout)
            newLayout.Position = 0
            Dim newLayoutData As New IO.StreamReader(newLayout)

            Dim sw As StringWriter = New StringWriter()
            Dim xw As XmlWriter = XmlWriter.Create(sw)
            xw.WriteStartDocument(True)
            'xw.Formatting = Formatting.Indented
            'xw.Indentation = 2
            xw.WriteStartElement("Configurations")

            xw.WriteStartElement("Width")
            xw.WriteString(Me.Width)
            xw.WriteEndElement()

            xw.WriteStartElement("Height")
            xw.WriteString(Me.Height)
            xw.WriteEndElement()

            xw.WriteEndElement()
            xw.WriteEndDocument()
            xw.Close()


            Dim FormData As Salling.BASE.ORM.FormData = uow.FindObject(Of Salling.BASE.ORM.FormData)(CriteriaOperator.Parse(String.Format("FormName == '{0}'", Me.table)))
            If FormData Is Nothing Then
                FormData = New Salling.BASE.ORM.FormData(uow)
                FormData.FormName = Me.table
                FormData.Language = Application.CurrentCulture.ToString
                FormData.LayoutData = newLayoutData.ReadToEnd()
                FormData.Configurations = sw.ToString
                FormData.Save()
            Else
                Dim s As New IO.MemoryStream()
                Dim w As New IO.StreamWriter(s)
                w.AutoFlush = True
                w.Write(FormData.LayoutData)
                s.Position = 0
                DataLayoutControl.RestoreLayoutFromStream(s)

                FormData.FormName = Me.table
                FormData.Language = Application.CurrentCulture.ToString
                FormData.LayoutData = newLayoutData.ReadToEnd()
                FormData.Configurations = sw.ToString
                FormData.Save()
            End If

            ' Save Any GridLayoutXML
            For Each child As Control In DataLayoutControl.Controls
                If child.GetType Is GetType(DevExpress.XtraGrid.GridControl) Then

                    'Dim s As New IO.MemoryStream()
                    'CType(child, DevExpress.XtraGrid.GridControl).MainView.SaveLayoutToStream(s)
                    's.Position = 0
                    'Dim r As New IO.StreamReader(s)

                    'Dim GridLayout As Salling.BASE.ORM.GridLayouts = uow.FindObject(Of Salling.BASE.ORM.GridLayouts)(CriteriaOperator.Parse(String.Format("FormName == '{0}'", Me.table)))
                    'If GridLayout Is Nothing Then
                    '    GridLayout = New Salling.BASE.ORM.GridLayouts(uow)
                    '    GridLayout.FormName = Me.table
                    '    GridLayout.Language = Application.CurrentCulture.ToString
                    '    GridLayout.LayoutData = r.ReadToEnd()
                    '    GridLayout.Save()
                    'Else
                    '    GridLayout.FormName = Me.table
                    '    GridLayout.Language = Application.CurrentCulture.ToString
                    '    GridLayout.LayoutData = r.ReadToEnd()
                    '    GridLayout.Save()
                    'End If

                    If mode = "shutdown" Then
                        Dim GridLayout As Salling.BASE.ORM.GridLayouts = uow.FindObject(Of Salling.BASE.ORM.GridLayouts)(CriteriaOperator.Parse(String.Format("FormName == '{0}' AND GridName == '{1}' AND Language == '{2}'", Me.table, CType(child, DevExpress.XtraGrid.GridControl).DataMember.ToString, Application.CurrentCulture.ToString)))
                        If GridLayout Is Nothing Then
                            GridLayout = New Salling.BASE.ORM.GridLayouts(uow)
                            GridLayout.FormName = Me.table
                            GridLayout.GridName = CType(child, DevExpress.XtraGrid.GridControl).DataMember.ToString
                            GridLayout.Language = Application.CurrentCulture.ToString

                            Dim xs As New IO.MemoryStream()
                            CType(child, DevExpress.XtraGrid.GridControl).MainView.SaveLayoutToStream(xs)
                            xs.Position = 0
                            Dim xr As New IO.StreamReader(xs)

                            GridLayout.LayoutData = xr.ReadToEnd()
                            GridLayout.Save()
                        Else
                            GridLayout.FormName = Me.table
                            GridLayout.GridName = CType(child, DevExpress.XtraGrid.GridControl).DataMember.ToString
                            GridLayout.Language = Application.CurrentCulture.ToString

                            Dim xs As New IO.MemoryStream()
                            CType(child, DevExpress.XtraGrid.GridControl).MainView.SaveLayoutToStream(xs)
                            xs.Position = 0
                            Dim xr As New IO.StreamReader(xs)

                            GridLayout.LayoutData = xr.ReadToEnd()
                            GridLayout.Save()
                        End If
                    End If
                    'CType(child, DevExpress.XtraGrid.GridControl).MainView.SaveLayoutToXml(GridLayoutXML)
                End If
            Next child

            uow.CommitChanges()
        End Sub

#End Region

        Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
            If uow.IsObjectToSave(Me.BindingContext(Me.xpcol).Current) = True Then
                Dim resp As DialogResult = DevExpress.XtraEditors.XtraMessageBox.Show("Did you want to ignore this changes?", "ddd", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If resp = DialogResult.Yes Then
                    uow.DropChanges()
                Else
                    Exit Sub
                End If
            End If
            Close()
        End Sub

        Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
            uow.CommitChanges()
        End Sub

        Private Sub Entry_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
            'Save Layout Xml
            'For Each it As DevExpress.XtraLayout.BaseLayoutItem In DataLayoutControl.Items
            '    it.AppearanceItemCaption.Font = Nothing
            'Next

            'Dim _defaultLayoutDLC As IO.MemoryStream = New IO.MemoryStream()
            'DataLayoutControl.SaveLayoutToStream(_defaultLayoutDLC)
            '_defaultLayoutDLC.Position = 0
            'Dim reader As New StreamReader(_defaultLayoutDLC)
            'Dim FrmLayoutXml = reader.ReadToEnd()
            '_defaultLayoutDLC.Position = 0


            'Dim stream As New MemoryStream()
            'DataLayoutControl.SaveLayoutToStream(stream)




            ' Save Any GridLayoutXML
            'For Each child As Control In DataLayoutControl.Controls
            '    If child.GetType Is GetType(DevExpress.XtraGrid.GridControl) Then
            '        CType(child, DevExpress.XtraGrid.GridControl).MainView.SaveLayoutToXml(GridLayoutXML)
            '    End If
            'Next child

            ' Save Form Configuration to XML Configuration File
            'Dim writer As New XmlTextWriter(ConfigXML, System.Text.Encoding.UTF8)
            'writer.WriteStartDocument(True)
            'writer.Formatting = Formatting.Indented
            'writer.Indentation = 2
            'writer.WriteStartElement("Configurations")

            'writer.WriteStartElement("Width")
            'writer.WriteString(Me.Width)
            'writer.WriteEndElement()

            'writer.WriteStartElement("Height")
            'writer.WriteString(Me.Height)
            'writer.WriteEndElement()

            'writer.WriteEndElement()
            'writer.WriteEndDocument()
            'writer.Close()

            'Using sw = New StringWriter()
            '    ' Build Xml with xw.


            '    Using xw = XmlWriter.Create(sw)
            '    End Using
            '    Return
            'End Using

            'Dim s As New IO.MemoryStream()
            'DataLayoutControl.SaveLayoutToStream(s)
            's.Position = 0
            'Dim r As New IO.StreamReader(s)


            'Dim sw As StringWriter = New StringWriter()
            'Dim xw As XmlWriter = XmlWriter.Create(sw)

            'xw.WriteStartDocument(True)
            ''xw.Formatting = Formatting.Indented
            ''xw.Indentation = 2
            'xw.WriteStartElement("Configurations")

            'xw.WriteStartElement("Width")
            'xw.WriteString(Me.Width)
            'xw.WriteEndElement()

            'xw.WriteStartElement("Height")
            'xw.WriteString(Me.Height)
            'xw.WriteEndElement()

            'xw.WriteEndElement()
            'xw.WriteEndDocument()
            'xw.Close()

            'Salling.BASE.ORM.FormData.CreateFormData(uow, Me.table, Application.CurrentCulture.ToString, r.ReadToEnd(), sw.ToString)

            SaveRetriveLayout("shutdown")

            If opener IsNot Nothing Then
                Dim type As Type = opener.GetType
                Dim method As MethodInfo = type.GetMethod("Reload")
                If method IsNot Nothing Then
                    method.Invoke(opener, New Object() {})
                End If
            End If

        End Sub

        Private Sub DataLayoutControl_ShowCustomization(sender As Object, e As EventArgs) Handles DataLayoutControl.ShowCustomization
            For Each it As DevExpress.XtraLayout.BaseLayoutItem In DataLayoutControl.Items
                it.AppearanceItemCaption.Font = Nothing
            Next
        End Sub

        Private Sub PictureEditParseEsitValue(sender As Object, e As DevExpress.XtraEditors.Controls.ConvertEditValueEventArgs)
            Dim img = DirectCast(sender, DevExpress.XtraEditors.PictureEdit)
            'If IsDBNull(img.EditValue) = False Then
            '    MsgBox(img.EditValue)
            'End If
            'If TypeOf (e.Value) Is System.Drawing.Bitmap Then
            '    e.Value = Image.FromFile(e.Value.ToString)
            '    e.Handled = True
            'End If

            'If Not (TypeOf e.Value Is BitmapImage) Then
            '    Return
            'End If
            'Dim img As BitmapImage = DirectCast(e.Value, BitmapImage)
            'Dim str As FileStream = DirectCast(img.StreamSource, FileStream)
            'MessageBox.Show(str.Name)

            If e.Value IsNot Nothing AndAlso e.Value.GetType() Is GetType(System.String) Then
                Try

                    img.EditValue = Image.FromFile(e.Value.ToString()) 'New Bitmap(e.Value.ToString())

                Catch
                    img.EditValue = Nothing
                End Try
            Else
                'img.EditValue = e.Value
            End If

        End Sub

        Private Sub LookupLinkButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
            If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
                Dim frm As New DataEntry(DirectCast(sender, DevExpress.XtraEditors.HyperLinkEdit).Tag, Nothing)
                frm.opener = Me
                frm.Show()
            End If
        End Sub

        Public Sub Reload()
            For Each child As Control In DataLayoutControl.Controls
                If child.GetType Is GetType(DevExpress.XtraEditors.LookUpEdit) Then
                    DirectCast(CType(child, DevExpress.XtraEditors.LookUpEdit).Properties.DataSource, DevExpress.Xpo.XPCollection).Reload()

                    'CType(child, DevExpress.XtraEditors.LookUpEdit).Properties.Columns(0).Visible = False
                    'CType(child, DevExpress.XtraEditors.LookUpEdit).Properties.Columns(1).Width = 150
                    CType(child, DevExpress.XtraEditors.LookUpEdit).EditValue = DirectCast(CType(child, DevExpress.XtraEditors.LookUpEdit).Properties.DataSource, DevExpress.Xpo.XPCollection).Count
                End If
            Next child
        End Sub

        Protected Overrides Function ProcessCmdKey(ByRef msg As System.Windows.Forms.Message, ByVal keyData As System.Windows.Forms.Keys) As Boolean
            Select Case keyData
                Case Keys.Escape
                    Close()
                Case Else
                    Return MyBase.ProcessCmdKey(msg, keyData)
            End Select

            Return True
        End Function

        Private Sub InitializeComponent()
            Me.DataLayoutControl = New DevExpress.XtraDataLayout.DataLayoutControl()
            Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
            Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
            Me.btnSave = New DevExpress.XtraEditors.SimpleButton()
            Me.Bar = New DevExpress.XtraEditors.PictureEdit()
            Me.FormName = New DevExpress.XtraEditors.LabelControl()
            Me.FormLogo = New DevExpress.XtraEditors.PictureEdit()
            CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.Bar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.FormLogo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'DataLayoutControl
            '
            Me.DataLayoutControl.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.DataLayoutControl.Location = New System.Drawing.Point(168, 0)
            Me.DataLayoutControl.Name = "DataLayoutControl"
            Me.DataLayoutControl.OptionsCustomizationForm.ShowPropertyGrid = True
            Me.DataLayoutControl.OptionsFocus.AllowFocusControlOnLabelClick = True
            Me.DataLayoutControl.OptionsView.AllowHotTrack = True
            Me.DataLayoutControl.OptionsView.DrawItemBorders = True
            Me.DataLayoutControl.OptionsView.HighlightFocusedItem = True
            Me.DataLayoutControl.Root = Me.LayoutControlGroup1
            Me.DataLayoutControl.Size = New System.Drawing.Size(700, 720)
            Me.DataLayoutControl.TabIndex = 0
            Me.DataLayoutControl.Text = "DataLayoutControl"
            '
            'LayoutControlGroup1
            '
            Me.LayoutControlGroup1.CustomizationFormText = "LayoutControlGroup"
            Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
            Me.LayoutControlGroup1.GroupBordersVisible = False
            Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
            Me.LayoutControlGroup1.Name = "LayoutControlGroup"
            Me.LayoutControlGroup1.Size = New System.Drawing.Size(700, 720)
            Me.LayoutControlGroup1.Text = "LayoutControlGroup"
            Me.LayoutControlGroup1.TextVisible = False
            '
            'btnClose
            '
            Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnClose.Location = New System.Drawing.Point(8, 666)
            Me.btnClose.Name = "btnClose"
            Me.btnClose.Size = New System.Drawing.Size(139, 45)
            Me.btnClose.TabIndex = 1
            Me.btnClose.Text = "Close"
            '
            'btnSave
            '
            Me.btnSave.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.btnSave.Location = New System.Drawing.Point(8, 615)
            Me.btnSave.Name = "btnSave"
            Me.btnSave.Size = New System.Drawing.Size(139, 45)
            Me.btnSave.TabIndex = 2
            Me.btnSave.Text = "Save"
            '
            'Bar
            '
            Me.Bar.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Bar.Location = New System.Drawing.Point(0, 106)
            Me.Bar.Name = "Bar"
            Me.Bar.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.Bar.Properties.Appearance.Options.UseBackColor = True
            Me.Bar.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.Bar.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
            Me.Bar.Size = New System.Drawing.Size(154, 615)
            Me.Bar.TabIndex = 4
            '
            'FormName
            '
            Me.FormName.Appearance.BackColor = System.Drawing.Color.Black
            Me.FormName.Appearance.BackColor2 = System.Drawing.Color.Transparent
            Me.FormName.Appearance.BorderColor = System.Drawing.Color.Transparent
            Me.FormName.Appearance.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.FormName.Appearance.ForeColor = System.Drawing.Color.White
            Me.FormName.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.FormName.AutoEllipsis = True
            Me.FormName.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.FormName.LineColor = System.Drawing.Color.Transparent
            Me.FormName.Location = New System.Drawing.Point(2, 110)
            Me.FormName.Name = "FormName"
            Me.FormName.Size = New System.Drawing.Size(150, 32)
            Me.FormName.TabIndex = 5
            Me.FormName.Text = "Room Types"
            '
            'FormLogo
            '
            Me.FormLogo.Location = New System.Drawing.Point(0, 0)
            Me.FormLogo.Name = "FormLogo"
            Me.FormLogo.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.FormLogo.Properties.Appearance.Options.UseBackColor = True
            Me.FormLogo.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.FormLogo.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
            Me.FormLogo.Size = New System.Drawing.Size(154, 108)
            Me.FormLogo.TabIndex = 6
            '
            'DataEntry
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(868, 719)
            Me.Controls.Add(Me.FormName)
            Me.Controls.Add(Me.btnSave)
            Me.Controls.Add(Me.btnClose)
            Me.Controls.Add(Me.DataLayoutControl)
            Me.Controls.Add(Me.Bar)
            Me.Controls.Add(Me.FormLogo)
            Me.MinimizeBox = False
            Me.Name = "DataEntry"
            Me.ShowIcon = False
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            CType(Me.DataLayoutControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.Bar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.FormLogo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

    End Class
End Namespace