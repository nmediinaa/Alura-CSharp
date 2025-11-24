namespace Praticando_Classes.Models;

public class Pedido
{
    public int IdPedido { get; }
    public string NomeCliente { get; set; }
    public string Status { get; set; }


    public Pedido(int idPedido, string nomeCliente, string status)
    {
        this.IdPedido = idPedido;
        this.NomeCliente = nomeCliente;
        this.Status = status;
    }

    public void AtualizarStatus(string status)
    {
        if (this.Status == status)
        {
            Console.WriteLine("ERRO: Status iguais");
        }
        else
        {
            this.Status = status;
            Console.WriteLine("ATUALIZADO.");
        }
    }

    public void ExibirPedido()
    {
        Console.WriteLine($"ID: {this.IdPedido}");
        Console.WriteLine($"Nome: {this.NomeCliente}");
        Console.WriteLine($"Status: {this.Status}");
    }
}