using SimuladorTransporte.Models;

int distancia = 10;


List<Transporte> transportes = new ()
{
    new Onibus(),
    new Metro(),
    new Bicicleta()
};

foreach (var item in transportes)
{
    Console.WriteLine($"{item.GetType().Name}: {item.CalcularTempo(distancia)} min");
}