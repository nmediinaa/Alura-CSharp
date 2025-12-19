namespace ToDOList;

public class MenuTaskCompleted : IMenu
{
    string title = "Menu Task Completed";
    private List<Tarefa> _listTarefas = new();
    private string[] _value;
    public void ShowHeader()
    {
        int charCount = title.Length;
        for(int i = 0 ; i < charCount; i++) Console.Write("=");
        Console.WriteLine("");
        Console.WriteLine(title);
        for(int i = 0 ; i < charCount; i++) Console.Write("=");
        Console.WriteLine("");
    }

    public int ShowOptions()
    {
        _listTarefas.Clear();
        using(FileStream fs = new FileStream("tarefa.txt", FileMode.Open))
        using (StreamReader reader = new StreamReader(fs))
        {
            while (!reader.EndOfStream)
            {
                _value = reader.ReadLine()!.Split(';');
                CreateTarefa(_value);
                Console.WriteLine($"[{_value[0]}] {_value[1]} [{_value[2]}]");
            }
        }
        
        Console.WriteLine("");
        Console.WriteLine("Digite o ID da tarefa para completar");
        Console.Write(">> ");
        int cmd = int.Parse(Console.ReadLine()!);
        CompleteTask(cmd);
        return 1;
    
    }

   
    private void CreateTarefa(string[] _value)
    {
        Tarefa _tarefa = new Tarefa();
        _tarefa.Id = int.Parse(_value[0]);
        _tarefa.Task = _value[1];
        _tarefa.Status = bool.Parse(_value[2]);
        _listTarefas.Add(_tarefa);
    }

    private void CompleteTask(int id)
    {
        Tarefa _tarefa = _listTarefas.Find(t => t.Id == id);
        if (_tarefa != null) _tarefa.Status = true;
        
        using (FileStream fs = new FileStream("tarefa.txt", FileMode.Create))
        using (StreamWriter writer = new StreamWriter(fs))
        {
            foreach (var tarefa in _listTarefas)
            {
                string idTask = tarefa.Id.ToString();
                string task = tarefa.Task;
                string status = tarefa.Status.ToString();
                string linha = $"{idTask};{task};{status}";
                writer.WriteLine(linha);
            }

        }
    }
    
}