using System;

namespace TeachMeSkills.DotNet.Task2
{
    class Book
    {
        public string bookName { get; set; }
        public Title title;
        public Author author;
        public Content content;
    }

    class Author
    {
        private string author = String.Empty;
        public string authorName
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }
        public Author()
        {
            authorName = "DefaultAuthor";
        }
        public Author(string authorName)
        {
            this.authorName = authorName;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Author : {0}", authorName);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Title
    {
        public string titleName { get; set; }
        public Title(string titleName)
        {
            this.titleName = titleName;
        }
        public Title()
        {
            this.titleName = "DefaultTitle";
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Title : {0}", titleName);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Content
    {
        public string content { get; set; }
        public Content(string contentName)
        {
            this.content = contentName;
        }
        public Content()
        {
            this.content = "DefaultContent";
        }
        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Content : {0}", content);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();

            Console.Write("Enter BOOK name : ");
            book1.bookName = Console.ReadLine();
            Console.Write("Enter Author : ");
            Author author = new Author(Console.ReadLine());
            book1.author = author;
            Console.Write("Enter Title : ");
            Title title = new Title(Console.ReadLine());
            book1.title = title;
            Console.Write("Enter Content: ");
            Content content = new Content(Console.ReadLine());
            book1.content = content;
            book1.author.Show();
            book1.title.Show();
            book1.content.Show();
        }
    }
}
