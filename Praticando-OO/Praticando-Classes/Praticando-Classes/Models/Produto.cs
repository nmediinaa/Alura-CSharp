namespace Praticando_Classes.Models;

public class Produto
{
    public string Nome { get; set; }
    private int _quantidadeEstoque;

    public int Quantidade
    {
        get
        {
            return _quantidadeEstoque;
        }
        set
        {
            if (value <= 0)
            {
                Console.WriteLine("Erro produto não pode ser inicializado com zero!");
            }
            else
            {
                _quantidadeEstoque = value;
            }
        }
        
    }

    public Produto(string nome, int quantidade)
    {
        this.Nome = nome;
        this.Quantidade = quantidade;
    }

    public void Retirar(int value)
    {
        if (_quantidadeEstoque >= value)
        {
            _quantidadeEstoque -= value;
            Console.WriteLine($"Retirada de {value} unidades realizada com sucesso.");
        }
        else
        {
            Console.WriteLine($"Erro: Estoque insuficiente para retirada de {value} unidades.");
        }
    }

    public void Exibir()
    {
        Console.WriteLine($"Produto: {Nome}");
        Console.WriteLine($"Quantidade: {Quantidade}");
    }
}