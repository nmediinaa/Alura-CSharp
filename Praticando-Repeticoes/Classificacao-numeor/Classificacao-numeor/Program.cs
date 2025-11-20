List<int> notasParticipantes = new List<int>(){1,2,5,6,9,10};

foreach (int notas in notasParticipantes)
{
    if (notas >= 6)
    {
        Console.WriteLine($"Nota: {notas} - APROVADO");
    }
    else
    {
        Console.WriteLine($"Nota: {notas} - Reprovado");
    }
}