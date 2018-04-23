using System.ComponentModel;
using System.Windows;
using DevExpress.Xpf.Core.Commands;
using DevExpress.Xpf.Printing;
using Reports;

namespace Viewer {
    public partial class MainWindowViewModel {
        readonly OrderReport orderReport;

        int orderId;
        public int OrderId {
            get {
                return orderId;
            }
            set {
                if(orderId != value) {
                    orderId = value;
                    OnPropertyChanged("OrderId");
                }
            }
        }

        Visibility buttonVisible;
        public Visibility ButtonVisible {
            get {
                return buttonVisible;
            }
            set {
                if(buttonVisible != value) {
                    buttonVisible = value;
                    OnPropertyChanged("ButtonVisible");
                }
            }
        }

        public DelegateCommand<object> ShowOrdersCommand { get; private set; }
        public XtraReportPreviewModel ReportModel { get; set; }

        void ShowOrders(object o) {
            ReportModel.Report.Dispose();
            ReportModel.Report = orderReport;
            ButtonVisible = Visibility.Collapsed;
        }

        #region INotifyPropertyChanged
        public event PropertyChangedEventHandler PropertyChanged;
        void OnPropertyChanged(string propertyName) {
            if(PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
    }
}
