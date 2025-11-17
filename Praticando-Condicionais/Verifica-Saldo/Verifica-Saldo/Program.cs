Console.Write("Digite seu saldo: \n");
double saldo = double.Parse(Console.ReadLine());

if (saldo < 0)
{
    Console.WriteLine($"Saldo Negativo: {saldo}");
}
else
{
    Console.WriteLine($"Saldo Positivo: {saldo}");
}