using System;

class Factura
{
    // Constante del impuesto ITBIS
    const double TASA_ITBIS = 0.18;

    static void Main()
    {
        Console.WriteLine("=== 2. SISTEMA DE FACTURACIÓN ===");

        // 1. ENTRADA DE DATOS
        Console.Write("Ingrese el nombre del producto: ");
        string producto = Console.ReadLine();

        Console.Write("Ingrese la cantidad: ");
        int cantidad = Convert.ToInt32(Console.ReadLine());

        Console.Write("Ingrese el precio unitario: ");
        double precio = Convert.ToDouble(Console.ReadLine());

        // 2. PROCESO
        double subtotal = cantidad * precio;
        double itbis = subtotal * TASA_ITBIS;
        double total = subtotal + itbis;

        // 3. SALIDA (Columnas alineadas con {valor,10:N2} y PadRight)
        Console.WriteLine("\n==================================");
        Console.WriteLine("            FACTURA               ");
        Console.WriteLine("==================================");
        Console.WriteLine($"Producto: {producto}");
        Console.WriteLine($"Cantidad: {cantidad}");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"{"Subtotal:",-15} {subtotal,10:N2}");
        Console.WriteLine($"{"ITBIS (18%):",-15} {itbis,10:N2}");
        Console.WriteLine("----------------------------------");
        Console.WriteLine($"{"Total a pagar:",-15} {total,10:N2}");
        Console.WriteLine("==================================");
    }
}