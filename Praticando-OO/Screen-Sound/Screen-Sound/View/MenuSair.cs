using Screen_Sound.Models;

namespace Screen_Sound.View;

public class MenuSair : Menu
{
    public override void Executar(Dictionary<string, Banda> bandaRegistradas)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}