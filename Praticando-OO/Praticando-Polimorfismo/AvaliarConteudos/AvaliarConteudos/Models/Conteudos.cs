namespace AvaliarConteudos.Models;

public class Conteudos
{
    public string Titulo { get; set; }

    public Conteudos(string titulo)
    {
        this.Titulo = titulo;
    }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"Titulo: {this.Titulo}");
    }
}