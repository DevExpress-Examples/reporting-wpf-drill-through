Imports DevExpress.Mvvm
Imports DevExpress.Xpf.Core
Imports DevExpress.XtraReports.UI
Imports WpfAppVb.Drill_through_example

Public Class MainWindow
    Inherits ThemedWindow

    Public Sub New()
        InitializeComponent()
        DataContext = New ViewModel(New XtraReportCategories())
    End Sub
End Class

Public Class ViewModel
    Inherits BindableBase
    Public ReadOnly Property Report() As XtraReport
    Public Sub New()
    End Sub
    Public Sub New(ByVal report As XtraReport)
        Me.Report = report
    End Sub
End Class