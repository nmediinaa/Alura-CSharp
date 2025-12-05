//Polimorfismo de subtipos, pois, uma unica referencia pode assumir varias "formas"

using RelatoriosFuncionarios.Models;

Funcionario f1 = new Gerente();
Funcionario f2 = new Desenvolvedor();

Console.WriteLine(f1.GerarRelatorio());
Console.WriteLine(f2.GerarRelatorio());