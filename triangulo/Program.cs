using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace triangulo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroFilas;

            Console.Write("Ingrese un numero de filas: ");
            numeroFilas = int.Parse(Console.ReadLine());

            int espacios = (2 * numeroFilas - 1) / 2; //la cantidad de espacios que va a tener el primer * va a ser la cantidad maxima de * que tenga la base del triangulo entre dos, ademas simpre seran numeros impares, por eso calculamos el ultimo numero impar que va a ser la cantidad de filas * 2 - 1 y a eso lo dividimos entre 2, por ser un numero entero nos redondeara para abajo y conseguiremos los espacios. 
            int vueltas = 1;

            while (vueltas <= numeroFilas)
            {
                for (int i = 0; i < espacios; i++)
                {
                    Console.Write(' ');
                }
                espacios--;

                for (int i = 0; i < (vueltas*2-1); i++) //de esta manera escribimos la cantidad de * que tendra nuestra fila, tiene que ser un numero impar
                {
                    Console.Write("*");
                }

                Console.WriteLine();
                vueltas++;
            }



        }
    }
}
