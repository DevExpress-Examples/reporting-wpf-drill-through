Imports DevExpress.Mvvm.DataAnnotations
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraReports.UI
Imports Reports
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Text
Imports System.Windows.Input

Namespace Viewer
    <POCOViewModel> _
    Public Class MainViewModel
        Private ReadOnly orderReport As XtraReport = New OrderReport()

        Private privateReport As XtraReport
        Public Overridable Property Report() As XtraReport
            Get
                Return privateReport
            End Get
            Protected Set(ByVal value As XtraReport)
                privateReport = value
            End Set
        End Property
        Public Overridable Property RequestDocumentCreation() As Boolean
        Public Overridable Property OrderId() As Integer

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

            Dim orderId_Renamed = CType(args.ElementTag, Integer?)
            If Not orderId_Renamed.HasValue Then
                Return
            End If
            OrderId = orderId_Renamed.Value
            Dim invoiceReport = New InvoiceReport()
            invoiceReport.Parameters("OrderId").Value = OrderId
            Report = invoiceReport
        End Sub

        Public Sub OnPreviewMouseMove(ByVal args As DocumentPreviewMouseEventArgs)

            Dim orderId_Renamed = CType(args.ElementTag, Integer?)
            If Not orderId_Renamed.HasValue Then
                Return
            End If
            OrderId = orderId_Renamed.Value
            Mouse.SetCursor(Cursors.Hand)
        End Sub
    End Class
End Namespace
