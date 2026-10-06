using System;

struct Drink
{
    public string Name;
    public int Percent;
}

struct Student
{
    public string Surname;
    public string Name;
    public int Id;
    public string BirthDate;
    public char Category;
    public Drink Drink;
    public int Volume;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 6. Студенты и напитки");

        Student[] students = new Student[5];

        students[0].Surname = "Иванов";
        students[0].Name = "Иван";
        students[0].Id = 1;
        students[0].BirthDate = "01.02.2006";
        students[0].Category = 'a';
        students[0].Drink.Name = "Пиво";
        students[0].Drink.Percent = 5;
        students[0].Volume = 5000;

        students[1].Surname = "Петров";
        students[1].Name = "Пётр";
        students[1].Id = 2;
        students[1].BirthDate = "15.05.2006";
        students[1].Category = 'b';
        students[1].Drink.Name = "Вино";
        students[1].Drink.Percent = 12;
        students[1].Volume = 3000;

        students[2].Surname = "Сидоров";
        students[2].Name = "Сидор";
        students[2].Id = 3;
        students[2].BirthDate = "20.08.2005";
        students[2].Category = 'c';
        students[2].Drink.Name = "Шампанское";
        students[2].Drink.Percent = 8;
        students[2].Volume = 2000;

        students[3].Surname = "Кузнецов";
        students[3].Name = "Кузьма";
        students[3].Id = 4;
        students[3].BirthDate = "03.11.2006";
        students[3].Category = 'd';
        students[3].Drink.Name = "Сок";
        students[3].Drink.Percent = 0;
        students[3].Volume = 4000;

        students[4].Surname = "Смирнов";
        students[4].Name = "Смир";
        students[4].Id = 5;
        students[4].BirthDate = "10.03.2006";
        students[4].Category = 'b';
        students[4].Drink.Name = "Водка";
        students[4].Drink.Percent = 40;
        students[4].Volume = 1000;

        int totalVolume = 0;
        double totalAlco = 0;

        for (int i = 0; i < 5; i++)
        {
            totalVolume = totalVolume + students[i].Volume;
            totalAlco = totalAlco + students[i].Volume * students[i].Drink.Percent / 100.0;
        }

        Console.WriteLine("Общий объем выпитой жидкости: " + totalVolume + " мл");
        Console.WriteLine("Общий объем алкоголя: " + totalAlco + " мл");
        Console.WriteLine();

        for (int i = 0; i < 5; i++)
        {
            double partLiquid = students[i].Volume * 100.0 / totalVolume;
            double alco = students[i].Volume * students[i].Drink.Percent / 100.0;
            double partAlco = alco * 100.0 / totalAlco;
            Console.WriteLine(students[i].Surname + ": жидкости " + partLiquid + "%, алкоголя " + partAlco + "%");
        }
    }
}
