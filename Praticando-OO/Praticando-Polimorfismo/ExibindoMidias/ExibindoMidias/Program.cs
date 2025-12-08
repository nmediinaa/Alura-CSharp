using ExibindoMidias.Models;


List<Midia> midias = new List<Midia>
{
    new Imagem("paisagem.jpg", "1920x1080"),
    new Video("GodSpeed", 120)
};

foreach (var midia in midias)
{
    midia.ExibirDetalhes();
}