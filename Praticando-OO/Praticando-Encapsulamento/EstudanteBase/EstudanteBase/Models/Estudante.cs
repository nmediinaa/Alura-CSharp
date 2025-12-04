namespace EstudanteBase;

public class Estudante
{
    public string Nome { get; private set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    
    public double Media
    {
        get
        {
            return (Nota1 + Nota2) / 2;
        }
    }

    public string Situacao
    {
        get
        {
            if (Media >= 6) return "Aprovado";
            else return "Reprovado";
        }
    }

    public Estudante(string nome)
    {
        this.Nome = nome;
    }
}