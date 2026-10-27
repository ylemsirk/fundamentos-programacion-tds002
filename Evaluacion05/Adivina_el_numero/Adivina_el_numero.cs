using System;

class AdivinaNumero
{
    static void Main()
    {
        Console.WriteLine("=== ADIVINA EL NÚMERO ===");
        Console.WriteLine("He generado un número secreto entre 1 y 100. ¡Intenta adivinarlo!\n");

        int numeroSecreto = Random.Shared.Next(1, 101);
        int intentos = 0;
        int suposicion = 0;

        do
        {
            Console.Write("Ingresa tu suposición: ");
            string input = Console.ReadLine();

            if (int.TryParse(input, out suposicion))
            {
                intentos++;

                if (suposicion < numeroSecreto)
                {
                    Console.WriteLine("Pista: El número secreto es **mayor**.\n");
                }
                else if (suposicion > numeroSecreto)
                {
                    Console.WriteLine("Pista: El número secreto es **menor**.\n");
                }
                else
                {
                    Console.WriteLine("\n==================================");
                    Console.WriteLine("¡Felicidades! Adivinaste el número.");
                    Console.WriteLine($"Total de intentos realizados: {intentos}");
                    Console.WriteLine("==================================");
                }
            }
            else
            {
                Console.WriteLine("Error: Por favor ingresa un número entero válido.\n");
            }

        } while (suposicion != numeroSecreto);
    }
}