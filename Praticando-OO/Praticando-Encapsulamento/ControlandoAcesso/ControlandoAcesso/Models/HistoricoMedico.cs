namespace ControlandoAcesso.Models;

internal class HistoricoMedico
{
    public string CodigoProntuario { get; private set; }

    public HistoricoMedico(string codigoProntuario)
    {
        this.CodigoProntuario = codigoProntuario;
    }

    public void ExibirCodigo()
    {
        Console.WriteLine($"Código Prontuario: {this.CodigoProntuario}");
    }
    
}