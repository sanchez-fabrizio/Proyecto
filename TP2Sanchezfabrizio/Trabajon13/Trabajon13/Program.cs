/* Dado un número de dos cifras, diseñe un programa que permita obtener el número invertido. Ejemplo,
si se introduce 23 que muestre 32. */
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
            int num, aux, aux2,aux3;

            Console.WriteLine("ingrese un numero de dos cifras");
            num = Convert.ToInt32(Console.ReadLine());
            aux = num / 10;
            aux2 = num % 10;
            aux3 = (aux2 * 10) + aux;
            Console.WriteLine("el numero invertido es = "+aux3);
            

        }
    }
}