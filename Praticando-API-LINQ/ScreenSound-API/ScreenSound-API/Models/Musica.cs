using System.Security.Principal;
using System.Text.Json.Serialization;

namespace ScreenSound_API.Models;

public class Musica
{
    private readonly List<string> tonalidade = new List<string>()
    {
        "C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B"
    };
    
    [JsonPropertyName("song")] //Anotação
    public string? Nome { get; set; }

    [JsonPropertyName("artist")] 
    public string? Artista { get; set; } //? operador que indica que a prop pode ser nula

    [JsonPropertyName("duration_ms")] 
    public int Duracao { get; set; }

    [JsonPropertyName("genre")] 
    public string? Genero { get; set; }

    [JsonPropertyName("year")] 
    public string AnoDeLancamento { get; set; }

    [JsonPropertyName("key")]
    public int Tom { get; set; }
    public string Tonalidade {
        get
        {
            return tonalidade[Tom];
        } 
    }



    public void ExibirDetalhes()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Artist: {Artista}");
        Console.WriteLine($"Ano de lancamento: {AnoDeLancamento}");
        Console.WriteLine($"Duracao: {Duracao/1000}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Tonalidade: {this.Tonalidade}");
    }
    
}