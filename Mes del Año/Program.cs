using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mes_del_Año
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] meses = { "ENERO", "FEBRERO", "MARZO", "ABRIL", "MAYO", "JUNIO", "JULIO", "AGOSTO", "SEPTIEMBRE", "OCTUBRE", "NOVIEMBRE", "DICIEMBRE" };

            Console.Write("Ingrese el nombre de un mes: ");
            string mes = Console.ReadLine();
            
            int i = 0;
            while (mes.ToUpper() != meses[i])
            {
                i++;
            }

            Console.WriteLine("Nombre del mes "+mes+" numero del mes "+ (i+1));
        }
    }
}
