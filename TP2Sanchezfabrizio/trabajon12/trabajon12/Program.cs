/*Realizar un programa que lea un número y que muestre su raíz cuadrada y su raíz cúbica. C# tiene
función que permita calcular la raíz cuadrada cúbica. ¿Cómo se puede calcular?*/
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
            double num1, aux;
            Console.WriteLine("ingrese un numero");
            num1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("su raiz cuadrada es = "+Math.Sqrt(num1)); //la funcion de math.sqrt es para sacar la raiz cuadrada
            /*aqui la funcion de math pow es para elevar un numero, pero aqui sacamos la raiz cubica que es 1/3 que saca la raiz cubica   */
            aux = Math.Pow(num1,1/3d);
            //la funcion math.round es para redondear el numero de la variable double
            Console.WriteLine("su raiz cubica es = "+ Math.Round(aux));
            //ejemplo para guiarme para sacar la raiz cuadrada con la funcion mathpow
            Console.WriteLine("su raiz cubica es =" + Math.Pow(num1, 1 / 2d));

        }
    }
}