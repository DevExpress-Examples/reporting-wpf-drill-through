Imports System.ComponentModel
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Core.Commands
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraReports
Imports Reports
' ...

Namespace Viewer
    Partial Public Class MainWindowViewModel
        Implements INotifyPropertyChanged
        ''' <summary>
        ''' Initializes a new instance of the MainWindowViewModel class.
        ''' </summary>
        Public Sub New()
            OrderId = 5
            ButtonVisible = Visibility.Collapsed
            ShowOrdersCommand = New DelegateCommand(Of Object)(AddressOf ShowOrders)

            _OrderReport = New OrderReport()
            ReportModel = New XtraReportPreviewModel With {.Report = _OrderReport}
            _OrderReport.CreateDocument()

            AddHandler ReportModel.PreviewMouseMove, AddressOf ReportModel_PreviewMouseMove
            AddHandler ReportModel.PreviewClick, AddressOf ReportModel_PreviewClick
        End Sub

        Sub ReportModel_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
            If String.IsNullOrEmpty(e.ElementTag) Then
                Return
            End If
            OrderId = Integer.Parse(e.ElementTag)
            e.Element.Cursor = Cursors.Hand
        End Sub

        Sub ReportModel_PreviewClick(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
            If String.IsNullOrEmpty(e.ElementTag) Then
                Return
            End If
            OrderId = Integer.Parse(e.ElementTag)
            Dim invoice = New InvoiceReport()
            invoice.Parameters("OrderId").Value = OrderId

            ReportModel.Report = invoice
            invoice.CreateDocument()
            ButtonVisible = Visibility.Visible
        End Sub

        Protected Sub ShowOrders(ByVal o As Object)
            ReportModel.Report.Dispose()
            ReportModel.Report = _OrderReport
            ButtonVisible = Visibility.Collapsed
        End Sub
    End Class
End Namespace
