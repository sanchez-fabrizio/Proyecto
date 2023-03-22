/* Una tienda ofrece un descuento del 15% sobre el total de la compra y un cliente desea saber cuánto
deberá pagar finalmente por su compra.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double descuento;
            double precio;
            double precio2;
            Console.WriteLine("ingrese el precio del producto");
            precio = Convert.ToDouble(Console.ReadLine());
            descuento = precio * 0.15;
            precio2 = precio -descuento;
            Console.WriteLine("lo que debe pagar el cliente es == " + precio2);
            Console.ReadKey();
            




        }
    }
}
