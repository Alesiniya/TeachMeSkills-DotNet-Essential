using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task19
{
    public static class Calculator
    {
        public static int Add(int a, int b)
        {
            return a + b;
        }
        public static int Substract(int a, int b)
        {
            return a - b;
        }
        public static int Multiplay(int a, int b)
        {
            return a * b;
        }
        public static double Divide(int a, int b)
        {
            if (b != 0)
            {
                return (double)a / (double)b;
            }
            else
            {
                throw new DivideByZeroException("Error! Division by Zero.");
            }
        }
    }
}
