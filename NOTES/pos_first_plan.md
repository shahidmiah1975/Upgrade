# POS-first migration checklist

This file records the immediate plan after adding CI and the backlog.

1. CI was added: .github/workflows/dotnet-build.yml — it detects a .sln and runs restore/build/test. If none found it exits cleanly.
2. Priority: Main POS / Order screen migration (WPF View + ViewModel).
3. Next actions:
   - Finish automated extraction/classification of every file inside EZMenu.zip and produce a detailed CSV (LOC, designer?, 3rd-party controls) and commit to migrate/ezmenu-wpf-poc.
   - Create the initial C# solution skeleton (EZMenu.sln) with projects:
     - EZMenu.Core (classlib)
     - EZMenu.Data (classlib)
     - EZMenu.Services (classlib)
     - EZMenu.UI.Wpf (wpf)
     - EZMenu.Tests (xunit)
   - Port core POCOs -> EZMenu.Core
   - Port typed DataSet wrappers (minimal) -> EZMenu.Data
   - Build POS ViewModel and a minimal View in EZMenu.UI.Wpf that shows a table/order list and can add/remove items.
