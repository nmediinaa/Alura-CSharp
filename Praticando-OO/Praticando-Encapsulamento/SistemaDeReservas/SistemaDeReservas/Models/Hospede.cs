namespace SistemaDeReservas.Models;

public class Hospede
{
    public string Nome { get; set; }

    public Hospede(string nome)
    {
        this.Nome = nome;
    }
}