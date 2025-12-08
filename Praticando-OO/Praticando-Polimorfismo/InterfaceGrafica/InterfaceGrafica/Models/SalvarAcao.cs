using InterfaceGrafica.Interfaces;

namespace InterfaceGrafica.Models;

public class SalvarAcao : IAcaoBotao
{
    public void ExecutaAcao()
    {
        Console.WriteLine("Salvando dados no banco...");
    }
}