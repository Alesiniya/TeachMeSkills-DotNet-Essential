using System;

namespace TeachMeSkills.DotNet.Task17
{
    class Program
    {
        static void Main(string[] args)
        {
            Store store = new Store();
            store.AddProduct();
            store.AddProduct();
            store.AddProduct();
            store.AddProduct();
            Console.Clear();
            store.PrintStore();
            Console.Write("Enter name to search : ");
            store.GetByName(Console.ReadLine());
        }
    }
}
