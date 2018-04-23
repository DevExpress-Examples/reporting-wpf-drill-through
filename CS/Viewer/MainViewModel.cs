using DevExpress.Mvvm.DataAnnotations;
using DevExpress.Xpf.Printing;
using DevExpress.XtraReports.UI;
using Reports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace Viewer {
    [POCOViewModel]
    public class MainViewModel {
        readonly XtraReport orderReport = new OrderReport();

        public virtual XtraReport Report { get; protected set; }
        public virtual bool RequestDocumentCreation { get; set; }
        public virtual int OrderId { get; set; }

        protected MainViewModel() {
            RequestDocumentCreation = true;
            Report = orderReport;
        }

        public void ShowOrders() {
            Report.Dispose();
            RequestDocumentCreation = false;
            Report = orderReport;
            RequestDocumentCreation = true;
        }
        public bool CanShowOrders() {
            return Report != orderReport;
        }

        public void OnPreviewMouseClick(DocumentPreviewMouseEventArgs args) {
            var orderId = args.ElementTag as int?;
            if(!orderId.HasValue)
                return;
            OrderId = orderId.Value;
            var invoiceReport = new InvoiceReport();
            invoiceReport.Parameters["OrderId"].Value = OrderId;
            Report = invoiceReport;
        }

        public void OnPreviewMouseMove(DocumentPreviewMouseEventArgs args) {
            var orderId = args.ElementTag as int?;
            if(!orderId.HasValue)
                return;
            OrderId = orderId.Value;
            Mouse.SetCursor(Cursors.Hand);
        }
    }
}
