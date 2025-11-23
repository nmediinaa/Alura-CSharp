namespace Praticando_Classes.Models;

public class Filme
{
    public string Nome { get; set; }
    public int ClassificacaoEtaria { get; set; }

    public Filme(string nome, int classificacaoEtaria)
    {
        this.ClassificacaoEtaria = classificacaoEtaria;
        this.Nome = nome;
    }

    public void PodeAssistir(int idade)
    {
        if (idade >= this.ClassificacaoEtaria)
        {
            ExibirResultado(true, idade);
        }else if (idade < this.ClassificacaoEtaria)
        {
            ExibirResultado(false, idade);
        }
    }

    private void ExibirResultado(bool controle, int idade)
    {
        if (controle)
        {
            Console.WriteLine($"Usuário com {idade} anos pode assistir ao filme {this.Nome}.");
        }else
        {
            Console.WriteLine($"Usuário com {idade} anos não pode assistir ao filme {this.Nome}.");
        }
    }
}