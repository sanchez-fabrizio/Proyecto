/*Un ciclista parte de una ciudad A a las HH horas, MM minutos y SS segundos. El tiempo de viaje hasta
llegar a otra ciudad B es de T segundos. Escribir un algoritmo que determine la hora de llegada a la ciudad B.*/
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
            int horas, minutos, segundos, aux,aux2,min2,seg2,h2,tiempo;
            Console.WriteLine("ingrese la hora que partio en la ciudad A");
            horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese los minutos que partio en la ciudad A ");
            minutos = Convert.ToInt32(Console.ReadLine());
             Console.WriteLine("ingrese los segundos que partio en la ciudad A");
            segundos = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese los segundo que llego");
               tiempo = Convert.ToInt32(Console.ReadLine());
            aux = (horas *3600) +(minutos *60) +segundos;
            aux2 = aux + tiempo;
           h2 = (aux2 / 3600);
            min2 = (aux2 % 3600)/60 ;
            seg2 = (aux2 % 3600)%60;  
            Console.WriteLine("la hora de llegada es "+ h2 +" hora " +min2+ " min "+seg2+" segundos ");
           




        }
    }
}