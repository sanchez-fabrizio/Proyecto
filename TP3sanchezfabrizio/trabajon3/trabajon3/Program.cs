/*Se pide ingresar una letra del alfabeto y mostrar si dicha letra es vocal o consonante.*/

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
            char letras;
            Console.WriteLine("ingrese una letra del alfabeto");
            letras = Convert.ToChar(Console.ReadLine());
            //'' esto es para asignar la letrao numero en especifico
            // and && seria y or || seria si la condicion es verdadera las dos muestra 
            if (letras == 'a' || letras == 'e' || letras == 'i' || letras == 'o' || letras == 'u')
            {

                Console.WriteLine("la letra es vocal   = " + letras);
            }
            else 
            { 

                Console.WriteLine("la letra es consonante  = "+ letras);

                Console.ReadKey();


            }

            
           



            
        }
    }
}
