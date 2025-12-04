namespace ControleMatricula.Models;

public class Curso
{
    public string Nome { get; set; }
    public int VagasTotais { get; set; }
    private List<Estudante> _matriculas = new List<Estudante>();

    public int VagasDisponiveis
    {
        get
        {
            return VagasTotais - _matriculas.Count;
        }
    }

    public bool Matricular(Estudante estudante)
    {
        if (_matriculas.Count == VagasTotais)
        {
            Console.WriteLine("Erro: Não a vagas mais para este curso");
            return false;
        }
        else
        {
            _matriculas.Add(estudante);
            Console.WriteLine("Estudante matriculado com sucesso");
            return true;
        }
    }

    public void ListarMatriculados()
    {
        Console.WriteLine($"Estudantes matriculados em {this.Nome}");
        foreach (var estudante in  _matriculas)
        {
            Console.WriteLine($"- {estudante.Nome}");
        }

        Console.WriteLine($"Vagas disponíveis: {this.VagasDisponiveis}");
    }

    public Curso(string nome, int vagasTotais)
    {
        Nome = nome;
        VagasTotais = vagasTotais;
    }
}