/*Escriba un programa en el cual se ingrese un valor límite positivo, y a continuación
solicite números al usuario hasta que la suma de los números introducidos supere el
límite inicial.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajon2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numerospositivo = 0;
            int totalpositivo = 0;
            int aux = 0;
            int aux2 = 0;
            int aux3 = 0;
            Console.WriteLine("ingrese un limite positivo");
            numerospositivo = Convert.ToInt32(Console.ReadLine());
            

            while(aux<numerospositivo)
            {
                Console.WriteLine("ingrese un numero positivo");
                totalpositivo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese otro numero positivo");
                aux2 = Convert.ToInt32(Console.ReadLine());
                aux = totalpositivo + aux2;
                
                

                
            }

            Console.WriteLine("su numero alcanzo al numero limite "+aux );
            Console.WriteLine("SU NUMERO LIMITE ERA " + numerospositivo);


            Console.ReadKey();
        }
    }
}
