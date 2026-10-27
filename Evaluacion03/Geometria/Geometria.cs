using System;

class Geometria
{
    static void Main()
    {
        Console.WriteLine("=== 3. Cálculos Geométricos ===");

        // 1. ENTRADA DE DATOS
        Console.Write("Ingrese el radio del círculo: ");
        double radio = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el primer cateto del triángulo rectángulo: ");
        double catetoA = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el segundo cateto del triángulo rectángulo: ");
        double catetoB = Convert.ToDouble(Console.ReadLine());

        // 2. PROCESO
        // Círculo: Área = PI * r^2, Circunferencia = 2 * PI * r
        double areaCirculo = Math.PI * Math.Pow(radio, 2);
        double circunferencia = 2 * Math.PI * radio;

        // Triángulo Rectángulo: Hipotenusa = Raíz cuadrada de (a^2 + b^2)
        double hipotenusa = Math.Sqrt(Math.Pow(catetoA, 2) + Math.Pow(catetoB, 2));

        // 3. SALIDA
        Console.WriteLine("\n=== RESULTADOS GEOMÉTRICOS ===");
        Console.WriteLine("Círculo:");
        Console.WriteLine($"  - Área          : {areaCirculo:N2}");
        Console.WriteLine($"  - Circunferencia: {circunferencia:N2}");
        Console.WriteLine("\nTriángulo Rectángulo:");
        Console.WriteLine($"  - Cateto A      : {catetoA:N2}");
        Console.WriteLine($"  - Cateto B      : {catetoB:N2}");
        Console.WriteLine($"  - Hipotenusa    : {hipotenusa:N2}");
    }
}