using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 5. Сколько бутылок купить в Duty Free");
        Console.WriteLine("Введите обычную цену, скидку в процентах и стоимость отпуска");

        Console.Write("Обычная цена (normPrice): ");
        int normPrice = int.Parse(Console.ReadLine());
        Console.Write("Скидка в Duty Free в процентах (salePrice): ");
        int salePrice = int.Parse(Console.ReadLine());
        Console.Write("Стоимость отпуска (holidayPrice): ");
        int holidayPrice = int.Parse(Console.ReadLine());

        int economiya = normPrice * salePrice / 100;
        int butylki = holidayPrice / economiya;

        Console.WriteLine("Нужно бутылок: " + butylki);
    }
}
