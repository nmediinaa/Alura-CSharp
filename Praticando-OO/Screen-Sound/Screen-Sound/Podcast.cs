namespace Screen_Sound;

public class Podcast
{
    public string Host { get; }
    public string Nome { get; }

    private List<Episodio> episodios = new List<Episodio>();

    public Podcast(string host, string nome)
    {
        this.Host = host;
        this.Nome = nome;
    }

    public void AdicionarEpisodios(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine("");
        Console.WriteLine("");
        Console.WriteLine("DETALHES DO PODCAST");
        Console.WriteLine($"Nome: {this.Nome}, Host: {this.Host}");
        Console.WriteLine($"EPISODIOS DO PODCAST {this.Nome}");
        foreach (var espisodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(espisodio.resumo);
        }

        Console.WriteLine($"Numero total de episodios: {episodios.Count}");
    }
}