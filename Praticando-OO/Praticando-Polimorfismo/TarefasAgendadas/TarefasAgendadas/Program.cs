using TarefasAgendadas.Models;

List<TarefaAgendada> tarefasAgendadas = new List<TarefaAgendada>
{
    new BackupTarefa(),
    new LimpezaTarefa(),
    new RelatorioTarefa()
};

foreach (var tarefa in tarefasAgendadas)
{
    Console.WriteLine(tarefa.Executar());
   
}