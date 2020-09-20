using System;

namespace TeachMeSkills.DotNet.Task1
{
    class Rectangle
    {
        double side1;
        double side2;
        public Rectangle(double side1, double side2) { this.side1 = side1; this.side2 = side2; }
        private double AreaCalculator()
        {
            return side1 * side2;
        }
        private double PerimeterCalculator()
        {
            return 2 * (side1 + side2);
        }

        public double Area
        {
            get
            {
                return AreaCalculator();
            }
        }
        public double Perimeter
        {
            get
            {
                return PerimeterCalculator();
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter side 1 : ");
            double side1 = Double.Parse(Console.ReadLine());
            Console.Write("Enter side 2 : ");
            double side2 = Double.Parse(Console.ReadLine());
            Console.WriteLine();
            Rectangle rectangle = new Rectangle(side1, side2);
            Console.WriteLine("Perimeter : {0:00.00}", rectangle.Perimeter);
            Console.WriteLine("Area : {0:00.00}", rectangle.Area);

            Console.ReadLine();
        }
    }
}
