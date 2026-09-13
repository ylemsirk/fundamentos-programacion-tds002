/*
 * Nombre: Ylemsirk Jafet Iberie Pichardo
 * Fecha: 07/09/2026
 * Descripción: Programa de consola en C# para la carpeta 01-HolaMundo que 
 *              imprime una tarjeta de presentación con nombre, matrícula, 
 *              carrera y frase dentro de un marco de caracteres.
 */

using System;

namespace HolaMundo
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Definición de las variables con los datos personales de la tarjeta
            string nombre    = "Nombre: Ylemsirk Jafet Iberie Pichardo";
            string matricula = "Matrícula: 2026-1095";
            string carrera   = "Carrera: Tecnólogo en Ciberseguridad";
            string frase     = "Frase: ¿Por qué?";

            // Cadena para construir el borde superior e inferior del marco
            string bordeHorizontal = "=================================================";

            // Imprime en consola la tarjeta aplicando alineación a la derecha para formatear el borde
            Console.WriteLine(bordeHorizontal);
            Console.WriteLine($"| {nombre,-45} |");
            Console.WriteLine($"| {matricula,-45} |");
            Console.WriteLine($"| {carrera,-45} |");
            Console.WriteLine($"| {frase,-45} |");
            Console.WriteLine(bordeHorizontal);
        }
    }
}
