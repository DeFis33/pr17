//***************************************************************************************************
//* Практическая работа № 17                                                                        *
//* Выполнил: Пирогов Д., группа 2ИСП                                                               *
//* Задание: изучить алгоритмы создания классов и их экземпляров, способов их реализации в языке C# *
//***************************************************************************************************

using System;

class Building
{
    string name;
    int floors;
    string Name
    {
        get 
        { 
            return name; 
        }
        set 
        { 
            name = value; 
        }
    }
    int Floors
    {
        get 
        { 
            return floors; 
        }
        set
        {
            if (value >= 1)
                floors = value;
            else Console.WriteLine("Количество этажей должно быть больше 0.");
        }
    }
    public void EnterData()
    {
        Console.Write("Введите название здания: ");
        Name = Console.ReadLine();

        Console.Write("Введите количество этажей: ");
        try
        {
            int a = Convert.ToInt32(Console.ReadLine());
            Floors = a;
        }
        catch (FormatException fe)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nОшибка ввода \n" + fe.Message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
        catch (Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"\nОшибка ввода \n" + e.Message);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
    public void DisplayData()
    {
        Console.WriteLine($"Название здания: {Name}");
        Console.WriteLine($"Количество этажей: {Floors}");
    }
}
class Program
{
    static void Main()
    {
        Console.WriteLine("Практическая работа №9.\nЗдравствуйте!");
        
        Building House = new Building();
        House.EnterData();
        Console.WriteLine("\nИнформация о здании: ");
        House.DisplayData();
    }
}