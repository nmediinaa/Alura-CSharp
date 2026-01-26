using System.Security.AccessControl;
using System.Text;

namespace ReporterGenerator;

public class CSVReporterGenerator : ReporterGenerator
{
    public CSVReporterGenerator(List<Dictionary<string, string>> input) : base(input){}
   

    public override string Generate()
    {
        if (Input == null || Input.Count == 0) throw new Exception("Input vazio ou nulo!");

        StringBuilder report = new StringBuilder();

        if (!string.IsNullOrEmpty(Title))
        {
            report.Append("");
            report.AppendLine(Title);
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
            report.Append("");
            report.AppendLine(Footer);
        }

        DataFormater dataFormater = new DataFormater();
        report.Append(dataFormater.FormatData(DateTime.Now.ToString()));
        
        File.WriteAllText("Report.csv", report.ToString(),  Encoding.UTF8);
        
        return Path.GetFullPath("Report.csv");
    }
}