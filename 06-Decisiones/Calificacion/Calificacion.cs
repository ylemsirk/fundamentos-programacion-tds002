using System;

class Calificacion
{
    static void Main()
    {
        Console.WriteLine("=== SISTEMA DE CALIFICACIONES ===");
        Console.Write("Ingrese la nota (0-100): ");

        if (int.TryParse(Console.ReadLine(), out int nota))
        {
            if (nota >= 0 && nota <= 100)
            {
                string letra;

                if (nota >= 90)
                {
                    letra = "A";
                }
                else if (nota >= 80)
                {
                    letra = "B";
                }
                else if (nota >= 70)
                {
                    letra = "C";
                }
                else
                {
                    letra = "F";
                }
                Console.WriteLine($"Resultado: La nota {nota} equivale a la calificación {letra}.");
            }
            else
            {
                Console.WriteLine("Error: La nota debe estar en el rango de 0 a 100.");
            }
        }
        else
        {
            Console.WriteLine("Error: Entrada no válida. Debe ingresar un número entero.");
        }
    }
}