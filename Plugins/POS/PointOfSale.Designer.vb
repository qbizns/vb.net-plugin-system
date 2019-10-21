Imports DevExpress.Xpo
Imports System.ComponentModel
Namespace Salling.Plugins
    <Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
    Partial Class PointOfSale
        Inherits DevExpress.XtraEditors.XtraForm

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

        Public Sub New(ouow As UnitOfWork)
            InitializeComponent()
            Me.uow = ouow
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
            Me.components = New System.ComponentModel.Container()
            Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PointOfSale))
            Dim EaN13Generator1 As DevExpress.XtraPrinting.BarCode.EAN13Generator = New DevExpress.XtraPrinting.BarCode.EAN13Generator()
            Me.Panel1 = New System.Windows.Forms.Panel()
            Me.PictureEdit2 = New DevExpress.XtraEditors.PictureEdit()
            Me.LblTime = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
            Me.PictureEdit1 = New DevExpress.XtraEditors.PictureEdit()
            Me.lblSecond = New DevExpress.XtraEditors.LabelControl()
            Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.Item = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.Qty = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.Price = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.Discount = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.SubTotal = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.BarCodeControl1 = New DevExpress.XtraEditors.BarCodeControl()
            Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
            Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
            Me.lblTotal = New DevExpress.XtraEditors.LabelControl()
            Me.Panel2 = New System.Windows.Forms.Panel()
            Me.Panel3 = New System.Windows.Forms.Panel()
            Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
            Me.Panel4 = New System.Windows.Forms.Panel()
            Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
            Me.LblItemCount = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl5 = New DevExpress.XtraEditors.LabelControl()
            Me.lblTotalDiscount = New DevExpress.XtraEditors.LabelControl()
            Me.Panel5 = New System.Windows.Forms.Panel()
            Me.Panel6 = New System.Windows.Forms.Panel()
            Me.LabelControl6 = New DevExpress.XtraEditors.LabelControl()
            Me.LblQtyTotal = New DevExpress.XtraEditors.LabelControl()
            Me.Panel7 = New System.Windows.Forms.Panel()
            Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
            Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.ItemID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ItemName = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.ItemPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.PnlStatistics = New DevExpress.XtraEditors.GroupControl()
            Me.lblItemQty = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
            Me.lblPriceMissing = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
            Me.lblBarcodeMissing = New DevExpress.XtraEditors.LabelControl()
            Me.LabelControl7 = New DevExpress.XtraEditors.LabelControl()
            Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
            Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
            Me.PnlPayment = New System.Windows.Forms.Panel()
            Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
            Me.txtPaymentChange = New DevExpress.XtraEditors.TextEdit()
            Me.txtPaymentTotal = New DevExpress.XtraEditors.TextEdit()
            Me.txtPaymentPaid = New DevExpress.XtraEditors.TextEdit()
            Me.Panel1.SuspendLayout()
            CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.Panel3.SuspendLayout()
            Me.Panel4.SuspendLayout()
            Me.Panel5.SuspendLayout()
            Me.Panel6.SuspendLayout()
            CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.PnlStatistics, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.PnlStatistics.SuspendLayout()
            Me.PnlPayment.SuspendLayout()
            CType(Me.txtPaymentChange.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPaymentTotal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            CType(Me.txtPaymentPaid.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            '
            'Panel1
            '
            Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.Panel1.Controls.Add(Me.PictureEdit2)
            Me.Panel1.Controls.Add(Me.LblTime)
            Me.Panel1.Controls.Add(Me.LabelControl2)
            Me.Panel1.Controls.Add(Me.LabelControl1)
            Me.Panel1.Controls.Add(Me.PictureEdit1)
            Me.Panel1.Controls.Add(Me.lblSecond)
            Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
            Me.Panel1.Location = New System.Drawing.Point(0, 0)
            Me.Panel1.Name = "Panel1"
            Me.Panel1.Size = New System.Drawing.Size(1370, 75)
            Me.Panel1.TabIndex = 0
            '
            'PictureEdit2
            '
            Me.PictureEdit2.Cursor = System.Windows.Forms.Cursors.Hand
            Me.PictureEdit2.EditValue = CType(resources.GetObject("PictureEdit2.EditValue"), Object)
            Me.PictureEdit2.Location = New System.Drawing.Point(181, 3)
            Me.PictureEdit2.Name = "PictureEdit2"
            Me.PictureEdit2.Properties.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.PictureEdit2.Properties.Appearance.Options.UseBackColor = True
            Me.PictureEdit2.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.PictureEdit2.Size = New System.Drawing.Size(48, 38)
            Me.PictureEdit2.TabIndex = 5
            '
            'LblTime
            '
            Me.LblTime.Appearance.Font = New System.Drawing.Font("Calibri", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblTime.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
            Me.LblTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LblTime.AutoEllipsis = True
            Me.LblTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.LblTime.Location = New System.Drawing.Point(3, 3)
            Me.LblTime.Name = "LblTime"
            Me.LblTime.Size = New System.Drawing.Size(134, 69)
            Me.LblTime.TabIndex = 3
            Me.LblTime.Text = "00:00"
            '
            'LabelControl2
            '
            Me.LabelControl2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Me.LabelControl2.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
            Me.LabelControl2.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelControl2.AutoEllipsis = True
            Me.LabelControl2.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.LabelControl2.Location = New System.Drawing.Point(1023, 46)
            Me.LabelControl2.Name = "LabelControl2"
            Me.LabelControl2.Size = New System.Drawing.Size(256, 26)
            Me.LabelControl2.TabIndex = 2
            Me.LabelControl2.Text = "نقطة بيع رقم : 1"
            '
            'LabelControl1
            '
            Me.LabelControl1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Times New Roman", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Me.LabelControl1.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
            Me.LabelControl1.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelControl1.AutoEllipsis = True
            Me.LabelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.LabelControl1.Location = New System.Drawing.Point(1023, 12)
            Me.LabelControl1.Name = "LabelControl1"
            Me.LabelControl1.Size = New System.Drawing.Size(256, 26)
            Me.LabelControl1.TabIndex = 1
            Me.LabelControl1.Text = "أحمد سعد"
            '
            'PictureEdit1
            '
            Me.PictureEdit1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PictureEdit1.EditValue = CType(resources.GetObject("PictureEdit1.EditValue"), Object)
            Me.PictureEdit1.Location = New System.Drawing.Point(1285, 3)
            Me.PictureEdit1.Name = "PictureEdit1"
            Me.PictureEdit1.Size = New System.Drawing.Size(82, 69)
            Me.PictureEdit1.TabIndex = 1
            '
            'lblSecond
            '
            Me.lblSecond.Appearance.Font = New System.Drawing.Font("Calibri", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblSecond.Appearance.ForeColor = System.Drawing.Color.Gray
            Me.lblSecond.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.lblSecond.AutoEllipsis = True
            Me.lblSecond.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblSecond.Location = New System.Drawing.Point(126, 34)
            Me.lblSecond.Name = "lblSecond"
            Me.lblSecond.Size = New System.Drawing.Size(38, 23)
            Me.lblSecond.TabIndex = 4
            Me.lblSecond.Text = "15"
            '
            'GridControl1
            '
            Me.GridControl1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.GridControl1.Location = New System.Drawing.Point(12, 165)
            Me.GridControl1.MainView = Me.GridView1
            Me.GridControl1.Name = "GridControl1"
            Me.GridControl1.Size = New System.Drawing.Size(800, 441)
            Me.GridControl1.TabIndex = 1
            Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
            '
            'GridView1
            '
            Me.GridView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.Item, Me.Qty, Me.Price, Me.Discount, Me.SubTotal})
            Me.GridView1.GridControl = Me.GridControl1
            Me.GridView1.Name = "GridView1"
            Me.GridView1.OptionsBehavior.AutoSelectAllInEditor = False
            Me.GridView1.OptionsSelection.EnableAppearanceFocusedCell = False
            Me.GridView1.OptionsSelection.EnableAppearanceFocusedRow = False
            Me.GridView1.OptionsSelection.EnableAppearanceHideSelection = False
            Me.GridView1.OptionsSelection.UseIndicatorForSelection = False
            Me.GridView1.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
            Me.GridView1.OptionsView.ShowGroupPanel = False
            Me.GridView1.OptionsView.ShowIndicator = False
            '
            'Item
            '
            Me.Item.AppearanceCell.Options.UseTextOptions = True
            Me.Item.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Item.AppearanceHeader.Options.UseTextOptions = True
            Me.Item.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.Item.Caption = "الصنف"
            Me.Item.FieldName = "ArItemName"
            Me.Item.Name = "Item"
            Me.Item.OptionsColumn.AllowEdit = False
            Me.Item.OptionsColumn.AllowFocus = False
            Me.Item.OptionsColumn.AllowSize = False
            Me.Item.OptionsColumn.FixedWidth = True
            Me.Item.Visible = True
            Me.Item.VisibleIndex = 4
            Me.Item.Width = 440
            '
            'Qty
            '
            Me.Qty.AppearanceCell.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Qty.AppearanceCell.Options.UseFont = True
            Me.Qty.AppearanceCell.Options.UseTextOptions = True
            Me.Qty.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.Qty.AppearanceHeader.Options.UseTextOptions = True
            Me.Qty.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.Qty.Caption = "الكمية"
            Me.Qty.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
            Me.Qty.FieldName = "Qty"
            Me.Qty.Name = "Qty"
            Me.Qty.OptionsColumn.AllowEdit = False
            Me.Qty.OptionsColumn.AllowFocus = False
            Me.Qty.OptionsColumn.AllowSize = False
            Me.Qty.OptionsColumn.FixedWidth = True
            Me.Qty.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
            Me.Qty.Visible = True
            Me.Qty.VisibleIndex = 3
            Me.Qty.Width = 81
            '
            'Price
            '
            Me.Price.AppearanceCell.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Price.AppearanceCell.Options.UseFont = True
            Me.Price.AppearanceCell.Options.UseTextOptions = True
            Me.Price.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.Price.AppearanceHeader.Options.UseTextOptions = True
            Me.Price.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.Price.Caption = "السعر"
            Me.Price.DisplayFormat.FormatString = "c2"
            Me.Price.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.Price.FieldName = "Price"
            Me.Price.Name = "Price"
            Me.Price.OptionsColumn.AllowEdit = False
            Me.Price.OptionsColumn.AllowFocus = False
            Me.Price.OptionsColumn.AllowSize = False
            Me.Price.OptionsColumn.FixedWidth = True
            Me.Price.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
            Me.Price.Visible = True
            Me.Price.VisibleIndex = 2
            Me.Price.Width = 76
            '
            'Discount
            '
            Me.Discount.AppearanceCell.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Discount.AppearanceCell.Options.UseFont = True
            Me.Discount.AppearanceCell.Options.UseTextOptions = True
            Me.Discount.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.Discount.AppearanceHeader.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.Discount.AppearanceHeader.Options.UseFont = True
            Me.Discount.AppearanceHeader.Options.UseTextOptions = True
            Me.Discount.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.Discount.Caption = "الخصم"
            Me.Discount.DisplayFormat.FormatString = "c2"
            Me.Discount.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.Discount.FieldName = "Discount"
            Me.Discount.Name = "Discount"
            Me.Discount.OptionsColumn.AllowEdit = False
            Me.Discount.OptionsColumn.AllowFocus = False
            Me.Discount.OptionsColumn.AllowSize = False
            Me.Discount.OptionsColumn.FixedWidth = True
            Me.Discount.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
            Me.Discount.Visible = True
            Me.Discount.VisibleIndex = 1
            Me.Discount.Width = 85
            '
            'SubTotal
            '
            Me.SubTotal.AppearanceCell.BackColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(56, Byte), Integer))
            Me.SubTotal.AppearanceCell.Font = New System.Drawing.Font("Courier New", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.SubTotal.AppearanceCell.ForeColor = System.Drawing.Color.White
            Me.SubTotal.AppearanceCell.Options.UseBackColor = True
            Me.SubTotal.AppearanceCell.Options.UseFont = True
            Me.SubTotal.AppearanceCell.Options.UseForeColor = True
            Me.SubTotal.AppearanceCell.Options.UseTextOptions = True
            Me.SubTotal.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.SubTotal.AppearanceHeader.Options.UseTextOptions = True
            Me.SubTotal.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.SubTotal.Caption = "المجموع"
            Me.SubTotal.DisplayFormat.FormatString = "c2"
            Me.SubTotal.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.SubTotal.FieldName = "SubTotal"
            Me.SubTotal.Name = "SubTotal"
            Me.SubTotal.OptionsColumn.AllowEdit = False
            Me.SubTotal.OptionsColumn.AllowFocus = False
            Me.SubTotal.OptionsColumn.AllowSize = False
            Me.SubTotal.OptionsColumn.FixedWidth = True
            Me.SubTotal.UnboundType = DevExpress.Data.UnboundColumnType.[Decimal]
            Me.SubTotal.Visible = True
            Me.SubTotal.VisibleIndex = 0
            Me.SubTotal.Width = 100
            '
            'BarCodeControl1
            '
            Me.BarCodeControl1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.BarCodeControl1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.BarCodeControl1.HorizontalTextAlignment = DevExpress.Utils.HorzAlignment.[Default]
            Me.BarCodeControl1.Location = New System.Drawing.Point(594, 81)
            Me.BarCodeControl1.Name = "BarCodeControl1"
            Me.BarCodeControl1.Padding = New System.Windows.Forms.Padding(10, 2, 10, 0)
            Me.BarCodeControl1.Size = New System.Drawing.Size(235, 78)
            Me.BarCodeControl1.Symbology = EaN13Generator1
            Me.BarCodeControl1.TabIndex = 2
            '
            'TextEdit1
            '
            Me.TextEdit1.EditValue = ""
            Me.TextEdit1.Location = New System.Drawing.Point(12, 81)
            Me.TextEdit1.Name = "TextEdit1"
            Me.TextEdit1.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.TextEdit1.Properties.Appearance.Options.UseFont = True
            Me.TextEdit1.Properties.Appearance.Options.UseTextOptions = True
            Me.TextEdit1.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.TextEdit1.Properties.AutoHeight = False
            Me.TextEdit1.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat
            Me.TextEdit1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
            Me.TextEdit1.Size = New System.Drawing.Size(591, 78)
            Me.TextEdit1.TabIndex = 3
            '
            'Timer1
            '
            Me.Timer1.Enabled = True
            Me.Timer1.Interval = 1000
            '
            'lblTotal
            '
            Me.lblTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblTotal.Appearance.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotal.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(56, Byte), Integer))
            Me.lblTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.lblTotal.AutoEllipsis = True
            Me.lblTotal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblTotal.Location = New System.Drawing.Point(3, 25)
            Me.lblTotal.Name = "lblTotal"
            Me.lblTotal.Size = New System.Drawing.Size(295, 47)
            Me.lblTotal.TabIndex = 5
            Me.lblTotal.Text = "0.00"
            '
            'Panel2
            '
            Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Panel2.Location = New System.Drawing.Point(817, 84)
            Me.Panel2.Name = "Panel2"
            Me.Panel2.Size = New System.Drawing.Size(1, 679)
            Me.Panel2.TabIndex = 6
            '
            'Panel3
            '
            Me.Panel3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.Panel3.Controls.Add(Me.lblTotal)
            Me.Panel3.Controls.Add(Me.LabelControl4)
            Me.Panel3.Location = New System.Drawing.Point(12, 688)
            Me.Panel3.Name = "Panel3"
            Me.Panel3.Size = New System.Drawing.Size(304, 75)
            Me.Panel3.TabIndex = 7
            '
            'LabelControl4
            '
            Me.LabelControl4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.LabelControl4.Appearance.BackColor = System.Drawing.Color.Transparent
            Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Me.LabelControl4.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.LabelControl4.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelControl4.AutoEllipsis = True
            Me.LabelControl4.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.LabelControl4.Location = New System.Drawing.Point(96, 3)
            Me.LabelControl4.Name = "LabelControl4"
            Me.LabelControl4.Size = New System.Drawing.Size(202, 26)
            Me.LabelControl4.TabIndex = 8
            Me.LabelControl4.Text = "إجمالى الفاتورة"
            '
            'Panel4
            '
            Me.Panel4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.Panel4.Controls.Add(Me.LabelControl3)
            Me.Panel4.Controls.Add(Me.LblItemCount)
            Me.Panel4.Location = New System.Drawing.Point(676, 688)
            Me.Panel4.Name = "Panel4"
            Me.Panel4.Size = New System.Drawing.Size(136, 75)
            Me.Panel4.TabIndex = 9
            '
            'LabelControl3
            '
            Me.LabelControl3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.LabelControl3.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Me.LabelControl3.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.LabelControl3.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelControl3.AutoEllipsis = True
            Me.LabelControl3.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.LabelControl3.Location = New System.Drawing.Point(3, 3)
            Me.LabelControl3.Name = "LabelControl3"
            Me.LabelControl3.Size = New System.Drawing.Size(123, 26)
            Me.LabelControl3.TabIndex = 8
            Me.LabelControl3.Text = "عدد الإصناف"
            '
            'LblItemCount
            '
            Me.LblItemCount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.LblItemCount.Appearance.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblItemCount.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(131, Byte), Integer))
            Me.LblItemCount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.LblItemCount.AutoEllipsis = True
            Me.LblItemCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.LblItemCount.Location = New System.Drawing.Point(3, 25)
            Me.LblItemCount.Name = "LblItemCount"
            Me.LblItemCount.Size = New System.Drawing.Size(130, 49)
            Me.LblItemCount.TabIndex = 5
            Me.LblItemCount.Text = "0"
            '
            'LabelControl5
            '
            Me.LabelControl5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.LabelControl5.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.LabelControl5.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Me.LabelControl5.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.LabelControl5.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelControl5.AutoEllipsis = True
            Me.LabelControl5.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.LabelControl5.Location = New System.Drawing.Point(64, 3)
            Me.LabelControl5.Name = "LabelControl5"
            Me.LabelControl5.Size = New System.Drawing.Size(141, 26)
            Me.LabelControl5.TabIndex = 8
            Me.LabelControl5.Text = "إجمالى الخصم"
            '
            'lblTotalDiscount
            '
            Me.lblTotalDiscount.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.lblTotalDiscount.Appearance.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.lblTotalDiscount.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(63, Byte), Integer), CType(CType(170, Byte), Integer), CType(CType(226, Byte), Integer))
            Me.lblTotalDiscount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.lblTotalDiscount.AutoEllipsis = True
            Me.lblTotalDiscount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblTotalDiscount.Location = New System.Drawing.Point(3, 25)
            Me.lblTotalDiscount.Name = "lblTotalDiscount"
            Me.lblTotalDiscount.Size = New System.Drawing.Size(204, 49)
            Me.lblTotalDiscount.TabIndex = 5
            Me.lblTotalDiscount.Text = "0.00"
            '
            'Panel5
            '
            Me.Panel5.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.Panel5.Controls.Add(Me.LabelControl5)
            Me.Panel5.Controls.Add(Me.lblTotalDiscount)
            Me.Panel5.Location = New System.Drawing.Point(319, 688)
            Me.Panel5.Name = "Panel5"
            Me.Panel5.Size = New System.Drawing.Size(208, 75)
            Me.Panel5.TabIndex = 10
            '
            'Panel6
            '
            Me.Panel6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Panel6.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.Panel6.Controls.Add(Me.LabelControl6)
            Me.Panel6.Controls.Add(Me.LblQtyTotal)
            Me.Panel6.Location = New System.Drawing.Point(532, 688)
            Me.Panel6.Name = "Panel6"
            Me.Panel6.Size = New System.Drawing.Size(139, 75)
            Me.Panel6.TabIndex = 11
            '
            'LabelControl6
            '
            Me.LabelControl6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.LabelControl6.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
            Me.LabelControl6.Appearance.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(178, Byte))
            Me.LabelControl6.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.LabelControl6.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.LabelControl6.AutoEllipsis = True
            Me.LabelControl6.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.LabelControl6.Location = New System.Drawing.Point(3, 3)
            Me.LabelControl6.Name = "LabelControl6"
            Me.LabelControl6.Size = New System.Drawing.Size(127, 26)
            Me.LabelControl6.TabIndex = 8
            Me.LabelControl6.Text = "إجمالى الكميات"
            '
            'LblQtyTotal
            '
            Me.LblQtyTotal.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.LblQtyTotal.Appearance.Font = New System.Drawing.Font("Courier New", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.LblQtyTotal.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.LblQtyTotal.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.LblQtyTotal.AutoEllipsis = True
            Me.LblQtyTotal.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.LblQtyTotal.Location = New System.Drawing.Point(3, 25)
            Me.LblQtyTotal.Name = "LblQtyTotal"
            Me.LblQtyTotal.Size = New System.Drawing.Size(133, 49)
            Me.LblQtyTotal.TabIndex = 5
            Me.LblQtyTotal.Text = "0"
            '
            'Panel7
            '
            Me.Panel7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.Panel7.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
            Me.Panel7.Location = New System.Drawing.Point(12, 610)
            Me.Panel7.Name = "Panel7"
            Me.Panel7.Size = New System.Drawing.Size(800, 1)
            Me.Panel7.TabIndex = 12
            '
            'GridControl2
            '
            Me.GridControl2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.GridControl2.Location = New System.Drawing.Point(18, 170)
            Me.GridControl2.MainView = Me.GridView2
            Me.GridControl2.Name = "GridControl2"
            Me.GridControl2.Size = New System.Drawing.Size(800, 441)
            Me.GridControl2.TabIndex = 13
            Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
            Me.GridControl2.Visible = False
            '
            'GridView2
            '
            Me.GridView2.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.GridView2.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.ItemID, Me.ItemName, Me.ItemPrice})
            Me.GridView2.GridControl = Me.GridControl2
            Me.GridView2.Name = "GridView2"
            Me.GridView2.OptionsBehavior.AutoSelectAllInEditor = False
            Me.GridView2.OptionsView.ColumnHeaderAutoHeight = DevExpress.Utils.DefaultBoolean.[True]
            Me.GridView2.OptionsView.ShowGroupPanel = False
            Me.GridView2.OptionsView.ShowIndicator = False
            '
            'ItemID
            '
            Me.ItemID.Caption = "الكود"
            Me.ItemID.FieldName = "OID"
            Me.ItemID.Name = "ItemID"
            '
            'ItemName
            '
            Me.ItemName.AppearanceCell.Options.UseTextOptions = True
            Me.ItemName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.ItemName.AppearanceHeader.Options.UseTextOptions = True
            Me.ItemName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.ItemName.Caption = "الصنف"
            Me.ItemName.FieldName = "ArItemName"
            Me.ItemName.Name = "ItemName"
            Me.ItemName.OptionsColumn.AllowEdit = False
            Me.ItemName.OptionsColumn.AllowSize = False
            Me.ItemName.OptionsColumn.FixedWidth = True
            Me.ItemName.Visible = True
            Me.ItemName.VisibleIndex = 1
            Me.ItemName.Width = 440
            '
            'ItemPrice
            '
            Me.ItemPrice.AppearanceCell.Font = New System.Drawing.Font("Courier New", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.ItemPrice.AppearanceCell.Options.UseFont = True
            Me.ItemPrice.AppearanceCell.Options.UseTextOptions = True
            Me.ItemPrice.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ItemPrice.AppearanceHeader.Options.UseTextOptions = True
            Me.ItemPrice.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
            Me.ItemPrice.Caption = "السعر"
            Me.ItemPrice.DisplayFormat.FormatString = "c2"
            Me.ItemPrice.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
            Me.ItemPrice.FieldName = "Price"
            Me.ItemPrice.Name = "ItemPrice"
            Me.ItemPrice.OptionsColumn.AllowEdit = False
            Me.ItemPrice.OptionsColumn.AllowFocus = False
            Me.ItemPrice.OptionsColumn.AllowSize = False
            Me.ItemPrice.OptionsColumn.FixedWidth = True
            Me.ItemPrice.Visible = True
            Me.ItemPrice.VisibleIndex = 0
            Me.ItemPrice.Width = 76
            '
            'PnlStatistics
            '
            Me.PnlStatistics.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.PnlStatistics.AppearanceCaption.Options.UseTextOptions = True
            Me.PnlStatistics.AppearanceCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.PnlStatistics.Controls.Add(Me.lblItemQty)
            Me.PnlStatistics.Controls.Add(Me.LabelControl10)
            Me.PnlStatistics.Controls.Add(Me.lblPriceMissing)
            Me.PnlStatistics.Controls.Add(Me.LabelControl9)
            Me.PnlStatistics.Controls.Add(Me.lblBarcodeMissing)
            Me.PnlStatistics.Controls.Add(Me.LabelControl7)
            Me.PnlStatistics.Location = New System.Drawing.Point(835, 84)
            Me.PnlStatistics.Name = "PnlStatistics"
            Me.PnlStatistics.Size = New System.Drawing.Size(523, 200)
            Me.PnlStatistics.TabIndex = 14
            Me.PnlStatistics.Text = "إحصائيات"
            '
            'lblItemQty
            '
            Me.lblItemQty.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.lblItemQty.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblItemQty.Location = New System.Drawing.Point(265, 43)
            Me.lblItemQty.Name = "lblItemQty"
            Me.lblItemQty.Size = New System.Drawing.Size(93, 13)
            Me.lblItemQty.TabIndex = 5
            Me.lblItemQty.Text = "0"
            '
            'LabelControl10
            '
            Me.LabelControl10.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.LabelControl10.Location = New System.Drawing.Point(364, 43)
            Me.LabelControl10.Name = "LabelControl10"
            Me.LabelControl10.Size = New System.Drawing.Size(154, 13)
            Me.LabelControl10.TabIndex = 4
            Me.LabelControl10.Text = ": إجمالى الأصناف"
            '
            'lblPriceMissing
            '
            Me.lblPriceMissing.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.lblPriceMissing.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblPriceMissing.Location = New System.Drawing.Point(265, 81)
            Me.lblPriceMissing.Name = "lblPriceMissing"
            Me.lblPriceMissing.Size = New System.Drawing.Size(93, 13)
            Me.lblPriceMissing.TabIndex = 3
            Me.lblPriceMissing.Text = "0"
            '
            'LabelControl9
            '
            Me.LabelControl9.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.LabelControl9.Location = New System.Drawing.Point(364, 81)
            Me.LabelControl9.Name = "LabelControl9"
            Me.LabelControl9.Size = New System.Drawing.Size(154, 13)
            Me.LabelControl9.TabIndex = 2
            Me.LabelControl9.Text = ": أصناف بدون سعر"
            '
            'lblBarcodeMissing
            '
            Me.lblBarcodeMissing.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far
            Me.lblBarcodeMissing.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.lblBarcodeMissing.Location = New System.Drawing.Point(265, 62)
            Me.lblBarcodeMissing.Name = "lblBarcodeMissing"
            Me.lblBarcodeMissing.Size = New System.Drawing.Size(93, 13)
            Me.lblBarcodeMissing.TabIndex = 1
            Me.lblBarcodeMissing.Text = "0"
            '
            'LabelControl7
            '
            Me.LabelControl7.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None
            Me.LabelControl7.Location = New System.Drawing.Point(364, 62)
            Me.LabelControl7.Name = "LabelControl7"
            Me.LabelControl7.Size = New System.Drawing.Size(154, 13)
            Me.LabelControl7.TabIndex = 0
            Me.LabelControl7.Text = ": أصناف بدون باركود"
            '
            'SimpleButton1
            '
            Me.SimpleButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.SimpleButton1.Location = New System.Drawing.Point(676, 617)
            Me.SimpleButton1.Name = "SimpleButton1"
            Me.SimpleButton1.Size = New System.Drawing.Size(136, 28)
            Me.SimpleButton1.TabIndex = 15
            Me.SimpleButton1.Text = "دفع"
            '
            'SimpleButton2
            '
            Me.SimpleButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
            Me.SimpleButton2.Location = New System.Drawing.Point(676, 651)
            Me.SimpleButton2.Name = "SimpleButton2"
            Me.SimpleButton2.Size = New System.Drawing.Size(136, 31)
            Me.SimpleButton2.TabIndex = 16
            Me.SimpleButton2.Text = "تعليق الفاتورة"
            '
            'PnlPayment
            '
            Me.PnlPayment.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
            Me.PnlPayment.Controls.Add(Me.LabelControl8)
            Me.PnlPayment.Controls.Add(Me.txtPaymentChange)
            Me.PnlPayment.Controls.Add(Me.txtPaymentTotal)
            Me.PnlPayment.Controls.Add(Me.txtPaymentPaid)
            Me.PnlPayment.Location = New System.Drawing.Point(345, 87)
            Me.PnlPayment.Name = "PnlPayment"
            Me.PnlPayment.Size = New System.Drawing.Size(639, 495)
            Me.PnlPayment.TabIndex = 17
            Me.PnlPayment.Visible = False
            '
            'LabelControl8
            '
            Me.LabelControl8.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.LabelControl8.Location = New System.Drawing.Point(303, 289)
            Me.LabelControl8.Name = "LabelControl8"
            Me.LabelControl8.Size = New System.Drawing.Size(36, 13)
            Me.LabelControl8.TabIndex = 3
            Me.LabelControl8.Text = "المتبقى"
            '
            'txtPaymentChange
            '
            Me.txtPaymentChange.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPaymentChange.EditValue = "0.00"
            Me.txtPaymentChange.Enabled = False
            Me.txtPaymentChange.Location = New System.Drawing.Point(44, 308)
            Me.txtPaymentChange.Name = "txtPaymentChange"
            Me.txtPaymentChange.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
            Me.txtPaymentChange.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPaymentChange.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(205, Byte), Integer), CType(CType(79, Byte), Integer), CType(CType(56, Byte), Integer))
            Me.txtPaymentChange.Properties.Appearance.Options.UseBackColor = True
            Me.txtPaymentChange.Properties.Appearance.Options.UseFont = True
            Me.txtPaymentChange.Properties.Appearance.Options.UseForeColor = True
            Me.txtPaymentChange.Properties.Appearance.Options.UseTextOptions = True
            Me.txtPaymentChange.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.txtPaymentChange.Properties.AutoHeight = False
            Me.txtPaymentChange.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.txtPaymentChange.Size = New System.Drawing.Size(551, 108)
            Me.txtPaymentChange.TabIndex = 2
            '
            'txtPaymentTotal
            '
            Me.txtPaymentTotal.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPaymentTotal.EditValue = "0.00"
            Me.txtPaymentTotal.Enabled = False
            Me.txtPaymentTotal.Location = New System.Drawing.Point(44, 41)
            Me.txtPaymentTotal.Name = "txtPaymentTotal"
            Me.txtPaymentTotal.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
            Me.txtPaymentTotal.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPaymentTotal.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(47, Byte), Integer), CType(CType(210, Byte), Integer), CType(CType(131, Byte), Integer))
            Me.txtPaymentTotal.Properties.Appearance.Options.UseBackColor = True
            Me.txtPaymentTotal.Properties.Appearance.Options.UseFont = True
            Me.txtPaymentTotal.Properties.Appearance.Options.UseForeColor = True
            Me.txtPaymentTotal.Properties.Appearance.Options.UseTextOptions = True
            Me.txtPaymentTotal.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.txtPaymentTotal.Properties.AutoHeight = False
            Me.txtPaymentTotal.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.txtPaymentTotal.Size = New System.Drawing.Size(551, 108)
            Me.txtPaymentTotal.TabIndex = 1
            '
            'txtPaymentPaid
            '
            Me.txtPaymentPaid.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
            Me.txtPaymentPaid.EditValue = "0.00"
            Me.txtPaymentPaid.Location = New System.Drawing.Point(44, 168)
            Me.txtPaymentPaid.Name = "txtPaymentPaid"
            Me.txtPaymentPaid.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(241, Byte), Integer))
            Me.txtPaymentPaid.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
            Me.txtPaymentPaid.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer), CType(CType(45, Byte), Integer))
            Me.txtPaymentPaid.Properties.Appearance.Options.UseBackColor = True
            Me.txtPaymentPaid.Properties.Appearance.Options.UseFont = True
            Me.txtPaymentPaid.Properties.Appearance.Options.UseForeColor = True
            Me.txtPaymentPaid.Properties.Appearance.Options.UseTextOptions = True
            Me.txtPaymentPaid.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            Me.txtPaymentPaid.Properties.AutoHeight = False
            Me.txtPaymentPaid.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
            Me.txtPaymentPaid.Size = New System.Drawing.Size(551, 108)
            Me.txtPaymentPaid.TabIndex = 0
            '
            'PointOfSale
            '
            Me.Appearance.BackColor = System.Drawing.Color.White
            Me.Appearance.Options.UseBackColor = True
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(1370, 772)
            Me.Controls.Add(Me.PnlPayment)
            Me.Controls.Add(Me.SimpleButton2)
            Me.Controls.Add(Me.SimpleButton1)
            Me.Controls.Add(Me.PnlStatistics)
            Me.Controls.Add(Me.Panel7)
            Me.Controls.Add(Me.Panel6)
            Me.Controls.Add(Me.Panel5)
            Me.Controls.Add(Me.Panel4)
            Me.Controls.Add(Me.Panel3)
            Me.Controls.Add(Me.Panel2)
            Me.Controls.Add(Me.TextEdit1)
            Me.Controls.Add(Me.BarCodeControl1)
            Me.Controls.Add(Me.GridControl1)
            Me.Controls.Add(Me.Panel1)
            Me.Controls.Add(Me.GridControl2)
            Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
            Me.Name = "PointOfSale"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "MainForm"
            Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
            Me.Panel1.ResumeLayout(False)
            CType(Me.PictureEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PictureEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.Panel3.ResumeLayout(False)
            Me.Panel4.ResumeLayout(False)
            Me.Panel5.ResumeLayout(False)
            Me.Panel6.ResumeLayout(False)
            CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.PnlStatistics, System.ComponentModel.ISupportInitialize).EndInit()
            Me.PnlStatistics.ResumeLayout(False)
            Me.PnlPayment.ResumeLayout(False)
            Me.PnlPayment.PerformLayout()
            CType(Me.txtPaymentChange.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPaymentTotal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            CType(Me.txtPaymentPaid.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub
        Friend WithEvents Panel1 As System.Windows.Forms.Panel
        Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents PictureEdit1 As DevExpress.XtraEditors.PictureEdit
        Friend WithEvents LblTime As DevExpress.XtraEditors.LabelControl
        Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
        Friend WithEvents BarCodeControl1 As DevExpress.XtraEditors.BarCodeControl
        Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
        Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents Item As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents Qty As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents Price As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents Discount As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents SubTotal As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents Timer1 As System.Windows.Forms.Timer
        Friend WithEvents lblSecond As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblTotal As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Panel2 As System.Windows.Forms.Panel
        Friend WithEvents Panel3 As System.Windows.Forms.Panel
        Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Panel4 As System.Windows.Forms.Panel
        Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LblItemCount As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl5 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblTotalDiscount As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Panel5 As System.Windows.Forms.Panel
        Friend WithEvents Panel6 As System.Windows.Forms.Panel
        Friend WithEvents LabelControl6 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LblQtyTotal As DevExpress.XtraEditors.LabelControl
        Friend WithEvents Panel7 As System.Windows.Forms.Panel
        Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
        Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
        Friend WithEvents ItemName As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents ItemPrice As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents PnlStatistics As DevExpress.XtraEditors.GroupControl
        Friend WithEvents lblBarcodeMissing As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl7 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblPriceMissing As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents lblItemQty As DevExpress.XtraEditors.LabelControl
        Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
        Friend WithEvents ItemID As DevExpress.XtraGrid.Columns.GridColumn
        Friend WithEvents PictureEdit2 As DevExpress.XtraEditors.PictureEdit
        Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
        Friend WithEvents PnlPayment As System.Windows.Forms.Panel
        Friend WithEvents txtPaymentPaid As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txtPaymentChange As DevExpress.XtraEditors.TextEdit
        Friend WithEvents txtPaymentTotal As DevExpress.XtraEditors.TextEdit
        Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    End Class
End Namespace