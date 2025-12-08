using AvaliarConteudos.Models;

List<Conteudos> conteudos = new List<Conteudos>
{
    new AulaGravada("Tudo sobre CSharp", 120),
    new MaterialComplementar("Macetes do CSharp", 60),
};

foreach (var conteudo in conteudos)
{
    conteudo.ExibirInfo();
}