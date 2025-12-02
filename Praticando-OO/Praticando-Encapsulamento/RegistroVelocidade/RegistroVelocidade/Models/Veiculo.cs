namespace RegistroVelocidade.Models;

public class Veiculo
{
    
    public string Placa { get; set; }
    private int _velocidade;
    


    public Veiculo(string placa)
    {
        this.Placa = placa;
    }
    
    
    public void AtualizarVelocidade(int valor)
    {
        if (valor > 0) this._velocidade = valor;
    }

    public int VelocidadeAtual
    {
        get{return this._velocidade;}
    }
}