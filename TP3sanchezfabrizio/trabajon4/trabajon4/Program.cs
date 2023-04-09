// Diseñe un programa que lea un número de tres cifras y determine si es o no capicúa.

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
            int numero,aux;
            Console.WriteLine("escriba un numero de tres cifra");
            numero  = Convert.ToInt16(Console.ReadLine());
            aux = (numero - numero % 100) / 100;
            if (numero <= 1000 && aux ==numero %10 )
            {
                Console.WriteLine("es capicua " );

            }
            else if(numero<=1000 && aux !=numero %10)
            {
                Console.WriteLine("no es capicua"  );
            }
            else  
            {
                Console.WriteLine("el numero es cuatro digitos " );
            }

            Console.ReadKey();
            
            }

            }





        }
    


