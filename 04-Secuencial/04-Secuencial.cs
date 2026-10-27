using System;

class Secuencial
{
    // Constantes requeridas
    const double KG_POR_LIBRA = 0.453592;

    static void Main()
    {
        Console.WriteLine("=== CONVERTIDOR DE UNIDADES ===");
        Console.WriteLine();

        // 1. Pedir el peso en libras
        Console.Write("Ingresa el peso en libras (lb): ");
        double libras = Convert.ToDouble(Console.ReadLine());

        // 2. Pedir la temperatura en °F
        Console.Write("Ingresa la temperatura en Fahrenheit (°F): ");
        double fahrenheit = Convert.ToDouble(Console.ReadLine());

        // 3. Cálculos de conversión
        double kilogramos = libras * KG_POR_LIBRA;
        double celsius = (fahrenheit - 32) * 5 / 9;

        // 4. Mostrar resultados con formato {valor:F2} y Math.Round
        Console.WriteLine();
        Console.WriteLine("=== RESULTADOS DE LA CONVERSIÓN ===");
        
        // Uso de {valor:F2} para el peso
        Console.WriteLine($"Peso: {libras} lb equivalen a {kilogramos:F2} kg.");
        
        // Uso de Math.Round para la temperatura
        double celsiusRedondeado = Math.Round(celsius, 2);
        Console.WriteLine($"Temperatura: {fahrenheit} °F equivalen a {celsiusRedondeado} °C.");
    }
}