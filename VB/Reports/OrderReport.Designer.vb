Namespace Reports
    Partial Public Class OrderReport
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
            Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
            Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.northwind1 = New Reports.Northwind()
            Me.categoriesTableAdapter = New Reports.NorthwindTableAdapters.CategoriesTableAdapter()
            Me.customersTableAdapter = New Reports.NorthwindTableAdapters.CustomersTableAdapter()
            Me.DetailReport = New DevExpress.XtraReports.UI.DetailReportBand()
            Me.Detail1 = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLine1 = New DevExpress.XtraReports.UI.XRLine()
            Me.xrLabel9 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel8 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
            Me.labelOrderId = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel5 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel4 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
            Me.ordersTableAdapter = New Reports.NorthwindTableAdapters.OrdersTableAdapter()
            Me.Header = New DevExpress.XtraReports.UI.XRControlStyle()
            Me.LinkStyle = New DevExpress.XtraReports.UI.XRControlStyle()
            DirectCast(Me.northwind1, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' BottomMargin
            ' 
            Me.BottomMargin.Name = "BottomMargin"
            Me.BottomMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' TopMargin
            ' 
            Me.TopMargin.Name = "TopMargin"
            Me.TopMargin.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLabel2, Me.xrLabel1})
            Me.Detail.HeightF = 34.45834F
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.ContactName")})
            Me.xrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(411.0417F, 0F)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.SizeF = New System.Drawing.SizeF(238.9583F, 34.45834F)
            Me.xrLabel2.StyleName = "Header"
            Me.xrLabel2.Text = "[ContactName]"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CompanyName")})
            Me.xrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(38.12501F, 0F)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.SizeF = New System.Drawing.SizeF(372.9167F, 34.45834F)
            Me.xrLabel1.StyleName = "Header"
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' northwind1
            ' 
            Me.northwind1.DataSetName = "Northwind"
            Me.northwind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' categoriesTableAdapter
            ' 
            Me.categoriesTableAdapter.ClearBeforeFill = True
            ' 
            ' customersTableAdapter
            ' 
            Me.customersTableAdapter.ClearBeforeFill = True
            ' 
            ' DetailReport
            ' 
            Me.DetailReport.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail1})
            Me.DetailReport.DataAdapter = Me.ordersTableAdapter
            Me.DetailReport.DataMember = "Customers.CustomersOrders"
            Me.DetailReport.DataSource = Me.northwind1
            Me.DetailReport.Level = 0
            Me.DetailReport.Name = "DetailReport"
            ' 
            ' Detail1
            ' 
            Me.Detail1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() { Me.xrLine1, Me.xrLabel9, Me.xrLabel8, Me.xrLabel7, Me.labelOrderId, Me.xrLabel5, Me.xrLabel4, Me.xrLabel3})
            Me.Detail1.HeightF = 103.125F
            Me.Detail1.Name = "Detail1"
            ' 
            ' xrLine1
            ' 
            Me.xrLine1.LocationFloat = New DevExpress.Utils.PointFloat(38.12501F, 95.04163F)
            Me.xrLine1.Name = "xrLine1"
            Me.xrLine1.SizeF = New System.Drawing.SizeF(611.875F, 8.083374F)
            ' 
            ' xrLabel9
            ' 
            Me.xrLabel9.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.ShippedDate", "{0:M/d/yyyy}")})
            Me.xrLabel9.LocationFloat = New DevExpress.Utils.PointFloat(501.4584F, 45.99997F)
            Me.xrLabel9.Name = "xrLabel9"
            Me.xrLabel9.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel9.SizeF = New System.Drawing.SizeF(138.5415F, 23F)
            Me.xrLabel9.Text = "xrLabel9"
            ' 
            ' xrLabel8
            ' 
            Me.xrLabel8.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.RequiredDate", "{0:M/d/yyyy}")})
            Me.xrLabel8.LocationFloat = New DevExpress.Utils.PointFloat(501.4584F, 22.99999F)
            Me.xrLabel8.Name = "xrLabel8"
            Me.xrLabel8.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel8.SizeF = New System.Drawing.SizeF(138.5416F, 23F)
            Me.xrLabel8.Text = "xrLabel8"
            ' 
            ' xrLabel7
            ' 
            Me.xrLabel7.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.OrderDate", "{0:M/d/yyyy}")})
            Me.xrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(501.4584F, 0F)
            Me.xrLabel7.Name = "xrLabel7"
            Me.xrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel7.SizeF = New System.Drawing.SizeF(138.5416F, 23F)
            Me.xrLabel7.Text = "xrLabel7"
            ' 
            ' labelOrderId
            ' 
            Me.labelOrderId.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { _
                New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.OrderID"), _
                New DevExpress.XtraReports.UI.XRBinding("Tag", Nothing, "Customers.CustomersOrders.OrderID") _
            })
            Me.labelOrderId.LocationFloat = New DevExpress.Utils.PointFloat(62.08334F, 68.99995F)
            Me.labelOrderId.Name = "labelOrderId"
            Me.labelOrderId.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.labelOrderId.SizeF = New System.Drawing.SizeF(235.4166F, 23F)
            Me.labelOrderId.StyleName = "LinkStyle"
            Me.labelOrderId.Text = "labelOrderId"
            ' 
            ' xrLabel5
            ' 
            Me.xrLabel5.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.ShipCountry")})
            Me.xrLabel5.LocationFloat = New DevExpress.Utils.PointFloat(62.08334F, 45.99997F)
            Me.xrLabel5.Name = "xrLabel5"
            Me.xrLabel5.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel5.SizeF = New System.Drawing.SizeF(235.4167F, 23F)
            Me.xrLabel5.Text = "xrLabel5"
            ' 
            ' xrLabel4
            ' 
            Me.xrLabel4.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.ShipCity")})
            Me.xrLabel4.LocationFloat = New DevExpress.Utils.PointFloat(62.08334F, 22.99999F)
            Me.xrLabel4.Name = "xrLabel4"
            Me.xrLabel4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel4.SizeF = New System.Drawing.SizeF(235.4167F, 23F)
            Me.xrLabel4.Text = "xrLabel4"
            ' 
            ' xrLabel3
            ' 
            Me.xrLabel3.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() { New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Customers.CustomersOrders.ShipAddress")})
            Me.xrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(62.08334F, 0F)
            Me.xrLabel3.Name = "xrLabel3"
            Me.xrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel3.SizeF = New System.Drawing.SizeF(235.4167F, 23F)
            Me.xrLabel3.Text = "xrLabel3"
            ' 
            ' ordersTableAdapter
            ' 
            Me.ordersTableAdapter.ClearBeforeFill = True
            ' 
            ' Header
            ' 
            Me.Header.BackColor = System.Drawing.Color.Gainsboro
            Me.Header.Font = New DevExpress.Drawing.DXFont("Verdana", 15.75F)
            Me.Header.Name = "Header"
            ' 
            ' LinkStyle
            ' 
            Me.LinkStyle.Font = New DevExpress.Drawing.DXFont("Verdana", 9.75F, DevExpress.Drawing.DXFontStyle.Underline)
            Me.LinkStyle.ForeColor = System.Drawing.Color.Maroon
            Me.LinkStyle.Name = "LinkStyle"
            Me.LinkStyle.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            ' 
            ' OrderReport
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() { Me.Detail, Me.TopMargin, Me.BottomMargin, Me.DetailReport})
            Me.DataAdapter = Me.customersTableAdapter
            Me.DataMember = "Customers"
            Me.DataSource = Me.northwind1
            Me.Font = New DevExpress.Drawing.DXFont("Verdana", 9.75F)
            Me.Margins = New DevExpress.Drawing.DXMargins(96, 104, 100, 100)
            Me.StyleSheet.AddRange(New DevExpress.XtraReports.UI.XRControlStyle() { Me.Header, Me.LinkStyle})
            Me.Version = "11.1"
            DirectCast(Me.northwind1, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me, System.ComponentModel.ISupportInitialize).EndInit()

        End Sub

        #End Region

        Private BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
        Private TopMargin As DevExpress.XtraReports.UI.TopMarginBand
        Private Detail As DevExpress.XtraReports.UI.DetailBand
        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel
        Private northwind1 As Northwind
        Private categoriesTableAdapter As NorthwindTableAdapters.CategoriesTableAdapter
        Private customersTableAdapter As NorthwindTableAdapters.CustomersTableAdapter
        Private DetailReport As DevExpress.XtraReports.UI.DetailReportBand
        Private Detail1 As DevExpress.XtraReports.UI.DetailBand
        Private xrLine1 As DevExpress.XtraReports.UI.XRLine
        Private xrLabel9 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel8 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel7 As DevExpress.XtraReports.UI.XRLabel
        Private labelOrderId As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel5 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel4 As DevExpress.XtraReports.UI.XRLabel
        Private xrLabel3 As DevExpress.XtraReports.UI.XRLabel
        Private ordersTableAdapter As NorthwindTableAdapters.OrdersTableAdapter
        Private Header As DevExpress.XtraReports.UI.XRControlStyle
        Private LinkStyle As DevExpress.XtraReports.UI.XRControlStyle

    End Class
End Namespace
