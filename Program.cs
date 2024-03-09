using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Buenas tardes, bienvenido a nuestro programa");

            int precioProducto1 = IngresarPrecioProducto(1);
            int precioProducto2 = IngresarPrecioProducto(2);
            int precioProducto3 = IngresarPrecioProducto(3);

            int total = precioProducto1 + precioProducto2 + precioProducto3;

            total = total > 500 ? (int)(total * 0.9) : total;

            Console.WriteLine($"El total a pagar es: {total} centimos");

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();

        }

        static int IngresarPrecioProducto(int numeroProducto)
        {
            Console.WriteLine($"Ingrese el precio del producto {numeroProducto} en centimos: ");
            return Convert.ToInt32( Console.ReadLine() );

        }

    }
}
