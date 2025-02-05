using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
using DevExpress.XtraReports.UI;

namespace WpfApp1 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : ThemedWindow {
        public MainWindow() {
            InitializeComponent();
            DataContext = new ViewModel(new XtraReportCategories());
            XtraReportCategories report = new XtraReportCategories();
            window.DocumentSource = report;

        }
        public class ViewModel : BindableBase {
            public XtraReport Report { get; } = new XtraReport();
            public ViewModel() { }
            public ViewModel(XtraReport report) => Report = report;
        }
    }
}