using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Suma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Ingrese el primer numero: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Ingrese el segundo numero: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la suma de " + a + " y " + b + " es " + (a + b) + ".");
        }
    }
}
