using Sensores.Interfaces;

namespace Sensores.Models;

public class SensorDePresenca : ISensor
{
    public void Ativar()
    {
        Console.WriteLine("Sensore de presença ativado...");
    }

    public void Desativar()
    {
        Console.WriteLine("Sensore de presença Desativado...");
    }
}