using System;

namespace TeacghMeSkills.DotNet.Task31
{
    class Program
    {
        static void Main(string[] args)
        {
            CarCollection carCollection = new CarCollection();
            carCollection.AddCar("Ford", new DateTime(2020, 1, 1));
            carCollection.AddCar();
            carCollection.AddCar("Ferrari", new DateTime(2000, 2, 2));
            Console.WriteLine("-------");
            foreach(Car car in carCollection.cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("-------");
            Console.WriteLine($"Total cars number : {carCollection.CarsNumber} pcs;");
        }
    }
}
