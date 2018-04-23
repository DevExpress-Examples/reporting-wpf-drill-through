using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Core.Commands;
using DevExpress.Xpf.Printing;
using DevExpress.Xpf.Mvvm;
using Reports;
// ...

namespace Viewer {
    public partial class MainWindowViewModel : INotifyPropertyChanged {
        /// <summary>
        /// Initializes a new instance of the MainWindowViewModel class.
        /// </summary>
        public MainWindowViewModel() {
            OrderId = 5;
            ButtonVisible = Visibility.Collapsed;
            ShowOrdersCommand = new DevExpress.Xpf.Mvvm.DelegateCommand<object>(ShowOrders);

            orderReport = new OrderReport();
            ReportModel = new XtraReportPreviewModel { Report = orderReport };
            orderReport.CreateDocument();

            ReportModel.PreviewMouseMove += ReportModel_PreviewMouseMove;
            ReportModel.PreviewClick += ReportModel_PreviewClick;
        }
        
        void ReportModel_PreviewMouseMove(object sender, PreviewClickEventArgs e) {
            if(string.IsNullOrEmpty(e.ElementTag)) {
                return;
            }
            OrderId = int.Parse(e.ElementTag);
            e.Element.Cursor = Cursors.Hand;
        }

        void ReportModel_PreviewClick(object sender, PreviewClickEventArgs e) {
            if(string.IsNullOrEmpty(e.ElementTag)) {
                return;
            }
            OrderId = int.Parse(e.ElementTag);
            var invoiceReport = new InvoiceReport();
            invoiceReport.Parameters["OrderId"].Value = OrderId;

            ReportModel.Report = invoiceReport;
            invoiceReport.CreateDocument();
            ButtonVisible = Visibility.Visible;
        }
    }
}
