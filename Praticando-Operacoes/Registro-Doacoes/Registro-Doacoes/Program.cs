//Exercicio 2 - Alura

Console.WriteLine("por gentileza, quanto gostaria de doar?");
double valorDoacao = double.Parse(Console.ReadLine()!);

Console.WriteLine("Gostaria de efetuar a doação anonima? [S/N]");
char anonima = char.Parse(Console.ReadLine()!);

Console.WriteLine("Conta corrente ou poupança?[C/P]");
char tipoDeConta = char.Parse(Console.ReadLine()!);

    
if (anonima == 'S')
{
    bool controleAnonima = true;
    Console.WriteLine($"Valor da doação: {valorDoacao}\n Doação anonima: {controleAnonima}\n Tipo de conta: {tipoDeConta}");
}else if (anonima == 'N')
{
    bool controleAnonima = false;
    Console.WriteLine($"Valor da doação: {valorDoacao}\n Doação anonima: {controleAnonima}\n Tipo de conta: {tipoDeConta}");
}