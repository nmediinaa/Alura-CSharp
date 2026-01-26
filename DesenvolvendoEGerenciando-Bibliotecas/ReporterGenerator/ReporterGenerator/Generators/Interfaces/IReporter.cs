namespace ReporterGenerator;

public interface IReporter
{
    List<Dictionary<string, string>> Input { get; set; }
    
    string Title { get; set; }
    
    string Description { get; set; }
    
    string Footer { get; set; }
    
    string Generate();
}