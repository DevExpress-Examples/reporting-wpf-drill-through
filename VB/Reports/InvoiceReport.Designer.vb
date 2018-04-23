Namespace Reports
    Partial Public Class InvoiceReport
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Dim xrSummary1 As New DevExpress.XtraReports.UI.XRSummary()
            Me.clQuantity = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell30 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.OrderId = New DevExpress.XtraReports.Parameters.Parameter()
            Me.DataStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.xrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.lbShipName = New DevExpress.XtraReports.UI.XRLabel()
            Me.clFreight = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clCustomerID = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clProductID = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTable1 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell29 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.clOrderID = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clSalesperson = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clOrderDate = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clRequiredDate = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clShippedDate = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clShipVia = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.xrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.xrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clSubtotal = New DevExpress.XtraReports.UI.XRTableCell()
            Me.LabelOddStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.LabelStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.clDiscount = New DevExpress.XtraReports.UI.XRTableCell()
            Me.lbBillTo = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbShipCountry = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbCompanyName = New DevExpress.XtraReports.UI.XRLabel()
            Me.GroupFooter0 = New DevExpress.XtraReports.UI.GroupFooterBand()
            Me.xrTable3 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.TitleStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.GroupHeader0 = New DevExpress.XtraReports.UI.GroupHeaderBand()
            Me.lbShipTo = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbShipAddress = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbAddress1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.lbCountry = New DevExpress.XtraReports.UI.XRLabel()
            Me.clExtPrice = New DevExpress.XtraReports.UI.XRTableCell()
            Me.clProductName = New DevExpress.XtraReports.UI.XRTableCell()
            Me.DataStyleOdd = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.topMarginBand1 = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.clUnitPrice = New DevExpress.XtraReports.UI.XRTableCell()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrTable2 = New DevExpress.XtraReports.UI.XRTable()
            Me.xrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
            Me.northwind1 = New Reports.Northwind()
            Me.invoicesTableAdapter = New Reports.NorthwindTableAdapters.InvoicesTableAdapter()
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.northwind1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' clQuantity
            ' 
            Me.clQuantity.BackColor = System.Drawing.Color.Empty
            Me.clQuantity.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.Quantity")})
            Me.clQuantity.EvenStyleName = "DataStyle"
            Me.clQuantity.Name = "clQuantity"
            Me.clQuantity.OddStyleName = "DataStyleOdd"
            Me.clQuantity.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.clQuantity.StylePriority.UseTextAlignment = False
            Me.clQuantity.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clQuantity.Weight = 0.13671274961597543R
            ' 
            ' xrTableCell30
            ' 
            Me.xrTableCell30.Name = "xrTableCell30"
            Me.xrTableCell30.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell30.StyleName = "LabelOddStyle"
            Me.xrTableCell30.Text = "Customer"
            Me.xrTableCell30.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell30.Weight = 0.130568356374808R
            ' 
            ' OrderId
            ' 
            Me.OrderId.Name = "OrderId"
            Me.OrderId.Type = GetType(Integer)
            Me.OrderId.Visible = False
            ' 
            ' DataStyle
            ' 
            Me.DataStyle.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.DataStyle.Name = "DataStyle"
            Me.DataStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' xrTableCell8
            ' 
            Me.xrTableCell8.Name = "xrTableCell8"
            Me.xrTableCell8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell8.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell8.Weight = 0.68827160493827155R
            ' 
            ' lbShipName
            ' 
            Me.lbShipName.BackColor = System.Drawing.Color.Empty
            Me.lbShipName.BorderColor = System.Drawing.Color.White
            Me.lbShipName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbShipName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ShipName")})
            Me.lbShipName.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbShipName.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbShipName.LocationFloat = New DevExpress.Utils.PointFloat(71.99999F, 0F)
            Me.lbShipName.Name = "lbShipName"
            Me.lbShipName.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbShipName.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbShipName.StylePriority.UseBackColor = False
            Me.lbShipName.Text = "ShipName"
            Me.lbShipName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' clFreight
            ' 
            Me.clFreight.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(212)))), (CInt((CByte(212)))))
            Me.clFreight.BorderColor = System.Drawing.Color.White
            Me.clFreight.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.clFreight.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.Freight", "{0:'Frieght:  '$#,##.00}")})
            Me.clFreight.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.clFreight.ForeColor = System.Drawing.Color.Black
            Me.clFreight.Name = "clFreight"
            Me.clFreight.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.clFreight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.clFreight.Weight = 0.31172839506172839R
            Me.clFreight.XlsxFormatString = """Frieght: ""$#,##.00"
            ' 
            ' xrTableRow4
            ' 
            Me.xrTableRow4.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(167)))), (CInt((CByte(73)))))
            Me.xrTableRow4.BorderColor = System.Drawing.Color.White
            Me.xrTableRow4.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell22, Me.xrTableCell24, Me.xrTableCell25, Me.xrTableCell26, Me.xrTableCell27, Me.xrTableCell28})
            Me.xrTableRow4.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrTableRow4.ForeColor = System.Drawing.Color.White
            Me.xrTableRow4.Name = "xrTableRow4"
            Me.xrTableRow4.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow4.Weight = 0.25842696629213485R
            ' 
            ' xrTableCell22
            ' 
            Me.xrTableCell22.Name = "xrTableCell22"
            Me.xrTableCell22.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell22.StyleName = "LabelOddStyle"
            Me.xrTableCell22.Text = "Product"
            Me.xrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell22.Weight = 0.10906298003072197R
            ' 
            ' xrTableCell24
            ' 
            Me.xrTableCell24.Name = "xrTableCell24"
            Me.xrTableCell24.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell24.StyleName = "LabelOddStyle"
            Me.xrTableCell24.Text = "Name"
            Me.xrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell24.Weight = 0.30261136712749614R
            ' 
            ' xrTableCell25
            ' 
            Me.xrTableCell25.Name = "xrTableCell25"
            Me.xrTableCell25.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell25.StyleName = "LabelOddStyle"
            Me.xrTableCell25.Text = "Quantity"
            Me.xrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell25.Weight = 0.13671274961597543R
            ' 
            ' xrTableCell26
            ' 
            Me.xrTableCell26.Name = "xrTableCell26"
            Me.xrTableCell26.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell26.StyleName = "LabelOddStyle"
            Me.xrTableCell26.Text = "Unit Price"
            Me.xrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell26.Weight = 0.13671274961597543R
            ' 
            ' xrTableCell27
            ' 
            Me.xrTableCell27.Name = "xrTableCell27"
            Me.xrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell27.StyleName = "LabelOddStyle"
            Me.xrTableCell27.Text = "Discount"
            Me.xrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell27.Weight = 0.13671274961597543R
            ' 
            ' xrTableCell28
            ' 
            Me.xrTableCell28.Name = "xrTableCell28"
            Me.xrTableCell28.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell28.StyleName = "LabelOddStyle"
            Me.xrTableCell28.Text = "Extended Price"
            Me.xrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell28.Weight = 0.1781874039938556R
            ' 
            ' clCustomerID
            ' 
            Me.clCustomerID.BackColor = System.Drawing.Color.Empty
            Me.clCustomerID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.CustomerID")})
            Me.clCustomerID.EvenStyleName = "DataStyle"
            Me.clCustomerID.Name = "clCustomerID"
            Me.clCustomerID.OddStyleName = "DataStyleOdd"
            Me.clCustomerID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clCustomerID.StylePriority.UseBackColor = False
            Me.clCustomerID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clCustomerID.Weight = 0.130568356374808R
            ' 
            ' clProductID
            ' 
            Me.clProductID.BackColor = System.Drawing.Color.Empty
            Me.clProductID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ProductID")})
            Me.clProductID.EvenStyleName = "DataStyle"
            Me.clProductID.Name = "clProductID"
            Me.clProductID.OddStyleName = "DataStyleOdd"
            Me.clProductID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clProductID.StylePriority.UseTextAlignment = False
            Me.clProductID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clProductID.Weight = 0.10906298003072197R
            ' 
            ' xrTable1
            ' 
            Me.xrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0F, 75F)
            Me.xrTable1.Name = "xrTable1"
            Me.xrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow1, Me.xrTableRow2, Me.xrTableRow3, Me.xrTableRow4})
            Me.xrTable1.SizeF = New System.Drawing.SizeF(646F, 89F)
            Me.xrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow1
            ' 
            Me.xrTableRow1.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(167)))), (CInt((CByte(73)))))
            Me.xrTableRow1.BorderColor = System.Drawing.Color.White
            Me.xrTableRow1.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell29, Me.xrTableCell30, Me.xrTableCell31, Me.xrTableCell32, Me.xrTableCell33, Me.xrTableCell34, Me.xrTableCell35})
            Me.xrTableRow1.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.xrTableRow1.ForeColor = System.Drawing.Color.White
            Me.xrTableRow1.Name = "xrTableRow1"
            Me.xrTableRow1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow1.Weight = 0.25842696629213485R
            ' 
            ' xrTableCell29
            ' 
            Me.xrTableCell29.Name = "xrTableCell29"
            Me.xrTableCell29.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell29.StyleName = "LabelOddStyle"
            Me.xrTableCell29.Text = "Order"
            Me.xrTableCell29.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell29.Weight = 0.10906298003072197R
            ' 
            ' xrTableCell31
            ' 
            Me.xrTableCell31.Name = "xrTableCell31"
            Me.xrTableCell31.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell31.StyleName = "LabelOddStyle"
            Me.xrTableCell31.Text = "Salesperson"
            Me.xrTableCell31.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell31.Weight = 0.17357910906298002R
            ' 
            ' xrTableCell32
            ' 
            Me.xrTableCell32.Name = "xrTableCell32"
            Me.xrTableCell32.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell32.StyleName = "LabelOddStyle"
            Me.xrTableCell32.Text = "Ordered"
            Me.xrTableCell32.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell32.Weight = 0.13671274961597543R
            ' 
            ' xrTableCell33
            ' 
            Me.xrTableCell33.Name = "xrTableCell33"
            Me.xrTableCell33.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell33.StyleName = "LabelOddStyle"
            Me.xrTableCell33.Text = "Required"
            Me.xrTableCell33.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell33.Weight = 0.13671274961597543R
            ' 
            ' xrTableCell34
            ' 
            Me.xrTableCell34.Name = "xrTableCell34"
            Me.xrTableCell34.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell34.StyleName = "LabelOddStyle"
            Me.xrTableCell34.Text = "Shipped"
            Me.xrTableCell34.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell34.Weight = 0.13671274961597543R
            ' 
            ' xrTableCell35
            ' 
            Me.xrTableCell35.Name = "xrTableCell35"
            Me.xrTableCell35.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell35.StyleName = "LabelOddStyle"
            Me.xrTableCell35.Text = "Ship Via"
            Me.xrTableCell35.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.xrTableCell35.Weight = 0.17665130568356374R
            ' 
            ' xrTableRow2
            ' 
            Me.xrTableRow2.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.xrTableRow2.BorderColor = System.Drawing.Color.White
            Me.xrTableRow2.Borders = DevExpress.XtraPrinting.BorderSide.Left
            Me.xrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.clOrderID, Me.clCustomerID, Me.clSalesperson, Me.clOrderDate, Me.clRequiredDate, Me.clShippedDate, Me.clShipVia})
            Me.xrTableRow2.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableRow2.Name = "xrTableRow2"
            Me.xrTableRow2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow2.Weight = 0.25842696629213485R
            ' 
            ' clOrderID
            ' 
            Me.clOrderID.BackColor = System.Drawing.Color.Empty
            Me.clOrderID.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.OrderID")})
            Me.clOrderID.EvenStyleName = "DataStyle"
            Me.clOrderID.Name = "clOrderID"
            Me.clOrderID.OddStyleName = "DataStyleOdd"
            Me.clOrderID.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clOrderID.StylePriority.UseBackColor = False
            Me.clOrderID.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clOrderID.Weight = 0.10906298003072197R
            ' 
            ' clSalesperson
            ' 
            Me.clSalesperson.BackColor = System.Drawing.Color.Empty
            Me.clSalesperson.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.Salesperson")})
            Me.clSalesperson.EvenStyleName = "DataStyle"
            Me.clSalesperson.Name = "clSalesperson"
            Me.clSalesperson.OddStyleName = "DataStyleOdd"
            Me.clSalesperson.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clSalesperson.StylePriority.UseBackColor = False
            Me.clSalesperson.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clSalesperson.Weight = 0.17357910906298002R
            ' 
            ' clOrderDate
            ' 
            Me.clOrderDate.BackColor = System.Drawing.Color.Empty
            Me.clOrderDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.OrderDate", "{0:MM/dd/yyyy}")})
            Me.clOrderDate.EvenStyleName = "DataStyle"
            Me.clOrderDate.Name = "clOrderDate"
            Me.clOrderDate.OddStyleName = "DataStyleOdd"
            Me.clOrderDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clOrderDate.StylePriority.UseBackColor = False
            Me.clOrderDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clOrderDate.Weight = 0.13671274961597543R
            ' 
            ' clRequiredDate
            ' 
            Me.clRequiredDate.BackColor = System.Drawing.Color.Empty
            Me.clRequiredDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.RequiredDate", "{0:MM/dd/yyyy}")})
            Me.clRequiredDate.EvenStyleName = "DataStyle"
            Me.clRequiredDate.Name = "clRequiredDate"
            Me.clRequiredDate.OddStyleName = "DataStyleOdd"
            Me.clRequiredDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clRequiredDate.StylePriority.UseBackColor = False
            Me.clRequiredDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clRequiredDate.Weight = 0.13671274961597543R
            ' 
            ' clShippedDate
            ' 
            Me.clShippedDate.BackColor = System.Drawing.Color.Empty
            Me.clShippedDate.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ShippedDate", "{0:MM/dd/yyyy}")})
            Me.clShippedDate.EvenStyleName = "DataStyle"
            Me.clShippedDate.Name = "clShippedDate"
            Me.clShippedDate.OddStyleName = "DataStyleOdd"
            Me.clShippedDate.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clShippedDate.StylePriority.UseBackColor = False
            Me.clShippedDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clShippedDate.Weight = 0.13671274961597543R
            ' 
            ' clShipVia
            ' 
            Me.clShipVia.BackColor = System.Drawing.Color.Empty
            Me.clShipVia.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ShippersCompanyName")})
            Me.clShipVia.EvenStyleName = "DataStyle"
            Me.clShipVia.Name = "clShipVia"
            Me.clShipVia.OddStyleName = "DataStyleOdd"
            Me.clShipVia.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.clShipVia.StylePriority.UseBackColor = False
            Me.clShipVia.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clShipVia.Weight = 0.17665130568356374R
            ' 
            ' xrTableRow3
            ' 
            Me.xrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell1})
            Me.xrTableRow3.Name = "xrTableRow3"
            Me.xrTableRow3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow3.Weight = 0.2247191011235955R
            ' 
            ' xrTableCell1
            ' 
            Me.xrTableCell1.Name = "xrTableCell1"
            Me.xrTableCell1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell1.Weight = 1R
            ' 
            ' xrTableRow7
            ' 
            Me.xrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell2, Me.clFreight})
            Me.xrTableRow7.Name = "xrTableRow7"
            Me.xrTableRow7.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow7.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow7.Weight = 0.33333333333333331R
            ' 
            ' xrTableCell2
            ' 
            Me.xrTableCell2.Name = "xrTableCell2"
            Me.xrTableCell2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrTableCell2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableCell2.Weight = 0.68827160493827155R
            ' 
            ' clSubtotal
            ' 
            Me.clSubtotal.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(212)))), (CInt((CByte(212)))))
            Me.clSubtotal.BorderColor = System.Drawing.Color.White
            Me.clSubtotal.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.clSubtotal.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ExtendedPrice")})
            Me.clSubtotal.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.clSubtotal.ForeColor = System.Drawing.Color.Black
            Me.clSubtotal.Name = "clSubtotal"
            Me.clSubtotal.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            xrSummary1.FormatString = "{0:'SubTotal:  '$#,##.00}"
            xrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Group
            Me.clSubtotal.Summary = xrSummary1
            Me.clSubtotal.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleRight
            Me.clSubtotal.Weight = 0.31172839506172839R
            Me.clSubtotal.XlsxFormatString = """SubTotal: ""$#,##.00"
            ' 
            ' LabelOddStyle
            ' 
            Me.LabelOddStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(229)))), (CInt((CByte(201)))), (CInt((CByte(148)))))
            Me.LabelOddStyle.Font = New System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.LabelOddStyle.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(46)))), (CInt((CByte(46)))), (CInt((CByte(51)))))
            Me.LabelOddStyle.Name = "LabelOddStyle"
            Me.LabelOddStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' LabelStyle
            ' 
            Me.LabelStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(244)))), (CInt((CByte(188)))))
            Me.LabelStyle.Font = New System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.LabelStyle.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(46)))), (CInt((CByte(46)))), (CInt((CByte(51)))))
            Me.LabelStyle.Name = "LabelStyle"
            Me.LabelStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' clDiscount
            ' 
            Me.clDiscount.BackColor = System.Drawing.Color.Empty
            Me.clDiscount.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.Discount", "{0:0%}")})
            Me.clDiscount.EvenStyleName = "DataStyle"
            Me.clDiscount.Name = "clDiscount"
            Me.clDiscount.OddStyleName = "DataStyleOdd"
            Me.clDiscount.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.clDiscount.StylePriority.UseTextAlignment = False
            Me.clDiscount.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clDiscount.Weight = 0.13671274961597543R
            ' 
            ' lbBillTo
            ' 
            Me.lbBillTo.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(212)))), (CInt((CByte(212)))))
            Me.lbBillTo.BorderColor = System.Drawing.Color.White
            Me.lbBillTo.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.lbBillTo.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbBillTo.ForeColor = System.Drawing.Color.Black
            Me.lbBillTo.LocationFloat = New DevExpress.Utils.PointFloat(297F, 0F)
            Me.lbBillTo.Name = "lbBillTo"
            Me.lbBillTo.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbBillTo.SizeF = New System.Drawing.SizeF(66F, 25F)
            Me.lbBillTo.Text = "Bill To:"
            Me.lbBillTo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbShipCountry
            ' 
            Me.lbShipCountry.BackColor = System.Drawing.Color.Empty
            Me.lbShipCountry.BorderColor = System.Drawing.Color.White
            Me.lbShipCountry.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbShipCountry.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ShipCountry")})
            Me.lbShipCountry.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbShipCountry.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbShipCountry.LocationFloat = New DevExpress.Utils.PointFloat(71.99999F, 50F)
            Me.lbShipCountry.Name = "lbShipCountry"
            Me.lbShipCountry.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbShipCountry.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbShipCountry.StylePriority.UseBackColor = False
            Me.lbShipCountry.Text = "ShipCountry"
            Me.lbShipCountry.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbCompanyName
            ' 
            Me.lbCompanyName.BackColor = System.Drawing.Color.Empty
            Me.lbCompanyName.BorderColor = System.Drawing.Color.White
            Me.lbCompanyName.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbCompanyName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.CustomersCompanyName")})
            Me.lbCompanyName.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbCompanyName.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbCompanyName.LocationFloat = New DevExpress.Utils.PointFloat(363F, 0F)
            Me.lbCompanyName.Name = "lbCompanyName"
            Me.lbCompanyName.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbCompanyName.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbCompanyName.StylePriority.UseBackColor = False
            Me.lbCompanyName.Text = "CompanyName"
            Me.lbCompanyName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' GroupFooter0
            ' 
            Me.GroupFooter0.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable3})
            Me.GroupFooter0.HeightF = 50F
            Me.GroupFooter0.Name = "GroupFooter0"
            Me.GroupFooter0.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupFooter0.PageBreak = DevExpress.XtraReports.UI.PageBreak.AfterBand
            Me.GroupFooter0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable3
            ' 
            Me.xrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.9999911F, 0F)
            Me.xrTable3.Name = "xrTable3"
            Me.xrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow6, Me.xrTableRow7})
            Me.xrTable3.SizeF = New System.Drawing.SizeF(645.0001F, 50F)
            Me.xrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow6
            ' 
            Me.xrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.xrTableCell8, Me.clSubtotal})
            Me.xrTableRow6.Name = "xrTableRow6"
            Me.xrTableRow6.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow6.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow6.Weight = 0.33333333333333331R
            ' 
            ' TitleStyle
            ' 
            Me.TitleStyle.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(147)))), (CInt((CByte(153)))), (CInt((CByte(148)))))
            Me.TitleStyle.BorderDashStyle = DevExpress.XtraPrinting.BorderDashStyle.Solid
            Me.TitleStyle.Borders = DevExpress.XtraPrinting.BorderSide.None
            Me.TitleStyle.BorderWidth = 1
            Me.TitleStyle.Font = New System.Drawing.Font("Verdana", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.TitleStyle.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(244)))), (CInt((CByte(188)))))
            Me.TitleStyle.Name = "TitleStyle"
            Me.TitleStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F)
            Me.TitleStyle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomCenter
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.HeightF = 75F
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' GroupHeader0
            ' 
            Me.GroupHeader0.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.lbShipTo, Me.lbBillTo, Me.xrTable1, Me.lbShipName, Me.lbShipAddress, Me.lbShipCountry, Me.lbAddress1, Me.lbCountry, Me.lbCompanyName})
            Me.GroupHeader0.GroupFields.AddRange(New DevExpress.XtraReports.UI.GroupField() { New DevExpress.XtraReports.UI.GroupField("OrderID", DevExpress.XtraReports.UI.XRColumnSortOrder.Descending)})
            Me.GroupHeader0.HeightF = 164F
            Me.GroupHeader0.Name = "GroupHeader0"
            Me.GroupHeader0.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.GroupHeader0.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbShipTo
            ' 
            Me.lbShipTo.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(212)))), (CInt((CByte(212)))), (CInt((CByte(212)))))
            Me.lbShipTo.BorderColor = System.Drawing.Color.White
            Me.lbShipTo.Borders = (CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.lbShipTo.Font = New System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold)
            Me.lbShipTo.ForeColor = System.Drawing.Color.Black
            Me.lbShipTo.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.lbShipTo.Name = "lbShipTo"
            Me.lbShipTo.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbShipTo.SizeF = New System.Drawing.SizeF(72F, 25F)
            Me.lbShipTo.Text = "Ship To:"
            Me.lbShipTo.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbShipAddress
            ' 
            Me.lbShipAddress.BackColor = System.Drawing.Color.Empty
            Me.lbShipAddress.BorderColor = System.Drawing.Color.White
            Me.lbShipAddress.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbShipAddress.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ShipAddress")})
            Me.lbShipAddress.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbShipAddress.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbShipAddress.LocationFloat = New DevExpress.Utils.PointFloat(71F, 25F)
            Me.lbShipAddress.Name = "lbShipAddress"
            Me.lbShipAddress.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbShipAddress.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbShipAddress.StylePriority.UseBackColor = False
            Me.lbShipAddress.Text = "ShipAddress"
            Me.lbShipAddress.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbAddress1
            ' 
            Me.lbAddress1.BackColor = System.Drawing.Color.Empty
            Me.lbAddress1.BorderColor = System.Drawing.Color.White
            Me.lbAddress1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbAddress1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.Address")})
            Me.lbAddress1.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbAddress1.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbAddress1.LocationFloat = New DevExpress.Utils.PointFloat(363F, 25F)
            Me.lbAddress1.Name = "lbAddress1"
            Me.lbAddress1.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbAddress1.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbAddress1.StylePriority.UseBackColor = False
            Me.lbAddress1.Text = "Address"
            Me.lbAddress1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' lbCountry
            ' 
            Me.lbCountry.BackColor = System.Drawing.Color.Empty
            Me.lbCountry.BorderColor = System.Drawing.Color.White
            Me.lbCountry.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
            Me.lbCountry.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.Country")})
            Me.lbCountry.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.lbCountry.ForeColor = System.Drawing.SystemColors.WindowText
            Me.lbCountry.LocationFloat = New DevExpress.Utils.PointFloat(363F, 50F)
            Me.lbCountry.Name = "lbCountry"
            Me.lbCountry.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.lbCountry.SizeF = New System.Drawing.SizeF(225F, 25F)
            Me.lbCountry.StylePriority.UseBackColor = False
            Me.lbCountry.Text = "Country"
            Me.lbCountry.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' clExtPrice
            ' 
            Me.clExtPrice.BackColor = System.Drawing.Color.Empty
            Me.clExtPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ExtendedPrice", "{0:$#,##.00}")})
            Me.clExtPrice.EvenStyleName = "DataStyle"
            Me.clExtPrice.Name = "clExtPrice"
            Me.clExtPrice.OddStyleName = "DataStyleOdd"
            Me.clExtPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.clExtPrice.StylePriority.UseTextAlignment = False
            Me.clExtPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clExtPrice.Weight = 0.18586789554531491R
            ' 
            ' clProductName
            ' 
            Me.clProductName.BackColor = System.Drawing.Color.Empty
            Me.clProductName.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.ProductName")})
            Me.clProductName.EvenStyleName = "DataStyle"
            Me.clProductName.Name = "clProductName"
            Me.clProductName.OddStyleName = "DataStyleOdd"
            Me.clProductName.Padding = New DevExpress.XtraPrinting.PaddingInfo(6, 0, 0, 0, 100F)
            Me.clProductName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clProductName.Weight = 0.30261136712749614R
            ' 
            ' DataStyleOdd
            ' 
            Me.DataStyleOdd.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(255)))), (CInt((CByte(244)))), (CInt((CByte(188)))))
            Me.DataStyleOdd.Font = New System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.DataStyleOdd.Name = "DataStyleOdd"
            Me.DataStyleOdd.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
            ' 
            ' topMarginBand1
            ' 
            Me.topMarginBand1.Name = "topMarginBand1"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel1})
            Me.PageHeader.HeightF = 32.99999F
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.OrderID", "{0:Invoice #}")})
            Me.xrLabel1.Font = New System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(1.999982F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(644.0001F, 32.99999F)
            Me.xrLabel1.StyleName = "TitleStyle"
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' clUnitPrice
            ' 
            Me.clUnitPrice.BackColor = System.Drawing.Color.Empty
            Me.clUnitPrice.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Invoices.UnitPrice", "{0:$#,##.00}")})
            Me.clUnitPrice.EvenStyleName = "DataStyle"
            Me.clUnitPrice.Name = "clUnitPrice"
            Me.clUnitPrice.OddStyleName = "DataStyleOdd"
            Me.clUnitPrice.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 6, 0, 0, 100F)
            Me.clUnitPrice.StylePriority.UseTextAlignment = False
            Me.clUnitPrice.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
            Me.clUnitPrice.Weight = 0.13671274961597543R
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrTable2})
            Me.Detail.HeightF = 23F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTable2
            ' 
            Me.xrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0F, 0F)
            Me.xrTable2.Name = "xrTable2"
            Me.xrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() { Me.xrTableRow5})
            Me.xrTable2.SizeF = New System.Drawing.SizeF(646.0001F, 23F)
            Me.xrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrTableRow5
            ' 
            Me.xrTableRow5.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(238)))), (CInt((CByte(238)))), (CInt((CByte(238)))))
            Me.xrTableRow5.BorderColor = System.Drawing.Color.White
            Me.xrTableRow5.Borders = (CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide))
            Me.xrTableRow5.BorderWidth = 1
            Me.xrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() { Me.clProductID, Me.clProductName, Me.clQuantity, Me.clUnitPrice, Me.clDiscount, Me.clExtPrice})
            Me.xrTableRow5.Font = New System.Drawing.Font("Tahoma", 8.25F)
            Me.xrTableRow5.Name = "xrTableRow5"
            Me.xrTableRow5.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.xrTableRow5.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            Me.xrTableRow5.Weight = 1R
            ' 
            ' northwind1
            ' 
            Me.northwind1.DataSetName = "Northwind"
            Me.northwind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' invoicesTableAdapter
            ' 
            Me.invoicesTableAdapter.ClearBeforeFill = True
            ' 
            ' InvoiceReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.GroupHeader0, Me.Detail, Me.GroupFooter0, Me.PageHeader, Me.BottomMargin, Me.topMarginBand1})
            Me.DataAdapter = Me.invoicesTableAdapter
            Me.DataMember = "Invoices"
            Me.DataSource = Me.northwind1
            Me.ReportPrintOptions.DetailCountOnEmptyDataSource = 0
            Me.DisplayName = "Invoice"
            Me.FilterString = "[OrderID] = ?OrderId"
            Me.Font = New System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
            Me.Margins = New System.Drawing.Printing.Margins(99, 95, 100, 75)
            Me.Parameters.AddRange(New DevExpress.XtraReports.Parameters.Parameter() { Me.OrderId})
            Me.ReportPrintOptions.PrintOnEmptyDataSource = False
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.LabelStyle, Me.DataStyle, Me.TitleStyle, Me.LabelOddStyle, Me.DataStyleOdd})
            Me.Version = "11.1"
            DirectCast(Me.xrTable1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable3, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.xrTable2, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.northwind1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private clQuantity As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell30 As DevExpress.XtraReports.UI.XRTableCell
        Private OrderId As DevExpress.XtraReports.Parameters.Parameter
        Private DataStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private xrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
        Private lbShipName As DevExpress.XtraReports.UI.XRLabel
        Private clFreight As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
        Private clCustomerID As DevExpress.XtraReports.UI.XRTableCell
        Private clProductID As DevExpress.XtraReports.UI.XRTableCell
        Private xrTable1 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell29 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
        Private clOrderID As DevExpress.XtraReports.UI.XRTableCell
        Private clSalesperson As DevExpress.XtraReports.UI.XRTableCell
        Private clOrderDate As DevExpress.XtraReports.UI.XRTableCell
        Private clRequiredDate As DevExpress.XtraReports.UI.XRTableCell
        Private clShippedDate As DevExpress.XtraReports.UI.XRTableCell
        Private clShipVia As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
        Private xrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
        Private xrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
        Private clSubtotal As DevExpress.XtraReports.UI.XRTableCell
        Private LabelOddStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private LabelStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private clDiscount As DevExpress.XtraReports.UI.XRTableCell
        Private lbBillTo As DevExpress.XtraReports.UI.XRLabel
        Private lbShipCountry As DevExpress.XtraReports.UI.XRLabel
        Private lbCompanyName As DevExpress.XtraReports.UI.XRLabel
        Private GroupFooter0 As DevExpress.XtraReports.UI.GroupFooterBand
        Private xrTable3 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
        Private TitleStyle As DevExpress.XtraReports.UI.XRControlStyle
        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private GroupHeader0 As DevExpress.XtraReports.UI.GroupHeaderBand
        Private lbShipTo As DevExpress.XtraReports.UI.XRLabel
        Private lbShipAddress As DevExpress.XtraReports.UI.XRLabel
        Private lbAddress1 As DevExpress.XtraReports.UI.XRLabel
        Private lbCountry As DevExpress.XtraReports.UI.XRLabel
        Private clExtPrice As DevExpress.XtraReports.UI.XRTableCell
        Private clProductName As DevExpress.XtraReports.UI.XRTableCell
        Private DataStyleOdd As DevExpress.XtraReports.UI.XRControlStyle
        Private topMarginBand1 As DevExpress.XtraReports.UI.TopMarginBand
        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private clUnitPrice As DevExpress.XtraReports.UI.XRTableCell
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private xrTable2 As DevExpress.XtraReports.UI.XRTable
        Private xrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
        Private northwind1 As Northwind
        Private invoicesTableAdapter As NorthwindTableAdapters.InvoicesTableAdapter

    End Class
End Namespace
