namespace ReservaExperiencia.Models;

public class ReservaPresencial : Reserva
{
    public ReservaPresencial(string titulo) : base(titulo)
    {
    }

    public override void Confirmar()
    {
        Console.WriteLine($"Confirmando reserva presencial: {this.Titulo}");
        Console.WriteLine("Ponto de encontro: Praça Central, às 8h");
    }
}