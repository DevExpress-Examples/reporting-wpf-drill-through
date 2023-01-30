namespace Reports
{
    partial class OrderReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.northwind1 = new Reports.Northwind();
            this.categoriesTableAdapter = new Reports.NorthwindTableAdapters.CategoriesTableAdapter();
            this.customersTableAdapter = new Reports.NorthwindTableAdapters.CustomersTableAdapter();
            this.DetailReport = new DevExpress.XtraReports.UI.DetailReportBand();
            this.Detail1 = new DevExpress.XtraReports.UI.DetailBand();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.xrLabel9 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel8 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.labelOrderId = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel3 = new DevExpress.XtraReports.UI.XRLabel();
            this.ordersTableAdapter = new Reports.NorthwindTableAdapters.OrdersTableAdapter();
            this.Header = new DevExpress.XtraReports.UI.XRControlStyle();
            this.LinkStyle = new DevExpress.XtraReports.UI.XRControlStyle();
            ((System.ComponentModel.ISupportInitialize)(this.northwind1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // BottomMargin
            // 
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // TopMargin
            // 
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLabel2,
            this.xrLabel1});
            this.Detail.HeightF = 34.45834F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // xrLabel2
            // 
            this.xrLabel2.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.ContactName")});
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(411.0417F, 0F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(238.9583F, 34.45834F);
            this.xrLabel2.StyleName = "Header";
            this.xrLabel2.Text = "[ContactName]";
            // 
            // xrLabel1
            // 
            this.xrLabel1.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CompanyName")});
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(38.12501F, 0F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(372.9167F, 34.45834F);
            this.xrLabel1.StyleName = "Header";
            this.xrLabel1.Text = "xrLabel1";
            // 
            // northwind1
            // 
            this.northwind1.DataSetName = "Northwind";
            this.northwind1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriesTableAdapter
            // 
            this.categoriesTableAdapter.ClearBeforeFill = true;
            // 
            // customersTableAdapter
            // 
            this.customersTableAdapter.ClearBeforeFill = true;
            // 
            // DetailReport
            // 
            this.DetailReport.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail1});
            this.DetailReport.DataAdapter = this.ordersTableAdapter;
            this.DetailReport.DataMember = "Customers.CustomersOrders";
            this.DetailReport.DataSource = this.northwind1;
            this.DetailReport.Level = 0;
            this.DetailReport.Name = "DetailReport";
            // 
            // Detail1
            // 
            this.Detail1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrLine1,
            this.xrLabel9,
            this.xrLabel8,
            this.xrLabel7,
            this.labelOrderId,
            this.xrLabel5,
            this.xrLabel4,
            this.xrLabel3});
            this.Detail1.HeightF = 103.125F;
            this.Detail1.Name = "Detail1";
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(38.12501F, 95.04163F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(611.875F, 8.083374F);
            // 
            // xrLabel9
            // 
            this.xrLabel9.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.ShippedDate", "{0:M/d/yyyy}")});
            this.xrLabel9.LocationFloat = new DevExpress.Utils.PointFloat(501.4584F, 45.99997F);
            this.xrLabel9.Name = "xrLabel9";
            this.xrLabel9.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel9.SizeF = new System.Drawing.SizeF(138.5415F, 23F);
            this.xrLabel9.Text = "xrLabel9";
            // 
            // xrLabel8
            // 
            this.xrLabel8.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.RequiredDate", "{0:M/d/yyyy}")});
            this.xrLabel8.LocationFloat = new DevExpress.Utils.PointFloat(501.4584F, 22.99999F);
            this.xrLabel8.Name = "xrLabel8";
            this.xrLabel8.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel8.SizeF = new System.Drawing.SizeF(138.5416F, 23F);
            this.xrLabel8.Text = "xrLabel8";
            // 
            // xrLabel7
            // 
            this.xrLabel7.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.OrderDate", "{0:M/d/yyyy}")});
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(501.4584F, 0F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(138.5416F, 23F);
            this.xrLabel7.Text = "xrLabel7";
            // 
            // labelOrderId
            // 
            this.labelOrderId.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.OrderID"),
            new DevExpress.XtraReports.UI.XRBinding("Tag", null, "Customers.CustomersOrders.OrderID")});
            this.labelOrderId.LocationFloat = new DevExpress.Utils.PointFloat(62.08334F, 68.99995F);
            this.labelOrderId.Name = "labelOrderId";
            this.labelOrderId.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.labelOrderId.SizeF = new System.Drawing.SizeF(235.4166F, 23F);
            this.labelOrderId.StyleName = "LinkStyle";
            this.labelOrderId.Text = "labelOrderId";
            // 
            // xrLabel5
            // 
            this.xrLabel5.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.ShipCountry")});
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(62.08334F, 45.99997F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(235.4167F, 23F);
            this.xrLabel5.Text = "xrLabel5";
            // 
            // xrLabel4
            // 
            this.xrLabel4.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.ShipCity")});
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(62.08334F, 22.99999F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(235.4167F, 23F);
            this.xrLabel4.Text = "xrLabel4";
            // 
            // xrLabel3
            // 
            this.xrLabel3.DataBindings.AddRange(new DevExpress.XtraReports.UI.XRBinding[] {
            new DevExpress.XtraReports.UI.XRBinding("Text", null, "Customers.CustomersOrders.ShipAddress")});
            this.xrLabel3.LocationFloat = new DevExpress.Utils.PointFloat(62.08334F, 0F);
            this.xrLabel3.Name = "xrLabel3";
            this.xrLabel3.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel3.SizeF = new System.Drawing.SizeF(235.4167F, 23F);
            this.xrLabel3.Text = "xrLabel3";
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.Gainsboro;
            this.Header.Font = new DevExpress.Drawing.DXFont("Verdana", 15.75F);
            this.Header.Name = "Header";
            // 
            // LinkStyle
            // 
            this.LinkStyle.Font = new DevExpress.Drawing.DXFont("Verdana", 9.75F, DevExpress.Drawing.DXFontStyle.Underline);
            this.LinkStyle.ForeColor = System.Drawing.Color.Maroon;
            this.LinkStyle.Name = "LinkStyle";
            this.LinkStyle.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            // 
            // OrderReport
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin,
            this.DetailReport});
            this.DataAdapter = this.customersTableAdapter;
            this.DataMember = "Customers";
            this.DataSource = this.northwind1;
            this.Font = new DevExpress.Drawing.DXFont("Verdana", 9.75F);
            this.Margins = new DevExpress.Drawing.DXMargins(96, 104, 100, 100);
            this.StyleSheet.AddRange(new DevExpress.XtraReports.UI.XRControlStyle[] {
            this.Header,
            this.LinkStyle});
            this.Version = "11.1";
            ((System.ComponentModel.ISupportInitialize)(this.northwind1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private Northwind northwind1;
        private NorthwindTableAdapters.CategoriesTableAdapter categoriesTableAdapter;
        private NorthwindTableAdapters.CustomersTableAdapter customersTableAdapter;
        private DevExpress.XtraReports.UI.DetailReportBand DetailReport;
        private DevExpress.XtraReports.UI.DetailBand Detail1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel9;
        private DevExpress.XtraReports.UI.XRLabel xrLabel8;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel labelOrderId;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xrLabel3;
        private NorthwindTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private DevExpress.XtraReports.UI.XRControlStyle Header;
        private DevExpress.XtraReports.UI.XRControlStyle LinkStyle;

    }
}
