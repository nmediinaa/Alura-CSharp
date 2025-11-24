namespace Praticando_Classes.Models.LojaOnline;

public class ProdutoDigital
{
    public string Nome { get; set; }
    public double Preco { get; set; }
    public Informacaotecnica Info { get; set; }


    public ProdutoDigital(string nome, double preco, Informacaotecnica info)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Info = info;
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Produto: {this.Nome}");
        Console.WriteLine($"Preço: {this.Preco}");
        Console.WriteLine($"Tamanho: {this.Info.TamanhoMB}");
        Console.WriteLine($"SO: {this.Info.SOps}");
    }
}