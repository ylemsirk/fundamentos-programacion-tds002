using System;

class CastingProgram
{
    static void Main()
    {
        Console.WriteLine("--- DEMOSTRACIÓN DE CASTING ---");
        Console.Write("Ingrese un número con decimales (ej. 45.78): ");

        if (double.TryParse(Console.ReadLine(), out double numeroDecimal))
        {
            // Casting explícito: convierte double a int (se descarta la parte decimal)
            int parteEntera = (int)numeroDecimal;
            
            Console.WriteLine($"\nNúmero original (double): {numeroDecimal}");
            Console.WriteLine($"Casting explícito a int (parte entera): {parteEntera}");

            // Casting implícito: un entero cabe de forma segura en un double
            int numeroEntero = 100;
            double numeroConvertido = numeroEntero; 

            Console.WriteLine($"\nValor entero original: {numeroEntero}");
            Console.WriteLine($"Casting implícito a double: {numeroConvertido}");
        }
        else
        {
            Console.WriteLine("Valor ingresado no válido.");
        }
    }
}