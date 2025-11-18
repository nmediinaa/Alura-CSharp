double valorTotal  = 0;

while (true)
{
    Console.Write("Digite o valor da venda (0 para sair): ");
    double valor = double.Parse(Console.ReadLine());
    valorTotal += valor;

    if (valor == 0)
    {
        break;
    }

    Console.Clear();
}

Console.WriteLine("Valor total: " + valorTotal);
