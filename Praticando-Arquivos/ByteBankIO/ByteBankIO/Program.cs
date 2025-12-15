using System.Text;
using ByteBankIO;
class Program
{
    static void Main(string[] args)
    {
        string filePath = "contas.txt";
        
        //LerArquivo(filePath);
        //CriarArquivo();
        CriarArquivoBinary();
        LerArquivoBinary();
   
    }

    static void LerArquivo(string filePath)
    {
        using (FileStream fluxoDoArquivo = new FileStream(filePath, FileMode.Open))
        {
            StreamReader reader = new StreamReader(fluxoDoArquivo);

            //Console.WriteLine(reader.ReadLine()); --> Le a primeira linha
            //Console.WriteLine(reader.ReadToEnd()); --> Carrega o arquivo inteiro na memória(Não aconselhavel) 
            //Console.WriteLine(reader.Read()); --> Retorna em Byte o PRIMEIRO caracter do arquivo
            
            //Aqui o processe nn carrega o arquivo inteiro na memória sendo muito parecido com o primeiro processo
            while (!reader.EndOfStream)//Le até o fim do arquivo
            {
                string linha = reader.ReadLine()!;
                ContaCorrente conta = CreateContaCorrente(linha);
                Console.WriteLine($"Ag: {conta.Agencia} Conta: {conta.Numero} Saldo: {conta.Saldo} Titular: {conta.Titular.Nome}");
            }
        } 
    }

    static ContaCorrente CreateContaCorrente(string linha)
    {
        string[] values = linha.Split(',');

        int ag = int.Parse(values[0]); 
        int numeroConta = int.Parse(values[1]);
        double saldo = double.Parse(values[2].Replace('.', ','));
        string titular = values[3];
        
        Cliente cliente = new Cliente();
        cliente.Nome = titular;
        
        ContaCorrente contaCorrente = new ContaCorrente(ag, numeroConta);
        contaCorrente.Titular = cliente;
        contaCorrente.Depositar(saldo);
        
        return contaCorrente;
    }

    static void CriarArquivo()
    {
        string newFilePath = "contasExportadas.csv";
        using (FileStream fluxoDoArquivo = new FileStream(newFilePath, FileMode.Create))
        using (StreamWriter writer = new StreamWriter(fluxoDoArquivo))
        {
                writer.Write("316,3254,3350.37,Leonardo");
                writer.Flush();//Descarrega o buffer para o disco rigido
                Console.WriteLine("Arquivo criado com sucesso!");
        }
    }

    static void CriarArquivoBinary()
    {
        using (FileStream fs = new FileStream("contasExportadas.csv", FileMode.Create))
        using (BinaryWriter writer = new BinaryWriter(fs))
        {
            writer.Write(316);
            writer.Write(3254);
            writer.Write(3350.37);
            writer.Write("Leonardo");
        }
        
    }

    static void LerArquivoBinary()
    {
        using (FileStream fs = new FileStream("contasExportadas.csv", FileMode.Open))
        using (BinaryReader reader = new BinaryReader(fs))
        {
            int ag = reader.ReadInt32();
            int numeroConta = reader.ReadInt32();
            double saldo = reader.ReadDouble();
            string titular = reader.ReadString();

            Console.WriteLine($"Ag: {ag} Numero: {numeroConta} saldo: {saldo} Titular: {titular}");
        }
    }

}