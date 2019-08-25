using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1
{
    class Práctica1_4
    {
        static void Main(string[] args)
        {
            uint num;
            double res;
            Console.WriteLine("Ingrese un número entero positivo");
            num = Convert.ToUInt32(Console.ReadLine());
            res = Math.Sqrt(num);
            Console.WriteLine("La raíz cuadrada del número es " + res);
            Console.ReadKey();
        }
    }
}
