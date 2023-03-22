//Escribir un programa que pregunte al usuario su nombre, y luego lo salude.
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
            string nombre;
            Console.WriteLine("ponga su nombre");
            nombre = Console.ReadLine();
            Console.Write("   hola   " + nombre);
            Console.ReadKey();
        }
    }
}
