namespace Praticando_Classes.Models;

public class Retangulo
{
    public int Altura { get; set; }
    public int Largura { get; set; }

    public int AreaRetangulo => this.Altura * this.Largura;
}