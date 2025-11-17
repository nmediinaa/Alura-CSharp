Console.WriteLine("Informe a nota do aluno: ");

double nota = Double.Parse(Console.ReadLine());

if (nota < 5)
{
    Console.WriteLine("Nota do aluno é D");
}else if (nota >= 5 && nota < 7)
{
    Console.WriteLine("Nota do aluno é C");
}else if (nota >= 7 && nota < 9)
{
    Console.WriteLine("Nota do aluno é B");
}else if (nota >= 9)
{
    Console.WriteLine("Nota do aluno é A");
}