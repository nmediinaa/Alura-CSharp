using System.Text.Json.Serialization;

namespace PraticaModelarEDesserializar.Models;

public class Livro
{
    [JsonPropertyName("titulo")]
    public string? Nome { get; set; }
    
    [JsonPropertyName("autor")]
    public string? Autor { get; set; }
    
    [JsonPropertyName("genero")]
    public string? Genero { get; set; }
    
    [JsonPropertyName("ano_publicacao")]
    public int AnoDeLancamento { get; set; }

    public void ExibirInformacoes()
    {
        Console.WriteLine("");
        Console.WriteLine($"Titulo: {Nome}");
        Console.WriteLine($"Autor: {Autor}");
        Console.WriteLine($"Genero: {Genero}");
        Console.WriteLine($"Ano de lancamento: {AnoDeLancamento}");
    }
}