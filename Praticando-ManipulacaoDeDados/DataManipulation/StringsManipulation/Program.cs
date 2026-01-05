using var stream = new FileStream("musicas.csv", FileMode.Open);
using var reader = new StreamReader(stream);

var musicas = MusicasDoCsv(reader)
    .Where(m => m.Artista.Equals("Coldplay", StringComparison.OrdinalIgnoreCase))
    .Take(5);

ExibirMusicas(musicas);
//Métodos
void ExibirMusicas(IEnumerable<Musica> musicas)
{
    string colunaTitulo = "Titulo".PadRight(40);
    string colunaArtista = "Artista".PadRight(20);
    string colunaDuracao = "Duracao".PadRight(20);
    string colunaGenero = "Genero".PadRight(20);
    string colunaLancamento = "Lancamento".PadRight(20);
    
    Console.WriteLine("Musicas do Arquivo".PadLeft(53));
    Console.WriteLine(colunaTitulo + colunaArtista + colunaDuracao + colunaGenero + colunaLancamento);
    Console.WriteLine("".PadRight(120, '='));
    int cont = 0;
    foreach (var musica in musicas.Take(5))
    {
        Console.WriteLine($"{musica.Titulo,-40}{musica.Artista,-20}{musica.Duracao/60.0,-20:F2}{musica.Generos[0],-20}{musica.Lancamento,-20:dd/MM/yyyy}");
        Console.WriteLine("".PadRight(120, '-'));
    }
}

void Senha()
{
    var senha = "Nicolas@26";

    int totalCaracteres = senha.Length;// ou poderiamos usar o .Count()
    int possuiLetrasMaiusculas = senha.Count(c => char.IsUpper(c)!);
    int possuiLetrasMinusculas = senha.Count(c => char.IsLower(c)!);
    int possuiNumero = senha.Count(c => char.IsDigit(c)!);
    int possuiSimbolo = senha.Count(c => !char.IsLetterOrDigit(c));

    if (totalCaracteres < 8 || possuiLetrasMaiusculas == 0 ||
        possuiLetrasMinusculas == 0 || possuiNumero == 0 ||
        possuiSimbolo == 0)
    {
        Console.WriteLine("SENHA FRACA");
    }else Console.WriteLine("Senha FORTE!");
}

IEnumerable<Musica> MusicasDoCsv(StreamReader leitor)
{
    var linha = leitor.ReadLine();

    while (linha != null)
    {
        var partes = linha.Split(';');
        if (partes.Length == 5)
        {
            var musica = new Musica
            {
                Titulo = string.IsNullOrWhiteSpace(partes[0]) ?  "Titulo não encontrado" : partes[0], 
                Artista = string.IsNullOrEmpty(partes[1]) ? "Artista não encontrado" : partes[1],
                Duracao = int.TryParse(partes[2], out int duracao) ? duracao : 0,
                Generos = partes[3].Split(',', StringSplitOptions.TrimEntries),//remove os espaços em branco indesejados
                Lancamento = DateTime.TryParse(partes[4], out DateTime data) ? data : DateTime.Now
            };   
            yield return musica;
        }
        linha = leitor.ReadLine();
    }
}


//Classes
class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public string[] Generos { get; set; }
    public DateTime Lancamento { get; set; }
}