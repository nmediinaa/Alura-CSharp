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

}