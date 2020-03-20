using System;

namespace ContagemRegressiva
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Preparar...");
            Console.ReadKey();
            Console.WriteLine("Apontar...");
            Console.ReadKey();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("FOGO!");
            Console.ReadKey();
        }
    }
}
