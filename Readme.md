<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128578804/10.1.6%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2310)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [MainWindow.xaml](./CS/DXPivotGrid_Localization/MainWindow.xaml) (VB: [MainWindow.xaml](./VB/DXPivotGrid_Localization/MainWindow.xaml))
* [MainWindow.xaml.cs](./CS/DXPivotGrid_Localization/MainWindow.xaml.cs) (VB: [MainWindow.xaml.vb](./VB/DXPivotGrid_Localization/MainWindow.xaml.vb))
<!-- default file list end -->
# How to localize PivotGridControl via the PivotGridLocalizer class


<p>The following example shows how to localize PivotGridControl via the PivotGridLocalizer class.</p><p>In this example, grand total headers ('Grand Total' by default) are replaced with 'Aggregate Total' strings, automatic total headers' patterns ('{0} Total' by default) are replaced with 'Total for {0}' strings, and the text displayed within the Filter Header Area ('Drop Filter Fields Here' by default) is replaced with 'Filter Header Area is currently empty' string. To do this, a PivotGridLocalizer class descendant (CustomDXPivotGridLocalizer) has been created, and its GetLocalizedString method has been overridden to replace the default strings.</p>

<br/>


