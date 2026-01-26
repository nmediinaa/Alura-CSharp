using System.Security.AccessControl;
using System.Text;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;

namespace ReporterGenerator;

public class PDFReporterGenerator : ReporterGenerator
{
    public PDFReporterGenerator(List<Dictionary<string, string>> input) : base(input){}
   

    public override string Generate()
    {
        if (Input == null || Input.Count == 0) throw new Exception("Input vazio ou nulo!");
        
        using PdfWriter writer = new ("Report.pdf");
        using PdfDocument pdf = new(writer);
        using Document document = new(pdf);

        if (!string.IsNullOrEmpty(this.Title))
        {
            Paragraph title = new Paragraph(Title)
                .SetFontSize(20)
                .SetMarginBottom(10);
            document.Add(title);
        }

        if (!string.IsNullOrEmpty(this.Description))
        {
            Paragraph description = new Paragraph(Description)
                .SetFontSize(20)
                .SetMarginBottom(10);
            document.Add(description);
        }

        Table tabela = new Table(Input.First().Keys.Count());
        
        foreach (var header in Input.First().Keys) tabela.AddCell(header);

        foreach (var row in Input)
        {
            string id = row.ContainsKey("Id") ? row["Id"] : "";
            string nome = row.ContainsKey("Nome") ? row["Nome"] : "";
            string email =  row.ContainsKey("Email") ? row["Email"] : "";
            string telefone = row.ContainsKey("Tel") ? row["Tel"] : "";
            
            tabela.AddCell(id);
            tabela.AddCell(nome);
            tabela.AddCell(email);
            tabela.AddCell(telefone);
        }
        
        document.Add(tabela);

        if (!string.IsNullOrEmpty(this.Footer))
        {
            Paragraph footer = new Paragraph(Footer);
            document.Add(footer);
        }
            
        return Path.GetFullPath("Report.pdf");
    }
}