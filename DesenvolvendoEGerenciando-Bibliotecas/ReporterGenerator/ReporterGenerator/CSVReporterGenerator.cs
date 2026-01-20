using System.Security.AccessControl;
using System.Text;

namespace ReporterGenerator;

public class CSVReporterGenerator : IReporter
{
    public List<Dictionary<string, string>> Input { get; set; }
    public string Title { get; set; }
    public string Description { get; set; }
    public string Footer { get; set; }

    public CSVReporterGenerator(List<Dictionary<string, string>> input)
    {
        this.Input = input;
    }

    public string Generate()
    {
        if (Input == null || Input.Count == 0) throw new Exception("Input vazio ou nulo!");

        StringBuilder report = new StringBuilder();

        if (!string.IsNullOrEmpty(Title))
        {
            report.AppendLine(Title);
            report.Append("");
        }
        if(!string.IsNullOrEmpty(Description)) report.AppendLine(Description);

        string header = string.Join(';', Input.First().Keys);
        report.AppendLine(header);
        
        foreach (var item in Input)
        {
            string line = string.Join(';', item.Values);
            report.AppendLine(line);
        }

        if (!string.IsNullOrEmpty(Footer))
        {
            report.AppendLine(Footer);
            report.Append("");
        }
        
        File.WriteAllText("Report.csv", report.ToString(),  Encoding.UTF8);
        
        return Path.GetFullPath("Report.csv");
    }
}