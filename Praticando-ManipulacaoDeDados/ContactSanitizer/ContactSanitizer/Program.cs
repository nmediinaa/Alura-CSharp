using System.Globalization;
using ContactSanitizer;
using ContactSanitizer.Services;
using ContactSanitizer.View;
using ReporterGenerator;

FileReader fileReader = new FileReader("Dados.txt");
string[] linhas = fileReader.ReaderLines();

ClienteSanitizer clienteSanitizer = new ClienteSanitizer();

RelatorioFinal relatorio = clienteSanitizer.Sanitize(linhas);

List<Dictionary<string, string>> reportData = new();
foreach (var cliente in  relatorio.ListaClientes)
{
    var record = new Dictionary<string, string>
    {
        { "Nome", cliente.Nome },
        { "Email", cliente.Email },
        { "Telefone", cliente.Tel }
    };
    
    reportData.Add(record);
}

CSVReporter reporter = new CSVReporter(reportData);

Console.WriteLine(reporter.GenerateReport("DadosClientesAtivos.csv"));
Console.WriteLine("");
relatorio.ExibirRelatorio();






