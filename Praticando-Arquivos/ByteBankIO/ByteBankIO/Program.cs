using System.Text;
using ByteBankIO;
class Program
{
    static void Main(string[] args)
    {
        string enderecoDoArquivo = "contas.txt";
        FileStream fluxoDoArquivo = new FileStream(enderecoDoArquivo, FileMode.Open);     
        
        var buffer = new byte[1024]; //1 KB

        int numerosDeBytesLidos = -1; 
        while (numerosDeBytesLidos != 0)
        {
            numerosDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
            ReadBuffer(buffer);
        }
    }


    static void ReadBuffer(byte[] buffer)
    {
        UTF8Encoding utf8 = new();
        string text = utf8.GetString(buffer);
        Console.Write(text);
    }
    
}