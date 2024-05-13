using System;
using System.Linq;
using System.Collections.Generic;

namespace LINQ_Join
{
    class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>()
            {
                new Person()
                {
                    Name = "Irene", Country = "España"
                },
                new Person()
                {
                    Name = "Mane", Country = "Argentina"
                },
                new Person()
                {
                    Name = "Louis", Country = "Inglaterra"
                }
            };

            var countries = new List<Country>()
            {
                new Country()
                {
                    Name = "España", Continent = "Europa"
                },
                new Country()
                {
                    Name = "Argentina", Continent = "América"
                },
                new Country()
                {
                    Name = "Inglaterra", Continent = "Europa"
                }
            };

            var peopleWithContinent = from person in people
                                      join country in countries
                                      on person.Country equals country.Name
                                      select new
                                      {
                                          Name = person.Name,
                                          Country = person.Country,
                                          Continent = country.Continent
                                      };

            foreach(var person in peopleWithContinent)
            {
                Console.WriteLine($"{person.Name} {person.Country} {person.Continent}");
            }
        }

        public class Person
        {
            public string Name { get; set; }
            public string Country { get; set; }
        }

        public class Country
        {
            public string Name { get; set; }
            public string Continent { get; set; }
        }
    }
}