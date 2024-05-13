using System;
using System.Collections.Generic;

namespace ListCommonMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() 
            { 
                4, 3, 5, 19
            };

            Show(numbers);

            // Insert
            numbers.Insert(0, 6);

            Show(numbers);

            // Contains
            if (numbers.Contains(33))
                Console.WriteLine("Existe");
            else
                Console.WriteLine("No existe");

            // IndexOf
            int pos = numbers.IndexOf(19);
            Console.WriteLine(pos);
            pos = numbers.IndexOf(28);
            Console.WriteLine(pos);

            // Sort
            numbers.Sort();
            Show(numbers);

            // AddRange
            var numbers2 = new List<int>()
            {
                300, 200, 400
            };
            numbers.AddRange(numbers2);
            Show(numbers);

            // Hay que volver a almacenarlo porque los string son inmutables
            /*string name = "Irene";
            name = name.ToUpper();
            Console.WriteLine(name);*/
        }

        public static void Show(List<int> numbers)
        {
            Console.WriteLine("-- Numeros --"); 
            foreach(var number in numbers)
            {
                Console.WriteLine(number);
            }
        }
    }
}