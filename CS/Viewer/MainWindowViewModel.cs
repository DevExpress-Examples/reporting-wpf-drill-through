using System.ComponentModel;
using System.Windows;
using System.Windows.Input;
using DevExpress.Xpf.Core.Commands;
using DevExpress.Xpf.Printing;
using DevExpress.XtraReports;
using Reports;
// ...

namespace Viewer {
    public class MainWindowViewModel : INotifyPropertyChanged {
        /// <summary>
        /// Initializes a new instance of the MainWindowViewModel class.
        /// </summary>
        public MainWindowViewModel() {
            OrderId = 5;
            ButtonVisible = Visibility.Collapsed;
            _ShowOrdersCommand = new DelegateCommand<object>(ShowOrders);
            ReportModel = new XtraReportPreviewModel();
            var report = new OrderReport();

            ReportModel.Report = (IReport)report;
            report.CreateDocument();

            ReportModel.PreviewMouseMove += ReportModel_PreviewMouseMove;
            ReportModel.PreviewClick += ReportModel_PreviewClick;
        }

        protected void ReportModel_PreviewClick(object sender, PreviewClickEventArgs e) {
            if (e.ElementTag != null && !e.ElementTag.Equals(string.Empty)) {
                OrderId = int.Parse(e.ElementTag);
                var invoice = new InvoiceReport();
                invoice.Parameters["OrderId"].Value = OrderId;

                ReportModel.Report = (IReport)invoice;
                invoice.CreateDocument();
                ButtonVisible = Visibility.Visible;
            }
        }

        protected void ReportModel_PreviewMouseMove(object sender, PreviewClickEventArgs e) {
            if (e.ElementTag != null && !e.ElementTag.Equals(string.Empty)) {
                OrderId = int.Parse(e.ElementTag);
                e.Control.Cursor = Cursors.Hand;

            }
        }

        protected void ShowOrders(object o) {
            var report = new OrderReport();
            ReportModel.Report = (IReport)report;
            report.CreateDocument();

            ButtonVisible = Visibility.Collapsed;
        }

        private int _OrderId;
        public int OrderId {
            get {
                return _OrderId;
            }
            set {
                if (_OrderId != value) {
                    _OrderId = value;
                    OnPropertyChanged("OrderId");
                }
            }
        }

        private Visibility _ButtonVisible;
        public Visibility ButtonVisible {
            get {
                return _ButtonVisible;
            }
            set {
                if (_ButtonVisible != value) {
                    _ButtonVisible = value;
                    OnPropertyChanged("ButtonVisible");
                }
            }
        }

        private DelegateCommand<object> _ShowOrdersCommand;
        public DelegateCommand<object> ShowOrdersCommand {
            get {
                return _ShowOrdersCommand;
            }
        }

        public XtraReportPreviewModel ReportModel { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;
        public virtual void OnPropertyChanged(string property) {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, new PropertyChangedEventArgs(property));
        }
    }
}
