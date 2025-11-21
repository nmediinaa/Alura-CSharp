namespace Screen_Sound;

public class Episodio
{
    public int Duracao { get; }
    public int Ordem { get;  }
    public string resumo => $"Numero: {Ordem}, Titulo: {Titulo}, Duração: {Duracao}, Convidados: {convidados}";
    public string Titulo { get; }
    public int convidados { get; set;}

    public Episodio(int duracao, int ordem, string titulo)
    {
        this.Duracao = duracao;
        this.Ordem = ordem;
        this.Titulo = titulo;
    }

    public void AdicionarConvidado()
    {
        this.convidados++;
    }
    
}