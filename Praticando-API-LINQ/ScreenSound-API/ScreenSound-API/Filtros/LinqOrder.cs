using ScreenSound_API.Models;

namespace ScreenSound_API.Filtros;

public class LinqOrder
{
    public static void FiltarArtistas(List<Musica> musicas)
    {
        var artistas = musicas.OrderBy(m => m.Artista).Select(m => m.Artista)
            .Distinct().ToList();
        Console.WriteLine("Lista de artistas:");
        foreach (var artista in artistas)
        {
            Console.WriteLine($"- {artista}");
        }
    }
}