// Run Best Practices Analyzer for the entire model
var analyzer = new BestPracticeAnalyzer();
var results = analyzer.Analyze(Model);

// Display results in Output Window
foreach(var result in results)
{
    Info($"[{result.Severity}] {result.Object?.Name ?? "Model"}: {result.Message}");
}

// Show summary
Info($"=== SUMMARY ===");
Info($"Total issues found: {results.Count}");
Info($"Errors: {results.Count(r => r.Severity == Microsoft.AnalysisServices.Tabular.BpaSeverity.Error)}");
Info($"Warnings: {results.Count(r => r.Severity == Microsoft.AnalysisServices.Tabular.BpaSeverity.Warning)}");
Info($"Information: {results.Count(r => r.Severity == Microsoft.AnalysisServices.Tabular.BpaSeverity.Information)}");