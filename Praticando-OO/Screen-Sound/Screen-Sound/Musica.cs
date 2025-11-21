namespace Screen_Sound;

public class Musica
{

       //Atributos da classe e modificadores de acesso
       public string Nome { get;}
       public Banda Artista { get; }
       public int Duracao { get; set; }
       public bool Disponivel { get; set; }//Properties
       public string Descricao => $"Musica: {Nome}, Pertence ao: {Artista}"; //GET com lambda(funções anonimas)
       
       public Musica(string nome, Banda artista)//Construtor da classe
       {
              this.Artista = artista;
              this.Nome = nome;
       }

       public void ExibeFicha()
       {
              Console.WriteLine($"Nome: {this.Nome} \nArtista: {this.Artista.Nome} \nDuração: {this.Duracao}");

              if (Disponivel)
              {
                     Console.WriteLine("Disponivel: Sim");
              }
              else
              {
                     Console.WriteLine("Disponivel: Não");
              }
       }
}

