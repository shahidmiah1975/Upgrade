I created a small EZMenu.Data project as a placeholder for the typed DataSet ports and data access adapters, and I updated the discovery CSV with estimated LOC and status columns.

Next steps (immediate):
- Inspect EZMenu.zip in the repository (I will scan the archive and populate exact LOC and designer matches). If you want me to open specific files from the archive, tell me which path(s) and I will fetch and analyze them.
- Regenerate typed DataSet classes from EZMenuDataSet.xsd (if present) or port the Designer.vb into C# wrappers. This is the critical part for preserving ADO.NET logic used across the app.
- Create EZMenu.sln referencing the src projects so CI can build a single solution, and then iterate until CI passes.

I will continue now and push incremental commits as I finish each step.