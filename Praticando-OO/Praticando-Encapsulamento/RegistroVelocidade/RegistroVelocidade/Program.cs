using RegistroVelocidade.Models;

Veiculo carro = new Veiculo("ABC-0909");
carro.AtualizarVelocidade(70);

Console.WriteLine("Veículo: " + carro.Placa);
Console.WriteLine("Velocidade atual: " + carro.VelocidadeAtual + " km/h");