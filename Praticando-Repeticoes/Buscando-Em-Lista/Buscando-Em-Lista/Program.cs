List<String> nomeAluno = new List<string>(){"Nicolas", "Mateo", "Higao", "Matheus", "Juliao", "Gabriel" };
int count = 0;

Console.WriteLine("Digite um nome de um aluno: ");
String nome = Console.ReadLine()!;

while (count < nomeAluno.Count())
{
    if (nomeAluno[count] == nome)
    {
        Console.WriteLine($"Aluno {nome} foi encontrado na posição {count}");
        break;
    }

    count++;

    if (count == nomeAluno.Count)
    {
        Console.WriteLine($"Aluno {nome} não está presente na lista");
    }

}