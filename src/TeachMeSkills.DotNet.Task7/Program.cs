using System;

namespace TeachMeSkills.DotNet.Task7
{
    class Invoice
    {
        private int account;
        private string customer;
        private string provider;
        private string article;
        private int quantity;

        public Invoice(int account, string customer, string provider)
        {
            this.account = account;
            this.customer = customer;
            this.provider = provider;
        }
        public Invoice()
        {
            this.account = 0;
            this.customer = String.Empty;
            this.provider = String.Empty;
        }

        public int Account
        {
            get
            {
                return this.account;
            }
        }
        public string Customer
        {
            get
            {
                return this.customer;
            }
        }
        public string Provider
        {
            get
            {
                return this.provider;
            }
        }
        public string Article
        {
            set
            {
                this.article = value;
            }
            get
            {
                return this.article;
            }
        }
        public int Quantity
        {
            set
            {
                this.quantity = value;
            }
            get
            {
                return this.quantity;
            }
        }

        public double Order(double price)
        {
            return (double)(this.quantity * price);
        }
        public double OrderWOVAT(double price)
        {
            return (double)(price * this.quantity * 1.20);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter CUSTOMER : ");
            string strCust = Console.ReadLine();
            Console.Write("Enter ACCOUNT : ");
            int acct = Int32.Parse(Console.ReadLine());
            Console.Write("Enter PROVIDER : ");
            string prov = Console.ReadLine();
            Invoice invoice = new Invoice(acct, strCust, prov);
            Console.WriteLine("-----------------------------------");
            Console.Write("Enter ARTICLE : ");
            invoice.Article = Console.ReadLine();
            Console.Write("Enter quantity : ");
            invoice.Quantity = Int32.Parse(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("----------ORDER DETAILES----------");
            Console.WriteLine("ACCOUNT --> {0}", invoice.Account);
            Console.WriteLine("CUSTOMER --> {0}", invoice.Customer);
            Console.WriteLine("PROVIDER --> {0}", invoice.Provider);
            Console.WriteLine("Product ART. --> {0}", invoice.Article);
            Console.WriteLine("Quantity --> {0}", invoice.Quantity);
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("SUM (w/o VAT) : {0:00.00}", invoice.Order(5.5));
            Console.WriteLine("SUM : {0:00.00}", invoice.OrderWOVAT(5.5));
        }
    }
}
