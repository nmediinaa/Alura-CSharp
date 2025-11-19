int senhaGerada = 0;
int senhaAtual = 0;
int cmd = 0;

while (cmd != 3)
{
    Console.WriteLine("1 - Gerar uma nova senha");
    Console.WriteLine("2 - Chamar próxima senha");
    Console.WriteLine("3 - Encerrar");
    Console.Write(">>");
    cmd = int.Parse(Console.ReadLine()!);

    switch (cmd)
    {
        case 1:
            senhaGerada++;
            Console.WriteLine($"Senha gerada: {senhaGerada.ToString("D3")}");
            break;
       case 2:
            senhaAtual++;
            Console.WriteLine($"Senha atual: {senhaAtual.ToString("D3")}");
            break;
       case 3:
           Console.Write("Encerrando o sistema...");
           break;
       default:
           Console.Write("Opção invalida...");
           break;
    }
}