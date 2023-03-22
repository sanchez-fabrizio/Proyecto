/*Mostrar el área y perímetro de un hexágono.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp2sanchezfabrizioyulicesacosta
{
    class Program
    {
        static void Main(string[] args)
        {
            double apotema;
            double perimetro;
            double aux;
            double aux2;
            Console.WriteLine("ingese el perimetro");
            perimetro = Convert.ToDouble(Console.ReadLine()); //utiliza el perimetro
            aux = perimetro * 6; //calcula el perimetro
            Console.WriteLine("ingresar el apotema");
            apotema = Convert.ToDouble(Console.ReadLine());//apotema utilizado 
            aux2 = aux * apotema / 2; //calcula el area
            Console.WriteLine("el perimetro es ====" + aux);
            Console.WriteLine("el area es ===" + aux2);
            Console.ReadKey();
        }
    }
}
