//- Calcular el cambio de monedas en dólares y euros al ingresar cierta cantidad de dinero en pesos.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            double Euros;
            double Dolares;
            double PesosDolar;
            double PesosEuros;
            Console.WriteLine("introduzca el DOLAR que tiene a su disposicion");
            Dolares = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("introdusza el EURO que tenga en su disposicion");
            Euros = Convert.ToDouble(Console.ReadLine());
            PesosDolar = (Dolares * 220);
            PesosEuros = (Euros * 213);
            Console.WriteLine("dolar a pesos son ===  " + PesosDolar);
            Console.WriteLine("euros a pesos son ====   " + PesosEuros);
            Console.ReadKey();
        }
    }
}
