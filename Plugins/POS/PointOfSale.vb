Imports System.Text.RegularExpressions
Imports System.Data.OleDb
Imports DevExpress.Data.Filtering
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports System.Windows.Forms
Imports System.Drawing
Imports Microsoft.PointOfService
Imports System.Text

Namespace Salling.Plugins
    Public Class PointOfSale
        Public Document As New DataTable
        Public DocumentItems As New DataTable

        Public Customers As New DataTable
        Public Event Item_add As Action

        Private explorer As PosExplorer
        Private scanner As Scanner


        Public Function getItemData() As DataTable
            '251097
            'Dim MDBConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\all.mdb;User Id=admin;Password=251097;"
            Dim MDBConnectionString As String = "Provider=Microsoft.Jet.OLEDB.4.0;" _
            & "Data Source=|DataDirectory|\all.mdb;" _
            & "Jet OLEDB:Database Password=251097;"

            Dim ds As New DataSet
            Dim cnn As OleDbConnection = New OleDbConnection(MDBConnectionString)

            cnn.Open()

            Dim sqlutos As New System.Data.OleDb.OleDbCommand("SELECT * FROM main", cnn)
            Dim idcounter As Integer = 0
            Dim reader As System.Data.OleDb.OleDbDataReader
            reader = sqlutos.ExecuteReader
            While reader.Read
                idcounter = idcounter + 1
                '              items.Rows.Add(New Object() {
                '  idcounter,
                '  i,
                '  Array(i),
                '  Price
                '})

                '              items.Rows.Add(idcounter, reader(0), reader(1), reader(2), reader(3), reader(4), reader(5), ngalan)
                '1 = الباركود
                '2 = إسم الصنف
                '6 = وحدة القياس الكبيرة
                '7 = وحدة القياس الصغيرة
                '8 = معامل التحويل من الكمية الكبرى الى الكمية الصغرى
                '10 = سعر أكبر وحدة
                '13 = سعر أصغر وحدة
                '19 = الشركة المنتجة
                '25 = الحد الأعلى
                '26 = الحد الإدنى
                '59 = سعر 4
                '60 = سعر 5
                '62 = باركود 2

                Dim _barcode As String = Nothing
                If reader(62).ToString IsNot Nothing Then
                    _barcode = reader(62).ToString
                Else
                    _barcode = reader(1).ToString
                End If
                Dim _item As Salling.BASE.ORM.Items
                _item = Salling.BASE.ORM.Items.CreateItem(uow, _
                                         "ITM" & idcounter.ToString("000000"), _
                                         _barcode, _
                                         reader(2).ToString, _
                                         reader(2).ToString, _
                                         reader(19).ToString, _
                                         reader(2).ToString, _
                                         False, _
                                         False, _
                                         False, _
                                         False, _
                                         False, _
                                         Nothing, _
                                         1, _
                                         Nothing, _
                                         Nothing, _
                                         Nothing
                                         )

                Dim _itemUOM1 As Salling.BASE.ORM.ItemUOM
                _itemUOM1 = Salling.BASE.ORM.ItemUOM.CreateItemUOM(uow, _
                                                         _item, _
                                                         reader(6).ToString, _
                                                         1, _
                                                         CDec(reader(10).ToString), _
                                                         CDec(reader(59).ToString), _
                                                         0, _
                                                         1000, _
                                                         CDec(reader(25).ToString), _
                                                         CDec(reader(26).ToString), _
                                                         CDec(reader(26).ToString), _
                                                         CDec(reader(25).ToString)
                                                         )

                Dim _itemUOM2 As Salling.BASE.ORM.ItemUOM
                _itemUOM2 = Salling.BASE.ORM.ItemUOM.CreateItemUOM(uow, _
                                                         _item, _
                                                         reader(7).ToString, _
                                                         CDec(reader(8).ToString), _
                                                         CDec(reader(13).ToString), _
                                                         CDec(reader(60).ToString), _
                                                         0, _
                                                         1000, _
                                                         CDec(reader(25).ToString), _
                                                         CDec(reader(26).ToString), _
                                                         CDec(reader(26).ToString), _
                                                         CDec(reader(25).ToString)
                                                         )


            End While
            reader.Close()


            cnn.Close()

            Return New DataTable
        End Function

        Public Sub makeStatistics()
            'Dim _Items As POS.ORM.Items = uow.FindObject(Of POS.ORM.Items)(CriteriaOperator.Parse(String.Format("Barcode == ''")))
            'lblBarcodeMissing.Text = _Items.

            'uow.Evaluate(Of POS.ORM.Items)(CriteriaOperator.Parse(String.Format("Barcode == ''")))

            'Dim num_rows As Long = 0
            'num_rows = Convert.ToInt32(uow.Evaluate(Of POS.ORM.Items, CriteriaOperator.Parse("Count()"), Nothing))

            Dim _itemQty As Object = uow.Evaluate(GetType(Salling.BASE.ORM.Items), CriteriaOperator.Parse("Count()"), Nothing)
            lblItemQty.Text = Convert.ToInt32(_itemQty).ToString

            Dim _itemWithoutBarcode As Object = uow.Evaluate(GetType(Salling.BASE.ORM.Items), CriteriaOperator.Parse("Count()"), CriteriaOperator.Parse("Barcode == ''"))
            lblBarcodeMissing.Text = Convert.ToInt32(_itemWithoutBarcode).ToString

            Dim _itemWithoutPrice As Object = uow.Evaluate(GetType(Salling.BASE.ORM.ItemUOM), CriteriaOperator.Parse("Count()"), CriteriaOperator.Parse("Price == 0 AND Rate > 1"))
            lblPriceMissing.Text = Convert.ToInt32(_itemWithoutPrice).ToString

        End Sub
        Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles Me.Load
            explorer = New PosExplorer(Me)
            AddHandler explorer.DeviceAddedEvent, AddressOf explorer_DeviceAddedEvent


            InitTables()
            ' getItemData()
            makeStatistics()
            Me.GridControl1.DataSource = DocumentItems

            Dim xpcolItems As XPCollection(Of Salling.BASE.ORM.Items) = New XPCollection(Of Salling.BASE.ORM.Items)(uow)
            Dim _itms As XPDataView = GetXPDataView("SELECT Items.OID, Items.Barcode, Items.ArItemName, Items.Company, ItemUOM.Price, ItemUOM.Cost FROM Items INNER JOIN ItemUOM ON Items.OID = ItemUOM.Item WHERE (((ItemUOM.Rate)>1));")
            Me.GridControl2.DataSource = _itms
            TextEdit1.Focus()

        End Sub



        Private Sub explorer_DeviceAddedEvent(sender As Object, e As DeviceChangedEventArgs)
            If e.Device.Type = "Scanner" Then
                scanner = DirectCast(explorer.CreateInstance(e.Device), Scanner)
                scanner.Open()
                scanner.Claim(1000)
                scanner.DeviceEnabled = True

                AddHandler scanner.DataEvent, AddressOf scanner_DataEvent

                scanner.DataEventEnabled = True
                scanner.DecodeData = True
            End If

        End Sub

        Private Sub scanner_DataEvent(sender As Object, e As DataEventArgs)
            Dim encoding As New ASCIIEncoding()
            scanner.DataEventEnabled = True
            MsgBox(encoding.GetString(scanner.ScanDataLabel))
        End Sub


        Private Sub TextEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TextEdit1.EditValueChanged
            BarCodeControl1.Text = TextEdit1.Text
        End Sub

        Private Sub TextEdit1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextEdit1.KeyDown
            Dim Generator As System.Random = New System.Random()
            Dim Qty As Integer = Generator.Next(2, 10)
            Dim Price As Decimal = CDec(Generator.Next(2, 230))
            Dim Subtotal As Decimal = CDec(Qty * Price)

            If TextEdit1.Text.Length > 1 Then
                Select Case TextEdit1.Text.Substring(0, 1)
                    Case "+"
                    Case "-"
                    Case "/"
                    Case "*"
                    Case "="
                    Case Else
                        If Regex.IsMatch(TextEdit1.Text, "^[0-9 ]+$") Then
                            BarCodeControl1.Visible = True
                            Me.GridControl2.Visible = False
                            Me.GridControl1.Visible = True
                        Else
                            BarCodeControl1.Visible = False

                            Me.GridControl2.Location = Me.GridControl1.Location
                            Me.GridControl2.Visible = True
                            Me.GridControl1.Visible = False

                            GridView2.OptionsFilter.AllowFilterEditor = False
                            GridView2.OptionsView.ShowAutoFilterRow = False
                            GridView2.ActiveFilterString = "Contains([ArItemName],'" & TextEdit1.Text & "')"
                        End If

                End Select
            End If

            If e.KeyCode = Keys.Down Then
                GridView2.Focus()
            End If

            If e.KeyCode = 13 Then





                Select Case TextEdit1.Text.Substring(0, 1)
                    Case "*"
                        DocumentItems(DocumentItems.Rows.Count - 1).Item("Qty") = CInt(TextEdit1.Text.Replace("*", ""))
                        DocumentItems(DocumentItems.Rows.Count - 1).Item("SubTotal") = CDec(DocumentItems(DocumentItems.Rows.Count - 1).Item("Price")) * CInt(DocumentItems(DocumentItems.Rows.Count - 1).Item("Qty"))
                        TextEdit1.Text = ""
                        BarCodeControl1.Text = ""
                        TextEdit1.Focus()
                        RaiseEvent Item_add()

                        'Dim dr() As System.Data.DataRow

                        'dr = DocumentItems(DocumentItems.Rows.Count - 1).Item("Qty") = 5


                        'If dr.Length > 0 Then
                        '    dr(0)("Qty") = CDec(TextEdit1.Text.Replace("+", "")) + CInt(dr(0)("Qty"))
                        '    dr(0)("SubTotal") = CDec(dr(0)("Price")) * CInt(dr(0)("Qty"))
                        'End If
                    Case "-"

                    Case "/"

                    Case "+"

                    Case "="
                        DocumentItems(DocumentItems.Rows.Count - 1).Item("Price") = CDec(TextEdit1.Text.Replace("=", ""))
                        DocumentItems(DocumentItems.Rows.Count - 1).Item("SubTotal") = CDec(DocumentItems(DocumentItems.Rows.Count - 1).Item("Price")) * CInt(DocumentItems(DocumentItems.Rows.Count - 1).Item("Qty"))
                        TextEdit1.Text = ""
                        BarCodeControl1.Text = ""
                        TextEdit1.Focus()
                        RaiseEvent Item_add()


                    Case Else

                        Dim _SearchItems As Salling.BASE.ORM.Items = uow.FindObject(Of Salling.BASE.ORM.Items)(CriteriaOperator.Parse(String.Format("Barcode == '" & TextEdit1.Text & "'")))
                        Dim itemPrice As Decimal = 0
                        For Each prc In _SearchItems.ItemUOMs
                            If prc.Rate() > 1 Then
                                itemPrice = prc.Price()
                            End If

                        Next

                        Dim dr() As System.Data.DataRow
                        dr = DocumentItems.Select("ArItemName='" & _SearchItems.ArItemName.ToString & "'")

                        If _SearchItems IsNot Nothing Then

                            If dr.Length > 0 Then
                                dr(0)("Qty") = 1 + CInt(dr(0)("Qty"))
                                dr(0)("SubTotal") = CDec(dr(0)("Price")) * CInt(dr(0)("Qty"))
                            Else
                                DocumentItems.Rows.Add(New Object() {
                                    _SearchItems.ArItemName.ToString,
                                    itemPrice,
                                    "1",
                                    "0",
                                   itemPrice
                                })
                            End If


                            TextEdit1.Text = ""
                            BarCodeControl1.Text = ""
                            TextEdit1.Focus()
                            RaiseEvent Item_add()
                        End If

                End Select



            End If
        End Sub

        Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
            'Dim d As DateTime = DateTime.ParseExact(Now.Hour & Now.Minute, "HHmm", Nothing)
            'LblTime.Text = d.ToString("hh:mm")
            lblSecond.Text = Now.Second.ToString
        End Sub

        Private Sub onItemAdd() Handles Me.Item_add
            If Not DocumentItems Is Nothing AndAlso DocumentItems.Rows.Count > 0 Then
                lblTotal.Text = FormatCurrency((IIf(IsDBNull(DocumentItems.Compute("SUM(SubTotal)", "")), "0", DocumentItems.Compute("SUM(SubTotal)", ""))).ToString, 2, 0, 0)
                lblTotalDiscount.Text = FormatCurrency((IIf(IsDBNull(DocumentItems.Compute("SUM(Discount)", "")), "0", DocumentItems.Compute("SUM(Discount)", ""))).ToString, 2, 0, 0)
                LblQtyTotal.Text = (IIf(IsDBNull(DocumentItems.Compute("SUM(Qty)", "")), "0", DocumentItems.Compute("SUM(Qty)", ""))).ToString
                LblItemCount.Text = DocumentItems.Rows.Count.ToString
            End If
            Me.GridControl2.Visible = False
            Me.GridControl1.Visible = True

        End Sub

        Private Sub InitTables()
            Dim Generator As System.Random = New System.Random()

            DocumentItems.Columns.Add("ArItemName", GetType(String))
            DocumentItems.Columns.Add("Price", GetType(Decimal))
            DocumentItems.Columns.Add("Qty", GetType(Decimal))
            DocumentItems.Columns.Add("Discount", GetType(Decimal))
            DocumentItems.Columns.Add("SubTotal", GetType(Decimal))


        End Sub

        Private Sub GridControl2_ProcessGridKey(sender As Object, e As KeyEventArgs) Handles GridControl2.ProcessGridKey
            If e.KeyCode = Keys.Enter Then
                If GridView2.FocusedRowHandle > 0 Then
                    e.Handled = True


                    Dim _SearchItems As Salling.BASE.ORM.Items = uow.FindObject(Of Salling.BASE.ORM.Items)(CriteriaOperator.Parse(String.Format("ItemName == '" & GridView2.GetFocusedRowCellValue("ItemName").ToString & "'")))
                    Dim itemPrice As Decimal = 0
                    For Each prc In _SearchItems.ItemUOMs
                        If prc.Rate() > 1 Then
                            itemPrice = prc.Price()
                        End If

                    Next
                    If _SearchItems IsNot Nothing Then

                        Dim dr() As System.Data.DataRow
                        dr = DocumentItems.Select("ArItemName='" & _SearchItems.ArItemName.ToString & "'")
                        If dr.Length > 0 Then
                            dr(0)("Qty") = 1 + CInt(dr(0)("Qty"))
                            dr(0)("SubTotal") = CDec(dr(0)("Price")) * CInt(dr(0)("Qty"))
                        Else
                            DocumentItems.Rows.Add(New Object() {
                                _SearchItems.ArItemName.ToString,
                                itemPrice,
                                "1",
                                "0",
                               itemPrice
                            })
                        End If


                        TextEdit1.Text = ""
                        BarCodeControl1.Text = ""
                        TextEdit1.Focus()
                        RaiseEvent Item_add()
                    End If

                    'Dim dr() As System.Data.DataRow
                    'dr = items.Select("Item='" & GridView2.GetFocusedRowCellValue("ItemName").ToString & "'")
                    'If dr.Length > 0 Then
                    '    DocumentItems.Rows.Add(New Object() {
                    '        dr(0)("Item").ToString(),
                    '        dr(0)("Price").ToString(),
                    '        "1",
                    '        "0",
                    '        CDec(dr(0)("Price").ToString())
                    '    })
                    '    TextEdit1.Text = ""
                    '    BarCodeControl1.Text = ""
                    '    TextEdit1.Focus()
                    '    RaiseEvent Item_add()
                    'End If

                End If
            End If
        End Sub

        Public Function GetXPDataView(query As String) As DevExpress.Xpo.XPDataView
            Dim dv As New XPDataView()
            Dim data As SelectedData = uow.ExecuteQueryWithMetadata(query)
            For Each row As SelectStatementResultRow In data.ResultSet(0).Rows
                dv.AddProperty(DirectCast(row.Values(0), String), DBColumn.[GetType](DirectCast([Enum].Parse(GetType(DBColumnType), DirectCast(row.Values(2), String)), DBColumnType)))
            Next
            dv.LoadData(New SelectedData(data.ResultSet(1)))
            Return dv
        End Function


        Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
            PnlPayment.Location = New Point(0, 0)
            PnlPayment.Width = Me.Width
            PnlPayment.Height = Me.Height
            PnlPayment.Visible = True

            txtPaymentTotal.Text = (IIf(IsDBNull(DocumentItems.Compute("SUM(SubTotal)", "")), "0", DocumentItems.Compute("SUM(SubTotal)", ""))).ToString
            txtPaymentPaid.Text = "0.00"
            txtPaymentChange.Text = "0.00"
            txtPaymentPaid.Focus()
        End Sub

        Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
            'Dim uow As New UnitOfWork
            'Dim cashsale As Salling.BASE.ORM.CashSale = Salling.BASE.ORM.CashSale.CreateCashSale(uow, _
            '                                                                   "CSH" & Now.Date.Year & Now.Date.Month & Now.Date.Day & Now.Date.Hour & Now.Date.Millisecond, _
            '                                                                   0, _
            '                                                                   0, _
            '                                                                   0, _
            '                                                                   0, _
            '                                                                  CDec((IIf(IsDBNull(DocumentItems.Compute("SUM(SubTotal)", "")), "0", DocumentItems.Compute("SUM(SubTotal)", "")))), _
            '                                                                  False, _
            '                                                                  False, _
            '                                                                  True, _
            '                                                                  False, _
            '                                                                  "")

            'For Each row As DataRow In DocumentItems.Rows
            '    Dim cashsaleitem As Salling.BASE.ORM.CashSaleItems = Salling.BASE.ORM.CashSaleItems.CreateCashSaleItems(uow, _
            '                                                                                          cashsale, _
            '                                                                                          uow.FindObject(Of POS.ORM.Items)(CriteriaOperator.Parse(String.Format("ItemName == '" & row("ItemName").ToString & "'"))), _
            '                                                                                          CDec(row("Qty")), _
            '                                                                                          Nothing, _
            '                                                                                          CDec(row("Price")), _
            '                                                                                          CDec(row("Discount")), _
            '                                                                                          Nothing, _
            '                                                                                          Nothing, _
            '                                                                                          Nothing, _
            '                                                                                          Nothing
            '                                                                                        )
            'Next row
            createNewSale()
        End Sub

        Public Sub createNewSale()
            Document.Clear()
            DocumentItems.Clear()
            lblTotal.Text = FormatCurrency(0, 2, 0, 0)
            lblTotalDiscount.Text = FormatCurrency(0, 2, 0, 0)
            LblQtyTotal.Text = "0"
            LblItemCount.Text = "0"
            TextEdit1.Focus()
        End Sub

        Private Sub txtPaymentPaid_EditValueChanged(sender As Object, e As EventArgs) Handles txtPaymentPaid.EditValueChanged
            Dim value1, value2 As Decimal

            If Decimal.TryParse(txtPaymentPaid.Text, value1) Then
                If Decimal.TryParse(txtPaymentTotal.Text, value2) Then
                    txtPaymentChange.Text = (value1 - value2).ToString()
                End If
            End If

        End Sub

        Private Sub txtPaymentPaid_KeyDown(sender As Object, e As KeyEventArgs) Handles txtPaymentPaid.KeyDown
            If e.KeyCode = Keys.Enter Then
                PnlPayment.Visible = False
                'Dim uow As New UnitOfWork
                'Dim cashsale As Salling.BASE.ORM.CashSale = Salling.BASE.ORM.CashSale.CreateCashSale(uow, _
                '                                                                   "CSH" & Now.Date.Year & Now.Date.Month & Now.Date.Day & Now.Date.Hour & Now.Date.Millisecond, _
                '                                                                   0, _
                '                                                                   0, _
                '                                                                   0, _
                '                                                                   0, _
                '                                                                  CDec((IIf(IsDBNull(DocumentItems.Compute("SUM(SubTotal)", "")), "0", DocumentItems.Compute("SUM(SubTotal)", "")))), _
                '                                                                  False, _
                '                                                                  False, _
                '                                                                  False, _
                '                                                                  False, _
                '                                                                  "")

                'For Each row As DataRow In DocumentItems.Rows
                '    Dim cashsaleitem As Salling.BASE.ORM.CashSaleItems = Salling.BASE.ORM.CashSaleItems.CreateCashSaleItems(uow, _
                '                                                                                          cashsale, _
                '                                                                                          uow.FindObject(Of POS.ORM.Items)(CriteriaOperator.Parse(String.Format("ItemName == '" & row("ItemName").ToString & "'"))), _
                '                                                                                          CDec(row("Qty")), _
                '                                                                                          Nothing, _
                '                                                                                          CDec(row("Price")), _
                '                                                                                          CDec(row("Discount")), _
                '                                                                                          Nothing, _
                '                                                                                          Nothing, _
                '                                                                                          Nothing, _
                '                                                                                          Nothing
                '                                                                                        )
                'Next row
                createNewSale()
            End If
        End Sub


    End Class
End Namespace