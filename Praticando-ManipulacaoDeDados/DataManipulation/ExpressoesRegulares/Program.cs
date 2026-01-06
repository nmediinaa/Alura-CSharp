using var stream = new FileStream("musicas.csv", FileMode.Open);
using var reader = new StreamReader(stream);

var musicas = ObterMusicas(reader).Take(5);
ExibirMusicasEmTabela(musicas);

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
        var duracao = string.Format("{0,-10:F3}", musica.Duracao / 60.0);
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
            var musica = new Musica
            {
                Titulo = string.IsNullOrWhiteSpace(partes[0]) ? "Título não encontrado" : partes[0],
                Artista = string.IsNullOrWhiteSpace(partes[1]) ? "Artista não encontrado" : partes[1],
                Duracao = int.TryParse(partes[2], out int duracao) ? duracao : 350,
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