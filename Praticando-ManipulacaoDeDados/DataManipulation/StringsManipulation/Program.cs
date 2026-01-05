using var stream = new FileStream("musicas.csv", FileMode.Open);
using var reader = new StreamReader(stream);

var senha = "Nicolas@26";

int totalCaracteres = senha.Length;// ou poderiamos usar o .Count()
int possuiLetrasMaiusculas = senha.Count(c => char.IsUpper(c));
int possuiLetrasMinusculas = senha.Count(c => char.IsLower(c));
int possuiNumero = senha.Count(c => char.IsDigit(c));
int possuiSimbolo = senha.Count(c => !char.IsLetterOrDigit(c));

if (totalCaracteres < 8 || possuiLetrasMaiusculas == 0 ||
    possuiLetrasMinusculas == 0 || possuiNumero == 0 ||
    possuiSimbolo == 0)
{
    Console.WriteLine("SENHA FRACA");
}else Console.WriteLine("Senha FORTE!");
//Métodos
IEnumerable<Musica> MusicasDoCsv(StreamReader leitor)
{
    var linha = leitor.ReadLine();

    while (linha != null)
    {
        var partes = linha.Split(';');
        if (partes.Length != 4) continue;
        var musica = new Musica
        {
            Titulo = partes[0],
            Artista = partes[1],
            Duracao = Convert.ToInt32(partes[2]),
            Generos = partes[3].Split(',').Select(g => g.Trim()).ToArray()
        };
        yield return musica;
        linha = leitor.ReadLine();
    }
}


//Classes
class Musica
{
    public string Titulo { get; set; }
    public string Artista { get; set; }
    public int Duracao { get; set; }
    public string[] Generos { get; set; } = [];
}