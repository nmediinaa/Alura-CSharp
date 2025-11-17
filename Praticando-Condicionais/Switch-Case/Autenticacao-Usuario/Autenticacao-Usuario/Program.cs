Console.WriteLine(@"Sistema de Autenticação
                   -----------------------");
                   
Console.WriteLine("Digite o nome do usuario:");
Console.Write(">> ");
string user = Console.ReadLine()!;

if (user == "admin")
{
    Console.Clear();
    Console.WriteLine($"Bem-vindo, {user}!");
}
else
{
    Console.Clear();
    Console.WriteLine("Usuário não cadastrado.");
    Console.WriteLine("Opções disponíveis:");
    Console.WriteLine("[1] Cadastrar novo usuário");
    Console.WriteLine("[2] Acessar como convidado");
    Console.WriteLine("[3] Sair");
    Console.Write(">> ");
    int opcao = Convert.ToInt32(Console.ReadLine()!);

    switch (opcao)
    {
        case 1:
            Console.WriteLine($"Usuário, {user} cadastrado com sucesso!");
            break;
        case 2: 
            Console.WriteLine("Acesso concedido como convidado.");
            break;
        case 3:
            Environment.Exit(0);
            break;
    }
}