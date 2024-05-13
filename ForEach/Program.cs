using System;
using System.Collections.Generic;

namespace ForEach
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new List<int>()
            {
                1, 4, 7, 10, 28, 33
            };

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            var students = new List<People>()
            {
                new People(){ Name = "Irene", Country = "España"},
                new People(){ Name = "Mane", Country = "Argentina"},
                new People(){ Name = "Louis", Country = "Inglaterra"}
            };

            Show(students);

            students.RemoveAt(2);

            Show(students);
        }

        static void Show(List<People> students)
        {
            Console.WriteLine("-- Personas --");
            foreach(var student in students)
            {
                Console.WriteLine($"Nombre: {student.Name}, País: {student.Country}");
            }
        }
    }

    class People
    {
        public string Name { get; set; }
        public string Country { get; set; }
    }
}