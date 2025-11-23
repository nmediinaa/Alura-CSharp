using Praticando_Classes.Models;

//Exercicio 1 - Classe Livro

Livro livro1 = new Livro();

livro1.Titulo = "Dom casurro";
livro1.Autor = "Machado de Assis";

Console.WriteLine($"Livro: {livro1.Titulo} \nAutor: {livro1.Autor}");
Console.WriteLine("");

//Exercicio 2 - Classe Passagem

Passagem passagem1 = new Passagem("Nicolas Medina", "Espanha");

Console.WriteLine($"Passagem\nPassageiro: {passagem1.Passageiro}\nDestino: {passagem1.Destino}");
Console.WriteLine("");

//Exercicio 3 - Classe Conta Bancario

ContaBancaria contaNicolas = new ContaBancaria("12345-0",30200);

contaNicolas.Depositar(5000);
Console.WriteLine("");

//Exercicio 4 - Gerenciamento de funcionarios

Funcionario funcionario1 = new Funcionario("Nicolas Medina", "Analista de desenvolvimento Junior");

funcionario1.Promover("Analista de desenvolvimento Junior");
funcionario1.Promover("Analista de desenvolvimento Pleno");
Console.WriteLine("");

//Exercicio 5 - Retangulos e calculando área
Retangulo retangulo = new Retangulo();
retangulo.Altura = 5;
retangulo.Largura = 8;

Console.WriteLine($"Area do retangulo: {retangulo.AreaRetangulo}");
Console.WriteLine("");

//Exercicio 6 - Classificação etaria
Filme filme = new Filme("Matrix", 18);

filme.PodeAssistir(17);
filme.PodeAssistir(18);
