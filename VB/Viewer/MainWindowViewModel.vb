Imports System.ComponentModel
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Core.Commands
Imports DevExpress.Xpf.Printing
Imports Reports

' ...
Namespace Viewer

    Public Partial Class MainWindowViewModel
        Implements INotifyPropertyChanged

        ''' <summary>
        ''' Initializes a new instance of the MainWindowViewModel class.
        ''' </summary>
        Public Sub New()
            OrderId = 5
            ButtonVisible = Visibility.Collapsed
            ShowOrdersCommand = New DelegateCommand(Of Object)(AddressOf ShowOrders)
            orderReport = New OrderReport()
            ReportModel = New XtraReportPreviewModel With {.Report = orderReport}
            orderReport.CreateDocument()
            AddHandler ReportModel.PreviewMouseMove, AddressOf ReportModel_PreviewMouseMove
            AddHandler ReportModel.PreviewClick, AddressOf ReportModel_PreviewClick
        End Sub

        Private Sub ReportModel_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
            If String.IsNullOrEmpty(e.ElementTag) Then
                Return
            End If

            OrderId = Integer.Parse(e.ElementTag)
            e.Element.Cursor = Cursors.Hand
        End Sub

        Private Sub ReportModel_PreviewClick(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
            If String.IsNullOrEmpty(e.ElementTag) Then
                Return
            End If

            OrderId = Integer.Parse(e.ElementTag)
            Dim invoiceReport = New InvoiceReport()
            invoiceReport.Parameters("OrderId").Value = OrderId
            ReportModel.Report = invoiceReport
            invoiceReport.CreateDocument()
            ButtonVisible = Visibility.Visible
        End Sub
    End Class
End Namespace
