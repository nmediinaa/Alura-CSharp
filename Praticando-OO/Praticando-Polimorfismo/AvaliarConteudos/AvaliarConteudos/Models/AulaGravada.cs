namespace AvaliarConteudos.Models;

public class AulaGravada : Conteudos
{
    public int Duracao { get; private set; }

    public AulaGravada(string titulo, int duracao) : base(titulo)
    {
        this.Duracao = duracao;
    }


    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Duracao: {this.Duracao}");
    }
}