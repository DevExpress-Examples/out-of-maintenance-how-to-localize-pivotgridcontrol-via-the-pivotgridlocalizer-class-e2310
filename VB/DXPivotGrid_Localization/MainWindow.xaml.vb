Imports System.Windows
Imports System.Windows.Data
Imports DevExpress.XtraPivotGrid.Localization
Imports DXPivotGrid_Localization.DataSet1TableAdapters

Namespace DXPivotGrid_Localization
	Partial Public Class MainWindow
		Inherits Window

'INSTANT VB NOTE: The variable salesPersonDataTable was renamed since it may cause conflicts with calls to static members of the user-defined type with this name:
		Private salesPersonDataTable_Conflict As New DataSet1.SalesPersonDataTable()
		Private salesPersonDataAdapter As New SalesPersonTableAdapter()
		Public Sub New()
			PivotGridLocalizer.Active = New CustomDXPivotGridLocalizer()
			InitializeComponent()
			pivotGridControl1.DataSource = salesPersonDataTable_Conflict
		End Sub
		Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
			salesPersonDataAdapter.Fill(salesPersonDataTable_Conflict)
			Dim nwindDataSet As DataSet1 = (DirectCast(Me.FindResource("nwindDataSet"), DataSet1))
			Dim nwindDataSetCategoryProductsTableAdapter As New CategoryProductsTableAdapter()
			nwindDataSetCategoryProductsTableAdapter.Fill(nwindDataSet.CategoryProducts)
			Dim categoryProductsViewSource As CollectionViewSource = (DirectCast(Me.FindResource("categoryProductsViewSource"), CollectionViewSource))
			categoryProductsViewSource.View.MoveCurrentToFirst()
		End Sub
	End Class
	Public Class CustomDXPivotGridLocalizer
		Inherits PivotGridLocalizer

		Public Overrides Function GetLocalizedString(ByVal id As PivotGridStringId) As String
			Select Case id
				Case PivotGridStringId.GrandTotal
					Return "Aggregate Total"
				Case PivotGridStringId.TotalFormat
					Return "Total for {0}"
				Case PivotGridStringId.FilterHeadersCustomization
					Return "Filter Header Area is currently empty"
				Case Else
					Return MyBase.GetLocalizedString(id)
			End Select
		End Function
	End Class
End Namespace
