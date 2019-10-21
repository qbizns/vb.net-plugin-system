Imports DevExpress.Xpo
Imports System.ComponentModel

Namespace Salling.UI
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class ListView
        Inherits DevExpress.XtraEditors.XtraForm

        Private GridListLayoutXML As String = ""

        Public _uow As UnitOfWork
        <Browsable(False)> _
        Public Property uow() As UnitOfWork
            Get
                Return _uow
            End Get
            Set(ByVal value As UnitOfWork)
                Me._uow = value
                Me._uow.TrackPropertiesModifications = False
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
                Me._xpcol.Session = Me.uow
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


        Public Sub New(ouow As UnitOfWork, table As String)
            InitializeComponent()

            'Me.MdiParent = Nav
            'Me.WindowState = FormWindowState.Maximized
            'Me.StartPosition = FormStartPosition.CenterParent

            ' Assign new UnitOfWork
            'Me.uow = ouow
            Me.uow = Salling.BASE.XPOUtils.GetNewUnitOfWork
            Me.table = table
            GridListLayoutXML = String.Format("{0}\layouts\{1}-GridList.xml", AppDomain.CurrentDomain.BaseDirectory, table)


        End Sub

        'Form overrides dispose to clean up the component list.
        <System.Diagnostics.DebuggerNonUserCode()> _
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        'Required by the Windows Form Designer
        Private components As System.ComponentModel.IContainer

        'NOTE: The following procedure is required by the Windows Form Designer
        'It can be modified using the Windows Form Designer.  
        'Do not modify it using the code editor.
        <System.Diagnostics.DebuggerStepThrough()> _
        Private Sub InitializeComponent()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ListView))
            Me.GridControl = New DevExpress.XtraGrid.GridControl()
            Me.GridView = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.SplitContainerControl1 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.BtnQuickFind = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton5 = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
            Me.BtnDelete = New DevExpress.XtraEditors.SimpleButton()
            Me.BtnEdit = New DevExpress.XtraEditors.SimpleButton()
            Me.BtnAddNew = New DevExpress.XtraEditors.SimpleButton()
            Me.SplitContainerControl2 = New DevExpress.XtraEditors.SplitContainerControl()
            Me.FilterControl = New DevExpress.XtraEditors.FilterControl()
            Me.lblTableName = New DevExpress.XtraEditors.LabelControl()
            Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.BtnExportXls = New DevExpress.XtraEditors.PictureEdit()
            Me.BtnExportDoc = New DevExpress.XtraEditors.PictureEdit()
            Me.BtnExportPdf = New DevExpress.XtraEditors.PictureEdit()
            Me.BtnPrintView = New DevExpress.XtraEditors.PictureEdit()
            Me.BtnPrint = New DevExpress.XtraEditors.PictureEdit()
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainerControl1.SuspendLayout()
            CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SplitContainerControl2.SuspendLayout()
            CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BtnExportXls.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BtnExportDoc.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BtnExportPdf.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BtnPrintView.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.BtnPrint.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'GridControl
            '
            Me.GridControl.Cursor = System.Windows.Forms.Cursors.Default
            Me.GridControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.GridControl.Location = New System.Drawing.Point(0, 0)
            Me.GridControl.MainView = Me.GridView
            Me.GridControl.Name = "GridControl"
            Me.GridControl.Size = New System.Drawing.Size(437, 274)
            Me.GridControl.TabIndex = 0
            Me.GridControl.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView})
            '
            'GridView
            '
            Me.GridView.GridControl = Me.GridControl
            Me.GridView.Name = "GridView"
            Me.GridView.OptionsView.ShowDetailButtons = False
            '
            'SplitContainerControl1
            '
            Me.SplitContainerControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.SplitContainerControl1.Location = New System.Drawing.Point(0, 49)
            Me.SplitContainerControl1.Name = "SplitContainerControl1"
            Me.SplitContainerControl1.Panel1.Controls.Add(Me.BtnQuickFind)
            Me.SplitContainerControl1.Panel1.Controls.Add(Me.SimpleButton5)
            Me.SplitContainerControl1.Panel1.Controls.Add(Me.SimpleButton4)
            Me.SplitContainerControl1.Panel1.Controls.Add(Me.BtnDelete)
            Me.SplitContainerControl1.Panel1.Controls.Add(Me.BtnEdit)
            Me.SplitContainerControl1.Panel1.Controls.Add(Me.BtnAddNew)
            Me.SplitContainerControl1.Panel1.Text = "Panel1"
            Me.SplitContainerControl1.Panel2.Controls.Add(Me.SplitContainerControl2)
            Me.SplitContainerControl1.Panel2.Text = "Panel2"
            Me.SplitContainerControl1.Size = New System.Drawing.Size(575, 359)
            Me.SplitContainerControl1.SplitterPosition = 133
            Me.SplitContainerControl1.TabIndex = 1
            Me.SplitContainerControl1.Text = "SplitContainerControl1"
            '
            'BtnQuickFind
            '
            Me.BtnQuickFind.Image = CType(resources.GetObject("BtnQuickFind.Image"), System.Drawing.Image)
            Me.BtnQuickFind.Location = New System.Drawing.Point(3, 156)
            Me.BtnQuickFind.Name = "BtnQuickFind"
            Me.BtnQuickFind.Size = New System.Drawing.Size(129, 46)
            Me.BtnQuickFind.TabIndex = 5
            Me.BtnQuickFind.Text = "Quick Find"
            '
            'SimpleButton5
            '
            Me.SimpleButton5.Image = CType(resources.GetObject("SimpleButton5.Image"), System.Drawing.Image)
            Me.SimpleButton5.Location = New System.Drawing.Point(3, 260)
            Me.SimpleButton5.Name = "SimpleButton5"
            Me.SimpleButton5.Size = New System.Drawing.Size(129, 46)
            Me.SimpleButton5.TabIndex = 4
            Me.SimpleButton5.Text = "Sort DESC"
            '
            'SimpleButton4
            '
            Me.SimpleButton4.Image = CType(resources.GetObject("SimpleButton4.Image"), System.Drawing.Image)
            Me.SimpleButton4.Location = New System.Drawing.Point(3, 208)
            Me.SimpleButton4.Name = "SimpleButton4"
            Me.SimpleButton4.Size = New System.Drawing.Size(129, 46)
            Me.SimpleButton4.TabIndex = 3
            Me.SimpleButton4.Text = "Sort ASC"
            '
            'BtnDelete
            '
            Me.BtnDelete.Image = CType(resources.GetObject("BtnDelete.Image"), System.Drawing.Image)
            Me.BtnDelete.Location = New System.Drawing.Point(3, 104)
            Me.BtnDelete.Name = "BtnDelete"
            Me.BtnDelete.Size = New System.Drawing.Size(129, 46)
            Me.BtnDelete.TabIndex = 2
            Me.BtnDelete.Text = "Delete Current"
            '
            'BtnEdit
            '
            Me.BtnEdit.Image = CType(resources.GetObject("BtnEdit.Image"), System.Drawing.Image)
            Me.BtnEdit.Location = New System.Drawing.Point(3, 52)
            Me.BtnEdit.Name = "BtnEdit"
            Me.BtnEdit.Size = New System.Drawing.Size(129, 46)
            Me.BtnEdit.TabIndex = 1
            Me.BtnEdit.Text = "Edit Current"
            '
            'BtnAddNew
            '
            Me.BtnAddNew.Image = CType(resources.GetObject("BtnAddNew.Image"), System.Drawing.Image)
            Me.BtnAddNew.Location = New System.Drawing.Point(3, 0)
            Me.BtnAddNew.Name = "BtnAddNew"
            Me.BtnAddNew.Size = New System.Drawing.Size(129, 46)
            Me.BtnAddNew.TabIndex = 0
            Me.BtnAddNew.Text = "Add New"
            '
            'SplitContainerControl2
            '
            Me.SplitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill
            Me.SplitContainerControl2.Horizontal = False
            Me.SplitContainerControl2.Location = New System.Drawing.Point(0, 0)
            Me.SplitContainerControl2.Name = "SplitContainerControl2"
            Me.SplitContainerControl2.Panel1.Controls.Add(Me.FilterControl)
            Me.SplitContainerControl2.Panel1.Text = "Panel1"
            Me.SplitContainerControl2.Panel2.Controls.Add(Me.GridControl)
            Me.SplitContainerControl2.Panel2.Text = "Panel2"
            Me.SplitContainerControl2.Size = New System.Drawing.Size(437, 359)
            Me.SplitContainerControl2.SplitterPosition = 80
            Me.SplitContainerControl2.TabIndex = 1
            Me.SplitContainerControl2.Text = "SplitContainerControl2"
            '
            'FilterControl
            '
            Me.FilterControl.Cursor = System.Windows.Forms.Cursors.Arrow
            Me.FilterControl.Dock = System.Windows.Forms.DockStyle.Fill
            Me.FilterControl.Location = New System.Drawing.Point(0, 0)
            Me.FilterControl.Name = "FilterControl"
            Me.FilterControl.Size = New System.Drawing.Size(437, 80)
            Me.FilterControl.SourceControl = Me.GridControl
            Me.FilterControl.TabIndex = 0
            Me.FilterControl.Text = "FilterControl1"
            '
            'lblTableName
            '
            Me.lblTableName.Appearance.Font = New System.Drawing.Font("Calibri", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTableName.Location = New System.Drawing.Point(60, 12)
            Me.lblTableName.Name = "lblTableName"
            Me.lblTableName.Size = New System.Drawing.Size(102, 26)
            Me.lblTableName.TabIndex = 2
            Me.lblTableName.Text = "Table Name"
            '
            'PictureEdit1
            '
            Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
            Me.PictureEdit1.Location = New System.Drawing.Point(2, 2)
            Me.PictureEdit1.Name = "PictureEdit1"
            Me.PictureEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.PictureEdit1.Size = New System.Drawing.Size(52, 43)
            Me.PictureEdit1.TabIndex = 3
            '
            'BtnExportXls
            '
            Me.BtnExportXls.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnExportXls.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnExportXls.EditValue = CType(resources.GetObject("BtnExportXls.EditValue"), Object)
            Me.BtnExportXls.Location = New System.Drawing.Point(527, 7)
            Me.BtnExportXls.Name = "BtnExportXls"
            Me.BtnExportXls.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.BtnExportXls.Size = New System.Drawing.Size(41, 36)
            Me.BtnExportXls.TabIndex = 4
            Me.BtnExportXls.ToolTip = "Export To Excel"
            '
            'BtnExportDoc
            '
            Me.BtnExportDoc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnExportDoc.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnExportDoc.EditValue = CType(resources.GetObject("BtnExportDoc.EditValue"), Object)
            Me.BtnExportDoc.Location = New System.Drawing.Point(480, 7)
            Me.BtnExportDoc.Name = "BtnExportDoc"
            Me.BtnExportDoc.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.BtnExportDoc.Size = New System.Drawing.Size(41, 36)
            Me.BtnExportDoc.TabIndex = 5
            Me.BtnExportDoc.ToolTip = "Export To Word Document"
            '
            'BtnExportPdf
            '
            Me.BtnExportPdf.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnExportPdf.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnExportPdf.EditValue = CType(resources.GetObject("BtnExportPdf.EditValue"), Object)
            Me.BtnExportPdf.Location = New System.Drawing.Point(433, 7)
            Me.BtnExportPdf.Name = "BtnExportPdf"
            Me.BtnExportPdf.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.BtnExportPdf.Size = New System.Drawing.Size(41, 36)
            Me.BtnExportPdf.TabIndex = 6
            Me.BtnExportPdf.ToolTip = "Export To PDF Document"
            '
            'BtnPrintView
            '
            Me.BtnPrintView.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnPrintView.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnPrintView.EditValue = CType(resources.GetObject("BtnPrintView.EditValue"), Object)
            Me.BtnPrintView.Location = New System.Drawing.Point(386, 7)
            Me.BtnPrintView.Name = "BtnPrintView"
            Me.BtnPrintView.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.BtnPrintView.Size = New System.Drawing.Size(41, 36)
            Me.BtnPrintView.TabIndex = 7
            Me.BtnPrintView.ToolTip = "Print Preview"
            '
            'BtnPrint
            '
            Me.BtnPrint.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.BtnPrint.Cursor = System.Windows.Forms.Cursors.Hand
            Me.BtnPrint.EditValue = CType(resources.GetObject("BtnPrint.EditValue"), Object)
            Me.BtnPrint.Location = New System.Drawing.Point(339, 7)
            Me.BtnPrint.Name = "BtnPrint"
            Me.BtnPrint.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.BtnPrint.Size = New System.Drawing.Size(41, 36)
            Me.BtnPrint.TabIndex = 8
            Me.BtnPrint.ToolTip = "Print Preview"
            '
            'ListView
            '
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(575, 408)
            Me.Controls.Add(Me.BtnPrint)
            Me.Controls.Add(Me.BtnPrintView)
            Me.Controls.Add(Me.BtnExportPdf)
            Me.Controls.Add(Me.BtnExportDoc)
            Me.Controls.Add(Me.BtnExportXls)
            Me.Controls.Add(Me.PictureEdit1)
            Me.Controls.Add(Me.lblTableName)
            Me.Controls.Add(Me.SplitContainerControl1)
            Me.Name = "ListView"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
            Me.Text = "ListView"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            CType(Me.GridControl, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.SplitContainerControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainerControl1.ResumeLayout(False)
            CType(Me.SplitContainerControl2, System.ComponentModel.ISupportInitialize).EndInit()
            Me.SplitContainerControl2.ResumeLayout(False)
            CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BtnExportXls.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BtnExportDoc.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BtnExportPdf.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BtnPrintView.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.BtnPrint.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
            Me.PerformLayout()

        End Sub
        Friend WithEvents GridControl As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents SplitContainerControl1 As DevExpress.XtraEditors.SplitContainerControl
        Friend WithEvents lblTableName As DevExpress.XtraEditors.LabelControl
        Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
        Friend WithEvents SimpleButton5 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents BtnDelete As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents BtnEdit As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents BtnAddNew As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents BtnQuickFind As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents BtnExportXls As DevExpress.XtraEditors.PictureEdit
        Friend WithEvents BtnExportDoc As DevExpress.XtraEditors.PictureEdit
        Friend WithEvents BtnExportPdf As DevExpress.XtraEditors.PictureEdit
        Friend WithEvents BtnPrintView As DevExpress.XtraEditors.PictureEdit
        Friend WithEvents SplitContainerControl2 As DevExpress.XtraEditors.SplitContainerControl
        Friend WithEvents FilterControl As DevExpress.XtraEditors.FilterControl
        Friend WithEvents BtnPrint As DevExpress.XtraEditors.PictureEdit
    End Class
End Namespace