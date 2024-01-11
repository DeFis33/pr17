//***************************************************************************************************
//* Практическая работа № 17                                                                        *
//* Выполнил: Пирогов Д., группа 2ИСП                                                               *
//* Задание: изучить алгоритмы создания классов и их экземпляров, способов их реализации в языке C# *
//***************************************************************************************************

using System;
using System.Xml.Linq;

class Program
{
    class Building
    {
        public string Name { get; set; }
        public int Floors { get; set; }
        public int Window { get; set; }
        void Input()
        {
            Console.Write("Введите название здания: ");
            Name = Console.ReadLine();
            Console.Write("Введите количество этажей: ");
            Floors = Int32.Parse(Console.ReadLine());
        }
        void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nИнформация о здании: ");
            Console.WriteLine($"Название здания: {Name}");
            Console.WriteLine($"Количество этажей: {Floors}");
            Console.WriteLine($"Окон в вашем здании: {Window}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        int Calculate()
        {
            return Floors * 10;
        }
        public Building()
        {
            Input();
            Window = Calculate();
            GetInfo();
        }
    }
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Практическая работа №17.\nЗдравствуйте!");

        Building obj1 = new Building();

        Console.ReadKey();
    }
}
