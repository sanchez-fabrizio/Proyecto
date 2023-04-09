/*La política de cobro de la empresa telefónica CELphone es: Cuando se realiza una llamada, el cobro es
por el tiempo que esta dura, de tal forma el costo por minuto es uniforme y es de 30 pesos; además, se
carga un impuesto del 3% cuando es domingo, y si es otro día, en turno de mañana 15% y en turno de tarde
10%. Realiza un programa para determinar cuánto debe pagar una persona que realiza una llamada, el
usuario debe ingresar los minutos que duró la llamada, el día, y el turno.*/
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
            int minutos, aux;
            string dia, turno;
            Console.WriteLine("ingresar los minutos de llamada");
            minutos = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("ingresar el dia de la llamada");
            dia = Convert.ToString(Console.ReadLine());
            Console.WriteLine("ingresar el turno de la llamada");
            turno = Convert.ToString(Console.ReadLine());
            aux = minutos * 30;
            
            if (dia == "domingo") {
                Console.WriteLine("lo que tiene que pagar el domingo es =  " + aux * 0.3 + " pesos ");
            }
            else if (turno == "mañana")
            {
                Console.WriteLine("lo que tiene que pagar en el turno " + turno + " del dia "+dia+" es = " + aux * 0.15 + " pesos ");
            }
            else if (turno == "tarde")
            {
                Console.WriteLine("lo que tiene que pagar en el turno " + turno + " del dia "+dia+ " es = " + aux * 0.10 +" pesos ");

            }



            Console.ReadKey();
            }
        




        }

            

        }




    
