
int cmd = 0;

while (cmd != 3)
{
    Console.WriteLine("1 - Celsius para Fahrenheit");
    Console.WriteLine("2 - Fahrenheit para Celsius");
    Console.WriteLine("3 - Sair");
    Console.Write(">> ");
    cmd = int.Parse(Console.ReadLine()!);

    if (cmd == 1)
    {
        Console.WriteLine("Digite uma temperatura: ");
        double temperatura = double.Parse(Console.ReadLine()!);
        double tmpF = (temperatura * 9 / 5) + 32;
        Console.WriteLine($"{temperatura}°C equivalem a: {Math.Round(tmpF)}°F");
    }else if (cmd == 2)
    {
        Console.WriteLine("Digite uma temperatura: ");
        double temperatura = double.Parse(Console.ReadLine()!);
        double tmpC = (temperatura - 32) * 5 / 9;
        Console.WriteLine($"{temperatura}°F equivalem a: {Math.Round(tmpC)}°C");
    }
    
}