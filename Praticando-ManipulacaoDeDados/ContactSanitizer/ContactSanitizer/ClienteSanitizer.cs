using System.Globalization;
using System.Text.RegularExpressions;

namespace ContactSanitizer;

public class ClienteSanitizer
{
    public string[] ClienteValues { get; set; }
    private List<Cliente> _listCliente = new ();
    
    //Converte uma cadeia de caracteres para uma convenção conhecida! Sempre antes de usar deixar a string em LowerCase
    TextInfo textInfo = new CultureInfo("pt-BR").TextInfo; 
    public List<Cliente> Sanitize()
    {
        string[] values = {};
        
        foreach (var linha in ClienteValues)
        {
            values = linha.Split(';');
            
            string nome = textInfo.ToTitleCase(values[1].ToLower());
            string nomeFormatado = Regex.Replace(nome, @"\s{2,}", " ");
            
            string telefoneFormatado = values[2];
            
            Cliente cliente = new Cliente()
            {
                Id = int.TryParse(values[0], out int id) ? id : -1,
                Nome = nomeFormatado,
                Tel = telefoneFormatado,
                Email = values[3],
            };
            _listCliente.Add(cliente);
        }
        
        return _listCliente;
    }
}