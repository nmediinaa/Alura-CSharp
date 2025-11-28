using Screen_Sound.Models;

namespace Screen_Sound.Models;

public interface IAvaliavel
{
    void AdicionarNota(Avaliacao nota);
    
    double Media{get;}
    
}