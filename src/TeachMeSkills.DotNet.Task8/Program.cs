using System;

namespace TeachMeSkills.DotNet.Task8
{
    class User
    {
        private string login;
        private string userName;
        private string userSurname;
        private int age;
        private DateTime dateToFill;
        public DateTime DateToFill
        {
            get
            {
                return DateTime.Now;
            }
        }
        public string Login
        {
            set
            {
                this.login = value;
            }
            get
            {
                return this.login;
            }
        }
        public int Age
        {
            set
            {
                this.age = value;
            }
            get
            {
                return this.age;
            }
                
        }
        public string UserName
        {
            set
            {
                this.userName = value;
            }
            get
            {
                return this.userName;
            }
        }
        public string UserSurName
        {
            set
            {
                this.userSurname = value;
            }
            get
            {
                return this.userSurname;
            }
        }

        public User()
        {
            dateToFill = DateTime.Now;
            Console.Write("Enter User Name : ");
            userName = Console.ReadLine();
            Console.Write("Enter User Surname : ");
            userSurname = Console.ReadLine();
            Console.Write("Enter Age : ");
            age = Int32.Parse(Console.ReadLine());
            Console.Write("Enter Login : ");
            login = Console.ReadLine();
        }
        public void PrintUserData()
        {
            Console.Write("User Name : ");
            Console.WriteLine(UserName);
            Console.Write("User Surname : ");
            Console.WriteLine(UserSurName);
            Console.Write("User Age : ");
            Console.WriteLine(Age);
            Console.Write("User Login : ");
            Console.WriteLine(Login);
            Console.WriteLine("Date of creation : {0} -> User {1}", DateToFill, UserName);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            User user = new User();
            Console.Clear();
            Console.WriteLine("----------USER DATA----------");
            user.PrintUserData();
        }
    }
}
