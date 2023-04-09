/*Realizar un programa que pida introducir solo frases o palabras de 6 caracteres. Si el usuario ingresa una
frase o palabra de 6 caracteres se deberá de imprimir un mensaje por pantalla que diga “CORRECTO”, en
caso contrario, se deberá imprimir “INCORRECTO”.*/
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
            
            Console.WriteLine("ingrese una frases o palabra con 6 caracter");
            frases = Convert.ToString (Console.ReadLine());
            // length cuenta de cuanto numero hay en una frases
            AUX = frases.Length;
            

            if (AUX <=6 )
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