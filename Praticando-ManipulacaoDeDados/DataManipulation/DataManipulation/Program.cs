using System.Collections;

DiasDaSemana diasDaSemana = new DiasDaSemana();

var carrinho = new List<Produto>()
{
    new Produto(){Nome = "Livro", Preco = 49.90},
    new Produto(){Nome = "Garrafa", Preco = 10.50}
};


foreach (var dia in diasDaSemana )
{
    Console.WriteLine(dia);
}

foreach (Produto p in carrinho)
{
    Console.WriteLine(p.Nome + ": R$" + p.Preco);
}

class Produto()
{
    public string Nome { get; set; }
    public double Preco { get; set; }
}


class DiasDaSemana() : IEnumerable<string>
{

    public IEnumerator<string> GetEnumerator()
    { 
        yield return "Domingo";
        yield return "Segunda";
        yield return "Terça";
        yield return "Quarta";
        yield return "Quinta";
        yield return "Sexta";
        yield return "Sabado";
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

// class DiasDaSemanaEnumerator() : IEnumerator<string>
// {
//     private string[] _diasDaSemanas = {
//         "Domingo", "Segunda", "Terça", "Quarta", "Quinta", "Sexta", "Sabado"
//     };
//
//     private int _pos = -1;
//     public bool MoveNext()
//     {
//         _pos++;
//         return _pos < _diasDaSemanas.Length;
//     }
//
//     public void Reset()
//     {
//         _pos = -1;
//     }
//
//     object? IEnumerator.Current => Current;
//
//     public string Current => _diasDaSemanas[_pos];
//
//     public void Dispose()
//     {
//  
//     }
// }