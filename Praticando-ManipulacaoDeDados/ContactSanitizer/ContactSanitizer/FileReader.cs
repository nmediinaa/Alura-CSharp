using System.Net.Http.Headers;

namespace ContactSanitizer;

public class FileReader
{
   
    public string FilePath { get; set; }
    
    public FileReader(string filePath)
    {
        this.FilePath = filePath;
    }


    public string[] ReaderLines()
    {
        return File.ReadAllLines(FilePath);
    }
}