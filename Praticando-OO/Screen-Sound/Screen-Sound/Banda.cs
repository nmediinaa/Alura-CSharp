namespace Screen_Sound;

public class Banda
{
    public string Nome { get; }
    private List<Album> albums = new List<Album>();

    public Banda(string nome)
    {
        this.Nome = nome;
    }
    
    public void AdicionarAlbum(Album album)
    {
            albums.Add(album);
    }

    public void ExibirDiscografia()
    {
        Console.WriteLine($"Discografia da banda {Nome}:");
        foreach (var album in albums)
        {
            Console.WriteLine(album.Nome);
        }
    }
}