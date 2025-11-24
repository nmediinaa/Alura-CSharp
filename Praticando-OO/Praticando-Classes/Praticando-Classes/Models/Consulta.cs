namespace Praticando_Classes.Models;

public class Consulta
{
    public string NomePaciente { get; set; }
    public string NomeMedico { get; set; }
    public DateTime DataConsulta { get; set; }

    public Consulta(string nomePaciente, string nomeMedico, DateTime dataConsulta)
    {
        this.NomePaciente = nomePaciente;
        this.NomeMedico = nomeMedico;
        this.DataConsulta = dataConsulta;
    }

    public void Reagendar(DateTime dataConsulta)
    {
        this.DataConsulta = dataConsulta;
    }

    public void ExibirResumo()
    {
        Console.WriteLine($"Consulta marcada com Dr(a).{this.NomeMedico} para o(a) paciente {this.NomePaciente}");
        Console.WriteLine($"Data: {this.DataConsulta}");
    }
}