using System.Globalization;
using System.Text.RegularExpressions;

namespace ContactSanitizer;

public class ClienteSanitizer
{
    private List<Cliente> _listCliente = new ();
    private List<Cliente> _listClienteFail = new();
    public RelatorioFinal RelatorioFinal = new ();
    
    //Converte uma cadeia de caracteres para uma convenção conhecida! Sempre antes de usar deixar a string em LowerCase
    TextInfo textInfo = new CultureInfo("pt-BR").TextInfo; 
    
    public RelatorioFinal Sanitize(string[] ClienteValues)
    {
        string[] values = {};
        
        foreach (var linha in ClienteValues)
        {
            values = linha.Split(';');
            string nome = textInfo.ToTitleCase(values[1].ToLower());
            string nomeFormatado = Regex.Replace(nome, @"\s{2,}", " ");
            
            string telefone = TelValidation(values[2]);
            string email = EmailValidation(values[3]);
            
            
            Cliente cliente = new Cliente()
            {
                Id = int.TryParse(values[0], out int id) ? id : -1,
                Nome = nomeFormatado,
                Tel = telefone,
                Email = email,
            };
            if(telefone != "Invalido" && email != "Email invalido!") RelatorioFinal.AdicionarCliente(cliente);
            else RelatorioFinal.AdicionarClienteErro(cliente);
        }

        return RelatorioFinal;
    }

    private string EmailValidation(string email)
    { 
        Regex emailValidation = new Regex(@"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$");
        string emailValid = emailValidation.IsMatch(email) ? email :  "Email invalido!";
        
        return emailValid;
    }
    
    private string TelValidation(string tel)
    {
        string telefoneFormatado = Regex.Replace(tel, @"[^\d]", "");
        if (telefoneFormatado.Length < 11) return "Invalido";
        //Representa um grupo('()') no pattern do regex ($1) $2-$3
        else return Regex.Replace(telefoneFormatado, @"(\d{2})(\d{5})(\d{4})", "($1) $2-$3");
    }
}