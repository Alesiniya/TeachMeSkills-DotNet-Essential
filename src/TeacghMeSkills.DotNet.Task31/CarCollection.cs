using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeacghMeSkills.DotNet.Task31
{
    public class CarCollection
    {
        public List<Car> cars { get; set; }
        public int CarsNumber { get { return cars.Count + 1; } }
        public CarCollection()
        {
            cars = new List<Car>();
        }
        public Car this[int index]
        {
            get
            {
                try
                {
                    return cars[index - 1];
                }
                catch(ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine($"Error! Wrong index. => {ex.Message}");
                    return cars[0];
                }
            }
            set
            {
                cars.Add(value);
            }
        }
        public void AddCar(string model, DateTime prodDate)
        {
            cars.Add(new Car(model, prodDate));
        }
        public void AddCar()
        {
            cars.Add(new Car());
        }
        public void RemoveAllCars()
        {
            cars.Clear();
        }
    }
}
