const double km = 1.60934;

Console.Write("Quantas milhas a viagem tem?\n");
double milhas =  double.Parse(Console.ReadLine()!);

double medidaMétrica = milhas*km;

Console.Write($"{milhas} equivalem a {medidaMétrica} quilômetros");