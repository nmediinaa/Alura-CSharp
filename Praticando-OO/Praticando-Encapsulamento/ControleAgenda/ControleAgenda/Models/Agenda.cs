namespace ControleAgenda.Models;

public class Agenda
{
    public string Proprietario { get; private set; }

    private readonly List<Contato> _contatos = new();

    public Agenda(string proprietario)
    {
       this. Proprietario = proprietario;
    }

    public bool AdicionarContato(Contato contato)
    {
        if (_contatos.Any(c => c.Nome == contato.Nome))
        {
            Console.WriteLine("Erro contato ja existente na agenda!");
            return false;
        }
        else
        {
            _contatos.Add(contato);
            Console.WriteLine("Contato adicionado com sucesso!");
            return true;
        }
    }

    public int QuantidadeContatos { get{ return _contatos.Count; } }

    public void ListarContatos()
    {
        Console.WriteLine("Contatos:");
        foreach (var contato in _contatos)
        {
            Console.WriteLine($"- {contato.Nome} | {contato.Telefone}");
        }

        Console.WriteLine($"Quantidades de contatos: {this.QuantidadeContatos}");
    }

}