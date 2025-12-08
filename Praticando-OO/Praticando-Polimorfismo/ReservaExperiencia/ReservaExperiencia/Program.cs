using ReservaExperiencia.Models;

List<Reserva> reservas = new List<Reserva>
{
    new ReservaPresencial("Trilha em Trindade"),
    new ReservaOnline("Workshop em C#"),
};

foreach (var reserva in reservas)
{
    reserva.Confirmar();
}