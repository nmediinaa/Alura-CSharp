using SistemaDeReservas.Models;

Hospede hospede = new Hospede("Nicolas Medina");
Quarto quarto = new Quarto(100, 1200);
Reserva reserva1 = new Reserva(hospede, quarto, 10);

Console.WriteLine($"Reserva para: {hospede.Nome}");
Console.WriteLine($"Quarto: {quarto.NumeroQuarto}");
Console.WriteLine($"Valor total: {reserva1.ValorTotal}");