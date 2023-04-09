/*Realizar un programa que pida un número y determine si ese número es par o impar. Mostrar en pantalla
un mensaje que indique si el número es par o impar. (para que un número sea par, se debe dividir entre dos
y su resto debe ser igual a 0).*/
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
            int numero;
               
            Console.WriteLine("ingrese un numero ");
            numero = Convert.ToInt16(Console.ReadLine());
            
            if (numero % 2 == 0)
            {

                Console.WriteLine("es par == " + numero);

            }
            else
            {

                Console.WriteLine("no es par == " + numero);

            }

            Console.ReadKey();

        }




    }
}