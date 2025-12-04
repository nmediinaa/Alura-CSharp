using EstudanteBase;

Estudante estudante = new Estudante("Nicolas Medina");

estudante.Nota1 = 10;
estudante.Nota2 = 8.0;

Console.WriteLine($"Estudante: {estudante.Nome}\nMédia: {estudante.Media}\nSituação: {estudante.Situacao}");
