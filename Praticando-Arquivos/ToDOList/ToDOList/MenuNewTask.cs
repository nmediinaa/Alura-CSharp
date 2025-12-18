namespace ToDOList;

public class MenuNewTask : IMenu
{
    private string title = "NEW TASK";
    
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
        Console.WriteLine("Digite o ID da tarefa:");
        Console.Write(">> ");
        string id = Console.ReadLine();
        
        Console.WriteLine("Digite o nome da tarefa:");
        Console.Write(">> ");
        string task = Console.ReadLine();

        string linha = $"{id};{task};false";
        
        using(FileStream fs = new FileStream("tarefa.txt", FileMode.Append))
        using (StreamWriter writer = new StreamWriter(fs))
        {
            writer.WriteLine(linha);
        }
        
        return 1;
    }
}