namespace MontagemComputadores.Models;

public class Computador
{
    public Processador Processador { get; set; }
    public PlacaMae PlacaMae { get; set; }


    public Computador(Processador processador,  PlacaMae placaMae)
    {
        this.Processador = processador;
        this.PlacaMae = placaMae;
    }

    public void ExibirInfo()
    {
        Console.WriteLine($"Processador: {this.Processador.Marca} - {this.Processador.Modelo}");
        Console.WriteLine($"PlacaMae: {this.PlacaMae.Fabricante} - {this.PlacaMae.Socket}");
    }
}