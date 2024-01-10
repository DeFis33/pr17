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
        void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nИнформация о здании: ");
            Console.WriteLine($"Название здания: {Name}");
            Console.WriteLine($"Количество этажей: {Floors}");
            Console.WriteLine($"Окон в вашем здании: {Window}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        public Building(string name_user, int floors_user, int window_user)
        {
            Name = name_user;
            Floors = floors_user;
            Window = window_user;
            GetInfo();
        }
    }
    public static void Main(string[] args)
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Практическая работа №17.\nЗдравствуйте!");
        Console.Write("Введите название здания: ");
        string Name = Console.ReadLine();
        Console.Write("Введите количество этажей: ");
        int Floors = Int32.Parse(Console.ReadLine());

        Building obj1 = new Building(Name, Floors, Window);

        Console.ReadKey();
    }
}
D:\Users\1213-5\Documents\2-ИСП\Дисциплина\Основы программирования\Фамилия\Пирогов Д\pr16\pr16.txt
