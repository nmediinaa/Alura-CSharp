Dictionary<string, string> tarefas = new Dictionary<string, string>()  
{  
    { "Refatorar módulo de login", "Ana" },  
    { "Testar API de pagamentos", "Pedro" }  
}; 

tarefas.Clear();
tarefas.Add("Implementar autenticação OAuth", "João");  
tarefas.Add("Otimizar consultas SQL", "Maria");  
tarefas.Add("Atualizar documentação", "Carlos");

Console.WriteLine("Tarefas da próxima sprint:");
foreach (var tarefa in tarefas)
{
    Console.WriteLine($"- {tarefa.Key}: {tarefa.Value}");
}

void inventario()
{
    Dictionary<int, string> inventario = new Dictionary<int, string>()
    {
        { 1, "Espada Longa" },
        { 2, "Arco Curto" },
        { 3, "Escudo de Ferro" }
    };

    Console.WriteLine("Inventario inicial:");
    foreach (var item in inventario)
    {
        Console.WriteLine($"ID: {item.Key} - {item.Value}");
    }

    inventario.Remove(2);
    inventario.Add(4, "Poção de vida");

    Console.WriteLine("Inventario Atualizado:");
    foreach (var item in inventario)
    {
        Console.WriteLine($"ID: {item.Key} - {item.Value}");
    }

}
void SistemaDeNotas()
{
    Dictionary<string, double> notasPorAluno = new Dictionary<string, double>()
    {
        {"Ana", 8.75},
        {"Bruno", 6.90},
        {"Julia", 9.25}
    };

    foreach (var nota in notasPorAluno)
    {
        Console.WriteLine($"Aluno: {nota.Key}, Nota: {nota.Value}");
    }

}