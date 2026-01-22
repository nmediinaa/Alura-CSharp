namespace ContactSanitizer.Services;
using ReporterGenerator;

public class CSVReporter : CSVReporterGenerator
{
    public CSVReporter(List<Dictionary<string, string>> input) : base(input)
    {
    }

    public string GenerateReport(string fileName)
    {
        Generate();
        
        File.Move("Report.csv", fileName);
        
        return Path.GetFullPath(fileName);
    }
}