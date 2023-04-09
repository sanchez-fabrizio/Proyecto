/*Escribir un programa que calcule cuántos dígitos tiene un número entero positivo.
(pista: se puede hacer dividiendo varias veces entre 10).*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajon8
{
    class Program
    {
        static void Main(string[] args)
        {
            int numeros;
            int aux;
            int contador = 0;

            
            
            do
            {

                Console.WriteLine("escribir un numero");
                numeros = Convert.ToInt32(Console.ReadLine());
               
                aux =  numeros /10;
                contador++;
                
                
            } while (numeros > 0);
            Console.WriteLine("digitos que tiene son ({0})", contador);
            
            Console.ReadKey();

        }
    }
}
