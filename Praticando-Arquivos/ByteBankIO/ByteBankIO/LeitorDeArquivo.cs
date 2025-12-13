using System.Text;

namespace ByteBankIO;

public class LeitorDeArquivo
{
    public static void ReadFile(string filePath)
    { 
        //Proteger contra excessões e evita vazamento de memória e bloqueio de arquivos
        using (FileStream fluxoDoArquivo = new FileStream(filePath, FileMode.Open))
        {
            var buffer = new byte[1024]; //1 KB

            int numerosDeBytesLidos = -1; 
            while (numerosDeBytesLidos != 0)
            {
                numerosDeBytesLidos = fluxoDoArquivo.Read(buffer, 0, 1024);
                ReadBuffer(buffer, numerosDeBytesLidos);
            }
            
            fluxoDoArquivo.Close();
        }
        
        void ReadBuffer(byte[] buffer, int bytesNovosLidos)
        {
            UTF8Encoding utf8 = new();
            string text = utf8.GetString(buffer,  0, bytesNovosLidos);
            Console.Write(text);
        }
    }
 
}