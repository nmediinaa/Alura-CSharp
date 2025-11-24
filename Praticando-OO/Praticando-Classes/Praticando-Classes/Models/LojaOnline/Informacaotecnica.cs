namespace Praticando_Classes.Models.LojaOnline;

public class Informacaotecnica
{
    public int TamanhoMB { get; set; }
    public string SOps { get; set; }

    public Informacaotecnica(int tamanhoMB, string sOps)
    {
        this.TamanhoMB = tamanhoMB;
        this.SOps = sOps;
    }
}