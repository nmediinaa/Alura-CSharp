using ControleAgenda.Models;
Agenda agenda = new Agenda("Nicolas Books");

agenda.AdicionarContato(new Contato("Julia Menossi", 1199999988));
agenda.AdicionarContato(new Contato("Julia Menossi", 1199999988));
agenda.AdicionarContato(new Contato("Ivan Medina", 1199977778));

agenda.ListarContatos();