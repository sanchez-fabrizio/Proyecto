//-Mostrar el área y perímetro de un paralelogramo.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2sanchezfabrizioyulicesacosta_v._2
{
    class Program
    {
        static void Main(string[] args)
        {
            double area;
            double perimetro;
            double altura;
            double BASE;
            Console.WriteLine("ingrese la altura");
            altura = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la base");
            BASE = Convert.ToInt32(Console.ReadLine());
            area = BASE * altura;
            perimetro = 2 * (BASE + area);
            Console.WriteLine("el perimetro es ==== " + perimetro);
            Console.WriteLine("la area es ====" + area);
            Console.ReadKey();
        }
    }
}
