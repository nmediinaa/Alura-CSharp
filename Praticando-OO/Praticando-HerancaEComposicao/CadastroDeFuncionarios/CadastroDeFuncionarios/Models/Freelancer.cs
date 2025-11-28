namespace CadastroDeFuncionarios.Models;

public class Freelancer : Funcionario
{
    private int _valorProjeto;

    public int ValorProjeto
    {
        get
        {
            return _valorProjeto;
        }
        set
        {
            _valorProjeto = value;
        }
    }

    public Freelancer(string nome, string cargo, int codFunc, int valorProjeto) 
        : base(nome, cargo, codFunc)
    {
        this.ValorProjeto = valorProjeto;
    }

    public override void ExibeInfo()
    {
        base.ExibeInfo();
        Console.WriteLine($"Valor do Projeto: {this.ValorProjeto}");
    }
}