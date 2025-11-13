Console.Write("Salario atual: ");
double salarioAtual = double.Parse(Console.ReadLine()!);

Console.WriteLine("Percentual de aumento: ");
double percentualAumento = double.Parse(Console.ReadLine()!);

Console.WriteLine($"Salario final: {NovoSalario(salarioAtual, percentualAumento)}");


string NovoSalario(double salario, double percentual)
{
    double salarioNovo = salarioAtual + (salarioAtual * percentual/100);
    return salarioNovo.ToString("C2");
}