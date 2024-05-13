using System;
using System.Collections.Generic;
using System.Linq;

namespace LINQ
{
    class Program
    {
        static void Main(String[] args)
        {
            List<People> people = new List<People>()
            {
                new People()
                {
                    Name = "Irene",
                    Country = "España"
                },
                new People()
                {
                    Name = "Mane",
                    Country = "Argentina"
                },
                new People()
                {
                    Name = "Louis",
                    Country = "Inglaterra"
                }
            };

            foreach (var person in people)
                Console.WriteLine(person);

            Console.WriteLine("--------------------");

            // select
            var peopleName = from p in people
                             select new
                             {
                                 Name = p.Name,
                                 Letters = p.Name.Length,
                                 Fixed = 1
                             };
            foreach (var person in peopleName)
                Console.WriteLine($"{person.Name} {person.Letters} {person.Fixed}");

            Console.WriteLine("--------------------");

            var peopleNameReal = from p in peopleName
                                 select new
                                 {
                                     Name = p.Name
                                 };
            foreach(var person in peopleNameReal)
                Console.WriteLine(person.Name);

            Console.WriteLine("--------------------");

            // filtrar
            var peopleSpain = from p in people
                              where p.Country == "España"
                              || p.Country == "Inglaterra"
                              select p;

            foreach(var person in peopleSpain)
                Console.WriteLine(person);

            Console.WriteLine("--------------------");

            // ordenar
            // descending lo ordena de forma descendente en este caso Z-A

            var orderedPeople = from p in people
                                orderby p.Country descending
                                select p;

            foreach(var person in orderedPeople)
                Console.WriteLine(person);

        }
    }

    public class People
    {
        public string Name { get; set; }
        public string Country { get; set; }

        public override string ToString()
        {
            return $"Nombre: {Name} País: {Country}";
        }

    }
}