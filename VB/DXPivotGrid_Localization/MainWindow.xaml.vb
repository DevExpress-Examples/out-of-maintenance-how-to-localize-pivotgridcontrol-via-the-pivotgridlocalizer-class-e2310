Imports System.Windows
Imports System.Windows.Data
Imports DevExpress.XtraPivotGrid.Localization
Imports DXPivotGrid_Localization.DataSet1TableAdapters

Namespace DXPivotGrid_Localization

    Public Partial Class MainWindow
        Inherits Window

        Private salesPersonDataTable As DataSet1.SalesPersonDataTable = New DataSet1.SalesPersonDataTable()

        Private salesPersonDataAdapter As SalesPersonTableAdapter = New SalesPersonTableAdapter()

        Public Sub New()
            PivotGridLocalizer.Active = New CustomDXPivotGridLocalizer()
            Me.InitializeComponent()
            Me.pivotGridControl1.DataSource = salesPersonDataTable
        End Sub

        Private Sub Window_Loaded(ByVal sender As Object, ByVal e As RoutedEventArgs)
            salesPersonDataAdapter.Fill(salesPersonDataTable)
            Dim nwindDataSet As DataSet1 = CType(FindResource("nwindDataSet"), DataSet1)
            Dim nwindDataSetCategoryProductsTableAdapter As CategoryProductsTableAdapter = New CategoryProductsTableAdapter()
            nwindDataSetCategoryProductsTableAdapter.Fill(nwindDataSet.CategoryProducts)
            Dim categoryProductsViewSource As CollectionViewSource = CType(FindResource("categoryProductsViewSource"), CollectionViewSource)
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
