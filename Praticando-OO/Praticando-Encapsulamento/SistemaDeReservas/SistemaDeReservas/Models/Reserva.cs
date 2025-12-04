namespace SistemaDeReservas.Models;

public class Reserva
{
    private int _diarias;
    public Hospede Hospede { get; }
    public Quarto Quarto { get; }
    public int Diarias
    {
        get { return _diarias;}
        set { if(value > 0)this._diarias = value;else Console.WriteLine("Erro valor da diaria nn pode ser zero ou negativo");
        }
    }
    
    public double ValorTotal
    {
        get { return this._diarias * this.Quarto.ValorDiaria; }
    }

    public Reserva(Hospede hospede, Quarto quarto, int diarias)
    {
        this.Hospede = hospede;
        this.Quarto = quarto;
        this.Diarias = diarias;
    }
}