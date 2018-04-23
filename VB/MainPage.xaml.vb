Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Net
Imports System.Windows
Imports System.Windows.Controls
Imports System.Windows.Documents
Imports System.Windows.Input
Imports System.Windows.Media
Imports System.Windows.Media.Animation
Imports System.Windows.Shapes
Imports DevExpress.Xpf.NavBar
Imports System.Windows.Data
Imports System.Globalization

Namespace AgNavBarCustomTheme
	Partial Public Class MainPage
		Inherits UserControl
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub RadioButton_Checked(ByVal sender As Object, ByVal e As RoutedEventArgs)
			If navBar Is Nothing Then
				Return
			End If

			Dim view As String = TryCast((CType(sender, RadioButton)).Content, String)

			Select Case view
				Case "ExplorerBar"
					navBar.View = New ExplorerBarView()
				Case "NavigationPane"
					navBar.View = New NavigationPaneView()
				Case "SideBar"
					navBar.View = New SideBarView()
			End Select
		End Sub
	End Class

	Public Class BooleanToAgleConverter
		Implements IValueConverter
		Public Function Convert(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.Convert
			Return If(CBool(value), 0R, System.Convert.ToDouble(parameter, CultureInfo.InvariantCulture))
		End Function

		Public Function ConvertBack(ByVal value As Object, ByVal targetType As Type, ByVal parameter As Object, ByVal culture As System.Globalization.CultureInfo) As Object Implements IValueConverter.ConvertBack
			Throw New NotImplementedException()
		End Function
	End Class
End Namespace
