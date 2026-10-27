using System;

class PromedioValidado
{
    static void Main()
    {
        Console.WriteLine("=== PROMEDIO DE NOTAS VALIDADO ===");
        Console.WriteLine("Ingrese notas válidas (0-100). Escriba -1 para finalizar y calcular.\n");

        double sumaNotas = 0;
        int contadorNotas = 0;
        double notaMayor = double.MinValue;
        double notaMenor = double.MaxValue;
        double nota;

        while (true)
        {
            Console.Write($"Ingrese la nota #{contadorNotas + 1} (-1 para terminar): ");
            string input = Console.ReadLine();

            if (double.TryParse(input, out nota))
            {
                if (nota == -1)
                {
                    break;
                }

                if (nota >= 0 && nota <= 100)
                {
                    sumaNotas += nota;
                    contadorNotas++;

                    if (nota > notaMayor)
                    {
                        notaMayor = nota;
                    }
                    if (nota < notaMenor)
                    {
                        notaMenor = nota;
                    }
                }
                else
                {
                    Console.WriteLine("Error: La nota debe estar en el rango de 0 a 100 (o -1 para salir).");
                }
            }
            else
            {
                Console.WriteLine("Error: Entrada no válida. Ingrese un valor numérico.");
            }
        }

        Console.WriteLine("\n==================================");
        Console.WriteLine("         ESTADÍSTICAS FINALES     ");
        Console.WriteLine("==================================");
        
        if (contadorNotas > 0)
        {
            double promedio = sumaNotas / contadorNotas;
            Console.WriteLine($"Total de notas evaluadas : {contadorNotas}");
            Console.WriteLine($"Nota promedio            : {promedio:N2}");
            Console.WriteLine($"Nota más alta            : {notaMayor:N2}");
            Console.WriteLine($"Nota más baja            : {notaMenor:N2}");
        }
        else
        {
            Console.WriteLine("No se ingresaron notas válidas para procesar.");
        }
        
        Console.WriteLine("==================================");
    }
}