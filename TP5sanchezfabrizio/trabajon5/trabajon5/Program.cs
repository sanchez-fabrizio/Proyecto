/*Escriba un programa que solicite dos números enteros (mínimo y máximo). A
continuación, se debe pedir al usuario que ingrese números enteros situados entre el
máximo y mínimo. Cada vez que un número se encuentre entre ese intervalo, se sumara
uno a una variable. El programa terminará cuando se escriba un número que no
pertenezca a ese intervalo, y al finalizar se debe mostrar por pantalla la cantidad de
números ingresados dentro del intervalo. */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trabajon5
{
    class Program
    {
        static void Main(string[] args)
        {
            int nummax;
            int nummin;
            int usuario;
            int contador = 0;
            Console.WriteLine("ingrese un numero minimo");
            nummin = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("ingrese un numero maximo");
            nummax = Convert.ToInt32(Console.ReadLine());
            do
            {
                contador++;
                Console.WriteLine("ingrese los numero que esta entre minimo({0}) y el max({1})",nummin,nummax);
                usuario = Convert.ToInt32(Console.ReadLine());

                
            }
            while (usuario > nummin && usuario<nummax );
            Console.WriteLine("los numeros intervalo que se muestra en pantalla es({0}) Y EL NUMERO que finalizo el USUARIO ({1})",contador,usuario);
            Console.ReadKey();
        }
    }
}
