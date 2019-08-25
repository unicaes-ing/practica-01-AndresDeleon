using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1
{
    class Práctica1_3
    {
        static void Main(string[] args)
        {
            float dec1, dec2, sum, rest, mult, div;
            Console.WriteLine("Ingrese el primer número decimal");
            dec1 = float.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número decimal");
            dec2 = float.Parse(Console.ReadLine());
            sum = dec1 + dec2;
            rest = dec1 - dec2;
            mult = dec1 * dec2;
            div = dec1 / dec2;
            Console.WriteLine("Sumatoria: " + string.Format("{0:0.0}", sum));
            Console.WriteLine("Resta: " + string.Format("{0:0.0}", rest));
            Console.WriteLine("Multiplicación: " + string.Format("{0:0.0}", mult));
            Console.WriteLine("División: " + string.Format("{0:0.0}", div));
            Console.ReadKey();
        }
    }
}
