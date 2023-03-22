//Mostrar el área y perímetro de un rombo.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2sancnezfabrizioyacostaulices
{
    class Program
    {
        static void Main(string[] args)
        {
            double perimetro;
            double area;
            double longitud;

            double aux;
            double Longitud2;
            Console.WriteLine("ingrese la longitud del rombo");//D
            longitud = Convert.ToDouble(Console.ReadLine());//lo lee perimetro
            Console.WriteLine("ingrese la altura del rombo");//d
            area = Convert.ToDouble(Console.ReadLine());//lo lee el area
            Longitud2 = longitud * 4;
            Console.WriteLine("su perimetro es ==== " + Longitud2);
            aux = Longitud2 * area / 2;
            Console.WriteLine("su area es =====" + aux);
            Console.ReadKey();

        }
    }
}
