//Soma de um Array

double[] doaces = {103.54, 259.72, 82.16, 154.87, 364.45, 14.49 };
//SomarValores(doaces);

//Ordenando Listas
string[] nomes = { "Fernanda", "Eduardo", "Gustavo", "Carolina", "Alice", "Bruno", "Daniel" };  
Array.Sort(nomes);

//Console.WriteLine($"O terceito nome da lista após a ordenação é {nomes[2]}");

//Trabalhando com indices

int[] numeros = { 5, 42, 8, 11, 23, 1, 14, 30, 19, 27, 36, 2, 50, 7, 18, 9 };

var primeiroDigito = Array.IndexOf(numeros, 19);
var segundoDigito = Array.IndexOf(numeros, 42);
var terceiroDigito = Array.IndexOf(numeros, 7);
Console.WriteLine($"Combinação do cadeado: {primeiroDigito}-{segundoDigito}-{terceiroDigito}");
//Métodos
void SomarValores(double[] doacoes)
{
    double totalDoacoes = 0;
    foreach (var valor in doaces)
    {
        totalDoacoes += valor;
    }

    Console.WriteLine($"Total de doações: {totalDoacoes:F2}");
}