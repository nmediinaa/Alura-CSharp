namespace CatagolacaoItens;

public class Pergaminho : ItemDigital
{
    public string Desc { get; set; }

    public Pergaminho(string titulo, string desc) : base(titulo)
    {
        this.Desc = desc;
    }


    public override void MostrarDetalhes()
    {
        base.MostrarDetalhes();
        Console.WriteLine($"Descrição: {Desc}");
    }
}