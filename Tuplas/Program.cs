using System;

namespace Tuplas
{
    class Program
    {
        static void Main(string[] args)
        {
            (int id, string name) product = (1, "cerveza stout");

            Console.WriteLine($"{product.id} {product.name}");

            product.name = "cerveza porter";

            Console.WriteLine($"{product.id} {product.name}");

            var person = (1, "Irene");
            Console.WriteLine($"Persona {person.Item1} {person.Item2}");

            var people = new[]
            {
                (1, "Irene"),
                (2, "Mane"),
                (3, "Louis")
            };
            foreach(var p in people)
            {
                Console.WriteLine($"{p.Item1} {p.Item2}");
            }

            (int id, string name)[] people2 = new[]
            {
                (1, "Irene"),
                (2, "Mane"),
                (3, "Louis")
            };
            foreach (var p in people2)
            {
                Console.WriteLine($"{p.id} {p.name}");
            }

            var cityInfo = getLocationCDMX();
            Console.WriteLine($"lat: {cityInfo.lat} long: {cityInfo.lng} nombre: {cityInfo.name}");

            var (_, lng, _) = getLocationCDMX();
            Console.WriteLine(lng);
        }

        public static (float lat, float lng, string name) getLocationCDMX()
        {
            float lat = 19.12121f;
            float lng = -99.19212f;
            string name = "CDMX";

            return (lat, lng, name);
        }
    }
}