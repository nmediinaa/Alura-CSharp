namespace CadastroDeFuncionarios.Models;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }
    public int CodFunc { get; private set; }

    public Funcionario(string nome, string cargo, int  codFunc)
    {
        this.Nome = nome;
        this.Cargo = cargo;
        this.CodFunc = codFunc;
    }

    public virtual void ExibeInfo()
    {
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"Cargo: {this.Cargo}");
        Console.WriteLine($"CodFunc: {this.CodFunc}");
    }
}