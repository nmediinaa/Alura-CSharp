int cont = 0;

for (int i = 1; i <= 10; i++)
{
    Console.WriteLine("Digite um numero: ");
    int numero = int.Parse(Console.ReadLine()!);

    if (numero % 2 == 1)
        cont++;
}

Console.WriteLine($"Voce digitou {cont} numeros impares");