Console.WriteLine(@"SISTE DE ESTOQUE
                   ----------------");
int estoqueAtual = 0;

do
{
    Console.WriteLine(@"Deseja adicionar um produto ao estoque?
                               1 - Sim | 0 - Não");
    int cmd = int.Parse(Console.ReadLine())!;
    if (cmd == 1)
    {
        Console.Write("Quantidade: ");
        int quantidade = int.Parse(Console.ReadLine());
        estoqueAtual += quantidade;
        Console.Write($"Quantidade de estoque: {estoqueAtual}");
        Thread.Sleep(1500);
        Console.Clear();
    }else if (cmd == 0)
    {
        break;
    }
} while (true);