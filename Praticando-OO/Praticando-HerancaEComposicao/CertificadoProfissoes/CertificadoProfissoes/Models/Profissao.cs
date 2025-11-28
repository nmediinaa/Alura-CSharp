namespace CertificadoProfissoes.Models;

public abstract class Profissao
{
    public string Titulo { get; set; }

    protected Profissao(string titulo)
    {
        Titulo = titulo;
    }
}