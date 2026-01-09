//Soma de um Array

double[] doaces = {103.54, 259.72, 82.16, 154.87, 364.45, 14.49 };

//SomarValores(doaces);

void SomarValores(double[] doacoes)
{
    double totalDoacoes = 0;
    foreach (var valor in doaces)
    {
        totalDoacoes += valor;
    }

    Console.WriteLine($"Total de doações: {totalDoacoes:F2}");
}

//Ordenando Listas
string[] nomes = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };  
Array.Sort(nomes);
//Console.WriteLine($"O terceito nome da lista após a ordenação é {nomes[2]}");


//Trabalhando com indices
int[] numeros = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };

var primeiroDigito = Array.IndexOf(numeros, 19);
var segundoDigito = Array.IndexOf(numeros, 42);
var terceiroDigito = Array.IndexOf(numeros, 7);
//Console.WriteLine($"Combinação do cadeado: {primeiroDigito}-{segundoDigito}-{terceiroDigito}");

//Trabalhando com HashSet e Listas
HashSet<int> scores = new HashSet<int>();//Nn repete itens 

scores.Add(150);
scores.Add(90);
scores.Add(200);
scores.Add(120);
scores.Add(150);
scores.Add(80);
scores.Add(180);
scores.Add(200);

List<int> scoresList = scores.OrderBy(s => s).ToList();//Transformamos em lista para usar o OrderBy

Console.WriteLine("Scores únicos em ordem crescente:");
foreach (var valor in scoresList)
{
    Console.WriteLine(valor);
}

List<char> charsSequence = new List<char>(){'o', 'd', 'n', 'u', 'm', ' ', 'á', 'l', 'o'};
charsSequence.Reverse();
foreach (var valor in charsSequence)
{
    Console.WriteLine(valor);
}


void SorteioNomes()

{
    List<string> nomesSorteio = new List<string> { "Ana", "Carlos", "Mariana", "João", "Lucas" };
    nomesSorteio.Sort();

    Console.WriteLine("Após Sort (ordem alfabética):");
    foreach (var valor in nomesSorteio)
    {
        Console.WriteLine(valor);
    }

    nomesSorteio.Reverse();

    Console.WriteLine("Após Reverse (ordem invertida):");
    foreach (var valor in nomesSorteio)
    {
        Console.WriteLine(valor);
    }

    string primeiroNome = nomesSorteio[0];
    nomesSorteio.Remove(primeiroNome);
    nomesSorteio.Add(primeiroNome);;

    Console.WriteLine("Após remover o primeiro e adicioná-lo no fim:");
    foreach (var valor in nomesSorteio)
    {
        Console.WriteLine(valor);
    }

    Console.WriteLine($"Pessoa sorteada foi: {nomesSorteio[3]}");
}

List<string> produtosPrincipal = new List<string> { "Mouse", "Teclado", "Monitor", "Joystick"};  
List<string> produtosSecundaria = new List<string> { "Headset", "Webcam", "Smartphone", "Mousepad"};

foreach (var produto in produtosSecundaria) produtosPrincipal.Add(produto);

Console.WriteLine("Lista consolidada:");
foreach (var produto in produtosPrincipal)
{
    Console.WriteLine(produto);
}
