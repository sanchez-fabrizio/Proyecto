/*- Realiza un programa que sólo permita introducir los caracteres ‘S’ y ‘N’. Si el usuario ingresa alguno de
esos dos caracteres se deberá de imprimir un mensaje por pantalla que diga “CORRECTO”, en caso
contrario, se deberá imprimir “INCORRECTO”.*/
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
            string caracter;
            Console.WriteLine("ingrese el caracter s o n ");
            caracter= Convert.ToString(Console.ReadLine());

            if (caracter == "s" || caracter == "n" || caracter == "S" || caracter == "N")
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