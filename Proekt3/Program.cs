using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 2. Данные пользователя: имя, город, возраст, PIN-код");
        Console.WriteLine("Введите данные по запросу программы");

        Console.Write("Введите имя: ");
        string name = Console.ReadLine();
        Console.Write("Введите город: ");
        string city = Console.ReadLine();
        Console.Write("Введите возраст: ");
        int age = int.Parse(Console.ReadLine());
        Console.Write("Введите PIN-код: ");
        string pin = Console.ReadLine();

        Console.WriteLine();
        Console.WriteLine("Имя: " + name);
        Console.WriteLine("Город: " + city);
        Console.WriteLine("Возраст: " + age);
        Console.WriteLine("PIN-код: " + pin);
    }
}
