/*Escriba un programa que solicite al usuario números decimales mientras que el usuario
escriba números mayores al primero que se ingresó. Por ejemplo: si el usuario ingresa
como primer número un 3.1, y luego ingresa un 4, el programa debe solicitar un tercer
número. El programa continuará solicitando valores sucesivamente mientras los valores
ingresados sean mayores que 3.1, caso contrario, el programa finaliza. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajon6
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal numerodecimales;
            decimal numero;
            decimal aux;
            int contador = 0;
            Console.WriteLine("ingrese un numero decimal");
            numerodecimales = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("ingrese un numero entero mayor que decimal");
            numero = Convert.ToDecimal(Console.ReadLine());
            do
            {
                contador++;
                Console.WriteLine("ingrese un numero que esta entre ({0}) ({1})", numerodecimales, numero);
                aux = Convert.ToDecimal(Console.ReadLine());

                

            } while (aux >numerodecimales && aux < numero);
            Console.Write("el numero que finalizo el programa ({0}) y el numero minimo ({1}) y el numero maximo ({2})", aux,numerodecimales,numero);
            
            Console.ReadKey();
        }
    }
}
