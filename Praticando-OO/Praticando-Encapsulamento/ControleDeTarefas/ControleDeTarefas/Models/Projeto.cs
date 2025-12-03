namespace ControleDeTarefas.Models;

public class Projeto
{
    public string Nome { get; set; }
    private List<string> _tarefas = new();

    public int QntdTarefas
    {
        get
        {
            return _tarefas.Count;
        }
    }

    public Projeto(string nome)
    {
        this.Nome = nome;
    }

    public void AdicionarTarefa(string tarefa)
    {
        _tarefas.Add(tarefa);
    }

    public void ExibirTarefas()
    {
        Console.WriteLine($"Projeto: {this.Nome}");
        Console.WriteLine("Tarefas:");
        foreach (var tarefa in _tarefas)
        {
            Console.WriteLine($"- {tarefa}");
        }

        Console.WriteLine($"Quantidade de tarefas: {QntdTarefas}");
    }
}