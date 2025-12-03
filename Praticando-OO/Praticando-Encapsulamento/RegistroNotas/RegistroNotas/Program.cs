using RegistroNotas.Models;

Avaliacao av1 = new Avaliacao("Nicolas");

av1.AtribuirNota(11);
av1.AtribuirNota(-1);

av1.AtribuirNota(10);

Console.WriteLine($"Aluno: {av1.Aluno}\nNota: {av1.Nota}");