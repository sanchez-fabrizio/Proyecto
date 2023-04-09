//Crea una aplicación que nos pida un día de la semana y que nos diga si es un día laboral o no.
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
            string semanas;
            Console.WriteLine("ingrese un dia de la semana ");
            semanas = Convert.ToString(Console.ReadLine());

            if (semanas == "lunes" || semanas == "martes" || semanas == "miercoles" || semanas == "jueves" || semanas == "viernes")
            {

                Console.WriteLine("es dia laboral   ");

            }
            else
            {

                Console.WriteLine("no es dia laboral  ");

            }

            Console.ReadKey();

        }




    }
}