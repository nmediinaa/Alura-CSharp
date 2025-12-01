using GestaoDeServicos.Interface;

namespace GestaoDeServicos.Model;

public class Manutencao :IServico
{
    public Funcionario Func { get; set; }
    public string Titulo { get; set; }

    public Manutencao(string titulo, Funcionario func)
    {
        this.Titulo = titulo;
        this.Func = func;
    }
    
    public void ExecutarServico()
    {
        Console.WriteLine($"Executando o serviço: {this.Titulo}");
        Console.WriteLine($"Responsavel: {this.Func.Nome} - {this.Func.Dep}");
    }
}