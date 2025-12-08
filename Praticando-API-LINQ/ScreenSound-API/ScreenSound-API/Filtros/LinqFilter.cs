using ScreenSound_API.Models;

namespace ScreenSound_API.Filtros;

public class LinqFilter
{
    public static void FiltrarGeneros(List<Musica> musicas)
    {
        var generos= musicas.Select(m => m.Genero).Distinct().ToList();//LINQ com expressão LAMBDA
        foreach (var genero in generos)
        {
            Console.WriteLine($"- {genero}");
        }
    }

    public static void FiltrarArtistaPorGenero(List<Musica> musicas, string genero)
    {
        var artistas = musicas.Where(m => m.Genero.Contains(genero))
            .Select(m => m.Artista).Distinct().ToList();
        Console.WriteLine($"Artista por genero musical >>> {genero}");
        foreach (var artista in artistas)
        {
            Console.WriteLine($"- {artista}");
        }
    }

    public static void FiltrarMusicasPorArtista(List<Musica> musicas, string artista)
    {
        var musicasPorArtista = musicas.Where(m => m.Artista.Equals(artista))
            .OrderBy(m => m.Nome).ToList();
        Console.WriteLine($"Musicas do {artista}");
        foreach (var musica in musicasPorArtista)
        {
            Console.WriteLine($"- {musica.Nome}");
        }
    }

    public static void FiltrarMusicasAno(List<Musica> musicas, string ano)
    {
        var musicasAno = musicas.Where(m => m.AnoDeLancamento.Equals(ano))
            .OrderBy(m => m.Nome).Select(m => m.Nome).Distinct().ToList();
        Console.WriteLine("Musicas lançadas no ano de " + ano);
        foreach (var musica in musicasAno)
        {
            Console.WriteLine($"- {musica}");
        }
    }
    
    public static void FiltrarMusicasEmTonalidades(List<Musica> musicas, string tom)
    {

        var musicasFiltradas = musicas.Where(m => m.Tonalidade.Equals(tom)).Distinct().ToList();
        Console.WriteLine($"Musicas no tem de {tom}");
        foreach (var musica in musicasFiltradas)
        {
            Console.WriteLine($"- {musica.Nome} key {musica.Tonalidade}");
        }
    }
}