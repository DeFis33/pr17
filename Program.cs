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
        public void EnterData()
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
                    return;
                }
                Console.Write("Введите количество этажей: ");
                string count = Console.ReadLine();

                if (Int32.TryParse(count, out int floors) && String.IsNullOrEmpty(count) && floors <= 0)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("\nВы ввели пустую строку.");
                    Console.ForegroundColor = ConsoleColor.White;
                    return;
                }
                Floors = floors;
            }
            catch (FormatException fe)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nОшибка ввода \n" + fe.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"\nОшибка ввода \n" + e.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void Display()
        {
            Console.WriteLine($"Название здания: {Name}");
            Console.WriteLine($"Количество этажей: {Floors}");
        }
        public void Calculation()
        {
            int window = Floors * 10;
            Console.WriteLine($"Окон в вашем здании: {window}");
        }
    }
    static void Main()
    {
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("Практическая работа №17.\nЗдравствуйте!");

        Building house = new Building();
        house.EnterData();
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nИнформация о здании: ");
        house.Display();
        house.Calculation();
        Console.ForegroundColor = ConsoleColor.White;
        Console.ReadKey();
    }
}
