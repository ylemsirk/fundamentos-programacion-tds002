/*
    Carpeta: 01-HolaMundo
    Descripción: Programa de consola en C# que muestra una tarjeta de presentación
    con Nombre, Matrícula, Carrera y Frase entre un marco decorativo.
*/

using System;
namespace HolaMundo
{
    public class Program
    {
        static void Main(string[] args)
        {
            string nombre    = "Nombre: Ylemsirk Jafet Iberie Pichardo";
            string matricula = "Matrícula: 2026-1095";
            string carrera   = "Carrera: Tecnólogo en Ciberseguridad";
            string frase     = "Frase: ¿Por qué?";
            string bordeHorizontal = "=================================================";
            Console.WriteLine(bordeHorizontal);
            Console.WriteLine($"| {nombre,-45} |");
            Console.WriteLine($"| {matricula,-45} |");
            Console.WriteLine($"| {carrera,-45} |");
            Console.WriteLine($"| {frase,-45} |");
            Console.WriteLine(bordeHorizontal);
        }
    }
}