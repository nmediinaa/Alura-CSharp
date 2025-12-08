namespace ReservaExperiencia.Models;

public class ReservaOnline : Reserva
{
    public ReservaOnline(string nome) : base(nome)
    {
    }

    public override void Confirmar()
    {
        Console.WriteLine($"Confirmando reserva online:{this.Titulo}");
        Console.WriteLine("Link de acesso enviado por e-mail!");
    }
}