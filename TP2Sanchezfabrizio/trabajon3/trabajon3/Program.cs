//- Hacer un programa que calcule el salario de un empleado, si se descuenta el 20% de su salario bruto.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            double salario1;
            double salario2;
            double salariobruto;
            Console.WriteLine("ingrese su salario");
            salario1 = Convert.ToInt32(Console.ReadLine());
            salario2 = salario1 * 0.20;
            salariobruto = salario1 - salario2;
            Console.WriteLine(salariobruto);
            Console.ReadKey();

        }
    }
}
