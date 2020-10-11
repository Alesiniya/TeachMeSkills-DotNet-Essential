using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task20
{
    public struct Train
    {
        public string departPoint;
        public string destinationPoint;
        public string id;

        public Train(string depart, string destination)
        {
            departPoint = depart;
            destinationPoint = destination;
            id = Guid.NewGuid().ToString().ToUpper().Substring(0, 5);
        }
        public void PrintTrain()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"{id}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"Depart - {departPoint} --> Destination - {destinationPoint};");
            Console.WriteLine();
        }
    }
}
