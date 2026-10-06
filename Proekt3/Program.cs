using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 3. Замена строчных букв на заглавные и наоборот");
        Console.WriteLine("Введите строку");

        Console.Write("Строка: ");
        string s = Console.ReadLine();

        string result = "";
        foreach (char ch in s)
        {
            if (char.IsLower(ch))
            {
                result = result + char.ToUpper(ch);
            }
            else
            {
                result = result + char.ToLower(ch);
            }
        }

        Console.WriteLine("Результат: " + result);
    }
}
