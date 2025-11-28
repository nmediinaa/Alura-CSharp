namespace DadosPassageiros.Models;

public class Passageiro : Pessoa
{
    public int QntdBilhetes { get; set; }

    public Passageiro(string nome, int idade, int qntdBilhetes) : base(nome, idade)
    {
        this.QntdBilhetes = qntdBilhetes;
    }


    public override void Exibir()
    {
        base.Exibir();
        Console.WriteLine($"Bilhetes: {this.QntdBilhetes}");
        Console.WriteLine("");
    }
}