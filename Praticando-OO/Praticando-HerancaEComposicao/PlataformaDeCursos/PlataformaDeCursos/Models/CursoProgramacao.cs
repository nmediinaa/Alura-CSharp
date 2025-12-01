using PlataformaDeCursos.Interface;

namespace PlataformaDeCursos.Models;

public class CursoProgramacao : ICurso
{
    public string Titulo { get; set; }
    public Instrutor Instrutor { get; set; }

    public CursoProgramacao(string titulo, Instrutor instrutor)
    {
        this.Titulo = titulo;
        this.Instrutor = instrutor;
    }
    
    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de programação: {this.Titulo}");
    }

    public void PublicarConteudo()
    {
        Console.WriteLine($"Curso publicado com sucesso: {this.Titulo} - {this.Instrutor.Nome} ({this.Instrutor.Especialidade})");
    }
}