namespace Praticando_Classes.Models;

public class Passagem
{
    public string Passageiro { get; }
    public string Destino { get; }

    public Passagem(string passageiro, string destino)
    {
        this.Passageiro = passageiro;
        this.Destino = destino;
    }
}