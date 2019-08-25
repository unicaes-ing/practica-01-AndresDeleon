using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1
{
    class Práctica1_2
    {
        static void Main(string[] args)
        {
            string nombre, cargo, correo, fecha;
            int edad;
            float sueldo;
            Console.WriteLine("Nombre del empleado");
            nombre = Console.ReadLine();
            Console.WriteLine("Cargo del empleado");
            cargo = Console.ReadLine();
            Console.WriteLine("Correo del empleado");
            correo = Console.ReadLine();
            Console.WriteLine("Edad del empleado");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fecha de contratación del empleado");
            fecha = Console.ReadLine();
            Console.WriteLine("Sueldo del empleado");
            sueldo = float.Parse(Console.ReadLine());
            Console.WriteLine("Nombre: " + nombre);
            Console.WriteLine("Cargo: " + cargo);
            Console.WriteLine("Correo: " + correo);
            Console.WriteLine("Edad: " + edad);
            Console.WriteLine("Fecha de contratación: " + fecha);
            Console.WriteLine("Sueldo: $" + sueldo);
            Console.ReadLine();
        }
    }
}
