<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128599444/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E3357)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->
# Reporting for WPF - Create a Drill-through Report

This example shows a **drill-through report** in a WPF application. This report type keeps the original report compact while still allowing access to more detailed information.

The drill-trough report type requires **a parameter binding** to display connected data. You also need to set **a filter string** in the detail report to display product records for the selected category. See the guide for more detailed steps: [Create Drill-Through Reports](https://docs.devexpress.com/XtraReports/4789).

In the app, you can click a _Category_ entry to invoke a detail report with products:

![Reporting for WPF - Click on a Drill-through Report](Images/main-report.png)

Use breadcrumbs to navigate back to the original report. The breadcrumb control automatically appear below the Document Viewer toolbar:

![Reporting for WPF - Go back in a Drill-through Report](Images/detailed-report.png)


## Files to Review

* [MainWindow.xaml.cs](./CS/MainWindow.xaml.cs) 
* [MainWindow.xaml](./CS/MainWindow.xaml)

## Documentation

- [Create Drill-Through Reports](https://docs.devexpress.com/XtraReports/4789/detailed-guide-to-devexpress-reporting/provide-interactivity/create-drill-through-reports)

## More Examples

- [Reporting for WPF - Create a Drill-through Report in Code](https://github.com/DevExpress-Examples/Reporting_documentpreviewcontrol-how-to-create-a-drill-down-report-runtime-sample-t337482)
- [Reporting for WinForms - Create a Drill-through Report](https://github.com/DevExpress-Examples/reporting-winforms-drill-through)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-drill-through&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-wpf-drill-through&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
