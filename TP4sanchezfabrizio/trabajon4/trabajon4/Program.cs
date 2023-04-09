/*- Realizar un programa que pida una frase o palabra y si la frase o palabra es de 4 caracteres de largo, el
programa le concatenara un signo de exclamación al final, y si no es de 4 caracteres el programa le
concatenara un signo de interrogación al final. El programa mostrará después la frase final.*/
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
            int AUX;
            string frases;

            Console.WriteLine("ingrese una frases o palabra");
            frases = Convert.ToString(Console.ReadLine());
            AUX = frases.Length;


            if (AUX <= 4 )
            {

                Console.WriteLine(frases + "?");

            }
            else
            {

                Console.WriteLine(frases + "!");

            }

            Console.ReadKey();

        }




    }
}