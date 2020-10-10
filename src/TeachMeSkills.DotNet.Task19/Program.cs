using System;

namespace TeachMeSkills.DotNet.Task19
{
    class Program
    {

        static void Main(string[] args)
        {
            Console.Write("Enter a : ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter b : ");
            int b = Int32.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("-------");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("- Addition -");
            Console.WriteLine($"{nameof(a)} + {nameof(b)} = {Calculator.Add(a, b)}");
            Console.WriteLine();
            Console.WriteLine("- Substraction -");
            Console.WriteLine($"{nameof(a)} - {nameof(b)} = {Calculator.Substract(a, b)}");
            Console.WriteLine();
            Console.WriteLine("- Multiplay -");
            Console.WriteLine($"{nameof(a)} * {nameof(b)} = {Calculator.Multiplay(a, b)}");
            Console.WriteLine();
            Console.WriteLine("- Division -");
            try
            {
                Console.WriteLine("{0:f4} / {1:f4} = {2:f2}", nameof(a), nameof(b), Calculator.Divide(a, b));
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
