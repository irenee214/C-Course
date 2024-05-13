
using System.Data.SqlClient;

namespace BaseDeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                BeerDB db = new BeerDB(@"(localdb)\Local", "CsharpDB");
                bool again = true;
                int op = 0;

                do
                {
                    ShowMenu();
                    Console.WriteLine("Elige una opción: ");
                    op = int.Parse(Console.ReadLine());

                    switch (op)
                    {
                        case 1:
                            Show(db);
                            break;
                        case 2:
                            Add(db);
                            break;
                        case 3:
                            Edit(db);
                            break;
                        case 4:
                            Delete(db);
                            break;
                        case 5:
                            again = false;
                            break;
                    }
                } while (again);

            }
            catch (SqlException ex)
            {
                Console.WriteLine("No se pudo realizar la conexion");
            }
        }

        public static void ShowMenu()
        {
            Console.WriteLine("\n---------- MENÚ ----------");
            Console.WriteLine("1.- Mostrar");
            Console.WriteLine("2.- Insertar");
            Console.WriteLine("3.- Editar");
            Console.WriteLine("4.- Eliminar");
            Console.WriteLine("5.- Salir");
        }

        public static void Show(BeerDB db)
        {
            Console.Clear();
            Console.WriteLine("Cervezas de la base de datos");
            List<Beer> beers = db.GetAll();

            foreach (var beer in beers)
            {
                Console.WriteLine($"Id: {beer.Id}, Nombre: {beer.Name}");
            }
        }

        public static void Add(BeerDB db)
        {
            Console.Clear();
            Console.WriteLine("Agregar nueva cerveza");
            Console.WriteLine("Escribe el nombre de la cerveza: ");
            string name = Console.ReadLine();
            Console.WriteLine("Escribe el id de la marca: ");
            int brandId = int.Parse(Console.ReadLine());
            Beer beer = new Beer(name, brandId);
        }

        public static void Edit (BeerDB db)
        {
            Console.Clear();
            Show(db);
            Console.WriteLine("Editar Cerveza");
            Console.WriteLine("Escribe el id de tu cerveza a editar: ");
            int id = int.Parse(Console.ReadLine());

            Beer beer = db.Get(id);

            if(beer != null)
            {
                Console.WriteLine("Escribe el nuevo nombre: ");
                string name = Console.ReadLine();
                Console.WriteLine("Escribe el nuevo id de la marca: ");
                int brandId = int.Parse(Console.ReadLine());

                beer.Name = name;
                beer.BrandId = brandId;
                db.Edit(beer);
            } 
            else
            {
                Console.WriteLine("La cerveza no existe");
            }
        }

        public static void Delete(BeerDB db)
        {
            Console.Clear();
            Show(db);
            Console.WriteLine("Eliminar Cerveza");
            Console.WriteLine("Escribe el id de tu cerveza a eliminar: ");
            int id = int.Parse(Console.ReadLine());

            Beer beer = db.Get(id);
            if (beer != null)
                db.Delete(id);
            else
                Console.WriteLine("La cerveza no existe");
        }
    }
}