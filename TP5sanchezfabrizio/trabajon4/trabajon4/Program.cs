/*Escriba un programa en el cual se ingrese un número y mientras ese número sea mayor
de 10, se pedirá el número de nuevo. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajon4
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("ingrese un numero");
            num = Convert.ToInt32(Console.ReadLine());

            while(num > 10)
            {
                Console.WriteLine("ingrese otro numero");
                num = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("su numero es " + num);
            Console.ReadKey();
        }
    }
}
