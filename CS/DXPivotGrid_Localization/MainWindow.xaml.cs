using System.Windows;
using System.Windows.Data;
using DevExpress.XtraPivotGrid.Localization;
using DXPivotGrid_Localization.DataSet1TableAdapters;

namespace DXPivotGrid_Localization {
    public partial class MainWindow : Window {
        DataSet1.SalesPersonDataTable salesPersonDataTable = new DataSet1.SalesPersonDataTable();
        SalesPersonTableAdapter salesPersonDataAdapter = new SalesPersonTableAdapter();
        public MainWindow() {
            PivotGridLocalizer.Active = new CustomDXPivotGridLocalizer();
            InitializeComponent();
            pivotGridControl1.DataSource = salesPersonDataTable;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e) {
            salesPersonDataAdapter.Fill(salesPersonDataTable);
            DataSet1 nwindDataSet = ((DataSet1)(this.FindResource("nwindDataSet")));
            CategoryProductsTableAdapter nwindDataSetCategoryProductsTableAdapter = 
                new CategoryProductsTableAdapter();
            nwindDataSetCategoryProductsTableAdapter.Fill(nwindDataSet.CategoryProducts);
            CollectionViewSource categoryProductsViewSource = 
                ((CollectionViewSource)(this.FindResource("categoryProductsViewSource")));
            categoryProductsViewSource.View.MoveCurrentToFirst();
        }
    }
    public class CustomDXPivotGridLocalizer : PivotGridLocalizer {
        public override string GetLocalizedString(PivotGridStringId id) {
            switch (id) {
                case PivotGridStringId.GrandTotal:
                    return "Aggregate Total";
                case PivotGridStringId.TotalFormat:
                    return "Total for {0}";
                case PivotGridStringId.FilterHeadersCustomization:
                    return "Filter Header Area is currently empty";
                default:
                    return base.GetLocalizedString(id);
            }
        }
    }
}
