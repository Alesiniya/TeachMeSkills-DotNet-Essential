using System;

namespace TeachMeSkills.DotNet.Task27
{
    class Program
    {
        delegate int GenerateRandom();
        delegate double GetAverage(GenerateRandom[] generateRans);
        static void Main(string[] args)
        {
            GenerateRandom[] arrOfDel = new GenerateRandom[10];
            GetAverage getAverage = delegate (GenerateRandom[] generateRans)
            {
                int sum = 0;
                for(int i = 0; i < generateRans.Length; i++)
                {
                    sum += generateRans[i].Invoke();
                }
                return (double)sum / (double)generateRans.Length;
            };
            GenerateRandom generator = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(100);
            };
            for (int j = 0; j < 10; j++)
            {
                arrOfDel[j] = generator;
            };
            Console.WriteLine($"Result - {getAverage(arrOfDel):f2}");
        }
    }
}
