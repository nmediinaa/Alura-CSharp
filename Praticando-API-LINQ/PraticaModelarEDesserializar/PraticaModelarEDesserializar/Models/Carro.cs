using System.Text.Json.Serialization;

namespace PraticaModelarEDesserializar.Models;

public class Carro
{
    [JsonPropertyName("marca")]
    public string? Marca { get; set; }
    
    [JsonPropertyName("modelo")]
    public string? Modelo { get; set; }
    
    [JsonPropertyName("ano")]
    public int AnoDeLancamento { get; set; }

    public void Exibir()
    {
        Console.WriteLine("");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Modelo: {Modelo}");
        Console.WriteLine($"Ano de lancamento: {AnoDeLancamento}");
        
    }
}