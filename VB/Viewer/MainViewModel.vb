Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraReports.UI
Imports Reports
Imports System.Windows.Input

Namespace Viewer

    <POCOViewModel>
    Public Class MainViewModel

        Private ReadOnly orderReport As XtraReport = New OrderReport()

        Public Overridable Property Report As XtraReport

        Public Overridable Property RequestDocumentCreation As Boolean

        Public Overridable Property OrderId As Integer

        Protected Sub New()
            RequestDocumentCreation = True
            Report = orderReport
        End Sub

        Public Sub ShowOrders()
            Report.Dispose()
            RequestDocumentCreation = False
            Report = orderReport
            RequestDocumentCreation = True
        End Sub

        Public Function CanShowOrders() As Boolean
            Return Report IsNot orderReport
        End Function

        Public Sub OnPreviewMouseClick(ByVal args As DocumentPreviewMouseEventArgs)
            Dim orderId = CType(args.ElementTag, Integer?)
            If Not orderId.HasValue Then Return
            Me.OrderId = orderId.Value
            Dim invoiceReport = New InvoiceReport()
            invoiceReport.Parameters("OrderId").Value = Me.OrderId
            Report = invoiceReport
        End Sub

        Public Sub OnPreviewMouseMove(ByVal args As DocumentPreviewMouseEventArgs)
            Dim orderId = CType(args.ElementTag, Integer?)
            If Not orderId.HasValue Then Return
            Me.OrderId = orderId.Value
            Mouse.SetCursor(Cursors.Hand)
        End Sub
    End Class
End Namespace
