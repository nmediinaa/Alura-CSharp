namespace RelatoriosFuncionarios.Models;

public class Desenvolvedor : Funcionario
{
    override public string GerarRelatorio()
    {
        return "Escreve código e corrige bugs";
    }
}