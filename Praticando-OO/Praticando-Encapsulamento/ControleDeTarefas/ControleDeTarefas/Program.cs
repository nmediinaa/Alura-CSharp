using ControleDeTarefas.Models;

Projeto p1 = new Projeto("Sistema de login");

p1.AdicionarTarefa("Criar tela de login");
p1.AdicionarTarefa("Implementar banco de dados");

p1.ExibirTarefas();