using System;

class Program
{
    static void Main(string[] args)
    {        
        GeneradorNumeros generador = new GeneradorNumeros();

        
        while (true)
        {
            Console.WriteLine("Seleccione una opción:");
            Console.WriteLine("1. Obtener el término n de Fibonacci");
            Console.WriteLine("2. Obtener el primo número n");
            Console.WriteLine("3. Obtener el número perfecto n");
            Console.WriteLine("4. Salir");

            int opcion = Convert.ToInt32(Console.ReadLine());

            if (opcion == 4)
            {
                Console.WriteLine("¡Adiós!");
                break;
            }

            Console.WriteLine("Ingrese el valor de n:");
            int n = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case 1:
                    Console.WriteLine($"El término {n} de Fibonacci es: {generador.Fibonacci(n)}");
                    break;
                case 2:
                    Console.WriteLine($"El primo número {n} es: {generador.Primo(n)}");
                    break;
                case 3:
                    Console.WriteLine($"El número perfecto número {n} es: {generador.NumeroPerfecto(n)}");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Inténtalo de nuevo.");
                    break;
            }
        }
    }
}