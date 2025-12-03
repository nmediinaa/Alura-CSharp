namespace ReajusteSalario.Models;

public class Funcionario
{
    private double _salario;
    
    public string Nome { get; set; }

    public string Salario
    {
        get
        {
            return _salario.ToString("C2");
        }
    }

    public Funcionario(string nome, double salario)
    {
        this.Nome = nome;
        this._salario = salario;
    }

    public void ReajusteSalario(double value)
    {
        if(value > _salario) this._salario = value;
        else Console.WriteLine("ERRO: Valor menor que o salario atual");
    }
}