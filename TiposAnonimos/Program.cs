using System;

namespace TiposAnonimos
{
    class Program
    {
        static void Main(string[] args)
        {
            var irene = new 
            {
                Name = "Irene",
                Country = "España"
            };

            Console.WriteLine($"{irene.Name} {irene.Country}");

            var beers = new[]
            {
                new { Name = "Red", Brand = "Delirium"},
                new { Name = "London Porter", Brand = "Fullers"}
            };

            foreach (var beer in beers)
            {
                Console.WriteLine($"Cerveza {beer.Name} {beer.Brand}");
            }
        }
    }
}