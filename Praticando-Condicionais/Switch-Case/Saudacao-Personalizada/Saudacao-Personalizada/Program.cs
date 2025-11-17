Console.WriteLine("Qual o momento do dia?");
Console.WriteLine(" 1- Manhã \n 2- Tarde \n 3 - Noite");
int periodo = int.Parse(Console.ReadLine()!);

Console.WriteLine("Qual o seu nome?");
String nome = Console.ReadLine()!;

switch (periodo)
{
    case 1: 
        Console.WriteLine("Bom dia, {nome}");
        break;
    case 2:
        Console.WriteLine($"Bom tarde, {nome}");
        break;
    case 3:
        Console.WriteLine($"Bom noite, {nome}");
        break;
}