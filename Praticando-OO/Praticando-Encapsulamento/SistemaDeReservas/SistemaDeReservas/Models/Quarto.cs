namespace SistemaDeReservas.Models;

public class Quarto
{
    private double _valorDiaria;
    public int NumeroQuarto { get; set; }

    public double ValorDiaria
    {
        get
        {
            return _valorDiaria;
        }
        set
        {
            if (value > 0) _valorDiaria = value;
            else Console.WriteLine("Erro valor da diaria nao pode ser zero ou negativo");
            ;
        }
    }

    public Quarto(int numeroQuarto, double valorDiaria)
    {
        NumeroQuarto = numeroQuarto;
        ValorDiaria = valorDiaria;
    }
}