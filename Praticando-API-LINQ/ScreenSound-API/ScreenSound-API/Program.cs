using System.Text.Json;
using ScreenSound_API.Models;
using ScreenSound_API.Filtros;

using (HttpClient client = new HttpClient())//Lib HttpClient
{
    try
    {
        string response = await client.GetStringAsync("https://guilhermeonrails.github.io/" +
                                                      "api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(response)!;//! Operador que não deixa ser nulo 
        //musicas[3].ExibirDetalhes();
        //LinqFilter.FiltrarGeneros(musicas);
        //LinqOrder.FiltarArtistas(musicas);
        //LinqFilter.FiltrarArtistaPorGenero(musicas,"rock");
        //LinqFilter.FiltrarMusicasPorArtista(musicas, "U2");
        //LinqFilter.FiltrarMusicasAno(musicas, "2000");
        LinqFilter.FiltrarMusicasEmTonalidades(musicas, "C#");

        // Playlist playlist = new("Playlist do Nicolas Medina");
        // playlist.adicionarMusica(musicas[199]);
        // playlist.adicionarMusica(musicas[194]);
        // playlist.adicionarMusica(musicas[1670]);
        // playlist.adicionarMusica(musicas[1998]);
        // playlist.adicionarMusica(musicas[3]);
        // playlist.ExibirInformacoes();
        //
        // playlist.GerarArquivoJson();
    }
    catch(Exception ex)
    {
        Console.WriteLine("Error: " + ex.Message);//Message prop do objeto Exception
    }

}