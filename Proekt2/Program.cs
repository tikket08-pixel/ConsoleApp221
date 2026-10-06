using System;

enum VUZ
{
    КГУ,
    КАИ,
    КХТИ
}

struct Worker
{
    public string Name;
    public VUZ Vuz;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Домашнее задание 3.1. Работник и ВУЗ");

        Worker worker;
        worker.Name = "Иванов Иван Иванович";
        worker.Vuz = VUZ.КАИ;

        Console.WriteLine("Имя: " + worker.Name);
        Console.WriteLine("ВУЗ: " + worker.Vuz);
    }
}
