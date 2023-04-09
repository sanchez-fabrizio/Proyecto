/*Calcular las calificaciones de un grupo de alumnos. La nota final de cada alumno se
calcula según el siguiente criterio: se promediarán las notas obtenidas en la parte
práctica; la parte de problemas y la parte teórica. El programa leerá el nombre del
alumno, las tres notas obtenidas, mostrará el resultado por pantalla, y a continuación
volverá a pedir los datos del siguiente alumno hasta que el nombre sea una cadena
vacía. Las notas deben estar comprendidas entre 0 y 10, y si no están dentro de ese
rango no se imprimirá el promedio y se mostrará un mensaje de error.*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajon7
{
    class Program
    {
        static void Main(string[] args)
        {
            int practicas;
            int teorica;
            int problemas;
            string alumno;
            int notafinal;
           
            do
            {
              
                Console.WriteLine("ingrese el nombre del alumno");
                alumno = Convert.ToString(Console.ReadLine());
                Console.WriteLine("ingrese la nota de las practicas");
                practicas = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese las notas teorica");
                teorica = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("ingrese la nota de los problemas");
                problemas= Convert.ToInt32(Console.ReadLine());
                notafinal = (practicas + teorica + problemas) / 3;


                Console.WriteLine("la nota del alumno ({0}) es ({1})   ", alumno, notafinal);


            } while(alumno != "" && notafinal <= 10);
            
            Console.WriteLine("error");
            Console.ReadKey();
        }
    }
}
