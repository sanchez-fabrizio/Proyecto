//- Escribir un programa que convierta un valor dado en grados Fahrenheit a grados Celsius.
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
            double celsius;
            double fahreheit;
            double aux;
            Console.WriteLine("ingrese el fahrenheit °");
            fahreheit = Convert.ToDouble(Console.ReadLine());
            aux = (fahreheit - 32) / 1.8;
            Console.WriteLine("celsius que dio de fahrenheit son ===="+aux+ "°");
            Console.ReadKey();
        }
    }
}
