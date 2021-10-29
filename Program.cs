using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2;

            Console.Beep();
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("--- Equação do segundo grau ---\n");
            Console.ResetColor();

            Console.Write("(a) : ");
            a = double.Parse(Console.ReadLine());
            
            Console.Write("(b) : ");
            b = double.Parse(Console.ReadLine());

            Console.Write("(c) : ");
            c = double.Parse(Console.ReadLine());

            delta = Math.Pow(b,2) - 4 * a * c;
            x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            x2 = (-b - Math.Sqrt(delta)) / 2 * a; 

            if(a == 0)
            {
                Console.WriteLine("\nNão é uma equação de 2º grau");
            }
            else if(delta < 0)
            {
                Console.WriteLine($"\nComo delta = {delta:N2}, a equação não possui raizes reais! ");
            }
            else
            {
                Console.WriteLine($"\nx' = {x1:N2} \nx'' = {x2:N2} ");
            }
        }
    }
}
