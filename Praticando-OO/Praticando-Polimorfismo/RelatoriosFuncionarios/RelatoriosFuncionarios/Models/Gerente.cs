namespace RelatoriosFuncionarios.Models;

public class Gerente : Funcionario
{
    public override string GerarRelatorio()
    {
        return "Gerencia a equipe";
    }
}