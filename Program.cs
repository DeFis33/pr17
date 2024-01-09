//***************************************************************************************************
//* Практическая работа № 17                                                                        *
//* Выполнил: Пирогов Д., группа 2ИСП                                                               *
//* Задание: изучить алгоритмы создания классов и их экземпляров, способов их реализации в языке C# *
//***************************************************************************************************

using System;

class Program
{
    class Building
    {
        string name;
        int floors;
        string Name
        {
            get { return name; }
            set { name = value; }
        }
        int Floors
        {
            get { return floors; }
            set { floors = value; }
        }
        public bool EnterData()
        {
            try
            {
                Console.Write("Введите название здания: ");
                Name = Console.ReadLine();

                if (String.IsNullOrEmpty(Name))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nВы ввели пустую строку.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }

                Console.Write("Введите количество этажей: ");
                string count = Console.ReadLine();

                if (!Int32.TryParse(count, out int floors) || floors <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nОшибка ввода: введите положительное число этажей.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return false;
                }
                Floors = floors;
                return true;
            }
            catch (FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nОшибка ввода \n" + fe.Message);
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nОшибка ввода \n" + e.Message);
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }
        }
        public void Display()
        {
            Console.WriteLine($"Название здания: {Name}");
            Console.WriteLine($"Количество этажей: {Floors}");
        }
        public void Calculation()
        {
            int Window = Floors * 10;
            Console.WriteLine($"Окон в вашем здании: {Window}");
        }
    }
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Практическая работа №17.\nЗдравствуйте!");

        Building house = new Building();
        if (house.EnterData())
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nИнформация о здании: ");
            house.Display();
            house.Calculation();
            Console.ForegroundColor = ConsoleColor.White;
        }
        Console.ReadKey();
    }
}
