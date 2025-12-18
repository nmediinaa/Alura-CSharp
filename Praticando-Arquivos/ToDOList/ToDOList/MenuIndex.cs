namespace ToDOList;

public class MenuIndex : IMenu
{
    string title = "To do List";
    private string[] _value;
    private List<Tarefa> _listTarefas = new();
    
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

        
        Console.WriteLine("1 - Adcionar tarefa");
        Console.WriteLine("2 - Marcar como concluida uma tarefa");
        Console.WriteLine("3 - Sair");
        Console.Write(">> ");
        int cmd = int.Parse(Console.ReadLine()!);
        return cmd;
    
    }

    private void CreateTarefa(string[] _value)
    {
        Tarefa _tarefa = new Tarefa();
        _tarefa.Id = int.Parse(_value[0]);
        _tarefa.Task = _value[1];
        _tarefa.Status = bool.Parse(_value[2]);
        _listTarefas.Add(_tarefa);
    }
}