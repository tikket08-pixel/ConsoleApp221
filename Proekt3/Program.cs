using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Задача 1. Типы данных: максимальное и минимальное значение");

        Console.WriteLine("sbyte - " + sbyte.MaxValue + " - " + sbyte.MinValue);
        Console.WriteLine("byte - " + byte.MaxValue + " - " + byte.MinValue);
        Console.WriteLine("short - " + short.MaxValue + " - " + short.MinValue);
        Console.WriteLine("ushort - " + ushort.MaxValue + " - " + ushort.MinValue);
        Console.WriteLine("int - " + int.MaxValue + " - " + int.MinValue);
        Console.WriteLine("uint - " + uint.MaxValue + " - " + uint.MinValue);
        Console.WriteLine("long - " + long.MaxValue + " - " + long.MinValue);
        Console.WriteLine("ulong - " + ulong.MaxValue + " - " + ulong.MinValue);
        Console.WriteLine("float - " + float.MaxValue + " - " + float.MinValue);
        Console.WriteLine("double - " + double.MaxValue + " - " + double.MinValue);
        Console.WriteLine("decimal - " + decimal.MaxValue + " - " + decimal.MinValue);
        Console.WriteLine("char - " + (int)char.MaxValue + " - " + (int)char.MinValue);
    }
}
