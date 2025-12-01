using SistemaDePagamentos.Interfaces;

namespace SistemaDePagamentos;

public class PagamentoDebito : Pessoa
{
    public PagamentoDebito(string nome, string email) 
        : base(nome, email)
    {
        
    }

    public void ProcessarPagamento()
    {
        Console.WriteLine($"Processando pagamento com cartão de débito para {this.Nome} - {this.Email}");
    }
}