/*Dada una secuencia de números ingresados por teclado que finaliza con la entrada de
un número negativo, por ejemplo: 5,3,0,2,4,4,0,0,2,3,6,0,......,-1; realizar un
programa que calcule el promedio de los números ingresados. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajon3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numnegativos = 0;
            int suma = 0;
            int contador = 0;
            

            do
            {
                Console.WriteLine("ingrese cualquier 1numero");
                numnegativos = Convert.ToInt32(Console.ReadLine());
                suma = suma + numnegativos;
                contador = contador++;
            }
            while ((numnegativos > 0));
            Console.WriteLine("el promedio del numero es" + suma);
            Console.ReadKey();
        }
    }
}
