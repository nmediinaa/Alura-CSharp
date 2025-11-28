namespace Screen_Sound.Models;

public class Album : IAvaliavel
{
    public string Nome { get;}
    private List<Musica> listaMusicas = new List<Musica>();//Iniciando uma lista vazia
    private List<Avaliacao> notas = new ();

    public double Media
    {
        get
        {
            if (notas.Count == 0) return 0;
            else return notas.Average(a => a.Nota);
        }
    }

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

    public void AdicionarNota(Avaliacao nota)
    {
       notas.Add(nota);
    }


}