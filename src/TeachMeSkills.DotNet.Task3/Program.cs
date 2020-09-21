using System;

namespace TeachMeSkills.DotNet.Task3
{
    class Point
    {
        private int x;
        private int y;
        private string name;

        public int X
        {
            set
            {
                this.x = value;
            }
            get
            {
                return x;
            }
        }
        public int Y
        {
            set
            {
                this.y = value;
            }
            get
            {
                return y;
            }
        }
        public string Name
        {
            set
            {
                this.name = value;
            }
            get
            {
                return name;
            }
        }
        public Point(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }
    }
    class Figure
    {
        private Point point1;
        private Point point2;
        private Point point3;
        private Point point4;
        private Point point5;
        public string name;

        public Figure(Point point1, Point point2, Point point3)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            name = "Triangle";
        }
        public Figure(Point point1, Point point2, Point point3, Point point4)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            name = "Quadrangle";
        }
        public Figure(Point point1, Point point2, Point point3, Point point4, Point point5)
        {
            this.point1 = point1;
            this.point2 = point2;
            this.point3 = point3;
            this.point4 = point4;
            this.point5 = point5;
            name = "Pentagon";
        }
        public double LengthSide(Point A, Point B)
        {
            return Math.Sqrt(Math.Pow((B.X - A.X), 2) + (Math.Pow((B.Y - A.Y), 2)));
        }
        public void PerimeterCalculator()
        {

            double perimeter = LengthSide(point1, point2) + LengthSide(point2, point3);
            if (point4 != null)
                perimeter += LengthSide(point3, point4);
            else
                perimeter += LengthSide(point3, point1);
            if (point5 != null)
            {
                perimeter += LengthSide(point4, point5) + LengthSide(point5, point1);
            }
            else if (point4 != null)
                perimeter += LengthSide(point4, point1);
            Console.WriteLine("Perimeter : {0:00.00}", perimeter);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter points number [3..5] : ");
            int num = Int32.Parse(Console.ReadLine());
            switch (num)
            {
                case 3:
                    Point point1 = GetPointParams();
                    Point point2 = GetPointParams();
                    Point point3 = GetPointParams();
                    Figure figure = new Figure(point1, point2, point3);
                    Console.WriteLine("----------------------");
                    figure.PerimeterCalculator();
                    Console.WriteLine("NAME : {0}", figure.name);
                    break;
                case 4:
                    point1 = GetPointParams();
                    point2 = GetPointParams();
                    point3 = GetPointParams();
                    Point point4 = GetPointParams();
                    figure = new Figure(point1, point2, point3, point4);
                    Console.WriteLine("----------------------");
                    figure.PerimeterCalculator();
                    Console.WriteLine("NAME : {0}", figure.name);
                    break;
                case 5:
                    point1 = GetPointParams();
                    point2 = GetPointParams();
                    point3 = GetPointParams();
                    point4 = GetPointParams();
                    Point point5 = GetPointParams();
                    figure = new Figure(point1, point2, point3, point4, point5);
                    Console.WriteLine("----------------------");
                    figure.PerimeterCalculator();
                    Console.WriteLine("NAME : {0}", figure.name);
                    break;
            }

        }
        private static Point GetPointParams()
        {
            Point point = new Point(0, 0, "A");
            Console.Write("Enter point name : ");
            point.Name = Console.ReadLine();
            Console.Write("Enter {0} X : ", point.Name);
            point.X = Int32.Parse(Console.ReadLine());
            Console.Write("Enter {0} Y : ", point.Name);
            point.Y = Int32.Parse(Console.ReadLine());
            return point;
        }
    }
}
