/*-Escriba un programa que pida 3 notas y valide si esas notas están entre 1 y 10. Si están entre esos
parámetros se debe poner en verdadero una variable de tipo lógico y si no ponerla en falso. Al final el
programa debe decir si las 3 notas son correctas usando la variable de tipo lógico.*/
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
            int nota, nota2, nota3;

            Console.WriteLine("ingrese la primera nota");
            nota = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la segunda nota");
            nota2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese la tercera nota");
            nota3 = Convert.ToInt32(Console.ReadLine());

           


            if ( nota <= 10 && nota2 <= 10 && nota3 <= 10 )
            {

                Console.WriteLine("la variable es tipo logico");

            }
            else
            {

                Console.WriteLine("la variable no es tipo logico");

            }

            Console.ReadKey();

        }




    }
}