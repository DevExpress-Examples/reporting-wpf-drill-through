using DevExpress.Mvvm;
using DevExpress.Xpf.Core;
using DevExpress.Xpf.Printing;
using DevExpress.XtraReports;
using DevExpress.XtraReports.UI;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

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