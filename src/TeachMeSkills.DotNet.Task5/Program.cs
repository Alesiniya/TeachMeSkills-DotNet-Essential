using System;

namespace TeachMeSkills.DotNet.Task5
{
    class Converter
    {
        public Converter(decimal _usd, decimal _eur, decimal _rub)
        {
            Usd = _usd;
            Eur = _eur;
            Rub = _rub;
        }

        public decimal Usd { get; }
        public decimal Eur { get; }
        public decimal Rub { get; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Converter converter = new Converter(0.39M, 0.33M, 29.43M);
            decimal valueMoney = 0.0M;
            int cash = 0;
            bool isChosen = false;
            while (!isChosen)
            {
                Console.Write("Enter CASH [1- USD, 2 - EUR, 3 - RUB, 0 - BYN] to convert : ");
                isChosen = Int32.TryParse(Console.ReadLine(), out cash);
                if(cash > 3 || cash < 0)
                {
                    isChosen = false;
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Error! Wrong choise.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
            }
            bool isParsed = false;
            while (!isParsed)
            {
                switch (cash)
                {
                    case 0:
                        Console.Write("Enter sum, BYN : ");
                        isParsed = Decimal.TryParse(Console.ReadLine(), out valueMoney);
                        if (isParsed)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Convertion {0:00.00} BYN -> : {1:00.00} USD, {2:00.00} EUR, {3:00.00} RUB",
                                valueMoney, Math.Round(valueMoney * converter.Usd, 2), Math.Round(valueMoney * converter.Eur, 2), Math.Round(valueMoney * converter.Rub, 2));
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error! Wrong value.");
                            Console.ForegroundColor = ConsoleColor.White;
                            isParsed = false;
                        }
                        break;
                    case 1:
                        Console.Write("Enter sum, USD : ");
                        isParsed = Decimal.TryParse(Console.ReadLine(), out valueMoney);
                        if (isParsed)
                        {
                            Console.WriteLine("Conversion {0:00.00} USD -> BYN {1:00.00}", valueMoney, Math.Round(valueMoney / converter.Usd, 2));
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error! Wrong value.");
                            Console.ForegroundColor = ConsoleColor.White;
                            isParsed = false;
                        }
                        break;
                    case 2:
                        Console.Write("Enter sum, EUR : ");
                        isParsed = Decimal.TryParse(Console.ReadLine(), out valueMoney);
                        if (isParsed)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Conversion {0:00.00} EUR -> BYN {1:00.00}", valueMoney, Math.Round(valueMoney / converter.Eur, 2));
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error! Wrong value.");
                            Console.ForegroundColor = ConsoleColor.White;
                            isParsed = false;
                        }
                        break;
                    case 3:
                        Console.Write("Enter sum, RUB : ");
                        isParsed = Decimal.TryParse(Console.ReadLine(), out valueMoney);
                        if (isParsed)
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.WriteLine("Conversion {0:00.00} RUB -> BYN {1:00.00}", valueMoney, Math.Round(valueMoney / converter.Rub,2 ));
                            Console.ForegroundColor = ConsoleColor.White;
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Error! Wrong value.");
                            Console.ForegroundColor = ConsoleColor.White;
                            isParsed = false;
                        }
                        Console.WriteLine("Conversion {0:00.00} RUB -> BYN {1:00.00}", valueMoney, Math.Round(valueMoney / converter.Rub, 2));
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Error! Wrong cash entered.");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
            }
        }
    }
}
