using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serie_De_Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantElementos = 10;

            int a = 0;
            int b = 1;
            int suma = a + b;

            for (int i = 0; i < cantElementos; i++)
            {
                Console.WriteLine(suma);
                b = a;
                a = suma;
                suma = a + b;
            }
        }
    }
}
