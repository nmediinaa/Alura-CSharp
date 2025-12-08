namespace AvaliarConteudos.Models;

public class MaterialComplementar : Conteudos
{
    public int Paginas { get; set; }

    public MaterialComplementar(string titulo, int paginas) : base(titulo)
    {
        this.Paginas = paginas;
    }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Páginas: {this.Paginas}");
    }
}