using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transformar_a_romano
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num, unidades, decenas, centenas, millar;
            Console.Write("Ingrese un numero entero: ");
            num = int.Parse(Console.ReadLine());

            unidades = num % 10;
            num /= 10;

            decenas = num % 10;
            num /= 10;

            centenas = num % 10;
            num /= 10;

            millar = num % 10;
            num /= 10;

            switch (millar)
            {
                case 1: Console.Write("M"); break;
                case 2: Console.Write("MM"); break;
                case 3: Console.Write("MMM"); break;
            }
            switch (centenas)
            {
                case 1: Console.Write("C"); break;
                case 2: Console.Write("CC"); break;
                case 3: Console.Write("CCC"); break;
                case 4: Console.Write("CD"); break;
                case 5: Console.Write("D"); break;
                case 6: Console.Write("DC"); break;
                case 7: Console.Write("DCC"); break;
                case 8: Console.Write("DCCC"); break;
                case 9: Console.Write("CM"); break;
            }
            switch (decenas)
            {
                case 1: Console.Write("X"); break;
                case 2: Console.Write("XX"); break;
                case 3: Console.Write("XXX"); break;
                case 4: Console.Write("XL"); break;
                case 5: Console.Write("L"); break;
                case 6: Console.Write("LX"); break;
                case 7: Console.Write("LXX"); break;
                case 8: Console.Write("LXXX"); break;
                case 9: Console.Write("XC"); break;
            }
            switch (unidades)
            {
                case 1: Console.Write("I"); break;
                case 2: Console.Write("II"); break;
                case 3: Console.Write("III"); break;
                case 4: Console.Write("IV"); break;
                case 5: Console.Write("V"); break;
                case 6: Console.Write("VI"); break;
                case 7: Console.Write("VII"); break;
                case 8: Console.Write("VIII"); break;
                case 9: Console.Write("IX"); break;
            }
            Console.WriteLine();
        }
    }
}
