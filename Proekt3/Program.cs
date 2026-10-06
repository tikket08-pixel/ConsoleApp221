using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 4. Количество вхождений подстроки в строку");
        Console.WriteLine("Введите строку и подстроку");

        Console.Write("Строка: ");
        string s = Console.ReadLine();
        Console.Write("Подстрока: ");
        string sub = Console.ReadLine();

        int count = 0;
        int pos = s.IndexOf(sub);
        while (pos != -1)
        {
            count++;
            pos = s.IndexOf(sub, pos + 1);
        }

        Console.WriteLine("Вхождений: " + count);
    }
}
