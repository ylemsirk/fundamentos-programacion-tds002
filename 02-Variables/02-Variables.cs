using System;
namespace Clase02
{
    public class Program2
    {
        static void Main(string[] args)
        {
            Console.Write("Ingrese su nombre: ");
            string name = Console.ReadLine();
            Console.Write("Ingrese su edad: ");
            int edad = int.Parse(Console.ReadLine());            
            Console.Write("Ingrese su estatura (cm): ");
            double estatura = double.Parse(Console.ReadLine());
            const int ANIO_ACTUAL = 2026;
            Console.WriteLine($"Hola {name}");
            Console.WriteLine($"Tienes {edad} años");
            Console.WriteLine($"Naciste en el año {ANIO_ACTUAL - edad}");
            Console.WriteLine($"Mides {estatura} cm");
        }
    }
}

