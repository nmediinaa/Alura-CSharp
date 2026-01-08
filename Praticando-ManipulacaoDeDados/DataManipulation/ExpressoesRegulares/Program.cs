using System.Text.Json;
using System.Text.Json.Serialization;
using System.Text.RegularExpressions;

using var stream = new FileStream("musicas.csv", FileMode.Open);
using var reader = new StreamReader(stream);

Regex regexCharEspecial = new Regex(@"[^a-zA-Z0-9\s]");

CreatingJsonFile(reader);

//ArtistasComCharEspecial(regexCharEspecial, reader);

void CreatingJsonFile(StreamReader reader)
{
    var musicas = ObterMusicas(reader)
        .GroupBy(m => m.Artista)
        .Select(g => new { Artista = g.Key, Musicas = g.OrderBy(m => m.Lancamento), Total = g.Count() })
        .ToList();

    var path = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "Artistas.json");//Buscando o caminho de um diretório

    using var jsonFile = new FileStream(path, FileMode.Create, FileAccess.Write);
    var options = new JsonSerializerOptions { WriteIndented = true };
    JsonSerializer.Serialize(jsonFile, musicas, options);

    Console.WriteLine("Arquivo JSON Gerado!");
}
void ArtistasComCharEspecial(Regex regex, StreamReader reader)
{
    var artistasComCharEspeciais = ObterMusicas(reader)
        .Where(m => regexCharEspecial.IsMatch(m.Artista))
        .Select(m => m.Artista)
        .Distinct();
    
    foreach (var artista in artistasComCharEspeciais)
    {
        Console.WriteLine(artista);
    } 
}

void ExibirMusicasEmTabela(IEnumerable<Musica> musicas)
{
    var titulo = "\nMúsicas do arquivo:"; // string literal
    Console.WriteLine(titulo);

    var colunaTitulo = "Título".PadRight(40);
    var colunaArtista = "Artista".PadRight(30);
    var colunaDuracao = "Duração".PadRight(10);
    var colunaLancamento = "Lançada Em".PadRight(15);
    Console.WriteLine($"{colunaTitulo}{colunaArtista}{colunaDuracao}{colunaLancamento}");
    var borda = "".PadRight(100, '=');
    Console.WriteLine(borda);

    foreach (var musica in musicas)
    {
        var duracao = string.Format("{0,-10:F2}", musica.Duracao / 60.0);
        var linha = $"{musica.Titulo,-40}{musica.Artista,-30}{duracao}{musica.Lancamento,-15:dd/MM/yyyy}";
        Console.WriteLine(linha);
    }
}

IEnumerable<Musica> ObterMusicas(StreamReader stream)
{
    var linha = stream.ReadLine();
    while (linha is not null)
    {
        var partes = linha.Split(';');
        if (partes.Length == 5)
        {
            int duracao = 350;
            Match match = Regex.Match(partes[2], @"(\d?\d):(\d\d)");
            if (match.Success)
            {
               var grupos = match.Groups;
               var minutos = grupos[1].Value;
               var segundos = grupos[2].Value;

               duracao = (int.Parse(minutos) * 60) + int.Parse(segundos);
            }
            var musica = new Musica
            {
                Titulo = string.IsNullOrWhiteSpace(partes[0]) ? "Título não encontrado" : partes[0],
                Artista = string.IsNullOrWhiteSpace(partes[1]) ? "Artista não encontrado" : partes[1],
                Duracao = duracao,
                Generos = partes[3].Split(',', StringSplitOptions.TrimEntries),
                Lancamento = DateTime.TryParse(partes[4], out var data) ? data : DateTime.Today
            };
            yield return musica;
        }
        linha = stream.ReadLine();
    }
}

class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public IEnumerable<string> Generos { get; set; }
    public DateTime Lancamento { get; set; }
}