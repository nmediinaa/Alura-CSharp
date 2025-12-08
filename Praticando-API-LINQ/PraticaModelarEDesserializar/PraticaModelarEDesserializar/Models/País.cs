using System.Text.Json.Serialization;

namespace PraticaModelarEDesserializar.Models;

public class País
{
    [JsonPropertyName("nome")]
    public string Nome { get; set; }
    
    [JsonPropertyName("capital")]
    public string Capital { get; set; }

    [JsonPropertyName("idioma")]
    public string Idioma { get; set; }

    [JsonPropertyName("continente")]
    public string Continente { get; set; }


    public void Exibir()
    {
        Console.WriteLine($"Nome: {Nome}");
        Console.WriteLine($"Capital: {Capital}");
        Console.WriteLine($"Idioma: {Idioma}");
        Console.WriteLine($"Continente: {Continente}");
        Console.WriteLine("");
    }
}