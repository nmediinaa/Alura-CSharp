const double pi = 3.14;

Console.Write("Digite um raio: ");
double raio = double.Parse(Console.ReadLine());

double area = pi * raio * raio;

double perimetro = 2 * pi * raio;

Console.WriteLine($"Raio = {raio}\nArea = {area.ToString("F2")}\nPerimetro = {perimetro.ToString("F2")}");