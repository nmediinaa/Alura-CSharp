using System.Collections;

Musica m1 = new();
m1.Titulo = "The Trooper";
m1.Artista = "Iron Maiden";
m1.Duracao = 430;

Musica m2 = new();
m2.Titulo = "Enter Sandman";
m2.Artista = "Metallica";
m2.Duracao = 430;

Musica m3 = new Musica() { Artista = "Limp bizkit", Titulo = "Take a look around", Duracao = 320 };

Playlist play1 = new();
play1.Nome = "Playlis do Nicolas";

play1.Add(m1);
play1.Add(m2);
play1.Add(m3);

ExibirPlaylist(play1);
RemoverPorTitulo("The Trooper", play1);
ExibirPlaylist(play1);


void ExibirPlaylist(Playlist playlist)
{
    Console.WriteLine($"Exibindo {playlist.Nome}");
    foreach (var musica in playlist)
    {
        Console.WriteLine($"    - {musica.Titulo} [{musica.Artista}]");
    }
}

void RemoverPorTitulo(string titulo, Playlist playlist)
{
    Musica? musica = playlist.MusicaPeloTitulo(titulo);
    if (musica is not null)
    {
        Console.WriteLine($"Removendo {musica.Titulo} [{musica.Artista}]");
        playlist.Remove(musica);
    }
    else Console.WriteLine("Nenhuma musica encontrada...");
}


class Musica()
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }

}

class Playlist() : ICollection<Musica>//Transformando classe playlist em uma Lista com interface ICollection
{
    private List<Musica> _listaMusicas = [];
    public string Nome { get; set; }

    public IEnumerator<Musica> GetEnumerator()
    {
        return _listaMusicas.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(Musica item)
    {
        _listaMusicas.Add(item);
    }

    public void Clear()
    {
        _listaMusicas.Clear();
    }

    public bool Contains(Musica item)
    {
        return _listaMusicas.Contains(item);
    }

    public void CopyTo(Musica[] array, int arrayIndex)
    {
        throw new NotImplementedException();
    }

    public bool Remove(Musica item)
    {
        return _listaMusicas.Remove(item);
    }

    public Musica? MusicaPeloTitulo(string titulo)
    {
        var musicaEncontrada = _listaMusicas.FirstOrDefault(m => m.Titulo == titulo);
        if (musicaEncontrada == null) return null;
        return musicaEncontrada;
    }

    public int Count
    {
        get { return _listaMusicas.Count; }
    }

    public bool IsReadOnly
    {
        get { return false; }
    }
}