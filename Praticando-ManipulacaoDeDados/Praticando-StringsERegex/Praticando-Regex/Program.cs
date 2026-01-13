using System.Text.RegularExpressions;

//O valor total é R$ 99,90 e pode ser parcelado em 3x de R$ 33,30.
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