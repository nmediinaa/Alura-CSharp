using System.Text.Json.Serialization;

namespace PraticaModelarEDesserializar.Models;

public class Filme
{
    [JsonPropertyName("id")]
    public string? IdFilme { get; set; }

    [JsonPropertyName("title")]
    public string? Nome { get; set; }

    [JsonPropertyName("year")]
    public string? AnoDeLancamento { get; set; }

    [JsonPropertyName("imDbRating")]
    public string? Nota { get; set; }
    
    public void Exibir()
    {
        Console.WriteLine($"Id: {IdFilme}");
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Ano de lançamento: {AnoDeLancamento}");
        Console.WriteLine($"Nota: {Nota}");
    }
}