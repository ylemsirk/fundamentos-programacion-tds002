using System;

class Nomina
{
    // Constantes de deducciones de ley
    const double TASA_AFP = 0.0287; // 2.87%
    const double TASA_SFS = 0.0304; // 3.04%

    static void Main()
    {
        Console.WriteLine("=== 1. CÁLCULO DE NÓMINA ===");
        
        // 1. ENTRADA DE DATOS
        Console.Write("Ingrese el nombre del empleado: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingrese las horas trabajadas: ");
        double horasTrabajadas = Convert.ToDouble(Console.ReadLine());

        Console.Write("Ingrese el pago por hora: ");
        double pagoPorHora = Convert.ToDouble(Console.ReadLine());

        // 2. PROCESO
        double salarioBruto = horasTrabajadas * pagoPorHora;
        double afp = salarioBruto * TASA_AFP;
        double sfs = salarioBruto * TASA_SFS;
        double salarioNeto = salarioBruto - (afp + sfs);
        
        // Convertir el nombre a MAYÚSCULAS
        string nombreMayuscula = nombre.ToUpper();

        // 3. SALIDA
        Console.WriteLine("\n--- BOLETA DE PAGO ---");
        Console.WriteLine($"Empleado: {nombreMayuscula}");
        Console.WriteLine($"Salario Bruto : {salarioBruto:N2}");
        Console.WriteLine($"Deducción AFP : {afp:N2}");
        Console.WriteLine($"Deducción SFS : {sfs:N2}");
        Console.WriteLine($"Salario Neto  : {salarioNeto:N2}");
    }
}