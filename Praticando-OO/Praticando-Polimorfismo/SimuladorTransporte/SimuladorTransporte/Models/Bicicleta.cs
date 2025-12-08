namespace SimuladorTransporte.Models;

public class Bicicleta : Transporte
{
    public override int CalcularTempo(int distancia)
    {
        return distancia * 4;
    }
}