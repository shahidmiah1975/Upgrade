# EZMenu WPF Migration Plan

This branch: migrate/ezmenu-wpf-poc

Purpose: hold scaffold and migration artifacts for converting the EZMenu WinForms VB app into a C# WPF (MVVM) .NET 10 solution.

Phase 0 — Discovery (in progress)
- Extract all VB forms, designers, resources and core models from EZMenu.zip.
- Produce a mapping: Form -> View + ViewModel + complexity.

Phase 1 — Scaffold & POC
- Create solution: EZMenu.sln with projects:
  - EZMenu.Core (C#)
  - EZMenu.Data (C#)
  - EZMenu.Services (C#)
  - EZMenu.UI.Wpf (C# WPF, net10.0)
- Add MVVM helpers: CommunityToolkit.Mvvm
- Convert core models (POCOs) to C#.
- Convert one high-value screen to WPF MVVM as proof-of-concept.

Phase 2 — Incremental migration
- Migrate UI screens in priority order, one PR at a time.
- Replace DataSet code with repository layer (Dapper/EF Core) as schedule allows.

Phase 3 — Polish & Handover
- Tests, CI, packaging, documentation.

Notes:
- Short-term approach: port typed DataSets to C# wrappers to reduce risk.
- Printing and custom WinForms controls may require rework; they will be flagged during Discovery.

Next immediate actions I will perform:
1. Complete the full Discovery list (forms, controls, services). Deliverable: forms mapping file.
2. Scaffold the .NET 10 solution and commit the initial project skeleton and converted core models (POC conversion thereafter).

If you want a different branch name or repo location, tell me now.
