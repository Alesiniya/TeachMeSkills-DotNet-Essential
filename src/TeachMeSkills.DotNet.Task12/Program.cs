using System;

namespace TeachMeSkills.DotNet.Task12
{
    public class Printer
    {
        public virtual void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
    public class LaserPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    public class InkPrinter : Printer
    {
        public override void Print(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(value);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.Print("Printer");
            Console.WriteLine("-----");
            LaserPrinter laserPrinter = new LaserPrinter();
            printer = laserPrinter;
            printer.Print("Laser  Printer.");
            ((LaserPrinter)printer).Print("Cast printer");
            Console.WriteLine("-----");
            InkPrinter inkPrinter = new InkPrinter();
            printer = inkPrinter;
            printer.Print("Ink Printer.");
            ((InkPrinter)printer).Print("Cast printer.");
        }
    }
}
