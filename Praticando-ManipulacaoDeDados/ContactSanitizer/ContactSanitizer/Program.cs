using System.Globalization;
using ContactSanitizer;
using ContactSanitizer.Services;
using ContactSanitizer.View;

FileReader fileReader = new FileReader("Dados.txt");
string[] linhas = fileReader.ReaderLines();

ClienteSanitizer clienteSanitizer = new ClienteSanitizer();

RelatorioFinal relatorio = clienteSanitizer.Sanitize(linhas);

relatorio.ExibirRelatorio();






