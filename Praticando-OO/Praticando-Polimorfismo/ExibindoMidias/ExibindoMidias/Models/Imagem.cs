namespace ExibindoMidias.Models;

public class Imagem : Midia
{
    public string Resolucao{ get; set; }

    public Imagem(string nome, string resolucao) : base(nome)
    {
        Resolucao = resolucao;
    }

    public override void ExibirDetalhes()
    {
        Console.WriteLine($"Imagem: {this.Nome} - Resolução: {this.Resolucao}");
    }
}