Imports Microsoft.VisualBasic
Imports System.ComponentModel
Imports System.Windows
Imports DevExpress.Xpf.Core.Commands
Imports DevExpress.Xpf.Printing
Imports Reports

Namespace Viewer
	Partial Public Class MainWindowViewModel
		Private ReadOnly orderReport As OrderReport

		Private orderId_Renamed As Integer
		Public Property OrderId() As Integer
			Get
				Return orderId_Renamed
			End Get
			Set(ByVal value As Integer)
				If orderId_Renamed <> value Then
					orderId_Renamed = value
					OnPropertyChanged("OrderId")
				End If
			End Set
		End Property

		Private buttonVisible_Renamed As Visibility
		Public Property ButtonVisible() As Visibility
			Get
				Return buttonVisible_Renamed
			End Get
			Set(ByVal value As Visibility)
				If buttonVisible_Renamed <> value Then
					buttonVisible_Renamed = value
					OnPropertyChanged("ButtonVisible")
				End If
			End Set
		End Property

		Private privateShowOrdersCommand As DevExpress.Xpf.Mvvm.DelegateCommand(Of Object)
		Public Property ShowOrdersCommand() As DevExpress.Xpf.Mvvm.DelegateCommand(Of Object)
			Get
				Return privateShowOrdersCommand
			End Get
			Private Set(ByVal value As DevExpress.Xpf.Mvvm.DelegateCommand(Of Object))
				privateShowOrdersCommand = value
			End Set
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

		Private Sub ShowOrders(ByVal o As Object)
			ReportModel.Report.Dispose()
			ReportModel.Report = orderReport
			ButtonVisible = Visibility.Collapsed
		End Sub

		#Region "INotifyPropertyChanged"
		Public Event PropertyChanged As PropertyChangedEventHandler
		Private Sub OnPropertyChanged(ByVal propertyName As String)
			RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
		End Sub
		#End Region
	End Class
End Namespace
