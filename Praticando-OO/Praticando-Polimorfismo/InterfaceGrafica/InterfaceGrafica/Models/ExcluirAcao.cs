using InterfaceGrafica.Interfaces;

namespace InterfaceGrafica.Models;

public class ExcluirAcao : IAcaoBotao
{
    public void ExecutaAcao()
    {
        Console.WriteLine("Excluindo registro do sistema...");
    }
}