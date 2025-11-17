Console.WriteLine("Digite seu codigo de recompensa (DOBRAR, CURAR, OURO, ESPECIAL): ");
string codigo = Console.ReadLine()!;

string mensagem = codigo switch//Switch simplificado
{
    "DOBRAR" => "Você ganhou 2x EXP por 1 hora!",
    "CURAR" => "Poção de cura adquirida!",
    "OURO" => "+1000 moedas de ouro!",
    "ESPECIAL" => "Item lendário desbloqueado!",
    _ => "Recompensa indisponível."
};

Console.WriteLine($"{mensagem}");