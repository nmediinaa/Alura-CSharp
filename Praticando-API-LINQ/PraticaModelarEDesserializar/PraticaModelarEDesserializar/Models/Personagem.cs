using System.Text.Json.Serialization;

namespace PraticaModelarEDesserializar.Models;

public class Personagem
{
    [JsonPropertyName("name")]
    public string? Nome { get; set; }
    
    [JsonPropertyName("gender")]
    public string? Genero { get; set; }
    
    [JsonPropertyName("born")]
    public string? Nascimento { get; set; }

    [JsonPropertyName("aliases")]
    public List<String>? Apelidos { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine("");
        Console.WriteLine($"Nome: {this.Nome}");
        Console.WriteLine($"Genero: {this.Genero}");
        Console.WriteLine($"Nascimento: {this.Nascimento}");
        Console.WriteLine($"APELIDOS do {this.Nome}");
        foreach (var a in Apelidos) Console.WriteLine("- " + a);
    }
}