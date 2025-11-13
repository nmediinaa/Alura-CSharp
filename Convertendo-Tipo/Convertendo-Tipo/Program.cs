Console.Write("Digite o peso total: ");
decimal peso = Convert.ToDecimal(Console.ReadLine());

int pesoArrendondado = (int)peso;

Console.WriteLine("Veiculos necessarios: " + pesoArrendondado);