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
        
        Regex emailValidation = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        
        foreach (var linha in ClienteValues)
        {
            values = linha.Split(';');
            
            string nome = textInfo.ToTitleCase(values[1].ToLower());
            string nomeFormatado = Regex.Replace(nome, @"\s{2,}", " ");
            
            string email = values[3];
            string emailValid = emailValidation.IsMatch(email) ? email : "Email invalido!";
            
            Cliente cliente = new Cliente()
            {
                Id = int.TryParse(values[0], out int id) ? id : -1,
                Nome = nomeFormatado,
                Tel = values[2],
                Email = emailValid,
            };
            _listCliente.Add(cliente);
        }
        
        return _listCliente;
    }
}