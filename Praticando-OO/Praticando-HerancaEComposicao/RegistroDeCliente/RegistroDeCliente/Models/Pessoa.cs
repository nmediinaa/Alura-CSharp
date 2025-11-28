namespace RegistroDeCliente.Models;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public Pessoa(string nome, int idade)
    {
        this.Nome = nome;
        this.Idade = idade;
    }

    public virtual void ExibeInformacoes()
    {
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"Idade: {this.Idade}");
    }
}