Console.Write("Informe a sua idade: ");
int idade = int.Parse(Console.ReadLine()!);

int anoNascimento = CalculaAnoNascimento(idade);

Console.WriteLine($"Voce nasceu no ano de {anoNascimento}");

int CalculaAnoNascimento(int idade)
{
    return 2025 - idade;
}

