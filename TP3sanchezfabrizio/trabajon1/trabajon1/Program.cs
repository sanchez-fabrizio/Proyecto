/*- Un hombre desea saber si su sueldo es mayor al sueldo mínimo, el programa le pedirá al usuario su
sueldo actual y el sueldo mínimo. Si el sueldo es mayor al mínimo se debe mostrar un mensaje por pantalla
indicándolo.*/

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
            int sueldomayor, sueldominimo;


            Console.WriteLine("ingrese su sueldo mayor ");
            sueldomayor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese su sueldo minimo");
            sueldominimo = Convert.ToInt32(Console.ReadLine());
            if (sueldomayor > sueldominimo) {
                Console.WriteLine("su sueldo es mayor al minimo    "+ "  su sueldo mayor =====   " + sueldomayor + " y su minimo es ==" + sueldominimo);
            }
            else
            {
                Console.WriteLine("su sueldo no es mayor al minimo    "+"  su sueldo minimo ====  " + sueldominimo+" y su mayor es === " + sueldomayor);



            }

        }
    }
}
