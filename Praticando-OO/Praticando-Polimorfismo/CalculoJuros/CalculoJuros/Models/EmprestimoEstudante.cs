namespace CalculoJuros.Models;

public class EmprestimoEstudante : IEmprestimo
{
    public decimal CalcularValorFinal(decimal valor, int meses)
    {
        return valor + (valor * (decimal)0.01 * meses);//Operador Cast
    }
}