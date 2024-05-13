using System;
using System.IO;

namespace Excepciones
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                string content = File.ReadAllText(@"C:\Users\practicas.soporte\Documents\ejemplo.txt");
                Console.WriteLine(content);

                string content2 = File.ReadAllText(@"C:\Users\practicas.soporte\Documents\ejemplo2.txt");
                Console.WriteLine(content2);

                throw new Exception("Ocurrió algo raro");
            } 
            catch(FileNotFoundException ex)
            {
                Console.WriteLine("El archivo no existe");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Aquí me he ejecutado pase lo que pase");
            }

            Console.WriteLine("Aquí se sigue ejecutando");
        }
    }
}