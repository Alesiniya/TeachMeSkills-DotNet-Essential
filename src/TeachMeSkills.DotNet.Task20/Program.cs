using System;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace TeachMeSkills.DotNet.Task20
{
    class Program
    {
        static void Main(string[] args)
        {
            Train[] trains = new Train[8];
            string departTrain;
            string destinationTrain;
            /// <summary>
            /// Fill the array Train.
            /// </summary>
            for (int i = 0; i < 8; i++)
            {
                Console.Write($"Enter Depart point [{i}] : ");
                departTrain = Console.ReadLine();
                Console.Write($"Enter Destination point [{i}] : ");
                destinationTrain = Console.ReadLine();
                trains[i] = new Train(departTrain, destinationTrain);
                Console.WriteLine("-------");
            }
            var sortedTrains = trains.OrderBy(t => t.id);
            int j = 0;
            foreach(Train train in sortedTrains)
            {
                trains[j] = train;
                j++;
            }
            ///<summary>
            ///Print trains list.
            ///</summary>
            Console.Clear();
            Console.WriteLine("Trains list : ");
            foreach(Train train2 in trains)
            {
                train2.PrintTrain();
            }
            Console.WriteLine();
            Console.Write("Enter ID to search : ");
            string idToSearch = Console.ReadLine();
            Train trainToSearch = findTrainById(trains, idToSearch);
            ///<summary>
            ///Find Train by user entered ID.
            /// </summary>
            if (trainToSearch.departPoint.Equals("null"))
            {
                Console.WriteLine("No Train with such ID exist.");
            }
            else
            {
                Console.WriteLine("-------");
                Console.WriteLine("Your train : ");
                findTrainById(trains, idToSearch).PrintTrain();
            }
        }
        public static Train findTrainById(Train[] trains, string id)
        {
            int i = 0;
            while(i < trains.Length)
            {
                if((trains[i].id).Equals(id.ToUpper()))
                {
                    return trains[i];
                }
                else
                {
                    i++;
                }
            }
            return new Train("null", "null");
        }
    }
}
