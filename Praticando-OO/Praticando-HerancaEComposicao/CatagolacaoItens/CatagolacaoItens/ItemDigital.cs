namespace CatagolacaoItens;

public class ItemDigital
{
    public string Titulo { get; set; }

    public ItemDigital(string titulo)
    {
        this.Titulo = titulo;
    }

    public virtual void MostrarDetalhes()
    {
        Console.WriteLine($"Titulo: {this.Titulo}");
    }
}