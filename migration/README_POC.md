# EZMenu WPF POC README

This branch contains a scaffold for migrating EZMenu (VB WinForms) to C# WPF (.NET 10) and a small POC app.

How to open and run the POC (locally):
1. Ensure .NET 10 SDK is installed on your machine.
2. From the repository root, in a terminal run:
   - dotnet build EZMenu.UI.Wpf/EZMenu.UI.Wpf.csproj
   - dotnet run --project EZMenu.UI.Wpf/EZMenu.UI.Wpf.csproj

The POC shows a minimal MainWindow and an OrderView with sample data and a Print stub.

Next steps:
- Continue discovery mapping of all forms and mark complexity.
- Convert additional core models found in core/Models/*.vb to EZMenu.Core project.
- Convert targeted Form -> View/ViewModel for prioritized screens.
