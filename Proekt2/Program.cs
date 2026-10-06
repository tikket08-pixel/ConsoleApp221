using System;

enum AccountType
{
    Current,
    Savings
}

struct BankAccount
{
    public string Number;
    public AccountType Type;
    public decimal Balance;
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Упражнение 3.2. Структура банковского счёта");

        BankAccount account;
        account.Number = "40817810099910004312";
        account.Type = AccountType.Savings;
        account.Balance = 150000.50m;

        Console.WriteLine("Номер: " + account.Number);
        Console.WriteLine("Тип: " + account.Type);
        Console.WriteLine("Баланс: " + account.Balance + " руб.");
    }
}
