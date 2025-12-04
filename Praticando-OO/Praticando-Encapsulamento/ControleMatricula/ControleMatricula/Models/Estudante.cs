namespace ControleMatricula.Models;

public class Estudante
{
    public string Nome { get; set; }

    public Estudante(string nome)
    {
        this.Nome = nome;
    }
}