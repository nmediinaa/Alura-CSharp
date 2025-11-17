const int senha = 42;
const int nivelacesso = 5;

Console.WriteLine("Digite sua senha de acesso: ");
int senhaUser = Int16.Parse(Console.ReadLine());

Console.WriteLine("Digite seu nivel de acesso: ");
int nivelAcessoUser = Int16.Parse(Console.ReadLine());


if (nivelAcessoUser == nivelacesso || nivelAcessoUser > nivelacesso)
{
    if (senhaUser == senha)
    {
        Console.WriteLine("Acesso liberado");
    }
    else
    {
        Console.WriteLine("Senha invalida!");
    }
}
else
{
    Console.WriteLine("Nivel de acesso não permitido");
}
