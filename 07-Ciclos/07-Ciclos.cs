using System;

class Ciclos
{
    static void Main()
    {
        int numero;
        do
        {
            Console.Write("Ingresa un número entre 1 y 12: ");
        } 
        while (!int.TryParse(Console.ReadLine(), out numero) || numero < 1 || numero > 12);

        Console.WriteLine($"\nTabla de multiplicar del {numero}:");

        int contador = 1;
        int acumulador = 0;

        while (contador <= 12)
        {
            int resultado = numero * contador;
            Console.WriteLine($"{numero} x {contador} = {resultado}");
            acumulador += resultado;
            contador++;
        }

        Console.WriteLine($"\nSuma total de todos los resultados: {acumulador}");
    }
}