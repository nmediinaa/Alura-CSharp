namespace TarefasAgendadas.Models;

public class LimpezaTarefa : TarefaAgendada
{
    public override string Executar()
    {
        return "Limpando arquivos temporários do servidor...";
    }
}