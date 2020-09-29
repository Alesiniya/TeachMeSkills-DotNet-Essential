using System;

namespace TachMeSkills.DotNet.Task10
{
    abstract public class Vehicle
    {
        private decimal price;
        private double speed;
        private DateTime dateOfProd;
        public decimal Price { set; get; }
        public double Speed { set; get; }
        public DateTime DateOfProd { set; get; }
        public Vehicle()
        {
            this.Price = 0.0M;
            this.Speed = 0;
            this.DateOfProd = new DateTime(2000, 01, 01);
        }
        abstract public void Display();
    }
    public class Car : Vehicle
    {
        public Car()
            : base()
        {
            Console.WriteLine("New Car object created.");
        }
        public override void Display()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("TYPE - CAR");
            Console.WriteLine("Price - {0}; Speed - {1}; Date - {2}", this.Price, this.Speed, this.DateOfProd);
        }
    }
    public class Plane : Vehicle
    {
        private double Height { set; get; }
        private int passNumber { set; get; }
        public Plane()
            : base()
        {
            Console.Write("Enter Height of this Plane : ");
            this.Height = Double.Parse(Console.ReadLine());
            Console.Write("Enter Number of passengers ");
            this.passNumber = Int32.Parse(Console.ReadLine());
        }
        public Plane(decimal price, double speed, DateTime dateOfProd)
        {
            this.Price = price;
            this.Speed = speed;
            this.DateOfProd = dateOfProd;
            Console.Write("Enter Height of this Plane : ");
            this.Height = Double.Parse(Console.ReadLine());
            Console.Write("Enter Number of passengers ");
            this.passNumber = Int32.Parse(Console.ReadLine());

        }
        public override void Display()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("TYPE - Plane;");
            Console.WriteLine("Price - {0}; Speed - {1}; DateOfProduction - {2}; Height - {3}; Passengers - {4}",
                this.Price, this.Speed, this.DateOfProd, this.Height, this.passNumber);
        }
    }
    public class Ship : Vehicle
    {
        public int PassNumber { set; get; }
        public string Port { set; get; }
        public Ship()
            : base()
        {
            Console.Write("Enter Number of Passengers : ");
            this.PassNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Port : ");
            this.Port = Console.ReadLine();
        }
        public override void Display()
        {
            Console.WriteLine();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
