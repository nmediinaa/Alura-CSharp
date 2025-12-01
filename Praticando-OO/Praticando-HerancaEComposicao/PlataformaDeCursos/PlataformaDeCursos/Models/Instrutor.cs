namespace PlataformaDeCursos.Models;

public class Instrutor
{
    public string Nome { get; set; }
    public string Especialidade { get; set; }

    public Instrutor(string nome, string especialidade)
    {
        this.Nome = nome;
        this.Especialidade = especialidade;
    }
}