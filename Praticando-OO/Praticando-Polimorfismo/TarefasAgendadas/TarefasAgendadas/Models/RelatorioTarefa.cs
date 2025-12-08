namespace TarefasAgendadas.Models;

public class RelatorioTarefa : TarefaAgendada
{
    public override string Executar()
    {
        return "Gerando e enviando relatório diário...";
    }
}