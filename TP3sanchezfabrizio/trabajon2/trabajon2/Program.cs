/*- Construir un programa que permita ingresar un número, si el número es mayor a 500, se debe calcular y
mostrar en pantalla el 18% de este.*/
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
            int numero;
            Console.WriteLine("ingrese un numero");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero >= 500)
            {
                Console.WriteLine("su numero es mayor a 500 se sumara 18%");
                Console.WriteLine("su numero es ===" + numero * 0.18);
            }
            else
            {

                Console.WriteLine("su numero no es mayor a 500 ");
            }





            }


         



            
        }


        
    }
    


