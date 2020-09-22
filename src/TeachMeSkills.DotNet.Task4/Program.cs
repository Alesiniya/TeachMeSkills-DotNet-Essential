using System;

namespace TeachMeSkills.DotNet.Task4
{
    class Address
    {
        private string index;
        private string country;
        private string city;
        private string street;
        private string house;
        private string apartment;

        public string Index
        {
            set
            {
                this.index = value;
            }
            get
            {
                return this.index;
            }
        }
        public string Country
        {
            set
            {
                this.country = value;
            }
            get
            {
                return this.country;
            }
        }
        public string City
        {
            set
            {
                this.city = value;
            }
            get
            {
                return this.city;
            }
               
        }
        public string Street
        {
            set
            {
                this.street = value;
            }
            get
            {
                return this.street;
            }
        }
        public string House
        {
            set
            {
                this.house = value;
            }
            get
            {
                return this.house;
            }
                
        }
        public string Apartment
        {
            set
            {
                this.apartment = value;
            }
            get
            {
                return this.apartment;
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Address address = new Address();
            Console.Write("Enter index : ");
            address.Index = Console.ReadLine();
            Console.Write("Enter country : ");
            address.Country = Console.ReadLine();
            Console.Write("Enter city : ");
            address.City = Console.ReadLine();
            Console.Write("Enter street : ");
            address.Street = Console.ReadLine();
            Console.Write("Enter house : ");
            address.House = Console.ReadLine();
            Console.Write("Enter apartment : ");
            address.Apartment = Console.ReadLine();
            // Print Address
            Console.WriteLine("Address : {0}, {1}, {2}, {3}, {4}, {5};",
                address.Index, address.Country, address.City, address.Street, address.House, address.Apartment);
        }
    }
}
