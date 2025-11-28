namespace CertificadoProfissoes.Models;

public class Certificado
{
    public Profissao Profissao { get; set; }

    public Certificado(Profissao profissao)
    {
        this.Profissao = profissao;
    }

    public void Emitir()
    {
        Console.WriteLine($"Certificado emitido para {this.Profissao.Titulo}");
    }
}