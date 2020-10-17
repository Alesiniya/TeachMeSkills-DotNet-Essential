using System;

namespace TeachMeSkills.DotNet.Task26
{
    public class Program
    {
        delegate double Operation(double oper1, double oper2);
        //Func<double, double, double> Operation;
        static void Main(string[] args)
        {
            Operation operation;
            Console.Write("Enter equation : ");
            string equation = Console.ReadLine();
            string[] eqElements = equation.Split(new char[] { '+', '-', '*', '/'});
            if (equation.IndexOf('+') != -1)
            {
                operation = (oper1, oper2) => oper1 + oper2;
            }
            else if (equation.IndexOf('-') != -1)
            {
                operation = (oper1, oper2) => oper1 - oper2;
            }
            else if (equation.IndexOf('*') != -1)
            {
                operation = (oper1, oper2) => oper1 * oper2;
            }
            else if (equation.IndexOf('/') != -1)
            {
                if (!eqElements[1].Equals('0'))
                {
                    operation = (oper1, oper2) => oper1 / oper2;
                }
                else
                {
                    throw new DivideByZeroException("Error! Divide by zero.");
                    //Console.WriteLine("Error! Divide by zero.");
                }
            }
            else
            {
                operation = null;
                Console.WriteLine("Error! Operation mistaken.");
            }
            if (operation != null)
            {
                double result = operation.Invoke(Double.Parse(eqElements[0]), Double.Parse(eqElements[1]));
                if (result % 1 != 0)
                {
                    Console.WriteLine($"{equation} = {result:f3}");
                }
                else
                {
                    Console.WriteLine($"{equation} = {result}");
                }
            }
            else
            {
                Console.WriteLine("Can not determine operation.");
            }
        }
    }
}
