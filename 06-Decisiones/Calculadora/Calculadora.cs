using System;

class Calculadora
{
    static void Main()
    {
        Console.WriteLine("=== CALCULADORA BÁSICA ===");
        Console.Write("Ingrese el primer número: ");
        if (!double.TryParse(Console.ReadLine(), out double num1))
        {
            Console.WriteLine("Error: El primer valor ingresado no es un número válido.");
            return;
        }
        Console.Write("Ingrese el segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out double num2))
        {
            Console.WriteLine("Error: El segundo valor ingresado no es un número válido.");
            return;
        }

        Console.WriteLine("\nElija una operación:");
        Console.WriteLine("1. Sumar (+)");
        Console.WriteLine("2. Restar (-)");
        Console.WriteLine("3. Multiplicar (*)");
        Console.WriteLine("4. Dividir (/)");
        Console.Write("Ingrese el número de la opción (1-4): ");

        if (int.TryParse(Console.ReadLine(), out int opcion))
        {
            Console.WriteLine(); 
            switch (opcion)
            {
                case 1:
                    double suma = num1 + num2;
                    Console.WriteLine($"Resultado: {num1} + {num2} = {suma:N2}");
                    break;

                case 2:
                    double resta = num1 - num2;
                    Console.WriteLine($"Resultado: {num1} - {num2} = {resta:N2}");
                    break;

                case 3:
                    double multiplicacion = num1 * num2;
                    Console.WriteLine($"Resultado: {num1} * {num2} = {multiplicacion:N2}");
                    break;

                case 4:
                    if (num2 == 0)
                    {
                        Console.WriteLine("Error: No es posible dividir entre cero.");
                    }
                    else
                    {
                        double division = num1 / num2;
                        Console.WriteLine($"Resultado: {num1} / {num2} = {division:N2}");
                    }
                    break;

                default:
                    Console.WriteLine("Error: La opción seleccionada no es válida. Elija un número del 1 al 4.");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Error: Debe ingresar un número entero para seleccionar la opción.");
        }
    }
}