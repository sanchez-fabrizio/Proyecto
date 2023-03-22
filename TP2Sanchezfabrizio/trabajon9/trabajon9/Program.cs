/*Un vendedor recibe un sueldo base más un 10% extra por comisión de sus ventas, el vendedor desea
saber cuánto dinero obtendrá por concepto de comisiones por las tres ventas que realiza en el mes y el total
que recibirá en el mes tomando en cuenta su sueldo base y comisiones.*/
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
            double sueldo;
            double sueldo1;
            double comision;
            Console.WriteLine("escriba su sueldo");
            sueldo = Convert.ToDouble(Console.ReadLine());
            comision = sueldo * 0.10;
            sueldo1 = sueldo + comision;
            Console.WriteLine("lo que obtendra su sueldo mas la comision es ==== " + sueldo1);
            Console.WriteLine("lo que obtendra su sueldo mas la comision de los tres dias es =====" + sueldo1 *3);
            Console.ReadKey();




        }
    }
}
