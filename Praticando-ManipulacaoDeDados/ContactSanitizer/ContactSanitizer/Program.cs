using System.Globalization;
using ContactSanitizer;

FileReader fileReader = new FileReader("Dados.txt");
string[] linhas = fileReader.ReaderLines();

ClienteSanitizer clienteSanitizer = new ClienteSanitizer()
{
    ClienteValues = linhas
};

var listaCliente = clienteSanitizer.Sanitize();

foreach (var cliente in listaCliente)
{
    Console.WriteLine($" | [{cliente.Id}] {cliente.Nome} {cliente.Tel} {cliente.Email}");
}



