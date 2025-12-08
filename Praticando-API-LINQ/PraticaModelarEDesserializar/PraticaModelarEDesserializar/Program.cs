using System.Text.Json;
using PraticaModelarEDesserializar.Models;

using (HttpClient client = new HttpClient())
{

    try
    {
        string response = client.GetStringAsync("https://anapioficeandfire.com/api/characters/583").Result;
        var personagem = JsonSerializer.Deserialize<Personagem>(response)!;
        personagem.ExibirInformacoes();
        
    }
    catch (Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    
}