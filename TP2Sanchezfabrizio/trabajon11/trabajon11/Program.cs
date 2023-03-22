/*Pide al usuario dos números y muestra la “distancia” entre ellos (el valor absoluto de su diferencia, de
modo que el resultado sea siempre positivo).*/
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
            double num1;
            double num2;
            double aux;
            double aux2;
            Console.WriteLine("ingrese un numero");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese otro numero");
            num2 = Convert.ToInt32(Console.ReadLine());
            aux = num1 + num2; //sumo el numero 
            aux2 = Math.Abs(aux); //funcion matematicas para que el resultado es positivo 
            Console.WriteLine("su distancia es de = "+ aux2 + " M "); 
            Console.ReadKey();
            







        }
    }
}