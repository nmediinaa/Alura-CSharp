Console.WriteLine("Nota 1:");
double nota1 = double.Parse(Console.ReadLine());
Console.WriteLine("Nota 2:");
double nota2 = double.Parse(Console.ReadLine());
Console.WriteLine("Nota 3:");
double nota3 = double.Parse(Console.ReadLine());

double media =  (nota1 + nota2 + nota3)/3;

Console.Write($"A média das notas é {media.ToString("F1")!}");