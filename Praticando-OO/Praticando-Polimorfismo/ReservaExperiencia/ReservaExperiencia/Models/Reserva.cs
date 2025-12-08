namespace ReservaExperiencia.Models;

public class Reserva
{

    public string Titulo { get; set; }

    public Reserva(string titulo)
    {
        this.Titulo = titulo;
    }

    public virtual void Confirmar(){}
}