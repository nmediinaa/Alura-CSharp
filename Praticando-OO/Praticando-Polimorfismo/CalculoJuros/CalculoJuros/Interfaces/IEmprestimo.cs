namespace CalculoJuros.Models;

public interface IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses);
}