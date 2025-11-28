using System.Runtime.CompilerServices;

namespace RegistroDeCliente.Models;

public class ClienteVip : Pessoa
{
    private string _fidalidade;

    public string Fidalidade
    {
        get
        {
            return _fidalidade;
        }
        set
        {
            value = _fidalidade;
        }
    }

    public string CodigoVip { get; private set; }
    
    public ClienteVip(string nome, int idade, string fidalidade, string codigoVip) 
        : base(nome, idade)
    {
        this.Fidalidade = fidalidade;
        this.CodigoVip = codigoVip;
    }

    public override void ExibeInformacoes()
    {
        base.ExibeInformacoes();
        Console.WriteLine($"Nivel de fidelidade: {this.Fidalidade}");
        Console.WriteLine($"Código VIP: {this.CodigoVip}");
    }
}