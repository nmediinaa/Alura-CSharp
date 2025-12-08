namespace ExibindoMidias.Models;

public class Midia
{
    public string Nome { get; set; }

    public Midia(string nome)
    {
        this.Nome = nome;
    }

    public virtual void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
    }
}