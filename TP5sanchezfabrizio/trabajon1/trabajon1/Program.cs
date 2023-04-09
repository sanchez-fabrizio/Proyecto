/*Escriba un programa que valide si una nota está entre 0 y 10, sino está entre 0 y 10 la nota se pedirá de
nuevo hasta que la nota sea correcta.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajon1
{
    class Program
    {
        static void Main(string[] args)
        {
            int notas;
            Console.WriteLine("escribir una nota entre 1 y 10");
            notas = Convert.ToInt32(Console.ReadLine());
            while (notas > 10)
            {

                Console.WriteLine("ingrese nuevamente la nota");
                notas = Convert.ToInt32(Console.ReadLine());
            }
            Console.Write("su nota es " + notas);
            Console.ReadKey();
        }
    }
}
