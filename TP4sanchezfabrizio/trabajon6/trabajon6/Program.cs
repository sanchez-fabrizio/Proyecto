/*Escriba un programa que pida una frase o palabra y valide si la primera letra de esa frase es una ‘A’. Si la
primera letra es una ‘A’, se deberá de imprimir un mensaje por pantalla que diga “CORRECTO”, en caso
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
            string palabras;
            string aux;
            string aux2;
            
            Console.WriteLine("ingrese una frase");
            palabras = Convert.ToString(Console.ReadLine());
            aux =palabras.Substring(0,1);
            
            /*sub string es como que cuenta las palabras , si ponemos 0 va iniciar en la primera frase seria la c 
             * pero si ponemos 0.1 ese uno va a contar las palabras que va a tener esa frase ejm = va hacer casa = iniciara solo en ca*/
            if (aux == "a" || aux == "A")
            {
                Console.WriteLine("correcto");
            }
            else { 
                Console.WriteLine("incorrecto");



                Console.ReadKey();

            }

        }




    }
}