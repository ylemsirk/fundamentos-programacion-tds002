using System;

class CajaRegistradora
{
    const double TASA_ITBIS = 0.18;
    static void Main()
    {
        Console.WriteLine("=== CAJA REGISTRADORA ===");
        Console.WriteLine("Ingrese los precios de los productos. Escriba 0 para terminar.\n");

        double subtotal = 0;
        int cantidadProductos = 0;
        double precio;

        do
        {
            Console.Write($"Ingrese el precio del producto {cantidadProductos + 1} (o 0 para finalizar): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out precio))
            {
                if (precio < 0)
                {
                    Console.WriteLine("Error: El precio no puede ser negativo. Intente de nuevo.");
                }
                else if (precio > 0)
                {
                    subtotal += precio;
                    cantidadProductos++;
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada no válida. Ingrese un valor numérico.");
                precio = -1; 
            }

        } while (precio != 0);

        double itbis = subtotal * TASA_ITBIS;
        double total = subtotal + itbis;

        Console.WriteLine("\n==================================");
        Console.WriteLine("         RESUMEN DE COMPRA        ");
        Console.WriteLine("==================================");
        Console.WriteLine($"Total de productos : {cantidadProductos}");
        Console.WriteLine($"Subtotal           : {subtotal:N2}");
        Console.WriteLine($"ITBIS (18%)        : {itbis:N2}");
        Console.WriteLine($"Total a pagar      : {total:N2}");
        Console.WriteLine("==================================");
    }
}