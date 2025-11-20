//Aqui neste programa escolhi usar o foreach,
//pois o mesmo foi feito para iterar sobre itens de uma coleção!


List<double> notasAlunos = new List<double>()
{
    8.5,
    6.2,
    9.1,
    5.8,
    7.4
};

foreach (int notas in notasAlunos)
{
    if (notas >= 7.0)
    {
        Console.WriteLine($"O aluno com a nota {notas} esta indo muito bem!");
    }
    else
    {
        Console.WriteLine($"O aluno com a nota {notas} está abaixo da média!");
    }
}