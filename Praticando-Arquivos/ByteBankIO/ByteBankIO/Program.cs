using System.Text;
using ByteBankIO;
class Program
{
    static void Main(string[] args)
    {
        string filePath = "contas.txt";
        
        //LeitorDeArquivo.ReadFile(filePath);


        using (FileStream fluxoDoArquivo = new FileStream(filePath, FileMode.Open))
        {
            StreamReader reader = new StreamReader(fluxoDoArquivo);

            //Console.WriteLine(reader.ReadLine()); --> Le a primeira linha
            //Console.WriteLine(reader.ReadToEnd()); --> Carrega o arquivo inteiro na memória(Não aconselhavel) 
            //Console.WriteLine(reader.Read()); --> Retorna em Byte o PRIMEIRO caracter do arquivo
            
            //Aqui o processe nn carrega o arquivo inteiro na memória sendo muito parecido com o primeiro processo
            while (!reader.EndOfStream)//Le até o fim do arquivo
            {
                Console.WriteLine(reader.ReadLine());
            }
        }    
        
        
        
        
        
    }

}