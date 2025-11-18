Console.Clear();
Random random = new Random();

int numeroSecreto  = random.Next(1, 11);

while (true)
{
    Console.Write("Adivinhe o numero de 1 a 10: ");
    int numero = int.Parse(Console.ReadLine()!);

    if (numeroSecreto == numero)
    {
        break;
    }
    else
    {
        Console.Write("Errou =(");
        Thread.Sleep(1500);
        Console.Clear();
    }
}

Console.WriteLine($"Parabens voce acertou o numero {numeroSecreto}");