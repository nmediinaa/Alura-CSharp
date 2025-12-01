namespace GestaoDeServicos.Model;

public class Funcionario
{
    public string Nome { get; set; }
    public string Dep { get; set; }

    public Funcionario(string nome, string dep)
    {
        this.Nome = nome;
        this.Dep = dep;
    }
}