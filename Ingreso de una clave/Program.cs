using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ingreso_de_una_clave
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int intentos = 0;
            String clave = "123";
            bool salir = false;
            while (!salir)
            {
                if (intentos < 4)
                {
                    Console.Write("Introduzca clave: ");
                    String claveIngresada = Console.ReadLine();
                    intentos += 1;
                    if (claveIngresada == clave)
                    {
                        Console.WriteLine("Clave correcta");
                        salir = true;
                    } else
                    {
                        Console.WriteLine("Clave incorrecta");
                    }
                } else
                {
                    Console.WriteLine("Ya se intentaron 4 claves");
                    salir = true;
                }
            }
            
        }
    }
}
