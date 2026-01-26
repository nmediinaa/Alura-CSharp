namespace ReporterGenerator;

public abstract class ReporterGenerator : IReporter
{
    public List<Dictionary<string, string>> Input { get; set; }
    
    public string Title { get; set; }
    public string Description { get; set; }
    public string Footer { get; set; }
    
    public string Generate()
    {
        throw new NotImplementedException();
    }
}