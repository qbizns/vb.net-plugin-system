Imports DevExpress.Xpo
Imports DevExpress.XtraDataLayout
Imports System.Reflection
Imports DevExpress.Xpo.Metadata
Imports System.Drawing
Imports System.ComponentModel
Imports System.Text.RegularExpressions
Imports DevExpress.XtraEditors
Imports System.Windows.Forms
Imports DevExpress.Data.Filtering
Imports DevExpress.Utils.Menu
Imports DevExpress.XtraGrid.Columns

Namespace Salling.UI

    Public Class _TextEdit
        Public Sub New(ByVal MemberName As String, ByVal XpCol As xpcollection, ByVal DataLayoutControl As DataLayoutControl)
            Dim textedit As New DevExpress.XtraEditors.TextEdit()
            textedit.Name = MemberName
            textedit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", XpCol, MemberName, True))

            DataLayoutControl.AddItem(MemberName, textedit, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)
        End Sub
    End Class

    Public Class _Currency
        Public Sub New(ByVal MemberName As String, ByVal XpCol As xpcollection, ByVal DataLayoutControl As DataLayoutControl)
            Dim Currency As New DevExpress.XtraEditors.TextEdit()
            Currency.Name = MemberName

            Currency.Name = MemberName
            Currency.EditValue = "0"
            Currency.Properties.Appearance.Options.UseTextOptions = True
            Currency.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Currency.Properties.Mask.EditMask = "c2"
            Currency.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
            Currency.Properties.Mask.UseMaskAsDisplayFormat = True
            Currency.StyleController = DataLayoutControl

            Currency.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", XpCol, MemberName, True))
            DataLayoutControl.AddItem(MemberName.ToString, Currency, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)
        End Sub
    End Class

    Public Class _PictureEdit
        Public Sub New(ByVal MemberName As String, ByVal XpCol As xpcollection, ByVal DataLayoutControl As DataLayoutControl)
            Dim PictureEdit As New DevExpress.XtraEditors.PictureEdit()
            PictureEdit.Name = MemberName
            PictureEdit.Properties.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
            PictureEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", XpCol, MemberName, True))

            AddHandler PictureEdit.ParseEditValue, AddressOf PictureEditParseEsitValue

            DataLayoutControl.AddItem(MemberName, PictureEdit, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)
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

    End Class

    Public Class _MemoEdit
        Public Sub New(ByVal MemberName As String, ByVal XpCol As xpcollection, ByVal DataLayoutControl As DataLayoutControl)
            Dim MemoEdit As New DevExpress.XtraEditors.MemoEdit()
            MemoEdit.Name = MemberName
            MemoEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", XpCol, MemberName, True))

            DataLayoutControl.AddItem(MemberName, MemoEdit, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)
        End Sub
    End Class

    Public Class _CheckEdit
        Public Sub New(ByVal MemberName As String, ByVal XpCol As xpcollection, ByVal DataLayoutControl As DataLayoutControl)
            Dim CheckEdit As New DevExpress.XtraEditors.CheckEdit()
            CheckEdit.Name = MemberName
            CheckEdit.Text = ""
            CheckEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", XpCol, MemberName, True))

            DataLayoutControl.AddItem(MemberName, CheckEdit, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)
        End Sub
    End Class

    Public Class _SpinEdit
        Public Sub New(ByVal MemberName As String, ByVal XpCol As xpcollection, ByVal DataLayoutControl As DataLayoutControl)
            Dim SpinEdit As New DevExpress.XtraEditors.SpinEdit()
            SpinEdit.Name = MemberName
            SpinEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", XpCol, MemberName, True))

            DataLayoutControl.AddItem(MemberName, SpinEdit, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)
        End Sub
    End Class

    Public Class _DateEdit
        Public Sub New(ByVal MemberName As String, ByVal XpCol As xpcollection, ByVal DataLayoutControl As DataLayoutControl)
            Dim DateEdit As New DevExpress.XtraEditors.DateEdit()
            DateEdit.Name = MemberName
            DateEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", XpCol, MemberName, True))

            DataLayoutControl.AddItem(MemberName, DateEdit, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)
        End Sub
    End Class

    Public Class _GridControl
        Public Sub New(ByVal Member As XPMemberInfo, ByVal FormName As String, ByVal XpCol As xpcollection, ByVal DataLayoutControl As DataLayoutControl, _
                       ByVal uow As UnitOfWork)
            Dim GridControl As New DevExpress.XtraGrid.GridControl()
            GridControl.Name = "GridControl"
            GridControl.UseEmbeddedNavigator = True
            GridControl.DataSource = XpCol
            GridControl.DataMember = Member.MemberType.ToString.Split(".").Last.Replace("]", "s")
            GridControl.Cursor = System.Windows.Forms.Cursors.Default

            Dim GridView As New DevExpress.XtraGrid.Views.Grid.GridView()

            GridControl.MainView = GridView
            Dim xpGridcol = Salling.BASE.XPO.GetXpcollection(Member.MemberType.ToString.Split("[").Last.Replace("]", ""), uow)

            For Each GridMember As MemberInfo In Salling.BASE.XPO.GetObject(Member.MemberType.ToString.Split("[").Last.Replace("]", "")).GetMembers



                If (GridMember.MemberType.ToString = "Property") Then
                    If (GridMember.Name <> "This" And GridMember.Name <> "Loading" And GridMember.Name <> "ClassInfo" And GridMember.Name <> "Session" And GridMember.Name <> "IsLoading" And GridMember.Name <> "IsDeleted") Then
                        Dim gm As XPMemberInfo = xpGridcol.ObjectClassInfo.GetMember(GridMember.Name)

                        Dim colMessage As DevExpress.XtraGrid.Columns.GridColumn = New DevExpress.XtraGrid.Columns.GridColumn()

                        colMessage.Caption = GridMember.Name
                        If gm.MemberType.ToString.Length > 14 AndAlso gm.MemberType.ToString.Substring(0, 18) = "Salling.BASE.ORM" Then
                            colMessage.FieldName = GridMember.Name & "!Key"
                        Else
                            colMessage.FieldName = GridMember.Name
                        End If

                        colMessage.Name = "col" & GridMember.Name
                        colMessage.OptionsColumn.AllowEdit = True
                        colMessage.OptionsColumn.FixedWidth = True
                        colMessage.OptionsColumn.[ReadOnly] = False
                        colMessage.Visible = True
                        colMessage.VisibleIndex = 0

                        GridView.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {colMessage})

                        Console.WriteLine("Grid Member : " & gm.MemberType.ToString)
                        Select Case gm.MemberType.ToString
                            Case "System.DateTime"

                            Case Else

                                If gm.MemberType.ToString.Length > 14 AndAlso gm.MemberType.ToString.Substring(0, 18) = "Salling.BASE.ORM" Then

                                    Dim RepositoryItemGridLookUpEdit = New DevExpress.XtraEditors.Repository.RepositoryItemGridLookUpEdit()
                                    Dim RepositoryItemGridLookUpEditView = New DevExpress.XtraGrid.Views.Grid.GridView()

                                    RepositoryItemGridLookUpEdit.AllowDropDownWhenReadOnly = DevExpress.Utils.DefaultBoolean.[False]
                                    RepositoryItemGridLookUpEdit.AutoHeight = False
                                    RepositoryItemGridLookUpEdit.DataSource = Salling.BASE.XPO.GetXpcollection(gm.MemberType.ToString.Replace(gm.MemberType.ToString.Substring(0, 14), ""), uow)
                                    RepositoryItemGridLookUpEdit.DisplayMember = "Description"
                                    RepositoryItemGridLookUpEdit.Name = GridMember.Name & "RepositoryItemGridLookUpEdit"
                                    RepositoryItemGridLookUpEdit.ValueMember = "Oid"
                                    RepositoryItemGridLookUpEdit.View = RepositoryItemGridLookUpEditView

                                    GridControl.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {RepositoryItemGridLookUpEdit})

                                    colMessage.ColumnEdit = RepositoryItemGridLookUpEdit

                                End If

                        End Select
                    End If
                End If

            Next GridMember


            GridView.GridControl = GridControl
            ' Show Footer for the grid
            GridView.OptionsView.ShowFooter = True
            GridView.OptionsLayout.Columns.RemoveOldColumns = False
            GridView.OptionsLayout.Columns.StoreAllOptions = True
            GridView.OptionsLayout.StoreAllOptions = True
            GridView.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Grid.GridEditingMode.EditForm
            GridView.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Bottom
            GridView.OptionsView.ShowDetailButtons = False
            GridView.OptionsView.ShowGroupPanel = False
            GridView.OptionsSelection.EnableAppearanceFocusedCell = False

            'Dim s As New IO.MemoryStream()
            'GridView.SaveLayoutToStream(s)
            's.Position = 0
            'Dim r As New IO.StreamReader(s)
            'Dim layout As String = Salling.BASE.ORM.GridLayouts.CreateGridLayout(uow, FormName, Member.MemberType.ToString.Split(".").Last.Replace("]", "s"), Application.CurrentCulture.ToString, r.ReadToEnd()).LayoutData

            'Dim layouts As New IO.MemoryStream()
            'Dim layoutw As New IO.StreamWriter(layouts)
            'layoutw.AutoFlush = True
            'layoutw.Write(layout)
            'layouts.Position = 0

            ''If IO.File.Exists(GridLayoutXML) Then
            'GridView.RestoreLayoutFromStream(layouts)

            'Else
            ' Clear all GridView Columns
            ' GridView.Columns.Clear()
            ' Populate Columns depending on XpCollection displayable properties
            'GridView.PopulateColumns()
            'End If



            Dim GridLayout As Salling.BASE.ORM.GridLayouts = uow.FindObject(Of Salling.BASE.ORM.GridLayouts)(CriteriaOperator.Parse(String.Format("FormName == '{0}' AND GridName == '{1}' AND Language == '{2}'", FormName, Member.MemberType.ToString.Split(".").Last.Replace("]", "s"), Application.CurrentCulture.ToString)))
            If GridLayout Is Nothing Then
                ' Clear all GridView Columns
                GridView.Columns.Clear()
                ' Populate Columns depending on XpCollection displayable properties
                GridView.PopulateColumns()
            Else
                Dim layouts As New IO.MemoryStream()
                Dim layoutw As New IO.StreamWriter(layouts)
                layoutw.AutoFlush = True
                layoutw.Write(GridLayout.LayoutData)
                layouts.Position = 0

                'If IO.File.Exists(GridLayoutXML) Then
                GridView.RestoreLayoutFromStream(layouts)
            End If

            'GridView.PopupMenuShowing += New DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventHandler(AddressOf gridView_PopupMenuShowing)
            AddHandler GridView.PopupMenuShowing, AddressOf gridView_PopupMenuShowing
            DataLayoutControl.AddItem(Member.Name.ToString, GridControl, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)

            Dim _editbtn As New DevExpress.XtraEditors.SimpleButton
            _editbtn.Name = Member.MemberType.ToString.Split(".").Last.Replace("]", "s") + "Edit"
            _editbtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
            _editbtn.StyleController = DataLayoutControl
            _editbtn.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/format/pictureshapeoutlinecolor_32x32.png")
            _editbtn.Tag = GridControl
            _editbtn.Text = "Edit"
            AddHandler _editbtn.Click, AddressOf gridView_editbtn_Click
            DataLayoutControl.AddItem(_editbtn.Name, _editbtn, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)

            Dim _Addbtn As New DevExpress.XtraEditors.SimpleButton
            _Addbtn.Name = Member.MemberType.ToString.Split(".").Last.Replace("]", "s") + "Add"
            _Addbtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
            _Addbtn.StyleController = DataLayoutControl
            _Addbtn.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/add_32x32.png")
            _Addbtn.Tag = GridControl
            _Addbtn.Text = "Add New"
            AddHandler _Addbtn.Click, AddressOf gridView_Addbtn_Click
            DataLayoutControl.AddItem(_Addbtn.Name, _Addbtn, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)

            Dim _Delbtn As New DevExpress.XtraEditors.SimpleButton
            _Delbtn.Name = Member.MemberType.ToString.Split(".").Last.Replace("]", "s") + "Delete"
            _Delbtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
            _Delbtn.StyleController = DataLayoutControl
            _Delbtn.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/actions/cancel_32x32.png")
            _Delbtn.Tag = GridControl
            _Delbtn.Text = "Delete"
            AddHandler _Delbtn.Click, AddressOf gridView_Delbtn_Click
            DataLayoutControl.AddItem(_Delbtn.Name, _Delbtn, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)

            Dim _Filterbtn As New DevExpress.XtraEditors.SimpleButton
            _Filterbtn.Name = Member.MemberType.ToString.Split(".").Last.Replace("]", "s") + "Filterbtn"
            _Filterbtn.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter
            _Filterbtn.StyleController = DataLayoutControl
            _Filterbtn.Image = DevExpress.Images.ImageResourceCache.Default.GetImage("images/filter/filter_32x32.png")
            _Filterbtn.Tag = GridView
            _Filterbtn.Text = "Filter"
            AddHandler _Filterbtn.Click, AddressOf gridView_Filterbtn_Click
            DataLayoutControl.AddItem(_Filterbtn.Name, _Filterbtn, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)

        End Sub
        Private Sub gridView_editbtn_Click(sender As Object, e As EventArgs)
            Dim GridControl As DevExpress.XtraGrid.GridControl
            GridControl = CType(CType(sender, DevExpress.XtraEditors.SimpleButton).Tag, DevExpress.XtraGrid.GridControl)
            GridControl.EmbeddedNavigator.Buttons.DoClick(GridControl.EmbeddedNavigator.Buttons.Edit)
        End Sub

        Private Sub gridView_Addbtn_Click(sender As Object, e As EventArgs)
            Dim GridControl As DevExpress.XtraGrid.GridControl
            GridControl = CType(CType(sender, DevExpress.XtraEditors.SimpleButton).Tag, DevExpress.XtraGrid.GridControl)

            GridControl.EmbeddedNavigator.Buttons.DoClick(GridControl.EmbeddedNavigator.Buttons.Append)
            GridControl.EmbeddedNavigator.Buttons.DoClick(GridControl.EmbeddedNavigator.Buttons.Edit)
        End Sub

        Private Sub gridView_Delbtn_Click(sender As Object, e As EventArgs)
            Dim GridControl As DevExpress.XtraGrid.GridControl
            GridControl = CType(CType(sender, DevExpress.XtraEditors.SimpleButton).Tag, DevExpress.XtraGrid.GridControl)

            GridControl.EmbeddedNavigator.Buttons.DoClick(GridControl.EmbeddedNavigator.Buttons.Remove)
        End Sub

        Private Sub gridView_Filterbtn_Click(sender As Object, e As EventArgs)
            Dim GridView As DevExpress.XtraGrid.Views.Grid.GridView
            GridView = CType(CType(sender, DevExpress.XtraEditors.SimpleButton).Tag, DevExpress.XtraGrid.Views.Grid.GridView)

            GridView.OptionsView.ShowAutoFilterRow = Not GridView.OptionsView.ShowAutoFilterRow
        End Sub

        Private Sub gridView_PopupMenuShowing(sender As Object, e As DevExpress.XtraGrid.Views.Grid.PopupMenuShowingEventArgs)
            If e.MenuType = DevExpress.XtraGrid.Views.Grid.GridMenuType.Column Then
                e.Menu.Items.Add(New DevExpress.Utils.Menu.DXMenuItem("Rename column", AddressOf RenameClickEventHandler) With { _
                    .Tag = e.HitInfo.Column _
                })
            End If
        End Sub



        Public Sub RenameClickEventHandler(sender As Object, e As EventArgs)
            Dim cName As String
            cName = InputBox("Enter Column Name.", "Column Translator", " ")

            If cName = " " Then
                MessageBox.Show("You must enter a Column Name to continue.")
                Exit Sub
            ElseIf cName = "" Then
                Exit Sub
            End If

            TryCast(TryCast(sender, DXMenuItem).Tag, GridColumn).Caption = cName

        End Sub

    End Class

    Public Class _LookUpEdit
        Private Shared _uow As UnitOfWork
        <Browsable(False)> _
        Public Shared Property uow() As UnitOfWork
            Get
                Return _uow
            End Get
            Set(ByVal value As UnitOfWork)
                _uow = value
            End Set
        End Property

        Private _opener As DevExpress.XtraEditors.XtraForm
        <Browsable(False)> _
        Public Property opener() As DevExpress.XtraEditors.XtraForm
            Get
                Return _opener
            End Get
            Set(ByVal value As DevExpress.XtraEditors.XtraForm)
                _opener = value
            End Set
        End Property

        Public Sub New(ByVal Member As XPMemberInfo, ByVal XpCol As xpcollection, ByVal DataLayoutControl As DataLayoutControl, _
                       ByVal ouow As UnitOfWork, ByVal FrmOpener As DevExpress.XtraEditors.XtraForm)

            Dim regex = New Regex("\bSalling\b.*\bORM")
            Dim match = regex.Match(Member.MemberType.ToString)
            Dim _table As String = Nothing
            If match.Success Then
                _table = Member.MemberType.ToString.Replace(match.Value & ".", "")
            End If
            uow = ouow
            opener = FrmOpener
            Dim LookUpEdit As New DevExpress.XtraEditors.LookUpEdit()
            LookUpEdit.Name = Member.Name.ToString

            LookUpEdit.Properties.DataSource = Salling.BASE.XPO.GetXpcollection(Member.MemberType.ToString, ouow)
            LookUpEdit.Properties.DisplayMember = Member.Name.ToString
            LookUpEdit.Properties.ValueMember = "Oid"

            LookUpEdit.Properties.BestFitMode = DevExpress.XtraEditors.Controls.BestFitMode.BestFit


            LookUpEdit.Properties.NullText = "..."
            LookUpEdit.StyleController = DataLayoutControl
            LookUpEdit.DataBindings.Clear()
            LookUpEdit.DataBindings.Add(New System.Windows.Forms.Binding("EditValue", XpCol, Member.Name.ToString & "!Key", True))
            DataLayoutControl.AddItem(Member.Name.ToString, LookUpEdit, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)

            Dim lookuplink As New DevExpress.XtraEditors.HyperLinkEdit()
            lookuplink.EditValue = Member.Name.ToString
            lookuplink.Location = New System.Drawing.Point(525, 94)
            lookuplink.Name = "lbl" & Member.Name.ToString
            lookuplink.Properties.AllowFocused = False
            lookuplink.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            lookuplink.Properties.Appearance.Options.UseBackColor = True
            lookuplink.Properties.Appearance.Options.UseTextOptions = True
            lookuplink.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            lookuplink.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            lookuplink.Properties.BrowserWindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden
            lookuplink.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)})
            lookuplink.Tag = Member.MemberType.ToString

            DataLayoutControl.AddItem("", lookuplink, DataLayoutControl.Items(0), DevExpress.XtraLayout.Utils.InsertType.Bottom)
            AddHandler lookuplink.ButtonClick, AddressOf LookupLinkButtonClick

            AddHandler LookUpEdit.KeyDown, AddressOf LookUpEditKeyDown

        End Sub

        Private Sub LookupLinkButtonClick(sender As Object, e As DevExpress.XtraEditors.Controls.ButtonPressedEventArgs)
            If e.Button.Kind = DevExpress.XtraEditors.Controls.ButtonPredefines.Plus Then
                Dim frm As New DataEntry(uow, DirectCast(sender, DevExpress.XtraEditors.HyperLinkEdit).Tag, Nothing)
                frm.opener = opener
                frm.Show()
            End If
        End Sub

        Private Sub LookUpEditKeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs)
            Dim edit As LookUpEdit = CType(sender, LookUpEdit)
            Try
                'If GridView1.ActiveEditor.Text.Trim.Length = 0 Then
                Select Case e.KeyCode
                    Case Keys.D0, Keys.D1, Keys.D2, Keys.D3, Keys.D4, Keys.D5, Keys.D6, Keys.D7, Keys.D8, Keys.D9
                        edit.Properties.DisplayMember = "Oid"
                    Case Else
                        If Char.IsLetter(Convert.ToChar(e.KeyValue)) Then
                            edit.Properties.DisplayMember = "Text"
                        End If
                End Select
                'End If
            Catch ex As Exception

            End Try
        End Sub

    End Class

End Namespace
