using InterfaceGrafica.Interfaces;

namespace InterfaceGrafica.Models;

public class EditarAcao : IAcaoBotao
{
    public void ExecutaAcao()
    {
        Console.WriteLine("Editando informações do cadastro...");
    }
}