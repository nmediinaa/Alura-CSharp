namespace CalculoJuros.Models;

public class EmprestimoAposentado : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        return valor + (valor * (decimal)0.015 * meses);
    }
}