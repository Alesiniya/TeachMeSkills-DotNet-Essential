using System;

namespace TeachMeSkills.DotNet.Task22
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter parameters of Notebook : ");
            Console.Write("Enter Model : ");
            string model = Console.ReadLine();
            Console.Write("Enter producer : ");
            string producer = Console.ReadLine();
            Console.Write("Enter price : ");
            decimal price = Decimal.Parse(Console.ReadLine());
            ///<summary>
            /// Create new instances.
            /// </summary>
            Notebook notebook = new Notebook();
            Notebook notebook1 = new Notebook(model, producer, price);
            ///<summary>
            ///Print instances. Why does default constructor works ?
            /// </summary>
            notebook.PrintNotebook();
            notebook1.PrintNotebook();
        }
    }
}
