//Trabalhando o conceito de composição

using MontagemComputadores.Models;

Processador p = new Processador("Ryzen", "Ryzen 7");
PlacaMae placaMae = new PlacaMae("Gigabyte", "AM4");

Computador comp1 = new Computador(p, placaMae);

comp1.ExibirInfo();