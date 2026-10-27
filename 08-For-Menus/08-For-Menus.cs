using System;

class ForMenus
{
    static void Main()
    {
        int opcion;

        do
        {
            Console.WriteLine("\n=== MENÚ PRINCIPAL ===");
            Console.WriteLine("1. Tablas de multiplicar (1 al 10)");
            Console.WriteLine("2. Triángulo de asteriscos");
            Console.WriteLine("0. Salir");
            Console.Write("Elige una opción: ");

            if (int.TryParse(Console.ReadLine(), out opcion))
            {
                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("\n--- Tablas del 1 al 10 ---");
                        for (int i = 1; i <= 10; i++)
                        {
                            for (int j = 1; j <= 10; j++)
                            {
                                Console.Write($"{i * j,4}");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 2:
                        Console.WriteLine("\n--- Triángulo de Asteriscos ---");
                        int n;
                        do
                        {
                            Console.Write("Ingresa el número de filas: ");
                        }
                        while (!int.TryParse(Console.ReadLine(), out n) || n <= 0);

                        for (int i = 1; i <= n; i++)
                        {
                            for (int j = 1; j <= i; j++)
                            {
                                Console.Write("*");
                            }
                            Console.WriteLine();
                        }
                        break;

                    case 0:
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Inténtalo de nuevo.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Entrada no válida. Ingresa un número.");
                opcion = -1;
            }

        } while (opcion != 0);
    }
}