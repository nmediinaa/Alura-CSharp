
IEnumerable<Musica> listaMusicas = ObterMusicas("C:\\Projetos\\Pessoais\\Alura-CSharp\\Praticando-ManipulacaoDeDados\\DataManipulation\\OperacoesComColecoes\\musicas.csv");
ExibirMusicas(listaMusicas);

//Métodos
void ExibirMusicas(IEnumerable<Musica> musicas)
{
    int cont = 0;
    Console.WriteLine("Musicas no arquivo:");
    foreach (var musica in musicas)
    {
        Console.WriteLine($"\t- {musica.Titulo} - [{musica.Artista}] | [{musica.Duracao}Ms]");
        cont++;
        if (cont == 5) break;
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
}