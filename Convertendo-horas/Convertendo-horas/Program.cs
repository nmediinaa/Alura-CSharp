Console.Write("Digitem uma minutagem >>");
int minutos = int.Parse(Console.ReadLine()!);

Conversor(minutos);

void Conversor(int minutagem)
{
    int horas = minutagem / 60;
    int minutosFaltantes = minutagem % 60;//Operador de resto da divisão
    
    Console.WriteLine($"Tempo:{horas} horas e {minutosFaltantes} minutos");
}