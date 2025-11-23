namespace Praticando_Classes.Models;

public class Funcionario
{
    public string Nome { get; set; }
    public string Cargo { get; set; }

    public Funcionario(string nome, string cargo)
    {
        this.Nome = nome;
        this.Cargo = cargo;
    }

    public void Promover(string cargo)
    {
        Console.WriteLine($"Funcionario: {this.Nome}\nCargo:{this.Cargo}");
        if (this.Cargo == cargo)
        {
            Console.WriteLine("Erro o funcionario ja possui este cargo!");
        }else if (this.Cargo != cargo)
        {
            this.Cargo = cargo;
            Console.WriteLine("Cargo atualizado");
            Console.WriteLine($"Funcionario: {this.Nome}\nCargo:{this.Cargo}");
        }
    }
    
}