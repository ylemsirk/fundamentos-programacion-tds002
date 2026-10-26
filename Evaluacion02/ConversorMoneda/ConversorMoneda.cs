using System;

class ConversorMoneda
{
    // Declaración de la constante con la tasa del día en camelCase
    const double tasaUsd = 61.05;

    static void Main()
    {
        Console.WriteLine("--- CONVERSOR DE MONEDA ---");
        Console.Write("Ingrese el monto en pesos: ");

        // Validar y leer el monto ingresado
        if (double.TryParse(Console.ReadLine(), out double montoPesos))
        {
            // Realizar la conversión a dólares
            double montoDolares = montoPesos / tasaUsd;

            // Mostrar el resultado con formato de dos decimales
            Console.WriteLine($"Monto ingresado: {montoPesos:N2} DOP");
            Console.WriteLine($"Equivalente en USD (Tasa: {tasaUsd}): ${montoDolares:N2} USD");
        }
        else
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
    }
}