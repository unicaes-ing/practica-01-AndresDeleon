using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1
{
    class Práctica1_5
    {
        static void Main(string[] args)
        {
            float tr1, tr2, tr3, tr4, prom;
            Console.WriteLine("Promedio de Ventas Total del Año 2019");
            Console.WriteLine("==============================================");
            Console.WriteLine("Promedio de ventas del Trimestre #1");
            tr1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Promedio de ventas del Trimestre #2");
            tr2 = float.Parse(Console.ReadLine());
            Console.WriteLine("Promedio de ventas del Trimestre #3");
            tr3 = float.Parse(Console.ReadLine());
            Console.WriteLine("Promedio de ventas del Trimestre #4");
            tr4 = float.Parse(Console.ReadLine());
            prom = (tr1 + tr2 + tr3 + tr4) / 4;
            Console.WriteLine("==============================================");
            Console.WriteLine("Promedio Total de Ventas del Año 2018: $" + prom);
            Console.ReadKey();
        }
    }
}
