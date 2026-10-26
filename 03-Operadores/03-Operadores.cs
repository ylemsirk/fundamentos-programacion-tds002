using System;

class Operadores
{
    static void Main()
    {
        Console.Write("Ingrese su primer número (x): ");
        int numeroUno = int.Parse(Console.ReadLine());
        Console.Write("Ingrese su segundo número (y): ");
        int numeroDos = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("-- Suma --");
        Console.WriteLine($"{numeroUno} + {numeroDos} = {numeroUno + numeroDos}");
        Console.WriteLine("-- Resta --");
        Console.WriteLine($"{numeroUno} - {numeroDos} = {numeroUno - numeroDos}");
        Console.WriteLine("-- Multiplicación --");
        Console.WriteLine($"{numeroUno} x {numeroDos} = {numeroUno * numeroDos}");
        Console.WriteLine("-- División entera --");
        Console.WriteLine($"{numeroUno} ÷ {numeroDos} = {numeroUno / numeroDos}");
        Console.WriteLine("-- División real --");
        Console.WriteLine($"{numeroUno} ÷ {numeroDos} = {Convert.ToDecimal(numeroUno) / Convert.ToDecimal(numeroDos)}");
        Console.WriteLine($"-- ¿{numeroUno} es par? --");
        Console.WriteLine($"{numeroUno % 2 == 0}");
    }

}

/*
----------------------
PRUEBA DE ESCRITORIO
----------------------
RESULTADO EN CONSOLA:

Ingrese su primer número (x): 10
Ingrese su segundo número (y): 3

//-- Suma --
10 + 3 = 13
-- Resta --
10 - 3 = 7
-- Multiplicación --
10 x 3 = 30
-- División entera --
10 ÷ 3 = 3
-- División real --
10 ÷ 3 = 3.3333333333333333333333333333
-- ¿10 es par? --
True

*/