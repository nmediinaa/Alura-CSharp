
void RelatorioEntrega()
{
    Console.WriteLine("Digite o nome do cliente:");
    string nome = Console.ReadLine()!;
    Console.WriteLine("Digite o endereço do cliente:");
    string enderecoCliente = Console.ReadLine()!;
    Console.WriteLine("Digite o valor do frete!");
    double frete = double.Parse(Console.ReadLine()!);
    Console.WriteLine("Digite a data de entrega:");
    DateTime data = DateTime.TryParse(Console.ReadLine()!, out data) ? data : DateTime.MinValue;

    Console.WriteLine("========== RELATÓRIO DE ENTREGA ==========");
    Console.WriteLine($"Cliente: {nome, 20}");
    Console.WriteLine($"Endereço: {enderecoCliente, 16}");
    Console.WriteLine($"Valor do frete: {frete, 10:C0}");
    Console.WriteLine($"Data entrega: {data, 14:dd/MM/yyyy}");
    Console.WriteLine("==========================================");
}


void PalavrasToUpper()
{
    Console.WriteLine("Digite o alerta:");
    string textoChave = Console.ReadLine()!;

    Console.WriteLine(textoChave.ToUpper());
}
void LendoLogs()
{
    string log = "2025-03-25,Erro,Arquivo não encontrado";

    var mensageErro = log.Split(",");
    bool dataConversao = DateTime.TryParse(mensageErro[0], out DateTime data);

    Console.WriteLine($"Data: {(dataConversao ? data.ToString(): "Null")}");
    Console.WriteLine($"Erro: {mensageErro[1]}");
    Console.WriteLine($"Mensagem: {mensageErro[2]}"); 
}

void SubstituirPalavraEmTexto()
{
    Console.WriteLine("Digite um texto:");
    string textoChave = Console.ReadLine()!;
    Console.WriteLine("Qual palavra você quer substituir?");
    string textoParaSubstituir = Console.ReadLine()!;
    Console.WriteLine("Por qual palavra?");
    string textoSubstituto = Console.ReadLine()!;
    
    var id = textoChave.IndexOf(textoParaSubstituir, StringComparison.OrdinalIgnoreCase);
    textoChave = textoChave.Remove(id);
    textoChave = textoChave.Insert(id, textoSubstituto);
    
    //Podemos tbm usar o replace, textoChave = textoChave.Replace(textoParaSubstituir, textoSubstituto);
    Console.WriteLine(textoChave); 
}

void NumeroChars()
{
    Console.WriteLine("Digite um texto:");
    string textoChave = Console.ReadLine()!;
    Console.WriteLine($"Numeros caracteres(contando espaço): {textoChave.Length}");
}

void PalvraChave()
{
    Console.WriteLine("Digite um texto:");
    string textoChave = Console.ReadLine()!;
    Console.WriteLine("Digite uma palavra chave:");
    string palavraChave = Console.ReadLine()!;

    if(textoChave.Contains(palavraChave, StringComparison.OrdinalIgnoreCase)) Console.WriteLine("A palavra-chave foi encontrada na pesquisa.");
    else Console.WriteLine("Palavra chave não encontrada!");
}