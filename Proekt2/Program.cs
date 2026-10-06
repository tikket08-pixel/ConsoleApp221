using System;

enum AccountType
{
    Current,
    Savings
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Упражнение 3.1. Виды банковского счёта");

        AccountType account = AccountType.Savings;
        Console.WriteLine("Тип счёта: " + account);
    }
}
