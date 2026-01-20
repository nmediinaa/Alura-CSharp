using ContactSanitizer.Models;

namespace ContactSanitizer.View;

public class RelatorioFinal
{
    public List<Cliente> ListaClientes { get; private set; } = new();
    public List<Cliente> ListaClienteError { get; private set; } = new();

    public void AdicionarCliente(Cliente cliente)
    {
        ListaClientes.Add(cliente);
    }

    public void AdicionarClienteErro(Cliente cliente)
    {
        ListaClienteError.Add(cliente);
    }

    public void ExibirRelatorio()
    {
        string titulo = "Relatório de Clintes CSV".PadLeft(55, '=').PadRight(90, '=');
        Console.WriteLine(titulo);
        Console.WriteLine("");
        
        foreach (var cliente in ListaClientes)
        {
            Console.WriteLine($" [SUCESSO] | Id: {cliente.Id} | Nome: {cliente.Nome} | Tel: {cliente.Tel} | Email: {cliente.Email}");
        }

        Console.WriteLine("");
        string tituloClienteInvalidos = "Clientes Invalidos".PadLeft(50, '=').PadRight(90, '=');
        Console.WriteLine(tituloClienteInvalidos);
        Console.WriteLine("");

        foreach (var cliente in ListaClienteError)
        {
            Console.WriteLine($" [ERRO] | Id: {cliente.Id} | Nome: {cliente.Nome} | Tel: {cliente.Tel} | Email: {cliente.Email}");
        }

        Console.WriteLine("");
        for(int i = 0; i < tituloClienteInvalidos.Length; i++) Console.Write('=');
    }
}