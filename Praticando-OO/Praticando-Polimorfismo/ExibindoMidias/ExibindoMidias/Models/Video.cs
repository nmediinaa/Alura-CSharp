namespace ExibindoMidias.Models;

public class Video : Midia
{
    public int Duracao{ get; set; }

    public Video(string nome, int duracao) : base(nome)
    {
        Duracao = duracao;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Video: {this.Nome} - Duracao: {this.Duracao}min");
    }
}