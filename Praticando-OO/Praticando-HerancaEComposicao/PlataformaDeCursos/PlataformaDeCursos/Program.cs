using PlataformaDeCursos.Interface;
using PlataformaDeCursos.Models;

Instrutor i1 = new Instrutor("Nicolas", "Back-end");
Instrutor i2 = new Instrutor("Julia", "Design");


ICurso c1 = new CursoProgramacao("C# - POO", i1);
ICurso c2 = new CursoDesign("Curso de Canva", i2);

c1.ValidarConteudo();
c1.PublicarConteudo();
Console.WriteLine("");
c2.ValidarConteudo();
c2.PublicarConteudo();