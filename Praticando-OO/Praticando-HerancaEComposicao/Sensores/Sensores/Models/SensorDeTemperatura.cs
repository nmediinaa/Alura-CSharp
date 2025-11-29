using Sensores.Interfaces;

namespace Sensores.Models;

public class SensorDeTemperatura : ISensor
{
    public void Ativar()
    {
        Console.WriteLine("Atiavando sensor de temperatura...");
    }

    public void Desativar()
    {
        Console.WriteLine("Desativando sensor de temperatura...");
    }
}