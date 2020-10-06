using System;
using System.Collections.Generic;
using System.Text;

namespace TeachMeSkills.DotNet.Task17
{
    public class Store
    {
        private List<Article> articles;
        public Store()
        {
            articles = new List<Article>();
        }
        public void GetByIndex(int index)
        {
            Console.WriteLine("Product - {0}; Price - {1}; Shop - {2};",
                articles[index].Product, articles[index].Price, articles[index].Shop);
        }
        public void GetByName(string name)
        {
            bool gotIt = false;
            int index = 0;
            while (!gotIt && index <= articles.Capacity)
            {
                if (articles[index].Product.Equals(name))
                {
                    Console.WriteLine("Product - {0}; Price - {1}; Shop - {2};",
                        articles[index].Product, articles[index].Price, articles[index].Shop);
                    gotIt = true;
                }
                else
                {
                    index++;
                }
            }
            if (!gotIt)
            {
                Console.WriteLine("Error! Element not found.");
            }
        }
        public void AddProduct()
        {
            Article art = new Article();
            Console.Write("Enter Product name : ");
            art.Product = Console.ReadLine();
            Console.Write("Enter Price : ");
            art.Price = Decimal.Parse(Console.ReadLine());
            Console.Write("Enter Shop : ");
            art.Shop = Console.ReadLine();
            articles.Add(art);
        }
        public void PrintStore()
        {
            Console.WriteLine("-----");
            foreach (var item in this.articles)
            {
                Console.WriteLine(item.Product);
                Console.WriteLine(item.Price);
                Console.WriteLine(item.Shop);
            }
        }
    }
}
