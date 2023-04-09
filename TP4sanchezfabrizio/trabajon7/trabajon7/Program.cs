/*Continuando el ejercicio anterior, ahora se pedirá una frase o palabra y se validará si la primera letra de
la frase es igual a la última letra de la frase. Se deberá de imprimir un mensaje por pantalla que diga
“CORRECTO”, en caso contrario, se deberá imprimir “INCORRECTO”.*/
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
            string palabras;
            string palabras2;
            int distancia;
            string aux;
            Console.WriteLine("ingresar una frase o palabra");
            palabras = Convert.ToString(Console.ReadLine());
            palabras2 = palabras.Substring(0,1);
            distancia = palabras.Length-1; //retrocede la ultima palabra esto
            aux = palabras.Substring(distancia);
            if (palabras2 == aux)
            {
                Console.WriteLine("correcto");
            }
            else
            {
                Console.WriteLine("incorrecto");
            }



            Console.ReadKey();

        }




    }
}