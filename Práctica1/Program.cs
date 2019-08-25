using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Práctica1
{
    class Práctica1_1
    {
        static void Main(string[] args)
        {
            //Andrés Lemus 10/07/2019
            string nombre, especie;
            int edad;
            Console.WriteLine("Nombre de su mascota");
            nombre = Console.ReadLine();
            Console.WriteLine("Especie de su mascota");
            especie = Console.ReadLine();
            Console.WriteLine("Edad de su mascota");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Su mascota {0} es un/una {1} y tiene {2} años de edad.", nombre, especie, edad);
            Console.ReadKey();
        }
    }
}
