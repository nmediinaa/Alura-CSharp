namespace TarefasAgendadas.Models;

public class BackupTarefa : TarefaAgendada
{
    public override string Executar()
    {
        return "Executando Backup do sistema...";
    }
}