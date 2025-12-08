namespace SimuladorTransporte.Models;

public class Metro : Transporte
{
    public override int CalcularTempo(int distancia)
    {
        return distancia + 5;
    }
}