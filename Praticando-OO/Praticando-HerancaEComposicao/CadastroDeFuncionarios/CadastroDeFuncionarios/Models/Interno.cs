using System.Drawing;

namespace CadastroDeFuncionarios.Models;

public class Interno : Funcionario
{
    private int _salario;
    public int Salario
    { get { return _salario;} set{_salario = value; } }

    public Interno(string nome, string cargo, int codFunc, int salario) 
        : base(nome, cargo, codFunc)
    {
        this.Salario = salario;
    }

    public override void ExibeInfo()
    {
        base.ExibeInfo();
        Console.WriteLine($"Salario: {Salario}");
    }
}