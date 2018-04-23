Imports System.ComponentModel
Imports System.Windows
Imports DevExpress.Xpf.Core.Commands
Imports DevExpress.Xpf.Printing
Imports Reports

Namespace Viewer
    Partial Public Class MainWindowViewModel
        ReadOnly _OrderReport As OrderReport

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

        Public Property ShowOrdersCommand() As DelegateCommand(Of Object)
        Public Property ReportModel() As XtraReportPreviewModel

#Region "INotifyPropertyChanged"
        Public Event PropertyChanged As PropertyChangedEventHandler Implements INotifyPropertyChanged.PropertyChanged
        Public Overridable Sub OnPropertyChanged(ByVal propertyName As String)
            If PropertyChangedEvent IsNot Nothing Then
                PropertyChangedEvent(Me, New PropertyChangedEventArgs(propertyName))
            End If
        End Sub
#End Region
    End Class
End Namespace
