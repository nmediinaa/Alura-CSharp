namespace ReporterGenerator;

internal class DataFormater : IDataFormater
{
    public string FormatData(string input)
    {
        if (DateTime.TryParse(input, out DateTime date))
        {
            return date.ToString("dd/MM/yyyy");
        }

        return input;
    }
}