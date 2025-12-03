namespace ValidaçãoSaque.Models;

public class ContaBancaria
{
    public string Titular { get; set; }
    private double _saldo;

    public double Saldo
    {
        get { return _saldo; }
    }

    public ContaBancaria(string titular, double saldo)
    {
        this.Titular = titular;
        this._saldo = saldo;
    }

    public void Sacar(double value)
    {
        if (SegurancaConta.ValidarSaque(value) && Saldo > 0)
        {
            _saldo -= value;
            Console.WriteLine($"Saque realizado com sucesso!\n Saldo Atual: {this.Saldo}");
        }else Console.WriteLine("Saque negado pela política de segurança.");
    }
}