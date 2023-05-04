using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace numeros_primos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Calcular los N primeros números primos gemelos.
            Console.Write("Ingrese la cantidad de numeros primos gemelos que desea conocer: ");
            int cant = int.Parse(Console.ReadLine());
            

            int cantidadPrimosGemelos = 0, numero = 2, a = 0, b = 0;

            while (cantidadPrimosGemelos < cant)
            {
                bool dosPrimos = false;
                while (!dosPrimos)
                {
                    bool esPrimo = true;
                    for(int i = 2; i < numero; i++)
                    {
                        if (numero % i == 0)
                        {
                            esPrimo = false;
                        }
                    }
                    if (esPrimo)
                    {
                        if (a == 0)
                        {
                            a = numero;
                        }
                        else
                        {
                            b = numero;
                            dosPrimos = true;
                        }
                    }
                    numero++;
                }
                if ((b - a) == 2)
                {
                    Console.WriteLine("(" + a + "," + b + ")");
                    cantidadPrimosGemelos++;
                }
                a = b;
                b = 0;
            }
        }
    }
}
