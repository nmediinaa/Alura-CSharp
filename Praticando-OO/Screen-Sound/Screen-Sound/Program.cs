using Screen_Sound;

// Manipulando a classe Banda
Banda linkinPark = new Banda("Linkin Park");



// Manipulando a classe Musica
Musica musica3 = new Musica("Papercut", linkinPark)
{
    Duracao = 230,
    Disponivel = false,
};

Musica musica4 = new Musica("One Step Closer", linkinPark)
{
    Duracao = 300,
    Disponivel = true,
};


musica3.ExibeFicha();
Console.WriteLine();
musica4.ExibeFicha();

// Manipulando a classe Album

Album albumLinkinPark = new Album("Hybrid Theory");
albumLinkinPark.AdicionarMusica(musica3);
albumLinkinPark.AdicionarMusica(musica4);
albumLinkinPark.ExibeMusicas();

// Manipulando a classe Banda

linkinPark.AdicionarAlbum(albumLinkinPark);
linkinPark.ExibirDiscografia();

// Manipulando a classe Podcast e Episodio

Podcast flow = new Podcast("Igor3k", "FlowPodCast");

Episodio ep = new Episodio(duracao: 120, ordem: 1, titulo: "MONARK e IGOR");
ep.AdicionarConvidado();
ep.AdicionarConvidado();
Episodio ep2 = new Episodio(duracao: 120, ordem: 2, titulo: "Rato borrachudo");
ep2.AdicionarConvidado();

flow.AdicionarEpisodios(ep);
flow.AdicionarEpisodios(ep2);

flow.ExibirDetalhes();
