/*Hacer un programa que ingrese por teclado un número total de segundos y que luego pueda mostrar la
cantidad de horas, minutos y segundos que existen en el valor ingresado.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos;
            int minutos;
            int horas;
            Console.WriteLine("ingresar los segundos");
            segundos = Convert.ToInt32(Console.ReadLine());
            minutos = segundos / 60;
            horas = minutos / 60;
            Console.WriteLine("los segundos son =" + segundos);
            Console.WriteLine("los segundos son =" + minutos);
            Console.WriteLine("los segundos son =" + horas);
            Console.ReadKey();





        }
    }
}

