using System.Collections;

DiasDaSemana diasDaSemana = new DiasDaSemana();


foreach (var dia in diasDaSemana )
{
    Console.WriteLine(dia);
}

IEnumerable<int> numeroPares = NumerosParesComYield();

int contador = 0;
foreach (var cont in numeroPares)
{
    Console.WriteLine(cont);
    contador++;
    if (contador > 5) break;
}

IEnumerable<int> NumerosParesComYield()
{
    int cont = 0;
    while (true)
    {
        yield return cont * 2;
        cont++;
    }
    
}

IEnumerable<int> NumerosParesSemYield(int limite)
{
    List<int> numeros = new List<int>();

    for (int i = 0; i < limite; i++)
    {
        Console.WriteLine(numeros.Count);
        numeros.Add(i*2);
    }
    return numeros;
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