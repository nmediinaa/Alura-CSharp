namespace ControlandoAcesso.Models;

public class Paciente
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Paciente(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }
}