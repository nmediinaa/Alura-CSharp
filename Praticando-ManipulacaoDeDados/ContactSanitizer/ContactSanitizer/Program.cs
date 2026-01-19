using System.Globalization;
using ContactSanitizer;

FileReader fileReader = new FileReader("Dados.txt");
string[] linhas = fileReader.ReaderLines();

ClienteSanitizer clienteSanitizer = new ClienteSanitizer();

var relatorio = clienteSanitizer.Sanitize(linhas);

relatorio.ExibirRelatorio();






