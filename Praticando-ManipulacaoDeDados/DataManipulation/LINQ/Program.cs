IEnumerable<Musica> listaMusicas = ObterMusicas("C:\\Projetos\\Pessoais\\Alura-CSharp\\Praticando-ManipulacaoDeDados\\DataManipulation\\OperacoesComColecoes\\musicas.csv");

IEnumerable<Musica> musicasFiltradas = 
    listaMusicas.Where(m => m.Artista == "Metallica")
    .Where(m => m.Duracao > 300)
    .OrderBy(m => m.Titulo)
    .ThenBy(m => m.Duracao)
    .Skip(5)
    .Take(5);
//ExibirMusicas(musicasFiltradas);


var generos = 
    listaMusicas.SelectMany(m => m.Genero)//Junta todos os itens da sublista Genero em uma só
        .Distinct()
        .OrderBy(g => g);
//ExibindoGeneros(generos);


var artistas = listaMusicas.GroupBy(m => m.Artista)
    .Where(m => m.Count() > 10);
//ExibindoMusicasByArtistas(artistas);

var artistaComMaisMusicas = 
    listaMusicas.GroupBy(m => m.Artista)
        .Select(a => new {Nome = a.Key, Musicas = a, Total = a.Count() })
        .MaxBy(a => a.Total);
if(artistaComMaisMusicas is not null)
    Console.WriteLine($"Artista com mais musica é {artistaComMaisMusicas.Nome} com {artistaComMaisMusicas.Total} musicas");
//Métodos
void ExibindoMusicasByArtistas(IEnumerable<IGrouping<string, Musica>> artistas)
{
    foreach (var artista in artistas.Take(5))
    {
        Console.WriteLine($"Musicas do artista {artista.Key} [{artista.Count()} Músicas]");
        foreach (var musica in artista)
        {
            Console.WriteLine($"\t- {musica.Titulo}");
        }
    }
}
void ExibindoGeneros(IEnumerable<string> generos)
{
    Console.WriteLine("Exibindo Generos do arquivo:");
    foreach (var genero in generos) Console.WriteLine($"\t- {genero}");
    
}
void ExibindoArtistas(IEnumerable<string> artistas)
{
    Console.WriteLine("Artistas do arquivo:");
    foreach (var artista in artistas)
    {
        Console.WriteLine($"\t- {artista}");
    }    
}
void ExibirMusicas(IEnumerable<Musica> musicas)
{
    int cont = 0;
    Console.WriteLine("Musicas no arquivo:");
    foreach (var musica in musicas)
    {
        Console.WriteLine($"\t- {musica.Titulo} - [{musica.Artista}] | [{musica.Duracao}Ms]");
        cont++;
        if (cont == 10) break;
    }
}


IEnumerable<Musica> ObterMusicas(string path)
{
    using (FileStream arquivo = new FileStream(path, FileMode.Open))
    {
        string[] linhas = [];
        StreamReader reader = new StreamReader(arquivo);

        while (!reader.EndOfStream)
        {
            string linha = reader.ReadLine();
            linhas =  linha.Split(';');
            Musica musica = new Musica();
            musica.Titulo = linhas[0];
            musica.Artista = linhas[1];
            musica.Duracao = int.Parse(linhas[2]);
            musica.Genero = linhas[3].Split(',').Select(g => g.Trim());
            yield return musica;
        }
    
    }  
}

//Classes
class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public IEnumerable<string> Genero { get; set; }
}