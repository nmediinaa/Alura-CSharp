Console.WriteLine("Digite uma idade: ");
int idade = int.Parse(Console.ReadLine());

if(idade >= 0 && idade <= 12)
{
    Console.WriteLine("Classificação: Infantil");
}else if (idade >= 13 && idade <= 17)
{
    Console.WriteLine("Classificação: Adolescente");
}else if (idade >= 18 && idade <= 58)
{
    Console.WriteLine("Classificação: Adulto");
}else if (idade >= 60)
{
    Console.WriteLine("Classificação: Idoso");
}