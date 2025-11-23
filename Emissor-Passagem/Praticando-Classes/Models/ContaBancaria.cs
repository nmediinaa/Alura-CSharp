namespace Praticando_Classes.Models;

public class ContaBancaria
{
    public string NumeroConta { get; }
    public double Saldo { get; set; }


    public ContaBancaria(string numeroConta, double saldo)
    {
        this.NumeroConta = numeroConta;
        this.Saldo = saldo;
    }

    public void Depositar(double valor)
    {
        this.Saldo += valor;
        Console.WriteLine($"Saldo atual: {this.Saldo}");
    }
}