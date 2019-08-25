using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1
{
    class Práctica1_6
    {
        static void Main(string[] args)
        {
            string nombre;
            double sueldo, isss, renta, afp;
            Console.WriteLine("Nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Sueldo del empleado");
            sueldo = float.Parse(Console.ReadLine());
            isss = sueldo * 0.075;
            afp = sueldo * 0.075;
            renta = sueldo * 0.1;
            sueldo = sueldo - isss - afp - renta;
            Console.WriteLine("Sueldo a pagar al empleado: " + sueldo.ToString("C"));
            Console.WriteLine("Descuentos");
            Console.WriteLine("ISSS: " + isss.ToString("C"));
            Console.WriteLine("AFP: " + afp.ToString("C"));
            Console.WriteLine("Renta: " + renta.ToString("C"));
            Console.ReadKey();
        }
    }
}
