Console.Write("Digite o código do produto (1 ou 2): \n");
int codigoProduto = int.Parse(Console.ReadLine());

if (codigoProduto != 1 && codigoProduto != 2)
{
    Console.WriteLine("Código invalido");
}
else if(codigoProduto == 1)
{
    Console.WriteLine("Produto Pericivel!");
}else  if(codigoProduto == 2)
{
    Console.WriteLine("Produto Não-Pericivel!");
}