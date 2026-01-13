using System.Text.RegularExpressions;



void ValidandoLink()
{
    string texto = "Acesse https://meusite.com ou http://ww.exemplo.org.br para mais informações.";

    string linkValidation = @"https?://[a-zA-Z\S]+\S*";
    string textoLimpo = Regex.Replace(texto, linkValidation, "[LINK]");
    Console.WriteLine(textoLimpo);
    
}


void ValidandoData()
{
    Console.WriteLine("Digite uma data(dd/mm/yyyy) ou (dd/mm/yy):");
    string data = Console.ReadLine()!;

    Regex dateValidation = new Regex(@"^\d{2}\/\d{2}\/\d{2,4}$");
    bool isValid = dateValidation.IsMatch(data);
    
    if (isValid) Console.WriteLine("A data está no formato correto");
    else Console.WriteLine("Formato inválido! Use (dd/mm/yyyy) ou (dd/mm/yy)");
}


void ValidandoEspacos()
{
    string texto = "    Olá,    mundo!   Como   vocês    estão?";

    string spaceValidation = @"\s{2,}";
    string textoLimpo = Regex.Replace(texto, spaceValidation, " ");
    Console.WriteLine(textoLimpo);
}


void RetornandoUmValor()
{
    Console.WriteLine("Digite um código:");
    string texto = Console.ReadLine()!;

    Regex valueValidation = new Regex(@"^R\$\d{2}\,\d{2}$");
    string valor = Regex.Match(texto, @"R\$ \d+,\d{2}").Value;
    Console.WriteLine($"{valor}");
}


void ValidandoSomenteNumeros()
{
    Console.WriteLine("Digite um código:");
    string codigo = Console.ReadLine()!;

    Regex codeValidation = new Regex(@"^\d+$");

    bool isValid = codeValidation.IsMatch(codigo);

    if (isValid) Console.WriteLine("Codigo valido!");
    else Console.WriteLine("Codigo invalido!");
   
}