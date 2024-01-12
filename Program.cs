using System;

class Program
{
    class Building
    {
        public string Name { get; set; }
        public int Floors { get; set; }
        public int Window { get; set; }
        public int Height { get; set; }
        void Input()
        {
            try
            {
                Console.Write("Введите название здания: ");
                Name = Console.ReadLine();
                if (String.IsNullOrEmpty(Name))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода. Название здания не может быть пустым.");
                    Console.ForegroundColor = ConsoleColor.White;
                    Environment.Exit(1);
                }
                Console.Write("Введите количество этажей: ");
                if (Int32.TryParse(Console.ReadLine(), out int floors) && floors > 0) Floors = floors;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода. Количество этажей должно быть целым и больше нуля.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                Console.Write("Введите высоту одного этажа (в метрах): ");
                if (Int32.TryParse(Console.ReadLine(), out int height) && height > 0) Height = height;
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Ошибка ввода. Высота должна быть числом больше нуля.");
                    Console.ForegroundColor = ConsoleColor.White;
                }
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
        void GetInfo()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nИнформация о здании: ");
            Console.WriteLine($"Название здания: {Name}");
            Console.WriteLine($"Количество этажей: {Floors}");
            Console.WriteLine($"Высота одного этажа: {Height}");
            Console.WriteLine($"Окон в вашем здании: {Window}");
            Console.ForegroundColor = ConsoleColor.White;
        }
        int Calculate()
        {
            double coefficient = 0.75; // коэффициент для учета окон на этаже
            int count = Convert.ToInt32(Floors * Height * coefficient);
            return count;
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
