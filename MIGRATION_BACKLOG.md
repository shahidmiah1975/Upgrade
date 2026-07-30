# EZMenu migration backlog

This repository branch contains the migration discovery backlog for the EZMenu WinForms/VB.NET project to a WPF/C# solution. The list below was generated from the EZMenu.zip archive found at commit 10db94ef66f4960273c07ba40a3b3d3ce7610d82.

Format: Path in archive -> Suggested target project/path -> Notes & Complexity

- CORE/EZMenu.Core/Enums/Enum.cs -> EZMenu.Core/Enums/Enum.cs -> Domain enums (Low)
- CORE/EZMenu.Core/Models/AFDAddressModel.cs -> EZMenu.Core/Models/AFDAddressModel.cs -> POCO (Low)
- CORE/EZMenu.Core/Models/CartModel.cs -> EZMenu.Core/Models/CartModel.cs -> POCO (Low)
- CORE/EZMenu.Core/Models/CollectionDrinksModel.cs -> EZMenu.Core/Models/CollectionDrinksModel.cs -> POCO (Low)
- CORE/EZMenu.Core/Models/CustomerModel.cs -> EZMenu.Core/Models/CustomerModel.cs -> POCO (Low)
- CORE/EZMenu.Core/Models/CustomerOrderModel.cs -> EZMenu.Core/Models/CustomerOrderModel.cs -> POCO (Low)
- CORE/EZMenu.Core/Models/DiscountsAndChargesModel.cs -> EZMenu.Core/Models/DiscountsAndChargesModel.cs -> POCO (Low–Medium)
- CORE/EZMenu.Core/Models/GroupModel.cs -> EZMenu.Core/Models/GroupModel.cs -> POCO (Low)
- CORE/EZMenu.Core/Models/ModifierModel.cs -> EZMenu.Core/Models/ModifierModel.cs -> POCO/Logic (Low–Medium)
- CORE/EZMenu.Core/Models/OrderInfoModel.cs -> EZMenu.Core/Models/OrderInfoModel.cs -> POCO (Low–Medium)
- CORE/EZMenu.Core/Models/OrderModsModel.cs -> EZMenu.Core/Models/OrderModsModel.cs -> POCO (Low–Medium)
- CORE/EZMenu.Core/Models/TableBillModel.cs -> EZMenu.Core/Models/TableBillModel.cs -> POCO (Low–Medium)
- EZMenu/app.config -> EZMenu.UI.Wpf/appsettings.json -> Convert settings; secrets migrate (Low)
- EZMenu/EZMenuDataSet.Designer.vb -> EZMenu.Data/EZMenuDataSet.* -> Port typed DataSet; plan refactor (Medium)
- EZMenu/ApplicationEvents.* -> EZMenu.UI.Wpf/App.xaml.cs -> Startup/event wiring (Low–Medium)
- EZMenu/Classes/clsDatabase.vb -> EZMenu.Data/DatabaseService.cs -> DB helper (Medium)
- EZMenu/Classes/clsCustomer.vb -> EZMenu.Services/CustomerService.cs -> Business logic (Low–Medium)
- EZMenu/Classes/clsDish.vb -> EZMenu.Core/Models + EZMenu.Services/DishService.cs -> (Low–Medium)
- EZMenu/Classes/clsTable.vb -> EZMenu.Services/TableService.cs + ViewModels -> (Medium)
- EZMenu/Classes/clsFakeOrder.vb -> tests/Seed/FakeOrderSeeder.cs -> Test/sample seed (Low)
- EZMenu/Classes/clsPrintInitiate.vb -> EZMenu.Services/PrintService.cs -> Printing adapter (High)
- EZMenu/Classes/clsPrintOrder.vb -> EZMenu.Services/PrintService.cs -> Printing logic (High)
- EZMenu/Classes/Customer.vb -> EZMenu.UI.Wpf/Views/CustomerView.xaml + ViewModels/CustomerViewModel.cs -> (Medium)
- EZMenu/Enums/Enums.vb -> EZMenu.Core/Enums/*.cs -> Convert enums (Low)

Notes:
- The branch `migrate/ezmenu-wpf-poc` already existed and I will commit this backlog file there.
- This backlog is a starting point; next step is to extract each .vb file to inspect for Forms vs services, detect designer files, detect dependencies, and produce a CSV with exact file counts and migration estimates.

What I pushed in this commit:
- migrate/ezmenu-wpf-poc/MIGRATION_BACKLOG.md

Next: I will extract all file entries and produce a detailed CSV (file, type, lines, forms?, designers?, suggested target, rough hours).