using System.ComponentModel;
using System.Text.Json;

namespace ScreenSound_API.Models;

public class Playlist
{
    public string Nome { get; set; }
    public List<Musica> listaMusicas { get; }

    public Playlist(string nome)
    {
        this.Nome = nome;
        listaMusicas = new List<Musica>();//Iniciando a lista vazia
    }

    public void adicionarMusica(Musica musica)
    {
        listaMusicas.Add(musica);
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine(this.Nome);
        var musicas = listaMusicas.OrderBy(lm => lm.Nome);
        foreach (var musica in musicas)
        {
            Console.WriteLine($"- {musica.Nome} do {musica.Artista}");
        }
        Console.WriteLine();
    }

    public void GerarArquivoJson()
    {
        string json = JsonSerializer.Serialize(new
        {
            nome = this.Nome,
            musicas = listaMusicas
        });//Utilizando o new com uma estrutura temporaria

        string nomeArquivo = $"{this.Nome}.json";
        File.WriteAllText(nomeArquivo, json);//Método estatico do objeto File
        Console.WriteLine($"Arquivo json gerado com sucesso em {Path.GetFullPath(nomeArquivo)}");
    }
}