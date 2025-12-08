using CalculoJuros.Models;


List<IEmprestimo> emprestimos = new()
{
    new EmprestimoEstudante(),
    new EmprestimoEmpresario(),
    new EmprestimoAposentado()
};

foreach (var emprestimo in emprestimos)
{
    decimal valor = emprestimo.CalcularValorFinal(1000m, 12);
    Console.WriteLine($"{emprestimo.GetType().Name}: R${valor: 0.00}");
}
