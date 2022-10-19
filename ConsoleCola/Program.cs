using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCola
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int dato, opcion;
            Cola cola=new Cola(4);
            do
            {
                Console.WriteLine("\t==================== [ MENU COLA ] =============================");
                Console.WriteLine("\t\t1.- INSERTAR ELEMENTO ");
                Console.WriteLine("\t\t2.- ELIMINAR ELEMENTO ");
                Console.WriteLine("\t\t3.- LISTAR");
                Console.WriteLine("\t\t4.- SALIR");
                Console.Write("\tELIJA UNA OPCION: ");
                opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        Console.Write("\tDigite un valor: ");
                        dato = int.Parse(Console.ReadLine());
                        cola.insertarItem(dato);
                        break;
                    case 2:
                        cola.eliminarItem();
                        break;
                    case 3:
                        cola.ListarItems();
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("\tOpcion no valida");
                        break;
                }
                Console.ReadKey();
                Console.Clear();
            } while (opcion != 4);


            Console.ReadKey(true);

        }
    }
}
