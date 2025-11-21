namespace Screen_Sound;

public class Album
{
    public string Nome { get;}
    private List<Musica> listaMusicas = new List<Musica>();//Iniciando uma lista vazia
    public int DuracaoTotal => listaMusicas.Sum(musica =>  musica.Duracao );
    
    public Album(string nome)
    {
        Nome = nome;
    }
    
    public void AdicionarMusica(Musica musica)
    {
        listaMusicas.Add(musica);
    }

    public void ExibeMusicas()
    {
        foreach (var faixa in listaMusicas)
        {
            Console.WriteLine(faixa.Nome);
        }
        Console.WriteLine(DuracaoTotal);
    }
}