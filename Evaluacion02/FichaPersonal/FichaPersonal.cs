using System;

class FichaPersonal
{
    static void Main()
    {
        // Solicitar datos al usuario usando variables en camelCase
        Console.Write("Ingrese su nombre: ");
        string nombreUsuario = Console.ReadLine();

        Console.Write("Ingrese su edad: ");
        int edadUsuario = int.Parse(Console.ReadLine());

        Console.Write("Ingrese su estatura en metros (ej. 1.75): ");
        double estaturaUsuario = double.Parse(Console.ReadLine());

        Console.Write("¿Trabaja actualmente? (true/false): ");
        bool trabajaUsuario = bool.Parse(Console.ReadLine());

        // Calcular el año en que cumplirá 30 años
        int anioActual = 2026;
        int anioTreinta = anioActual + (30 - edadUsuario);

        // Mostrar la ficha personal utilizando interpolación de cadenas
        Console.WriteLine("\n--- FICHA PERSONAL ---");
        Console.WriteLine($"Nombre: {nombreUsuario}");
        Console.WriteLine($"Edad: {edadUsuario} años");
        Console.WriteLine($"Estatura: {estaturaUsuario} m");
        Console.WriteLine($"¿Trabaja?: {(trabajaUsuario ? "Sí" : "No")}");
        Console.WriteLine($"Cumplirá 30 años en el año: {anioTreinta}");
    }
}