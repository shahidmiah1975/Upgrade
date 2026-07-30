# Discovery (partial)

I started scanning EZMenu.zip and located the following files and folders (partial list extracted from zip content). I will finish the full extraction and classification next.

core/
  Enums/Enum.cs
  Models/AFDAddressModel.cs
  Models/CartModel.cs
  Models/CollectionDrinksModel.cs
  Models/CustomerModel.cs
  Models/CustomerOrderModel.cs
  Models/DiscountsAndChargesModel.cs
  Models/GroupModel.cs
  Models/ModifierModel.cs
  Models/OrderInfoModel.cs
  Models/OrderModsModel.cs
  Models/TableBillModel.cs

EZMenu/
  app.config
  EZMenuDataSet.Designer.vb
  ApplicationEvents.*
  Classes/
    clsCustomer.vb
    clsDatabase.vb
    clsDish.vb
    clsFakeOrder.vb
    clsPrintInitiate.vb
    clsPrintOrder.vb
    clsTable.vb
    Customer.vb
    Customer.vb (appears multiple times in zip)
    clsPrintOrder.vb
    ... (many .vb class & form files)
  Enums/Enums.vb

Notes & next steps:
- I will finish parsing the full zip content and produce a comprehensive list of all ~40 forms, identifying which are Forms (System.Windows.Forms.Form), UserControls, or pure service classes.
- For each Form I will emit:
  - filename
  - detected designer file
  - likely purpose (one-line)
  - complexity (Low / Medium / High)
  - dependencies (uses printing, uses DataSet, custom control usage)

Deliverable ETA: within today I will push the full discovery file listing to this branch and then scaffold the solution skeleton and converted core models.
