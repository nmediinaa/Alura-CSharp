//var diasDaSemana = new ArrayList(){"Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado"};


var carrinho = new List<Produto>()
{
    new Produto(){Nome = "Livro", Preco = 49.90},
    new Produto(){Nome = "Garrafa", Preco = 10.50}
};


foreach (Produto p in carrinho)
{
    Console.WriteLine(p.Nome + ": R$" + p.Preco);
}

class Produto()
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}

class DiasDaSemana()
{
    private
}