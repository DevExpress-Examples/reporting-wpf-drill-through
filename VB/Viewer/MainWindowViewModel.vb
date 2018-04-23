Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.Windows
Imports System.Windows.Input
Imports DevExpress.Xpf.Core.Commands
Imports DevExpress.Xpf.Printing
Imports DevExpress.XtraReports
Imports Reports
' ...

Namespace Viewer
	Public Class MainWindowViewModel
		Implements INotifyPropertyChanged
		''' <summary>
		''' Initializes a new instance of the MainWindowViewModel class.
		''' </summary>
		Public Sub New()
			OrderId = 5
			ButtonVisible = Visibility.Collapsed
			_ShowOrdersCommand = New DelegateCommand(Of Object)(AddressOf ShowOrders)
			ReportModel = New XtraReportPreviewModel()
			Dim report = New OrderReport()

			ReportModel.Report = CType(report, IReport)
			report.CreateDocument()

			AddHandler ReportModel.PreviewMouseMove, AddressOf ReportModel_PreviewMouseMove
			AddHandler ReportModel.PreviewClick, AddressOf ReportModel_PreviewClick
		End Sub

		Protected Sub ReportModel_PreviewClick(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
			If e.ElementTag IsNot Nothing AndAlso (Not e.ElementTag.Equals(String.Empty)) Then
				OrderId = Integer.Parse(e.ElementTag)
				Dim invoice = New InvoiceReport()
				invoice.Parameters("OrderId").Value = OrderId

				ReportModel.Report = CType(invoice, IReport)
				invoice.CreateDocument()
				ButtonVisible = Visibility.Visible
			End If
		End Sub

		Protected Sub ReportModel_PreviewMouseMove(ByVal sender As Object, ByVal e As PreviewClickEventArgs)
			If e.ElementTag IsNot Nothing AndAlso (Not e.ElementTag.Equals(String.Empty)) Then
				OrderId = Integer.Parse(e.ElementTag)
				e.Control.Cursor = Cursors.Hand

			End If
		End Sub

		Protected Sub ShowOrders(ByVal o As Object)
			Dim report = New OrderReport()
			ReportModel.Report = CType(report, IReport)
			report.CreateDocument()

			ButtonVisible = Visibility.Collapsed
		End Sub

		Private _OrderId As Integer
		Public Property OrderId() As Integer
			Get
				Return _OrderId
			End Get
			Set(ByVal value As Integer)
				If _OrderId <> value Then
					_OrderId = value
					OnPropertyChanged("OrderId")
				End If
			End Set
		End Property

		Private _ButtonVisible As Visibility
		Public Property ButtonVisible() As Visibility
			Get
				Return _ButtonVisible
			End Get
			Set(ByVal value As Visibility)
				If _ButtonVisible <> value Then
					_ButtonVisible = value
					OnPropertyChanged("ButtonVisible")
				End If
			End Set
		End Property

		Private _ShowOrdersCommand As DelegateCommand(Of Object)
		Public ReadOnly Property ShowOrdersCommand() As DelegateCommand(Of Object)
			Get
				Return _ShowOrdersCommand
			End Get
		End Property

		Private privateReportModel As XtraReportPreviewModel
		Public Property ReportModel() As XtraReportPreviewModel
			Get
				Return privateReportModel
			End Get
			Set(ByVal value As XtraReportPreviewModel)
				privateReportModel = value
			End Set
		End Property

		Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
		Public Overridable Sub OnPropertyChanged(ByVal [property] As String)
			Dim handler As PropertyChangedEventHandler = PropertyChangedEvent
			If handler IsNot Nothing Then
				handler(Me, New PropertyChangedEventArgs([property]))
			End If
		End Sub
	End Class
End Namespace
