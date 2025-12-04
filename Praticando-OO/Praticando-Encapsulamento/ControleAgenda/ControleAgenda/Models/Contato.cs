namespace ControleAgenda.Models;

public class Contato
{
    public string Nome { get; set; }
    public int Telefone { get; set; }

    public Contato(string nome, int telefone)
    {
        this.Nome = nome;
        this.Telefone = telefone;
    }
}