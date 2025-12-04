using ControleMatricula.Models;

Curso curso00 = new Curso("Ciencia da Computação", 2);

curso00.Matricular(new Estudante("Nicolas Medina"));
//curso00.Matricular(new Estudante("Ivan Oritz"));
//curso00.Matricular(new Estudante("XPTO"));

curso00.ListarMatriculados();