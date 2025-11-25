namespace Screen_Sound.Models;

public class Avaliacao
{
    public int Nota { get;  }

    public Avaliacao(int nota)
    {
        this.Nota = nota;
    }


    public static Avaliacao Parse(string texto)//Método estatico, podemos usar sem instaciar um objeto, pois não utiliza nada da classe
    {
        int nota = int.Parse(texto);
        return new Avaliacao(nota);
    }
}