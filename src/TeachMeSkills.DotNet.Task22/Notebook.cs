using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task22
{
    public struct Notebook
    {
        public string model;
        public string producer;
        public decimal price;

        public Notebook(string model, string producer, decimal price)
        {
            this.model = model;
            this.producer = producer;
            this.price = price;
        }

        public void PrintNotebook()
        {
            Console.WriteLine("Notebook parameters : ");
            Console.WriteLine($"Model - {model}, Producer - {producer}, Price - {price};");
        }
    }
}
