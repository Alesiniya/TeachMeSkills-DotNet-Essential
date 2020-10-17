using System;

namespace TeachMeSkills.DotNet.Task28
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<int, int, int, double> getAverageValue = delegate (int val1, int val2, int val3)
            {
                return (double)(val1 + val2 + val3) / 3.0;
            };
            Console.WriteLine($"{getAverageValue.Invoke(2, 2, 3):f2}");
        }
    }
}
