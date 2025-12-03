namespace ValidaçãoSaque.Models;

internal class SegurancaConta
{
    public static bool ValidarSaque(double value)
    {
        return value < 1000;

    }
}