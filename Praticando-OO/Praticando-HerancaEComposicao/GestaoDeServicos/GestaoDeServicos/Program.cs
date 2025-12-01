using GestaoDeServicos.Interface;
using GestaoDeServicos.Model;

Funcionario tecnico = new Funcionario("Nicolas", "TI");
IServico s1 = new Manutencao("Atualização de servidor", tecnico);

Funcionario analista = new Funcionario("Julia", "Consultoria");
IServico s2 = new Consultoria("Planejamento estratégico", analista);

s1.ExecutarServico();
s2.ExecutarServico();