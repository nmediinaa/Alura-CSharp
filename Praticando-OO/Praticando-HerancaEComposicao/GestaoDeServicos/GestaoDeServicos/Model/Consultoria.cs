using GestaoDeServicos.Interface;

namespace GestaoDeServicos.Model;

public class Consultoria : IServico
{
    public string Titulo { get; set; }
    public Funcionario Func { get; set; }
    
    public Consultoria(string titulo, Funcionario func)
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