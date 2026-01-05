using var stream = new FileStream("musicas.csv", FileMode.Open);
using var reader = new StreamReader(stream);



//Métodos
IEnumerable<Musica> MusicasDoCsv(StreamReader leitor)
{
    var linha = leitor.ReadLine();

    while (linha != null)
    {
        var partes = linha.Split(';');
        if (partes.Length != 4) continue;
        var musica = new Musica
        {
            Titulo = partes[0],
            Artista = partes[1],
            Duracao = Convert.ToInt32(partes[2]),
            Generos = partes[3].Split(',').Select(g => g.Trim()).ToArray()
        };
        yield return musica;
        linha = leitor.ReadLine();
    }
}


//Classes
class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public string[] Generos { get; set; } = [];
}