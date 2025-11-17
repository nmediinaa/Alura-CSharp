double resultado;

Console.WriteLine("Digite o primeiro operando: ");
double operandoUm = double.Parse(Console.ReadLine());

Console.WriteLine("Digite o segundo operando: ");
double operandoDois = double.Parse(Console.ReadLine());

Console.WriteLine("Digite uma operação (+. -, *, / ou %): ");
char operacao = char.Parse(Console.ReadLine());

switch (operacao)
{
    case  '+':
        resultado = operandoUm + operandoDois;
        Console.WriteLine(resultado);
        break;
    case '-':
        resultado = operandoUm - operandoDois;
        Console.WriteLine(resultado);
        break;
    case '*':
        resultado = operandoUm * operandoDois;
        Console.WriteLine(resultado);
        break;  
    case '/':
        resultado  = operandoDois / operandoUm;
        Console.WriteLine(resultado);
        break;      
    case '%':
        resultado = operandoDois % operandoUm;
        Console.WriteLine(resultado);
        break;
    default:
        Console.WriteLine("Operador invalido!");
        break;
}