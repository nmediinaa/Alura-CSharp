using System.Collections;
using System.Globalization;

Musica m1 = new();
m1.Titulo = "The Trooper";
m1.Artista = "Iron Maiden";
m1.Duracao = 430;

Musica m2 = new();
m2.Titulo = "Enter Sandman";
m2.Artista = "Metallica";
m2.Duracao = 430;

Musica m3 = new Musica() { Artista = "Limp bizkit", Titulo = "Take a look around", Duracao = 320 };
Musica m4 = new Musica() { Artista = "Limp bizkit", Titulo = "Take a look around", Duracao = 320 };


Playlist play1 = new();
play1.Nome = "Playlis do Nicolas";

play1.Add(m1);
play1.Add(m2);
play1.Add(m3);
play1.Add(m4);
play1.Add(m1);

ExibirPlaylist(play1);
//MusicaAleatoria(play1);
//OrdenarPorArtista(play1);


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

void MusicaAleatoria(Playlist playlist)
{
    var musica = playlist.MusicaAleatoria();
    Console.WriteLine($"Musica aleatória selecionada: {musica.Titulo} [{musica.Artista}]");
}

void OrdenarPorArtista(Playlist playlist)
{ 
    var musicaOrdenadas = playlist.OrdenarMusicas();
    foreach (var musica in musicaOrdenadas)
    {
        Console.WriteLine($"{musica.Titulo} [{musica.Artista}]");
    }
}

class Musica()
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }

    public override bool Equals(object? obj)
    {
        if(obj == null) return false;
        if(obj is Musica musica)  return this.Titulo.Equals(musica.Titulo) && this.Artista.Equals(musica.Artista);
        return false;
    }

    public override int GetHashCode()
    {
        return this.Titulo.GetHashCode() ^ this.Artista.GetHashCode();
    }
}

class Playlist() : ICollection<Musica>//Transformando classe playlist em uma Lista com interface ICollection
{
    private HashSet<Musica> _hashMusicas = [];
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
        if(_hashMusicas.Add(item)) _listaMusicas.Add(item);
    }

    public void Clear()
    {
        _listaMusicas.Clear();
    }

    public bool Contains(Musica item)
    {
        return _listaMusicas.Contains(item);
    }

    public List<Musica> OrdenarMusicas()
    { 
        
         List<Musica> musicasOrdenadas = _listaMusicas.OrderBy(m => m.Titulo).ToList();
         return musicasOrdenadas;
    }
    
    public Musica? MusicaAleatoria()
    { 
        if(_listaMusicas.Count == 0) return null;
        Random random = new();
        int numeroRand = random.Next(0, _listaMusicas.Count - 1);
        return _listaMusicas[numeroRand];
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