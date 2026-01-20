using System.Security.AccessControl;
using System.Text;

namespace ReporterGenerator;

public class ReporterGenerator
{
    public List<Dictionary<string, string>> Input { get; set; }

    public ReporterGenerator(List<Dictionary<string, string>> input)
    {
        this.Input = input;
    }

    public string Generate()
    {
        if (Input == null || Input.Count == 0) throw new Exception("Input vazio ou nulo!");

        StringBuilder report = new StringBuilder();

        string header = string.Join(';', Input.First().Keys);
        report.AppendLine(header);
        
        foreach (var item in Input)
        {
            string line = string.Join(';', item.Values);
            report.AppendLine(line);
        }
        
        File.WriteAllText("Report.csv", report.ToString());
        
        return Path.GetFullPath("Report.csv");
    }
}