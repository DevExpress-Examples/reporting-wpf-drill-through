Imports System.ComponentModel
Imports System.Windows
Imports DevExpress.Xpf.Core.Commands
Imports DevExpress.Xpf.Printing
Imports Reports

Namespace Viewer

    Public Partial Class MainWindowViewModel

        Private _ShowOrdersCommand As DelegateCommand(Of Object)

        Private ReadOnly orderReport As OrderReport

        Private orderIdField As Integer

        Public Property OrderId As Integer
            Get
                Return orderIdField
            End Get

            Set(ByVal value As Integer)
                If orderIdField <> value Then
                    orderIdField = value
                    OnPropertyChanged("OrderId")
                End If
            End Set
        End Property

        Private buttonVisibleField As Visibility

        Public Property ButtonVisible As Visibility
            Get
                Return buttonVisibleField
            End Get

            Set(ByVal value As Visibility)
                If buttonVisibleField <> value Then
                    buttonVisibleField = value
                    OnPropertyChanged("ButtonVisible")
                End If
            End Set
        End Property

        Public Property ShowOrdersCommand As DelegateCommand(Of Object)
            Get
                Return _ShowOrdersCommand
            End Get

            Private Set(ByVal value As DelegateCommand(Of Object))
                _ShowOrdersCommand = value
            End Set
        End Property

        Public Property ReportModel As XtraReportPreviewModel

        Private Sub ShowOrders(ByVal o As Object)
            ReportModel.Report.Dispose()
            ReportModel.Report = orderReport
            ButtonVisible = Visibility.Collapsed
        End Sub

'#Region "INotifyPropertyChanged"
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged

        Private Sub OnPropertyChanged(ByVal propertyName As String)
            RaiseEvent PropertyChanged(Me, New PropertyChangedEventArgs(propertyName))
        End Sub
'#End Region
    End Class
End Namespace
