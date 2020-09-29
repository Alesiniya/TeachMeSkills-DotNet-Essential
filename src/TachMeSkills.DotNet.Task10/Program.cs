using System;

namespace TachMeSkills.DotNet.Task10
{
    abstract public class Vehicle
    {
        public decimal Price { set; get; }
        public double Speed { set; get; }
        public DateTime DateOfProd { set; get; }
        public Vehicle()
        {
            Console.Write("Enter Price {0}: ", this.GetType());
            this.Price = Decimal.Parse(Console.ReadLine());
            Console.Write("Enter Speed {0}: ", this.GetType());
            this.Speed = Double.Parse(Console.ReadLine());
            this.DateOfProd = new DateTime(2000, 01, 01);
        }
        abstract public void Display();
    }
    public class Car : Vehicle
    {
        public string Type { get; } = "Car";
        public Car()
            : base()
        {
            Console.WriteLine("New Car object created.");
        }
        public override void Display()
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("TYPE - CAR");
            Console.WriteLine("Price - {0}; Speed - {1}; Date - {2}", this.Price, this.Speed, this.DateOfProd.ToShortDateString());
        }
    }
    public class Plane : Vehicle
    {
        public string Type { get; } = "Plane";
        private double Height { set; get; }
        private int passNumber { set; get; }
        public Plane()
            : base()
        {
            this.Type = "Plane";
            Console.WriteLine("PLANE Parameters : ");
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
            this.Type = "Plane";
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
                this.Price, this.Speed, this.DateOfProd.ToShortDateString(), this.Height, this.passNumber);
        }
    }
    public class Ship : Vehicle
    {
        public string Type { get; } = "Ship";
        public int PassNumber { set; get; }
        public string Port { set; get; }
        public Ship()
            : base()
        {
            this.Type = "Ship";
            Console.WriteLine("SHIP Parameters : ");
            Console.Write("Enter Number of Passengers : ");
            this.PassNumber = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Port : ");
            this.Port = Console.ReadLine();
        }
        public override void Display()
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("TYPE - SHIP.");
            Console.WriteLine("Price - {0}; Speed - {1}; DateOfProduction - {2}; Passengers - {3}; Port - {4}.",
                this.Price, this.Speed, this.DateOfProd.ToShortDateString(), this.PassNumber, this.Port);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car();
            Plane plane1 = new Plane(2300000M, 800, new DateTime(2020, 01, 20));
            Ship ship1 = new Ship();
            car1.Display();
            plane1.Display();
            ship1.Display();
        }
    }
}
