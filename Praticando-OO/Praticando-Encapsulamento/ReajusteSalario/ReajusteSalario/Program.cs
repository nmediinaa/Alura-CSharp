using ReajusteSalario.Models;

Funcionario func = new Funcionario("Nicolas Medina", 15000);

Console.WriteLine($"Nome: {func.Nome}\nSalario: {func.Salario}");

func.ReajusteSalario(14000);
func.ReajusteSalario(16500);

Console.WriteLine($"Nome: {func.Nome}\nSalario: {func.Salario}");