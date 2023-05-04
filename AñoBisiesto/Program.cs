using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AñoBisiesto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int anio;
            Console.Write("Ingrese un año: ");
            anio = int.Parse(Console.ReadLine());

            bool esBisiesto = false;
            if (anio % 4 == 0) {
                esBisiesto=true;
                if (anio % 100 == 0 && anio % 400 != 0)
                {
                    esBisiesto = false;
                }
            }

            if (esBisiesto)
            {
                Console.WriteLine(anio + " Es bisiesto.");
            } else 
            {
                Console.WriteLine(anio + " No es bisiesto");
            }
        }
    }
}
