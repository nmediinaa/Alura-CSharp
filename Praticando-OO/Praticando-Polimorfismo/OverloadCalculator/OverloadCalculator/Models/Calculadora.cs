namespace OverloadCalculator.Models;

//Polimorfismo do tipo overload(sobrecarga), temos mais de um método com o mesmo nome com comportamentos diferentes
public class Calculadora
{
    public int Somar(int n1, int n2)
    {
        return n1 + n2;
    }

    public int Somar(int n1, int n2, int n3)
    {
        return n1 + n2 + n3;
    }

    public double Somar(double n1, double n2)
    {
        return n1 + n2;
    }
}